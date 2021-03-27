using System;
using Acme.BookStore.Authors;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Ahthors 
{
    public class Author : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        
        public DateTime BrithDay { get; set; }
        public string ShortBio { get; set; }

        private Author()
        {

        }

        internal Author(
            Guid id,
            [NotNull] string name,
            DateTime birthDay,
            [CanBeNull] string shortBio = null) : base(id)
        {
            SetName(name);
            BrithDay = birthDay;
            ShortBio = shortBio;
        }
        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }
        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: AuthorConsts.MaxNameLength
            );
        }
    }
}
