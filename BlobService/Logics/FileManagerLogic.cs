using Azure.Storage.Blobs;
using BlobService.Models;

namespace BlobService.Logics
{
    public class FileManagerLogic : IFileManagerLogic
    {
        private readonly BlobServiceClient _blobServiceClient;

        public FileManagerLogic(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task Upload(ImageModel imageModel)
        {
            BlobContainerClient blobContainer = _blobServiceClient.GetBlobContainerClient("images");
            BlobClient blobClient = blobContainer.GetBlobClient(imageModel.ImageFile?.FileName);
            await blobClient.UploadAsync(imageModel.ImageFile?.OpenReadStream());
        }

        public async Task<byte[]> Read(string filename)
        {
            BlobContainerClient blobContainer = _blobServiceClient.GetBlobContainerClient("images");
            BlobClient blobClient = blobContainer.GetBlobClient(filename);
            var imgDownloaded = await blobClient.DownloadAsync();
            using (MemoryStream ms = new MemoryStream())
            {
                await imgDownloaded.Value.Content.CopyToAsync(ms);
                return ms.ToArray();
            }
        }
    }
}
