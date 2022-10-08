using System;
using AutoMapper;
using Bookstore.Common.Dto;
using Bookstore.Model;
using Bookstore.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.BusinessLogic.Services
{
    public class BookService: IBookService
    {
        private readonly BookstoreContext _context;
        private readonly IMapper _mapper;

        public BookService(BookstoreContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<BookDto> Get()
        {
            var books = _context.Books
                .Include(b=>b.Author)
                .Include(b=>b.CostBook)
                .Include(b=>b.AboutBook)
                .Include(b=>b.Provider)
                .Include(b=>b.PublishingOffice)
                .AsNoTracking()
                .ToList();
            var booksDto = _mapper.Map<List<BookDto>>(books);

            return booksDto;
        }

        public void Sync()
        {
            var books = new List<Book> {
                new Book
            {
                Name = "Тонкое искусство пофигизма",
                Img = "05.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description = "Современное общество пропагандирует культ успеха: будь умнее, богаче, продуктивнее – будь лучше всех. Соцсети изобилуют историями на тему, как какой-то малец придумал приложение и заработал кучу денег, статьями в духе \"Тысяча и один способ быть счастливым\", а фото во френдленте создают впечатление, что окружающие живут лучше и интереснее, чем мы. Однако наша зацикленность на позитиве и успехе лишь напоминает о том, чего мы не достигли, о мечтах, которые не сбылись. Как же стать по-настоящему счастливым?",
                    Weight = 285,
                    AgeLimit = 16,
                    PublicationYear = 2022
                },
                CostBook = new CostBook
                {
                    Price = (decimal)24,
                    CostDelivery = 6,
                    TimeDelivery = "3 день"
                },
                Author = new Author
                {
                    Name="Марк",
                    Surname="Мэнсон",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "Найди себя",
                Img = "01.jpg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Твёрдая",
                    Description = "Как понять, чего я действительно хочу? Есть ли способ избежать ложных целей, навязанных обществом или родителями? Можно ли верить себе, руководствоваться своими желаниями? И вообще – что такое \"я\"? Фамилия в паспорте, набор социальных ролей или что-то иное? Ответить на эти вопросы помогут двенадцать историй из практики психолога и бизнес-коуча Леонида Кроля.",
                    Weight = 380,
                    AgeLimit = 14,
                    PublicationYear = 2022
                },
                CostBook = new CostBook
                {
                    Price = (decimal)35,
                    CostDelivery = 4,
                    TimeDelivery = "1 день"
                },
                Author = new Author
                {
                    Name="Леонид",
                    Surname="Кроль",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "Ты в порядке",
                Img = "06.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description="Книга посвящена отношениям человека с собой и другими и освещает самые распространенные проблемы, с которыми люди приходит к психологу: неуверенность, неспособность отпустить прошлое, неумение собраться с силами, ревность, вина, зависть, безысходность, сожаление об упущенных возможностях, потребность в любви, раздражение на весь мир, горе потери...",
                    Weight = 520,
                    AgeLimit = 10,
                    PublicationYear = 2021
                },
                CostBook = new CostBook
                {
                    Price = (decimal)23,
                    CostDelivery = 3,
                    TimeDelivery = "5 день"
                },
                Author = new Author
                {
                    Name="Алина",
                    Surname="Адлер",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "Пиши, сокращай",
                Img = "07.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description ="Максим Ильяхов и Людмила Сарычева на конкретных примерах показывают, что такое хорошо и что такое плохо в информационных, рекламных, журналистских и публицистических текстах. Как писать письма, на которые будут отвечать, и рассылки, от которых не будут отписываться. Как создавать действенные и не вульгарные рекламные объявления. Как излагать мысли кратко, ясно и убедительно: без языкового мусора, фальши и штампов. Следуя рекомендациям в книге, вы научитесь писать понятно, увлекать читателей и добиваться доверия. Это обязательная книга для копирайтеров, авторов и редакторов, а также дизайнеров, программистов, менеджеров, предпринимателей, руководителей, служащих и всех, кто использует текст в работе.",
                    Weight = 440,
                    AgeLimit = 14,
                    PublicationYear = 2021
                },
                CostBook = new CostBook
                {
                    Price = (decimal)35,
                    CostDelivery = 1,
                    TimeDelivery = "2 день"
                },
                Author = new Author
                {
                    Name="Алина",
                    Surname="Адлер",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "Мужские правила",
                Img = "08.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description="Марк Мэнсон, автор супербестселлеров \"Тонкое искусство пофигизма\" и \"Всё хреново\", написал практическое руководство для мужчин о том, как привлечь и удержать внимание женщин. От тысяч других пособий на ту же тему оно отличается как любовь королевы от предложения секса за деньги на привокзальной площади.",
                    Weight = 440,
                    AgeLimit = 14,
                    PublicationYear = 2021
                },
                CostBook = new CostBook
                {
                    Price = (decimal)24,
                    CostDelivery = 3,
                    TimeDelivery = "3 день"
                },
                Author = new Author
                {
                    Name="Марк",
                    Surname="Мэнсон",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "Семь навыков высокоэффективных людей",
                Img = "09.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description ="Эта книга – мировой супербестселлер, работа № 1 по теме личностного роста. Она оказала большое влияние на жизни миллионов людей во всем мире, включая Билла Клинтона, Ларри Кинга и Стивена Форбса. Половина крупнейших мировых корпораций, входящих в рейтинг Fortune 500, посчитали своим долгом ознакомить своих сотрудников с философией эффективности, изложенной в \"Семи навыках\".",
                    Weight = 470,
                    AgeLimit = 14,
                    PublicationYear = 2019
                },
                CostBook = new CostBook
                {
                    Price = (decimal)27,
                    CostDelivery = 1,
                    TimeDelivery = "1 день"
                },
                Author = new Author
                {
                    Name="Стивен",
                    Surname="Кови",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
                new Book
            {
                Name = "1984",
                Img = "10.jpeg",
                Language = "Русский",
                Genre = "Психология",
                AboutBook = new AboutBook
                {
                    Cover = "Мягкая",
                    Description = "\"1984\" – последняя книга Джорджа Оруэлла, он опубликовал её в 1949 году, за год до смерти. Роман-антиутопия прославил автора и остаётся золотым стандартом жанра. Действие происходит в Лондоне, одном из главных городов тоталитарного супергосударства Океания. Пугающе детальное описание общества, основанного на страхе и угнетении, служит фоном для одной из самых ярких человеческих историй в мировой литературе.",
                    Weight = 510,
                    AgeLimit = 18,
                    PublicationYear = 2021
                },
                CostBook = new CostBook
                {
                    Price = (decimal)20,
                    CostDelivery = 2,
                    TimeDelivery = "2 день"
                },
                Author = new Author
                {
                    Name="Джордж",
                    Surname="Оруэлл",
                    Patronymic="Иванович",
                },
                PublishingOffice = new PublishingOffice
                {
                    Name = "Альпина Паблишер",
                    Phone="+375336600928",
                    Address="г. Минск"
                },
                Provider = new Provider
                {
                    Name = "Ez",
                    Phone="+375292342342",
                    Address="г. Пинск"
                }
            },
            };
            _context.Books.AddRange(books);
            _context.SaveChanges();
        }
    }
}

