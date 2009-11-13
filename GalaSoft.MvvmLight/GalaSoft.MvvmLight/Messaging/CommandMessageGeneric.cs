﻿// ****************************************************************************
// <copyright file="CommandMessageGeneric.cs" company="GalaSoft Laurent Bugnion">
// Copyright © GalaSoft Laurent Bugnion 2009
// </copyright>
// ****************************************************************************
// <author>Laurent Bugnion</author>
// <email>laurent@galasoft.ch</email>
// <date>13.4.2009</date>
// <project>GalaSoft.MvvmLight.Messaging</project>
// <web>http://www.galasoft.ch</web>
// <license>
// See license.txt in this project or http://www.galasoft.ch/license_MIT.txt
// </license>
// ****************************************************************************

using System;

////using GalaSoft.Utilities.Attributes;

namespace GalaSoft.MvvmLight.Messaging
{
    /// <summary>
    /// Passes a string message (Command) and a generic value (Content) to a recipient.
    /// </summary>
    /// <typeparam name="T">The type of the Content property.</typeparam>
    ////[ClassInfo(typeof(Messenger))]
    [Obsolete("This class has been replaced by NotificationMessage<T>. Only the name changed, nothing else. Please use the new class from now on.")]
    public class CommandMessage<T> : GenericMessage<T>
    {
        /// <summary>
        /// Initializes a new instance of the CommandMessage class.
        /// </summary>
        /// <param name="content">A value to be passed to recipient(s).</param>
        /// <param name="command">A string containing any arbitrary message to be
        /// passed to recipient(s)</param>
        public CommandMessage(T content, string command)
            : base(content)
        {
            Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the CommandMessage class.
        /// </summary>
        /// <param name="sender">The message's sender.</param>
        /// <param name="content">A value to be passed to recipient(s).</param>
        /// <param name="command">A string containing any arbitrary message to be
        /// passed to recipient(s)</param>
        public CommandMessage(object sender, T content, string command)
            : base(sender, content)
        {
            Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the CommandMessage class.
        /// </summary>
        /// <param name="sender">The message's sender.</param>
        /// <param name="target">The message's intended target. This parameter can be used
        /// to give an indication as to whom the message was intended for. Of course
        /// this is only an indication, amd may be null.</param>
        /// <param name="content">A value to be passed to recipient(s).</param>
        /// <param name="command">A string containing any arbitrary message to be
        /// passed to recipient(s)</param>
        public CommandMessage(object sender, object target, T content, string command)
            : base(sender, target, content)
        {
            Command = command;
        }

        /// <summary>
        /// Gets a string containing any arbitrary message to be
        /// passed to recipient(s).
        /// </summary>
        public string Command
        {
            get;
            private set;
        }
    }
}