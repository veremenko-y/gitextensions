            var sb = new StringBuilder();
        public static byte[] GetSelectedLinesAsNewPatch([NotNull] GitModule module, [NotNull] string newFileName, [NotNull] string text, int selectionPosition, int selectionLength, [NotNull] Encoding fileContentEncoding, bool reset, byte[] filePreamble)
            var sb = new StringBuilder();
            var selectedChunks = FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreamble, fileContentEncoding);
                // if selection intersects with chunks
        private static IReadOnlyList<Chunk> FromNewFile([NotNull] GitModule module, [NotNull] string text, int selectionPosition, int selectionLength, bool reset, [NotNull] byte[] filePreamble, [NotNull] Encoding fileContentEncoding)
                Chunk.FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreamble, fileContentEncoding)
            var result = new Chunk();
                    // do not refactor, there are no break points condition in VS Express
        public static Chunk FromNewFile([NotNull] GitModule module, [NotNull] string fileText, int selectionPosition, int selectionLength, bool reset, [NotNull] byte[] filePreamble, [NotNull] Encoding fileContentEncoding)
            var result = new Chunk { _startLine = 0 };
                string preamble = i == 0 ? new string(fileContentEncoding.GetChars(filePreamble)) : string.Empty;