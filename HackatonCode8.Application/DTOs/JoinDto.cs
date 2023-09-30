using HackatonCode8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonCode8.Application.DTOs;

public class JoinDto:IRequest<Response>
{
    public User User { get; set; }
    public Education Education { get; set; }
    public Interest Interest { get; set; }
}
