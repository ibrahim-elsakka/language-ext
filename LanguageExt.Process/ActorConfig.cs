﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization.Formatters;

namespace LanguageExt
{
    internal class ActorConfig
    {
        public readonly ProcessName RootProcessName           = "root";
        public readonly ProcessName SystemProcessName         = "system";
        public readonly ProcessName UserProcessName           = "user";
        public readonly ProcessName DeadLettersProcessName    = "dead-letters";
        public readonly ProcessName RegisteredProcessName     = "registered";
        public readonly ProcessName ErrorsProcessName         = "errors";
        public readonly ProcessName AskProcessName            = "ask";
        public readonly ProcessName ReplyProcessName          = "reply";
        public readonly ProcessName InboxShutdownProcessName  = "inbox-shutdown";
        public readonly TimeSpan    Timeout                   = TimeSpan.FromSeconds(30);

        public readonly JsonSerializerSettings JsonSerializerSettings =
            new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Full
            };

        public readonly static ActorConfig Default =
            new ActorConfig();
    }
}
