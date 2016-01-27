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
    /// <para>The information about a group member of the shared folder.</para>
    /// </summary>
    /// <seealso cref="MembershipInfo" />
    public class GroupMembershipInfo : MembershipInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupMembershipInfo> Encoder = new GroupMembershipInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupMembershipInfo> Decoder = new GroupMembershipInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The access type for this member.</param>
        /// <param name="group">The information about the membership group.</param>
        /// <param name="permissions">The permissions that requesting user has on this member.
        /// The set of permissions corresponds to the MemberActions in the request.</param>
        public GroupMembershipInfo(AccessLevel accessType,
                                   GroupInfo @group,
                                   col.IEnumerable<MemberPermission> permissions = null)
            : base(accessType, permissions)
        {
            if (@group == null)
            {
                throw new sys.ArgumentNullException("@group");
            }

            this.Group = @group;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupMembershipInfo()
        {
        }

        /// <summary>
        /// <para>The information about the membership group.</para>
        /// </summary>
        public GroupInfo Group { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupMembershipInfo" />.</para>
        /// </summary>
        private class GroupMembershipInfoEncoder : enc.StructEncoder<GroupMembershipInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupMembershipInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("group", value.Group, writer, Dropbox.Api.Sharing.GroupInfo.Encoder);
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, Dropbox.Api.Sharing.MemberPermission.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupMembershipInfo" />.</para>
        /// </summary>
        private class GroupMembershipInfoDecoder : enc.StructDecoder<GroupMembershipInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupMembershipInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupMembershipInfo Create()
            {
                return new GroupMembershipInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupMembershipInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "group":
                        value.Group = Dropbox.Api.Sharing.GroupInfo.Decoder.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<MemberPermission>(reader, Dropbox.Api.Sharing.MemberPermission.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
