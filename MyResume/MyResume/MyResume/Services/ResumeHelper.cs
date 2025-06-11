using Microsoft.EntityFrameworkCore.Metadata;
using MyResume.Domain.Interfaces;
using MyResume.Model.Response;

namespace MyResume.Services
{
    public class ResumeHelper
    {
        private readonly ILogger<ResumeHelper> _logger;
        private readonly IResumeDao _resumeDao;

        public Resume GetResume(int Id)
        {
            _logger.LogInformation($"ResumeHelper::Fetching resume for ID: {Id}");
            try
            {
                var resumes = _resumeDao.GetResumesAsync(Id).Result;
                if (resumes == null || !resumes.Any())
                {
                    _logger.LogWarning($"No resumes found for ID: {Id}");
                    return null;
                }
                //var resumeDto = AutoMapper.Mapper(resumes.FirstOrDefault(), new Resume());
                return new Resume();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching resume for ID: {Id}");
                throw;
            }
        }
    }
}
