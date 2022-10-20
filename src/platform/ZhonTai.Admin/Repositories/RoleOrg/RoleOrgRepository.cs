﻿using ZhonTai.Admin.Core.Consts;
using ZhonTai.Admin.Core.Db.Transaction;
using ZhonTai.Admin.Core.Repositories;
using ZhonTai.Admin.Domain;
using ZhonTai.Admin.Domain.RoleOrg;

namespace ZhonTai.Admin.Repositories;

public class RoleOrgRepository : RepositoryBase<RoleOrgEntity>, IRoleOrgRepository
{
    public RoleOrgRepository(UnitOfWorkManagerCloud uowm) : base(DbKeys.AppDb, uowm)
    {

    }
}