Nabouraná verze rytíře Jedi se hroutila, protože vyvolávala funkci mimo konec stolu.
Ukázalo se, že se předpokládá, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má další metody připíchnuté na konec ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to dost velký předpoklad, protože je to pouze vytváření viewportu pomocí Direct3D objektu, nikoli Direct3D3 objektu.
Nyní jsem pochopil, že v praxi, IDirectXObject2 je typicky správná supersoubor IDirectXObject, bez změněných funkčních podpisů, a nové metody jen přidány na konec.
To však není všeobecně pravda; pro tyto případy záleží na tom, jaké rozhraní používáte k vytvoření dotyčného objektu.
Takže každopádně, protože to zde platí, abych to opravil, musel jsem rozšířit svou implementaci viewportu tak, aby obsahovala metody IDirect3DViewport3 tak, aby volání do nové bylo platné.
Předpokládejme pro argumentaci, že věda se alespoň částečně skládá ze seznamů objektivně faktických výroků o světě, pravdivých kromě jakékoli teorie, kterou by mohly podpořit.
I když je pravda, že taková fakta ve vědě existují, stále je možné tvrdit, že vědecká fakta jsou nabitá teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta na tomto čtení, ale volbu, které experimenty provádět kontroly, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplývat pouze z experimentů, které jsou samy o sobě v kapitalismu možné jen proto, že vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, než aby se daly jinak vytáhnout.
Jde o velmi stručný náčrt věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi prosazujícími existenci objektivních vědeckých faktů.
Je to *ne* argument ve prospěch existence objektivních vědeckých faktů, v což nevěřím.
Bude to moje první projektové auto.
Vybírám si to o víkendu.
Hledal jsem dobré první auto a opravdu miluju estetiku 80. let.
Už na cívkách a snížené výšce jízdy.
Udělal jsem malý průzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zážitky?
Vím, že nejsou rychlé ve srovnání
#Venování do Fediverse času.
S domácím partnerem jsme dnes večer zašli do obchodu s alkoholem na pár piv a láhev bubu.
Když jsme se šli podívat, pokladní je celkem samozřejmá #trans žena.
Já, v trenýrkách, manželka a Domácí partner, všichni potetovaní a s novým účesem, který on sám popsal jako "čímž vypadám jako neonacista."
Její tělo okamžitě ztuhlo a v očích se jí objevil strach.
A pak jsme prostě... zaplatili za naše věci.
A poděkoval.
A řekl jsem, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale skutečnost, že byla vyděšená jako první FUCKING SUCKS A I HATE IT.
Tohle je nejhloupější časová osa a nesnáším ji dot com.
Donaldu Trumpovi nic nebrání v tom, aby kandidoval na prezidenta, když je obviněn, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se omilostnil, aby se dostal z vězení.
Ze státního vězení se ale omilostnit nemůže.
Chce to guvernéra státu.
Oběma zúčastněnými státy jsou New York a Georgia.
Guvernér posledně jmenovaného Kemp Trumpovi nepochybně odpustí, pokud ho usvědčí nebo dokonce obviní státní zástupkyně okresu Fulton Fannie Willisová.
NY je nejlepší nadějí na zodpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze redukovat na vysílání signálů s kontextově nezávislým významem.
V této práci, založené na variantě klasického Lewisova (1969) signalizačního modelu, zkoumáme podmínky vzniku kontextově závislé komunikace v situovaném scénáři.
Zejména demonstrujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové rozpoznání symbolických významů.
Ukazujeme, že environmentální omezení volby referentu přijímače může odesílatel jednostranně využít, aniž by na konci přijímače došlo k dezinformačním schopnostem.
V souladu se společnými předpoklady se zdá, že povědomí odesílatele o kontextu je nutné pro kontextovou komunikaci.
Naznačujeme, že kontextově závislá komunikace je situovaný mnohovrstevnatý jev, který je zásadně ovlivněn vlastnostmi prostředí, jako je rozložení kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale stále umožňují téměř dokonalou komunikační přesnost.
Moc se mi líbilo dohnat Penny a Nicholase z Ashanti Development o víkendu na rozhovor o jejich pokroku.
Ashanti Development spolupracuje se stále se rozšiřujícím počtem komunit v oblasti Ashanti v Ghaně již téměř 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti pro začlenění a podporu vlastního rozvoje.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase a podporoval řadu projektů.
Když jsme o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména v oblasti výsadby stromů a podpory zemědělských podniků.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšení výnosů plodin prostřednictvím řady zásahů od podpory nákupů vybavení až po školení.
Nicholas spolupracuje se zemědělci na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je podzimní červ, který může zdevastovat kukuřici.
Fotky z mé návštěvy Ghany v roce 2011.
Obchod UPS poblíž mě mi nedovolí napsat štítek nebo napsat na krabici.
Musí vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou se chystá a kdo ji posílá.
Musím poslat e-mail s nějakou náhodnou adresou, s neformátovanými údaji, aby si úředník mohl přečíst e-mail a zadat ho do svého systému, aby vytiskl štítek.
A vždycky mi za to "pohodlí" účtují 2,25 dolaru.
Druhý den ráno a nemůžu se dostat přes hanebnou předstírání žurnalistiky veřejné služby Chrise Lichta na CNN včera večer.
Bylo to pobouření, jako symbolický 6. leden antidemokratický svátek lží a křivd, sebedestruktivně pořádaný americkými médii.
Smutná audience.
Licht se dohodl na všem republikánském publiku!
Kdo prověřoval a vybíral jednotlivce?
Je třeba tam nahlásit nějaký příběh.
Sledování klamné nezodpovědnosti toho všeho.
Nemůže se to opakovat.
Mám velmi průvanový sklep, což v podstatě znamená, že se mi podaří sehnat útočiště pro spoustu hlodavců.
Za poslední měsíc se objevila spousta známek většího počtu hlodavců, což bylo výjimečně překvapivé, protože je jaro a já bych si myslel, že se se změnou počasí odváží ven.
Nicméně jsem měl kolem sebe rozloženo několik obyčejných starých lapaček a každých pár dní bych na nich poslušně doplňoval arašídové máslo, jak ho myši laskavě olizují.
Tuhle rutinu jsem včera večer konečně nabažil, vyčistil všechny pasti arašídového másla a nalepil na ně pistácii.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř každou "humánní" past na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť spokojený se zabíjením, ale nebudu se vyjadřovat k etice zabíjení myší.)
Už mě nebaví konzervativní strany a vlády, které se zahalují do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jasně, že snížili daně z podnikání.
Zároveň však snižují granty a daňové úlevy, které podporují větší podnikatelskou aktivitu.
Vlastním podnik. Je úspěšná navzdory provinční vládě, ne kvůli ní.
Zjistilo se, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Popupy, automatické přehrávání videí, animace, popovery a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělávají své peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud lidi zahání.
To platí i teď, když je goatse.cx pryč, i když by to byl těsný závod na dno mezi goatse a řekněme khou.com, kde jsem se snažil podívat na video, které mi Wendy poslala.
V prvním dnešním vlaku se kontrolor jízdenek podíval na naše jízdenky a řekl "dlouhá cesta!"
"Jo a dneska se vrátím," řekl jsem.
"Jen ho vysadím v Glasgowě," pokusil jsem se vysvětlit a ukázal na svého společníka na cestách.
"Není něco, co bys hodně slyšel 'Jen ho vysadím v Glasgowě'," řekl letenský chlapík.
Je to věc, kterou jsem nikdy předtím neřekl.
Věc, o které mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který vlastně nikdo nechce, kromě fanatiků, kteří v něm jsou.
A jsou to opravdu blázni.
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Pořiďte si nějaké nálepky na nárazníky, které jsou protitrumpovské, a omítněte je po celém těle.
Zařvi na ty, kteří by se nad námi snažili mluvit.
To není normální.
Tohle není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak vykašlává covidovou hlenovou bouři z druhé strany ulice.
Tak jsem spěchal, abych se dostal do svého aptu, abych se mu vyhnul, ale přesto se mu podařilo mě dohnat, abych si popovídal.
Přísahám, že lidé nakažení covidem jsou zombie, které se snaží nakazit všechny ostatní.
Není společensky přijatelné vycházet na veřejnost nebo spěchat k lidem, když kašlete na slizovou bouři.
Opakuji. Není společensky přijatelné šířit svou covidovou hlenovou bouři všude!!!
Writing Wonders 5/11: Směje se váš MC nebo pláče víc?
Abe své smutky tají a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho pobaví hrubý humor.
Jan ti ublíží dřív, než tě nechá vidět, že je zraněná a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4000 tísni se Yl ocitá na místě lásky a má obrovský pocit, že neví, co si počít, takže je tu spousta obojího.
#CNN musí prostě zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Která kabelová zpráva "výkonná" volala, aby dala tlustému, prolhanému zločinci tolik vysílacího času?
Vysoký tlak bude panovat až do začátku příštího týdne.
V polovině příštího týdne by měla dorazit studená fronta.
Dnes časně ráno infračervené satelitní a povrchové pozorování naznačilo rozšiřující se oblast nízkých vrstev a nepřehledných <URL>
Geeky student Arnie Cunningham se zamiluje do Christine, rezavého Plymouthu Furyho z roku 1958, a začne být posedlý obnovou klasického automobilu k její bývalé slávě.
Jak se auto mění, mění se i Arnie, jehož nově nabytá sebedůvěra se mění v aroganci za volantem jeho exotické krásy.
Obchodní partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce šité na míru vašim firemním potřebám.
Potřebujete pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte si spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu vašich investic do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a nepřetržitou podporou, která umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších částí o tom, jak se moji sousedé obracejí proti mně, je přemýšlení o tom, kolik úsilí vyžaduje být nepřátelský.
Zapomeň na mě, dobře.
Nevšímej si mě, dobře.
Bolí to, ale musíš to udělat ty.
V této chvíli se však otevřená nevraživost a násilí zhoršují.
To vyžaduje úsilí.
Zabouchnout mi dveře do obličeje vyžaduje úsilí.
Naši psi bývali nejlepšími přáteli.
A pořád nemám žádnou IDEA, co bych mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu 6+ let.
Ta loď je nepřístupná.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě nepodstatná.
Můžeš ji zabít, jestli můžeš.
Ale na palubě té lodi často létá jiný jedinec.
Kdyby zemřel... následky by byly... významné.
Hodně se ušklíbám nad otcovským opatrovnictvím.
Zde je (o něco delší než) toot-délka crash kurz v tom, co mám na mysli dad-ification:
Není to můj termín, je to termín používaný k popisu, kdy je vyprávění nebo herní mechanika postavena kolem ústředního protagonisty (obvykle staršího, obvykle mužského), který spravuje nebo hlídá jinou osobu (často mladší).
Poslední z nás je snadným a kanonickým příkladem otcovství.
Joel používá své schopnosti a schopnost uzákonit (extrémní) násilné činy, aby splnil úkol, který je kódován jako "starostlivost."
Dadifikace obvykle předpokládá, že řešením situace, kdy se rodičovská postava musí starat nebo chránit dítě nebo dítě, je drtivá síla a využití této síly k vynucení velmi specificky tvarované mocenské dynamiky.
Dadifikace nahlodává možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoli agenturu, kterou dítě má.
Tímto způsobem je Dad-ification zastáncem spousty neoliberálních ideálů; zejména myšlenek, jako je bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je rychlý přehled o tom, jak používat naše webové stránky.
- Rozesíláme oznámení, když letenka jde do prodeje.
- Poskytujeme odkazy na to, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky, ani si neúčtujeme předplatné.
- Další podrobnosti jsou v plném blogu.
- Vedeme seznam příkladů termínů rezervací pro každou nabídku, kterou zveřejníme, a aktualizujeme tento seznam několikrát denně.
Ukrajinské děti mají právo vyrůstat v mírovém a bezpečném prostředí.
Nepředstavitelný strach, hrůza a vysídlení je však zanechaly s neviditelnou jizvou traumatu.
Toto úterý se prezidentka von der Leyenová v Kyjevě setkala s první dámou Alenou Zelenskou, aby prodiskutovala, jak podpořit její úsilí o poskytnutí pomoci v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli duševní zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže tuto cestu překonat.
Parta lesklé nové dobroty v #dartu
Postupem času se šipka stala mým cílem pro rychlé uživatelské rozhraní.
S #flutterem je radost pracovat a mají #mobx pro snadnou správu obchodů.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě chvění je na hovno, pokud jde o chování, jako by se chovala dobrá nativní aplikace (kdekoliv, opravdu. I třepotavý webový cíl stojí za prd).
Ale umožňuje rychlý pohyb, a proto je ideální pro malé hacky.
Echidna s ametystem a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou postavu a svalnatost.
Jejich ocas je extrémně hustý.
Vlasy mají malinové, krátké a kudrnaté.
Oči mají hruškovité a nosí šarlatové brýle na kočičí oči.
Jejich nejzajímavějším rysem jsou dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Umět skákat opravdu vysoko, trhat obyčejné lidi na cáry, používat strašidelné magické schopnosti a doplňovat zdraví hodováním na nepřátelích - to by mělo být základní součástí všech PC her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze, aby vypadali špatně - všichni ...
Zdálo se mi, že rodiče hrají mou porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mamince líbila logická hra, kterou jsem před lety vyrobila, a většinu tajemství našla sama, takže nebyla jen maminkou, když řekla, že se jí líbí.
Tak snad se jí bude líbit i moje pornohra?
Možná má příliš mnoho jazykových jemností.
Musím to přeložit do mandarínštiny a/nebo Hokkienu, z nichž ani jedno vůbec neznám.
Asi se budu muset podívat, jestli je Bing nebo Google lepší v překládání špinavých gay sexuálních slovních hříček.
Chvíli si pohrávám s touto myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od "pravidelného" zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Po pravdě řečeno, zdraví vaší mysli, vašeho mozku je stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce uznáván TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými vnímáno jako méně "reálné" než fyzické zdraví, mám tak trochu pocit, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, pohlaví, psychologii, tím více mi tvrzení "Moje pohlaví je mužské, mé pohlaví je ženské" připadá zjednodušující a nepřesné.
Skoro to vypadá, jako bych postoupil část sporu TERF.
Mám pocit, že být trans znamená být "biologicky nebinární."
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení "nebinární" je třeba rozšířit z pouhého genderového výrazu, který se má používat při odkazu na sex.
Poslouchal jsem, zapínal a vypínal, díla @iotar
V tom záhadném kolektivu je spousta dobrých věcí.
Jako třeba krauty moods a další světská pop music a radiofonická dílna a všelijaké.
Moc stojí za to se do toho pustit.
Také FWIW Líbí se mi rozhraní archive.org mnohem více než desktop #bandcamp \- Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrávám s Flutterem.
Nerad bych zakládal svůj byznys na technice od Googlu, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého cross platformového zážitku a ukazuje to.
(A také: Web je nyní z velké části věcí Googlu, bohužel)
Také se prosím zdržte toho, abyste mi řekli, že aplikace google/flutter jsou na iOS a macOS na nic.
Cross platforma je těžké, pokud to chcete udělat dobře.
Já to vím.
Děkuji těm lidem, kteří si stáhli nejnovější aktualizaci na Leasey.
Vyšlo na světlo několik velmi malých obtíží.
Nic, co by zazvonilo na poplach, ale přesto se řeší.
Příští týden bude vytvořena malá aktualizace, která je opraví.
Většina včerejška byla vynaložena na instalaci nové aktualizace pro některé zákazníky a každý, kdo tuto pomoc potřebuje, ji už měl obdržet.
Hezký den!
Technická zpověď: Nemohu se omotat kolem Grafany & Promethea, alespoň z hlediska metriky serveru/aplikace a monitorování.
Nevím přesně, proč na to můj mozek nedokáže přijít; může se stát, že nástroje jsou tak široké a neurčité, že můj mozek se kvůli "příliš mnoha možnostem" prostě zablokuje.
Chci dělat palubní desky.
Grafana vypadá pěkně.
Mozek nemá práci.
Takže s blížící se novou úrovní nájezdů #FFXIV jsem už dlouho přemýšlel "člověče, rád bych zkusil pořádný nájezd, ale Party Finder zní jako nepořádek a nikdy nenajdu statika, který by mě měl."
Tak jsem si řekl, kašlu na to!
Udělám si vlastní statiku!
Plný lidí, kteří jsou příliš nedočkaví na to, aby se pokusili připojit k nájezdové statice, bez očekávání, že budou vůbec dobří!
V žádném případě by to nefungovalo, pravděpodobně!
...A tak jsem zjistil, že musím vyřešit rozpis nájezdové skupiny.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a ztratil jsem veškerou vášeň pro fikci a skvělé vypravěčství.
Ale po ~dekádách~ čtení téměř nic (s výjimkou funkčních pracovních non-fiction věcí a příležitostné svépomocné knihy) jsem si stanovil cíl přečíst 23 knih v roce 2023.
Jsem teď na knize # 31 a je teprve květen.
Jsem ZPĚT baby!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou v soukromí přišlo pár lidí a řeklo "podívejte se, kvůli vší vaší práci vám takovou sumu peněz udělím."
Chci vidět tyto společnosti, které zprostředkující transakce vysvětlují svým zákazníkům, jak si stanovují svá procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobrou čtvrtinu, tak to udělají.
Je nebezpečí pustit migranty na jižní hranici? Nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Ještě jednou.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, prodiktátoři pravého křídla.. je tu nebezpečí.
Deportujte bělošské rasisty.
Už mě tak unavují titulky, které tvrdí, že "Dálková práce je mrtvá." nebo že "Dálková práce byla neúspěšný experiment."
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Všechno je to klikací návnada, ale dělá mi to starosti o manažery a manažery, kteří tyto články čtou.
Před rokem 2020 existovala práce na dálku.
Stále budou existovat pracovní místa, která lze v dohledné době vykonávat na dálku.
Práce na dálku je umožněna.
Umožňuje lidem pracovat v pohodlných prostorách a ne dusných, hlučných kancelářích.
Umožňuje přístupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavým dojížděním, které jim ubírá čas od jejich dne a jejich rodin.
Jen ignorovat tato fakta je špatné.
Přestaňte generalizovat a snažte se pochopit, jak vaši zaměstnanci skutečně dělají práci.
#WFH #obchod #neurodiverzita
Nejsou to jen konzervativci versus pokrokáři, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Tohle je válka mezi pro-lidmi a anti-lidmi," řekl.
Parker se zmínil o potratech a o impulsu moderních městských žen odkládat narození dětí kvůli jejich kariéře.
Tvrdí také, že NDP a pokrokáři chtějí vylidnit společnost v zájmu životního prostředí.
"Ty jsi uhlík, který se snaží snížit."
Takže jako od začátku u všech mých narozenin v minulosti jsem měl vždycky drsné.
Kdykoliv se May objevila, bál jsem se, že se pokusím oslavit svůj den.
Vždycky by se něco stalo, pokazilo se to, nebo by to prostě skončilo stresující a depresivní.
Celá léta jsem bojoval, abych se z toho myšlení dostal a měl lepší dny.
Trvalo to roky, než jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si bday bez obav.
A dnešek se už stává velkým dnem!
Do zimy zbývá v této malé části Velkého jižního světa 30 dní.
Ale nemůžu se nechat oklamat!
Tohle je začátek.
Déšť padá a dokud není zmrzlý, nepůjdeš v něm tančit!
Je to krásný den na objednání zmrzliny.
Byla to jedna psí noc a ten doggo nevstával z postele ani na "Psí snídani - Snídaně pro psa!"
Podšívku si zapnu do bundy - pro případ, že bych ji potřebovala uvnitř.
Víte o výkonném způsobu, jak může webová komponenta reagovat na přidání/odstranění z dokumentu?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Je to většinou sémantický HTML s CSS, a obecně nevyžaduje vlastní prvky (který nabízí connectedCallback).
V současné době používáme hack MutationObserver.
Pro výkon nedodržujeme celý dokument.
Vytvoříme samostatný dočasný rodič, nainstalujeme tam MO a pozorujeme, jak se odděluje (čímž se připojuje jinde).
Casper the #rat je v dnešní době absolutní jednotka.
Myslím, že moje nová práce mu prospěla - dvě volné procházky denně, zatímco pracuji, v poměrně předvídatelných časech.
Konečně jsem dostala dobrou houpací fotku, abych si mohla být jistá, že není tlustý.
(U #krysů může být příliš vysoký tělesný tuk špatný pro jejich zdraví.)
To není on.
Je prostě naprosto vyrván z toho, že mi dvakrát denně trhá kancelář.
Nemám stupnici, která by ho vážila, ale má pocit, že má hodně přes kilo.
Jsem tak šťastná, že se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1) Mírné úpravy mapy Hel's Fighters.
Mapové menu je navíc plně funkční!
2) Systém odměn v měně byl připojen.
Zítra se bude testovat různými bitvami.
Deštivé dny!
Minulý týden jsem udělal tunu a cítil jsem se mnohem lépe, pokud jde o polní položky.
Všechny límce, kapusta, mangold jsou transplantovány.
Plánuje se zasadit do salátu v Pennu na 6řádkovém vzoru a zjistit, jak se to srovnává s vysíláním semenných postelí.
Jarní hrášek v Gilpinu se objevuje tak, že je třeba nastavit trellise.
Také je třeba tam zasadit salátovou řadu, aby se integrovala řezaná zelenina v obou mají vyškolenou posádku na zavlažování, přípravu postele a transplantaci, což je 90% nesklizených dovednostních předmětů
Je rok 2023 a stále vidím, jak se lidé s iPhony aktivně vyhýbají používání Apple Maps.
Apple Maps přichází ve výchozím nastavení s iOS, a přesto by se lidé vydali ze všech sil stahovat a instalovat Google Maps na své iPhony.
Netuším proč.
Zvědavý, měl jsem otevřenou mysl, abych porovnal, jak se srovnávají Google Maps a Apple Maps, na svém testovacím zařízení iPhone (můj denní ovladač je zařízení s Androidem, takže je vzácné, že používám iPhone).
Zkušenosti s dodržováním pokynů byly na Apple Maps ve srovnání s Google Maps mnohem lepší.
Vyhrává Apple Maps.
Proč tedy lidé skáčou přes další obruče, aby si nainstalovali Google Maps?
To netuším.
Mohlo by se stát, že se Google Maps dostaly na trh jako první?
Byla to katastrofa Apple Maps z roku 2012?
Je možné, že je Google Search integrován s Google Maps?
To netuším.
To znamená, že jsem zaujatý.
Jsem zaujatý pro to, aby se odpadky nepouštěly koncovým uživatelům, a Apple se královsky posral s jejich Apple Maps, když v roce 2012 vyšly.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to země, která z ní dělá dobrého skladiště bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Dům sám o sobě klesá v hodnotě, protože ztrácí svůj stav a je třeba ho vyměnit.
Spousta ppl si myslí, že doslova vlastní zemi, když si koupí kus.
To není ten případ.
V Číně můžete pronajímat pouze pozemky.
Nejsou tak hloupí, aby prodali navěky.
Vláda může tyto politiky změnit, kdykoli bude chtít.
Pozemek je dočasný.
Zdá se nepředstavitelné, že by vám jednou mohla být odebrána půda, když sledujete australské a americké mediální kanály, ale to proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl přemýšlela určitým způsobem.
Zemi velmi snadno a rychle odebere vláda jednoho dne, pokud to chce udělat.
A hádej co?
Nikdy nedávalo smysl, jak si ppl může udržet půdu na úkor ostatních.
Jednou se to musí odnést.
Proto Číňané povolují jen pronájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k prostému, ale pravdivému!!
Všem investorům tam venku připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm#geolog #podnikání #udržitelnost #úspěch #přátelství #toast #sny
Často se divím lidské schopnosti být *tak* dole na sebe, zatímco jsem zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a vinou ve světě, kde je "úspěch" tak často propůjčován lidem zodpovědným za nejtrestuhodnější činy...
Všichni jsme tak zapeklití tvorové.
Ale mírné zoufalství nad naší nepořádností je klíčové - protože nám dává více prostoru, abychom se vypořádali s ruinami všude kolem.
Tak se snaž nezapomínat, co?
Laskavost k nám samým je také aktivismus.
Někteří programátoři: "Na rychlosti psaní nezáleží!"
nebo "Modální editory jsou dnes k ničemu" :morty:
Jak extrahovat funkcionalitu svých #Axum projektů do sdílených knihoven: "Hold my keyboard" :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup pro sdílení, ale prozatím se mi to líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzvou tohoto týdne na Zjevení je Zůstat vzhůru celou noc.
Už pár dní si pohrávám s tímto malým kouskem na hlavě.
Je to rozhodně víc romantika než špína.
Možná jsem četla mnoho románků s nemožným "setkáním s roztomilými" a tohle je výsledek, ale líbí se mi to.
Také jednoho dne budu naprosto dělat míli vysoký orgasmus, možná ne s str
Nesouhlasím s tím, že #Mastodon je těžké nastavit.
Běžné, opravdu to není tak těžké.
Ale je obtížnější najít lidi, kteří by vás sledovali a budovali vaši časovou osu.
Přál bych si, aby existovalo nějaké doporučení "kdo se má řídit."
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany, jako je Elk a / nebo Ivory.
Pokud se držíte výchozího webového rozhraní, nevypadá to dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali, a pravděpodobně potřebujete dobrou aplikaci pro zlepšení #UX.
Nevím, jestli je možná prevence, ale stojí za to to zkusit.
Čtyři kroky, které nastiňuji, jsou předmětem diskuse, přičemž v každém z nich došlo k určitému pokroku:
Popis: názvy pro incidenty chování člověka-algoritmu, které vysvětlují algoritmy a lidi.
Vysvětlení: počítejte s oběma stranami vzájemného vlivu
Prognóza: předvídání škod dříve, než k nim dojde (i když po minutách)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých hranic důvěry
Nedíval jsem se na radnici CNN, ale zdá se, že Trump řekl přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne Send na svém telefonu.
I kdyby je během radnice nestihl vyslovit, všichni v Americe je stejně uslyší, opakovaně, mezi dneškem a listopadem 2024.
To stále není důvod mu dávat jiné místo, ale škoda se přehání.
Vyhraje primárky.
Nemůžeme ho nechat být.
Je tady a bude říkat tyhle věci, ať se děje, co se děje.
Přihlásil se na čekací listinu společnosti Google "AI Test Kitchen" a nastoupil ve stejný den.
V tuto chvíli je to velmi podbízivé.
"MusicLM Demo" je mírně zajímavé.
Můžete požádat o konkrétní skladbu, jako je "jazz s trumpetovým sólem v tempu 5/4" a po několika sekundách pro vás vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... hudba prostě... není dobrá.
Házet všechno, co máte přes plot v reakci na GPT, to není ono.
Snažte se více Google.
Je to divné dělat vzpírání, ale také nemít ponětí, co je vaše one-rep-max, což je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Pracuji sám ve své ložnici bez reflektoru nebo dokonce váhového stojanu.
Jen já a činka s hromadou závaží.
Stisknu lavičku na posteli.
Když se pokusím přijít na to, že můj jeden zástupce max je, že možná nevlastním dost závaží na to, abych max out, nebo by mě to naopak mohlo vážně zranit/zabít.
Každopádně, náklad jde dnes nahoru.
Pořád je to dobrý pocit.
Přísahám, že burrata před pěti lety neexistovala
Tohle je moje osobní věc s Mandelovým efektem.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem to neviděl v luxusním hokynářství ani v žádném italském lahůdkářství.
Nikdy jsem neviděla, že by to dělala něčí máma nebo že by to na mě strkala na večírku nebo že by to vypadalo ve spojení s něčími eskapádami při výrobě omáčky nebo pečením
Prostě se jednoho dne objevila a najednou byla k dispozici všude.
Vstoupil jsem do dimenze burraty.
drake stárnoucí iPad rozdává, a tak je na trhu s novým tabletem.
Poté, co jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo linuxový tablet, který miluje?
To by bylo hlavně pro prohlížení webu, příležitostný e-mail a některé hry.
V letech 1998-06 Gamefan, ve vztahu k dlouhému vývoji první hry Unreal, Jason Schrieber poznamenal,
"Dobrá hra je jen pozdě, dokud se nevydá.
Špatná hra je špatná navždy."
Takže to byl Epic, kdo to vznikl?
Můžeme jít dál.
Starší vydání GamePro 1997-11 má citát s daleko větší nejednoznačností,
"Nebo, jak zní chytlavá fráze z oboru: pozdní hra je pozdě, dokud se nevydá.
Špatná hra je špatná do konce života."
Je to tedy tak pomíjivé?
Pouhé "catchphrase" bez jasného původce?
Smoky, můj desetiměsíční samec Domestic Blue kotě, hrající si s červeným gumovým Apple Pencil komfortním zařízením zakoupeným od Amazonu, před několika měsíci utekl.
Nosí ho v ústech hrdě po celém domě a já se musím jen vnitřně smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsme absolvovali kompletní okružní jízdu novým vlakem ICNG.
Opravdu se mi to líbí.
Esp kočáry s většími okny.
Jsou oblasti, které by potřebovaly trochu leštidla.
Jmenovitě nedostatek popelnic a nedostatek značek, které by vysvětlovaly význam světelných barev.
Opravte ty drobné problémy a pak jich můžeme mít víc, prosím?
Nebudu smutná, když uvidím konec akcií ICM nebo DDZ.
Pravidla jednoho zákazníka zůstávají, protože se snažíme zajistit, aby se každý, kdo stojí ve frontě, mohl dostat k tabuli.
Můžete si koupit jednu z výše uvedených desek, ne jednu z každé.
Pro Picos nebo jiné zboží neexistují žádná nákupní omezení.
Včera jsem se nejlépe bavil se svým přítelem a bývalým rabínským kolegou.
Navštívili jsme na pár hodin na mé verandě.
Taková přátelství přesahují rozdíly.
Všichni máme co vyprávět.
Pán vám žehnej a držte se!
A močál se zazelenává.
Mám docela rád akkoma software a název domény jsem dostal pro můj příklad.
Ale mám pocit, že jsem tuhle instanci začal takříkajíc špatnou nohou.
A nikdy jsem se tam neudobřil.
Bude se tu ještě o něco déle zdržovat a přemýšlet o tom, jestli bych vůbec měl migrovat.
#FalconHraKnihy
Zdá se, že osmiocí Repnidové se dívají, jak usazujete leták na rudé půdě, ale nijak se k vám nepohybují, ve skutečnosti jsou nehybní, když vylezete z letáku a pomalu k nim kráčíte.
Země pod vašima nohama se začne třást a pak se třást, jako při zemětřesení a vy ztratíte půdu pod nohama, i když se zdá, že Repnidové nejsou nedotčeni.
Skála pod vámi náhle ustupuje.
Repnidy se vytunelovaly pod povrchem a vy spadnete do vroucí hmoty stovek Repnidových těl v jeskyni dole.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry vám kontaminuje plíce.
Nikdo se nikdy nedozví, že jsi byl prvním budoucím cestovatelem.
Přistanete nosem letce vzhůru na straně hromady strusky a vylezete ven.
Zdá se, že osmiocí Repnidové se dívají, ale nehýbou se k vám, ve skutečnosti jsou nehybní, když k nim pomalu kráčíte.
Zastavíte se ještě na pahorku rozpadlé skály a půdy, promluvíte k nim a řeknete: "Přicházím v míru, jako přítel."
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladatel nezachytí žádnou odpověď.
Rozhodli jste se použít své psychické vědomí, abyste je kontaktovali mentálně.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a vaše mysl se od kontaktu odvrací.
Rozhodnete se, že navázat kontakt znovu by bylo nebezpečné a vrátit se ke svému letáku, ale zážitek vám vyčistil mysl, která byla zmatená od chvíle, kdy jste skočili do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je docela snadné naplánovat kurz na Zemi v roce 3034 n.l.
Všimněte si, že jste při skoku vyčerpali další polybdenovou tyč.
[pokračování]
#dnes mám kávu, sluníčko a klidný čas!
Začal jsem nový šál.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně spřádanou stříbřitě šedou přízi, která je většinou jemně spřádána hrudkami.
Plánuji, že ji smíchám s jemnou fialovou/lila pestrou bavlnou.
Ale nejsem si jistý, jestli mám toho fialového dost.
Používám H háček s podobným vzorem háčkování, jako jsem to dělala předtím.
Včera večer jsem se poprvé připojil, takže uvidíme.
Přeji všem šťastný čtvrtek!
Nenávidím však přednášky o výtvarném umění a literatuře a moje školní historie to potvrzuje.
Doslova jsem to zkusil a upustil JEDNOHO.
A až do doby před dvěma lety jsem o tom neměl tušení, dokud jsem nezkontroloval své přepisy.
Třídní nenávist k literatuře je ještě horší: ráda čtu.
Většinu klasik jsem trefil před osmnáctkou - i když to je spíš odraz života v bumfuck nikde, četl jsem v zoufalství i Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a jsem tam šťastná, ale musím být někde jinde, abych se dostatečně zchladila, abych si přes den přečetla beletrii, aniž bych se cítila provinile.
Je to, jako bych byl o svátcích, a proto dělám to, co člověk dělá o svátcích.
A to je také přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma, a trochu jsem se dostal z #MECFS z toho, že jsem prostě v cizím prostředí, kde jsem méně schopný přecházet a musím si pamatovat, kde se věci nacházejí.
A to i přesto, že stále mám svůj seznam úkolů a také organizuji svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které na práci ve hrách miluju.
Co si o tom budou lidé myslet?
Líbí se mi to, ale podaří se mi přilákat publikum těch správných hráčů?
Bude komunita rozkvétat kolem uživatelem vytvořeného obsahu hry?
(Opravdu v to doufám.)
Příběh hry, nápady a otázky, které inspiruje, se cítí aktuální.
Doufám, že to půjde dobře.
Je den ThinkPadu!!
Přišel jsem domů o polední přestávce, abych viděl, jak sedím venku uwu.
Přál bych si, abych si ho mohl vzít zpátky do práce se mnou, abych nastavil víc.
Ale to bude muset počkat do večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to příliš roztomilé až do té míry, že to bylo tvídové?
Nejrozhodněji
Mluví některá z těchto postav o lidských bytostech?
Ani vzdáleně
Ale líbilo se mi to?
Rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Měl nedávno vystudovaný umělec dnes večer nějakou kritiku špatně.
Částečně proto, že by se špatně učili.
Ale je důležité nevymlouvat se na problémy a jen je opravovat, zejména ve výrobě, když váš olovo potřebuje změny.
Hlavně s konkurencí.
Každý umělec tam byl, dělal stejné chyby.
Dobrá kritika je tu proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Předpokládá se, že máte schopnost problém vyřešit, nebo najít řešení.
Takže zatímco kompostování a kvetoucí rolování jsou nádhernou připomínkou k tomu, abyste vzhlédli a byli si vědomi života za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte semena, která jsou zaseta a pěstována (a ne náhodně rozptýlena) dobrými kukačkami.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu lístek podstrčil, když se těsně před psí hlídkou míjeli na stezce.
Byla na cestě ke zdi, on odcházel ze služby.
Podíval se za sebe, aby se podíval, jak odchází, a aby se ujistil, že je nikdo neviděl.
Neohlédla se.
Počkal, až se ocitne ve tmě palandy, než vytáhl vzkaz a přečetl si ho v paprsku světla procházejícím zatemňovacími závěsy.
Jedno slovo s blokovým potiskem.
Dlouho na to zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových #Mastodonových kamarádů a chci udržet trend.
Volání do #Fediverse ve mně vyvolává pocit, jako by velryba zpívala rozlehlým oceánem!
Chcete se připojit k mému "podu"?
Zvláště bych se rád spojil s více.
Každý, kdo má na CNN v plamenech vlasy, může poděkovat Stephenu Colbertovi za tvrdou pravou zatáčku.
Pomohl udělat z Chrise Lichta národní problém.
I když by se nám někteří lidé mohli líbit, pokud jen fašistům zajišťují druholigovou kariéru, pravděpodobně by ji měli nosit.
Bylo to poprvé (ale nebude to naposledy), kdy Kaveesha Dilhari oba skórovali 20+ ran a ve stejném T20I získali 2+ hříchy.
Připojuje se k vybrané skupině srílanských žen, aby dosáhla všestranného úspěchu ve formátu.
Policie zatkla 15 lidí po násilném protestu před britským uprchlickým hotelem
Incident přichází po nárůstu počtu uprchlíků a žadatelů o azyl, kteří přeplouvají kanál La Manche do Spojeného království na lodích.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem používaným k ubytování žadatelů o azyl stala násilnou poblíž anglického města Liverpool.
Policejní oddělení v Merseyside uvedlo, že policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer ve Knowsley.
Policejní sbor uvedl, že někteří demonstranti házeli předměty a zapalovali policejní dodávku.
Zatčení lidé, kteří se pohybovali ve věku od 13 do 54 let, byli zadrženi "po násilných nepokojích."
Merseysidská policejní komisařka Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zraněných."
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který Knowsleyho zastupuje v britském parlamentu, řekl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou bigoti a jsou přívětiví k lidem, kteří utíkají z některých nejnebezpečnějších míst na světě a hledají místo bezpečí," řekl.
"Ti, kdo dnes večer demonstrují proti uprchlíkům, nereprezentují tuto komunitu."
Protest se odehrál uprostřed zvýšeného napětí, když rostoucí počet uprchlíků a migrantů přeplul kanál La Manche v malých člunech.
Více než 45 000 lidí se touto cestou dostalo do Spojeného království v roce 2022 a většina požádala o azyl.
Systém pro posuzování žádostí o azyl se kvůli politickému chaosu a byrokratickým průtahům zpomalil a mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Přechody přes kanál La Manche se staly politickým tématem, kdy konzervativní vláda slíbila, že "zastaví lodě" a bude prosazovat plán na vyslání takových žadatelů o azyl do Rwandy.
Odpůrci obviňují vládu, že démonizuje zoufalé lidi prchající před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v úvodu sezony v Brandywellu
Derry střední obránce Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City zvítězilo v Prezidentském poháru, když zvítězilo 2:0 nad Shamrock Rovers.
Držitelé FAI Cupu porazili v minulé sezoně vítěze ligy v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops se ve druhé půli tlačili ke snížení, ale svěřenci Ruaidhriho Higginse stáli pevně, aby vyhráli oponování.
Derry odcestuje do St. Patrick's Athletic na ligovou premiéru příští pátek.
Patchingův boční volej po 23 minutách postrčil Derry dopředu - středopolař otevřel skóre, když Foylesider loni v únoru zvítězil 2:1 nad případnými šampiony.
Hoops pokračovali ve výhře v Premier Division o 13 bodů, ale Duffy měl brzy City dál s dalekonosným úsilím, kterému se podařilo vykroutit se pod brankářem Leonem Pohlsem do sítě.
V minulé sezoně byli běžci o přestávce dva góly k dobru.
Graham Burke byl nejblíže snížení nedoplatků ve druhém setu, ale Candystripes byli pohodlnými vítězi týden před jejich hledáním národní slávy.
Šéf města Ruaidhri Higgins pochválil svůj tým po tom, co řekl, že je to "nejtěžší týden mého života" po smrti jeho bratra Kevina.
"Je to kopanec do zubů a čekají nás těžké týdny, ale v jeho paměti se do toho pustíme," řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě s dobrým výkonem je opravdu potěšující."
DHS najímá advokátní kancelář, aby se zabývala možným řízením o impeachmentu Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí advokátní kancelář - Debevoise & Plimpton - aby pomohla v případném řízení o impeachmentu ministra Alejandra Mayorkase, protože potenciálně čelí obvinění republikánů z manipulace s jižní hranicí.
"Ministerstvo vnitřní bezpečnosti si ponechalo externího právního zástupce, aby pomohlo zajistit, aby životně důležité poslání ministerstva nebylo přerušeno bezprecedentním, neodůvodněným a stranickým úsilím některých členů Kongresu o impeachment, kteří již podnikli kroky k zahájení řízení," uvedla v pátek mluvčí DHS v prohlášení.
"DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic a zároveň bude přiměřeně reagovat na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS."
Úředník DHS sděluje CBS News, že ministerstvo najal firmu na nasmlouvanou práci po dobu vyšetřování kongresu.
Debevoise byla zvolena kvůli svým odborným znalostem v oblasti impeachmentu a dvoustranickým zkušenostem ve spolupráci s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno informovalo, že smlouva s Debevoise je kvalifikována jako odpovídající výdaj pro DHS.
DHS se snaží zajistit, aby její poslání nebylo podkopáno stranickými útoky a aby řízení proti Mayorkasovi vyřizovali lidé s příslušnými odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale ptal se na vyšetřování impeachmentu minulý čtvrtek, řekl novinářům: "Budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s posledním Kongresem. Myslím, že je to naše odpovědnost."
Připustil, že "bude nějakou dobu trvat," než vyhoví vyšetřování sněmovny.
"Trávím ten čas stejně jako ostatní a také nebudeme kompromitovat čas, který strávíme při naplňování našeho poslání."
Vysoký představitel DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím právním zástupcem.
Obžalován byl dosud pouze jeden člen kabinetu, ministr války William Belknap.
V roce 1876 byl Belknap, který působil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl senátem zproštěn obžaloby.
Trendové zprávy
Díky za přečtení CBS NEWS.
Čtyři mladíci obviněni z útoku čtrnáctiletého, který zemřel na sebevraždu poté, co zbil video, bylo zveřejněno na internetu
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři mladíci z New Jersey byli obviněni v souvislosti s útokem čtrnáctileté dívky, která si později vzala život poté, co bylo na sociálních médiích zveřejněno video incidentu.
Jeden mladistvý je obviněn z těžkého ublížení na zdraví, dva mladiství jsou obviněni ze spiknutí za účelem spáchání těžkého ublížení na zdraví a jeden mladistvý je obviněn z obtěžování, sdělil v e-mailu prokurátor okresu Ocean Bradley D. Billhimer CBS News.
Adriana Kuchová, 14 let, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video útoku na střední regionální školu.
Na videu bylo vidět dívky, jak po mladíkovi házejí pití, pak ji kopou a táhnou po školních chodbách.
Strčili Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kucha opakovaně udeřila.
Další dívka mimo záběr videa se při nahrávání scény zasmála.
Přišli dva dospělí, aby útok rozehnali, přičemž jeden dospělý mladíky od sebe odtáhl.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: "To je to, co dostanete."
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali," řekl ve čtvrtek její otec Michael Kuch televizi CBS New York a dodal, že je rozzlobený a chce, aby všichni viděli video a to, co puberťáci udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video, na kterém je napadena ve škole. CBS2
Kuch řekl, že policie měla být okamžitě přivolána, protože studenti, s nimiž prý měla jeho dcera problémy, jí rozbili obličej dvacetiuncovou lahví.
"Kdyby zavolali policii a provedli vyšetřování, ty dívky by videa ze školy nezveřejnily," řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
"Vždy řešíme každou otázku šikany a v den incidentu byli čtyři studenti suspendováni," řekl doktor Triantafillos Parlapanides, superintendent škol, televizi CBS New York.
Školní úředníci řekli CBS New York, že oznámili rodině a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucího soudního vystoupení, řekl prokurátor CBS News.
Studenti školy uspořádali ve středu procházku na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v citové tísni nebo v sebevražedné krizi, můžete se dostat na linku 988 Suicide & Crisis Lifeline zavoláním nebo textovou zprávou 988.
Můžete si také popovídat s 988 Suicide & Crisis Lifeline zde.
Pro více informací o zdrojích a podpoře péče o duševní zdraví je možné kontaktovat Linku pomoci Národní aliance pro duševní onemocnění (NAMI) od pondělí do pátku, od 10.00 do 22.00.
ET, na 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 zdravotníky, wellness profesionály o tom, jak se vyhnout vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v naší práci.
Pro ty ve zdravotnictví to může být nesmírně obtížné, a proto jsem položil 30 zdravotníkům a wellness profesionálům stejnou otázku: "Jak zvládáte svou energii a nevyhoříte ve své profesi?"
Jejich kariéra sahá od lékařů infekčních nemocí přes psychology až po učitele myšlení - a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v chodu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vyčnívala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Vybudovat silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají smrtelné nemoci, Eufrosina Youngová děkuje svému silnému podpůrnému systému za svou schopnost udržet si energii.
Young je certifikovaným neurologem a specialistou na ALS na neurologickém oddělení Fakultní nemocnice v Upstate a říká, že se tam "mobilizují jako armáda lidí."
Na amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo se věnuje tvrdé práci na vývoji léčby a poskytování lepších možností pro své pacienty, udržuje Youngovou v chodu i v nejtěžších dnech.
"Neneseme tíhu světa, ale jsme součástí světa lidí, kteří se za tuto práci zasazují," říká.
2.Odpočívej, když potřebuješ
Práce ve dvou zaměstnáních jako výzkumník spánku a inženýr algoritmů, to vše při péči o nové dítě, by rozhodně vedlo Raphaela Vallata k vyhoření, kdyby si neodpočinul, říká.
"Mám pocit, že když se chystám vyhořet, v podstatě každý úkol mi připadá jako hora, kterou je třeba zdolat, a připadá mi super naléhavý a důležitý," říká Vallat.
V těch chvílích si "opravdu musíte vzít nějaké volno a uvědomit si, že tyto úkoly mohou počkat."
Vallat obvykle najde ve svém dni okamžiky, kdy se může odmlčet a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3.Buďte zapálení do toho, co děláte, a pamatujte si svůj účel
Až do jara 2022 pracovala infekční specialistka Céline Gounderová 100 hodin týdně sedm dní v týdnu.
Být v první linii během pandemie jí sežralo téměř veškerý čas, ale vyhnula se vyhoření tím, že si připomněla, proč je její práce důležitá.
"Myslím, že práce není jako práce, když máte pocit, že máte nějaký dopad," říká Gounder.
"Pokud pracujete bláznivé hodiny a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu potřebujete ustoupit a ptát se, co děláte."
4.Mít jiné radosti
Na druhé straně každý z odborníků řekl, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho ve své práci dosáhnete, říká Christina Maslachová, sociální psycholožka, profesorka psychologie v důchodu na U.C. Berkeley a autorka knihy "The Burnout Challenge: Managing People's Relationships with Their Jobs."
"Podívejte se na svůj život jako na celek a ujistěte se, že jsou na něm dobré věci, a ujistěte se, že na ně máte čas."
Získejte bezplatný průvodce Warrena Buffetta pro investování od CNBC, který destiluje miliardářovu nejlepší radu č. 1 pro pravidelné investory, do's and don'ts a tři klíčové investiční principy do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Buďte chytřejší o svých penězích a kariéře s naším týdenním bulletinem
Mladistvý obviněn z vraždy v prosinci Chicagská školní střelba, která za sebou zanechala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě dvou studentů na chicagské střední škole v prosinci, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou trestných činů pokusu o vraždu, oznámil chicagský policejní superintendent David Brown.
"V současné době nemáme jasný motiv, proč by šestnáctiletý chtěl střílet a zabíjet jiné děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, i když Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběťmi, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy veřejnosti je pomohly dovést k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční za ty, kteří byli natolik odvážní, že se přihlásili, aby zajistili, že pachatel bude dopaden a nyní bude pohnán k odpovědnosti," řekl státní zástupce okresu Cook Kim Foxx.
Očekává se, že podezřelý se v sobotu dostaví k Bond Court, uvedl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Minnesotští biologové zachraňují uvězněného černého medvěda
Minnesotské ministerstvo přírodních zdrojů přispěchalo na pomoc medvědovi nešťastnému medvědovi poté, co uvízl v příkopu.
Medvěd se podle příspěvku na Facebooku z oddělení schoulil do propustky u silnice poblíž Wannasky v Minnesotě.
Když však sníh začal tát, začala se propustka zaplavovat a podle oddělení uvěznila medvěda v hlubokém sněhu a ledu.
Zaměstnanci oddělení na místo rychle zareagovali a pomohli medvěda odstranit.
Medvědí biolog oddělení Andrew Tri "vyšetřil medvěda a prohlásil ho za zdravého, ale groggyho - zřejmě proto, že se probudil ze zimního spánku," podle příspěvku na Facebooku.
Oddělení pak medvěda přemístilo do státního útočiště, aby obnovilo jeho hibernaci.
Ospalý masožravec byl odhadován na 6 let a mezi 375 a 400 librami.
Oddělení připomnělo obyvatelům, že stěhování medvědů je práce, která je nejlépe ponechána profesionálům.
Pokud se bojíte o medvěda ve svém okolí, měli byste kontaktovat místní úřady - nesnažte se spícího obra přemístit nebo nakrmit.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tarts, salátu a Fancy Feast cat food.
Ale naštěstí pro dobře míněné kopáče, "protože medvědi nemají chuť se v zimě najíst, medvěd nekousl."
Minnesota je podle ministerstva přírodních zdrojů domovem 12 000 až 15 000 černých medvědů, kteří se vyskytují hlavně v severní třetině státu.
Predátoři přezimují v zimě až šest nebo sedm měsíců, během nichž nejedí a žijí ze svého uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedli generální tajemník Nejvyšší rady starožitností v Egyptě Mostafa Waziri, velvyslanec Spanu v Egyptě Alvaro Iranzo a předseda Španělské národní výzkumné rady (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise od Nejvyšší rady starožitností a CSIC, která funguje od roku 2002.
Uvedl, že mise provedla vykopávky a restaurátorské práce a zveřejnila výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií i pohřební zahradu.
Důležité hrobky z významné éry
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili během počátku 18. dynastie Nového království - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že uspořádání hrobek má tvar T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty odpovídají vchodu, sloupové hale vedoucí k pohřební šachtě a stěnám s výraznými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a měl přehled o dílech řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byl také zodpovědný za nahrávání Hatšepsutovy cesty do Puntlandu a za poskytování elektra (směs zlata a stříbra) pro zakrytí vrcholu obelisků, které umístila do karnackých chrámů.
Kromě toho měl na starosti proces přesunu obelisků.
V místnosti, která předchází Djehutyho pohřební komoře, jsou nápisy vyryté 43 kapitolami Knihy mrtvých, poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek, než byly napsány na plátno a papyrus.
Hery zastával pozici superintendenta královských zásob posvátné královské manželky a matky Ahhotep.
Jared O'Mara nikdy neměl být kandidátem labouristů, říká Rachel Reevesová
Zneuctěný bývalý poslanec Jared O'Mara "neměl být nikdy vybrán jako kandidát labouristů" a zaslouží si svůj čtyřletý trest vězení, řekl stínový kancléř.
Rachel Reevesová hovořila s listem Guardian ve volebním obvodu Bolton North East v pátek, několik hodin poté, co klíčové osobnosti místní strany skončily na protest proti tomu, jak národní výkonný výbor labouristů (NEC) kontroluje parlamentní výběrové řízení pro příští všeobecné volby.
Celá výběrová komise v Boltonu North East rezignovala poté, co jim nebylo umožněno vybrat si užší seznam, což je v Labouristické straně Keira Starmera stále běžnější praxe, a prohlásila: "Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, nikoli místních členů na severu."
Dodali: "To jde proti postoji nezbytnému k tomu, abychom získali zpět červenou zeď, která je tak zoufale potřebná k vytvoření labouristické vlády."
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kdo jsou vybíráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Obzvlášť nešťastné bylo, že Leigh Drennan, předseda labouristického Severozápadu a pobočník Jeremyho Corbyna podporujícího poslankyni Warrington North Charlotte Nicholsovou, nebyl dlouho hledaný, aby se pokusil získat křeslo zpět od konzervativců, navzdory tomu, že získal nominace od čtyř velkých odborových svazů.
Reevesová řekla, že s výběrem kandidátů nemá nic společného, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné postupy pro to, kdo může být na dlouhém seznamu a kdo může být na krátkém seznamu."
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné žádosti o výdaje v celkové výši 52 000 liber ve snaze financovat jeho zneužívání kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl řádně prověřen labouristy, když byl vybrán, aby v roce 2017 v bleskových všeobecných volbách bojoval s Nickem Cleggem, bývalým vicepremiérem liberálních demokratů, v Sheffieldu Hallam.
Na otázku, zda se v myslích labouristické NEC rýsuje velký debakl O'Mara, Reeves řekl: "Nechci v žádném případě naznačovat, že někdo, kdo není na užším seznamu, je uživatel kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako kandidát labouristů; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest."
O'Marovy okolnosti byly "dost výjimečné," řekla Reevesová, ale uznala: "Pro Labouristickou stranu a všechny politické strany je třeba si vzít důležitá ponaučení z výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě řadou premiérů a pokut a stran a standardů, které značně zaostávají za tím, co byste mohli očekávat."
Dodala: "Jedna věc, kterou bych řekla o Labouristické straně, je, že když lidé dělají špatně, ztrácejí bič. A v Konzervativní straně tomu tak prostě není."
Archie Bland a Nimo Omer vás provedou nejlepšími příběhy a tím, co znamenají, zdarma každý všední den ráno.
Oznámení o ochraně osobních údajů: Newslettery mohou obsahovat informace o charitativních organizacích, on-line reklamách a obsahu financovaném externími stranami.
Více informací naleznete v našich Zásadách ochrany osobních údajů.
Používáme Google reCaptcha k ochraně našich webových stránek a platí zásady ochrany osobních údajů a podmínky služby společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve výcvikovém středisku pro Openreach, které poskytuje britskou širokopásmovou síť.
Poté, co Reeves sledoval, jak učni šplhají po předstíraných telegrafních sloupech v lokalitě za 1,7 milionu liber, diskutoval o plánech labouristů na přepracování učňovské dávky, která nutí větší firmy odložit 0,5% své mzdy na financování učňů.
Podniky si stěžují, že dávka je příliš nepružná. Například, řekl Reeves, Openreach "chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vláknech, ale učňovská dávka nemá takovou flexibilitu kolem rekvalifikace."
Reeves řekl, že labouristé daň změní, aby firmy mohly peníze použít na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový sektor, a v těch, která v současnosti montují plynové kotle.
"Potřebujeme je v rámci energetického přechodu na čistou nulu, abychom se naučili pracovat na elektrických vozidlech nebo montovat tepelná čerpadla nebo vodíkové kotle.
Chceme, aby tito lidé byli přeškoleni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se proti nim naskládá učňovská dávka.
Podniky chtějí větší flexibilitu a mladí lidé, kteří začínají v životě, nebo starší lidé, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou pro budoucnost relevantní," uvedl Reeves.
Jeden zatčený uprostřed protestu Tate Britain kvůli akci drag queen children
Jedna osoba byla zatčena uprostřed protestu před Tate Britain, kde se pořádala pohádková akce pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření, že pronesla rasově přitěžující poznámku vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyla hlášena žádná zranění a policisté zůstávají na místě, uvedla jednotka.
Tate v sobotu pořádal Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou webové stránky galerie popisují jako "prvního tahouna v Evropě, který četl příběhy dětem ve školce."
Před galerií demonstrovala pravicová skupina protestujících a setkali se s protistranami vedenými bojovníky za práva a politickými skupinami, včetně Stand Up to Racism.
Důstojníci museli vytvořit chodbu, aby se účastníci mohli dostat na místo.
Královna tažení na Twitteru uvedla, že den byl "řádně emocionální," a dodala, že pět demonstrantů získalo vstup do Tate a "způsobilo narušení" v částech budovy, ale na údaje to nemělo vliv.
Již dříve řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ+ bylo "čestí."
Její údaje se již dříve staly terčem protestujících.
Drag Queen řekla, že "hodnocení rizik" proběhlo předem - ale dodala, že je "směšné," že jsou nezbytná.
Aida tweetovala: "Do Tate se dostalo 5 nenávistníků. Způsobili narušení. ALE aby to nebylo Drag Story Hour UK ...Vyvolali povyk jinde v budově, ne tam, kde byla show!! SHOW 2 šel plavně!!!"
Aida pořádala v sobotu v jedenáct dopoledne, v poledne a ve dvě odpoledne tři vypravěčská sezení.
Mluvčí Tate řekl: "Neprogramujeme umělce s cílem propagovat konkrétní úhly pohledu, ani sladit rozdílné úhly pohledu."
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, s jakými aspekty se zapojí."
Trumpova ceněná 40 Wall Street Building On 'Lender Watch' Amid Dropping Income: Report
Silně zatížený mrakodrap Donalda Trumpa na 40 Wall Street je na "půjčovatelské hlídce" uprostřed prudce klesajících příjmů a rostoucích nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější - vyskočila ve třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání žádosti o zbývající hypotéku ve výši 126,5 milionu dolarů, uvedla agentura Bloomberg.
Výdaje mezitím od vzniku hypotéky v roce 2015 údajně vzrostly o 11%.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
Den 11. září 2001, kdy došlo k teroristickým útokům, které zničily Světové obchodní centrum a zabily 3000 lidí, se jeden Trump v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budovou ve městě.
Nejenže bylo jeho tvrzení necitlivé, ale byla to také lež.
Další nedaleký mrakodrap na Pine Street na Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem výškových kanceláří na Manhattanu už léta klesá, což se po vypuknutí pandemie COVID-19 ještě zhoršilo, protože řada firem zavřela provoz a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, "oslovila dlužníka o status leasingového vývoje" a plány na zlepšení výkonnosti nemovitosti podle podání, uvedla agentura Bloomberg.
Majitel Wagnerové tvrdí, že válka na Ukrajině se bude táhnout roky
Majitel ruského soukromého vojenského dodavatele Wagner Group, který se aktivně podílí na bojích na Ukrajině, předpověděl, že válka by se mohla táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek uvedl, že může trvat 18 měsíců až dva roky, než si Rusko plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny v Donbasu.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a pro své lukrativní kremelské zakázky na stravování byl nazván "putinovským kuchařem," znamenalo uznání obtíží, jimž Kreml čelil v kampani, kterou původně očekával během několika týdnů, kdy ruské jednotky 24. února napadly Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících nezdarů, když ukrajinská armáda zahájila úspěšné protiofenzívy s cílem získat zpět široké pásy území na východě a jihu.
Kreml se vyhnul prognózám, jak dlouho by boje mohly pokračovat, a prohlásil, že to, co nazval "zvláštní vojenskou operací," bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří oblast Donbasu, kde od roku 2014 bojují separatisté podporovaní Moskvou proti ukrajinským silám.
Prigožin uvedl, že žoldnéři Wagnerovy skupiny pokračují v nelítostných bojích o ovládnutí ukrajinské pevnosti Bakhmut v Doněcké oblasti.
Uznal, že ukrajinské jednotky stupňují zuřivý odpor.
Vzhledem k tomu, že ruské jednotky vytlačily své útoky na Donbasu, Moskva se také snaží demoralizovat Ukrajince tím, že je v kruté zimě nechává bez tepla a vody.
Rusko v pátek zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Zařízení vysokonapěťové infrastruktury byla zasažena ve východních, západních a jižních regionech, což mělo za následek výpadky proudu v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná," a dodala, že se jedná o zálohy, aby se udržely dodávky energie, ale poznamenala, že v některých oblastech bude příděly energie pokračovat.
Ukrajinský vojenský šéf, generál Valerij Zalužnyj, řekl, že ruské síly odpálily mezi čtvrtečním a pátečním polednem 71 střel s plochou dráhou letu, 35 střel S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět bezpilotních letounů.
Ukrajinské úřady ohlásily další útoky zabijáckých bezpilotních letounů ještě v pátek.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 bezpilotních letounů Shahed.
Pozdě v pátek zveřejnili ruští vojenští blogeři a některé ukrajinské zpravodajské služby video zachycující útok námořního dronu na strategický železniční most v Oděsské oblasti.
Zrnité video ukazovalo rychle se pohybující předmět, který se blížil k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a vybuchl při silném výbuchu.
Pravost videa se nepodařilo ověřit.
Ukrajinská armáda se k útoku nevyjádřila a Serhij Bratčuk, mluvčí regionální administrativy, nepotvrdil útok bezpilotního letounu, když v sobotu hovořil v televizním vystoupení.
Most, na který se počátkem války zaměřily ruské raketové údery, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazašští záchranáři pokračují v kopání sutin a pátrají po přeživších v Türkiye, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů brzdí velké množství trosek a nestabilní konstrukce.
Od nynějška kazašský záchranný tým vytáhl v Türkiye sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc je také poskytována nepřetržitě.
Jmenovitě zemětřesení o síle 7,7 stupně, které zpustošilo části jihovýchodního Türkiye a severní Sýrie, udeřilo počátkem pondělí.
Počet obětí mohutných otřesů, které dnes zasáhly jihovýchod od Türkiye, přesáhl 20 tisíc.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM - Slavnostní zahájení 10. asijské atletické halové mistrovství se konalo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Při zahájení akce přečetl šéf kazašské vlády uvítací dopis prezidenta Kassyma-Jomarta Tokajeva.
"Sport nezná hranic.
Posiluje přátelství a sdružuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro provozování profesionálního a hromadného sportu.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex s kapacitou přes šest tisíc lidí," stojí v dopise kazašského prezidenta.
Kazachstánští sportovci úspěšně soutěží a reprezentují Kazachstán na velkých světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání mistrovství Asie v Astaně dá nový impuls rozvoji atletiky v zemi a zaváže se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za pomoc při přípravě a konání šampionátu.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Na turnaji se sešlo přes 500 sportovců z 31 zemí, kteří mají soutěžit v závodě, štafetovém závodě, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, hodu oštěpem a všestranném závodě.
Turnaj má proběhnout do 12. února.
Dříve se uvádělo, že kazašská běžkyně Caroline Chepkoech Kipkiruiová získala ženské 3000 m zlato a Olga Safronová si na turnaji připsala ženské 60 m stříbro.
Foto: primeminister.kz
"Yellowstonský" herec Q'orianka Kilcher poráží obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském blockbusterovém procesu pomluvy, zaznamenala další právní vítězství - tentokrát s "Yellowstone" hercem Q'oriankou Kilcherovou.
V pátek kancelář okresního státního zástupce v Los Angeles zbavila Kilchera, 32 let, všech obvinění v případu podvodu s odškodněním zaměstnanců.
V prohlášení sdíleném v pátek s The Times mluvčí okresního státního zástupce v Los Angeles uvedl, že soud "zjistil, že se slečna Kilcherová nedopustila pojistného podvodu, a informoval soud, že nejsme schopni pokračovat."
V červenci 2022 obvinili kalifornští úředníci Kilcherovou ze dvou trestných činů podvodu s odškodněním zaměstnanců a obvinili ji, že mezi říjnem 2019 a zářím 2021 nezákonně inkasovala více než 96 000 dolarů v invalidních dávkách.
Časový rámec zahrnuje také několik měsíců, kdy Kilcher pracoval na "Yellowstone," navzdory hercovým tvrzením, že byla příliš zraněná na to, aby mohla pracovat.
Kilcher se sám vzdal a v květnu byl obžalován.
"Dnes jsem nevděčný za to, že můj případ byl zamítnut - zítra moje cesta začíná pomáhat zvyšovat povědomí a požadovat větší transparentnost práv pracovníků v rámci systému pracovníků," uvedl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že se "těší, až vrhá více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji."
Kilcher také poděkoval Vasquezové a jejímu kolegovi Brownu Rudnickovi advokátovi Stevu Cookovi za "jejich neochvějnou víru v mou nevinu."
Podle TMZ si Kilcher ty dva najal v září.
Kilcherová vypukla s filmem Terrence Malicka z roku 2002 "Nový svět," kde ztvárnila Pocahontase.
Mezi její kredity patří také "Synové anarchie," "Alienista" a "Dora a ztracené město zlata."
Naposledy se objevila ve filmu "Pes" v hlavní roli Channinga Tatuma.
Do této zprávy přispěla i tehdejší personalistka Christina Martinezová.
Šéf Balenciagy nazývá prázdninovou kampaň "hloupou chybou"
Luxusní oděvní značka Balenciaga se stále vzpamatovává z odporu vůči dvěma svým nedávným reklamním kampaním.
Měsíce poté, co se módní dům dostal pod horko kvůli propagačním obrázkům, o nichž kritici tvrdili, že sexualizují děti, umělecký ředitel Balenciagy Demna (celé jméno Demna Gvasalia) řekl, že ho obrázky v rozhovoru pro Vogue zveřejněném v pátek stále mrzí.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro darovací kampaň s dětmi a beru na sebe svou odpovědnost," řekl Vogue a zopakoval tak předchozí prohlášení, které v prosinci zveřejnil na sociálních médiích.
V listopadu značka sdílela fotografie pro svou kolekci "Dárek," na níž byly dětské modelky pózující s plyšovými medvídky, kteří byli oblečeni do otroctví.
Krátce nato Balenciaga upustila fotografie pro svou kampaň na jaro 2023, která obsahovala stránku z případu Nejvyššího soudu z roku 2008, který se týkal "virtuální dětské pornografie" v pozadí.
Rodiče, včetně hvězdy reality TV a dlouholeté fanynky Balenciagy - a značkové partnerky - Kim Kardashianové, vystoupili proti značce a jejím "znepokojivým obrazům" na sociálních médiích.
O den později Balenciaga vydal prohlášení, v němž se za fotografie omlouvá a nastiňuje změny, které provede, aby se v budoucnu vyhnul podobným "chybám."
"Tato zkušenost mě donutila přehodnotit spoustu věcí způsobem, jakým já, my, pracujeme, způsobem, jakým vytváříme a komunikujeme obrazy, způsobem, jakým komunikujeme s naším publikem, a způsobem, jakým se učíme ze svých chyb a posouváme se kupředu," řekl Demna Vogue.
Podrobně popsal postbacklashové změny v Balenciaze: "restrukturalizaci image oddělení," provádění více interních a externích kontrol obrazových kampaní a spolupráci s Národní dětskou aliancí na pomoc "tisícům dětí v procesu překonávání traumatu a řešení jejich duševního zdraví."
"Je to jediná věc, která mě z celé té hrozné situace těší: udělat z ní něco dobrého," řekl o tomto partnerství, které bylo oznámeno ve středu.
S NCA se spojuje také mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod Keringovým deštníkem je Gucci, který v prosinci čelil kritice za kampaň s Harrym Stylesem, o níž někteří kritici sociálních médií tvrdili, že také sexualizuje děti.
V rozhovoru Denma řekl, že se hodlá odklonit od "provokativních" způsobů značky.
"Je to součást mého učení: budu mít dospělejší a serióznější přístup ke všemu, co uvolním jako nápad nebo obraz," řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciagy, která vyrábí kvalitní oblečení - nedělá image ani bzučení."
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jedna z "bolestivějších" částí odporu pošpinila "jméno Balenciagy a odkaz Cristóbala Balenciagy."
"Balenciaga je dům, který je více než jedno století starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem měl plné ruce práce s tím, abych ho uvedl do svého moderního významu, a najednou jsme byli napadeni a označeni za něco, co vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s darovací kampaní a určitě jsme se z ní poučili."
Jsou to falešné zprávy, CBN Debunks tvrdí, že postrádá kapacitu tisknout další nové poznámky Naira
Centrální banka Nigérie (CBN) označila za zavádějící zprávu, která tvrdila, že cituje govemora CBN, pana Godwina Emefieleho, za připisování současné výzvy při distribuci nově přepracovaných bankovek Naira nedostatku tiskařských materiálů v nigerijské společnosti Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neučinil takové prohlášení během své prezentace Národní státní radě na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele na schůzce pouze sdělil, že NSPMC pracuje na tisku všech denominací Nairy, aby uspokojila transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy, které projevily všechny zúčastněné strany ohledně distribuce nových Nairových poznámek, "jsme znepokojeni tím, do jaké míry se partikulární zájmy pokoušejí manipulovat s fakty a postavit veřejnost proti bance."
Nwasinobi uvedl, že CBN je i nadále odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění pozdějších předpisů).
"Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálů pro výrobu požadované odrážky Nairy.
"Banka proto chce apelovat na veřejnost, aby zmíněnou zprávu ignorovala a chovala se zdrženlivěji, přestože usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na zvláštní hlasové poznámce, která se objevila na sociálních médiích a která tvrdila, že CBN plánuje zavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že žádný takový plán neexistuje a že tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický tah CBN a jsou jen zoufalými pokusy osob, které se snaží podněcovat veřejnost proti bance," konstatoval.
Tim Sherwood se po skličujícím debutu v Tottenhamu rozplývá do 44 milionů liber podpisem Pedra Porra
Porro měl odpoledne na to, aby zapomněl proti Leicesteru (obrázek: Getty)
Tim Sherwood se při porážce Tottenhamu 4:1 s Leicesterem City vloupal do "absolutně nechutné" obrany Pedra Porra.
Spurs podepsali pravého obránce od Sporting CP v den uzávěrky přestupu na počáteční úvěrovou smlouvu na 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
Třiadvacetiletý útočník si svůj debut odbyl Antoniem Contem v sobotu na King Power Stadium s tím, že se po 14 minutách ujal vedení díky Rodrigu Bentancurovi.
Ale změnilo se to v bídné odpoledne, kdy Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni skórovali, aby dali Leicesteru v poločase 3:1, přičemž Porro vydržel trýznivý první poločas v Premier League.
Španěl byl opět na vině, protože Leicester si myslel, že díky Barnesovi přidali čtvrtý, a i když byl gól vyloučen pro ofsajd, bývalý manažer Spurs Sherwood zůstal šokován plzeňskou defenzivou.
"Nechci si toho kluka pořád vybírat, ale je třeba ho zbavit jeho povinností," řekl Sherwood v sobotu fotbalistům.
Dám mu výhodu pochybností, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden říkal, že utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a toto je poslední přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale to, na co se dívám, je hráč, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na obranu a tento hráč, v současné době se snaží bránit. Je proti velmi dobré hráče v Barnes a Maddison, ale je to velmi zklamání."
Zatímco gól byl vyloučen, Leicester obnovil jejich náskok 4:1 s Barnesem na terč devět minut před plným nasazením.
Navzdory tomu, že minulý týden porazil Manchester City, Tottenham promarnil šanci posunout se před Newcastle na třetí místo.
OBRAZEM: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala Joaa Felixe a místo toho se vrhla na hvězdu Tottenhamu
OBRAZEM: Tottenham se chystá ucházet o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu
Další příběhy, jako je tento, najdete na naší sportovní stránce.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoliv souboj o privilegia kvůli obsílce Mika Pence
Zpráva, že zvláštní právní zástupce Jack Smith předvolal Mika Pence, vyvolává otázku: Jak tým Trump využije soudů k tomu, aby tento nejnovější vývoj v sondě ministerstva spravedlnosti zamlžil?
Stručná odpověď zní, že jakýkoli pokus o zmaření Penceova obsílky z důvodů exekutivních privilegií by měl selhat.
Za prvé je tu prahová otázka, zda si bývalý prezident vůbec může nárokovat privilegium.
Připomeňme, že se Trump pokusil a nepodařilo se mu zablokovat výboru Sněmovny 6. ledna, aby získal záznamy Bílého domu.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, přičemž nesouhlasil pouze soudce Clarence Thomas (manžel volební popírače voleb v roce 2020 Ginni Thomasové).
Soud však ponechal otevřenou otázku, zda si exprezident může nárokovat privilegia, přičemž soudce Brett Kavanaugh navrhl, že by takové tvrzení podpořil.
Není tedy alespoň jasné, zda si bývalý prezident může nárokovat privilegium, a neříká nic o tom, zda by nárok uspěl.
Navíc odvolání Nejvyššího soudu kvůli pokusu tehdejšího prezidenta Richarda Nixona vyhnout se dodržování obsílek ukazuje, že neurčité tvrzení o privilegiích nebude stačit a může být překonáno konkrétní potřebou důkazů.
Soud v roce 1974"s United States versus Nixon poznamenal:
... je-li důvod pro uplatnění výsady, pokud jde o předvolané materiály hledané pro použití v trestním řízení, založen pouze na všeobecném zájmu na mlčenlivosti, nemůže převážit nad základními požadavky řádného právního procesu při spravedlivém výkonu trestního soudnictví.
Zobecněné prosazování výsady musí ustoupit prokázané, konkrétní potřebě důkazů v probíhajícím trestním řízení.
Proto je precedens na straně vlády.
Zpoždění od soudních sporů i v případě prohry však samozřejmě může být pro Trumpa určitým vítězstvím.
Další utlumení pravděpodobnosti úspěšného nároku na privilegia je však předchozí odmítnutí Trumpova pokusu zablokovat výpověď 6. ledna velké poroty.
Jak v říjnu uvedl list The Washington Post, toto odmítnutí konstatovalo, že například bývalý Penceův pobočník Marc Short "pravděpodobně disponoval informacemi důležitými pro trestní vyšetřování ministerstva spravedlnosti ohledně útoku na Kapitol 6. ledna 2021, který nebyl dostupný z jiných zdrojů."
Také to, že Pence má pravděpodobně jedinečné informace, by ministerstvu spravedlnosti pomohlo v jakémkoli předvolání.
A důvod, proč si myslíme, že Pence takové informace má, je dalším důvodem, proč by nárok na privilegia měl selhat.
To proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Těžko říct, že komunikace je privilegovaná, když jste je dříve považovali za vhodné k propagaci.
Takže zatímco obsílka by mohla představovat různé politické a osobní výpočty pro Pence - který může soupeřit o republikánskou nominaci v roce 2024 proti Trumpovi, někoho, kdo účinně schvaloval výzvy k Penceově mimosoudní popravě 6. ledna -, soudy by měly mít snadný čas stranit ministerstvu spravedlnosti ohledně privilegií.
Případ Bidenova běhu je zřejmý - a slabý
Proč je to důležité?
Biden a jeho kolegové demokraté sice nemohou při schvalování zákonů s vládní stranou ovládající sněmovnu mnoho dělat, ale i tak mohou strávit další dva roky tím, že půjdou příkladem.
Dohromady by všichni v týmu měli hledat příležitosti, jak hrát Gallantovi s podivnými Goofusovými impulzy republikánů.
Ale je také důležité, aby Biden vyburcoval svou důvěryhodnost u amerického lidu - a možná byl zoufale potřebným agentem změny v naší až příliš potetované politické kultuře.
Washington, notoricky cynické místo, je proslulý svými zdravým rozumem ochromujícími představami o vedení.
Zřejmě jednou z nejznámějších je podivná norma, která zastává názor, že veřejně přiznané chyby jsou známkou slabosti a že politici by měli jít do komických hloubek, aby se tomu vyhnuli.
Je tu ještě jedna cesta: v Bailoutových pamětech Neila Barofského o jeho působení ve Washingtonu jako zvláštního generálního inspektora dohlížejícího na program na pomoc problémovým aktivům popsal rady, které dostal od Kristine Belisleové, ženy, kterou si šikovně najal na funkci ředitelky komunikace.
Bylo to asi tak protiwashingtonské, jak jen to jde: "Přiznáme si a dokonce zvýrazníme své chyby."
Jak pokračovala ve vysvětlování, ve strategii je metoda, kterou by většina lidí uvnitř Beltwaye považovala za šílenství:
To je nejlepší způsob, jak si získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Občas bychom se mohli stydět a zveřejnit věci, které bychom mohli - a ostatní by - snadno skrýt, ale tisk budeme šokovat svou upřímností.
Nikdo jiný to nedělá a zanedlouho budeme mít zabudovanou obranu, až budeme napadeni.
Nezáleží na tom, co uslyší, tisk k nám přijde první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je pro Bidena možná největší důvod, proč pokračovat v kurzu radikálního přebírání odpovědnosti: v každém prezidentském úřadu nevyhnutelně nastávají okamžiky, kdy je zásadní mít důvěru veřejnosti a institucí, které chrání občanský zájem.
Navíc je tu životně důležitý kapitál, který si lze vydělat vlastnictvím našich chyb, a je tu důležitý rozdíl, který Biden může se svými politickými oponenty vyvodit.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: Řekni pravdu - a zahanbe ďábla.
Některé reklamy na Super Bowl, na které se nemůžu dočkat
Devadesátá sitcomová hvězda reprízuje svou milovanou roli, aby vám prodala pojištění auta.
Inzerát, který se stává kulturním fenoménem a okamžitě se jako televizní pořad zezelená a prodlouží dvanáctivteřinovou scénu do deseti sezón.
Všechny celebrity z loňských krypto reklam se omlouvají za své krypto reklamy.
Tihle "whassup" hoši, ale hlavní je, že teď jsou staří.
Všichni jsou teď v hajzlu, že jo?
Takže nějaká série reklam režírovaných Rianem Johnsonem, kde když přijdete na to, kdo vraždu spáchal, dostanete slevu na rok pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativní chlápci týden zuřit.
Timothée Chalamet v nějaké funkci.
Někoho, kdo byl údajně navždy zrušen, aby se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte a který určitě uvidíte, až bude za tři týdny streamován.
Nesnesitelně chytlavá nová znělka, kterou si budete zpívat celé roky.
Recyklovaný vtip na Twitteru z doby před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste se spojili s Wells Fargo.
"Zoom zoom" dítě, ale bit je v tom, že teď je dospělý.
Bidenův ÚOOZ "Nechce ozbrojené občanství"
Rektor Andrew Clyde (R-GA) ve čtvrtek zasedal s Breitbart News a diskutoval o svých plánech zablokovat pravidlo ATF pistole a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti "v první řadě nechce ozbrojené občany."
Clyde dal jasně najevo svůj nesouhlas s pravidlem o držení pistole.
Mezi jeho důvody tohoto odporu patří jak obecné námitky, tak konkrétnější.
Obecně vyjádřil své přesvědčení, že naši otcové zakladatelé nestanovili plán řízení, který by zahrnoval federální agentury, které by vytvářely zákony místo zákonodárného sboru.
Řekl: "Ministerstvo spravedlnosti je tu od toho, aby prosazovalo zákon, ne aby tvořilo zákon. Když máte výkonnou moc, která tvoří zákon a vymáhá zákon, pak máte krále a království. Naši Zakladatelé nepožadovali krále a v ústavě Spojených států nevytvořili království."
Clyde se pak přesunul ke specifikům týkajícím se pravidla pistolové výztuže a vyjádřil své znepokojení nad tím, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: "ATF chce, aby se zvýšila registrační databáze Národního zákona o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co přichází před konfiskací, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany."
Dodal: "Ale tohle ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby po nás mohli jít."
Clyde tvrdí, že pravidlo ATF pistole se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní, a hodlá s ním bojovat zuby nehty.
Řekl, že má "tři nástroje," kterými může proti pravidlu bojovat.
Prvním z těchto nástrojů je zákon SHORT a druhým zákon o kongresovém přezkumu.
Dne 30. ledna Breitbart News citoval Clydea, který nastínil svůj plán "znovu zavést zákon Stop Harassing Owners of Rifles Today Act neboli SHORT Act, který by zrušil prvky Národního zákona o střelných zbraních, čímž by ATF zakázal registrovat a zakazovat pistole se stabilizačními rovnátky."
Poznamenal také, že "předloží usnesení o nesouhlasu podle zákona o revizi Kongresu, aby přehlasoval nezákonný přehmat Bidenovy administrativy."
Oba akty, zákon SHORT a zákon o kongresovém přezkumu, mají možnost zablokovat pravidlo ATF o pistolové ortéze.
Jak však Clyde ve čtvrtek řekl Breitbart News, velkou výzvou je, že obě tyto trasy budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k uzákonění právních předpisů SHORT Act, nebo k dokončení usnesení o nesouhlasu podle zákona o kongresovém přezkumu.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být doplněna o další, větší návrhy zákonů, které demokraté velmi touží schválit.
Clyde však naznačil, že existuje i třetí způsob, jak zablokovat pravidlo ATF pistole.
Řekl: "Jsem v Rozpočtovém výboru a můžeme zrušit toto pravidlo o držení pistole, a to prostřednictvím toho, čemu se říká pozměňovací návrh o omezení. Toto pravidlo můžeme doslova znehodnotit a v podstatě říci: "Žádné peníze nesmí být vynaloženy na provádění nebo prosazování tohoto konkrétního pravidla pistolové ortézy."
A totéž můžeme udělat i s pravidlem ATF receiver/frame, z loňského srpna.
Myslím, že je třeba oba znehodnotit, a těším se na spolupráci s našimi přivlastňovateli, abychom to udělali.
AWR Hawkins je oceněným komentátorem druhého dodatku pro Breitbart News a spisovatelem/kurátorem Down Range s AWR Hawkinsem, týdenním bulletinem zaměřeným na všechny věci druhého dodatku, také pro Breitbart News.
Je politickým analytikem ozbrojeného amerického rozhlasu a velvyslancem USA.
AWR Hawkins má doktorát z vojenské historie se zaměřením na válku ve Vietnamu (hnědé vodní námořnictvo), americké námořnictvo od založení, občanskou válku a ranou moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat, abyste získali Down Range na breitbart.com/downrange.
Kontaktujte ho přímo na adrese awrhawkins@breitbart.com.
"Doufáme," že Biden má plán na manipulaci s hlavou 42 Ending, "Jestli to udělají, tak se o to plně nepodělili"
Jared Polis (D) v pátečním vydání pořadu NBC "MTP Now" řekl, že má "velké obavy" z toho, co se stane, až hlava 42 v květnu skončí, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že "pokud to udělají, ještě se s námi o to plně nepodělili."
A řekl, že "jsme řekli, že potřebujete plán. Chceme, aby ho u nás prověřili."
Polis prohlásil, že si přeje, aby se během schůzky guvernérů v Bílém domě věnovalo otázce přistěhovalectví více času, ale tato otázka se "vznesla."
Částečně jsme tam měli i tajemníka Starostů.
A tak jsme znovu nadnesli, že je tu spousta obav, které sdílím o to, co se stane, až hlava 42 v květnu skončí, a tak, zajistit, aby federální vláda měla plán.
Doufáme, že ano.
Pokud ano, ještě se s námi o to plně nepodělili.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to u nás prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo krát tři, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Následujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stahuje "nevkusný" inzerát poblíž krematoria - RT World News
McDonald's se omluvil poté, co byl inzerát na hamburger řetězce rychlého občerstvení "McCrispy" umístěn blízko krematoria ve Spojeném království - i když někteří místní viděli tu legrační stránku.
Řetězec restaurací se zavázal, že odstraní urážlivé reklamní hromadění po stížnostech obyvatel Trura v britském hrabství Cornwall.
V pátek si získala pozornost na sociálních médiích za to, že byla umístěna na rušné silnici přímo naproti provozovně, která nabízí kremační služby.
Jasně osvětlený inzerát, který byl umístěn přímo za cedulí ukazující na krematorium, byl některými rozzlobenými místními označen za "nevkusný."
"I když vidím tu legrační stránku, je nevkusná a jsem si jistý, že někteří truchlící rodinní příslušníci ji nebudou rádi vidět při návštěvě Penmountu na pohřeb a kremaci milované osoby," řekl obyvatel, jehož tchyně byla loni zpopelněna v pohřebním ústavu, jak citovala britská média.
Ne každého však nešťastné umístění reklamy tak urazilo, přičemž jeden z nich poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, "jak dávno jste sledovali nápis krematorium v černé kravatě."
Jeden člověk řekl, že "spadli ze židle se smíchem," když si inzerátu všimli na internetu, zatímco jiný místní si všiml, že to "není o nic horší" než rozhodnutí rady bavit se myšlenkou umožnit výstavbu krematoria "vedle důchodové vesnice."
Prohlášení vydané společností McDonald's zveřejnila místní média v pátek brzy poté, co se na internetu objevil obraz reklamy, v němž řetězec restaurací uvedl, že inzerát co nejdříve odstraní.
"Nevěděli jsme o dopravní značce v okolí této autobusové zastávky. S ohledem na obavy, které CornwallLive vyvolal, jsme však požádali o odstranění naší reklamy," uvedla značka rychlého občerstvení.
Cornwallská rada, která provozuje krematorium i autobusový přístřešek, který zobrazuje inzerát, odmítla komentář k rozruchu, když ji kontaktovala místní média.
Pohřešovaná žena "vnitřního instinktu" není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové vstoupilo do 16. dne poté, co její partner řekl, že jeho "střevním instinktem" je, že není v řece.
Lancashirská policie uvedla, že policisté mají "otevřenou mysl" a zároveň nadále apelují na informace o paní Bulleyové, která zmizela 27. ledna při venčení svého psa v St Michael's na Wyre.
Síla pokračuje v prohledávání řeky Wyre směrem k moři v zátoce Morecambe a pracuje na jedné hypotéze, že pětačtyřicetiletý mladík z Inskipu mohl spadnout dovnitř.
Při jejich pátrání pomáhali specialisté a potápěči z HM Coastguard, horské záchranné služby a Lancashire Fire and Rescue Service s nasazenými čichacími psy, drony a policejními vrtulníky.
Paní Bulleyová zmizela, když kráčela se svým springerským kokršpanělem Willow poblíž řeky, krátce poté, co ve škole vysadila své dcery ve věku šest a devět let.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále napojený na pracovní hovor.
Její partner Paul Ansell řekl, že si chce ponechat "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "vnitřní instinkt" mu říká, že není v řece.
Popsal paní Bulleyovou jako "zábavnou," "milující," "nejvěrnější přítelkyni, jakou jste kdy mohli mít" a "výjimečnou mámu," která "absolutně zbožňuje naše dívky."
"Je to jen pilíř síly pro naši rodinu a bez ní je ta díra větší, než si dokážete představit," řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází "bezprecedentním peklem," naděje, že se jeho partner najde, je "silnější než kdy jindy."
Policie odmítla nečistou hru a incident považuje za vyšetřování pohřešované osoby.
Ve čtvrtek se těžiště jejich pátrání přesunulo ze Svatého Michala asi 10 mil po proudu, kde se řeka vypouští do moře v zátoce Morecambe, přičemž v oblasti byly spatřeny hlídkové a záchranné čluny.
Poslední komunistický vůdce východního Německa zemřel v 95 letech
BERLÍN (AP) - Hans Modrow, který působil jako poslední komunistický vůdce východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95.
Modrow zemřel v sobotu časně ráno, tweetovala parlamentní skupina Levicové strany.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce poté, co padla Berlínská zeď, a později pozval do vlády opoziční síly, ale nedokázal zpomalit narůstající dynamiku znovusjednocení Německa.
"Celý mírový průběh nastolení německé jednoty byl právě jeho zvláštním úspěchem," napsala levice na Twitteru."To zůstane jeho politickým odkazem."
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst protiestablishmentové osobnosti.
Odmítl stranické požitky a trval na tom, že bude bydlet v normálním bytě.
Post ve vrcholném vedení východního Německa mu unikal, dokud se v listopadu 1989 - několik dní po pádu Berlínské zdi - nestal premiérem, což byla pozice, která dříve měla jen malý vliv.
Když počátkem prosince odstoupil vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou osobností východního Německa.
Komunisté už ale nemohli sami volat výstřelky.
Následující měsíc souhlasil s tím, že se podělí o moc se stále hlasitější opozicí a posunul první svobodné volby ve východním Německu do března 1990, uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle nabrala prosjednocovací příchuť, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se západním Německem směrem k případné "sjednocené vlasti," která by byla nezávislá na vojenských blocích a vládla by společnému parlamentu v Berlíně.
Modrow stál v čele volební kampaně restyltovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nestačila k tomu, aby jim zabránila skončit jako teprve třetí nejsilnější strana s šestnáctiprocentní podporou.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a podporovala ji vláda západoněmeckého vůdce Helmuta Kohla.
Německo se znovu spojilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal do roku 1994, a čestným předsedou postkomunistické PDS - předchůdce dnešní opoziční Levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost za tvrdé komunistické vlády ho několik let po znovusjednocení přivedla k soudu.
V roce 1995 ho soud usvědčil z podněcování k falšování výsledků v květnových komunálních volbách v Drážďanech 1989.
Vyměřila mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný, a tvrdil, že jeho výsledek zhorší rozpory mezi východními a západními Němci.
Jeho právní zástupce tvrdil, že napravil předchozí nespravedlnost tím, že dohlížel na svobodné volby ve funkci premiéra.
Později v životě Modrow působil v radě starších levicové strany.
"Hans byl hluboce upřímný a bojovný socialista," tweetoval Dietmar Bartsch, předseda poslaneckého klubu Levicové strany.
"Až do vysokého věku byl důležitým poradcem v naší straně, jehož moudrost bude chybět."
Indická vláda po kritice stahuje výzvu k objetí krav na Valentýna
Objímání krávy na Valentýna už indická vláda nepovzbuzuje - navzdory tomu, že dříve žádala lidi, aby tak činili, aby propagovali hinduistické hodnoty.
Rada pro dobré životní podmínky zvířat v Indii (AWBI) odvolala svou výzvu "Cow Hug Day" poté, co vyvolala kritiku politických rivalů a uživatelů sociálních médií.
Indický vládní úřad vyzval občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva obejmout krávy byla "absolutně bláznivá, vzdorující logice."
Dodal, že rozhodnutí stáhnout odvolání je spíše "aby se zabránilo tomu, že politika hinduistického [hinduistického nacionalismu] bude zesměšňována tváří v tvář tvrdé kritice ze všech stran."
AWBI v pátek své odvolání zamítla s tím, že "stojí staženo."
Teprve ve středu se v jejím prohlášení stálo, že "objímání krav [by] přineslo emocionální bohatost a zvýšilo individuální i kolektivní štěstí."
Více o Indii
Dodala, že kráva je "páteří indické kultury a venkovského hospodářství... kvůli své výživné povaze jako [a] matka."
Na původní oznámení se objevily smíšené reakce, protože některá zveřejněná videa krav odmítajících objímat a odbíjet se.
Jiní chtěli upřesnit, že apel je spíše pro sledování vlastní kultury, na rozdíl od "slepého" sledování západních hodnot.
Mladí Indové obvykle tráví Valentýn přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Ani mazlení s kravami není nic nového - v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známé jako "koe knuffelen."
Devoutští hinduisté uctívají krávu - známou jako gau mata neboli "mateřská kráva" - a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie přepadli obchody prodávající valentýnské předměty, pálili karty a dárky a vyháněli páry držící ruce z restaurací a parků a trvali na tom, že den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nálety pomáhají znovu upevnit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosadila hinduistickou agendu a usiluje o nadvládu náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinové tvoří většinu zbytku.
Chodec zemřel v nemocnici po havárii s autem v Cowdenbeathu, když byl muž zatčen
Po srážce s autem ve Fife zemřel chodec.
Osmatřicetiletá žena byla v pátek kolem 1.30 hodin převezena do nemocnice Victoria v Kirkcaldy po havárii na Broad Street v Cowdenbeathu.
V souvislosti s havárií byl následně zatčen čtyřiadvacetiletý muž.
Policie žádá, aby se přihlásili svědci nebo kdokoli, kdo má záběry z palubní kamery.
Seržant Lee Walkingshaw řekl: "Naše dotazy probíhají a apelujeme na každého, kdo byl v oblasti a kdo byl svědkem havárie, aby se ozval."
Chtěl bych také apelovat na každého, kdo v oblasti řídil a kdo může mít záběry z palubní kamery, které by mohly napomoci našemu vyšetřování, aby nás kontaktoval.
"Každý, kdo může pomoci, je požádán, aby zavolal Policii Skotska na číslo 101, citující incident číslo 1638 z pátku 10. února 2023."
V ČÍSLACH: Osloské čtvrti, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, se zvýší na více než třetinu.
V Oslu tvořili občané z Asie, včetně Turecka, největší přistěhovaleckou skupinu, podle údajů národní datové agentury Statistics Norway (SSB) jich ve městě žilo přes 62 985.
Poté tvořili druhou největší skupinu občané z EU, EHP a Velké Británie, kteří tvořili nedaleko 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, v Oslu žilo 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, která tvořila 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen nesmělých 7000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo přes 3000 státních příslušníků.
Z Oceánie přitom v Oslu pocházelo necelých 700 lidí.
Alna na severovýchodě města byla čtvrtí s nejvíce zahraničními obyvateli.
V roce 2022 tam bylo registrováno přibližně 18 257 zahraničních rezidentů.
Trendy Grünerløkka, která se nachází přiměřeně centrálně, pak měla druhý nejvyšší počet zahraničních rezidentů, a to 17 631.
Gamle Oslo mělo také významnou přistěhovaleckou populaci, po přestěhování z jiné země tam žilo 17 631 lidí.
Údaje norské statistiky ukázaly, že cizinci byli roztroušeni po všech městských obvodech, protože Søndre Nordstrand, čtvrť nejjižněji v Oslu, tam měla registrováno přes 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl okresem s pátým nejvíce cizinci.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okresů v Oslu s nejvíce obyvateli z jiné země.
Na druhém konci spektra volalo Marka domů pouhých 184 zahraničních obyvatel a jen něco přes 700 jich žilo v centrální čtvrti města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní čtvrti s nejmenším počtem zahraničních obyvatel.
Tyto čtvrti však měly podstatně více přistěhovalců, kteří tam žili, než v centrálním Oslu a Marka.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili v Frogneru, Grünerløkce, Gamle Oslo a St. Hanshaugen.
Mezitím, zatímco ve hře Oslo pobývala také spousta občanů z Asie, včetně Turecka (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovner, Grünerløkka a Søndre Norstrand.
Ty ze Severní Ameriky byly rozloženy poměrně rovnoměrně přes Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji nacházeli v Frogneru, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království měli tendenci žít v nejcentrálnější čtvrti města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek státních příslušníků Oceánie byly Frogner, Grünerløkka a Gamle Oslo čtvrti s nejvyšší populací těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
Florence Tanová
BENGALURU (Reuters) - Zimbabwe začne do března provozovat novou jednotku ve své jediné uhelné elektrárně, říká náměstek ministra energetiky země a poskytuje úlevu milionům občanů otřesených častými výpadky proudu v posledních měsících.
Nový blok elektrárny Hwange zvedne instalovaný výkon afrického státu o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, uvedla Magna Mudyiwa, aniž by uvedla časový plán.
Méně než polovina ze 16 milionů občanů Zimbabwe má přístup k elektřině a globální tlak na financování nové uhelné kapacity omezil schopnost země zapojovat chronické výpadky proudu, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu vyrábět až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době generujeme mnohem méně než to..asi 1000MW," řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700MW, takže máme vážný deficit," řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné elektrárny se v průběhu času prudce snížila, zatímco poptávka po elektřině se v posledních letech prudce zvýšila kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících růstové vyhlídky Zimbabwe.
Nedostatek finančních prostředků na uhelnou energii žene ekonomiku závislou na těžbě a zemědělství k dovozu nákladné energie od regionálních sousedů včetně Zambie a Mosambiku.
(Psaní Sudarshan Varadhan; Editing by Jacqueline Wong)
(PERSON11) Ale pro některé složky, z nějakého důvodu, zvukový formát je špatný, takže, něco je špatně
V podstatě ten velký obchod, nebo něco není v pořádku.
Takže některé soubory jsou stále ještě  mají podivný výstup.
Ale pro většinu složek by to už mělo být v pořádku.
Dobře, díky.
Jo, to je skvělé.
Podporuji to, je skvělé, že [PERSON7], jste přemýšleli o [PERSON11].
A [PERSON11] teď má čas.
Jsou i jiné věci, kde jsem myslel na [PERSON11] a to by byl výcvik, prázdných systémů, aby se zkracovaly.
Takže, pokud jste, [PERSON11], měli čas.
Zřejmě neexistuje způsob, jak bychom to mohli udělat příští týden.
Ale opravdu bychom měli mít systém připravený na
Podíval jsem se na tutoriál z NLP  bylo to?
(PERSON6) Pro nadcházející sezení a ptal jsem se na poptávku, protože jsem viděl (meme) projekt demo.
Dělají offline titulkování.
Takže to je o něco snazší než to, co děláme.
Stále mají stejné segmentační problémy a tak dále.
Jejich poslání v překladu se ale zkracuje už jen proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
V datech tedy dochází k přirozenému zkracování.
Bylo by skvělé, kdybychom mohli také lokalizovat takový typ dat, kde dochází k nějakému přirozenému zkracování.
Dali bychom to do architektury.
(PERSON8) To chce trochu času, protože musím přijít na to, který je ten, který dostává propustky.
Takže, jakmile to vím, můžu to sledovat, takže do budoucna
Nebo vlastně pro budoucnost bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset dělat konverzi.
(PERSON6) No, tohle, tohle by mělo být vlastně
Pořád mě slyšíš?
Kvalita zvuku je o něco horší.
Takže by se to mělo dělat pořád.
Takže pokaždé, když toto hodnocení spustíme, mělo by být spuštěno od nuly.
Takže pokaždé by mělo dojít k čerstvému stažení čerstvé konverze a čerstvého hodnocení.
(PERSON8) Ale přesto, pokud mám sledovat soubory, které je třeba ručně převést, takže mohu napsat skript, a to by se mohlo postarat o ty známé alespoň, a samozřejmě, pokud přidáme nějaké nové soubory, mohu vidět na to později.
(PERSON6) Takže je to důležitá věc, na kterou jsme měli narazit už před několika měsíci.
Pamatujte, od srpna jsem vám říkal, že to chceme vyhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejste to jen vy osobně, [PERSON8].
Očividně byly i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si, že "tohle bude snadné, prostě to spustíme."
A teprve když to skutečně uděláte, vidíte všechny problémy.
Takže, to je známo, běžné.
Vždycky je to tak.
Takže to je vzkaz pro všechny.
Než se o to pokusíte, nikdy nevíte, v čem bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, tak chtěli nahrát video.
Zoom mi nikdy nefungoval tak špatně jako dnes u nahrávky.
Takže než to uděláte, nemůžete říct, zda to bude fungovat, nebo ne.
A zde narážíme na problémy s konverzí formátů souborů.
Takže doufejme, že se nám podaří rychle získat čísla.
Takže, máte zatím nějakou slovní chybovost?
(PERSON8) Ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně hluku.
Takže jsem vás požádal, abyste měli různé verze tohoto slovníku tím, že vezmete jen slova, která byla pozorována, pětkrát.
A to jen ty výslovnosti, které byly pozorovány třikrát a víckrát, nebo něco podobného.
Takže, tímto způsobem, tyto náhodné chyby, jako je příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale stejně, budete mít varianty ve výslovnosti, protože pokud osoba, říká toto "alzo," pokud si pamatujete, pokud říká toto "alzo" s "Z" 20 krát v rozhovoru, pak uvidíte, že v datech s "Z".
A pokud se mu někdy podaří říct také správně, pak jo, zase to uvidíte v datech.
Takže bych chtěl, aby [PERSON4] byl ve spojení s [PERSON2].
Možná budete pokračovat v hovoru, že?
Teď budu muset odejít, protože potřebuju dát dětem oběd a tak dále.
Ale prosím, zůstaňte na této výzvě a společně zjistěte, jak používat tento slovník.
Takže [PERSON4], prosím, ukažte [PERSON2], co je to slovník, který systém přijímá.
Podělte se o obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste do tohoto souboru vypustili.
Jedna věc, která bude ještě potřeba, je náhražka jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže, slovník bude mít tři col ns.
Grafem, jak je výstupem.
Jeden to poznal.
Fonemy, jak navrhoval [PERSON2].
A bude tam více linek s různými phonemovými variacemi.
A třetí col n bude také opět stejný pro všechny z nich, a opět bude stejná grafemová forma.
Takže tehdy vidí jazykový model.
A myslím si, že tímto způsobem by tyto systémy měly být schopny to načíst.
A možná narazíte ještě na jeden problém: že není připraven na dva velké vlastní slovníky.
Takže je to také něco, co musí být testováno, ale prosím, otestujte to, vy dva spolu.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a musíte dát tyto dva poznatky dohromady.
Ah, aby to fungovalo s, s vygenerovaným slovníkem.
Dobře, dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
Jo, jasně, probereme to.
(PERSON6) Jo, takže je ještě něco, [PERSON2], co máte?
(PERSON2) No, možná zajímavé informace pro Dominika.
Dokončuji výcvik německé ASR, která může být použita pro razítkování času.
Nejsem si jistý, jak to bude dobré, protože se to snažím dělat na (Libry) Speech.
A když jsem ji stahoval, tvrdili, že má více než 600 hodin.
Pak ale trénink říkal, že skutečná tréninková souprava obsahuje jen kolem 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale vyřčené různými mluvčími.
Například v angličtině nebo češtině jsem dříve pozoroval strmější konverze.
A teď se to tak rychle nepromění.
Takže, pokud během tréninku odebereme nějaké vzorky.
Pak jsou ještě nějaké vážné chyby ve výstupu ASR.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo to aspoň zkusíme.
Dobře, to je dobře, jo.
Tak jsem začal, ale myslím, že jsem nikdy nedokončil e-mail, protože jste mi připomněl, [PERSON8], že vaše nadávky filtrování ještě není integrován.
A myslím, že je to také důležitá zpráva pro [PERSON5], který opět zmizel z hovoru.
Takže důležité poselství je, že ano, je velmi dobré, že aktivně tlačíte na to, aby vaše výsledky byly integrovány, a každý by to měl udělat.
A zároveň potřebujeme mít nastavení, abyste si ho mohli skutečně integrovat a vyzkoušet sami.
Takže tomu říkám "integrace do-it-yourself."
Takže, [PERSON8], při práci s [PERSON5] a při dokumentování, jaké jsou nastavení, ujistěte se, že je dostatečně dobře testován kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontrolu jazykového modelu a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou součástku, měl by mu být celý plynovod přístupný přiměřeně snadno, aby si ho mohl vyzkoušet sám.
Takže tato integrace kutilů je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že?
Filtrování nadávek, bylo testováno na kládách?
Myslím, že to tak bylo.
Jo, myslím, že to bylo testováno na kládách.
Takže, teď je čas to vyzkoušet na živých potrubích.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] řídil pro sebe některé pracovníky a živě hrál některé problematické soubory, jako je použití [PROJEKT8] nebo cokoliv jiného.
Prostě je zahrajte.
Sledujte zvukový výstup na vašem počítači a podívejte se, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité ji nejprve ladit pomocí souborů protokolu a pak je důležité ji ladit v potrubí.
A pokud toto ladění může provést autor oné složky, zde, v tomto případě [PERSON4], bylo by to nejefektivnější pro nás všechny.
Takže, [PERSON8], potvrďte prosím, že souhlasíte s touto myšlenkou jako integrace do-it-yourself.
Jo, takže pro angličtinu s více akcenty.
Nyní to tedy [PERSON14] skládáme do jediného technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a bude to dělat napříč různými mluvčími.
Takže to budou opravdu vícereproduktorové věty, a proto by se mohla zlepšit i robustnost na různé akcenty těchto reproduktorů.
Aha, takže to je jeden experiment s částicemi.
A později možná uděláme něco víc s tou věcí s více akcenty.
Takže tyto nové věty se vlastně pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět co největší množinu vět.
A vytvoříme nové věty z textového jazykového modelu přidáním zvukové části k tomu, aby jazykový model byl lepší pro ASR a robustnost pro různé reproduktory by byla také lepší.
A při včerejším rozhovoru jsem slyšel další nápad.
Bylo to během tréninku.
Ze zvuku vypouštěli časová pásma a frekvenční pásma.
Trénovali tedy na narušených vstupech, a to také značně zlepšilo robustnost systému.
Kdokoliv jiný může pracovat na věci s nerodným přízvukem.
Ok, pak další věc, kterou jsem si všiml, je - tohle je v pondělním testovacím dokumentu.
Je zvýrazněn čtyřikrát.
Takže když se nějaká relace děje, potřebujeme jména a terminologii pro tuto relaci.
A musíme ji sbírat, připravovat ručně, vytvářet ji poněkud.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Takže v tom je určitá dovednost b, kterou je třeba procvičit.
Takže jsem docela zručný v promíchávání textových souborů.
A kdykoli někoho z vás vidím, jak to dělá, mám v hlavě vždycky tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tam je tato dovednost něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jediný člověk pro to by mohl být [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoci s okamžitou úpravou domény, dat křupání, prosím, řekněte to.
A pak potřebujeme -
Takže jakmile zajistíme slovník pojmů a bez ohledu na výslovnost slova, potřebujeme techniky, jak tyto slovníky použít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal pro všechna sezení, byl, že v hybridním ASR nebyla skutečně viditelná.
Takže jedno takové zasedání se bude opakovat toto pondělí.
[PERSON9] již zahajuje sběr dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJEKT5].
Takže, možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domény a [PERSON14], protože dělá, jak pracovat s [PROJEKT5].
Kdybyste se vy tři mohli setkat a dvakrát zkontrolovat, co [PROJEKT5] dělá s -
Není to [PROJEKT5], vlastně adaptace domény je pro nástrojovou sadu [PERSON18], správně.
Takže je to trochu pozpátku, ujistěte se, že starý přístup funguje.
V současné době je absolutně nemožné provést jakoukoli doménovou adaptaci pro plně nervovou ASR.
Takže to, o čem uvažuji, je mít nezávislé klíčové slovo, které se odvíjí od zvuku, a nějaký postup slučování.
Takže bychom mohli mít dva ASR současně.
End-to-end ASR, což je obecně lepší.
A pak doménově přizpůsobené nastavení [PROJECT5], které slouží pouze k rozpoznání klíčových slov.
A když vidíme klíčové slovo v doméně přizpůsobené verzi, pak bychom pak použili tu větu z [PROJEKT5], která je obecně horší, ale obsahuje správné termíny.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně nervovou ASR a dělat různé experimenty na doladění a tak.
Takže jsme o tom diskutovali s [PERSON14].
A [PERSON14], je nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
Jo, takže jestli je tu ještě někdo, kdo by na to byl zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co by bylo obecně dobře přijato jako papír, protože lidé to ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže bychom tam opravdu mohli něco ovlivnit.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat pro to v současné době používáme, protože například, když se podíváte jako [ORGANIZATION4] modely na [ORGANIZATION5], že jsou jako už docela dobré v těchto věcech -
(PERSON6) A myslím, že když se nám prostě líbí -
Pravděpodobně bychom z nich mohli získat data, protože máte jako tak velkou sadu videí v podstatě s různými doménami a různými mluvčími rodných jazyků na [ORGANIZACE5].
A měl jsem nápad, že bychom mohli použít nějaký nástroj, abychom si stáhli v podstatě nějaké druhy filtrovaných videí z [ORGANIZACE5] a udělali z nich tréninkové testy.
Takže to mám v plánu udělat sám.
Mám v plánu tam jít, ale potřebujeme záložní osobu.
A také, pro akci [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, osoba archivářka, abychom tu relaci znovu neztratili.
A důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A zde v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by rostly.
Myslím si, že by bylo asi nejjednodušší dát tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnoceny po každé nové hodnotící kampani.
Připravit tyto tabulky může být obtížné.
Takže jsem se zeptal [PERSON7] a [PERSON7] bohužel nebude k dispozici během tohoto hovoru.
Prozradit nám, zda [ORGANISATION242], což je webové řešení.
Některé začínající společnosti, které nabízejí účty pro akademické účely zdarma.
Jestli by nám to pomohlo nebo ne.
Dobře, takže [ORGANISATION242] nedoporučuje [PERSON7].
Takže jednoduchý html je pravděpodobně cesta.
Takže, jakmile [PERSON2] má tato hodnocení m vyčistit.
Takže to znamená přesunout pár skriptů tam, kam patří z testovací sady [PROJECT3] a nějakého automatického běžce.
Pak také prosím vytvořte konverzi z tabulek do html podobné technické konverzi a pak tyto výsledky pravidelně umístěte na svou webovou stránku.
Nebo to, co byste dokonce mohli udělat, je mít kompletní git check out přímo umístěn v tomto veřejném html nebo singling z tohoto veřejného html.
Aby byl okamžitě přístupný přes web a každý se mohl podívat na aktuální skóre a prozkoumat to.
To by tedy bylo užitečné, zejména pro m lidi mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají jako -
Výkon byl špatný pro některé soubory, a oni mohli přímo m procházet na webu m.
Mohli by si ji také prohlédnout na [ORGANISATION101].
To je na vás, abyste to nastavili tak, aby to bylo uživatelsky přívětivé a snadno se dalo sledovat.
Dobře, udělám to.
Jo, díky.
Nyní pracuji na předložení demo papíru, které má být předloženo příští pátek, pokud se nemýlím.
A pak mám před sebou nějaké projektové zprávy a začínám sbírat dokumenty - třeba nebo odkazy na dokumenty, zatím ne na samotné dokumenty, pro obě zasedání.
(PERSON11) <parallel_talk> I pro ASR bychom měli přidat bezplatnou metriku -
Vlastně více, měli bychom přidat komplementární met- tyto komplementární metriky. </parallel_talk>
Takže, zmínil jste jeden a to je sprosté filtrování m hodnocení.
Takže <parallel_talk> mají explicitní seznam věcí, které se nesmí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A pak hodnocení vzácných slov.
A zde máme výslovný seznam jmen a pojmů, které chceme objevit ve výstupu, bodované nejen (pořádkovou) rychlostí </parallel_talk>, ale bodované něčím, co tyto věci přímo vysvětluje, že?
Ano, takže naprosto souhlasím.
To zahrnuje i manuální přípravu reference.
Takže, <parallel_talk> oba potřebují ručně vytvořené odkazy. </parallel_talk>
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit. </parallel_talk>
Takže tohle by se mohlo stát prázdnou součástí druhé věci vzácného slova -
Takže <parallel_talk> by to bylo vzácné slovo hodnocení pro MT a pak z [PROJEC210] jsme také pravděpodobně dostat nějaký slovník. </parallel_talk>
Takže to by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat, abyste přepracovali <nesrozumitelné/> domény a vytvořili takový slovník tím, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže, jako užší seznam - seznam slov, která se nám líbí, a nelíbí se nám v <nesrozumitelné/> doméně.
Mohl bys to udělat?
(PERSON11) Mělo by to být proveditelné, tak to zkusíme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Tak si to zapíšu.
Takže, <parallel_talk> mířící k [ORGANISATION62] termínu s titulkem studijního papíru. </parallel_talk>
Ano <parallel_talk> a pak vícezdrojový s [PERSON7] nebo založený na [PERSON7] nebo - </parallel_talk>
A pokud jde o ID jazyka, jsem zvědavý, jak ho chcete přesně integrovat, protože to již zahrnuje zvažování více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude to zvuk do textového pracovníka, a bude emitovat časové razítko jako pro čtyři nebo dva druhé okno a třídu.
<nesrozumitelné/> ticho, česky, německy, anglicky, a pak pustím na ostatní, jak to chtějí použít v potrubí.
To je důležité.
Prosím, zapište toto do dokumentu toto <nesrozumitelné/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], dobře a také možná [PERSON5].
Máme-li tento nástroj, musíme (doručit) zvuk více ASR nebo více pracovníkům <nesrozumitelné/>
Budeme potřebovat (dopravit) zvuk do anglické ASR, samostatně do německé ASR a české ASR, například v závislosti na <other_noise/>
A také, do tohoto jazyka ID pracovníka a pak musíme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je multizdrojový nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a bude vysílat - pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Takže potřebujeme filtr pro ASR, takže ASR je tichý, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem si vymyslel tenhle typ nastavení.
Dalším nastavením by bylo, že stejný zvuk je dodáván do ASR a této jazykové kontroly.
Tato kontrola jazyka je v podstatě součástí ASR, umlčuje ASR, pokud je to špatný jazyk.
To je také možnost.
Takže musíme zjistit, který způsob integrace jazykového ID je nejlepší pro naše účely.
Takže, prosím, nepřestávejte o tom přemýšlet jako o tom, jaké jsou naše plynovody.
V ideálním případě si myslím, že nejméně podobné manažerské zmatky a tak dále by nastaly, kdyby naše modely MT byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná dělat jen kopii, pokud angličtina byla uvedena jako vstup, takže bychom měli vícejazyčné více ASR na začátku.
Vše, co jde do angličtiny, a pak z angličtiny půjde do všech jazyků.
A později, až [PERSON12] bude mít vícejazyčný model ASR, nebude toto jazykové ID ani potřeba.
(PERSON3) Jde o to, že pokud provádíme analýzu správněji, jedna věc je možné kontradiktorní hodnocení, jen abychom naznačili, že omezení mají skutečně dopad na skutečný výstup.
Že by to bylo hezké a jo možná analýza pozornosti.
Ale nejsem si jistý, jestli by nám to mohlo dát stejné odpovědi, v podstatě, pokud se modelka účastní nebo se nevěnuje omezení.
(PERSON4) Musel jsem se podívat jen na pár příkladů pozornosti, nedělal jsem žádné statistiky ani nic jiného, a to se dívá na omezení, a když překládá omezení, vypadá to jako omezení daná, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti nedělá žádné v tomto smyslu.
Dělá to některé obecné chyby v překladu, ale ne ty (fenomeny), které se snažíme vyřešit.
No a když se vrátíme k automatickému vyhodnocování, problém s nesouladem je v tom, že výstup je správně skloňován, ale kontext je jiný.
Není to tedy stejná slovní forma jako v odkazu, že?
(PERSON4) Jo, ale také jsem zkontroloval, jestli jsou kontexty platné překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly označeny jako chybné automatickým hodnocením, bylo 91 z nich správně skloňováno ve správných kontextech.
(PERSON4) A myslím, že jen dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako by překlad byl špatný.
A pak jsou některé případy, kdy překlad byl naprosto špatný, protože věta byla opravdu špatná, a ta část musí být <nesrozumitelná/>, ale to bylo stejně jako jeden nebo dva případy.
(PERSON3) Ale snažíte se přizpůsobit přesměrování formulářů, když to vyhodnocujete, že?
Ty neděláš nic...
(PERSON3) -lemmatizace reference a-
(PERSON4)  Oba, obojí, obojí, Vyrovnávám jak povrchové formy, tak lemma.
Aha, chápu, to jsou ty dva góly, že?
(PERSON4) Je to jen dilema skóre pro (evropské?) není v tabulce kvůli tabulce jako se nevejde do papíru tak <nesrozumitelné/>
Pokrytí je vždy jako 97 procent.
To jen vytváří správné lemy, prostě-
Jo, dobře, chápu to, chápu to.
Takže v podstatě pokrytí lemy říká, zda omezení existuje, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně skloňováno, ale to není ten případ.
(PERSON3) Ach jo, jen nevím, jestli vy, jestli chytíte <nesrozumitelné/>, když jsme mluvili o [PERSON1],
ale jedna věc, je, že, že (rána) je lepší, ale druhá věc je, že lemy jsou ve skutečnosti správně inflected ručně,
ale to je další, ne, žádný problém, je to vlastně dobře, že je <nesrozumitelné/> správně, jo.
Tak jsem si říkal, že by to mohlo být.
Ale nejsem si jistý, jestli na to máme nějaké testovací údaje, ale mohli bychom se pokusit hrát si s modely s nějakým stylem přenosu?
Jak víte, můžeme použít omezení a pokusit se místo toho použít synonymní omezení a zjistit nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to jen neurčitě popisoval, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, zřetelný scénář.
Nevím, [PERSON1], víte o nějakých style transfer datech pro angličtinu česky? Máme něco?
(PERSON4) <nesrozumitelné/>
(PERSON1) Přenesením stylu, Dušane, myslíte, že by bylo něco, co je v psaném jazyce, a vy byste byl cílovou stranou, bylo by to v mluveném jazyce nebo něco takového?
(PERSON3) No, to je věc jako, mám jen omezené znalosti o úkolu.
Ale umím si představit, že chcete přepsat větu, že ji nepíše muž, ale místo ní píše žena nebo, nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
S přesnými datovými soubory a tím, co pokrývají, nejsem až tak obeznámen.
A myšlenka je taková, že styl vět se poměrně neurčitě definuje.
Takže opět, nejsem si tak jistý.
(PERSON1) Máme tento korpus transformací vět.
A jedna věc, která tam je a mohla by být označena jako převod stylu, je například to, že věty jsou obecnější.
Takže detaily jsou vynechány, věta je zjednodušena a pak věta zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení dělá Matous nějaký experiment s angličtinou, ale nemáme tam žádná referenční data.
Takže nemáme žádný soubor dat pro kompresi vět.
Takže možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediný odkaz by byl příliš omezený na to, aby vám řekl něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových transformací, například by se to dalo udělat <nesrozumitelně/> pro češtinu, takže možná by byl ten správný člověk Rudolf Rosa, který by se ho zeptal, jestli vůbec nějaký takový soubor dat vytvořil.
Takže vznikne kořenová generace nějakého větného protějšku.
(PERSON3) Myslím, že to je vlastně jako zajímavá otázka, zda můžeme využít omezení k tomu, abychom v překladu prosadili tento druh obdobného pohlaví řečníka.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní podčást testovací sady [PROJECT1], která by to pokryla.
Aha, takže někdy známe pohlaví řečníka, takže pokud ano... možná se podělím o obrazovku a prohlédnu si ji.
Nebo jsem to zkusila s Marian, která se toho zúčastnila a je to... Nevím, o kolik BLEU bodů níže.
(PERSON2) Protože stejně jako já věřím, že Martin dělá svůj <nesrozumitelný/> malý překlad, takže překládá více vět najednou a pak si vybere jen tu středovou a jde takhle na celý dokument.
Takže kontext je jako v jednom <nesrozumitelném/> spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nebyl to Dominik, kdo dělal nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva roky pro dvojité prázdné, kde se zabývali kontextem nebo spojovali kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale věc je s tím, že se spojením není zcela jisté, zda má stejný účinek jako my, nastavení multikodéru-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje úplně.
(PERSON8) Jo, dobře, tak promiň, možná bych měl mít větší pravdu, že to nefungovalo tak, jak jsem to udělal <smích/>
(PERSON1) Jo, protože si myslím, že je to metoda, která se velmi snadno testuje, a vždy by měla být testována v kontrastu se dvěma kodéry, a očekával bych, že někdy bude lepší a někdy horší než dva kodéry nastavené, v závislosti na přesném úkolu, jako je to, co přesně je druhá věc, kterou kódujete.
Takže, možná, když máte dvě kopie dvou parafrází stejné věty,
Možná je to nějak matoucí pro pozornost, takže cokoliv, nevím.
Chování by také mohlo být jiné u starých metod sekvence-sekvence, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak možná s transformátorem je to jo, je těžší trénovat, takže možná potřebujete cokoliv, co zvýší počet zahřívacích souprav, zahřívacích souprav.
Jo, takže prostě víš, že...
(PERSON8) Nepamatuji si to, takže si to přesně nepamatuji, ale tohle je jako...
když jsem v létě začal s těmi multizdrojovými experimenty.
První věc, se kterou jsem začal, bylo spojování parafráze a zdroje a možná, že si teď nepamatuji,
Můžu to zkontrolovat až do další schůzky, jestli jsem to taky zkusil,
Rozhodně jsem to zkusil, když jsou zdroje na první pozici pak nějaký oddělovač a parafráze na druhé pozici.
Možná jsem také zkusil, že jsem ty dvě věci náhodně zamíchal, jo, a jen si pamatuji, že to dělalo hojně tyhle pronikavé věci a zkoušelo multiekodéry.
(PERSON8) A pravděpodobně to bylo způsobeno nízkým skóre.
(PERSON2) <nesrozumitelné/>, které se vám líbí, můžete zlepšit své amenity skóre pouhým přidáním frázového výstupu a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže, pokud zadáte výstup založený na frázích, který je v podstatě post editing, že? Můžete o tom přemýšlet jako o posteditingu, jako byste zveřejnili výstup založený na frázích, že? Nebo jako záleží na úhlu pohledu, že?
(PERSON1) <nesrozumitelné/> že ho rádi přepíšete, ale technicky přesně odpovídá úkolu postediting, můžete ho připojit jako řešení úkolu postediting.
(PERSON10) Dobře, takže jedna otázka jen pro mě jen proto, abych se ujistil, že v nastavení spojení vložíte token oddělovače vět, že?
Máte speciální token, který rozlišujete, jako který je zdroj a který je kontext nebo druhá věta, nebo je prostě bez ničeho spojujete?
A doufat, že se to systém naučí?
(PERSON8) Zkoušel jsem to, hádám dva tokeny a jo jako protože v první verzi jsme měli podezření, že token může být také tokenizován sám, takže jsem to pak přehrál s dalším tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník, a tento slovník neobsahoval oddělovací tokeny.
Takže jsem použil nějaký token, který jsem předpokládal, že to nebude jako tokenizovaný na několik kousků, a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže by se to dalo udělat víc správně, jo, souhlasím.
(PERSON2) Ale část Flask nebo komunikace s klientem je něco, co nemohu udělat.
Protože nemám žádné zkušenosti a nemám čas to rozjet.
Myslel jsem, že to znamená něco, co používám Neznám mediátora.
(PERSON2) Ne, vytvořte HTTP klienta, který může vyplnit frontu a číst z jiné fronty.
A text odeslat zpět v HTTP požadavku.
Protože moje představa je, že uživatelská kliknutí budou použita i v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk v malých kusech zároveň.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dát do fronty, kterou budu řešit frontu později s (ASR).
A model udělá nějakou logiku, nějaký závěr s tím.
A kdykoli má nový přepis, pošle ho zpět a uživatel by měl získat částečný přepis zpět.
A měl by být okamžitě zobrazen v textovém poli.
Mohl bych o tom přemýšlet.
Jen Flask taky moc neznám, ale jo, na to můžu myslet.
(PERSON2) Možná jiný HTTP server.
Nevím, možná na to ani nepotřebujeme nóbl HTTP server.
(PERSON1) Chci říct, že pro textový tok používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo pro tohle.
(PERSON2) Jo, jediný požadavek je, že by to mělo zvládnout více připojení najednou.
(PERSON1) No myslím, že on-line textový tok je něco kolem 2 000 alespoň.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými vnitřními pracovníky, takže myslím, jo, takže mám <nesrozumitelný/> řekněme deset, no místo výstupu, soubor od <nesrozumitelného/> vedlejšího pracovníka, takže <nesrozumitelné/> které máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
To by nám ušetřilo čas.
(PERSON7) Jo, jo, to je velmi důležité pro paralelizaci všeho ve skutečnosti, paralelizaci jak zpracování systémů, tak vyhodnocení buněčného DF, protože on by potřeboval běžet tolikrát, budou chyby, je třeba to rychle znovu spustit.
Dobře, takže díky.
Takže, jste s tím velmi zaneprázdněni, nechci na vás dávat žádné jiné věci, tak mi dovolte začít s připomínkami.
Musíme dokončit popis [PROJECT1] stolní soupravy,
Koho tu máme?
No, vlastně ne, jo, (je to hotové) a tady to bohužel není.
Takže, tohle by bylo pro [PERSON2],
Pak hodnocení, toto je pro [PERSON1], ale diskutovali jsme o tom.
Poslyšte, dejte mi tabulku v DSD, pojďme sem dát tenkou čáru a protlačit šablonu tabulky, jako je plánová struktura do delebl teď, takže čísla přijdou později, ale chci vidět nějaká čísla a plnou strukturu tabulky velmi brzy.
Dobře, díky.
Máme [PERSON5], to je dobře.
Takže pro [PERSON5] bych rád zkontroloval, jaký je pokrok v hodnocení systémů a zda jste ve spojení s [PERSON1] také pro vývoj, který je důležitější.
Slyšíš nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
Jo, takže je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory, a pak spustíte vyhodnocení.
A důvodem tohoto rozkolu je to, že můžete více paralyzovat.
Takže určitě budou problémy na různých frontách a čísla budeme potřebovat velmi brzy.
Takže, pokud například některé testovací soubory z nějakého důvodu selžou,
Pak ještě můžete udržet překlad v chodu pro zbývající,
a přehodnotit, sel T F, ty chybějící, a tak dále.
Takže, jde o to, aby se nevytvářelo sériové, sekvenční zpracování, které zahrnuje obojí,
ale jde o to, abychom dosáhli výsledků, a ve skutečnosti je lepší to dělat v plátcích.
Nejdřív seženeme všechny výstupy, pak seženeme všechna hodnocení.
Jo, takže, myslím, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Třeba odfiltrování trámů a nahrazení trámů různými trámy.
A pro takové multi-tokenové omezení a podobné věci.
Ale kvůli pozitivním omezením jsem jen porovnal tréninkový přístup s jo jen s těmito velmi jednoduchými věcmi.
Stačí stejným způsobem upravovat skóre v každém kroku.
Dobře, takže zpět k pozitivním omezením.
Už jste se soustředil na analýzu systému?
(PERSON2) Jo, právě teď trochu čekám na přepracování datového souboru z ([PERSON9]).
Také [PERSON9] Podíval jsem se na (kód) a myslím, že vím, proč je tak pomalý.
Protože pro každou položku v terminologii při (Europar) přepracování otevřete datový soubor, tokenizujete ho, čtete řádek po řádku, tokenizujete řádek po řádku a pak ho uzavřete.
Ale to děláš jen ty -
(PERSON4) Takže si pamatuji, že pro [PROJEKT1] jsem to dělal z minulého roku z nějaké chalupy v horách.
A právě jsem si krátce před Silvestrem uvědomil, že to musím předložit.
A <smích/> takže tohle je také něco, co se stane [PERSON8] Obávám se, že by mohl být... no, žádná párty, ale možná na vzdálené párty.
A pak by si najednou uvědomil, že to musí předložit.
Takže v té chvíli nebude žádná recenze jako. <smích/>
Prostě by vzal PDF a tak ho nahrál. <smích/>
Dobře, dobře.
Takže, Jo, zkontroluju 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že je lepší jim poslat e-mail právě teď a jen požádat o tento odkaz předem.
Dobře, dobře.
Jo, díky.
(PERSON7) Máme dnes k projednání další otázky, nebo je to tak všechno až do Nového roku?
Doufám, že pro mě nic nebylo?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo nástrojové dokumenty, které byly publikovány jako speciální vydání PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normální jako tam byly také PBML otázky, které smíšené prázdné margin papíry a samostatné papíry kvůli počtu těchto dokumentů.
A dokonce jsme měli něco jako kdyby papír nebyl dost dobrý pro PBML, ale kdyby byl nástroj představen na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, jak už jsem řekl, váš systém, váš nástroj je zajímavý.
Zveřejněte ji prosím na MT maratonu mezi lidmi.
Ale vaše noviny jsou moc špatné.
Musíte ji zlepšit a dostanete se pouze k další PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že při pokusu o SIGDial přilákáme lepší účastníky.
(PERSON3) To ano, to je... jak jsem si myslel, že jsem také měl, ale neznám ani jedno z míst.
Poslední papírovou registraci mají v červenci.
Takže konference byla v září a papírové podání bylo v květnu.
Protože pro Interspeech bychom to mohli také rádi rozdělit papír po papíru.
Aby některé listiny šly do mezipromluvního řízení.
A některé z našich předkládacích dokumentů přijdou později k řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď s SIGDial nebo Interspeech.
Pokud je v pořádku, že mají nějaké naše papíry, vzhledem k tomu, že tyto papíry jsou předloženy do březnového termínu.
Takže existuje absolutní přísný požadavek.
A myslím, že proti tomu nemohou mít nic.
Protože jestli ten papír stojí za publikování.
Jako, je to jen bonus, že papír má nějaký společný výsledek úkolu, který se objevuje v satelitní akci.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o zvláštní zasedání.
V Mezimluvě se tomu říká zvláštní zasedání, to nechceme.
V Interspeech chceme satelitní akci.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj dokument hotový do termínu Interspeech, pošlete ho jako Interspeech papír a budete ho mít v rámci Interspeech.
Ah, pokud to neuděláte, ah, udělejte to pro termín Interspeech, tady je náš termín.
A to je pro PBML.
Jo, dobře.
Ale ta věc je jako u družicové akce Interspeech.
Ehm, Interspeech jako by se nedostal do žádného řízení.
(PERSON2) Můžete si myslím, že si můžete jen rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím, že je to něco jiného, protože si myslím, že to není věc, která by jeho kurzy zklamala.
Rád selhávám, protože to nedokážeš dokončit.
Samozřejmě, jako by se lidé jen vzdávali, ale myslím tím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
Jo, myslím, že nám na začátku semestru řekl, že když budeme chtít jednu (??), dostanete jednu.
Právě ve druhém termínu byste ji měli předložit.
To je skoro jediná věc, na kterou se ptal.
Zároveň nám ale řekl, že soudě podle trendů z předchozích let to spousta lidí nedělá.
Na zkoušku se jim to snadněji čte.
Ne, promiň, studuj na zkoušku.
(PERSON2) Jo, protože obecně, jeho zkoušky jsou poměrně snadné.
(PERSON2) Takže bych neřekl, že je to super snadné, protože jsou kurzy, kde je zkouška jako zábava.
No, jedna z nich byla včera pro mě.
(PERSON2) Jo, když má krátký kontext a protože se rozhodujem na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se opravdu zavazuje k něčemu, co například za vteřinu nebo dvě, přijde na to, no, vlastně to byl špatný překlad.
Takže se snaží použít jiné znění.
Abych například věc specifikoval.
Takže vlastně se mi to moc líbilo.
Některé překlady se mi líbí. Opravdu mě to udivilo, i když bylo vidět, že model na první pokus chyboval, opravdu chtěl udělat nějakou korekci.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i o něco nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita, protože překlad, pokud čtete všechno, že dostanete stejné informace, ale formulace je prostě špatná, protože používala například více slov a používala některé opravy a tak.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A u kterých jazykových párů máte tyto výsledky, třeba u některých příkladů?
Protože bych se na to rád podíval, jen tak ze zvědavosti.
Určitě, můžu ti dát svoje klády.
(PERSON7) Ale ve kterých jazycích?
Protože víš, že neumím německy.
(PERSON2) angličtina a němčina.
(PERSON7) Jo, ale nemusím nutně mluvit německy <smích/>.
(PERSON2) Pak mohu poskytnout anglickyčínsky a anglickyjaponsky, pokud to pomůže <smích/>.
(PERSON2) Takže zase chci, aby to bylo lidsky čitelné.
Protože tohle blikání je opravdu otravné a pak se člověk přestane soustředit na to, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Promiň, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoliv vidím nějaké slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš pytel.
Tak jsem dal slovo do pytle.
A ráda propojuji věci v tašce, abych získala celkový obraz slova.
A myslím, že to je ten problém s blikáním.
Když něco přeložíte a pak to změníte, tak vlastně už to čtu, mám to v mozku.
A pak ztrácím soustředění a kontrolu nad tím, co bylo vlastně tehdy přeloženo jako správné a nebylo to, co nebylo.
Proto si myslím, že celá ta věc s blikáním je z podstaty špatná a hloupá.
Jako když vidím motivaci, jako když chceš ukázat všechno, co máš.
I když nemůžeš slíbit, že je to dobré.
Ale myslím si, že s těmito informacemi navíc nemůžeme pracovat.
A myslím si, že možná problém je v tom, že systémy vytvářejí lidé, kteří s tím pracují.
Pokud jsem vývojář systému, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále ho ukazuji a je to nějak dobré, ale myslím si, že vývojář se ve skutečnosti nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíše že, ach jo, můj systém to dokáže vydat opravdu rychle.
A i když se jen odhaduje, že kvalita je v pořádku, myslím, že možná proto byl retranslace vytvořen.
Jen vývojáři systémů jsou dychtiví zobrazovat informace, a já si myslím, že protože jsme omezeni v jako vol e informací, které můžeme vnímat nějaký čas, rádi vidíme, že informace navíc je pro nás jen další zátěží.
Takže si myslím, že není dobré ukazovat něco navíc.
Třeba když chcete snížit latenci, tak místo blikání stačí snížit kvalitu.
Myslím, že to je pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč bys měl vidět tu nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Stejně jako technicky, když začnou překládat lidští překladatelé, myslím tím cíl, který i tam je pro anotátory, snažili by se řídit řečovým řetězcem původního řečníka.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatně, takže by se prostě opravili.
(PERSON2) No, ale jo, to znamená s mým řešením, jako byste se nefliknul, ale zavázal jste se, jako že neexistuje způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Mám silný pocit, že naše práce není zrovna v oblasti řeči, je nezdravá.
Protože zde neexistuje pojem řeči.
Na textu přímo pracujeme.
Věc se ale má tak, že návrh na letošní statistickou dílnu skončil, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo pozdě.
Je lepší, když se dostaneme k jednomu ze dvou sektilních nebo mezipromluv, protože oba jsou v komunitě dobře uznáváni.
Můžeme motivovat účastníky, aby se přihlásili.
Ach, jediná výhrada, kterou teď zjišťuji, je, že nám nedovolí prostor v řízení, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšeni, že zveřejní článek v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, že?
Takže to není přínos pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
To byl tedy důvod, proč jsem se zvlášť zaručil za zvláštní zasedání.
Ale tentokrát je problém, co mohu pochopit, je, že naposledy, časové období mezi návrhy, podáním a předložením závěrečného dokumentu bylo pět měsíců, takže by byl dost času na náš program, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vnímám jako důležitý možný zdroj nerodné anglické řeči, který můžeme použít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na nejjasnější hlasovou soutěž a stánek zvládneme, když budeme muset.
To bych ale rád omezil, protože šíření do středoškoláků má pro nás menší dopad.
Důležitější je použít ji jako testovací sezení.
Takže bychom se měli zaměřit, [PERSON1], na [PROJEKT2] nejjasnější hlas a udržet organizátory šťastné, abychom tam mohli provádět sběr dat.
A udělat cokoliv, co chtějí, abychom udělali výměnou za to, a my musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tento plenární program užitečný.
takže by to pro nás bylo zkušební sezení, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud se nás ptají, jestli se od nás opravdu očekává, že tam budeme a přítomni, tak dobře, ale pokud ne, tak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
Jo, ještě jsem se o registraci nepokusil, ale myslím, že minule bylo povinné mít stánek.
Ano, jsem. Takže, diskutujte s nimi o tom, co je potřeba, aby byli šťastní, a oni nám umožňují udělat nejjasnější hlas, což je nejdůležitější.
Zkušební sezení je méně nutkání.
A budka je jen něco, čemu bychom se opravdu mohli vyhnout, pokud možno.
Byl bych raději, kdyby se k sezení připojili dříve, než aby dělali takové věci.
Takže tyto přípravy opravdu musíme procvičit.
S online světem se zdá, že se jednoduše j p do relace, a práce je hotová.
Tak tomu ale není.
Vždy trvá 30 minut, než se rozběhne a správně se připojí.
Takže tam musíme být dřív.
A pokud nějaké sezení, které děláme, začne v devět, ale organizátoři se sejdou ve čtvrt na devět.
Pak už musíme přijít ve čtvrt na osm, abychom měli těch 30 minut navíc, abychom se ujistili, že všechno běží a honí lidi.
Takže tohle je poznámka pro všechny, že aby vedení fungovalo, předvídejte také, co by vás vedení mohlo najednou požádat, a to by trochu pomohlo.
Dalším poselstvím, které je velmi důležité, je nahrávání těchto důležitých sezení.
Nevím, jestli jste odpověděl, neviděl jsem nikoho, kdo by poskytl nějaké aktualizace dokumentu.
Možná jsem vám to zapomněla říct.
Měl jsem dokument o zkušenostech z [PROJECT4]a [PROJECT5] 2020.
A první bod této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto sezení.
Takže je důležité pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, mít dobré záznamy z těchto sezení.
A jedním aspektem je získat souhlasy, aby bylo skutečně umožněno nahrávání.
A to i v případě, že se pokusíme získat souhlasy zpětně nebo tak.
Pak je tu technická stránka nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
Jo, [PERSON5] ten odkaz posílá.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citrony v řadě:(
Objednal jsem si ji u této firmy, protože jsem ji koupil v předchozích sezonách a skvěle nám fungovala.
V této sezóně jsem si koupila další velikost, kterou jsem potřebovala.
Jedno z pyžam, které jsem dostal, mělo díru na noze pyžama.
Vrátil jsem ji a firma mi poslala novou.
Náhradní pyžamo, které nosil můj syn, jsem si dala do pračky jako vždy a zip se ulomil!
Jsem tak zklamaná, protože nemám čas řešit návraty každých pár dní, a přesto se to právě teď děje.
Přesně tak, jak je popsáno
Tohle je základní nafukovací kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuově zapečetěném sáčku, takže je třeba ho na několik dní zavěsit, aby se vrásky dostaly ven a trochu se "vyfoukly."
Jsem 5 ft 6 palců a kabát je na mně po kolena.
Objednala jsem si 2+ velikosti vzhledem k jiným komentářům a zkušenostem z minulosti a kabát je asi o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale nejsou na ní žádné vazby.
Přední zip funguje.
V boku ani vzadu nejsou žádné průduchy pro další pohyb, ale s větší velikostí bych měl mít dost místa.
V pase mám dvě kapsy (mohou být vyšší nebo nižší).
Neexistují žádné ozdoby ani stylingové detaily - je to BASIC COAT.
Za cenu si myslím, že je to v pořádku.
Nosil jsem ji za větrného dne, ale ne za studena.
Nemohl jsem cítit vítr, takže cítím, že je to dobré znamení.
Jsem však zvědavý, jak si povede v chladnějších teplotách a v dešti/sněhu (údajně odolném).
Celkově mě to těší.
Vakuový těsnicí sáček lze znovu použít a prodejce přidal opravdu roztomilý děkovný dopis, který byl skvělým dotekem.
Tohle je moc pěkná sukně.
Krajkový vzor je elegantní a měkký
Tohle je moc pěkná sukně.
Krajkový vzor je elegantní a měkký.
Nezvrásní se, i po namačkání do plastu a krabice byla velmi hladká, takže to je opravdu super.
To se dá snadno obléct nebo obléct a díky délce a střihu má jakýsi vintage pocit, do kterého jsem opravdu zamilovaná.
Myslím, že by to mohlo být lichotivé pro každého.
Jsem 5'5" a 130 liber a objednal jsem si malé, takže bych řekl, že pokud máte pocit, že se zaseknete mezi malým a středním, rozhodně o velikost nižším.
Nefungoval s mým Buick LeSabre z roku 1999
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce i baterie předinstalovaná.
I když však měl být kompatibilní s mým Buickem LeSabre z roku 1999, dálkový ovladač nedokázal programovat ani synchronizovat s vozem.
Pokyny jsou dost snadné a vím, že jsem je správně dodržoval, protože jsem byl schopen úspěšně přeprogramovat svůj starý vzdálený fob.
Tato nová by však nefungovala, a tak ji budu vracet.
S prodejcem ani servisem nebyl žádný problém, jen se zdálo, že právě tato položka je vadná nebo neslučitelná s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta mi utrhlo velké něco, co letělo po dálnici, takže jsem potřeboval náhradu.
Po přečtení některých recenzí jsem se bála, že se to nehodí, ale bylo to perfektní!
Vlastním Corolla LE z roku 2013.
Nedával jsem si to na sebe - nechal jsem si to udělat chlápka v obchodě s mrtvolami - ale vypadalo to opravdu snadno.
Prostě to prasklo za méně než 5 minut.
Dal jsem mu 4 hvězdičky za pevnost, protože to vypadá dost chatrně (čas a létající trosky poznají), ale přes to všechno jsem velmi spokojen, že moje auto už nemá zející chřtán na přední straně a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Můj 5letý absolutně miloval toto světlo To nevydrželo dlouho, dostal ho k narozeninám v lednu, to už má únor potíže s tlačítky a neběží jasně se zásuvkou, požírá baterie i zkoušel dobíjení baterií Super cool, ale potřebuje zlepšení
Hudební start
Klavír je skvělý startér!
To najde vaše dítě vnitřní umělecké schopnosti a hudební talent.
Vyvíjí dobrou koordinaci ruky a očí.
Klavír není jen hračka, ale ve skutečnosti funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě bylo budoucím pianistou, měli byste vyzkoušet tento produkt!
Za ty peníze to stojí!
Dávám si to na nos podle pokynů dvakrát denně a třem si ho 2 minuty.
Kůže na nose se zarudla a úplně zeslábla.
Dost mě to zaskočilo.
Měl jsem dobře zahojenou jizvu po pádu do ostnatého drátu z doby před lety.
Nejenže tento přípravek nefungoval, ale málem jsem skončil u dermatologa, ale asi po týdnu jsem ho konečně uklidnil tím, že jsem dal aqua-for a náplast na okolí.
Nos mám však stále zarudlý, ale doufám, že to brzy zmizí.
Podělal někdo vzorec?
To je tak divný.
Při normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslila jsem růžovou čáru pomocí malířské tyčinky od jiné značky, abyste viděli, jak by růžová měla vypadat, a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červenými nebo růžovými.
Bílá není tak jasná, jak bych doufal.
Ostatní barvy jsou skvělé a líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem si myslel, že je růžová.
Asi bude stačit ta fialová.
většinou funguje
Vybělil jsem si celou hlavu a pak jsem ji před několika měsíci obarvil černým krabicovým barvivem.
Pak jsem šel a nechal si po hlavě vložit zvýraznění.
O pár týdnů později jsem si na vlasy nasadila modrozelenou barvu na vlasy Arctic Fox a ta nevybledla.
Použila jsem tuto látku s Olaplexem č. 3 a ta se po celém těle TREMENDOUSLY odlehčila, odstranila zelené a modré části a také zvedla tmavé krabicové barvivo.
Po dni jsem si však všiml zeleného odstínu vlasů.
Každý den se to zhoršuje a já jsem teď použil extraktor barev dvakrát, se stejnými výsledky.
Moje vlasy jsou také tmavší tam, kde bylo barvivo na krabice.
Je to skvělý produkt, který prostě nevydrží.
Nevěř tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba mírnit některými realističtějšími hodnoceními.
Zkoušel jsem to číst, ale našel jsem jazyk plochý.
metafora "sladkovodní" a mnoho popisů dělohy jako řeky a dítěte jako ryby se zdálo nucené, nabourané a vymyšlené.
Přeskočil jsem to a vypadalo to, že jediné, co najdu, je univerzitní drama.
Dávám této knize 10 hvězdiček!
Výborné čtení!!
Naprosto se mi ta kniha líbila!!
V průběhu let jsem adoptovala 4 siamské kočky ze Siri a každá z nich byla absolutní láskou.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri šla nad a za její úsilí o záchranu koček (hlavně siamských)!!
Opravdu se mi líbí toto prstencové světlo!
Je to skvělé za cenu a dostane práci!
Jediný problém je, že žárovka se zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji zase zapnout.
Nemyslím si, že by se to mělo stát...Nevím, jestli mám vadné světlo nebo co, ale kromě přehřátí je to velmi pěkné kruhové světlo.
Zmatená vypravěčská linie
S knihou bylo těžké držet krok, protože hodně poskakovala.
Také název neodpovídá příběhu.
Autor naznačil, že několik lidí bylo infikováno tímto mimozemšťanem, nicméně vynechal možná podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a hodně si číst, abych se ujistil, že mi nic nechybí.
Milovaný Collins...
Chvíli trvalo, než se Grady rozehřál
3 1/2 Hvězdy Remedy je bratrská nejlepší kamarádka romance i druhá náhodná romance smíchaná do jedné.
Je to jedinečný příběh a hrdina (Grady) musí udělat všechno pro to, aby Collinse dostal zpátky a dokázal, že je pro ni tím pravým.
Před třemi lety měli Grady a Collins úžasnou společnou noc.
Collinsová si myslela, že konečně dostane všechno, o čem snila, svého nejlepšího přítele bratrů... ale když se druhý den ráno probudila sama a nikdy o ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpátky a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel a že se jí tentokrát nevzdává.
I když se mi líbila premisa tohoto příběhu a občas i Gradyho, opravdu mi lezl na nervy.
Naprosto chápu jeho úvahy o tom, že tu noc odešel, ale že ani neposlal dopis Collinsovi, v němž by se vysvětloval?
Nechávat ji celé ty roky přemýšlet a bolet a pak čekat, že ho přivítá zpátky s otevřenou náručí?
Byl to klam?!
Collins měl pravdu, když byl rozrušený, rozzlobený, zraněný atd.
Měla pravdu, když se s ním pohádala, když ji chtěl zpátky, a pohnula se kupředu.
Obdivuji její vůli, protože Grady byl vytrvalý.
Collinsovou jsem v této knize miloval, byla silná a střežila si srdce a já ji za to obdivoval.
Jistě milovala Gradyho, ale bála se a váhala ho pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně nechala věci plynout v tempu, které chtěla, a když byla připravena naslouchat, poslouchala.
V této knize je spousta úzkosti a bavilo mě sledovat, jak se tihle dva znovu spojují, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevycházel jako tak kňouravý a byl by trochu chápavější.
Pořád říkal, že to chápe, ale občas byl na mě trochu moc stydlivý a pak byl ke konci sladký.
Nakonec jsem ho miloval stejně jako Collinse, ale na začátku knihy jsem měl potíže s čtením jeho úhlů pohledu, protože jsem se nemohl spojit s jeho postavou.
První část této knihy, nebyl můj oblíbený, ale on druhý díl?
Zbožňoval jsem, proto i mé hodnocení.
Pokud máte rádi druhou šanci a bratry nejlepší přátele romancí, možná se vám tato kniha opravdu bude líbit, jen jsem to měl zpočátku s Gradym těžké a jak zvládl některé věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho portrétu Churchilla
Pan Oldman hrál a vytvořil mnoho, různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho portrét Churchilla, byl velmi dobře proveden.
Stlačený časový rámec od 10. května do 26. května byl dobře prezentován s hodinami 7 otočných stran...
Krajina i kostýmy byly vynikající.
Je dojemný s dnešní dvojicí polobohů, kteří zastávají světové politické postavení.
Stojí za pohled několikrát... stojí za promyšlené přemítání... ještě mnohokrát
Vyhněte se Wifi připojení- jít Bluetooth!
Tohle jsem koupil pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydlení v hotelu.
Nemohl jsem se dostat k této stupnici, abych se připojil k Wifi v hotelu.
Rozhodl jsem se, že počkám, až se nastěhujeme do našeho domu a budu si moci nastavit vlastní Wifi systém.
Březen 2018- Nastavil jsem svůj systém Wifi a tato stupnice se stále nepřipojí.
Pokaždé, když se o to pokusím, dostanu chybovou zprávu.
Dokonce i když jsem 10' pryč od Wifi jednotky.
Sledoval jsem instalační video na YouTube bez úspěchu.
Když jsem přístroj zakoupil, myslel jsem si, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato stupnice používá směrovač Wifi ke komunikaci s telefonem.
Tento systém je omezen na připojení routeru...který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Tuto stupnici bych nikomu nedoporučoval kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to stupnicí připojení Bluetooth.
Dobře, ale rád bych našel něco lepšího
Po mnoha výzkumech jsem začal používat tento produkt před mnoha lety.
Mělo to nejmenší množství škodlivých složek a stále fungovalo dobře.
Vyschne však tak rychle, že nakonec použijete tolik maziva, což nakonec stojí spoustu peněz a také je při sexu příliš rušivé.
Jen jsem byl příliš líný hledat nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a není příliš nákladný.
Životnost baterie je hrozná na té, kterou jsem koupil na Amazonu.
Stále nemohu uvěřit, že Logitech tento ovladač ukončil, nic jiného se ve srovnání s tím nepřiblíží.
Naprosto miluji tento dálkový ovladač Harmony, toto je můj čtvrtý.
Pes sežvýkal první, manžel poklekl na obrazovku druhé a třetí stále fungují, ale uprostřed dotykové obrazovky je značka lokte, také díky hubeňourovi... koupil si tuhle jako zálohu a obrazovky skvělé, ale baterie, se kterou přišel, drží nabití možná na pár dní.
Můj originál (3.) udržuje nabíjení po celé týdny a já používám svůj ovladač na všechno.
Zlomila se za necelý týden
Líbí se mi produkt, který má pěknou velikost a barvu!
Bohužel měl jen týden a otevřel jedny dveře a praskl vršek dřevěného kusu!
Jsem opravdu zklamaný!
Všechno je smontované a já už tu krabici nemám, tak jak bych vůbec mohl přemýšlet o tom, že ji pošlu zpátky?!
Můj manžel se to pokusil opravit dřevěným lepidlem, ale bohužel to také nefungovalo!
Dveře zase vyskočily ven!!
Není příliš snadné sestavit plus....
Při montáži je to pěkný kus nábytku, ale montáž byla obtížná.
Některé znaky byly nesprávně označeny, takže jsem se musel pokusit přijít na to sám Šrouby, které dodávali k připevnění podlahy a bočních panelů, všechny praskly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také dveře ze skleněných panelů jsou mimo provoz a neodpovídají rovnoměrně.
Toto zarovnání zabraňuje tomu, aby některé dveře zůstaly zavřené, protože magnet na zavírání dveří je mimo provoz.
Ještě jsem nepřišel na to, abych je srovnal.
BAD CODE PRINTED ON THE TOP OF THE POD
Ty jsem koupil v únoru.
Nedávno jsem se je snažil použít a bohužel pokaždé, když zkouším jeden můj Keurig stroj mi dává chybovou zprávu, že modul není kompatibilní s mým strojem.
Používám kapsle Donut Shop ve svém stroji od doby, kdy jsem si je poprvé koupil a nikdy jsem neměl problém.
Při bližším zkoumání kávového lusku jsem si všiml, že kód vytištěný na horní straně lusku není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Zakoupil jsem krabici 72, což je 6 krabic po 12 kusech.
Dokonce jsem vyzkoušel jeden z každého z 6 boxů a stále dostává stejnou chybovou zprávu.
Vím, že to není můj stroj, protože ostatní lusky se snažím pracovat v pohodě.
Teprve z této zásilky mám tento problém.
Velké zklamání, protože mé návratové okno vypršelo.
UPDATE: Mluvil jsem se zástupcem zákazníka, který refundoval peníze.
Děkujeme společnosti AMAZON za skvělou zákaznickou podporu!
Sladidlo na cestách.
Taková pohodlnost!
Je opravdu příjemné mít mou oblíbenou alternativu cukru zabalenou v malých baleních!
Miluju odbočování a je tak pohodlné mít je v kabelce na večeři nebo je používat u přítele.
I když jsou trochu drahé, nemohu vystát Equal ani růžové věci v mém ledovém čaji.
Uhněte nebo nic, takže jsem nadšená, že mám své sladidlo na odchodu!
Ve skutečnosti nedělá žádné "čištění" vzduchu
Koupil jsem to jako zvlhčovač vzduchu, ta část "čištění vzduchu" je vlastně falešná reklama; podle toho, jak tvrdá je vaše voda, se sediment ve dně hromadí, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač vzduchu bych ho ohodnotil jako o něco méně účinný než zvlhčovač typu knot se stejnou velikostí ventilátoru.
Výhodou je, že nekonzumuje knoty.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně musíte provozovat asi 5 let, abyste rozdíl vyrovnali.
Má poměrně velkou kapacitu vody pro svou velikost, protože "tank" je nedílnou součástí jednotky a je to nízký výkon (i když ne lepší než knotový typ).
Také se poměrně snadno čistí, i když plastové disky nelze opravovat, protože diskovou jednotku nelze demontovat.
Pro německé strojírenství však kvalita stavby není velká.
Už rok mám svůj, což by bylo asi šest měsíců provozu za chladného počasí, a jednotka vyvinula velmi otravný rachot ze sestavy ventilátoru.
Odhaduji, že by to byla ložiska ventilátorů, takže jen čekám, až se tady stane úplný neúspěch.
Jak poznamenal někdo jiný, jakékoli opravy se téměř rovnají pouhému nákupu nového zvlhčovače knotů.
tl; dr - nestojí za extra náklady, jste na tom lépe s zvlhčovačem knotu.
Asi se to snáze zlomilo, než si mysleli.
Dávám tomuto produktu 3 hvězdičku udělat s tím, že když jsem ho dostal, byl rozbitý už uvnitř.
Jakmile jsem si to prohlédl, uvědomil jsem si, že ten, kdo to dal do krabice, to tam dal rozbité, Tohle mohly být buď výrobci baličky, nebo kvůli výrobcům problém mohl být v tom, že kupující vrátil zboží a tvrdil, že ho prostě nechce nebo nepotřebuje a Amazon možná neudělal dostatečně kvalitní kontrolu, když se vrátil.
Po pravdě řečeno, kupující nemohl říct, že je rozbitý, protože pak by ho Amazon nevzal zpět, což je dobré zejména u tohoto druhu výrobku tak či onak, i když jsem to já, kdo uvízl v něčí nedbalosti.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a diskutoval o tom se svým manželem, jsem se rozhodl dát tomuto kupci další šanci.
S tím, že budu pouze aktualizovat své hodnocení na vyšší hvězdu v závislosti na tom, jak se zákaznický servis vypořádá s tímto příspěvkem (alespoň jeho adresováním) a pokud položka přijde ve skvělé kondici, má skutečně možnost dělat to, co dělá, a dobře funguje, když dělá to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale nebylo to pro mě tak snadné nainstalovat.
Oba "zvonky" jsem zkoušela do zapojeného vysílače nainstalovat několikrát bez jakéhokoliv štěstí.
Byl jsem připraven vrátit ji jako nefungující, ale myslel jsem si, že to ještě zkusím a zkontroluji baterie v zvoncích.
Voila...z krytů baterií trčely malé plastové kartičky, které jsem vytáhl a ven přišel plastový kousek, který zakrýval baterii a bránil jí v práci.
Poté, co jsem odstranil tyto kousky plastu, zvony fungovaly v pořádku a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v návodu pro uživatele není zmínka o plastu nad baterií, který musí být odstraněn, aby zvonek fungoval.
Bylo by méně frustrující, kdyby se o tom zmínili a já si nemyslel, že problém je v tom, že nedokončuji instalaci správně.
Je to dobrý produkt s širokou škálou kroužků, zvonků a melodií, které si můžete vybrat, a je snadné je změnit, kdykoli chcete.
Jedna věc, kterou se při hodnocení tohoto zvonu ptají, je, jak je "nepovětrný."
Nemohu se k tomu vyjádřit, protože byl instalován 5. července 2019 a pravděpodobně se nebudeme moci vyjádřit k tomu, jak je odolný proti povětrnostním vlivům, až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - Znovu mě nabil
Vyrostli s nimi a byli nadšeni, že je koupí pro mého syna, ale přišli o balíček živých housenek.
Řekli mi, že ho vymění a tentokrát si naúčtují polovinu lodní dopravy.
Po delší době telefonování mě nakonec dobíjeli na novou objednávku se slevou 3$.
Považoval jsem to za dost neprofesionální, protože nejenže o to přišli, ale vedli mě k přesvědčení, že to napraví jen proto, aby mi na konci třicetiminutového telefonátu s nějakým šprýmem o poukázce naúčtovali téměř plnou cenu.
Strávil jsem 30 minut na telefonu, tak jsem propadl a právě jsem si koupil další sadu housenek.
To je jedno.
Funguje dobře po některých bolestech hlavy.
Měl jsem nějaké problémy, aby to fungovalo.
Dodaný kabel nebyl k ničemu - nenabíjel by baterii.
Když jsem vyměnil kabel s mým vlastním byl schopen nabít a pak připojit zařízení přes bluetooth k PC.
Měl problémy najít software pro PC, ale když jsem poslal e-mail jejich podporu, odpověděli během jednoho dne se správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, ale nebyl jsem schopen připojit se k iPhonu nebo iPadu (zkoušel jsem několik z nich) přes bluetooth.
Bude muset hard-wire, pokud se rozhodnu použít toto zařízení v mém produktu.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je to jako starožitné zlato
Před nákupem jsem se zeptal prodejce, jestli je barva příliš žlutá, a bylo mi řečeno, že je jako starožitné zlato, tmavší.
Nic těsného!
Sada vypadá velmi levně.
Je to super lesklá žlutá se spoustou CZ, ještě lesklejší.
Na fotce to vypadá skvěle, ale ve skutečném životě bych to ani teenagerovi nedala na sebe.
Miloval prsten - ale nemohl ho nosit pořád! :(
Ten prsten byl krásný.
Líbil se mi design a podsaditý pocit; vypadalo to draho a bylo to velmi pohodlné!
Jediný důvod, proč jsem dala jen 3 hvězdičky a nakonec výrobek vrátila, je ten, že jsem si uvědomila, že ho nebudu moci nosit pořád.
Rád nosím své prsteny pořád, a proto se vždycky starám o to, abych dostal sterlingové stříbro, a vím, že někteří lidé říkali, že jejich prsteny jsou po nějaké době poskvrněné, ale já jsem své nosil asi týden v kuse - i při mytí rukou - a nevšiml jsem si žádného poskvrnění.
Zajímavé bylo, že problém, který jsem měl, byl v tom, že vnitřní pás prstenu mi ve skutečnosti zbělel a zvlhl - něco jako šátek poté, co ho necháte dlouho zapnutý.
Stalo se to, i když jsem se ujistil, že prsten a prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale začalo to být nepříjemné, tak jsem se rozhodl, že to pro mě není ten prsten.
:( Škoda, protože jsem to opravdu miloval!
Takže pokud si kupujete tento prsten se záměrem nosit ho jen příležitostně, říkám, jděte na to!!
Nebudete zklamáni!
koupit Pampered Chef...
Vlastním malý sólokapr Pampered Chef, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Miluji používání těchto kopečků při pečení perfektně porcovaných sušenek.
Podíval jsem se na odměrku OXO a odměrku Pampered Chef a rozhodl jsem se, že ušetřím nějaké peníze a pořídím si odměrku OXO - většinou mám s jejich výrobky štěstí.
Tohle ne.
Asi u sušenky s arašídovým máslem č. 30 přestala fungovat páka uvnitř lopatky.
Musel jsem vytrhnout rukojeti od sebe a znovu umístit páku, abych mohl udělat ještě pár dalších, a pak to zopakovat.
Takže... ušetřete si zdravý rozum a kupte si odměrku Pampered Chef.
Stojí to za to!
Už si pana Kávu nekoupím
Nějakou dobu to byl jemný kávovar, ale vždycky s ním byly problémy.
Pokud byste dostali vodu mezi černým plastem a kovem na karafě, unikala by a odčerpávala vodu celé dny.
Pak se nám rozbila plastová páka, která umožňuje, aby káva protékala filtrem do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale oni by mě pouze odkázali na servisní středisko, které je více než 90 minut od mého domu.
Je skvělé vařit kávu a udržovat ji horkou, ale je s ní příliš mnoho dalších problémů, než aby se do ní dalo investovat za současnou cenu.
Musí se koupit!!
Milovala jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediné, s čím jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v rukojeti a všiml jsem si, že předtím, než jsem ho koupil, což je důvod, proč stále dávám tento 5 hvězdiček!
Bylo to snadné na čištění a vše přišlo zabaleno jednotlivě, což jsem zjistil, že je opravdu organizovaný a uklidnilo mou duši lol láska, láska, láska, láska barva a já bych určitě koupit znovu pro sebe nebo pro milovanou osobu!
Může být dobrý na tyči, ale ne jako závěsný přepážkový nebo meteorologický štít.
Hanba Audubonovi.
Pokyny vám říkají, abyste zástrčku protlačili otvorem v přepážce a "Ujistěte se, že je bezpečně na místě."
Jak?
Je navržen tak, aby přepážka jednoduše volně seděla na zástrčce, takže ji může vytlačit jakákoliv potvora nebo sebemenší vítr.
Zásuvku můžete otočit vzhůru nohama tak, aby se palcové šrouby nacházely na spodní straně přepážky, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to neudělá a jen ty nejmenší prsty by to měly snadné.
Trvalo mi přes hodinu, než jsem je napůl upekl, abych je přišrouboval, abych zajistil zástrčku na zástrčku.
Je to kompletní PITA.
Objednal jsem si čtyři; ty tři, které jsem neotevřel, jdou rovnou zpátky a já jsem na trhu pro lepší meteorologické stráže.
(Řekněme si to na rovinu; není nic takového, co by ve skutečnosti "zmátlo" veverky!)
Miluji mnoho vlastností těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které dostávaly moje nové zeleninové sazenice z okna.
Miluji mnoho vlastností těchto světel.
Klady: Za prvé, snadno se upnou na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak mé rostliny rostou.
Světla jsou chladná na dotek a nezpůsobila škodu ani při doteku s rostlinami.
Věřím, že moje zelenina těžila ze světel.
Světla jsou stmívatelná, ale používám jen nejsilnější nastavení.
Časovač jsem nevyužil, raději jsem je sám zapínal a vypínal.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: nevěřím, že tato světla jsou dostatečně silná na to, aby byla primárním zdrojem světla pro mateřské rostliny.
Světla jsou malá!
Až vyhoří světla, budu si muset koupit úplně novou jednotku.
Dávejte pozor... je to velmi špatné... karty sloty příliš velké!
Když jsem to viděl poprvé, myslel jsem si, že je to krásné, ale vonělo to SO BAD.
Zpočátku jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že je to MOLD vůně.
Nikdy to nezmizelo, tak jsem to musel vrátit.
A navíc, kapsy na kreditní karty jsou příliš velké.
Kreditní karty sklouzávají až dolů, tipy se neukazují, takže nemáte ponětí, jaká karta je kde a velmi obtížné se dostat ven.
Fotka, na které ukazují, kde se kartičky zalepují, je nepřesná.
Je to velmi malé..
Dostal cestovní peněžní pás a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych si ho nekoupil a ještě budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Nejdřív musím říct, že barva je loveeeee.
Spousta věcí, které si objednávám ve fialové, vždycky přijde příliš lehká, příliš kiddish, příliš divná, příliš neonová, co to máš.
Ale tahle fialová byla hluboká a svěží a já ji miluju, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, jaký jsem měl.
Dodává se s krytem, a i když nemusí mít příliš funkční využití, opravdu to udržuje ostrý vzhled.
Balení je hrozné - obdržel 3 poškozené kytary
Velmi dobře vypadající kytara.
Škoda, že firma neví, jak svůj produkt ochránit.
Neobtěžujte se s tím, že se pokusíte obdržet takovou, která není poškozená.
Vrátili jsme 2 kvůli poškození v lodní dopravě a 3. byl také poškozen.
Vzdal jsem se.
Dodávají ji v měkkém tenkém pouzdře s jedním listem hnědého papíru v lepenkové krabici.
Vůbec žádné polstrování.
Skvělý koncept!
Jen potřebuje další vylepšení, aby to byl opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluju karaoke, takže tenhle mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje tak, že současně funguje jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a zaznamenává vše, co vyjde.
V samotném mikrofonu ale není žádná hudba.
Má bluetooth konektor, takže ho synchronizujete s telefonem a stáhnete si karaoke aplikaci, která může posílat karaoke písně do mikrofonu.
Nebo můžete dokonce synchronizovat aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon přichází s různými možnostmi upravit úroveň hlasitosti hudby a vašeho hlasu (odděleně také!)
a dokonce má možnost nastavit úroveň ozvěny, takže ve skutečnosti zníte, jako byste byli v karaoke místnosti.
Některé věci, na kterých bych rád viděl budoucí vylepšení, jsou: 1) je tu nějaká nepříjemná zpětná vazba, která se nezdá být pryč bez ohledu na to, jak daleko jsem svůj telefon od mikrofonu.
Jestli jsi na to přišel, rád bych to věděl!
2) možnost přepínání ve středu mikrofonu je nemotorná.
Jsem cucák minimalismu, takže je skvělé, když budoucí produkty dokážou design uhlazenější.
3) podpora dalších karaoke aplikací Konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne prostřednictvím ploché obrazovky nebo centrálního reproduktorového systému obývacího pokoje, není to tak zábavné v prostředí večírku.
Pokud to výrobce dokáže nějak integrovat do většího ekosystému karaoke večírků, tak by to udělalo toto nekonečno příjemnější.
Žebrovaný od společnosti Vision Supplies
V říjnu 2017 jsem koupil čtyři (4) kazety od Vision Supplies - Amazon Marketplace, takže bych je měl, když je potřeba, a abych ušetřil náklady na dopravu.
Používali dva za posledních pár let, asi jeden za rok, a fungovali dobře.
Minulý týden jsem se pokusil použít jednu, téměř prázdnou po vytištění 20 etiket, ale v poslední době došla po 40 stranách.
Plast chybí na obou.
Platnost záruky vypršela!!!!
Kdo by po obdržení zkontroloval každou kazetu????
BUYER BE AWARE!!!!!!!!!!!
Omlouvám se, co?
Kamarádka mi doporučila masku této řady, tak jsem si koupila tu, tento kondicionér a všechno v jednom mléce.
Nemohu mluvit za účinnost výrobku, protože vůně prostě nebyla snesitelná.
Víš, že zatuchlá vůně starých budov se používá na ženských toaletách, aby se pokusila zamaskovat vůni *dámy*, ale ukázalo se, že je to jen taková kyselá, chemická, jakási zatuchlá babička?
To je vše, co mě napadá, když to cítím.
Znáte různé tahy různých lidí, takže se vám možná bude líbit ta vůně.
Můj přítel říkal, že to může pomoci i těm nejpoškozenějším vlasům, takže pokud se nestaráte o vůni, pak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že čím dál víc přírodních linek se prostě zajímá méně, protože se to stejně bude prodávat, a tak teď všechno jen voní jako playdough.
Ztratil jsem kvůli nim pár oblíbených řádků, které mění vzorec na levnější ingredience.
Nevím, jestli je to tak, nebo jestli je to padělek (který jsem nazval Davines a oni řekli, že není), ale tohle smrdí jako Y U C K a musel jsem ho vrátit.
Spustí internet
Tento modem/router jsem si koupil asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale za poslední rok plus Ive měl problémy s tím, že upustil internet.
To se děje na všech mých zařízeních jak Wi-Fi, tak kabelové.
Jediný způsob, jak obnovit službu, bylo provést reset napájení střídavým proudem.
Tohle se dělo jednou nebo dvakrát denně.
Comcast vyšel ven, vedl novou koaxiální linku od podstavce k domu a zvýšil úroveň signálu.
Stejný problém.
Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát přišel o službu 5G.
Musel jsem udělat tovární reset, abych to obnovil.
Na základě mých zkušeností nemohu tento modem/router doporučit.
Zakoupil jsem modem/router Netgear AC1900.
Je to fantastické.
Měl jsem to přes týden bez problémů.
Je rychlejší a dosah je větší než u Arrisu.
Četl jsem na internetu, že jiní lidé měli problémy s modemem/routerem Arris připojeným ke Comcastu.
Pokud máte Comcast internet nedoporučuji tento Arris modem/router.
Získejte Netgear, jeho mnohem spolehlivější.
ale stává se, že je to dost otravné.
Na pozitivní notu
1 z fanoušků vyzněl nevyváženě z krabice.
Ovládání rychlosti je opravdu podivné - pokud je vytočíte na 100%, ventilátory se vypnou, takže je třeba je otočit na 100% a pak pomalu vytočit zpět, dokud se nevrátí.
Kvalita sestavení je průměrná, ale zdá se, že u většiny těchto typů výrobků je to v tomto cenovém bodě par.
Nohy pro držení notebooku při naklonění se párkrát odlomily...
Vracejí se dovnitř, ale stává se, že je to dost otravné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z větracích otvorů umístěných poblíž horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem doprostřed a poskytuje velmi malý dodatečný průtok vzduchu do notebooku s takovou chlazením.
Ok případ s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný - 3,5 nebo 4 max.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně případů.
Z těch je Gumdrop asi nejlepší, ale má několik vážných problémů.
Guma pouzdra (silikon, cokoliv) je velmi hladká a kluzká a nedává vám moc sebedůvěry, když držíte Tab jednou rukou.
Tab A je těžký, takže pokud se položíte při sledování videa, pouzdro vám sklouzne do ruky, takže musíte často upravovat.
Musel jsem odstranit čirý plastový štít, který pokrývá obrazovku, protože to narušilo ovládání dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a chatrný.
A konečně, ztížili cestu k peru S.
Pero S je v zadním pravém dolním rohu Tab A a vyrobili malou gumovou klapku, která chrání rohové výkyvy dozadu pro přístup k peru S.
To znamená, že aby se pero S dostalo ven, musí se klapka vyhoupnout o 180 stupňů.
Je to opravdu trapné a těžko se to dělá jednou rukou.
Tento případ odvádí dobrou práci při ochraně mého Tabu A, ale s těmito vážnými konstrukčními vadami ho nemohu doporučit, pokud nemáte S pero, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu hladký - jedna zastávka nakupování pro všechny mé potřeby konektivity.
Miluju, když to hodím a laptopy maličký napájecí adaptér do tašky a připravuji se na práci na velkém 4k displeji nebo na focení z foťáku.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 usb-c hubech, které jsem vyzkoušel od různých značek), je to, že macs zjevně nedokáže rozlišit mezi násobky stejného monitoru (takže můj mac vydává stejné video na všechny identické monitory připojené k rozbočovači, ať už HDMI a / nebo VGA).
Ale pokud používám 2 samostatné huby / adaptéry nebo 2 různé modely monitoru, pak mac správně výstupy na displeje jednotlivě.
Ok, potřebuje nějaké zlepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje nějaký bezpečnostní zámek přes tlačítko nárazu (byl stisknut spíš náhodou, když je v kapse, pak jsem ho vlastně měl v úmyslu použít) moji psi se dokonce omylem zabouchli poté, co šlápli na dálkový ovladač.
Také pokud se váš pes rád válí v mývalích hovínkách jako já, je to taková bolest v zadku, že se čistí.
Jak se fekálie dostává mezi trhliny zařízení, které vyžaduje, abyste celou věc rozebrali, abyste ji správně vyčistili a dostali zápach ven.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebuješ zorný úhel, aby to fungovalo.
A byly doby, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Být dobíjecí je určitě příjemná vlastnost a nabíjení vydrží ještě nějakou dobu.
Stačí mi nabíjet moje asi jednou za dva týdny.
Dostaneš, za co zaplatíš.
Hrůzný výrobek, nesprávně zastoupený
Koupil jsem si to jako tracker k použití při plavání a nedostal jsem ani pořádnou šanci to vyzkoušet.
Za prvé, není voděodolný a nedoporučuje se používat při plavání podle návodu.
Za druhé, nepřichází s nabíječkou.
Místo toho navrhuje použít USB zástrčku nebo počítač.
Fajn, těch máme kolem sebe hodně.
Když se ho však snažím dostat do přístavu, abych ho nabil, spustí se hned zpátky.
Nejsem si jistý, jestli je něco, co není kompatibilní, nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet svůj přístroj, zatímco se nabíjí.
A konečně, aplikace neustále objevuje reklamy, i když je zavřená.
Když jsem posílal text, objevily se reklamy, což je velmi znepokojující.
Pak jsem zavřel všechny aktivní aplikace v telefonu a uviděl další reklamu, když jsem si šel zkontrolovat čas o 20 minut později.
Hrůzný produkt, asi dostanu to, za co jsem zaplatil...
Skvělý batoh, ale overkill na popruhy
Tento batoh vypadá dobře a dobře si vede.
Je to hodně, zvlášť když to porovnáte s tím, co batohy stojí teď dny.
Důvod, proč jsem srazil hvězdu, je ten, že je tam příliš mnoho popruhů.
Na té tašce je víc popruhů, než dokážu spočítat.
Nakonec tyto popruhy vyříznu a spálím, protože většina z nich není opravdu nutná a prostě se připletete do cesty otevírání a zavírání tašky.
Kromě toho jsem si vyrobila svou novou školní tašku na vysokou.
Tam je přihrádka přímo v zadní části batohu pro můj MacBook Pro a všechny mé knihy se vejdou do kapes, které jsou k dispozici.
Vlajka je také skvělým zakončením
Můj pes ho ještě nezničil
Měl jsem zkušenosti s hokejovými míčky.
Můj pes je miluje - svou oblíbenou aportovací a žvýkací hračku - a vznášejí se.
Tedy dokud je nepřekousne na kousky.
Zkoušel několik, dokonce i "horké" verze - a ty trvaly o pár minut déle než ostatní.
Dokud se ty neobjevily.
Ty obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavý v tom, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj v psu.
Palečky nahoru od Daisy a mě.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme zkontrolovali baterii a viděli jsme, že voda jde do přihrádky, kam jdou baterie.
Samotné baterie shnily a vycházela z nich černá tekutina.
Při pohledu na design se zdá, že v žádném případě by kryt baterie nemohl být vodotěsný, což znamená, že nejenže voda šla do přihrádky během koupele, některé z tohoto toxického materiálu také vyšly ven.
Prosím, nekupujte tento produkt.
Jsem šokován, že bylo dovoleno jít na trh i přes tak zjevnou chybu.
problémy s přehřátím a těžké připojení regulátoru
Dávám mu 3 hvězdičky prozatím, nechci zanechat špatnou recenzi pro prodejce, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale špatně pravděpodobně zkusit oba jen vidět, co říkají.
Líbí se mi, že dron je pohodová malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů mi připadají spíš jako hračka než tenhle.
Nicméně jeho jediný dron jsem kdy měl problémy s přehřátím a to ve skutečnosti bere zábavu z létání im bude předpokládat prozatím, že je to výrobní problém, který potřebují řešit co nejrychleji, pokud chtějí, aby tam produkt byl úspěšný.
Opravdu doufám, že mi prodejce neposlal použitý dron, protože jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, protože dorazí 1 den po nákupu.
Po kontaktování prodejce a dji tello aktualizuji datum své recenze.
K téhle dárkové tašce mám co říct
K této sadě dárkových tašek mám co říct.
Podařilo se mi zabalit všechny vánoční dárky s taškami, dárkovým obalem a hedvábným papírem.
Výrobek je skvělá kvalita a různé možnosti velikosti usnadňují výběr perfektního pro každý dárek!
Vřele doporučuji.
Prodejce je naprosto sladký a pozorný.
Po mém nákupu mě oslovil, abych se ujistil, že jsem se svým výrobkem spokojený.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte tuto hru, fyzika je hrozná a já jsem tak naštvaný na tuto hru, protože pravděpodobně existuje asi 40 hackerů na každé hře a hře.
Nedělejte s tím ani nic, víte, že prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra pokračuje v aktualizacích o svých postavách opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné nekupujte tuto hru fyzika je hrozná a mechanika je hrozná lidé, kteří očividně lidé, kteří postavili tuto hru, byli vysoko nebo něco takového, protože je to jedna z nejhorších her, které jsem upřímně kdy hrál ve svém životě, raději bych hrál Pixel Games v této blbosti je to jedna z nejhorších her, které nekupují
Ne jako jiné hrobky nájezdník hry
Od samého začátku to nepřipadalo jako ostatní hry na nájezdníky hrobek.
Hra je brutální v tom, že ovládání není chytré v tom, aby vědělo, jakým směrem se snažíte vydat.
Nechat tě padnout na smrt tím nejzbytečnějším způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Nelíbila se mi tato hra.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraju hry.
Ergonomické a cenově dostupné, ale ne příliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou tam žádné ostré rohy, které by se daly zachytit, a s napájecím kabelem jako trvalým uchycením je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští v akčním hraní, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžkopádní a máme tendenci opotřebovávat 2-3 ovladače ročně.
Pro nás tedy každoroční investice do kontrolorů znamená, že musíme být vybíraví a obezřetní, pokud jde o to, co kupujeme.
Ovladač by si vystačil s odolnějšími pružinami; po několika měsících tlačítka, která se používají nejvíce, přestanou reagovat a pravý joystick ztratí své centrování, IE- umožňuje mapové obrazovky přiblížit a postavy kráčejí vpřed, aniž by se dotkly ovládacích prvků.
Dostaneš, za co zaplatíš
Byl jsem zklamán, když jsem obdržel tuto položku, protože stříbrná část, která se pohybuje kolem obličeje, se zdála být vyrobena z nějakého levného plastu.
Není to fakt, že byla vyrobena z plastu, který mě zklamal stejně jako fakt, že použitý plast ji dělal neuvěřitelně levnou.
Pro mě tenhle detail zničil celý ten pohled.
Také jsem nevěřila, že vydrží každodenní nošení, a tak jsem ho nakonec vrátila.
Byl jsem zklamaný, protože se mi zdálo, že by to byl dobrý obchod, nebýt toho.
Nicméně, to můžete přehlédnout, pak by to mohlo být správné pro vás.
Byla dobře zabalená a dorazila rychle.
Nic jako předchozí telefony Stylo, MASSIVE DISAPPOINTMENT.
Měl jsem původní Stylo i Stylo 2, Stylo 2 V a Stylo 2 Plus.
Stylos se mi očividně moc líbil vzhledem k tomu, že pokaždé, když vyšel nový, jsem si ho koupil.
Nikdy proto, že by člověk měl problémy nebo se rozbil, jen proto, že jsem chtěl zůstat vylepšený a "ve smyčce" a udělal jsem to.
Ze všech těch telefonů jsem ani jednou neměl problémy se samotným telefonem.
Když jsem tento nákup pro Stylo 3 přes Virgin Mobile, prostě jsem věděl, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos tak nádherné.
Nikdy jsem ani nebyl schopen úspěšně nechat tento telefon převést na můj účet Virgin Mobile.
S tímhle telefonem jsem si zahrával o něco méně než týden.
Hledal jsem informace na internetu a zoufale jsem se snažil dát Stylo 3 výhodu pochybností v naději, že jsem to jen já, kdo dělá něco špatně, ale bohužel jsem tím promarnil spoustu času, protože to byl 100% telefon se všemi problémy, které jsem si nechtěl připustit.
Nenávidím, že musím dát Stylo tak hrozné hodnocení a recenzi, ale byl jsem tímto telefonem nesmírně zklamán.
Doufejme, že LG zvýší svou hru a může zlepšit budoucí Stylos, pokud nějaké existují, ale tohle byl obrovský BUST.
Z té lepší stránky, návrat a moje vrácení peněz proběhly hladce, ale to je tak všechno.
