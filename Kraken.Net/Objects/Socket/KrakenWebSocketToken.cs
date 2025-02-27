﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kraken.Net.Objects.Socket
{
    /// <summary>
    /// Socket token
    /// </summary>
    public class KrakenWebSocketToken
    {
        /// <summary>
        /// Token to use for connecting to private websockets
        /// </summary>
        public string Token { get; set; } = "";
        /// <summary>
        /// Expires after x seconds
        /// </summary>
        public int Expires { get; set; }
    }
}
