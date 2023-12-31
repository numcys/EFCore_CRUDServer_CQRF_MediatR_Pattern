﻿using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers
{
	public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery,List<EmployeeModel>>
	{
		private readonly IDataAccess _dataAccess;

		public GetEmployeeListHandler(IDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery query, CancellationToken cancellationToken)
		{
			return Task.FromResult(_dataAccess.GetEmployees());
		}
	}
}
