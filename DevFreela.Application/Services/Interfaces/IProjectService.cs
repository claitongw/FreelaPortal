using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        void Start(int id);
        void Finish(int id);
    }
}
