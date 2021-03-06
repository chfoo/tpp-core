namespace TPPCore.Irc
{
    public static class NumericalReplyCodes
    {
        public const int RPL_WELCOME = 1;
        public const int RPL_YOURHOST = 2;
        public const int RPL_CREATED = 3;
        public const int RPL_MYINFO = 4;
        public const int RPL_BOUNCE = 5;
        public const int RPL_TRACELINK = 200;
        public const int RPL_TRACECONNECTING = 201;
        public const int RPL_TRACEHANDSHAKE = 202;
        public const int RPL_TRACEUNKNOWN = 203;
        public const int RPL_TRACEOPERATOR = 204;
        public const int RPL_TRACEUSER = 205;
        public const int RPL_TRACESERVER = 206;
        public const int RPL_TRACESERVICE = 207;
        public const int RPL_TRACENEWTYPE = 208;
        public const int RPL_TRACECLASS = 209;
        public const int RPL_TRACERECONNECT = 210;
        public const int RPL_STATSLINKINFO = 211;
        public const int RPL_STATSCOMMANDS = 212;
        public const int RPL_STATSCLINE = 213;
        public const int RPL_STATSNLINE = 214;
        public const int RPL_STATSILINE = 215;
        public const int RPL_STATSKLINE = 216;
        public const int RPL_STATSQLINE = 217;
        public const int RPL_STATSYLINE = 218;
        public const int RPL_ENDOFSTATS = 219;
        public const int RPL_UMODEIS = 221;
        public const int RPL_SERVICEINFO = 231;
        public const int RPL_ENDOFSERVICES = 232;
        public const int RPL_SERVICE = 233;
        public const int RPL_SERVLIST = 234;
        public const int RPL_SERVLISTEND = 235;
        public const int RPL_STATSVLINE = 240;
        public const int RPL_STATSLLINE = 241;
        public const int RPL_STATSUPTIME = 242;
        public const int RPL_STATSOLINE = 243;
        public const int RPL_STATSHLINE = 244;
        public const int RPL_STATSSLINE = 244;
        public const int RPL_STATSPING = 246;
        public const int RPL_STATSBLINE = 247;
        public const int RPL_STATSDLINE = 250;
        public const int RPL_LUSERCLIENT = 251;
        public const int RPL_LUSEROP = 252;
        public const int RPL_LUSERUNKNOWN = 253;
        public const int RPL_LUSERCHANNELS = 254;
        public const int RPL_LUSERME = 255;
        public const int RPL_ADMINME = 256;
        public const int RPL_ADMINLOC1 = 257;
        public const int RPL_ADMINLOC2 = 258;
        public const int RPL_ADMINEMAIL = 259;
        public const int RPL_TRACELOG = 261;
        public const int RPL_TRACEEND = 262;
        public const int RPL_TRYAGAIN = 263;
        public const int RPL_NONE = 300;
        public const int RPL_AWAY = 301;
        public const int RPL_USERHOST = 302;
        public const int RPL_ISON = 303;
        public const int RPL_UNAWAY = 305;
        public const int RPL_NOWAWAY = 306;
        public const int RPL_WHOISUSER = 311;
        public const int RPL_WHOISSERVER = 312;
        public const int RPL_WHOISOPERATOR = 313;
        public const int RPL_WHOWASUSER = 314;
        public const int RPL_ENDOFWHO = 315;
        public const int RPL_WHOISCHANOP = 316;
        public const int RPL_WHOISIDLE = 317;
        public const int RPL_ENDOFWHOIS = 318;
        public const int RPL_WHOISCHANNELS = 319;
        public const int RPL_LISTSTART = 321;
        public const int RPL_LIST = 322;
        public const int RPL_LISTEND = 323;
        public const int RPL_CHANNELMODEIS = 324;
        public const int RPL_UNIQOPIS = 325;
        public const int RPL_NOTOPIC = 331;
        public const int RPL_TOPIC = 332;
        public const int RPL_INVITING = 341;
        public const int RPL_SUMMONING = 342;
        public const int RPL_INVITELIST = 346;
        public const int RPL_ENDOFINVITELIST = 347;
        public const int RPL_EXCEPTLIST = 348;
        public const int RPL_ENDOFEXCEPTLIST = 349;
        public const int RPL_VERSION = 351;
        public const int RPL_WHOREPLY = 352;
        public const int RPL_NAMREPLY = 353;
        public const int RPL_KILLDONE = 361;
        public const int RPL_CLOSING = 362;
        public const int RPL_CLOSEEND = 363;
        public const int RPL_LINKS = 364;
        public const int RPL_ENDOFLINKS = 365;
        public const int RPL_ENDOFNAMES = 366;
        public const int RPL_BANLIST = 367;
        public const int RPL_ENDOFBANLIST = 368;
        public const int RPL_ENDOFWHOWAS = 369;
        public const int RPL_INFO = 371;
        public const int RPL_MOTD = 372;
        public const int RPL_INFOSTART = 373;
        public const int RPL_ENDOFINFO = 374;
        public const int RPL_MOTDSTART = 375;
        public const int RPL_ENDOFMOTD = 376;
        public const int RPL_YOUREOPER = 381;
        public const int RPL_REHASHING = 382;
        public const int RPL_YOURESERVICE = 383;
        public const int RPL_MYPORTIS = 384;
        public const int RPL_TIME = 391;
        public const int RPL_USERSSTART = 392;
        public const int RPL_USERS = 393;
        public const int RPL_ENDOFUSERS = 394;
        public const int RPL_NOUSERS = 395;
        public const int ERR_NOSUCHNICK = 401;
        public const int ERR_NOSUCHSERVER = 402;
        public const int ERR_NOSUCHCHANNEL = 403;
        public const int ERR_CANNOTSENDTOCHAN = 404;
        public const int ERR_TOOMANYCHANNELS = 405;
        public const int ERR_WASNOSUCHNICK = 406;
        public const int ERR_TOOMANYTARGETS = 407;
        public const int ERR_NOSUCHSERVICE = 408;
        public const int ERR_NOORIGIN = 409;
        public const int ERR_NORECIPIENT = 411;
        public const int ERR_NOTEXTTOSEND = 412;
        public const int ERR_NOTOPLEVEL = 413;
        public const int ERR_WILDTOPLEVEL = 414;
        public const int ERR_BADMASK = 415;
        public const int ERR_UNKNOWNCOMMAND = 421;
        public const int ERR_NOMOTD = 422;
        public const int ERR_NOADMININFO = 423;
        public const int ERR_FILEERROR = 424;
        public const int ERR_NONICKNAMEGIVEN = 431;
        public const int ERR_ERRONEUSNICKNAME = 432;
        public const int ERR_NICKNAMEINUSE = 433;
        public const int ERR_NICKCOLLISION = 436;
        public const int ERR_UNAVAILRESOURCE = 437;
        public const int ERR_USERNOTINCHANNEL = 441;
        public const int ERR_NOTONCHANNEL = 442;
        public const int ERR_USERONCHANNEL = 443;
        public const int ERR_NOLOGIN = 444;
        public const int ERR_SUMMONDISABLED = 445;
        public const int ERR_USERSDISABLED = 446;
        public const int ERR_NOTREGISTERED = 451;
        public const int ERR_NEEDMOREPARAMS = 461;
        public const int ERR_ALREADYREGISTRED = 462;
        public const int ERR_NOPERMFORHOST = 463;
        public const int ERR_PASSWDMISMATCH = 464;
        public const int ERR_YOUREBANNEDCREEP = 465;
        public const int ERR_YOUWILLBEBANNED = 466;
        public const int ERR_KEYSET = 467;
        public const int ERR_CHANNELISFULL = 471;
        public const int ERR_UNKNOWNMODE = 472;
        public const int ERR_INVITEONLYCHAN = 473;
        public const int ERR_BANNEDFROMCHAN = 474;
        public const int ERR_BADCHANNELKEY = 475;
        public const int ERR_BADCHANMASK = 476;
        public const int ERR_NOCHANMODES = 477;
        public const int ERR_BANLISTFULL = 478;
        public const int ERR_NOPRIVILEGES = 481;
        public const int ERR_CHANOPRIVSNEEDED = 482;
        public const int ERR_CANTKILLSERVER = 483;
        public const int ERR_RESTRICTED = 484;
        public const int ERR_UNIQOPPRIVSNEEDED = 485;
        public const int ERR_NOOPERHOST = 491;
        public const int ERR_NOSERVICEHOST = 492;
        public const int ERR_UMODEUNKNOWNFLAG = 501;
        public const int ERR_USERSDONTMATCH = 502;
    }
}
