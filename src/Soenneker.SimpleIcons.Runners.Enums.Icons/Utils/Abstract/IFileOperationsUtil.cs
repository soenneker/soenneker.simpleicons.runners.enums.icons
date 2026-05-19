using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.SimpleIcons.Runners.Enums.Icons.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(string filePath, CancellationToken cancellationToken);
}
