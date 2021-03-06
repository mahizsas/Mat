﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Mat.Common
{
    public static class MediaFactory
    {
        private static readonly List<string> _allowedExtensions = new List<string>
                                                             {
                                                                 ".jpeg",
                                                                 ".jpg",
                                                                 ".png"
                                                             };

        private static readonly List<string> _allowedMime = new List<string>
                                                                {
                                                                    "image/jpeg",
                                                                    "image/png"
                                                                };

        /// <summary>
        /// Recognizes media based on a file path.
        /// </summary>
        /// <param name="path">The file path</param>
        /// <returns></returns>
        public static bool IsPathMedia(string path)
        {
            var ext = Path.GetExtension(path);
            if (ext == null) return false;
            return _allowedExtensions.Contains(ext.ToLowerInvariant());
        }

        public static bool IsMimeTypeMedia(string mimeType)
        {
            return _allowedMime.Contains(mimeType);
        }

        public static Media CreateFromUrl(Guid source, string url)
        {
            return new Media(source) {Url = url};
        }
    }
}
