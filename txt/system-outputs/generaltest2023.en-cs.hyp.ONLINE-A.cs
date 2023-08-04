Rozsekaná verze Jedi Knight padala, protože volala funkci mimo konec vtable.
Ukázalo se, že se předpokládalo, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má další metody připojené na konci ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože to vytváří výřez pouze pomocí objektu Direct3D, nikoli objektu Direct3D3.
Teď chápu, že v praxi je IDirectXObject2 typicky řádnou nadmnožinou IDirectXObject, beze změněných signatur funkcí a nových metod přidaných pouze na konec.
To však neplatí univerzálně; V těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Každopádně, protože to zde platí, abych to opravil, musel jsem rozšířit implementaci viewportu tak, aby obsahovala metody IDirect3DViewport3 tak, aby volání nového bylo platné.
Předpokládejme pro účely argumentace, že věda se alespoň zčásti skládá ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoli teorii, kterou by mohly podporovat.
I kdyby byla pravda, že taková fakta ve vědě existují, je stále možné tvrdit, že vědecká fakta jsou zatížena teorií.
Vědecká fakta jsou výsledkem experimentů.
Experimenty nevytvářejí fakta na tomto čtení, ale volba, které experimenty provedou, kontroluje, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou být výsledkem pouze experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho donucení, aby se jinak uskutečnily.
Toto je velmi stručný nástin přijatelného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvednout to tento víkend.
Hledal jsem dobré auto prvního auta; a opravdu miluji estetiku 80. let.
Již na cívkách a snížené světlé výšce.
Udělal jsem malý výzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že nejsou ve srovnání s nimi rychlé
#Venting do fediverzního období.
Dnes večer jsme s domácím partnerem šli do obchodu s alkoholem pro pár piv a láhev bubu.
Když jsme se šli podívat, pokladní je poměrně zřejmá #trans žena.
Já, v kraťasech a manželském šlehači, a The Domestic Partner, všichni načapaní a s novým účesem, který on sám popsal jako "díky kterému vypadám jako neonacista".
Její tělo okamžitě ztuhlo a v očích měla výraz strachu.
A pak jsme jen... zaplatil za naše věci.
A poděkoval.
A já řekl, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale skutečnost, že se nejprve bála KURVA JE NA PRD A JÁ TO NENÁVIDÍM.
Tohle je nejhloupější časová osa a nenávidím ji dot com.
Donaldu Trumpovi nic nebrání v tom, aby kandidoval na prezidenta, když byl obviněn, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by si odpustil dostat se z vězení.
Ale nemůže se omilostnit ze státního vězení.
Chce to guvernéra státu.
Dva zúčastněné státy jsou New York a Georgia.
Jeho guvernér Kemp nepochybně Trumpovi udělí milost, pokud bude usvědčen nebo dokonce obžalován Fannie Willisovou z okresu Fulton.
NY je nejlepší nadějí na zodpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze redukovat na vysílání signálů s kontextově nezávislým významem.
V této práci, založené na variantě klasického Lewisova (1969) signalizačního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takové objevení dostatečný.
Současně studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové rozlišování významů symbolů.
Ukazujeme, že environmentální omezení výběru referentu příjemce mohou být jednostranně využita odesílatelem, bez možnosti jednoznačnosti na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Domníváme se, že kontextově závislá komunikace je situovaný vícevrstvý jev, zásadně ovlivněný vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil setkání s Penny a Nicholasem z Ashanti Development o víkendu, abychom si popovídali o jejich pokroku.
Ashanti Development spolupracuje se stále rostoucím počtem komunit v regionu Ashanti v Ghaně již téměř 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, které jim umožňují začlenit a podpořit svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil památných šest měsíců po boku Nicholase podporou řady projektů.
Když jsme se o víkendu setkali, byl jsem nadšený, když jsem slyšel o pokroku, zejména pokud jde o výsadbu stromů a podporu farem.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšení výnosů plodin prostřednictvím řady intervencí, od podpory nákupem vybavení až po školení.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je podzimní armáda, která může zničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Prodejna UPS v mém okolí mi nedovolí napsat štítek nebo napsat na krabici.
Musí vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou to jde a kdo to posílá.
Musím poslat e-mailem nějakou náhodnou adresu s neformátovanými údaji, aby si úředník mohl přečíst e-mail a zadat jej do svého systému pro tisk štítku.
A vždy mi účtují 2,25 dolarů za toto "pohodlí".
Druhý den ráno se nemůžu přenést přes ostudné předstírání žurnalistiky veřejné služby Chrise Lichta na CNN.
Byla to urážka, jako symbolický antidemokratický festival lží a křivdy 6. ledna, sebedestruktivně pořádaný americkými médii.
OSTUDNÉ PUBLIKUM.
Licht SOUHLASIL s republikánským publikem!
Kdo prověřil a vybral jednotlivce?
Je tam příběh, který by měl být hlášen.
Hodnocení - hledání bludné nezodpovědnosti toho všeho.
Nedá se to opakovat.
Mám velmi průvanový sklep, což v podstatě znamená, že mohu získat spoustu hlodavců, kteří hledají útočiště.
V posledním měsíci se objevilo mnoho známek většího počtu hlodavců, což bylo mimořádně překvapující, protože je jaro a myslel bych si, že se odváží ven se změnou počasí.
Přesto jsem měl kolem sebe rozmístěnou hromadu obyčejných starých pastí a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, zatímco ho myši laskavě olizují dočista.
Včera večer jsem se konečně nabažil této rutiny, vyčistil jsem všechny pasti arašídového másla a přelepil na ně pistácie.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř všechny "humánní" pasti na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť spokojen s jejich zabíjením, ale nebudu komentovat etiku zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se balí do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jistě, snížili daně z podnikání.
Snižují však také granty a daňové úlevy, které povzbuzují větší podnikatelskou aktivitu.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Zjistil tvrdou cestou, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělávají své peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud odhánějí lidi.
To platí i teď, když je goatse.cx pryč, i když by to byl těsný závod ke dnu mezi kozou a, řekněme, khou.com, kde jsem se snažil sledovat video, které mi Wendy poslala.
V prvním vlaku se dnes kontrolor podíval na naše jízdenky a řekl "dlouhá cesta!"
"Jo a dneska se vrátím," řekla jsem.
"Právě ho vysadím v Glasgow," pokusila jsem se vysvětlit a ukázala na svého společníka.
"Není tu něco, co byste slyšeli často, 'prostě ho vysadím v Glasgow'," řekl lístař.
Je to věc, kterou jsem nikdy předtím neřekl.
Věc, o které mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který nikdo opravdu nechce, kromě fanatiků, kteří jsou v něm.
A jsou to opravdu blázni.
Nemůžeme jim dovolit, aby se zmocnili naší země.
Je čas se bránit.
Jděte ven a protestujte.
Sežeňte si nějaké nálepky na náraznících, které jsou proti Trumpovi, a nalepte je všude.
Křičte zpátky na ty, kteří by se nás snažili přemluvit.
To není normální.
To není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak vykašlává z druhé strany ulice bouři s covidovým hlenem.
Tak jsem spěchal, abych se dostal do svého bytu, abych se mu vyhnul, ale stále se mu podařilo dohonit mě, aby si popovídal.
Přísahám, že lidé nakažení covidem jsou zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné jít na veřejnost nebo spěchat k lidem, když vykašláváte hlenovou bouři.
Opakuji. Není společensky přijatelné šířit svou covidovou hlenovou bouři všude!!
Psaní zázraků 5/11: Směje se váš MC nebo pláče více?
Abe skrývá své smutky a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví hrubý humor.
Jan vám ublíží dřív, než vám dá najevo, že je zraněná, a nejvíc se směje, když je to vzhůru nohama.
Mio ví, že smutek je neustálým společníkem života.
Po 4 000 utrpení se Yl ocitá na místě lásky a má obrovské pocity, že neví, co s tím, takže je tu spousta obojího.
#CNN prostě musí zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo v této ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "manažer" kabelových zpráv vyzval k tomu, aby tomu tlustému, prolhanému zločinci poskytl tolik vysílacího času?
Tlaková výše bude přetrvávat až do začátku příštího týdne.
Studená fronta by měla dorazit do poloviny příštího týdne.
Časně ráno infračervená satelitní a povrchová pozorování naznačila rozšiřující se oblast nízkých stratuů a nerovnoměrných <URL>vrstev
Podivínský student Arnie Cunningham se zamiluje do Christine, rezavého Plymouthského Furyho z roku 1958, a stane se posedlý obnovením klasického automobilu k její bývalé slávě.
Jak se mění auto, mění se i Arnie, jehož nově nabytá sebedůvěra se mění v aroganci za volantem své exotické krásy.
Salesforce Partner
Codleo je jedním z nejlepších Salesforce partnerů, který nabízí nejlepší Salesforce služby šité na míru potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije jeho odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, aby vaše firma prosperovala v ekosystému Salesforce.
Jedna z nejbláznivějších částí mých sousedů, kteří se obracejí proti mně, je přemýšlení o tom, kolik úsilí to stojí být nepřátelský.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíte to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře před nosem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A stále nemám ponětí, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu po dobu 6 + let.
Toto plavidlo je zakázáno.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě irelevantní.
Můžete ji zabít, pokud můžete.
Ale na palubě této lodi často letí jiný jedinec.
Kdyby měl umřít... Důsledky by byly... významný.
Hodně mě trápí táta.
Zde je (o něco delší než) rychlokurz v tom, co myslím tátou:
Není to můj termín, je to termín používaný k popisu, kdy je příběh nebo herní mechanika postavena na ústředním protagonistovi (obvykle starším, obvykle mužském), který řídí nebo hlídá jinou osobu (často mladší).
The Last of Us je snadným a kanonickým příkladem tatínkovství.
Joel využívá své dovednosti a schopnost provádět (extrémní) násilné činy ke splnění úkolu, který je kódován jako "péče".
Táta obvykle předpokládá, že řešením situace, kdy rodičovská postava musí pečovat o dítě nebo dítě zastupovat, je drtivá síla a použití této síly k vynucení velmi specificky tvarované dynamiky moci.
Tátství nahlodává možnost společného řešení a často zcela ignoruje nebo podkopává jakoukoli svobodu jednání, kterou dítě má.
Tímto způsobem je táta zástupcem mnoha neoliberálních ideálů; Zejména nápady jako bootstrapping a soběstačnost jako konečný cíl / ukazatel úspěchu.
Zde je stručný přehled toho, jak používat naše webové stránky.
- Rozesíláme oznámení, když se letenky dostanou do prodeje.
- Poskytujeme odkazy na to, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Více podrobností je v celém blogovém příspěvku.
- Udržujeme seznam příkladů rezervačních dat pro každou nabídku, kterou zveřejňujeme, a aktualizujeme tento seznam několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto jim nepředstavitelný strach, hrůza a vysídlení zanechaly neviditelnou jizvu traumatu.
Toto úterý se předsedkyně von der Leyenová setkala v Kyjevě s první dámou Olenou Zelenskou, aby projednala, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli podporu v oblasti duševního zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže projít touto cestou.
Hromada nablýskaných nových dobrot v #dart
Postupem času se šipka stala mým go-to pro rychlé uživatelské rozhraní.
S #flutter je radost pracovat a mají #mobx pro snadné řízení prodejny.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, flutter je opravdu špatný, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i flutter web cíl naštve).
Umožňuje se však rychle pohybovat, a proto je ideální pro malé hacky.
Echidna s ametystem a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou stavbu a svalnaté.
Jejich ocas je extrémně tlustý.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové brýle cateye.
Jejich nejzajímavějším rysem jsou jejich dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Být schopen skákat opravdu vysoko, trhat obyčejné lidi na kusy, používat strašidelné magické síly a doplňovat zdraví hodováním na nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové, aby vypadali špatně - všichni ...
Zdálo se mi, že moji rodiče hrají mou porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mé mámě líbila logická hra, kterou jsem vyrobil před lety, a většinu tajemství našla sama, takže nebyla jen mámou, když řekla, že se jí to líbí.
Takže možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a / nebo hokkienu, z nichž ani jeden nevím vůbec.
Hádám, že budu muset zjistit, zda je Bing nebo Google lepší v překladu špinavých gay sexuálních hříček.
Chvíli jsem si pohrával s touto myšlenkou:
Duševní zdraví je často považováno za něco odděleného od "běžného" zdraví.
Proč?
Protože se to děje v mysli a zdá se to méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku, stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce uznáván TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně "skutečné" než fyzické zdraví, cítím, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více se tvrzení "Moje pohlaví je mužské, mé pohlaví je ženské" zdá zjednodušující a nepřesné.
Skoro to vypadá jako přenechání části argumentu TERFům.
Mám pocit, že být trans znamená být "biologicky nebinární".
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení "nebinární" by mělo být rozšířeno z pouhého genderového termínu, který se používá při odkazování na pohlaví.
Poslouchal jsem díla @iotar
V restu tohoto tajemného kolektivu je spousta dobrých věcí.
Jako krauty nálady a jiná světská pop music a radiofonické dílny a všechno možné.
Velmi stojí za to vyzkoušet.
Také FWIW se mi líbí rozhraní archive.org mnohem víc než desktopové #bandcamp \- Nemám tušení, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrát s Flutterem.
Nerad bych založil své podnikání na technologii od společnosti Google, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého zážitku napříč platformami a to ukazuje.
(A také: Web je nyní do značné míry věcí Google, bohužel)
Také se prosím zdržte toho, abyste mi říkali, že aplikace google / flutter nasávají iOS a macOS.
Cross platform je těžké, pokud to chcete dělat dobře.
To vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Objevilo se několik velmi malých obtíží.
Nic, co by spustilo poplašné zvony, ale přesto jsou řešeny.
Příští týden bude vydána malá aktualizace, která je opraví.
Většina včerejška byla věnována instalaci nové aktualizace pro některé zákazníky a každý, kdo tuto pomoc potřebuje, by ji měl již dostat.
Hezký den!
Technická zpověď: Nemohu zabalit hlavu kolem Grafana & Prometheus, alespoň z hlediska metrik serveru / aplikací a monitorování.
Nevím přesně, proč na to můj mozek nemůže přijít; Je možné, že nástroje jsou tak široké a vágní, že můj mozek prostě zablokuje kvůli "příliš mnoha možnostem".
Chci vytvořit řídicí panely.
Grafana vypadá hezky.
Mozek bez práce.
Takže s blížící se novou úrovní #FFXIV raidu jsem si dlouho říkal "člověče, rád bych zkusil pořádný raiding, ale Party Finder mi přijde jako bordel a nikdy nenajdu statika, která by mě měla."
Tak jsem si řekl, zašroubuj to!
Udělám si vlastní statiku!
Plná lidí, kteří jsou příliš dychtiví na to, aby se pokusili připojit k statickému nájezdu, bez očekávání, že budou vůbec dobří!
K dispozici je... V žádném případě by to pravděpodobně nefungovalo!
... A tak jsem se ocitl v situaci, kdy jsem musel vyřešit soupisku raidových skupin.
V mládí jsem byl nenasytný čtenář.
Pak život rozdrtil mou duši a ztratil jsem veškerou vášeň pro fikci a skvělé vyprávění.
Ale po ~desetiletích~ čtení téměř nic (s výjimkou funkčních non-fiction věcí souvisejících s prací a příležitostné svépomocné knihy) jsem si stanovil cíl přečíst 23 knih v roce 2023.
Nyní jsem na knize # 31 a je to jen květen.
Jsem zpátky, zlato!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou přišlo v soukromí pár lidí a řekli: "Podívej, kvůli vší tvé práci ti dám tuhle sumu peněz."
Chci, aby tyto společnosti, které zprostředkovávají transakce, vysvětlily svým zákazníkům, jak nastavují svá procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobré čtvrtletí, budou.
Je nebezpečné vpouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, prodiktátorská pravice... V tom je nebezpečí.
Deportujte bílé supremacisty.
Jsem tak unavený z titulků, které tvrdí, že "Práce na dálku je mrtvá." nebo že "Práce na dálku byla neúspěšným experimentem".
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno clickbait, ale znepokojuje mě to o vedoucích pracovníků a manažerů, kteří čtou tyto články.
Před rokem 2020 existovala práce na dálku.
Stále budou existovat pracovní místa, která lze v dohledné budoucnosti provádět na dálku.
Práce na dálku je povolena.
Umožňuje lidem pracovat v pohodlných prostorech a ne v dusných, hlučných kancelářích.
Umožňuje přístupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim zabírá čas od dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a pokuste se pochopit, jak vaši zaměstnanci skutečně pracují.
#WFH #business #neurodiversity
Nejsou to jen konzervativci versus progresivisté, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Je to válka mezi pro-lidmi a anti-lidmi," řekl.
Parkerová se zmínila o potratech a nutkání moderních městských žen odkládat děti kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
"Vy jste uhlík, který se snaží snížit."
Takže stejně jako od začátku pro všechny mé narozeniny v minulosti, vždy jsem měl drsné.
Kdykoli se objevil květen, bál jsem se, že se pokusím oslavit svůj bday.
Vždycky se něco stane, pokazí se nebo prostě skončí stresující a depresivní.
Bojoval jsem v průběhu let, abych se dostal z tohoto myšlení a měl lepší dny.
Trvalo to roky, kdy jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si svůj den bez obav.
A dnešek se již stává skvělým dnem!
Zima je v této malé části Velkého jižního světa vzdálena 30 dní.
Ale nemůžu být oklamán!
To je začátek.
Déšť padá a zatímco / dokud není zmrzlý, nebudete v něm tančit!
Je to skvělý den na objednání dodávky zmrzliny.
Byla to jedna psí noc a ten pejsek nevstával z postele, ani na "Psí snídaně - snídaně pro psy!"
Podšívku zapnu do cyklistické bundy - pro případ, že bych ji potřebovala uvnitř.
Víte o výkonném způsobu, jak může webová komponenta reagovat na přidání nebo odebrání z dokumentu?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Jedná se většinou o sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
V současné době používáme hack MutationObserver.
U výkonu nesledujeme celý dokument.
Vytvoříme odpojeného dočasného rodiče, nainstalujeme tam MO a pozorujeme, jak se odděluje (tedy připojen jinde).
Casper the #rat je dnes absolutní jednotkou.
Myslím, že moje nová práce pro něj byla dobrá - dva volné toulky denně, zatímco pracuji, v poměrně předvídatelných časech.
Konečně jsem dostal dobrou visící fotku, takže si mohu být jistý, že není tlustý.
(V #rats může být příliš vysoký tělesný tuk špatný pro jejich zdraví.)
Není.
Je úplně roztrhaný z toho, že dvakrát denně pochoduje po mé kanceláři.
Nemám váhu, abych ho vážil, ale má pocit, že má hodně přes kilo.
Mám obrovskou radost, když vidím, jak se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1) Drobné úpravy rozvržení mapy Hel's Fighters.
Menu mapy je navíc plně funkční!
2) Byl připojen systém odměn za měnu.
Zítra bude testován různými bitvami.
Deštivé dny!
Minulý týden udělal tunu a cítil se mnohem lépe o položkách v terénu.
Všechny límce, kapusta, chard je transplantován.
Plánuje se nastavit v salátu v Penn na 6řádkovém vzoru a uvidíme, jak se to porovná s vysíláním semenných lůžek.
Jarní hrášek v Gilpinu se objevuje, takže je třeba nastavit mřížoví.
Také je třeba tam zasadit salátovou řadu, aby se integrovaly řezané zeleniny v obou vyškolených posádkách na zavlažování, přípravě postele a přesazování, což je 90% nesklizňových dovedností
Je rok 2023 a stále vidím, že lidé s iPhony se aktivně vyhýbají používání Apple Maps.
Apple Maps přichází standardně s iOS, a přesto by lidé šli z cesty, aby si stáhli a nainstalovali Mapy Google na své iPhony.
Netuším proč.
Zvědavý jsem si udržel otevřenou mysl, abych porovnal, jak Google Maps a Apple Maps porovnávají, na mém testovacím zařízení iPhone (můj denní ovladač je zařízení Android, takže je vzácné, že používám iPhone).
Zkušenost s dodržováním pokynů byla na Apple Maps mnohem lepší ve srovnání s Mapami Google.
Apple Maps vyhrává.
Tak proč lidé skáčou přes další obruče, aby nainstalovali Mapy Google?
Ani nápad.
Je možné, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že je Vyhledávání Google integrováno s Mapami Google?
Ani nápad.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch toho, aby se koncovým uživatelům neuvolňovaly odpadky, a Apple královsky se podělal se svými Apple Maps, když vyšel v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z ní dělá dobrého skladovatele bohatství tak dlouho, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a potřebuje vyměnit.
Mnoho ppl si myslí, že doslova vlastní zemi, když si koupí kus.
Není tomu tak.
V Číně si můžete pronajmout pouze půdu.
Nejsou tak hloupí, aby prodávali navždy.
Vláda může tyto politiky změnit, kdykoli chce.
Země je dočasná.
Zdá se nepředstavitelné, že by vám jednoho dne mohla být odebrána půda, když sledujete australské a americké mediální kanály, ale to je proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl myslela určitým způsobem.
Vláda jim půdu jednoho dne velmi snadno a rychle vezme, pokud to bude chtít.
A hádejte co?
Nikdy nedávalo smysl, jak může ppl držet půdu na úkor ostatních.
Jednoho dne se to musí odnést.
To je důvod, proč Číňané povolují pouze pronájmy.
Už jim došly pozemky.
K úspěchu, k uskutečnění snů, přátelství, k jednoduchému, ale pravdivému!!
Všem investorům tam venku připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si prostých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm#geolog #entrepreneurship #sustainability #success #friendship #toast #dreams
Často žasnu nad lidskou schopností být "tak" na sebe, když jsem zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a vinou ve světě, kde je "úspěch" tak často udělován lidem zodpovědným za nejhanebnější činy...
Všichni jsme takoví chaotická zvířátka.
Ale jemné zoufalství nad naším nepořádkem je zásadní - protože nám dává více prostoru k řešení ruin všude kolem.
Tak se snaž nezapomenout, co?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: "Na rychlosti psaní nezáleží!"
nebo "Modální editoři jsou dnes k ničemu" :morty:
Já, extrahování funkcí mých #Axum projektů do sdílených knihoven: "Hold my keyboard" :p artyparrot: :helix: :ferrisdance:
Nejste si jisti, zda je to nejlepší přístup ke sdílení, ale zatím se mi líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva tohoto týdne na Revelations je Zůstaňte vzhůru celou noc.
Už několik dní si pohrávám s tímto kouskem na hlavě.
Je to rozhodně více romantika než špína.
Možná jsem četl mnoho románků s nemožnými "setkat se s roztomilými" a toto je výsledek, ale líbí se mi to.
Také jednoho dne udělám míli vysoký orgasmus, možná ne se str
Nesouhlasím s tím, že #Mastodon je obtížné nastavit.
Běžné, opravdu to není tak těžké.
Je však obtížnější najít lidi, které byste mohli sledovat a vytvářet časovou osu.
Přál bych si, aby existovalo doporučení "koho následovat".
Ale kromě toho to není těžké - pokud používáte aplikaci 3rd, jako je Elk a / nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá a necítí se dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do něj dostali, a pravděpodobně budete potřebovat dobrou aplikaci, abyste #UX zlepšili.
Nevím, jestli je prevence možná, ale stojí za to vyzkoušet.
Čtyři kroky, které nastiňuji, jsou k diskusi, s určitým pokrokem v každém z nich:
Popis: názvy incidentů chování lidských algoritmů, které odpovídají za algoritmy a lidi.
Vysvětlení: vysvětlení obou stran vzájemného vlivu
Předvídání: předvídání škod dříve, než k nim dojde (i když po minutách)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých mezí důvěry
Nesledoval jsem radnici CNN, ale zdá se, že Trump říká přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne tlačítko Odeslat na svém telefonu.
I kdyby je neřekl na radnici, všichni v Americe je stejně uslyší, opakovaně, ode dneška do listopadu 2024.
To stále není důvod dát mu jiné místo, ale škoda je zveličována.
Vyhraje primárky.
Nemůžeme ho odradit.
Je tady a bude říkat tyhle věci bez ohledu na to, co se děje.
Přihlásil se do čekací listiny Google "AI Test Kitchen" a dostal se do stejného dne.
V tuto chvíli je to velmi ohromující.
"MusicLM Demo" je mírně zajímavé.
Můžete požádat o konkrétní hudební skladbu jako "jazz se sólem na trubku v 5/4 tempu" a po několika sekundách vám vygeneruje dvě stopy.
Zdá se, že rozumí tempu, ale... Hudba je prostě... Nic extra.
Házet vše, co máte, přes plot v reakci na GPT není ono.
Zkuste více Google.
Je to divné dělat vzpírání, ale také nemáte ponětí, co je vaše one-rep-max, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám ve své ložnici bez spottera nebo dokonce stojanu na závaží.
Jen já a činka se spoustou závaží.
Na posteli tlačím na lavičku.
Pokud se pokusím zjistit své maximum jednoho opakování, nemusím vlastnit dostatek závaží, abych se dostal na maximum, nebo naopak, mohlo by mě to vážně zranit / zabít.
Každopádně, zatížení dnes stoupá.
Stále se cítí dobře.
Přísahám, že burrata před pěti lety neexistovala
To je moje osobní věc s Mandelovým efektem.
Nikdy jsem to neviděla v kuchařce.
Nikdy jsem to neviděl v luxusním hokynáři nebo v některém z italských lahůdek.
Nikdy jsem neviděla, že by to něčí máma udělala, nebo mi to strčilo na večírku, nebo jsem neviděla, že by se to objevilo ve spojení s něčími eskapádami nebo pečením
Prostě se jednoho dne objevila a najednou byla všude dostupná.
Vstoupil jsem do dimenze burrata.
Drakeův stárnoucí iPad se rozdává, takže je na trhu pro nový tablet.
Protože jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo tablet Linux, který miluje?
To by bylo hlavně pro prohlížení webu, příležitostné e-maily a některé hry.
V letech 1998-06 Gamefan, v souvislosti s dlouhým vývojem první Unreal hry, Jason Schrieber komentoval:
"Dobrá hra je pozdě, dokud se nedostane.
Špatná hra je špatná navždy."
Byl to tedy Epic, kdo to vymyslel?
Můžeme jít dál.
Dřívější vydání GamePro 1997-11 obsahuje citaci s mnohem větší nejednoznačností,
"Nebo, jak říká slogan z oboru: Pozdní hra je pozdě jen do té doby, než je odeslána.
Špatná hra je špatná po zbytek života."
Je to tedy tak pomíjivé?
Pouhá "fráze" bez jasného původce?
Smoky, můj 10 měsíční pes Domestic Blue kotě, hrající si s červeným gumovým komfortním zařízením Apple Pencil zakoupeným od Amazonu, utekl před několika měsíci.
Hrdě ji nosí v ústech po celém domě a já se musím v duchu smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jste udělali celou okružní cestu na novém vlaku ICNG.
Moc se mi to líbí.
Zvláště kočáry s většími okny.
Existují oblasti, které by mohly použít nějaký lesk.
Konkrétně nedostatek košů a nedostatek značek, které by vysvětlily význam barev osvětlení.
Opravte tyto drobné problémy a pak můžeme mít více z nich, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Jedno pravidlo pro každého zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo stojí ve frontě, mohl dostat do rukou nástěnku.
Můžete si koupit JEDNU z výše uvedených desek, ne jednu od každého.
Neexistují žádná omezení nákupu Picos nebo jiného zboží.
Včera jsem se nejlépe bavil se svým přítelem a bývalým kolegou rabínem.
Navštívili jsme pár hodin na mé verandě.
Taková přátelství překračují rozdíly.
Všichni máme co vyprávět.
Pán vám žehnej a ochraňuj tě!
A močál se zelená.
Docela se mi líbí akkoma software a doménové jméno, které jsem dostal pro svou instanci.
Ale mám pocit, že jsem tento případ začal takříkajíc špatnou nohou.
A nikdy jsem se tam necítil pohodlně.
Ještě se tu ještě trochu zdržím a přemýšlím, zda bych měl vůbec migrovat.
#FalconGameBooks
Zdá se, že osmiocí Repnidi sledují, jak usadíte leták na červenou půdu, ale nedělají žádný pohyb směrem k vám, ve skutečnosti jsou nehybní, když vylezete z letáku a pomalu k nim kráčíte.
Země pod vašima nohama se začne třást a pak se otřásat, jako při zemětřesení a vy ztratíte půdu pod nohama, i když se zdá, že Repnidy nejsou ovlivněny.
Skála pod tebou náhle povolí.
Repnidy prorazily tunel pod povrchem a vy spadáte do vroucí masy stovek těl Repnid v jeskyni pod ním.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskra kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jste byl prvním budoucím lidským cestovatelem.
Přistanete nosem letáku nahoru na stranu haldy strusky a vylezete ven.
Zdá se, že osmiocí Repnidi se dívají, ale nedělají žádný pohyb směrem k vám, ve skutečnosti jsou nehybní, když k nim pomalu kráčíte.
Zastavíte se ještě na hromadě rozpadající se skály a hlíny a promluvíte k nim a řeknete: "Přicházím v pokoji, jako přítel."
Zdá se, že vás nemohou slyšet, natož porozumět, protože váš Univerzální Překladatel nezveřejňuje žádnou odpověď.
Rozhodnete se použít své psychické vědomí, abyste je mentálně kontaktovali.
Je těžké pochopit jejich myšlenky; Jsou děsivě cizí a vaše mysl se odvrací od kontaktu.
Rozhodnete se, že opětovné navázání kontaktu by bylo nebezpečné a vrátíte se ke svému letci, ale zkušenost vyčistila vaši mysl, která byla zmatená od té doby, co jste skočili do budoucnosti.
Jakmile se vrátíte do Falcon's Wing, zjistíte, že je docela snadné naplánovat kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[pokračování]
#today mám kávu, sluníčko a klid!
Začal jsem nový šátek.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně spřádanou stříbrnošedou přízi, která je většinou jemně spřádaná hrudkami.
Mám v plánu ji smíchat s jemnou fialovou / fialovou pestrou bavlnou.
Ale nejsem si jistý, že mám dost fialové.
Používám háček H s podobným dvojitým háčkovaným vzorem jako dříve.
První spojení jsem udělal včera večer, tak uvidíme.
Přeji všem šťastný čtvrtek!
Nesnáším však hodiny výtvarného umění a literatury a můj školní dějepis to potvrzuje.
Doslova jsem zkoušel a upustil KAŽDOU JEDNU.
A až do doby před dvěma lety jsem neměl tušení, dokud jsem nezkontroloval své přepisy.
Nenávist k literatuře je ještě horší: rád čtu.
Většinu klasiků jsem trefil před osmnácti - i když to je spíš odraz života v bumfucku nikde, v zoufalství jsem četl i Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a jsem tam šťastný, ale musím být někde jinde, abych se ochladil a četl beletrii během dne bez pocitu viny.
Je to, jako bych byl na dovolené, a proto dělám to, co člověk dělá o svátcích.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma a trochu jsem se #MECFS vymanil z toho, že jsem prostě v cizím prostředí, kde jsem méně schopný držet tempo a musím si pamatovat, jak se věci mají.
A to i přesto, že stále mám svůj seznam úkolů a organizuji si i svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny dobré věci, které miluji na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi, ale bude schopen přilákat publikum správných hráčů?
Rozkvete komunita kolem obsahu vytvářeného uživateli ve hře?
(Opravdu v to doufám.)
Příběh, nápady a otázky, které hra inspiruje, působí aktuálně.
Doufám, že to půjde dobře.
Je tu den ThinkPadu!!
Přišel jsem domů na oběd, abych viděl, že to sedí venku uwu.
Přál bych si, abych to mohl vzít zpátky do práce se mnou, abych nastavil více.
Ale to bude muset počkat do dnešního večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to příliš roztomilé do té míry, že jsem byl twee?
Rozhodně
Mluví některá z těchto postav lidskými bytostmi?
Ani vzdáleně
Ale líbilo se mi to?
Naprosto!
co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno vystudovaný umělec vzal dnes večer nějakou kritiku špatně.
Částečně proto, že by se učili špatně.
Je však důležité nevymlouvat se na problémy a prostě je opravit, zejména ve výrobě, když váš zájemce potřebuje změny.
Zejména s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tu proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Předpokládá, že máte schopnost problém vyřešit nebo najít řešení.
Takže zatímco kompostování a posouvání květů jsou skvělou připomínkou, abyste se podívali nahoru a byli si vědomi života mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak jsou semena zaseta a kultivována (a ne náhodně rozptýlena) dobrými peeps.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu podstrčil vzkaz, když se míjeli na cestě, těsně před psí hlídkou.
Byla na cestě ke zdi, on odcházel ze služby.
Podíval se za sebe, aby ji sledoval, jak odchází, a ujistil se, že je nikdo neviděl.
Neohlédla se.
Počkal, až bude v temnotě palandy, než vytáhl vzkaz a přečetl si ho v paprsku světla procházejícím zatemňovacími závěsy.
Jedno blokově vytištěné slovo.
Dlouho na ni zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových #Mastodon kamarádů a chci tento trend udržet.
Když volám do #Fediverse, cítím se jako velryba zpívající přes obrovský oceán!
Chcete se připojit k mému "lusku"?
Zvláště bych se rád spojil s více.
Každý, kdo má vlasy v ohni ohledně CNN, může poděkovat Stephenu Colbertovi za ostrou odbočku doprava.
Pomohl udělat z Chrise Lichta národní problém.
Jakkoliv bychom se mohli líbit některým lidem, pokud jen poskytují kariéru v nižší lize fašistům, pravděpodobně by ji měli nosit.
Bylo to poprvé (ale nebude to naposledy), kdy Kaveesha Dilhari zaznamenala 20+ běhů a vzala 2+ branek ve stejném T20I.
Připojila se k vybrané skupině srílanských žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilném protestu před britským uprchlickým hotelem
Incident přichází po zvýšení počtu uprchlíků a žadatelů o azyl, kteří překračují kanál La Manche do Velké Británie na lodích.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem používaným k ubytování žadatelů o azyl stala násilnou poblíž anglického města Liverpool.
Policejní oddělení v Merseyside uvedlo, že policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer v Knowsley.
Policie uvedla, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zatčení lidé ve věku od 13 do 54 let byli zadrženi "po násilných výtržnostech".
Policejní komisařka z Merseyside Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zranění."
Ministerstvo vnitra využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku, podle místních médií.
George Howarth, který zastupuje Knowsleyho v britském parlamentu, řekl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou bigotní a jsou vítáni lidmi, kteří utíkají z některých z nejnebezpečnějších míst na světě při hledání bezpečného místa," řekl.
"Ti, kteří dnes večer demonstrovali proti uprchlíkům na tomto protestu, nereprezentují tuto komunitu."
Protest se konal uprostřed zvýšeného napětí, kdy rostoucí počet uprchlíků a migrantů překračuje kanál La Manche v malých člunech.
Více než 45 000 lidí se dostalo do Velké Británie touto cestou v roce 2022 a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se kvůli politickým nepokojům a byrokratickým průtahům zpomalil, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytováních.
Překročení Lamanšského průlivu se stalo politickým tématem, kdy konzervativní vláda slíbila, že "zastaví lodě" a prosazuje plán na vyslání takových žadatelů o azyl do Rwandy.
Oponenti obviňují vládu z démonizace zoufalých lidí prchajících před válkou a chudobou.
President's Cup: Candystripes porazili Rovers v úvodním utkání sezony v Brandywellu
Záložník Derry Adam Reilly zavírá Lee Graceho v Brandywellu
Derry City zvítězilo v President's Cupu, když zvítězilo 2-0 nad Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze ligy z minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops ve druhém poločase tlačili na snížení, ale svěřenci Ruaidhri Higginse odolali a vyhráli zápas.
Derry cestuje do St. Patrick's Athletic na zahájení ligy příští pátek.
Patchingův volej nohou postrčil Derry do vedení po 23 minutách - záložník otevřel skóre, když Foylesider loni v únoru vyhrál 2:1 nad pozdějšími šampiony.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy brzy poslal City do vedení dalekonosnou střelou, která se dostala pod brankáře Leona Pohlse do sítě.
Finalisté minulé sezony byli o přestávce dva góly k dobru.
Nejblíže ke snížení byl ve druhé třetině Graham Burke, ale Candystripes týden před cestou za národní slávou pohodlně zvítězili.
Šéf City Ruaidhri Higgins pochválil svůj tým po tom, co nazval "nejtěžším týdnem svého života" po smrti svého bratra Kevina.
"Je to kopanec do zubů a jsou před námi těžké týdny, ale budeme s tím pokračovat v jeho paměti," řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě dobrým výkonem je opravdu potěšující."
DHS si najímá právnickou firmu, aby se zabývala možným procesem impeachmentu Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí právnickou firmu Debevoise & Plimpton, aby pomohla v možném procesu impeachmentu ministra Alejandra Mayorkase, protože potenciálně čelí obvinění republikánů ve Sněmovně reprezentantů ohledně jeho přístupu k jižní hranici.
"Ministerstvo vnitřní bezpečnosti si ponechalo externího poradce, aby pomohl zajistit, že životně důležité poslání ministerstva nebude přerušeno bezprecedentními, neoprávněnými a stranickými snahami o impeachment některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl mluvčí DHS v pátečním prohlášení.
"DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečit naše hranice, přičemž bude odpovídajícím způsobem reagovat na více než 70 kongresových výborů a podvýborů, které dohlížejí na DHS."
Úředník DHS řekl CBS News, že ministerstvo najalo firmu na smluvní práci po celou dobu vyšetřování Kongresu.
Debevoise byla vybrána kvůli svým odborným znalostem v oblasti impeachmentu a zkušenostem obou politických stran při spolupráci s Kongresem na dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, DC, 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise je pro DHS vhodným výdajem.
DHS se snaží zajistit, aby jeho poslání nebylo podkopáváno partyzánskými útoky a aby řízení proti Mayorkasovi vedli lidé s odpovídajícími odbornými znalostmi.
Mayorkas tento vývoj nekomentoval, ale na dotaz ohledně vyšetřování impeachmentu minulý čtvrtek novinářům řekl: "Budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s posledním Kongresem. Myslím, že je to naše zodpovědnost."
Připustil, že "bude nějakou dobu trvat", než vyhoví vyšetřování Sněmovny.
"Strávím tento čas stejně jako ostatní a také nebudeme dělat kompromisy v čase, který strávíme plněním našeho poslání."
Vysoký představitel DHS potvrdil, že Mayorkas se se svým novým externím poradcem ještě nesetkal.
Pouze jeden člen kabinetu byl kdy obžalován, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl osvobozen senátem.
Populární zprávy
Děkujeme, že jste si přečetli CBS NEWS.
Čtyři teenageři obvinění z útoku na 14letého chlapce, který zemřel sebevraždou po bití videa, bylo zveřejněno online
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem 14leté dívky, která si později vzala život poté, co bylo video incidentu zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z útoku s přitěžujícími okolnostmi, dva mladiství jsou obviněni ze spiknutí s cílem spáchat útok s přitěžujícími okolnostmi a jeden mladistvý je obviněn z obtěžování, řekl prokurátor Ocean County Bradley D.
Adriana Kuch, 14, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video útoku na střední škole Central Regional High School.
Na videu bylo vidět, jak dívky házejí po dívce drink, pak do ní kopou a táhnou ji po školních chodbách.
Adrianu strčili do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kucha opakovaně udeřila.
Další dívka mimo záběr se smála, když natáčela scénu.
Dva dospělí přišli rozehnat útok, přičemž jeden dospělý teenagery od sebe odtrhl.
Adriana ležela zraněná a pohmožděná na podlaze chodby, jak se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: "To je to, co dostaneš."
"Milovala život. Byla nejšťastnější dítě. Všichni ji milovali," řekl její otec Michael Kuch pro CBS New York a dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
14letá Adriana Kuch zemřela sebevraždou poté, co bylo na internetu zveřejněno znepokojivé video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že policie měla být zavolána okamžitě, protože studenti, se kterými měla jeho dcera problémy, jí rozbili obličej 20uncovou lahví.
"Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejňovaly videa ze školy," řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
"Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni," řekl CBS New York Dr. Triantafillos Parlapanides, ředitel škol.
Představitelé školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních slyšení, řekl prokurátor CBS News.
Studenti ve škole uspořádali ve středu pochod na podporu Adrianiny rodiny.
Pokud vy nebo někdo, koho znáte, je v emocionální tísni nebo sebevražedné krizi, můžete se obrátit na linku 988 Suicide & Crisis Lifeline voláním nebo textovou zprávou 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Pro více informací o zdrojích péče o duševní zdraví a podpoře je linka pomoci Národní aliance pro duševní nemoci (NAMI) k dispozici od pondělí do pátku od 10:00 do 22:00.
ET, na čísle 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 zdravotními, wellness profesionály o tom, jak se vyhnout vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v naší práci.
To může být pro ty, kteří pracují ve zdravotnictví, velmi obtížné, a proto jsem položil 30 zdravotníkům a wellness stejnou otázku: "Jak řídíte svou energii a nevyhoříte ve své profesi?"
Jejich kariéra sahá od lékařů infekčních chorob přes psychology až po učitele všímavosti - a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vystupovala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají terminální onemocnění, Eufrosina Young děkuje svému silnému podpůrnému systému za její schopnost udržet si energii.
Young je certifikovaný neurolog a specialista na ALS na neurologickém oddělení Upstate University Hospital a říká, že tam "mobilizují jako armáda lidí".
Neexistuje lék na amyotrofickou laterální sklerózu (ALS), ale vědomí, že není jediná, kdo tvrdě pracuje na vývoji léčby a poskytování lepších možností pro své pacienty, udržuje Youngovou i v jejích nejtěžších dnech.
"Neneseme tíhu světa, ale jsme součástí světa lidí, kteří tuto práci obhajují," říká.
2.Odpočívejte, když potřebujete
Práce ve dvou zaměstnáních jako výzkumník spánku a algoritmický inženýr, to vše při péči o nové dítě, by určitě vedla Raphaela Vallata k vyhoření, pokud by neodpočíval, říká.
"Mám pocit, že když se chystám vyhořet, v podstatě každý úkol se cítí jako hora, na kterou musíte vylézt, a cítím se velmi naléhavě a důležitě," říká Vallat.
V takových chvílích "si opravdu potřebujete vzít volno a uvědomit si, že tyto úkoly mohou počkat".
Vallat si obvykle najde chvíle ve svém dni, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil před návratem do práce.
3.Be nadšení pro to, co děláte, a pamatujte na svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně sedm dní v týdnu.
Pobyt v první linii během pandemie jí zabral téměř všechen čas, ale vyhoření se vyhnula tím, že si připomněla, proč je její práce důležitá.
"Nemyslím si, že práce se cítí jako práce, když máte pocit, že máte vliv," říká Gounder.
"Pokud pracujete šílené hodiny a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu musíte udělat krok zpět a zeptat se, co děláte."
4.Mějte jiné radosti
Každý z odborníků uvedl, že se zabývají nějakým koníčkem, jako je cvičení, tanec a dokonce i hra na kytaru.
Je nesmírně důležité mít život, který si užíváte, který přesahuje to, čeho dosáhnete ve své práci, říká Christina Maslach, sociální psycholožka, profesorka psychologie v důchodu na UC Berkeley a autorka knihy "Výzva vyhoření: Řízení vztahů lidí s jejich prací".
"Podívejte se na svůj život jako celek a ujistěte se, že jsou na něm dobré věci a ujistěte se, že na ně máte čas."
Získejte bezplatný průvodce investováním Warrena Buffetta od CNBC, který destiluje miliardářovu nejlepší radu č. 1 pro pravidelné investory, co dělat a nedělat, a tři klíčové investiční principy do jasné a jednoduché příručky.
Zaregistrujte se nyní: Buďte chytřejší o svých penězích a kariéře s naším týdenním zpravodajem
Mladistvý obviněn z vraždy v prosinci Střelba ve škole v Chicagu, která zanechala 2 mrtvé
16letý chlapec byl obviněn z vraždy při prosincové smrtelné střelbě dvou studentů na střední škole v Chicagu, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou případů pokusu o vraždu, oznámil superintendant chicagské policie David Brown.
"V současné době nemáme jasný motiv, proč by 16letý chtěl střílet a zabíjet jiné děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběti, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti jim pomohly dostat se k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční za ty, kteří byli natolik stateční, že vystoupili, aby zajistili, že pachatel bude chycen a nyní bude hnán k odpovědnosti," řekla státní zástupkyně okresu Cook Kim Foxxová.
Očekává se, že podezřelý se objeví před soudem Bond v sobotu, řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Minnesotští biologové zachraňují chyceného černého medvěda
Minnesotské ministerstvo přírodních zdrojů přišlo na pomoc medvědovi, nešťastníkovi poté, co uvízl v příkopu.
Medvěd se podle facebookového příspěvku ministerstva schoval v propustku u silnice poblíž Wannasky v Minnesotě.
Když ale sníh začal tát, propustek se začal zaplavovat a medvěda uvěznil v hlubokém sněhu a ledu.
Zaměstnanci oddělení rychle zareagovali na scénu a pomohli medvěda odstranit.
Medvědí biolog Andrew Tri "medvěda vyšetřil a prohlásil ho za zdravého, ale groggy - očividně proto, že se probudil ze zimního spánku," uvádí se v příspěvku na Facebooku.
Ministerstvo pak přemístilo medvěda do státního útočiště, aby obnovilo jeho hibernaci.
Ospalý masožravec byl odhadován na 6 let starý a mezi 375 a 400 liber.
Oddělení připomnělo obyvatelům, že přesun medvědů je práce, kterou je nejlepší přenechat profesionálům.
Pokud se obáváte medvěda ve vašem okolí, měli byste kontaktovat místní úřady - nesnažit se přestěhovat nebo krmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili vykopat medvěda sami a nabídli mu jídlo, včetně Pop-Tarts, salátu a Fancy Feast kočičího jídla.
Ale naštěstí pro kopáče s dobrými úmysly, "protože medvědi nemají touhu jíst v zimě, medvěd nekousl."
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se nacházejí hlavně v severní třetině státu, podle ministerstva přírodních zdrojů.
Predátoři v zimě hibernují až šest nebo sedm měsíců, během kterých nejedí a žijí ze svého uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Džehuty a Hery
Hrobky Džehutyho a Heryho byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci vedli generální tajemník Nejvyšší rady pro památky v Egyptě Mostafa Waziri, velvyslanec společnosti Span v Egyptě Alvaro Iranzo a prezident španělské Národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady pro památky a CSIC, která pracuje od roku 2002.
Řekl, že mise provedla vykopávky a restaurátorské práce a publikovala výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahrady.
Významné hrobky z významné doby
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili na počátku 18. dynastie Nové říše - jedné z nejdůležitějších ér starověkého Egypta.
Řekl, že půdorys hrobek je ve tvaru písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty jsou v souladu se vstupem, sloupovou síní vedoucí k pohřební šachtě a stěnami s výraznými nápisy.
Waziri dodal, že Džehuty byl dohlížel na státní pokladnu a dohlížel na díla řemeslníků a umělců za vlády královny Hatšepsut.
Džehuty byla také zodpovědná za záznam cesty Hatšepsut do Puntlandu a poskytla elektrum (směs zlata a stříbra) pro zakrytí vrcholu obelisků, které umístila v chrámech v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
V místnosti, která předchází Džehutyho pohřební komoře, jsou nápisy s vyrytými 43 kapitolami Knihy mrtvých, což je poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátně a papyru.
Hery zastával funkci superintendanta královských zásob posvátné královské manželky a matky Ahhotep.
Jared O'Mara nikdy neměl být labouristickým kandidátem, říká Rachel Reevesová
Zostuzený bývalý poslanec Jared O'Mara "nikdy neměl být vybrán jako labouristický kandidát" a zaslouží si svůj čtyřletý trest odnětí svobody, řekl stínový kancléř.
Rachel Reevesová hovořila s deníkem Guardian ve volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak labouristický národní výkonný výbor (NEC) kontroluje parlamentní výběrový proces pro příští všeobecné volby.
Celá výběrová komise v Bolton North East rezignovala poté, co jí nebylo umožněno vybrat užší výběr, což je stále běžnější praxe v Labouristické straně Keira Starmera, a řekla: "Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu."
Dodali: "To jde proti postoji nezbytnému k získání zpět rudé zdi, která je tak zoufale potřebná k vytvoření labouristické vlády."
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybíráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Obzvláště nešťastná byla skutečnost, že Leigh Drennan, předseda Labouristické severozápadní strany a poradce poslankyně za Warrington North Charlotte Nicholsové, která podporuje Jeremyho Corbyna, nebyl na dlouhém seznamu, aby se pokusil získat křeslo zpět od konzervativců, přestože získal nominace od čtyř velkých odborových svazů.
Reevesová řekla, že nemá nic společného s výběrem kandidátů, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo může být zařazen do užšího výběru."
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné žádosti o výdaje v celkové výši 52 000 liber ve snaze financovat své zneužívání kokainu a alkoholu.
Mnoho lidí naznačuje, že nebyl řádně prověřen labouristy, když byl vybrán, aby bojoval s Nickem Cleggem, bývalým liberálním demokratickým místopředsedou vlády, v Sheffield Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se v myslích labouristické NEC rýsuje debakl s O'Marou, Reeves řekl: "Nechci žádným způsobem naznačovat, že někdo, kdo není v užším výběru, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest."
Okolnosti O'Mary byly "docela výjimečné," řekla Reevesová, ale uznala: "Existují důležité lekce pro Labouristickou stranu a všechny politické strany o výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě tím, že se střídali premiéři a pokuty a strany a standardy zdaleka nedosahovaly toho, co byste mohli očekávat."
Dodala: "Jedna věc, kterou bych řekla o Labouristické straně, je, že když lidé dělají něco špatného, ztrácejí bič. A to prostě není případ Konzervativní strany."
Archie Bland a Nimo Omer vás provedou nejlepšími příběhy a tím, co znamenají, zdarma každé všední ráno.
Oznámení o ochraně osobních údajů: Zpravodaje mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich Zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme Google reCaptcha a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku pro Openreach, které poskytuje britskou širokopásmovou síť.
Poté, co Reeves sledoval, jak učni šplhají po telegrafních sloupech v lokalitě za 1,7 milionu liber, diskutoval o plánech labouristů na přepracování učňovského odvodu, který nutí větší firmy odkládat stranou 0,5% svých mezd na financování učňů.
Podniky si stěžují, že odvod je příliš nepružný. Například, řekl Reeves, Openreach "chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vlákně, ale učňovský poplatek nemá takovou flexibilitu ohledně rekvalifikace."
Reeves řekl, že labouristé změní odvod tak, aby společnosti mohly použít peníze na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový průmysl a ty, které v současné době instalují plynové kotle.
"Potřebujeme, aby se v rámci přechodu na čistou nulu naučili dovednosti pro práci na elektrických vozidlech nebo instalaci tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto je učňovský odvod navršen proti nim.
Podniky chtějí větší flexibilitu a mladé lidi, kteří začínají svůj život, nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost, "řekl Reeves.
Jeden zatčen během protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala drag queen vypravěčská akce pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově motivovaného komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyla hlášena žádná zranění a policisté zůstávají na místě, uvedla policie.
Tate hostila v sobotu Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou webová stránka galerie popisuje jako "první drag umělec v Evropě, který četl příběhy dětem v dětském pokoji".
Pravicová skupina demonstrantů demonstrovala před galerií a setkala se s protidemonstranty vedenými bojovníky za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit chodbu, aby se účastníci mohli dostat do místa konání.
Drag Queen napsala na Twitteru, že den byl "opravdu emocionální" a dodala, že pět protestujících se dostalo do Tate a "způsobilo narušení" v částech budovy, ale neovlivnilo čtení.
Předtím řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ+ bylo "ctí".
Její čtení se již dříve stalo terčem protestujících.
Drag Queen řekla, že "hodnocení rizik" proběhlo předem - ale dodala, že je "směšné", že jsou nezbytné.
Aida tweetovala: "5 nenávistníků se dostalo do Tate. Způsobili rozruch. Ale ne Drag Story Hour UK ... Udělali rozruch jinde v budově, ne tam, kde byla show! ! SHOW 2 šla hladce!!"
Aida pořádala tři vypravěčské seance v sobotu v 11, v poledne a ve 14 hodin.
Mluvčí Tate řekl: "Neprogramujeme umělce, abychom prosazovali konkrétní názory, ani abychom sladili odlišné názory."
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, kterými aspekty se budou zabývat."
Trumpova cenná budova 40 Wall Street na "Lender Watch" uprostřed klesajících příjmů: Zpráva
Silně zatížený mrakodrap Donalda Trumpa na Wall Street 40 je na "věřitelské hlídce" uprostřed klesajících příjmů a rostoucích nákladů, informovala v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější - vyskočila ve třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání o zbývající hypotéce budovy ve výši 126,5 milionu dolarů, uvedla agentura Bloomberg.
Výdaje mezitím údajně vzrostly o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubí budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků 11. září 2001, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, ale také lež.
Další nedaleký mrakodrap na Pine Street na dolním Manhattanu se stal nejvyšší budovou po zničení Twin Towers.
Nájem výškových kancelářských prostor na Manhattanu klesá již několik let, což se zhoršilo po vypuknutí pandemie COVID-19, kdy mnoho společností zavřelo a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která obsluhuje hypotéku na 40 Wall Street, "oslovila dlužníka pro stav rozvoje pronájmu" a plány na zlepšení výkonu nemovitosti, podle podání, uvedla agentura Bloomberg.
Majitel Wagnerové říká, že válka na Ukrajině se potáhne roky
Majitel ruského soukromého vojenského dodavatele skupiny Wagner, který se aktivně podílí na bojích na Ukrajině, předpověděl, že válka by se mohla táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek řekl, že může trvat 18 měsíců až dva roky, než si Rusko plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny, Donbasem.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinův šéfkuchař" pro své lukrativní cateringové smlouvy s Kremlem, znamenalo uznání obtíží, kterým Kreml čelil v kampani, která původně očekávala, že skončí během několika týdnů, když ruská vojska 24. února napadla Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících porážek, když ukrajinská armáda zahájila úspěšnou protiofenzívu, aby získala zpět široké pásy území na východě a jihu.
Kreml se vyhnul předpovědím, jak dlouho by boje mohly pokračovat, a uvedl, že to, co nazval "zvláštní vojenskou operací", bude pokračovat, dokud nebudou splněny její cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří Donbas, kde separatisté podporovaní Moskvou bojují proti ukrajinským silám od roku 2014.
Prigožin řekl, že žoldáci skupiny Wagner pokračují v zuřivých bojích o kontrolu nad ukrajinskou pevností Bachmut v Doněcké oblasti.
Uznal, že ukrajinské jednotky kladou zuřivý odpor.
Zatímco ruská vojska útočí na Donbas, Moskva se také snaží demoralizovat Ukrajince tím, že je nechává bez tepla a vody v kruté zimě.
V pátek Rusko zahájilo 14. kolo masivních útoků na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Ve východních, západních a jižních regionech byla zasažena infrastrukturní zařízení vysokého napětí, což v některých oblastech vedlo k výpadkům proudu.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná" a dodala, že zahrnuje zálohy, aby se udržely dodávky energie, ale poznamenala, že v některých oblastech bude pokračovat přídělový systém elektřiny.
Velitel ukrajinské armády generál Valerij Zalužnyj uvedl, že ruské síly odpálily od čtvrtka do pátečního poledne 71 střel s plochou dráhou letu, 35 raket S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět dronů.
Ukrajinské úřady v pátek informovaly o dalších útocích zabijáckých dronů.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 bezpilotních letounů Shahed.
V pátek pozdě večer ruští vojenští blogeři a některé ukrajinské zpravodajské kanály zveřejnily video ukazující útok námořního dronu na strategický železniční most v Oděské oblasti.
Zrnité video ukázalo rychle se pohybující objekt, který se blíží k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a exploduje v silném výbuchu.
Pravost videa se nepodařilo ověřit.
Ukrajinská armáda útok nekomentovala a Serhij Bračuk, mluvčí regionální správy, nechtěl potvrdit útok dronem, když v sobotu hovořil v televizním projevu.
Most, který byl na počátku války cílem ruských raketových útoků, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte reportáže AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 mrtvých v Türkiye: 11. února 2023, 12:15
GAZIANTEP. KAZINFORM - Kazašští záchranáři pokračují v prokopávání trosek a hledají přeživší v Türkiye, Kazinform cituje tiskovou službu kazašského ministerstva pro mimořádné situace.
Práce záchranářů je ztížena velkým množstvím trosek a nestabilními konstrukcemi.
Kazachstánský záchranný tým vytáhl sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte, v Türkiye.
První lékařská pomoc je také poskytována nepřetržitě.
Zejména zemětřesení o síle 7,7 stupně, které zpustošilo části jihovýchodního Türkiye a severní Sýrie, udeřilo v pondělí brzy ráno.
K dnešnímu dni počet obětí masivních otřesů, které zasáhly jihovýchod od Türkiye, přesáhl 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA. KAZINFORM - Zahajovací ceremoniál 10. halového mistrovství Asie v atletice se konal v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, Kazinform cituje tiskovou službu kazašského premiéra.
Při zahájení akce přečetl předseda kazašské vlády uvítací dopis prezidenta Kassyma-Žomarta Tokajeva.
"Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro profesionální a masové sporty.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický areál s kapacitou přes šest tisíc lidí," píše se v dopise kazašského prezidenta.
Kazachstánští sportovci úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání mistrovství Asie v Astaně dá nový impuls rozvoji atletiky v zemi a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanovi al-Hamadovi za jeho pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaj svedl dohromady více než 500 sportovců z 31 zemí, kteří budou soutěžit v závodě, štafetovém závodě, skoku dalekém, skoku vysokém, trojskoku, skoku o tyči, vrhu koulí a všestranné události.
Turnaj potrvá do 12. února.
Dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkirui získala zlato v běhu na 3000 m žen a Olga Safronova získala na turnaji stříbro v běhu na 60 metrů žen.
Foto: primeminister.kz
"Yellowstonský" herec Q'orianka Kilcher porazil obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském procesu s pomluvou, dosáhla dalšího právního vítězství - tentokrát s "yellowstonským" hercem Q'oriankou Kilcherem.
V pátek okresní prokuratura okresu Los Angeles zprostila 32letého Kilchera všech obvinění v případu podvodů s odměňováním zaměstnanců.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora v Los Angeles uvedl, že soud "rozhodl, že paní Kilcherová se nedopustila pojistného podvodu a oznámil soudu, že nemůžeme pokračovat."
V červenci 2022 kalifornští úředníci obvinili Kilcherovou ze dvou trestných činů kompenzačních podvodů a obvinili ji z nezákonného pobírání více než 96 000 dolarů invalidních dávek mezi říjnem 2019 a zářím 2021.
Časový rámec také zahrnuje několik měsíců, kdy Kilcher pracovala na "Yellowstone", navzdory tvrzení herce, že byla příliš zraněná na to, aby pracovala.
Kilcher se vzdal a v květnu byl předveden.
"Dnes jsem více než vděčný, že můj případ byl zamítnut - zítra začíná moje cesta, která pomůže zvýšit povědomí a požadovat větší transparentnost práv pracovníků v rámci systému pracovníků comp," uvedl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že "se těší na to, že vrhne více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji."
Kilcherová také poděkovala Vasquezové a jejímu kolegovi Stevu Cookovi, právníkovi Browna Rudnicka za "jejich neochvějnou víru v mou nevinu".
Podle TMZ je Kilcher najal v září.
Kilcher prorazila v roce 2002 ve filmu Terrence Malicka "Nový svět", kde ztvárnila Pocahontas.
Mezi její filmy patří také "Sons of Anarchy", "The Alienist" a "Dora and the Lost City of Gold".
Naposledy se objevila v road-trip filmu "Dog" s Channingem Tatumem v hlavní roli.
K této zprávě přispěla redaktorka Times Christina Martinez.
Šéf Balenciagy označil sváteční kampaň za "hloupou chybu"
Značka luxusního oblečení Balenciaga se stále vzpamatovává z odporu kvůli dvěma svým nedávným reklamním kampaním.
Měsíce poté, co se módní dům dostal pod palbu kvůli propagačním obrázkům, které podle kritiků sexualizují děti, umělecký ředitel Balenciaga Demna (celým jménem Demna Gvasalia) řekl, že je mu stále líto obrázků v rozhovoru pro Vogue zveřejněném v pátek.
"Chci se osobně omluvit za špatný umělecký výběr konceptu dárkové kampaně s dětmi a beru na sebe svou zodpovědnost," řekl Vogue a zopakoval předchozí prohlášení, které v prosinci zveřejnil na sociálních sítích.
V listopadu značka sdílela fotografie pro svou kolekci "The Gift", která představovala dětské modelky pózující s medvídky, kteří byli oblečeni v bondage oblečení.
Krátce poté Balenciaga stáhla fotografie pro svou kampaň na jaře 2023, která obsahovala stránku z případu Nejvyššího soudu z roku 2008 týkajícího se "virtuální dětské pornografie" v pozadí.
Rodiče, včetně hvězdy reality show a dlouholeté fanynky Balenciagy - a partnerky značky - Kim Kardashian, vystoupili proti značce a jejím "znepokojujícím obrázkům" na sociálních médiích.
O několik dní později Balenciaga vydala prohlášení, ve kterém se omluvila za fotografie a nastínila změny, které zavede, aby se v budoucnu vyhnula podobným "chybám".
"Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s našimi diváky a jak se učíme z našich chyb a posouváme se vpřed," řekla Demna Vogue.
Podrobně popsal změny v Balenciaga: "restrukturalizace oddělení image", provádění více interních a externích kontrol snímků kampaně a partnerství s Národní dětskou aliancí, aby pomohla "tisícům dětí v procesu překonávání traumatu a řešení jejich duševního zdraví."
"Je to jediná věc, která mě na celé této hrozné situaci těší: udělat z toho něco dobrého," řekl o partnerství, které bylo oznámeno ve středu.
S NCA spolupracuje také mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod deštníkem Kering je Gucci, který v prosinci čelil odporu kvůli kampani s Harrym Stylesem, o které někteří kritici sociálních médií tvrdili, že také sexualizuje děti.
V rozhovoru Denma řekl, že plánuje odklon od "provokativních" způsobů značky.
"Je to součást mého učení: budu mít zralejší a serióznější přístup ke všemu, co vydám jako nápad nebo obraz," řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům značky Balenciaga, která vyrábí kvalitní oblečení - ne dělat image nebo buzz."
Když už mluvíme o původu značky, Demna jinde v rozhovoru řekl, že jednou z "nejbolestivějších" částí odporu bylo pošpinění "jména Balenciagy a odkazu Cristóbala Balenciagy".
"Balenciaga je dům, který je více než jedno století starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem byl zaneprázdněn tím, že jsem dělal vše, co bylo v mých tvůrčích silách, abych ho přivedl k jeho modernímu významu, a najednou jsme byli pod útokem a označeni jako něco, co vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s dárkovou kampaní a určitě jsme se z ní poučili."
Je to falešná zpráva, CBN vyvrací tvrzení, že postrádá kapacitu pro tisk dalších nových poznámek Naira
Nigerijská centrální banka (CBN) označila za zavádějící zprávu, která tvrdí, že cituje guvernéra CBN, pana Godwina Emefieleho, který připisuje současnou výzvu při distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů v Nigerian Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neučinil takové prohlášení během své prezentace Národní státní radě na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele pouze řekl na schůzce, že NSPMC pracuje na tisku všech nominálních hodnot Naira, aby uspokojil transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek Naira, "jsme znepokojeni rozsahem, v jakém se partikulární zájmy pokoušejí manipulovat fakty a štvat veřejnost proti bance."
Nwasinobi uvedl, že CBN je i nadále odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (ve znění pozdějších předpisů).
"Chceme také zopakovat, že NSPMC má kapacitu a dostatek materiálu k vytvoření požadované indent Naira.
"Banka proto chce apelovat na veřejnost, aby nebrala v úvahu zmíněnou zprávu a byla zdrženlivější, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na konkrétní hlasovou poznámku na sociálních médiích, která tvrdila, že CBN plánuje zavřít některé banky, zejména v určitém geopolitickém regionu země, CBN uvedla, že žádný takový plán neexistuje a že tato tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nereprezentují politický směr CBN a jsou pouze zoufalými pokusy osob usilujících o podněcování veřejnosti proti bance," uvedl.
Tim Sherwood po tristním debutu v Tottenhamu podepsal Pedra Porra za 44 milionů liber
Porro měl odpoledne zapomenout proti Leicesteru (Obrázek: Getty)
Tim Sherwood se pustil do "absolutně nechutné" obrany Pedra Porra při porážce Tottenhamu 4-1 s Leicesterem City.
Spurs podepsali pravého obránce ze Sportingu CP v den uzávěrky přestupů na počáteční hostování za 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
23letý útočník debutoval v sobotu na King Power Stadium Antoniem Contem, když se jeho tým ujal vedení po 14 minutách zásluhou Rodriga Bentancura.
Ale změnilo se to v bídné odpoledne, když Nampalys Mendy, James Maddison a Kelechi Iheanacho skórovali a dali Leicesteru v poločase 3-1, zatímco Porro prožil divoký první poločas v Premier League.
Španěl byl opět na vině, protože Leicester si myslel, že přidal čtvrtou zásluhu Barnese a zatímco gól byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood zůstal šokován defenzivním úsilím krajního obránce.
"Nechci si toho kluka dál dobírat, ale potřebuje být zbaven svých povinností," řekl Sherwood pro Soccer Saturday.
Dám mu výhodu pochybností, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho pozice je naprosto nechutná, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden řekl, že utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
V tuto chvíli nedělejme žádné závěry, ale to, na co se dívám, je hráč, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na bránění a tento hráč má momentálně problémy s obranou. Stojí proti velmi dobrým hráčům v Barnesovi a Maddisonovi, ale je to velké zklamání."
Leicester sice nerozhodoval, ale Leicester si vzal vedení 4:1 zpět díky Barnesovi devět minut před koncem.
Přestože Tottenham minulý týden porazil Manchester City, promarnil šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepsala Joao Felixe a místo toho se vrhla na hvězdu Tottenhamu
VÍCE: Tottenham se chystá nabídnout hvězdu Crystal Palace Marc Guehi, ale Chelsea má neoficiální možnost zpětného odkupu
Další podobné příběhy najdete na naší sportovní stránce.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli boj o privilegia kvůli předvolání Mikea Pence
Zpráva, že zvláštní vyšetřovatel Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak Trumpův tým využije soudy, aby zpackal tento nejnovější vývoj ve vyšetřování ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus potopit předvolání Pence na základě výsady exekutivy by měl selhat.
Za prvé, je tu prahová otázka, zda si bývalý prezident může toto privilegium vůbec nárokovat.
Připomeňme si, že Trump se pokusil a neúspěšně zabránil výboru Sněmovny reprezentantů 6. ledna, aby získal záznamy Bílého domu.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, nesouhlasil pouze soudce Clarence Thomas (manžel popíračky voleb v roce 2020 Ginni Thomasové).
Soud však ponechal otevřenou otázku, zda si exprezident může nárokovat privilegia, přičemž soudce Brett Kavanaugh naznačil, že by takový nárok podpořil.
Takže je přinejmenším nejasné, zda si bývalý prezident může nárokovat toto privilegium, neříká nic o tom, zda by nárok uspěl.
Odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se předvolání navíc ukazuje, že vágní tvrzení o privilegiu nestačí a může být překonáno specifickou potřebou důkazů.
Soud v roce 1974 konstatoval rozsudek Spojené státy vs. Nixon:
... Pokud je důvod pro uplatnění výsady týkající se materiálů předvolaných k použití v trestním řízení založen pouze na obecném zájmu na důvěrnosti, nemůže převážit nad základními požadavky řádného soudního procesu při spravedlivém výkonu trestního soudnictví.
Všeobecné uplatňování privilegia musí ustoupit prokázané, specifické potřebě důkazů v probíhajícím trestním řízení.
Precedens je tedy na straně vlády.
Samozřejmě, že zpoždění soudního sporu i v prohraném sporu může být pro Trumpa svým způsobem vítězstvím.
Šance na úspěšné uplatnění privilegia však dále tlumí předchozí odmítnutí Trumpova pokusu zablokovat výpověď před velkou porotou 6. ledna.
Jak v říjnu informoval deník The Washington Post, toto odmítnutí poznamenalo, že například bývalý Penceův poradce Marc Short "pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti ohledně útoku na Kapitol 6. ledna 2021, které nebyly dostupné z jiných zdrojů".
To, že i Pence má pravděpodobně jedinečné informace, by pomohlo ministerstvu spravedlnosti v jakémkoliv boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegium měl selhat.
Je to proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říci, že komunikace je privilegovaná, když jste ji dříve považovali za vhodnou k publicitě.
Takže zatímco předvolání může představovat různé politické a osobní kalkulace pro Pence - který může soupeřit o republikánskou nominaci v roce 2024 proti Trumpovi, někoho, kdo účinně toleroval výzvy k Penceově mimosoudní popravě 6. ledna - soudy by měly mít snadné časy stranit ministerstvu spravedlnosti ohledně privilegií.
Argumenty proti Bidenově kandidatuře jsou zřejmé - a slabé
Proč je to důležité?
Zatímco Biden a jeho demokratičtí kolegové nemohou udělat mnoho pro schvalování zákonů s republikány, kteří ovládají Sněmovnu reprezentantů, stále mohou strávit příští dva roky tím, že budou příkladem.
Kolektivně by všichni v týmu měli hledat příležitosti, jak hrát Gallanta s podivnými Goofusovými impulzy republikánů.
Ale je také důležité, aby Biden vylepšil svou důvěryhodnost u amerického lidu - a možná se stal zoufale potřebným agentem změny v naší až příliš ošuntělé politické kultuře.
Washington, notoricky cynické místo, je známý svými představami o vůdcovství, které ochromují zdravý rozum.
Snad jedním z nejznámějších je podivný standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli jít do komických délek, aby se tomu vyhnuli.
Existuje i jiný způsob: Neil Barofsky ve svých pamětech Bailout o svém pobytu ve Washingtonu, kde působil jako zvláštní generální inspektor dohlížející na program Troubled Asset Relief Program, popsal rady, které dostal od Kristine Belisleové, ženy, kterou chytře najal jako ředitelku komunikace.
Bylo to asi tak protiwashingtonské, jak jen to může být: "Přiznáme a dokonce zdůrazníme naše chyby."
Jak pokračovala ve vysvětlování, ve strategii je metoda, kterou by většina lidí na východním pobřeží považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o TARP ve Washingtonu.
Můžeme být občas v rozpacích a prozradit věci, které bychom mohli - a jiní by - snadno skrýt, ale šokujeme tisk svou upřímností.
Nikdo jiný to nedělá a zanedlouho budeme mít zabudovanou obranu, když budeme napadeni.
Bez ohledu na to, co slyší, tisk k nám přijde jako první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč se Biden vydal cestou radikálního přebírání odpovědnosti: v každém prezidentství nevyhnutelně nastávají okamžiky, kdy je důvěra veřejnosti a institucí, které chrání občanské zájmy, kritická.
Navíc existuje životně důležitý kapitál, který lze získat tím, že přiznáme své chyby, a existuje důležitý rozdíl, který Biden může vytáhnout se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým příslovím: Říkej pravdu – a zahanbuj ďábla.
Některé reklamy Super Bowl se nemůžu dočkat, až je uvidím
Hvězda sitcomu devadesátých let, která si zopakovala svou milovanou roli, aby vám prodala pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, čímž se dvanáctisekundová scéna prodlouží na deset řad.
Všechny celebrity z loňských kryptoreklam se omlouvají za své kryptoreklamy.
Ti "fujští" kluci, ale trochu je, že teď jsou staří.
Všichni jsou teď do kdo, že?
Takže nějaká série reklam v režii Riana Johnsona, kde když zjistíte, kdo vraždu spáchal, dostanete slevu na roční pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativci týden zuřit.
Timothée Chalamet v určité funkci.
Někdo, kdo byl údajně navždy zrušen, se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte, který určitě uvidíte, až bude streamován za tři týdny.
Nesnesitelně chytlavá nová znělka, kterou si budete zpívat roky.
Recyklovaný vtip na Twitteru z doby před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste bankovali s Wells Fargo.
Dítě "zoom zoom", ale trochu je, že teď je dospělý.
Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občany"
Republikán Andrew Clyde (R-GA) se ve čtvrtek posadil s Breitbart News a diskutoval o svých plánech zablokovat pravidlo pistole ATF a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občany".
Clyde dal jasně najevo svůj nesouhlas s pravidlem pistolové ortézy.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější.
Obecně vyjádřil své přesvědčení, že naši otcové zakladatelé nepředložili plán vládnutí, který by zahrnoval federální agentury, které by vytvářely zákony namísto zákonodárného sboru.
Řekl: "Ministerstvo spravedlnosti je tu proto, aby vynucovalo právo, ne aby ho vytvářelo. Když máte výkonnou moc, která vytváří zákon a vynucuje zákon, pak máte krále a království. Naši zakladatelé nevolali po králi a nestanovili království v Ústavě Spojených států."
Clyde se poté přesunul ke specifikům týkajícím se pravidla pistolové ortézy a vyjádřil své obavy, že pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: "To, co ATF chce, je, že chtějí zvýšit registrační databázi pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co předchází konfiskaci, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany."
Dodal: "Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo má co, aby mohli jít po nás."
Clyde tvrdí, že pravidlo pistolové ortézy ATF se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní a plánuje proti němu bojovat zuby nehty.
Řekl, že má "tři nástroje", kterými může bojovat proti pravidlu.
Prvním z těchto nástrojů je zákon SHORT Act a druhým je zákon o revizi Kongresu.
30. ledna Breitbart News citovaly Clydea, který nastínil svůj plán "znovu zavést zákon Stop obtěžovat majitele pušek dnes, nebo zákon SHORT, aby zrušil prvky zákona o národních střelných zbraních, čímž by zakázal ATF registrovat a zakázat pistole se stabilizačními výztuhami."
Poznamenal také, že "předloží rezoluci o nesouhlasu podle zákona o revizi Kongresu, aby přehlasoval nezákonné překročení Bidenovy administrativy".
Oba zákony, SHORT Act a Congressional Review Act, mají možnost zablokovat pravidlo pistole ATF.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k přijetí legislativy SHORT Act, nebo k dokončení rezoluce o nesouhlasu podle zákona o revizi Kongresu.
Dal jasně najevo, že získání Bidenova podpisu není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k jiným, větším zákonům, které demokraté velmi touží schválit.
Clyde však naznačil, že existuje také třetí způsob, jak zablokovat pravidlo pistole ATF.
Řekl: "Jsem v přídělovém výboru a můžeme zrušit financování tohoto pravidla pistolových výztuh prostřednictvím toho, co se nazývá promlčecí pozměňovací návrh. Můžeme doslova zrušit financování tohoto pravidla a v podstatě říci: "Žádné peníze nesmí být vynaloženy na provádění nebo vynucování tohoto konkrétního pravidla pistole."
A totéž můžeme udělat s pravidlem ATF přijímač/rám z loňského srpna.
Myslím si, že obojí musí být zbaveno finančních prostředků, a těším se na spolupráci s našimi přivlastňovateli, abychom toho dosáhli.
AWR Hawkins je oceňovaný sloupkař druhého dodatku pro Breitbart News a spisovatel / kurátor týdenního zpravodaje Down Range with AWR Hawkins zaměřeného na všechny věci druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins je držitelem titulu PhD ve vojenské historii se zaměřením na válku ve Vietnamu (námořnictvo hnědé vody), americké námořnictvo od počátku, občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat a získat Down Range na breitbart.com/downrange.
Oslovte ho přímo na awrhawkins@breitbart.com.
"Doufáme", že Biden má plán, jak se vypořádat s koncem hlavy 42, "pokud ano, nesdíleli ho úplně"
V pátečním vydání NBC "MTP Now" guvernér Colorada Jared Polis (D) řekl, že má "hodně obav" z toho, co se stane, když hlava 42 skončí v květnu, doufá, že Bidenova administrativa má plán, kdy tato politika skončí, a že "pokud ano, ještě se s námi plně nepodělili."
A řekl: "Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili."
Polis uvedl, že by si přál, aby se otázce imigrace věnovalo více času během setkání guvernérů v Bílém domě, ale tato otázka "přišla".
Částečně jsme tam měli ministra Mayorkase.
A tak jsme znovu zmínili, že sdílím spoustu obav ohledně toho, co se stane, až hlava 42 skončí v květnu, a tak se ujistíme, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě se s námi o to plně nepodělili.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pětkrát nebo tři, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stahuje "nevkusnou" reklamu u krematoria - RT World News
McDonald's se omluvil poté, co reklama na hamburger "McCrispy" řetězce rychlého občerstvení byla umístěna poblíž krematoria ve Velké Británii - ačkoli někteří místní obyvatelé viděli legrační stránku.
Řetězec restaurací se zavázal, že odstraní urážlivé reklamní poutání na základě stížností obyvatel města Truro v britském hrabství Cornwall.
V pátek si získala pozornost na sociálních sítích tím, že byla umístěna na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí ukazující na krematorium, byla některými rozzlobenými místními označena za "nevkusnou".
"I když vidím legrační stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou rádi vidět, když navštíví Penmount na pohřeb a kremaci milovaného člověka," řekl obyvatel, jehož tchyně byla loni zpopelněna v pohřebním ústavu, jak citovala britská média.
Ne všichni však byli nešťastným umístěním inzerátu tak uraženi, přičemž jeden poznamenal, že reakce člověka na něj bude pravděpodobně ovlivněna tím, "jak je to dávno, co jste sledovali nápis krematoria s černou kravatou".
Jedna osoba řekla, že "spadla ze židle smíchy", když viděla reklamu online, zatímco další místní také poznamenala, že to nebylo "o nic horší" než rozhodnutí rady zabývat se myšlenkou povolit výstavbu krematoria "vedle vesnice důchodců".
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek krátce poté, co se obrázek reklamy stal virálním online, ve kterém řetězec restaurací uvedl, že reklamu odstraní co nejdříve.
"Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. Nicméně ve světle obav, které vznesl CornwallLive, jsme požádali o odstranění naší reklamy," uvedla značka rychlého občerstvení.
Rada Cornwallu, která provozuje krematorium i autobusový přístřešek, který zobrazuje reklamu, odmítla komentovat rozruch, když byla kontaktována místními médii.
"Instinkt" pohřešované ženy není v řece
Pátrání po pohřešované Angličance Nicolě Bulleyové vstoupilo do 16. dne poté, co její partner řekl, že jeho "instinkt" je, že není v řece.
Lancashirská policie uvedla, že policisté si udržují "otevřenou mysl" a nadále žádají o informace o paní Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael's na Wyre.
Jednotka pokračuje v prohledávání řeky Wyre směrem k moři v zálivu Morecambe a pracuje na jedné hypotéze, že 45letý muž z Inskipu mohl spadnout.
S pátráním jim pomáhali specialisté a potápěči z pobřežní stráže Jejího Veličenstva, horské služby a hasičské a záchranné služby Lancashir, nasazených psů, dronů a policejních vrtulníků.
Paní Bulleyová zmizela při procházce se svým špringršpanělem Willow poblíž řeky, krátce poté, co vysadila své dcery ve věku šest a devět let ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner Paul Ansell řekl, že chce nechat "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popsal paní Bulleyovou jako "zábavnou", "milující", "nejvěrnější kamarádku, jakou jste kdy mohli mít" a "výjimečnou mámu", která "absolutně zbožňuje naše dívky".
"Je jen pilířem síly pro naši rodinu a bez ní je díra větší, než si dokážete představit," řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází "bezprecedentním peklem", naděje, že jeho partnerka bude nalezena, je "silnější než kdy jindy".
Policie nekalou hru odmítla a incident vyšetřuje jako pátrání po pohřešované osobě.
Ve čtvrtek se zaměření jejich hledání přesunulo ze St Michael's na asi 10 mil po proudu, kde se řeka vlévá do moře v zálivu Morecambe, s hlídkovými a záchrannými čluny spatřenými v oblasti.
Poslední komunistický vůdce NDR zemřel v 95 letech
BERLÍN (AP) - Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95 let.
Modrow zemřel v sobotu brzy ráno, uvedla parlamentní skupina Die Party na Twitteru.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nedokázal zpomalit nabírající hybnou sílu pro sjednocení Německa.
"Celý mírový průběh budování německé jednoty byl právě jeho mimořádným úspěchem," napsala levice na Twitteru. To zůstane jeho politickým odkazem."
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst postavy proti establishmentu.
Odmítal stranické požitky a trval na tom, že bude bydlet v normálním bytě.
Post ve východoněmeckém nejvyšším vedení mu unikal až do listopadu 1989 - několik dní po pádu Berlínské zdi, kdy se stal premiérem, což byla pozice, která měla do té doby jen malý vliv.
Když počátkem prosince rezignoval vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal vrcholnou politickou osobností východního Německa.
Ale komunisté už nemohli rozhodovat sami.
Následující měsíc souhlasil se sdílením moci se stále hlasitější opozicí a posunul první svobodné volby ve východním Německu na březen 1990, uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle nabrala příchuť pro sjednocení, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se západním Německem o konečné "sjednocené vlasti", která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow vedl volební kampaň přestylizované komunistické strany, Strany demokratického socialismu, ale jeho osobní popularita nestačila k tomu, aby skončili jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé sjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, méně než rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS - předchůdkyně dnešní opoziční Levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho přivedla před soud několik let po sjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků komunálních voleb v Drážďanech v květnu 1989.
Uložil mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozdělení mezi východními a západními Němci.
Jeho advokát argumentoval, že odčinil předchozí křivdy tím, že dohlížel na svobodné volby jako premiér.
Později v životě Modrow sloužil v radě starších levicové strany.
"Hans byl hluboce upřímný a bojovný socialista," tweetoval Dietmar Bartsch, předseda parlamentní skupiny Die Party.
"Až do stáří byl důležitým rádcem v naší straně, jehož moudrost bude chybět."
Indická vláda po kritice stáhla výzvu k objetí krav na Valentýna
Objímání krávy na Valentýna již indická vláda nepodporuje - navzdory tomu, že dříve žádala lidi, aby tak učinili na podporu hinduistických hodnot.
Indická rada pro dobré životní podmínky zvířat (AWBI) stáhla svou výzvu "Den objetí krávy" poté, co vyvolala kritiku od politických soupeřů a uživatelů sociálních médií.
Indické vládní úřady vyzvaly občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay řekl, že výzva k objetí krav byla "naprosto šílená, popírající logiku".
Dodal, že rozhodnutí stáhnout odvolání bylo spíše "zabránit tomu, aby politika hindutvy [hinduistického nacionalismu] byla zesměšňována tváří v tvář tvrdé kritice ze všech stran."
AWBI v pátek odmítla své odvolání s tím, že "je stažena".
Teprve ve středu se v prohlášení objevilo, že "objímání krav přinese emocionální bohatství a zvýší individuální a kolektivní štěstí".
Více o Indii
Dodala, že kráva je "páteří indické kultury a venkovské ekonomiky... pro svou výživnou povahu jako matka."
Na původní oznámení se objevily smíšené reakce, protože někteří zveřejnili videa krav, které odmítají objímání a nabíjení.
Jiní chtěli objasnit, že výzva je spíše pro následování vlastní kultury, než pro "slepé" následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněnými parky a restauracemi, vyměňují si dárky a pořádají večírky.
Mazlení s krávami také není nic nového - v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známé jako "koe knuffelen".
Oddaní hinduisté uctívají krávu - známou jako gau mata nebo "matka kráva" - a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie provedli razie v obchodech prodávajících valentýnské zboží, pálili pohlednice a dárky a vyhnali páry držící se za ruce z restaurací a parků a trvali na tom, že tento den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal tvrdí, že takové nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadřazenost náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinisté tvoří většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeathu, muž zatčen
Chodec zemřel po srážce s autem ve Fife.
38letá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeathu v pátek kolem 13:30.
V souvislosti s nehodou byl následně zatčen 24letý muž.
Policie vyzývá všechny svědky nebo kohokoliv, kdo má záznam z palubní kamery, aby se přihlásil.
Seržant Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a vyzýváme každého, kdo byl v oblasti a kdo byl svědkem havárie, aby se spojil."
Chtěl bych také apelovat na každého, kdo řídil v této oblasti a kdo může mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
"Každý, kdo může pomoci, je požádán, aby zavolal policii Skotska na číslo 101 s uvedením incidentu číslo 1638 z pátku 10. února 2023."
V ČÍSLECH: Čtvrti Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu rodičům cizincům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili občané Asie, včetně Turecka, největší skupinu přistěhovalců, přičemž více než 62 985 těchto státních příslušníků žije ve městě, podle údajů národní datové agentury Statistics Norway (SSB).
Poté tvořili občané EU, EHP a Spojeného království druhou největší skupinu, která představovala 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, přičemž v Oslu žije 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, což představuje 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen plachých 7 000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo jen něco přes 3 000 státních příslušníků.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrť s nejvíce cizími obyvateli.
V roce 2022 zde žilo 18 257 zahraničních rezidentů.
Poté měla módní Grünerløkka, která se nachází poměrně centrálně, druhý nejvyšší počet zahraničních obyvatel, a to 17 631.
Gamle Oslo mělo také významnou populaci přistěhovalců, kde žilo 17 631 lidí poté, co se přestěhovali z jiné země.
Norské statistiky ukázaly, že cizinci jsou rozptýleni po celém městě, protože Søndre Nordstrand, nejjižnější čtvrť v Oslu, měla více než 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl okresem s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořili zbytek z deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra bylo jen 184 zahraničních obyvatel, kteří nazývali Marku domovem, a něco přes 700 žilo v centrální městské části.
Ullern, Vestre Aker a Nordstrand tvořily další městské části s nejmenším počtem zahraničních obyvatel.
V těchto čtvrtích však žilo výrazně více přistěhovalců než v centru Osla a Marky.
Ti ze zemí EU a EHP a ti ze Spojeného království žili většinou ve Frogner, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Zatímco mnoho občanů z Asie, včetně Turecka, také bydlelo ve Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Norstrandem.
Ti ze Severní Ameriky byli poměrně rovnoměrně rozmístěni po částech Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve Frogner, Grünerløkka, Gaple, Oslo, St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království měli tendenci žít v centrální městské části Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek občanů z Oceánie, Frogner, Grünerløkka a Gamle Oslo byly městské části s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí provoz nového uhelného bloku do března
Autor: Florence Tan
Zimbabwe začne v březnu provozovat nový blok ve své jediné uhelné elektrárně, říká náměstek ministra energetiky země, což poskytne úlevu milionům občanů otřesených častými výpadky elektřiny v posledních měsících.
Nový blok elektrárny Hwange zvýší instalovaný výkon afrického národa o více než 14% na 2400 megawattů.
Očekává se, že další blok bude uveden do provozu brzy poté, řekl Magna Mudyiwa, aniž by poskytl časový harmonogram.
Méně než polovina z 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení financování nových uhelných elektráren omezilo schopnost země zablokovat chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich energetických zdrojů, ale v tuto chvíli vyrábíme mnohem méně. asi 1000 MW," řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit," řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné společnosti v průběhu času prudce poklesla, zatímco poptávka po energii v posledních letech vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících růstové vyhlídky Zimbabwe.
Nedostatek finančních prostředků na uhelnou energetiku vede ekonomiku závislou na těžbě a zemědělství k dovozu nákladné energie od regionálních sousedů, včetně Zambie a Mosambiku.
(Napsal Sudarshan Varadhan; Střih: Jacqueline Wong)
(OSOBA11) Ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně -
V podstatě velký obchod, nebo něco je špatně.
Takže některé soubory jsou stále - stále mají divný výstup.
Ale - ale pro většinu složek by to mělo být již v pořádku.
(OSOBA1) Dobře, díky.
(OSOBA6) Jo, to je skvělé.
Podporuji to, je skvělé, že [OSOBA7], jste mysleli na [OSOBU11].
A [OSOBA11] má nyní čas.
Jsou další věci, kde jsem myslel na [PERSON11] a to by byl trénink prázdných systémů, aby dělaly zkrácení.
Takže, pokud jste vy, [PERSON11], měli čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat příští týden.
Ale skutečně bychom měli mít systém – připravený na –
Podíval jsem se na tutoriál z NLP - bylo to tak?
(OSOBA6) Pro nadcházející zasedání jsem se zeptal na poptávku, protože jsem viděl demo projektu (mem).
Dělají offline titulkování.
Takže je to o něco jednodušší než to, co děláme.
Stále mají stejné problémy se segmentací a tak dále.
Ale jejich poslání v překladu se zkracuje jednoduše proto, že data se zkracují.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech dochází k jakémusi přirozenému zkrácení.
Bylo by skvělé, kdybychom mohli také najít takový typ dat, kde dochází k nějakému přirozenému zkrácení.
Dali bychom to do architektury.
(OSOBA8) To trvá trochu času, protože musím zjistit, který z nich je ten, který dostává průchody.
Takže, jakmile to vím, mohu to sledovat, takže do budoucna -
Nebo vlastně, do budoucna bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset dělat konverzi.
(OSOBA6) No, tohle, tohle by vlastně mělo být –
Slyšíš mě ještě?
Kvalita zvuku je o něco horší.
Takže by se to mělo opravdu dělat, pořád.
Takže pokaždé, když spustíme toto hodnocení, mělo by být spuštěno od nuly.
Takže pokaždé by mělo dojít k novému stažení čerstvé konverze a novému hodnocení.
(OSOBA8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript, a mohl by se postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, mohu to vidět později.
(OSOBA6) Takže to je důležitá věc, se kterou jsme se měli setkat už před několika měsíci.
Nezapomeňte, že od srpna vám říkám, že chceme vyhodnotit na pozdější testovací sadě.
A pokaždé vy všichni...
Nejste to jen vy osobně, [OSOBA8].
Byly tam samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si: "To bude snadné, prostě to spustíme".
A teprve když to skutečně uděláte, vidíte všechny problémy.
Takže je to známé, běžné.
Je to tak vždycky.
Takže to je vzkaz pro všechny.
Než to zkusíte, nikdy nevíte, jaký bude problém.
Takže například telefonát, který jsem měl, ve kterém se mnou někdo dělal rozhovor, tak chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Takže než to uděláte, nemůžete říci, zda to bude fungovat nebo ne.
A zde narážíme na problémy s konverzí formátů souborů.
Doufejme tedy, že se nám podaří rychle získat čísla.
Máte tedy zatím nějakou míru chyb ve slovech?
(OSOBA8) Ne, nezpracoval jsem to.
Takže [OSOBA1] řekla, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je spousta šumu.
Požádal jsem tedy, abyste měli různé verze tohoto slovníku tím, že budete brát pouze slova, která byla pozorována, pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takže tímto způsobem tyto náhodné chyby, jako je příklad s touto čtyřkou IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba, říká to "alzo", pokud si pamatujete, pokud řekne toto "alzo" s "Z" 20 krát v rozhovoru, pak to uvidíte v datech s "Z".
A pokud se mu někdy podaří říci také správně, pak ano, opět to uvidíte v datech.
Takže bych chtěl, aby [OSOBA4] byla v kontaktu s [OSOBOU2].
Možná pokračujete v hovoru, že?
Teď budu muset odejít, protože potřebuji dát dětem oběd a tak dále.
Ale prosím, zůstaňte na tomto volání a společně vymyslete, jak tento slovník používat.
Takže [OSOBA4], ukažte prosím [PERSON2], jaký je slovník, který systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste vydali do tohoto souboru.
Jedna věc, která bude ještě potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři sloupce.
Grafém, jak je výstup.
Jeden poznal.
Fonémy, jak navrhovala [OSOBA2].
A bude tam více řádků s různými variantami fonémů.
A třetí sloupec n bude také stejný pro všechny z nich a opět bude existovat stejná forma grafému.
Takže tehdy vidí jazykový model.
A myslím si, že tímto způsobem by tyto systémy měly být schopny to načíst.
A možná narazíte ještě na jeden problém: že není připraven na dva velké slovníky na míru.
Takže je to také něco, co musí být testováno, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a musíte tyto dvě znalosti spojit dohromady.
Aha, aby to fungovalo s vygenerovaným slovníkem.
(OSOBA4) OK.
(OSOBA6) Takže [OSOBA2], dává to smysl?
(OSOBA2) Jo, jasně, budeme o tom diskutovat.
(OSOBA6) Jo, takže je ještě něco, [OSOBA2], co máš?
(OSOBA2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německé ASR, která může být použita pro časová razítka.
Nejsem si jistý, jak dobré to bude, protože se to snažím udělat na (Libry) Speech.
A i když, když jsem to stahoval, tvrdili, že má více než 600 hodin.
Ale pak školení říkalo, že skutečný tréninkový soubor obsahoval jen asi 300 hodin.
A stále si nejsem jistý, zda těch 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo češtině jsem pozoroval strmější převody.
A teď se to nebude převádět tak rychle.
Takže, pokud vezmeme nějaké vzorky během tréninku.
Pak jsou ve výstupu ASR ještě nějaké závažné chyby.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo to alespoň zkusíme.
(OSOBA17) Dobře, to je dobré, ano.
Takže jsem začal, ale myslím, že jsem vám nikdy nedokončil e-mail, protože jste mi připomněl, [PERSON8], že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že je to také důležitá zpráva pro [PERSON5], která opět zmizela z hovoru.
Takže důležitým poselstvím je, že ano, je velmi dobré, že aktivně tlačíte na to, aby vaše výsledky byly integrovány, a každý by to měl dělat.
A zároveň potřebujeme mít nastavení, abyste jej mohli skutečně integrovat a otestovat sami.
Takže tomu říkám "do-it-yourself integrace".
Takže [PERSON8], když pracujete s [PERSON5] a dokumentujete, jaká jsou nastavení, ujistěte se, že je dostatečně testován kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykového modelu a všichni ostatní.
Takže kdykoli někdo vyvine novou užitečnou součást, celá pipeline by mu měla být přístupná poměrně snadno, aby ji mohl sám vyzkoušet.
Takže tato integrace "udělej si sám" je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[OSOBA4], že?
Filtrování vulgárních výrazů, bylo testováno na protokolech?
Myslím, že ano.
(OSOBA8) Jo, myslím, že to bylo testováno na kládách.
Takže teď je čas otestovat to na živých kanálech.
A opět, myslím, že je lepší, když [OSOBA8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] spustil pro sebe některé pracovníky a živě hrál některé problematické soubory, jako je použití [PROJECT8] nebo cokoliv jiného.
Jednoduše je hrajte.
Sledujte zvukový výstup na vašem zařízení a zjistěte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité ho nejdřív ladit pomocí souborů protokolu a pak je důležité ho ladit v kanálu.
A pokud by toto ladění mohl provést autor této komponenty, zde, v tomto případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Takže, [PERSON8], potvrďte prosím, že souhlasíte s touto myšlenkou integrace typu "udělej si sám".
(OSOBA17) Jo, takže pro angličtinu s více přízvuky.
Takže nyní [PERSON14] to dáváme dohromady do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, spočívá v tom, že vytvoří nové věty se slovy, která byla vyřčena v jiných větách, a bude to dělat napříč různými mluvčími.
Takže to budou opravdu věty s více mluvčími, a proto by se mohla zlepšit i robustnost různých přízvuků těchto mluvčích.
Aha, takže to je jeden částicový experiment.
A později můžeme udělat něco víc s věcí s multi-akcentem.
Takže tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět co největší soubor vět.
A vytvoříme nové věty z čistě textového jazykového modelu přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost pro různé mluvčí bude také lepší.
A ve včerejším rozhovoru jsem slyšel další nápad.
Bylo to během tréninku.
Vynechávali ze zvuku časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech, a to také výrazně zlepšilo robustnost systému.
(OSOBA17) Kdokoli jiný může pracovat na věci s nepůvodním přízvukem.
Ok, pak další věc, kterou jsem si všiml, je - to je v pondělním testovacím dokumentu.
Je zvýrazněn čtyřikrát.
Takže když se koná nějaké zasedání, potřebujeme pro něj názvy a terminologii.
A musíme ji sbírat, připravovat ručně, trochu ji vytvářet.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Takže v tom je určitá dovednost b, kterou je třeba procvičit.
Takže jsem docela zkušený v míchání textových souborů.
A kdykoli vidím, že to někdo z vás dělá, pak mám rád vždy v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme, aby za to byl někdo zodpovědný.
A obávám se, že jediný, kdo by to mohl udělat, by mohl být [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoci s okamžitou adaptací domény, zpracováním dat, prosím, řekněte to.
A pak potřebujeme -
Takže, jakmile jsme zajistili slovník termínů a jakoukoli výslovnost slov, potřebujeme techniky, které tyto slovníky použijí v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal po všechny relace, byl, že to nebylo opravdu viditelné v hybridním ASR.
Takže jedno takové zasedání se uskuteční i toto pondělí.
[PERSON9] již začíná sběr dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJECT5].
Takže možná [OSOBA9] a [OSOBA8], protože se učí, jak provádět adaptaci domény a [OSOBA14], protože dělá, jak pracovat s [PROJECT5].
Pokud byste se vy tři mohli setkat a zkontrolovat, co dělá [PROJECT5] s -
Není to [PROJECT5], ve skutečnosti je adaptace domény pro sadu nástrojů [PERSON18], že.
Takže je to trochu zpátečnické hledění, ujistěte se, že starý přístup funguje.
V současné době je naprosto nemožné provést jakoukoli adaptaci domény pro plně neurální ASR.
Takže to, co zvažuji, je mít nezávislé klíčové slovo spotting ze zvuku a nějaký postup slučování.
Takže bychom mohli mít dvě ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení přizpůsobené doméně [PROJECT5], které se používá pouze k rozpoznání klíčových slov.
A když vidíme klíčové slovo v doménově upravené verzi, pak bychom použili tuto větu z [PROJECT5], která je obecně horší, ale obsahuje správné termíny.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a dělat různé experimenty s jemným laděním a podobně.
Takže jsme o tom diskutovali s [PERSON14].
A [PERSON14], existuje nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
(OSOBA17) Jo, takže pokud je tu ještě někdo, kdo by byl zvědavý, dejte mi prosím vědět nebo se s námi spojte.
Takže je to něco, co by bylo obecně dobře přijato jako papír, protože lidé to ještě nedělají.
A to je nejnaléhavější problém těchto dnů.
Takže bychom tam opravdu mohli mít vliv.
(OSOBA6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat pro to v současné době používáme, protože například, jako když zkontrolujete modely [ORGANIZACE4] na [ORGANIZATION5], že jsou již docela dobří v těchto věcech -
(OSOBA6) A myslím si, že pokud se nám líbí -
Pravděpodobně bychom mohli získat data od nich, protože máte jako tak velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčích na [ORGANIZATION5].
A napadlo mě, že bychom mohli použít nějaký nástroj ke stažení v podstatě některých druhů filtrovaných videí z [ORGANIZACE5] a udělat z nich tréninkové testy.
Takže to plánuji udělat sám.
Mám v plánu tam jet, ale potřebujeme záložní osobu.
A také pro akci [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže archivátor, abychom o tu relaci znovu nepřišli.
A důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A navrhl jsem zde v odstavci pro [PERSON2], že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by rostly.
Myslím, že by bylo asi nejjednodušší dát tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Příprava těchto tabulek může být obtížná.
Zeptal jsem se tedy [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Chcete-li nám sdělit, zda [ORGANISATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli by nám to pomohlo, nebo ne.
Dobře, takže [ORGANISATION242] nedoporučuje [OSOBA7].
Takže jednoduché html je pravděpodobně způsob, jak jít.
Takže jakmile [OSOBA2] má tato hodnocení vyčištěna.
To znamená přesunout těch pár skriptů tam, kam patří, z testovací sady [PROJECT3] a nějakého automatického běžce.
Pak také vytvořte konverzi z tabulek do html podobnou technické konverzi a poté tyto výsledky pravidelně vkládejte na své webové stránky.
Nebo to, co můžete dokonce udělat, je mít kompletní git check out přímo umístěný v tomto veřejném html nebo singling z tohoto veřejného html.
Aby byl okamžitě přístupný přes web a kdokoliv by se mohl podívat na aktuální bodování a prozkoumat to.
Takže by to bylo užitečné, zejména pro m lidí mimo [ORGANIZACI2], jako je [ORGANIZACE15].
Víme, že mají jako -
Výkon byl špatný pro některé soubory, a oni mohli přímo m procházet na webu m.
Mohli by si ji také prohlédnout na [ORGANIZATION101].
Je na vás, abyste ji nastavili tak, aby byla uživatelsky přívětivá a snadno sledovatelná.
(OSOBA2) Dobře, udělám to.
(OSOBA11) Jo, díky.
Nyní pracuji nebo se chystám aktualizovat zaslání demo papíru, které má být vydáno příští pátek, pokud se nemýlím.
A pak mám nějaké projektové zprávy a začínám shromažďovat dokumenty - jako, nebo odkazy na dokumenty, ne dokumenty samotné, pro dvě zasedání.
(OSOBA11) <parallel_talk> Pro ASR bychom také měli přidat bezplatnou metriku -
Ve skutečnosti bychom měli přidat komplementární met - tyto komplementární metriky. </parallel_talk>
Takže jste zmínil jednu a tou je filtrování vulgárních výrazů m hodnocení.
Takže <parallel_talk> mějte explicitní seznam věcí, které se nesmí objevit ve výstupu, </parallel_talk>že?
<parallel_talk> A pak hodnocení vzácných slov.
A tady máme explicitní seznam jmen a termínů, které chceme objevit ve výstupu, bodované nejen podle (řádové) míry</parallel_talk>, ale bodované něčím, co přímo odpovídá těmto věcem, že?
Ano, takže naprosto souhlasím.
To zahrnuje také ruční přípravu reference.
Oba tedy <parallel_talk> potřebují ručně vytvořené reference. </parallel_talk>
Mám jednu poznámku od [OSOBY1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit. </parallel_talk>
Takže by se to mohlo stát prázdnou částí druhé věci vzácného slova -
Takže <parallel_talk> by to bylo vzácné hodnocení slov pro MT a pak z [PROJEC210] pravděpodobně dostaneme i nějaký slovník. </parallel_talk>
Takže to by byla doména [PROJEC210] samozřejmě.
A [PERSON2], mohl bych vás požádat, abyste revidovali <unintelligible/> doménu a vytvořili takový slovník tím, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže jako shortlist - seznam slov, která se nám líbí a nelíbí se nám v <unintelligible/> doméně.
Mohli byste to udělat?
(OSOBA11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Tak to napíšu.
Takže <parallel_talk> směřujeme k termínu [ORGANIZACE62] s titulkovou studijní prací. </parallel_talk>
Ano <parallel_talk> a pak multi-source s [PERSON7] nebo na základě [PERSON7] nebo - </parallel_talk>
A pokud jde o ID jazyka, jsem zvědavý, jak ho chcete přesně integrovat, protože to již zahrnuje zvažování více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(OSOBA13) Bude to zvuk pro textového pracovníka a bude vydávat časová razítka jako pro čtyři nebo dvě sekundy okna a třídu.
<unintelligible/> ticho, česky, německy, anglicky a pak nechám ostatní, jak to chtějí použít.
(OSOBA11) To je důležité.
Prosím, napište to sem do dokumentátoru tohoto <unintelligible/> shrnutí, protože to je pro [OSOBA2].
A také [OSOBA2], když mluvíte s [OSOBA10], dobře a také možná [OSOBA5].
Pokud máme tento nástroj, musíme (dodávat) zvuk více ASR nebo více pracovníkům <unintelligible/>
Budeme muset samostatně (dodat) zvuk do anglického ASR, odděleně do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také k tomuto pracovníkovi ID jazyka a pak potřebujeme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je multizdrojový nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a bude vysílat - pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby ASR mlčel, pokud je to špatný jazyk, a aby to byl rozpoznaný text, pokud je to správný jazyk.
Právě jsem to vymyslel tento typ nastavení.
Dalším nastavením by bylo, že stejný zvuk je dodáván do ASR a této jazykové kontroly.
Tato kontrola jazyka je v podstatě součástí ASR, umlčuje ASR, pokud je to špatný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Takže, prosím, přemýšlejte o tom, co jsou naše potrubí.
V ideálním případě by podle mého názoru nejméně podobné zmatky v řízení a tak dále vznikly, kdyby naše modely MT byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná udělat jen kopii, pokud by angličtina byla uvedena jako vstup, takže bychom měli na začátku vícejazyčné vícenásobné ASR.
Všichni půjdou do angličtiny a pak z angličtiny půjdou do všech jazyků.
A později, až bude mít [PERSON12] vícejazyčný model ASR, nebude toto ID jazyka ani potřeba.
(OSOBA3) Jde o to, že pokud budeme provádět analýzu správněji, jednou věcí je možné kontradiktorní hodnocení, jen abychom naznačili, že omezení mají skutečně dopad na skutečný výstup.
Že by to bylo hezké a ano, možná analýza pozornosti.
Ale nejsem si jistý, jestli by nám to mohlo dát stejné odpovědi, v podstatě, pokud se model účastní nebo nevěnuje omezení.
(OSOBA4) Musel jsem se podívat jen na několik příkladů pozornosti, nedělal jsem žádné statistiky nebo něco takového, a to se dívá na omezení, a když převádí omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti v tomto smyslu žádné nedělá.
Dělá některé obecné chyby v překladu, ale ne (jevy), které se snažíme vyřešit.
Když se vrátíme k automatickému vyhodnocení, problém s nesouladem je, že výstup je správně skloňován, ale kontext je jiný.
Není to tedy stejný slovní tvar jako v odkazu, že?
(OSOBA4) Ano, ale také jsem zkontroloval, zda jsou kontexty platné překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly označeny jako chyby automatickým vyhodnocením, 91 z nich bylo správně skloňováno ve správných kontextech.
(OSOBA4) A myslím, že jen dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako by překlad byl špatný.
A pak jsou případy, kdy byl překlad úplně špatný, protože věta byla opravdu špatná a ta část musí být <unintelligible/>, ale to bylo jako jeden nebo dva případy.
(OSOBA3) Ale vy se snažíte sladit formy odklonu, když to vyhodnocujete, že?
Neděláte žádné-
(OSOBA3) -lemmatizace reference a
(OSOBA4) Oba, oba, oba, obojí, shoduji jak povrchové formy, tak lemma.
(OSOBA3) Ach vidím, ach ano, to jsou dvě skóre, že?
(OSOBA4) Je to jen dilema, skóre pro (evropské?) není v tabulce, protože tabulka jako se nevejde do papíru, takže <unintelligible/>
Pokrytí je vždy jako 97 procent.
Prostě generuje správná lemmata, jen -
(OSOBA3) Ach ano, dobře, chápu to, chápu to.
Takže v podstatě lemma pokrytí říká, zda existuje omezení, a rozdíl povrchového pokrytí naznačuje, že by mohlo být nesprávně skloňováno, ale není tomu tak.
(OSOBA3) Ach ano, jen nevím, jestli vy, pokud jste, jestli jste chytili<unintelligible/>, když jsme mluvili o [OSOBA1],
Ale jedna věc je, že (rána) je lepší, ale druhá věc je, že lemmata jsou ve skutečnosti správně skloňována ručně,
Ale to je další, ne, žádný problém, je to vlastně dobré, co je <unintelligible/> správné, ano.
Tak jsem si říkal, že by to tak mohlo být.
Ale nejsem si jistý, jestli pro to máme nějaká testovací data, ale mohli bychom se pokusit pohrát si s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít omezení a zkusit místo toho použít synonymní omezení a podívat se nebo porovnat jak, jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to jen vágně popisoval, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakém přenosu dat stylu pro anglickou češtinu? Máme něco?
(OSOBA4) <unintelligible/>
(OSOBA1) Přenosem stylu, Dušane, myslíš, že by tam bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, bylo by to v mluveném jazyce nebo něco takového?
(OSOBA3) No, to je ta věc jako, mám jen omezené znalosti o úkolu.
Ale dokážu si představit, že chcete přepsat větu, kterou nenapsal muž, ale místo toho ji napsala žena, nebo, nevím, jako můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem opravdu obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenka spočívá v tom, že styl vět je poměrně vágně definován.
Takže znovu, není si tak jistý.
(OSOBA1) Máme tento korpus větných transformací.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například zobecnění vět.
Takže detaily jsou vynechány, věta je zjednodušena a pak věta zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení Matous dělá nějaký experiment s angličtinou – češtinou, ale nemáme tam žádná referenční data.
Nemáme tedy žádnou datovou sadu komprese vět.
Takže možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediný odkaz by byl příliš omezený, aby vám řekl něco o kvalitě vašeho zobecnění.
A nevím o žádné podobné genderové transformaci, například by se to dalo udělat <unintelligible/> pro češtinu, takže možná by byl ten správný člověk Rudolf Rosa, který by se ho zeptal, jestli někdy vygeneroval nějaký takový dataset.
Takže tam bude kořenové generování nějakého větného protějšku.
(OSOBA3) Myslím, že je to vlastně jako zajímavá otázka, zda můžeme použít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(OSOBA1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní dílčí část testovací sady [PROJECT1], která by to pokryla.
Ah, abychom někdy znali pohlaví mluvčího, takže pokud jste...  možná budu sdílet obrazovku a procházet to.
(OSOBA8) Nebo jsem to zkusila s Marianem, který se jí zúčastnil a je to... Nevím, o kolik bodů BLEU nižší.
(OSOBA2) Protože stejně jako Martin dělá svůj <unintelligible/> malý překlad, tak překládá více vět najednou a pak si vybere jen tu prostřední a takto jde pro celý dokument.
Takže kontext je jako v jedné <unintelligible/> spolu s větou, kterou vlastně chceme přeložit.
(OSOBA10) Jo, myslím - nebyl to Dominik, který dělal nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva roky pro dvojité prázdné, kde navštěvovali kontext nebo spojovali kontext se vstupní větou a dělali nějaký překlad na úrovni dokumentu.
Ale věc je, že s tím zřetězení není zcela jisté, zda má stejný účinek jako nastavení multi kodéru -
(OSOBA1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje tečka.
(OSOBA8) Jo, dobře, tak se omlouvám, možná bych měl být správnější, že to nefungovalo tak, jak jsem to <laugh/> udělal
(OSOBA1) Ano, protože si myslím, že je to metoda, která je velmi snadno testovatelná, a vždy by měla být testována na rozdíl od dvou kodérů a očekával bych, že někdy bude lepší a někdy horší než dva nastavené kodéry, v závislosti na přesné úloze, jako je to, co přesně je druhá věc, kterou kódujete.
Takže možná, pokud máte dvě kopie dvě parafráze stejné věty,
možná je to nějak matoucí pro pozornost, takže co, nevím.
Chování také mohlo být odlišné pro staré metody sekvence k sekvenci, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak, možná s transformátorem je to ano, je těžší trénovat, takže možná potřebujete zvýšit počet zahřívacích sad, zahřívacích sad.
(OSOBA2) Jo, tak prostě vím jako-
(OSOBA8) Nepamatuji si, takže si to přesně nepamatuji, ale tohle je jako co-
když jsem v létě začal s těmi vícezdrojovými experimenty.
První věc, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná, teď si nepamatuji,
Mohu to zkontrolovat do další schůzky, zda jsem to také zkusil,
Určitě jsem to zkusil, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Mohl jsem také zkusit, že jsem zamíchal dvě věci náhodně, ano, a jen si pamatuji, že to dělalo hojně tyto věci a zkoušel multi-enkodéry.
(OSOBA8) A bylo to pravděpodobně kvůli nízkému skóre.
(OSOBA2) <unintelligible/> to, co se vám líbí, může zlepšit vaše skóre pohodlí pouhým připojením výstupu založeného na frázích a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže jako vám věřím, ale je překvapující, že to nefungovalo.
(OSOBA10) Takže, pokud zadáte výstup založený na frázích, je to v podstatě editace po úpravách, že? Můžete o tom přemýšlet jako o posteditaci, jako byste posteditovali frázový výstup, že? Nebo jako záleží na úhlu pohledu, že?
(OSOBA1) <unintelligible/> že to chcete plně přepsat, ale technicky to přesně vyhovuje úkolu posteditace, můžete to připojit jako řešení úlohy posteditace.
(OSOBA10) Dobře, takže jedna otázka jen pro mě, jen abyste se ujistili, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální token k rozlišení, jako je to, který je zdroj a který je kontext nebo druhá věta, nebo je jen zřetězíte bez ničeho?
A doufat, že se to systém naučí?
(OSOBA8) Snažil jsem se, myslím, že dva tokeny a ano jako, protože v první verzi jsme měli podezření, že token by mohl být tokenizován i sám, takže jsem to pak přehrál s jiným tokenem, který není jen pro tento účel, protože jsme použili nějaký předem natrénovaný slovník a tento slovník neobsahoval oddělovací tokeny.
Takže jsem použil nějaký žeton, u kterého jsem předpokládal, že to nebude jako žetonizované na několik kusů a tak se to jednou objeví.
Neměl jsem žádnou záruku, že se tento žeton nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže by to mohlo být provedeno správněji, ano, souhlasím.
(OSOBA2) Ale baňková část nebo komunikační část s klientem je něco, co nemohu udělat.
Protože nemám žádné zkušenosti a nemám čas to rozběhnout.
(OSOBA1) Myslel jsem, že to znamená něco pomocí neznámého prostředníka.
(OSOBA2) Ne, vytvořte HTTP klienta, který může naplnit frontu a číst z jiné fronty.
A odešlete text zpět v požadavku HTTP.
Protože moje představa je, že uživatelská kliknutí by měla být použita i v ukrajinském projektu.
(OSOBA2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk v malých kouscích současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dejte do fronty, se kterou budu frontu zpracovávat později (ASR).
A model s tím udělá nějakou logiku, nějaké závěry.
A kdykoli má nový přepis, pošle jej zpět a uživatel by měl dostat částečný přepis zpět.
A měl by být okamžitě zobrazen v textovém poli.
(OSOBA1) Mohl bych o tom přemýšlet.
Jen Flasku taky moc neznám, ale ano, můžu o tom přemýšlet.
(OSOBA2) Možná jiný HTTP server.
Nevím, možná na to ani nepotřebujeme luxusní HTTP server.
(OSOBA1) Myslím, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo.
(OSOBA2) Ano, jediným požadavkem je, aby zpracovával více připojení najednou.
(OSOBA1) No, myslím, že online tok textu je něco kolem 2 000 minimálně.
(OSOBA1) Mám na mysli skript, který mám ve dvou různých složkách a pak ho spustím s malými různými vnitřními pracovníky, takže myslím, ano, takže mám <unintelligible/> deset, no, místo výstupu, soubor vedlejšího <unintelligible/> pracovníka, takže máme, takže <unintelligible/> se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
(OSOBA1) Ach, to by nám ušetřilo čas.
(OSOBA7) Ano, ano, to je velmi důležité paralelizovat všechno vlastně, paralelizovat jak zpracování systémů, tak i vyhodnocení buňky DF, protože by to musel spustit mnohokrát, budou chyby, musíte to znovu spustit rychle.
(OSOBA7) Dobře, takže díky.
Takže jste s tím velmi zaneprázdněni, nechci na vás dávat žádné další věci, takže mi dovolte začít s připomenutím.
Musíme dokončit popis [PROJECT1] stolní soupravy,
Koho tu máme?
No, ne tak docela, ano, (je to hotovo) a není to tady, bohužel.
Takže by to bylo pro [OSOBU2],
Pak hodnocení, to je pro [PERSON1], ale diskutovali jsme o tom.
Poslouchejte, dejte mi tabulku v DSD, pojďme sem dát jemnou čáru a posunout šablonu tabulky, jako je struktura plánu do deleblu, takže čísla přijdou později, ale chci vidět nějaká čísla a celou strukturu tabulky velmi brzy.
(OSOBA7) Dobře, děkuji.
Máme [PERSON5], to je dobré.
Takže pro [PERSON5] bych rád zjistil, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také pro vývoj, který je důležitější.
Slyšíš nás, [PERSON5]?
(OSOBA1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
(OSOBA7) Jo, tak je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(OSOBA7) a shromáždíte všechny výstupní soubory a potom spustíte vyhodnocení.
A důvodem tohoto rozdělení je, že můžete více paralyzovat.
Takže jsem si jistý, že problémy budou na různých frontách a čísla budeme potřebovat velmi brzy.
Pokud tedy například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále nechat překlad běžet pro ty zbývající,
a přehodnotit se selem T F, chybějící a tak dále.
Takže nejde o to vytvořit sériové, sekvenční zpracování, které zahrnuje obojí,
Ale jde o to získat výsledky a je vlastně lepší to udělat v řezech.
Nejprve získáme všechny výstupy, pak dostaneme všechna hodnocení.
(OSOBA1) Jo, takže, chci říct, právě teď jsem dělal to samé.
(OSOBA2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu komplikovanějšího v dekódování.
Stejně jako odfiltrování paprsků a nahrazení nosníků jinými paprsky.
A pro omezení více tokenů a podobné věci.
Ale pro pozitivní omezení jsem pouze porovnával tréninkový přístup s ano, jen s těmito velmi jednoduchými věcmi.
Jen upravit skóre v každém kroku stejným způsobem.
(OSOBA7) Dobře, takže zpět k pozitivním omezením.
Zaměřili jste se již na analýzu systému?
(OSOBA2) Jo, právě teď tak nějak čekám na opětovné zpracování datové sady z ([PERSON9]).
Také [PERSON9] jsem se podíval na (kód) a myslím, že vím, proč je tak pomalý.
Protože pro každou položku v terminologii v opětovném zpracování (Europar) otevřete datovou sadu, tokenizujete ji, přečtete ji řádek po řádku, tokenizujete ji řádek po řádku a pak ji zavřete.
Ale vy to děláte jen vy -
(OSOBA4) Takže si vzpomínám, že pro [PROJECT1] jsem to dělal z loňského roku z nějaké chaty v horách.
A já jsem si krátce před Silvestrem uvědomila, že to musím odevzdat.
A <laugh/> tak je to také něco, co se stane [OSOBĚ8], obávám se, že by mohl být... No, žádná párty, ale možná na vzdálené párty.
A pak by si najednou uvědomil, že to musí odevzdat.
Takže v tomto bodě nebude žádná revize podobných. <laugh/>
Jednoduše by vzal PDF a nahrál ho tak. <laugh/>
(OSOBA7) No, dobře.
Takže ano, podívám se na 21. a jinak jim pošlu e-mail.
(OSOBA4) Prosím, myslím, že je lepší poslat jim e-mail právě teď a požádat o tento odkaz předem.
(OSOBA7) OK.
(OSOBA4) Jo, díky.
(OSOBA7) Máme dnes další otázky, o kterých musíme diskutovat, nebo je to všechno až do Nového roku?
(OSOBA6) Doufám, že pro mě nic nebylo?
(OSOBA3) Před několika lety.
MT maratony mívaly tento systém nebo nástrojové papíry, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálními, jako tam byly také PBML emise, které míchaly prázdné okrajové papíry a samostatné papíry kvůli počtu těchto papírů.
A dokonce jsme měli něco jako kdyby papír nebyl dost dobrý pro PBML, ale kdyby byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další číslo PBML.
Takže máme, i když jsem řekl, váš systém, váš nástroj je zajímavý.
Zveřejněte to prosím na MT maratonu mezi lidmi.
Ale váš papír je příliš špatný.
Musíte to vylepšit a dostanete se pouze k dalšímu PBML.
(OSOBA4) Ano, ale další možnost pro SIGDial.
Není možné, že vyzkoušením SIGDial přilákáme lepší účastníky?
(OSOBA3) To je ano, to je... jako jsem si myslel, že jsem také měl, ale neznám ani jedno z míst.
Poslední papírovou registraci mají v červenci.
Takže konference byla v září a odevzdání příspěvku bylo v květnu.
Protože pro Interspeech bychom to také mohli rozdělit papír po papíru.
Aby některé příspěvky šly na jednání Interspeech.
A některé z našich dokumentů by přišly později na jednání PBML.
A autoři by si mohli vybrat.
Takže to musíme vyjednat buď se SIGDial nebo Interspeech.
Pokud je v pořádku, aby měli některé z našich dokumentů, vzhledem k tomu, že tyto dokumenty jsou předloženy do březnového termínu.
Existuje tedy absolutně přísný požadavek.
A myslím, že proti tomu nemohou mít nic.
Protože pokud článek stojí za publikování.
Stejně jako je to jen bonus, že papír má nějaký výsledek sdíleného úkolu, který se objeví v satelitní události.
Takže ano, myslím, že je to v pořádku.
Takže nemusíme žádat o zvláštní zasedání.
V Interspeech se tomu říká speciální sezení, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj příspěvek připraven do termínu Interspeech, pošlete jej jako Interspeech papír a budete ho mít v Interspeech.
Ach, pokud ne, ach, udělejte to pro termín Interspeech, tady je náš termín.
A to je pro PBML.
(OSOBA7) Aha, dobře.
Ale je to jako pro satelitní událost Interspeech.
Ehm, Interspeech jako se nedostane do žádného řízení.
(OSOBA2) Můžete si vyhradit celý semestr jen na kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že to opravdu není věc, která by selhala v jeho kurzech.
Rádi selháváte, protože to nejste schopni dokončit.
Samozřejmě, jako by to lidé jen vzdávali, ale myslím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že je to určitě možné, ale je to spousta práce.
(OSOBA1) Jo, myslím, že nám na začátku semestru řekl, že když budeme chtít jedničku (??), dostaneme jedničku.
Právě ve druhém termínu byste ji měli odeslat.
To je v podstatě jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů předchozích let, mnoho lidí to nedělá.
Na zkoušku se jim čte snadněji.
Ne, omlouvám se, učte se na zkoušku-
(OSOBA2) Ano, protože obecně jsou jeho zkoušky poměrně snadné.
(OSOBA2) Takže bych neřekl, že je to super snadné, protože jsou kurzy, kde je zkouška jako zábava.
(OSOBA1) No, jeden z nich byl včera pro mě.
(OSOBA2) Jo, když to má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se to opravdu zavazuje k něčemu, co například za sekundu nebo dvě zjistí, no, vlastně to byl špatný překlad.
Snaží se tedy použít jinou formulaci.
Například specifikovat věc.
Takže se mi to vlastně moc líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když bylo vidět, že model udělal chybu na první pokus, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita způsobena překladem, pokud si přečtete vše, co dostanete stejné informace, ale formulace je prostě špatná, protože používá například více slov a používá nějaké opravy a tak.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako některé příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
(OSOBA2) Určitě, můžu ti vyhodit své kulatiny.
(OSOBA7) Ale v jakých jazycích?
Protože víte, že nemluvím německy.
(OSOBA2) Angličtina a němčina.
(OSOBA7) Jo, ale nemusím nutně mluvit německy<laugh/>.
(OSOBA2) Pak mohu poskytnout angličtinu-čínštinu a angličtinu-japonštinu, pokud to pomůže<laugh/>.
(OSOBA2) Takže znovu chci udělat to lidsky čtivé.
Protože toto blikání je opravdu otravné a pak ztratíte zaměření na to, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a o tom, jak pracujeme s informacemi.
Omlouvám se, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoli vidím slovo, dávám si ho do paměti a moje paměť není lineární věc, ale je to spíše jako pytel.
Tak jsem dal slovo do pytle.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je problém s blikáním.
Když něco přeložíte a pak to změníte, tak už jsem to vlastně četl, mám to v hlavě.
A pak ztrácím soustředění a kontrolu nad tím, co bylo skutečně přeloženo jako správné a co nebylo.
Takže to je důvod, proč si myslím, že celá ta věc s blikáním je z definice špatná a hloupá.
Jako já vidím motivaci, jako byste chtěli ukázat vše, co máte.
I když nemůžete slíbit, je to dobré.
Myslím si však, že s těmito dodatečnými informacemi nemůžeme pracovat.
A myslím si, že možná problém je v tom, že systémy jsou vytvářeny lidmi, kteří s tím pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslíbím, že překlad je správný, stále ho ukážu a je to nějak dobré, ale myslím, že vývojář se opravdu nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíše, že můj systém to dokáže vyprodukovat opravdu rychle.
A i když to jen hádá, že kvalita je v pořádku, myslím, že možná proto byl vytvořen repřeklad.
Jen vývojáři systémů dychtivě zobrazují informace a myslím si, že protože jsme omezeni v množství informací, které můžeme někdy vnímat, rádi vidíme, že další informace jsou pro nás jen další zátěží.
Takže si myslím, že není dobré ukazovat navíc.
Stejně jako pokud chcete snížit latenci, pak místo blikání stačí snížit kvalitu.
Myslím, že je to pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste vlastně potřebovali vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(OSOBA1) Stejně jako technicky, když lidští překladatelé začnou překládat, myslím tím cíl, který je i pro anotátory, by se snažili sledovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatné, takže by se prostě opravili.
(OSOBA2) No, ale ano, to znamená s mým řešením, jako byste neblikali, ale zavázali jste se, jako že neexistuje způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(OSOBA3) Silně cítím, že naše práce není přímo v oblasti řeči, je nezdravá.
Protože zde není žádný koncept řeči.
Pracujeme přímo na textu.
Ale jde o to, že návrh na letošní statistický seminář skončil, což bylo v září, což bylo pro nás příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme jednu ze dvou sektilních nebo interspeech, protože oba jsou v komunitě dobře známí.
Umíme motivovat účastníky, aby se přihlásili.
Ach, jediná námitka, kterou teď zjišťuji, je interspeech je, že nám nedají prostor ve sborníku, což může odradit některé účastníky, nejsem si jistý, jak moc budou nadšeni, že publikují článek v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, ne?
Takže to není přínos pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
Takže to byl důvod, proč jsem se za toto zvláštní zasedání zaručil především.
Ale tentokrát je problém v tom, co chápu, že naposledy, doba mezi podáním a konečným podáním papíru byla pět měsíců, takže by to bylo dost času na náš rozvrh, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vnímám jako důležitý možný zdroj nerodilé angličtiny, kterou můžeme použít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na soutěž o nejjasnější hlas a můžeme udělat kabinu, pokud budeme muset.
Ale rád bych to omezil, protože šíření mezi studenty středních škol je pro nás menší dopad.
Je důležitější jej použít jako testovací relaci.
Takže bychom se měli zaměřit, [PERSON1], na [PROJECT2] nejjasnější hlas a udržet organizátory spokojené, abychom tam mohli sbírat data.
A dělat to, co chtějí, abychom výměnou za to udělali, a my musíme zkontrolovat jejich program plenárního zasedání a jaký typ titulkování by byl pro tento plenární program užitečný.
Takže by to pro nás byla zkouška, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud jsme požádáni, jestli se od nás opravdu očekává, že tam budeme a přítomni, pak dobře, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
(OSOBA1) Jo, ještě jsem se kvůli tomu nepokoušel o registraci, ale myslím, že minule bylo povinné mít stánek.
(OSOBA2) Ano. Diskutujte s nimi tedy o tom, co je potřeba, aby byli šťastní, a oni nám umožňují dělat nejjasnější hlas, což je nejdůležitější věc.
Testovací sezení je méně nutkání.
A stánek je prostě něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se připojili k sezením dříve, než aby dělali takové věci.
Takže opravdu potřebujeme praktikovat tyto přípravy.
S online světem se zdá, že prostě j p do sezení a práce je hotová.
Tak tomu ale není.
Vždy trvá 30 minut, než se spustí a správně připojí.
Takže tam musíme být dříve.
A když nějaký trénink, který děláme, začíná v devět, ale organizátoři se sejdou ve tři čtvrtě na devět.
Pak už musíme přijít ve čtvrt na osm, abychom měli 30 minut navíc, abychom se ujistili, že všechno běží a honí lidi.
Takže to je poznámka pro všechny, že aby vedení pracovalo, předvídejte také, co po vás vedení může najednou chtít, a to by trochu pomohlo.
Dalším poselstvím, které je velmi důležité, je záznam těchto důležitých zasedání.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto sezení.
Takže pro účely dalšího vyhodnocení nebo analýzy toho, co se pokazilo, je důležité mít dobré záznamy těchto sezení.
A jedním z aspektů je získat souhlasy, aby bylo skutečně umožněno nahrávat to.
A to i v případě, že se snažíme získat souhlasy zpětně nebo cokoli jiného.
Pak je tu technická stránka nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [OSOBA5] posílá tento odkaz.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citrony v řadě :(
Objednal jsem si od této společnosti, protože jsem ji koupil v předchozích sezónách a fungovalo to pro nás skvěle.
Tuto sezónu jsem si koupil další velikost, kterou jsem potřeboval.
Jedno z pyžam, které jsem dostala, mělo díru na patě pyžama.
Vrátil jsem ji a firma mi poslala novou.
Náhradní pyžamo, které měl můj syn na sobě, jsem ho dal do pračky jako vždy a zip se utrhl!
Jsem tak zklamaný, protože nemám čas řešit návraty každých pár dní, a přesto se to právě teď děje.
Přesně tak, jak je popsáno
Jedná se o základní puffer kabát.
Pokud hledáte základní srst, pak tato srst splní očekávání.
Kabát dorazil ve vakuově uzavřeném sáčku, takže je třeba ho na několik dní pověsit, aby se vrásky vynořily a trochu se "nafoukly".
Jsem 5 stop 6 palců a kabát je na mě dlouhý po kolena.
Objednal jsem si 2+ velikosti kvůli jiným připomínkám a minulým zkušenostem a srst je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale žádné vazby na ní.
Přední zip funguje.
Na boku ani vzadu nejsou žádné větrací otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek prostoru.
V pase mám dvě kapsy (mohou být na tobě vyšší nebo nižší).
Nejsou zde žádné ozdoby ani stylingové detaily - je to ZÁKLADNÍ kabát.
Za cenu si myslím, že je to v pořádku.
Nosil jsem ho ve větrném dni, ale ne v zimě.
Necítil jsem vítr, takže cítím, že je to dobré znamení.
Jsem však zvědavý, jak to bude fungovat v chladnějších teplotách a v dešti / sněhu (má být odolný).
Celkově jsem spokojen.
Vakuový těsnicí sáček lze znovu použít a prodávající zahrnul opravdu roztomilé poděkování, které bylo skvělým dotykem.
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a měkký
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a měkký.
Nemačká se, ani po napěchování do igelitu a krabice to bylo velmi hladké, takže je to opravdu skvělé.
To může být snadno oblečeno nebo oblečeno a má jakýsi vinobraní pocit kvůli délce a střihu, který jsem opravdu rád.
Myslím, že by to mohlo být lichotivé pro každého.
Jsem 5'5 "a 130 liber a objednal jsem si malé, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně velikost dolů.
Nepracoval s mým 1999 Buick LeSabre
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce i předinstalovaná baterie.
Nicméně, i když by měl být kompatibilní s mým Buick LeSabre z roku 1999, dálkový ovladač se nepodařilo naprogramovat nebo synchronizovat s vozem.
Pokyny jsou dostatečně jednoduché a vím, že jsem je dodržoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý dálkový ovladač.
Tento nový by však nefungoval, a tak ho budu vracet.
Nebyl žádný problém s prodejcem nebo službou, jen se zdálo, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta byl roztrhán velkým něčím, co letělo po dálnici, takže jsem potřeboval výměnu.
Po přečtení některých recenzí jsem se bál, že by se to nehodilo, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Nedala jsem si to na sebe - měla jsem chlapa v karosárně, který to udělal za mě - ale vypadalo to opravdu jednoduše.
Prostě se to rozsvítilo za méně než 5 minut.
Dal jsem mu 4 hvězdy za robustnost, protože se zdá být docela chatrný (čas a létající trosky řeknou), ale celkově jsem velmi spokojen, že moje auto už nemá zející chřtán na přední straně a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Můj 5letý absolutně miloval toto světlo Netrvalo to dlouho, dostal to na své narozeniny v lednu, je to únor, už má potíže s tlačítky a neběží jasně se zástrčkou, spotřebovává baterie, dokonce se pokusil dobíjet baterie Super cool, ale potřebuje zlepšení
Hudební start
Klavír je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci rukou a očí.
Klavír není jen hračka, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě bylo budoucím pianistou, měli byste tento produkt vyzkoušet!
Velmi stojí za to peníze!
Dal jsem si to na nos podle pokynů dvakrát denně a vtíral jsem to po dobu 2 minut.
Kůže na nose mi zčervenala a úplně zrudla.
Dost mě to zaskočilo.
Měl jsem dobře zahojenou jizvu z pádu do ostnatého drátu před lety.
Nejen, že tento produkt nefungoval, ale málem jsem skončil v ordinaci dermatologa, nicméně uvedení aqua-foru a náplasti na oblast nakonec asi po týdnu uklidnilo.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo pokazil vzorec??
To je tak divné.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí tyčinky od jiné značky, abyste viděli, jak by růžová měla vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červenou nebo růžovou.
Bílá není tak jasná, jak bych doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy smývají.
Prostě jsem tam byl růžový.
Myslím, že fialová bude stačit.
funguje z větší části
Před několika měsíci jsem si vybělil celou hlavu a pak ji obarvil černou krabičkou.
Pak jsem šel a nechal si dát melíry po celé hlavě.
O několik týdnů později jsem si na vlasy nanesla modrozelenou barvu na vlasy Arctic Fox a ta nevybledla.
Použil jsem tyto věci s Olaplexem č. 3 a ohromně se zesvětlil po celém těle, odstranil zelené a modré části, stejně jako zvedl tmavé barvivo.
Po dni jsem si však všiml zeleného odstínu vlasů.
Každý den se to zhoršuje a já jsem použil barevný extraktor dvakrát, se stejnými výsledky.
Moje vlasy také tmavnou tam, kde byla krabicová barva.
To je skvělý produkt, jen se zdá, že nevydrží.
Nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román musí být mírněno některými realističtějšími hodnoceními.
Snažil jsem se to přečíst, ale zjistil jsem, že jazyk je plochý.
Metafora "sladkovodní" a mnoho popisů dělohy jako řeky a dítěte jako ryby se zdály nucené, otřepané a vykonstruované.
Přeskočil jsem dopředu a vypadalo to, že jediné, co najdu, je drama v kampusu.
Dávám této knize 10 hvězdiček!
Výborné čtení! !
Absolutně jsem miloval knihu! !
V průběhu let jsem adoptoval 4 siamské kočky ze Siri a všechny z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Legrační, vtipné a velmi zábavné! !
Siri šla nad rámec svého úsilí o záchranu koček (hlavně siamských)! !
Opravdu se mi líbí toto kruhové světlo!
Je to skvělé za cenu a dělá to práci!
Jediným problémem je, že žárovka se zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji znovu zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám vadné světlo nebo co, ale kromě přehřátí je to velmi pěkné kruhové světlo.
Matoucí děj
S knihou bylo těžké držet krok, protože hodně poskakovala.
Také název neodpovídá příběhu.
Autor naznačil, že několik lidí bylo nakaženo tímto mimozemšťanem, nicméně vynecháno může podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a hodně číst, abych se ujistil, že mi nic neuniklo.
Miloval Collinse. . .
Chvíli trvalo, než se Grady zahřál
3 1/2 hvězdičky Remedy je bratr nejlepší přítel romance, stejně jako druhá šance romance smíšená do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše, aby dostal Collinse zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostává všechno, o čem snila, nejlepšího přítele svého bratra... Ale když se ráno probudila sama a nikdy o ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpátky a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel a že se jí tentokrát nevzdá.
I když se mi líbila premisa tohoto příběhu a občas i Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale že ani neposlat dopis Collinsovi, ve kterém by vysvětlil sám sebe?
Nechat ji celé ty roky žasnout a trápit a pak očekávat, že ho přivítá zpátky s otevřenou náručí?
Klamal?!
Collins měl pravdu, když byl naštvaný, naštvaný, zraněný atd.
Měla pravdu, když se s ním pohádala, když ji chtěl zpátky a pohnula se kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collinsovou v této knize, byla silná a střežila si své srdce a já ji za to obdivoval.
Jistě, milovala Gradyho, ale bála se a váhala, jestli ho pustit zpátky do svého života, kdo by netoužil po tom, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně nechala věci plynout tempem, které chtěla, a když byla připravena poslouchat, poslouchala.
V téhle knize je hodně úzkosti a já jsem si užil sledovat, jak se ti dva znovu spojili, když Collins začal odpouštět Gradymu, jen bych si přál, aby Grady nepůsobil tak ufňukaný a byl trochu chápavější.
Pořád říkal, že rozumí, ale občas byl ke mně trochu moc vlezlý a ke konci byl sladký.
Nakonec jsem ho miloval stejně jako Collinse, ale na začátku knihy jsem měl problém číst jeho názory, protože jsem se nemohl spojit s jeho postavou.
První část této knihy nebyla moje oblíbená, ale druhá část?
Zbožňoval jsem, proto mé hodnocení.
Pokud máte rádi druhou šanci a románky nejlepších přátel bratrů, možná se vám tato kniha opravdu líbí, jen jsem měl zpočátku těžké časy s Gradym a s tím, jak se vypořádal s některými věcmi, které udělal.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla, bylo to velmi dobře provedeno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otočných stránek...
Scenérie a kostýmy byly vynikající.
Je dojemné s dnešní dvojicí polobohů, kteří zastávají světové politické pozice.
Stojí za to podívat se několikrát. . . stojí za promyšlené přemítání... mnohokrát
Vyhněte se připojení Wifi - jděte Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydlení v hotelu.
Nemohl jsem dostat tuto stupnici, abych se připojil k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domu a budu si moci nastavit vlastní Wifi systém.
Březen 2018 - Nastavil jsem svůj systém Wifi a tato váha se stále nepřipojuje.
Pokaždé, když se pokusím, zobrazí se chybová zpráva.
Dokonce i když jsem 10 'od jednotky Wifi.
Sledoval jsem video nastavení YouTube bez úspěchu.
Když jsem koupil jednotku, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato váha používá směrovač Wifi ke komunikaci s telefonem.
Tento systém je omezen na připojení routeru... který obvykle není blízko ložnice, na rozdíl od mobilního telefonu!
Tuto stupnici bych nikomu nedoporučoval kvůli připojení Wifi.
Místo toho se prosím podívejte na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to měřítkem připojení Bluetooth.
Dobře, ale chtěl bych najít něco lepšího
Po velkém výzkumu jsem začal používat tento produkt před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval dobře.
Nicméně, to vyschne tak rychle, že skončíte s použitím tolik lubrikantu, který nakonec stojí spoustu peněz, stejně jako je příliš rušivý během sexu.
Byl jsem příliš líný hledat nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš nákladný.
Životnost baterie je hrozná na tom, který jsem koupil na Amazonu.
Stále nemůžu uvěřit, že Logitech tento dálkový ovladač ukončil, nic jiného se ve srovnání s tím neblíží.
Absolutně miluji tento dálkový ovladač Harmony, toto je můj 4.
Pes rozkousal první, manžel klečel na obrazovce druhého a třetí stále funguje, ale uprostřed dotykové obrazovky je značka lokte také díky manželovi. . . koupil tento jako zálohu a obrazovky skvělé, ale baterie, se kterou přišla, drží poplatek možná na pár dní.
Můj původní (3.) udržuje nabíjení po celé týdny a používám dálkový ovladač pro všechno.
Zlomil se za méně než týden
Líbí se mi produkt, je to pěkná velikost a barva!
Bohužel to měl jen týden a otevřel jedny dveře a praskl horní část dřevěného kusu!
Jsem opravdu zklamaný!
Je to všechno sestavené a já už nemám krabici, tak jak bych mohl vůbec přemýšlet o tom, že ji pošlu zpět?!
Můj manžel se to snažil opravit lepidlem na dřevo, ale bohužel to také nefungovalo!
Dveře se znovu vynořily! !
Není příliš snadné sestavit plus....
Je to pěkně vypadající kus nábytku při montáži, ale montáž byla obtížná.
Některé písmenné značky byly nesprávně označeny, takže jsem se musel pokusit přijít na to sám: šrouby, které dodali k připevnění podlahy a bočních panelů, byly všechny prasklé.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také dveře skleněných panelů jsou mimo řadu a neodpovídají rovnoměrně.
Toto vyrovnání zabraňuje tomu, aby jedny z dveří zůstaly zavřené, protože magnet, který udržuje dveře zavřené, je mimo řadu.
Stále jsem nepřišel na to, jak je zarovnat.
CHYBNÝ KÓD VYTIŠTĚNÝ NA HORNÍ STRANĚ KAPSLE
Koupil jsem je v únoru.
Nedávno jsem se je snažil použít a bohužel pokaždé, když zkusím jeden, můj stroj Keurig mi dává chybovou zprávu, že pod není kompatibilní s mým strojem.
Používám kapsle Donut Shop ve svém stroji od doby, kdy jsem ho poprvé zakoupil a nikdy jsem neměl problém.
Při bližším zkoumání kávového lusku jsem si všiml, že kód vytištěný na horní straně kapsle není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jeden z každého z 6 boxů a stále dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože ostatní lusky, které zkouším, fungují dobře.
Je to jen z této zásilky, že mám tento problém.
Velké zklamání, protože mé návratové okno vypršelo.
UPDATE: Mluvil jsem se zástupcem zákazníka, který vrátil peníze.
Děkujeme společnosti AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestách.
Takové pohodlí!
Je opravdu hezké mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích!
Miluji vychýlení a je tak pohodlné mít je v kabelce na večeři nebo k použití v domě přítele.
I když jsou trochu drahé, nemohu vystát Equal nebo růžové věci v mém ledovém čaji.
Uhnout nebo nic, takže jsem nadšený, že mám své sladidlo na cestách!
Ve skutečnosti neprovádí žádné "čištění" vzduchu
Koupil to jako zvlhčovač, část "čištění vzduchu" je ve skutečnosti falešná reklama; V závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych jej hodnotil jako o něco méně účinný než zvlhčovač typu knotu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně budete muset provozovat asi 5 let, abyste dosáhli rozdílu.
Na svou velikost má poměrně velkou kapacitu vody, protože "nádrž" je nedílnou součástí jednotky a má nízký výkon (i když ne lepší než typ knotu).
Je také poměrně snadné čistit, i když plastové disky nelze skutečně opravit, protože diskovou jednotku nelze rozebrat.
Pro německé inženýrství však kvalita sestavení není skvělá.
Mám svůj už rok, což by bylo asi šest měsíců chladného počasí, a jednotka vyvinula velmi nepříjemný chrastivý zvuk z sestavy ventilátoru.
Můj odhad by byl ventilátorová ložiska, takže jen čekám, až se zde stane úplné selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní nákupu nového zvlhčovače knotu.
Tl; DR - Nestojí za dodatečné náklady, jste lepší s knotovým zvlhčovačem.
Myslím, že to bylo snazší zlomit, než si mysleli.
Dávám tomuto produktu 3 hvězdičky na skutečnost, že když jsem ho dostal dovnitř, byl rozbitý již uvnitř.
Jakmile jsem to prozkoumal, uvědomil jsem si, že ten, kdo ho vložil do krabice, ho tam vložil rozbitý, To mohlo být buď výrobci baličů, nebo kvůli výrobcům, problém by mohl být v tom, že kupující vrátil položku a tvrdil, že ji prostě nechce nebo ji nepotřebuje a Amazon možná neudělal dostatečně dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti kupující nemohl říct, že je rozbitý, protože pak by to Amazon nevzal zpět, což je dobré, zejména s tímto druhem produktu, i když jsem ten, kdo uvízl s něčí nedbalostí.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a diskutoval o tom se svým manželem, rozhodl jsem se dát tomuto kupujícímu další šanci.
S tím jsem řekl, že aktualizuji své hodnocení pouze na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (alespoň tím, že ho řeší) a pokud položka přijde ve skvělé kondici, skutečně má příležitost dělat to, co dělá, a funguje dobře dělat to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale nebylo pro mě tak snadné nainstalovat.
Zkoušel jsem instalovat oba "zvonky" do zapojeného vysílače několikrát, ale bez úspěchu.
Byl jsem připraven vrátit to jako nefunguje, ale myslel jsem, že to ještě zkusím a zkontroluji baterie ve zvoncích.
Tady prosím... z krytů baterií vyčnívaly malé plastové jazýčky, které jsem vytáhl a vyšel plastový kus, který zakrýval baterii a bránil jí v práci.
Poté, co jsem odstranil tyto kousky plastu, zvonky fungovaly dobře a byl jsem s tímto nákupem naprosto spokojen.
Zvláštní věc je, že v uživatelské návodové brožuře není žádná zmínka o plastu nad baterií, která musí být odstraněna, aby zvonek fungoval.
Bylo by mnohem méně frustrující, kdyby se o tom zmínili, a nemyslel jsem si, že problém spočíval v tom, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou vyzvánění, zvonkohry a melodií, které si můžete vybrat, a je snadné jej změnit, kdykoli budete chtít.
Jedna věc, kterou se ptají při hodnocení tohoto zvonu, je, jak "odolný" proti povětrnostním vlivům.
Nemohu to komentovat, protože to bylo instalováno 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je to odolné proti povětrnostním vlivům až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - Znovu nabito
Vyrostl jsem s nimi a byl jsem nadšený, že je koupím pro svého syna, ale ztratili balíček živých housenek.
Řekli mi, že ho tentokrát vymění a naúčtují polovinu dopravy.
Po značném telefonním čase mě nakonec znovu nabili za novou objednávku se slevou 3 $.
Myslel jsem, že je to docela neprofesionální, protože nejenže to ztratili, ale vedli mě k přesvědčení, že to napraví, jen aby mi účtovali téměř plnou cenu na konci 30minutového telefonního hovoru s nějakým spielem o poukazu.
Strávil jsem 30 minut na telefonu, takže jsem se podvolil a koupil další sadu housenek.
Cokoliv.
Funguje dobře po některých bolestech hlavy.
Měl nějaké problémy, aby to fungovalo.
Dodaný kabel nebyl dobrý - baterii by nenabíjel.
Když jsem vyměnil kabel za svůj vlastní, byl schopen nabíjet a poté připojit zařízení přes bluetooth k počítači.
Měl potíže s nalezením počítačového softwaru, ale když jsem poslal e-mail jejich podporu, odpověděli během jednoho dne se správnými informacemi o stahování.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, nicméně jsem se nemohl připojit ani k iPhone, ani k iPadu (vyzkoušel jsem několik z každého) přes bluetooth.
Bude muset hard-drát, pokud se rozhodnu použít toto zařízení v mém produktu.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je to jako starožitné zlato
Zeptal jsem se prodejce, jestli je barva příliš žlutá před nákupem a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízkého!
Sada vypadá velmi levně.
Je to super lesklé žluté se spoustou CZs, ještě lesklejší.
Na fotce vypadá skvěle, ale v reálném životě bych ji ani nedala teenagerovi, aby ji nosila.
Miloval prsten - ale nemohl ho nosit po celou dobu! :(
Tento prsten byl krásný.
Miloval jsem design a robustní pocit; Vypadalo to drahé a bylo to velmi pohodlné!
Jediným důvodem, proč jsem dal pouze 3 hvězdy a nakonec vrátil produkt, je to, že jsem si uvědomil, že bych ho nemohl nosit po celou dobu.
Ráda nosím své prsteny po celou dobu, což je důvod, proč se vždy ujistím, že dostanu sterlingové stříbro, a vím, že někteří lidé říkali, že jejich prsteny se po chvíli pošpinily, ale já jsem nosil svůj asi týden v kuse - dokonce i při mytí rukou - a nevšiml jsem si žádného poskvrnění.
Zajímavé je, že problém, který jsem měl, spočíval v tom, že vnitřní pás prstenu se ve skutečnosti změnil na můj prst bílý a vlhký - něco jako náplast poté, co ji necháte dlouho zapnutou.
To se stalo, i když jsem se ujistil, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se mi to nestalo s žádným jiným prstenem, ale bylo to nepříjemné, takže jsem se rozhodl, že to není prsten pro mě.
:( Škoda, protože jsem to opravdu miloval!
Takže pokud kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám, jděte na to! !
Nebudete zklamáni!
kupte si Hýčkaného šéfkuchaře...
Vlastním malou lopatku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Miluji používání těchto kopečků při pečení pro dokonale naporcované sušenky.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a získat OXO - obvykle mám štěstí s jejich produkty.
Ne tento.
Asi na sušenku s arašídovým máslem # 30 přestala fungovat páka uvnitř lopatky.
Musel jsem vypáčit rukojeti od sebe a znovu umístit páku, abych udělal ještě několik, a pak opakovat.
Takže... Šetřete si zdravý rozum a kupte si kopeček Pampered Chef.
Stojí to za to!
Znovu si nekoupí pana Coffee
Na chvíli to byl jemný kávovar, ale vždy s ním byly problémy.
Pokud byste dostali vodu mezi černý plast a kov na karafu, vytekla by a vypustila vodu po celé dny.
Pak se nám zlomila plastová páka, která umožňuje, aby káva protékala filtrem do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je skvělý při přípravě kávy a udržování horké kávy, ale existuje příliš mnoho dalších problémů, než aby se do ní investovalo za současnou cenu.
Musí koupit! !
Miloval jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v rukojetích a všiml jsem si, že předtím, než jsem si ji koupil, což je důvod, proč stále dávám 5 hvězdiček!
Bylo snadné to vyčistit a všechno přišlo zabalené jednotlivě, což jsem zjistil, že je opravdu organizované a uklidnilo to mou duši lol láska, láska, LOVE barvu a určitě bych to koupil znovu pro sebe nebo pro milovaného člověka!
Může být dobrý na tyči, ale NE jako závěsná přepážka nebo ochranný štít.
Hanba Audubonovi.
Pokyny vám řeknou, abyste zatlačili zástrčku nahoru otvorem v ozvučnici a "Ujistěte se, že je bezpečně na svém místě."
JAK???
Je navržen tak, aby přepážka jednoduše volně seděla na zástrčce, takže může být tlačena nahoru jakýmkoli zvířátkem nebo nejmenším větrem.
Zástrčku můžete otočit vzhůru nohama tak, aby šrouby s palcem byly na spodní straně ozvučnice, ale bude vám trvat hodiny, než tyto šrouby otočíte; Žádný nástroj to neudělá a jen ty nejmenší prsty by to měly snadné.
Trvalo mi více než hodinu, než jsem udělal nedopečenou práci, abych je zašrouboval tak, aby zajistil přepážku k zástrčce.
Je to kompletní PITA.
Objednal jsem si čtyři z nich; tři, které jsem neotevřel, jdou rovnou zpět a já jsem na trhu pro lepší stráže počasí.
(Přiznejme si to; neexistuje nic takového, co by skutečně "zmátlo" veverky!)
Miluji mnoho funkcí těchto světel
Koupil jsem tuto lampu, abych doplnil světlo, které mé nové zeleninové sazenice dostávaly z okna.
Miluji mnoho vlastností těchto světel.
Klady: Za prvé, snadno se upnou na mou polici a ohnou se do mnoha poloh, což mi umožňuje provádět změny, jak mé rostliny rostou.
Světla jsou chladná na dotek a nezpůsobují škodu ani při dotyku rostlin.
Věřím, že moje zelenina těží ze světel.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Časovač jsem nevyužil, raději jsem je zapínal a vypínal sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro školkařské rostliny.
Světla jsou malá!
Když světla vyhoří, budu muset koupit zcela novou jednotku.
POZOR... VŮNĚ JE VELMI ŠPATNÁ. . . SLOTY PRO KARTY JSOU PŘÍLIŠ VELKÉ!
Když jsem to poprvé viděl, myslel jsem si, že je to krásné, ale tak to smrdělo.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že je to vůně BOLD.
Nikdy to nezmizelo, tak jsem to musel vrátit.
PLUS, kapsy pro kreditní karty jsou příliš velké.
Kreditní karty se posouvají až dolů, tipy se nezobrazují, takže nemáte tušení, jaká karta je kde a velmi obtížné se dostat ven.
FOTOGRAFIE, KTEROU UKAZUJÍ, KDE KARTY VYČNÍVAJÍ, JE NEPŘESNÁ.
Je to velmi malé..
Obdržel cestovní pás peněz a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych to nekoupil a budu muset ještě hledat něco většího.
Dobrý deštník, koupil bych ho znovu, kdybych musel
Nejprve musím říct, že barva je loveeeee.
Spousta věcí, které si objednávám ve fialové, je vždy příliš lehká, příliš dětská, příliš divná, příliš neonová, co máte.
Ale tato fialová byla hluboká a svěží a miluji ji, deštník je robustní a opravdu kvalitní.
Pravděpodobně nejlepší deštník, který jsem měl.
Dodává se s krytem a přestože nemusí mít mnoho funkčního využití, opravdu udržuje ostrý vzhled.
Balení je hrozné - obdržel 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Neobtěžujte se snahou získat ten, který není poškozen.
Vrátili jsme 2 kvůli poškození v lodní dopravě a 3. byl také poškozen.
Vzdal to.
Dodávají ho v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Žádné polstrování vůbec.
Skvělý koncept!
Jen potřebuje další vylepšení, aby to byl opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené, způsob, jakým to funguje, je současně funguje jako 1) osobní mikrofon, 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Celkově máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co vychází.
V samotném mikrofonu však není žádná hudba.
Má konektor Bluetooth, takže jej synchronizujete s telefonem a stáhnete si karaoke aplikaci, která může posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a hlasu (také samostatně!)
A dokonce má možnost upravit úroveň ozvěny tak, abyste skutečně zněli, jako byste byli v karaoke místnosti.
Některé věci, které bych rád viděl budoucí zlepšení, jsou: 1) existuje nějaká nepříjemná zpětná vazba, která se nezdá být pryč bez ohledu na to, jak daleko jsem telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem příznivcem minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly učinit design elegantnějším.
3) Podpora více karaoke aplikací Konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne přes plochou obrazovku nebo centrální reproduktorový systém v obývacím pokoji, není to tak zábavné v prostředí párty.
Pokud to výrobce dokáže nějakým způsobem integrovat do většího karaoke ekosystému, bylo by toto nekonečno příjemnější.
Žebrováno dodávkami Vision Supplies
V říjnu 2017 jsem zakoupil čtyři (4) kazety od společnosti Vision Supplies - Amazon Marketplace, takže bych měl v případě potřeby a ušetřit náklady na dopravu.
Použil dva za posledních pár let, asi jeden za rok, a fungovaly dobře.
Pokusil se použít jeden minulý týden, téměř prázdný po vytištění 20 štítků, ale poslední jeden došel po 40 stránkách.
Plast chybí na obou.
Oznámil jsem, že záruka vypršela!!!
Kdo by kontroloval každou jednotlivou kazetu při přijetí????
KUPUJÍCÍ BUĎTE POZOR!!!!!!!!!!
Promiňte, co?
Můj přítel doporučil masku této řady, takže jsem si koupil to, tento kondicionér a vše v jednom mléce.
Nemohu mluvit o účinnosti produktu, protože vůně prostě nebyla tolerovatelná.
Víte, že zatuchlý zápach starých budov používá na dámských toaletách, aby se pokusil zamaskovat zápach *dam*, ale prostě se ukáže, že je to kyselý, chemický, druh zatuchlé babičky vůně?
Jo, to je všechno, na co si vzpomenu, když tohle ucítím.
Znáte různé tahy, různé lidi, tak možná se vám vůně bude líbit.
Můj přítel říkal, že může pomoci i těm nejvíce poškozeným vlasům, takže pokud se nestaráte o vůni, pak se nebojte.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že stále více a více přírodních linií se prostě stará méně, protože se stejně prodá a tak teď všechno voní jako těsto.
Ztratil jsem několik oblíbených řádků, když změnili vzorec na levnější ingredience.
Nevím, jestli je to tento případ, nebo jestli je to falešný (který jsem nazval Davines a oni řekli, že není), ale tohle voní jako Y U C K a musel jsem to vrátit.
Kapky internet
Koupil jsem tento modem / router asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale za poslední rok plus jsem měl problémy s tím, že to upustilo internet.
To se děje na všech mých zařízeních, Wi-Fi i kabelových.
Jediným způsobem, jak obnovit službu, bylo provést reset střídavého proudu.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil nové koaxiální vedení z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Kluci z Arris Tech byli skvělí, ale nemohli problém vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést obnovení továrního nastavení, abych to obnovil.
Nemohu doporučit tento modem / router na základě mých zkušeností.
Koupil jsem si modem / směrovač Netgear AC1900.
Je to fantastické.
Měl jsem to více než týden bez problémů.
Je rychlejší a dojezd je větší než u modelu Arris.
Četl jsem online, že jiní lidé měli problémy s modemem / routerem Arris připojeným ke společnosti Comcast.
Pokud máte Comcast internet, nedoporučuji tento modem / router Arris.
Získejte Netgear, je mnohem spolehlivější.
Ale stává se to dost na to, aby to bylo nepříjemné.
Pozitivní nota
1 z fanoušků znělo mimo rovnováhu z krabice.
Ovládání rychlosti je opravdu nezvyklé - Pokud je vytočíte na 100%, ventilátory se vypnou, takže je třeba je zapnout na 100% a pomalu je vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že je to par pro většinu těchto typů produktů v tomto cenovém bodě.
Nohy pro držení notebooku, když je nakloněn, se několikrát utrhly...
Vrátí se zpět, ale stane se to dost na to, aby to bylo nepříjemné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z větracích otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a poskytuje velmi málo dodatečného proudění vzduchu do notebooku s takovou konfigurací chlazení.
Ok případ s vážnými omezeními
Tento případ je v pořádku, ale ne výjimečný - 3,5 nebo 4 max.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně pouzder.
Z nich je Gumdrop asi nejlepší, ale má některé vážné problémy.
Pouzdro gumy (silikon, cokoliv) je velmi hladké a hladké a nedává vám mnoho jistoty, když držíte jazýček jednou rukou.
Karta A je těžká, takže pokud ležíte při sledování videa, pouzdro vám sklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový štít, který zakrývá obrazovku, protože to narušilo činnost dotykové obrazovky.
To ovlivnilo pevnost 1-dílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a křehký.
Nakonec ztížili přístup k peru S.
Pero S je v pravém zadním dolním rohu karty A a udělali malou gumovou klapku, která chrání roh, otočit se dozadu pro přístup k peru S.
To znamená, že aby se pero S dostalo ven, musí se klapka vyklopit o 180 stupňů.
To je opravdu nepříjemné a těžké dělat s jednou rukou.
Tento případ dělá dobrou práci při ochraně mého Tab A, ale s těmito vážnými konstrukčními nedostatky to nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Vše, co jsem potřeboval
Tento produkt je opravdu hladký - jedno místo nakupování pro všechny mé potřeby připojení.
Miluji jen házet tento a můj notebook, malý napájecí adaptér v mé go bagu a být připraven pracovat na velkém displeji 4k nebo zachytit fotografie z mého fotoaparátu.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích USB-c, které jsem zkoušel od různých značek), je, že Mac zřejmě nedokáže rozpoznat rozdíl mezi násobky stejného monitoru (takže můj Mac vydává stejné video na všechny identické monitory připojené k rozbočovači, ať už pomocí HDMI a / nebo VGA).
Ale pokud používám 2 samostatné rozbočovače / adaptéry nebo 2 různé modely monitorů, pak mac správně výstupy na displeje jednotlivě.
Ok, potřebuje nějaké zlepšení.
Slušný výcvikový nástroj, ale opravdu musí mít nějaký bezpečnostní zámek nad tlačítkem šoku (byl stisknut více na nehodu, když je v kapse, než jsem ho skutečně zamýšlel použít), moji psi se dokonce omylem zachytili poté, co šlápli na dálkový ovladač.
Také, pokud se váš pes rád válí v mývalích hovínkách jako já, je to taková bolest v zadku k čištění.
Vzhledem k tomu, že fekální hmota se dostane mezi praskliny zařízení, musíte celou věc rozebrat, abyste ji řádně vyčistili a dostali zápach ven.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že téměř potřebujete přímou viditelnost, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Dobíjení je určitě příjemná funkce a nabíjení trvá nějakou dobu.
Potřebuji nabíjet jen asi jednou za dva týdny.
Dostanete to, za co zaplatíte.
Hrozný produkt, zkreslený
Koupil jsem si to jako tracker, abych ho mohl používat při plavání, a ani jsem neměl pořádnou šanci to vyzkoušet.
Za prvé, není odolný proti vodě a nedoporučuje se používat při plavání podle návodu k použití.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB konektor nebo počítač.
Fajn, těch máme kolem sebe spoustu.
Když se však pokusím dostat do portu, aby se nabil, spustí se hned zpět.
Nejsem si jistý, jestli je něco nekompatibilní, nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
Nakonec aplikace stále zobrazuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílal text, což je velmi znepokojující.
Pak jsem zavřel všechny aktivní aplikace v telefonu a viděl jsem ještě další reklamu, když jsem šel zkontrolovat čas o 20 minut později.
Hrozný produkt, myslím, že dostanu to, za co jsem zaplatil ...
Skvělý batoh, ale overkill na popruhy
Tento batoh vypadá dobře a funguje dobře.
Je to hodně, zvlášť když to porovnáte s tím, co stojí batohy dnes.
Důvod, proč jsem srazil hvězdu, je ten, že je tam příliš mnoho popruhů.
Na téhle tašce je víc popruhů, než dokážu spočítat.
Nakonec tyto další popruhy odříznu a spálím, protože většina z nich není opravdu nutná a jen překáží otevírání a zavírání tašky.
Kromě toho jsem si z toho udělal svou novou školní tašku na vysokou školu.
Hned vzadu v batohu je přihrádka na MacBook Pro a všechny mé knihy se vejdou do kapes, které jsou k dispozici.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli jste problémy s hokejovými míči.
Můj pes je miluje - její oblíbená hračka pro aportování a žvýkání - a vznášejí se.
Tedy dokud je nerozkousá na kousky.
Vyzkoušel několik, dokonce i verze "horkého počasí" - a trvaly o několik minut déle než ostatní.
Dokud se neobjevily.
Ty ve zkoušce obstály.
Můj pes není velký, ale je tvrdohlavý v tom, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj u psa.
Palec nahoru od Daisy a mě.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Zkontrolovali jsme baterii po několika týdnech používání a zjistili jsme, že voda šla do prostoru, kde jdou baterie.
Samotné baterie shnily a vytékala z nich černá tekutina.
Při pohledu na design se zdá, že neexistuje žádný způsob, jak by kryt baterie mohl být vodotěsný, což znamená, že nejenže voda šla do prostoru během koupání, ale některé z těchto toxických materiálů vyšly také.
Prosím, nekupujte tento produkt.
Jsem šokován, že to bylo dovoleno jít na trh i přes tak zjevnou chybu.
problémy s přehřátím a obtížné připojení ovladače
Dávám mu 3 hvězdičky prozatím, nechci nechat špatnou recenzi pro prodávajícího, pokud si to nezaslouží, ale tento drone se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale nemocný pravděpodobně zkusit oba jen vidět, co říkají.
Líbí se mi, že dron je skvělá malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí spíše jako hračka než tento.
Nicméně je to jediný drone, se kterým jsem kdy měl problémy s přehřátím, a ve skutečnosti to bere zábavu z létání im bude předpokládat, že je to výrobní problém, který musí řešit co nejdříve, pokud chtějí, aby tam produkt byl úspěšný.
Opravdu doufám, že mi prodávající neposlal dron, protože jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, jak dorazí 1 den po zakoupení.
Aktualizuji datum své recenze po kontaktování prodejce a dji tello.
O této dárkové tašce mám jen dobré věci
O této sadě dárkových tašek mám jen dobré věci.
Dokázala jsem zabalit všechny své vánoční dárky taškami, dárkovým obalem a hedvábným papírem.
Produkt je velmi kvalitní a různé možnosti velikosti usnadňují výběr toho pravého pro každý dárek!
Vřele doporučuji.
Prodávající je naprosto milý a pozorný.
Po nákupu se ke mně obrátil, aby se ujistil, že jsem se svým produktem spokojen.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte tuto hru, fyzika je hrozná a já jsem tak naštvaný na tuto hru, protože pravděpodobně existuje asi 40 hackerů na každou hru a hru.
Ani s tím nic neuděláte, víte, prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra pokračuje v aktualizacích o svých postavách, opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné, nekupujte tuto hru, fyzika je hrozná a mechanika je hrozná, lidé, kteří samozřejmě lidé která postavila tuto hru vysoko nebo tak něco, protože je to jedna z nejhorších her, které jsem upřímně kdy hrál v mém životě, raději bych hrál Pixel Games v těchto kecy, je to jedna z nejhorších her, které nekupujte
Ne jako ostatní hry Tomb Raider
Od samého začátku se necítil jako ostatní hry Tomb Raider.
Hratelnost je brutální v tom, že ovládání není chytré v tom, aby vědělo, jakým směrem se snažíte vydat.
Nechat vás padnout na smrt těmi nejnadbytečnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tato hra mě nebavila.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomické a cenově dostupné, ale ne příliš tolerantní k neustálému používání
Má štíhlejší tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, na které by se mohl zachytit, a s napájecím kabelem jako trvalým připojením je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který je spuštěn v akčních hrách, se cítí mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžkopádní a máme tendenci opotřebovávat 2-3 regulátory ročně.
Takže pro nás investice do regulátorů každoročně znamenají, že musíme být vybíraví a obezřetní v tom, co kupujeme.
Regulátor by mohl dělat s odolnějšími pružinami; po několika měsících přestanou nejčastěji používaná tlačítka reagovat a pravý joystick ztratí své vycentrování, IE- přiblíží obrazovky map a postavy chodí dopředu, aniž by se dotkly ovládacích prvků.
Dostanete to, za co zaplatíte
Byl jsem zklamán, když jsem obdržel tuto položku, protože stříbrná část, která prochází kolem obličeje, vypadala, že je vyrobena z nějakého levného plastu.
Není to skutečnost, že byl vyroben z plastu, který mě zklamal, stejně jako skutečnost, že použitý plast vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled pro mě.
Také jsem nevěřila, že vydrží každodenní nošení, takže jsem ji nakonec vrátila.
Byl jsem zklamaný, protože se zdálo, že by to byl dobrý obchod, kdyby tomu tak nebylo.
Pokud to však můžete přehlédnout, pak by to pro vás mohlo být to pravé.
Bylo to dobře zabaleno a dorazilo rychle.
Nic jako předchozí telefony Stylo, MASIVNÍ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je zřejmé, že se mi Stylos opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem ho.
Nikdy ne proto, že by člověk měl problémy nebo se zlomil, jen proto, že jsem chtěl zůstat upgradován a "ve smyčce" a já jsem to udělal.
Ze všech těchto telefonů jsem ani jednou neměl žádné problémy s telefonem samotným.
Když jsem provedl tento nákup pro Stylo 3 prostřednictvím Virgin Mobile, věděl jsem, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos tak úžasné.
Nikdy jsem nebyl schopen tento telefon úspěšně převést na svůj účet Virgin Mobile.
S tímto telefonem jsem se potýkal o něco méně než týden.
Hledal jsem informace na internetu a dělal různé hovory, zoufale jsem se snažil dát Stylo 3 výhodu pochybností doufat, že to byl jen já dělat něco špatně, ale bohužel jsem ztratil spoustu času, protože to bylo 100% telefon se všemi problémy, které jsem nechtěl přiznat.
Nenávidím skutečnost, že musím dát Stylo tak hrozné hodnocení a recenzi, ale byl jsem extrémně zklamán tímto telefonem.
Doufejme, že LG ups jejich hra a může zlepšit budoucí Stylos, pokud tam jsou nějaké, ale to bylo obrovské BUST.
Na světlé straně, návrat a moje vrácení peněz proběhly hladce, ale to je o tom.
