using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic
{
    public class DiagOption
    {
        public string text;
        public Action action;
        public DiagOption parent = null;
        public List<DiagOption> children = new List<DiagOption>();

        public DiagOption(string text, Action action)
        {
            this.text = text;
            this.action = action;
        }

        public DiagOption(string text, Action action, DiagOption parent)
        {
            this.text = text;
            this.action = action;
            this.parent = parent;

            parent.AddChild(this);
        }

        public void AddChild(DiagOption child)
        {
            children.Add(child);
        }
    }
}
