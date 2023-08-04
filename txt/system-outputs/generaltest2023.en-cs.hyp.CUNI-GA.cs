Hacknutá verze rytíře Jedi se hroutila, protože vyvolávala funkci na konci vtablu
Ukázalo se, že se předpokládalo, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má další metody připíchnuté na konec ve srovnání s IDirect3DViewportem, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože se jedná pouze o vytvoření viewportu pomocí Direct3D objektu, ne Direct3D3 objektu.
Nyní, chápu, že v praxi, IDirectXObject2 je typicky správná nadmnožina IDirectXObject, bez změněných signatur funkcí, a nové metody pouze přidány na konec.
To však neplatí všeobecně; pro tyto případy záleží na tom, jaké rozhraní používáte k vytvoření daného objektu
Takže každopádně, protože to zde platí, abych to opravil, musel jsem rozšířit implementaci viewportu o metody IDirect3DViewport3 tak, aby volání na nový bylo platné.
Předpokládejme pro účely argumentace, že věda se alespoň zčásti skládá ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoliv teorii, kterou by mohly podpořit.
I kdyby byla pravda, že taková fakta ve vědě existují, je stále možné argumentovat, že vědecká fakta jsou zatížena teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta na základě tohoto čtení, ale volba toho, které experimenty provést, kontroluje, která fakta budou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplývat pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby mohly dopadnout jinak.
Toto je velmi stručný náčrt hodnověrného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
To není argument ve prospěch existence objektivních vědeckých faktů, kterým já nevěřím.
Bude to moje první projektové auto
Vyzvednu si to o víkendu.
Hledal jsem dobré první auto pro chlapa, a opravdu se mi líbí ta estetika 80. let.
Už na stočených závitech a snížené jízdní výšce.
Udělal jsem malý průzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zážitky?
Vím, že nejsou rychlé ve srovnání
Větrám se do Fediversova času.
Domácí partner a já jsme dnes večer zašli do obchodu s alkoholem pro pár piv a láhev bubu
Když jsme se šli odhlásit, pokladní byla celkem zřejmá #trans žena.
Já, v prkenných kraťasech a s mlátičkou na manželku, a Domácí partner, celý potetovaný a s novým účesem, který on sám popsal jako „dělající ze mě neonacistu“.
Její tělo okamžitě ztuhlo a v očích se jí objevil výraz strachu.
A pak jsme prostě... zaplatili za naše věci
A poděkovali jsme.
A řekl jsem, že její nehty vypadají cool.
Úsměv úlevy na její tváři byl skvělý pocit, ale to, že byla vyděšená jako první, to mi došlo.
Tohle je ta nejhloupější časová osa a nesnáším ji.
Donaldu Trumpovi nic nebrání v tom, aby kandidoval na prezidenta v době, kdy je obžalován, poté, co byl usvědčen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se omilostnil, aby se dostal z vězení.
Ale nemůže se omilostnit ze státního vězení.
Chtělo by to guvernéra státu.
Dvěma státy, kterých se to týká, jsou New York a Georgia.
Guvernér Kemp nepochybně Trumpa omilostní, bude-li usvědčen nebo dokonce obžalován okresní prokurátorkou Fulton County Fannie Willisovou.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikace v reálném světě nemůže být redukována na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického Lewisova (1969) signalizačního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména dokazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový výskyt dostačující.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové rozčlenění významů symbolů.
Ukazujeme, že ekologická omezení v referentní volbě příjemce mohou být jednostranně využita odesílatelem, aniž by na straně příjemce existovaly rozcestníkové možnosti.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Domníváme se, že kontextově závislá komunikace je situovaný vícevrstevný jev, zásadně ovlivněný vlastnostmi prostředí, jako je například rozložení kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale přesto umožňují téměř dokonalou přesnost komunikace.
Moc se mi líbilo o víkendu pokecat s Penny a Nicholasem z Ashanti Development a popovídat si o jejich pokroku.
Ashanti Development pracuje se stále rostoucím počtem komunit v ghanském regionu Ašantá již téměř 20 let, navazuje kontakty s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, aby mohly zakotvit a podpořit svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase a podporoval řadu projektů.
Když jsme to o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména v oblasti výsadby stromů a podpory zemědělství.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšenou úrodu díky řadě intervencí od podpory nákupem vybavení až po školení.
Nicholas pracuje se zemědělci na omezení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je například opadavý červ, který může ničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS v mé blízkosti mi nedovolí napsat štítek nebo psát na krabici
Musí štítek vytisknout.
Nedovolí mi, abych jim řekl adresu, na kterou jde a kdo ji posílá.
Musím poslat nějakou náhodnou adresu s neformátovanými daty, aby si úředník mohl e-mail přečíst a zadat ho do svého systému, aby mohl vytisknout štítek.
A za tuto „pohodlnost“ mi vždy účtují 2,25 dolaru
Druhý den ráno a já se nemůžu přenést přes to, jak Chris Licht včera večer na CNN hanebně předstíral žurnalistiku veřejné služby.
Byla to nehoráznost, něco jako symbolický protidemokratický festival lží a křivd 6. ledna, který sebedestruktivně pořádala americká média.
ŠAMEFULNÍ AUDIENCE.
Licht SE DOHODL před celým republikánským publikem
Kdo prověřoval a vybíral osoby?
Tam se bude psát reportáž.
Sledovanost – hledání klamné nezodpovědnosti za to vše
To se nemůže opakovat.
Mám v suterénu hodně průvanu, což v podstatě znamená, že se sem může uchýlit spousta hlodavců.
Za poslední zhruba měsíc se objevila spousta známek výskytu většího počtu hlodavců, což bylo výjimečně překvapivé, protože je jaro a já bych si myslel, že se se změnou počasí vydají ven.
Nicméně jsem si nechal rozmístit několik obyčejných starých lapačů a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, protože myši je laskavě olízly dočista.
Včera v noci jsem se konečně téhle rutiny nabažil, vyčistil jsem všechny pasti od arašídového másla a přilepil na ně pistácie.
Fungovalo to
(fwiw, vyzkoušel jsem skoro všechny „humánní“ pasti na trhu, ale s velmi malým úspěchem.
Nijak zvlášť se mi nelíbí, že je zabíjím, ale komentáře k etice zabíjení myší přijímat nebudu.)
Už mě nebaví, jak se konzervativní strany a vlády zahalují do značky podporující byznys.
Nejsou, aspoň ne v Albertě.
Jistě, že snížili daně pro podnikatele.
Zároveň však snižují granty a daňové úlevy, které podporují větší podnikatelskou aktivitu.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne kvůli ní.
Zjistil jsem drsným způsobem, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělávají peníze, ale všechny ty nesmysly se zdají být kontraproduktivní, pokud odhánějí lidi pryč.
To platí i teď, že goatse.cx je pryč, i když by to byl těsný závod ke dnu mezi goatse a řekněme khou.com, kde jsem se snažil sledovat video, které mi poslala Wendy.
V prvním vlaku se kontrolorka jízdenek podívala na naše jízdenky a řekla „dlouhá cesta!“
„Jo a dneska se vrátím,“ řekl jsem.
„Jenom ho vysadím v Glasgow,“ pokusil jsem se mu vysvětlit a ukázal na svého spolucestujícího.
„To se moc neslyší 'Jenom ho vysadím v Glasgow',“ řekl prodavač letenek
Je to věc, kterou jsem také nikdy předtím neřekl.
Věc, která mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpizmus je kult.
Je to kult, který nikdo doopravdy nechce, kromě fanatiků, kteří v něm jsou.
A oni jsou opravdu blázni
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas bránit se
Jděte ven a protestujte.
Pořiďte si nějaké samolepky, které jsou proti Trumpovi a polepte je všude.
Křičte na ty, kteří by se snažili mluvit přes nás.
To není normální.
To není v pořádku...
Můj soused i já jsme dorazili domů ve stejnou dobu a přes ulici jsem slyšela, jak vykašlává slizovitou smršť.
Tak jsem spěchala do svého apt, abych se mu vyhnula, ale on mě přesto stihl dohnat, aby si pokecal.
Přísahám, že kovatidou infikovaní lidé jsou zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné vyjít ven na veřejnost nebo se vrhat na lidi, když vykašláváte slizovou smršť.
Znovu opakuji Není společensky přijatelné, aby se tvá hnisavá hlenová bouře šířila všude!
Writing Wonders 5/11: Směje se tvůj MC víc, nebo pláče?
Abe skrývá svůj zármutek a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví hrubý humor.
Jan ti ublíží dřív, než ti dá najevo, že je zraněná, a nejvíc se směje, když je všechno vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4000 útrapách se Yl ocitá na místě lásky a má obrovské pocity, se kterými si neví rady, takže je tam hodně obojího.
#CNN se prostě musí zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo v té ubohé, umírající televizi byl zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který „manažer“ kabelové televize volal, aby dal tlustému, prolhanému zločinci tolik vysílacího času?
Vysoký tlak bude převládat až do počátku příštího týdne
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno IR družice a pozorování na povrchu indikovaly rozšiřující se oblast s nízkými vrstvami a nesourodostí < URL >
Bláznivý student Arnie Cunningham se zamiluje do Christine, zrezivělého Plymouthu Fury z roku 1958, a stane se posedlý obnovou klasického automobilu její někdejší slávy.
Jak se vůz mění, mění se i Arnie, jehož nově nabytá sebedůvěra se za volantem jeho exotické krásky mění v aroganci.
Partneři Salesforce
Codleo je jedním z nejlepších partnerů Salesforce nabízejících nejlepší služby Salesforce šité na míru vašim firemním potřebám.
Potřebuješ pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije své odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám může partner Salesforce pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což vašemu podniku umožní prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších věcí na tom, že se moji sousedé obracejí proti mně, je přemýšlení o tom, kolik úsilí stojí být nepřátelský.
Zapomeň na mě. Fajn.
Ignoruj mě. Fajn.
Bolí to, ale musíš to udělat.
V tomto bodě se však otevřené nepřátelství a násilí ještě zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře před nosem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A pořád nemám ani tušení, co jsem mohl udělat, abych si tohle zasloužil.
Měli klíče od mého bytu více jak 6 let
Ta loď je nepřístupná.
Jsem si vědom vaší nenávisti vůči Organě.
Ona je pro mě irelevantní
Můžete ji zabít, pokud budete moci.
Ale na palubě této lodi často létá jiný jedinec
Kdyby zemřel... následky by byly... značné
Hodně si stěžuji na tátifikaci.
Zde je (o něco delší) rychlokurz toho, co mám na mysli pod pojmem tátifikace:
Není to můj termín, je to termín používaný k popisu toho, když je vyprávěcí či herní mechanika postavena kolem ústředního protagonisty (obvykle staršího, obvykle mužského pohlaví), který hlídá jinou osobu (často mladšího)
The Last of Us je snadným a kanonickým příkladem tátifikace.
Joel využívá své schopnosti a schopnosti provádět (extrémní) násilné činy ke splnění úkolu, který je kódován jako „starostlivý“.
Tádeifikace obvykle předpokládá, že řešením situace, kdy se rodičovská postava musí starat o dítě nebo jeho zástupce chránit, je zdrcující síla a použití této síly k vynucení velmi specificky tvarované mocenské dynamiky.
Tátování nahlodává možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoliv instituci, kterou dítě má.
V tomto směru představuje tátifikace zastání mnoha neoliberálních ideálů, zejména myšlenek jako je bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je stručný přehled, jak využít naše webové stránky.
- Když je letenka v prodeji, rozesíláme upozornění.
- Poskytujeme odkazy, kde si můžete zarezervovat jízdné.
- Neprodáváme jízdenky, ani neúčtujeme předplatné.
- Více podrobností je v úplném příspěvku na blogu.
- Udržujeme seznam příkladů termínů rezervací pro každý obchod, který uveřejňujeme, a tento seznam aktualizujeme několikrát denně
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Nepředstavitelný strach, teror a vysídlení jim však zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezident von der Leyen setkal v Kyjevě s první dámou Olenou Zelenskou, aby s ní projednal, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Už jsme jim nabídli pomoc v oblasti duševního zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže tuto cestu zvládnout.
Hromada zářivých nových dobrot v #dart
Postupem času se šipka stala mojí oblíbenou volbou pro rychlé uživatelské rozhraní
#flutter je radost s nimi pracovat a mají #mobx pro snadnou správu obchodu.
Příběh závislosti je taky méně šílený než nodejs.
Samozřejmě, že flutter je opravdu na nic, pokud jde o chování, jako by se chovala dobrá nativní aplikace (vlastně kdekoliv. Dokonce i flutter web target je na nic)
Ale umožňuje se pohybovat rychle a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými hroty.
Jsou průměrně vysoké, mají průměrnou postavu a jsou svalnatí.
Jejich ocas je extrémně tlustý
Vlasy mají malinové, krátké a kudrnaté.
Oči mají hruškovité a nosí šarlatové brýle značky cateye.
Jejich nejzajímavějším rysem jsou jejich dobré skutky
Hledáte seznam nejlepších upířích her na PC?
Schopnost skákat opravdu vysoko, trhat normální lidi na kusy, používat strašidelné magické síly a doplňovat zdraví hodováním na nepřátelích – to by mělo být základem všech PC her, abych byl upřímný.
Navzdory nejlepším snahám Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze udělat je špatnými – všichni ...
Zdálo se mi, že moji rodiče hráli mou porno hru a dávali mi zpětnou vazbu.
Ve skutečném životě se mámě líbila puzzle hra, kterou jsem před lety vyrobil, a většinu tajemství našla sama, takže nebyla jen mámou, když řekla, že se jí to líbí.
Takže možná se jí bude taky líbit moje porno hra?
Možná je v ní příliš mnoho jazykových jemností
Potřebuji to přeložit do mandarínštiny a / nebo hokkienštiny, ani jedno z toho vůbec neznám.
Asi budu muset zjistit, jestli je Bing nebo Google lepší v překládání sprostých gay sexuálních hříček.
Chvíli jsem si pohrával s touhle myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od „běžného“ zdraví.
Proč ?
Protože se to děje v mysli a zdá se to být méně hmatatelné než fyzické zdraví.
Popravdě, zdraví vaší mysli, vašeho mozku, je stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce rozpoznáván pomocí TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými vnímáno jako méně „skutečné“ než zdraví fyzické, mám pocit, že bytí trans je pouze intersexualitou mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více se mi tvrzení „Moje pohlaví je mužské, moje pohlaví je ženské“ zdá zjednodušené a nepřesné.
Skoro to vypadá jako postoupení části argumentu TERFům.
Cítím, že být trans znamená být „biologicky nebinární“.
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení „nebinární“ je třeba rozšířit z pouhého genderového termínu, který se má používat při odkazování na sex.
S přestávkami jsem poslouchal díla @iotar
V záloze tohohle záhadného společenstva je hodně dobrých věcí.
Jako krauty nálady a další světská pop music a radiofonické workshopy a všechno možné.
Velmi stojí za to to zkusit
FWIW Rozhraní archive.org se mi líbí mnohem víc než desktopové # bandcamp\ – Nemám tušení, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrávám s Flutter.
Nerad bych zakládal svůj byznys na technologiích od Googlu, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými podněty k vytvoření přesvědčivého zážitku napříč platformami a je to znát.
(A také: Web je nyní bohužel z velké části věcí Googlu)
Také se prosím zdržte toho, abyste mi říkali, že google/flutter aplikace jsou na iOS a macOS k ničemu.
Cross platforma je těžká, pokud to chcete udělat dobře.
To vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci do Leasey.
Na světlo vyšlo několik velmi malých problémů.
Nic, co by rozezvučelo poplašné zvony, ale přesto se to řeší.
Příští týden bude vytvořena malá aktualizace, která je opraví.
Většinu včerejška jsme strávili instalací nové aktualizace pro některé zákazníky a každý, kdo tuto pomoc potřebuje, by ji už měl dostat.
Přeji hezký den!
Technické přiznání: Grafana & Prometheus mi nejde do hlavy, alespoň z hlediska metriky serverů/aplikací a monitorování.
Nevím přesně, proč na to můj mozek nemůže přijít; mohlo by to být tím, že nástroje jsou prostě tak široké a vágní, že můj mozek je prostě zablokovaný kvůli 'příliš mnoha možnostem'.
Chci vyrábět palubní desky.
Grafana vypadá hezky.
Mozek nepracuje.
Takže když se blíží nový raid tier #FFXIV, dlouho jsem si říkal „člověče, rád bych zkusil pořádný raiding, ale Party Finder zní jako bordel a nikdy nenajdu statickou elektřinu, která by mě dostala.“
Tak jsem si řekl: Kašlu na to!
Vyrobím si vlastní statickou elektřinu!
Plno lidí, kteří jsou příliš nedočkaví na to, aby se pokusili připojit k raid static, bez očekávání, že budou vůbec dobří!
... to by asi v žádném případě nefungovalo!
...A tak jsem se ocitl v situaci, kdy jsem musel sestavit rozpis nájezdových skupin.
V mládí jsem byl vášnivý čtenář.
Pak mi život rozdrtil duši a ztratil jsem veškerou vášeň pro beletrii a skvělé vyprávění příběhů.
Ale po desítkách let, kdy jsem skoro nic nečetl (s výjimkou funkčních prací nesouvisejících s beletrií a občasné svépomocné knihy), jsem si dal za cíl přečíst v roce 2023 23 knih.
Jsem teď na knize # 31 a je teprve květen.
Jsem ZPĚT, baby!
Nedosáhl jsem vlastně ničeho.
Jsem šťastný, že za mnou pár lidí přišlo v soukromí a řekli: „Podívej, kvůli vší tvé práci ti dám takovou sumu peněz.“
Chci vidět, jak ty společnosti, co zprostředkovávají transakce, vysvětlují svým zákazníkům, jak si stanovují procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud bude mít Spotify dobré čtvrtletí, tak ano.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Znovu.
Tihle lidé chtějí zlepšit svůj život
Bílí nacionalisté, zbraňoví fetišisté, pro-diktátorská pravice... to je nebezpečí.
Deportujte bílé rasisty.
Jsem tak unavený z titulků, které tvrdí, že „Práce na dálku je mrtvá.“ nebo že „Práce na dálku byl neúspěšný experiment.“
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele jedné velké společnosti.
Je to všechno klikací návnada, ale dělá mi to starosti ohledně vedoucích pracovníků a manažerů, kteří tyto články čtou.
Práce na dálku existovala před rokem 2020.
Stále budou existovat pracovní místa, která lze v dohledné budoucnosti vykonávat na dálku.
Práce na dálku je povolena
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístup každému, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim ubírá čas od jejich dne a od rodiny.
Ignorovat tyto skutečnosti je špatné.
Přestaňte zevšeobecňovat a pokuste se pochopit, jak vaši zaměstnanci vlastně dělají svou práci.
#WFH #podnikání #neurodiverzita
Nejde jen o konzervativce versus progresivisty, řekl na semináři více než stovky přívrženců v Grande Prairie.
„Tohle je válka mezi pro-lidmi a proti-lidmi,“ řekl.
Parkerová se zmínila o potratech a o popudu moderních městských žen odkládat narození dětí kvůli kariéře.
Tvrdí také, že NDP a progresivisté chtějí kvůli životnímu prostředí společnost vylidnit.
„Vy jste ten uhlík, který se pokoušejí snížit.“
Tak jako od začátku u všech mých narozenin v minulosti, vždycky jsem měla ty drsné.
Kdykoli se vynořil květen, děsila jsem se zkoušet slavit svůj bday.
Vždycky se něco stane, pokazí se to nebo to prostě skončí stresem a depresí.
Celé roky jsem bojovala, abych se z toho dostala a měla lepší dny.
Trvalo mi roky změnit svůj život a tvrdě pracovat, ale nakonec...
Začínám se usmívat a užívat si svůj den bez starostí.
A dnešek už se stává skvělým dnem!
Do zimy v této malé části Velkého Jižního Světa zbývá 30 dní.
Ale já se nemůžu nechat oklamat!
Tohle je začátek.
Padá déšť a dokud není zmrzlý, nebudeš v něm tancovat!
Dnes je dobrý den na objednání zmrzliny.
Byla to jedna psí noc a ten pejsek nevstal z postele ani na „Psí snídaně – Snídaně pro psa!“
Zazipuju si podšívku do cyklistické bundy – jen pro případ, že bych ji potřebovala mít uvnitř.
Znáte účinný způsob, jak webová komponenta reaguje na přidání / odstranění z dokumentu?
Jedná se o knihovnu komponent Wikipedie (OOUI).
Většinou jde o sémantický HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
V současné době používáme hack MutationObserver.
Pro účely představení se nedíváme na celý dokument.
Vytvoříme detašovaného dočasného rodiče, nainstalujeme tam MO a sledujeme, jak se stává detašovaným (tedy připojeným někam jinam).
Krysák Casper je v dnešní době naprostá jednotka
Myslím, že moje nová práce mu prospěla – dvě volné toulky denně, zatímco já pracuji, a to v celkem předvídatelných časech.
Konečně jsem si pořídila dobrou fotku, abych si mohla být jistá, že není tlustý.
(U #krys může být příliš vysoký obsah tělesného tuku škodlivý pro jejich zdraví.)
Není tu.
Je prostě naprosto zničený z toho, jak dvakrát denně řádí v mé kanceláři.
Nemám váhu, abych ho zvážila, ale má pocit, že váží přes půl kila.
Jsem tak šťastná, když vidím, jak se mu daří.
Dnešní průběžná zpráva Aerostrike:
1) Drobné úpravy mapového rozložení Hel's Fighters.
Navíc menu mapy je plně funkční!
2) Systém měnových odměn byl připojen.
Zítra bude testována různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal spoustu a cítím se mnohem lépe ohledně polních položek.
Všechny krkovice, kapusta, mangold jsou transplantovány.
Plány na zasazení salátu v Pennu na 6řádkovém vzoru a uvidíme, jak se to srovná s vysíláním osetých záhonů.
Objevují se jarní hrášky v Gilpinu, takže treláž je třeba nastavit.
Také je třeba tam nasadit salátovou řadu, aby se do obou začlenila sekaná zelenina. Mám školenou posádku na zavlažování, přípravu záhonů a přesazování, což je 90% nesklízených dovednostních položek.
Je rok 2023 a já stále vidím, jak se lidé s iPhony aktivně vyhýbají používání Apple Maps.
Apple Maps přichází s iOS standardně, a přesto by si lidé do svých iPhonů Google Maps stahovali a instalovali.
Netuším proč.
Zvědavě jsem si nechával otevřenou mysl, abych porovnal, jak si Google Maps a Apple Maps stojí v porovnání na mém zkušebním iPhone (můj denní ovladač je zařízení s Androidem, takže iPhone používám jen zřídka).
Zkušenost s dodržováním pokynů byla na Apple Maps mnohem lepší než na Google Maps.
Apple Maps vítězí.
Tak proč lidé skáčou přes obruče navíc, aby si nainstalovali Google Maps?
Netuším.
Mohlo to být tím, že se Google Maps dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že je Google Search integrován s Google Maps?
Netuším.
Tím chci říct, že jsem zaujatý.
Jsem ve prospěch neprozrazování odpadků koncovým uživatelům a Apple to královsky posral se svými Apple Maps, když to vyšlo v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale právě půda z něj dělá dobrého skladníka bohatství tak dlouho, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Dům sám o sobě klesá na hodnotě, protože ztrácí svůj stav a je třeba ho vyměnit.
Hodně lidí si myslí, že jim země doslova patří, když si koupí kus.
Tohle není ten případ.
V Číně si můžete jen pronajmout půdu.
Nejsou tak hloupí, aby to prodali navždy.
Vláda může tuto politiku změnit, kdykoliv se jí zachce.
Ten pozemek je dočasný.
Zdá se nemyslitelné, že by vám jednoho dne mohla být odebrána půda, když sledujete australské a americké mediální kanály, ale to je proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl přemýšlela určitým způsobem.
Jednoho dne jim vláda velmi snadno a rychle odebere půdu, pokud to budou chtít udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si ppl může udržet půdu na úkor ostatních.
Jednoho dne to musí být odstraněno
To je důvod, proč Číňané povolují pouze pronájmy.
Už jim došla půda.
Na úspěch, naplnění snů, přátelství, na prosté, ale pravdivé!
Všem investorům tam venku připiju na váš úspěch a uskutečnění vašich snů
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si prostých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirma#geolog #podnikání #udržitelnost #úspěch #přátelství #přípitek #sny
Často přemýšlím nad lidskou schopností být *tak* sama sebou, když je zaplavena tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a pocitem viny ve světě, kde je „úspěch“ tak často připisován lidem zodpovědným za ty nejhanebnější činy...
Všichni jsme taková špinavá zvířátka
Ale mírnit zoufalství nad naší chaotičností je klíčové – protože nám to dává více prostoru k tomu, abychom se vypořádali s rozvalinami všude kolem.
Tak se snažte nezapomínat, jo?
Laskavost k sobě samým je taky aktivismus.
Někteří programátoři: „Na rychlosti psaní nezáleží!“
nebo „Modální editory jsou dnes k ničemu“ :morty:
Me extrahování funkčnosti mých #Axum projektů do sdílených knihoven: „Hold my keyboard“ :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, zda je to nejlepší přístup pro sdílení, ale líbí se mi to zatím: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva pro tento týden ve Zjevení zní Zůstaň vzhůru celou noc.
Už pár dní si pohrávám s tímto malým kouskem na mé hlavě.
Je to rozhodně víc romantika než špína
Možná jsem četla mnoho románků s nemožnými 'meet cutes' a tohle je výsledek, ale líbí se mi to.
Taky jednoho dne určitě udělám ten mílový orgasmus, možná ne se str
Nesouhlasím s tím, že je těžké #Mastodon nastavit.
Common, to opravdu není tak těžké
Ale je mnohem těžší najít lidi, které byste sledovali a vytvořili si časovou linii.
Přál bych si, aby nějak existovalo doporučení „koho následovat.“
Ale kromě toho to není těžké – pokud používáte aplikaci třetí strany, jako je Elk a/nebo Ivory.
Pokud se držíte výchozího webového rozhraní, nevypadá to dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali a pravděpodobně potřebujete dobrou aplikaci pro vylepšení #UX.
Nevím, jestli je prevence možná, ale stojí za to to zkusit.
Čtyři kroky, které jsem nastínil, jsou předmětem diskuse, přičemž v každém z nich bylo dosaženo určitého pokroku.
Popis: Názvy pro případy chování lidí-algoritmů, které počítají s algoritmy a lidmi.
Vysvětlení: vysvětlete obě strany vzájemného vlivu
Prognóza: předvídání škod dříve, než k nim dojde (i když jen o minuty)
Intervence: znalosti o tom, co můžeme udělat pro to, abychom dosáhli změny, v rámci jistých mezí důvěry
Nedíval jsem se na CNN, ale vypadá to, že Trump říkal přesně ty samé věci, které říká pokaždé, když otevře ústa nebo stiskne v telefonu Send.
I kdyby je nestihl vyslovit na radnici, každý v Americe je stejně uslyší, a to opakovaně, od teď až do listopadu 2024.
Stále to není důvod, proč mu dát jiné místo, ale škoda je zveličována.
On vyhraje primárky
Nemůžeme ho poslat pryč.
Je tady a bude říkat tyhle věci, ať se stane cokoliv.
Přihlásil jsem se do čekací listiny „AI Test Kitchen“ od Googlu a dostal jsem se tam ve stejný den.
V tuhle chvíli je to velmi zdrcující.
Demo „MusicLM“ je mírně zajímavé
Můžete požádat o konkrétní hudební skladbu jako „jazz s trumpetovým sólem v 5/4 tempu“ a po pár vteřinách vám vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... ta hudba prostě... není dobrá.
Házet všechno, co máte, přes plot v reakci na GPT, to není ono.
Snažte se víc googlit.
Je divné dělat vzpírání, ale zároveň nemít ani ponětí, co je váš one-rep-max, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám ve své ložnici bez zaměřovače nebo dokonce stojanu na váhy.
Jenom já a činka se spoustou závaží.
Tlačím bench press na mé posteli.
Pokud se pokusím přijít na to, že můj rep max je jeden, možná nevlastním dost závaží na to, abych se dostal na maximum, nebo naopak by mě to mohlo vážně zranit / zabít.
Každopádně, zátěž dneska stoupne.
Pořád je to dobrý pocit
Přísahám, že burrata před pěti lety neexistovala.
Je to můj osobní Mandelův efekt.
Nikdy jsem to neviděla v kuchařce.
Nikdy jsem to neviděla v luxusním obchodě ani v žádném italském lahůdkářství.
Nikdy jsem neviděla, že by to vyrobila něčí máma, nebo že by mi to někdo strčil na večírku, nebo že by se to objevilo ve spojení s něčími eskapádami při výrobě omáček nebo pečení
Prostě se to jednoho dne objevilo a najednou to bylo k dostání všude
Vstoupil jsem do dimenze burraty.
Drakeovi stárnoucí iPad se rozpadá, takže je na trhu s novým tabletem.
Vzhledem k tomu, že jsme se zde radikalizovali, zdráháme se koupit si nový stroj FAANG*.
Má někdo Linuxový tablet, který se mu líbí?
Ten by byl určen hlavně pro prohlížení webu, příležitostný e-mail a některé hry.
V roce 1998-06 Gamefan, v souvislosti s dlouhým vývojem první hry Unreal, Jason Schrieber poznamenal:
„Dobrá hra má zpoždění jen do doby, než dorazí.
Špatná hra je špatná navždy.“
Takže to byl Epic, kdo vytvořil tohle?
Můžeme dál pokračovat
Starší číslo GamePro 1997-11 má citát s mnohem větší nejednoznačností,
„Anebo, jak se říká v jedné průmyslové frázi: Pozdní hra má zpoždění jen do doby, než dorazí.
Špatná hra je špatná pro zbytek tvého života.“
Je to tedy tak pomíjivé?
Pouhá hláška bez jasného původce?
Smoky, moje desetiměsíční koťátko Domestic Blue, si hraje s červeným gumovým utěšovacím přístrojem Apple Pencil zakoupeným od Amazonu a před několika měsíci utekl.
Hrdě ji nosí v puse po celém domě a já se musím jen v duchu smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsem absolvoval kompletní okružní jízdu novým vlakem ICNG.
Moc se mi to líbí.
Pozor na vagóny s většími okny.
Jsou tu oblasti, které by potřebovaly trochu vyleštit.
Jmenovitě nedostatek popelnic a nedostatek cedulí, které by vysvětlovaly význam světelných barev.
Vyřešte ty drobnosti a můžeme jich pak mít víc, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Pro každého zákazníka platí jedno pravidlo, protože se snažíme zajistit, aby se každý, kdo se postaví do fronty, mohl dostat k tabuli.
Můžete si koupit JEDNU z výše uvedených tabulí, ne jednu z každé.
Na Picos ani jiné zboží neplatí žádná omezení nákupu.
Včera jsem se skvěle bavil se svým přítelem a bývalým rabínským kolegou.
Navštívili jsme ho na pár hodin na mé verandě
Takováto přátelství přesahují rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Bůh vám žehnej a ochraňuj vás!
A bažina se zazelená.
Docela se mi líbí akkoma software a doménové jméno, které jsem dostal pro můj případ.
Ale mám pocit, že jsem tenhle případ začal tak říkajíc špatnou nohou
A nikdy jsem se tam necítila pohodlně.
Ještě se tu trochu déle zdržím a přemýšlím o tom, jestli bych vůbec měl migrovat.
#FalconGameBooks
Zdá se, že osmoocí repnidové pozorují, jak přistáváte s létavcem na červené půdě, ale nepohnou se směrem k vám, ve skutečnosti jsou nehybní, když vystoupíte z létavce a pomalu kráčíte směrem k nim.
Země pod vašima nohama se začne chvět a pak se začne otřásat, jako při zemětřesení, a vy ztrácíte půdu pod nohama, i když Repnidé se zdají být nedotčeni.
Skála pod vámi náhle povolí.
Repnidé se prokopali pod povrch a vy padáte do vařící se masy stovek těl Repnidů v jeskyni dole.
Konec je rychlý, neboť několik párů tesáků vstříkne svůj smrtící jed a vzduch z Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jste byl prvním budoucím lidským cestovatelem.
Přistanete s letounem nosem vzhůru na boku hromady strusky a vylezete ven.
Osmoocí Repnidové vypadají, že se dívají, ale nepohnou se směrem k vám, ve skutečnosti jsou nehybní, když se k nim pomalu blížíte.
Zastavíš se ještě na hromadě rozdrobené skály a hlíny a promluvíš k nim se slovy: „Přicházím v míru, jako přítel.“
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladač nezachytí žádnou odpověď.
Rozhodnete se použít své Psychické Vědomí, abyste se s nimi mentálně spojili.
Je těžké pochopit smysl jejich myšlenek; jsou děsivě cizí a vaše mysl před kontaktem couvá.
Usoudíte, že navázat znovu kontakt by bylo nebezpečné a vrátíte se ke svému letounu, ale tento zážitek vám vyčistil mysl, která byla zmatená už od chvíle, kdy jste skočili do budoucnosti.
Jakmile se vrátíte zpět do Falconova křídla, zjistíte, že je docela snadné určit kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste během skoku spotřebovali další polybdenovou tyč.
[pokrač]
#dnes mám kávu, sluníčko a klid!
Začala jsem nosit nový šál.
V této chvíli si tím nejsem jistá
Našla jsem nestejně spředenou stříbřitě šedou přízi, která je z větší části jemně spředená nerovnoměrně.
Plánuji ji smíchat s jemnou fialovo-šeříkovou pestrobarevnou bavlnou.
Ale nejsem si jistá, jestli mám dost té fialové
Používám háček H s podobným dvojitým háčkovaným vzorem, jako jsem to dělala již dříve.
Včera večer jsem udělal první spojení, tak uvidíme
Přeji všem šťastný čtvrtek!
Nicméně nesnáším hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Doslova jsem to zkusila a upustila od KAŽDÉHO JEDNOTLIVÉHO
A ještě asi před dvěma lety jsem o tom neměl ani ponětí, dokud jsem si nezkontroloval přepisy.
Nenávist v hodinách literatury je ještě horší: miluju čtení.
Většinu klasiky jsem stihl do osmnácti – i když to je spíš odraz toho, že žiju někde v zapadákově, v zoufalství jsem četl i Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a já jsem tam šťastná, ale musím být někde jinde, abych se během dne dostatečně zchladila a mohla číst beletrii bez pocitu viny.
Je to jako bych byla na prázdninách, a proto dělám to, co člověk dělá o prázdninách.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma a trochu jsem si #MECFS odnesl z toho, že jsem prostě byl v cizím prostředí, kde jsem méně schopen krotit se a pamatovat si, kde co je.
A to i přesto, že stále mám svůj seznam úkolů a také si organizuji svůj život.
Lidstvo bude venku za 5 dnů
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které na práci ve hrách miluju.
Co si o tom lidé pomyslí?
Líbí se mi to, ale bude to schopné přilákat publikum těch správných hráčů?
Rozkvete komunita kolem uživatelem vytvořeného obsahového dílu hry?
(Opravdu doufám, že ano.)
Příběh, nápady a otázky, které hra vzbuzuje, jsou aktuální.
Doufám, že vše půjde dobře.
Dneska je den ThinkPadu!!
Přišel jsem domů o polední přestávce, abych viděl tohle sezení venku před uwu.
Přál bych si, abych si to mohl vzít s sebou do práce a připravit další.
Ale to bude muset počkat do večera.
Tak jsem se konečně podívala na #Heartstopper
Bylo to přehnaně roztomilé, až to vypadalo jako twee?
Zcela určitě.
Mluví některá z těchto postav s lidskými bytostmi?
Ani vzdáleně ne
Ale miloval jsem to?
Rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno vystudovaný umělec dnes večer špatně snášel kritiku
Zčásti proto, že by se učili špatně.
Ale je důležité nevymlouvat se na problémy a prostě je napravit, zvlášť ve výrobě, když vaše vedení potřebuje změnu.
Zvlášť, když je konkurence.
Každý umělec tam byl a udělal stejné chyby.
Dobrá kritika je tu proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost problém napravit, nebo najít řešení.
zatímco kompostování a posouvání květů jsou úžasnou připomínkou, jak se podívat nahoru a uvědomit si život mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak jsou semena vysévána a kultivována (a ne náhodně rozptýlena) dobrými lidé.
Tyto kořeny jsou skryté.
Práce není viditelná.
Ale pro silný a pevný budoucí růst.
Jami mu lístek podstrčila, když se míjeli na cestičce, těsně před psí hlídkou.
Ona byla na cestě ke zdi, on se vracel ze služby
Podíval se za sebe, aby viděl, jak odchází, a aby se ujistil, že je nikdo nezahlédl.
Neohlédla se zpátky.
Počkal, dokud se neocitl v temnotě ložnice, pak vytáhl lístek a přečetl si ho v paprsku světla, který pronikal zatemňovacími závěsy
Jedno slovo vytištěné v bloku.
Dlouho se na něj díval a snažil se zachovat klid:
V poslední době jsem potkal pár skvělých nových #Mastodon kamarádů a chci tento trend udržet.
Když volám do #Fediverse, připadám si jako velryba zpívající v obrovském oceánu!
Chceš se připojit k mému „podu“?
Obzvlášť bych se rád spojil s dalšími
Každý, komu kvůli CNN hoří vlasy, může děkovat Stephenu Colbertovi za ostrou pravotočivou zatáčku.
Pomohl udělat z Chrise Lichta národní problém.
I když by se nám někteří lidé mohli líbit, pokud fašistům jen zajišťují kariéru v nižší lize, asi by ji měli nosit.
Bylo to poprvé (ale nebude to naposledy), co Kaveesha Dilhariová vstřelila 20+ runs a dala 2+ wickets ve stejném T20I.
Připojila se k vybrané skupině srílanských žen, které dosáhly všestranného úspěchu v tomto formátu.
Policie zatkla 15 lidí po násilném protestu před hotelem pro uprchlíky ve Velké Británii.
Incident se stal poté, co se zvýšil počet uprchlíků a žadatelů o azyl, kteří na lodích přepluli kanál La Manche do Spojeného království.
Policie zatkla 15 lidí po protiuprchlické demonstraci před hotelem, v němž byli ubytováni žadatelé o azyl, která se stala násilnou nedaleko anglického města Liverpool.
Policejní oddělení v Merseyside uvedlo, že jeden policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer v Knowsley.
Policejní síly uvedly, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zadržení lidé ve věku od 13 do 54 let byli zadrženi „v důsledku násilných nepokojů“.
Policejní komisařka v Merseyside Emily Spurrellová řekla Radio City: „Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zraněných.“
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který Knowsleyho zastupuje v britském parlamentu, řekl, že násilí v pátek večer neodráželo komunitu.
„Lidé z Knowsley nejsou bigotní a jsou vstřícní k lidem, kteří utíkají z některých z nejnebezpečnějších míst na světě a hledají bezpečné místo,“ řekl.
„Ti, kteří dnes večer na tomto protestu demonstrují proti uprchlíkům, nereprezentují tuto komunitu.“
Protest se konal za zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů přeplouvá kanál La Manche v malých člunech.
Touto cestou se v roce 2022 do Spojeného království dostalo více než 45 000 lidí a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se kvůli politickým zmatkům a byrokratickým průtahům zpomalil, takže mnoho žadatelů o azyl uvízlo v hotelích nebo jiných dočasných ubytovacích zařízeních.
Přechody přes kanál La Manche se staly politickým tématem, přičemž konzervativní vláda slíbila, že „zastaví lodě“ a uskutečňuje plán poslat takové žadatele o azyl do Rwandy.
Odpůrci obviňují vládu, že démonizuje zoufalé lidi, kteří prchají před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v úvodním zápase sezóny v Brandywellu
Derry záložník Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City vyšlo z Prezidentského poháru vítězně, když porazilo 2:0 Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops se ve druhém poločase snažili snížit stav, ale Ruaidhri Higginsovi svěřenci stáli pevně za vítězstvím.
Derry cestuje do St. Patrick's Athletic na úvodní zápas ligy příští pátek.
Patchingův boční volej postrčil Derry do vedení po 23 minutách – střední záložník otevřel skóre, když Foylesider loni v únoru vybojoval nad případnými šampiony výhry 2:1.
Hoops pak vyhráli Premier Division o 13 bodů, ale Duffy brzy dostal City dál do vedení dalekonosným úsilím, které se dokázalo vykroutit pod brankářem Leonem Pohlsem do sítě.
V minulé sezoně byli soupeři o dva góly lepší v rozehrávce.
Graham Burke byl nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byli pohodlnými vítězi týden před jejich cestou za národní slávou.
Šéf města Ruaidhri Higgins ocenil svůj tým po tom, co řekl, že to byl „nejtěžší týden mého života“ po smrti jeho bratra Kevina.
„Je to kopanec do zubů a čekají nás těžké týdny, ale na jeho památku s tím budeme pokračovat,“ řekl Higgins.
„Porazit Shamrock Rovers a zaslouženě tak dobrým výkonem je opravdu potěšující.“
DHS najala advokátní kancelář, aby se postarala o případné řízení o odvolání Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí advokátní kancelář Debevoise & Plimpton, aby pomohla s možným řízením o odvolání ministra Alejandra Mayorkase, protože ten potenciálně čelí obvinění ze strany republikánů ve Sněmovně reprezentantů ohledně jeho nakládání s jižní hranicí.
„Ministerstvo vnitřní bezpečnosti si najalo externího poradce, aby pomohlo zajistit, že zásadní poslání ministerstva nebude přerušeno bezprecedentními, neoprávněnými a stranickými snahami o odvolání některých členů Kongresu, kteří již podnikli kroky k zahájení řízení,“ uvedla v pátečním prohlášení mluvčí DHS.
„DHS bude nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic a zároveň bude náležitě reagovat na více než 70 výborů a podvýborů Kongresu, které mají nad DHS dohled.“
Úředník DHS sdělil CBS News, že ministerstvo najalo firmu na smluvně zadanou práci na dobu trvání kongresového vyšetřování.
Debevoise byla vybrána kvůli svým odborným znalostem v oblasti impeachmentu a zkušenostem obou stran při spolupráci s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP via Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva se společností Debevoise je pro DHS považována za přiměřený výdaj.
DHS se snaží zajistit, aby její poslání nebylo ohroženo partyzánskými útoky a aby řízení proti Mayorkasovi vedli lidé s odpovídajícími odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na dotaz ohledně vyšetřování impeachmentu minulý čtvrtek řekl novinářům: „Budeme spolupracovat s tímto Kongresem, stejně jako jsme spolupracovali s minulým Kongresem. Myslím, že je to naše odpovědnost.“
Připustil, že „to bude nějakou dobu trvat“, než se podrobí vyšetřování Sněmovny
„Budu ten čas trávit stejně jako ostatní a také nebudeme ohrožovat čas, který strávíme plněním našeho poslání.“
Vysoký úředník DHS potvrdil, že se Mayorkas ještě nesetkal se svým novým externím právním zástupcem.
Pouze jeden člen vlády byl dosud odvolán, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulysses S. Granta, obviněn z přijímání úplatků, ale nakonec byl Senátem zproštěn viny.
Trendové novinky
Díky za čtení CBS NEWS.
Čtyři mladiství byli obviněni z útoku na 14letého mladíka, který zemřel na sebevraždu po bití, video bylo zveřejněno na internetu
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři mladiství z New Jersey byli obviněni v souvislosti s útokem na čtrnáctiletou dívku, která si později vzala život poté, co bylo video s incidentem zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z těžkého ublížení na zdraví, dva mladiství jsou obviněni ze spiknutí za účelem spáchání těžkého ublížení na zdraví a jeden mladistvý je obviněn z obtěžování, řekl v e-mailu CBS News prokurátor okresu Ocean Bradley D. Billhimer.
Čtrnáctiletá Adriana Kuchová byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video útoku na střední škole Central Regional High School.
Na videu bylo vidět, jak dívky házejí po mladistvé skleničku a pak ji kopou a vlečou školní chodbou.
Strčily Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kuche opakovaně udeřila pěstí.
Jiná dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli útok rozehnat, přičemž jeden dospělý děti od sebe odtrhl.
Adriana ležela zraněná a pohmožděná na podlaze chodby, zatímco se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: „To je to, co dostanete.“
„Milovala život. Ona byla to nejšťastnější dítě Všichni ji milovali,“ řekl ve čtvrtek CBS New York její otec Michael Kuch a dodal, že je naštvaný a chce, aby všichni viděli video a to, co mladiství udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že policie měla být zavolána okamžitě, protože studenti, se kterými prý měla jeho dcera problémy, jí rozbili obličej dvacetikilovou lahví
„Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejňovaly videa ze školy,“ řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
„Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni,“ řekl CBS New York doktor Triantafillos Parlapanides, superintendant škol.
Vedení školy řeklo CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do dalšího soudního líčení, řekl prokurátor CBS News.
Studenti školy uspořádali ve středu pochod na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, o kom víte, že je v emocionální tísni nebo v sebevražedné krizi, můžete se dovolat na linku 988 Suicide & Crisis Lifeline, a to telefonicky nebo prostřednictvím SMS zprávy 988.
Můžete si také popovídat s 988 Suicide & Crisis Lifeline zde.
Další informace o zdrojích a podpoře péče o duševní zdraví získáte na lince HelpLine Národní aliance pro duševní onemocnění (NAMI) od pondělí do pátku od 10 do 22 hodin.
ET, na 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvila jsem s 30 profesionály z oblasti zdraví a wellness o tom, jak se vyhnout vyhoření.
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v našich zaměstnáních.
To může být extrémně obtížné pro ty, kteří pracují ve zdravotnictví, a proto jsem položila 30 zdravotníkům a wellness profesionálům stejnou otázku: „Jak zvládáte svou energii a nevyhoříte ve své profesi?“
Jejich kariéra sahá od lékařů infekčních chorob přes psychology až po učitele všímavosti – a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vynikala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Budovat silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří trpí nevyléčitelnými nemocemi, děkuje Eufrosina Youngová svému silnému podpůrnému systému za schopnost udržet si energii.
Youngová je certifikovaná neuroložka a specialistka na ALS na oddělení neurologie Upstate University Hospital a říká, že se tam „mobilizují jako armáda lidí“.
Na amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo se usilovně snaží vyvinout léčbu a zajistit lepší možnosti pro své pacienty, udržuje Youngovou i v těch nejtěžších dnech.
„Neneseme na sobě tíhu světa, ale jsme součástí světa lidí, kteří se o tuto práci zasazují,“ říká.
2.Odpočívejte, když potřebujete
Pracovat ve dvou zaměstnáních jako spánkový výzkumník a algoritmický inženýr, to vše při péči o nové dítě, by Raphaela Vallata rozhodně dovedlo k vyhoření, kdyby si neodpočinul, říká.
„Mám pocit, že když se chystám vyhořet, v podstatě mi každý úkol připadá jako hora, kterou musíte zdolat, a připadá mi to strašně naléhavé a důležité,“ říká Vallat.
V těchto chvílích „si opravdu potřebujete vzít nějaký čas volno a uvědomit si, že tyto úkoly mohou počkat.“
Vallat si ve svém dni obvykle najde chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil před návratem do práce.
3.Buďte zapálení pro to, co děláte a pamatujte si svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně po sedm dní v týdnu.
Pobyt v první linii během pandemie jí ubíral téměř veškerý čas, ale vyhoření se vyhnula tím, že si připomněla, proč je její práce důležitá.
„Nemyslím si, že práce působí jako práce, když máte pocit, že máte vliv,“ říká Gounder.
„Pokud pracujete v šílené pracovní době a děláte něco, co pro vás nemá žádný význam, myslím, že byste opravdu měli ustoupit a zamyslet se nad tím, co vlastně děláte.“
4.Mějte jiné radosti
Na druhé straně každý z odborníků uvedl, že se věnuje nějakému koníčku, jako je cvičení, tanec a dokonce i hra na kytaru.
Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho dosáhnete ve své práci, říká Christina Maslachová, sociální psycholožka, profesorka psychologie na univerzitě v Berkeley v důchodu a autorka knihy „The Burnout Challenge: Managing People's Relationships with Their Jobs“.
„Podívejte se na svůj život jako na celek a ujistěte se, že jsou na něm dobré věci, a ujistěte se, že na ně máte čas.“
Získejte zdarma od CNBC Warrena Buffetta Průvodce investováním, který vydestiluje miliardářovu první nejlepší radu pro běžné investory, udělej to a nedělej to, a tři klíčové investiční principy do přehledného a jednoduchého průvodce.
Zaregistrujte se nyní: Buďte chytřejší o svých penězích a kariéře s naším týdenním newsletterem
Mladík obviněn z vraždy při prosincové střelbě ve škole v Chicagu, která si vyžádala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při prosincové smrtelné střelbě na dva studenty na střední škole v Chicagu, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou pokusů o vraždu, oznámil chicagský policejní superintendant David Brown.
„V současné době nemáme jasný motiv, proč by šestnáctiletý chlapec chtěl střílet a zabíjet další děti,“ řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoliv Brown uvedl, že obvinění z vraždy a pokusu o vraždu bude čelit jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběťmi, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti je pomohly dovést k podezřelému, který byl ve čtvrtek zatčen.
„Jsme vděční za ty, kteří byli natolik stateční, že se přihlásili, aby zajistili, že pachatel bude chycen a bude nyní pohnán k odpovědnosti,“ řekl státní zástupce okresu Cook Kim Foxx.
Podezřelý by měl v sobotu předstoupit před soud v Bond Court, kde budou představeny další podrobnosti o důkazech, které nashromáždili.
Minnesotští biologové zachránili uvězněného černého medvěda
Minnesotské oddělení přírodních zdrojů přišlo na pomoc medvědovi nešťastnému poté, co uvízl v příkopu.
Medvěd se podle příspěvku na Facebooku oddělení skrčil ve stoce u silnice poblíž Wannasky v Minnesotě.
Když ale sníh začal tát, kanál se začal zaplavovat a medvěd byl uvězněn v hlubokém sněhu a ledu, jak tvrdí ministerstvo.
Zaměstnanci oddělení rychle zareagovali na místo činu a pomohli medvěda odstranit.
biolog oddělení Andrew Tri podle příspěvku na Facebooku „medvěda vyšetřil a prohlásil, že je zdravý, ale omámený – zřejmě proto, že byl probuzen ze zimního spánku“.
Oddělení pak medvěda přemístilo do státního útulku, aby obnovilo jeho zimní spánek.
Ospalý masožravec byl podle odhadů 6 let starý a vážil mezi 375 a 400 librami.
Oddělení připomnělo obyvatelům, že stěhování medvědů je práce, kterou je lepší přenechat profesionálům.
Pokud se bojíte o medvěda ve svém okolí, měli byste se obrátit na místní úřady – nesnažte se spícího obra přemístit nebo nakrmit.
V tomto případě se kolemjdoucí nejprve pokusili medvěda sami vykopat a nabídli mu jídlo, včetně sušenek, salátu a krmení pro kočky Fancy Feast.
Naštěstí pro dobře míněné kopáče ale „protože medvědi nemají v zimě chuť jíst, medvěd nekousl“.
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se podle Oddělení přírodních zdrojů vyskytují hlavně v severní třetině státu.
Predátoři přezimují v zimě až šest nebo sedm měsíců, během nichž nejedí a žijí z uloženého tělesného tuku.
Fotografie: Egypt po restaurování slavnostně otevřel hrobky Djehutyho a Heryho
Hrobky Djehuty a Heryho byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedli generální tajemník Nejvyšší rady starožitností v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a předseda španělské Národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady starožitností a CSIC, která pracuje od roku 2002.
Uvedl, že mise prováděla vykopávky a restaurátorské práce a publikovala výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahradu.
Důležité hrobky z významné éry
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili během počátku 18. dynastie Nové říše – jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že rozložení hrobek je ve tvaru písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Jedná se o vchod, sloupovou síň vedoucí k pohřební šachtě a stěny s výraznými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a dohlížel na práce řemeslníků a umělců během vlády královny Hatšepsut.
Djehuty byl také zodpovědný za záznam Hatšepsutovy cesty do Puntlandu a za poskytnutí elektra (směsi zlata a stříbra) pro zakrytí vrcholků obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přemísťování obelisků.
V místnosti, která předchází Djehutyho pohřební komnatě, jsou nápisy s vyrytými 43 kapitolami Knihy mrtvých, což je poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátno a papyrus.
Hery zastával pozici superintendanta královských skladů posvátné královské manželky a matky Ahhotepové.
Jared O'Mara nikdy neměl být kandidátem Labouristické strany, říká Rachel Reevesová
Zneuctěný bývalý poslanec Jared O'Mara „neměl být nikdy vybrán jako kandidát labouristů“ a zaslouží si svůj čtyřletý trest ve vězení, uvedl stínový kancléř.
Rachel Reevesová v pátek hovořila s listem Guardian ve volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak labouristický národní výkonný výbor (NEC) kontroloval parlamentní výběrové řízení pro příští všeobecné volby.
Celá výběrová komise v Bolton North East rezignovala poté, co jim nebylo umožněno vybrat si užší výběr, což je stále častější praxe v labouristické straně Keira Starmera, která říká: „Opět se zdá, že labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu.“
Dodali: „To je v rozporu s postojem nutným k tomu, abychom získali zpět červenou zeď, která je tak zoufale potřebná k vytvoření labouristické vlády.“
Reeves řekl: „Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří byli vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.“
Zvláště nešťastné bylo, že Leigh Drennan, předsedkyně labouristické strany Severozápad a poradkyně poslankyně za Warrington North Charlotte Nicholsová podporující Jeremyho Corbyna, nebyla zařazena do užšího výběru, aby se pokusila získat křeslo zpět od konzervativců, navzdory tomu, že získala nominace od čtyř velkých odborových svazů.
Reevesová řekla, že s výběrem kandidátů nemá nic společného, ale dodala: „Vím, že je opravdu důležité, abychom měli přísné procesy ohledně toho, kdo může být zařazen do užšího výběru a kdo může být vybrán do užšího výběru.“
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota shledala, že předložil falešné žádosti o proplacení výdajů v celkové výši 52 000 liber ve snaze financovat své užívání kokainu a alkoholu.
Mnoho lidí naznačovalo, že nebyl náležitě prověřen labouristy, když byl vybrán, aby bojoval proti Nicku Cleggovi, bývalému místopředsedovi liberální demokracie, v Sheffieldském Hallamu v předčasných parlamentních volbách v roce 2017.
Na otázku, zda se O'Marův debakl rýsuje v myslích labouristické NEC, Reevesová odpověděla: „Nechci v žádném případě naznačovat, že kdokoli, kdo není na užším seznamu, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest.“
Okolnosti kolem O'Mary byly „dost výjimečné“, řekla Reevesová, ale uznala: „Labouristická strana a všechny politické strany si musí vzít z výběru kandidátů důležité ponaučení.
Ale také bych řekla, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě sledem premiérů a pokut a stran a standardů, které značně zaostávají za tím, co byste mohli očekávat.“
Dodala: „„Jedna věc, kterou bych o labouristické straně řekla, je, že když lidé udělají chybu, ztratí bič. A to prostě není případ Konzervativní strany.“
Archie Bland a Nimo Omer vás provedou hlavními zprávami a tím, co znamenají, zdarma každý všední den ráno.
Upozornění na ochranu osobních údajů: Newslettery mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Více informací najdete v našich zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme službu Google reCaptcha a platí Zásady ochrany osobních údajů a Smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku společnosti Openreach, která poskytuje širokopásmovou síť ve Velké Británii.
Poté, co sledoval učně, jak šplhají po předstíraných telegrafních sloupech na staveništi za 1,7 milionu liber, diskutoval Reeves o plánech labouristů na přepracování odvodů za učňovskou přípravu, které nutí větší firmy, aby dávaly stranou 0,5% své mzdy na financování učňů.
Podniky si stěžují, že poplatek je příliš nepružný. Například, řekl Reeves, Openreach „chce rekvalifikovat lidi, kteří pracují na mědi, na práci na vlákně, ale učňovské dávky nemají takovou flexibilitu, pokud jde o rekvalifikaci.“
Reeves řekl, že labouristé by změnili odvod tak, aby firmy mohly použít peníze na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a ty, které v současnosti montují plynové kotle.
„Potřebujeme je jako součást energetického přechodu na čistou nulu, aby se naučili dovednostem pracovat na elektrických vozidlech nebo montovat tepelná čerpadla nebo vodíkové kotle.
Chceme, aby tito lidé byli přeškolováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto je na ně uvalena daň z učňovského vzdělání.
Podniky chtějí větší flexibilitu a mladé lidi začínající v životě nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost,“ uvedl Reeves.
Jedna zatčená uprostřed protestu Tate Britain kvůli akci drag queen pro děti
Jedna osoba byla zatčena uprostřed protestu u Tate Britain, kde se konala událost s vyprávěním příběhů drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově vyhroceného komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nejsou hlášena žádná zranění a policisté zůstávají na místě, uvedla policie.
Tate v sobotu pořádala Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou webové stránky galerie popisují jako „první drag artistku v Evropě, která četla příběhy dětem v dětském pokoji“.
Pravicová skupina protestujících demonstrovala před galerií a setkala se s odpůrci vedenými bojovníky za trans-práva a politickými skupinami, včetně hnutí Stand Up to Racism.
Policisté museli vytvořit koridor, aby se návštěvníci mohli dostat na místo konání.
Drag queen napsala na Twitter, že den byl „řádně emotivní“, a dodala, že pět demonstrantů získalo přístup do Tate a „způsobilo rozruch“ v některých částech budovy, ale neovlivnili čtení.
Už dříve řekla Pink News, že pozvání do Tate na akci během měsíce LGBTQ+ historie bylo „ctí“.
Její čtení se v minulosti stávalo terčem protestujících.
Drag Queen řekla, že „posouzení rizik“ proběhlo předem – ale dodala, že je „směšné“, že bylo nezbytné.
Aida napsala na Twitter: „Do Tate se dostalo 5 nenávistníků. Způsobili narušení provozu ALE ne v Drag Story Hour UK... Udělali povyk jinde v budově, ne tam, kde byla show!! SHOW 2 šla jako po másle!!!“
Aida pořádala tři vyprávění příběhů v sobotu v 11 hodin, v poledne a ve 14 hodin.
Mluvčí Tate řekla: „Neprogramujeme umělce, abychom prosazovali konkrétní názory, ani abychom slaďovali odlišné názory.“
Naše galerie nabízejí široký program a návštěvníci mají možnost si vybrat, kterým jeho aspektům se budou věnovat.“
Trump's Prized 40 Wall Street Building On 'Lender Watch' Amid Dropping Income: Zpráva
Silně zadlužený mrakodrap Donalda Trumpa na 40 Wall Street je na „věřitelské hlídce“ uprostřed prudce klesajících příjmů a zvyšujících se nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72-patrové budově – Trumpově nejcennější – vyskočila na téměř 18% ve třetím čtvrtletí loňského roku, podle měsíčního podání na zbývající hypotéku ve výši 126,5 milionu dolarů, Bloomberg uvedl.
Výdaje mezitím údajně stouply o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 odhadnuta na 540 milionů dolarů.
V den teroristických útoků z 11. září 2001, které zničily World Trade Center a zabily 3000 lidí, se Trump chlubil v televizním rozhovoru, že 40 Wall Street je náhle nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, ale byla to také lež.
Další nedaleký mrakodrap na Pine Street v Dolním Manhattanu se stal po zničení Dvojčat nejvyšší budovou.
Pronájem kanceláří ve výškových budovách na Manhattanu už roky klesá, což se ještě zhoršilo po vypuknutí pandemie COVID-19, kdy mnoho společností ukončilo svou činnost a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, „se obrátila na dlužníka se žádostí o status nájemní výstavby“ a plány na zlepšení výkonnosti nemovitosti, jak uvedla agentura Bloomberg.
Majitel firmy Wagner tvrdí, že válka na Ukrajině se potáhne roky
Majitel soukromého vojenského dodavatele ruské skupiny Wagner Group, který se aktivně účastní bojů na Ukrajině, předpověděl, že by se válka mohla táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek řekl, že Rusku může trvat 18 měsíců až dva roky, než si zcela zajistí kontrolu nad východním průmyslovým centrem Ukrajiny, Donbasem.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a kterému se kvůli jeho lukrativním kremelským zakázkám na občerstvení přezdívalo „Putinův šéfkuchař“, znamenalo uznání obtíží, kterým Kreml čelil v kampani, kterou původně očekával ukončit během několika týdnů, když ruská vojska 24. února vtrhla na Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících nezdarů, když ukrajinská armáda zahájila úspěšné protiofenzívy s cílem získat zpět široké části území na východě a jihu.
Kreml se vyhýbá prognózám, jak dlouho by mohly boje pokračovat, a tvrdí, že to, co nazval „speciální vojenskou operací“, bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří Donbas, kde Moskvou podporovaní separatisté od roku 2014 bojují proti ukrajinským silám.
Prigožin řekl, že žoldáci Wagnerovy skupiny pokračují v zuřivých bojích o kontrolu nad ukrajinskou pevností Bakhmut v Doněcké oblasti.
Uznal, že ukrajinská vojska vyvíjejí zuřivý odpor.
V době, kdy ruské jednotky prosazovaly své útoky na Donbase, se Moskva také snaží demoralizovat Ukrajince tím, že je v kruté zimě ponechává bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Ve východních, západních a jižních regionech byla zasažena zařízení vysokonapěťové infrastruktury, což v některých oblastech vyústilo v výpadky proudu.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale kontrolovatelná“, a dodala, že se jedná o zálohování, aby se udržely dodávky elektrické energie, ale poznamenala, že v některých oblastech bude přídělový systém pokračovat.
Ukrajinský vojenský šéf generál Valerij Zalužnyj uvedl, že ruské síly odpálily od čtvrtka do pátečního poledne 71 střel s plochou dráhou letu, 35 střel S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět bezpilotních letounů.
Ukrajinské úřady později v pátek informovaly o dalších útocích zabijáckých bezpilotních letounů.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 bezpilotních letounů Shahed.
Ruští vojenští blogeři a některé ukrajinské zpravodajské servery zveřejnily v pátek pozdě večer video zachycující útok námořního dronu na strategický železniční most v Oděské oblasti.
Zrnité video zachycovalo rychle se pohybující objekt, který se přiblížil k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a explodoval v silném výbuchu.
Pravost videa nemohla být ověřena.
Ukrajinská armáda se k útoku nevyjádřila a Serhij Bračuk, mluvčí regionální správy, nepotvrdil útok bezpilotního letounu, když v sobotu hovořil v televizním projevu.
Most, který byl na počátku války cílem ruských raketových útoků, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM – Kazašští záchranáři pokračují v prohledávání sutin a pátrají po přeživších v Türkiye, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství trosek a nestabilních konstrukcí.
K dnešnímu dni vytáhl kazašský záchranný tým v Türkiye sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc je také poskytována nepřetržitě.
Zejména zemětřesení o síle 7,7 stupně, které zpustošilo části jihovýchodního Türkiye a severní Sýrie, udeřilo brzy v pondělí.
Počet obětí mohutných otřesů, které zasáhly jihovýchod Türkiye, dnes přesáhl 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM – Slavnostní zahájení 10. halového mistrovství Asie v atletice se uskutečnilo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Při zahájení akce předseda kazašské vlády přečetl uvítací dopis prezidenta Kassyma-Jomarta Tokajeva.
„Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je v Kazachstánu věnována sportu.
V naší zemi existují všechny podmínky pro provozování profesionálního a masového sportu
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex, který pojme přes šest tisíc lidí,“ stojí v dopise kazašského prezidenta.
Kazašští atleti úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání asijského mistrovství v Astaně dá nový impuls rozvoji atletiky v zemi, a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za jeho pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se koná poprvé na území SNS.
Turnaje se zúčastnilo přes 500 atletů z 31 zemí, kteří mají soutěžit v závodech, štafetových závodech, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí a všestranných závodech.
Turnaj má probíhat do 12. února.
Již dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoechová Kipkiruiová vyhrála ženské zlato na 3000 m a Olga Safronovová získala na turnaji stříbro v běhu na 60 metrů.
foto: primeminister.kz
Herec z Yellowstonu Q'orianka Kilcher porazil obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském senzačním procesu za pomluvu, dosáhla dalšího právního vítězství – tentokrát s hercem ze seriálu Yellowstone Q'oriankou Kilcherem.
Okresní prokuratura v Los Angeles v pátek zprostila dvaatřicetiletého Kilchera všech obvinění v případu podvodu s odškodněním zaměstnanců.
V prohlášení sdíleném v pátek s deníkem The Times mluvčí okresního prokurátora v Los Angeles uvedl, že soud „určil, že slečna Kilcherová nespáchala pojistný podvod a oznámil soudu, že nejsme schopni pokračovat“.
V červenci 2022 kalifornské úřady obvinily Kilcherovou ze dvou trestných činů podvodu s náhradami zaměstnancům a obvinily ji, že v období od října 2019 do září 2021 neoprávněně inkasovala více než 96 000 dolarů na dávkách pro invalidy.
Časový rámec zahrnuje také několik měsíců, kdy Kilcherová pracovala na Yellowstonu, a to navzdory hercovým tvrzením, že byla příliš zraněná na to, aby pracovala.
Kilcherová se sama vzdala a v květnu byla obžalována
„Dnes jsem více než vděčná, že byl můj případ zamítnut – zítra má cesta začne pomáhat zvyšovat povědomí a požadovat větší transparentnost práv zaměstnanců v rámci systému zaměstnaneckých náhrad,“ řekla Kilcherová v pátek v prohlášení, které sdílela s The Times.
Dodala, že „se těší na to, že vrhne více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji“.
Kilcher rovněž poděkoval Vasquezové a jejímu kolegovi advokátovi Stevu Cookovi z Brown Rudnick za „jejich neochvějnou víru v moji nevinu“.
Podle TMZ Kilcherová najala oba v září.
Kilcherová se rozešla s filmem Terrence Malicka „Nový svět“ z roku 2002, kde ztvárnila roli Pocahontas.
Mezi její tituly patří také „Synové anarchie“, „Alienista“ a „Dora a ztracené město ze zlata“.
Naposledy se objevila v road-trip filmu „Pes“ s Channingem Tatumem v hlavní roli.
K této zprávě přispěla redaktorka Timesu Christina Martinezová.
Šéf Balenciagy nazývá prázdninovou kampaň „hloupou chybou“
Značka luxusního oblečení Balenciaga se stále vzpamatovává z kritiky dvou svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal pod palbu kritiků kvůli propagačním snímkům, které podle kritiků sexualizovaly děti, umělecký ředitel Balenciagy Demna (celým jménem Demna Gvasalia) v rozhovoru pro Vogue, který vyšel v pátek, řekl, že ho obrázky stále mrzí.
„Chci se osobně omluvit za špatný umělecký výběr konceptu pro dárkovou kampaň s dětmi a beru na sebe svou odpovědnost,“ řekl Vogue a zopakoval tak předchozí prohlášení, které v prosinci zveřejnil na sociálních sítích.
V listopadu se značka podělila o fotografie pro svou kolekci „The Gift“, která představovala dětské modelky pózující s plyšovými medvídky oblečenými do bondage oblečení.
Krátce poté Balenciaga vypustil fotografie pro svou kampaň na jaře 2023, na kterých byla v pozadí stránka z případu Nejvyššího soudu z roku 2008, který se týkal „virtuální dětské pornografie“.
Rodiče, včetně hvězdy reality TV a dlouholeté fanynky Balenciagy – a partnerky značky – Kim Kardashianové, vystoupili proti značce a jejím „znepokojivým obrázkům“ na sociálních sítích.
O několik dní později Balenciaga vydala prohlášení, v němž se za fotografie omluvila a nastínila změny, které provede, aby zabránila podobným „chybám“ v budoucnu.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrázky, ve způsobu, jakým komunikujeme s naším publikem, a ve způsobu, jakým se učíme ze svých chyb a jdeme dál,“ řekl Demna pro Vogue.
Podrobně popsal změny po odezvách v Balenciagu: „restrukturalizace oddělení image“, provádění dalších interních a externích kontrol pro snímky z kampaní a partnerství s Národní dětskou aliancí, které má pomoci „tisícům dětí v procesu překonávání traumat a vyrovnávání se s jejich duševním zdravím“.
„Je to jediná věc, která mě na celé této hrozné situaci těší: udělat z toho něco dobrého,“ řekl o tomto partnerství, které bylo oznámeno ve středu.
Spolupracuje také s NCA Balenciagova mateřská společnost Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod Keringovým deštníkem je společnost Gucci, která v prosinci čelila kritice kvůli kampani s Harrym Stylesem, o níž někteří kritici na sociálních sítích tvrdili, že sexualizuje i děti.
V rozhovoru Denma řekl, že má v plánu oprostit se od „provokativních“ způsobů značky.
„Je to součást mého učení: budu mít zralejší a vážnější přístup ke všemu, co zveřejním jako myšlenku nebo obraz,“ uvedl.
„Rozhodl jsem se vrátit ke svým kořenům v módě i ke kořenům Balenciagy, která vyrábí kvalitní oblečení – nevytváří image ani buzz.“
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jednou z „nejbolestivějších“ částí odporu bylo pošpinění „jména Balenciagy a odkazu Cristóbala Balenciagy“.
„Balenciaga je dům, který je více než sto let starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem dělal vše, co bylo v mých tvůrčích silách, abych ho uvedl do moderního významu, a najednou jsme byli pod útokem a označeni jako něco, co vůbec nejsme,“ řekl Demna.
„Určitě jsme udělali obrovskou a hloupou chybu s kampaní na dárky a určitě jsme se z ní poučili.“
Je to falešná zpráva, CBN popírá, že nemá kapacitu tisknout další nové bankovky Naira
Nigerijská centrální banka (CBN) označila za zavádějící zprávu, která tvrdila, že cituje Godwina Emefieleho, guvernéra CBN, který současný problém v distribuci nově přepracovaných bankovek Naira připisuje nedostatku tiskových materiálů v Nigerijské společnosti Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN, Osita Nwasinobi, uvedl, že guvernér CBN nikdy takové prohlášení neučinil během své prezentace před Národní státní radou na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele na zasedání pouze sdělil, že NSPMC pracuje na tisku všech nominálních hodnot bankovek Naira, aby vyhověla transakčním potřebám Nigerijců.
Řekl, že zatímco CBN oceňuje obavy, které projevují všechny zúčastněné strany ohledně distribuce nových bankovek Naira, „jsme znepokojeni tím, do jaké míry se partikulární zájmy pokoušejí manipulovat fakty a stavět veřejnost proti bance“.
Nwasinobi řekl, že CBN je i nadále odhodlána vykonávat své funkce v oblasti měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (v platném znění).
„Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálu pro výrobu požadované odrážky Nairy.
„Banka proto chce apelovat na veřejnost, aby uvedenou zprávu nebrala v potaz a zachovala větší zdrženlivost, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi,“ dodal.
Ke konkrétní hlasové poznámce, která se objevila na sociálních médiích a která tvrdila, že CBN plánuje zavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že žádný takový plán neexistuje a že tvrzení jsou nelogická a neodpovídají fungování nigerijského bankovního systému.
„Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický záměr CBN a jsou to pouze zoufalé pokusy osob, které se snaží veřejnost proti bance poštvat,“ uvedl.
Tim Sherwood se po bezútěšném debutu v Tottenhamu rozplakal na 44 milionů liber při podpisu smlouvy s Pedrem Porrem
Porro měl odpoledne, na které se dalo zapomenout proti Leicesteru (Obrázek: Getty)
Tim Sherwood se pustil do „absolutně nechutného“ bránění Pedra Porra během porážky Tottenhamu 4:1 s Leicesterem City.
Spurs podepsali s obráncem ze Sporting CP v den uzávěrky přestupů původní smlouvu o půjčce za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
Třiadvacetiletý hráč dostal svůj debut od Antonia Conteho v sobotu na King Power Stadium a jeho tým se ujal vedení po 14 minutách přes Rodriga Bentancura.
Ale změnilo se to v mizerné odpoledne s Nampalysem Mendym, Jamesem Maddisonem a Kelechim Iheanachem, kteří skórovali a dali Leicesteru v poločase skóre 3: 1 a Porrem, který vydržel prudký první poločas v Premier League.
Španěl opět chyboval, protože Leicester si myslel, že přidali čtvrtý gól přes Barnese a zatímco gól byl vyloučen kvůli ofsajdu, bývalý trenér Spurs Sherwood zůstal šokován defenzivním úsilím Barnese.
„Nechci se do toho kluka dál navážet, ale musí být uvolněn ze svých povinností,“ řekl Sherwood fotbalistům v sobotu.
Dám mu za pravdu, protože je to jeho debut, ale Pedro Porro není špatný, to je neuvěřitelné.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden říkal, že utratili hodně peněz, ano, utratili, ale jejich nábor byl velmi špatný a tohle je poslední přírůstek.
Nedělejme teď žádné závěry, ale dívám se na hráče, který se nechce bránit.
Více o: Premier League
„Antonio Conte si stěžoval na bránění a tento hráč má v tuto chvíli problémy s bráněním. Stojí proti velmi dobrým hráčům Barnesovi a Maddisonovi, ale je to velké zklamání.“
Zatímco gól byl vyloučen, Leicester obnovil své vedení 4: 1 a Barnes se dostal do cíle devět minut před koncem základní hrací doby.
Přestože Tottenham minulý týden porazil Manchester City, promarnil šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala smlouvu s Joaem Felixem a místo toho se vrhla na hvězdu Tottenhamu
VÍCE: Tottenham se chystá ucházet o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální opci na odkup
Další podobné příběhy najdete na naší sportovní stránce
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli privilegovaný boj o předvolání Mika Pence
Zpráva, že zvláštní obhájce Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak bude tým Trump využívat soudy, aby zkazil poslední vývoj vyšetřování ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus o zmaření Penceova předvolání na základě privilegií exekutivy by měl ztroskotat.
Za prvé je tu prahová otázka, zda si bývalý prezident vůbec může privilegium nárokovat.
Připomeňme, že Trump se snažil a nepodařilo se zablokovat sněmovní komisi 6. ledna, aby získala záznamy z Bílého domu.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, s čímž nesouhlasil pouze soudce Clarence Thomas (manžel popíračky voleb v roce 2020 Ginni Thomasové).
Soud však ponechal otevřenou otázku, zda si bývalý prezident může nárokovat privilegia, přičemž soudce Brett Kavanaugh naznačil, že by takové právo podpořil.
Je tedy přinejmenším nejasné, zda si bývalý prezident může tuto výsadu nárokovat, aniž by bylo řečeno, zda by tento nárok uspěl.
Navíc odvolání k Nejvyššímu soudu kvůli snaze tehdejšího prezidenta Richarda Nixona vyhnout se vyhovění předvolání ukazuje, že vágní tvrzení o privilegiu nestačí a může být překonáno specifickou potřebou důkazů.
Soud v roce 1974 v případu Spojené státy versus Nixon konstatoval:
... když je důvod pro uplatnění privilegia, pokud jde o předvolané materiály, které mají být použity v trestním řízení, založen pouze na všeobecném zájmu o důvěrnost, nemůže převážit nad základními požadavky řádného soudního řízení při spravedlivém výkonu trestní spravedlnosti.
Všeobecné tvrzení o privilegiu musí ustoupit prokázané, specifické potřebě důkazů v probíhajícím trestním řízení.
Precedens je proto na straně vlády.
Odklady od vedení soudního sporu i v prohraném případě však mohou být pro Trumpa jistým vítězstvím.
Ale další utlumení šancí na úspěšné uplatnění privilegií je předchozí odmítnutí Trumpova pokusu zablokovat výpověď velké poroty z 6. ledna.
Jak v říjnu informoval list The Washington Post, toto odmítnutí poznamenalo, že například bývalý Pencův poradce Marc Short „pravděpodobně vlastnil informace důležité pro trestní vyšetřování útoku na Kapitol ze 6. ledna 2021 ministerstvem spravedlnosti, které nebyly dostupné z jiných zdrojů“.
To, že i Pence má pravděpodobně jedinečné informace, by ministerstvu spravedlnosti pomohlo v případném boji o předvolání.
A důvod, proč si myslíme, že Pence takové informace má, je další důvod, proč by nárok na privilegia neměl uspět.
To proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Těžko říct, že komunikace je privilegovaná, když jste ji předtím považovali za vhodnou pro publicitu.
Takže zatímco předvolání by mohlo představovat různé politické a osobní propočty pro Pence – který by se mohl ucházet o republikánskou nominaci v roce 2024 proti Trumpovi, někoho, kdo účinně schvaloval výzvy k Penceově mimosoudní popravě 6. ledna – soudy by to měly mít lehké, když se v otázce privilegií přikloní na stranu Ministerstva spravedlnosti.
Případ proti Bidenově kandidatuře je zřejmý – a slabý
Proč to je důležité?
Biden a jeho kolegové demokraté sice nemohou moc schvalovat zákony, když má Sněmovnu pod kontrolou vládní strana, ale přesto mohou další dva roky strávit tím, že půjdou příkladem.
Kolektivně by všichni v týmu měli vyhledávat příležitosti, jak si zahrát na galantní podivínské impulzy republikánů.
Ale pro Bidena je také důležité, aby posílil svou důvěryhodnost u amerického lidu – a možná se stal zoufale potřebným hybatelem změn v naší až příliš chatrné politické kultuře.
Washington, notoricky cynické místo, je proslulé svými názory o vůdcovství, které ochromují zdravý rozum.
Snad jednou z nejznámějších je podivná norma, která tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli zajít až do komických krajností, aby se tomu vyhnuli.
Existuje i jiný způsob: v knize Bailout, ve vzpomínkách Neila Barofského z doby, kdy sloužil ve Washingtonu jako zvláštní generální inspektor dohlížející na program pomoci problémovým aktivům, popsal radu, kterou dostal od Kristine Belislové, ženy, kterou si šikovně najal jako svou ředitelku komunikace.
Bylo to asi tak anti-washingtonské, jak jen to může být: „Přiznáme a dokonce zdůrazníme naše chyby.“
Jak dále vysvětlila, ve strategii je metoda, kterou by většina lidí v Beltway považovala za šílenství:
Tohle je nejlepší způsob, jak si získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Možná budeme občas v rozpacích a prozradíme věci, které bychom mohli – a jiní by to udělali – snadno skrýt, ale budeme šokovat tisk svou upřímností.
Nikdo jiný tohle nedělá a zanedlouho budeme mít vybudovanou obranu, když na nás zaútočí.
Bez ohledu na to, co uslyší, tisk přijde nejdřív za námi a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč se Biden vydal cestou radikálního převzetí zodpovědnosti: v každém prezidentském úřadu nevyhnutelně nastanou okamžiky, kdy je rozhodující mít důvěru veřejnosti a institucí, které chrání občanské zájmy.
Navíc je tu životně důležitý kapitál, který lze získat vlastnictvím našich chyb, a je tu důležitý rozdíl, který Biden může načrtnout se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: Řekni pravdu a zahanb ďábla.
Pár reklam na Super Bowl, na které se nemůžu dočkat.
Hvězda sitcomů z devadesátých let si zopakuje svou milovanou roli, aby vám prodala pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, který rozšíří dvanáctivteřinovou scénu do deseti sérií.
Všechny celebrity z loňských kryptoreklam se omlouvají za své kryptografické reklamy
Ti chlápci z „whassup“ ale vtip je v tom, že teď už jsou staří.
Každej se teď zajímá o kdoví co, že?
Takže nějaká série reklam režírovaná Rianem Johnsonem, kde když zjistíte, kdo spáchal vraždu, dostanete slevu na roční pojištění auta.
Reklama, kvůli které budou všichni super online konzervativní kluci týden zuřit
Timothée Chalamet v nějaké funkci.
Někdo, kdo byl údajně navždy zrušen, se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte, na kterou se určitě podíváte, až se bude vysílat za tři týdny.
Nesnesitelně chytlavá nová znělka, kterou si budete roky zpívat sami pro sebe.
Recyklovaný vtip na Twitteru z doby před dvěma měsíci.
Muzikant, jehož celá věc je kontrakultura, který ti kontrakulturně říká, ať jdeš do banky Wells Fargo.
Kluk se zvětšeným zoomem, ale vtip je v tom, že už je dospělý
Bidenovo ministerstvo spravedlnosti „Nechce ozbrojené občany“
Reprezentant Andrew Clyde (R-GA) si ve čtvrtek sedl s Breitbart News a diskutoval o svých plánech blokovat pravidlo ATF o pistolových výztužích a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti „vůbec nechce ozbrojené občanstvo“.
Clyde dal jasně najevo svůj nesouhlas s pravidlem o pistolových výztužích
Jeho důvody pro tento nesouhlas zahrnují jak obecné námitky, tak i ty konkrétnější.
Obecně vyjádřil své přesvědčení, že naši Otcové zakladatelé nestanovili plán vládnutí, který by zahrnoval federální agentury vytvářející zákony místo zákonodárného sboru.
Řekl: „Ministerstvo spravedlnosti je tu od toho, aby prosazovalo právo, ne aby ho vytvářelo. Když máte výkonnou moc, která vytváří zákony a prosazuje je, pak máte krále a království. Naši Zakladatelé nepožadovali krále a v Ústavě Spojených států nenavrhli žádné království.“
Clyde pak přešel ke konkrétnostem ohledně pravidla o pistolových výztužích a vyjádřil obavu, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: „To, co ATF chce, je rozšířit registrační databázi pro národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co předchází konfiskaci, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany.“
Dodal: „Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo má co, aby po nás mohli jít.“
Clyde tvrdí, že pravidlo o pistolových výztužích ATF se zrodilo v prostředí nepřátelství vůči Druhému dodatku a vůči soukromému vlastnictví zbraní, a hodlá s tím bojovat zuby nehty.
Řekl, že má „tři nástroje“, kterými může proti tomuto pravidlu bojovat.
Prvním z těchto nástrojů je SHORT Act a druhým je Zákon o přezkumu Kongresu
30. ledna Breitbart News citoval Clydea, který nastínil svůj plán na „znovuzavedení zákona Stop Harassing Owners of Rifles Today Act, neboli zákona SHORT, který by zrušil prvky zákona o národních střelných zbraních, čímž by zakázal ATF registrovat a zakazovat pistole se stabilizačními výztuhami“.
Poznamenal také, že „předloží usnesení o nesouhlasu podle zákona o přezkumu Kongresu, aby se zamezilo nezákonnému překročení pravomocí Bidenovy administrativy.“
Oba zákony, SHORT Act a Congressional Review Act, mají možnost zablokovat pravidlo ATF o pistolových výztuhách
Ale jak Clyde řekl Breitbart News Thursday, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k přijetí zákona SHORT Act nebo k finalizaci řešení nesouhlasu podle zákona o kontrole Kongresu.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k dalším, větším návrhům zákonů, o jejichž schválení demokraté velmi usilují.
Nicméně Clyde naznačil, že existuje i třetí způsob, jak blokovat pravidlo ATF pistol brace.
Řekl: „Jsem v rozpočtovém výboru a můžeme zrušit toto pravidlo o pistolových výztuhách prostřednictvím toho, co se nazývá omezujícím dodatkem. Můžeme se doslova vzepřít tomuto pravidlu a v podstatě říci: „Žádné peníze nesmí být vynaloženy na vykonání nebo prosazování tohoto konkrétního pravidla pistolové výztuže.“
A to samé můžeme udělat i s pravidlem ATF receiver/frame z loňského srpna.
Myslím, že oba musí být zneškodněni a těším se na spolupráci s našimi přivlastňovateli, abychom toho dosáhli.
AWR Hawkins je oceňovaný sloupkař Druhého dodatku pro Breitbart News a spisovatel/kurátor časopisu Down Range pro AWR Hawkins, týdenní zpravodaj zaměřený na vše, co se týká Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem na Turning Point USA.
AWR Hawkins je držitelem doktorátu z vojenské historie se zaměřením na válku ve Vietnamu (hnědé vodní námořnictvo), americké námořnictvo od Počátku, Občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat k odběru Down Range na breitbart.com/downrange.
Kontaktujte ho přímo na awrhawkins@breitbart.com.
„Doufáme, že“ Biden má plán, jak zvládnout Title 42 Ending, „Pokud ano, tak se o plán plně nepodělili“
V pátečním vydání pořadu stanice NBC „MTP Now“ řekl coloradský guvernér Jared Polis (D), že má „velké obavy“ z toho, co se stane, až plán 42 v květnu skončí, doufá, že Bidenova administrativa má plán na to, kdy tato politika skončí, a že „pokud ano, ještě se s námi o něj plně nepodělili“.
A řekl: „Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili.“
Polis uvedl, že by si přál, aby se otázce přistěhovalectví věnovalo více času během setkání guvernérů v Bílém domě, ale tato otázka se „objevila“.
Částečně jsme tam měli ministra Mayorkase.
A tak jsme se znovu zmínili o obavách, které sdílím ohledně toho, co se stane, až Hlava 42 v květnu skončí, a tak se ujišťujeme, že federální vláda má plán.
Doufáme, že to udělají.
Pokud ano, ještě se s námi o to plně nepodělili.
Ale říkali jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to nebude to, co jsme zažili v prosinci pětkrát nebo třikrát, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu vládu.
Sledujte Iana Hanchetta na Twitteru: @IanHanchett
McDonald's stáhl „nevkusnou“ reklamu poblíž krematoria – RT World News
McDonald's se omluvil poté, co byla v blízkosti krematoria ve Velké Británii umístěna reklama na hamburger „McCrispy“ řetězce rychlého občerstvení – i když někteří místní obyvatelé viděli vtipnou stránku věci.
Řetězec restaurací se zavázal odstranit urážlivé reklamní poutače na základě stížností obyvatel Trura v britském hrabství Cornwall.
V pátek si získal pozornost na sociálních sítích tím, že byl umístěn na rušnou silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlený inzerát, který byl umístěn přímo za cedulí ukazující na krematorium, označili někteří rozzlobení místní obyvatelé za „nevkusný“.
„I když vidím tu legrační stránku, je to nevkusné a jsem si jist, že někteří truchlící členové rodiny to nebudou chtít vidět při návštěvě Penmountu na pohřbu a kremaci milované osoby,“ řekl obyvatel, jehož tchýně byla loni v pohřebním ústavu zpopelněna, jak citují britská média.
Nicméně ne všichni byli tak pohoršeni nešťastným umístěním reklamy, jeden poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, „jak dávno jsi sledoval ceduli krematoria s černou kravatou na krku.“
Jeden člověk řekl, že „spadl ze židle smíchy“, když si inzerátu všiml na internetu, zatímco jiný místní poznamenal, že to není „o nic horší“ než rozhodnutí rady zabývat se myšlenkou, že by krematorium mohlo být postaveno „vedle vesnice důchodců“.
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek brzy poté, co se na internetu objevila fotografie reklamy, v níž řetězec restaurací uvedl, že inzerát co nejdříve odstraní.
„Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. S ohledem na obavy, které vznesla společnost CornwallLive, jsme však požádali o odstranění naší reklamy,“ uvedla značka rychlého občerstvení.
Společnost Cornwall Council, která provozuje krematorium i autobusovou zastávku, jež inzerát zobrazuje, odmítla komentář o rozruchu, když ji kontaktovala místní média.
'Střevní instinkt' pohřešovaná žena není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové začalo 16. den poté, co její partner řekl, že jeho 'instinkt' říká, že ona není v řece.
Lancashirská policie uvedla, že policisté si zachovávají „otevřenou mysl“, zatímco nadále žádají o informace o slečně Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael's na Wyre.
Policie pokračuje v prohledávání řeky Wyre směrem k moři v zátoce Morecambe a pracují na jedné hypotéze, že pětačtyřicetiletá dívka z Inskipu mohla spadnout do vody.
Při pátrání jim pomáhali specialisté a potápěči z pobřežní stráže HM, horské záchranné služby a požární a záchranné služby v Lancashiru, nasazeni byli i čmuchalové psi, drony a policejní vrtulníky.
Slečna Bulleyová zmizela, když venčila svého kokršpaněla Willowa poblíž řeky, krátce poté, co odložila své dcery ve věku šesti a devíti let do školy.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále připojený k pracovnímu hovoru.
Její partner Paul Ansell řekl, že chce nechat „všechny možnosti otevřené“ ohledně jejího zmizení, ale jeho „vnitřní instinkt“ mu říká, že v řece není.
Popsal paní Bulleyovou jako „zábavnou“, „milující“, „nejvěrnější přítelkyni, jakou kdy můžete mít“ a „výjimečnou maminku“, která „absolutně zbožňuje naše holky“.
„Je jen pilířem síly naší rodiny a bez ní je ta díra větší, než si vůbec dokážete představit,“ řekl pro 5 News
Pan Ansell řekl, že ačkoli rodina prochází „nevídaným peklem“, naděje, že jeho partner bude nalezen, je „silnější než kdy předtím“.
Policie vyloučila trestný čin a událost považuje za vyšetřování pohřešované osoby.
Ve čtvrtek se jejich pátrání přesunulo ze St Michael's na přibližně 10 mil po proudu řeky, kde se řeka vlévá do moře v zátoce Morecambe, přičemž v oblasti byly spatřeny hlídkové a záchranářské čluny.
Poslední komunistický vůdce východního Německa zemřel v 95 letech
BERLÍN (AP) – Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Měl 95 let
Modrow zemřel v sobotu brzy ráno, informovalo parlamentní uskupení Levice na twitteru.
Reformně smýšlející komunista Modrow převzal vládu nad východním Německem krátce po pádu Berlínské zdi a později přizval do vlády opoziční síly, ale nedokázal zpomalit nabývající dynamiku sjednocení Německa.
„Celý mírový průběh ustavení německé jednoty byl právě jeho mimořádným úspěchem,“ napsala levice na Twitteru. „To zůstane jeho politickým odkazem.“
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst protiestablishmentové osobnosti.
Odmítal stranické požitky a trval na tom, že bude bydlet v normálním bytě.
Funkce v nejvyšším vedení východního Německa mu unikala, dokud nebyl v listopadu 1989 – několik dní po pádu Berlínské zdi – jmenován premiérem, což byla pozice, která dříve měla jen malý vliv.
Když šéf tvrdé linie Egon Krenz a jeho vládnoucí politbyro počátkem prosince rezignovali, stal se Modrow nejvyšší politickou osobností východního Německa.
Komunisté už ale nemohli rozhodovat sami za sebe.
Následující měsíc souhlasil s tím, že se bude dělit o moc se stále hlasitější opozicí, a za sílících nepokojů posunul přelomové první svobodné volby ve východním Německu na březen 1990.
I když prodemokratické manifestace rychle nabíraly sjednocující příchuť, komunisté se zpočátku stavěli proti hovorům o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se západním Německem o případné „sjednocené vlasti“, která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow stál v čele volební kampaně přepracovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nestačila na to, aby jim zabránila skončit jako pouze třetí nejsilnější strana s 16 procentní podporou.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS – předchůdce dnešní opoziční levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho dostala před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků komunálních voleb v květnu 1989 v Drážďanech.
Uložil mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozpory mezi východními a západními Němci.
Jeho obhájce argumentoval, že napravil předchozí nespravedlnosti tím, že jako premiér dohlížel na svobodné volby.
Později v životě Modrow působil v radě starších levicové strany
„Hans byl hluboce upřímný a bojovný socialista,“ tweetoval Dietmar Bartsch, předseda parlamentní skupiny Levice.
„Až do stáří byl důležitým rádcem naší strany, jehož moudrost nám bude chybět.“
Indická vláda po kritice stáhla výzvu k objímání krav na Valentýna
Objímání krávy na Valentýna již není podporováno indickou vládou – navzdory tomu, že dříve žádala lidi, aby tak činili kvůli propagaci hinduistických hodnot.
Rada pro dobré životní podmínky zvířat Indie (AWBI) stáhla svou výzvu ke „dni objímání krav“ poté, co vyvolala kritiku politických soupeřů a uživatelů sociálních médií.
Indické vládní ministerstvo vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay řekl, že výzva k objímání krav byla „naprosto šílená, odporující logice“.
Dodal, že rozhodnutí stáhnout odvolání bylo spíše „kvůli tomu, aby politika hindutvského [hinduistického nacionalismu] nebyla zesměšňována tváří v tvář tvrdé kritice ze všech stran“.
AWBI své odvolání v pátek popřela a prohlásila, že „je staženo“.
Teprve ve středu se v jejím prohlášení psalo, že „objímání krav [by] přineslo citové bohatství a zvýšilo individuální i kolektivní štěstí“.
Více informací o Indii
Dodala, že kráva je „páteří indické kultury a venkovské ekonomiky... kvůli své výživné povaze jako [matka]“.
Reakce na první oznámení byly smíšené, když někteří zveřejnili videa s kravami, které odmítaly objetí a vybíhaly pryč.
Jiní chtěli objasnit, že apel byl spíše na následování vlastní kultury, na rozdíl od „slepého“ následování západních hodnot.
Mladí Indové obvykle tráví Valentýn přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Mazlení krav také není nic nového – v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známo jako „koe knuffelen“.
Oddaní hinduisté uctívají krávu – známou jako gau mata neboli „mateřská kráva“ – a většina států v Indii porážku krav zakázala.
V posledních letech někteří hinduističtí zastánci tvrdé linie podnikali razie v obchodech s valentýnskými předměty, pálili pohlednice a dárky a vyháněli páry držící se za ruce z restaurací a parků, přičemž tvrdili, že tento den je proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takovéto nájezdy pomáhají znovu upevnit hinduistickou identitu.
Kritici premiéra Nárendry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadvládu náboženství v sekulárním národě známém svou různorodostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinové tvoří většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeathu, muž byl zatčen
Chodec zemřel po srážce s autem ve Fife.
Osmatřicetiletá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeathu v pátek kolem 13:30.
V souvislosti s havárií byl následně zatčen čtyřiadvacetiletý muž.
Policie žádá všechny svědky nebo kohokoliv, kdo má záznam z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: „Naše vyšetřování pokračuje a žádáme každého, kdo byl v oblasti a kdo byl svědkem havárie, aby se nám ozval.“
Také bych apeloval na každého, kdo řídil v této oblasti a kdo by mohl mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
„Žádáme každého, kdo by mohl pomoci, aby zavolal policii Skotska na číslo 101, s uvedením incidentu číslo 1638 z pátku 10. února 2023“.
V ČÍSLECH: Čtvrť Oslo, kde žije nejvíc cizinců
Zhruba 177 000 z 634 000 obyvatel Osla imigrovalo do Norska z jiných zemí.
Když započítáme ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili největší přistěhovaleckou skupinu občané z Asie, včetně Turecka, přičemž podle údajů národní datové agentury Statistics Norway (SSB) ve městě žilo více než 62 985 těchto státních příslušníků.
Poté tvořili druhou největší skupinu občané z EU, EHP a Spojeného království, kteří tvořili necelých 10 procent obyvatel města.
Třetí největší skupinu přistěhovalců v Oslu tvořili Afričané, v Oslu žilo 28.020 lidí z Afriky.
Čtvrtou nejpočetnější skupinou byli Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, což představuje 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 zde žilo jen o málo více než 7000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo o něco více než 3000 státních příslušníků.
Mezitím v Oslu žilo méně než 700 lidí z Oceánie.
Alna, ležící na severovýchodě města, byla čtvrtí s nejvíce zahraničními obyvateli.
V roce 2022 zde žilo přibližně 18 257 zahraničních obyvatel.
Grünerløkka, nacházející se přiměřeně v centru města, pak měla druhý nejvyšší počet zahraničních rezidentů, a to 17 631.
Gamle Oslo mělo také významnou populaci přistěhovalců, 17 631 lidí tam žilo poté, co se přestěhovali z jiné země.
Statistiky Norska ukázaly, že cizinci jsou roztroušeni po všech městských obvodech, protože Søndre Nordstrand, městský obvod na jihu Osla, má registrováno více než 14 000 imigrantů.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl čtvrtí s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okresů v Oslu s nejvíce obyvateli z jiné země.
Na opačném konci spektra jen 184 zahraničních obyvatel nazývalo Marku domovem a něco přes 700 jich žilo v centrální městské části města.
Ullern, Vestre Aker a Nordstrand tvořily další městské části s nejméně zahraničními obyvateli.
V těchto městských částech však žilo výrazně více imigrantů než v centrálním Oslu a Markě.
Lidé ze zemí EU a EHP a ti ze Spojeného království většinou žili ve městech Frogner, Grünerløkka, Gamle Oslo a St. Hanshaugen
Zatímco spousta občanů z Asie, včetně Turecka, pobývala také ve Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet imigrantů z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Nordstrandem.
Ti ze Severní Ameriky byli celkem rovnoměrně rozmístěni ve městech Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve městech Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojeného království obvykle žili v nejústřednější městské čtvrti města Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika set státních příslušníků z Oceánie byly čtvrti Frogner, Grünerløkka a Gamle Oslo čtvrtěmi s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe do března zahájí provoz nové uhelné elektrárny
Autor: Florence Tan
BENGALURU (Reuters) – Zimbabwe zahájí do března provoz nové jednotky ve své jediné uhelné elektrárně, tvrdí náměstek ministra energetiky země, a poskytne tak pomoc milionům občanů otřesených v posledních měsících častými výpadky proudu.
Nová jednotka elektrárny Hwange zvedne instalovaný výkon afrického státu o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa bez udání časového harmonogramu.
Méně než polovina ze 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení financování nových uhelných kapacit omezilo schopnost země zastavit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
„Máme kapacitu vyrobit až 2100 megawattů (MW) z našich zdrojů energie, ale v tuto chvíli vyrábíme mnohem méně..asi 1000 MW,“ řekla Mudyiwa agentuře Reuters.
„Ale naše poptávka po elektřině je asi 1700MW, takže máme vážný deficit,“ řekla.
Nedostatečné srážky vedly k poklesu výroby elektřiny ve vodních elektrárnách, zatímco účinnost jediné, desítky let staré uhelné elektrárny se v průběhu času prudce snížila, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžební a zemědělské aktivitě.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů, které zatěžují vyhlídky Zimbabwe na růst.
Nedostatek financí na uhelnou energii žene těžební a na zemědělství závislou ekonomiku k dovozu nákladné energie od regionálních sousedů, včetně Zambie a Mosambiku.
(Scénář napsal Sudarshan Varadhan; Editace: Jacqueline Wong)
(PERSON11) Ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně –
V podstatě, velký obchod, nebo něco je špatně.
Takže, některé soubory jsou stále – stále mají podivný výstup.
Ale – ale u většiny složek by to již mělo být v pořádku.
Dobře, díky.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé, že, [PERSON7], jste mysleli na [PERSON11].
A [PERSON11] teď má čas.
Jsou i jiné věci, kde jsem přemýšlel o [PERSON11] a to by byl trénink, prázdných systémů, aby prováděly zkrácení.
Takže, kdybyste, [PERSON11], měli čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat pro příští týden.
Ale měli bychom opravdu mít systém – připravený na –
Podíval jsem se na tutoriál z NLP – bylo to tak?
(PERSON6) Pro nadcházející zasedání a zeptal jsem se na poptávku, protože jsem viděl (meme) demo projektu.
Dělají offline titulkování.
Takže je to o něco jednodušší než to, co děláme my.
Stále mají stejné problémy se segmentací a tak dále.
Ale jejich poslání při překladu se zkracuje jednoduše proto, že se data zkracují.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže dochází k přirozenému zkrácení dat.
Bylo by skvělé, kdybychom také mohli najít takový typ dat, kde dochází k nějakému přirozenému zkrácení.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože potřebuju zjistit, který z nich je ten, který dostává propustky.
Takže, jakmile to budu vědět, můžu to sledovat, takže do budoucna –
Nebo vlastně do budoucna bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset dělat konverzi.
(PERSON6) No, tohle by vlastně mělo být –
Slyšíš mě ještě?
Kvalita zvuku je trochu horší.
Takže tohle by se opravdu mělo dělat pořád.
Takže pokaždé, když provedeme toto vyhodnocení, mělo by být provedeno úplně od nuly.
Pokaždé by tedy mělo dojít k novému stažení nové konverze a novému vyhodnocení
(PERSON8) Ale přesto, pokud budu mít přehled o souborech, které je třeba ručně převést, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známé, a samozřejmě, když přidáme nějaké nové soubory, tak se o to můžu přesvědčit později.
(PERSON6) Takže tohle je důležitá věc, na kterou jsme měli narazit už před několika měsíci.
Nezapomeňte, že už od srpna vám říkám, že to chceme zhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejde jen o tebe osobně [PERSON8].
Očividně tu byly i jiné věci
Ale pokaždé, když jste o tom přemýšleli, tak jste si říkali „tohle bude jednoduché, prostě to spustíme“.
A až když to opravdu uděláte, vidíte všechny problémy.
Takže tohle je známé, běžné.
Vždycky je to tak.
Takže je to zpráva pro všechny.
Než to zkusíte, nikdy nevíte, v čem bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, takže chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes při nahrávání
Takže než to uděláte, nemůžete říct, jestli to bude fungovat nebo ne.
A tady narážíme na problémy s konverzí formátů souborů.
Doufejme tedy, že budeme schopni rychle získat čísla.
Takže, máte zatím nějaké procento chyb slov?
(PERSON8) Ne, nezpracoval jsem to
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně šumu.
Tak jsem vás požádal, abyste měli různé verze tohoto slovníku tak, že vezmete pouze slova, která byla pozorována, a to pětkrát.
A pouze ty výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takto vznikly tyto náhodné chyby, jako je příklad s touto čtyřkou IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba, řekne toto „alzo“, pokud si vzpomenete, pokud řekne toto „alzo“ se „Z“ dvacetkrát v řeči, pak to uvidíte v datech s „Z“.
A pokud se mu někdy podaří říci také správně, pak ano, opět to uvidíte v datech.
Takže bych chtěl, aby [PERSON4] byl v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, ne?
Budu muset teď odejít, protože potřebuji dát dětem oběd a tak dále.
Ale zůstaňte prosím u tohoto hovoru a společně vymyslete, jak používat tento slovník.
Takže [PERSON4], prosím, ukažte [PERSON2], jaký slovník systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte převést slovník, který jste vyslali, do tohoto souboru.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Všechna tato slova by však měla být známými slovy.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže, slovník bude mít tři sloupce
Graf, jak je výstup.
Jeden byl rozpoznán
Fonety, jak [PERSON2] navrhoval.
A bude tam více linek s různými variacemi fonémů
A třetí sloupec n bude opět stejný pro všechny z nich a opět tam bude stejný grafémový tvar.
To je tedy okamžik, kdy jazykový model vidí.
A myslím, že tímto způsobem by tyto systémy měly být schopny jej načíst.
A možná narazíte ještě na jeden problém: že to není připraveno pro dva velké uživatelské slovníky.
Takže tohle je taky něco, co se musí otestovat, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] tedy ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a potřebujete dát tyto dvě znalosti dohromady.
Aha, takže to funguje s, s generovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává tohle smysl?
(PERSON2) Jo, jasně, probereme to.
(PERSON6) Jo, takže ještě ještě něco jiného, [PERSON2], co máte?
(PERSON2) No, možná zajímavá informace pro Dominika
Dokončuji trénink německého ASR, který může být použit k časovému označení.
Nejsem si jistý, jak dobré to bude, protože se to snažím dělat na (Libry) Speech.
Ale když jsem to stahoval, tvrdili, že to má více než 600 hodin.
Ale pak trénink říkal, že skutečný tréninkový soubor obsahoval jen asi 300 hodin.
A stále si nejsem jistý, jestli těch 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo v češtině jsem pozoroval strmější konverze.
A teď už se to nebude tak rychle měnit
Takže, pokud odebereme nějaké vzorky během tréninku
Pak jsou tu ještě nějaké vážné chyby ve výstupu ASR.
Takže doufám, že pro časové označení to bude stačit.
Nebo bychom to alespoň mohli zkusit
(PERSON17) Okay, to je dobře, jo.
Tak jsem začal, ale myslím, že jsem ti nikdy nedokončil e-mail, protože jsi mi připomněl, [PERSON8], že tvé filtrování nadávek ještě není integrované.
A myslím, že je to také důležitá zpráva pro [PERSON5], který opět zmizel z hovoru.
Takže důležité poselství je, že ano, je velmi dobře, že aktivně prosazujete, aby vaše výsledky byly integrovány, a každý by tak měl činit.
A zároveň potřebujeme nastavení, abyste ho mohli skutečně integrovat a otestovat sami.
Takže tomu říkám „integrace do-it-yourself“.
Takže, [PERSON8], při práci s [PERSON5] a při dokumentování, jaké jsou nastavení, ujistěte se, že je dostatečně dobře testováno kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontrolu jazykových modelů a všemi ostatními.
Kdykoli tedy někdo vyvine novou užitečnou součástku, měl by mít k plnému potrubí poměrně snadný přístup, aby si ji mohl sám otestovat.
Tato integrace „udělej si sám“ je tedy důležitá, protože jinak to všechno zůstane na vás [PERSON8] a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že ano?
Filtrování nadávek bylo testováno na protokolech?
Myslím, že ano.
Jo, myslím, že to bylo testováno na protokolech.
Takže teď je čas to otestovat na živých potrubích.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] spustil pro sebe některé z pracovníků a živě přehrával některé problematické soubory, jako je použití [PROJECT8] nebo cokoliv jiného.
Jednoduše je zahrajte.
Sledujte zvukový výstup na vašem stroji a uvidíte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité to nejprve odladit, pomocí souborů protokolu, a pak je důležité to odladit v potrubí.
A pokud toto odladění může provést autor této komponenty, zde, v tomto případě [PERSON4], by to bylo nejefektivnější pro nás všechny.
Takže, [PERSON8], potvrďte prosím, že souhlasíte s touto myšlenkou integrace typu „udělej si sám“.
(PERSON17) Jo, takže pro víceakcentovou angličtinu.
Takže my to teď [PERSON14] dáváme dohromady jen do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a bude to dělat napříč různými mluvčími.
Budou to tedy opravdu věty s více mluvčími, a proto by se mohla zlepšit i odolnost vůči různým akcentům těchto mluvčích.
Aha, takže tohle je jeden částicový experiment.
A později možná uděláme něco víc s tou věcí s multiakcentem.
Takže tyto nové věty se vlastně pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model
Takže systém ASR musí vidět největší možnou sadu vět.
A budeme vytvářet nové věty z textového jazykového modelu tím, že k tomu přidáme zvukovou část, takže jazykový model bude pro ASR lepší a robustnost vůči různým mluvčím bude také lepší.
A ve včerejší přednášce jsem zaslechl další nápad.
Bylo to během tréninku.
Vypouštěli ze zvuku časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech a to také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoliv jiný může zapracovat na nepůvodním akcentu.
Ok, další věc, kterou jsem si všiml je – tohle je v pondělním testovacím dokumentu.
To je zvýrazněno čtyřikrát.
Takže, když probíhá nějaké sezení, potřebujeme jména a terminologii pro toto sezení.
A my to potřebujeme sbírat, připravovat ručně, nějak to vytvořit.
A tato ruční tvorba by měla být podporována automatickými nástroji, jak jen to je možné.
Takže je v tom určitá dovednost b, kterou je třeba procvičit.
Takže jsem docela zručný v míchání textových souborů.
A kdykoliv vidím někoho z vás, jak to dělá, tak mám vždycky v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš účel, ale alespoň byste to měli zvážit.
Tato dovednost je tedy něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jediný, kdo by to mohl udělat, je [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, s zpracováním dat, řekněte to prosím.
A pak potřebujeme -
Takže, jakmile jsme zabezpečili slovník pojmů a bez ohledu na výslovnost slova, potřebujeme techniky, jak tyto slovníky použít v systémech.
Můj dojem z doménové adaptace, kterou [PERSON9] pečlivě prováděl na všech sezeních, byl tedy takový, že v hybridním ASR to nebylo opravdu vidět.
Takže jedno takové sezení se uskuteční opět toto pondělí
[PERSON9] již zahajuje sběr dat, ale rád bych viděl přínos této úpravy domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domén a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Kdybyste se vy tři mohli setkat a zkontrolovat, co [PROJECT5] dělá s -
Není to [PROJECT5], vlastně je to doménová adaptace pro sadu nástrojů [PERSON18], správně.
Takže se díváme trochu do minulosti a ujišťujeme se, že starý přístup funguje.
V současné době je absolutně nemožné udělat nějakou doménovou adaptaci pro plně neurální ASR.
Takže uvažuji o nezávislém rozpoznávání klíčových slov ze zvuku a o nějaké slučovací proceduře
Takže bychom mohli mít dvě ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak doménově upravené nastavení [PROJECT5], které se používá pouze pro vyhledávání klíčových slov.
A když vidíme klíčové slovo ve verzi přizpůsobené doméně, pak bychom použili větu z [PROJECT5], která je obecně horší, ale obsahuje správné termíny.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a dělat různé experimenty na finetuningu a tak dále.
Takže jsme to probrali s [PERSON14].
A, [PERSON14], máte nějaké novinky od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je tu někdo další, kdo by byl na to zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co by bylo opravdu dobře přijímáno obecně jako papír, protože lidé to ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže tam bychom opravdu mohli něco ovlivnit.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat k tomu v současné době používáme, protože, například, když si zkontrolujete například [ORGANIZATION4] modely na [ORGANIZATION5], že jsou jako už docela dobré v těchto věcech
(PERSON6) A myslím si, že když se nám prostě líbí -
Mohli bychom z nich asi jen získat data, protože máte jako takovou velkou sadu videí v podstatě s různými doménami a různých mluvčích rodných jazyků na [ORGANIZATION5].
A měl jsem nápad, že bychom mohli použít nějaký nástroj a stáhnout v podstatě nějaké druhy filtrovaných videí z [ORGANIZATION5] a udělat z nich tréninkové testy.
Takže to mám v plánu udělat sám.
Mám v plánu tam jít, ale potřebujeme záložní osobu.
A také pro akci [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, archiváře, abychom to sezení znovu neztratili.
A ještě důležitější a stále přetrvávající téma, na kterém je třeba pracovat, je lezení po žebříku.
A tady v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generované a které by rostly.
Myslím si, že by bylo asi nejjednodušší umístit tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnocovány po každé nové hodnotící kampani.
Může být obtížné tyto tabulky připravit.
Tak jsem se zeptal [PERSON7] a [PERSON7] bohužel nebude k dispozici během tohoto hovoru.
Aby nám řekli, zda [ORGANISATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli by nám to pomohlo nebo ne.
Dobře, takže [ORGANISATION242] není [PERSON7] doporučována.
Takže jednoduchý html je asi ta správná cesta.
Takže jakmile bude mít [PERSON2] tato hodnocení vyčištěna.
To tedy znamená přesunout těch pár skriptů tam, kam patří z testovací sady [PROJECT3] a nějakého automatického spouštěče.
Pak také prosím vytvořte konverzi z tabulek do html podobnou konverzi tech a pak tyto výsledky pravidelně vkládejte na svou webovou stránku.
Nebo byste dokonce mohli udělat úplný git check out přímo umístěný v tomto veřejném html nebo singling z tohoto veřejného html.
Takže by to bylo okamžitě přístupné přes web, a každý by se mohl podívat na aktuální skóre a prozkoumat to.
Takže, to by bylo užitečné, zejména pro lidi mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají něco jako -
Výkon byl špatný pro některé soubory, a mohli přímo m procházet na webu m.
Mohli by to také ve skutečnosti procházet na [ORGANISATION101]
Záleží jen na vás, abyste ji nastavili tak, aby byla uživatelsky přívětivá a snadno se sledovala
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na, nebo se dostávám k aktualizaci, demo podání, které má být odevzdáno příští pátek, pokud se nepletu.
A pak musím udělat nějaké zprávy o projektu a začínám shromažďovat dokumenty – nebo odkazy na dokumenty, ne dokumenty samotné, pro obě sezení.
(PERSON11) <parallel_talk> I pro ASR bychom měli přidat doplňkovou metriku -
Vlastně více, měli bychom přidat doplňující met- tyto doplňkové metriky. </parallel_talk>
Zmínil jste tedy jednu a to je filtrování nadávek v hodnocení.
Takže <parallel_talk> mají explicitní seznam věcí, které se nesmí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A pak vyhodnocení vzácných slov.
A tady máme explicitní seznam jmen a pojmů, které chceme objevit ve výstupu, bodované ne jednoduše podle (pořadí) sazby </parallel_talk> ale bodované něčím, co tyto věci přímo popisuje, že?
Ano, takže naprosto souhlasím.
To zahrnuje i manuální přípravu reference.
Takže, <parallel_talk> oba potřebují manuálně vytvořené reference. </parallel_talk>
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavila nějaký překladatelský slovník.
A brzy by se o to měla podělit. </parallel_talk>
Takže by se to mohlo stát prázdnou částí druhé věci vzácného slova -
Takže <parallel_talk> tohle by bylo vyhodnocení vzácných slov pro MT a pak z [PROJEC210] pravděpodobně dostaneme také nějaký slovník. </parallel_talk>
Takže to by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat, abyste revidovali doménu <nesrozumitelné/> a vytvořili takový slovník pohledem na výstupy a na to, co ve výstupech chybí.
Takže, jako shortlisting – výpis slov, která se nám líbí a nelíbí se nám v doméně <nesrozumitelné/>.
Dokázal byste to?
(PERSON11) Mělo by to být proveditelné, tak to pojďme zkusit.
Bylo by to jako – bylo by skvělé, kdyby se vám to podařilo.
Takže si to napíšu.
Takže, <parallel_talk> směřuje k uzávěrce [ORGANISATION62] s podtitulkovou studijní prací. </parallel_talk>
Ano <parallel_talk> a poté multi-source s [PERSON7] nebo na základě [PERSON7] nebo – </parallel_talk>
A pokud jde o ID jazyka, zajímalo by mě, jak přesně ho chcete integrovat, protože už zahrnuje zvažování více ASR zdrojů, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude pracovat jako audio-textový pracovník a bude vysílat časová razítka, jako pro čtyři nebo dvě sekundy a třídu.
<nesrozumitelné/> ticho, čeština, němčina, angličtina, a pak řeknu ostatním, jak to chtějí použít v potrubí.
(PERSON11) Je to důležité.
Prosím napište to sem do dokumentátoru toto <nesrozumitelné/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], no a také možná [PERSON5].
Pokud máme tento nástroj, musíme (poslat) zvuk na více ASR nebo více pracovníků <nesrozumitelné/>
Zvuk budeme zvlášť potřebovat (poslat) do anglického ASR, zvlášť do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také, do tohoto jazykového ID pracovníka a pak potřebujeme sloučit tyto výstupy, a to je nástroj, který zatím nemáme.
To je vícezdrojový nástroj, který bude pozorovat textové výstupy a také sledovat časová razítka a bude vysílat – pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby ASR byla tichá, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem si to takhle vymyslel
Dalším z nastavení by bylo, že stejný zvuk je dodáván do ASR a tohoto jazykového kontrolora.
Tato jazyková kontrola je v podstatě součástí ASR, umlčuje ASR, pokud je to nesprávný jazyk.
To je také možnost.
Takže musíme přijít na to, který způsob integrace jazykového ID je pro naše účely nejlepší.
Takže o tom prosím přemýšlejte jako o tom, jaké jsou naše potrubí.
V ideálním případě si myslím, že by nejméně podobné zmatky v řízení a tak dále nastaly, pokud by naše MT modely byly vícejazyčné.
Pokud by podporovaly různé zdrojové jazyky a překládaly by z některého z těchto jazyků do angličtiny.
Možná děláme jen kopii, pokud je jako vstup zadána angličtina, takže bychom na začátku měli vícejazyčné vícejazyčné ASR.
Vše přejde do angličtiny a pak z angličtiny půjde do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, by toto ID jazyka nebylo ani potřeba.
Jde o to, že pokud budeme analýzu provádět důkladněji, jedna věc je možné kontradiktorní hodnocení, které jen naznačí, že omezení mají ve skutečnosti dopad na skutečný výstup.
Že by to bylo hezké a, jo, možná analýza pozornosti.
Ale nejsem si jistý, jestli by nám to mohlo dát stejné odpovědi, v podstatě, jestli se model věnuje nebo nevěnuje omezení.
(PERSON4) Musel jsem se podívat jen na několik příkladů pozornosti, nedělal jsem žádné statistiky nebo tak něco, a dívá se na omezení, a když překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti nedělá žádné v tomto smyslu.
Dělá to nějaké obecné chyby v překladu, ale ne ty (jevy), které se snažíme vyřešit.
Vrátíme-li se k automatickému vyhodnocování, problém s nesouladem je v tom, že výstup je správně poskládaný, ale kontext je jiný.
Tudíž se nejedná o stejný slovní tvar jako v odkazu, že?
(PERSON4) Jo, ale také jsem zkontroloval, jestli kontexty jsou platné překlady a ve většině případů to tak je.
Stejně jako v prvních 100 příkladech, které byly automatickým hodnocením označeny jako chyby, bylo 91 z nich správně zasazeno do správných kontextů.
(PERSON4) A myslím, že pouze dvě nebo tři věty byly správně vloženy do nesprávného kontextu, jako by překlad byl špatný.
A pak jsou některé případy, kdy překlad byl úplně špatně, protože věta byla opravdu špatná a část musí být < nesrozumitelná / >, ale to bylo jen jeden nebo dva případy.
(PERSON3) Ale vy se snažíte srovnat diverzní formuláře, když to vyhodnocujete, že?
Ty neděláš vůbec nic...
(PERSON3) -lemmatizace odkazu a-
(PERSON4) Oba, oba, oba, já se shoduji jak povrchové formy a lemma.
(PERSON3) Aha, aha jo, to jsou dvě skóre, že?
(PERSON4) Je to jen dilema skóre pro (Evropské?) není v tabulce, protože tabulka jako se nevejde do papíru, takže <nesrozumitelné/>
Pokrytí je vždycky tak 97 procent.
Prostě generuje správné lemmy, jen...
(PERSON3) No jo, dobře, chápu to, chápu to.
Takže v podstatě lemma pokrytí říká, zda je tam omezení, a rozdíl povrchového pokrytí naznačuje, že by to mohlo být nesprávně inflected, ale to není tento případ.
(PERSON3) No jo, jen nevím, jestli jste, jestli jste chytili <nesrozumitelné/> když jsme mluvili o [PERSON1],
ale jedna věc, je, že (úder) je lepší, ale druhá věc je, že lemmy jsou ve skutečnosti správně vloženy ručně, (
ale to je další, ne, žádný problém, je to vlastně dobré, že je <nesrozumitelné/> jo, jo.
Tak jsem si myslel, že by mohlo být.
Ale nejsem si jistý, jestli na to máme nějaká testovací data, ale mohli bychom si zkusit pohrát s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít omezení a pokusit se použít místo toho synonymní omezení a vidět nebo porovnat jak, jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to popisoval jen vágně, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakých datech přenosu stylu pro anglickou češtinu? Máme něco?
(PERSON4) <nesrozumitelné/>
Tím převodem stylů, Dušane, myslíš, že by tam bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, byl bys v mluveném jazyce nebo něco takového?
(PERSON3) No, to je ta věc, že mám jen omezené znalosti o tomto úkolu.
Ale umím si představit, že chcete přepsat větu, která není napsána mužem, ale je napsána ženou, nebo, já nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámen s přesnými datovými soubory a s tím, co pokrývají.
Myšlenka je taková, že styl vět je definován velmi nejasně.
Takže znovu, nejsem si tak jistý.
(PERSON1) Máme tento soubor větných transformací.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například udělat věty obecnější.
Takže detaily jsou vynechány, věta je zjednodušena a věta pak zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli tu máme něco jako zkrácení trestu.
Pro zkrácení Matous provádí nějaký experiment s angličtinou-češtinou, ale nemáme tam žádná referenční data.
Nemáme tedy žádný datový soubor pro kompresi vět
Možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže to jediné referenční by bylo příliš omezené na to, aby vám něco řeklo o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových transformací, například by to mohlo být provedeno <nesrozumitelné/> pro češtinu, takže možná by tou správnou osobou byl Rudolf Rosa, který by se ho zeptal, jestli někdy nějaký takový datový soubor vygeneroval.
Takže, bude existovat kořenové generování nějakého větného protipólu.
(PERSON3) Myslím, že je to vlastně jako zajímavá otázka, jestli můžeme využít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(OSOBA) To je vlastně velmi dobrý nápad
Mohli bychom se na to zaměřit a vytvořit konkrétní podčást testovací sady [PROJECT1], která by to pokryla.
Aha, takže někdy známe pohlaví mluvčího, takže pokud ano... možná budu sdílet obrazovku a prohlížet si ji.
Nebo jsem to zkusil s Marian, která se toho jen účastnila a je to... Nevím, o kolik BLEU bodů níž.
(PERSON2) Protože stejně jako si myslím, že Martin dělá svůj <nesrozumitelný/> malý překlad, tak překládá více vět najednou a pak si vybere jen tu středovou a takto pokračuje v celém dokumentu.
Kontext je tedy jako jeden <nesrozumitelný/> společně s větou, kterou chceme přeložit.
(PERSON10) Jo, myslím – nebyl to Dominik, který dělal nějaké experimenty s Ivanou?
Myslím, že minulý rok nebo dva roky před dvojitou prázdnotou, kde navštěvovali kontext nebo spojovali kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale věc se má tak, že u tohoto zřetězení není úplně jisté, zda to má stejný efekt jako nastavení více enkodérů-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje naplno.
(PERSON8) Jo, dobře, omlouvám se, možná bych měl být přesnější, že to nefungovalo tak, jak jsem to udělal já. smích
(PERSON1) Jo, protože si myslím, že je to metoda, která se dá velmi snadno otestovat, a vždy by se měla testovat v kontrastu se dvěma enkodéry, a očekával bych, že někdy to bude lepší a někdy horší než nastavené dva enkodéry, záleží na přesném úkolu, jako co přesně je druhá věc, kterou enkódujete.
Takže pokud máte dvě kopie dvou parafrází stejné věty,
možná je to nějak matoucí pro pozornost, tak co, já nevím.
Chování by také mohlo být odlišné pro staré sekvenční metody, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak možná s transformátorem je to jo, je těžší trénovat, takže možná budete potřebovat jakékoliv zvýšení zahřívacího čísla, zahřívací sety.
(PERSON2) Jo, tak prostě vězte jako-
Nepamatuju se, takže si to nepamatuju přesně, ale tohle je něco jako...
když jsem v létě začínal s těmi vícezdrojovými experimenty.
První věc, se kterou jsem začal, bylo spojování parafráze a zdroje a možná já, už si nevzpomínám,
Můžu si to do příští schůzky ověřit, jestli jsem to taky zkusil,
Rozhodně jsem to zkusil, když jsou zdroje na první pozici pak nějaký oddělovač a parafráze na druhé pozici.
Mohl jsem také zkusit, že jsem míchal dvě věci náhodně, jo, a já si jen pamatuji, že to dělalo hojně tyhle kompenetrační věci a zkoušelo vícekódování.
(PERSON8) A bylo to pravděpodobně kvůli nízkému skóre.
(OSOBNOST 2) <nesrozumitelné/> které se vám líbí může zlepšit vaše bodové ohodnocení pouhým přidáním frázového výstupu a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže pokud zadáte výstup založený na frázích, tak je to v podstatě post-editace, že? Můžete o tom přemýšlet jako o posteditingu, jako byste posteditovali výstup založený na frázích, že? Nebo to záleží na úhlu pohledu, že?
(PERSON1) <nesrozumitelné/> že to rádi plně přepisujete, ale technicky to odpovídá přesně úkolu posteditování, můžete to připojit jako řešení úkolu posteditování.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální znak pro rozlišení, jako který je zdroj a který je kontext nebo druhá věta, nebo je prostě zřetězíte bez ničeho?
A doufat že se to systém naučí?
(PERSON8) Snažil jsem se, asi dva tokeny a jo jako, protože v první verzi jsme měli podezření, že by token mohl být také token sám, tak jsem to pak přehrál dalším tokenem, který není jen pro tento účel, protože jsme použili nějaký předem vyškolený slovník, a tento slovník neobsahoval oddělovací tokeny.
Takže jsem použil nějaký token, o kterém jsem předpokládal, že nebude jako tokenizovaný na několik kousků a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento znak nemůže objevit na jiných místech ve větě a to je jediné místo, kde se to může objevit.
Takže by to mohlo být provedeno lépe, jo, souhlasím.
(PERSON2) Ale ta část s Flaskem nebo komunikační část s klientem je něco, co neumím.
Protože nemám žádné zkušenosti a nemám čas to rozjet.
(PERSON1) Myslel jsem, že to znamená něco s využitím neznámého mediátora.
(PERSON2) Ne, vytvořte HTTP klienta, který dokáže zaplnit frontu a číst z jiné fronty.
A pošlete text zpět jako HTTP požadavek.
Protože moje představa je, že uživatelské kliknutí bude použito i v ukrajinském projektu.
A moje představa je taková, že klient klikne na tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk po malých kouscích najednou.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dejte do fronty, se kterou budu frontu později obsluhovat (ASR).
A model udělá nějakou logiku, nějakou dedukci s tím.
A kdykoliv bude mít nový kus přepisu, pošle ho zpět, a uživatel by měl dostat částečný přepis zpět.
A mělo by to být okamžitě zobrazeno v textovém poli.
(PERSON1) Mohl bych o tom popřemýšlet.
Prostě Flask taky moc neznám, ale jo, můžu o tom přemýšlet.
(PERSON2) Oh, možná jiný HTTP server.
Já nevím, možná na to ani nepotřebujeme fajnový HTTP server
(PERSON1) Pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to v tomto případě fungovalo.
(PERSON2) Jo, jediný požadavek je, že by to mělo zvládnout více připojení najednou.
(PERSON1) No myslím, že online tok textu je něco kolem 2 000 přinejmenším.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými vnitřními pracovníky, takže mám na mysli, jo, takže mám <nesrozumitelné/> řekněme deset, no místo výstupu, soubor od <nesrozumitelného/> vedlejšího pracovníka, takže <nesrozumitelné/> to máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
Oh, to by nám ušetřilo čas.
(PERSON7) Jo, jo, to je velmi důležité vlastně všechno paralelizovat, paralelizovat jak zpracování systémů, tak i vyhodnocení buňky DF, protože by to musel spustit mnohokrát, budou tam chyby, musíte to rychle znovu spustit.
(PERSON7) Dobře, tak díky.
Takže, jste velmi zaneprázdněni tímto, nechci na vás házet další věci, takže začnu připomenutím.
Potřebujeme dokončit popis [PROJECT1] stolní soupravy,
Koho to tu máme?
No, vlastně ani ne, jo, (je to hotovo) a bohužel to tady není
Takže tohle by bylo pro [PERSON2],
Pak hodnocení, to je pro [PERSON1], ale o tom jsme diskutovali.
Poslouchej, dej mi tabulku v DSD dejme sem tenkou čáru a posuneme šablonu tabulky, jako je struktura plánu, do deleblu, takže čísla přijdou později, ale já chci vidět nějaká čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuju.
Máme [PERSON5], to je dobré.
Pro [PERSON5] bych tedy chtěl zjistit, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] i pro vývoj, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak vymyslíme, které balíčky nainstalovat do prostředí Petri.
(PERSON7) Jo, je tu ještě jedna věc
Možná to není dobrý nápad kombinovat tyhle dva běhy do jednoho
Myslím, že je vlastně lepší, když to spustíte odděleně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a jeho zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a pak spustíte vyhodnocení.
A důvod tohoto rozdělení je, že můžete více paralyzovat.
Jsem si jist, že nastanou problémy na různých frontách, a čísla budeme velmi brzy potřebovat.
Takže pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále nechat běžet překlad pro ty zbývající,
a přehodnotit, se sel T F, ty chybějící, a tak dále.
Takže jde o to, že nejde o vytvoření sériového, sekvenčního zpracování, které by zahrnovalo obojí,
ale jde o to získat výsledky, a je vlastně lepší to dělat po částech
Nejdřív dostaneme všechny výstupy, pak dostaneme všechna hodnocení.
Jo, takže, chci říct, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem při dekódování udělal něco trochu složitějšího.
Třeba odfiltrování trámů a nahrazení trámů jinými trámy
A pro multi-tokenové omezení a podobné věci.
Ale pro pozitivní omezení, jsem jen porovnával tréninkový přístup s, jo, jen tyto velmi jednoduché věci.
Jen upravujeme skóre v každém kroku stejným způsobem.
Dobře, takže zpátky k pozitivním omezením.
Už jste se zaměřil na analýzu systému?
(PERSON2) Jo, právě teď tak trochu čekám na přepracování souboru dat z ([PERSON9]).
[PERSON9] Podíval jsem se na (kód) a myslím, že vím, proč je to tak pomalé.
Protože pro každý záznam v terminologii v (Europar) přepracování otevřete datový soubor, tokenizujte ho, přečtěte ho řádek po řádku, tokenizujte ho řádek po řádku a pak ho zavřete.
Ale to děláš jenom ty -
(PERSON4) Tak, pamatuji si, že pro [PROJEKT1] jsem to dělal z loňského roku z nějaké chalupy v horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím předložit.
A <smích/> tak to je také něco, co se stane [PERSON8] Obávám se, že by mohl být...no, žádná párty, ale možná na té vzdálené párty.
A pak by si najednou uvědomil, že to musí předložit.
Takže v tu chvíli žádná recenze nebude. <smích/>
Prostě by vzal PDF a nahrál to tak. <smích/>
(PERSON7) No, dobře.
Jo, zkontroluji to na 21. a jinak jim pošlu e-mail
(PERSON4) Prosím, myslím, že bude lepší poslat jim e-mail hned teď a jen se předem zeptat na ten odkaz.
(PERSON7) Dobře.
(PERSON4) Jo díky
(PERSON7) Máme dnes ještě nějaké další problémy k projednání, nebo je to vše až do Nového roku?
(PERSON6) Doufám, že tu pro mě nic nebylo?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo nástrojové papíry, které byly publikovány jako speciální vydání PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálem, jako by tam byly také emise PBML, které míchaly prázdné okrajové papíry a samostatné papíry, protože těch papírů bylo hodně.
A dokonce jsme měli věc, jako když papír nebyl dost dobrý pro PBML, ale když byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro jedno z příštích vydání PBML.
Takže máme, jak jsem už řekl, váš systém, váš nástroj je zajímavý.
Prosím, zveřejněte to na maratonu MT mezi lidmi.
Ale tvůj referát je moc špatný
Musíte ho vylepšit a dostanete se jen k dalšímu PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že když zkusíme SIGDial, přilákáme lepší účastníky?
(PERSON3) To je ano, to jsem si taky myslela, ale neznám ani jedno z těch míst.
V červenci mají poslední papírovou registraci
Takže konference byla v září a papírové podání bylo v květnu.
Protože pro Interspeech bychom to taky mohli rozdělit papír po papíru.
aby se některé dokumenty dostaly do interspeech procedury.
A některé z našich podkladů by přišly později do řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď se SIGDial nebo Interspeech.
Pokud jim nebude vadit, že mají některé naše podklady, vzhledem k tomu, že tyto dokumenty jsou odevzdány do březnového termínu.
Takže je tu absolutně striktní požadavek.
A myslím, že proti tomu nemohou mít nic.
Protože jestli ten článek stojí za publikování.
Jako, je to jen bonus, že noviny mají nějaký sdílený výsledek úkolu, který se objevuje v satelitní události.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o speciální zasedání.
V Interspeech se tomu říká speciální zasedání, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří připravit referát do uzávěrky pro interspeech, zašlete jej jako příspěvek pro interspeech a budete ho mít v Interspeech.
Ah, pokud to neuděláte, ah, udělejte to do termínu Interspeech, tady je náš termín.
A to je pro PBML.
(PERSON7) Ah, okej.
Ale je to jako při satelitní akci Interspeech.
Interspeech jako by se do žádného řízení nedostal.
(PERSON2) Můžete, myslím, že si prostě můžete rezervovat celý semestr jen na kurzy [PERSON9] a budete mít hodně práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že to opravdu není věc, selhat v jeho kurzech.
Jako když selžete, protože nejste schopni to dokončit.
Samozřejmě že to lidi prostě vzdávají, ale myslím si, že je to možná z jiného důvodu, že prostě není možné to přejít.
Myslím si, že je to určitě možné, ale je to hodně práce.
Jo, myslím, že nám na začátku semestru řekl, že jestli chceme jedničku, dostaneme jedničku (
Právě v druhém termínu byste ji měli odevzdat.
To je v podstatě jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů z předchozích let, mnoho lidí to nedělá.
Zjišťují, že je pro ně jednodušší číst na zkoušku.
Ne, promiňte, učte se na zkoušku-
(PERSON2) Jo, protože obecně jsou jeho zkoušky poměrně jednoduché.
(PERSON2) Takže bych neřekl, že je to super snadné, protože existují kurzy, kde je zkouška jako zábava.
No, jedna z nich byla pro mě včera.
(OSOBNOST) Jo, když to má krátký kontext a protože dělám rozhodnutí na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se to opravdu zavazuje k něčemu a například za sekundu nebo dvě, přijde na to, no, vlastně to byl špatný překlad.
Snaží se tedy použít jiné formulace.
Například specifikovat tu věc.
Takže vlastně se mi to opravdu líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když jste mohli vidět, že model udělal chyby na první pokus, opravdu to chtělo udělat nějakou korekci.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i trochu nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita kvůli překladu, pokud si přečtete všechno, tak dostanete stejné informace, ale formulace je prostě špatná, protože použila například více slov a použila nějaké korekce a tak.
Takže si myslím, že to je naprosto v pořádku pro simultánní, pokud neztratíte žádnou informaci.
A pro jaké jazykové dvojice máte tyto výsledky, jako nějaké příklady?
Protože bych se na to rád podíval, jen tak ze zvědavosti.
(PERSON2) Určitě, můžu ti dát moje záznamy.
(PERSON7) Ale ve kterých jazycích?
Protože víte, že nemluvím německy.
(PERSON2) Anglicky a německy.
(PERSON7) Jo, ale já nutně nemluvím německy < smích
(PERSON2) Pak mohu poskytnout angličtinu-čínštinu a angličtinu-japonštinu, pokud to pomůže <smích/>.
Takže znovu, chci, aby to bylo lidsky čitelné.
Protože tohle blikání je opravdu otravné a pak se přestanete soustředit na to, co bylo skutečně řečeno, protože je to možná také otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Promiňte, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoliv vidím slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš jako sáček.
Tak jsem vložila slovo do sáčku.
A rád spojuju věci v tašce, abych získal celkový obraz slova.
A myslím si, že to je ten problém s blikáním.
Když něco přeložíš a pak to změníš, tak už jsem to vlastně četl, mám to v hlavě.
A pak ztratím soustředění a kontrolu nad tím, co bylo vlastně tehdy přeloženo jako správné a co nebylo.
Takže to je důvod, proč si myslím, že celá ta věc s blikáním je špatná a hloupá už z definice.
Jako bych viděla motivaci, jako že chceš ukázat všechno, co máš.
I když nemůžeš slíbit, že je to dobré.
Myslím si ale, že s těmito informacemi navíc pracovat nemůžeme.
A myslím si, že problém je možná v tom, že systémy jsou vytvořeny lidmi, kteří s nimi pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, pořád to ukazuji a je to nějak dobré, ale myslím si, že vývojář se doopravdy nesoustředí na samotný obsah.
A jak vnímáte obsah, ale spíše to, že, no jo, můj systém to dokáže velmi rychle vygenerovat.
A i když to jen hádá, že kvalita je v pořádku, myslím, že možná proto byla vytvořena retranslace.
Jen vývojáři systémů jsou dychtiví zobrazovat informace a myslím si, že protože jsme omezeni v tom, jako je objem informací, které můžeme vnímat nějaký čas, vidíme, že informace navíc jsou pro nás jen další zátěž.
Takže si myslím, že není dobré ukazovat něco navíc.
Jako když chcete snížit latenci, tak místo blikání prostě snižte kvalitu.
Myslím, že je to pořád lepší než ukazovat záblesk.
Protože jaký by byl skutečný případ použití?
Proč byste opravdu potřeboval vidět tu nestabilní hypotézu?
Třeba z uživatelského pohledu?
(PERSON1) Jako technicky, když začnou lidští překladatelé překládat, myslím tím cíl, který mají anotátoři, snažili by se následovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli a to by bylo špatně, takže by se prostě opravili.
(PERSON2) No ale jo tohle znamená s mým řešením, jako byste nedělali blikání, ale zavázali jste se, jako že neexistuje způsob, jak to změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Mám silný pocit, že naše práce není zrovna v oblasti řeči, je nezdravá.
Protože tady neexistuje pojem řeči.
Pracujeme přímo na textu.
Ale je to tak, že návrh na statistický seminář v letošním roce skončil, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel v roce 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme buď jeden ze dvou sektorů nebo interspeech, protože oba jsou v komunitě dobře známy.
Dokážeme účastníky motivovat k tomu, aby se přihlásili.
Ah, jediná námitka, kterou teď nacházím, je, že pokud jde o interspeech, tak nám neumožní prostor v jednání, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšeni, když budou publikovat práci v archivu
Takže v archivech mohou lidé publikovat kdykoliv, ne?
To tedy není pro jejich profil přínosem.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu?
Takže to byl důvod, proč jsem se zvlášť zaručil za mimořádné zasedání
Ale tentokrát, problém je, co mohu pochopit je, že naposledy, časové období mezi návrhy, podáním a konečným podáním papíru bylo pět měsíců, takže by to bylo dost času pro náš rozvrh, ale tentokrát..
Jsou to jen tři měsíce.
Vidím tedy tento veletrh jako důležitý možný zdroj nerodilé anglické řeči, který můžeme využít pro rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli soustředit na soutěž Clearest Voice a můžeme udělat stánek, pokud budeme muset.
Ale rád bych to omezil, protože šíření mezi středoškoláky má pro nás menší dopad.
Důležitější je použít ji jako zkušební sezení.
Takže bychom se měli soustředit, [PERSON1], na [PROJEKT2] Clearest voice, a udržovat pořadatele spokojené, abychom tam mohli dělat sběr dat.
dělejte, co chtějí, abychom udělali výměnou za to, a my potřebujeme zkontrolovat jejich plenární program a jaký typ titulkování by byl pro tento plenární program užitečný.
takže by to pro nás bylo testovací sezení, a co se týče naší přítomnosti na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže pokud se nás někdo zeptá, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, tak dobře, ale pokud ne, pak si myslím, že je pro nás rozhodně dobré být za oponou a v zákulisí a dělat tam svou práci.
Jo, ještě jsem se kvůli tomu nepokusil o registraci, ale myslím si, že minule bylo povinné mít stánek.
(OSOBO2) Ano. Takže s nimi proberte, co je potřeba, aby byli šťastní, a oni nám umožní dělat Nejčistší hlas, což je ta nejdůležitější věc.
Zkušební sezení není tak naléhavé.
A ten stánek je prostě něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se k sezení připojili dříve, než aby dělali takovéhle věci.
Takže opravdu potřebujeme procvičit tyto přípravy.
S on-line světem to vypadá, že stačí j p do relace, a práce je hotová.
To však není tento případ.
Zprovoznění zařízení a jeho správné připojení trvá vždy 30 minut
Takže tam musíme být dříve.
A když nějaké sezení, které děláme, začne v devět, ale organizátoři se sejdou ve čtvrt na devět.
Pak musíme přijít už ve čtvrt na osm, abychom měli těch 30 minut navíc, abychom se ujistili, že vše běží a abychom naháněli lidi.
Takže, toto je poznámka pro všechny, že aby vedení fungovalo, prosím také předvídejte, co po vás vedení může náhle chtít, a to by trochu pomohlo.
Dalším sdělením, které je velmi důležité, je záznam těchto důležitých zasedání.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJEKT4] a [PROJEKT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní v nahrávání těchto zasedání.
Takže pro účely dalšího vyhodnocení nebo analýzy toho, co se nepovedlo, je důležité mít dobré nahrávky těchto sezení.
A jedním aspektem je získat souhlasy, aby nám bylo skutečně umožněno nahrávat.
A to i když se snažíme získat souhlasy zpětně nebo tak nějak.
Pak je tu technický aspekt nahrávání.
A viděli jsme, že je to tak různorodé a složité.
Jo, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citrony v řadě :(
Objednal jsem si u této firmy, protože jsem si ji koupil v předchozích sezónách a fungovala nám skvěle.
V této sezóně jsem si koupila další velikost, kterou jsem potřebovala.
Jedno z pyžam, které jsem dostala, mělo díru na patce pyžama.
Vrátil jsem ji a firma mi poslala novou.
Náhradní pyžamo, které měl jednou na sobě můj syn, jsem dala do pračky jako vždycky a zip se ulomil!
Jsem tak zklamaná, protože nemám čas řešit reklamace každých pár dní a přesto se to právě teď děje.
Přesně, jak bylo popsáno
Tohle je jen obyčejný kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuovém neprodyšném sáčku, takže je potřeba ho na pár dní pověsit, aby se na něm uvolnily vrásky a trochu se „nafoukl“.
Měřím 5 stop a 6 palců a kabát je na mě dlouhý po kolena.
Objednala jsem si 2+ velikosti vzhledem k dalším připomínkám a zkušenostem z minulosti a kabát je pravděpodobně o něco větší, než je potřeba.
Nicméně s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale není na ní žádná pouta
Přední zip funguje.
Na boku ani vzadu nejsou žádné otvory pro větší pohyb, ale s většími rozměry bych měla mít dostatek místa.
V pase mám dvě kapsy (u vás mohou být vyšší nebo nižší).
Nejsou zde žádné ozdoby ani detaily stylingu – je to BASIC COAT.
Za tu cenu si myslím, že to je v pořádku.
Měla jsem ho na sobě za větrného dne, ale ne za studena.
Necítila jsem vítr, takže to považuji za dobré znamení.
Jsem však zvědavý, jak si povede v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem spokojená.
Vak vakuového těsnění se dá znovu použít a prodejce k němu připojil opravdu roztomilé poděkování, což bylo skvělé.
Tohle je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký
Tohle je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký.
Nemačká se, ani po nacpání do plastu a krabice byla velmi hladká, takže je to opravdu super.
Tohle se dá snadno obléknout a má to takový vintage nádech díky délce a střihu, což mě opravdu baví.
Myslím, že by to mohlo lichotit komukoliv.
Měřím 175 cm a vážím 130 liber a objednala jsem si to malé, takže bych řekla, pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně o velikost níž.
Nefungovalo to s mým Buickem LeSabre z roku 1999
Zboží dorazilo rychle a vypadalo, že je v dobrém stavu, dokonce obsahovalo i předinstalovanou baterii.
I když měl být kompatibilní s mým Buickem LeSabre z roku 1999, ovladač se nepodařilo naprogramovat ani synchronizovat s autem.
Pokyny jsou celkem jednoduché a já vím, že jsem se jimi řídil správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý ovladač.
Tento nový však nefungoval a tak ho budu vracet.
Nebyl žádný problém s prodejcem nebo servisem, jen se zdálo, že tato konkrétní věc byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Gril auta mi utrhlo něco velkého, co letělo po dálnici, takže jsem potřeboval náhradu.
Bála jsem se po přečtení některých recenzí, že to nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE 2013.
Neoblékla jsem si ho sama – jeden chlápek v autodílně mi to udělal -, ale vypadalo to opravdu jednoduše.
Prostě se to za necelých 5 minut hned zapnulo.
Dal jsem mu 4 hvězdičky za robustnost, protože to opravdu vypadá dost chatrně (čas a létající trosky to prozradí), ale přes to všechno jsem velmi spokojený, že moje auto už teď nemá na předku otevřenou tlamu a že cena byla rozumná.
Potřebuje vylepšení
Super úžasné světlo Můj 5letý absolutně miloval toto světlo Netrvalo to dlouho, dostal ho k narozeninám v lednu už je únor má problémy s tlačítky a neběží jasně se zásuvkou vysává baterie dokonce zkoušel dobíjení baterií Super cool, ale potřebuje zlepšení
Hudební zahájení
Piano je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci rukou a očí.
Klavír není jen hrací hračka, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby se vaše dítě stalo budoucím pianistou, měli byste tento produkt vyzkoušet!
Za ty peníze to opravdu stojí!
Dal jsem si to na nos, jak mi bylo nařízeno, dvakrát denně, a dvě minuty jsem to tam třel.
Kůže na nose mi zrudla a byla úplně odřená.
Dost mě to zaskočilo.
Měl jsem dobře zahojenou jizvu po pádu do ostnatého drátu z doby před lety.
Nejen, že tento přípravek nefungoval, ale málem jsem skončil u dermatologa, nicméně když jsem dal aqua-for a obvaz přes celou oblast, tak se to asi po týdnu konečně uklidnilo.
Můj nos je však stále zarudlý, ale doufám, že to brzy přejde.
Někdo zkazil vzorec??
To je tak divné.
Za normálního světla to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí malířské tyčinky od jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaný.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červené nebo růžové.
Ta bílá není tak zářivá, jak jsem doufal.
Zbylé barvy jsou skvělé a líbí se mi, jak snadno se tyhle barvy smyjí.
Jen jsem si všiml, že byla růžová
Myslím, že fialová bude stačit.
většinou funguje
Před několika měsíci jsem si vybělila celou hlavu a pak si ji obarvila černou krabicovou barvou
Pak jsem šla a nechala si nanést melír na celou hlavu
O pár týdnů později jsem si na vlasy nanesla modrozelené barvivo Arctic Fox a už nevybledlo.
Použila jsem to s přípravkem Olaplex č. 3 a TREMENDOUSLY to celé prosvětlilo, odstranilo zelené a modré části a také zvedlo tmavé barvivo krabičky.
Nicméně po jednom dni jsem si všimla zeleného odstínu na vlasech.
Každý den je to horší a už jsem použila extraktor barev dvakrát, se stejnými výsledky.
Moje vlasy jsou také stále tmavší tam, kde bylo barvivo
Je to skvělý produkt, ale nezdá se, že vydrží dlouho.
nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba mírnit nějakým realističtějším hodnocením.
Zkusila jsem si to přečíst, ale jazyk mi prostě připadal plochý.
„sladkovodní“ metafora a mnohé popisy dělohy jako řeky a dítěte jako ryby mi připadaly nucené, ošuntělé a vykonstruované.
Přeskočila jsem dopředu a vypadalo to, že jediné, co najdu, bude školní drama.
Dávám této knize 10 hvězdiček!
Vynikající čtení!
Tu knížku jsem absolutně miloval!!
V průběhu let jsem adoptovala 4 siamské kočky od Siri a všechny z nich byly absolutní láska.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Zábavné, vtipné a velmi zábavné!!
Siri se ve své snaze o záchranu koček (hlavně siamských) vydala nad rámec svých možností!
Opravdu se mi líbí to světlo v prstenu!
Za tu cenu je báječné a odvede svou práci
Jediný problém je, že žárovka se zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji zase zapnout.
Nemyslím si, že by se to mělo stát...Nevím, jestli mám vadné světlo, nebo co, ale kromě přehřívání je to velmi pěkné kruhové světlo.
Zmatená dějová linie
S knihou bylo těžké držet krok, protože hodně poskakovala.
Také název se nehodí k příběhu
Autor uvedl, že tímto mimozemšťanem bylo infikováno několik lidí, nicméně vynechal možná podrobnosti o tom, kdy nebo jak se to stalo.
Občas jsem byl zmatený a musel jsem se vracet a znovu hodně číst, abych se ujistil, že mi nic neuniklo.
Miloval jsem Collinse...
Chvíli trvalo, než jsem si na Gradyho zvykl.
3 1/2 Stars Remedy je bratrův nejlepší kamarádský románek stejně jako druhá šance románek smíchaný do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše, aby získal Collinse zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostala vše, o čem snila, nejlepší kamarádku svého bratra... ale když se druhý den ráno probudila sama a už o ní neslyšela, věci se definitivně změnily.
Teď je Grady zpět a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdá.
I když se mi líbila premisa tohoto příběhu a občas i Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale ani neposlat Collinsovi dopis, ve kterém by se vysvětlil?
Nechat ji celé ty roky přemýšlet a trpět a pak čekat, že ho přivítá zpět s otevřenou náručí?
Měl halucinace?!
Collins měl právo být rozčilený, naštvaný, zraněný, atd.
Udělala dobře, že se s ním poprala, když ji chtěl zpátky, a pohnula se kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collinsovou v téhle knize, byla silná a střežila si své srdce a za to jsem ji obdivoval.
Jistě, milovala Gradyho, ale byla vystrašená a váhala, jestli ho má pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla z těch dvou rozhodně moje nejoblíbenější.
Rozhodně nechala věci plynout tempem, jakým chtěla, a když byla připravená naslouchat, naslouchala.
V téhle knížce je hodně úzkosti a já jsem si užíval, jak se ti dva znovu spojili, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevypadal tak ufňukaně a byl trochu chápavější.
Pořád říkal, že to chápe, ale chvílemi byl na mě trochu moc dotěrný a ke konci byl milý.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla problém číst jeho názory, protože jsem se nedokázala spojit s jeho postavou.
První část této knihy nebyla moje oblíbená, ale on druhý díl?
Zbožňovala jsem ho, proto mé hodnocení.
Pokud máte rádi druhou šanci a romance o nejlepších kamarádech, možná si tuto knihu opravdu užijete, jen jsem to měla s Gradym ze začátku těžké a jak zvládal některé věci, které dělal
On a Johnny Depp jsou úžasní herci.
Ohledně jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké poznat, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla, bylo to velmi dobře provedeno.
Komprimovaný časový rámec od 10. května do 26. května byl dobře prezentován s hodinami 7 otáčení stránek...
Scéna a kostýmy byly vynikající.
Je dojemné s dnešní dvojicí polobohů, kteří zastávají světovou politickou pozici.
Stojí za pohled několikrát...stojí za zamyšlení... ještě mnohokrát
Vyhněte se Wifi připojení- přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydleli v hotelu.
Nepodařilo se mi sehnat toto měřítko pro připojení k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domu a budu si moci nastavit vlastní Wifi systém.
Březen 2018- Nastavil jsem si Wifi systém a toto měřítko se stále nepřipojí
Pokaždé, když to zkusím, dostanu chybovou zprávu.
I když jsem 10' daleko od Wifi jednotky.
Sledoval jsem instalační video na YouTube bez úspěchu.
Když jsem si jednotku koupil, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho toto měřítko používá Wifi router pro komunikaci s telefonem.
Tento systém je omezen na připojení routeru...který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Nikomu bych nedoporučoval toto měřítko kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to měřítkem připojení Bluetooth.
Dobře, ale rád bych našel něco lepšího
Po dlouhém výzkumu jsem začal tento produkt používat před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval dobře.
Nicméně vysychá tak rychle, že nakonec používáte tolik lubrikantu, což nakonec stojí hodně peněz, stejně jako je příliš rušivý při sexu.
Jen jsem byl příliš líný hledat nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a není příliš nákladný.
Výdrž baterie na té, kterou jsem koupil na Amazonu, je hrozná.
Stále nemohu uvěřit, že Logitech ukončil výrobu tohoto dálkového ovladače, nic jiného se tomu ani nepřibližuje
Tenhle dálkový ovladač Harmony absolutně miluju, tohle je můj čtvrtý.
Pes sežvýkal ten první, manžel klečel na obrazovce toho druhého a ty třetí pořád fungují, ale uprostřed dotykové obrazovky je otisk lokte... koupil jsem tenhle jako zálohu a obrazovky skvělé, ale baterie, se kterou přišel, vydrží nabití možná na pár dní.
Můj původní (třetí) udržuje nabití týdny v kuse a na všechno používám dálkový ovladač
Rozbito za necelý týden.
Líbí se mi výrobek je to pěkná velikost a barva!
Bohužel ho měl jen týden a otevřel jedny dveře a to praskla horní část kusu dřeva!
Jsem opravdu zklamaný!
Všechno je to smontované a já už tu krabici nemám, tak jak jsem mohl vůbec přemýšlet o tom, že bych ji poslal zpátky?!
Manžel se to pokusil opravit lepidlem na dřevo ale bohužel ani to nefungovalo!
Dveře se znovu otevřely!!
Montáž není příliš snadná a navíc...
Po sestavení je to pěkný kus nábytku, ale montáž byla obtížná.
Některé znaky písmen byly špatně označeny, takže jsem se musel pokusit přijít na to sám Šrouby, které dodali k upevnění podlahy a bočních panelů, byly všechny popraskané.
Musel jsem jít ven a koupit rohové držáky, abych si byl jistý, že zůstanou pohromadě
Také skleněné výplně dveří jsou mimo linii a nepasují rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny dveře zůstaly zavřené, protože magnet, který drží dveře zavřené, není v pořádku.
Pořád jsem ještě nepřišel na to, jak je zarovnat.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA PŘÍŠTĚ PODU
Tyto jsem zakoupil v únoru.
Nedávno jsem je zkoušel používat a bohužel pokaždé, když jeden vyzkouším, můj stroj Keurig mi dá chybové hlášení, že modul není kompatibilní s mým přístrojem.
Používal jsem lusky z Donut Shopu ve svém stroji od chvíle, kdy jsem ho poprvé zakoupil a nikdy jsem neměl problém.
Při bližším zkoumání lusku na kávu jsem si všiml, že kód vytištěný na vrchní straně lusku není příliš čitelný, takže mohu pouze předpokládat, že mám špatnou krabici.
Koupil jsem krabici po 72 kusech, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jednu z každé ze 6 krabic a dostávám stále stejné chybové hlášení.
Vím, že to není můj stroj, protože ostatní, které jsem vyzkoušel, fungují skvěle.
Tenhle problém mám pouze z této zásilky.
Velké zklamání, protože mi vypršelo okno pro návrat.
AKTUALIZOVÁNO: Mluvil jsem se zástupcem zákazníka, který mi vrátil peníze.
Děkuji AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestách.
Taková vymoženost!
Je opravdu příjemné mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích s sebou!
Miluji uhýbání, a je tak pohodlné mít je, abych si je mohla hodit do kabelky na večeři venku, nebo je použít u kamaráda doma
I když jsou trochu drahé, nemůžu vystát Equal nebo růžovou hmotu v ledovém čaji.
Swerve nebo nic, takže jsem nadšená, že mám své sladidlo na cestách!
Nedělá vlastně žádné „čištění vzduchu“
Koupil jsem to jako zvlhčovač, část „čištění vzduchu“ je vlastně falešná reklama; v závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo něco takového.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač knotový se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává proutky.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně budete muset provozovat asi 5 let, abyste vyrovnali rozdíl.
Na svou velikost má poměrně velkou kapacitu vody, protože „nádrž“ je nedílnou součástí jednotky a má nízký výkon (i když ne lepší než typ knotu).
Také se poměrně snadno čistí, i když plastové disky vlastně nelze obsluhovat, protože diskovou jednotku nelze rozebrat.
Nicméně pro německé strojírenství není kvalita stavby nijak vysoká.
Já ho mám už rok, což by znamenalo asi šest měsíců provozu za chladného počasí, a z ventilátoru se vyvinul velmi nepříjemný rachot.
Hádám, že to jsou ložiska ventilátoru, takže jen čekám, až tady dojde k úplnému selhání.
Jak poznamenal někdo jiný, každá oprava se téměř rovná koupi nového zvlhčovače.
tl; dr – nestojí za příplatek, s zvlhčovačem knotů jste na tom lépe
Myslím, že to bylo jednodušší rozbít, než si mysleli.
Dávám tomuto produktu 3 hvězdy s tím, že když jsem to dostal už to bylo rozbité již uvnitř.
Jakmile jsem si to prohlédl jsem si uvědomil, že ten, kdo dal to do krabice dal to tam rozbité, To by mohlo být problém výrobce, pro výrobce problém by mohl být, že kupující vrátil položku a tvrdil, že prostě nechtěli nebo nepotřebovali to a Amazon možná neudělal dostatečně dobrou kontrolu kvality, když to vrátil.
Ve vší spravedlnosti kupující nemohl říct, že to bylo rozbité, protože pak Amazon by si to nemohl vzít zpět, což je dobré zejména s tímto druhem výrobku tak jako tak, i když já jsem ten, kdo uvízl s něčí nedbalosti.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a prodiskutoval to se svým partnerem, jsem se rozhodl dát tomuto kupci ještě jednu šanci.
S tím, že budu pouze aktualizovat své hodnocení na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (alespoň adresováním) a v případě, že položka přichází ve skvělé formě, ve skutečnosti má možnost dělat to, co dělá, a dobře dělá to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem vcelku spokojen, ale instalace pro mě nebyla tak jednoduchá.
Několikrát jsem zkoušel nainstalovat oba „zvonky“ do připojeného vysílače, ale bez úspěchu
Už jsem to chtěl vrátit, protože to nefunguje, ale řekl jsem si, že to ještě jednou zkusím a zkontroluji baterie ve zvonech.
Voila...z krytů baterií trčely malé plastové výložky, které jsem natáhl a z nich vylezl plastový kus, který zakrýval baterii a bránil jejímu fungování.
Poté, co jsem odstranil tyto kusy plastu, zvonky fungovaly bez problémů a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v návodu pro uživatele není žádná zmínka o plastu nad baterií, která musí být vyjmuta, aby zvonek fungoval.
Bylo by mnohem méně frustrující, kdyby se o tom zmínili a já si nemyslel, že problém byl v tom, že jsem instalaci nedokončil správně.
Je to dobrý produkt s širokou škálou kroužků, zvonků a melodií, které si můžete vybrat a je snadné je měnit, kdykoliv chcete.
Při hodnocení tohoto zvonu se ptají na to, jak je odolný vůči povětrnostním vlivům.
Nemohu to komentovat, protože byla instalována 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolná vůči počasí až do příštího období dešťů...pravděpodobně v listopadu.
Ztratil jsem balíček – Nabil mě znovu
Vyrostla jsem s nimi a byla jsem nadšená, že je koupím svému synovi, ale ztratili balíček živých housenek.
Řekli mi, že ho vymění a tentokrát si naúčtují polovinu poštovného.
Po dlouhém telefonickém hovoru mi nakonec znovu naúčtovali novou objednávku se slevou asi 3 $
Myslela jsem si, že je to dost neprofesionální, protože nejenže o to přišli, ale oni mě vedli k přesvědčení, že to napraví jen proto, aby mi naúčtovali skoro plnou cenu na konci třicetiminutového telefonátu s nějakým blábolením o poukazu.
Strávil jsem 30 minut na telefonu, takže jsem ustoupil a koupil další sadu housenek.
To je fuk
Funguje dobře po některých bolestech hlavy
Měl jsem nějaké problémy s jeho zprovozněním.
Dodávaný kabel nebyl dobrý – baterii nenabíjel.
Když jsem vyměnil kabel za můj vlastní byl schopen nabíjet a pak připojit zařízení přes bluetooth k PC.
Měl jsem problém najít PC software, ale když jsem poslal e-mail na jejich podporu odpověděli během jednoho dne se správnou informací o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, nicméně jsem nebyl schopen připojit se ani k iPhone nebo iPad (vyzkoušeno několik z každého) přes bluetooth.
Budu zařízení muset pevně zapojit, pokud se rozhodnu používat toto zařízení ve svém produktu.
... byla příliš žlutá před nákupem a bylo mi řečeno, že je jako starožitné zlato
Zeptala jsem se prodejce, jestli je barva příliš žlutá před nákupem a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic podobného!
Sada vypadá velmi levně.
Je super lesklá žlutá se spoustou CZs, ještě zářivější.
Na fotce vypadá skvěle, ale ve skutečném životě bych ji nedala ani teenagerovi, aby ji nosil.
Líbil se mi prsten – ale nemohl jsem ho nosit pořád! :(
Tenhle prsten byl nádherný.
Moc se mi líbil design a jeho robustní vzhled; vypadal draze a byl velmi pohodlný
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec jsem výrobek vrátil, je ten, že jsem si uvědomil, že bych ho nemohl nosit pořád.
Rád nosím své prsteny pořád, proto se vždycky ujišťuji, že dostanu šterlinkové stříbro, a vím, že někteří lidé říkali, že se jim prsteny po nějaké době zašpinily, ale já jsem ten svůj nosil asi týden v kuse – dokonce i při mytí rukou – a žádné zašpinění jsem si nevšiml.
Zajímavé je, že problém, který jsem měl, byl ten, že vnitřní pásek prstenu ve skutečnosti zbarvoval můj prst do bíla a vlhka – něco jako obvaz, když ho necháte dlouho na sobě.
Stalo se to i tehdy, když jsem se ujistil, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se mi to nestalo s žádným jiným prstenem, ale bylo to nepříjemné a tak jsem se rozhodla, že to není prsten pro mě.
:( Škoda, protože jsem to opravdu milovala!
Takže pokud si kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám, jděte do toho!!
Nebudete zklamáni!
Kupte si rozmazleného šéfkuchaře...
Vlastním malou naběračku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých 'věcí' je ve skladu.
Miluju používat tyto lžíce při pečení dokonale porcovaných sušenek.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a pořídit si tu OXO – většinou mám s jejich výrobky štěstí.
Tohle ne.
Asi u 30. sušenky s arašídovým máslem přestala páčka uvnitř naběračky fungovat.
Musela jsem páčky rozpárat a znovu umístit páčku, abych mohla udělat ještě pár dalších kroků, a pak opakovat.
Takže... zachraňte si zdravý rozum a kupte si Pampered Chef..
Stojí to určitě za to!
Nebude kupovat Mr. Coffee znovu
Chvíli to byl výborný kávovar, ale vždycky s ním byly nějaké problémy.
Kdyby se voda dostala mezi černý plast a kov na karafě, prosakovala by a voda by vytékala celé dny.
Pak se rozbila naše plastová páka, která umožňuje kávě proudit přes filtr do karafy.
Kontaktoval jsem zákaznickou podporu s dotazem na nový kus, ale oni mě pouze odkázali na servisní středisko, které je od mého domu vzdáleno více než 90 minut.
Skvěle vaří kávu a udržuje ji horkou, ale je s ní příliš mnoho dalších problémů, než aby se do ní dalo investovat za současnou cenu.
Musím koupit!
Milovala jsem tuto růžovozlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v úchytech a všiml jsem si to předtím, než jsem si to koupil, což je důvod, proč stále dávám 5 hvězdiček!
Bylo to snadné vyčistit a vše přišlo zabalené jednotlivě, které jsem zjistil, že je opravdu organizované a to uklidnilo mou duši lol láska, láska, LOVE barva a já bych určitě koupit to znovu pro sebe nebo pro milovanou osobu!
Může být dobrá na tyči, ale ne jako závěsná přepážka nebo štít proti povětrnostním vlivům.
Škoda Audubonu.
V návodu se píše, že máte zatlačit zástrčku nahoru otvorem v přepážce a „Ujistěte se, že je bezpečně na svém místě“.
JAK???
Je navržena tak, že přepážka jednoduše sedí volně na zástrčce, takže může být vytlačena nahoru jakýmkoliv tvorem nebo sebemenším větrem.
Můžete otočit zástrčku vzhůru tak, aby palec byl na spodní straně přepážky, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to nezvládne a jen ty nejmenší prsty to budou mít snadné.
Trvalo mi přes hodinu, než jsem je nedodělaně přišrouboval, abych zajistil přepážku k zástrčce
Je to kompletní PITA.
Objednal jsem si čtyři takové; ty tři, které jsem neotevřel, půjdou rovnou zpátky a já jsem na trhu s lepšími ochrannými prostředky proti povětrnostním vlivům.
(Přiznejme si to; neexistuje nic takového, co by veverky skutečně „vyvedlo z míry“!)
Miluji mnoho vlastností těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které mé nové rostlinné sazenice dostávaly z okna.
Miluji mnoho vlastností těchto světel.
Klady: Za prvé, snadno se přichytí k mé polici, a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou na dotek chladná a nezpůsobila žádnou škodu ani při dotyku s rostlinami.
Věřím, že mé zelenině prospívá světlo.
Světla jsou stmívatelná, ale používám jen to nejsilnější nastavení.
Nepoužil jsem časovač, raději jsem je zapínal a vypínal sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby mohla být primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až světla dohoří, budu si muset koupit úplně novou jednotku
POZOR...SMELL JE VELMI BAD...CARD SLOTS TOO BIG!
Když jsem to poprvé uviděl, pomyslel jsem si, že je to krásné, ale vonělo to TAK ZLĚ.
Nejdřív jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že je to MOLD vůně.
Nikdy to nezmizelo, tak jsem to musel vrátit.
PLUS, kapsy na kreditky jsou příliš velké.
Kreditní karty sklouznou až dolů, tipy se nezobrazí, takže nemáte ponětí, která karta je kde a je velmi obtížné dostat se ven.
FOTO, které ukazují, kde jsou karty, je NEAKTUALIZOVANÉ.
Je velmi malý ..
Dostal pásek na peníze na cestu a je o hodně menší, než ukazují fotky
Přál jsem si, abych si ho nekoupil a ještě se budu muset poohlédnout po něčem větším.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Za prvé musím říct, že ta barva je miloučká
Spousta věcí, které si objednávám ve fialové, mi vždycky přijdou moc lehké, moc dětinské, moc divné, moc neonové.
Ale tahle fialová byla hluboká a svěží a moc se mi líbila, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, co jsem měl.
Dodává se s krytem a i když možná nemá moc funkčního využití, opravdu udržuje ostrý vzhled.
Balení je hrozné – obdrželi jsme 3 poškozené kytary
Velmi pěkná kytara
Škoda, že firma neví, jak svůj výrobek ochránit.
Nesnažte se přijímat takové, které nejsou poškozené.
Vrátili jsme 2 z důvodu poškození při přepravě a 3. byl také poškozen
Vzdal jsem to
Dodávají ji v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné polstrování
Parádní koncept!
Jen potřebuje další vylepšení, aby to byl opravdu parádní produkt
Opravdu parádní koncept, pokud jde o karaoke-ing.
Miluju karaoke, takže tenhle mikrofon okamžitě vzbudil můj zájem.
Myslím, že celkový design je dobrý – růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje tak, že se to současně chová jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co vychází.
V samotném mikrofonu ale není žádná hudba.
Má bluetooth konektor, takže ho synchronizujete s telefonem a stáhnete si karaoke aplikaci, která umí posílat karaoke písničky do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a vašeho hlasu (také samostatně!)
a dokonce má možnost nastavit úroveň ozvěny, takže vlastně zníte, jako byste byli v karaoke místnosti.
Některé věci, u kterých bych chtěl vidět budoucí vylepšení, jsou: 1) je tu nějaká otravná zpětná vazba, která zřejmě nezmizí bez ohledu na to, jak daleko mám telefon od mikrofonu.
Pokud jsi na to přišel, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem blázen do minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly design vylepšit.
3) podpora více karaoke aplikací A konečně, protože zvuk vychází přímo z tohoto mikrofonu, a ne přes plochou obrazovku nebo centrální reproduktor v obývacím pokoji, není to taková zábava v prostředí večírků.
Kdyby to výrobce dokázal nějak integrovat do většího party karaoke ekosystému, bylo by to nekonečno zábavnější.
Vyškrábané od Vision Supplies
Říjen 2017 zakoupil čtyři (4) kazety od Vision Supplies – Amazon Marketplace, takže bych je měl v případě potřeby a kvůli úspoře přepravních nákladů.
Za posledních pár let jsem použil dvě, asi jednu ročně, a fungovaly dobře.
Minulý týden jsem zkoušel použít jeden, skoro prázdný po vytištění 20 štítků, ale v posledním mi došel po 40 stranách.
Plastika na obou chybí.
Sdělená záruka vypršela!!!!
Kdo by kontroloval každou jednotlivou kazetu po obdržení????
BUYER BE AWARE!!!!!!!!!!!!!
Promiňte, cože?
Moje kamarádka mi doporučila masku této řady, tak jsem si koupila tuto, tento kondicionér a vše v jednom mléce.
Nemohu mluvit o účinnosti výrobku, protože zápach byl prostě nesnesitelný.
Znáte ten zatuchlý zápach, který staré budovy používají na ženských toaletách, aby zakryly zápach *dam*, ale ukázalo se, že to je jen takový kyselý, chemický, zatuchlý pach babičky?
Jo, to je všechno, co mě napadá, když tohle cítím.
Znáte různé tahy různých lidí, tak se vám možná ta vůně bude líbit.
Moje kamarádka říkala, že to může pomoci i těm nejvíce poškozeným vlasům, takže pokud vás vůně nezajímá, tak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že více a více přírodních linií to prostě nezajímá, protože se to stejně bude prodávat, a tak teď všechno voní jen jako těsto na hraní.
Ztratil jsem pár oblíbených vět kvůli změně receptury na levnější ingredience.
Nevím, jestli je to tak, nebo jestli je to padělek (volal jsem Davinesovi a oni řekli, že není), ale smrdí to jako Y U C K a musel jsem to vrátit.
Vypouští internet
Tento modem/router jsem si koupil asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale poslední rok navíc jsem měl problémy s tím, že mi vypadl internet
To se děje na všech mých zařízeních jak Wi-Fi, tak i drátových.
Jediný způsob, jak obnovit službu, byl provést reset napájení.
To se dělo jednou nebo dvakrát denně.
Vyšel Comcast, spustil novou koaxiální linku od podstavce k domu a zvýšil úroveň signálu.
Stejný problém.
Chlapi z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést tovární reset, abych to obnovil.
Na základě svých zkušeností nemohu tento modem/router doporučit.
Koupil jsem si modem/router Netgear AC1900.
To je fantastické.
Měl jsem to více než týden bez problémů
Je to rychlejší a dosah je větší než u Arrisu.
Četl jsem na internetu, že jiní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte internet Comcast, nedoporučuji tento modem/router Arris.
Pořiďte si Netgear, je mnohem spolehlivější.
ale stává se to dost často na to, aby to bylo otravné.
Pozitivní poznámka
1 z ventilátorů zněl nevyváženě z krabice.
Ovládání otáček je opravdu vratké – pokud je vytočíte na 100%, ventilátory se vypnou, takže je třeba ho zapnout na 100% a pak ho pomalu vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že to je pro většinu těchto typů výrobků v této cenové relaci obvyklé.
Nohy pro držení notebooku vzhůru, když je nakloněný, se několikrát ulomily...
Vracejí se dovnitř, ale stává se to natolik, že to je otravné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z ventilačních otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem doprostřed a poskytují velmi malý dodatečný průtok vzduchu do notebooku s takovou konfigurací chlazení.
OK případ se závažnými omezeními
Tento případ je ok, ale ne výjimečný – maximálně 3,5 nebo 4.
Problém je, že pro pero Tab A 10.1 w S je k dispozici méně pouzder.
Z těch je Gumdrop asi nejlepší, ale má několik vážných problémů.
Pouzdro z gumy (silikonu, čehokoliv) je velmi hladké a kluzké a nedává vám příliš sebedůvěry, když držíte Tab jednou rukou.
Tab A je těžký, takže pokud si lehnete a sledujete video, pouzdro vám sklouzne do ruky, takže musíte provádět častá přizpůsobení.
Musel jsem odstranit průhledný plastový štít, který kryje obrazovku, protože to narušovalo fungování dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní gumový vnější kryt působí opravdu pružně a chatrně.
A nakonec ztížili přístup k peru S.
Pero S se nachází v pravém zadním dolním rohu Tab A a díky nim se malá gumová chlopeň, která chrání roh, posunula dozadu pro přístup k peru S.
To znamená, že abychom dostali pero S ven, musí se klapka vychýlit o 180 stupňů.
To je opravdu nepříjemné a těžko se to dělá s jednou rukou.
Tento kufřík odvádí dobrou práci při ochraně mého Tab A, ale při těchto závažných konstrukčních nedostatcích jej nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Vše, co jsem potřeboval
Tento produkt je opravdu elegantní – jedna zastávka nákupu pro všechny mé potřeby připojení.
Miluju házet notebook a můj malinký napájecí adaptér do mého go batohu a být připraven pracovat na velkém 4k displeji nebo pořizovat fotky z mého fotoaparátu.
Jediná divná věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačů usb-c, které jsem vyzkoušel od různých značek), je, že mac zjevně nepozná rozdíl mezi násobky stejného monitoru (takže můj mac vysílá stejné video na všechny identické monitory připojené k rozbočovači ať už pomocí HDMI a / nebo VGA).
Ale pokud používám 2 samostatné rozbočovače/adaptéry nebo 2 různé modely monitoru, pak mac správně výstupy na displeje jednotlivě.
Ok, potřebuje nějaké vylepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký bezpečnostní zámek nad tlumičem (byl zmáčknut spíš náhodou, když jsem ho měl v kapse, než že bych ho chtěl použít) moji psi se dokonce omylem zapnuli poté, co šlápli na ovladač
Také pokud se váš pes rád válí v mývalích výkalech jako ten můj, je to taková bolest v zadku to čistit.
Když se fekálie dostanou mezi praskliny zařízení, což vyžaduje, abyste to celé rozebrali, pořádně to vyčistili a odstranili ten zápach.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že k tomu, aby to fungovalo, skoro potřebujete výhled.
A byly chvíle, kdy to nefungovalo vůbec, i když jsem od svého psa jen 30 stop daleko.
Být dobíjecí je určitě příjemná vlastnost a nabití vydrží dobrou chvíli.
Já si ho potřebuju nabíjet jen jednou za dva týdny
Dostaneš to, za co zaplatíš
Příšerný produkt, nesprávně prezentovaný
Koupil jsem si ho jako sledovací zařízení, abych ho mohl používat při plavání, a neměl jsem ani pořádnou šanci ho vyzkoušet
Za prvé, není voděodolný a nedoporučuje se ho používat při plavání podle návodu k použití.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB zástrčku nebo počítač.
Fajn, máme jich kolem sebe spoustu
Když se ho ale snažím dostat do přístavu, aby se nabíjel, tak hned zase vyplouvá.
Nejsem si jistý, jestli je tam něco, co není kompatibilní, nebo je to jen špatně udělané, ale nehodlám sedět a držet své zařízení uvnitř, zatímco se nabíjí.
A konečně, aplikace neustále zobrazuje reklamy, i když je zavřená.
Reklamy vyskakovaly, když jsem posílal SMS, což je velmi znepokojující.
Pak jsem vypnul všechny aktivní aplikace v telefonu, a když jsem šel zkontrolovat čas o 20 minut později, uviděl jsem další reklamu.
Hrozný produkt, asi dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přemíra na popruzích
Tenhle batoh vypadá dobře a podává dobré výkony
Je to skvělá nabídka, zvlášť když to porovnáte s tím, co stojí batohy dnes.
Důvod, proč jsem srazil hvězdičku, je ten, že je tam prostě moc popruhů.
Na tomhle batohu je víc popruhů, než dokážu spočítat.
Skončím odřezáváním a vypalováním těchto přídavných popruhů, protože většina z nich není ve skutečnosti nutná a jenom překáží při otevírání a zavírání batohu.
Kromě toho jsem si z tohohle udělala novou školní tašku na vysokou.
Přímo vzadu v batohu je přihrádka pro můj MacBook Pro a všechny moje knížky se dobře vejdou do dodaných kapes.
Vlajka je taky skvělým zakončením
Můj pes ho ještě nezničil
Měl jsem problémy s hokejovými míči
Můj pes je miluje – je to její oblíbená hračka na aportování a žvýkání – a plavou
Dokud je nerozžvýká na kousky.
Vyzkoušel jsem jich několik, dokonce i verze s „horkým počasím“ – a vydržely o pár minut déle než ostatní.
Dokud se neobjevily tyhle.
Tyhle obstály při zkoušce.
Můj pes není velký, ale je tvrdohlavý ohledně toho, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj u psa.
Palec nahoru od Daisy a ode mě
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme baterii zkontrolovali a zjistili jsme, že do prostoru, kam baterie patří, natekla voda.
Baterie samotné shnily a vytékala z nich černá tekutina.
Při pohledu na design se zdá, že není možné, aby byl kryt baterie vodotěsný, což znamená, že nejen že voda šla do prostoru během koupání, ale část toxického materiálu také vytekla ven.
Prosím, nekupujte tento výrobek.
Jsem šokován, že bylo povoleno jít na trh i přes tak zjevnou vadu.
problémy s přehříváním a potíže při připojování regulátoru
Dávám tomu zatím 3 hvězdičky, nechci zanechat špatnou recenzi pro prodávajícího, pokud si to nezaslouží, ale tento dron se přehřívá hodně.
Nejsem si jistý, jestli bych měl kontaktovat prodávajícího nebo dji tello sami, ale asi zkusím obojí jen proto, abych viděl, co oni říkají.
Líbí se mi, že dron je super hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí víc jako hračka než tento jeden.
Nicméně jediný dron jsem kdy měl problémy s přehříváním a to vlastně bere zábavu z létání. bude předpokládat pro teď, že je výrobní problém, který potřebují řešit co nejdříve, pokud chtějí, aby výrobek byl úspěšný.
Opravdu doufám, že prodejce mi neposlal použití dron, jak jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, jak to dorazí 1 den po nákupu.
Budu aktualizovat datum mé recenze po kontaktování prodejce a dji tello.
O této dárkové tašce mohu říct jen dobré věci
O této sadě dárkových tašek můžu říct jen dobré věci
Všechny své vánoční dárky jsem mohla zabalit do tašek, dárkového obalu a hedvábného papíru.
Výrobek je velmi kvalitní a díky různým velikostem je snazší vybrat ten ideální pro každý dárek!
Vřele ho doporučuji
Prodejce je naprosto milý a pozorný.
Po nákupu mě oslovil, aby se ujistil, že jsem se svým výrobkem spokojená.
5 hvězdiček po celém obvodu!
Fyzika je příšerná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte si tuto hru fyzika je příšerná a já jsem na tuto hru tak naštvaný, protože na každé hře a této hře je asi 40 hackerů.
Nedělají s tím nic. Prostě nechají hackery, ať si dělají, co chtějí a pak vědí, že ta hra je hrozná, ale nedělají s tím vůbec nic a hra pořád dokola aktualizuje jejich postavy. To, co by měli aktualizovat je fyzika, protože je to hrozné, nekupujte tuhle hru. Fyzika je hrozná a mechanika je hrozná. Lidé, kteří tu hru postavili, byli očividně zfetovaní nebo tak, protože je to jedna z nejhorších her, co jsem kdy v životě hrál upřímně bych raději hrál Pixel Games v téhle kravině. Je to jedna z nejhorších her, nekupujte ji.
Ne jako ostatní hry s nájezdníky na hrobky
Od samého začátku mi to nepřipadalo jako ostatní hry s nájezdníky na hrobky
Hra je brutální v tom, že ovládání není chytré v tom, že ví, jakým směrem se snažíte ubírat.
Nechá vás padnout na smrt tím nejpobytečnějším způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tato hra se mi nelíbila
Nemám v plánu ji dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraju hry.
Ergonomický a cenově dostupný, ale nepříliš tolerantní k neustálému používání
Má štíhlejší konstrukční tvar, který lépe padne do ruky, nejsou tu žádné ostré rohy k zachycení a s napájecí šňůrou jako trvalým nástavcem je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští při akčním hraní, působí mnohem slaběji.
2) Směrový joystick a tlačítka ovladače se opotřebovávají velmi rychle.
Jsme velmi těžkopádní a máme tendenci opotřebovávat 2-3 ovladače ročně.
Pro nás tedy každoroční investice do ovladačů znamená, že musíme být vybíraví a obezřetní ohledně toho, co nakupujeme.
Ovladač by si mohl vystačit s odolnějšími pružinami; po pár měsících tlačítka, která jsou používána nejvíce, přestanou reagovat a pravý joystick ztratí své vycentrování, IE- nutí mapové obrazovky přibližovat se a postavy kráčejí vpřed, aniž by se dotkly ovládacích prvků.
Dostaneš to, za co zaplatíš
Byl jsem zklamán, když jsem obdržel tento předmět, protože stříbrná část, která obepíná obličej, vypadala jako vyrobená z nějakého laciného plastu.
Nezklamal mě ani tak fakt, že byl vyroben z plastu, jako spíš fakt, že díky použitému plastu vypadal neuvěřitelně lacině.
Pro mě tenhle detail zničil celý můj vzhled
Také jsem nevěřil, že to vydrží každodenní nošení, takže jsem to nakonec vrátil.
Byl jsem zklamaný, protože to vypadalo, že by to byl dobrý obchod, nebýt toho.
Nicméně, pokud to můžete přehlédnout, pak by to mohlo být pro vás to pravé.
Bylo to dobře zabaleno a dorazilo rychle
Nic jako předchozí telefony Stylo, MASSIVE DISAPPOINTMENT.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je jasné, že se mi Stylos opravdu líbil, vzhledem k tomu, že pokaždé, když vyšel nový, jsem si ho koupil.
Nikdy proto, že jeden měl problémy nebo rozbitý, jen proto, že jsem chtěl zůstat aktualizován a „v obraze“ a to se mi povedlo.
Ze všech těch telefonů jsem ani jednou neměl problémy se samotným telefonem.
Když jsem si koupil Stylo 3 přes Virgin Mobile, věděl jsem, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale mýlil jsem se, když jsem to předpokládal.
Tenhle telefon měl tolik problémů, že mě upřímně šokovalo, jak předchozí Stylos byl tak úžasný.
Nikdy se mi ani nepodařilo úspěšně převést tento telefon na můj Virgin Mobile účet
S tímhle telefonem jsem si pohrával necelý týden.
Hledal jsem informace na internetu a volal jsem na různé telefony, zoufale jsem se snažil dát Stylu 3 výhodu pochybnosti v naději, že jsem to jen já, kdo dělá něco špatně, ale bohužel jsem tím promarnil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Nesnáším skutečnost, že musím dát Stylovi tak hrozné hodnocení a recenzi, ale byl jsem extrémně zklamaný tímto telefonem.
Doufejme, že LG pozvedne jejich hru a může zlepšit budoucí Stylos, pokud existují nějaké, ale tohle byl obrovský BUST.
Na druhou stranu, návrat a vrácení peněz šlo hladce, ale to je asi tak všechno.
