using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToDelete = await _studentRepository.GetByIdAsync(request.StudentId);

            await _studentRepository.DeleteAsync(studentToDelete);

            return Unit.Value;
        }
    }
}
