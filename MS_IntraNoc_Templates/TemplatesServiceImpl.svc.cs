using System;
using Izzi.Noc.Business.Interfaces;
using Izzi.Noc.Business.Objects;

namespace Izzi.Noc.Services
{
    public class TemplatesServiceImpl : ITemplatesServices
    {
        ITemplatesExtended templatesExtended;

        public TemplatesServiceImpl()
        {
            templatesExtended = new TemplatesExtendedImpl();
        }
        public bool existTemplateById(int templateId)
        {
            return templatesExtended.existTemplateById(templateId);
        }
    }
}
