Hacknutá verze rytíře Jedi se hroutila, protože vyvolávala funkci na konci vtablu.
Ukázalo se, že je předpoklad, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má další metody připíchnuté na konci ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože to je pouze vytvoření pohledu pomocí objektu Direct3D, ne objektu Direct3D3.
Nyní, chápu, že v praxi, IDirectXObject2 je typicky řádná nadmnožina IDirectXObject, bez změněných podpisů funkcí, a nové metody pouze přidány na konec.
To však neplatí všeobecně; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže v každém případě, protože to platí i zde, pro opravu jsem musel rozšířit svůj pohled implementace obsahovat metody IDirect3DViewport3 tak, aby volání na nový byl platný.
Předpokládejme pro účely argumentace, že věda se alespoň zčásti skládá ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoliv teorii, kterou by mohly podpořit.
I když je pravda, že taková fakta ve vědě existují, je stále možné tvrdit, že vědecká fakta jsou zatížena teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale výběr toho, které experimenty budou prováděny, kontroluje, která fakta budou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplývat pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho donucování, aby se jim jinak dařilo.
Toto je velmi stručný nástin věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi potvrzujícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým já nevěřím.
Bude to moje první projektové auto.
Vyzvednu si to o víkendu.
Hledal jsem dobré auto pro prvního chlapa, a opravdu se mi líbí estetika 80. let.
Již na cívkách a snížené jízdní výšce.
Udělal jsem si malý průzkum, ale byl bych rád, kdyby měl někdo nějaké informace o tomto autě.
Osobní zážitky?
Vím, že ve srovnání s nimi nejsou rychlí.
#Venting into the Fediverse time.
Domácí partner a já jsme šli dnes večer do obchodu pro pár piv a láhev piva.
Když jsme se šli odhlásit, pokladní je celkem jasná #trans žena.
Já, v kraťasech a mlátičce manželek, a Domácí partner, celý potetovaný a s novým účesem, o kterém sám říkal, že ze mě dělá neonacistu.
Její tělo okamžitě ztuhlo a v očích se jí objevil strach.
A pak jsme prostě... zaplatili za naše věci.
A poděkoval ti.
A já řekl, že její nehty vypadají cool.
Úsměv úlevy na její tváři byl skvělý pocit, ale skutečnost, že byla vyděšená jako první.
Tohle je ta nejhloupější časová osa a já ji nesnáším.
Donaldu Trumpovi nic nebrání v tom, aby kandidoval na prezidenta, zatímco je obžalován, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Kdyby byl zvolen, nepochybně by si odpustil, aby se dostal z vězení.
Ale ze státního vězení se omilostnit nemůže.
Chce to guvernéra státu.
Jedná se o dva státy New York a Georgia.
Guvernér Kemp nepochybně Trumpa omilostní, bude-li usvědčen nebo dokonce obžalován okresní prokurátorkou Fultonu Fannie Willisovou.
NY je nejlepší nadějí na zodpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze redukovat na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického Lewisova (1969) signalizačního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména demonstrujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový výskyt dostatečný.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové rozčlenění významů symbolů.
Ukazujeme, že ekologická omezení při volbě referenta příjemce mohou být jednostranně využita odesílatelem, bez rozcestníkových schopností na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je nutné, aby odesílatel znal kontext.
Domníváme se, že kontextově závislá komunikace je situovaný vícevrstevný jev, zásadně ovlivněný vlastnostmi prostředí, jako je rozložení kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale přesto umožňují téměř dokonalou přesnost komunikace.
Moc se mi líbilo, že jsem se o víkendu sešel s Penny a Nicholasem z Ashanti Development a popovídali si o jejich pokroku.
Ašantská rozvojová spolupracuje se stále rostoucím počtem komunit v ghanském regionu Ašantá již téměř 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygienických zařízení, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, aby mohly zakotvit a podporovat svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Mikuláše a podporoval řadu projektů.
Když jsme to o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména v oblasti výsadby stromů a podpory zemědělství.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšenou úrodu prostřednictvím řady intervencí od podpory nákupem vybavení po odbornou přípravu.
Nicholas spolupracuje se zemědělci na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je opadavý červ, který může ničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS vedle mě mi nedovolí napsat štítek nebo napsat na krabici.
Musí se vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou to jde a kdo to posílá.
Musím poslat nějakou náhodnou adresu s neformátovanými daty, aby si úředník mohl e-mail přečíst a zadat ho do svého systému, aby mohl vytisknout štítek.
A vždycky mi účtují 2,25 dolaru za tuhle „vymoženost“.
Druhý den ráno a já se nemůžu dostat přes ostudné předstírání Chrise Lichta o veřejné službě žurnalistiky na CNN včera večer.
Byla to nehoráznost, jako symbolický antidemokratický festival lží a křivd 6. ledna, který sebedestruktivně pořádala americká média.
ŠAMPIONÁLNÍ AUDIENCE.
Licht DOHODLY všem republikánským divákům!
Kdo prověřoval a vybíral jednotlivce?
Bude tam reportáž.
Sledovanost – hledání klamné nezodpovědnosti za to všechno.
Nemůže se to opakovat.
Mám v suterénu hodně průvan, což v podstatě znamená, že se sem může uchýlit spousta hlodavců.
Asi za poslední měsíc se objevilo hodně stop po větších hlodavcích, což bylo mimořádně překvapivé, protože je jaro a já bych si myslel, že se se změnou počasí vydají ven.
Nicméně jsem si nechal rozmístit několik obyčejných starých lapačů a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, protože myši je laskavě olízly dočista.
Včera v noci mě tahle rutina konečně přestala bavit, vyčistila jsem všechny pasti od burákového másla a nalepila na ně pistáciovou.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř všechny „humánní“ pasti na trhu s velmi malým úspěchem.
Nejsem nijak nadšený z jejich zabíjení, ale nebudu se vyjadřovat k etice zabíjení myší.)
Už mě nebaví, jak se konzervativní strany a vlády zabalují do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jasně, že snížili daně z podnikání.
Zároveň však snižují granty a daňové úlevy, které podporují větší podnikatelskou aktivitu.
Mám vlastní firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Objevil tvrdý způsob, že v roce 2023, místní televizní stanice webové stránky jsou absolutně nejhorší zážitek na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, popovery a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělat své peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud odhánějí lidi pryč.
To je pravda i teď, že kozy.cx je pryč, i když by to byl těsný závod ke dnu mezi kozy a, řekněme, khou.com, kde jsem se snažil sledovat video, které mi Wendy poslala.
V prvním vlaku se dnes pokladní podíval na naše jízdenky a řekl: „Dlouhá cesta!“
„Jo, a dneska se vrátím,“ řekl jsem.
„Jenom ho vysadím v Glasgowě,“ pokusil jsem se mu vysvětlit a ukázal na svého spolucestujícího.
„Moc často neslyšíte: ,Jenom ho vysadím v Glasgow',“ řekl prodavač lístků.
Je to věc, kterou jsem nikdy předtím neřekl.
Věc, která mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který vlastně nikdo nechce, kromě fanatiků, kteří v něm jsou.
A jsou to opravdu blázni.
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Získejte nějaké samolepky, které jsou anti-Trump a vylepit je po celém.
Křič na ty, kteří by se o nás pokoušeli mluvit.
To není normální.
To není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a přes ulici jsem slyšela, jak vykašlává slizovitou bouři.
Tak jsem spěchala, abych se mu vyhnula, ale on mě přesto dohonil, abych si s ním popovídala.
Přísahám, že kovadlinkově infikovaní lidé jsou zombie, které se snaží nakazit všechny ostatní.
Není společensky přijatelné vyjít na veřejnost nebo se vrhnout na lidi, když vykašláváte hlenovou bouři.
Opakuji. Není společensky přijatelné, aby se tvá hnidová bouře slizu šířila všude!!!
Psaní Zázraků 5/11: Směje se váš MC víc, nebo pláče?
Abe skrývá svůj žal a snadno se směje, zatímco Tom se nebojí plakat, ale méně se baví hrubým humorem.
Jan ti ublíží dřív, než ti dá najevo, že je zraněná a nejvíc se směje, když je všechno vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4000 trápení Yl se ocitá v místě lásky a má obrovské pocity, že neví, co s tím, takže je hodně obojího.
#CNN potřebuje prostě zavřít.
Včerejší fiasko s #MangoMoron bylo neskutečným fiaskem.
Kdo v té ubohé, umírající televizi byl zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který „vedoucí“ z kabelovky zavolal tomu tlustému, prolhanému kriminálníkovi, aby mu dal tolik vysílacího času?
Vysoký tlak bude přetrvávat až do začátku příštího týdne.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno, IR satelit a povrchová pozorování ukázala rozšiřující se oblast nízkých vrstev a nesourodé <URL>
Geeky student Arnie Cunningham se zamiluje do Christine, rezavé 1958 Plymouth Fury, a stane se posedlý obnovou klasického automobilu k její bývalé slávě.
Jak se auto mění, mění se i Arnie, jehož nově nabytá sebedůvěra se za volantem jeho exotické krásy mění v aroganci.
Partner Salesforce
Codleo je jedním z nejlepších Salesforce Partner nabízející nejlepší Salesforce služby šité na míru vašim firemním potřebám.
Potřebuješ pomoc?
Kontaktujte naše Salesforce konzultanty ještě dnes!
Najděte si spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu vaší CRM investice.
Zjistěte, jak vám může partner Salesforce pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což vašemu podniku umožní prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších věcí na mých sousedech, kteří se obracejí proti mně, je přemýšlení o tom, kolik úsilí stojí být nepřátelští.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Prásknout mi dveřmi před nosem vyžaduje úsilí.
Naši psi bývali nejlepšími přáteli.
A já stále nemám žádnou představu, co jsem mohl udělat, abych si tohle zasloužil.
Měli klíče od mého bytu více než 6 let.
Ta loď je zakázaná.
Jsem si vědom vaší nenávisti k Organě.
Ona je pro mě irelevantní.
Můžeš ji zabít, jestli to dokážeš.
Ale na palubě té lodi často létá jiný jedinec.
Pokud by zemřel... následky by byly... značné.
Hodně si stěžuju na otcovství.
Zde je (o něco delší než) toot-délka rychlokurz v tom, co mám na mysli táta-ification:
Není to můj termín, je to termín používaný k popisu toho, když je vyprávěcí nebo herní mechanika postavena na centrálním protagonistovi (obvykle starším, obvykle mužském), který hlídá nebo hlídá jinou osobu (často mladší).
The Last of Us je jednoduchý a kanonický příklad otcovství.
Joel využívá svých schopností a schopností k provedení (extrémních) násilných činů, aby splnil úkol, který je zašifrován jako „starostlivost“.
Táta-ification obvykle předpokládá, že řešení situace, kdy se rodičovská postava musí starat nebo chránit dítě nebo dítě záskok, je zdrcující síla a použití této síly k vynucení velmi specificky tvarované mocenské dynamiky.
Tátování nahlodává možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoliv agenturu, kterou dítě má.
Tátovražba tak představuje zastání mnoha neoliberálních ideálů, zejména myšlenek, jako je bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je rychlý přehled o tom, jak využít naše webové stránky.
- Při prodeji letenek rozesíláme oznámení.
- Poskytujeme odkazy na místa, kde si můžete zarezervovat jízdné.
- Neprodáváme vstupenky, ani neúčtujeme předplatné.
- Více podrobností najdete v úplném blogu.
- Vedeme seznam příkladů rezervačních termínů pro každý obchod jsme zveřejnit a my aktualizovat tento seznam několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto jim nepředstavitelný strach, hrůza a přemístění zanechaly neviditelnou jizvu traumatu.
Toto úterý se v Kyjevě setkala prezidentka von der Leyenová s první dámou Olenou Zelenskou, aby s ní projednala, jak podpořit její úsilí o poskytnutí pomoci v oblasti duševního zdraví ohroženým dětem.
Již jsme nabídli duševní a psychosociální podporu.
Všechno naše úsilí jim pomůže přežít tuto cestu.
Hromada zářivých nových dobrot v #dart
Postupem času se šipka stala mým oblíbencem pro rychlé uživatelské rozhraní.
#flutter je radost s nimi pracovat, a mají #mobx pro snadné vedení obchodu.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, flutter naštve opravdu špatně, pokud jde o chování jako dobrý nativní aplikace by (kdekoliv, opravdu. Dokonce i flutter web cíl naštve).
Ale to umožňuje pohybovat rychle, a to je důvod, proč je ideální pro malé hacky.
Echidna s ametystem a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou postavu a svalnaté tělo.
Jejich ocas je extrémně silný.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Oči mají hruškovité a nosí šarlatové cateye brýle.
Jejich nejzajímavějším rysem jsou jejich dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Být schopen skákat opravdu vysoko, trhat obyčejné lidi na kousky, používat strašidelné magické síly, a doplnit zdraví tím, že hoduje na své nepřátele – to by mělo být základem všech PC her, abych byl upřímný.
Přes nejlepší úsilí Bram Stoker, Max Schreck, a Stephenie Meyer ve snaze, aby jim vypadat špatně – všichni ...
Zdálo se mi, že moji rodiče hráli mou porno hru a dávali mi zpětnou vazbu.
V reálném životě, moje máma dělala jako puzzle hru jsem udělal před lety, a ona našla většinu tajemství na vlastní pěst, takže ona nebyla jen máma, když řekla, že se jí to líbí.
Možná se jí bude líbit I moje porno hra?
Možná má příliš mnoho jazykových jemností.
Musím to přeložit do mandarínštiny a/nebo Hokkienu, ani jedno z toho neznám.
Asi budu muset zjistit, jestli Bing nebo Google je lepší v překladu špinavé gay sex slovní hříčky.
Chvíli jsem si pohrával s myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od „pravidelného“ zdraví.
Proč?
Protože se to děje v mysli a zdá se to být méně hmatatelné než fyzické zdraví.
Po pravdě řečeno, zdraví vaší mysli, vašeho mozku, je právě tak otázkou zdraví, jako zdraví vaší nohy.
Intersex je dokonce rozpoznáván pomocí TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně „skutečné“ než zdraví fyzické, mám pocit, že bytí trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, pohlaví, psychologii, tím více se mi výrok „Mé pohlaví je mužské, mé pohlaví je ženské“ zdá zjednodušující a nepřesný.
Skoro to vypadá jako postoupení části sporu TERF.
Mám pocit, že být trans znamená být „biologicky nebinární“.
Mé pohlaví není binární, mé pohlaví je ženské.
Myslím, že označení „nebinární“ musí být rozšířeno z pouhého genderového termínu, který se používá, když se odkazuje na pohlaví.
S přestávkami jsem poslouchal díla @iotar
V tomto záhadném souboru je spousta dobrých věcí.
Jako nálady krauty a další světská pop music a radiofonické workshopy a všechno možné.
Stojí za to to zkusit.
Také FWIW Rozhraní archive.org se mi líbí mnohem víc než desktopové #bandcamp \- Nemám ponětí, jak lidé používají bc jako primární hudební platformu (kromě politických důvodů).
Trochu jsem si hrál s Flutter.
Nerad bych zakládal své podnikání na technologiích od Googlu, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivé zkušenosti napříč platformami a je to vidět.
(A také: Web je nyní do značné míry Google věc, bohužel)
Také prosím zdržte se mi říct, že Google / flutter aplikace sát na iOS a macOS.
Cross platforma je těžké, pokud chcete, aby to dobře.
Já vím.
Děkujeme lidem, kteří si stáhli poslední aktualizaci Leasey.
Objevilo se několik velmi malých problémů.
Nic, co by zvonilo na poplach, ale přesto se řeší.
Příští týden bude vydána malá aktualizace, která je opraví.
Většinu včerejšího dne jsme strávili instalací nové aktualizace pro některé zákazníky a každý, kdo ji potřebuje, by ji už měl obdržet.
Přeji hezký den!
Technické přiznání: Grafana & Prometheus mi nejde do hlavy, alespoň z hlediska metriky serveru/aplikace a sledování.
Nevím přesně, proč na to můj mozek nemůže přijít; může to být tím, že nástroje jsou prostě tak široké a neurčité, že můj mozek je prostě zablokovaný kvůli 'příliš mnoha možnostem'.
Chci dělat palubní desky.
Grafaně to sluší.
Mozek nepracuje.
Takže když se blíží nová řada nájezdů #FFXIV, dlouho jsem si říkal „Člověče, rád bych zkusil pořádný nájezdy, ale Party Finder zní jako bordel a já nikdy nenajdu statickou elektřinu, která by mě dostala.“
Tak jsem si řekl, kašlu na to!
Udělám si vlastní statickou elektřinu!
Plné lidí příliš dychtivý zkusit připojit se k raid statické, bez očekávání, že být dobrý vůbec!
V žádném případě by to asi nefungovalo!
...A tak jsem se přistihl, že musím sestavit rozpis nájezdových skupin.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a ztratil jsem veškerou vášeň pro fikci a skvělé vyprávění příběhů.
Ale po desítkách let, kdy jsem skoro nic nečetl (s výjimkou funkčních prací a literatury faktu a občasné svépomocné knihy), jsem si dal za cíl přečíst v roce 2023 23 knih.
Teď jsem u knihy 31 a je teprve květen.
Jsem BACK baby!
Ve skutečnosti jsem ničeho nedosáhl.
Jsem šťastný, že za mnou pár lidí přišlo v soukromí a řekli: „Podívej, kvůli vší tvé práci ti dám takovou sumu peněz.“
Chci vidět ty společnosti, které zprostředkovávají transakce, jak vysvětlují svým zákazníkům, jak si nastavují procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobré čtvrtletí, tak budou.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vybydlená a chátrající města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, zbraňoví fetišisté, pro-diktátorské pravicové křídlo... to je to nebezpečí.
Deportujte bílé rasisty.
Jsem tak unavená z titulků, které tvrdí, že „Dálková práce je mrtvá.“ nebo že „Dálková práce byla neúspěšný experiment.“
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno návnada, ale dělá mi to starosti ohledně vedoucích pracovníků a manažerů, kteří tyto články čtou.
Před rokem 2020 se pracovalo na dálku.
Stále budou existovat pracovní místa, která lze v dohledné budoucnosti realizovat na dálku.
Vzdálená práce je povolena.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim ubírá čas od jejich dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a pokuste se pochopit, jak vaši zaměstnanci skutečně dělají svou práci.
#WFH #business #neurodiversity
Nejde jen o konzervativce versus pokrokáře, řekl na semináři více než 100 přívrženců v Grande Prairie.
„Tohle je válka mezi lidmi a lidmi,“ řekl.
Parkerová se zmínila o potratech a o popudu moderních městských žen odkládat porod kvůli kariéře.
Tvrdí také, že NDP a progresivisté chtějí kvůli životnímu prostředí vylidnit společnost.
„Vy jste ten uhlík, který se snaží snížit.“
Tak jako od začátku u všech mých narozenin v minulosti, vždycky jsem měl ty drsné.
Kdykoliv se objevila May, děsila jsem se, že se pokusím oslavit svůj den.
Vždycky se něco stane, pokazí se to, nebo to skončí stresem a depresí.
Léta jsem bojoval, abych se z toho dostal a měl lepší dny.
Trvalo roky, než jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si svůj den bez starostí.
A dnešek se již stává velkým dnem!
Zima je v této malé části Velkého Jižního Světa za 30 dní.
Ale já se nedám oklamat!
Tohle je začátek.
Déšť padá a dokud není zmrzlý, tak v něm nebudeš tancovat!
Je pěkný den na objednání zmrzliny.
Byla to noc pro jednoho psa a ten pes nevstal z postele ani na „Dog's Breakfast – Breakfast for Dog's!“
Zapnu si podšívku do cyklistické bundy – jen pro případ, že bych ji potřeboval uvnitř.
Znáte výkonný způsob, jak webová komponenta reaguje na přidání/odebrání z dokumentu?
Toto je pro knihovnu komponent (OOUI) na Wikipedii.
Většinou se jedná o sémantický HTML s CSS a obecně nevyžaduje uživatelské prvky (které nabízí připojené Callback).
V současné době používáme hack MutationObserver.
Pro představení se nedíváme na celý dokument.
Vytvoříme odpojeného dočasného rodiče, nainstalujeme tam MO a pozorujeme, jak se odpoutává (takto přichycen jinde).
Casper #krysa je dnes absolutní jednotka.
Myslím, že moje nová práce mu prospěla – dvě volné toulky denně, zatímco já pracuji, v celkem předvídatelných časech.
Konečně mám dobrou visící fotku, takže si můžu být jistá, že není tlustý.
(U #krys může být příliš vysoký tělesný tuk škodlivý pro jejich zdraví.)
Není.
Je úplně hotový z toho, jak dvakrát denně obchází mou kancelář.
Nemám váhu, která by ho vážila, ale připadá mi, že váží přes půl kila.
Jsem tak ráda, že se mu daří.
Dnešní zpráva společnosti Aerostrike o pokroku:
1) Mírné úpravy mapy Hel's Fighters.
Nabídka map je navíc plně funkční!
2) Systém měnových odměn byl propojen.
Zítra bude testována různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal tunu a cítím se mnohem lépe ohledně předmětů v terénu.
Všechny kapusty, kapusta, mangold jsou transplantovány.
Plány nastavit v salátu v Penn na 6row vzor a uvidíme, jak se to srovnává s vysíláním osetých lůžek.
Jarní hrášek v Gilpinu se objevuje, takže je třeba nastavit mřížoví.
Také je třeba osivo řadu salát tam integrovat řezané zeleně v obou mají vyškolenou posádku na zavlažování, příprava na lůžko, a přesazení, což je 90% nesklízení dovedností položky
Je rok 2023 a stále vidím lidi s iPhony, jak se aktivně vyhýbají používání Apple Maps.
Apple Maps přichází s iOS jako výchozí, a přesto by lidé šli svou cestou stahovat a instalovat Google Maps do svých iPhonů.
Netuším proč.
Zvědavý, Nechal jsem otevřenou mysl porovnat, jak Google Maps a Apple Maps porovnat, na mém testovacím iPhone zařízení (můj denní ovladač je Android zařízení, takže je to vzácné, že používám iPhone).
Zkušenosti s dodržováním pokynů byly mnohem lepší na Apple Maps ve srovnání s Google Maps.
Apple Maps vítězí.
Tak proč lidé skáčou přes další obruče, aby si nainstalovali Google Maps?
Nemám ponětí.
Je možné, že se Google Maps dostaly na trh jako první?
Byla to katastrofa Apple Maps 2012?
Je možné, že je Google Search integrován s Mapami Google?
Nemám ponětí.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch neprozrazování odpadků koncovým uživatelům, a Apple to královsky posral s jejich Apple Maps, když to vyšlo v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale právě půda z něj dělá dobrého skladníka bohatství tak dlouho, dokud si budete myslet, že vláda nezmění systém, ve kterém žijeme.
Dům sám o sobě ztrácí na hodnotě, protože ztrácí svůj stav a potřebuje vyměnit.
Spousta lidí si myslí, že jim doslova patří země, když si koupí kousek.
To není ten případ.
V Číně si můžete pouze pronajmout půdu.
Nejsou tak hloupí, aby to prodali navždy.
Vláda může tyto politiky kdykoli změnit.
Půda je dočasná.
Zdá se nemyslitelné, že by vám jednoho dne mohla být odebrána půda, když sledujete australské a americké mediální kanály, ale to proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl přemýšlela určitým způsobem.
Jednoho dne jim vláda velmi snadno a rychle sebere půdu, pokud to budou chtít udělat.
A hádej co?
Nikdy nedávalo smysl, jak si ppl může udržet půdu na úkor ostatních.
Jednoho dne to musí být odebráno.
Proto Číňané povolují jen pronájmy.
Už jim došla půda.
Na úspěch, uskutečnění snů, přátelství, na prosté, ale pravdivé!!
Všem investorům tam venku připiji na váš úspěch a uskutečnění vašich snů.
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robekofirma#geolog #podnikání #udržitelnost #úspěch #přátelství #přípitek #sny
Často přemýšlím nad lidskou schopností být *tak* na dně, když je zaplavena tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se osobním selháním a pocitem viny ve světě, kde se „úspěch“ tak často připisuje lidem, kteří jsou zodpovědní za ty nejhanebnější činy...
Všichni jsme taková špinavá zvířátka.
Ale mírnit zoufalství nad naší chaotičností je klíčové – protože nám to dává více prostoru k tomu, abychom se vypořádali s ruinami všude kolem.
Tak se snaž nezapomenout, jo?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: „Na rychlosti psaní nezáleží!“
nebo „Modální redaktoři jsou dnes k ničemu“ :morty:
Me extrahování funkcionality mých #Axum projektů do sdílených knihoven: „Hold my keyboard“ :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup pro sdílení, ale zatím se mi to líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva pro tento týden na Zjevení je Zůstaň vzhůru celou noc.
Už pár dní si pohrávám s tímhle kouskem na hlavě.
Rozhodně je to víc romantika než špína.
Možná jsem četla mnoho románků s nemožnými 'meet cutes' a tohle je výsledek, ale líbí se mi to.
Taky jednoho dne budu mít mílový orgasmus, možná ne se str.
Nesouhlasím s tím, že #Mastodon je obtížné nastavit.
Obyčejné, opravdu to není tak těžké.
Ale je mnohem těžší najít lidi, kteří by tě sledovali a vytvořili tvou časovou osu.
Přál bych si, aby existovalo doporučení „koho následovat“.
Ale kromě toho to není těžké – pokud používáte aplikaci třetí strany, jako je Elk a / nebo slonovina.
Pokud zůstanete u výchozího webového rozhraní, nevypadá a necítíte se dobře (imho).
Takže to vyžaduje trochu více úsilí se do toho dostat a pravděpodobně potřebujete dobrou aplikaci pro vylepšení #UX.
Nevím, jestli je prevence možná, ale za pokus to stojí.
Čtyři kroky, které jsem nastínil, jsou předmětem diskuse, přičemž v každém z nich bylo dosaženo určitého pokroku:
Popis: Názvy pro případy chování lidí-algoritmů, které zodpovídají za algoritmy a lidi.
Vysvětlení: vysvětlení obou stran vzájemného vlivu
Prognóza: předvídání škod dříve, než k nim dojde (i když po minutách)
Intervence: znalosti o tom, co můžeme udělat pro změnu, v rámci jistých mezí důvěry
Radnici CNN jsem nesledoval, ale zdá se, jako by Trump říkal přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne Send na svém telefonu.
I kdyby je nestihl vyslovit na radnici, každý v Americe je stejně uslyší, a to opakovaně, ode dneška do listopadu 2024.
Stále to není důvod, abychom mu dávali jiné místo, ale škoda se zveličuje.
On vyhraje primárky.
Nemůžeme ho nechat odejít.
Je tady a bude to říkat, ať se děje, co se děje.
Přihlásil se na čekací listinu „AI Test Kitchen“ od Googlu a nastoupil ve stejný den.
V tuto chvíli je to velmi podbízivé.
„MusicLM Demo“ je mírně zajímavé.
Můžete požádat o specifickou skladbu, jako je „jazz se sólem na trubku v 5/4 tempu“ a ta vám po pár vteřinách vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... ta hudba prostě... není dobrá.
Házet všechno, co máte, přes plot v reakci na GPT, to není ono.
Snaž se víc googlit.
Je to divné dělat vzpírání, ale taky nemít ponětí, co je to jedna-rep-max, což je jeden z klíčových způsobů, jak lidé sledují své pokroky.
Cvičím sám ve své ložnici bez zaměřovače nebo dokonce bez držáku na váhu.
Jen já a činka s hromadou činek.
Tlačím na lavici na posteli.
Když se pokusím přijít na to, že můj jeden rep max je, že možná nevlastním dost činek na max, nebo naopak by mě to mohlo vážně zranit/zabít.
Každopádně, náklad dnes stoupne.
Pořád je mi dobře.
Přísahám, že Burrata před pěti lety neexistoval.
Tohle je můj osobní Mandelův efekt.
Nikdy jsem to v kuchařce neviděla.
Nikdy jsem ho neviděla v nóbl hokynářství ani v žádném italském lahůdkářství.
Nikdy jsem neviděla, že by to dělala něčí máma, nebo že by mi to někdo strčil na večírku, nebo že by se to objevilo ve spojení s něčími husarskými kousky nebo dny pečení.
Prostě se jednoho dne objevila a najednou byla dostupná všude.
Vstoupil jsem do dimenze Burrata.
Drake stárnoucí iPad se rozpadá, takže je na trhu s novým tabletem.
Protože jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo Linux tablet, který miluje?
To by bylo hlavně pro prohlížení webu, příležitostné e-maily, a některé hry.
V 1998-06 Gamefan, v souvislosti s dlouhým vývojem první Unreal hry, Jason Schrieber komentoval,
„Dobrá hra má zpoždění jen do té doby, než dorazí.
Špatná hra je špatná navždy.“
Takže to byl Epic, kdo to vytvořil?
Můžeme jít dál.
Starší vydání GamePro 1997-11 má citát s mnohem větší nejednoznačností,
„Anebo, jak se říká v jedné průmyslové frázi: pozdní hra má zpoždění jen do té doby, než dorazí.
Špatná hra je špatná do konce života.“
Je to tedy tak pomíjivé?
Pouhá „hláška“ bez jasného původce?
Smoky, můj 10ti měsíční pejsek Domestic Blue kotě, si hraje s červenou gumou Apple Pencil komfortní zařízení koupil od Amazonu utekl před několika měsíci.
Nosí ho hrdě v puse po celém domě a já se musím v duchu smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsem absolvoval kompletní okružní jízdu novým vlakem ICNG.
Opravdu se mi to líbí.
Važ si těch kočárů s většími okny.
Jsou tu oblasti, které by potřebovaly vyleštit.
Jmenovitě nedostatek zásobníků a nedostatek znaků, které by vysvětlovaly význam světelných barev.
Vyřešte ty drobnosti a můžeme jich mít víc, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Pravidla jednoho zákazníka zůstávají, protože se snažíme zajistit, aby se každý, kdo stojí ve frontě, mohl dostat k prknu.
Můžete si koupit jednu z výše uvedených desek, ne jednu od každé.
Neexistují žádná omezení nákupu na Picos nebo jiné zboží.
Včera jsem se skvěle bavil se svým přítelem a bývalým kolegou rabínem.
Navštívili jsme ji na pár hodin na mé verandě.
Taková přátelství přesahují rozdíly.
Všichni máme co vyprávět.
Bůh vám žehnej a ochraňuj vás!
A bažina se zazelená.
Docela se mi líbí akkoma software a název domény jsem dostal pro můj případ.
Ale mám pocit, že jsem tenhle případ začal tak říkajíc špatnou nohou.
A nikdy jsem se tam neusadil.
Will se tu ještě chvíli zdrží a popřemýšlí o tom, jestli mám vůbec migrovat.
#FalconGameBooks
Zdá se, že osmoocí Repnidové sledují, jak přistáváte s létavcem na červené půdě, ale nepohnou se směrem k vám, ve skutečnosti jsou nehybní, když vylezete z létavce a pomalu kráčíte směrem k nim.
Půda pod vašima nohama se začne chvět a pak se začne třást, jako při zemětřesení, a vy ztratíte půdu pod nohama, i když se zdá, že to Repnidy nezasáhlo.
Skála pod tebou náhle povolí.
Repnidové se prokopali pod povrch a vy spadnete do vroucí masy stovek Repnidských těl v jeskyni pod vámi.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl prvním budoucím lidským cestovatelem.
Přistaneš s letounem čumákem nahoru na bok hromady strusky a vylezeš ven.
Osmiocí Repnidové vypadají, že se dívají, ale nepohnou se směrem k vám, ve skutečnosti jsou nehybní, když k nim pomalu kráčíte.
Zastavíš se na hromadě rozdrobené skály a hlíny a promluvíš k nim se slovy: „Přicházím v míru, jako přítel.“
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladač nezachytí žádnou odpověď.
Rozhodnete se využít své Psychické Vědomí a kontaktovat je mentálně.
Je těžké porozumět jejich myšlenkám; jsou děsivě cizí a vaše mysl před kontaktem couvá.
Usoudíte, že navázat další kontakt by bylo nebezpečné a vrátíte se do svého letounu, ale tato zkušenost vám pročistila mysl, která byla zmatená od chvíle, kdy jste skočil do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je docela snadné zadat kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[pokračování]
#today I have coffee, sunshine and quiet time!
Začala jsem nosit nový šál.
V tuto chvíli si tím nejsem jistý.
Našla jsem nerovnoměrně spředenou stříbrnou šedou přízi, která je většinou jemně spředená s hrudkami.
Mám v plánu ji smíchat s jemnou fialovo-lilakovou bavlnou.
Ale nejsem si jistá, jestli mám dost fialové.
Používám háček H s podobným dvojitým háčkovaným vzorem, jako jsem to dělala dříve.
Včera večer jsem udělal první spoj, tak uvidíme.
Přejeme všem šťastný čtvrtek!
Nicméně nesnáším hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Doslova jsem se snažil a upustil KAŽDÝ JEDEN.
A ještě před dvěma lety jsem o tom neměl ani tušení, dokud jsem si nezkontroloval přepisy.
Nenávist v hodinách literatury je ještě horší: miluju čtení.
Většinu klasiky jsem si odbyla před osmnáctou – i když to je spíš odraz života v zasraný díře, taky jsem si v zoufalství přečetla Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a já jsem tam šťastná, ale musím být někde jinde, abych se během dne dostatečně zchladila a mohla číst beletrii, aniž bych se cítila provinile.
Je to jako bych byl na dovolené, a proto dělám to, co člověk dělá na dovolené.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma a trochu jsem si #MECFS odnesl z toho, že jsem prostě byl v cizím prostředí, kde jsem méně schopen se krotit a pamatovat si, kde co je.
A to i přesto, že mám stále svůj seznam úkolů a také si organizuji svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které miluju na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi to, ale bude schopen přilákat publikum správných hráčů?
Rozkvétá komunita kolem uživatelem generovaného obsahového dílu hry?
(Opravdu v to doufám.)
Příběh hry, nápady a otázky, které inspiruje, jsou aktuální.
Doufám, že to půjde dobře.
Je to ThinkPad den!!
Přišel jsem domů o přestávce na oběd, abych viděl tohle, jak sedím venku uwu.
Přál bych si, abych si to mohl vzít s sebou do práce a připravit další.
Ale to bude muset počkat do večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to přehnaně roztomilé až do té míry, že to byl twee?
Zcela určitě
Mluví některá z těch postav s lidmi?
Ani vzdáleně.
Ale líbilo se mi to?
Rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno promovaný umělec špatně snášel kritiku.
Částečně proto, že by je špatně učili.
Ale je důležité nevymlouvat se na problémy a prostě je napravit, zejména ve výrobě, když vaše vedení potřebuje změny.
Zvlášť s tou konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tu proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost opravit problém, nebo najít řešení.
Takže zatímco kompostování a bloom rolování jsou nádhernou připomínkou podívat se nahoru, a být si vědomi života mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak jsou semena vysévána a kultivována (a ne náhodně rozptýlena) dobrými vykuky.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu ten vzkaz podstrčil, když se míjeli na pěšině, těsně před psí hlídkou.
Ona byla na cestě ke zdi, on odcházel ze služby.
Ohlédl se za sebe, aby se podíval, jak odchází, a aby se ujistil, že je nikdo neviděl.
Neohlédla se.
Počkal, až se ocitne v temnotě ložnice, pak vytáhl lístek a přečetl si ho v paprsku světla, který pronikal zatemněnými závěsy.
Jedno slovo vytištěné blokem.
Dlouho na ni zíral a snažil se zachovat klid.
V poslední době jsem potkal nějaké úžasné nové #Mastodon kamarády a chci udržet trend.
Když volám do #Fediverse, připadám si jako velryba zpívající obrovským oceánem!
Chceš se přidat k mému „pod“?
Rád bych se spojil s dalšími.
Každý, kdo má kvůli CNN vlasy v ohni, může poděkovat Stephenu Colbertovi za tvrdou pravotočivou zatáčku.
Pomohl udělat z Chrise Lichta národní problém.
I když by se nám u některých lidí líbilo, pokud fašistům jen zajišťují kariéru v nižší lize, asi by ji měli nosit.
To bylo poprvé (ale nebude to naposledy), že Kaveesha Dilhari oba vstřelil 20 + runs & vzal 2 + wickets ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, které dosáhly všestranného úspěchu ve formátu.
Policie zatkla 15 lidí po násilném protestu před hotelem pro uprchlíky ve Velké Británii
Incident přichází poté, co se zvýšil počet uprchlíků a žadatelů o azyl, kteří se na lodích plaví přes kanál La Manche do Spojeného království.
Policie zatkla 15 lidí po protiuprchlické demonstraci před hotelem používaným k ubytování žadatelů o azyl, kteří se stali násilníky poblíž anglického města Liverpool.
Policejní oddělení v Merseyside uvedlo, že policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer v Knowsley.
Policie řekla, že nějací demonstranti házeli předměty a zapálili policejní dodávku.
Zatčení lidé ve věku od 13 do 54 let byli zadrženi „v důsledku násilných nepokojů“.
Policejní komisařka Emily Spurrellová řekla Radio City: „Bylo to neuvěřitelně nebezpečné a mezi policisty bylo pár zraněných.“
Podle místních médií využívá ministerstvo vnitra hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje Knowsleyho v britském parlamentu, řekl, že násilí v pátek večer neodráželo komunitu.
„Lidé z Knowsley nejsou bigotní a jsou vstřícní k lidem, kteří prchají z některých nejnebezpečnějších míst na světě a hledají bezpečné místo,“ řekl.
„Ti, kteří dnes večer demonstrují proti uprchlíkům, nezastupují tuto komunitu.“
Protest se konal uprostřed zvýšeného napětí, když rostoucí počet uprchlíků a migrantů přeplouval kanál La Manche v malých člunech.
V roce 2022 se touto cestou do Spojeného království dostalo více než 45 000 lidí a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se zpomalil na minimum kvůli politickým nepokojům a byrokratickým průtahům, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Přechody přes kanál La Manche se staly politickým tématem, když konzervativní vláda slíbila, že „zastaví lodě“ a uskutečňuje plán na vyslání takových žadatelů o azyl do Rwandy.
Odpůrci obviňují vládu, že démonizuje zoufalé lidi prchající před válkou a chudobou.
Prezidentův pohár: Candystripes porazili Rovers v úvodním zápase sezóny v Brandywellu
Derry záložník Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City vyšel vítězně v Poháru prezidenta, když utekl 2-0 vítězů nad Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze minulé sezóny v Brandywellu díky brankám Willa Patchinga a Michaela Duffyho z prvního poločasu.
Ve druhém poločase se hokejisté snažili snížit, ale Ruaidhri Higginsovi svěřenci si pevně stáli za výhrou.
Derry cestuje do St. Patrick's Athletic na zahájení ligy příští pátek.
Patching na straně-footed volej šťouchl Derry v přední po 23 minutách – střední záložník otevřel skóre, když Foylesider je utekl 2-1 vítězů nad případné mistry loni v únoru.
Hoops šli vyhrát Premier Division o 13 bodů, ale Duffy brzy měl City dále v čele s dalekonosným úsilím, které se podařilo vykroutit pod brankářem Leonem Pohlsem a do sítě.
V minulé sezoně to bylo o dva góly na lepší rozehrávku.
Graham Burke šel nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byli pohodlní vítězové týden před jejich cestě za národní slávou.
Šéf města Ruaidhri Higgins chválil svůj tým po tom, co řekl, že to byl „nejtěžší týden mého života“ po smrti jeho bratra Kevina.
„Je to kopanec do zubů a čekají nás těžké týdny, ale budeme s tím pokračovat v jeho paměti,“ řekl Higgins.
„Porazit Shamrock Rovers a zaslouženě s dobrým výkonem je opravdu potěšující.“
DHS najala právnickou firmu, aby se postarala o možné obvinění Alejandra Mayorkase z velezrady.
Ministerstvo vnitřní bezpečnosti si najalo externí právnickou firmu – Debevoise & Plimpton – aby pomohla v případném procesu odvolání ministra Alejandra Mayorkase, protože ten může čelit obvinění ze strany republikánů ohledně jeho manipulace s jižní hranicí.
„Ministerstvo vnitřní bezpečnosti si najalo externí poradce, aby pomohlo zajistit, že životně důležité poslání ministerstva nebude přerušeno bezprecedentními, neopodstatněnými a partyzánskými snahami některých členů Kongresu, kteří již podnikli kroky k zahájení řízení,“ uvedl mluvčí DHS v pátečním prohlášení.
„DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic a zároveň bude vhodně reagovat na více než 70 výborů a podvýborů Kongresu, které mají dohled nad DHS.“
Úředník DHS sdělil CBS News, že si oddělení najalo firmu na smluvně zajištěnou práci po dobu trvání kongresového vyšetřování.
Debevoise byl vybrán kvůli svým odborným znalostem v oblasti impeachmentu a nadstranickým zkušenostem se spoluprací s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP via Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva se společností Debevoise je pro DHS vhodným výdajem.
DHS se snaží zajistit, aby její mise nebyla ohrožena partyzánskými útoky a aby řízení proti Mayorkasovi vedli lidé s odpovídajícími odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na dotaz ohledně vyšetřování obžaloby minulý čtvrtek řekl novinářům: „Budeme s tímto kongresem spolupracovat, stejně jako jsme spolupracovali s posledním kongresem. Myslím, že to je naše zodpovědnost.“
Připustil, že „to bude nějakou dobu trvat“, než se podřídí vyšetřování Sněmovny.
„Ten čas strávím stejně jako ostatní a také nebudeme ohrožovat čas, který strávíme plněním našeho poslání.“
Vysoký úředník DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím poradcem.
Pouze jeden člen vlády byl obviněn, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S.
Trendové novinky
Díky za přečtení CBS NEWS.
Čtyři mladiství byli obviněni z útoku na 14letého mladíka, který zemřel na sebevraždu po bití video bylo zveřejněno na internetu
Táta říká, že si dcera vzala život poté, co ji šikanovali ve škole NJ.
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem čtrnáctileté dívky, která si později vzala život poté, co bylo video incidentu zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z těžkého ublížení na zdraví, dva mladiství jsou obviněni ze spiknutí s cílem spáchat těžké ublížení na zdraví a jeden mladistvý je obviněn z obtěžování, Ocean County prokurátor Bradley D. Billhimer řekl CBS News v e-mailu.
Čtrnáctiletá Adriana Kuchová byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na střední škole Central Regional High School.
Na videu bylo vidět, jak dívky házejí po mladistvé skleničku, pak ji kopou a vlečou školními chodbami.
Strčili Adrianu do červených skříněk, které lemovaly školní chodby, a jedna z dívek v růžové košili Kuche opakovaně praštila.
Jiná dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli, aby útok přerušili, a jeden dospělý od sebe odtrhával mládež.
Adriana ležela zraněná a pohmožděná na podlaze chodby, zatímco se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: „To je to, co dostaneš.“
„Milovala život. Byla nejšťastnější dítě. Všichni ji milovali,“ řekl ve čtvrtek její otec Michael Kuch stanici CBS New York a dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojující video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že policie měla být okamžitě zavolána, protože studenti, se kterými měla jeho dcera problémy, jí rozbili obličej dvacetiuncovou lahví.
„Kdyby zavolali policii a provedli vyšetřování, ty holky by nezveřejnily videa ze školy,“ řekl Kuch.
Také řekl, že jeho dcera, která měla modřiny na těle, měla být převezena do nemocnice.
„Vždy se zabýváme každým problémem šikany a v den incidentu byli čtyři studenti suspendováni,“ řekl Dr. Triantafillos Parlapanides, školní inspektor, CBS New York.
Školní úředníci řekli CBS New York, že uvědomili rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních stání, řekl prokurátor CBS News.
Studenti školy uspořádali ve středu pochod na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, o kom víte, že je v citové tísni nebo v sebevražedné krizi, můžete se dovolat na linku 988 Suicide & Crisis Lifeline telefonicky nebo prostřednictvím SMS linky 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Další informace o zdrojích a podpoře péče o duševní zdraví vám poskytne Linka důvěry Národní aliance pro duševní onemocnění (NAMI) od pondělí do pátku od 10:00 do 22:00.
ET, na 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 zdravotníky, wellness profesionály o zamezení vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v našich pracovních pozicích.
To může být pro pracovníky ve zdravotnictví nesmírně obtížné, a proto jsem položil 30 zdravotnickým a wellness odborníkům stejnou otázku: „Jak zvládáte energii a nevyhoříte ve své profesi?“
Jejich kariéra sahá od lékařů infekčních chorob přes psychology až po učitele všímavosti – a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v chodu.
I přes velké rozdíly v jejich rolích, tam bylo několik témat v jejich reakcích, které vyčnívají jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Build silnou komunitu
Jako člověk, který pracuje s pacienty s nevyléčitelnými nemocemi, děkuje Eufrosina Youngová svému silnému podpůrnému systému za schopnost udržet si energii.
Young je certifikovaný neurolog a specialista na ALS na oddělení neurologie Upstate University Hospital a říká, že se tam mobilizují jako armáda lidí.
Neexistuje lék na amyotrofickou laterální sklerózu (ALS), ale s vědomím, že není jediná, kdo dává do tvrdé práce na vývoji léčby a poskytovat lepší možnosti pro své pacienty, udržuje Young jít i na její nejtěžší dny.
„Neneseme tíhu světa, ale jsme součástí světa lidí, kteří se o tuto práci zasazují,“ říká.
2.Rest when you need to
Dvě zaměstnání jako spánkový výzkumník a algoritmický inženýr, to vše při péči o nové dítě, by rozhodně přivedlo Raphaela Vallata k vyhoření, kdyby si neodpočinul, říká.
„Mám pocit, že když se chystám vyhořet, v podstatě každý úkol mi připadá jako hora, na kterou musíte vylézt, a připadá mi to strašně naléhavé a důležité,“ říká Vallat.
V těchto chvílích „si opravdu potřebujete vzít nějaký čas volno a uvědomit si, že tyto úkoly mohou počkat.“
Vallat si obvykle najde ve svém dni chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3.Buďte zapálení pro to, co děláte a zapamatujte si svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounder 100 hodin týdně po sedm dní v týdnu.
Být v první linii během pandemie jí zabralo téměř všechen čas, ale vyhnula se vyhoření tím, že si připomněla, proč je její práce důležitá.
„Nemyslím si, že práce je jako práce, když máte pocit, že máte vliv,“ říká Gounder.
„Pokud pracujete v šílené pracovní době a děláte něco, co pro vás nemá žádný význam, myslím, že byste opravdu měli ustoupit a zamyslet se nad tím, co děláte.“
4.Have other joys
Na druhé straně každý z odborníků řekl, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce hra na kytaru.
Podle Christiny Maslachové, sociální psycholožky, profesorky psychologie na univerzitě v Berkeley a autorky knihy „The Burnout Challenge: Managing People's Relationships with Their Jobs“ je nesmírně důležité mít život, který vás baví a přesahuje to, čeho dosáhnete ve své práci.
„Podívej se na svůj život jako celek a ujisti se, že jsou na něm dobré věci, a ujisti se, že na ně máš čas.“
Získejte zdarma od CNBC Warrena Buffetta Průvodce investováním, který vydestiluje miliardářovu první nejlepší radu pro běžné investory, udělej to a nedělej to, a tři klíčové investiční principy do přehledného a jednoduchého průvodce.
Zaregistrujte se nyní: Získejte chytřejší o svých penězích a kariéře s naším týdenním bulletinem
Mladistvý obviněný z vraždy v prosincové škole v Chicagu, střelba, která si vyžádala dva mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy v souvislosti s vraždou dvou studentů na střední škole v Chicagu v prosinci, oznámila v pátek policie.
Podezřelý je obviněn ze dvou vražd prvního stupně a dvou pokusů o vraždu, oznámil ředitel chicagské policie David Brown.
„V současné době nemáme jasný motiv, proč by šestnáctiletý kluk chtěl střílet a zabíjet ostatní děti,“ řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoliv Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benito Juarez.
Oběti, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti jim pomohly dostat se k podezřelému, který byl zatčen ve čtvrtek.
„Jsme vděční za ty, kteří byli tak stateční, že se přihlásili, aby zajistili, že pachatel bude chycen a nyní bude hnán k odpovědnosti,“ řekl státní zástupce Cook County Kim Foxx.
Podezřelý by měl v sobotu předstoupit před soud v Bond Court, kde budou představeny další podrobnosti o důkazech, které shromáždili.
Minnesotští biologové zachránili chyceného černého medvěda
Minnesotské ministerstvo přírodních zdrojů přišlo zachránit medvěda nešťastného poté, co uvízl v příkopu.
Medvěd si dřepl do kanálu u silnice poblíž Wannasky v Minnesotě, jak se píše na facebooku.
Ale když sníh začal tát, kanál se začal zatápět a medvěd byl uvězněn v hlubokém sněhu a ledu, podle oddělení.
Zaměstnanci oddělení rychle zareagovali na místo činu a pomohli medvěda odstranit.
Medvědí biolog Andrew Tri medvěda „vyšetřil a prohlásil, že je zdravý, ale grogy – zřejmě proto, že byl probuzen ze zimního spánku,“ píše se na Facebooku.
Oddělení poté medvěda přemístilo do státní svatyně, aby se mohl znovu uložit k zimnímu spánku.
Ospalý masožravec byl odhadován na 6 let a mezi 375 a 400 liber.
Oddělení připomnělo obyvatelům, že stěhování medvědů je nejlepší nechat na profesionálech.
Pokud máte obavy z medvěda ve vašem okolí, měli byste kontaktovat místní úřady – ne se snažit přesunout nebo nakrmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda sami vyhrabat a nabídli mu jídlo, včetně Pop-Tarts, salátu a Fancy Feast cat food.
Ale, naštěstí pro dobře míněné kopáče, „protože medvědi nemají touhu jíst v zimě, medvěd nekousl.“
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se vyskytují hlavně v severní třetině státu, podle Ministerstva přírodních zdrojů.
Predátoři přezimují v zimě až šest nebo sedm měsíců, během nichž nejedí a žijí z uskladněného tělesného tuku.
Fotografie: Po rekonstrukcích Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedli generální tajemník Nejvyšší rady starožitností v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a předseda Španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny společnou egyptsko-španělskou archeologickou misí Nejvyšší rady starožitností a CSIC, která pracovala od roku 2002.
Řekl, že mise provedla výkopové a restaurátorské práce a publikoval výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahradu.
Významné hrobky z významné doby
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili na počátku 18. dynastie Nového království – jednoho z nejdůležitějších období starověkého Egypta.
Řekl, že uspořádání hrobek je ve tvaru písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty odpovídají vchodu, sloupové hale vedoucí k pohřební šachtě a stěnám s výraznými nápisy.
Waziri dodal, že Djehuty byl kontrolorem státní pokladny a kontroloval díla řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byl také zodpovědný za záznam Hatšepsutovy cesty do Puntlandu a za poskytnutí elektra (směsi zlata a stříbra) na pokrytí vrcholu obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces stěhování obelisků.
V místnosti, která předchází Djehutyho pohřební komnatě, jsou nápisy s vyrytými 43 kapitolami Knihy mrtvých, což je poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátno a papyrus.
Hery zastával funkci správce královských skladů posvátné královské manželky a matky Ahhotepa.
Jared O'Mara neměl být kandidátem Labouristické strany, říká Rachel Reevesová
Zneuctěný bývalý poslanec Jared O'Mara „neměl být nikdy vybrán jako kandidát labouristů“ a zaslouží si svůj čtyřletý trest ve vězení, uvedl stínový kancléř.
Rachel Reevesová v pátek hovořila s listem Guardian ve volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak celostátní výkonný výbor labouristů (NEC) kontroloval parlamentní výběrové řízení pro příští všeobecné volby.
Celá výběrová komise v Bolton North East odstoupila poté, co jim nebylo umožněno vybrat si užší výběr, což je stále častější praxe ve Straně práce Keira Starmera, která říká: „Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu.“
Dodali: „To je v rozporu s postojem nezbytným k získání zpět červené zdi, která je tak zoufale potřebná k vytvoření labouristické vlády.“
Reeves řekl: „Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybíráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.“
Obzvláště nešťastná byla skutečnost, že Leigh Drennanová, předsedkyně labouristické strany North West a poradkyně Jeremyho Corbyna podporující poslankyně za stranu Warrington North Charlotte Nicholsové, nebyla dlouho na seznamu kandidátů, aby se pokusila získat křeslo zpět od konzervativců, přestože získala nominace od čtyř velkých odborových svazů.
Reevesová řekla, že s výběrem kandidátů nemá nic společného, ale dodala: „Vím, že je opravdu důležité, abychom měli přísné postupy pro to, kdo může být vybrán na dlouhé listině a kdo může být vybrán do užšího výběru.“
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota shledala, že předložil falešné žádosti o proplacení výdajů v celkové výši 52 000 liber ve snaze financovat jeho užívání kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl labouristy řádně prověřen, když byl vybrán do souboje s Nickem Cleggem, bývalým místopředsedou liberální demokracie, v předčasných parlamentních volbách v Sheffieldu Hallam v roce 2017.
Na otázku, zda se debakl kolem O'Mary rýsuje v myslích labouristické strany NEC, Reeves odpověděl: „Nechci v žádném případě naznačovat, že někdo, kdo není na užším seznamu, je uživatel kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako kandidát Labouristické strany; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest.“
Okolnosti kolem O'Mary byly „dost výjimečné“, řekla Reevesová, ale uznala: „Labouristická strana a všechny politické strany se musí poučit z výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě řadou ministerských předsedů a pokut a stran a standardů, které značně zaostávaly za tím, co jste mohli očekávat.“
Dodala: „"Jedna věc, kterou bych o Labouristické straně řekla, je, že když lidé dělají chyby, ztrácejí bič. A to prostě není případ Konzervativní strany.“
Archie Bland a Nimo Omer vás provedou nejlepšími příběhy a tím, co znamenají, zdarma každý všední den ráno.
Oznámení o ochraně osobních údajů: Newslettery mohou obsahovat informace o charitách, online reklamy a obsah financovaný externími stranami.
Více informací naleznete v našich Zásadách ochrany osobních údajů.
Používáme Google reCaptcha k ochraně našich webových stránek a platí Zásady ochrany osobních údajů a Smluvní podmínky společnosti Google.
Reeves se měl v Boltonu setkat s učni ve školicím centru pro společnost Openreach, která poskytuje širokopásmovou síť ve Spojeném království.
Poté, co Reeves sledoval, jak učni šplhají po předstíraných telegrafních sloupech na staveništi za 1,7 milionu liber, diskutoval o plánech labouristů přepracovat učňovské dávky, které nutí větší firmy dávat stranou 0,5% z jejich výplaty na financování učňů.
Podniky si stěžují, že poplatky jsou příliš nepružné. Například, řekl Reeves, Openreach „chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vlákno, ale učňovské dávky nemají takovou flexibilitu, pokud jde o rekvalifikaci.“
Reeves řekl, že labouristé změní odvod tak, aby firmy mohly použít peníze na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a ty, které v současné době montují plynové kotle.
„Potřebujeme je jako součást přechodu energie na čistou nulu, abychom se naučili pracovat na elektrických vozidlech nebo vybavovat tepelná čerpadla nebo vodíkové kotle.
Chceme, aby tito lidé byli přeškoleni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se na ně vztahuje učňovská dávka.
Podniky chtějí větší flexibilitu a mladé lidi začínající v životě nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost,“ uvedl Reeves.
Jeden zatčený uprostřed protestu Tate Britain kvůli akci transvestitů
Jedna osoba byla zatčena uprostřed protestu u Tate Britain, kde se konala událost s vyprávěním příběhů pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasistického komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nejsou hlášena žádná zranění a policisté zůstávají na místě činu.
The Tate v sobotu hostil Drag Queen Story Hour ve Velké Británii s příběhy vyprávěnými Aidou H Dee, kterou web galerie popisuje jako „první travesti umělkyni v Evropě, která četla příběhy dětem v dětském pokoji“.
Pravicová skupina protestujících demonstrovala před galerií a setkali se s protistranami v čele s bojovníky za transpráva a politickými skupinami, včetně hnutí Stand Up to Racism.
Důstojníci museli utvořit koridor, aby se návštěvníci mohli dostat na místo.
Na Twitteru drag queen napsala, že tento den byl „řádně emocionální“ a dodala, že pět protestujících získalo přístup do Tate a „způsobilo rozruch“ v některých částech budovy, ale neovlivnilo údaje.
Už dříve řekla Pink News, že pozvání do Tate na akci během měsíce LGBTQ+ historie byla „pocta“.
Její čtení se již dříve stalo terčem protestujících.
Královna tažení prohlásila, že „vyhodnocení rizik“ proběhlo už předtím – ale dodala, že je „směšné“, že bylo nezbytné.
Aida tweetovala: „Do Tate se dostalo 5 haterů. Oni způsobili rozruch. VUT v Brně Drag Story Hour UK ...Dělali povyk jinde v budově, ne tam, kde byla show!! SHOW 2 šla jako po másle!!!“
Aida v sobotu v jedenáct hodin dopoledne, v poledne a ve dvě odpoledne uspořádala tři vypravěčské porady.
Mluvčí Tate řekl: „Neprogramujeme umělce, abychom prosazovali konkrétní názory, ani abychom slaďovali rozdílné pohledy na věc.“
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, kterým jeho aspektům se věnují.“
Trumpova ceněná 40 Wall Street Building On 'Lender Watch' Amid Dropping Income: Report
Silně zadlužený mrakodrap Donalda Trumpa na 40 Wall Street je na „věřitelské hlídce“ uprostřed prudce klesajících příjmů a zvyšujících se nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72-patrové budově – Trump je nejcennější – vyskočil na téměř 18% ve třetím čtvrtletí loňského roku, podle měsíčního podání na budově je zbývající 126.5 milionů dolarů hypotéky, Bloomberg uvedl.
Výdaje přitom údajně vzrostly o 11% od vzniku hypotéky z roku 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků 11. září 2001, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chvástal, že Wall Street 40 je náhle nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, ale byla to také lež.
Další nedaleký mrakodrap na Pine Street v Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem kancelářských budov na Manhattanu už léta klesá, což se ještě zhoršilo po vypuknutí pandemie COVID-19, kdy mnoho společností ukončilo činnost a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, „oslovila dlužníka o status leasingové výstavby“ a plány na zlepšení výkonnosti nemovitosti, podle podání, Bloomberg uvedl.
Majitel firmy Wagner tvrdí, že válka na Ukrajině se potáhne roky.
Majitel ruské Wagnerovy skupiny, soukromý vojenský dodavatel aktivně zapojený do bojů na Ukrajině, předpověděl, že válka by se mohla táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek řekl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny Donbasem.
Dodal, že válka může trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpru.
Prohlášení milionáře Prigožina, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván „Putinovým šéfkuchařem“ pro své lukrativní zakázky na stravování v Kremlu, znamenalo uznání potíží, s nimiž se Kreml potýkal v kampani, kterou původně očekával ukončit během několika týdnů, kdy ruská vojska 24. února vtrhla na Ukrajinu.
Rusko na podzim utrpělo řadu ponižujících nezdarů, když ukrajinská armáda zahájila úspěšné protiofenzívy s cílem získat zpět široké pásy území na východě a jihu.
Kreml se vyhnul prognózám, jak dlouho by boje mohly pokračovat, a prohlásil, že to, co nazval „speciální vojenskou operací“, bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří Donbas, kde od roku 2014 bojují separatisté podporovaní Moskvou proti ukrajinským silám.
Prigožin prohlásil, že žoldnéři Wagnerovy skupiny pokračují v zuřivých bojích o kontrolu nad ukrajinskou pevností Bakhmut v Doněcké oblasti.
Uznal, že ukrajinské jednotky stupňují zuřivý odpor.
V době, kdy ruské jednotky přitlačily k útokům na Donbase, se Moskva také snaží Ukrajince demoralizovat tím, že je v kruté zimě ponechá bez tepla a vody.
Rusko v pátek zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Ve východních, západních a jižních regionech byla zasažena infrastruktura vysokého napětí, což v některých oblastech vedlo k výpadkům proudu.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale kontrolovatelná“, a dodala, že se jedná o zálohování, aby se udržely dodávky energie, ale poznamenala, že přídělový systém bude v některých oblastech pokračovat.
Náčelník ukrajinské armády generál Valerij Zalužnyj uvedl, že ruské síly odpálily od čtvrtka do pátečního poledne 71 střel s plochou dráhou letu, 35 střel S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět bezpilotních letounů.
Ukrajinské úřady později v pátek ohlásily další útoky zabijáckých bezpilotních letounů.
Ukrajinské letectvo uvedlo, že armáda sestřelila 20 bezpilotních letounů Shahed ve večerních hodinách.
V pátek pozdě večer zveřejnili ruští vojenští bloggeři a některé ukrajinské zpravodajské servery video ukazující útok námořního bezpilotního letounu na strategický železniční most v Oděské oblasti.
Zrnité video zachycovalo rychle se pohybující objekt, který se blížil k mostu v Žatci, asi 50 kilometrů jihozápadně od Oděsy, a explodoval silným výbuchem.
Pravost toho videa nemohla být ověřena.
Ukrajinská armáda útok nekomentovala a Serhij Bratchuk, mluvčí regionální správy, útok dronů nepotvrdil, když v sobotu hovořil v televizních komentářích.
Most, který byl na počátku války cílem ruských raketových útoků, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM – Kazašští záchranáři pokračují v prohledávání sutin a pátrají po přeživších v Türkiye, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství trosek a nestabilních konstrukcí.
Kazašský záchranný tým odtamtud vytáhl sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte, v Türkiye.
První lékařská pomoc je poskytována také nepřetržitě.
Zemětřesení o síle 7,7 stupně Richterovy stupnice, které zpustošilo části jihovýchodního Türkiye a severní Sýrie, udeřilo v pondělí.
K dnešnímu dni počet obětí mohutných otřesů na jihovýchodě Türkiye přesáhl 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls k rozvoji atletiky
ASTANA.KAZINFORM – Zahajovací ceremoniál 10. halového mistrovství Asie v atletice se konal v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského předsedy vlády.
Předseda kazašské vlády při zahájení akce přečetl uvítací dopis prezidenta Kassym-Jomarta Tokajeva.
„Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je v Kazachstánu věnována sportu.
V naší zemi existují všechny podmínky pro provozování profesionálního a masového sportu.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je atletický komplex, kde sedí přes šest tisíc lidí,“ stojí v dopise kazašského prezidenta.
Kazašští atleti úspěšně závodí a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání asijského mistrovství v Astaně dá nový impuls rozvoji atletiky v zemi a zaváže se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smajlov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za jeho pomoc při přípravě a pořádání šampionátu.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaje se zúčastnilo více než 500 sportovců z 31 zemí, kteří se utkají v závodě, štafetovém závodě, skoku dalekém, skoku vysokém, trojskoku, skoku o tyči, vrhu koulí a vůbec.
Turnaj bude probíhat do 12. února.
Podle dřívějších zpráv vyhrála kazašská běžkyně Caroline Chepkoech Kipkiruiová zlato v běhu na 3000 metrů a Olga Safronovová si na turnaji připsala stříbro v běhu na 60 metrů.
Foto: primeminister.kz
Herec z Yellowstonu Q'orianka Kilcher čelí obvinění z podvodu.
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském senzačním procesu s pomluvou, dosáhla dalšího právního vítězství – tentokrát s hercem z Yellowstonu Q'oriankou Kilcherem.
V pátek prokurátor okresu Los Angeles očistil dvaatřicetiletého Kilchera ze všech obvinění v případu podvodu s odškodněním dělníků.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora Los Angeles uvedl, že soud „určil, že paní Kilcherová nespáchala pojistný podvod a oznámil soudu, že nejsme schopni pokračovat“.
V červenci 2022 kalifornské úřady obvinily Kilchera ze dvou podvodů s odškodňováním pracovníků, obvinily ji z toho, že od října 2019 do září 2021 nezákonně inkasovala více než 96 000 dolarů v invalidním důchodu.
Časový rámec také zahrnuje několik měsíců, kdy Kilcher pracovala na seriálu Yellowstone, navzdory tomu, že herec tvrdil, že byla příliš zraněná, než aby mohla pracovat.
Kilcher se sám vzdal a v květnu byl obžalován.
„Dnes jsem více než vděčný, že můj případ byl zamítnut – zítra začíná moje cesta, která má pomoci zvýšit povědomí a požadovat větší transparentnost práv pracovníků v rámci zaměstnaneckého počítačového systému“ řekl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že „se těší na to, až tuto zkušenost více osvětlí a bude pokračovat v práci, kterou miluji“.
Kilcher také poděkoval Vasquezové a jejímu kolegovi Stevu Cookovi za „jejich neochvějnou víru v mou nevinu“.
Podle TMZ si je Kilcher najal v září.
V roce 2002 se objevila ve filmu Terrence Malicka Nový svět, kde ztvárnila Pocahontas.
Mezi její kredity patří také „Sons of Anarchy“, „The Alienist“ a „Dora and the Lost City of Gold“.
Naposledy se objevila v road-trip filmu „Pes“ s Channingem Tatumem v hlavní roli.
K této zprávě přispěla i redaktorka Timesů Christina Martinezová.
Šéf Balenciaga nazval prázdninovou kampaň „hloupou chybou“
Luxusní oděvní značka Balenciaga se stále vzpamatovává z kritiky dvou svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal pod palbu reklamních obrázků, které podle kritiků sexualizovaly děti, umělecký ředitel Balenciaga Demna (celým jménem Demna Gvasalia) v rozhovoru pro časopis Vogue, který vyšel v pátek, řekl, že je mu těchto obrázků stále líto.
„Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro nadační kampaň s dětmi a beru za to svou zodpovědnost,“ řekl pro Vogue v reakci na předchozí prohlášení, které v prosinci zveřejnil na sociálních sítích.
V listopadu značka sdílela fotky pro svou kolekci „The Gift“, kde pózovaly dětské modelky s plyšovými medvídky, oblečenými do bondage.
Krátce nato Balenciaga stáhla fotografie pro svou kampaň na jaře 2023, na nichž byla stránka z případu Nejvyššího soudu z roku 2008, který se týkal „virtuální dětské pornografie“ v pozadí.
Rodiče, včetně hvězdy reality show a dlouholeté fanynky Balenciaga – a partnerky značky – Kim Kardashian, se na sociálních sítích vyslovili proti značce a jejím „znepokojivým obrázkům“.
O několik dní později Balenciaga vydala prohlášení, v němž se za fotografie omluvila a nastínila změny, které provede, aby se vyhnula podobným „chybám“ v budoucnu.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s našimi posluchači, a ve způsobu, jakým se učíme z našich chyb a jdeme kupředu,“ řekla Demna pro Vogue.
Podrobně popsal změny v Balenciaze: „restrukturalizace image oddělení“, provádění více interních a externích kontrol pro snímky z kampaní a partnerství s Národní dětskou aliancí na pomoc „tisícům dětí v procesu překonávání traumat a vyrovnávání se s jejich duševním zdravím“.
„Je to jediná věc, která mě na celé téhle hrozné situaci těší: udělat z toho něco dobrého,“ řekl o partnerství, které bylo oznámeno ve středu.
S NCA spolupracuje také mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod deštníkem Kering je Gucci, který v prosinci čelil kritice za kampaň s Harrym Stylesem, o které někteří kritici na sociálních sítích tvrdili, že také sexualizuje děti.
V rozhovoru Denma řekla, že se hodlá odklonit od „provokativních“ způsobů značky.
„Je to součást mého učení: budu mít zralejší a vážnější přístup ke všemu, co vypustím jako myšlenku nebo obraz,“ řekl.
„Rozhodla jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciagy, která vyrábí kvalitní oblečení – nedělá image ani bzukot.“
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jednou z „nejbolestivějších“ částí odporu bylo pošpinění „jména Balenciaga a odkazu Cristóbala Balenciagy“.
„Balenciaga je dům, který je více než jedno století starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem byl zaneprázdněn dělat vše, co je v mých tvůrčích silách, aby to moderní význam, a najednou jsme byli pod útokem a označeni jako něco, co vůbec nejsme,“ řekl Demna.
„Určitě jsme udělali obrovskou a hloupou chybu s kampaní na dárky a určitě jsme se z toho poučili.“
Je to falešné zprávy, CBN Debunks tvrdí, že postrádá kapacitu k tisku více nových poznámek Naira
Nigerijská centrální banka (CBN) označila za zavádějící zprávu, která tvrdila, že cituje Godwina Emefieleho, guvernéra CBN, který současný problém v distribuci nově přepracovaných bankovek Naira připisuje nedostatku tiskových materiálů v Nigerian Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu, mluvčí CBN, Osita Nwasinobi, řekl v žádném okamžiku, CBN guvernér učinil takové prohlášení během jeho prezentaci na Národní rady státu na zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele pouze sdělil, že NSPMC pracuje na tisku všech nominálních hodnot Naira, aby byly uspokojeny transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy, které všechny zúčastněné strany projevují ohledně distribuce nových poznámek Nairové, „jsme znepokojeni tím, do jaké míry se partikulární zájmy pokoušejí manipulovat fakty a poštvat veřejnost proti bance“.
Nwasinobi řekl, že CBN je nadále odhodlána vykonávat své funkce v oblasti měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (v platném znění).
„Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálu pro výrobu požadované odrážky Nairy.
„Banka proto chce apelovat na veřejnost, aby nebrala zmíněnou zprávu v potaz a zachovala větší zdrženlivost, i když vytrvale pracujeme na zvýšení oběhu nových bankovek v zemi,“ dodal.
Na zvláštní hlasovou notu, která se objevila na sociálních médiích a tvrdila, že CBN plánuje uzavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že takový plán neexistuje a že tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
„Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický záměr CBN a jsou jen zoufalými pokusy osob, které se snaží veřejnost proti bance poštvat,“ uvedl.
Tim Sherwood slzy do £ 44 m podpis Pedro Porro po skličující Tottenham debut
Porro měl odpoledne zapomenout proti Leicesteru (Obrázek: Getty)
Tim Sherwood se pustil do „absolutně nechutného“ bránění Pedra Porra během porážky Tottenhamu s Leicesterem City 4:1.
Spurs podepsal právo-back od Sporting CP v den uzávěrky přestupů na počáteční úvěr na 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
Třiadvacetiletý hráč byl předán jeho debut Antonio Conte v sobotu na King Power Stadium a jeho strana se vedení po 14 minutách přes Rodrigo Bentancur.
Ale to se změnilo v mizerné odpoledne s Nampalys Mendy, James Maddison a Kelechi Iheanacho všechny skóre dát Leicester 3-1 v poločase s Porro snášet žhavý první poločas v Premier League.
Španěl byl na vině znovu jako Leicester si myslel, že přidal čtvrtý prostřednictvím Barnes a zatímco gól byl vyloučen pro ofsajd, bývalý Spurs manažer Sherwood zůstal šokován plzeňské defenzivní úsilí.
„Nechci se do toho kluka pořád navážet, ale musí být zbaven svých povinností,“ řekl Sherwood fotbalistům v sobotu.
Dám mu za pravdu, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho pozice je naprosto nechutná, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden říkal, že utratili hodně peněz, ano, ale jejich nábor byl velmi špatný a toto je poslední přírůstek.
Nedělejme teď žádné závěry, ale to, na co se dívám, je hráč, který nechce bránit.
Více: Premier League
„Antonio Conte si stěžoval na bránění a tento hráč se momentálně snaží bránit. Stojí proti velmi dobrým hráčům Barnesovi a Maddisonovi, ale je to velké zklamání.“
Zatímco gól byl vyloučen, Leicester obnovena jejich 4-1 vedení s Barnes na cílové devět minut od plného času.
Navzdory porážce Manchester City minulý týden, Tottenham promarnil šanci posunout se před Newcastle na třetí místo.
Jimmy Floyd Hasselbaink řekl Chelsea, aby nepodepsala smlouvu s Joaem Felixem a místo toho šla za hvězdu Tottenhamu.
VÍCE: Tottenham se chystá ucházet o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost odkupu
Pro více takových příběhů se podívejte na naši sportovní stránku.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoliv boj o privilegia kvůli předvolání Mika Pence.
Zpráva, že zvláštní zástupce Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak bude tým Trump využívat soudy, aby zkazil poslední vývoj vyšetřování ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus o potopení Penceova předvolání na základě výsad výkonné moci by měl selhat.
Za prvé, je tu prahová otázka, zda bývalý prezident vůbec může nárokovat tuto výsadu.
Připomeňme si, že Trump se snažil a nepodařilo zablokovat sněmovní komisi 6. ledna získat záznamy z Bílého domu.
Nejvyšší soud se loni odmítl Trumpovým odvoláním zabývat, s čímž nesouhlasil pouze soudce Clarence Thomas (manžel odpíračky voleb v roce 2020 Ginni Thomasové).
Soud však ponechal otevřenou otázku, zda si bývalý prezident může nárokovat privilegia, když soudce Brett Kavanaugh naznačil, že by takové právo podpořil.
Je tedy přinejmenším nejasné, zda si bývalý prezident může tuto výsadu nárokovat, aniž by se zmiňoval o tom, zda by tento nárok uspěl.
Navíc odvolání k Nejvyššímu soudu kvůli snaze tehdejšího prezidenta Richarda Nixona vyhnout se vyhovění předvolání ukazuje, že vágní privilegované tvrzení nestačí a může být překonáno specifickou potřebou důkazů.
Soud v roce 1974 v případu Spojené státy versus Nixon konstatoval:
... pokud je důvod pro uplatnění výsady, pokud jde o předvolané materiály, které mají být použity v trestním řízení, založen pouze na všeobecném zájmu o důvěrnost, nemůže převážit nad základními požadavky řádného soudního řízení při spravedlivém výkonu trestního soudnictví.
Zobecněné uplatňování privilegií musí ustoupit prokázané, specifické potřebě důkazů v probíhajícím trestním řízení.
Proto je precedens na straně vlády.
Samozřejmě, že odklady od projednávání i prohraného sporu mohou být pro Trumpa určitým vítězstvím.
Ale další tlumení šancí na úspěšné privilegium nárok je předchozí odmítnutí Trumpova pokusu zablokovat 6. ledna velkou porotu svědectví.
Jak v říjnu napsal deník The Washington Post, toto odmítnutí poznamenalo, že například bývalý Pencův poradce Marc Short „pravděpodobně vlastnil informace důležité pro trestní vyšetřování útoku na Kapitol ze 6. ledna 2021, které nebyly dostupné z jiných zdrojů“.
To, že i Pence má unikátní informace, by ministerstvu pomohlo v případném boji o předvolání.
A důvod, proč si myslíme, že Pence takové informace má, je další důvod, proč by měl nárok na privilegia selhat.
To proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Těžko říct, že komunikace je privilegovaná, když jste ji předtím považovali za vhodnou pro publicitu.
A tak zatímco by obsílka mohla předložit různé politické a osobní propočty pro Pence – který by se mohl ucházet o republikánskou nominaci v roce 2024 proti Trumpovi, někoho, kdo účinně schvaloval výzvy k Penceově mimosoudní popravě 6. ledna – soudy by měly mít co dělat, aby se postavily na stranu ministerstva spravedlnosti.
The Case Against a Biden Run Is Obvious – and Weak
Proč je to důležité?
I když Biden a jeho kolegové demokraté nemohou dělat mnoho v cestě při schvalování zákonů s GOP v ovládání sněmovny, stále mohou strávit příští dva roky dávat příklad.
Kolektivně, každý v týmu by měl vyhledávat příležitosti hrát Gallant na republikány „divné Goofus impulsy.
Ale je také důležité, aby si Biden vylepšil svou důvěryhodnost u amerického lidu – a možná byl zoufale potřebným hybatelem změn v naší až příliš plytké politické kultuře.
Washington, notoricky cynické místo, je proslulý svými názory na vůdcovství, které ochromují zdravý rozum.
Snad jedním z nejznámějších je podivný standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že by politici měli zajít do komických krajností, aby se tomu vyhnuli.
Existuje i jiný způsob: v knize Bailout, ve vzpomínkách Neila Barofského z doby, kdy sloužil ve Washingtonu jako zvláštní generální inspektor dohlížející na program pomoci problémovým aktivům, popsal radu, kterou dostal od Kristine Belislové, ženy, kterou si šikovně najal jako ředitelku komunikace.
Bylo to asi tak anti-Washington, jak to může být: „Přiznáme a dokonce zvýraznit naše chyby.“
Jak dále vysvětlovala, ve strategii je metoda, kterou by většina lidí v Beltway považovala za šílenství:
Tohle je nejlepší způsob, jak si získat důvěru tisku.
Poznají, že se netočíme jako ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o TARP ve Washingtonu.
Možná se občas ztrapníme a prozradíme věci, které bychom mohli – a ostatní by to snadno skryli, ale svou upřímností šokujeme tisk.
Nikdo jiný to nedělá a zanedlouho budeme mít vybudovanou obranu, až na nás zaútočí.
Bez ohledu na to, co uslyší, tisk přijde nejdřív za námi a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč se Biden vydal cestou radikálního přebírání odpovědnosti: v každém prezidentském úřadu nevyhnutelně nastanou okamžiky, kdy je důvěra veřejnosti a institucí, které chrání občanské zájmy, kritická.
Navíc je tu životně důležitý kapitál, který se dá získat vlastnictvím našich chyb, a je tu důležitý rozdíl, který může Biden se svými politickými oponenty udělat.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: Řekni pravdu– a zahanbi ďábla.
Pár reklam na Super Bowl, na které se nemůžu dočkat.
Hvězda sitcomu z devadesátých let si zopakuje svou milovanou roli, aby vám prodal pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, který rozšíří dvanáctivteřinovou scénu na deset sezón.
Všechny celebrity z loňských kryptografických reklam se omlouvají za své kryptografické reklamy.
Tihle „whassup“ kluci, ale jde o to, že teď jsou staří.
Všichni teď jedou v kdoví čem, že?
Série reklam režírovaných Rianem Johnsonem, kde když zjistíte, kdo vraždil, dostanete slevu na roční pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativní kluci týden zuřit.
Timothée Chalamet v jisté funkci.
Někdo, kdo byl údajně navždy zrušen, aby se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte, na kterou se určitě podíváte, až se bude za tři týdny vysílat.
Nesnesitelně chytlavá nová znělka, kterou si budeš zpívat roky.
Recyklovaný vtip na Twitteru před dvěma měsíci.
Muzikant, který se chová jako kontrakultura, který vám kontrakulturně říká, ať jdete do banky s Wells Fargo.
Kluk se zoomem, ale jde o to, že už je dospělý.
Biden DOJ „Nechce ozbrojeného občana“
Rektor Andrew Clyde (R-GA) se ve čtvrtek sešel s Breitbart News a diskutoval o svých plánech na zablokování pravidla ATF o pistolových výztuhách a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti vůbec nechce ozbrojené občany.
Clyde dal jasně najevo svůj nesouhlas s pravidlem pistole.
Důvody tohoto nesouhlasu jsou jak obecné, tak konkrétnější.
Obecně vyjádřil své přesvědčení, že naši Otcové zakladatelé nepředložili plán vládnutí, který by zahrnoval federální agentury vytvářející zákony namísto zákonodárného sboru.
Řekl: „Ministerstvo spravedlnosti je tu od toho, aby prosazovalo právo, ne aby ho vytvářelo. Když máte výkonnou moc, která dělá zákony a prosazuje je, pak máte krále a království. Naši zakladatelé nepožadovali krále a v Ústavě Spojených států nenavrhli žádné království.“
Clyde poté přešel k detailům týkajícím se pravidla držení pistole a vyjádřil obavu, že toto pravidlo je součástí většího úsilí ATF o získání širší registrace střelných zbraní.
Poznamenal: „ATF chce zvýšit evidenční databázi pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co předchází konfiskaci, je registrace. A konfiskace je podle mého názoru konečný cíl, protože toto ministerstvo spravedlnosti nechce ozbrojené občany.“
„Ale tohle ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby po nás mohli jít.“
Clyde tvrdí, že pravidlo o pistolích ATF se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní a hodlá s tím bojovat zuby nehty.
Řekl, že má „tři nástroje“, kterými může proti pravidlu bojovat.
Prvním z těchto nástrojů je SHORT Act a druhým je Congressional Review Act.
30. ledna Breitbart News citoval Clydea, který nastínil svůj plán na „znovuzavedení zákona Stop Harassing Owners of Rifles Today Act, neboli KRÁTKÉHO zákona, který by zrušil prvky zákona o střelných zbraních, čímž by zakázal ATF registrovat a zakazovat pistole se stabilizačními výztuhami“.
Poznamenal také, že „předloží usnesení o nesouhlasu podle zákona o kongresovém přezkumu, aby přehlasoval nezákonné překročení pravomocí Bidenovy administrativy“.
Oba zákony, SHORT Act a Congressional Review Act, mají možnost blokovat pravidlo ATF pistol brace.
Ale jak Clyde řekl Breitbart News Thursday, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, buď k přijetí zákona SHORT Act, nebo k finalizaci řešení nesouhlasu podle zákona kongresu.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa KRÁTKÉHO aktu by mohla být přidána k dalším, větším návrhům zákonů, o jejichž schválení demokraté velmi usilují.
Nicméně, Clyde naznačil, že existuje ještě třetí způsob, jak blokovat pravidlo ATF pistol brace.
Řekl: „Jsem v rozpočtovém výboru a můžeme zrušit toto pravidlo o pistolových výztuhách, prostřednictvím toho, čemu se říká omezující dodatek. Můžeme doslova popřít toto pravidlo a v podstatě říci, „Žádné peníze nesmí být vynaloženy na vykonání nebo prosazování tohoto konkrétního pravidla pistole podpěry.“
A to samé můžeme udělat s pravidlem ATF receiver/frame z loňského srpna.
Myslím si, že oba musí být zneškodněni, a těším se na spolupráci s našimi přivlastňovateli.
AWR Hawkins je oceňovaný sloupkař Druhého dodatku pro Breitbart News a spisovatel/kurátor časopisu Down Range pro AWR Hawkins, týdeník zaměřený na vše, co se týká Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem v USA na Turning Point.
AWR Hawkins je držitelem doktorátu z vojenské historie se zaměřením na válku ve Vietnamu (hnědé vodní námořnictvo), americké námořnictvo od Počátku, občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se přihlásit k odběru Down Range na breitbart.com/downrange.
Spojte se s ním přímo na awrhawkins@breitbart.com.
„Doufáme, že“ Biden má plán, jak zvládnout titul 42 Konec, „pokud ano, tak ho plně nesdíleli“
Jared Polis (D) v pátečním vydání NBC „MTP Now“ řekl, že má „velké obavy“ z toho, co se stane, až Hlava 42 v květnu skončí, doufá, že Bidenova administrativa má plán, kdy tato politika skončí, a že „pokud ano, ještě ho s námi plně nesdíleli.“
A řekl: „Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili.“
Polis uvedl, že by si přál, aby během setkání guvernérů v Bílém domě bylo věnováno více času otázce přistěhovalectví, ale tato otázka „přišla na přetřes“.
Měli jsme tam částečně I ministra Mayorkase.
A tak jsme znovu nadnesli, že je tu spousta obav, které sdílím ohledně toho, co se stane, až Hlava 42 v květnu skončí, a tak se ujišťujeme, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě se nám o to plně nepodělili.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pětkrát nebo třikrát, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu vládu.
Ian Hanchett na Twitteru @IanHanchett
McDonald's stahuje „nevkusnou“ reklamu u krematoria – RT World News
McDonald's se omluvil poté, co reklama na hamburger „McCrispy“ řetězce rychlého občerstvení byla umístěna v blízkosti krematoria ve Velké Británii – i když někteří místní obyvatelé viděli tu vtipnou stránku.
Řetězec restaurací se zavázal, že na základě stížností obyvatel města Truro v hrabství Cornwall ve Spojeném království odstraní urážlivé reklamní poutače.
V pátek si získala pozornost na sociálních sítích tím, že byla umístěna na rušnou silnici přímo proti zařízení, které nabízí kremační služby.
Jasně osvětlený inzerát, který byl umístěn přímo za cedulí ukazující na krematorium, byl některými rozhněvanými místními obyvateli označen za „nevkusný“.
„I když vidím tu legrační stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou chtít vidět, až navštíví Penmount na pohřbu a kremaci milované osoby,“ řekl obyvatel, jehož tchyně byla loni v pohřebním ústavu zpopelněna, jak citovala britská média.
Nicméně ne všichni byli tak pohoršeni nešťastným umístěním reklamy, jeden poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, „jak dávno jsi sledoval krematorium s černou kravatou.“
Jeden člověk řekl, že „spadl ze židle smíchy“, když viděl inzerát na internetu, zatímco to bylo také poznamenal další místní, že to nebylo „o nic horší“ než rozhodnutí rady zabývat se myšlenkou, aby krematorium bylo postaveno „vedle domova důchodců“.
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek krátce poté, co se na internetu objevila fotografie reklamy, v níž řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
„Nevšimli jsme si dopravní značky v blízkosti této autobusové zastávky. Nicméně s ohledem na obavy, které vznesla společnost CornwallLive, jsme požádali o odstranění naší reklamy,“ uvedla značka rychlého občerstvení.
Cornwallská radnice, která provozuje krematorium i autobusový přístřešek, který inzerát zobrazuje, komentář k rozruchu odmítla, když ji kontaktovala místní média.
'Gut instinkt' pohřešovaná žena není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové vstoupilo do 16. dne poté, co její partner řekl, že jeho „instinkt“ je, že není v řece.
Policie v Lancashire uvedla, že policisté mají „otevřenou mysl“ a zároveň nadále žádají informace o slečně Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael's na Wyre.
Síly pokračují v prohledávání řeky Wyre směrem k moři v zátoce Morecambe a pracují s jednou hypotézou, že pětačtyřicetiletý muž z Inskipu tam mohl spadnout.
Při pátrání jim pomáhali specialisté a potápěči z pobřežní stráže HM, horské záchranné služby a požární a záchranné služby v Lancashiru, nasazeni byli i čmuchací psi, drony a policejní vrtulníky.
Slečna Bulleyová zmizela při procházce se svým špringršpanělem Willowem u řeky krátce poté, co své dcery ve věku šesti a devíti let vysadila ve škole.
Telefon hypotečního poradce byl nalezen na lavičce nad řekou, stále připojený k pracovnímu hovoru.
Její partner, Paul Ansell, řekl, že chce nechat „všechny možnosti otevřené“ ohledně jejího zmizení, ale jeho „instinkt“ mu říká, že není v řece.
Popsal slečnu Bulleyovou jako „zábavnou“, „milující“, „nejvěrnější přítelkyni, kterou můžete kdy mít“ a „výjimečnou matku“, která „naprosto zbožňuje naše dívky“.
„Je jen pilířem síly naší rodiny a bez ní je ta díra větší, než si vůbec dokážete představit,“ řekl pro 5 News.
Pan Ansell řekl, že ačkoliv rodina prochází „bezprecedentním peklem“, naděje, že jeho partner bude nalezen, je „silnější než kdy předtím“.
Policie nepovažovala trestný čin za trestný čin a incident vyšetřuje jako pohřešovanou osobu.
Ve čtvrtek se jejich pátrání přesunulo ze St Michael's asi 10 mil po proudu, kde se řeka vlévá do moře v zátoce Morecambe, přičemž v oblasti byly spatřeny hlídkové a záchranné čluny.
Poslední komunistický vůdce ve východním Německu zemřel v 95 letech.
BERLÍN (AP) – Zemřel Hans Modrow, který byl posledním komunistickým vůdcem východního Německa během bouřlivých voleb, které skončily prvními a jedinými svobodnými volbami v zemi.
Bylo mu 95.
Modrow zemřel v sobotu, parlamentní skupina Levice tweetnul.
Reformně smýšlející komunista Modrow převzal vládu nad východním Německem krátce po pádu Berlínské zdi a později přizval do vlády opoziční síly, ale nemohl zpomalit nabírání dynamiky pro sjednocení Německa.
„Celý mírový průběh nastolení jednoty Německa byl právě jeho mimořádným úspěchem,“ napsala levice na Twitteru."To zůstane jeho politickým odkazem.“
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst antiestablishmentové osobnosti.
Odmítl stranické výhody a trval na tom, že bude bydlet v normálním bytě.
Funkce v nejvyšším vedení východního Německa mu unikala, dokud se v listopadu 1989 – několik dní po pádu Berlínské zdi – nestal premiérem, což byla pozice, která předtím měla jen malý vliv.
Když na začátku prosince odstoupil vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, stal se Modrow vrcholnou politickou osobností východního Německa.
Ale komunisté už nemohli sami rozhodovat.
Následující měsíc souhlasil s tím, že se bude dělit o moc se stále hlasitější opozicí, a posunul první svobodné volby ve východním Německu na březen 1990, uprostřed rostoucích nepokojů.
I když prodemokratické manifestace rychle nabývaly na příchuti sjednocování, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na jednání se Západním Německem o případné „jednotné vlasti“, která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow vedl volební kampaň přeškolených komunistů, Strany demokratického socialismu, ale jeho osobní popularita nebyla dostatečná, aby zabránila tomu, aby skončili jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé sjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS – předchůdce dnešní opoziční levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho dostala před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků komunálních voleb v Drážďanech v květnu 1989.
Dostal za to devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozpory mezi východními a západními Němci.
Jeho obhájce tvrdil, že dohlédnutím na svobodné volby předsedy vlády napravil předchozí nespravedlnosti.
Později v životě Modrow sloužil v radě starších strany Levice.
„Hans byl hluboce upřímný a bojovný socialista,“ tweetoval Dietmar Bartsch, předseda parlamentní skupiny Levicové strany.
„Až do stáří byl důležitým rádcem naší strany, jehož moudrost bude postrádána.“
Indická vláda po kritice stahuje odvolání k objímání krav na Valentýna
Objímání krávy na Valentýna už indická vláda nepovzbuzuje – navzdory tomu, že dříve žádala lidi, aby tak činili a prosazovali hinduistické hodnoty.
Indický úřad pro ochranu zvířat (Animal Welfare Board of India, AWBI) stáhl svou výzvu „Cow Hug Day“ poté, co vyvolala kritiku ze strany politických rivalů a uživatelů sociálních médií.
Indická vláda vyzvala občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay prohlásil, že volání po objetí krav bylo „naprosto šílené, odporující logice“.
Dodal, že rozhodnutí stáhnout odvolání bylo spíše „zabránit tomu, aby politika hindutvského [hinduistického nacionalismu] byla zesměšňována tváří v tvář tvrdé kritice ze všech stran“.
AWBI v pátek své odvolání popřela a prohlásila, že „je stažena“.
Bylo to teprve ve středu, kdy jeho prohlášení znělo, že „objímání krav [by] přineslo citové bohatství a zvýšilo individuální a kolektivní štěstí.“
Další informace o Indii
Doplnil, že kráva je „páteří indické kultury a venkovské ekonomiky... pro svou výživnou povahu jako [matka].“
Na úvodní oznámení byly reakce smíšené, když někteří zveřejnili videa, na nichž krávy odmítají objetí a ženou se pryč.
Jiní chtěli objasnit, že apel byl spíše na následování vlastní kultury, na rozdíl od „slepého“ následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Mazlení s krávou také není nic nového – s tím, že je považován za terapeutický v některých částech světa, a v Nizozemsku, kde je známý jako „koe knuffelen.“
Oddaní hinduisté uctívají krávu – známou jako gau mata, nebo „matka kráva“ – a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie podnikali razie v obchodech s valentýnskými předměty, pálili pohlednice a dárky a vyháněli páry držící se za ruce z restaurací a parků s tím, že tento den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu upevnit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosadila hinduistickou agendu a usiluje o nadvládu tohoto náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinisté představují většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeath, muž zatčen
Chodec zemřel po srážce s autem ve Fife.
Osmatřicetiletá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeathu v pátek kolem 13:30.
V souvislosti s havárií byl následně zatčen 24letý muž.
Policie žádá svědky nebo kohokoliv, kdo má záznam z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: „Naše vyšetřování pokračuje a žádáme každého, kdo byl v oblasti a kdo byl svědkem havárie, aby se ozval.“
Také bych apeloval na každého, kdo řídil v této oblasti a kdo by mohl mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
„Žádáme všechny, kteří mohou pomoci, aby zavolali Policii Skotska na číslo 101, citujeme incident číslo 1638 z pátku 10. února 2023.“
IN NUMBERS: Města Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když započítáme osoby narozené v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, se zvýší na více než třetinu.
Největší skupinu přistěhovalců tvořili v Oslu občané z Asie, včetně Turecka, přičemž podle údajů národní datové agentury Statistics Norway (SSB) jich ve městě žilo více než 62 985.
Poté tvořili druhou největší skupinu občané z EU, EHP a Spojeného království, kteří tvořili necelých 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, v Oslu žilo 28 020 lidí z Afriky.
Čtvrtou nejpočetnější skupinou byli Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, což představovalo 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen necelých 7000 občanů ze zemí Jižní Ameriky, zatímco ze Severní a Střední Ameriky pocházelo jen o maličko více než 3000 státních příslušníků.
Mezitím v Oslu žilo necelých 700 lidí z Oceánie.
Alna na severovýchodě města byla čtvrtí s nejvíce zahraničními obyvateli.
V roce 2022 zde žilo přibližně 18 257 cizinců.
Trendy Grünerløkka, nacházející se přiměřeně v centru města, měla druhý nejvyšší počet zahraničních rezidentů, a to 17 631.
Gamle Oslo mělo také významnou populaci imigrantů, 17 631 lidí tam žilo poté, co se přestěhovali z jiné země.
Statistika Údaje Norska ukázaly, že cizinci byli roztroušeni po všech městských obvodech, protože Søndre Nordstrand, okres ležící jižně od Osla, měl registrováno více než 14 000 imigrantů.
Mnoho imigrantů také žilo ve vyhledávaných oblastech, protože Frogner byl okres s pátým nejvíce cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek z deseti okresů v Oslu s nejvíce obyvateli z jiné země.
Na opačném konci spektra bylo pouhých 184 zahraničních rezidentů, kteří Marku nazývali domovem, a něco přes 700 jich žilo v centrální městské čtvrti.
Ullern, Vestre Aker a Nordstrand tvořily další čtvrti s nejméně zahraničními obyvateli.
V těchto čtvrtích však žilo výrazně více přistěhovalců než v centru Osla a Marky.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili ve Frogneru, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Mezitím, zatímco mnoho občanů z Asie, včetně Turecka, také pobývalo ve hře Oslo (5 837), většina z nich byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde spolu se Stovnerem, Grünerløkkou a Søndre Norstrandem žil největší počet přistěhovalců z Afriky.
Ti ze Severní Ameriky byli poměrně rovnoměrně rozmístěni po Frogneru, Grünerløkkě, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve městech Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojeného království měli tendenci žít v nejústřednějším městském obvodu Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika set státních příslušníků z Oceánie byly Frogner, Grünerløkka a Gamle Oslo okresy s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí do března provoz nové uhelné elektrárny
Florence Tan
BENGALURU (Reuters) – Zimbabwe zahájí provoz nové jednotky ve své jediné uhelné elektrárně do března, říká náměstek ministra energetiky země, který poskytuje pomoc milionům občanů otřesených častými výpadky proudu v posledních měsících.
Nová jednotka elektrárny Hwange zvedne instalovaný výkon afrického státu o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časovou osu.
Méně než polovina z 16 milionů zimbabwských občanů má přístup k elektřině a globální omezení financování nových uhelných elektráren omezilo schopnost země zastavit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
„Máme kapacitu vyrábět až 2100 megawattů (MW) z našich zdrojů energie, ale v tuto chvíli vyrábíme mnohem méně, než to ..asi 1000 MW,“ řekl Mudyiwa agentuře Reuters.
„Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit,“ řekla.
Nedostatečné srážky vedly k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné elektrárny se v průběhu času prudce snížila, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžební a zemědělské aktivitě.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících vyhlídky růstu Zimbabwe.
Nedostatek financí na uhelnou energii žene těžební a na zemědělství závislou ekonomiku k dovozu nákladné energie od regionálních sousedů včetně Zambie a Mosambiku.
(Napsal Sudarshan Varadhan; Úpravy Jacqueline Wong)
(PERSON11) Ale pro některé složky, z nějakého důvodu, zvukový formát je špatně, takže, něco je špatně –
V podstatě velký obchod, nebo něco není v pořádku.
Takže, některé soubory jsou stále – stále mají divný výstup.
Ale – ale pro většinu složek by to už mělo být v pořádku.
Tak jo, díky.
Jo, to je skvělé.
Podporuji to, je skvělé, že, [PERSON7], jste mysleli na [PERSON11].
A [PERSON11] nyní má čas.
Tam jsou jiné věci, kde jsem myslel na [PERSON11] a že by byl trénink, prázdné systémy, tak, že oni dělají zkrácení.
Takže, pokud jste [PERSON11] měli čas.
Je jasné, že to nemůžeme udělat příští týden.
Ale měli bychom mít systém – připravený na –
Podíval jsem se na návod od NLP – bylo to tak?
(PERSON6) Pro nadcházející sezení a ptal jsem se na poptávku, protože jsem viděl (meme) projekt demo.
Dělají offline titulky.
To je o něco jednodušší než to, co děláme my.
Stále mají stejné problémy se segmentací a tak dále.
Ale jejich poslání v překladu se zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže, je tu něco jako přirozené zkrácení dat.
Bylo by skvělé, kdyby se nám podařilo lokalizovat takový typ dat tam, kde dochází k nějakému přirozenému zkracování.
Dali bychom to do architektury.
To zabere trochu času, protože musím zjistit, který z nich je ten, který dostává propustky.
Takže, až to budu vědět, můžu to sledovat, takže pro budoucnost –
Nebo vlastně, pro budoucnost bych to potřebovat, protože jakmile mám webový soubor, pravděpodobně nebudu muset dělat konverzi.
(OSOBNOST) No, tohle, tohle by vlastně mělo být –
Slyšíš mě ještě?
Kvalita zvuku je trochu horší.
Takže by se to mělo dělat pořád.
Takže pokaždé, když tohle vyhodnocení provedeme, mělo by být provedeno od nuly.
Takže pokaždé by mělo být nové stažení nové konverze a nové hodnocení.
(PERSON8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, mohu se o to později přesvědčit.
Takže tohle je důležitá věc, na kterou jsme měli narazit už před několika měsíci.
Nezapomeňte, že od srpna vám říkám, že chceme provést hodnocení na pozdějším testovacím setu.
A pokaždé, vy všichni...
Nejde jen o vás osobně [PERSON8].
Byly tu samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si, že to bude snadné, prostě to spustíme.
A teprve když to skutečně uděláte, vidíte všechny problémy.
Takže tohle je známé, běžné.
Tak je to vždycky.
Takže to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, v čem bude problém.
Takže, například, hovor, který jsem měl, ve kterém mě někdo zpovídal, takže chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Takže než to uděláte, nemůžete říct, zda to bude fungovat nebo ne.
A tady narážíme na problémy s konverzí formátů souborů.
Takže doufejme, že budeme schopni rychle získat čísla.
Takže, máte zatím nějakou chybovost slov?
Ne, ještě jsem to nezpracoval.
Takže [OSOBA] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím, že v tomto slovníku je hodně hluku.
Takže jsem vás požádal, abyste měli různé verze tohoto slovníku tím, že vezmete pouze slova, která byla pozorována, pětkrát.
A pouze výslovnost, která byla pozorována třikrát nebo vícekrát, nebo tak nějak.
Takto vznikly tyto náhodné chyby, jako je příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale stejně, budete mít varianty ve výslovnosti, protože pokud osoba, říká to „alzo“, pokud si vzpomenete, pokud říká to „alzo“ s „Z“ 20 krát v řeči, pak uvidíte, že v datech s „Z“.
A pokud se mu někdy podaří říct, že také správně, pak ano, opět, uvidíte, že v datech.
Proto bych rád [PERSON4] kontaktoval [PERSON2].
Možná budete pokračovat v hovoru, že?
Teď budu muset odejít, protože musím dát dětem oběd a tak dále.
Ale prosím, zůstaňte na tomto hovoru a společně vymyslete, jak používat tento slovník.
[PERSON4], ukažte prosím [PERSON2], jaký slovník systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte převést slovník, který jste vydali do tohoto souboru.
Jedna věc, která bude ještě potřeba, je náhrada za jazykový model.
Ale všechna tato slova by měla být známá.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři sloupce n.
Graficeme, jak je výstup.
Jeden rozpoznán.
fonémy, jak [PERSON2] navrhoval.
A bude tam více linek s různými variantami fonémů.
A třetí sloupec n bude opět stejný pro všechny z nich, a opět tam bude stejná grafická forma.
Tak to je, když jazykový model vidí.
A myslím, že tímto způsobem by to tyto systémy měly být schopny načíst.
A možná narazíte ještě na jeden problém: že není připraven na dva velké vlastní slovníky.
Takže, tohle je také něco, co se musí otestovat, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] ví, co vytvořil ve slovníku.
A víte, jak slovník vypadá, když ho vytváříte ručně, a musíte si dát tyto dvě znalosti dohromady.
Ah, takže to funguje s, s generovaným slovníkem.
(PERSON4) Dobře.
[PERSON6] Takže [PERSON2], dává to smysl?
Jo, jasně, promluvíme si o tom.
Jo, takže je tu ještě něco, co máte?
No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časovou značku.
Nejsem si jistý, jak dobré to bude, protože se to snažím udělat v (Libry) Speech.
A když jsem to stahoval, tvrdili, že to má víc než 600 hodin.
Ale pak trénink řekl, že skutečná tréninková souprava obsahovala jen asi 300 hodin.
A pořád si nejsem jistý, jestli těch 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo češtině jsem pozoroval strmější konverze.
A teď už se tak rychle neobnoví.
Takže, když odebereme nějaké vzorky během tréninku.
Pak je tu ještě několik závažných chyb ve výstupu ASR.
Takže doufám, že pro časové razítko to bude stačit.
Nebo bychom to aspoň mohli zkusit.
Dobře, to je dobrý, jo.
Tak jsem začal, ale myslím, že jsem nikdy nedokončil e-mail pro vás, protože jste mi připomněli, [PERSON8], že vaše filtrování nadávek ještě není integrované.
A myslím, že to je také důležitá zpráva pro [PERSON5], který opět zmizel z hovoru.
Takže, důležité poselství je, že ano, je velmi dobré, že aktivně prosazujete, aby vaše výsledky byly integrovány, a každý by tak měl učinit.
A zároveň potřebujeme nastavení, abyste ho mohli sami integrovat a otestovat.
Takže tomu říkám „integrace do-it-yourself“.
[PERSON8] tedy při práci s [PERSON5] a při dokumentování nastavení dbejte na to, aby byla dostatečně otestována kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontrolu jazykového modelu a všemi ostatními.
Kdykoli tedy někdo vyvine novou užitečnou součástku, měl by mít k plnému potrubí poměrně snadný přístup, aby ji mohl sám otestovat.
Takže tato integrace „udělej si sám“ je důležitá, protože jinak to všechno zůstane na vás [PERSON8] a nechcete být přetíženi.
Takže chcete poskytnout těmto lidem vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že?
Filtrování nadávek, bylo testováno na kládách?
Myslím, že ano.
Jo, myslím, že to bylo testováno na kládách.
Takže teď je čas to otestovat na živých potrubích.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] spustil pro sebe některé pracovníky a živě hrál některé z problematických souborů, jako je použití [PROJECT8] nebo cokoliv jiného.
Prostě je přehraj.
Sledujte zvukový výstup na vašem stroji a uvidíte, jak to funguje.
Protože jen při skutečném nastavení se objeví skutečné chyby.
Je důležité jej nejprve odladit, pomocí log souborů, a pak je důležité jej odladit v potrubí.
A pokud toto ladění může provést autor této komponenty, zde, v tomto případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Takže, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou integrace typu „udělej si sám“.
Jo, takže pro angličtinu s více přízvuky.
Takže, nyní [OSOBNOST] dáváme dohromady pouze jedno technické řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že bude vytvářet nové věty se slovy, která byla vyslovena v jiných větách, a bude tak činit napříč různými mluvčími.
Takže to budou opravdu věty s více mluvčími, a proto by se mohla zlepšit i odolnost vůči různým akcentům těchto mluvčích.
Aha, tak to je jeden částicový experiment.
A později možná uděláme něco víc s tím vícerým přízvukem.
Tyto nové věty se vlastně pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Takže systém ASR musí vidět co největší sadu vět.
A budeme vytvářet nové věty z textového jazykového modelu přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost pro různé reproduktory bude také lepší.
A při včerejším rozhovoru jsem zaslechl další nápad.
Bylo to během tréninku.
Vypouštěli ze zvuku časová pásma a frekvenční pásma.
Trénovali tedy na narušených vstupech a to také výrazně zlepšilo robustnost systému.
Kdokoliv jiný může zapracovat na nepůvodním přízvuku.
Ok, další věc, které jsem si všiml je – tohle je v pondělním testovacím dokumentu.
Je čtyřikrát zvýrazněn.
Takže, když se koná nějaké sezení, potřebujeme jména a terminologii pro toto sezení.
A my to musíme posbírat, připravit ručně, nějak to vytvořit.
A tato ruční tvorba by měla být podporována s automatickými nástroji, jak je to jen možné.
Je v tom jistá dovednost b, kterou je třeba procvičit.
Takže, jsem docela zručný v míchání textových souborů.
A kdykoli někoho z vás uvidím, jak to dělá, tak mám vždycky v hlavě tipy, co by se dalo udělat rychleji.
Možná to pro tebe není rychlejší, ale aspoň bys to měl zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jediný, kdo by to mohl udělat, je [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoci s okamžitou adaptací domény, s zpracováním dat, prosím, řekněte to.
A pak potřebujeme -
Takže, jakmile jsme zabezpečili slovník pojmů a bez ohledu na výslovnost slova, potřebujeme techniky, abychom tyto slovníky mohli použít v systémech.
Můj dojem z adaptace domény, kterou [PERSON9] pečlivě prováděl na všech sezeních, byl tedy takový, že v hybridním ASR nebyla skutečně viditelná.
Takže jedno takové sezení se bude opakovat toto pondělí.
[PERSON9] již zahajuje sběr dat, ale rád bych viděl přínos tohoto přizpůsobení domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat přizpůsobení domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Pokud byste se vy tři mohli setkat a překontrolovat, co dělá [PROJECT5] s -
Není to [PROJECT5], vlastně, doménová adaptace je pro sadu nástrojů [PERSON18], že.
Takže to vypadá trochu pozpátku, ujistit se, že starý přístup funguje.
V tuto chvíli je absolutně nemožné provést jakoukoliv adaptaci domény pro plně neurální ASR.
Takže uvažuji o tom, že budeme mít nezávislé vyhledávání podle klíčových slov ze zvuku a nějakou slučovací proceduru.
Takže bychom mohli mít dvě ASR běžící současně.
Konec-to-end ASR, což je obecně lepší.
A pak doménově přizpůsobené nastavení [PROJECT5], které se používá pouze k rozpoznání klíčových slov.
A když vidíme klíčové slovo ve verzi přizpůsobené doméně, pak bychom použili větu z [PROJECT5], která je obecně horší, ale obsahuje správné výrazy.
To je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a dělat různé experimenty s finetuningem a tak.
Takže jsme to probrali s [PERSON14].
A, [PERSON14], nějaké novinky od vašeho potenciálního kolegy nebo přítele?
Jo, takže pokud je tu někdo další, kdo by byl zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co je opravdu dobře přijímáno obecně jako papír, protože lidé to ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže bychom to tam opravdu mohli ovlivnit.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat v současné době používáme pro toto, protože, například, když si zkontrolujete jako [ORGANIZATION4] modely na [ORGANIZATION5], že jsou jako už docela dobré v těchto věcech -
(OSOBNOST) A já si myslím, že kdybychom jen -
Mohli bychom pravděpodobně jen získat data z nich, protože máte jako takový velký soubor videí v podstatě s různými doménami a různých mluvčích rodných jazyků na [ORGANIZATION5].
A napadlo mě, že bychom mohli prostě použít nějaký nástroj a stáhnout v podstatě nějaké druhy filtrovaných videí z [ORGANIZATION5] a udělat z nich tréninkové testy.
Takže to mám v plánu udělat sám.
Mám v plánu tam jít, ale potřebujeme někoho v záloze.
A také, pro akci [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, osoba z archivu, abychom znovu nepřišli o to sezení.
A ještě důležitějším a stále přetrvávajícím tématem je lezení po žebříku.
A já jsem zde v odstavci pro [PERSON2] navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by rostly.
Myslím si, že by bylo asi nejjednodušší postavit tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Příprava těchto tabulek může být obtížná.
Tak jsem se zeptal [PERSON7] a [PERSON7] bohužel nebude k dispozici během tohoto hovoru.
Chcete-li nám říct, zda [ORGANISATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANISATION242] se [PERSON7] nedoporučuje.
Takže jednoduchý html je asi ta správná cesta.
Takže, jakmile [PERSON2] má tato hodnocení vyčistit.
To znamená přesunout těch pár skriptů tam, kam patří, z testovací sady [PROJECT3] a nějakého automatického spouštěče.
Pak také prosím vytvořte konverzi z tabulek do html podobné tech konverzi a pak dát tyto výsledky pravidelně na své webové stránky.
Nebo můžete dokonce udělat to, že budete mít úplný git check out přímo umístěný v této veřejné html nebo singling z této veřejné html.
Tak, aby to bylo okamžitě přístupné přes web, a kdokoliv mohl podívat na aktuální skóre a prozkoumat, že.
Takže, to by bylo užitečné, zejména pro m lidí mimo [ORGANISATION2], jako je, [ORGANISATION15].
Víme, že mají něco jako...
Výkon byl špatný pro některé soubory, a oni mohli přímo m procházet to na webu m.
Mohli by také procházet to skutečně na [ORGANISATION101].
Je na vás, abyste ji nastavili tak, aby byla uživatelsky přívětivá a snadno se sledovala.
Dobře, to udělám.
Jo, díky.
Nyní pracuji na, nebo se dostávám k aktualizaci, demo papíru podání, které je očekáváno příští pátek, pokud se nemýlím.
A pak mám nějaké zprávy o projektu a začínám shromažďovat dokumenty – jako, nebo odkazy na dokumenty, ne dokumenty samotné, pro dvě sezení.
(PERSON11) <parallel_talk> I pro ASR bychom měli přidat bezplatnou metriku -
Vlastně více, měli bychom přidat doplňkové met- tyto doplňkové metriky. </parallel_talk>
Takže jste zmínil jeden a to je filtrování nadávek m hodnocení.
Takže <parallel_talk> mají explicitní seznam věcí, které se nesmí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A pak hodnocení vzácných slov.
A tady máme explicitní seznam jmen a pojmů, které chceme zobrazit ve výstupu, bodované ne jednoduše podle (pořadí) rychlosti </parallel_talk> ale bodované podle něčeho, co přímo účtuje tyto věci, že?
Ano, naprosto souhlasím.
To zahrnuje i manuální přípravu reference.
Takže, <parallel_talk> oba potřebují ručně vytvořené reference. </parallel_talk>
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladatelský slovník.
A měla by se o to brzy podělit. </parallel_talk>
Takže by se to mohlo stát prázdnou částí druhé věci vzácného slova -
Takže <parallel_talk> to by bylo vzácné slovo hodnocení pro MT a pak z [PROJEC210] jsme také pravděpodobně získat nějaký slovník. </parallel_talk>
To by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat o revizi <nesrozumitelné/> domény a vytvořit takový slovník při pohledu na výstupy a co chybí ve výstupech.
Tak, jako shortlist – seznam slov, která se nám líbí, a my se nám nelíbí v doméně <nesrozumitelné/> domény.
Můžeš to udělat?
Mělo by to jít, tak to zkusíme.
Bylo by skvělé, kdyby se ti to povedlo.
Tak si to napíšu.
Takže, <parallel_talk> s cílem [ORGANISATION62] termín s titulky studijní papír. </parallel_talk>
Ano <parallel_talk> a pak multi-source s [PERSON7] nebo na základě [PERSON7] nebo – </parallel_talk>
A pro ID jazyka, Jsem zvědavý, jak chcete integrovat to přesně, protože to již zahrnuje zvažuje více zdrojů ASR, více kanálů, tak co by bylo použití případ pro ID jazyka?
Jak to zapojíme?
(PERSON13) To bude audio na text pracovník, a bude vysílat časové známky jako pro čtyři nebo dvě sekundy okna a třídy.
<nesrozumitelné/> ticho, česky, německy, anglicky, a pak dám na ostatní, jak to chtějí použít v potrubí.
To je důležité.
Prosím, zapište to sem do dokumentu toto <nesrozumitelné/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], dobře a také možná [PERSON5].
Pokud máme tento nástroj, musíme (poslat) audio na více ASR nebo více pracovníků <nesrozumitelné/>
Zvuk budeme zvlášť potřebovat (poslat) do anglického ASR, zvlášť do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také, že tento jazyk ID pracovníka a pak musíme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je vícezdrojový nástroj, který bude pozorovat textové výstupy a také sledovat časová razítka a bude vysílat – pravděpodobně by chtěl generovat výstup do tří různých jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže, potřebujeme filtr pro ASR, aby ASR bylo tiché, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem si to vymyslel.
Dalším z nastavení by bylo, že stejný zvuk je dodáván do ASR a tento jazyk kontrola.
Tato kontrola jazyka je v podstatě součástí ASR, umlčení ASR, pokud je to špatný jazyk.
To je taky možnost.
Takže, musíme zjistit, který způsob integrace jazyka ID je nejlepší pro naše účely.
Takže o tom prosím uvažujte jako o tom, jaké jsou naše potrubí.
V ideálním případě si myslím, že nejméně podobné manažerské zmatky a tak dále by vznikly, pokud by naše MT modely byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná děláme jen kopii, pokud je jako vstup zadána angličtina, takže bychom měli na začátku vícejazyčné vícejazyčné ASR.
Vše přejde do angličtiny, a pak z angličtiny přejde do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, tento jazyk ID nebude ani potřeba.
Jde o to, že pokud budeme analýzu provádět důkladněji, jedna věc je možné sporné hodnocení, které jen ukazuje, že omezení mají ve skutečnosti dopad na skutečný výstup.
Že by to bylo hezké a jo, možná analýza pozornosti.
Ale nejsem si jistý, že by nám to mohlo dát stejné odpovědi, v podstatě, pokud se model věnuje nebo nevěnuje omezení.
(PERSON4) Musel jsem se podívat jen na pár příkladů pozornosti, nedělal jsem žádné statistiky nebo něco, a dívá se na omezení, a když překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti nedělá žádné v tomto smyslu.
To dělá některé obecné překladové chyby, ale ne (jevy), které se snažíme vyřešit.
No, vrátíme-li se k automatickému vyhodnocování, problém nesouladu je v tom, že výstup je správně poskládaný, ale kontext je jiný.
Tudíž se nejedná o stejný slovní tvar jako v odkazu, že?
(PERSON4) Jo, ale také jsem zkontroloval, zda kontexty jsou platné překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly automatickým hodnocením označeny jako chyby, bylo 91 z nich správně vloženo do správných kontextů.
(PERSON4) A myslím, že jen dvě nebo tři věty byly správně vloženy do nesprávného kontextu, jako by překlad byl špatný.
A pak jsou tu některé případy, kdy překlad byl úplně špatně, protože věta byla opravdu špatně, a část musí být <nesrozumitelné/>, ale to bylo jen jako jeden nebo dva případy.
Ale snažíte se najít shodu s různými formami, když to vyhodnocujete, že?
Ty neděláš žádné--
(PERSON3) -lemmatization of the reference and the-
(PERSON4) Oba, oba, oba, I'm matching both the surface forms and lemma.
Aha, aha, aha, to jsou ty dvě partitury, že?
(OSOBNOST) Je to jen dilema skóre pro (Evropan?) není v tabulce, protože tabulky jako se nevejde do papíru, takže <nesrozumitelné/>
Pokrytí je vždycky tak 97 procent.
Jen to generuje správné lemmy, jen...
Jo, dobře, chápu to, chápu to.
Takže v podstatě, lemma pokrytí říká, zda omezení je tam, a rozdíl pokrytí povrchu naznačuje, že by mohlo být nesprávně inflected, ale to není ten případ.
(PERSON3) Oh ano, jen nevím, jestli vy, pokud jste chytit <nesrozumitelné/> když jsme mluvili o [PERSON1],
ale jedna věc, je, že, že (úder) je lepší, ale druhá věc je, že lemmas jsou vlastně správně ručně poskládané,
ale to je další, ne, žádný problém, je to vlastně dobré, že je <nesrozumitelné/> pravda, jo.
Tak mě napadlo, že by mohl být.
Ale nejsem si jistý, zda pro to máme nějaká testovací data, ale mohli bychom se pokusit pohrát si s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít omezení a pokusit se použít místo toho synonymní omezení a vidět nebo porovnat jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to popisoval jen mlhavě, protože sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakém stylu přenosu dat pro anglickou češtinu? Máme něco? – Ne.
(PERSON4) <nesrozumitelné/>
Tím převodem stylu, Dušane, myslíš, že by tam bylo něco, co je v psaném jazyce, a ty bys byl cílová strana, byl bys v mluveném jazyce nebo něco takového?
(OSOBNOST) No, to je věc, jako, mám jen omezené znalosti o úkolu.
Ale umím si představit, že chcete přepsat větu, která není napsána mužem, ale je napsána ženou, nebo, já nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenka je taková, že styl vět je docela nejasně definován.
Takže znovu, nejsem si tak jistý.
Máme tu tento soubor větných transformací.
A jedna věc, která tam je a mohla by být označena jako styl přenosu je například, dělat věty obecnější.
Takže, detaily jsou vynechány, věta je zjednodušena, a pak aby věta zněla hovorově.
No, jen parafrázi.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení Matous dělá nějaký experiment s angličtinou-češtinou, ale nemáme tam žádné referenční údaje.
Nemáme tedy žádný soubor dat pro kompresi vět.
Možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže to jediné referenční by bylo příliš omezené na to, aby vám něco řeklo o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových transformací, například by se to dalo udělat <nesrozumitelné/> pro češtinu, takže možná by tím správným člověkem byl Rudolf Rosa, který by se ho zeptal, jestli někdy nějaký takový datový soubor vygeneroval.
Takže, bude to na kořenech založená generace nějakého větného protějšku.
(OSOBNOST) Myslím, že to je vlastně jako zajímavá otázka, zda můžeme použít omezení k prosazování tohoto druhu jako pohlaví mluvčího v překladu.
To je vlastně velmi dobrý nápad.
Mohli bychom se na to zaměřit a vytvořit konkrétní podčást testovací sady [PROJECT1], která by to pokryla.
Aha, takže občas známe pohlaví mluvčího, takže pokud ano... možná se podělím o obrazovku a budu si to prohlížet.
Nebo jsem to zkusil s Marian, která se toho účastnila a je to... Nevím, o kolik BLEU bodů níž.
(OSOBNOST) Protože stejně jako si myslím, že Martin dělá svůj <nesrozumitelný/> malý překlad, tak překládá více vět najednou a pak si vybere jen tu středovou a takto pokračuje pro celý dokument.
Kontext je tedy jeden <nesrozumitelný/> spolu s větou, kterou chceme přeložit.
(PERSON10) Jo, myslím – nedělal Dominik nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva před lety pro dvojité prázdné, kde se účastnili kontextu nebo spojování kontextu se vstupní větou a dělat nějaký druh dokumentu úrovni překladu.
Ale věc se má tak, že u zřetězení není úplně jisté, zda má stejný efekt jako nastavení vícenásobného enkodéru-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale je to Jsem překvapen, že [PERSON8] říká, že to nefunguje plný stop.
Jo, dobře, omlouvám se, možná bych měla být přesnější, že to nefungovalo tak, jak jsem to udělala já.
(PERSON1) Jo, protože si myslím, že je to metoda, která se velmi snadno testuje, a vždy by měla být testována v kontrastu s dvěma enkodéry, a já bych očekával, že někdy bude lepší a někdy horší než dva enkodéry, které jsou nastaveny, v závislosti na přesném úkolu, jako co přesně je druhá věc, kterou enkódujete.
Takže pokud máte dvě kopie dvou parafrází jedné věty,
Možná je to pro tu pozornost nějak matoucí, takže nevím.
Chování by také mohlo být jiné pro staré sekvence-to-sekvence metody, ve srovnání s transformátorem, takže pro RNN pak se choval jinak možná s transformátorem je to jo, je těžší trénovat, takže možná potřebujete jakékoliv zvýšení zahřívacího čísla, zahřívací sety.
(PERSON2) Jo, tak jen vědět, jako-
Nepamatuju si to, takže si to přesně nepamatuju, ale tohle je jako...
když jsem v létě začal s experimenty s více zdroji.
První věc, se kterou jsem začal, bylo spojení parafráze a zdroje a možná jsem, teď si nevzpomínám,
Můžu si to ověřit do příští schůzky, jestli jsem to taky zkusil,
Rozhodně jsem se snažil, když jsou zdroje na první pozici pak nějaký oddělovač a parafrázi na druhé pozici.
Taky jsem mohl zkusit, že jsem ty dvě věci náhodně zamíchal, jo, a jen si pamatuju, že to dělalo hojně tuhle kompenetrační věc a zkoušelo to multi-kodéry.
A pravděpodobně to bylo kvůli nízkému skóre.
(OSOBNOST 2) <nesrozumitelné/> které se vám líbí může zlepšit vaše bodové ohodnocení pouhým přidáním frázového výstupu a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže pokud zadáte výstup založený na frázích, je to v podstatě post editace, že? Můžete o tom přemýšlet jako o posteditu, jako o výstupu založeném na frázích, že? Nebo to záleží na úhlu pohledu, ne?
(PERSON1) <nesrozumitelné/> že se vám líbí plně přepsat, ale technicky to přesně odpovídá úkolu vyslání, můžete to připojit jako řešení úkolu vyslání.
Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte oddělovač vět token, že?
Máte speciální znak pro rozlišení, jako který je zdroj a který je kontext nebo druhá věta, nebo je jen zřetězit bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Snažil jsem se, Myslím, že dva tokeny a jo jako proto, že v první verzi, jsme měli podezření, že token by mohl být také tokenized sám, tak jsem pak přehrál to s jiným tokenem, který je nejen pro tento účel, protože jsme použili nějaký předškolený slovník, a tento slovník neobsahoval oddělovače tokeny.
Tak jsem použil nějaký symbol, o kterém jsem předpokládal, že nebude jako tokenizovaný na několik kousků a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento znak nemůže objevit na jiných místech věty, a to je jediné místo, kde se může objevit.
Takže by se to dalo udělat lépe, jo, souhlasím.
Ale část Flask nebo komunikace s klientem je něco, co nemohu dělat.
Protože nemám žádné zkušenosti a nemám čas to rozběhnout.
Myslela jsem, že to znamená něco s využitím neznámého mediátora.
(PERSON2) Ne, vytvořte HTTP klienta, který může vyplnit frontu a číst z jiné fronty.
A poslat text zpět v HTTP požadavku.
Protože můj nápad je, aby uživatelské kliknutí být použity v ukrajinském projektu taky.
A moje představa je, že klient klikne na tlačítko mikrofonu a začne mluvit, a když uživatel mluví, pošlete zvuk po malých kouscích zároveň.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server jej vložte do fronty, se kterou se o frontu postarám později (ASR).
A model bude mít nějakou logiku, nějakou dedukci s tím.
A kdykoliv má nový kousek přepisu, pošle ho zpět a uživatel by měl dostat částečný přepis zpět.
A mělo by se to okamžitě zobrazit v textovém poli.
Mohl bych o tom přemýšlet.
Já vlastně Flaska taky neznám, ale jo, můžu o tom přemýšlet.
(PERSON2) Možná jiný HTTP server.
Nevím, možná na to ani nepotřebujeme nóbl HTTP server.
Pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo.
Jo, jediným požadavkem je, aby zvládl více spojení najednou.
Myslím, že on-line tok textu je něco kolem dvou tisíc.
(PERSON1) Myslím skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými pracovníky uvnitř, takže myslím, jo, takže mám <nesrozumitelný/> řekněme deset, no místo výstupu, soubor od <nesrozumitelný/> postranního pracovníka, takže <nesrozumitelný/> který máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
To by nám ušetřilo čas.
(PERSON7) Jo, jo, to je velmi důležité, aby paralelizoval všechno vlastně, paralelizovat jak zpracování systémů, tak i hodnocení buňky DF, protože on by potřeboval spustit to mnohokrát, tam bude chyby, musíte znovu spustit to rychle.
Dobře, takže díky.
Takže, jste velmi zaneprázdněn tímto, nechci na vás házet další věci, takže začnu s připomenutím.
Potřebujeme dokončit popis sady stolů [PROJECT1],
Kohopak to tu máme?
No, vlastně ani ne, jo, (je to hotové) a bohužel tu není.
Takže tohle by bylo pro [PERSON2],
Pak hodnocení, to je pro [PERSON1], ale diskutovali jsme o tom.
Poslyš, dej mi tabulku v DSD dejme sem tenkou čáru a posuňme šablonu tabulky, jako je teď struktura plánu do deleblu, takže čísla přijdou později, ale já chci vidět nějaká čísla a úplnou strukturu tabulky velmi brzy.
Dobře, děkuji vám.
Máme [PERSON5], to je dobré.
Pro [PERSON5] bych tedy rád zjistil, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také pro vývoj, který je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
Jo, je tu další věc,
Možná není dobrý nápad kombinovat tyhle dva běhy do jedné sestavy.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a pak spustíte vyhodnocení.
A důvod tohoto rozdělení je ten, že můžete paralyzovat více.
Jsem si jist, že se vyskytnou problémy na různých frontách a čísla budeme velmi brzy potřebovat.
Takže pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále udržet překlad běží pro ty zbývající,
a přehodnotit, se sel T F, ty chybějící, a, a tak dále.
Jde o to, nevytvářet sériové, sekvenční zpracování, které zahrnuje obojí,
ale jde o to, získat výsledky, a je vlastně lepší to udělat po částech.
Nejdřív dostaneme všechny výstupy, pak dostaneme všechna hodnocení.
Jo, takže, chci říct, právě teď jsem dělal to samé.
Ano, to je jediná věc, kterou jsem dělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Jako odfiltrování trámů a nahrazení trámů různými trámy.
A pro multi-token omezení a podobné věci.
Ale pro pozitivní omezení, jsem jen porovnával tréninkový přístup s jo jen tyto velmi jednoduché věci.
Jen upravuji skóre v každém kroku stejným způsobem.
Dobře, takže zpět k pozitivním omezením.
Soustředil jste se už na analýzu systému?
(PERSON2) Jo, právě teď tak trochu čekám na přepracování datového souboru ([PERSON9]).
Také jsem se podíval na (kód) a myslím, že vím, proč je to tak pomalé.
Protože pro každý záznam v terminologii v (Europar) přepracování, otevřete datový soubor, tokenize je, číst řádek po řádku, tokenize je řádek po řádku a pak zavřít.
Ale to děláš jen ty -
(OSOBNOST) Tak si vzpomínám, že pro [PROJEKT1] jsem to dělal z loňského roku z nějaké chalupy v horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím předložit.
Obávám se, že by mohl být... no, žádná párty, ale možná na vzdálené párty.
A pak by si najednou uvědomil, že to musí předložit.
Takže v té chvíli žádná recenze nebude. <laugh/>
On by prostě vzít PDF a nahrát ji tak. <smích/>
No, dobře.
Takže jo, zkontroluju 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že bude lepší poslat jim e-mail hned teď a požádat o odkaz předem.
(PERSON7) Dobře.
Jo, díky.
Máme dnes k projednání jiné otázky, nebo je to vše až do Nového roku?
Doufám, že tam pro mě nic nebylo?
Před několika lety.
MT maratony mívaly tento systém nebo nástrojové papíry, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálem, jako by byly také emise PBML, které míchaly prázdné maržové papíry a samostatné papíry kvůli počtu těchto papírů.
A dokonce jsme měli věc, jako kdyby papír nebyl dost dobrý pro PBML, ale pokud nástroj byl představen na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, jak už jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, zveřejněte to na MT maratonu mezi lidmi.
Ale vaše práce je špatná.
Musíte ji vylepšit a dostanete se pouze k dalšímu PBML.
(OSOBNOST) Ano, ale další možnost pro SIGDial.
Není možné, že zkoušíme SIGDial a přilákáme tak trochu lepší účastníky.
To ano, to je... to jsem si taky myslel, ale neznám ani jedno z míst.
V červenci mají poslední papírovou registraci.
Takže konference byla v září a papírové podání bylo v květnu.
Protože pro Interspeech bychom to mohli rozdělit papír po papíru.
Aby se některé dokumenty dostaly na jednání mezi řečí.
A některé z našich podkladů přijdou později na PBML.
A autoři by si mohli svobodně vybrat.
Takže musíme jednat buď s SIGDial nebo Interspeech.
Pokud jim nebude vadit, že budou mít některé z našich dokumentů, vzhledem k tomu, že tyto dokumenty jsou odevzdány v březnovém termínu.
Takže, je tu absolutně striktní požadavek.
A myslím, že proti tomu nemohou nic mít.
Protože jestli ten článek stojí za zveřejnění.
Jako, je to jen bonus, že papír má nějaký sdílený výsledek úkolu, který se objeví v satelitní události.
Takže jo, myslím, že je to v pohodě.
Nemusíme tedy žádat o zvláštní zasedání.
V Interspeech se tomu říká zvláštní zasedání, to nechceme.
V Interspeech chceme tu satelitní událost.
Ale řekneme to našim lidem.
Podaří-li se vám připravit referát do uzávěrky pro interspeech, zašlete jej jako příspěvek pro interspeech a budete jej mít v rámci interspeech.
Ah, jestli ne, ah, udělej to na termín Interspeech, tady je náš termín.
A tohle je za PBML.
(PERSON7) Ah, okay.
Ale je to jako v případě Interspeech satelitu.
Interspeech jako by se nedostal do žádného řízení.
(OSOBNOST) Můžete si myslím, že můžete jen můžete vyhradit celý semestr jen pro [OSOBY] kurzy a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale já si myslím, že je to něco jiného, protože si myslím, že to opravdu není věc, která by selhala v jeho kurzech.
Jako když selžete, protože nejste schopni to dokončit.
Samozřejmě, jako by to lidé prostě vzdávali, ale myslím, že je to možná z jiného důvodu, že prostě není možné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
Jo, myslím, že nám na začátku semestru řekl, že když chceme jedničku, dostaneš jedničku.
Jen ve druhé lhůtě, měli byste předložit.
To je asi tak jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů z předchozích let, mnoho lidí to nedělá.
Snadněji se jim čte na zkoušku.
Ne, promiň, uč se na zkoušku.
Jo, protože obecně jsou jeho zkoušky poměrně snadné.
(OSOBNOST) Takže bych neřekl, že je to super snadné, protože existují kurzy, kde je zkouška jako zábava.
No, jeden z nich byl pro mě včera.
(OSOBNOST) Jo, když to má krátký kontext a protože dělám rozhodnutí na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak to opravdu zavazuje k něčemu, že například v sekundě nebo dvou, to přijde oh, dobře, vlastně to byl špatný překlad.
Snaží se tedy použít jiné formulace.
Pro, například, specifikovat věc.
Takže se mi to vlastně líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když jste mohli vidět, že model udělal chyby na první pokus, to opravdu chtěl, aby nějaký druh opravy.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i trochu nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečné.
Ale pokud je nižší kvalita proto, že překlad, pokud budete číst všechno, že dostanete stejné informace, ale formulace je jen špatná, protože se používá, například, více slov a používá některé opravy a tak.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové dvojice máte tyto výsledky, jako některé příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
Určitě, můžu vám dát svoje záznamy.
Ale ve kterých jazycích?
Protože víš, že nemluvím německy.
(PERSON2) Anglicky a německy.
Jo, ale já nutně nemluvím německy.
(PERSON2) Pak mohu poskytnout anglicko-čínské a anglicko-japonské, pokud to pomůže <smích/>.
Takže znovu, chci to udělat lidsky čitelné.
Protože toto blikání je opravdu otravné a pak se přestanete soustředit na to, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Promiň, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoliv vidím slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš pytlík.
Tak jsem vložil slovo do pytlíku.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je ten problém s blikáním.
Když něco přeložíš a pak to změníš, tak už to vlastně čtu, mám to v hlavě.
A pak ztratím soustředění a kontrolu nad tím, co bylo tehdy přeloženo jako správné a nebylo to, co nebylo.
Proto si myslím, že celá ta věc s blikáním je špatná a hloupá už z podstaty.
Jako bych viděl motivaci, jako bys chtěl ukázat všechno, co máš.
I když nemůžeš slíbit, že je to dobré.
Myslím si však, že s těmito informacemi navíc nemůžeme pracovat.
A myslím si, že problém je v tom, že systémy jsou vytvářeny lidmi, kteří s nimi pracují.
Pokud jsem vyvíjí systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, Pořád to ukázat a je to nějak dobré, ale myslím, že vývojář není opravdu zaměření na obsah sám.
A jak vnímáte obsah, ale spíše to, no jo, můj systém to dokáže rychle vygenerovat.
A I když jen hádá, že kvalita je v pořádku, myslím, že možná proto byla vytvořena retranslace.
Jen vývojáři systémů jsou dychtiví zobrazovat informace, a myslím, že protože jsme omezeni v jako objem informací můžeme vnímat nějaký čas, rádi vidíme, že další informace je jen další zátěž pro nás.
Takže si myslím, že není dobré ukazovat něco navíc.
Jako když chcete snížit latenci, tak místo blikání prostě snížíte kvalitu.
Myslím, že je to pořád lepší, než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste opravdu potřeboval vidět hypotézu o labilitě?
Jako z pohledu uživatele?
(PERSON1) Jako technicky, když začnou lidští překladatelé překládat, myslím tím cíl, který mají anotátoři, snažili by se následovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy něco řeknou, a to by bylo špatně, takže by se prostě opravili.
(OSOBNOST) No, ale jo, to znamená, že s mým řešením, jako byste nedělali blikání, ale zavázali, jako že není žádný způsob, jak změnit, ale opravit sám sebe.
A to je vlastně to, co dělají překladatelé.
Mám silný pocit, že naše práce není přímo v oblasti řeči, je nezdravá.
Protože tady není žádný pojem řeči.
Pracujeme přímo na textu.
Ale je to tak, že návrh na statistický seminář v letošním roce je u konce, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by měl přijít v roce 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme jednu ze dvou sekt nebo průnik, protože oba z nich jsou dobře uznávané v komunitě.
Můžeme účastníky motivovat, aby se přihlásili.
Jediná výhrada, kterou teď zjišťuji, je ta, že nám nepovolí prostor v jednání, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšeni publikováním příspěvku v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, že?
Takže to není přínos pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
Takže tohle byl důvod, proč jsem se za to zvláštní sezení zaručil.
Ale tentokrát, problém je, co jsem pochopil, je, že naposledy, časové období mezi návrhy, podání a závěrečné papírové podání bylo pět měsíců, takže by to bylo dost času na náš plán, ale tentokrát.
Jsou to jen tři měsíce.
Vnímám tedy tento veletrh jako důležitý možný zdroj nerodilé anglické řeči, který můžeme využít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na soutěž Clearest Voice a můžeme udělat stánek, když budeme muset.
Ale rád bych to omezil, protože šíření informací mezi středoškoláky má na nás menší dopad.
Důležitější je použít ji jako testovací relaci.
Takže bychom se měli zaměřit [PERSON1], na [PROJEKT2] Nejčistší hlas, a udržet organizátory spokojený, abychom mohli udělat sběr dat tam.
A dělejte, co chtějí, abychom udělali výměnou za to, a my musíme zkontrolovat jejich program na plenárním zasedání a jaký typ titulkování by byl pro program na plenárním zasedání užitečný.
takže by to pro nás bylo zkušební sezení, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže pokud se nás někdo zeptá, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, tak dobře, ale pokud ne, tak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
Jo, ještě jsem se kvůli tomu nepokusil o registraci, ale myslím, že minule bylo povinné mít stánek.
(OSOBA) Ano. Takže, proberte s nimi, co je potřeba, aby byli šťastní, a oni nám umožní udělat hlas Clearest, což je nejdůležitější.
Zkušební sezení je menší nutkání.
A ten stánek je něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se k sezení připojili dříve, než aby dělali takové věci.
Takže opravdu musíme trénovat tyto přípravy.
S on-line svět, zdá se, že stačí j p do relace, a práce je hotová.
Ale tak tomu není.
Zprovoznění a správné připojení trvá vždy 30 minut.
Takže tam musíme být dřív.
A když nějaké sezení, které děláme, začíná v devět, ale organizátoři se sejdou ve tři čtvrtě na devět.
Pak musíme přijít už ve čtvrt na osm, abychom měli těch 30 minut navíc, abychom se ujistili, že všechno běží a honili lidi.
Takže, tohle je poznámka pro všechny, že aby vedení fungovalo, prosím, také předvídejte, co po vás vedení může najednou chtít, a to by trochu pomohlo.
Dalším poselstvím, které je velmi důležité, je záznam těchto důležitých zasedání.
Nevím, jestli jste reagoval, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní v nahrávání těchto sezení.
Takže pro účely dalšího hodnocení nebo analýzy toho, co se nepovedlo, je důležité mít dobré nahrávky z těchto sezení.
A jedním aspektem je získat souhlas, aby nám bylo umožněno nahrávat.
A I když se pokusíme získat souhlas zpětně nebo tak.
Pak je tu technická stránka nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [PERSON5] tento odkaz odesílá.
Vzpomínám si, že jsem ho poslal e-mailem.
2 špatné citrony v řadě :(
Objednal jsem si u této společnosti, protože jsem ji koupil v minulých sezónách a fungovala skvěle.
Tuto sezónu jsem si koupil další velikost, kterou jsem potřeboval.
Jedno z pyžam, které jsem dostal, mělo díru na noze pyžama.
Vrátil jsem ho a firma mi poslala nový.
Náhradní pyžamo, co měl můj syn jednou na sobě, jsem dala do pračky jako vždycky a zip se ulomil!
Jsem tak zklamaná, protože nemám čas řešit návraty každých pár dní a přesto se to právě teď děje.
Přesně jak bylo popsáno
Tohle je obyčejný kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuovém uzavřeném sáčku, takže je potřeba ho na pár dní pověsit, aby se na něm uvolnily vrásky a trochu se „nafoukl“.
Měřím 5 stop 6 palců a kabát je na mě dlouhý po kolena.
Objednala jsem si 2+ velikosti vzhledem k dalším připomínkám a zkušenostem z minulosti a kabát je pravděpodobně o něco větší, než je potřeba.
Nicméně s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale bez pout.
Přední zip funguje.
V boku ani vzadu nejsou žádné průduchy pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase mám dvě kapsy (na vás mohou být vyšší nebo nižší).
Nejsou zde žádné ozdoby ani detaily stylingu – je to BASIC COAT.
Za tu cenu si myslím, že je to v pořádku.
Nosila jsem ho ve větrném dni, ale ne v zimě.
Necítil jsem vítr, takže cítím, že je to dobré znamení.
Jsem však zvědavý, jak si povede v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově mě to těší.
Vakuový sáček lze znovu použít a prodejce součástí opravdu roztomilý děkovný dopis, který byl skvělý dotek.
To je moc pěkná sukně.
Krajkový vzor je elegantní a měkký
To je moc pěkná sukně.
Krajkový vzor je elegantní a měkký.
Nemačká se, dokonce i po namačkání do plastu a krabice byla velmi hladká, takže je to fakt super.
To lze snadno obléknout nebo nastrojit, a má jakýsi vintage pocit vzhledem k délce a střihu, který jsem opravdu do.
Myslím, že by to mohlo lichotit komukoliv.
Mám 5'5“ a 130 liber a objednal jsem si malé, takže bych řekl, pokud máte pocit, že jste uvízl mezi malým a středním, určitě velikost dolů.
Nefungovalo to s mým Buickem LeSabre z roku 1999.
Zboží dorazilo rychle a vypadalo, že je v dobrém stavu, dokonce i baterie předinstalovaná.
Nicméně, i když by měl být kompatibilní s mým Buickem LeSabre z roku 1999, ovladač se nepodařilo naprogramovat ani synchronizovat s autem.
Instrukce jsou celkem jednoduché a vím, že jsem se jimi řídil správně, protože se mi podařilo úspěšně přeprogramovat můj starý dálkový ovladač.
Tento nový však nefungoval, a tak jej budu vracet.
Nebyl žádný problém s prodejcem nebo servisem, jen se zdálo, že tato konkrétní věc byla vadná nebo neslučitelná s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta utrhlo něco velkého, co letělo po dálnici, takže jsem potřeboval náhradu.
Bál jsem se po přečtení některých recenzí, že to nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Nevzala jsem si ho na sebe – nechala jsem si to udělat od jednoho chlápka v karosárně – ale vypadalo to opravdu jednoduše.
Zapnul se za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože se mi zdá dost chatrný (čas a poletující trosky to prozradí), ale přes to všechno jsem velmi spokojený, že moje auto už nemá na předku otevřenou tlamu a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Můj 5 rok starý absolutně miloval toto světlo To netrvalo dlouho dostal ho k narozeninám v lednu je to únor již má problémy s tlačítky a neběží jasně s plug in žere až baterie i snažil dobíjení baterie Super cool, ale potřebuje zlepšení
Hudební začátek
Klavír je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci rukou a očí.
Klavír není jen hrací hračka, ale to skutečně funguje a umožňuje vaše dítě hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě být budoucí pianista, měli byste vyzkoušet tento produkt ven!
Za ty peníze to stálo!
Dal jsem si to na nos, jak mi bylo nařízeno, dvakrát denně a dvě minuty jsem si to třel.
Kůže na mém nose zrudla a byla úplně syrová.
Dost mě to zaskočilo.
Měl jsem dobře zahojenou jizvu po pádu do ostnatého drátu z doby před lety.
Nejen, že tento produkt nefungoval, ale málem jsem skončila v ordinaci dermatologa, nicméně tím, že jsem dala na plochu aqua-for a obvaz, se to asi po týdnu uklidnilo.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo podělal vzorec?
To je tak divný.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí malířské tyčinky jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl říkat jim červené nebo růžové.
Bílá není tak jasná, jak jsem doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem si myslel, že tam byla růžová.
Myslím, že fialová bude stačit.
pracuje z větší části
Před pár měsíci jsem si vybělila celou hlavu a pak si ji obarvila černou krabičkou.
Pak jsem šel a nechal si udělat melír po celé hlavě.
O pár týdnů později jsem si na vlasy nanesla modrozelenou barvu na vlasy Arctic Fox a už nevybledly.
Použil jsem tuhle věc s Olaplexem č. 3 a zesvětlilo to TREMENDOUSLY po celém těle, odstranilo to zelenou a modrou část a zvedlo to tmavé krabičkové barvivo.
Nicméně, po jednom dni jsem si všiml zeleného odstínu na mých vlasech.
Každý den je to horší a já jsem použil barvu extraktor dvakrát teď, se stejnými výsledky.
Taky mi tmavnou vlasy tam, kde byla barva na krabici.
Je to skvělý produkt, ale nezdá se, že by vydržel dlouho.
Nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román musí být zmírněno nějakým realističtějším hodnocením.
Zkoušel jsem si to přečíst, ale jazyk mi došel.
metafora „sladkovodní“ a mnohé popisy dělohy jako řeky a dítěte jako ryby se zdály nucené, neohrabané a vymyšlené.
Přeskočil jsem a vypadalo to, že najdu jen školní drama.
Dávám této knize 10 hvězdiček!
Vynikající čtení!!
Tu knížku jsem absolutně miloval!!
Adoptoval jsem 4 siamské kočky od Siri v průběhu let a každý z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké dát dolů.
Vtipné, vtipné a velmi zábavné!!
Siri šla nad rámec svých snah o záchranu koček (hlavně siamských)!!
Moc se mi líbí tohle světlo!
Je to nádherné za cenu a to dostane práci!
Jediný problém je, že žárovka se ohřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji zase zapnout.
Nemyslím si, že by se to mělo stát...Nevím, jestli mám vadné světlo nebo co, ale kromě přehřívání je to velmi pěkné kruhové světlo.
Matoucí děj
S knihou bylo těžké držet krok, protože hodně poskakovala.
Také název nezapadá do příběhu.
Autor uvedl, že tímto mimozemšťanem bylo infikováno několik lidí, nicméně vynechány mohou být podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a znovu hodně číst, abych se ujistil, že mi nic neuniklo.
Miloval Collinse...
Chvíli mi trvalo, než jsem si na Gradyho zvykl.
3 1/2 Stars Remedy je bratr nejlepší přítel romance, stejně jako druhá šance romance smíchané do jednoho.
Je to unikátní příběh a hrdina (Grady) musí udělat všechno, aby Collinse dostal zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostala všechno, o čem snila, nejlepší kamarádku svého bratra... ale když se druhý den ráno probudila sama a nikdy o ní neslyšela, věci se definitivně změnily.
Teď je Grady zpátky a neodchází a dělá všechno, co je v jeho silách, aby jí dokázal, proč odešel a že se jí tentokrát nevzdá.
I když se mi líbila premisa tohoto příběhu a občas i Grady, opravdu mi lezl na nervy.
Naprosto chápu, proč tu noc odešel, ale neposlat ani Collinsovi dopis, ve kterém by to vysvětlil?
Nechat ji celé ty roky přemýšlet a trpět a pak čekat, že ho přivítá s otevřenou náručí?
Měl halucinace?!
Collins měl právo být naštvaný, naštvaný, zraněný, atd.
Udělala dobře, že se s ním začala prát, když ji chtěl zpátky, a pohnula se kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collinsovou v té knize, byla silná a střežila si své srdce a za to jsem ji obdivoval.
Určitě Gradyho milovala, ale bála se a váhala, jestli ho má pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla určitě moje nejoblíbenější z těch dvou.
Rozhodně nechávala věci běžet tempem, jakým chtěla, a když byla připravena naslouchat, naslouchala.
V téhle knížce je hodně úzkosti a já jsem si užíval, když se tihle dva znovu spojili, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevypadal tak ukňouraně a byl trochu chápavější.
Pořád říkal, že to chápe, ale občas na mě byl až moc vlezlý a ke konci byl milý.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla problém přečíst si jeho názory, protože jsem se nedokázala spojit s jeho postavou.
První část této knihy, nebyl můj oblíbený, ale on druhá část?
Zbožňoval jsem, proto mé hodnocení.
Pokud máte rádi druhou šanci, a bratři nejlepší přítel romance, můžete si opravdu vychutnat tuto knihu, Jen jsem měl těžké časy s Grady na první a jak on zvládá některé z věcí, které dělal.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho portrétu Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké poznat, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla, bylo velmi dobře provedeno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otáčení stránek...
Scéna a kostýmy byly vynikající.
Je dojemný s dnešním párem polobohů, kteří zastávají světovou politickou pozici.
Stojí za pohled několikrát...stojí za zamyšlené zamyšlení... ještě mnohokrát.
Vyhněte se Wifi připojení- jít Bluetooth!
Koupil jsem ho své ženě v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydlení v hotelu.
Nemohl jsem sehnat takové měřítko, abych se připojil k Wifi v hotelu.
Rozhodla jsem se počkat, až se nastěhujeme k nám domů a já si budu moci nastavit vlastní Wifi systém.
Březen 2018- Nastavil jsem si Wifi systém a tato stupnice se stále nepřipojuje.
Pokaždé, když to zkusím, dostanu chybové hlášení.
I když jsem 10' daleko od Wifi jednotky.
Sledoval jsem video na YouTube bez úspěchu.
Když jsem si koupil jednotku, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato stupnice používá ke komunikaci s telefonem Wifi router.
Tento systém je omezen na připojení routeru...které obvykle nebývá blízko ložnice na rozdíl od mobilního telefonu!
Takovou stupnici bych nikomu nedoporučoval kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to měřítkem připojení přes Bluetooth.
Dobře, ale rád bych našel něco lepšího.
Po dlouhém výzkumu jsem začal používat tento produkt před mnoha lety.
Mělo to nejmenší množství škodlivých ingrediencí a pořád to fungovalo.
Nicméně, to vyschne tak rychle, že skončíte s použitím tolik lubrikantu, což nakonec stojí hodně peněz, stejně jako příliš rušivé při sexu.
Jen jsem byl příliš líný hledat nový produkt, ale začne hledat takový, který je neškodný, funguje dobře, a ne příliš nákladné.
Výdrž baterie je hrozná na té, kterou jsem koupil na Amazonu.
Stále nemohu uvěřit, že Logitech ukončil výrobu tohoto dálkového ovladače, nic jiného se tomu ani neblíží.
Naprosto miluju tenhle ovladač Harmony, tohle je můj čtvrtý.
Pes sežvýkal první, manžel klečel na obrazovce druhé, a ty třetí stále fungují, ale tam je loket značka uprostřed dotykové obrazovky také zásluhou manžílka ... koupil tento jako zálohu a obrazovky skvělé, ale baterie to přišlo s nabíjení možná na pár dní.
Můj originál (3. díl) si nechává nabíječku na několik týdnů a na všechno používám dálkový ovladač.
Vloupal se za méně než týden
Líbí se mi výrobek je to pěkná velikost a barva!
Bohužel ho měl jen týden a otevřel jedny dveře a praskl vršek kusu dřeva!
Jsem opravdu zklamaný!
Všechno je to smontované a já už tu krabici nemám, tak jak bych mohl vůbec pomyslet na to, že ji pošlu zpátky?!
Manžel to zkoušel opravit lepidlem na dřevo, ale bohužel ani to nezabralo!
Dveře se zase otevřely!!
Není příliš snadné sestavit plus....
Při montáži je to pěkný kus nábytku, ale montáž byla obtížná.
Některé znaky písmen byly špatně označeny, takže jsem se musel pokusit přijít na to sám Šrouby, které dodávali k připevnění podlahy a bočních panelů, všechny popraskaly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také skleněné výplně dveří jsou z řady a neodpovídají rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny dveře zůstaly zavřené, protože magnet na zavření dveří je mimo provoz.
Pořád jsem nepřišel na to, jak je srovnat.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA PŘÍŠTĚ PODU
Koupil jsem je v únoru.
V poslední době jsem se je snažil používat a bohužel pokaždé, když se snažím jeden můj Keurig stroj mi dává chybové hlášení, že modul není kompatibilní s mým strojem.
Používal jsem lusky z Donut Shopu ve svém stroji od doby, kdy jsem ho poprvé zakoupil a nikdy jsem neměl žádný problém.
Při bližším zkoumání kávového lusku jsem si všiml, že kód vytištěný na vrchu lusku není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabičku.
Koupil jsem krabici 72, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jeden z každého z 6 polí a stále dostávají stejné chybové hlášení.
Vím, že to není můj stroj, protože ostatní lusky, které zkouším, fungují skvěle.
Jen díky této zásilce mám tento problém.
Velké zklamání, protože mi vypršelo okno pro návrat.
AKTUALIZACE: Mluvil jsem se zástupcem zákazníka, který vracel peníze.
Děkuji AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestu.
Takové pohodlí!
Je to opravdu pěkné mít můj oblíbený cukr alternativu zabalené v malých vzít s sebou balíčky!
MILUJI, a je to tak pohodlné, aby se tyto hodit do kabelky na večeři ven, nebo použít v domě přítele.
I když jsou trochu drahé, nemůžu vystát Equal nebo růžovou hmotu v mém ledovém čaji.
Uhnout nebo nic, takže jsem nadšený, že mám sladidlo na cestách!
Nedělá vlastně žádné „čištění vzduchu“
Koupil to jako zvlhčovač vzduchu, část „čištění vzduchu“ je vlastně falešná reklama; v závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není žádný prach ve vašem domě, pokud žijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač s knotem a stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku, pravděpodobně budete muset spustit asi 5 let, aby se rozdíl nahoru.
Má poměrně velkou vodní kapacitu na svou velikost, protože 'nádrž' je nedílnou součástí jednotky, a to je nízký výkon (i když ne lepší než knot typu).
Je také poměrně snadné čistit, i když plastové disky nelze opravdu servisovat, protože diskovou jednotku nelze rozebrat.
Nicméně, pro německé strojírenství, kvalita stavby není velká.
Já ho mám už rok, což by znamenalo asi šest měsíců provozu za chladného počasí, a jednotka vyvinula velmi nepříjemný rachot z ventilátoru sestavy.
Hádám, že to jsou ložiska ventilátoru, takže jen čekám, až tady dojde k úplnému selhání.
Jak poznamenal někdo jiný, jakákoliv oprava se téměř rovná koupi nového zvlhčovače knotů.
tl; dr – nestojí za příplatek, jste na tom lépe s knot zvlhčovače.
Myslím, že bylo snazší to prolomit, než si mysleli.
Dávám tento produkt 3 hvězdy udělat s tím, že když jsem to dostal do to bylo rozbité již uvnitř.
Jakmile jsem to prozkoumal jsem si uvědomil, že ten, kdo dal to do krabice dal to tam rozbité, To by mohlo být buď výrobce balírny nebo pro výrobce, aby problém mohl být, že kupující vrátil zboží a tvrdil, že to prostě nechtěl, nebo to nepotřeboval a Amazon možná neudělal dost dobrou kontrolu kvality, když se vrátil.
Ve vší slušnosti kupující nemohl říct, že to bylo rozbité, protože pak Amazon by si to zpátky, což je dobré zejména s tímto druhem produktu tak jako tak, i když já jsem ten, kdo uvízl s něčí nedbalost.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a prodiskutoval to se svým partnerem, jsem se rozhodl dát tomuto kupci další šanci.
S tím řekl, že budu pouze aktualizovat své hodnocení na vyšší hvězdu v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (alespoň adresováním) a v případě, že položka přichází ve skvělé formě, vlastně má možnost dělat to, co dělá, a funguje dobře dělá to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale instalace pro mě nebyla tak snadná.
Několikrát jsem zkoušel bez úspěchu instalovat oba „zvonky“ do připojeného vysílače.
Už jsem to chtěl vrátit, protože to nefunguje, ale řekl jsem si, že to ještě jednou zkusím a zkontroluju baterie ve zvoncích.
Voila...z krytů baterií, které jsem natáhl, trčely malé plastové destičky a z nich vylezl plastový kus, který baterii zakrýval a zabraňoval jejímu fungování.
Poté, co jsem odstranil tyto kousky plastu, zvonky fungovaly bez problémů a byl jsem s tímto nákupem naprosto spokojen.
Zvláštní je, že v návodu pro uživatele není žádná zmínka o plastu nad baterií, který musí být odstraněn, aby zvonek fungoval.
Bylo by méně frustrující, kdyby se o tom zmínili a já si nemyslel, že problém je v tom, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou kroužků, zvonků a melodií si můžete vybrat a je snadné změnit, kdy chcete.
Při hodnocení tohoto zvonu se ptají na to, jak je odolný proti povětrnostním vlivům.
Nemohu to komentovat, protože to bylo instalováno 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je to odolné proti počasí až do příštího období dešťů...pravděpodobně v listopadu.
Ztracený balíček – Nabil mě znovu
Vyrostl jsem s nimi a byl jsem nadšený, že je koupím svému synovi, ale přišli o balíček živých housenek.
Řekli mi, že ho vymění a tentokrát si naúčtují polovinu přepravného.
Po značném telefonickém čase mi nakonec znovu naúčtovali novou objednávku se slevou asi 3$.
Myslela jsem, že je to dost neprofesionální, protože nejen, že o to přišli, ale oni mě vedli k přesvědčení, že to napraví jen proto, aby mi naúčtovali téměř plnou cenu na konci 30minutového telefonátu s nějakým žvástem o poukázce.
Strávil jsem 30 minut na telefonu, tak jsem ustoupil a koupil si další sadu housenek.
To je fuk.
Funguje dobře po bolestech hlavy.
Měl jsem nějaké problémy s jeho zprovozněním.
Dodávaný kabel nebyl k ničemu – baterii nenabíjel.
Když jsem vyměnil kabel za svůj vlastní byl schopen nabíjet a pak připojit zařízení přes bluetooth k PC.
Měl problémy najít PC software, ale když jsem e-mailem jejich podporu odpověděli během jednoho dne se správnou informací ke stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, nicméně jsem nebyl schopen připojit se ani k iPhone nebo iPad (vyzkoušeno několik od každého) přes bluetooth.
Budu se muset pevně zapojit, pokud se rozhodnu použít toto zařízení ve svém produktu.
... byl příliš žlutý před nákupem a bylo řečeno, že je to jako starožitné zlato
Zeptal jsem se prodejce, jestli barva byla příliš žlutá před nákupem a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízko!
Set vypadá velmi levně.
Je to super lesklá žlutá se spoustou CZs, ještě lesklejší.
Na fotce to vypadá skvěle, ale ve skutečnosti bych to nedal ani teenagerovi.
Líbil se mi prsten – ale nemohl jsem ho nosit pořád! :(
Ten prsten byl nádherný.
Moc se mi líbil design a jeho robustní vzhled; vypadal draze a byl velmi pohodlný!
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec vrátil produkt je, protože jsem si uvědomil, že bych nebyl schopen nosit po celou dobu.
Prstýnky nosím rád pořád, a proto si vždycky dávám pozor, abych je dostal z ryzího stříbra, a vím, že někteří lidé říkali, že jejich prstýnky jsou po nějaké době zašlé, ale já jsem je nosil asi týden v kuse – i když jsem si myl ruce – a žádného pošpinění jsem si nevšiml.
Zajímavé je, že problém, který jsem měl, byl, že vnitřní pásek prstenu mi vlastně otáčel prst bílý a vlhký – něco jako obvaz, když ho necháte delší dobu nasazený.
To se stalo, i když jsem se ujistil, prsten a můj prst byl zcela suchý.
Nevím, proč se to stalo a nikdy se mi to nestalo s žádným jiným prstenem, ale začalo to být nepříjemné, tak jsem se rozhodla, že to není prsten pro mě.
:( Škoda, protože jsem to opravdu miloval!
Takže pokud si kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám jděte do toho!!
Ty nebudeš zklamaný!
koupit Pampered Chef...
Vlastním malou lžičku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých „věcí“ je ve skladu.
Miluji používání těchto kopečků při pečení pro perfektně porcované sušenky.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a koupit si OXO – většinou mám s jejich produkty štěstí.
Tenhle ne.
Asi ve 30. minutě přestala páčka uvnitř naběračky fungovat.
Musel jsem páčit kliky od sebe a přemístit páku, abych mohl udělat ještě pár dalších kroků, a pak opakovat.
Takže... zachraň si zdravý rozum a kup si kopeček Pampered Chef.
Stojí to za to!
Nebude kupovat pana Kávu znovu
Chvíli to byl dobrý kávovar, ale vždycky s ním byly problémy.
Kdybyste dostali vodu mezi černý plast a kov na karafě, prosakovala by a odtékala by celé dny.
Pak se rozbila naše plastová páka, která umožňuje průtok kávy filtrem do karafy.
Kontaktoval jsem zákaznickou podporu s dotazem na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je skvělý v přípravě kávy a udržování ji horkou, ale existuje příliš mnoho dalších problémů s ním investovat do něj za současnou cenu.
Musím koupit!!
Milovala jsem tuhle růžovozlatou barvu a všechno kolem bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v rukojeti a všiml jsem si, že před zakoupením, což je důvod, proč jsem ještě dát tento 5 hvězdiček!
Bylo snadné čistit a vše přišlo zabalené jednotlivě, které jsem zjistil, že je opravdu organizované a to uklidnilo mou duši lol láska, láska, LOVE barvu a já bych určitě koupit to znovu pro sebe nebo pro milovanou osobu!
Může být dobrá na tyči, ale ne jako závěsná přepážka nebo povětrnostní štít.
Hanba Audubonovi.
V návodu se píše, že se má ucpávka protlačit otvorem v přepážce nahoru a „Ujistěte se, že je bezpečně na svém místě.“
Jak???
Je navržen tak, aby přepážka jednoduše seděla volně na zástrčce, takže může být vytlačena nahoru jakýmkoli tvorem nebo sebemenším větrem.
Můžete otočit kolík vzhůru nohama, takže palečnice jsou na spodní straně přepážky, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to nedokáže a jen ty nejmenší prsty by to měly snadné.
Trvalo mi přes hodinu, než jsem je napůl upekl a přišrouboval k zásuvce.
Je to kompletní PITA.
Objednal jsem si čtyři; ty tři, které jsem neotevřel, půjdou rovnou zpátky a jsem na trhu s lepšími meteorologickými strážemi.
(Přiznejme si to; neexistuje nic takového, co by veverky skutečně „zmátlo“)
Miluji mnoho z rysů těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které mé nové rostlinné sazenice dostávaly z okna.
Miluji mnoho rysů těchto světel.
Klady: Za prvé, oni svorky snadno na mé polici, a ohýbají se do mnoha pozic, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou chladná na dotek a nezpůsobila žádnou škodu ani při dotyku s rostlinami.
Věřím, že mé zelenině prospívají světla.
Světla jsou stmívatelná, ale používám jen nejsilnější nastavení.
Časovače jsem nevyužil, raději je zapínám a vypínám sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silné, aby byly primárním zdrojem světla pro rostliny školky.
Světla jsou malá!
Až zhasnou světla, budu si muset koupit celou novou jednotku.
BEWARE...SMELL IS VERY BAD...CARD SLOTS TOO BIG!
Když jsem to poprvé uviděl, řekl jsem si, že je to krásné, ale vonělo to TAKÉ ZLÁŠTĚ.
Zpočátku jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že je MOLD vůně.
Nikdy neodešel, tak jsem ho musel vrátit.
PLUS, kapsy pro kreditní karty jsou příliš velké.
Kreditní karty sklouznou až dolů, tipy se nezobrazí, takže nemáte ponětí, která karta je kde a je velmi obtížné se z ní dostat.
FOTOGALERIE, KTEROU PŘEKVAPUJÍ KARTY, JE NEDOSTATEČNÁ.
Je to velmi malé.
Dostal cestovní pásek na peníze a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych si ji nekoupil a ještě se budu muset poohlédnout po něčem větším.
Dobrý deštník, koupil bych ho znovu, kdybych musel
Za prvé, musím říct, že barva je zamilovaná.
Spousta věcí, které si objednávám ve fialové, jsou vždycky moc lehké, moc dětinské, moc divné, moc neonové.
Ale tahle fialová byla hluboká a svěží a moc se mi líbí, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, co jsem kdy měl.
Dodává se s krytem a i když to nemusí mít moc funkční použití, to opravdu udržuje to vypadá ostrý.
Balení je hrozné – obdržel 3 poškozené kytary
Moc pěkná kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Nesnažte se přijímat takové, které nejsou poškozené.
Vrátili jsme 2 z důvodu poškození při přepravě a 3. byl také poškozen.
Vzdal jsem to.
Odesílají ho v měkkém tenkém kufříku s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné vycpávky.
Skvělý koncept!
Jen potřebuje nějaké další vylepšení, aby to opravdu úžasné produkt
Fakt super koncept, když přijde na karaoke.
Miluju karaoke, takže tenhle mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý – růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možností souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené, způsob, jak to funguje je, že současně působí jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Celkem máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co vychází.
V samotném mikrofonu ale není žádná hudba.
Má bluetooth konektor, takže si ho synchronizujete s telefonem a stáhnete si karaoke aplikaci, která umí posílat karaoke písničky do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení hlasitosti hudby a vašeho hlasu (také samostatně!)
a dokonce má možnost nastavit úroveň ozvěny, takže vlastně zníte, jako byste byli v karaoke místnosti.
Některé věci, které bych chtěl vidět budoucí zlepšení jsou: 1) tam je nějaké nepříjemné zpětná vazba, která se nezdá jít pryč bez ohledu na to, jak daleko jsem si telefon od mikrofonu.
Jestli jsi na to přišel, rád bych to věděl!
2) volby přepínače ve středu mikrofonu je neohrabaný.
Jsem blázen do minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly udělat design uhlazenější.
3) podpora více karaoke aplikací Konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne přes plochou obrazovku nebo centrální obývací reproduktor systém, není to tak zábavné v prostředí party.
Pokud to výrobce dokáže nějak integrovat do většího party karaoke ekosystému, tak by to udělalo tohle nekonečno zábavnější.
Ribbed off by Vision Supplies
Říjen 2017 zakoupil čtyři (4) kazety od Vision Supplies – Amazon Marketplace, takže bych měl v případě potřeby a ušetřit náklady na dopravu.
Za posledních pár let jsem použil dvě, asi jednu za rok, a fungovaly dobře.
Minulý týden jsem zkoušel použít jeden, po vytištění 20 štítků skoro prázdný, ale v posledním mi došel po 40 stránkách.
Plastika chybí na obou.
Vypovídaná záruka vypršela!!!!
Kdo by kontroloval každou jednotlivou kazetu, kdyby ji obdržel????
BUYER BE AWARE!!!!!!!!!!!
Promiň, cože?
Můj přítel mi doporučil masku této řady, tak jsem koupil tohle, tenhle kondicionér a všechno v jednom mléce.
Nemohu mluvit o účinnosti výrobku, protože zápach byl prostě nesnesitelný.
Znáte ten zatuchlý zápach, který staré budovy používají na ženských záchodech, aby zakryly zápach *dam*, ale ukázalo se, že to je jen kyselý, chemický, zatuchlý pach babičky?
To je všechno, co mě napadá, když cítím tohle.
Víš, různé tahy, různí lidé, tak se ti možná ta vůně bude líbit.
Můj přítel řekl, že to může pomoci i nejvíce poškozené vlasy, takže pokud vám nezáleží na vůni pak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že více a více přírodních linek je prostě nezajímá, protože se to stejně bude prodávat, a tak teď všechno voní jako těsto na hraní.
Ztratil jsem pár oblíbených vět, když měnili vzorec na levnější ingredience.
Nevím, jestli je to tak, nebo jestli je to padělek (na který jsem volal Davinesovi a oni řekli, že není), ale tohle smrdí jako Y U K a musel jsem ho vrátit.
Zahodí internet
Modem/router jsem koupil asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale za poslední rok plus jsem měl problémy s tím klesá internet.
To se děje na všech mých zařízeních, jak Wi-Fi a drátové.
Jediný způsob, jak obnovit službu, bylo provést reset střídavého proudu.
Tohle se dělo jednou nebo dvakrát denně.
Vyšel Comcast, spustil novou koaxiální linku z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Kluci z Arris Tech byli skvělí, ale nedokázali vyřešit problém.
Navíc jsem ztratil 5G službu ve třech případech.
Musel jsem provést reset továrny, abych to obnovil.
Na základě svých zkušeností nemohu tento modem/router doporučit.
Koupil jsem si modem/router Netgear AC1900.
Je to fantastické.
Měl jsem to více než týden bez problémů.
Je rychlejší a dolet je větší než u Arrisu.
Na internetu jsem četl, že ostatní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte Comcast internet nedoporučuji tento modem/router Arris.
Získejte Netgear, jeho mnohem spolehlivější.
ale stává se to dost, aby to bylo otravné.
Na pozitivní notu
1 z ventilátorů zněl z rovnováhy z krabice.
Ovládání otáček je opravdu vratké – pokud je vytočíte na 100%, ventilátory se vypnou, takže je třeba ho zapnout na 100% a pak ho pomalu vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že je to stejné pro většinu těchto typů výrobků v tomto cenovém bodě.
Nohy pro držení notebooku, když je nakloněný, se párkrát ulomily...
Vrátí se tam, ale stává se to dost, aby to bylo otravné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z průduchů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem doprostřed a poskytují velmi malý přísun vzduchu do notebooku s takovou konfigurací chlazení.
Ok případ s vážnými omezeními
Tento případ je v pořádku, ale ne výjimečný – 3,5 nebo 4 max.
Problémem je, že pro Tab A 10.1 w S pero je k dispozici méně případů.
Z nich je Gumdrop asi nejlepší, ale má některé vážné problémy.
Pouzdro z gumy (silikonu, čehokoliv) je velmi hladké a hladké a nedává vám moc sebedůvěry, když držíte Tab jednou rukou.
Tabulátor A je těžký, takže pokud si lehnete a sledujete video, pouzdro vám sklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový štít, který kryje obrazovku, protože to narušovalo ovládání dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní gumový vnější kryt působí opravdu pružně a chatrně.
A nakonec nám ztížili cestu k peru S.
Pero S je v pravém zadním dolním rohu Tab A a díky nim se malá gumová chlopeň, která chrání roh, zhoupla dozadu pro přístup k peru S.
To znamená, že aby se pero S dostalo ven, musí se klapka zhoupnout o 180 stupňů.
To je opravdu trapné a těžké dělat s jednou rukou.
Tento kufřík odvádí dobrou práci při ochraně mého Tab A, ale s těmito závažnými konstrukčními nedostatky jej nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Vše, co jsem potřeboval
Tento produkt je opravdu hladký – jedna zastávka nakupování pro všechny mé potřeby připojení.
Miluju házet tohle a moje notebooky malinký napájecí adaptér do mého go batohu a být připraven pracovat na velkém 4k displeji nebo pořizovat fotky z mého fotoaparátu.
Jediná divná věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačů usb-c, které jsem vyzkoušel od různých značek), je, že mac je zřejmě nemůže poznat rozdíl mezi násobky stejného monitoru (takže můj mac výstupy stejné video na všechny stejné monitory připojené k rozbočovači, ať už HDMI a / nebo VGA).
Ale pokud použiji 2 samostatné huby/adaptéry nebo 2 různé modely monitoru pak mac správně výstupy na displeje jednotlivě.
Ok, potřebuje nějaké zlepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký bezpečnostní zámek nad tlumičem (byl zmáčknut spíš náhodou, když jsem ho měl v kapse, než že bych ho chtěl použít) moji psi se dokonce po šlápnutí na ovladač nechtěně zapnuli.
Také pokud váš pes rád válet v mývalí hovínka jako můj dělá to je taková bolest v zadku čistit.
Když se fekálie dostanou mezi praskliny zařízení, což vyžaduje, abyste to celé rozebrali, pořádně to vyčistili a dostali ten zápach ven.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebuješ výhled, aby to fungovalo.
A byly chvíle, kdy nefungoval vůbec, I když jsem jen 30 stop od svého psa.
Být dobíjecí je jistě pěkná vlastnost a náboj vydrží dobrou chvíli.
Mně stačí nabíjet jen jednou za dva týdny.
Dostaneš, za co si zaplatíš.
Hrozný produkt, zkreslený
Koupil jsem si to jako sledovací zařízení, abych to mohl použít při plavání, a ani jsem neměl pořádnou šanci to vyzkoušet.
Za prvé, není voděodolný a nedoporučuje se ho používat při plavání podle návodu k obsluze.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB zástrčku nebo počítač.
Fajn, máme jich tu spoustu.
Když se ho ale snažím dostat do přístavu, aby se nabil, tak se zase vypouští.
Nejsem si jistý, jestli je tu něco, co není kompatibilní, nebo jestli je to jen špatně udělané, ale nebudu sedět a držet svůj přístroj uvnitř, zatímco se nabíjí.
A konečně, aplikace neustále objevuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílal textovku, což je velmi znepokojující.
Pak jsem vypnul všechny aktivní aplikace v telefonu, a viděl ještě další reklamu, když jsem šel zkontrolovat čas o 20 minut později.
Hrozný produkt, myslím, že dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přemíra na popruhy
Tento batoh vypadá dobře a dobře si vede.
Je to hodně, zvláště když to porovnáte s tím, co batohy stojí teď dny.
Důvod, proč jsem shodil hvězdu, je, že je tam příliš mnoho popruhů.
Na té tašce je víc popruhů, než dokážu spočítat.
Skončím s odřezáváním a vypalováním těchto přídavných popruhů, protože většina z nich není opravdu nutná a jen překáží při otevírání a zavírání tašky.
Kromě toho jsem si vyrobil novou školní brašnu na vysokou.
Vzadu v batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se vejdou do kapes, které jsou k dispozici.
Vlajka je také skvělým zakončením.
Můj pes ho ještě nezničil.
Měl jsem problémy s Hockey Balls.
Můj pes je miluje – její oblíbená aportovací a žvýkací hračka – a plavou.
Dokud je nerozžvýká na kousky.
Vyzkoušel jsem jich několik, dokonce i verze s „horkým počasím“ – a vydržely o pár minut déle než ostatní.
Dokud se neobjevili tihle.
Tyhle obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavý v tom, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj v psovi.
Daisy a já máme palec nahoru.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme baterii zkontrolovali a zjistili jsme, že do prostoru, kam baterie patří, natekla voda.
Baterie samotné shnily a vytékala z nich černá tekutina.
Při pohledu na konstrukci se zdá, že není možné, aby byl kryt baterie vodotěsný, což znamená, že nejenže voda vnikala do prostoru během koupání, ale část toxického materiálu také vytekla.
Prosím nekupujte tento produkt.
Jsem šokován, že bylo povoleno jít na trh i přes tak zjevnou vadu.
problémy s přehříváním a problémy s připojením regulátoru
I dávat to 3 hvězdičky pro tuto chvíli, nechci zanechat špatnou recenzi pro prodejce, pokud si to zaslouží, ale tento drone přehřívá hodně.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale asi zkusit oba jen vidět, co říkají.
Líbí se mi, že dron je cool hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí více jako hračka než tento.
Nicméně jeho jediný drone jsem kdy měl problémy s přehříváním a to vlastně bere zábavu z létání im bude předpokládat, že nyní jeho výrobní problém, který je třeba řešit co nejdříve, pokud chtějí tam produkt být úspěšný.
Opravdu doufám, že mi prodejce neposlal použití dron, jak jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, jak to dorazí 1 den po zakoupení.
Budu aktualizovat datum mé recenze po kontaktování prodejce a dji tello.
O téhle dárkové tašce můžu říct jen dobré věci.
K téhle sadě dárkových tašek můžu říct jen dobré věci.
Podařilo se mi zabalit všechny vánoční dárky s taškami, dárkovým balením a hedvábným papírem.
Produkt je velmi kvalitní a díky různým velikostem je snazší vybrat ten pravý pro každý dárek!
Vřele to doporučuji.
Prodávající je naprosto milý a pozorný.
Po nákupu mě oslovil, aby se ujistil, že jsem se svým produktem spokojená.
Pět hvězdiček kolem dokola!
Fyzika je hrozná a lidé, kteří tu hru vytvořili, s tím nic neudělají.
Nekupujte tuto hru fyzika jsou hrozné a já jsem tak naštvaný na tuto hru, protože pravděpodobně existuje asi 40 hackerů na každou hru a hru.
Nedělají s tím nic. Prostě nechají hackery dělat, co chtějí, a pak vědí, že ta hra je hrozná, ale nedělají s tím absolutně nic a hra pořád dokola aktualizuje jejich postavy. To, co by měli aktualizovat, je fyzika, protože je to hrozné, nekupujte tuhle hru. Fyzika je hrozná a mechanika je hrozná. Lidé, kteří tu hru postavili, byli očividně na vysoké úrovni, protože je to jedna z nejhorších her, co jsem kdy v životě hrál, bych si radši zahrál Pixel Games v téhle kravině. Je to jedna z nejhorších her, nekupujte ji.
Ne jako ostatní hrobky Raider hry
Od samého začátku to nebylo cítit jako ostatní hrobky lupič hry.
Hratelnost je brutální v tom, že ovládací prvky nejsou chytré v tom, že víte, jakým směrem se snažíte vydat.
Nechat tě padnout na smrt tím nejpodstatnějším způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tahle hra se mi nelíbila.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomické a cenově dostupné, ale nepříliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou tu žádné ostré rohy, o které by se dalo zachytit, a s napájecím kabelem jako trvalým nástavcem je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští v akčním hraní, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžké ruce a mají tendenci opotřebovat 2-3 ovladače za rok.
Takže pro nás každoroční investování do kontrolorů znamená, že musíme být vybíraví a obezřetní v tom, co kupujeme.
Ovladač by si mohl vystačit s odolnějšími pružinami; po několika měsících přestanou reagovat tlačítka, která se používají nejvíce, a pravý joystick ztratí své vycentrování, IE- nechá obrazovky s mapou přiblížit a postavy kráčejí vpřed, aniž by se dotkly ovládacích prvků.
Dostaneš, za co zaplatíš.
Byl jsem zklamán, když jsem obdržel tento předmět, protože stříbrná část, která obepíná obličej, vypadala, že je vyrobena z nějakého laciného plastu.
Nezklamal mě ani tak fakt, že byl vyroben z plastu, jako fakt, že díky použitému plastu vypadal neuvěřitelně levně.
Pro mě tenhle detail zničil celý můj vzhled.
Také jsem nevěřil, že vydrží každodenní nošení, a tak jsem ho nakonec vrátil.
Byl jsem zklamaný, protože to vypadalo, že by to byl dobrý obchod, kdyby nebylo toho.
Nicméně, pokud můžete přehlédnout, že, pak by to mohlo být pro vás to pravé.
Bylo dobře zabaleno a dorazilo rychle.
Nic jako předchozí Stylo telefony, MASILNÉ DISAPPOINTMENT.
Měl jsem originální Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je jasné, že se mi Stylos opravdu líbil, vzhledem k tomu, že pokaždé, když vyšla nová, koupil jsem ji.
Nikdy proto, že jeden měl problémy nebo zlomené, jen proto, že jsem chtěl zůstat aktualizován a „v obraze“ a já jsem udělal.
Ze všech těch telefonů jsem ani jednou neměl problémy se samotným telefonem.
Když jsem si koupil Stylo 3 přes Virgin Mobile, věděl jsem, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale mýlil jsem se, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak předchozí Stylos byl tak úžasný.
Nikdy se mi ani nepodařilo tento telefon úspěšně převést na můj účet Virgin Mobile.
S tímhle telefonem jsem si pohrával necelý týden.
Hledal jsem informace na internetu a dělal jsem různé hovory zoufale se snaží dát Stylo 3 výhodu pochybnosti doufal, že to byl jen já dělat něco špatně, ale bohužel jsem ztrácel spoustu času tím, protože to bylo 100% telefon se všemi problémy, které jsem nechtěl přiznat.
Nesnáším fakt, že musím dát Stylo tak hrozné hodnocení a recenzi, ale byl jsem extrémně zklamaný s tímto telefonem.
Doufejme, že LG ups jejich hru a může zlepšit budoucí Stylos, pokud existují, ale to byl obrovský BUST.
Na druhou stranu, vrácení a vrácení peněz proběhlo hladce, ale to je tak všechno.
