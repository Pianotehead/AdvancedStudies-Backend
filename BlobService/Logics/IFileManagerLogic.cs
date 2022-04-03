using BlobService.Models;

namespace BlobService.Logics
{    
    public interface IFileManagerLogic
    {
        Task Upload(ImageModel imageModel);
        Task<byte[]> Read(string filename);
    }
}
