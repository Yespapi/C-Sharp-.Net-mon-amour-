using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LesVues.TableBuilder
{
    public class MvcHtmlTableRow : IDisposable
    {

        private readonly TextWriter _writer;
        private readonly CellType _type;
        private readonly TagBuilder _builder;
        private bool _disposed;

        public TextWriter Writer
        {
            get { return _writer; }
        }

        public CellType Type
        {
            get { return _type; }
        }

        public MvcHtmlTableRow(TextWriter writer, CellType type, object attributes)
        {
            _writer = writer;
            _type = type;
            _builder = new TagBuilder("tr");

            TableHelper.MergeAttributes
                (_builder, attributes);

            _writer.Write(_builder.ToString(TagRenderMode.StartTag));

        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _writer.Write(_builder.ToString(TagRenderMode.EndTag));
            _disposed = true;
        }
    }
}