using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Archives
{
    public interface IArchiveFolder
    {
        string? Path { get; }
        IReadOnlyCollection<IArchiveFile> Files { get; }
    }
}
