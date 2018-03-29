using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Globalization;

namespace InfinityMeshTask.Models.Database
{
    public class DatabaseInitilizer:DropCreateDatabaseAlways<MyDatabase>
    {
        protected override void Seed(MyDatabase context)
        {
            base.Seed(context);
            List<Blog> fayiz = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Now},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach(var s in fayiz)
            {
                context.blogs.Add(s);
            }
            User fayiz1 = new User() { name = "Fayiz Hamad", age = 28, email = "e.f.i_cet@hotmail.com", blogs = fayiz };
            context.users.Add(fayiz1);
            var Ahmed = new List<Blog>
            {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-03-22 , 20:48")
        },
                new Blog {title="blog2",summary="blog sumuury2",content="heeeeeeeeeeeeelloooooooowww2",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}
            };
            foreach (var s in Ahmed)
            {
                context.blogs.Add(s);
            }

            var Ahmed2 = new User { name = "Ahmed Kadric", age = 28, email = "Ahmedkadric@hotmail.com", blogs = Ahmed };
            context.users.Add(Ahmed2);

            

            var Ejub = new List<Blog>
            {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog2",summary="blog sumuury2",content="heeeeeeeeeeeeelloooooooowww2",publishDate=DateTime.Now},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Parse("2018-02-22 , 20:48")}
            };
            foreach (var s in Ejub)
            {
                context.blogs.Add(s);
            }

            var Ejub2 = new User { name = "Ejub Kadric", age = 28, email = "Ejubkadric@hotmail.com", blogs = Ejub };
            context.users.Add(Ejub2);

            var Yusuf = new List<Blog>
            {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog2",summary="blog sumuury2",content="heeeeeeeeeeeeelloooooooowww2",publishDate=DateTime.Now},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Parse("2018-02-22 , 20:48")}
            };
            foreach (var s in Yusuf)
            {
                context.blogs.Add(s);
            }

            var Yusuf2 = new User { name = "Yusuf Kadric", age = 28, email = "Yusufkadric@hotmail.com", blogs = Yusuf };
            context.users.Add(Yusuf2);

            var Kerim = new List<Blog>
            {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Now},
                new Blog {title="blog2",summary="blog sumuury2",content="heeeeeeeeeeeeelloooooooowww2",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}
            };
            foreach (var s in Kerim)
            {
                context.blogs.Add(s);
            }

            var Kerim2 = new User { name = "Kerim Kadric", age = 28, email = "Kerimkadric@hotmail.com", blogs = Kerim };
            context.users.Add(Kerim2);

            var Kemal = new List<Blog>
            {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}
            };
            foreach (var s in Kemal)
            {
                context.blogs.Add(s);
            }

            var Kemal2 = new User { name = "Kemal Kadric", age = 28, email = "Kemalkadric@hotmail.com", blogs = Kemal };
            context.users.Add(Kemal2);

            List<Blog> Muhamed = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Muhamed)
            {
                context.blogs.Add(s);
            }
            User Muhamed1 = new User() { name = "Muhamed Hamad", age = 28, email = "Muhamed@hotmail.com", blogs = Muhamed };
            context.users.Add(Muhamed1);
            List<Blog> Said = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Said)
            {
                context.blogs.Add(s);
            }
            User Said1 = new User() { name = "Said Hamad", age = 28, email = "Said@hotmail.com", blogs = Said };
            context.users.Add(Said1);
            List<Blog> Enes = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Enes)
            {
                context.blogs.Add(s);
            }
            User Enes1 = new User() { name = "Enes Hamad", age = 28, email = "Enes@hotmail.com", blogs = Enes };
            context.users.Add(Enes1);
            List<Blog> Semir = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Semir)
            {
                context.blogs.Add(s);
            }
            User Semir1 = new User() { name = "Semir Hamad", age = 28, email = "Avdo@hotmail.com", blogs = Semir };
            context.users.Add(Semir1);
            List<Blog> Avdo = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Avdo)
            {
                context.blogs.Add(s);
            }
            User Avdo1 = new User() { name = "Avdo Hamad", age = 28, email = "Avdo@hotmail.com", blogs = Avdo };
            context.users.Add(Avdo1);
            List<Blog> Admir = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Admir)
            {
                context.blogs.Add(s);
            }
            User Admir1 = new User() { name = "Admir Hamad", age = 28, email = "Avdo@hotmail.com", blogs = Admir };
            context.users.Add(Admir1);
            List<Blog> Ekrem = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Ekrem)
            {
                context.blogs.Add(s);
            }
            User Ekrem1 = new User() { name = "Ekrem Hamad", age = 28, email = "Ekrem@hotmail.com", blogs = Ekrem };
            context.users.Add(Ekrem1);
            List<Blog> Suleiman = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Suleiman)
            {
                context.blogs.Add(s);
            }
            User Suleiman1 = new User() { name = "Suleiman Hamad", age = 28, email = "Suleiman@hotmail.com", blogs = Suleiman };
            context.users.Add(Suleiman1);
            List<Blog> Abdullah = new List<Blog>() {
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-02-22 , 20:48")},
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now}

            };
            foreach (var s in Abdullah)
            {
                context.blogs.Add(s);
            }
            User Abdullah1 = new User() { name = "Abdullah Hamad", age = 28, email = "Abdullah@hotmail.com", blogs = Abdullah };
            context.users.Add(Abdullah1);
            List<Blog> Damir = new List<Blog>() {
                new Blog {title="blog3",summary="blog sumuury3",content="heeeeeeeeeeeeelloooooooowww3",publishDate=DateTime.Now},
                 new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-05-22 , 20:48")},
                 new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-04-22 , 20:48")},
                new Blog {title="blog1",summary="blog sumuury1",content="heeeeeeeeeeeeelloooooooowww1",publishDate=DateTime.Parse("2018-03-22 , 20:48")}
                

            };
            foreach (var s in Damir)
            {
                context.blogs.Add(s);
            }
            User Damir1 = new User() { name = "Damir Hamad", age = 28, email = "Damir@hotmail.com", blogs = Damir };
            context.users.Add(Damir1);

            context.SaveChanges();
        }
    }
}