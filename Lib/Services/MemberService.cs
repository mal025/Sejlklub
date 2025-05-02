using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;
using Lib.Repo;

namespace Lib.Services
{
    public class MemberService
    {
        private IMemberRepo _memberRepo;

        public MemberService(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }

        public List<Member> GetAll()
        {
            return _memberRepo.GetAll();
        }

        public void Add(Member member, string path)
        {
            _memberRepo.Add(member, path);
        }
        public Member GetByID(int id)
        {
            return _memberRepo.GetByID(id);
        }

    }
}
