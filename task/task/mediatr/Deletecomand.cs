using MediatR;

namespace task.mediatr
{
 
    public class Deletecomand : IRequest
    {
        public long Id { get; set; }
    }
}
