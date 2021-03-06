// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed file locking policy for team.</para>
    /// </summary>
    public class FileLockingPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileLockingPolicyChangedDetails> Encoder = new FileLockingPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileLockingPolicyChangedDetails> Decoder = new FileLockingPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLockingPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="newValue">New file locking policy.</param>
        /// <param name="previousValue">Previous file locking policy.</param>
        public FileLockingPolicyChangedDetails(global::Dropbox.Api.TeamPolicies.FileLockingPolicyState newValue,
                                               global::Dropbox.Api.TeamPolicies.FileLockingPolicyState previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLockingPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileLockingPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>New file locking policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.FileLockingPolicyState NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous file locking policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.FileLockingPolicyState PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileLockingPolicyChangedDetails" />.</para>
        /// </summary>
        private class FileLockingPolicyChangedDetailsEncoder : enc.StructEncoder<FileLockingPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileLockingPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamPolicies.FileLockingPolicyState.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamPolicies.FileLockingPolicyState.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileLockingPolicyChangedDetails" />.</para>
        /// </summary>
        private class FileLockingPolicyChangedDetailsDecoder : enc.StructDecoder<FileLockingPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileLockingPolicyChangedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileLockingPolicyChangedDetails Create()
            {
                return new FileLockingPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileLockingPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamPolicies.FileLockingPolicyState.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamPolicies.FileLockingPolicyState.Decoder.Decode(reader);
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
