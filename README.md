# SWLab-2 (Random-Queue-Generator)

This program gives you a queue that generates random turns for chosen number of people in it.

## How to Start

* First you need to download and install <a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0"> dotnet 6.0 SDK </a>

   check the installation with this command:
   ```
   dotnet --list-sdks
   ```

* Then Clone the project
* Go to the folder `firstAlgorithm`
* Open Terminal and run the code:

  ```
  dotnet run
  ```
* enjoy!

## How this program developed

1. The programs structure was in the first couple of commits in `main` branch.
1. After that developing of the program started in `firstAlg` branch.
1. After Two or more commits of developing the program a Pull Request was made to merge two branches.
1. Then a new branch called `updateFirstAlg` was made to make modifications on the program.
1. After Merging it like the last one I edited README on github a little bit and added a commit.
   because I am alone I couldn't create a conflict with another person and I did it inside the README file.
1. Then I changed README file on my Laptop a little bit that made the pull command turns into a conflict.
1. After resolving the conflict I commited the correct version. 
1. another branch called `fixbugs` created to correct some bugs and merged like others as well.

## Answer to questions
### پوشه‌ی .git چیست؟ چه اطلاعاتی در آن ذخیره می‌شود؟
پوشه `.git` جایی است که گیت در آن متادیتا و دیتابیس اشیا را برای پروژه ما ذخیره می‌کند. این یکی از مهم ترین پارت‌های گیت است و وقتی شما پروژه را کلون کنید درون کامپیوتر شما میاید.  

### منظور از atomic بودن کامیت و request pull چیست؟
اتمیک بودن کامیت به این معناست که شما می‌توانید از آن کامیت برگردید بدون آن که اثرات جانبی بد و پشیمانی‌ای به وجود آید. اگر یک کامیت از  تاریخچه کامیت‌های شما پاک شود ولی باعث شود تغییرات درست دیگر شما در پروزه پاک شود، آن کامیت اتمیک نبوده.
<br>
در گیت شما با `pull request` به بقیه می‌گویید که این سری تغییرات را در branchی جدا شما داده‌اید و اگر مورد تایید شما هست با برنامه اصلی ترکیب کنید.

### تفاوت دستورهای fetch و pull و merge را بیان کنید. مثال بزنید.
‌‌‌‌در گیت `git fetch` آپدیت‌های داخل کد را دریافت می‌کند ولی با کد اصلی ادغام نمی‌کند در حالی که اگر بخواهیم این تغییرات در ریپازیتوری اعمال شود باید `merge` کنیم اما `git pull` به صورت مستقیم یک `git fetch` انجام داده و سپس `merge` می‌کند و لازم نیست ما هر کار را جدا انجام دهیم. 
<br>
برای مثال اگر می‌خواید بدانید بقیه روی کد چیکار کردند ولی نمی‌خواهید فعلا کد خود که در حال توسعه‌اش هستید را دست بزنید می‌توانید از `git fetch` استفاده کنید ولی اگر کارتان تمام شده می‌توانید به صورت مستقیم از `git pull` استفاده کنید.

### تفاوت دستورهای rebase و clone را بیان کنید. مثال بزنید.
دستور `git clone` یک ریپازیتوری را کلون می‌کند و موقعی که شما می‌خواهید ریپوی لوکال خود را داشته باشید به درد می‌خورد. همچنین این دستور یک remote به نام `origin` درست می‌کند که باعث می‌شود این برنچ لوکال ما با remote active branch در تعامل باشد. 
<br>
اما `git rebase` کاری می‌کند که هر کامیتی که شما در برنچ فعلی خود دارید ولی در upstream نیست در فضای موقتی ذخیره شود تا برنچ شما همانند قبل این که تغییرات خود را شروع کنید شود. برای مثال از استفاده نیز اگر شما دستور `git pull -rebase` را بزنید، گیت تغییرات ریموت را می‌گیرد و تغییرات لوکال شما را عقب می‌برد و بعد از اضافه کردن تغییرات ریموت تغییرات شما را یکی یکی روی برنچ آپدیت شده میاورد. این مورد اگر کار در حال توسعه شما نیازی داشته باشد که دیگری توسعه داده خیلی به درد بخور است و می‌توان ازش استفاده کرد. 

### تفاوت دستورهای reset و revert را بیان کنید. مثال بزنید.
با دستور `git reset` ما می‌توانیم در برنچی که هستیم با حذف کامیت ها به کامیت های قبلی برگردیم. برای مثال با دستور `git checkout new-feature reset HEAD~2` اگر در برنچ `new-feature` ما 3 کامیت داشته باشیم با این دستور می‌توانیم به کامیت اول برگردیم و 2 کامیت قبلی را حذف کنیم.
<br> 
برخلاف دستور `git reset` که ما ممکن است در برنچی بعد از کامیت‌های `A` و `B` و `C` به این نتیجه برسیم که کامیتی که در قسمت `B` انجام دادیم باعث باگ شده یا تغییراتی را اضافه کرده که ما ‌نمی‌خواستیم؛ بنابرین ما می‌توانیم با دستور `git revert B` کاری کنیم که گیت تغییرات انجام شده در قسمت کامیت `B` را با نگه داشتن حداکثری کامیت `C` به ما برگرداند و درواقع کاری که می‌کند کامیت جدیدی مثلا به نام `B*` تولید می‌شود (بعد از کامیت `C`) که در این کامیت تغییرات `B` از بین رفته‌اند.

### منظور از stage و snapshot چیست؟
در گیت ما سه حالت برای دارایی‌های داخل ریپازیتوریمان داریم. یا `modified`اند یا `staged` یا `commited`. حالت چهارمی هم هست به نام `untracked` که چون در ریپازیتوری آورده نشده اند جزو آن 3 گفته نشد. وقتی ما فایلی را تغییر می‌دهیم یا همان `modified` می‌کنیم، بعدش با دستور `git add` آن را `staged` می‌کنیم که بدین معناست که ما این فایل تغییریافته را انتخاب کردیم که در ورژن فعلی خود به `commit snapshot` بعدی ما برود. 
<br>
در واقع `snapshot` یک حالت از یک فایل یا فولدر ما در پروزه در ***تاریخ مشخصی از زمان*** است که با کامیت‌ها مشخص می‌شوند.
