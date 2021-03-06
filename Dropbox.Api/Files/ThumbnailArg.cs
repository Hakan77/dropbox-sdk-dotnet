// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The thumbnail arg object</para>
    /// </summary>
    public sealed class ThumbnailArg : enc.IEncodable<ThumbnailArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path to the image file you want to thumbnail.</param>
        /// <param name="format">The format for the thumbnail image, jpeg (default) or png. For
        /// images that are photos, jpeg should be preferred, while png is  better for
        /// screenshots and digital arts.</param>
        /// <param name="size">The size for the thumbnail image.</param>
        public ThumbnailArg(string path,
                            ThumbnailFormat format = null,
                            ThumbnailSize size = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            if (format == null)
            {
                format = ThumbnailFormat.Jpeg.Instance;
            }

            if (size == null)
            {
                size = ThumbnailSize.W64h64.Instance;
            }

            this.Path = path;
            this.Format = format;
            this.Size = size;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ThumbnailArg()
        {
            this.Format = ThumbnailFormat.Jpeg.Instance;
            this.Size = ThumbnailSize.W64h64.Instance;
        }

        /// <summary>
        /// <para>The path to the image file you want to thumbnail.</para>
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// <para>The format for the thumbnail image, jpeg (default) or png. For  images that
        /// are photos, jpeg should be preferred, while png is  better for screenshots and
        /// digital arts.</para>
        /// </summary>
        public ThumbnailFormat Format { get; private set; }

        /// <summary>
        /// <para>The size for the thumbnail image.</para>
        /// </summary>
        public ThumbnailSize Size { get; private set; }

        #region IEncodable<ThumbnailArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ThumbnailArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
                obj.AddFieldObject<ThumbnailFormat>("format", this.Format);
                obj.AddFieldObject<ThumbnailSize>("size", this.Size);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ThumbnailArg enc.IEncodable<ThumbnailArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");
                if (obj.HasField("format"))
                {
                    this.Format = obj.GetFieldObject<ThumbnailFormat>("format");
                }
                if (obj.HasField("size"))
                {
                    this.Size = obj.GetFieldObject<ThumbnailSize>("size");
                }
            }

            return this;
        }

        #endregion
    }
}
