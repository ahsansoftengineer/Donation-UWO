using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Common
{
  [ApiExplorerSettings(IgnoreApi = true)]
  public class FileUploderz : AlphaController<FileUploderz>
  {
    private readonly IWebHostEnvironment hostEnv;
    public FileUploderz(
      ILogger<FileUploderz> logger, 
      IMapper mapper, 
      IUnitOfWork unitOfWork,
      IWebHostEnvironment hostingEnvironment
      ): 

      base(logger, mapper, unitOfWork)
    {
      hostEnv = hostingEnvironment;
    }

    public async Task<IActionResult> UploadFile(IFormFile file)
    {
      if (file == null || file.Length == 0) return BadRequest("Invalid file");

      // Specify the directory where you want to save the file
      //var uploadDirectory = "D:/Directory";
      var uploadDirectory = hostEnv.ContentRootPath + "/Filezs/ouz/";
      Console.WriteLine(hostEnv.ContentRootPath);

      // Create the directory if it doesn't exist
      if (!Directory.Exists(uploadDirectory))
        Directory.CreateDirectory(uploadDirectory);

      // Generate a unique file name (e.g., using a Guid)
      var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

      // Combine the directory and file name to get the full path
      var filePath = Path.Combine(uploadDirectory, fileName);

      // Save the file to the specified path
      using (var stream = new FileStream(filePath, FileMode.Create))
      {
        await file.CopyToAsync(stream);
      }

      return Ok("File uploaded successfully");
    }
  }
}
