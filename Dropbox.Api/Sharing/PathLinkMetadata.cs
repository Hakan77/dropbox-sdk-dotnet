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
    /// <para>Metadata for a path-based shared link.</para>
    /// </summary>
    /// <seealso cref="LinkMetadata" />
    public sealed class PathLinkMetadata : LinkMetadata, enc.IEncodable<PathLinkMetadata>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PathLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link.</param>
        /// <param name="visibility">Who can access the link.</param>
        /// <param name="path">Path in user's Dropbox.</param>
        /// <param name="expires">Expiration time, if set. By default the link won't
        /// expire.</param>
        public PathLinkMetadata(string url,
                                Visibility visibility,
                                string path,
                                sys.DateTime? expires = null)
            : base(url, visibility, expires)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PathLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public PathLinkMetadata()
        {
        }

        /// <summary>
        /// <para>Path in user's Dropbox.</para>
        /// </summary>
        public string Path { get; private set; }

        #region IEncodable<PathLinkMetadata> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<PathLinkMetadata>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>(".tag", "path");
                obj.AddField<string>("url", this.Url);
                obj.AddFieldObject<Visibility>("visibility", this.Visibility);
                obj.AddField<string>("path", this.Path);
                if (this.Expires != null)
                {
                    obj.AddField<sys.DateTime>("expires", this.Expires.Value);
                }
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        PathLinkMetadata enc.IEncodable<PathLinkMetadata>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Url = obj.GetField<string>("url");
                this.Visibility = obj.GetFieldObject<Visibility>("visibility");
                this.Path = obj.GetField<string>("path");
                if (obj.HasField("expires"))
                {
                    this.Expires = obj.GetField<sys.DateTime>("expires");
                }
            }

            return this;
        }

        #endregion
    }
}
