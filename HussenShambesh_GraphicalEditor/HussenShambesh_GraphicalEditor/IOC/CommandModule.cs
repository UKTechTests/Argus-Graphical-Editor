using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using HussenShambesh_GraphicalEditor.Interfaces;
using HussenShambesh_GraphicalEditor.Commands;
using HussenShambesh_GraphicalEditor.Entities;
using IOC;

namespace HussenShambesh_GraphicalEditor.IOC
{
    public class CommandModule : NinjectModule
    {

        public override void Load()
        {
            this.Bind<ICommandExecute>().To<CommandI>().Named(CommanType.I.ToString());

            this.Bind<ICommandFactory>().ToFactory(() => new NameInstanceProvider());
        }

    }
}
