﻿// Copyright 2015 Apcera Inc. All rights reserved.

namespace NATS.Client
{
    /// <summary>
    /// Provides factory methods to create connections to NATS Servers.
    /// </summary>
    public sealed class ConnectionFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionFactory"/> class,
        /// providing factory methods to create connections to NATS Servers.
        /// </summary>
        public ConnectionFactory() { }

        /// <summary>
        /// Attempt to connect to the NATS server referenced by <paramref name="url"/>.
        /// </summary>
        /// <remarks>
        /// <para><paramref name="url"/> can contain username/password semantics.
        /// Comma seperated arrays are also supported, e.g. <c>&quot;urlA, urlB&quot;</c>.</para>
        /// </remarks>
        /// <param name="url">A string containing the URL (or URLs) to the NATS Server. See the Remarks
        /// section for more information.</param>
        /// <returns>An <see cref="IConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IConnection CreateConnection(string url)
        {
            Options opts = new Options();
            opts.processUrlString(url);
            return CreateConnection(opts);
        }

        /// <summary>
        /// Retrieves the default set of client options.
        /// </summary>
        /// <returns>The default <see cref="Options"/> object for the NATS client.</returns>
        public static Options GetDefaultOptions()
        {
            return new Options();
        }

        /// <summary>
        /// Attempt to connect to the NATS server using TLS referenced by <paramref name="url"/>.
        /// </summary>
        /// <remarks>
        /// <para><paramref name="url"/> can contain username/password semantics.
        /// Comma seperated arrays are also supported, e.g. urlA, urlB.</para>
        /// </remarks>
        /// <param name="url">A string containing the URL (or URLs) to the NATS Server. See the Remarks
        /// section for more information.</param>
        /// <returns>An <see cref="IConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IConnection CreateSecureConnection(string url)
        {
            Options opts = new Options();
            opts.processUrlString(url);
            opts.Secure = true;
            return CreateConnection(opts);
        }

        /// <summary>
        /// Create a connection to the NATs server using the default options.
        /// </summary>
        /// <returns>An <see cref="IConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        /// <seealso cref="GetDefaultOptions"/>
        public IConnection CreateConnection()
        {
            return CreateConnection(GetDefaultOptions());
        }

        /// <summary>
        /// Create a connection to a NATS Server defined by the given options.
        /// </summary>
        /// <param name="opts">The NATS client options to use for this connection.</param>
        /// <returns>An <see cref="IConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IConnection CreateConnection(Options opts)
        {
            Connection nc = new Connection(opts);
            nc.connect();
            return nc;
        }

        /// <summary>
        /// Attempt to connect to the NATS server, with an encoded connection, using the default options.
        /// </summary>
        /// <returns>An <see cref="IEncodedConnection"/> object connected to the NATS server.</returns>
        /// <seealso cref="GetDefaultOptions"/>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IEncodedConnection CreateEncodedConnection()
        {
            return CreateEncodedConnection(GetDefaultOptions());
        }

        /// <summary>
        /// Attempt to connect to the NATS server, with an encoded connection, referenced by <paramref name="url"/>.
        /// </summary>
        /// <remarks>
        /// <para><paramref name="url"/> can contain username/password semantics.
        /// Comma seperated arrays are also supported, e.g. urlA, urlB.</para>
        /// </remarks>
        /// <param name="url">A string containing the URL (or URLs) to the NATS Server. See the Remarks
        /// section for more information.</param>
        /// <returns>An <see cref="IEncodedConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IEncodedConnection CreateEncodedConnection(string url)
        {
            Options opts = new Options();
            opts.processUrlString(url);
            return CreateEncodedConnection(opts);
        }

        /// <summary>
        /// Attempt to connect to the NATS server, with an encoded connection, using the given options.
        /// </summary>
        /// <param name="opts">The NATS client options to use for this connection.</param>
        /// <returns>An <see cref="IEncodedConnection"/> object connected to the NATS server.</returns>
        /// <exception cref="NATSNoServersException">No connection to a NATS Server could be established.</exception>
        /// <exception cref="NATSConnectionException"><para>A timeout occurred connecting to a NATS Server.</para>
        /// <para>-or-</para>
        /// <para>An exception was encountered while connecting to a NATS Server. See <see cref="System.Exception.InnerException"/> for more
        /// details.</para></exception>
        public IEncodedConnection CreateEncodedConnection(Options opts)
        {
            EncodedConnection nc = new EncodedConnection(opts);
            nc.connect();
            return nc;
        }
    }
}
