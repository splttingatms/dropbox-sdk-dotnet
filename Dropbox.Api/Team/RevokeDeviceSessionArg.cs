// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The revoke device session arg object</para>
    /// </summary>
    public class RevokeDeviceSessionArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeDeviceSessionArg> Encoder = new RevokeDeviceSessionArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeDeviceSessionArg> Decoder = new RevokeDeviceSessionArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionArg" />
        /// class.</para>
        /// </summary>
        public RevokeDeviceSessionArg()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is WebSession</para>
        /// </summary>
        public bool IsWebSession
        {
            get
            {
                return this is WebSession;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a WebSession, or <c>null</c>.</para>
        /// </summary>
        public WebSession AsWebSession
        {
            get
            {
                return this as WebSession;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DesktopClient</para>
        /// </summary>
        public bool IsDesktopClient
        {
            get
            {
                return this is DesktopClient;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DesktopClient, or <c>null</c>.</para>
        /// </summary>
        public DesktopClient AsDesktopClient
        {
            get
            {
                return this as DesktopClient;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MobileClient</para>
        /// </summary>
        public bool IsMobileClient
        {
            get
            {
                return this is MobileClient;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MobileClient, or <c>null</c>.</para>
        /// </summary>
        public MobileClient AsMobileClient
        {
            get
            {
                return this as MobileClient;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeDeviceSessionArg" />.</para>
        /// </summary>
        private class RevokeDeviceSessionArgEncoder : enc.StructEncoder<RevokeDeviceSessionArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeDeviceSessionArg value, enc.IJsonWriter writer)
            {
                if (value is WebSession)
                {
                    WriteProperty(".tag", "web_session", writer, enc.StringEncoder.Instance);
                    WebSession.Encoder.EncodeFields((WebSession)value, writer);
                    return;
                }
                if (value is DesktopClient)
                {
                    WriteProperty(".tag", "desktop_client", writer, enc.StringEncoder.Instance);
                    DesktopClient.Encoder.EncodeFields((DesktopClient)value, writer);
                    return;
                }
                if (value is MobileClient)
                {
                    WriteProperty(".tag", "mobile_client", writer, enc.StringEncoder.Instance);
                    MobileClient.Encoder.EncodeFields((MobileClient)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeDeviceSessionArg" />.</para>
        /// </summary>
        private class RevokeDeviceSessionArgDecoder : enc.UnionDecoder<RevokeDeviceSessionArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeDeviceSessionArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeDeviceSessionArg Create()
            {
                return new RevokeDeviceSessionArg();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RevokeDeviceSessionArg Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "web_session":
                        return WebSession.Decoder.DecodeFields(reader);
                    case "desktop_client":
                        return DesktopClient.Decoder.DecodeFields(reader);
                    case "mobile_client":
                        return MobileClient.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>End an active session</para>
        /// </summary>
        public sealed class WebSession : RevokeDeviceSessionArg
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<WebSession> Encoder = new WebSessionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<WebSession> Decoder = new WebSessionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="WebSession" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public WebSession(DeviceSessionArg value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="WebSession" /> class.</para>
            /// </summary>
            private WebSession()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public DeviceSessionArg Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="WebSession" />.</para>
            /// </summary>
            private class WebSessionEncoder : enc.StructEncoder<WebSession>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(WebSession value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.DeviceSessionArg.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="WebSession" />.</para>
            /// </summary>
            private class WebSessionDecoder : enc.StructDecoder<WebSession>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="WebSession" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override WebSession Create()
                {
                    return new WebSession();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override WebSession DecodeFields(enc.IJsonReader reader)
                {
                    return new WebSession(Dropbox.Api.Team.DeviceSessionArg.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Unlink a linked desktop device</para>
        /// </summary>
        public sealed class DesktopClient : RevokeDeviceSessionArg
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DesktopClient> Encoder = new DesktopClientEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DesktopClient> Decoder = new DesktopClientDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DesktopClient" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public DesktopClient(RevokeDesktopClientArg value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DesktopClient" />
            /// class.</para>
            /// </summary>
            private DesktopClient()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public RevokeDesktopClientArg Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DesktopClient" />.</para>
            /// </summary>
            private class DesktopClientEncoder : enc.StructEncoder<DesktopClient>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DesktopClient value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.RevokeDesktopClientArg.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DesktopClient" />.</para>
            /// </summary>
            private class DesktopClientDecoder : enc.StructDecoder<DesktopClient>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DesktopClient" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DesktopClient Create()
                {
                    return new DesktopClient();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override DesktopClient DecodeFields(enc.IJsonReader reader)
                {
                    return new DesktopClient(Dropbox.Api.Team.RevokeDesktopClientArg.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Unlink a linked mobile device</para>
        /// </summary>
        public sealed class MobileClient : RevokeDeviceSessionArg
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MobileClient> Encoder = new MobileClientEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MobileClient> Decoder = new MobileClientDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MobileClient" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MobileClient(DeviceSessionArg value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MobileClient" />
            /// class.</para>
            /// </summary>
            private MobileClient()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public DeviceSessionArg Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MobileClient" />.</para>
            /// </summary>
            private class MobileClientEncoder : enc.StructEncoder<MobileClient>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MobileClient value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.DeviceSessionArg.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MobileClient" />.</para>
            /// </summary>
            private class MobileClientDecoder : enc.StructDecoder<MobileClient>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MobileClient" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MobileClient Create()
                {
                    return new MobileClient();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MobileClient DecodeFields(enc.IJsonReader reader)
                {
                    return new MobileClient(Dropbox.Api.Team.DeviceSessionArg.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }
    }
}