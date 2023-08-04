Rozsekaná verze Jediho Knighta padala, protože volala funkci z konce vtable.
Ukázalo se, že se předpokládalo, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má další metody připíchnuté na konec ve srovnání s IDirect3DViewportem, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože se jedná pouze o vytvoření viewportu pomocí Direct3D objektu, ne Direct3D3 objektu.
Teď jsem si, že v praxi, IDirectXObject2 je typicky řádná nadmnožina IDirectXObject, bez změněných podpisů funkcí, a nové metody pouze přidány na konec.
Ale to není univerzálně pravdivé; pro tyto případy záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže každopádně, protože to tady platí, abych to opravil, musel jsem rozšířit implementaci viewportu tak, aby obsahovala metody IDirect3DViewport3 tak, aby volání na nový bylo platné.
Předpokládejme pro účely argumentace, že věda se alespoň částečně skládá ze seznamů objektivně věcných tvrzení o světě, pravdivých bez ohledu na jakoukoliv teorii, kterou by mohly podpořit.
I kdyby byla pravda, že taková fakta ve vědě existují, je stále možné argumentovat, že vědecká fakta jsou zatížena teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta na základě tohoto čtení, ale volba toho, které experimenty provést, kontroluje, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplývat pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby mohly dopadnout jinak.
Toto je velmi stručný náčrt hodnověrného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, v což nevěřím.
Bude to moje první auto pro projekt.
Vyzvednu si ho o víkendu.
Hledal jsem dobré auto pro prvního chlapa; a opravdu se mi líbí estetika 80. let.
Už na stočených závitech a snížené jízdní výšce.
Trochu jsem pátral, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zážitky?
Vím, že nejsou rychlé ve srovnání
# Venting into the Fediverse time.
Domácí partner a já jsme šli večer do obchodu s alkoholem na pár piv a láhev bubu.
Když jsme se šli odhlásit, pokladní byla celkem zřejmá #trans žena.
Já, v prkenných šortkách a mlátičce manželky, a Domácí partner, celý potetovaný a s novým účesem, který on sám popsal jako „dělající ze mě neonacistu“.
Její tělo okamžitě ztuhlo a v očích se jí objevil výraz strachu.
A pak jsme prostě... zaplatili za naše věci.
A poděkovali jsme.
A já řekl, že její nehty vypadají cool.
Úsměv úlevy na její tváři byl skvělý pocit, ale fakt, že byla vyděšená jako první KURVA SUCKOVÁ A JÁ TO PORADÍM.
Tohle je ta nejhloupější časová osa a nesnáším to dot.com.
Donaldu Trumpovi nic nebrání v tom, aby kandidoval na prezidenta, když je obviněn, poté, co byl usvědčen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se omilostnil, aby se dostal z vězení.
Ale nemůže se omilostnit ze státního vězení.
Chce to guvernéra státu.
Dvěma státy, kterých se to týká, jsou New York a Georgia.
Guvernér posledně jmenovaného Kemp nepochybně Trumpa omilostní, pokud bude usvědčen nebo dokonce obžalován prokurátorkou okresu Fulton Fannie Willisovou.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikace v reálném světě nemůže být redukována na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického signalizačního modelu Lewis (1969), zkoumáme podmínky pro vznik komunikace závislé na kontextu v situovaném scénáři.
Zejména demonstrujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostačující.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextuální rozcestník významů symbolů.
Ukazujeme, že environmentální omezení volby odkazu přijímače může být jednostranně využito odesílatelem, aniž by došlo k rozcestníkovým schopnostem na straně přijímače.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Navrhujeme, že kontextově závislá komunikace je situovaný vícevrstvý jev, zásadně ovlivněný vlastnostmi prostředí, jako je rozložení kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale přesto umožňují téměř dokonalou přesnost komunikace.
O víkendu jsem si moc rád popovídal s Penny a Nicholasem z Ashanti Development a popovídal si o jejich pokroku.
Ashanti Development pracuje se stále rostoucím počtem komunit v regionu Ashanti v Ghaně už téměř 20 let, zapojuje se do komunit a poskytuje podporu s vodou a hygienou, vzděláváním, zdravotní péčí, výsadbou stromů a zemědělstvím.
Komunity získávají znalosti, aby mohly zakotvit a podporovat svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase a podporoval řadu projektů.
Když jsme to o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou zemědělských podniků.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšenou úrodu prostřednictvím řady intervencí od podpory s nákupem vybavení až po školení.
Nicholas pracuje se zemědělci na omezení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je podzimní armyworm, který může ničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Úložiště UPS v mé blízkosti mi nedovolí napsat štítek nebo napsat na krabici.
Musí štítek vytisknout.
Nedovolí mi, abych jim řekl adresu, na kterou jde a kdo ji posílá.
Musím poslat e-mailem nějakou náhodnou adresu, s neformátovanými údaji, aby si úředník mohl přečíst e-mail a zadat ho do svého systému, aby si štítek vytiskl.
A vždy mi za to „pohodlí“ naúčtují 2,25 dolaru.
Druhý den ráno a já se nemůžu přenést přes to, jak Chris Licht včera večer na CNN hanebně předstíral žurnalistiku veřejné služby.
Byla to nehoráznost, jako symbolický antidemokratický festivus lží a křivd 6. ledna, sebedestruktivně pořádaný americkými médii.
ŠAMEFULNÍ AUDIENCE.
Licht SE DOHODL před celým republikánským publikem!
Kdo prověřoval a vybíral jednotlivce?
Tam se bude psát reportáž.
Sledovanost--hledání klamné nezodpovědnosti za to všechno.
To se nesmí opakovat.
Mám suterén plný průvanu, což v podstatě znamená, že se mi tam může uchýlit spousta hlodavců.
Za poslední měsíc se objevila spousta známek, že je hlodavců víc, což bylo výjimečně překvapivé, protože je jaro a já bych si myslel, že se při změně počasí odváží ven.
Nicméně jsem si nechal rozmístit pár obyčejných starých lapačů a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, jak ho myši laskavě lízaly dočista.
Včera v noci jsem konečně měl téhle rutiny plné zuby, vyčistil jsem všechny pasti od arašídového másla a přilepil na ně pistáciovou pastičku.
Fungovalo to.
(fííí, vyzkoušel jsem skoro všechny „humánní“ pasti na trhu s pramalým úspěchem.
Nijak zvlášť se mi nelíbí jejich zabíjení, ale komentáře k etice zabíjení myší přijímat nebudu.)
Už mě nebaví, jak se konzervativní strany a vlády zahalují do značky podporující byznys.
Nejsou, alespoň ne v Albertě.
Jistě, že snižují podnikatelské daně.
Ale také snižují granty a daňové úlevy, které podporují větší podnikatelskou aktivitu.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne kvůli ní.
Zjistil jsem drsným způsobem, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorší zkušeností na internetu.
Popups, auto-play videa, animace, popovers, a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak si vydělají peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud to odhání lidi pryč.
To platí i teď, že goatse.cx je pryč, i když by to byl těsný závod ke dnu mezi goatse a, řekněme, khou.com, kde jsem se snažil podívat na video, které mi poslala Wendy.
Dneska v prvním vlaku se kontrolorka jízdenek podívala na naše jízdenky a řekla „dlouhá cesta!“
„Jo a dneska se vracím,“ řekl jsem.
„Jenom ho vysadím v Glasgow,“ pokusil jsem se vysvětlit a ukázal na svého spolucestujícího.
„Moc se neslyší ,jenom ho vysadím v Glasgow',“ řekl prodavač jízdenek.
Je to věc, kterou jsem taky ještě nikdy neřekl.
Věc, která mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který nikdo doopravdy nechce, kromě fanatiků, kteří v něm jsou.
A jsou to opravdu blázni.
Nemůžeme dovolit, aby nám unesli naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Sežeňte si nějaké nálepky, které jsou proti Trumpovi a polepte je všude.
Křičte na ty, kteří by se přes nás snažili mluvit.
To není normální.
To není v pořádku...
Domů jsme se sousedem dorazili ve stejnou dobu a já ho slyšela, jak přes ulici vykašlává kovalidovou hlenovou bouři.
Tak jsem se vrhla do svého apt, abych se mu vyhnula, ale on mě přesto stihl dohnat, aby si popovídal.
Přísahám, že kovalidovou infekcí jsou lidé zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné chodit na veřejnost nebo spěchat k lidem, když vykašláváte hlenovou bouři.
Opakuji. Není společensky přijatelné šířit vaši kovalidovou hlenovou bouři všude!!!
Writing Wonders 5/11: Směje se tvůj MC víc, nebo pláče?
Abe skrývá svůj zármutek a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví hrubý humor.
Jan ti ublíží dřív, než ti dá najevo, že je zraněná a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že zármutek je stálým životním společníkem.
Po 4000 útrapách se Yl ocitá na místě lásky a má obrovské pocity, že neví, co s tím, takže je tu hodně obojího.
#CNN se musí prostě zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo z té ubohé, umírající televize byl zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který „manažer“ kabelových zpráv volal, aby dal tlustému, prolhanému zločinci tolik vysílacího času?
Vysoká tlaková výše bude převládat až do začátku příštího týdne.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno IR satelity a pozorování na povrchu indikovaly rozšiřující se oblast s nízkou vrstvou a nesourodostí <URL>
Bláznivý student Arnie Cunningham se zamiluje do Christine, rezavého Plymouthu Fury z roku 1958, a stane se posedlý obnovou klasického automobilu její dřívější slávu.
Jak se auto mění, mění se i Arnie, jehož nově nalezená sebedůvěra se za volantem jeho exotické krásy mění v aroganci.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce nabízejících nejlepší služby Salesforce šité na míru vašim firemním potřebám.
Potřebujete pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije jejich odborných znalostí a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám může partner Salesforce pomoci s implementací, úpravou, integrací a průběžnou podporou, která umožní vašemu podniku prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších částí o tom, jak se moji sousedé obracejí proti mně, je přemýšlení o tom, kolik úsilí stojí být nepřátelský.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To stojí úsilí.
Prásknout mi dveřmi před nosem stojí úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A pořád nemám ani ponětí, co jsem mohl udělat, abych si tohle zasloužil.
Měli klíče od mého bytu přes 6 let.
Ta loď je nepřístupná.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě irelevantní.
Můžete ji zabít, pokud budete moci.
Ale na palubě té lodi často létá jiný jedinec.
Kdyby zemřel... následky by byly... značné.
Hodně si stěžuji na tátifikaci.
Zde je (o něco delší než) toot-length rychlokurz toho, co mám na mysli pod pojmem tátifikace:
Není to můj termín, je to termín používaný k popisu toho, když je vyprávěcí nebo hrací mechanik postaven kolem ústředního protagonisty (obvykle staršího, obvykle mužského) hlídajícího nebo hlídajícího jiného člověka (často mladšího).
The Last of Us je snadným a kanonickým příkladem tátifikace.
Joel využívá své schopnosti a schopnosti provádět (extrémní) násilné činy ke splnění úkolu, který je kódován jako „starostlivý“.
Tádeifikace obvykle předpokládá, že řešením situace, kdy se rodičovská postava musí starat o dítě nebo jeho zástupce chránit, je zdrcující síla a použití této síly k vynucení velmi specificky tvarované mocenské dynamiky.
Tádeifikace nahlodává možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoliv agenturu, kterou dítě má.
V tomto směru je tati-ifikace zástupem mnoha neoliberálních ideálů; zejména myšlenek jako bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je stručný přehled, jak využít naše webové stránky.
- Odesíláme upozornění, když je letenka v prodeji.
- Poskytujeme odkazy, kde si můžete zarezervovat letenku.
- Neprodáváme letenky, ani neúčtujeme předplatné.
- Více podrobností je v úplném příspěvku na blogu.
- Udržujeme seznam příkladů termínů rezervací pro každý obchod, který zveřejníme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Nepředstavitelný strach, teror a vysídlení jim však zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezident von der Leyen setkal v Kyjevě s první dámou Olenou Zelenskou, aby s ní projednal, jak podpořit její úsilí o poskytnutí pomoci v oblasti duševního zdraví zranitelným dětem.
Už jsme jim nabídli pomoc v oblasti duševního zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže tuto cestu zvládnout.
Parta zářivé nové dobroty v #dart
Postupem času se šipka stala mým zájemcem o rychlé UI.
#flutter je radost s ním pracovat a mají #mobx pro snadnou správu obchodu.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, že flutter je opravdu na nic, pokud jde o chování, jako by se chovala dobrá nativní aplikace (kdekoliv, opravdu. I flutter web target je na nic).
Ale umožňuje se pohybovat rychle a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými špičkami.
Jsou průměrně vysocí, mají průměrnou postavu a jsou svalnatí.
Ocas mají extrémně hustý.
Vlasy malinové, krátké a kudrnaté.
Oči mají hruškovité a nosí šarlatové brýle cateye.
Jejich nejzajímavějším rysem jsou dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Schopnost skákat opravdu vysoko, trhat normální lidi na kusy, používat strašidelné magické síly a doplňovat zdraví hodováním na svých nepřátelích – to by mělo být základem všech PC her, abych byl upřímný.
Navzdory nejlepším snahám Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze udělat z nich špatné – všichni ...
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mámě líbila puzzle hra, kterou jsem udělal před lety a většinu tajemství našla sama, takže nebyla jen máma, když řekla, že se jí líbí.
Takže se jí možná bude líbit I moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a/nebo Hokkienu, ani jedno z toho vůbec neznám.
Asi budu muset zjistit, jestli je Bing nebo Google lepší v překládání špinavých gay sexuálních hříček.
Už nějakou dobu si pohrávám s touto myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od „běžného“ zdraví.
Proč?
Protože se to děje v mysli a zdá se to být méně hmatatelné než fyzické zdraví.
Po pravdě řečeno, zdraví vaší mysli, vašeho mozku, je stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce uznáván TERFy a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými vnímáno jako méně „reálné“ než fyzické zdraví, tak nějak cítím, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více se mi tvrzení „Moje pohlaví je mužské, moje pohlaví je ženské“ zdá zjednodušené a nepřesné.
Skoro to vypadá jako postoupení části argumentu TERFům.
Cítím, že být trans znamená být „biologicky nebinární“.
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení „nebinární“ je třeba rozšířit z pouhého genderového výrazu, který se má používat při odkazování na sex.
Byl jsem, s přestávkami, poslouchat díla @iotar
V tomto záhadném kolektivu je spousta dobrých věcí, které se nahromadily.
Jako krauty nálady a další světácká pop music a radiofonická dílna a všechno možné.
Velmi stojí za to si to vyzkoušet.
Také FWIW Rozhraní archive.org se mi líbí mnohem víc než desktopové #bandcamp \- Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrát s Flutter.
Nerad bych zakládal svůj byznys na technologiích od Googlu, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými podněty k vytvoření přesvědčivého zážitku napříč platformami a je to vidět.
(A také: Web je nyní bohužel z velké části věcí Googlu)
Také se prosím zdržte toho, abyste mi říkali, že google/flutter aplikace jsou na iOS a macOS k ničemu.
Cross platforma je těžká, pokud to chcete dělat dobře.
To vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci do Leasey.
Na světlo vyšlo několik velmi malých potíží.
Nic, co by rozeznělo poplašné zvony, ale přesto jsou adresovány.
Příští týden bude vytvořena malá aktualizace, která je opraví.
Většina včerejška byla věnována instalaci nové aktualizace pro některé zákazníky a každý, kdo tuto pomoc potřebuje, by ji už měl dostat.
Přeji hezký den!
Přiznání k technice: Grafana & Prometheus mi hlava nebere, alespoň z hlediska metriky serveru/aplikace a monitoringu.
Nevím přesně, proč na to můj mozek nemůže přijít; mohlo by to být tím, že nástroje jsou prostě tak široké a vágní, že můj mozek prostě ztvrdne kvůli 'příliš mnoha možnostem'.
Chci vyrábět přístrojové desky.
Grafana vypadá hezky.
Mozek nepracuje.
Takže když se blíží nový raid tier #FFXIV, dlouho jsem si říkal „člověče, rád bych zkusil pořádný raiding, ale Party Finder zní jako bordel, a nikdy nenajdu statickou elektřinu, která by mě dostala.“
Tak jsem si řekl, kašlu na to!
Udělám si vlastní statickou elektřinu!
Plno lidí, kteří jsou příliš nedočkaví, aby se pokusili připojit k raid static, bez očekávání, že budou vůbec dobří!
To... to by asi v žádném případě nefungovalo!
...A tak jsem zjistil, že musím vyřešit rozpis raid group.
V mládí jsem byl nenasytným čtenářem.
Pak mi život rozdrtil duši a ztratil jsem veškerou vášeň pro beletrii a skvělé vyprávění příběhů.
Ale po ~desetiletích~, kdy jsem skoro nic nečetl (s výjimkou funkčních prací nesouvisejících s beletrií a příležitostné svépomocné knihy) jsem si dal za cíl přečíst 23 knih v roce 2023.
Teď jsem na knize # 31 a je teprve květen.
Jsem ZPĚT, zlato!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou přišlo pár lidí mezi čtyřma očima a řekli mi: „Podívejte, kvůli vaší práci vám poskytnu takovou sumu peněz.“
Chci vidět ty společnosti, které mezitransakcemi vysvětlují svým zákazníkům, jak si stanovují procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud bude mít Spotify dobrý kvartál, tak bude.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Znovu.
Tihle lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pro-diktátorské pravicové křídlo... to je to nebezpečí.
Deportovat bílé rasisty.
Jsem tak unavený z titulků, které tvrdí, že „Práce na dálku je mrtvá.“ nebo že „Práce na dálku byl neúspěšný experiment.“
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele jedné velké společnosti.
Je to všechno klikací návnada, ale dělá mi to starosti s vedoucími pracovníky a manažery, kteří tyto články čtou.
Práce na dálku existovala před rokem 2020.
Stále budou existovat pracovní místa, která lze v dohledné budoucnosti vykonávat na dálku.
Práce na dálku je umožnění.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístup každému, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim bere čas od jejich dne a jejich rodin.
Ignorovat tyto skutečnosti je špatné.
Přestaňte zobecňovat a pokuste se pochopit, jak vaši zaměstnanci vlastně práci dělají.
#WFH #business #neurodiversity
Nejde jen o konzervativce versus pokrokáře, řekl na semináři více než stovky přívrženců v Grande Prairie.
„Tohle je válka mezi pro-lidmi a proti-lidmi,“ řekl.
Parker se zmínil o potratech a o popudu moderních městských žen odkládat děti kvůli kariéře.
Tvrdí také, že NDP a pokrokáři chtějí vylidňovat společnost kvůli životnímu prostředí.
„Jste uhlík, který se snaží redukovat.“
Tak jako od začátku u všech mých narozenin v minulosti, vždy jsem měla ty drsné.
Kdykoliv se vynořil květen, děsila jsem se zkoušet slavit svůj bday.
Vždy se něco stalo, pokazilo se to, nebo to skončilo stresem a depresí.
Bojovala jsem celé roky, abych se dostala z tohoto myšlení a měla lepší bdays.
Trvalo roky změnit svůj život a tvrdě pracovat, ale nakonec...
Začínám se usmívat a užívat si svůj bday bez starostí.
A dnešek se již stává velkým dnem!
Do zimy v této malé části Velkého jižního světa zbývá 30 dní.
Ale já se nenechám oklamat!
Tohle je začátek.
Padá déšť a dokud/dokud není zmrzlý, tak v něm tancovat nebudete!
Je krásný den na objednání zmrzliny.
Byla to jedna psí noc a ten pejsek nevstal z postele ani na „Psí snídani – Psí snídani!“
Zazipuju si podšívku do cyklistické bundy – jen pro případ, že bych ji potřeboval mít uvnitř.
Znáte performant způsob, jak webová komponenta reaguje na přidání/odebrání z dokumentu?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Většinou je to sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí připojenýCallback).
V současné době používáme hack MutationObserver.
Pro výkon nesledujeme celý dokument.
Vytvoříme oddělený dočasný rodič, nainstalujeme tam MO a sledujeme, jak se odděluje (takto připojený jinde).
Krysák Casper je v dnešní době absolutní jednotka.
Myslím, že moje nová práce mu prospěla – dva volné toulky denně, zatímco já pracuji, v celkem předvídatelných časech.
Konečně jsem si pořídila dobrou fotku, abych si mohla být jistá, že není tlustý.
(U krys může příliš vysoký tělesný tuk škodit jejich zdraví.)
Není.
Je prostě naprosto zničený z toho, jak dvakrát denně řádí v mé kanceláři.
Nemám váhu, abych ho zvážila, ale má pocit, že má hodně přes půl kila.
Jsem tak šťastná, když vidím, jak se mu daří.
Dnešní průběžná zpráva Aerostrike:
1) Drobné úpravy mapového rozvržení Hel's Fighters.
Navíc menu mapy je plně funkční!
2) Systém měnové odměny byl připojen.
Zítra bude testován s různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal tunu a cítím se mnohem lépe ohledně polních položek.
Všechny lístky, kapusta, mangold se transplantují.
Plány na zasazení do salátu v Pennu na 6řádkovém vzoru a uvidíme, jak se to srovná s vysíláním osetých záhonů.
Objevují se jarní hrášky v Gilpinu, takže je třeba nastavit trellise.
Také je třeba tam nasadit salátovou řadu, aby se do obou začlenila sekaná zelenina mají vyškolenou posádku na zavlažování, přípravu záhonů a přesazování, což je 90% nesklízených dovednostních položek
Je rok 2023 a já stále vidím lidi s iPhony, jak se aktivně vyhýbají používání Apple Maps.
Apple Maps je s iOS výchozí, a přesto by si lidé do svých iPhonů Google Maps stahovali a instalovali.
Netuším proč.
Zvědavě jsem si nechával otevřenou mysl, abych porovnal, jak si Google Maps a Apple Maps stojí v porovnání, na mém testovacím iPhone zařízení (můj denní ovladač je zařízení s Androidem, takže iPhone používám jen zřídka).
Zkušenost s dodržováním pokynů byla na Apple Maps daleko lepší než na Google Maps.
Apple Maps vítězí.
Tak proč lidé skáčou přes obruče navíc, aby si nainstalovali Google Maps?
Netuším.
Mohlo to být tím, že se Google Maps dostaly na trh jako první?
Byla to katastrofa s Apple Maps 2012?
Mohlo to být tím, že Google Search je integrován s Google Maps?
Netuším.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch toho, aby se nevypouštěly odpadky koncovým uživatelům, a Apple to s jejich Apple Maps královsky posral, když to v roce 2012 vyšlo.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z ní dělá dobrého skladníka bohatství na tak dlouho, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Dům sám o sobě klesá na hodnotě, protože ztrácí svůj stav a je třeba ho vyměnit.
Hodně lidí si myslí, že jim doslova patří země, když si koupí kus.
To není ten případ.
V Číně si můžete jen pronajmout půdu.
Nejsou tak hloupí, aby prodali navždy.
Vláda může změnit tuto politiku, kdykoliv se jí zachce.
Ta půda je dočasná.
Zdá se nepředstavitelné, že by jednoho dne mohla být půda odebrána, když sledujete australské a americké mediální kanály, ale to proto, že bohatí jsou tam celý den, aby zajistili, že vaše mysl bude myslet určitým způsobem.
Ta půda je velmi snadno a rychle odebrána vládou jednoho dne, pokud to bude chtít udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si ppl může udržet půdu na úkor ostatních.
Musí být odebrána jednoho dne.
Proto Číňané povolují jen pronájmy.
Už jim došla půda.
Na úspěch, realizaci snů, přátelství, na prosté, ale pravdivé!!
Všem investorům tam venku, připiji na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si v životě těch prostých, ale pravdivých věcí, které nám přinášejí radost a naplnění.
#Robecofirm#geologist #podnikání #udržitelnost #úspěch #přátelství #přípitek #sny
Často se divím lidské schopnosti být *tak* na sebe sám, zatímco jsem zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a vinou ve světě, kde je „úspěch“ tak často propůjčován lidem zodpovědným za ty nejhanebnější činy...
Všichni jsme taková zapeklitá zvířátka.
Ale mírnit zoufalství nad naší zapeklitostí je klíčové – protože nám to dává větší prostor vypořádat se s ruinami všude kolem.
Takže se snažte nezapomínat, co?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: „Na rychlosti psaní nezáleží!“
nebo „Modální editory jsou dnes k ničemu“ :morty:
Me extrahování funkčnosti mých #Axum projektů do sdílených knihoven: „Hold my keyboard“ :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup pro sdílení, ale zatím se mi líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Příkaz k tomuto týdnu ve Zjevení zní Zůstaň vzhůru celou noc.
Už pár dní si pohrávám s tímto malým kouskem na hlavě.
Rozhodně je to víc romantika než špína.
Možná jsem četla mnoho romancí s nemožnými 'meet cutes' a tohle je výsledek, ale líbí se mi to.
Taky jednou určitě udělám ten mílový orgasmus, možná ne se str.
Nesouhlasím s tím, že je těžké nastavit #Mastodon.
Běžné, opravdu to není tak těžké.
Ale je těžší najít lidi, které byste sledovali a vytvořili si časovou osu.
Přál bych si, aby existovalo nějaké doporučení „koho se držet“.
Ale kromě toho to není těžké – pokud používáte aplikaci třetí strany jako je Elk a/nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá to dobře a necítíte se dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali a pravděpodobně potřebujete dobrou aplikaci na vylepšení #UX.
Nevím, jestli je prevence možná, ale stojí za to to zkusit.
Čtyři kroky, které jsem nastínil, jsou předmětem diskuze, v každém je určitý pokrok:
Popis: názvy pro incidenty chování lidských algoritmů, které počítají s algoritmy a lidmi.
Vysvětlení: účet pro obě strany vzájemného vlivu
Prognóza: předvídání škod dříve, než k nim dojde (i když jen o minuty)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v určitých mezích důvěry
Nedíval jsem se na radnici CNN, ale vypadá to, že Trump říkal přesně ty samé věci, které říká pokaždé, když otevře ústa nebo stiskne v telefonu Send.
I kdyby je nestihl říct během radnice, stejně je každý v Americe uslyší, a to opakovaně, od teď až do listopadu 2024.
To pořád není důvod, proč mu dát jiné místo, ale škoda se zveličuje.
Primárky vyhraje.
Nemůžeme ho poslat pryč.
Je tady a řekne tyhle věci, ať se děje, co se děje.
Přihlásil jsem se do čekací listiny „AI Test Kitchen“ od Googlu a dostal jsem se tam ve stejný den.
V tuto chvíli je to velmi zdrcující.
Demo „MusicLM“ je mírně zajímavé.
Můžete se zeptat na konkrétní skladbu jako „jazz s trumpetovým sólem v 5/4 tempu“ a po pár vteřinách vám vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... ta hudba prostě... není dobrá.
Házet všechno, co máte, přes plot v reakci na GPT, to není ono.
Zkuste víc Google.
Je divné dělat vzpírání, ale zároveň nemít ani ponětí, co je váš one-rep-max, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám v ložnici bez zaměřovače nebo dokonce bez držáku na činky.
Jen já a činka s hromadou činek.
Lis na lavičku si dávám na postel.
Pokud se pokusím přijít na to, že můj one-rep max je, že možná nevlastním dost činek na to, abych se dostal na maximum, nebo naopak by mě to mohlo vážně zranit/zabít.
Každopádně, zátěž dnes stoupá.
Pořád je to dobrý pocit.
Přísahám, že burrata před pěti lety neexistovala
Tohle je můj osobní efekt Mandely.
Nikdy jsem to v kuchařce neviděla.
Nikdy jsem to neviděla v luxusním obchodě nebo v italském lahůdkářství.
Nikdy jsem neviděla, že by to dělala něčí máma nebo že by mi to někdo strčil na večírku nebo že by se to objevilo ve spojení s něčími eskapádami při výrobě omáček nebo pečení
Prostě se to jednoho dne objevilo a najednou to bylo k dostání všude.
Vstoupila jsem do dimenze burraty.
Drakeovi stárnoucí iPad vypovídá službu, takže je na trhu s novým tabletem.
Vzhledem k tomu, že jsme se zde radikalizovali, zdráháme se koupit si nový stroj FAANG*.
Má někdo z vás tablet s Linuxem, který miluje?
Ten by byl hlavně pro prohlížení webu, příležitostný e-mail a nějaké hry.
V 1998-06 Gamefan, v souvislosti s dlouhým vývojem první Unreal hry, Jason Schrieber komentoval,
„Dobrá hra je jen pozdě, dokud se loď.
Špatná hra je špatná navždy.“
Takže to byl Epic, který vznikl toto?
Můžeme pokračovat.
Starší číslo GamePro 1997-11 má citát s mnohem více nejednoznačností,
„Nebo, jak průmysl hláška říká: Pozdní hra je jen pozdě, dokud se loď.
Špatná hra je špatná pro zbytek svého života.“
Je to tak pomíjivé pak?
Pouze „hláška“ bez jasného původce?
Smoky, moje desetiměsíční koťátko Domestic Blue, si hraje s červeným gumovým utěšovacím přístrojem Apple Pencil, který koupil od Amazonu a před několika měsíci utekl.
Hrdě ho nosí v puse po celém domě a já se musím v duchu smát.
Pokaždé, když ho vidím, jak to dělá.
Udělali jsme teď kompletní okružní jízdu novým vlakem ICNG.
Moc se mi to líbí.
Hlavně ty vagóny s většími okny.
Jsou tam oblasti, které by potřebovaly trochu vyleštit.
Jmenovitě nedostatek popelnic a nedostatek cedulí, které by vysvětlovaly význam světelných barev.
Opravte ty drobné problémy a můžeme jich pak mít víc, prosím?
Nebudu smutný, až uvidím konec zásob ICM nebo DDZ.
Pro každého zákazníka platí jedno pravidlo, protože se snažíme zajistit, aby se každý, kdo se postaví do fronty, mohl dostat k tabuli.
Můžete si koupit JEDNU z tabulí uvedených výše, ne jednu od každé.
Na Picos ani jiné zboží neplatí žádná omezení při nákupu.
Včera jsem se skvěle bavil se svým přítelem a bývalým rabínským kolegou.
Navštívili jsme se pár hodin na mé verandě.
Taková přátelství přesahují rozdíly.
Všichni máme co vyprávět.
Pán ti žehnej a ochraňuj tě!
A bažina se zelená.
Docela se mi líbí akkoma software a doménové jméno, které jsem dostal pro mou instanci.
Ale mám pocit, že jsem nějak začal tuto instanci na špatnou nohu, tak říkajíc.
A nikdy jsem se tam pohodlně.
Ještě se tu chvíli zdržím a přemýšlím o tom, jestli bych měl vůbec migrovat.
#FalconGameBooks
Osmiocí Repnidé jako by sledovali, jak dosedáte s letounem na rudou půdu, ale nehýbají se směrem k vám, ve skutečnosti jsou nehybní, když vylezete z letounu a pomalu kráčíte směrem k nim.
Země pod vašima nohama se začne chvět a pak se začne otřásat, jako při zemětřesení a vy ztratíte půdu pod nohama, i když Repnidé vypadají, že jsou nedotčeni.
Skála pod vámi náhle povolí.
Repnidé se prokopali pod povrch a vy padáte do vařící se masy stovek těl Repnidů v jeskyni dole.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jste byli první lidský budoucí cestovatel.
Přistanete s letounem nosem vzhůru na boku hromady strusky a vylezete ven.
Osmiocí Repnidé jako by se dívali, ale nehýbají se směrem k vám, ve skutečnosti jsou nehybní, když jdete pomalu směrem k nim.
Zastavíte se ještě na hromadě rozpadlé skály a půdy a mluvíte k nim se slovy: 'Přicházím v míru, jako přítel.'
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladač nezachytí žádnou odpověď.
Rozhodnete se použít své Psychické Vědomí, abyste se s nimi mentálně spojili.
Je těžké pochopit smysl jejich myšlenek; jsou děsivě cizí a vaše mysl před kontaktem couvne.
Rozhodnete se, že navázat kontakt znovu by bylo nebezpečné, a vraťte se ke svému letounu, ale tento zážitek vám vyčistil mysl, která byla zmatená od chvíle, kdy jste skočili do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je docela snadné načrtnout kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[cont'd]
#dnes mám kávu, sluníčko a ticho!
Začala jsem nosit nový šál.
V tuto chvíli si tím nejsem jistá.
Našla jsem nestejně spředenou stříbřitě šedou přízi, která je z větší části jemně spředená s hrudkami.
Plánuji ji smíchat s jemnou fialovo-šeříkovou pestrou bavlnou.
Nejsem si však jistá, zda mám dost fialové.
Používám háček H s podobným dvojitým háčkovaným vzorem jako dříve.
První spoj jsem udělala včera večer, tak uvidíme.
Přeji všem šťastný čtvrtek!
Nicméně nesnáším hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Doslova jsem to zkusil a upustil od KAŽDÉHO JEDNOTLIVÉHO.
A ještě asi před dvěma lety jsem o tom neměl ani ponětí, dokud jsem si nezkontroloval přepisy.
Nenávist z hodin literatury je ještě horší: miluju čtení.
Většinu klasik jsem četl před osmnáctinou – i když to je spíš odraz života v prdeli nikde, v zoufalství jsem četl i Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a báječný a jsem tam šťastná, ale musím být někde jinde, abych se během dne dostatečně zchladila a mohla číst beletrii bez pocitu viny.
Je to jako bych byla na prázdninách, a proto dělám to, co člověk dělá o prázdninách.
A to i přesto, že jsem tu poslední dvě noci nespala tak dobře jako doma, a trochu jsem se #MECFS odreagovala z toho, že jsem prostě v cizím prostředí, kde jsem méně schopná se krotit a musím si pamatovat, kde co je.
A to i přesto, že mám stále svůj seznam úkolů a také si organizuji svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které miluji na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi to, ale bude to schopné přilákat publikum těch správných hráčů?
Rozkvete komunita kolem uživatelem vytvořené obsahové části hry?
(Opravdu doufám, že ano.)
Příběh hry, nápady a otázky, které vzbuzuje, působí aktuálně.
Doufám, že to půjde dobře.
Je ThinkPad den!!
Přišel jsem domů o polední pauze, abych viděl tohle sezení venku uwu.
Přál bych si, abych to mohl vzít zpátky do práce se mnou a nastavit další.
Ale to bude muset počkat do večera.
Tak jsem se konečně podívala na #Heartstopper
Bylo to až moc roztomilé?
Rozhodně
Mluví některá z těchto postav s lidmi?
Ani vzdáleně
Ale líbilo se mi to?
Rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno vystudovaný umělec dnes špatně přijal nějakou kritiku.
Částečně proto, že by se špatně učil.
Ale je důležité nevymlouvat se na problémy a prostě je napravit, zvlášť při produkci, když vaše hlavní role potřebuje změnu.
Zvlášť při soutěži.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tam proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost problém napravit, nebo najít řešení.
Takže zatímco kompostování a posouvání květů jsou nádhernou připomínkou, jak vzhlédnout a uvědomit si život mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledovat, jak semínka zasejí a kultivují (a ne náhodně rozptylují) dobří peepové.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu lístek podstrčila, když se míjeli na stezce, těsně před psí hlídkou.
Byla na cestě ke zdi, on přicházel ze služby.
Ohlédl se za sebe, aby se podíval, jak odchází, a aby se ujistil, že je nikdo neviděl.
Neohlédla se.
Počkal, až bude ve tmě palandy, pak lístek vytáhl a přečetl si ho v paprsku světla, který pronikal zatemňujícími závěsy.
Jedno slovo s tiskacími písmeny.
Dlouho na něj zíral a snažil se zachovat klid:
V poslední době jsem potkal pár skvělých nových #Mastodon kamarádů a chci tento trend udržet.
Při volání do #Fediverse se cítím jako velryba zpívající rozlehlým oceánem!
Chcete se připojit k mému „podu“?
Zvláště bych se rád spojil s více.
Každý, komu kvůli CNN hoří vlasy, může děkovat Stephenu Colbertovi za ostrou pravotočivou zatáčku.
Pomohl udělat z Chrise Lichta národní problém.
I když se nám někteří lidé mohou líbit, pokud jen poskytují fašistům kariéru v nižší lize, asi by ji měli nosit.
Bylo to poprvé (ale nebude to naposledy), co Kaveesha Dilhariová vstřelila 20+ runs a dala 2+ wickets ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilném protestu před britským hotelem pro uprchlíky
Incident se stal poté, co se zvýšil počet uprchlíků a žadatelů o azyl, kteří na lodích přepluli kanál La Manche do Spojeného království.
Policie zatkla 15 lidí po protiuprchlické demonstraci před hotelem, v němž byli ubytováni žadatelé o azyl, která se u anglického města Liverpool zvrhla v násilnosti.
Policejní oddělení v Merseyside uvedlo, že jeden policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer v Knowsley.
Policejní síly uvedly, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zadržení lidé, kteří byli ve věku od 13 do 54 let, byli zadrženi „po násilných nepokojích“.
Policejní komisařka v Merseyside Emily Spurrellová řekla Radio City: „Bylo to neuvěřitelně nebezpečné a mezi policisty došlo k několika zraněním.“
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který Knowsleyho zastupuje v britském parlamentu, řekl, že násilí v pátek večer neodráželo komunitu.
„Lidé v Knowsley nejsou bigotní a jsou vstřícní k lidem, kteří utíkají z některých z nejnebezpečnějších míst na světě a hledají bezpečné místo,“ řekl.
„Ti, kteří dnes večer na tomto protestu demonstrují proti uprchlíkům, nepředstavují tuto komunitu.“
Protest se konal za zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů přeplouvá kanál La Manche v malých člunech.
Touto cestou se v roce 2022 do Spojeného království dostalo více než 45 000 lidí a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se kvůli politickým zmatkům a byrokratickým průtahům zpomalil na minimum, takže mnoho žadatelů o azyl uvízlo v hotelích nebo jiných dočasných ubytovacích zařízeních.
Přechody kanálu La Manche se staly politickým tématem, kdy konzervativní vláda slibuje „zastavení člunů“ a prosazuje plán poslat takové žadatele o azyl do Rwandy.
Odpůrci obvinili vládu, že démonizuje zoufalé lidi prchající před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v úvodním zápase sezóny v Brandywellu
Derry záložník Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City vyšlo z Prezidentského poháru vítězně, když porazilo 2:0 Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops se ve druhém poločase snažili snížit stav, ale Ruaidhri Higginsovi svěřenci stáli pevně za vítězstvím.
Derry cestuje do St. Patrick's Athletic na úvodní zápas ligy příští pátek.
Patchingův boční volej postrčil Derry do vedení po 23 minutách – střední záložník otevřel skóre, když Foylesider loni v únoru vybojoval nad případnými šampiony výhry 2:1.
Hoops pak vyhráli Premier Division o 13 bodů, ale Duffy brzy dostal City dál do vedení dalekonosným úsilím, které se dokázalo vykroutit pod brankářem Leonem Pohlsem do sítě.
V minulé sezoně byli druzí dva góly k dobru v rozehrávce.
Graham Burke byl nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byli pohodlnými vítězi týden před jejich cestou za národní slávou.
Šéf města Ruaidhri Higgins chválil svůj tým po tom, co řekl, že to byl „nejtěžší týden mého života“ po smrti jeho bratra Kevina.
„Je to kopanec do zubů a čekají nás těžké týdny, ale budeme s tím pokračovat v jeho paměti,“ řekl Higgins.
„Porazit Shamrock Rovers a zaslouženě tak dobrým výkonem je opravdu potěšující.“
DHS si najala advokátní kancelář, aby se postarala o případné řízení o odvolání Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí advokátní kancelář Debevoise & Plimpton, aby pomohla s možným řízením o odvolání ministra Alejandra Mayorkase, protože ten potenciálně čelí obvinění ze strany republikánů ve Sněmovně reprezentantů ohledně jeho nakládání s jižní hranicí.
„Ministerstvo vnitřní bezpečnosti si najalo externího poradce, aby pomohlo zajistit, že zásadní poslání ministerstva nebude přerušeno bezprecedentními, neoprávněnými a stranickými snahami o odvolání některých členů Kongresu, kteří již podnikli kroky k zahájení řízení,“ uvedla v pátečním prohlášení mluvčí DHS.
„DHS bude nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic a zároveň bude vhodně reagovat na více než 70 výborů a podvýborů Kongresu, které mají nad DHS dohled.“
Úředník DHS sdělí CBS News, že ministerstvo najalo firmu na smluvně zadanou práci na dobu trvání kongresového vyšetřování.
Debevoise byla vybrána kvůli svým odborným znalostem v oblasti impeachmentu a zkušenostem obou stran při spolupráci s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP via Getty Images
Ministerstvo spravedlnosti nedávno upozornilo, že smlouva s Debevoise je způsobilá jako přiměřený výdaj pro DHS.
DHS se snaží zajistit, aby její poslání nebylo podkopáváno partajními útoky a aby řízení proti Mayorkasovi vedli lidé s patřičnými odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na dotaz ohledně vyšetřování impeachmentu minulý čtvrtek řekl novinářům: „Budeme spolupracovat s tímto Kongresem, stejně jako jsme spolupracovali s minulým Kongresem. Myslím, že je to naše odpovědnost.“
Připustil, že „bude nějakou dobu trvat“, než vyhovíme vyšetřování Sněmovny.
„Tuto dobu strávím stejně jako ostatní a také neohrozíme čas, který strávíme plněním našeho poslání.“
Vysoký představitel DHS potvrdil, že Mayorkas se dosud nesešel se svým novým externím právním zástupcem.
Pouze jeden člen kabinetu byl kdy odvolán, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulysses S. Granta, obviněn z přijímání úplatků, ale nakonec byl Senátem zproštěn viny.
Trending News
Díky za přečtení CBS NEWS.
Čtyři teenageři obviněni z útoku na čtrnáctiletou dívku, která zemřela na sebevraždu po bití videa bylo zveřejněno na internetu
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ
Táta říká, že si dcera vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem na čtrnáctiletou dívku, která si později vzala život poté, co bylo video s incidentem zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z těžkého ublížení na zdraví, dva mladiství jsou obviněni ze spiknutí za účelem spáchání těžkého ublížení na zdraví a jeden mladistvý je obviněn z obtěžování, řekl v e-mailu CBS News prokurátor okresu Ocean Bradley D. Billhimer.
Čtrnáctiletá Adriana Kuchová byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na střední škole Central Regional High School.
Video ukazovalo dívky, jak po teenagerce házejí skleničku, pak ji kopou a táhnou po školních chodbách.
Strčily Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžovém tričku Kuchovou opakovaně udeřila.
Jiná dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli útok rozehnat, přičemž jeden dospělý děti od sebe odtrhl.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: „To je to, co dostanete.“
„Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali,“ řekl ve čtvrtek CBS New York její otec Michael Kuch a dodal, že je naštvaný a chce, aby všichni viděli video a to, co mladiství udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojující video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že měla být okamžitě zavolána policie, protože studenti, se kterými podle něj měla jeho dcera problémy, jí rozbili obličej dvacetiuncovou lahví.
„Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejňovaly videa ze školy,“ řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
„Vždy řešíme každý problém šikany a v den incidentu byly čtyři studentky suspendovány,“ řekl CBS New York doktor Triantafillos Parlapanides, ředitel škol.
Vedení školy sdělilo CBS New York, že rodinu informovalo a smrt Adriany označilo za hroznou.
Každému teenagerovi a jejich opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních stání, řekl prokurátor CBS News.
Studenti ve škole uspořádali ve středu vycházku na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v citovém strádání nebo v sebevražedné krizi, můžete se spojit s 988 Suicide & Crisis Lifeline telefonicky nebo textovou zprávou 988.
Můžete si také popovídat s 988 Suicide & Crisis Lifeline zde.
Více informací o zdrojích a podpoře péče o duševní zdraví získáte na lince HelpLine Národní aliance pro duševní nemoci (NAMI) od pondělí do pátku od 10 do 22 hodin.
ET, na adrese 1-800-950-NAMI (6264) nebo na e-mailu info@nami.org.
Mluvila jsem s 30 zdravotníky, wellness profesionály o vyhýbání se vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v našich zaměstnáních.
To může být extrémně obtížné pro ty, kteří pracují ve zdravotnictví, a proto jsem položila 30 zdravotníkům a wellness profesionálům stejnou otázku: „Jak zvládáte svou energii a nevyhoříte ve své profesi?“
Jejich kariéra se pohybuje od lékařů infekčních chorob přes psychology až po učitele všímavosti – a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vynikala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Budovat silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají smrtelné nemoci, Eufrosina Youngová děkuje svému silnému podpůrnému systému za schopnost udržet si energii.
Youngová je certifikovaná neuroložka a specialistka na ALS na oddělení neurologie Upstate University Hospital a říká, že se tam „mobilizují jako armáda lidí“.
Na amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo se usilovně snaží vyvinout léčbu a zajistit lepší možnosti pro své pacienty, udržuje Youngovou i v těch nejtěžších dnech.
„Neseme tíhu světa, ale jsme součástí světa lidí, kteří se o tuto práci zasazují,“ říká.
2.Odpočívejte, když potřebujete
Pracovat ve dvou zaměstnáních jako spánkový výzkumník a inženýr algoritmů, to vše při péči o nové dítě, by Raphaela Vallata rozhodně dovedlo k vyhoření, kdyby si neodpočinul, říká.
„Mám pocit, že když se chystám vyhořet, v podstatě každý úkol působí jako hora, kterou potřebujete zdolat, a připadá si super naléhavý a důležitý,“ říká Vallatová.
V těchto chvílích „si opravdu potřebujete vzít nějaký čas volno a uvědomit si, že tyto úkoly mohou počkat.“
Vallat si obvykle ve svém dni najde chvíle, kdy se může zastavit a strávit čas v přírodě, aby se před návratem do práce uzemnil.
3.Buďte zapálení pro to, co děláte, a pamatujte na svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně po sedm dní v týdnu.
Být v první linii během pandemie jí zabralo téměř všechen čas, ale vyhoření se vyhnula tím, že si připomněla, proč je její práce důležitá.
„Nemyslím si, že práce působí jako práce, když máte pocit, že na ni máte vliv,“ říká Gounder.
„Pokud pracujete šíleně dlouho a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu potřebujete ustoupit a ptát se, co děláte.“
4.Mějte jiné radosti
Na druhé straně každý z odborníků uvedl, že se věnuje nějakému koníčku, jako je cvičení, tanec a dokonce hra na kytaru.
Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho dosáhnete ve své práci, říká Christina Maslachová, sociální psycholožka, profesorka psychologie na univerzitě v Berkeley v důchodu a autorka knihy „The Burnout Challenge: Managing People's Relationships with Their Jobs“.
„Podívejte se na svůj život jako na celek a ujistěte se, že jsou na něm dobré věci, a ujistěte se, že na ně máte čas.“
Získejte zdarma od CNBC Warrena Buffetta Průvodce investováním, který destiluje miliardářovu nejlepší radu č.1 pro běžné investory, dělejte a nedělejte, a tři klíčové principy investování do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Buďte chytřejší o svých penězích a kariéře s naším týdenním zpravodajem
Mladík obviněn z vraždy při střelbě ve škole v Chicagu, která si vyžádala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě na dva studenty na střední škole v Chicagu v prosinci, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou pokusů o vraždu, oznámil chicagský policejní superintendant David Brown.
„V současné době nemáme jasný motiv, proč by šestnáctiletý chlapec chtěl střílet a zabíjet další děti,“ řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, i když Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběťmi, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti je pomohly dovést k podezřelému, který byl zatčen ve čtvrtek.
„Jsme vděční za ty, kteří byli natolik stateční, že se přihlásili, aby zajistili, že pachatel bude dopaden a bude nyní hnán k odpovědnosti,“ řekl státní zástupce okresu Cook Kim Foxx.
Podezřelý by se měl v sobotu dostavit k soudu v Bond, řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Biologové z Minnesoty zachránili uvězněného medvěda černého
Minnesotské oddělení přírodních zdrojů přišlo na pomoc medvědímu nešťastníkovi poté, co uvízl v příkopu.
Medvěd se podle příspěvku na Facebooku oddělení skrčil ve stoce u silnice poblíž Wannasky v Minnesotě.
Když ale začal tajit sníh, stoka se začala zaplavovat a medvěda podle oddělení uvěznila v hlubokém sněhu a ledu.
Zaměstnanci oddělení na místo rychle zareagovali a pomohli medvěda odstranit.
Medvědí biolog oddělení Andrew Tri podle příspěvku na Facebooku „medvěda vyšetřil a prohlásil, že je zdravý, ale groggy – zřejmě proto, že byl probuzen ze zimního spánku“.
Oddělení pak medvěda přemístilo do státního útulku, aby obnovilo jeho hibernaci.
Ospalý masožravec byl podle odhadů 6 let starý a vážil mezi 375 a 400 librami.
Oddělení připomnělo obyvatelům, že přesun medvědů je práce, kterou je nejlepší nechat na profesionálech.
Pokud se bojíte o medvěda ve svém okolí, měli byste se obrátit na místní úřady – nesnažte se spícího obra přemístit nebo nakrmit.
V tomto případě se kolemjdoucí nejprve pokusili medvěda sami vykopat a nabídli mu potravu, včetně sušenek, salátu a krmení pro kočky Fancy Feast.
Naštěstí pro dobře míněné kopáče ale „protože medvědi nemají v zimě chuť jíst, medvěd nekousl“.
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se podle Oddělení přírodních zdrojů vyskytují hlavně v severní třetině státu.
Dravci v zimě přezimují až šest nebo sedm měsíců, během nichž nejedí a žijí ze svého uloženého tělesného tuku.
Fotografie: Egypt po restaurování slavnostně otevřel hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedli generální tajemník Nejvyšší rady starožitností v Egyptě Mostafa Waziri, velvyslanec Spanu v Egyptě Alvaro Iranzo a předseda španělské Národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady starožitností a CSIC, která pracuje od roku 2002.
Řekl, že mise prováděla vykopávky a restaurátorské práce a publikovala výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahrady.
Důležité hrobky z významné éry
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili během počátku 18. dynastie Nové říše – jedné z nejvýznamnějších epoch starověkého Egypta.
Řekl, že rozložení hrobek má tvar T, styl běžně používaný v hrobkách z 18. dynastie.
Ty odpovídají vstupu, sloupové síni vedoucí k pohřební šachtě a stěnám s výraznými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a během vlády královny Hatšepsut dohlížel na práce řemeslníků a umělců.
Djehuty byl také zodpovědný za zaznamenávání cesty Hatšepsut do Puntlandu a za poskytování elektra (směsi zlata a stříbra) pro zakrytí horní části obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
V místnosti, která předchází pohřební komnatě Djehuty, jsou nápisy s vyrytými 43 kapitolami Knihy mrtvých, poprvé byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátno a papyrus.
Hery zastával pozici superintendanta královských skladů posvátné královské manželky a matky Ahhotepové.
Jared O'Mara nikdy neměl být labouristickým kandidátem, říká Rachel Reevesová
Zostuzený bývalý poslanec Jared O'Mara „nikdy neměl být vybrán jako labouristický kandidát“ a zaslouží si svůj čtyřletý trest vězení, řekl stínový kancléř.
Rachel Reevesová v pátek hovořila s listem Guardian ve volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak labouristický národní výkonný výbor (NEC) kontroloval parlamentní výběrové řízení pro příští všeobecné volby.
Celá výběrová komise v Bolton North East odstoupila poté, co jim nebylo umožněno vybrat užší výběr, což je stále běžnější praxe v labouristické straně Keira Starmera, a řekla: „Opět se zdá, že labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu.“
A dodali: „To jde proti postoji nezbytnému k získání zpět rudé zdi, která je tak zoufale potřebná k vytvoření labouristické vlády.“
Reeves řekl: „Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří byli vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.“
Zvláště nešťastné bylo, že Leigh Drennanová, předsedkyně labouristické strany Severozápad a poradkyně poslankyně za Warrington North Charlotte Nicholsová, podporující Jeremyho Corbyna, nebyla zařazena do užšího výběru, aby se pokusila získat křeslo zpět od konzervativců, přestože získala nominace od čtyř velkých odborových svazů.
Reevesová řekla, že s výběrem kandidátů nemá nic společného, ale dodala: „Vím, že je opravdu důležité, abychom měli přísné procesy ohledně toho, kdo může být zařazen do užšího výběru a kdo může být zařazen do užšího výběru.“
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota shledala, že předložil falešné žádosti o proplacení výdajů v celkové výši 52 000 liber ve snaze financovat své užívání kokainu a alkoholu.
Mnoho lidí naznačovalo, že nebyl náležitě prověřen labouristy, když byl vybrán, aby bojoval proti Nicku Cleggovi, bývalému místopředsedovi liberální demokracie, v Sheffieldském Hallamu v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se debakl O'Mara rýsuje v myslích labouristické NEC, Reevesová odpověděla: „Nechci v žádném případě naznačovat, že každý, kdo není na užším seznamu, je uživatel kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest.“
Okolnosti kolem O'Mary byly „dost výjimečné“, řekla Reevesová, ale uznala: „Pro labouristickou stranu a všechny politické strany je třeba se při výběru kandidátů poučit.
Ale také bych řekla, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě sledem premiérů a pokut a stran a standardů, které zdaleka nedosahují toho, co by se dalo očekávat.“
A dodala: „„Jedna věc, kterou bych o Labouristické straně řekla, je, že když lidé udělají chybu, ztratí bič. A to prostě není případ konzervativní strany.“
Archie Bland a Nimo Omer vás provedou hlavními zprávami a tím, co znamenají, zdarma každé všední ráno.
Upozornění na ochranu osobních údajů: Newslettery mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Více informací najdete v našich Zásadách ochrany osobních údajů.
Používáme Google reCaptcha k ochraně našich webových stránek a platí Zásady ochrany osobních údajů a Smluvní podmínky Google.
Reevesová byla v Boltonu, aby se setkala s učni ve školicím centru pro Openreach, který poskytuje širokopásmovou síť ve Velké Británii.
Poté, co sledoval učně, jak šplhají po předstíraných telegrafních sloupech na staveništi za 1,7 milionu liber, diskutoval Reeves o plánech labouristů na přepracování odvodů za učňovskou přípravu, které nutí větší firmy, aby dávaly stranou 0,5% své mzdy na financování učňů.
Podniky si stěžují, že odvody jsou příliš nepružné. Například, řekl Reeves, Openreach „chce rekvalifikovat lidi, kteří pracují na mědi, na práci na vlákně, ale odvody za učňovskou přípravu nemají takovou flexibilitu, pokud jde o rekvalifikaci.“
Reeves řekl, že labouristé by odvody změnili, aby firmy mohly použít peníze na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a v těch, které v současnosti montují plynové kotle.
„Potřebujeme je jako součást energetického přechodu na čistou nulu, aby se učili dovednostem pro práci na elektrických vozidlech nebo na montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se odvody za učňovskou přípravu vrší proti nim.
Podniky chtějí větší flexibilitu a mladí lidé začínající v životě nebo starší lidé, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost,“ uvedl Reeves.
Jedna zatčená uprostřed protestu Tate Britain kvůli dětské akci drag queen
Jedna osoba byla zatčena uprostřed protestu u Tate Britain, kde se pořádala akce drag queen vyprávějící příběhy pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově vyhroceného komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyli hlášeni žádní zranění a policisté zůstávají na místě, uvedla policie.
Tate v sobotu pořádala Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou webové stránky galerie popisují jako „první drag artistku v Evropě, která četla příběhy dětem ve školce“.
Pravicová skupina protestujících demonstrovala před galerií a setkala se s protistranami vedenými bojovníky za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit koridor, aby se účastníci mohli dostat na místo konání.
Drag queen napsala na Twitter, že den byl „řádně emotivní“, a dodala, že pět protestujících získalo vstup do Tate a „způsobilo narušení“ v některých částech budovy, ale neovlivnili čtení.
Již dříve řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ+ bylo „poctou“.
Její čtení se již dříve stalo terčem protestujících.
Drag Queen řekla, že „posouzení rizik“ proběhlo předem – ale dodala, že je „směšné“, že bylo nezbytné.
Aida napsala na Twitter: „5 haterů se dostalo do Tate. Způsobili narušení. ALE ne Drag Story Hour UK ...Udělali povyk jinde v budově, ne tam, kde byla show!! SHOW 2 šlo plavně!!!“
Aida pořádala tři vyprávění příběhů v sobotu v 11 hodin, v poledne a ve 14 hodin.
Mluvčí Tate řekla: „Neprogramujeme umělce, abychom propagovali konkrétní názory, ani abychom sladili odlišné názory.“
Naše galerie nabízejí široký program a návštěvníci mají možnost si vybrat, kterým jeho aspektům se budou věnovat.“
Trump's Prized 40 Wall Street Building on 'Lender Watch' Amid Dropping Income: Report
Donald Trump's heavily mortgaged skyscraper at 40 Wall Street is on „lender watch“ amid plummeting income and increasing costs, Bloomberg hlásil v pátek.
Míra neobsazenosti v 72-patrové budově – Trumpově nejcennější – vyskočila na téměř 18% ve třetím čtvrtletí loňského roku, podle měsíčního podání na zbývající hypotéku ve výši 126,5 milionu dolarů, Bloomberg hlásil.
Výdaje mezitím údajně stouply o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995, která byla odhadnuta na 540 milionů dolarů v roce 2015.
V den teroristických útoků z 11. září 2001, které zničily World Trade Center a zabily 3000 lidí, se Trump chlubil v televizním rozhovoru, že 40 Wall Street je náhle nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, ale byla to také lež.
Další nedaleký mrakodrap na Pine Street v Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem výškových kanceláří na Manhattanu klesá už několik let, což se ještě zhoršilo po vypuknutí pandemie COVID-19, protože mnoho společností ukončilo činnost a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, „se obrátila na dlužníka se žádostí o status nájemní výstavby“ a plány na zlepšení výkonnosti nemovitosti, jak uvedla agentura Bloomberg.
Majitel firmy Wagner tvrdí, že válka na Ukrajině se potáhne roky
Majitel soukromého vojenského dodavatele ruské skupiny Wagner Group, který se aktivně účastní bojů na Ukrajině, předpověděl, že válka se může táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek řekl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým centrem Ukrajiny Donbasem.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a kterému se kvůli jeho lukrativním kremelským kontraktům s občerstvením přezdívalo „Putinův šéfkuchař“, znamenalo uznání potíží, kterým Kreml čelil v kampani, kterou původně očekával ukončit během několika týdnů, když ruská vojska 24. února vtrhla na Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících nezdarů, když ukrajinská armáda zahájila úspěšné protiofenzívy s cílem získat zpět široké části území na východě a jihu.
Kreml se vyhnul předpovědím, jak dlouho by mohly boje pokračovat, a prohlásil, že to, co nazval „zvláštní vojenskou operací“, bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří Donbas, kde Moskvou podporovaní separatisté od roku 2014 bojují s ukrajinskými silami.
Prigožin řekl, že žoldáci z Wagnerovy skupiny pokračují v nelítostných bojích o kontrolu nad ukrajinskou baštou Bakhmut v Doněcké oblasti.
Uznal, že ukrajinská vojska kladou nelítostný odpor.
Vzhledem k tomu, že ruská vojska tlačí své útoky v Donbasu, Moskva se také snaží demoralizovat Ukrajince tím, že je v kruté zimě nechává bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Ve východních, západních a jižních regionech byla zasažena zařízení vysokonapěťové infrastruktury, což v některých oblastech vyústilo v výpadky proudu.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale kontrolovatelná“, a dodala, že zahrnuje zálohy, aby udržela dodávky energie, ale poznamenala, že v některých oblastech bude pokračovat přídělový systém.
Ukrajinský vojenský šéf generál Valerij Zalužnyj uvedl, že ruské síly odpálily od čtvrtka do pátečního poledne 71 střel s plochou dráhou letu, 35 střel S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět bezpilotních letounů.
Ukrajinské úřady informovaly o dalších útocích vražedných bezpilotních letounů později v pátek.
Ukrajinské letectvo uvedlo, že armáda sestřelila večer 20 bezpilotních letounů Shahed.
Ruští vojenští blogeři a některé ukrajinské zpravodajské servery zveřejnily v pátek pozdě večer video zachycující útok námořního bezpilotního letounu na strategický železniční most v Oděské oblasti.
Zrnité video zachycovalo rychle se pohybující objekt, který se blížil k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a explodoval v silném výbuchu.
Pravost videa nemohla být ověřena.
Ukrajinská armáda se k útoku nevyjádřila a Serhij Bračuk, mluvčí regionální správy, nepotvrdil útok bezpilotního letounu, když v sobotu hovořil v televizním vystoupení.
Most, který byl cílem ruských raketových útoků na začátku války, slouží železničnímu spojení s Rumunskem, které je klíčovým potrubím pro dodávky zbraní ze Západu.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM – Kazašští záchranáři pokračují v prohledávání sutin a pátrají po přeživších v Türkiye, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství trosek a nestabilních konstrukcí.
K dnešnímu dni vytáhl kazašský záchranný tým v Türkiye sedm přeživších zemětřesení a těla 19 lidí včetně jednoho dítěte.
První lékařská pomoc je také poskytována nepřetržitě.
Zejména zemětřesení o síle 7,7 stupně, které zpustošilo části jihovýchodního Türkiye a severní Sýrie, udeřilo brzy v pondělí.
Počet obětí mohutných otřesů, které dnes zasáhly jihovýchod Türkiye, přesáhl 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM – Slavnostní zahájení 10. halového mistrovství Asie v atletice se uskutečnilo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Při zahájení akce přečetl předseda kazašské vlády uvítací dopis prezidenta Kassyma-Jomarta Tokajeva.
„Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je sportu v Kazachstánu věnována.
V naší zemi existují všechny podmínky pro provozování profesionálních a hromadných sportů.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex, který pojme přes šest tisíc lidí,“ stojí v dopise kazašského prezidenta.
Kazašští atleti úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání asijského mistrovství v Astaně dá nový impuls rozvoji atletiky v zemi, a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smajlov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za jeho pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaje se zúčastnilo přes 500 atletů z 31 zemí, kteří mají soutěžit v závodech, štafetových závodech, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí a ve všestranném závodě.
Turnaj má proběhnout do 12. února.
Dříve se uvádělo, že kazašská běžkyně Caroline Chepkoechová Kipkiruiová získala zlato žen na 3000 m a Olga Safronová na turnaji získala stříbro žen na 60 m.
Foto: primeminister.kz
Herec z Yellowstonu Q'orianka Kilcher porazil obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském trhákovém procesu za pomluvu, dosáhla dalšího právního vítězství – tentokrát s hercem z Yellowstonu Q'oriankou Kilcherovou.
Okresní prokuratura v Los Angeles v pátek zprostila dvaatřicetiletého Kilchera všech obvinění v případu podvodu s náhradami zaměstnancům.
V prohlášení, které v pátek sdílela s deníkem The Times, mluvčí okresního prokurátora v Los Angeles uvedla, že soud „rozhodl, že slečna Kilcherová se nedopustila pojistného podvodu a informoval soud, že nejsme schopni pokračovat“.
V červenci 2022 kalifornské úřady obvinily Kilcherovou ze dvou trestných činů podvodu s náhradami zaměstnancům a obvinily ji, že od října 2019 do září 2021 neoprávněně inkasovala více než 96 000 dolarů na dávkách pro invalidy.
Časový rámec zahrnuje také několik měsíců, kdy Kilcherová pracovala na Yellowstonu, a to navzdory hercovým tvrzením, že byla příliš zraněná na to, aby pracovala.
Kilcherová se sama vzdala a v květnu byla obžalována.
„Dnes jsem více než vděčná, že byl můj případ zamítnut – zítra má cesta začne pomáhat zvyšovat povědomí a požadovat větší transparentnost práv zaměstnanců v rámci systému zaměstnaneckých náhrad,“ řekla Kilcherová v pátek v prohlášení, které sdílela s The Times.
Dodala, že „se těší, že vrhne více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji“.
Kilcherová také poděkovala Vasquezové a jejímu kolegovi advokátovi Stevu Cookovi z Brown Rudnick za „jejich neochvějnou víru v mou nevinu“.
Podle TMZ si Kilcherová najala oba v září.
Kilcherová se rozešla s filmem Terrence Malicka „Nový svět“ z roku 2002, kde ztvárnila Pocahontas.
Mezi její kredity patří také „Synové anarchie“, „Alienista“ a „Dora a ztracené město ze zlata“.
Naposledy se objevila v road-trip filmu „Pes“ s Channingem Tatumem v hlavní roli.
Do této zprávy přispěla redaktorka Timesů Christina Martinezová.
Šéf Balenciagy označil prázdninovou kampaň za „hloupou chybu“
Značka luxusního oblečení Balenciaga se stále potácí v nevoli kvůli dvěma svým nedávným reklamním kampaním.
Měsíce poté, co se módní dům dostal pod palbu kritiků kvůli propagačním snímkům, které podle kritiků sexualizovaly děti, umělecký ředitel Balenciagy Demna (celým jménem Demna Gvasalia) v rozhovoru pro Vogue zveřejněném v pátek řekl, že ho obrázky stále mrzí.
„Chci se osobně omluvit za špatný umělecký výběr konceptu pro dárkovou kampaň s dětmi a beru na sebe svou odpovědnost,“ řekl Vogue a zopakoval tak předchozí prohlášení, které v prosinci zveřejnil na sociálních sítích.
V listopadu značka sdílela fotografie pro svou kolekci „The Gift“, na které byly dětské modely pózující s plyšovými medvídky, kteří byli oblečeni v bondage oděvu.
Krátce poté Balenciaga vypustil fotografie pro svou kampaň na jaře 2023, na kterých byla v pozadí stránka z případu Nejvyššího soudu z roku 2008, který se týkal „virtuální dětské pornografie“.
Rodiče, včetně hvězdy reality TV a dlouholeté fanynky Balenciagy – a partnerky značky – Kim Kardashianové, vystoupili proti značce a jejím „znepokojivým obrázkům“ na sociálních sítích.
O několik dní později Balenciaga vydal prohlášení, ve kterém se za fotografie omlouvá a nastiňuje změny, které zavede, aby se v budoucnu podobným „chybám“ vyhnul.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrázky, ve způsobu, jakým komunikujeme s naším publikem, a ve způsobu, jakým se učíme ze svých chyb a jdeme dál,“ řekl Demna pro Vogue.
Podrobně popsal změny po odezvách v Balenciagu: „restrukturalizace oddělení image“, provádění dalších interních a externích kontrol pro snímky z kampaní a partnerství s Národní dětskou aliancí, které má pomoci „tisícům dětí v procesu překonávání traumat a vyrovnávání se s jejich duševním zdravím“.
„Je to jediná věc, která mě na celé té hrozné situaci těší: udělat z toho něco dobrého,“ řekl o partnerství, které bylo oznámeno ve středu.
Spolupracuje také s NCA Balenciagova mateřská společnost Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod Keringovým deštníkem je Gucci, která v prosinci čelila kritice kvůli kampani s Harrym Stylesem, o níž někteří kritici na sociálních sítích tvrdili, že sexualizuje i děti.
V rozhovoru Denma řekl, že se hodlá oprostit od „provokativních“ způsobů značky.
„Je to součást mého učení: budu mít zralejší a vážnější přístup ke všemu, co vydám jako myšlenku nebo image,“ řekl.
„Rozhodl jsem se vrátit ke svým kořenům v módě i ke kořenům Balenciagy, která vyrábí kvalitní oblečení – nedělá image ani buzz.“
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jednou z „nejbolestivějších“ částí odporu bylo pošpinění „jména Balenciaga a odkazu Cristóbala Balenciagy“.
„Balenciaga je dům, který je více než sto let starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem dělal vše, co bylo v mých tvůrčích silách, abych ho přivedl k jeho modernímu významu, a najednou jsme byli pod útokem a označeni jako něco, co vůbec nejsme,“ řekl Demna.
„Rozhodně jsme udělali obrovskou a hloupou chybu s darovací kampaní a rozhodně jsme se z ní poučili.“
Je to falešná zpráva, CBN popírá, že nemá kapacitu tisknout další nové bankovky Naira
Nigerijská centrální banka (CBN) označila zprávu, která tvrdila, že cituje vládu CBN pana Godwina Emefieleho, za zavádějící, protože současnou výzvu v distribuci nově přepracovaných bankovek Naira připisuje nedostatku tiskových materiálů v Nigerijské bezpečnostní tiskárně a mincovně Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy takové prohlášení neučinil během své prezentace před Národní státní radou na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele na zasedání pouze sdělil, že NSPMC pracuje na tisku všech nominálních hodnot bankovek Naira, aby uspokojila transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek Naira, „jsme znepokojeni tím, do jaké míry se partikulární zájmy pokoušejí manipulovat s fakty a štvát veřejnost proti bance.“
Nwasinobi řekl, že CBN je nadále odhodlána vykonávat své funkce v oblasti měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (v platném znění).
„Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované odrážky Naira.
„Banka si proto přeje apelovat na veřejnost, aby uvedenou zprávu nebrala v potaz a uplatňovala větší zdrženlivost, i když neúnavně pracujeme na zvýšení oběhu nových bankovek v zemi,“ dodal.
Ke konkrétní hlasové poznámce, která se objevila na sociálních médiích a která tvrdila, že CBN plánuje zrušit některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že žádný takový plán neexistuje a že tvrzení jsou nelogická a neodpovídají fungování nigerijského bankovního systému.
„Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický tah CBN a jsou to jen zoufalé pokusy osob, které se snaží štvát veřejnost proti bance,“ konstatoval.
Tim Sherwood se po bezútěšném debutu v Tottenhamu rozplakal na 44 milionů liber při podpisu smlouvy s Pedrem Porrem
Porro měl odpoledne, na které se dalo zapomenout proti Leicesteru (Obrázek: Getty)
Tim Sherwood se pustil do „absolutně nechutného“ bránění Pedra Porra během porážky Tottenhamu 4:1 s Leicesterem City.
Spurs podepsali smlouvu s pravým obráncem ze Sporting CP v den uzávěrky přestupů na původní smlouvu o půjčce za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
Třiadvacetiletý hráč dostal svůj debut od Antonia Conteho v sobotu na King Power Stadium s tím, že jeho tým se dostal do vedení po 14 minutách přes Rodriga Bentancura.
Ale změnilo se to v mizerné odpoledne s Nampalys Mendym, Jamesem Maddisonem a Kelechim Iheanachem, kteří skórovali a dali Leicesteru v poločase 3:1 s Porrem, který vydržel rozpálený první poločas v Premier League.
Španěl opět chyboval, protože Leicester si myslel, že přidali čtvrtý přes Barnese a zatímco gól byl vyloučen kvůli ofsajdu, bývalý trenér Spurs Sherwood zůstal šokován defenzivním úsilím plzeňského hráče.
„Nechci si pořád dobírat toho kluka, ale potřebuje být uvolněn ze svých povinností,“ řekl Sherwood Soccer Saturday.
Dám mu výhodu pochybnosti, protože je to jeho debut, ale Pedro Porro není špatný je neuvěřitelný.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden říkal, že utratili hodně peněz, ano, utratili, ale jejich nábor byl velmi špatný a tohle je poslední přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale to, na co se dívám, je hráč, který nechce bránit.
Více: Premier League
„Antonio Conte si stěžoval na bránění a tento hráč se v tuto chvíli snaží bránit. Stojí proti velmi dobrým hráčům Barnesovi a Maddisonovi, ale je to velké zklamání.“
Zatímco gól byl vyloučen, Leicester obnovil vedení 4:1 a Barnes se dostal do cíle devět minut před koncem základní hrací doby.
Přestože minulý týden porazil Manchester City, Tottenham propásl šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala smlouvu s Joaem Felixem a místo toho se vrhla na hvězdu Tottenhamu
VÍCE: Tottenham se chystá ucházet o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální opci na odkup
Další podobné příběhy najdete na naší sportovní stránce.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli privilegovaný boj o předvolání Mika Pence
Zpráva, že zvláštní obhájce Jack Smith předvolal Mika Pence, vyvolává otázku: Jak tým Trump využije soudy, aby zmařil tento poslední vývoj v pátrání ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus o zmaření Penceova předvolání na základě privilegií exekutivy by měl ztroskotat.
Za prvé, je tu prahová otázka, zda bývalý prezident vůbec může privilegium požadovat.
Připomeňme, že Trump se snažil a nepodařilo se zablokovat sněmovní komisi 6. ledna, aby získala záznamy z Bílého domu.
Nejvyšší soud loni odmítl zabývat se Trumpovým odvoláním, pouze soudce Clarence Thomas (manžel popíračky voleb z roku 2020 Ginni Thomasové) nesouhlasil.
Soud však ponechal otevřenou otázku, zda exprezident může nárokovat privilegium, přičemž soudce Brett Kavanaugh navrhl, že by takové tvrzení podpořil.
Je tedy přinejmenším nejasné, zda si bývalý prezident může nárokovat privilegium, aniž by říkal, zda by nárok uspěl.
Navíc odvolání k Nejvyššímu soudu kvůli snaze tehdejšího prezidenta Richarda Nixona vyhnout se vyhovění předvolání ukazuje, že vágní tvrzení o privilegiu nestačí a může být překonáno specifickou potřebou důkazu.
Soud v roce 1974 poznamenal, že Spojené státy versus Nixon:
... když je důvod pro uplatnění privilegia, pokud jde o předvolané materiály hledané pro použití v trestním řízení, založen pouze na všeobecném zájmu na důvěrnosti, nemůže převážit nad základními požadavky na řádný soudní proces ve spravedlivém výkonu trestní spravedlnosti.
Všeobecné tvrzení o privilegiu musí ustoupit prokázané, specifické potřebě důkazu v probíhajícím trestním řízení.
Proto je precedens na straně vlády.
Ovšem, odklady od vedení soudního sporu i v prohraném případě mohou být pro Trumpa určitým vítězstvím.
Ale další utlumení šancí na úspěšné uplatnění privilegií je předchozí odmítnutí Trumpova pokusu zablokovat výpověď velké poroty z 6. ledna.
Jak v říjnu uvedl The Washington Post, toto odmítnutí poznamenalo, že například bývalý Pencův poradce Marc Short „pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti útoku na Kapitol z 6. ledna 2021, které nebyly dostupné z jiných zdrojů.“
To, že Pence má pravděpodobně také unikátní informace, by pomohlo ministerstvu spravedlnosti v jakémkoli boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je další důvod, proč by privilegium nemělo uspět.
To proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Těžko říct, že komunikace jsou privilegované, když jste je předtím považovali za vhodné pro publicitu.
Takže zatímco předvolání by mohlo představovat různé politické a osobní kalkulace pro Pence – který může soupeřit o republikánskou nominaci v roce 2024 proti Trumpovi, pro někoho, kdo fakticky promíjel výzvy k Penceově mimosoudní popravě 6. ledna – soudy by měly mít lehké období, kdy by se v otázce privilegií přiklonily na stranu ministerstva spravedlnosti.
Případ proti Bidenovu běhu je zřejmý – a slabý
Proč je to důležité?
Biden a jeho kolegové demokraté sice nemohou moc schvalovat zákony, když má Sněmovnu pod kontrolou vládní strana, ale přesto mohou další dva roky strávit tím, že půjdou příkladem.
Všichni v týmu by měli společně vyhledávat příležitosti, jak si zahrát na galantní na podivínské husákovské impulzy republikánů.
Ale pro Bidena je také důležité, aby si spálil svou důvěryhodnost u amerického lidu – a možná se stal zoufale potřebným hybatelem změn v naší až příliš chatrné politické kultuře.
Washington, notoricky cynické místo, je proslulé svými zdravým rozumem ochromujícími představami o vůdcovství.
Snad jednou z nejznámějších je podivná norma, která tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli zajít až do komických krajností, aby se tomu vyhnuli.
Je tu ještě jeden způsob: V Bailout, memoárech Neila Barofského o jeho působení ve Washingtonu, kde sloužil jako zvláštní generální inspektor dohlížející na program na pomoc problémovým aktivům, popsal rady, které se mu dostalo od Kristine Belisleové, ženy, kterou chytře najal, aby byla jeho ředitelkou komunikace.
Bylo to asi tak anti-washingtonské, jak to jen šlo: „Přiznáme a dokonce zdůrazníme naše chyby.“
Jak dále vysvětlila, ve strategii je metoda, kterou by většina lidí v Beltway považovala za šílenství:
Tohle je nejlepší způsob, jak si získat důvěru tisku.
Poznají, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Možná se občas stydíme a prozradíme věci, které bychom mohli – a jiní by to udělali – snadno skrýt, ale svou upřímností tisk šokujeme.
Nikdo jiný tohle nedělá a zanedlouho budeme mít vybudovanou obranu, když na nás zaútočí.
Ať uslyší cokoliv, tisk přijde nejdřív za námi a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč se Biden vydal cestou radikálního přebírání zodpovědnosti: v každém prezidentském úřadu nevyhnutelně nastanou chvíle, kdy je rozhodující důvěra veřejnosti a institucí, které chrání občanský zájem.
Navíc je tu životně důležitý kapitál, který lze získat vlastnictvím našich chyb, a je tu důležitý rozdíl, který Biden může načrtnout se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: Říkat pravdu – a zahanbit ďábla.
Pár reklam na Super Bowl, na které se nemůžu dočkat
Hvězda sitcomů z devadesátých let, která opakuje svou milovanou roli, aby vám prodala pojištění na auto.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, který rozšiřuje dvanáctivteřinovou scénu do deseti sezón.
Všechny celebrity z loňských reklam na kryptografii se omlouvají za své reklamy na kryptografii.
Ti chlápci z „whassup“ ale vtip je v tom, že teď už jsou staří.
Každý je teď na whodunnity, ne?
Takže nějaká série reklam režírovaná Rianem Johnsonem, kde když zjistíte, kdo spáchal vraždu, dostanete slevu na roční pojištění na auto.
Reklama, kvůli které budou všichni super-online konzervativní chlápci týden zuřit.
Timothée Chalamet v nějaké funkci.
Někdo, kdo byl údajně navždy zrušen, aby se vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte, na kterou se určitě podíváte, až se bude vysílat za tři týdny.
Nesnesitelně chytlavá nová znělka, kterou si budete roky zpívat pro sebe.
Recyklovaný vtip na Twitteru z doby před dvěma měsíci.
Muzikant, jehož celá věc je kontrakultura, který vám protikulturně říká, abyste si nahráli s Wells Fargo.
Kluk se zvětšeným zoomem ale jde o to, že už je dospělý.
Biden DOJ 'Nechce ozbrojeného občana'
Reprezentant Andrew Clyde (R-GA) si ve čtvrtek sedl s Breitbart News a diskutoval o svých plánech blokovat pravidlo ATF o pistolových výztužích a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti „vůbec nechce ozbrojené občanstvo“.
Clyde dal jasně najevo svůj nesouhlas s pravidlem pistolových výztuží.
Jeho důvody pro tento nesouhlas zahrnují jak obecné námitky, tak i ty konkrétnější.
Obecně vyjádřil své přesvědčení, že naši Otcové zakladatelé nestanovili plán vládnutí, který by zahrnoval federální agentury vytvářející zákony místo zákonodárného sboru.
Řekl: „Ministerstvo spravedlnosti je tu od toho, aby prosazovalo právo, ne aby ho vytvářelo. Když máte výkonnou moc vytvářející právo a prosazující právo, pak máte krále a království. Naši Zakladatelé nevolali po králi a nestanovili království v Ústavě Spojených států.“
Clyde pak přešel ke konkrétnostem ohledně pravidla o pistolových výztužích a vyjádřil obavu, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: „To, co ATF chce, je rozšířit registrační databázi pro národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co předchází konfiskaci, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany.“
Dodal: „Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo má co, aby po nás mohli jít.“
Clyde tvrdí, že pravidlo o pistolových výztužích ATF se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní, a plánuje s tím bojovat zuby nehty.
Řekl, že má „tři nástroje“, kterými může proti tomuto pravidlu bojovat.
Prvním z těchto nástrojů je zákon o KRÁTKÉM a druhým zákon o přezkumu Kongresu.
30. ledna citoval Breitbart News Clydea, který nastínil svůj plán „znovu zavést zákon Stop Harassing Owners of Rifles Today Act, nebo zákon SHORT Act, který zruší prvky zákona o státních střelných zbraních, a tím zakáže ATF registrovat a zakazovat pistole se stabilizačními ortézami“.
Poznamenal také, že „zavede usnesení o nesouhlasu podle zákona Kongresu o přezkumu, aby zrušil protiprávní překročení pravidel Bidenovou administrativou“.
Oba zákony, zákon SHORT Act a zákon Kongresu o přezkumu, mají možnost blokovat pravidlo ATF o pistolových ortézách.
Ale jak řekl Clyde Breitbart News Thursday, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, buď k uzákonění zákona SHORT Act nebo k dokončení usnesení o nesouhlasu podle zákona Kongresu o přezkumu.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k dalším, větším návrhům zákonů, které demokraté velmi dychtí schválit.
Nicméně, Clyde naznačil, že existuje i třetí způsob, jak blokovat pravidlo ATF pistol brace.
Řekl: „Jsem v rozpočtovém výboru a můžeme toto pravidlo pistol brace zrušit, prostřednictvím toho, čemu se říká omezující dodatek. Můžeme toto pravidlo doslova zrušit a v podstatě říct: „Žádné peníze nesmí být vynaloženy na vykonání nebo prosazení tohoto konkrétního pravidla pistol brace.“
A můžeme také udělat úplně to samé s pravidlem ATF receiver/frame, z loňského srpna.
Myslím, že oba musí být defunded a těším se na spolupráci s našimi přivlastňovateli, abychom to mohli udělat.
AWR Hawkins je oceněný komentátor druhého dodatku pro Breitbart News a spisovatel/kurátor Down Range s AWR Hawkins, týdenního zpravodaje zaměřeného na všechny věci druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem v USA v bodu zvratu.
AWR Hawkins má doktorát z vojenské historie se zaměřením na válku ve Vietnamu (hnědé vodní námořnictvo), americké námořnictvo od Počátku, občanskou válku a ranou moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
K získání Down Range se můžete přihlásit na breitbart.com/downrange.
Spojte se s ním přímo na awrhawkins@breitbart.com.
'We Hope' Biden Has a Plan for Handling Title 42 Ending, 'If They Do, They Haven't Shared It Fully'
V pátečním vydání pořadu stanice NBC „MTP Now“ řekl coloradský guvernér Jared Polis (D), že má „velké obavy“ z toho, co se stane, až Hlava 42 v květnu skončí, doufá, že Bidenova administrativa má plán na to, kdy tato politika skončí, a že „pokud ano, ještě se s námi o něj plně nepodělili“.
A řekl, že „jsme řekli, potřebujete plán. Chceme, aby ho s námi prověřili“.
Polis uvedl, že by si přál, aby se více času věnovalo otázce přistěhovalectví během setkání guvernérů v Bílém domě, ale tato otázka „přišla na přetřes“.
Měli jsme tam z části tajemníka Mayorkase.
A tak jsme znovu nadnesli, že mám velké obavy z toho, co se stane, až Hlava 42 v květnu skončí, a tak se ujistíme, že federální vláda má plán.
Doufáme, že ho mají.
Pokud ho mají, ještě se s námi plně nepodělili.
Ale řekli jsme si, potřebujete plán.
Chceme, aby ho s námi prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo krát tři, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Ian Hanchett na Twitteru @IanHanchett
McDonald's stahuje „nevkusný“ inzerát v blízkosti krematoria – RT World News
McDonald's se omluvil poté, co byla v blízkosti krematoria ve Velké Británii umístěna reklama na hamburger „McCrispy“ řetězce rychlého občerstvení – i když někteří místní obyvatelé tu vtipnou stránku viděli.
Řetězec restaurací se zavázal odstranit urážlivé reklamní poutače na základě stížností obyvatel Trura v britském hrabství Cornwall.
V pátek si na sociálních sítích získal pozornost tím, že byl umístěn na rušnou silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlený inzerát, který byl umístěn přímo za cedulí ukazující na krematorium, označili někteří rozzlobení místní obyvatelé za „nevkusný“.
„I když tu vtipnou stránku vidím, je nevkusný a jsem si jistý, že někteří truchlící členové rodiny ho při návštěvě Penmountu na pohřbu a kremaci milované osoby neuvidí rádi,“ řekl jeden z obyvatel, jehož tchyně byla loni v pohřebním ústavu zpopelněna, jak citovala britská média.
Ne všichni však byli nešťastným umístěním inzerátu tak uraženi, když jeden poznamenal, že reakce člověka na něj bude pravděpodobně ovlivněna tím, „jak dávno jste sledovali nápis krematorium s černou kravatou“.
Jeden člověk řekl, že „spadl ze židle smíchy“, když si inzerátu všiml na internetu, zatímco jiný místní poznamenal, že to není „o nic horší“ než rozhodnutí rady zabývat se myšlenkou, že by krematorium mohlo být postaveno „vedle vesnice důchodců“.
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek brzy poté, co se na internetu rozšířil obrázek inzerátu, v němž řetězec restaurací uvedl, že inzerát co nejdříve odstraní.
„Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. Avšak ve světle obav, které vyvolal CornwallLive, jsme požádali o odstranění naší reklamy,“ uvedla značka rychlého občerstvení.
Společnost Cornwall Council, která provozuje krematorium i autobusovou zastávku, která inzerát zobrazuje, odmítla komentář k rozruchu, když ji kontaktovala místní média.
Pohřešovaná žena 'instinkt' není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové začalo 16. den poté, co její partner řekl, že jeho 'instinkt' říká, že není v řece.
Lancashirská policie uvedla, že policisté si zachovávají „otevřenou mysl“, zatímco nadále žádají o informace o paní Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael's na Wyre.
Policie pokračuje v prohledávání řeky Wyre směrem k moři v zátoce Morecambe, pracuje na jedné hypotéze, že pětačtyřicetiletá dívka z Inskipu mohla spadnout do vody.
V pátrání jim pomáhali specialisté a potápěči z HM Coastguard, horské záchranné služby a Lancashirská hasičská a záchranná služba, s nasazenými čmuchacími psy, drony a policejními vrtulníky.
Paní Bulleyová zmizela, když venčila svého kokršpaněla Willowa poblíž řeky, krátce poté, co vysadila své dcery ve věku šesti a devíti let ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále připojený k pracovnímu hovoru.
Její partner Paul Ansell řekl, že chce nechat „všechny možnosti otevřené“ ohledně jejího zmizení, ale jeho „instinkt“ mu říká, že v řece není.
Popsal paní Bulleyovou jako „zábavnou“, „milující“, „nejvěrnější přítelkyni, jakou kdy můžete mít“ a „výjimečnou maminku“, která „absolutně zbožňuje naše holky“.
„Je jen pilířem síly naší rodiny a bez ní je ta díra větší, než si vůbec dokážete představit,“ řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází „nevídaným peklem“, naděje, že jeho partnerka bude nalezena, je „silnější než kdy jindy“.
Policie zlehčila trestný čin a událost považuje za vyšetřování pohřešované osoby.
Ve čtvrtek se ohnisko jejich pátrání přesunulo ze St Michael's na přibližně 10 mil po proudu, kde se řeka vlévá do moře v zátoce Morecambe, v oblasti byly spatřeny hlídkové a záchranné čluny.
Poslední komunistický vůdce východního Německa zemřel v 95 letech
BERLÍN (AP) – Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95 let.
Modrow zemřel v sobotu brzy ráno, informovalo parlamentní uskupení Levice na twitteru.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později přizval do vlády opoziční síly, ale nedokázal zpomalit rostoucí dynamiku pro znovusjednocení Německa.
„Celý mírový průběh ustavení německé jednoty byl přesně jeho zvláštním úspěchem,“ napsala Levice na Twitteru."To zůstane jeho politickým odkazem.“
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst postavy namířené proti establishmentu.
Odmítal stranické požitky a trval na tom, že bude žít v normálním bytě.
Funkce v nejvyšším vedení východního Německa mu unikala, dokud nebyl v listopadu 1989 – několik dní po pádu Berlínské zdi – jmenován premiérem, což byla pozice, která dříve měla jen malý vliv.
Když na začátku prosince rezignoval vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou osobností východního Německa.
Komunisté už ale sami o sobě nemohli rozhodovat.
Následující měsíc souhlasil s tím, že se bude dělit o moc se stále hlasitější opozicí, a za sílících nepokojů posunul první svobodné volby ve východním Německu až na březen 1990.
I když prodemokratické manifestace rychle nabývaly na sjednocující příchuti, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se západním Německem o případné „sjednocené vlasti“, která by byla nezávislá na vojenských blocích a řídil by ji společný berlínský parlament.
Modrow stál v čele volební kampaně restylovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nestačila na to, aby jim zabránila skončit jako pouze třetí nejsilnější strana s 16 procentní podporou.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde zasedal do roku 1994, a čestným předsedou postkomunistické PDS – předchůdce dnešní opoziční Levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho dostala před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků v květnových komunálních volbách v Drážďanech.
Uložil mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozpory mezi východními a západními Němci.
Jeho obhájce tvrdil, že napravil předchozí nespravedlnosti tím, že jako premiér dohlížel na svobodné volby.
Později Modrow působil v radě starších strany Levice.
„Hans byl hluboce upřímný a bojovný socialista,“ tweetoval Dietmar Bartsch, předseda parlamentní skupiny Levice.
„Až do stáří byl důležitým poradcem v naší straně, jehož moudrost bude chybět.“
Indická vláda po kritice stáhla výzvu k objímání krav na Valentýna
Objímání krávy na Valentýna již není podporováno indickou vládou – navzdory tomu, že dříve žádala lidi, aby tak činili v zájmu propagace hinduistických hodnot.
Rada pro dobré životní podmínky zvířat Indie (AWBI) stáhla svou výzvu ke „dni objímání krav“ poté, co vyvolala kritiku politických soupeřů a uživatelů sociálních médií.
Indické vládní ministerstvo vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay řekl, že výzva k objímání krav byla „naprosto šílená, odporující logice“.
Dodal, že rozhodnutí stáhnout výzvu bylo spíše „aby se zabránilo zesměšňování politiky hindutvského [hinduistického nacionalismu] tváří v tvář tvrdé kritice ze všech stran“.
AWBI v pátek svou výzvu popřela s tím, že „se stahuje“.
Teprve ve středu se v jejím prohlášení psalo, že „objímání krav [by] přineslo citové bohatství a zvýšilo individuální i kolektivní štěstí“.
Více o Indii
Dodala, že kráva je „páteří indické kultury a venkovské ekonomiky... kvůli své výživné povaze jako [matka]“.
Na původní oznámení se objevily smíšené reakce, když někteří zveřejnili videa krav, které odmítají být objímány a odplouvají.
Jiní chtěli objasnit, že výzva byla spíše pro následování vlastní kultury, na rozdíl od „slepého“ následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Mazlení krav také není nic nového – v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známo jako „koe knuffelen“.
Oddaní hinduisté uctívají krávu – známou jako gau mata, neboli „mateřská kráva“ – a většina států v Indii porážku krav zakázala.
V posledních letech někteří hinduističtí zastánci tvrdé linie podnikali nájezdy do obchodů, kde prodávali valentýnské předměty, pálili karty a dárky a vyháněli páry držící se za ruce z restaurací a parků a trvali na tom, že den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Šiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu upevnit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadřazenost náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinové tvoří většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeathu, muž byl zatčen
Chodec zemřel po srážce s autem ve Fife.
Osmatřicetiletá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeathu v pátek kolem 13:30.
V souvislosti s nehodou byl následně zatčen čtyřiadvacetiletý muž.
Policie žádá všechny svědky nebo kohokoli se záznamem z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: „Naše vyšetřování pokračuje a žádáme každého, kdo byl v oblasti a kdo byl svědkem nehody, aby se s námi spojil.“
Apeluji také na každého, kdo řídil v oblasti a kdo by mohl mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
„Každý, kdo by mohl pomoci, se žádá, aby zavolal policii ve Skotsku na 101, cituje incident číslo 1638 z pátku 10. února 2023.“
V ČÍSLECH: Čtvrť Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když započítáme ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili největší přistěhovaleckou skupinu občané z Asie, včetně Turecka, podle údajů národní datové agentury Statistics Norway (SSB) žilo ve městě přes 62 985 těchto státních příslušníků.
Poté tvořili druhou největší skupinu občané z EU, EHP a Velké Británie, kteří tvořili ne příliš daleko 10 procent obyvatel města.
Třetí největší skupinu přistěhovalců v Oslu tvořili Afričané, v Oslu žilo 28 020 lidí z Afriky.
Čtvrtou největší skupinou byli Evropané ze zemí, které nejsou součástí Velké Británie, EU nebo EHP, a to 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 zde žilo jen o málo více než 7 000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo o něco více než 3 000 státních příslušníků.
Mezitím v Oslu žilo méně než 700 lidí z Oceánie.
Alna na severovýchodě města byla čtvrtí s nejvíce zahraničními obyvateli.
V roce 2022 zde bylo registrováno asi 18 257 zahraničních obyvatel.
Poté měla trendy Grünerløkka, nacházející se přiměřeně centrálně, druhý nejvyšší počet zahraničních obyvatel, 17 631.
Gamle Oslo mělo také významnou populaci imigrantů, 17 631 lidí tam žilo poté, co se přestěhovali z jiné země.
Statistiky Norské údaje ukázaly, že cizinci byli roztroušeni po všech městských okresech, protože Søndre Nordstrand, čtvrt nejdále na jih v Oslu, tam měla registrováno přes 14 000 imigrantů.
Mnoho imigrantů také žilo ve vyhledávaných oblastech, protože Frogner byl čtvrtí s pátým nejvíce cizinci.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okresů v Oslu s nejvíce obyvateli z jiné země.
Na opačném konci spektra jen 184 zahraničních obyvatel nazývalo Marku domovem a něco přes 700 jich žilo v centrální městské části města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní městské části s nejméně zahraničními obyvateli.
V těchto městských částech však žilo výrazně více imigrantů než v centrálním Oslu a Markě.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili ve Frogneru, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Zatímco spousta občanů z Asie, včetně Turecka, pobývala také ve Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet imigrantů z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Nordstrandem.
Ti ze Severní Ameriky byli celkem rovnoměrně rozmístěni ve městech Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve městech Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojeného království obvykle žili v nejústřednější městské čtvrti města, Ullernu, Vestre Akeru, Nordre Akeru a Stovneru.
A konečně z několika stovek státních příslušníků z Oceánie byly čtvrti Frogner, Grünerløkka a Gamle Oslo čtvrtěmi s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
By Florence Tan
BENGALURU (Reuters) – Zimbabwe zahájí provoz nové jednotky ve své jediné uhelné elektrárně do března, říká náměstkyně ministra energetiky země, která poskytne úlevu milionům občanů, jimiž v posledních měsících otřásají časté výpadky proudu.
Nová jednotka elektrárny Hwange zvedne instalovaný výkon afrického státu o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa bez udání časového harmonogramu.
Méně než polovina ze 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení financování nových uhelných kapacit omezilo schopnost země zaplnit chronické výpadky proudu, které v posledních dnech trvaly až 18 hodin.
„Máme kapacitu vyrobit až 2100 megawattů (MW) z našich zdrojů energie, ale v tuto chvíli vyrábíme mnohem méně..asi 1000 MW,“ řekla Mudyiwa agentuře Reuters.
„Ale naše poptávka po elektřině je asi 1700MW, takže máme vážný deficit,“ řekla.
Nedostatečné srážky vedly k poklesu výroby elektřiny ve vodních elektrárnách, zatímco účinnost jediné, desítky let staré uhelné elektrárny se v průběhu času prudce snížila, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžební a zemědělské aktivitě.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů, které zatěžují vyhlídky Zimbabwe na růst.
Nedostatek financí na uhelnou energii pohání těžební a na zemědělství závislou ekonomiku k dovozu nákladné energie z regionálních sousedů včetně Zambie a Mosambiku.
(Napsal Sudarshan Varadhan; Editing by Jacqueline Wong)
(PERSON11) Ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně –
V podstatě velký obchod, nebo něco je špatně.
Takže, některé soubory jsou stále – stále mají podivný výstup.
Ale – ale u většiny složek by to už mělo být v pořádku.
(PERSON1) Dobře, díky.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé, že, [PERSON7], jste si vzpomněli na [PERSON11].
A [PERSON11] má nyní čas.
Jsou i jiné věci, kde jsem přemýšlel o [PERSON11] a to by byl trénink, prázdných systémů, aby prováděly zkrácení.
Takže, kdybyste, [PERSON11], měli čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat pro příští týden.
Ale opravdu bychom měli mít systém – připravený na –
Podíval jsem se na tutoriál z NLP – bylo to tak?
(PERSON6) Pro nadcházející sezení a ptal jsem se na poptávku, protože jsem viděl demo projektu (meme).
Dělají offline titulkování.
Takže, to je o něco jednodušší než to, co děláme my.
Stále mají stejné problémy se segmentací a tak dále.
Ale jejich poslání v překladu je zkrácení jednoduše proto, že se data zkracují.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech je něco jako přirozené zkrácení.
Bylo by skvělé, kdybychom také mohli najít takový typ dat, kde dochází k nějakému přirozenému zkrácení.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože potřebuji zjistit, který z nich je ten, který dostává propustky.
Takže, jakmile to budu vědět, můžu si to sledovat, takže do budoucna –
Nebo vlastně do budoucna bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset dělat konverzi.
(PERSON6) No, tohle, tohle by vlastně mělo být –
Slyšíte mě ještě?
Kvalita zvuku je trochu horší.
Takže, tohle by se mělo opravdu dělat, pořád.
Takže, pokaždé, když spustíme toto hodnocení, mělo by se to spustit od začátku.
Takže, pokaždé, by mělo být čerstvé stažení čerstvé konverze a čerstvé vyhodnocení.
(PERSON8) Ale stejně, když si vedu záznamy o souborech, které je třeba ručně převést, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známé, a samozřejmě, když přidáme nějaké nové soubory, tak to uvidím později.
(PERSON6) Takže tohle je důležitá věc, na kterou jsme měli narazit už před několika měsíci.
Pamatujte si, že už od srpna vám říkám, že chceme vyhodnocovat na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejste to jen vy osobně, [PERSON8].
Byly tam samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, tak jste si říkali „tohle bude jednoduché, prostě to spustíme“.
A až když to opravdu uděláte, vidíte všechny problémy.
Takže, tohle je známé, běžné.
Vždycky to tak je.
Takže to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, jaký bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, takže chtěli nahrát video.
Zoom nikdy nefungoval tak špatně jako dnes pro nahrávání.
Takže, než to uděláte, nemůžete říct, jestli to bude fungovat nebo ne.
A tady narážíme na problémy s konverzí formátů souborů.
Takže, doufejme, že budeme schopni rychle získat čísla.
Takže, máte zatím nějakou chybovost slov?
(PERSON8) Ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně šumu.
Takže jsem se ptal, že budete mít různé verze tohoto slovníku tím, že vezmete pouze ta slova, která byla pozorována, pětkrát.
A pouze ty výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takže tímto způsobem tyto náhodné chyby, jako je příklad s tímto čtyřmi IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba, řekne toto „alzo“, pokud si vzpomenete, pokud řekne toto „alzo“ se „Z“ dvacetkrát v rozhovoru, pak to uvidíte v datech s „Z“.
A pokud se mu někdy podaří říci také správně, pak ano, opět, uvidíte to v datech.
Takže bych chtěl, aby [PERSON4] byl v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, že?
Budu muset odejít teď, protože potřebuji dát dětem oběd a tak dále.
Ale prosím, zůstaňte u tohoto hovoru a společně vymyslete, jak používat tento slovník.
Takže [PERSON4], prosím, ukažte [PERSON2], jaký slovník systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste do tohoto souboru vypustili.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři sloupce n.
Graf, jak je výstup.
Jeden rozpoznán.
Telefony, jak [PERSON2] navrhoval.
A bude tam více řádků s různými fonémy variacemi.
A třetí sloupec n bude také stejný pro všechny z nich a opět tam bude stejný grafem formulář.
Takže to je, když jazykový model vidí.
A myslím, že tímto způsobem, by tyto systémy měly být schopny jej načíst.
A také možná narazíte na ještě jeden problém: že to není připraveno pro dva velké vlastní slovníky.
Takže, to je také něco, co musí být otestováno, ale prosím otestujte to, vy dva dohromady.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a potřebujete dát tyto dvě znalosti dohromady.
Aha, tak to funguje s, s generovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Jo, jasně, probereme to.
(PERSON6) Jo, takže je ještě něco jiného, [PERSON2], co máte?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji trénink německého ASR, které může být použito pro časové razítko.
Nejsem si jistý, jak dobré to bude, protože se to snažím dělat na (Libry) Speech.
A, i když, když jsem to stahoval, tvrdili, že to má více než 600 hodin.
Ale pak trénink říkal, že skutečný tréninkový soubor obsahoval jen kolem 300 hodin.
A já si stále nejsem jistý, jestli těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo češtině jsem pozoroval strmější převody.
A teď se to nepřevede tak rychle.
Takže, když si vezmeme nějaké vzorky během tréninku.
Pak jsou tam stále nějaké vážné chyby ve výstupu ASR.
Takže doufám, že pro časová razítka je to dost dobré.
Nebo bychom to alespoň mohli zkusit.
(PERSON17) Dobře, to je dobře, jo.
Tak jsem začal, ale myslím, že jsem vám nikdy nedokončil e-mail, protože jste mi připomněli, [PERSON8], že vaše filtrování nadávek ještě není integrované.
A myslím, že je to také důležitá zpráva pro [PERSON5], který opět zmizel z hovoru.
Takže, důležitá zpráva je, že ano, je velmi dobře, že aktivně tlačíte na to, aby vaše výsledky byly integrované, a všichni by tak měli činit.
A zároveň potřebujeme mít nastavení, abyste ho mohli skutečně integrovat a otestovat sami.
Takže tomu říkám „integrace do-it-yourself“.
Takže, [PERSON8], při práci s [PERSON5] a při dokumentování, jaké jsou nastavení, ujistěte se, že je dostatečně dobře testováno kolegy, jako [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykových modelů a všemi ostatními.
Takže, kdykoliv někdo vyvine novou užitečnou komponentu, mělo by mu být celé potrubí přiměřeně snadno přístupné, takže si ho může otestovat sám.
Takže, tato integrace do kutilství je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a nechcete být přetíženi.
Takže, chcete poskytnout těmto lidem vstupy a výstupy jako první testovací přístup, který už byl proveden.
[PERSON4], že?
Filtrování nadávek, bylo testováno na protokolech?
Myslím, že bylo.
(PERSON8) Jo, bylo testováno na protokolech, myslím.
Takže, teď je čas to vyzkoušet na živých ropovodech.
A znovu, myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] spustil pro sebe některé z pracovníků a živě přehrával některé problematické soubory jako použití [PROJECT8] nebo cokoliv jiného.
Jednoduše je přehrajte.
Sledujte zvukový výstup na vašem stroji a uvidíte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité to nejprve odladit, pomocí souborů protokolu, a pak je důležité to odladit v ropovodu.
A pokud toto odladění může provést autor této komponenty, zde, v tomto případě [PERSON4], by to bylo nejefektivnější pro nás všechny.
Takže, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou integrace typu udělej si sám.
(PERSON17) Jo, takže pro multiakcentovanou angličtinu.
Takže my to teď [PERSON14] dáváme dohromady jen do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a bude to dělat napříč různými mluvčími.
Takže to budou opravdu vícemluvné věty, a proto by se také mohla zlepšit robustnost vůči různým akcentům těchto mluvčích.
Aha, takže to je jeden částicový experiment.
A později můžeme udělat něco víc s tou věcí s multiakcentem.
Takže tyto nové věty se vlastně pokusí vyřešit dva problémy jedním experimentem.
Jeden problém je implicitní jazykový model.
Takže systém ASR musí vidět největší možnou sadu vět.
A my vytvoříme nové věty z textového jazykového modelu tím, že k tomu přidáme zvukovou část, takže jazykový model bude pro ASR lepší a robustnost vůči různým mluvčím bude také lepší.
A ve včerejší přednášce jsem slyšel další nápad.
Bylo to během tréninku.
Vypouštěli ze zvuku časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech a to také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoliv jiný může pracovat na té věci s cizím přízvukem.
Ok, pak další věc, kterou jsem si všiml je – je to v pondělním testovacím dokumentu.
Je to čtyřikrát zvýrazněné.
Takže, když probíhá nějaké sezení, potřebujeme jména a terminologii pro toto sezení.
A my to potřebujeme sbírat, připravovat ručně, nějak to vytvořit.
A toto ruční vytváření by mělo být podporováno automatickými nástroji, jak je to jen možné.
Takže, je v tom určitá dovednost b, kterou je třeba procvičit.
Takže, jsem docela zručný v míchání textových souborů.
A kdykoliv vidím kohokoliv z vás, jak to dělá, pak mám rád vždy v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš účel, ale alespoň byste to měli zvážit.
Takže tam je tato dovednost něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jediná osoba pro to by mohla být [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, datovým chroupáním, prosím, řekněte to.
A pak potřebujeme -
Takže, jakmile jsme zabezpečili slovník pojmů a bez ohledu na výslovnost slova, potřebujeme techniky, jak tyto slovníky použít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal pro všechny relace, byl, že to nebylo opravdu vidět v hybridním ASR.
Takže, jedna taková relace se bude konat opět toto pondělí.
[PERSON9] již zahajuje sběr dat, ale byl bych rád, kdyby přínos této adaptace domény byl v v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Kdybyste se vy tři mohli sejít a dvakrát zkontrolovat, co [PROJECT5] dělá s -
Není to [PROJECT5], vlastně, adaptace domény je pro sadu nástrojů [PERSON18], že.
Takže se díváme trochu do minulosti a ujišťujeme se, že starý přístup funguje.
V současné době je absolutně nemožné udělat nějakou doménovou adaptaci pro plně neurální ASR.
Takže to, co zvažuji, je mít nezávislé vyhledávání klíčových slov ze zvuku a nějakou slučovací proceduru.
Takže bychom mohli mít dvě ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak doménově upravené nastavení [PROJECT5], které se používá pouze k vyhledání klíčových slov.
A když vidíme klíčové slovo ve verzi uzpůsobené doméně, pak bychom použili tuto větu z [PROJECT5], která je obecně horší, ale obsahuje správné termíny.
To je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a dělat různé experimenty na finetuningu a tak.
Takže jsme to probrali s [PERSON14].
A [PERSON14], je nějaká novinka od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je tu někdo další, kdo by byl na to zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže, je to něco, co by bylo opravdu dobře přijato obecně jako jako papír, protože lidé to zatím nedělají.
A to je v dnešní době ten nejnaléhavější problém.
Takže bychom tam opravdu mohli něco ovlivnit.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat k tomu v současné době používáme, protože, například, když zkontrolujete jako [ORGANIZATION4] modely na [ORGANIZATION5], že jsou jako už docela dobří v těchto věcech -
(PERSON6) A myslím si, že kdybychom prostě jen jako -
Mohli bychom z nich asi jen získat data, protože máte jako takovou velkou sadu videí v podstatě s různými doménami a různými mluvčími rodnými jazyky na [ORGANIZATION5].
A já jsem měl nápad, že bychom mohli použít nějaký nástroj ke stažení v podstatě nějaké druhy filtrovaných videí z [ORGANIZATION5] a udělat z nich tréninkové testy.
Takže to mám v plánu udělat sám.
Mám v plánu tam jít, ale potřebujeme záložní osobu.
A také, pro událost [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, archiváře, abychom to sezení znovu neztratili.
A důležitější a stále přetrvávající téma k práci je šplhání po žebříku.
A tady v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generované a které by rostly.
Myslím, že by bylo asi nejjednodušší dát tabulky jen jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnoceny po každé nové hodnotící kampani.
Může být obtížné tyto tabulky připravit.
Tak jsem se zeptal [PERSON7] a [PERSON7] bohužel nebudou dostupné během této výzvy.
Aby nám řekli, zda [ORGANISATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli by nám to pomohlo nebo ne.
Dobře, takže [ORGANISATION242] není [PERSON7] doporučeno.
Takže jednoduché html je pravděpodobně cesta, kterou se musíme vydat.
Takže jakmile [PERSON2] bude mít tato hodnocení m vyčištěná.
To znamená přesunout těch pár skriptů tam, kam patří z [PROJECT3] testovací sady a nějakého automatického spouštěče.
Pak také prosím vytvořte konverzi z tabulek do html podobnou konverzi tech a pak tyto výsledky pravidelně vkládejte na svou webovou stránku.
Nebo co byste mohli dokonce udělat je, že budete mít kompletní git check out přímo umístěný v této veřejné html nebo singling z této veřejné html.
Tak, že by to bylo okamžitě přístupné přes web a kdokoliv by se mohl podívat na aktuální skóre a prozkoumat to.
Takže, to by bylo užitečné, zejména pro m lidi mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají jako -
Výkon byl špatný pro některé soubory, a oni mohli přímo m procházet na webu m.
Mohli by to také procházet ve skutečnosti na [ORGANISATION101].
To je na vás nastavit tak, aby to bylo uživatelsky přívětivé a snadno sledovat.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji, nebo se dostat k aktualizaci, demo papír podání, který má být příští pátek, pokud se nemýlím.
A pak mám nějaké projektové zprávy dělat a začínám sbírat dokumenty – jako, nebo odkazy na dokumenty, ne dokumenty samotné ještě, pro dvě sezení.
(PERSON11) <parallel_talk> Také pro ASR bychom měli přidat doplňkovou metriku -
Vlastně více bychom měli přidat doplňkovou met- tyto doplňkové metriky. </parallel_talk>
Zmínil jste tedy jednu a to je filtrování nadávek m vyhodnocení.
Takže <parallel_talk> mají explicitní seznam věcí, které se nesmí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A pak vyhodnocení vzácných slov.
A tady máme explicitní seznam jmen a pojmů, které chceme ve výstupu objevit, bodované ne jednoduše podle (pořadí) sazby </parallel_talk> ale bodované něčím, co tyto věci přímo popisuje, že?
Ano, takže naprosto souhlasím.
To zahrnuje také manuální přípravu reference.
Takže, <parallel_talk> oba potřebují manuálně vytvořené reference. </parallel_talk>
Mám jednu poznámku z [PERSON1].
Takže <parallel_talk> [PERSON1] sestavila nějaký překladatelský slovník.
A měla by ho brzy sdílet. </parallel_talk>
Takže by se to mohlo stát prázdnou částí druhé věci vzácného slova -
Takže <parallel_talk> tohle by bylo vzácné vyhodnocení slov pro MT a pak z [PROJEC210] bychom také pravděpodobně dostali nějaký slovník. </parallel_talk>
Takže to by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat, abyste revidovali doménu <nesrozumitelné/> a vytvořili takový slovník pohledem na výstupy a na to, co ve výstupech chybí.
Takže, jako shortlisting – výpis slov, která se nám líbí, a nelíbí se nám v doméně <nesrozumitelné/>.
Dokázali byste to?
(PERSON11) Mělo by to být proveditelné, tak to pojďme zkusit.
Bylo by to jako – bylo by skvělé, kdyby se vám to podařilo.
Takže, napíšu si to.
Takže, <parallel_talk> míří k termínu [ORGANISATION62] s podtitulkovou studijní prací. </parallel_talk>
Ano <parallel_talk> a pak multi-source s [PERSON7] nebo na základě [PERSON7] nebo – </parallel_talk>
A co se týče ID jazyka, jsem zvědavý, jak ho chcete přesně integrovat, protože už zahrnuje zvažování více ASR zdrojů, více kanálů, tak jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude to audio na textového pracovníka a bude vysílat časová razítka jako pro čtyři nebo dvě sekundy okno a třídu.
<nesrozumitelné/> ticho, čeština, němčina, angličtina, a pak dám ostatním, jak to chtějí použít v potrubí.
(PERSON11) To je důležité.
Prosím, napište to sem do dokumentátoru toto <nesrozumitelné/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], no a také možná [PERSON5].
Pokud máme tento nástroj, potřebujeme (poslat) zvuk více ASR nebo více pracovníkům <nesrozumitelné/>
Budeme zvlášť potřebovat (poslat) zvuk do anglického ASR, odděleně do německého ASR a českého ASR, například v závislosti na <jiný_šum/>
A také, do tohoto jazykového ID pracovníka a pak potřebujeme sloučit tyto výstupy, a to je nástroj, který zatím nemáme.
To je vícezdrojový nástroj, který bude pozorovat textové výstupy a také sledovat časová razítka a bude vysílat – pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby ASR bylo tiché, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem vymyslel tento typ nastavení.
Další nastavení by bylo, že stejný zvuk je dodáván do ASR a tohoto jazykového kontrolora.
Tato jazyková kontrola je v podstatě součástí ASR, umlčuje ASR, pokud je to špatný jazyk.
To je také možnost.
Takže musíme přijít na to, který způsob integrace ID jazyka je nejlepší pro naše účely.
Takže, prosím, přemýšlejte o tom dál jako o tom, co jsou naše potrubí.
V ideálním případě si myslím, že nejméně jako zmatky v řízení a tak dále by vznikly, pokud by naše modely MT byly vícejazyčné.
Pokud by podporovaly různé zdrojové jazyky a překládaly by z některého z těchto jazyků do angličtiny.
Možná by dělaly jen kopii, pokud by byla angličtina zadána jako vstup, tak bychom měli vícejazyčné vícejazyčné ASR na začátku.
Všechny jdou do angličtiny a pak z angličtiny půjdou do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, tak by toto ID jazyka ani nebylo potřeba.
(PERSON3) Jde o to, že pokud děláme analýzu korektněji, jedna věc je možné kontradiktorní vyhodnocení, jen abychom naznačili, že omezení mají vlastně vliv na skutečný výstup.
Že by to bylo hezké a jo možná analýza pozornosti.
Ale nejsem si jistý, jestli by nám to mohlo dát stejné odpovědi, v podstatě, jestli se model zúčastňuje nebo nevěnuje omezení.
(PERSON4) Musel jsem se podívat jen na pár příkladů pozornosti, nedělal jsem žádné statistiky nebo tak, a podívá se to na omezení, a když to přeloží omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti v tomto smyslu žádné nedělá.
Dělá to nějaké obecné chyby v překladu, ale ne ty (jevy), které se snažíme vyřešit.
No, když se vrátím k automatickému vyhodnocení, problém s nesouladem je, že výstup je správně inflected, ale kontext je jiný.
Tudíž to není stejná slovní podoba jako v odkazu, že?
(PERSON4) Jo, ale také jsem zkontroloval, jestli kontexty jsou platné překlady a ve většině případů jsou.
Jako v prvních 100 příkladech, které byly označeny jako chyba automatickým vyhodnocením 91 z nich bylo správně inflected ve správných kontextech.
(PERSON4) A myslím, že jen dvě nebo tři věty byly správně inflected v nesprávném kontextu, jako že překlad byl špatný.
A pak jsou některé případy, kdy překlad byl úplně špatný, protože věta byla opravdu špatná a část musí být <nesrozumitelná/>, ale to byl jen jeden nebo dva případy.
(PERSON3) Ale vy se snažíte srovnat diverzní formuláře, když to vyhodnocujete, že?
Neděláte žádnou-
(PERSON3) -lemmatizaci odkazu a-
(PERSON4) Oba, oba, oba, já se shoduji jak povrchové formy a lemma.
(PERSON3) Aha, aha, aha, to jsou ty dvě skóre, že?
(PERSON4) Je to jen dilema skóre pro (Evropana?) není v tabulce, protože tabulka jako se nevejde do papíru, takže <nesrozumitelné/>
Pokrytí je vždy jako 97 procent.
Prostě generuje správné lemmy, jen-
(PERSON3) Jo, dobře, chápu to, chápu to.
Takže v podstatě lemma pokrytí říká, zda omezení je tam, a rozdíl povrchového pokrytí naznačuje, že by mohlo být nesprávně inflected, ale to není tento případ.
(PERSON3) No jo, jen nevím, jestli jste, jestli jste chytili <nesrozumitelné/> když jsme mluvili o [PERSON1],
ale jedna věc, je, že, že (rána) je lepší, ale druhá věc je, že lemmy jsou ve skutečnosti správně zasazeny ručně,
ale to je, že je další, ne, žádný problém, je to vlastně dobré, že je <nesrozumitelné/> správně, jo.
Tak jsem si myslel, že by mohlo být.
Ale nejsem si jistý, jestli na to máme nějaká testovací data, ale mohli bychom se pokusit pohrát si s modely s nějakým stylovým přenosem?
Jak víte, můžeme použít omezení a zkusit místo toho použít synonymní omezení a vidět nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to popsal jen neurčitě, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakých datech přenosu stylu pro anglickou češtinu? Máme něco?
(PERSON4) <nesrozumitelné/>
(PERSON1) Přenesením stylu, Dušane, myslíte, že by tam bylo něco, co je v psaném jazyce, a vy byste byl cílová strana, bylo by to v mluveném jazyce nebo něco takového?
(PERSON3) No, to je ta věc, že mám jen omezené znalosti o úkolu.
Ale umím si představit, že chcete přepsat větu, že to není psáno mužem, ale je to psáno ženou místo toho nebo, já nevím, jako že můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámen s přesnými datovými soubory a s tím, co pokrývají.
A myšlenka je, že styl vět je dost vágně definován.
Takže znovu, ne tak jistý.
(PERSON1) Máme tento korpus větných transformací.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například udělat věty obecnější.
Takže detaily jsou vynechány, věta je zjednodušena, a pak aby věta zněla hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení, Matous dělá nějaký experiment s angličtinou-češtinou, ale nemáme tam žádná referenční data.
Takže nemáme žádný datový soubor komprese vět.
Takže možná zobecnění by mohlo být zajímavé, ale obávám se, že je tam příliš mnoho různých dobrých zobecnění, takže ta jediná referenční by byla příliš omezená na to, aby vám řekla něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných proměn pohlaví, například, tohle by mohlo být provedeno <nesrozumitelné/> pro češtinu, takže možná tou správnou osobou by byl Rudolf Rosa, který by se ho zeptal, jestli někdy vygeneroval nějaký takový datový soubor.
Takže, bude existovat kořenové generování nějakého větného protějšku.
(PERSON3) Myslím, že to je vlastně jako zajímavá otázka, jestli můžeme použít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit určitou podčást testovací sady [PROJEKT1], která by to pokryla.
Ah, takže někdy známe pohlaví mluvčího, takže pokud jste... možná budu sdílet obrazovku a prohlížet si to.
(PERSON8) Nebo jsem to zkusil s Marianem, který to jen navštěvuje a je to... Nevím, o kolik BLEU bodů níž.
(PERSON2) Protože stejně jako věřím, že Martin dělá svůj <nesrozumitelný/> malý překlad, tak překládá více vět najednou a pak vybere jen tu středovou a jde takhle na celý dokument.
Takže kontext je jako v jedné <nesrozumitelný/> společně s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím – nebyl to Dominik, který dělal nějaké experimenty s Ivanou?
Myslím, že minulý rok nebo dva roky před dvojitou prázdnotou, kde navštěvovali kontext nebo spojovali kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale s tím spojováním není úplně jisté, jestli to má stejný efekt jako nastavení multi enkodéru-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje naplno.
(PERSON8) Jo, dobře, promiňte, možná bych měl být správnější, že to nefungovalo tak, jak jsem to udělal <smích/>
(PERSON1) Jo, protože si myslím, že je to metoda, která se dá velmi snadno otestovat, a vždy by se měla testovat v kontrastu se dvěma enkodéry, a očekával bych, že někdy to bude lepší a někdy horší než nastavené dva enkodéry, záleží na přesném úkolu, jako co přesně je druhá věc, kterou enkódujete.
Takže, možná když máte dvě kopie dvou parafrází stejné věty,
možná je to nějak matoucí pro pozornost, tak co, nevím.
Chování by také mohlo být jiné pro staré metody sekvence na sekvenci, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak možná s transformátorem je to jo, je těžší trénovat, takže možná potřebujete cokoliv zvýšit počet zahřívacích sad, zahřívacích sad.
(PERSON2) Jo, tak prostě vím jako-
(PERSON8) Nepamatuju si, takže si přesně nepamatuju, ale tohle je jako co-
když jsem v létě začínal s těmi vícezdrojovými experimenty.
První věc, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná já, už si to nepamatuji,
Můžu to zkontrolovat do další schůzky, jestli jsem to taky zkusil,
Určitě jsem to zkusil, když jsou zdroje na první pozici pak nějaký oddělovač a parafráze na druhé pozici.
Taky jsem mohl zkusit, že jsem ty dvě věci náhodně zamíchal, jo, a jen si pamatuji, že to dělalo hojně tyhle kompenetrační věci a zkoušelo vícekódování.
(PERSON8) A bylo to pravděpodobně kvůli nízkým skóre.
(PERSON2) <nesrozumitelné/> které se vám líbí si můžete vylepšit skóre amenity tím, že jen připojíte výstup založený na frázích a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže jako bych vám věřil ale je překvapivé, že to nefungovalo.
(PERSON10) Takže, když zadáte výstup založený na frázích, který je v podstatě post editace, že? Můžete o tom přemýšlet jako o posteditování, jako byste posteditovali výstup založený na frázích, že? Nebo jako záleží na úhlu pohledu, že?
(PERSON1) <nesrozumitelné/> že to rádi plně přepisujete, ale technicky to odpovídá přesně úkolu posteditování, můžete to připojit jako řešení úkolu posteditování.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální token pro rozlišení, jako který je zdroj a který je kontext nebo druhá věta nebo je prostě zřetězíte bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Snažil jsem se, asi dva tokeny a jo jako, protože v první verzi jsme měli podezření, že by token mohl být také token sám, takže jsem to pak přehrál dalším tokenem, který není jen pro tento účel, protože jsme použili nějaký předem vyškolený slovník, a tento slovník neobsahoval oddělovače tokenů.
Takže jsem použil nějaký token, že jsem předpokládal, že to nebude jako tokenized do několika kusů a tak se to objeví jednou.
Neměl jsem žádnou záruku, že tento token se nemůže objevit na jiných místech ve větě a to je jediné místo, kde se to může objevit.
Takže by to mohlo být provedeno lépe, jo, souhlasím.
(PERSON2) Ale ta část s Flaskem nebo komunikační část s klientem je něco, co neumím.
Protože nemám žádné zkušenosti a nemám čas to rozběhnout.
(PERSON1) Myslel jsem, že to znamená něco s použitím neznámého mediátora.
(PERSON2) Ne, vytvořte HTTP klienta, který dokáže zaplnit frontu a číst z jiné fronty.
A pošlete text zpět v HTTP požadavku.
Protože moje představa je, že uživatelské kliknutí bude použito i v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, pošlete zvuk v malých kusech ve stejnou dobu.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dejte do fronty, se kterou budu frontu později obsluhovat (ASR).
A model udělá nějakou logiku, nějakou dedukci s tím.
A kdykoliv bude mít nový kus přepisu, pošle ho zpět, a uživatel by měl dostat částečný přepis zpět.
A měl by být okamžitě zobrazen v textovém poli.
(PERSON1) O tom bych mohl přemýšlet.
Prostě Flask taky moc neznám, ale jo, o tom můžu přemýšlet.
(PERSON2) Oh možná jiný HTTP server.
Nevím, možná na to ani nepotřebujeme nóbl HTTP server.
(PERSON1) Myslím pro tok textu, používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo na tohle.
(PERSON2) Jo, jediný požadavek je, že by to mělo zvládnout více připojení najednou.
(PERSON1) No myslím, že online tok textu je něco kolem 2 000 minimálně.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochou různých interních pracovníků, takže mám na mysli, jo, takže mám <nesrozumitelný/> řekněme deset, no místo výstupu, soubor od <nesrozumitelný/> vedlejšího pracovníka, takže <nesrozumitelný/> který máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
(PERSON1) Oh, to by nám ušetřilo čas.
(PERSON7) Jo, jo, tohle je velmi důležité vlastně všechno paralelizovat, paralelizovat jak zpracování systémů, tak i vyhodnocení buňky DF, protože by to potřeboval spustit mnohokrát, budou tam chyby, musíte to rychle znovu spustit.
(PERSON7) Dobře, takže díky.
Takže, jste s tím velmi zaneprázdněni, nechci na vás dávat žádné další věci, takže začnu s připomínkami.
Potřebujeme dokončit popis [PROJEKT1] stolní sady,
Koho to tu máme?
No dobře, ne opravdu, jo, (je to hotové) a to tu bohužel není.
Takže, to by bylo pro [PERSON2],
Pak hodnocení, to je pro [PERSON1], ale o tom jsme mluvili.
Poslouchejte, dejte mi tabulku v DSD pojďme dát tenkou čáru sem a tlačit šablonu tabulky, jako je struktura plánu do delebl teď, takže čísla přijdou později, ale chci vidět nějaká čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuji.
Máme [PERSON5], to je dobré.
Takže, pro [PERSON5], chtěl bych zkontrolovat, jaký je pokrok v hodnocení systémů, a zda jste v kontaktu s [PERSON1] také pro vývoj, který je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak vymyslíme, které balíčky nainstalovat do prostředí Petri.
(PERSON7) Jo, takže je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte odděleně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a posbíráte všechny výstupní soubory, a pak spustíte vyhodnocení.
A důvod tohoto rozdělení je, že můžete více paralyzovat.
Takže, určitě se objeví problémy na různých frontách, a čísla budeme potřebovat velmi brzy.
Takže, pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále nechat běžet překlad pro ty zbývající,
a přehodnotit, se sel T F, ty chybějící, a tak dále.
Takže, jde o to, že nejde o vytvoření sériového, sekvenčního zpracování, které by zahrnovalo obojí,
ale jde o to získat výsledky, a je vlastně lepší to udělat v řezech.
Nejdřív dostat všechny výstupy, pak dostaneme všechna hodnocení.
(OSOBA) Jo, takže, myslím, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Jako odfiltrování paprsků a nahrazení paprsků různými paprsky.
A pro jako multi-token omezení a podobné věci.
Ale pro pozitivní omezení, jsem jen porovnal tréninkový přístup s jo jen s touto velmi jednoduchou věcí.
Jen modifikace skóre v každém kroku stejným způsobem.
(PERSON7) Dobře, takže zpět k pozitivním omezením.
Už jste se zaměřil na analýzu systému?
(PERSON2) Jo, právě teď, jsem trochu čekám na datový soubor přepracování z ([PERSON9]).
Také [PERSON9] Podíval jsem se na (kód), a myslím, že vím, proč je to tak pomalé.
Protože pro každý záznam v terminologii v (Europar) přepracování, otevřete datový soubor, tokenizujte ho, přečtěte ho řádek po řádku, tokenizujte ho řádek po řádku a pak ho zavřete.
Ale vy jen děláte, že -
(PERSON4) Tak, pamatuji si, že pro [PROJEKT1] jsem to dělal z loňského roku z nějaké chalupy v horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím předložit.
A <smích/> tak to je také něco, co se stane [PERSON8] Obávám se, že by mohl být...no, žádný večírek, ale možná na tom vzdáleném večírku.
A pak by si najednou uvědomil, že to musí předložit.
Takže, v tu chvíli nebude žádná recenze jako v tomto bodě. <smích/>
Prostě by vzal PDF a nahrál to tak. <smích/>
(PERSON7) No, dobře.
Tak, Jo, zkontroluji 21., a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že bude lepší poslat jim e-mail hned teď a jen se předem zeptat na ten odkaz.
(PERSON7) Dobře.
(PERSON4) Jo díky.
(PERSON7) Máme dnes ještě nějaké další problémy k projednání, nebo je to všechno až do Nového roku?
(PERSON6) Doufám, že tam pro mě nic nebylo?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo nástrojové papíry, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálními jako tam byly také PBML problémy, které míchaly prázdné okrajové papíry a oddělené papíry kvůli počtu těchto papírů.
A dokonce jsme měli věc, jako když papír nebyl dost dobrý pro PBML, ale když byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další číslo PBML.
Takže, máme, i jak jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, publikujte ho na MT maratonu mezi lidmi.
Ale váš papír je příliš špatný.
Musíte ho vylepšit, a dostanete se jen k dalšímu PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že zkoušení SIGDialu přilákáme tak trochu lepší účastníky.
(PERSON3) To je ano, to je... jak jsem si myslel, že jsem také měl, ale neznám ani jedno z míst.
V červenci mají finální papírovou registraci.
Takže, konference byla v září a papírové podání bylo v květnu.
Protože pro Interspeech bychom to také mohli rozdělit papír po papíru.
Aby některé papíry šly do řízení Interspeech.
A některé z našich podkladů by přišly později do řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď se SIGDial nebo Interspeech.
Pokud je v pořádku, aby měli některé naše podklady, vzhledem k tomu, že tyto podklady jsou odevzdány v březnovém termínu.
Takže je tu absolutní striktní požadavek.
A myslím, že proti tomu nemohou nic mít.
Protože pokud ten papír stojí za to vydat.
Jako, je to jen bonus, že ten papír má nějaký sdílený výsledek úkolu, který se objeví v satelitní události.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o speciální zasedání.
V Interspeech se tomu říká speciální zasedání, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít váš papír připravený v Interspeech termínu, pošlete ho jako Interspeech papír a budete ho mít v Interspeech.
Ah, pokud to neuděláte, ah, udělejte to v Interspeech termínu, tady je náš termín.
A to je pro PBML.
(PERSON7) Ah, okay.
Ale ta věc je jako pro Interspeech satelitní událost.
Erm, Interspeech jako se nedostane do žádného řízení.
(PERSON2) Můžete si myslím, že můžete prostě můžete rezervovat celý semestr jen na kurzy [PERSON9] a budete mít hodně práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že to opravdu není věc propadnout v jeho kurzech.
Jako propadnout, protože nejste schopni to dokončit.
Samozřejmě, jako lidé to prostě vzdávají, ale myslím, že je to možná z jiného důvodu, že prostě není možné projít.
Myslím si, že je to určitě možné, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám řekl na začátku semestru, že dobře, když chceme jedničku (??) dostanete jedničku.
Právě v druhém termínu, byste ji měli odevzdat.
To je v podstatě jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů předchozích let, mnoho lidí to nedělá.
Zjišťují, že je pro ně jednodušší číst na zkoušku.
Ne, promiňte, učte se na zkoušku-
(PERSON2) Jo, protože dobře obecně, jeho zkoušky jsou poměrně snadné.
(OSOBO2) Takže bych neřekl, že je to super jednoduché, protože jsou některé kurzy, kde je zkouška jako zábava.
(OSOBO1) No, jeden z nich byl včera pro mě.
(PERSON2) Jo, když to má krátký kontext a protože dělám rozhodnutí na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se to opravdu zaváže k něčemu, co například za sekundu nebo dvě, přijde na to, no, vlastně to byl špatný překlad.
Takže se to snaží použít jinou formulaci.
Například specifikovat tu věc.
Takže vlastně se mi to opravdu líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když jste mohli vidět, že model udělal chyby na první pokus, opravdu to chtělo udělat nějakou korekci.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i trochu nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita kvůli překladu, pokud si přečtete všechno, tak dostanete stejné informace, ale formulace je prostě špatná, protože použila například více slov a použila nějaké korekce a tak.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádnou informaci.
A pro které jazykové dvojice máte tyto výsledky, jako nějaké příklady?
Protože bych se na to rád podíval, jen tak ze zvědavosti.
(PERSON2) Oh určitě, můžu vám vyhodit mé záznamy.
(PERSON7) Ale ve kterých jazycích?
Protože víte, že nemluvím německy.
(PERSON2) Anglicky a německy.
(PERSON7) Jo, ale já nutně nemluvím německy <smích/>.
(PERSON2) Pak mohu poskytnout anglicko-čínsky a anglicko-japonsky, pokud to pomůže <smích/>.
(PERSON2) Takže znovu, mám na mysli, aby to bylo lidsky čitelné.
Protože tohle blikání je opravdu otravné a pak se přestanete soustředit na to, co bylo skutečně řečeno, protože to je možná také otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Promiňte, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoliv vidím slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš taška.
Takže dám slovo do tašky.
A rád spojuji věci v tašce, abych získal celkový obraz toho slova.
A myslím si, že to je ten problém s blikáním.
Když něco přeložíte a pak to změníte, pak už jsem to vlastně četl, je to v mém mozku.
A pak ztratím soustředění a kontrolu nad tím, co bylo vlastně tehdy přeloženo jako správné a nebylo to, co nebylo.
Takže proto si myslím, že celá ta věc s blikáním je špatná a hloupá už z definice.
Jako vidím motivaci, jako že chcete zobrazit všechno, co máte.
I když nemůžete slíbit, že je to dobré.
Ale myslím si, že nemůžeme pracovat s těmito informacemi navíc.
A myslím si, že problém je možná v tom, že systémy jsou vytvořeny lidmi, kteří s tím pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, pořád to ukazuji a je to nějak dobré, ale myslím si, že vývojář se doopravdy nesoustředí na samotný obsah.
A jak vnímáte obsah, ale spíše to, že, no jo, můj systém to umí opravdu rychle vygenerovat.
A i když to jen hádá, že kvalita je v pořádku, myslím, že možná proto byl vytvořen retranslace.
Prostě vývojáři systémů jsou dychtiví zobrazovat informace, a myslím si, že protože jsme omezeni v tom, jako je objem informací, které můžeme vnímat nějaký čas, rádi vidíme, že informace navíc jsou pro nás jen další zátěž.
Takže si myslím, že není dobré ukazovat něco navíc.
Jako když chcete snížit latenci, tak místo blikání prostě snižte kvalitu.
Myslím, že je to pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste potřebovali vidět nestabilní hypotézu, opravdu?
Jako z uživatelské perspektivy?
(PERSON1) Jako technicky, když začnou překládat lidské překladatele, myslím tím cíl, který je i pro anotátory, snažili by se sledovat řečový řetězec původního řečníka.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatně, tak by se prostě opravili.
(PERSON2) No ale jo to znamená s mým řešením, jako byste nedělali blikání, ale zavázali jste se, jako že neexistuje způsob, jak to změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Mám silný pocit, že naše práce není zrovna v oblasti projevu, je nezdravá.
Protože zde neexistuje pojem projevu.
Pracujeme přímo na textu.
Ale věc se má tak, že návrh na statistický workshop v tomto roce je u konce, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel v roce 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme buď jeden ze dvou sektorů nebo interspeech, protože oba jsou v komunitě dobře známy.
Můžeme účastníky motivovat k tomu, aby se podřizovali.
Ah, jediná námitka, kterou teď nacházím, je, že pokud jde o interspeech, tak nám neumožní prostor v řízení, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšeni, když budou publikovat práci v archivu.
Takže v archivu mohou lidé publikovat kdykoliv, ne?
Takže to není přínos pro jejich profily.
Takže jak motivovat účastníky, aby se připojili k našemu společnému úkolu.
Takže, to byl důvod, proč jsem se zvlášť zaručil za mimořádné zasedání.
Ale tentokrát, problém je, co mohu pochopit je, že naposledy, časové období mezi návrhy, podáním a konečným podáním papíru bylo pět měsíců, takže by to bylo dost času pro náš rozvrh, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vnímám jako důležitý možný zdroj nerodilé anglické řeči, kterou můžeme využít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na hlasovou soutěž Clearest a můžeme dělat stánek, když budeme muset.
Ale to bych chtěl omezit, protože šíření do středoškoláků je pro nás menší dopad.
Důležitější je použít to jako testovací sezení.
Takže bychom se měli soustředit, [PERSON1], na [PROJEKT2] Clearest hlas, a udržet pořadatele spokojené, abychom tam mohli dělat sběr dat.
A dělat to, co po nás chtějí výměnou za to, a my potřebujeme zkontrolovat jejich plenární program, a jaký typ titulkování by byl pro tento plenární program užitečný.
takže by to pro nás bylo testovací sezení, a co se týče naší vlastní přítomnosti na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud se nás zeptají, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, tak dobře, ale pokud ne, pak si myslím, že je pro nás rozhodně dobré být za oponou a v zákulisí a dělat tam svou práci.
(OSOBA) Jo, ještě jsem se na to nepokoušel udělat registraci, ale myslím, že minule bylo povinné mít stánek.
(OSOBA) Ano. Takže s nimi proberte, co je potřeba, aby byli šťastní, a oni nám umožní dělat hlas Nejčistší, což je ta nejdůležitější věc.
Zkušební zasedání je méně nutkání.
A stánek je jen něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se připojili k sezení dříve, než dělat takové věci.
Takže opravdu potřebujeme procvičit tyto přípravy.
S on-line světem to vypadá, že prostě j p do sezení, a práce je hotová.
Ale to není tento případ.
Vždy trvá 30 minut, než se to rozběhne a správně připojí.
Takže, musíme tam být dříve.
A pokud nějaké sezení, které děláme, začíná v devět, ale organizátoři se sejdou ve tři čtvrtě na devět.
Pak musíme přijít už ve čtvrt na osm, abychom měli 30 minut navíc, abychom se ujistili, že vše běží a naháněli lidi.
Takže, toto je poznámka pro všechny, že aby vedení pracovalo, prosím také předvídat, co by vás vedení mohlo najednou požádat, abyste udělali, a to by trochu pomohlo.
Další zpráva, která je velmi důležitá, je nahrávání těchto důležitých sezení.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké- nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJEKT4] a [PROJEKT5] 2020.
A první bod této zkušenosti je, že jsme byli velmi špatní v nahrávání těchto sezení.
Takže, je důležité pro účely dalšího vyhodnocení nebo analýzy toho, co se pokazilo, mít dobré nahrávky těchto sezení.
A jedním aspektem je získat souhlasy, aby nám bylo skutečně umožněno nahrávat.
A to i když se snažíme získat souhlasy zpětně nebo jakkoli.
Pak je tu technický aspekt- nahrávání.
A viděli jsme, že je to tak různorodé a složité.
Jo, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citróny v řadě :(
Objednala jsem si od této firmy, protože jsem ji koupila v předchozích sezónách a skvěle nám vyhovovala.
V této sezóně jsem si koupila další velikost, kterou jsem potřebovala.
Jedno z pyžam, které jsem dostala, mělo díru na patce pyžama.
Vrátila jsem ho a firma mi poslala nové.
Náhradní pyžamo, které měl jednou můj syn, jsem si dala do pračky jako vždy a zip se ulomil!
Jsem tak zklamaná, protože nemám čas řešit reklamace každých pár dní a přesto se to právě teď děje.
Přesně jak je popsáno
Jedná se o základní puffer kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuovém neprodyšném sáčku, takže je potřeba ho na pár dní pověsit, aby se uvolnily vrásky a trochu se „nafoukl“.
Měřím 165 centimetrů a kabát je na mě dlouhý po kolena.
Objednala jsem si 2+ velikosti kvůli jiným komentářům a minulým zkušenostem a kabát je pravděpodobně o něco větší, než je potřeba.
Nicméně s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou manžety, takže je pravděpodobně přidám později.
Kapuce funguje, ale nejsou na ní žádné kravaty.
Přední zip funguje.
Na boku ani na zádech nejsou otvory pro větší pohyb, ale s většími rozměry bych měla mít dostatek místa.
V pase mám dvě kapsy (u vás mohou být vyšší nebo nižší).
Nejsou tam žádné ozdoby ani stylingové detaily – je to BASIC COAT.
Za tu cenu si myslím, že je v pořádku.
Měla jsem ho na sobě za větrného dne, ale ne za studena.
Necítila jsem vítr, takže to považuji za dobré znamení.
Nicméně jsem zvědavá, jak si povede v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem spokojená.
Vak vakuového těsnění lze znovu použít a prodejce k němu připojil opravdu roztomilé poděkování, což byl skvělý tah.
Tohle je velmi pěkná sukně.
Krajkový vzor je nóbl a měkký
Tohle je velmi pěkná sukně.
Krajkový vzor je nóbl a měkký.
Nemačká se, ani po nacpání do plastu a krabice byla velmi hladká, takže je to opravdu super.
Tohle se dá snadno obléknout dolů nebo vyšňořit a díky délce a střihu to má takový vintage nádech, což mě opravdu baví.
Myslím, že tohle by mohlo lichotit každému.
Měřím 175 cm a vážím 130 liber a objednala jsem si malé, takže bych řekla, pokud máte pocit, že jste uvízla mezi malým a středním, rozhodně o velikost níž.
Nefungovalo to s mým Buickem LeSabre z roku 1999
Položka dorazila rychle a vypadalo to, že je v dobrém stavu, a to i včetně předinstalované baterie.
Nicméně, i když to mělo být kompatibilní s mým Buickem LeSabre z roku 1999, ovladač se nepodařilo naprogramovat nebo synchronizovat s autem.
Pokyny jsou celkem jednoduché a já vím, že jsem se jimi řídil správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý ovladač.
Tento nový však nefungoval a tak ho budu vracet.
Nebyl žádný problém s prodejcem nebo servisem, jen se zdálo, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta byl utržen velkým něčím, co letělo po dálnici, takže jsem potřeboval náhradu.
Po přečtení několika recenzí jsem se bál, že by mi tohle nesedělo, ale bylo to perfektní!
Vlastním Corollu LE 2013.
Sám jsem si ji nenasadil – udělal mi ji jeden chlápek z karosárny – ale vypadalo to opravdu jednoduše.
Prostě se to za necelých 5 minut hned zapnulo.
Dal jsem tomu 4 hvězdičky za bytelnost, protože to opravdu vypadá dost chatrně (čas a létající trosky to prozradí), ale přes to všechno jsem velmi spokojený, že moje auto už nemá na předku otevřenou tlamu a že cena byla rozumná.
Potřebuje vylepšit
Super úžasné světlo Mému 5letému absolutně zbožňovalo toto světlo Netrvalo dlouho a dostal ho v lednu k narozeninám je únor už má problémy s tlačítky a neběží jasně se zásuvkou spolyká baterie dokonce zkoušel dobíjet baterie Super cool, ale potřebuje vylepšit
Hudební start
Klavír je skvělé předkrmy!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci rukou a očí.
Klavír není jen hrací hračka, ale ve skutečnosti funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby se vaše dítě stalo budoucím klavíristou, měli byste tento produkt vyzkoušet!
Za ty peníze to stojí!
Dávám si to na nos podle pokynů dvakrát denně a 2 minuty si to vtírám.
Kůže na nose mi zčervenala a byla úplně odřená.
Docela mě to zarazilo.
Měl jsem dobře zahojenou jizvu po pádu do ostnatého drátu z doby před lety.
Nejen, že tento přípravek nefungoval, ale málem jsem skončil u dermatologa, nicméně když jsem dal aqua-for a obvaz přes celou oblast, tak se to asi po týdnu konečně uklidnilo.
Nos mám sice ještě zčervenalý, ale doufám, že to brzy přejde.
Někdo podělal vzorec??
To je tak divné.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí malířské tyčinky od jiné značky, takže můžete vidět, jak by měla růžová vypadat a vědět, že to není jen můj foťák.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaný.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl jim říkat červená nebo růžová.
Bílá není tak jasná, jak bych doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyhle barvy smyjí.
Jen jsem si myslel, že tam byla růžová.
Myslím, že fialová bude stačit.
většinou funguje
Před pár měsíci jsem si celou hlavu odbarvila a pak přebarvila černým barvivem.
Pak jsem šla a nechala si dát melír na celou hlavu.
O pár týdnů později jsem si na vlasy dala modrozelenou barvu Arctic Fox a ta už nevybledla.
Použila jsem to s přípravkem Olaplex č. 3 a ten TREMENDOUSLY po celém těle zesvětlil, odstranil zelenou a modrou část a také zvedl tmavou barvu na vlasy.
Nicméně po dni jsem si všimla zeleného odstínu na vlasech.
Každý den je to horší a už jsem použila extraktor barev dvakrát, se stejnými výsledky.
Moje vlasy také tmavnou tam, kde byla barva na vlasy.
To je skvělý produkt, jen se zdá, že nevydrží.
nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba mírnit nějakým realističtějším hodnocením.
Zkusil jsem si to přečíst, ale jazyk mi prostě připadal plochý.
metafora „sladkovodní“ a mnoho popisů dělohy jako řeky a dítěte jako ryby mi připadaly nucené, ošuntělé a vykonstruované.
Přeskočil jsem dopředu a vypadalo to, že jediné, co najdu, bude univerzitní drama.
Dávám této knize 10 hvězdiček!
Výborné čtení!!
Kniha se mi absolutně líbila!!
Za ta léta jsem adoptovala 4 siamské kočky od Siri a všechny z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri šla ve své snaze zachránit kočky (hlavně siamské)!!
Moc se mi líbí tohle svítidlo!
Za tu cenu je báječné a odvede svou práci!
Jediný problém je, že se žárovka zahřeje příliš rychle a světlo zhasne, takže ji musím vypnout chvíli počkat a pak ji zase zapnout.
Nemyslím si, že by se to mělo stát...nevím, jestli mám vadné světlo nebo co, ale je to moc pěkné svítidlo, kromě přehřátí.
Matoucí dějová linie
Kniha byla těžko držet krok s tím, jak to skákalo kolem hodně.
Také název nesedí příběh.
Autor uvedl, že několik lidí bylo infikováno tímto mimozemšťanem, nicméně vynechal může podrobnosti o tom, kdy nebo jak se to stalo.
Byl jsem občas zmatený a musel jsem se vrátit a znovu přečíst hodně, aby se ujistil, že jsem nic nezmeškal.
Miloval Collinse...
Chvíli trvalo, než si na Gradyho zvykl
3 1/2 Stars Remedy je bratrův nejlepší kamarádský románek stejně jako druhá šance románek smíchaný do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat všechno pro to, aby Collinse získal zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collins si myslel, že konečně dostává vše, o čem snila, svého bratra nejlepšího přítele... ale když se druhý den ráno probudila sama a už o ní neslyšela, věci se definitivně změnily.
Teď je Grady zpět a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdá.
I když jsem miloval premisu tohoto příběhu a občas mi Grady opravdu lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale ani neposlat Collinsovi dopis, ve kterém by se vysvětlil?
Nechat ji celé ty roky v údivu a bolesti a pak čekat, že ho přivítá zpátky s otevřenou náručí?
Měl halucinace?!
Collins měl pravdu, že byl naštvaný, naštvaný, zraněný atd.
Udělala dobře, že se s ním pustila do boje, když ji chtěl zpátky a pohnula se kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collinse v této knize, byla silná a střežila si své srdce a za to jsem ji obdivoval.
Jistě, milovala Gradyho, ale byla vystrašená a váhala, jestli ho má pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně nechala věci plynout tempem, jakým chtěla, a když byla připravená naslouchat, naslouchala.
V této knize je hodně úzkosti a opravdu jsem si užíval, když jsem sledoval, jak se tihle dva znovu spojí, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevyšel tak ukňouraně a byl by trochu chápavější.
Pořád říkal, že to chápe, ale občas na mě byl trochu moc dotěrný a pak byl ke konci sladký.
Nakonec jsem ho miloval stejně jako Collins, ale na začátku knihy, jsem měl těžké čtení jeho úhlů pohledu, protože jsem nemohl spojit s jeho charakterem.
První část této knihy, nebyl můj oblíbený, ale on druhý díl?
Zbožňoval jsem, proto mé hodnocení.
Pokud máte rádi druhou šanci, a bratři nejlepší přítel romance, můžete opravdu těšit tuto knihu, jsem prostě měl těžké s Gradym na první a jak zvládl některé věci, které dělal.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho, různých postav.
Je velmi těžké poznat, že je to on.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho ztvárnění Churchilla, bylo velmi dobře provedeno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otáčejícími se stranami...
Scéna a kostýmy byly vynikající.
Je dojemné s dnešní dvojicí polobohů držících světovou politickou pozici.
Stojí za pohled několikrát...stojí za zamyšlení... mnohokrát
Vyhněte se Wifi připojení- přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydleli v hotelu.
Nepodařilo se mi získat toto měřítko pro připojení k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domova a budu si moci nastavit vlastní Wifi systém.
Březen 2018- Nastavil jsem si Wifi systém a toto měřítko se stále nechce připojit.
Pokaždé, když to zkusím, dostanu chybové hlášení.
I když jsem 10' od Wifi jednotky.
Sledoval jsem video nastavení YouTube bez úspěchu.
Když jsem si jednotku koupil, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho toto měřítko používá Wifi router pro komunikaci s telefonem.
Tento systém je omezen na připojení routeru...který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Nikomu bych nedoporučoval toto měřítko kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to měřítkem pro připojení Bluetooth.
Dobře, ale rád bych našel něco lepšího
Po dlouhém výzkumu jsem začal tento produkt používat před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval dobře.
Nicméně vysychá tak rychle, že nakonec používáte tolik lubrikantu, což nakonec stojí hodně peněz, stejně jako to, že je příliš rušivý při sexu.
Jen jsem byl příliš líný hledat nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a není příliš nákladný.
Životnost baterie je na tom, který jsem si koupila na Amazonu, hrozná.
Pořád nemůžu uvěřit, že Logitech tento ovladač přestal vyrábět, nic jiného se tomu ve srovnání s tím ani nepřibližuje.
Tenhle ovladač od Harmony naprosto miluju, tohle je můj čtvrtý.
Pes sežvýkal ten první, manžel klečel na obrazovce toho druhého a ty třetí pořád fungují, ale uprostřed dotykové obrazovky je otisk lokte také díky manžílkovi...tenhle jsem si koupila jako zálohu a obrazovky skvělé, ale baterie, se kterou přišel, vydrží nabití možná pár dní.
Můj původní (třetí) udržuje nabití týdny v kuse a na všechno používám svůj ovladač.
Rozbito za necelý týden
Líbí se mi výrobek je to pěkná velikost a barva!
Bohužel to měl jen týden a otevřel jedny dveře a to popraskané horní části dřeva kusu!
Jsem opravdu zklamaný!
Je to všechno smontované a já nemám krabici už tak jak jsem mohl vůbec přemýšlet o odeslání zpět?!
Můj manžel to zkusil a opravit lepidlem na dřevo ale bohužel ani to nefungovalo!
Dveře vykoukl hned zase!!
Montáž není příliš snadná a navíc....
Při montáži je to pěkný kus nábytku, ale montáž byla obtížná.
Některé znaky písmen byly špatně označeny, takže jsem se musel pokusit přijít na to sám Šrouby, které dodali k upevnění podlahy a bočních panelů, byly všechny popraskané.
Musel jsem jít ven a koupit rohové konzoly, abych se ujistil, že drží pohromadě.
Také dveře skleněných panelů jsou mimo linku a nepasují rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny dveře zůstaly zavřené, protože magnet, který drží dveře zavřené, je mimo linku.
Stále jsem nepřišel na to, jak je zarovnat.
ZÁKLADNÍ KÓD VYTIŠTĚNÝ NA TOP PODu
Tyhle jsem si zakoupil v únoru.
Nedávno jsem je zkoušel používat a bohužel pokaždé, když jeden vyzkouším, můj stroj Keurig mi dá chybové hlášení, že lusk není kompatibilní s mým strojem.
Používal jsem lusky Donut Shop ve svém stroji od doby, kdy jsem ho poprvé zakoupil a nikdy jsem neměl problém.
Při bližším zkoumání lusku na kávu jsem si všiml, že kód vytištěný na vrchní straně lusku není příliš čitelný, takže mohu pouze předpokládat, že mám špatnou krabici.
Koupil jsem si krabici po 72, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jednu z každé ze 6 krabic a dostávám stále stejné chybové hlášení.
Vím, že to není můj stroj, protože ostatní lusky, které zkouším, fungují v pohodě.
Tenhle problém mám pouze z této zásilky.
Velké zklamání, protože mi vypršelo okno pro návrat.
UPDATE: Mluvil jsem se zástupcem zákazníka, který mi vrátil peníze.
Děkuji AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestách.
Taková vymoženost!
Je opravdu hezké mít svou oblíbenou cukrovou alternativu zabalenou v malých balíčcích s sebou!
MILUJU uhýbat, a je tak pohodlné mít je, abych je mohla hodit do kabelky na večeři venku, nebo je použít u kamaráda doma.
I když jsou trochu drahé, nemůžu vystát Equal nebo růžovou hmotu v ledovém čaji.
Swerve nebo nic, tak jsem nadšená, že mám své sladidlo na cestách!
Ve skutečnosti nedělá žádné vzduchové „čištění“
Koupil jsem to jako zvlhčovač, část „čištění vzduchu“ je ve skutečnosti falešná reklama; podle toho, jak je vaše voda tvrdá, se na dně hromadí usazeniny, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych ho ohodnotil jako o něco méně účinný než zvlhčovač typu knot se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku ji budete muset provozovat asi 5 let, abyste rozdíl vyrovnali.
Na svou velikost má poměrně velkou kapacitu vody, protože „nádrž“ je nedílnou součástí jednotky a má nízký výkon (i když ne lepší než typ knotu).
Také se poměrně snadno čistí, i když plastové disky vlastně nelze obsluhovat, protože diskovou jednotku nelze rozebrat.
Nicméně pro německé strojírenství není kvalita stavby velká.
Já mám svůj už rok, což by bylo asi šest měsíců běhu za chladného počasí, a jednotka vyvinula velmi nepříjemný rachotivý zvuk z montáže ventilátoru.
Můj odhad by byla ložiska ventilátoru, takže jen čekám, až se tady stane naprostá porucha.
Jak poznamenal někdo jiný, každá oprava je téměř rovnocenná nákupu nového zvlhčovače knotů.
tl; dr – nestojí za příplatek, s zvlhčovačem knotů je vám lépe.
Myslím, že to bylo jednodušší rozbít, než si mysleli.
Dávám tento produkt 3 hvězdičky udělat s tím, že když jsem to dostal v něm byl rozbitý už uvnitř.
Jakmile jsem si to prohlédl jsem si uvědomil, že ten, kdo dal to do krabice dal to tam rozbité, To mohlo být buď výrobci baličky nebo pro výrobce problém by mohl být, že kupující vrátil položku a tvrdil, že prostě nechtěli nebo nepotřebovali to a Amazon možná neudělal dost dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti kupující nemohl říct, že to bylo rozbité, protože pak Amazon by si to vzal zpět, což je dobré zejména s tímto druhem výrobku tak jako tak i když jsem ten, kdo uvízl s něčí nedbalosti.
Udělal jsem však dostat své peníze zpět, takže poté, co přemýšlel o tom a diskutovat o tom s mým manželem jsem se rozhodl dát tomuto kupujícímu další šanci.
S tím řekl budu pouze aktualizovat své hodnocení na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (tím, že alespoň adresování) a pokud položka přijde ve skvělé formě, vlastně má možnost dělat to, co to dělá, a funguje dobře dělá to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem celkem spokojen, ale nebylo to pro mě tak jednoduché nainstalovat.
Několikrát jsem zkoušel bez úspěchu nainstalovat oba „zvonky“ do zásuvky vysílače.
Už jsem to chtěl vrátit jako nefunkční, ale řekl jsem si, že to ještě jednou zkusím a zkontroluji baterie ve zvoncích.
Voila...z krytů baterií trčely malé plastové výložky, které jsem natáhl a z nich vylezl plastový kus, který zakrýval baterii a bránil jejímu fungování.
Poté, co jsem tyto kusy plastu odstranil, zvonky fungovaly v naprostém pořádku a byl jsem s tímto nákupem naprosto spokojen.
Zvláštní je, že v návodu pro uživatele není žádná zmínka o plastu nad baterií, která musí být vyjmuta, aby zvonek fungoval.
Bylo by aloto méně frustrující, kdyby se o tom zmínili a já si nemyslel, že problém byl v tom, že jsem instalaci nedokončil správně.
Je to dobrý produkt s širokou škálou kroužků, zvonků a melodií, které si můžete vybrat a je snadné je měnit, kdykoliv chcete.
Jedna věc, kterou žádají při hodnocení tohoto zvonu je, jak je „odolný proti povětrnostním vlivům“.
Nemohu to komentovat, protože byl instalován 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný proti povětrnostním vlivům až do příštího období dešťů...pravděpodobně v listopadu.
Ztracený balíček – Znovu mi nabili
Vyrostl jsem s nimi a byl jsem nadšený, že je koupím pro syna, ale ztratili balíček živých housenek.
Řekli mi, že mi ho vymění a tentokrát si naúčtují polovinu poštovného.
Po výrazném telefonátu mi nakonec znovu naúčtovali novou objednávku se slevou tak 3$.
Myslel jsem si, že je to dost neprofesionální, protože nejenom, že ho ztratili, ale oni mě vedli k přesvědčení, že ho napraví jen proto, aby mi naúčtovali téměř plnou cenu na konci 30 minutového telefonátu s nějakým blábolením o poukazu.
Strávil jsem 30 minut na telefonu, tak jsem ustoupil a prostě si koupil další sadu housenek.
To je fuk.
Funguje dobře po některých bolestech hlavy.
Měl nějaké problémy s jeho zprovozněním.
Dodávaný kabel nebyl k ničemu – nebude nabíjet baterii.
Když jsem vyměnil kabel za můj vlastní byl schopen nabíjet a pak připojit zařízení přes bluetooth k PC.
Měl jsem problém najít PC software, ale když jsem e-mailem jejich podporu odpověděli během jednoho dne se správnou informací o stahování.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, nicméně jsem nebyl schopen připojit buď iPhone nebo iPad (zkoušel několik od každého) přes bluetooth.
Budu muset hard-wire, pokud se rozhodnu používat toto zařízení v mém produktu.
... byla příliš žlutá před nákupem a bylo mi řečeno, že je jako starožitné zlato
Zeptala jsem se prodejce, jestli je barva příliš žlutá před nákupem a bylo mi řečeno, že je jako starožitné zlato, tmavší.
Nic podobného!
Sada vypadá VELMI levně.
Je super lesklá žlutá se spoustou Kč, ještě lesklejší.
Na fotce vypadá skvěle, ale ve skutečném životě bych ji nedala ani teenagerovi, aby ji nosil.
Prsten se mi moc líbil – ale nemohl jsem ho nosit pořád! :(
Tenhle prsten byl nádherný.
Líbil se mi design a ten robustní pocit; vypadal draze a byl velmi pohodlný!
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec jsem výrobek vrátil, je ten, že jsem si uvědomil, že bych ho nemohl nosit pořád.
Rád nosím své prsteny pořád, proto se vždycky ujišťuji, že dostanu šterlinkové stříbro, a vím, že někteří lidé říkali, že se jim prsteny po nějaké době zašpinily, ale já jsem ten svůj nosil asi týden v kuse – dokonce i při mytí rukou – a žádné zašpinění jsem si nevšiml.
Zajímavé bylo, že problém, který jsem měl, byl ten, že vnitřní pásek prstenu ve skutečnosti zbarvoval můj prst do běla a zvlhl – tak nějak, jak to dělá náplast, když ho necháte dlouho na sobě.
Stalo se to i tehdy, když jsem se ujistil, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale bylo to nepříjemné a tak jsem se rozhodla, že to není prsten pro mě.
:( Škoda, protože jsem ho opravdu milovala!
Takže pokud si tento prsten kupujete s úmyslem nosit ho jen občas, říkám jděte do toho!!
Nebudete zklamáni!
koupit si Pampered Chef...
Vlastním malou lžíci Pampered Chef, ale jsem mezi rezidencemi, takže většina mých 'věcí' je ve skladu.
Miluju používání těchto lžic při pečení dokonale porcovaných sušenek.
Podívala jsem se na lžíci OXO a na lžíci Pampered Chef a rozhodla jsem se ušetřit nějaké peníze a pořídit si tu OXO – obvykle mám s jejich výrobky štěstí.
Ne s tímhle.
Asi při sušence s arašídovým máslem č. 30 přestala páčka uvnitř lžíce fungovat.
Musela jsem páčky rozpárat a znovu umístit páčku, abych mohla udělat ještě pár věcí, a pak to zopakovat.
Takže... zachraňte si zdravý rozum a kupte si lžíci Pampered Chef.
Stojí to za to!
Mr. Coffee si už nekoupíte
Chvíli to byl dobrý kávovar, ale vždy s ním byly problémy.
Pokud jste dostali vodu mezi černý plast a kov na karafě, prosakovala by a odváděla vodu celé dny.
Pak se rozbila naše plastová páka, která umožňuje kávě proudit přes filtr do karafy.
Kontaktoval jsem zákaznickou podporu s dotazem na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Skvěle se vaří káva a udržuje ji horkou, ale je s ní příliš mnoho dalších problémů, než aby se do ní dalo investovat za současnou cenu.
Musím koupit!!
Miloval jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo to opravdu jednoduché.
Líbí se mi mít trochu více detailů v úchytech a všiml jsem si, že předtím, než jsem si ji koupil, což je důvod, proč jsem ještě dát tuto 5 hvězdiček!
Bylo snadné vyčistit a vše přišlo zabalené jednotlivě, které jsem zjistil, že je opravdu organizovaný a to zklidnilo mou duši lol láska, láska, LOVE barva a já bych určitě koupit to znovu pro sebe nebo pro milovaného!
Mohlo by to být dobré na tyči, ale NENÍ to jako závěsná přepážka nebo protimeteorologický štít.
Hanba Audubonu.
V návodu se píše, že máte zatlačit zástrčku nahoru otvorem v přepážce a „Ujistěte se, že je bezpečně na svém místě“.
JAK???
Je navržena tak, že přepážka jednoduše volně sedí na zástrčce, takže ji může vytlačit každý tvor nebo sebemenší vítr.
Můžete otočit zástrčku vzhůru nohama tak, aby palec šroubů byl na spodní straně přepážky, ale otočení těch šroubů vám zabere hodiny; žádný nástroj to neudělá a jen ty nejmenší prsty by to měly snadné.
Trvalo mi přes hodinu, než jsem napůl upečenou práci s jejich přišroubováním, abych zajistil přepážku ke zástrčce.
Je to kompletní PITA.
Objednal jsem čtyři takové; ty tři, které jsem neotevřel, jdou rovnou zpátky a já jsem na trhu s lepšími protimeteorologickými strážci.
(Přiznejme si to; neexistuje nic takového, co by veverky skutečně „vyvedlo z míry“!)
Miluji mnoho funkcí těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které mé nové rostlinné sazenice dostávaly z okna.
Miluji mnoho funkcí těchto světel.
Pros: Za prvé, snadno se přichytí k mé poličce a ohnou se do mnoha poloh, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou chladná na dotek a nezpůsobila újmu ani při dotyku s rostlinami.
Věřím, že moje zelenina má ze světel prospěch.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Nepoužil jsem časovač, raději jsem je zapínal a vypínal sám.
Vidím tuto funkci jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou tak silná, aby mohla být primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až světla dohoří, budu si muset koupit celou novou jednotku.
BEWARE...SMELL IS VERY BAD...CARD SLOTS TOO BIG!
Když jsem to poprvé uviděl, pomyslel jsem si, že je to krásné, ale vonělo to TAK BAD.
Nejdřív jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že je to MOLD vůně.
Nikdy to nezmizelo, tak jsem to musel vrátit.
PLUS, kapsy na kreditky jsou příliš velké.
Kreditky sklouznou až dolů, tipy nejsou vidět, takže nemáte ponětí, co karta je kde a velmi obtížné se dostat ven.
FOTO, které ukazují, kde jsou karty, je nedosažitelné.
Je velmi malý..
Dostal pásek na peníze na cestu a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych si ho nekoupil a ještě se budu muset poohlédnout po něčem větším.
Dobrý deštník, koupil bych ho znovu, kdybych musel
Za prvé, musím říct, že barva je miloučká.
Spousta věcí, které si objednávám ve fialové, vždy přijde moc světlá, moc dětská, moc divná, moc neonová, co to máte.
Ale tahle fialová byla hluboká a svěží a já ji miluju, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, co jsem měl.
Dodává se s krytem a i když nemusí mít moc funkčního využití, opravdu udržuje ostrý vzhled.
Balení je hrozné – obdrželi jsme 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že firma neví, jak svůj výrobek ochránit.
Neobtěžujte se přijímat jednu, která není poškozená.
Vrátili jsme 2 kvůli škodám v lodní dopravě a 3. byla také poškozená.
Vzdala to.
Dodávají ji v měkkém tenkém obalu s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné vycpávky.
Parádní koncept!
Jen potřebuje další vylepšení, aby to byl opravdu parádní produkt
Opravdu parádní koncept, pokud jde o karaoke-ing.
Miluju karaoke, takže tenhle mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý – růžové zlato je pěkný detail.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje tak, že se to současně chová jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a zaznamenává vše, co z něj vychází.
V samotném mikrofonu ale není žádná hudba.
Má bluetooth konektor, takže ho synchronizujete s telefonem a stáhnete si karaoke aplikaci, která umí poslat karaoke písničky do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a vašeho hlasu (také samostatně!)
a dokonce má možnost nastavit úroveň ozvěny tak, abyste skutečně zněli, jako byste byli v karaoke místnosti.
Některé věci, které bych v budoucnu rád viděl vylepšené, jsou: 1) je tu nějaká otravná zpětná vazba, která zřejmě nezmizí bez ohledu na to, jak daleko od mikrofonu telefon budu mít.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem blázen do minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly design vylepšit.
3) podpora více karaoke aplikací A konečně, protože zvuk vychází přímo z tohoto mikrofonu, a ne přes plochou obrazovku nebo centrální reproduktor v obývacím pokoji, není to taková zábava v prostředí večírků.
Pokud by to výrobce nějak integroval do většího party karaoke ekosystému, tak by si to nekonečno zpříjemnilo.
Vyškrábané od Vision Supplies
Říjen 2017 zakoupil čtyři (4) kazety od Vision Supplies – Amazon Marketplace, takže bych měl v případě potřeby a ušetřit náklady na dopravu.
Používal jsem dvě za posledních pár let, asi jednu ročně, a fungovaly dobře.
Zkusil jsem použít jednu minulý týden, téměř prázdnou po vytištění 20 etiket, ale v poslední došla po 40 stranách.
Plast chybí na obou.
Řekl záruka vypršela!!!!
Kdo by kontroloval každou kazetu po obdržení????
KUPUJTE BÝT AWARE!!!!!!!!!!!
Promiňte, cože?
Moje kamarádka mi doporučila masku této řady, tak jsem si koupila tuto, tento kondicionér a vše v jednom mléce.
Nemohu mluvit za účinnost produktu, protože ten zápach byl prostě nesnesitelný.
Víte, že zatuchlý zápach staré budovy používají na dámských toaletách, aby se pokusily zamaskovat zápach *dam*, ale ukázalo se, že je to jen takový kyselý, chemický, trochu zatuchlý babiččin zápach?
Jo, to je vše, co mě napadá, když to cítím.
Znáte různé tahy různých lidí, tak se vám možná ta vůně bude líbit.
Moje kamarádka říkala, že to může pomoci i těm nejvíce poškozeným vlasům, takže pokud vás vůně nezajímá, tak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že více a více přírodních linií prostě zajímá méně, protože se to stejně bude prodávat a tak teď všechno voní jen jako těsto na hraní.
Ztratila jsem pár oblíbených linií, když změnili recepturu na levnější ingredience.
Nevím, jestli je to tady ten případ, nebo jestli je to podvrh (což jsem nazval Davines a oni řekli, že není), ale tohle voní jako Y U C K a musel jsem to vrátit.
Drops internet
Tento modem/router jsem si koupil asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale poslední rok navíc jsem měl problémy s tím, že mi vypadl internet.
To se děje na všech mých zařízeních jak Wi-Fi, tak po drátě.
Jediný způsob, jak obnovit službu, bylo provést reset střídavého napájení.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Chlapi z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát přišel o službu 5G.
Musel jsem provést tovární reset, abych to obnovil.
Na základě svých zkušeností nemohu tento modem/router doporučit.
Koupil jsem si modem/router Netgear AC1900.
Je to fantastické.
Měl jsem to přes týden bez problémů.
Je to rychlejší a dosah je větší než u Arrisu.
Četl jsem na internetu, že jiní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte internet Comcast nedoporučuji tento modem/router Arris.
Pořiďte si Netgear, je mnohem spolehlivější.
ale stává se to dost na to, aby to bylo otravné.
Pozitivní poznámka
1 z ventilátorů zněl nevyváženě z krabice.
Ovládání rychlosti je opravdu vratké – Pokud je vytočíte na 100%, ventilátory se vypnou, takže je potřeba ho otočit na 100% a pak ho pomalu vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že to je u většiny těchto typů výrobků v tomto cenovém bodě obvyklé.
Nohy pro držení notebooku nahoře, když je nakloněný, se párkrát ulomily...
Vracejí se dovnitř, ale stává se to dost na to, aby to bylo otravné.
Pozitivní poznámka, tohle má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z ventilátorů umístěných blízko vrcholu notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a poskytují velmi málo dodatečného proudění vzduchu do notebooku s takovou konfigurací chlazení.
Ok kufřík s vážnými omezeními
Tento kufřík je ok, ale ne výjimečný – maximálně 3,5 nebo 4.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně kufříků.
Z těch je Gumdrop asi nejlepší, ale má několik vážných problémů.
Gumový kufřík (silikon, cokoliv) je velmi hladký a kluzký a nedává vám moc sebevědomí, když držíte Tab jednou rukou.
Tab A je těžký, takže když si lehnete při sledování videa, kufřík vám sklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový kryt, který kryje obrazovku, protože to narušilo ovládání dotykové obrazovky.
To ovlivnilo pevnost plastového rámu z 1 dílu, který obklopuje Tab A, takže gumový vnější kryt je teď opravdu pružný a chatrný.
A konečně, ztížili přístup k peru S.
Pero S je v pravém zadním dolním rohu Tab A a udělali malou gumovou chlopeň, která chrání roh, aby se zhoupla dozadu pro přístup k peru S.
To znamená, že aby se S pero dostalo ven, musí se klapka vychýlit o 180 stupňů.
To je opravdu nepříjemné a těžko se to dělá jednou rukou.
Tento kufřík odvádí dobrou práci při ochraně mého Tab A, ale s těmito vážnými konstrukčními nedostatky ho nemohu doporučit, pokud nemáte S pero, pak nemáte moc na výběr.
Vše, co jsem potřeboval
Tento produkt je opravdu hladký – jedna zastávka nakupování pro všechny mé potřeby připojení.
Miluji jen házet to a můj notebook maličký napájecí adaptér v mém go bag a být připraven pracovat na velkém 4k displeji nebo chytat fotografie z mého fotoaparátu.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovače USB-C, které jsem vyzkoušel od různých značek) je, že mac je zřejmě nemůže poznat rozdíl mezi násobky stejného monitoru (takže můj mac výstupy stejné video na všechny identické monitory připojené k rozbočovači, ať už pomocí HDMI a/nebo VGA).
Ale pokud používám 2 samostatné rozbočovače/adaptéry nebo 2 různé modely monitoru, pak mac správně výstupy na displeje jednotlivě.
Ok, potřebuje nějaké vylepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký bezpečnostní zámek nad tlačítkem šoku (byl zmáčknut spíš náhodou, když ho mám v kapse, pak jsem ho vlastně chtěl použít) moji psi se dokonce omylem zapnuli po šlápnutí na ovladač.
Také pokud se váš pes rád válí v mývalích hovínkách jako ten můj, je to taková otrava s čištěním.
Jak se fekálie dostává mezi trhliny zařízení, což vyžaduje, abyste celou věc rozebrali, abyste ji pořádně vyčistili a zbavili se zápachu.
Také dosah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebujete výhled, aby to fungovalo.
A byly chvíle, kdy to nefungovalo vůbec, i když jsem od svého psa jen 30 stop daleko.
Být dobíjecí je určitě příjemná vlastnost a nabití vydrží dobrou chvíli.
Já ten svůj potřebuji nabíjet jen asi jednou za dva týdny.
Dostanete, za co si zaplatíte.
Hrozný produkt, zkreslený
Koupil jsem si ho jako tracker, abych ho mohl používat při plavání, a ani jsem neměl pořádnou šanci si ho vyzkoušet.
Za prvé, není voděodolný a nedoporučuje se používat při plavání podle návodu k použití.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB zástrčku nebo počítač.
Fajn, těch máme kolem spoustu.
Když se ho ale snažím dostat do portu, aby se nabíjel, hned se zase spustí ven.
Nejsem si jistý, jestli je tam něco, co není kompatibilní, nebo je to jen špatně udělané, ale nebudu sedět a držet své zařízení uvnitř, zatímco se nabíjí.
A konečně, aplikace pořád vyskakuje reklamy, i když je zavřená.
Reklamy vyskakovaly, když jsem posílal SMS, což je velmi znepokojující.
Pak jsem vypnul všechny aktivní aplikace v telefonu, a když jsem šel zkontrolovat čas o 20 minut později, uviděl jsem další reklamu.
Hrozný produkt, myslím, že dostanu, za co jsem zaplatil...
Skvělý batoh, ale na popruzích přemíra
Tenhle batoh vypadá dobře a podává dobré výkony.
Je to skvělá nabídka, zvlášť když ho porovnáte s tím, co batohy stojí teď několik dní.
Důvod, proč jsem srazil hvězdu, je ten, že je tam prostě moc popruhů.
Na tomhle batohu je víc popruhů, než dokážu spočítat.
Skončím tak, že tyhle popruhy navíc přestřihnu a spálím, protože většina z nich není opravdu nutná a jen překáží při otevírání a zavírání batohu.
Jinak jsem si z tohohle udělal svou novou školní tašku na vysokou.
Přímo vzadu v batohu je přihrádka na můj MacBook Pro a všechny moje knížky se vejdou do poskytnutých kapes.
Vlajka je také skvělým zakončením.
Můj pes ho ještě nezničil
Měl problémy s hokejovými míčky.
Můj pes je miluje – svou oblíbenou hračku na aportování a žvýkání – a plavou.
Tedy dokud je nerozžvýká na kousky.
Vyzkoušel několik, dokonce i verze s „horkým počasím“ – a vydržely o pár minut déle než ostatní.
Dokud se neobjevily tyhle.
Tyhle obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavá v tom, co žvýká.
Jak se říká, nejde o to, jak velký pes v boji je, ale jak velký boj je v psovi.
Palec nahoru od Daisy a já.
Tento výrobek je nebezpečný pro děti.
To je obrovský zdravotní hazard pro vaše dítě.
Zkontrolovali jsme baterii po několika týdnech používání a viděli, že voda jde do prostoru, kam jdou baterie.
Baterie samy o sobě shnily a vytékala z nich černá kapalina.
Při pohledu na design se zdá, že není možné, aby byl kryt baterie vodotěsný, což znamená, že nejen že voda šla do prostoru během koupání, ale část toxického materiálu také vytekla.
Prosím, nekupujte tento výrobek.
Jsem šokován, že bylo povoleno jít na trh i přes tak zjevnou vadu.
problémy s přehříváním a těžké časy připojování regulátor
Dávám tomu 3 hvězdičky pro tuto chvíli, nechci nechat špatnou recenzi pro prodejce, pokud si to zaslouží, ale tento drone přehřívá hodně.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale ill pravděpodobně zkusit oba jen vidět, co říkají.
Líbí se mi drone je cool malá hračka, která létat je lepší než některé větší starší drony a některé z mých větších dronů pocit, více jako hračka, než tento jeden.
Nicméně jeho jediný drone jsem kdy měl problémy s přehříváním a to vlastně bere zábavu z létání im bude předpokládat, pro tuto chvíli, že jeho výrobní problém, který je třeba řešit asap, pokud chtějí, aby tam výrobek být úspěšný.
Opravdu doufám, že prodejce mi poslal použití drone, jak jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, jak to dorazí 1 den po nákupu.
Budu aktualizovat datum mé recenze po kontaktování prodejce a dji tello.
O této dárkové tašce mohu říct jen dobré věci
O této sadě dárkové tašky mohu říct jen dobré věci.
Všechny své vánoční dárky jsem mohla zabalit do tašek, dárkového obalu a hedvábného papíru.
Výrobek je velmi kvalitní a díky různým velikostem je snazší vybrat ten perfektní ke každému dárku!
Vřele ho doporučuji.
Prodejce je naprosto milý a pozorný.
Po nákupu mě oslovil, aby se ujistil, že jsem se svým výrobkem spokojená.
5 hvězdiček na celé kolo!
Fyzika je příšerná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte si tuto hru fyzika je příšerná a já jsem na tuto hru tak naštvaný, protože pravděpodobně na každé hře a hře je asi 40 hackerů.
Ani s tím nic nedělejte víte, že prostě nechají hackery dělat, co chtějí a pak vědí, že hra je příšerná ale nedělají s tím vůbec nic a hra pokračuje v aktualizacích o jejich postavách opravdu to, co by měli aktualizovat je fyzika, protože je to příšerné nekupujte si tuto hru fyzika je příšerná a mechanici jsou příšerní lidé, kteří očividně postavili tuto hru byli zhulení nebo tak něco, protože je to jedna z nejhorších her, které jsem kdy hrál upřímně bych raději hrál Pixel Games v této blbosti je to jedna z nejhorších her nekupujte
Ne jako ostatní hry s nájezdníky na hrobky
Od samého začátku mi to nepřipadalo jako ostatní hry s nájezdníky na hrobky.
Hratelnost je brutální v tom, že ovládání není chytré v tom, že víte, jakým směrem se snažíte vydat.
Nechá vás padnout na smrt těmi nejpodstatnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tahle hra se mi nelíbila.
Nemám v plánu ji dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraju hry.
Ergonomický a cenově dostupný, ale nepříliš tolerantní k neustálému používání
Má štíhlejší konstrukční tvar, který lépe padne do rukou, nejsou tam žádné ostré rohy, o které by se dalo zachytit a s napájecí šňůrou jako trvalým nástavcem je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští při hraní akčních her, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se opotřebovávají velmi rychle.
Jsme velmi těžkopádní a máme tendenci opotřebovávat 2-3 ovladače ročně.
Pro nás tedy každoroční investice do ovladačů znamená, že musíme být vybíraví a obezřetní v tom, co nakupujeme.
Ovladač by se hodil s odolnějšími pružinami; po pár měsících tlačítka, která se používají nejvíce, přestanou reagovat a správný joystick ztratí centrování, IE- způsobí přiblížení obrazovky mapy a postavy jdou dopředu, aniž by se dotkly ovladačů.
Dostanete, za co zaplatíte
Byl jsem zklamán, když jsem tento předmět obdržel, protože stříbrný díl, který obepíná obličej, vypadal, že je vyroben z nějakého levného plastu.
Není to tím, že byl vyroben z plastu, co mě zklamalo, ale tím, že použitý plast vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled pro mě.
Také jsem nevěřil, že to vydrží každodenní nošení, takže jsem to nakonec vrátil.
Byl jsem zklamán, protože se zdálo, že by to byl dobrý obchod, kdyby nebylo toho.
Nicméně, pokud můžete přehlédnout, že, pak by to mohlo být pro vás to pravé.
Byl zabalen dobře a dorazil rychle.
Nic jako předchozí telefony Stylo, MASSIVE DISAPPOINTMENT.
Měl jsem původní Stylo stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je jasné, že se mi Stylos opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, jsem si ho koupil.
Nikdy proto, že měl někdo problémy nebo rozbitý, jen proto, že jsem chtěl zůstat upgradovaný a „v obraze“ a to se mi povedlo.
Ze všech těch telefonů jsem ani jednou neměl problémy se samotným telefonem.
Když jsem dělal tento nákup pro Stylo 3 přes Virgin Mobile, prostě jsem věděl, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tenhle telefon měl tolik problémů, že mě upřímně šokovalo, jak předchozí Stylos byl tak úžasný.
Nikdy se mi ani nepodařilo úspěšně nechat si tento telefon převést na svůj účet Virgin Mobile.
S tímto telefonem jsem se motal o něco méně než týden.
Hledal jsem informace na internetu a volal jsem na různé telefony, zoufale jsem se snažil dát Stylu 3 výhodu pochybnosti v naději, že jsem to jen já, kdo dělá něco špatně, ale bohužel jsem tím promarnil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Štve mě, že musím dát Stylu tak hrozné hodnocení a recenzi, ale byl jsem extrémně zklamaný tímto telefonem.
Doufejme, že LG pozvedne jejich hru a může zlepšit budoucí Stylos, pokud existují nějaké, ale tohle byl obrovský BUST.
Na druhou stranu, vrácení peněz a moje vrácení šlo hladce, ale to je tak všechno.
