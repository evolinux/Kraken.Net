﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Sockets;
using Kraken.Net.Objects;
using Kraken.Net.Objects.Socket;

namespace Kraken.Net.Interfaces
{
    /// <summary>
    /// Interface for the Kraken socket client
    /// </summary>
    public interface IKrakenSocketClient: ISocketClient
    {
        /// <summary>
        /// Subscribe to ticker updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToTickerUpdates(string symbol, Action<KrakenSocketEvent<KrakenStreamTick>> handler);

        /// <summary>
        /// Subscribe to ticker updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToTickerUpdatesAsync(string symbol, Action<KrakenSocketEvent<KrakenStreamTick>> handler);

        /// <summary>
        /// Subscribe to kline updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="interval">Kline interval</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToKlineUpdates(string symbol, KlineInterval interval, Action<KrakenSocketEvent<KrakenStreamKline>> handler);

        /// <summary>
        /// Subscribe to kline updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="interval">Kline interval</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToKlineUpdatesAsync(string symbol, KlineInterval interval, Action<KrakenSocketEvent<KrakenStreamKline>> handler);

        /// <summary>
        /// Subscribe to trade updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToTradeUpdates(string symbol, Action<KrakenSocketEvent<IEnumerable<KrakenTrade>>> handler);

        /// <summary>
        /// Subscribe to trade updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToTradeUpdatesAsync(string symbol, Action<KrakenSocketEvent<IEnumerable<KrakenTrade>>> handler);

        /// <summary>
        /// Subscribe to spread updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToSpreadUpdates(string symbol, Action<KrakenSocketEvent<KrakenStreamSpread>> handler);

        /// <summary>
        /// Subscribe to spread updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToSpreadUpdatesAsync(string symbol, Action<KrakenSocketEvent<KrakenStreamSpread>> handler);

        /// <summary>
        /// Subscribe to depth updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="depth">Depth of the initial order book snapshot</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToDepthUpdates(string symbol, int depth, Action<KrakenSocketEvent<KrakenStreamOrderBook>> handler);

        /// <summary>
        /// Subscribe to depth updates
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <param name="depth">Depth of the initial order book snapshot</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToDepthUpdatesAsync(string symbol, int depth, Action<KrakenSocketEvent<KrakenStreamOrderBook>> handler);

        /// <summary>
        /// Subscribe to open order updates
        /// </summary>
        /// <param name="socketToken">The socket token as retrieved by the GetWebsocketTokenAsync method in the KrakenClient</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToOrderUpdates(string socketToken,
            Action<Dictionary<string, KrakenOrder>> handler);

        /// <summary>
        /// Subscribe to open order updates
        /// </summary>
        /// <param name="socketToken">The socket token as retrieved by the GetWebsocketTokenAsync method in the KrakenClient</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToOrderUpdatesAsync(string socketToken,
            Action<Dictionary<string, KrakenOrder>> handler);

        /// <summary>
        /// Subscribe to own trade updates
        /// </summary>
        /// <param name="socketToken">The socket token as retrieved by the GetWebsocketTokenAsync method in the KrakenClient</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        CallResult<UpdateSubscription> SubscribeToOwnTradeUpdates(string socketToken,
            Action<Dictionary<string, KrakenUserTrade>> handler);

        /// <summary>
        /// Subscribe to own trade updates
        /// </summary>
        /// <param name="socketToken">The socket token as retrieved by the GetWebsocketTokenAsync method in the KrakenClient</param>
        /// <param name="handler">Data handler</param>
        /// <returns>A stream subscription. This stream subscription can be used to be notified when the socket is disconnected/reconnected</returns>
        Task<CallResult<UpdateSubscription>> SubscribeToOwnTradeUpdatesAsync(string socketToken,
            Action<Dictionary<string, KrakenUserTrade>> handler);
    }
}