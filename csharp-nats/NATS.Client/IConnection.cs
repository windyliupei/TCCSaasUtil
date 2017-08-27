﻿// Copyright 2015 Apcera Inc. All rights reserved.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace NATS.Client
{
    /// <summary>
    /// Represents a connection to the NATS server.
    /// </summary>
    public interface IConnection : IDisposable
    {
        /// <summary>
        /// Gets the configuration options for this instance.
        /// </summary>
        Options Opts { get; }

        /// <summary>
        /// Gets the URL of the NATS server to which this instance
        /// is connected, otherwise <c>null</c>.
        /// </summary>
        string ConnectedUrl { get; }

        /// <summary>
        /// Gets the server ID of the NATS server to which this instance
        /// is connected, otherwise <c>null</c>.
        /// </summary>
        string ConnectedId { get; }

        /// <summary>
        /// Gets an array of known server URLs for this instance.
        /// </summary>
        /// <remarks><see cref="Servers"/> also includes any additional
        /// servers discovered after a connection has been established. If
        /// authentication is enabled, <see cref="Options.User"/> or
        /// <see cref="Options.Token"/> must be used when connecting with
        /// these URLs.</remarks>
        string[] Servers { get; }

        /// <summary>
        /// Gets an array of server URLs that were discovered after this
        /// instance connected.
        /// </summary>
        /// <remarks>If authentication is enabled, <see cref="Options.User"/> or
        /// <see cref="Options.Token"/> must be used when connecting with
        /// these URLs.</remarks>
        string[] DiscoveredServers { get; }

        /// <summary>
        /// Gets the last <see cref="Exception"/> encountered by this instance,
        /// otherwise <c>null</c>.
        /// </summary>
        Exception LastError { get; }

        /// <summary>
        /// Publishes <paramref name="data"/> to the given <paramref name="subject"/>.
        /// </summary>
        /// <remarks>
        /// <para>NATS implements a publish-subscribe message distribution model. NATS publish subscribe is a
        /// one-to-many communication. A publisher sends a message on a subject. Any active subscriber listening
        /// on that subject receives the message. Subscribers can register interest in wildcard subjects.</para>
        /// <para>In the basic NATS platfrom, if a subscriber is not listening on the subject (no subject match),
        /// or is not acive when the message is sent, the message is not recieved. NATS is a fire-and-forget
        /// messaging system. If you need higher levels of service, you can either use NATS Streaming, or build the
        /// additional reliability into your client(s) yourself.</para>
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the data to publish
        /// to the connected NATS server.</param>
        void Publish(string subject, byte[] data);

        /// <summary>
        /// Publishes a <see cref="Msg"/> instance, which includes the subject, an optional reply, and an
        /// optional data field.
        /// </summary>
        /// <param name="msg">A <see cref="Msg"/> instance containing the subject, optional reply, and data to publish
        /// to the NATS server.</param>
        /// <seealso cref="IConnection.Publish(string, byte[])"/>
        void Publish(Msg msg);

        /// <summary>
        /// Publishes <paramref name="data"/> to the given <paramref name="subject"/>.
        /// </summary>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="reply">An optional reply subject.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the data to publish
        /// to the connected NATS server.</param>
        /// <seealso cref="IConnection.Publish(string, byte[])"/>
        void Publish(string subject, string reply, byte[] data);

        /// <summary>
        /// Sends a request payload and returns the response <see cref="Msg"/>, or throws
        /// <see cref="NATSTimeoutException"/> if the <paramref name="timeout"/> expires.
        /// </summary>
        /// <remarks>
        /// <see cref="Request(string, byte[])"/> will create an unique inbox for this request, sharing a single
        /// subscription for all replies to this <see cref="Connection"/> instance. However, if 
        /// <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription. 
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <param name="timeout">The number of milliseconds to wait.</param>
        /// <returns>A <see cref="Msg"/> with the response from the NATS server.</returns>
        /// <seealso cref="IConnection.Request(string, byte[])"/>
        Msg Request(string subject, byte[] data, int timeout);

        /// <summary>
        /// Sends a request payload and returns the response <see cref="Msg"/>.
        /// </summary>
        /// <remarks>
        /// <para>NATS supports two flavors of request-reply messaging: point-to-point or one-to-many. Point-to-point
        /// involves the fastest or first to respond. In a one-to-many exchange, you set a limit on the number of 
        /// responses the requestor may receive and instead must use a subscription (<see cref="ISubscription.AutoUnsubscribe(int)"/>).
        /// In a request-response exchange, publish request operation publishes a message with a reply subject expecting
        /// a response on that reply subject.</para>
        /// <para><see cref="Request(string, byte[])"/> will create an unique inbox for this request, sharing a single
        /// subscription for all replies to this <see cref="Connection"/> instance. However, if 
        /// <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription. 
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.</para>
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <returns>A <see cref="Msg"/> with the response from the NATS server.</returns>
        Msg Request(string subject, byte[] data);

        /// <summary>
        /// Asynchronously sends a request payload and returns the response <see cref="Msg"/>, or throws 
        /// <see cref="NATSTimeoutException"/> if the <paramref name="timeout"/> expires.
        /// </summary>
        /// <remarks>
        /// <see cref="RequestAsync(string, byte[], int)"/> will create an unique inbox for this request, sharing a
        /// single subscription for all replies to this <see cref="Connection"/> instance. However, if
        /// <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription.
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <param name="timeout">The number of milliseconds to wait.</param>
        /// <returns>A task that represents the asynchronous read operation. The value of the <see cref="Task{TResult}.Result"/>
        /// parameter contains a <see cref="Msg"/> with the response from the NATS server.</returns>
        /// <seealso cref="IConnection.Request(string, byte[])"/>
        Task<Msg> RequestAsync(string subject, byte[] data, int timeout);

        /// <summary>
        /// Asynchronously sends a request payload and returns the response <see cref="Msg"/>.
        /// </summary>
        /// <remarks>
        /// <see cref="RequestAsync(string, byte[])"/> will create an unique inbox for this request, sharing a single
        /// subscription for all replies to this <see cref="Connection"/> instance. However, if
        /// <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription. 
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <returns>A task that represents the asynchronous read operation. The value of the 
        /// <see cref="Task{TResult}.Result"/> parameter contains a <see cref="Msg"/> with the response from the NATS
        /// server.</returns>
        /// <seealso cref="IConnection.Request(string, byte[])"/>
        Task<Msg> RequestAsync(string subject, byte[] data);

        /// <summary>
        /// Asynchronously sends a request payload and returns the response <see cref="Msg"/>, or throws
        /// <see cref="NATSTimeoutException"/> if the <paramref name="timeout"/> expires, while monitoring for 
        /// cancellation requests.
        /// </summary>
        /// <remarks>
        /// <see cref="RequestAsync(string, byte[], int, CancellationToken)"/> will create an unique inbox for this
        /// request, sharing a single subscription for all replies to this <see cref="Connection"/> instance. However,
        /// if <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription.
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <param name="timeout">The number of milliseconds to wait.</param>
        /// <param name="token">The token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous read operation. The value of the
        /// <see cref="Task{TResult}.Result"/> parameter contains  a <see cref="Msg"/> with the response from the NATS
        /// server.</returns>
        /// <seealso cref="IConnection.Request(string, byte[])"/>
        Task<Msg> RequestAsync(string subject, byte[] data, int timeout, CancellationToken token);

        /// <summary>
        /// Asynchronously sends a request payload and returns the response <see cref="Msg"/>, while monitoring for
        /// cancellation requests.
        /// </summary>
        /// <remarks>
        /// <see cref="RequestAsync(string, byte[], CancellationToken)"/> will create an unique inbox for this request,
        /// sharing a single subscription for all replies to this <see cref="Connection"/> instance. However, if 
        /// <see cref="Options.UseOldRequestStyle"/> is set, each request will have its own underlying subscription.
        /// The old behavior is not recommended as it may cause unnecessary overhead on connected NATS servers.
        /// </remarks>
        /// <param name="subject">The subject to publish <paramref name="data"/> to over
        /// the current connection.</param>
        /// <param name="data">An array of type <see cref="Byte"/> that contains the request data to publish
        /// to the connected NATS server.</param>
        /// <param name="token">The token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous read operation. The value of the
        /// <see cref="Task{TResult}.Result"/> parameter contains a <see cref="Msg"/> with the response from the NATS 
        /// server.</returns>
        /// <seealso cref="IConnection.Request(string, byte[])"/>
        Task<Msg> RequestAsync(string subject, byte[] data, CancellationToken token);

        /// <summary>
        /// Creates an inbox string which can be used for directed replies from subscribers.
        /// </summary>
        /// <remarks>
        /// The returned inboxes are guaranteed to be unique, but can be shared and subscribed
        /// to by others.
        /// </remarks>
        /// <returns>A unique inbox string.</returns>
        string NewInbox();

        /// <summary>
        /// Expresses interest in the given <paramref name="subject"/> to the NATS Server.
        /// </summary>
        /// <param name="subject">The subject on which to listen for messages.
        /// The subject can have wildcards (partial: <c>*</c>, full: <c>&gt;</c>).</param>
        /// <returns>An <see cref="ISyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        ISyncSubscription SubscribeSync(string subject);

        /// <summary>
        /// Expresses interest in the given <paramref name="subject"/> to the NATS Server.
        /// </summary>
        /// <remarks>
        /// The <see cref="IAsyncSubscription"/> returned will not start receiving messages until
        /// <see cref="IAsyncSubscription.Start"/> is called.
        /// </remarks>
        /// <param name="subject">The subject on which to listen for messages. 
        /// The subject can have wildcards (partial: <c>*</c>, full: <c>&gt;</c>).</param>
        /// <returns>An <see cref="IAsyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        IAsyncSubscription SubscribeAsync(string subject);

        /// <summary>
        /// Expresses interest in the given <paramref name="subject"/> to the NATS Server, and begins delivering
        /// messages to the given event handler.
        /// </summary>
        /// <remarks>The <see cref="IAsyncSubscription"/> returned will start delivering messages
        /// to the event handler as soon as they are received. The caller does not have to invoke
        /// <see cref="IAsyncSubscription.Start"/>.</remarks>
        /// <param name="subject">The subject on which to listen for messages.
        /// The subject can have wildcards (partial: <c>*</c>, full: <c>&gt;</c>).</param>
        /// <param name="handler">The <see cref="EventHandler{TEventArgs}"/> invoked when messages are received 
        /// on the returned <see cref="IAsyncSubscription"/>.</param>
        /// <returns>An <see cref="IAsyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        IAsyncSubscription SubscribeAsync(string subject, EventHandler<MsgHandlerEventArgs> handler);

        /// <summary>
        /// Creates a synchronous queue subscriber on the given <paramref name="subject"/>.
        /// </summary>
        /// <remarks>All subscribers with the same queue name will form the queue group and
        /// only one member of the group will be selected to receive any given message
        /// synchronously.</remarks>
        /// <param name="subject">The subject on which to listen for messages.</param>
        /// <param name="queue">The name of the queue group in which to participate.</param>
        /// <returns>An <see cref="ISyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>, as part of 
        /// the given queue group.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        /// <seealso cref="ISubscription.Queue"/>
        ISyncSubscription SubscribeSync(string subject, string queue);

        /// <summary>
        /// Creates an asynchronous queue subscriber on the given <paramref name="subject"/>.
        /// </summary>
        /// <remarks>
        /// <para>All subscribers with the same queue name will form the queue group and
        /// only one member of the group will be selected to receive any given message.</para>
        /// <para>The <see cref="IAsyncSubscription"/> returned will not start receiving messages until
        /// <see cref="IAsyncSubscription.Start"/> is called.</para>
        /// </remarks>
        /// <param name="subject">The subject on which to listen for messages.
        /// The subject can have wildcards (partial: <c>*</c>, full: <c>&gt;</c>).</param>
        /// <param name="queue">The name of the queue group in which to participate.</param>
        /// <returns>An <see cref="IAsyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        /// <seealso cref="ISubscription.Queue"/>
        IAsyncSubscription SubscribeAsync(string subject, string queue);

        /// <summary>
        /// Creates an asynchronous queue subscriber on the given <paramref name="subject"/>, and begins delivering
        /// messages to the given event handler.
        /// </summary>
        /// <remarks>
        /// <para>All subscribers with the same queue name will form the queue group and
        /// only one member of the group will be selected to receive any given message.</para>
        /// <para>The <see cref="IAsyncSubscription"/> returned will start delivering messages
        /// to the event handler as soon as they are received. The caller does not have to invoke
        /// <see cref="IAsyncSubscription.Start"/>.</para>
        /// </remarks>
        /// <param name="subject">The subject on which to listen for messages.
        /// The subject can have wildcards (partial: <c>*</c>, full: <c>&gt;</c>).</param>
        /// <param name="queue">The name of the queue group in which to participate.</param>
        /// <param name="handler">The <see cref="EventHandler{MsgHandlerEventArgs}"/> invoked when messages are received 
        /// on the returned <see cref="IAsyncSubscription"/>.</param>
        /// <returns>An <see cref="IAsyncSubscription"/> to use to read any messages received
        /// from the NATS Server on the given <paramref name="subject"/>.</returns>
        /// <seealso cref="ISubscription.Subject"/>
        /// <seealso cref="ISubscription.Queue"/>
        IAsyncSubscription SubscribeAsync(string subject, string queue, EventHandler<MsgHandlerEventArgs> handler);

        /// <summary>
        /// Performs a round trip to the server and returns when it receives the internal reply, or throws
        /// a <see cref="NATSTimeoutException"/> exception if the NATS Server does not reply in time.
        /// </summary>
        /// <param name="timeout">The number of milliseconds to wait.</param>
        void Flush(int timeout);

        /// <summary>
        /// Performs a round trip to the server and returns when it receives the internal reply.
        /// </summary>
        void Flush();

        /// <summary>
        /// Closes the <see cref="IConnection"/> and all associated
        /// subscriptions.
        /// </summary>
        /// <seealso cref="IsClosed"/>
        /// <seealso cref="State"/>
        void Close();

        /// <summary>
        /// Returns a value indicating whether or not the <see cref="IConnection"/>
        /// instance is closed.
        /// </summary>
        /// <returns><c>true</c> if and only if the <see cref="IConnection"/> is
        /// closed, otherwise <c>false</c>.</returns>
        /// <seealso cref="Close"/>
        /// <seealso cref="State"/>
        bool IsClosed();

        /// <summary>
        /// Returns a value indicating whether or not the <see cref="IConnection"/>
        /// is currently reconnecting.
        /// </summary>
        /// <returns><c>true</c> if and only if the <see cref="IConnection"/> is
        /// reconnecting, otherwise <c>false</c>.</returns>
        /// <seealso cref="State"/>
        bool IsReconnecting();

        /// <summary>
        /// Gets the current state of the <see cref="IConnection"/>.
        /// </summary>
        /// <seealso cref="ConnState"/>
        ConnState State { get; }

        /// <summary>
        /// Gets the statistics tracked for the <see cref="IConnection"/>.
        /// </summary>
        /// <seealso cref="ResetStats"/>
        IStatistics Stats { get; }

        /// <summary>
        /// Resets the associated statistics for the <see cref="IConnection"/>.
        /// </summary>
        /// <seealso cref="Stats"/>
        void ResetStats();

        /// <summary>
        /// Gets the maximum size in bytes of any payload sent
        /// to the connected NATS Server.
        /// </summary>
        /// <seealso cref="Publish(Msg)"/>
        /// <seealso cref="Publish(string, byte[])"/>
        /// <seealso cref="Publish(string, string, byte[])"/>
        /// <seealso cref="Request(string, byte[])"/>
        /// <seealso cref="Request(string, byte[], int)"/>
        /// <seealso cref="RequestAsync(string, byte[])"/>
        /// <seealso cref="RequestAsync(string, byte[], CancellationToken)"/>
        /// <seealso cref="RequestAsync(string, byte[], int)"/>
        /// <seealso cref="RequestAsync(string, byte[], int, CancellationToken)"/>
        long MaxPayload { get; }
    }
}
