using Sabirzyanov320ExamRegistration.Data;
using Sabirzyanov320ExamRegistration.Data.Entities;

namespace Sabirzyanov320ExamRegistration.Services;

public static class AuthorizationService
{
    public static User? AuthorizedUser { get; set; }
}