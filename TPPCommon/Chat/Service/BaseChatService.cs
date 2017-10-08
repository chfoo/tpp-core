using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using TPPCommon.Chat;
using TPPCommon.Configuration;
using TPPCommon.Logging;
using TPPCommon.PubSub;
using TPPCommon.PubSub.Events;

namespace TPPCommon.Chat.Service {
    /// <summary>
    /// Chat service for handling, sending, and dispatching messages to PubSub
    /// and the chat client.
    /// </summary>
    public abstract class BaseChatService : TPPService {
        protected TPPLoggerBase Logger;
        protected ExponentialBackoffCounter backoff;
        protected Client.IChatClient ChatClient;
        protected Client.ConnectionConfig ConnectionConfig;
        protected abstract string ServiceName { get; }

        protected override string[] ConfigNames
        {
            get => new string[] { $"config_{ServiceName}" };
        }
        protected override int StartupDelayMilliseconds
        {
            get => 0;
        }

        public BaseChatService(
                IPublisher publisher,
                ISubscriber subscriber,
                ITPPLoggerFactory loggerFactory,
                IConfigReader configReader) :
                base (publisher, subscriber, loggerFactory, configReader)
        {
            backoff = new ExponentialBackoffCounter();
        }

        override protected void Initialize()
        {
            Logger = LoggerFactory.Create($"chat.{ServiceName}");
        }

        override protected void Run()
        {
            while (true) {
                Logger.LogInfo("Chat service connecting");

                try {
                    ChatClient.ConnectAsync(ConnectionConfig).Wait();
                } catch (SocketException error) {
                    Logger.LogError("Error connecting to chat", error);

                    backoff.Increment();
                    backoff.Sleep();
                }

                Logger.LogInfo("Chat service connected");
                backoff.Reset();

                ProcessMessagesAsync().Wait();

                Logger.LogInfo("Chat service disconnected");
                backoff.Increment();
                backoff.Sleep();
            }
        }

        protected async Task ProcessMessagesAsync()
        {
            Logger.LogDebug("Processing messages");

            var sendTask = SendMessagesAsync();
            var receiveTask = ReceiveMessagesAsync();
            Task[] tasks = {sendTask, receiveTask};
            await Task.WhenAny(tasks);

            ChatClient.Disconnect();

            Logger.LogDebug("Stopped processing messages");
        }

        protected async Task SendMessagesAsync()
        {
            Logger.LogDebug("Processing sending messages");

            while (ChatClient.IsConnected()) {
                // TODO: read messages from a queue
                await Task.Delay(1000);
            }

            Logger.LogDebug("Stopped sending messages");
        }

        protected async Task ReceiveMessagesAsync()
        {
            Logger.LogDebug("Processing receiving messages");

            while (ChatClient.IsConnected()) {
                var message = await ChatClient.ReceiveMessageAsync();
                ChatMessageEvent chatEvent =
                    new ChatMessageEvent(ServiceName, message);

                Publisher.Publish(chatEvent);
            }

            Logger.LogDebug("Stopped receiving messages");
        }
    }
}
