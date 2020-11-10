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
    /// <para>Changed an alert setting.</para>
    /// </summary>
    public class AdminAlertingChangedAlertConfigDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AdminAlertingChangedAlertConfigDetails> Encoder = new AdminAlertingChangedAlertConfigDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AdminAlertingChangedAlertConfigDetails> Decoder = new AdminAlertingChangedAlertConfigDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AdminAlertingChangedAlertConfigDetails" /> class.</para>
        /// </summary>
        /// <param name="alertName">Alert Name.</param>
        /// <param name="previousAlertConfig">Previous alert configuration.</param>
        /// <param name="newAlertConfig">New alert configuration.</param>
        public AdminAlertingChangedAlertConfigDetails(string alertName,
                                                      AdminAlertingAlertConfiguration previousAlertConfig,
                                                      AdminAlertingAlertConfiguration newAlertConfig)
        {
            if (alertName == null)
            {
                throw new sys.ArgumentNullException("alertName");
            }

            if (previousAlertConfig == null)
            {
                throw new sys.ArgumentNullException("previousAlertConfig");
            }

            if (newAlertConfig == null)
            {
                throw new sys.ArgumentNullException("newAlertConfig");
            }

            this.AlertName = alertName;
            this.PreviousAlertConfig = previousAlertConfig;
            this.NewAlertConfig = newAlertConfig;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AdminAlertingChangedAlertConfigDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AdminAlertingChangedAlertConfigDetails()
        {
        }

        /// <summary>
        /// <para>Alert Name.</para>
        /// </summary>
        public string AlertName { get; protected set; }

        /// <summary>
        /// <para>Previous alert configuration.</para>
        /// </summary>
        public AdminAlertingAlertConfiguration PreviousAlertConfig { get; protected set; }

        /// <summary>
        /// <para>New alert configuration.</para>
        /// </summary>
        public AdminAlertingAlertConfiguration NewAlertConfig { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AdminAlertingChangedAlertConfigDetails" />.</para>
        /// </summary>
        private class AdminAlertingChangedAlertConfigDetailsEncoder : enc.StructEncoder<AdminAlertingChangedAlertConfigDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AdminAlertingChangedAlertConfigDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("alert_name", value.AlertName, writer, enc.StringEncoder.Instance);
                WriteProperty("previous_alert_config", value.PreviousAlertConfig, writer, global::Dropbox.Api.TeamLog.AdminAlertingAlertConfiguration.Encoder);
                WriteProperty("new_alert_config", value.NewAlertConfig, writer, global::Dropbox.Api.TeamLog.AdminAlertingAlertConfiguration.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AdminAlertingChangedAlertConfigDetails" />.</para>
        /// </summary>
        private class AdminAlertingChangedAlertConfigDetailsDecoder : enc.StructDecoder<AdminAlertingChangedAlertConfigDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="AdminAlertingChangedAlertConfigDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AdminAlertingChangedAlertConfigDetails Create()
            {
                return new AdminAlertingChangedAlertConfigDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AdminAlertingChangedAlertConfigDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "alert_name":
                        value.AlertName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_alert_config":
                        value.PreviousAlertConfig = global::Dropbox.Api.TeamLog.AdminAlertingAlertConfiguration.Decoder.Decode(reader);
                        break;
                    case "new_alert_config":
                        value.NewAlertConfig = global::Dropbox.Api.TeamLog.AdminAlertingAlertConfiguration.Decoder.Decode(reader);
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
