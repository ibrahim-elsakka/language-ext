﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    /// <summary>
    /// Named process already exists
    /// </summary>
    [Serializable]
    public class NamedProcessAlreadyExistsException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException()
            :
            base("Named process already exists")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected NamedProcessAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /// <summary>
    /// Invalid process name
    /// </summary>
    [Serializable]
    public class InvalidProcessNameException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException()
            :
            base("Invalid process name")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected InvalidProcessNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /// <summary>
    /// Invalid process ID
    /// </summary>
    [Serializable]
    public class InvalidProcessIdException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException()
            :
            base("Invalid process ID")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected InvalidProcessIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /// <summary>
    /// NoChildProcessesException
    /// </summary>
    [Serializable]
    public class NoChildProcessesException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException()
            :
            base("No child processes")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected NoChildProcessesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }


    /// <summary>
    /// A process threw an exception in its message loop
    /// </summary>
    [Serializable]
    public class ProcessException : Exception
    {
        /// <summary>
        /// Process that threw the exception
        /// </summary>
        public string Self;

        /// <summary>
        /// Process that sent the message
        /// </summary>
        public string Sender;

        /// <summary>
        /// Ctor
        /// </summary>
        [JsonConstructor]
        public ProcessException(string message, string self, string sender, Exception innerException)
            :
            base(message, innerException)
        {
            Self = self;
            Sender = sender;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected ProcessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /// <summary>
    /// Kill process
    /// </summary>
    [Serializable]
    public class SystemKillActorException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public SystemKillActorException()
            :
            base("SYS:Poison pill")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public SystemKillActorException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public SystemKillActorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        protected SystemKillActorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
