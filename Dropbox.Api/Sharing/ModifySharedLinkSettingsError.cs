// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The modify shared link settings error object</para>
    /// </summary>
    public class ModifySharedLinkSettingsError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ModifySharedLinkSettingsError> Encoder = new ModifySharedLinkSettingsErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ModifySharedLinkSettingsError> Decoder = new ModifySharedLinkSettingsErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ModifySharedLinkSettingsError"
        /// /> class.</para>
        /// </summary>
        public ModifySharedLinkSettingsError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is SettingsError</para>
        /// </summary>
        public bool IsSettingsError
        {
            get
            {
                return this is SettingsError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SettingsError, or <c>null</c>.</para>
        /// </summary>
        public SettingsError AsSettingsError
        {
            get
            {
                return this as SettingsError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EmailNotVerified</para>
        /// </summary>
        public bool IsEmailNotVerified
        {
            get
            {
                return this is EmailNotVerified;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EmailNotVerified, or <c>null</c>.</para>
        /// </summary>
        public EmailNotVerified AsEmailNotVerified
        {
            get
            {
                return this as EmailNotVerified;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ModifySharedLinkSettingsError" />.</para>
        /// </summary>
        private class ModifySharedLinkSettingsErrorEncoder : enc.StructEncoder<ModifySharedLinkSettingsError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ModifySharedLinkSettingsError value, enc.IJsonWriter writer)
            {
                if (value is SettingsError)
                {
                    WriteProperty(".tag", "settings_error", writer, enc.StringEncoder.Instance);
                    SettingsError.Encoder.EncodeFields((SettingsError)value, writer);
                    return;
                }
                if (value is EmailNotVerified)
                {
                    WriteProperty(".tag", "email_not_verified", writer, enc.StringEncoder.Instance);
                    EmailNotVerified.Encoder.EncodeFields((EmailNotVerified)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ModifySharedLinkSettingsError" />.</para>
        /// </summary>
        private class ModifySharedLinkSettingsErrorDecoder : enc.UnionDecoder<ModifySharedLinkSettingsError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ModifySharedLinkSettingsError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ModifySharedLinkSettingsError Create()
            {
                return new ModifySharedLinkSettingsError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ModifySharedLinkSettingsError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "settings_error":
                        return SettingsError.Decoder.DecodeFields(reader);
                    case "email_not_verified":
                        return EmailNotVerified.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>There is an error with the given settings</para>
        /// </summary>
        public sealed class SettingsError : ModifySharedLinkSettingsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SettingsError> Encoder = new SettingsErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SettingsError> Decoder = new SettingsErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SettingsError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public SettingsError(SharedLinkSettingsError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SettingsError" />
            /// class.</para>
            /// </summary>
            private SettingsError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharedLinkSettingsError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SettingsError" />.</para>
            /// </summary>
            private class SettingsErrorEncoder : enc.StructEncoder<SettingsError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SettingsError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Sharing.SharedLinkSettingsError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SettingsError" />.</para>
            /// </summary>
            private class SettingsErrorDecoder : enc.StructDecoder<SettingsError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="SettingsError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SettingsError Create()
                {
                    return new SettingsError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(SettingsError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "settings_error":
                            value.Value = Dropbox.Api.Sharing.SharedLinkSettingsError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The caller's email should be verified</para>
        /// </summary>
        public sealed class EmailNotVerified : ModifySharedLinkSettingsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EmailNotVerified> Encoder = new EmailNotVerifiedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EmailNotVerified> Decoder = new EmailNotVerifiedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EmailNotVerified" />
            /// class.</para>
            /// </summary>
            private EmailNotVerified()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EmailNotVerified</para>
            /// </summary>
            public static readonly EmailNotVerified Instance = new EmailNotVerified();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EmailNotVerified" />.</para>
            /// </summary>
            private class EmailNotVerifiedEncoder : enc.StructEncoder<EmailNotVerified>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EmailNotVerified value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EmailNotVerified" />.</para>
            /// </summary>
            private class EmailNotVerifiedDecoder : enc.StructDecoder<EmailNotVerified>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EmailNotVerified" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EmailNotVerified Create()
                {
                    return new EmailNotVerified();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override EmailNotVerified DecodeFields(enc.IJsonReader reader)
                {
                    return EmailNotVerified.Instance;
                }
            }

            #endregion
        }
    }
}