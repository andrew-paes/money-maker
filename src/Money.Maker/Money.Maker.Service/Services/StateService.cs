using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Repositories;
using Money.Maker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Service.Services
{
    public class StateService : GenericService<State, StateRepository>, IStateService
    {

    }
}
