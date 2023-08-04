Hacknutá verze Jedi Knight se hroutila, protože volala funkci z konce vtable.
Ukázalo se, že se předpokládá, že volání IDirect3D:: CreateViewport () vrátí IDirect3DViewport3, který má další metody přilepené na konec ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože vytváří pouze výřez pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní chápu, že v praxi je IDirectXObject2 obvykle řádnou nadmnožinou IDirectXObject, bez změněných podpisů funkcí a nové metody jsou přidány pouze na konec.
To však neplatí univerzálně; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže v každém případě, protože to platí i zde, abych to opravil, musel jsem rozšířit svou implementaci viewportu tak, aby obsahovala metody IDirect3DViewport3 tak, aby volání nového bylo platné.
Předpokládejme, že věda alespoň zčásti sestává ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoli teorii, kterou by mohly podporovat.
I když je pravda, že taková fakta ve vědě existují, je stále možné tvrdit, že vědecká fakta jsou nabitá teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale volba toho, které experimenty provádět, řídí, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplynout pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se uskutečnily jinak.
Toto je velmi stručný náčrt věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou konzistentní s teoriemi tvrdícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvedněte si ho tento víkend.
Hledal jsem dobré auto pro první auto; a opravdu miluji estetiku 80. let.
Už na přejezdech cívek a snížené jízdní výšce.
Udělal jsem malý výzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zážitky?
Vím, že nejsou rychlí ve srovnání
# Větrání do Fediverse času.
Domácí Partner a já jsme šli do obchodu s lihovinami dnes večer na nějaké pivo a láhev bubu.
Když jsme se šli podívat, pokladní je docela zřejmá # trans žena.
Já, v kraťasech a šlehači na manželku, a The Domestic Partner, celý oškubaný a s novým sestřihem, který sám popsal jako "vypadat jako neonacista."
Její tělo okamžitě ztuhlo a v očích se jí objevil výraz strachu.
A pak jsme prostě... zaplatili za naše věci.
A řekl děkuji.
A řekla jsem, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale fakt, že se nejdřív bála, JE NA KURVO A NENÁVIDÍM TO.
To je nejhloupější časová osa a nenávidím to dot com.
Nic nebrání Donaldu Trumpovi, aby kandidoval na prezidenta, zatímco je obžalován, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se omilostnil, aby se dostal z vězení.
Ale nemůže se omilostnit ze státního vězení.
Chce to guvernéra státu.
Dalšími dvěma státy jsou New York a Georgia.
Guvernér posledně jmenovaného Kemp nepochybně omilostní Trumpa, pokud bude odsouzen nebo dokonce obžalován DA okresu Fulton Fannie Willisovou.
New York je nejlepší nadějí pro odpovědnost
Existují významné důkazy, že komunikace v reálném světě nemůže být redukována na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického Lewisova (1969) signálního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové rozpoznání významů symbolů.
Ukazujeme, že environmentální omezení výběru přijímače může být jednostranně využito odesílatelem, bez možnosti rozpoznání na straně přijímače.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Předpokládáme, že kontextově závislá komunikace je situovaný vícevrstvý jev, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil setkání s Penny a Nicholasem z Ashanti Development o víkendu, abychom si popovídali o jejich pokroku.
Ashanti Development spolupracuje se stále rostoucím počtem komunit v regionu Ashanti v Ghaně již téměř 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, aby mohly začlenit a podporovat svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase a podpořil řadu projektů.
Když jsme to o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména o výsadbě stromů a podpoře zemědělských podniků.
Byly vysazeny tisíce stromů a zemědělci zaznamenali zvýšení výnosů plodin prostřednictvím řady intervencí od podpory nákupem vybavení až po školení.
Nicholas pracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je Fall Armyworm, který může zničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS poblíž mě mi nedovolí napsat štítek nebo napsat na krabici.
Je nutné vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou to jde, a kdo to posílá.
Musím poslat e-mail na nějakou náhodnou adresu s neformátovanými daty, aby si úředník mohl přečíst e-mail a zadat jej do svého systému, aby vytiskl štítek.
A oni mi vždy účtují 2,25 dolarů za toto "pohodlí."
Druhý den ráno a nemůžu se dostat přes hanebné předstírání žurnalistiky veřejné služby Chrise Lichta na CNN včera večer.
Byla to nehoráznost, jako symbolický protidemokratický svátek lží a křivd 6. ledna, sebedestruktivně organizovaný americkými médii.
Ostudné publikum.
Licht SOUHLASIL s celým republikánským publikem!
Kdo vybíral a vybíral lidi?
Je tu příběh, který se tam bude hlásit.
Hodnocení - hledání bludné nezodpovědnosti toho všeho.
Nedá se to opakovat.
Mám velmi průvanový suterén, což v podstatě znamená, že mohu dostat spoustu hlodavců, kteří se ukrývají.
V uplynulém měsíci se objevilo mnoho známek více hlodavců, což bylo mimořádně překvapivé, protože je jaro a já bych si myslel, že by se vydali venku se změnou počasí.
Nicméně, měl jsem pár obyčejných starých snap-pasti umístěny kolem, a by poslušně doplnit arašídové máslo na ně každých pár dní, jak myši laskavě lízat to čisté.
Tuhle rutinu jsem konečně včera večer měla plné zuby, vyčistila jsem všechny pasti od burákového másla a přilepila k nim pistácii.
Vyšlo to.
(FWIW, zkoušel jsem téměř všechny "humánní" pasti na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť spokojený s jejich zabíjením, ale nebudu komentovat etiku zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se zahalují do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jasně, že snížili daně z podnikání.
Ale také snižují granty a daňové úlevy, které povzbuzují větší podnikatelskou aktivitu.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Zjistil, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automatické přehrávání videí, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělat peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud odhání lidi.
To platí i nyní, když je goatse.cx pryč, i když by to byl těsný závod na dně mezi kozou a řekněme KHOU.com, kde jsem se snažil sledovat video, které mi Wendy poslal.
V prvním dnešním vlaku se pokladní podíval na naše jízdenky a řekl: "Dlouhá cesta!"
"Jo a dneska se vracím," řekl jsem.
"Právě ho vysadím v Glasgow," pokusil jsem se vysvětlit a ukázal na svého společníka.
"Není nic, co byste často slyšeli:" Právě jsem ho vysadil v Glasgow, "" řekl lístek.
Je to věc, kterou jsem taky nikdy předtím neřekl.
Věc, která mě včera v noci přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který vlastně nikdo nechce, kromě fanatiků, kteří v něm jsou.
A jsou to opravdu oříšky.
Nemůžeme jim dovolit, aby okradli naši zemi.
Je čas se bránit.
Vyjděte ven a protestujte.
Pořiďte si samolepky na nárazníky, které jsou proti Trumpovi, a omítněte je všude.
Křičte zpět na ty, kteří by se o nás pokoušeli mluvit.
To není normální.
To není v pořádku.
Můj soused a já jsme dorazili domů ve stejnou dobu a přes ulici jsem ho slyšel vykašlávat covidovou hlenovou bouři.
Tak jsem spěchal, abych se dostal do svého bytu, abych se mu vyhnul, ale stále se mu podařilo dohnat mě, abych si popovídal.
Přísahám, že covid-infikovaní lidé jsou zombie snažící se nakazit všechny ostatní.
Není společensky přijatelné jít na veřejnost nebo spěchat k lidem, když kašlete na hlenovou bouři.
Opakuji.není společensky přijatelné šířit svou covidovou hlenovou bouři všude!!!
Writing Wonders 5 / 11: Směje se váš MC více nebo pláče?
Abe skrývá svůj zármutek a snadno se směje, zatímco Tom se nebojí plakat, ale je méně pobaven hrubým humorem.
Jan ti ublíží dřív, než ti dá najevo, že je zraněná, a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je neustálým společníkem života.
Po 4000 utrpení se Yl ocitá na místě lásky a má obrovské pocity, že neví, co s tím dělat, takže je tu spousta obojího.
"CNN prostě musí skončit.
Včerejší fiasko s # MangoMoron bylo nehorázné fiasko.
Kdo v této ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "šéf" kabelových zpráv zavolal, aby dal tomu tlustému, prolhanému zločinci tolik vysílacího času?
Vysoký tlak bude převládat do začátku příštího týdne.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes časně ráno infračervená družicová a povrchová pozorování naznačila rozšiřující se oblast nízkých vrstev a nepravidelných < URL >
Podivínský student Arnie Cunningham se zamiluje do Christine, zrezivělé Plymouth Fury z roku 1958, a stane se posedlým obnovením klasické automobilové slávy.
Jak se mění auto, mění se i Arnie, jehož nově nabytá sebedůvěra se mění v aroganci za volantem jeho exotické krásky.
Salesforce partner
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše Salesforce konzultanty ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije své odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších částí o mých sousedech, kteří se obrátili proti mně, je přemýšlet o tom, kolik úsilí je třeba být nepřátelský.
Zapomeň na mě, fajn.
Nevšímejte si mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto okamžiku se otevřené nepřátelství a násilí zhoršuje.
To chce úsilí.
Zabouchnout dveře před mým obličejem vyžaduje úsilí.
Naši psi bývali nejlepšími přáteli.
Pořád netuším, co jsem mohla udělat, abych si to zasloužila.
Měli klíče od mého bytu po dobu 6 let.
Ta loď je zakázaná.
Jsem si vědom vaší nenávisti vůči Organě.
Ona je pro mě irelevantní.
Můžeš ji zabít, jestli to dokážeš.
Na palubě té lodi ale často létá jiný jedinec.
Kdyby zemřel, následky by byly. vážné.
Hodně mě štve tatíčkovství.
Zde je (o něco delší než) Toot-délka rychlokurz v tom, co mám na mysli táta-ification:
Není to můj termín, je to termín používaný k popisu, když je vyprávění nebo herní mechanika postavena kolem centrálního protagonisty (obvykle staršího, obvykle mužského), který řídí nebo hlídá jinou osobu (často mladší).
The Last of Us je snadný a kanonický příklad táta-ifikace.
Joel používá své dovednosti a schopnost uzákonit (extrémní) násilné činy, aby splnil úkol, který je kódován jako "péče."
Táta-ification obvykle předpokládá, že řešení situace, kdy se rodičovská postava musí starat o dítě nebo chránit dítě nebo dítě, je ohromující síla a pomocí této síly vynutit velmi specificky tvarovanou dynamiku moci.
Táta-ifikace narušuje možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoli agenturu, kterou má dítě.
Tímto způsobem, táta-ification je stánek pro mnoho neoliberálních ideálů; zejména myšlenky, jako je bootstrapping a soběstačnost jako konečný cíl / ukazatel úspěchu.
Zde je stručný přehled o tom, jak používat naše webové stránky.
- Vysíláme oznámení, když letenka jde do prodeje.
- Poskytujeme odkazy na místa, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti jsou v plném blogu.
Udržujeme seznam příkladných termínů rezervací pro každou nabídku, kterou zveřejňujeme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Nepředstavitelný strach, hrůza a vysídlení je však zanechaly s neviditelnou jizvou traumatu.
Toto úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby projednala, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli duševní zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže projít touto cestou.
Hromada lesklé nové dobroty v # dart
Postupem času se šipka stala mým go-to pro rychlé uživatelské rozhraní.
S # flutter je radost pracovat a mají # mobx pro snadnou správu obchodu.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, že flutter je opravdu špatný, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i flutter web target je na hovno).
Ale umožňuje rychlý pohyb, a proto je ideální pro malé hacky.
Ježura s ametystovými a purpurovými hroty.
Jsou průměrné výšky, má průměrnou stavbu a svalnatý.
Jejich ocas je extrémně silný.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškovité a nosí šarlatové brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Schopnost skákat opravdu vysoko, trhat běžné lidi na kousky, používat strašidelné magické síly a doplňovat zdraví tím, že hodujete na svých nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové, kteří se snažili, aby vypadali špatně - všichni.
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
V reálném životě se mé matce líbila logická hra, kterou jsem udělal před lety, a našla většinu tajemství sama, takže nebyla jen matkou, když řekla, že se jí to líbí.
Tak třeba se jí moje porno hra bude taky líbit?
Možná má příliš mnoho jazykových jemností.
Musím to přeložit do mandarínštiny a / nebo Hokkien, z nichž ani jeden vůbec nevím.
Asi budu muset zjistit, zda Bing nebo Google je lepší při překladu špinavé gay sex hříčky.
Chvíli jsem si pohrával s touto myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od "běžného" zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku, stejně tak otázkou zdraví jako zdraví vašich nohou.
Intersex je dokonce uznáván TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejným způsobem, že duševní zdraví je mnohými vnímáno jako méně "skutečné" než fyzické zdraví, mám pocit, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více mi tvrzení "Mé pohlaví je mužské, mé pohlaví je ženské" připadá zjednodušující a nepřesné.
Skoro to vypadá, že část argumentu postoupí TERFům.
Myslím, že být trans znamená být "biologicky nebinární".
Moje pohlaví je nebinární, moje pohlaví je žena.
Myslím, že označení "nebinární" musí být rozšířeno z pouhého genderového termínu, který má být používán při odkazování na pohlaví.
Byl jsem, zapnuto a vypnuto, poslech děl @ iotar
V nedodělcích tohoto tajemného kolektivu je spousta dobrých věcí.
Stejně jako krautové nálady a jiná světoborná pop music a radiofonní dílna a všelijaké.
Velmi stojí za to mít jít na.
Také se mi líbí rozhraní archive.org mnohem více než desktop # bandcamp\ - Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrát s flutterem.
Nerad bych založil své podnikání na technice od společnosti Google, abych byl upřímný, na druhou stranu je Google jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého zážitku mezi platformami a ukazuje to.
(A také: Web je nyní do značné míry věc Google, bohužel)
Také se prosím zdržte toho, abyste mi řekli, že aplikace Google / flutter sají na iOS a macOS.
Cross platform je těžké, pokud to chcete dělat dobře.
To já vím.
Děkuji těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Ukázalo se několik velmi malých obtíží.
Nic, co by vyvolalo poplašné zvony, ale přesto jsou řešeny.
Příští týden bude vydána malá aktualizace, která je opraví.
Většina včerejška byla věnována instalaci nové aktualizace pro některé zákazníky a všichni, kteří potřebují tuto pomoc, by ji měli dostat.
Přeji hezký den!
Technické přiznání: Nemohu zabalit hlavu kolem Grafana & Prometheus, alespoň z hlediska metriky serveru / aplikace a monitorování.
Nevím přesně, proč můj mozek nemůže přijít na to; mohlo by to být, že nástroje jsou prostě tak široké a vágní, že můj mozek prostě hardlocks kvůli "příliš mnoho možností."
Chci dělat dashboardy.
Grafana vypadá pěkně.
Mozek bez práce.
Takže s blížící se novou úrovní raidů # FFXIV jsem si dlouho myslel: "Člověče, rád bych zkusil pořádný nájezd, ale Party Finder zní jako nepořádek a nikdy nenajdu statiku, která mě bude mít."
Tak jsem si řekl, seru na to!
Udělám si vlastní statiku!
Plné lidí, kteří jsou příliš dychtiví na to, aby se pokusili připojit k nájezdu statické, bez očekávání, že budou vůbec dobří!
Neexistuje... žádný způsob, jak by to fungovalo, pravděpodobně!
... A tak jsem se přistihl, že musím utřídit soupisku raidové skupiny.
V mládí jsem byl nenasytný čtenář.
Pak život rozdrtil mou duši a já ztratil veškerou svou vášeň pro fikci a skvělé vyprávění.
Ale po ~ desetiletích ~ čtení téměř nic (s výjimkou funkčních pracovních nefikčních věcí a příležitostné svépomocné knihy) jsem si stanovil cíl přečíst 23 knih v roce 2023.
Teď jsem na knize # 31 a je teprve květen.
Jsem ZPĚT, zlato!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou pár lidí přišlo v soukromí a řekli: "Podívejte, díky vaší práci vám poskytnu tuto částku peněz."
Chci vidět tyto společnosti, které zprostředkovávají transakce, vysvětlovat svým zákazníkům, jak nastavují svá procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud bude mít Spotify dobrý kvartál, budou.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vydlabaná a rozpadající se města po celé zemi.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pro-diktátorské pravicové křídlo.
Deportujte bílé supremacisty.
Jsem tak unavený z titulků, které tvrdí, že "práce na dálku je mrtvá." Nebo že "práce na dálku byla neúspěšným experimentem."
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno clickbait, ale dělá mi starosti o vedoucích pracovníků a manažerů, kteří čtou tyto články.
Před rokem 2020 existovala práce na dálku.
Stále budou existovat pracovní místa, která mohou být v dohledné budoucnosti provedena na dálku.
Vzdálená práce je umožněna.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které odvádí čas od jejich dne a jejich rodin.
Ignorovat tato fakta je špatně.
Přestaňte generalizovat a snažte se pochopit, jak vaši zaměstnanci skutečně pracují.
# WFH # podnikání # neurodiverzita
Není to jen konzervativci versus progresivisté, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Je to válka mezi pro-lidmi a anti-lidmi," řekl.
Parker odkazoval na potrat a impuls moderních městských žen, aby odložily děti kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost v zájmu životního prostředí.
"Vy jste uhlík, který se snaží snížit."
Takže jako od začátku pro všechny mé narozeniny v minulosti, vždycky jsem měl ty drsné.
Vždy, když se objevil květen, bál jsem se, že se pokusím oslavit své narozeniny.
Vždy se něco stane, pokazí, nebo prostě skončí stresující a depresivní.
V průběhu let jsem bojoval, abych se dostal z tohoto myšlení a měl lepší narozeniny.
Trvalo to roky, než jsem změnil svůj život a tvrdě pracoval, ale nakonec.
Začínám se usmívat a užívat si narozeniny bez starostí.
A dnes se již stává velkým dnem!
Zima je za 30 dní v této malé části Velkého Jižního světa.
Ale já se nedám oklamat!
Tohle je začátek.
Prší a dokud nemrzne, nebudeš v něm tancovat!
Je to dobrý den na objednání dodávky zmrzliny.
Byla to jedna psí noc a ten pes se nedostal z postele ani na "Psí snídaně - Snídaně pro psy!"
Vložku si zapíšu na zip do cyklistické bundy - pro případ, že ji budu potřebovat uvnitř.
Znáte výkonný způsob, jak webová komponenta reagovat na přidání / odebrání z dokumentu?
Jedná se o knihovnu komponent Wikipedie (OOUI).
Je to většinou sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
V současné době používáme MutationObserver hack.
Kvůli výkonu nesledujeme celý dokument.
Vytvoříme odděleného dočasného rodiče, nainstalujeme tam MO a pozorujeme, jak se odděluje (a tak je připojen jinde).
Casper # rat je v těchto dnech absolutní jednotkou.
Myslím, že moje nová práce pro něj byla dobrá - dva volné roamingy denně, když pracuji, v poměrně předvídatelných časech.
Konečně mám dobrou fotku, takže si můžu být jistý, že není tlustý.
(U # krys může být příliš vysoký tělesný tuk špatný pro jejich zdraví.)
Není.
Je naprosto zničený z toho, jak se dvakrát denně motá kolem mé kanceláře.
Nemám váhu, abych ho vážil, ale má pocit, že je hodně přes kilo.
Jsem tak šťastná, že ho vidím vzkvétat.
Dnešní zpráva o postupu Aerostrike:
1) Mírné úpravy rozložení mapy Hel 's Fighters.
Navíc je menu mapy plně funkční!
2) Systém měnových odměn byl připojen.
Zítra se bude testovat různými bitvami.
Deštivé dny!
Minulý týden jsem udělal tunu a cítil se mnohem lépe o položkách v terénu.
Přesazují se všechny obojky, kapusta, mangold.
Plánuje nastavit v salátu v Penn na 6row vzoru a uvidíme, jak to ve srovnání s vysílacími osetých lůžek.
Jarní hrášek v Gilpinu se ukazuje, takže je třeba nastavit mřížku.
Také je třeba zasít salátovou řadu, aby se integrovala nakrájená zeleň v obou vyškolených posádkách na zavlažování, přípravu postele a přesazování, což je 90% nesklizňových dovedností
Je to 2023 a stále vidím, že lidé s iPhony se aktivně vyhýbají používání Apple Maps.
Apple Mapy jsou standardně dodávány s iOS, a přesto by se lidé snažili stáhnout a nainstalovat Mapy Google do svých iPhonů.
Netuším proč.
Zvědavý, nechal jsem si otevřenou mysl, abych porovnal, jak se porovnávají Mapy Google a Mapy Apple, na mém testovacím zařízení iPhone (můj denní řidič je zařízení Android, takže je vzácné, že používám iPhone).
Zkušenosti s následováním pokynů byly v Mapách Apple mnohem lepší ve srovnání s Mapami Google.
Apple Maps vítězí.
Tak proč je to, že lidé skákají přes další obruče, aby nainstalovali Mapy Google?
Žádný nápad.
Je možné, že se Google Maps dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že vyhledávání Google je integrováno s Mapami Google?
Žádný nápad.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch toho, abych koncovým uživatelům nevypouštěl odpadky, a Apple královsky posral své Apple Maps, když vyšel v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to země, která z ní dělá dobrého skladovatele bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a je třeba ho vyměnit.
Mnoho lidí si myslí, že doslova vlastní zemi, když si koupí kus.
Není tomu tak.
V Číně si můžete pronajmout pouze pozemek.
Nejsou tak hloupí, aby prodávali navždy.
Vláda může tuto politiku kdykoli změnit.
Pozemek je provizorní.
Zdá se nepředstavitelné, že vám jednoho dne může být odebrána půda, když sledujete australské a americké mediální kanály, ale to proto, že bohatí jsou tam celý den, aby zajistili, že vaše mysl myslí určitým způsobem.
Země je velmi snadno a rychle odebrána vládou jednoho dne, pokud to chtějí udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si PPL může ponechat půdu na úkor jiných.
Jednoho dne to musí být odstraněno.
To je důvod, proč Číňané umožňují pouze pronájmy.
Už jim došly pozemky.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem investorům připíjím na váš úspěch a uskutečnění vašich snů.
Pokračujme ve společné práci na vytvoření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
# Robecofirm # geolog # podnikání # udržitelnost # úspěch # přátelství # přípitek # sny
Často se podivuji nad lidskou schopností být * tak * na sebe, zatímco je zaplavena tolika důkazy o tom, jak vypadá skutečná krutost.
Agonizovat nad osobním selháním a vinou ve světě, kde je "úspěch" tak často udělován lidem odpovědným za nejtrestuhodnější činy.
Všichni jsme taková nepořádná stvoření.
Ale mírnění zoufalství nad naší chaotičností je klíčové - protože nám dává více prostoru vypořádat se s troskami všude kolem.
Tak se snaž nezapomenout, ne?
Laskavost k sobě samému je také aktivismus.
Někteří programátoři: "Na rychlosti psaní nezáleží!"
Nebo "Modální editory jsou dnes k ničemu": Morty:
Já extrahuji funkcionalitu svých # Axum projektů do sdílených knihoven: "Hold my keyboard": Partyparrot:: Helix:: Ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup pro sdílení, ale zatím se mi to líbí: < URL >
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva tohoto týdne na Revelations je Zůstaňte vzhůru celou noc.
Už pár dní si pohrávám s tímhle kouskem na hlavě.
Je to rozhodně více romantika než špína.
Možná jsem četla mnoho románů s nemožným "meet cutes" a tohle je výsledek, ale líbí se mi to.
Také jednoho dne budu úplně dělat míli vysoký orgasmus, možná ne se str
Nesouhlasím s tím, že # Mastodon je obtížné nastavit.
Obyčejně, to opravdu není tak těžké.
Ale je obtížnější najít lidi, kteří budou sledovat a budovat vaši časovou osu.
Kéž by existovalo nějaké doporučení "koho sledovat."
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany, jako je Elk a / nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá a necítí se dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali, a pravděpodobně potřebujete dobrou aplikaci pro zlepšení # UX.
Nevím, jestli je prevence možná, ale stojí za to to zkusit.
Čtyři kroky, které jsem nastínil, jsou předmětem diskuse, s určitým pokrokem v každém z nich:
Popis: Názvy incidentů chování lidského algoritmu, které odpovídají algoritmům a lidem.
Vysvětlení: Zohlednění obou stran vzájemného vlivu
Předvídání: Předvídání škod dříve, než se stanou (i když o minuty)
Intervence: Znalosti o věcech, které můžeme udělat, abychom vytvořili změnu, v určitých mezích důvěry
Nesledoval jsem radnici CNN, ale zdá se, jako by Trump řekl přesně ty samé věci, které říká pokaždé, když otevře ústa nebo stiskne tlačítko Odeslat na svém telefonu.
I kdyby se mu je nepodařilo říci během radnice, všichni v Americe je stejně uslyší, opakovaně, od nynějška do listopadu 2024.
To stále není důvod, proč mu dát jiné místo, ale škoda je přehnaná.
Vyhraje primárky.
Nemůžeme ho chtít pryč.
Je tady a bude to říkat, ať se děje, co se děje.
Přihlásil jsem se na čekací listinu Google "AI Test Kitchen" a dostal se do stejného dne.
V tuto chvíli je to velmi podbízivé.
"MusicLM Demo" je mírně zajímavé.
Můžete požádat o konkrétní kus hudby, jako je "jazz s trubkou sólo v 5 / 4 tempo" a to bude generovat dvě skladby pro vás po několika sekundách.
Zdá se, že rozumí tempu, ale. hudba jen. není dobrá.
Házet všechno, co máte, přes plot v reakci na GPT není ono.
Zkuste raději Google.
Je to divné dělat vzpírání, ale také nemají ponětí, co vaše one-rep-max je, cus to je jeden z klíčových způsobů, jak lidé sledovat jejich pokrok.
Cvičím sám ve své ložnici bez spottera nebo dokonce stojanu na závaží.
Jen já a činka s hromadou závaží.
Mám bench press na posteli.
Pokud se pokusím přijít na to, že můj jeden rep max je, možná nebudu mít dostatek závaží, abych maximalizoval, nebo naopak by mě to mohlo vážně zranit / zabít.
Každopádně zatížení jde dnes nahoru.
Pořád se cítí dobře.
Přísahám, že burrata před pěti lety neexistovala
To je můj osobní Mandelův efekt.
Nikdy jsem to neviděla v kuchařce.
Nikdy jsem ho neviděl v luxusním hokynářství nebo v nějakém italském lahůdkářství.
Nikdy jsem neviděl, že by to něčí máma udělala, nebo mi to strčila na párty nebo viděla, že se objeví ve spojení s někým, kdo dělá omáčky nebo pečení.
Prostě se to jednoho dne objevilo a najednou to bylo dostupné všude.
Vstoupil jsem do dimenze burraty.
Drakeův stárnoucí iPad se rozdává, takže je na trhu pro nový tablet.
Protože jsme se zde radikalizovali, zdráháme se koupit si nový stroj FAANG *.
Má někdo linuxový tablet, který miluje?
To by bylo hlavně pro prohlížení webových stránek, příležitostný e-mail a některé hry.
V letech 1998-06 GameFan, ve vztahu k dlouhému vývoji první Unreal hry, Jason Schrieber poznamenal:
"Dobrá hra přichází pozdě, dokud se neobjeví.
Špatná hra je špatná navždy. "
Takže to byl Epic, kdo tohle vznikl?
Můžeme pokračovat dál.
Dřívější vydání GamePro 1997-11 má citát s mnohem větší nejednoznačností,
"Nebo, jak říká průmyslová fráze: Pozdní hra je pozdě, dokud není odeslána.
Špatná hra je špatná do konce života. "
Je to tedy tak pomíjivé?
Pouze "chytlavá fráze" bez jasného původce?
Smoky, můj 10měsíční kocourek Domestic Blue, si hraje s červeným gumovým komfortním zařízením Apple Pencil, které koupil od Amazonu, před několika měsíci utekl.
Nosí ho v puse hrdě po celém domě a já se jen musím vnitřně smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsme absolvovali kompletní zpáteční cestu v novém vlaku ICNG.
Moc se mi líbí.
ESP kočáry s většími okny.
Existují oblasti, které by mohly použít nějaký polština.
Konkrétně nedostatek dostatečných košů a nedostatek značek, které by vysvětlovaly význam barev osvětlení.
Opravte tyto drobné problémy, a pak můžeme mít více z nich, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Jedno pravidlo na zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo stojí ve frontě, mohl dostat své ruce na desku.
Můžete si koupit jednu z výše uvedených desek, ne jednu z nich.
Neexistují žádná omezení nákupu Picos nebo jiného zboží.
Včera jsem se nejlépe bavil se svým kamarádem a bývalým kolegou rabínem.
Navštívili jsme na pár hodin na mé verandě.
Takové přátelství překonává rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Pán ti žehnej a opatruj tě!
A bažina se zazelenává.
Docela se mi líbí software akkoma a název domény, který jsem dostal pro svou instanci.
Ale mám pocit, že jsem nějak začal tuto instanci na špatné noze, abych tak řekl.
Nikdy jsem se tam necítila pohodlně.
Ještě chvíli zůstanu tady a budu přemýšlet, jestli mám vůbec migrovat.
# FalconGameBooks
Zdá se, že osmiocí Repnidi se dívají, když leták položíte na červenou půdu, ale nehýbou se k vám, ve skutečnosti jsou nehybní, když vylezete z letáku a pomalu jdete k nim.
Země pod vašima nohama se začne třást a pak třást, jako při zemětřesení a vy ztratíte půdu pod nohama, i když Repnidi se zdají být nedotčeni.
Kámen pod vámi náhle povolí.
Repnidi se tunelovali pod povrchem a vy spadnete do vroucí masy stovek Repnid těl v jeskyni pod vámi.
Konec je rychlý, protože několik párů tesáků vstřikuje svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl první budoucí cestovatel.
Přistanete nosem letáku nahoru na straně hromady strusky a vylezete ven.
Zdá se, že osmiocí Repnidi se dívají, ale nehýbou se k vám, ve skutečnosti jsou nehybní, když pomalu jdete k nim.
Zastavíš se ještě na hromadě rozpadlé skály a zeminy a promluvíš k nim, říkajíc: "Přicházím v míru, jako přítel."
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš Univerzální Překladatel nepřijímá žádnou odpověď.
Rozhodnete se použít své psychické vědomí, abyste je mentálně kontaktovali.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a vaše mysl se od kontaktu odvrací.
Rozhodnete se, že opětovné navázání kontaktu by bylo nebezpečné a vrátíte se do svého letáku, ale tato zkušenost vyčistila vaši mysl, která byla zmatená od té doby, co jste skočili do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je docela snadné naplánovat kurz na Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[Pokračování]
# Dnes mám kávu, sluníčko a klid!
Začala jsem nový šál.
V tuto chvíli si tím nejsem jistý.
Našla jsem nerovnoměrně spředenou stříbřitě šedou přízi, která je většinou jemně spředená s hrudkami.
Plánuji ho smíchat s jemnou fialovo / šeříkově pestrou bavlnou.
Ale nejsem si jistá, jestli mám dost té fialky.
Používám H háček s podobným dvojitým háčkovaným vzorem, jako jsem to udělal předtím.
První díl jsem dotočila včera, tak uvidíme.
Přeji všem šťastný čtvrtek!
Nesnáším však hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Zkoušel jsem doslova a do písmene každý z nich.
A až do doby před dvěma lety jsem neměl tušení, dokud jsem nezkontroloval své přepisy.
Ještě horší je nenávist třídy literatury: Miluji čtení.
Většinu klasiky jsem narazil před osmnáctým rokem - i když to je spíš odraz života v bumfuck nikde, také jsem v zoufalství četl Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a jsem tam šťastná, ale musím být někde jinde, abych se dostatečně ochladila, abych si během dne četla beletrii bez pocitu viny.
Je to jako bych byl na dovolené, a proto dělám to, co člověk dělá o svátcích.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma a trochu jsem se # MECFS vymanil z toho, že jsem prostě v cizím prostředí, kde jsem méně schopen se pohybovat a musím si pamatovat, kde jsou věci.
A to i přesto, že stále mám svůj seznam úkolů a organizuji svůj život.
Lidstvo je pryč za 5 dní.
Je to vzrušující, nervy drásající, stresující, a všechny dobré věci, které mám rád o práci ve hrách.
Co si o tom budou lidé myslet?
Líbí se mi to, ale bude schopen přilákat publikum správných hráčů?
Rozkvete komunita kolem uživatelsky generovaného obsahu hry?
(Opravdu v to doufám.)
Příběh hry, nápady a otázky, které inspiruje, jsou aktuální.
Doufám, že všechno půjde dobře.
Je to ThinkPad den!!
Přišel jsem domů o polední přestávce, abych viděl, jak sedí venku uwu.
Přál bych si, abych to mohl vzít zpět do práce se mnou, abych vytvořil více.
Ale to bude muset počkat do večera.
Tak jsem se konečně podívala na # Heartstopper
Bylo to příliš roztomilé na to, aby to bylo twee?
Zcela určitě
Mluví některé z těchto postav lidsky?
Ani vzdáleně
Ale miloval jsem to?
Naprosto!
Co tu dělá Olivia Colemanová?
Dlužila někomu peníze?
Měl nedávno absolvent umělec vzít nějakou kritiku špatně dnes večer.
Částečně proto, že by se špatně učili.
Ale je důležité nevymlouvat se na problémy a jen je opravit, zejména ve výrobě, když vaše vedení potřebuje změny.
Hlavně s tou konkurencí.
Každý umělec tam byl, dělal stejné chyby.
Dobrá kritika je tam, aby problém rychle opravila, a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost vyřešit problém nebo najít řešení.
Takže zatímco kompostování a rolování květů jsou nádhernou připomínkou, abyste se podívali nahoru a byli si vědomi života za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte semena, která jsou zaseta a kultivována (a ne náhodně rozptýlena) dobrými liďáky.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu vzkaz podstrčila, když se míjeli na pěšině, těsně před psí hlídkou.
Byla na cestě ke zdi, on odcházel ze služby.
Ohlédl se za sebe, aby se podíval, jak odchází, a ujistil se, že je nikdo neviděl.
Ani se neohlédla.
Počkal, až se octne ve tmě palandy, vytáhl lístek a přečetl si ho v paprsku světla, který pronikal zatemňovacími závěsy.
Jedno slovo vytištěné na bloku.
Dlouho na ni zíral a snažil se zůstat klidný:
V poslední době jsem se setkal s některými úžasnými novými kamarády # Mastodon a chci udržet trend.
Volání do # Fediverse mi dává pocit, že velryba zpívá přes obrovský oceán!
Chcete se připojit k mému "pod"?
Rád bych se spojil s více.
Každý, kdo má vlasy v ohni o CNN, může poděkovat Stephenu Colbertovi za tvrdou pravou zatáčku.
Pomohl udělat z Chrise Lichta národní problém.
I když se nám někteří lidé mohou líbit, pokud fašistům jen poskytují kariéru nižší ligy, pravděpodobně by ji měli nosit.
Bylo to poprvé (ale nebude to naposledy), kdy Kaveesha Dilhari zaznamenal 20 + běhů a vzal 2 + branky ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilném protestu před britským hotelem pro uprchlíky
Incident přichází po nárůstu počtu uprchlíků a žadatelů o azyl překračujících kanál La Manche do Spojeného království na člunech.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem, který slouží k ubytování žadatelů o azyl, stala násilnou poblíž anglického města Liverpool.
Policejní oddělení Merseyside uvedlo, že policista a dva civilisté utrpěli lehká zranění během výtržností v pátek v noci v Knowsley.
Policie uvedla, že někteří protestující házeli předměty a zapálili policejní dodávku.
Lidé ve věku od 13 do 54 let byli zadrženi "po násilných nepokojích."
Policejní komisařka z Merseyside Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zraněných."
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje Knowsley v britském parlamentu, řekl, že násilí v pátek v noci neodráží komunitu.
"Lidé z Knowsley nejsou fanatici a vítají lidi, kteří utíkají z nejnebezpečnějších míst na světě a hledají bezpečí," dodal.
"Ti, kteří dnes večer demonstrují proti uprchlíkům, nereprezentují tuto komunitu."
Protest se konal uprostřed zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů překračuje kanál La Manche v malých člunech.
Více než 45 000 lidí se touto cestou dostalo do Spojeného království v roce 2022 a většina požádala o azyl.
Systém posuzování žádostí o azyl se zpomalil kvůli politickým nepokojům a byrokratickým průtahům, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Překročení Lamanšského průlivu se stalo politickým problémem, kdy konzervativní vláda slíbila, že "zastaví lodě" a bude pokračovat v plánu poslat takové žadatele o azyl do Rwandy.
Odpůrci obvinili vládu, že démonizuje zoufalé lidi prchající před válkou a chudobou.
President 's Cup: Candystripes porazili Rovers v úvodním zápase sezóny v Brandywellu
Záložník Derry Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City zvítězilo v Prezidentském poháru, když zvítězilo 2: 0 nad Shamrock Rovers.
Držitelé Poháru FAI porazili vítěze minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops ve druhém poločase tlačili na snížení, ale svěřenci Ruaidhri Higginse stáli pevně, aby vyhráli oponu.
Derry cestuje do St. Patrick 's Athletic na zahájení ligy příští pátek.
Patchingův boční volej posunul Derry dopředu po 23 minutách - záložník otevřel skóre, když Foylesider vyhrál 2-1 nad možnými šampiony loni v únoru.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy brzy dostal City dále do vedení s dalekonosným úsilím, které se podařilo kroutit pod brankářem Leonem Pohlsem a do sítě.
Druzí v minulé sezoně měli o přestávce dva góly k dobru.
Graham Burke šel nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byly pohodlné vítězové týden před jejich hledání národní slávy.
Šéf City Ruaidhri Higgins pochválil svůj tým po tom, co řekl, že to byl "nejtěžší týden mého života" po smrti svého bratra Kevina.
"Je to kopanec do zubů a čekají nás těžké týdny, ale na jeho památku v tom budeme pokračovat," řekl Higgins.
Porazit Shamrock Rovers a zaslouženě tak dobrým výkonem je opravdu potěšující. "
DHS najme právnickou firmu, aby se zabývala možným řízením o impeachmentu Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti najalo externí právnickou firmu - Debevoise & Plimpton - aby pomohla v případném řízení o impeachmentu pro ministra Alejandra Mayorkase, protože potenciálně čelí obvinění ze strany republikánů ve sněmovně ohledně jeho zacházení s jižní hranicí.
"Ministerstvo vnitřní bezpečnosti si ponechalo externího poradce, aby pomohlo zajistit, že životně důležitá mise ministerstva nebude přerušena bezprecedentním, neoprávněným a stranickým impeachmentem některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl mluvčí DHS.
"DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečit naše hranice a zároveň odpovídajícím způsobem reagovat na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS."
Úředník DHS řekl CBS News, že ministerstvo najalo firmu na smluvní práci po dobu trvání kongresového vyšetřování.
Debevoise byl vybrán kvůli svým odborným znalostem v oblasti impeachmentu a oboustranným zkušenostem při práci s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
Olivier DOULIERY / AFP přes Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise se kvalifikuje jako vhodné výdaje pro DHS.
DHS se snaží zajistit, aby jeho poslání nebylo podkopáno partyzánskými útoky a aby řízení proti Mayorkasovi bylo vedeno lidmi s příslušnými odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na dotaz ohledně vyšetřování impeachmentu minulý čtvrtek řekl novinářům: "Budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s minulým Kongresem. Myslím, že je to naše odpovědnost."
Připustil, že "bude nějakou dobu trvat," než vyhoví vyšetřování Sněmovny.
Strávím ten čas stejně jako ostatní a také nebudeme dělat kompromisy ohledně času, který strávíme plněním našeho poslání. "
Vysoký představitel DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím poradcem.
Pouze jeden člen vlády byl kdy obžalován, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulysses S. Granta, obviněn z přijímání úplatků, ale nakonec byl osvobozen Senátem.
Trendy novinky
Díky za přečtení CBS News.
Čtyři teenageři obviněni z útoku na 14-letého, který zemřel na sebevraždu po bití video bylo zveřejněno on-line
Otec říká, že dcera si vzala život poté, co byla šikanována ve škole NJ
Táta říká, že dcera si vzala svůj vlastní život poté, co byla šikanována ve škole NJ 02: 33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem na 14letou dívku, která si později vzala život poté, co video incidentu bylo zveřejněno na sociálních médiích.
Jeden mladistvý je obviněn z napadení s přitěžujícími okolnostmi, dva mladiství jsou obviněni ze spiknutí s cílem spáchat útok s přitěžujícími okolnostmi a jeden mladistvý je obviněn z obtěžování, řekl prokurátor Ocean County Bradley D.
Čtrnáctiletá Adriana Kuchová byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na střední regionální škole.
Na videu je vidět, jak dívky házejí na dívku pití, pak ji kopnou a táhnou po školních chodbách.
Adrianu strčili do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kucha opakovaně udeřila.
Další dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli, aby rozbili útok, přičemž jeden dospělý vytáhl dospívající od sebe.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: "To je to, co dostanete."
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali," řekl její otec Michael Kuch CBS New York ve čtvrtek a dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
14letá Adriana Kuch zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojující video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že policie měla být zavolána okamžitě, protože studenti, se kterými podle něj měla jeho dcera problémy, jí rozbili obličej lahví o objemu 20 uncí.
"Kdyby zavolali policii a provedli vyšetřování, ty dívky by videa ze školy nezveřejnily," řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
"Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni," řekl CBS New York Dr. Triantafillos Parlapanides, superintendant škol.
Představitelé školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jejich opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních vystoupení, řekl prokurátor CBS News.
Studenti ve škole uspořádali ve středu stávku na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v emocionální tísni nebo sebevražedné krizi, můžete se obrátit na linku 988 Suicide & Crisis Lifeline zavoláním nebo zasláním textové zprávy 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Pro více informací o zdrojích péče o duševní zdraví a podporu, National Alliance on Mental Illness (NAMI) HelpLine lze dosáhnout od pondělí do pátku, 10: 00-22: 00.
Et, na čísle 1-800-950-NAMI (6264) nebo e-mailem info @ nami.org.
Mluvil jsem s 30 odborníky na zdraví a wellness o tom, jak se vyhnout vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v našich zaměstnáních.
To může být velmi obtížné pro ty, kteří ve zdravotnictví, což je důvod, proč jsem se zeptal 30 zdraví a wellness profesionály stejnou otázku: "Jak spravovat svou energii a ne vyhořet ve své profesi?"
Jejich kariéra se pohybuje od lékařů infekčních nemocí přes psychology až po učitele všímavosti - a všichni měli skvělé rady, jak zůstat motivováni a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, které vynikly jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři hlavní přístupy, které používají.
1.Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají smrtelné nemoci, Eufrosina Youngová děkuje svému silnému podpůrnému systému za svou schopnost udržet si energii.
Young je certifikovaný neurolog a specialista na ALS na neurologickém oddělení Upstate University Hospital a říká, že se tam "mobilizují jako armáda lidí."
Neexistuje lék na amyotrofickou laterální sklerózu (ALS), ale s vědomím, že není jediná, kdo se věnuje tvrdé práci při vývoji léčby a poskytuje lepší možnosti pro své pacienty, udržuje Young i v nejtěžších dnech.
"Neneseme tíhu světa, ale jsme součástí světa lidí, kteří se za tuto práci zasazují," říká.
2.Odpočiňte si, když potřebujete
Práce na dvou místech jako výzkumník spánku a inženýr algoritmů, to vše při péči o nové dítě, by určitě vedlo Raphaela Vallata k vyhoření, kdyby si neodpočinul, říká.
"Mám pocit, že když se chystám vypálit, v podstatě každý úkol se cítí jako hora, kterou musíte vylézt, a cítí se velmi naléhavý a důležitý," říká Vallat.
V těch chvílích "si opravdu potřebujete vzít nějaké volno a uvědomit si, že tyto úkoly mohou počkat."
Vallat si ve svém dni obvykle najde chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
Být vášnivý o tom, co děláte, a pamatovat si svůj účel
Až do jara 2022 pracovala specialistka na infekční onemocnění Céline Gounderová 100 hodin týdně po sedm dní v týdnu.
Být na frontách během pandemie jí sežralo téměř všechen čas, ale vyhnula se vyhoření tím, že si připomněla, proč je její práce důležitá.
"Nemyslím si, že práce se cítí jako práce, když máte pocit, že máte vliv," říká Gounder.
"Pokud pracujete šílené hodiny a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu potřebujete ustoupit a ptát se, co děláte."
4.Mějte i jiné radosti
Všichni odborníci uvedli, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je nesmírně důležité mít život, který si užíváte, který přesahuje to, čeho dosáhnete ve své práci, říká Christina Maslach, sociální psycholožka, profesorka psychologie v důchodu na UC Berkeley a autorka knihy "The Burnout Challenge: Managing People 's Relationships with Their Jobs."
"Podívej se na svůj život jako na celek a ujisti se, že jsou v něm dobré věci, a ujisti se, že na ně máš čas."
Získejte zdarma CNBC Warren Buffett Guide to Investing, který destiluje miliardářovu nejlepší radu č. 1 pro pravidelné investory, dělá a nedělá a tři klíčové investiční principy do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Získejte chytřejší informace o svých penězích a kariéře s naším týdenním zpravodajem
Mladistvý obviněn z vraždy při prosincové střelbě v Chicagu, která zanechala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě dvou studentů na střední škole v Chicagu v prosinci, oznámila v pátek policie.
Podezřelý je obviněn ze dvou vražd prvního stupně a dvou pokusů o vraždu, oznámil šéf chicagské policie David Brown.
"V současné době nemáme jasný motiv, proč by šestnáctiletý chtěl střílet a zabíjet jiné děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběti, které zemřely, byly oba chlapci ve věku 14 a 15 let, oznámila policie.
Vyšetřovatelé říkají, že tipy od veřejnosti jim pomohly vést k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděčni těm, kteří měli dost odvahy, aby se ozvali a zajistili, že pachatel bude dopaden a hnán k odpovědnosti," uvedla státní zástupkyně Kim Foxxová.
Očekává se, že se podezřelý objeví v sobotu u Bond Court, řekl Brown, kde budou představeny další podrobnosti o důkazech, které shromáždili.
Biologové z Minnesoty zachránili uvězněného černého medvěda
Ministerstvo přírodních zdrojů Minnesoty přišlo na záchranu medvěda, který se ocitl v pasti v příkopu.
Medvěd se schoval v propustku podél silnice poblíž Wannasky v Minnesotě, podle příspěvku na Facebooku z oddělení.
Ale když sníh začal tát, propustek začal zaplavovat a podle oddělení uvěznil medvěda v hlubokém sněhu a ledu.
Pracovníci z oddělení rychle zareagovali na scénu a pomohli medvěda odstranit.
Medvědí biolog oddělení, Andrew Tri, "zkoumal medvěda a prohlásil ho za zdravého, ale omámeného - zřejmě proto, že byl probuzen ze zimního spánku," podle příspěvku na Facebooku.
Ministerstvo poté přemístilo medvěda do státní rezervace, aby mohl pokračovat v hibernaci.
Ospalý masožravec byl odhadnut na 6 let a mezi 375 a 400 librami.
Ministerstvo připomnělo obyvatelům, že stěhování medvědů je práce, kterou je nejlepší nechat profesionálům.
Pokud se obáváte medvěda ve vašem okolí, měli byste kontaktovat místní úřady - nesnažte se hýbat nebo krmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tarts, salátu a kočičího jídla Fancy Feast.
Ale naštěstí pro dobře míněné kopáče, "protože medvědi nemají v zimě chuť jíst, medvěd nekousl."
Minnesota je podle ministerstva přírodních zdrojů domovem 12 000 až 15 000 černých medvědů, kteří se nacházejí hlavně v severní třetině státu.
Dravci hibernují po dobu šesti až sedmi měsíců v zimě, během které nejedí a žijí ze svého uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedl generální tajemník Nejvyšší rady pro památky v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a prezident Španělské národní výzkumné rady (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise od Nejvyšší rady pro památky a CSIC, která pracuje od roku 2002.
Řekl, že mise provedla výkopové a restaurátorské práce a zveřejnila výzkum související s hrobkami, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahrady.
Významné hrobky z významné doby
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili na počátku 18. dynastie Nové říše - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že uspořádání hrobek je ve tvaru T, což je styl běžně používaný v hrobkách z 18. dynastie.
Jedná se o vchod, sloupovou halu vedoucí k pohřební šachtě a stěny s výraznými nápisy.
Waziri dodal, že Djehuty byl za vlády královny Hatšepsut dozorcem státní pokladny a dohlížel na díla řemeslníků a umělců.
Djehuty byl také zodpovědný za záznam Hatšepsutovy cesty do Puntlandu a poskytování elektra (směs zlata a stříbra) pro pokrytí vrcholu obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
Místnost, která předchází pohřební komoře Djehuty, obsahuje nápisy vyryté 43 kapitolami Knihy mrtvých, poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátně a papyru.
Hery, zastával funkci superintendenta královských obchodů posvátné královské manželky a matky, Ahhotep.
Jared O 'Mara nikdy neměl být labouristickým kandidátem, říká Rachel Reeves
Bývalý poslanec Jared O 'Mara "nikdy neměl být vybrán jako labouristický kandidát" a zaslouží si čtyřletý trest vězení, řekl stínový kancléř.
Rachel Reevesová hovořila s Guardianem v pátek ve volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odstoupily na protest proti tomu, jak národní výkonný výbor labouristů (NEC) kontroluje parlamentní výběrový proces pro příští všeobecné volby.
Celá výběrová komise v Bolton North East rezignovala poté, co jim nebylo umožněno vybrat užší seznam, což je stále běžnější praxe v Labouristické straně Keira Starmera, a uvedla: "Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místní členy na severu."
"Je to v rozporu s postojem nezbytným k tomu, abychom získali zpět červenou zeď, která je tak zoufale potřebná k vytvoření labouristické vlády."
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Tam byl zvláštní neštěstí, že Leigh Drennan, předseda Labour North West a poradce Jeremy Corbyn-podporující Warrington North MP Charlotte Nichols, nebyl longlisted pokusit se získat místo zpět od konzervativců, a to navzdory sbírání nominací ze čtyř velkých odborů.
Reeves řekla, že nemá nic společného s výběrem kandidátů, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo může být zařazen do užšího výběru."
O 'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné nároky na výdaje v celkové výši 52 000 liber ve snaze financovat své zneužívání kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl řádně prověřen labouristy, když byl vybrán, aby bojoval s Nickem Cleggem, bývalým liberálním demokratickým místopředsedou vlády, v Sheffield Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se v myslích labouristického NEC rýsuje velký debakl O 'Mara, Reeves řekl: "Nechci v žádném případě naznačovat, že někdo, kdo není na užším seznamu, je uživatelem kokainu.
Ale Jared O 'Mara byl hrozný případ.
Nikdy neměl být zvolen labouristickým kandidátem, nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest. "
Okolnosti O 'Mara byly "docela výjimečné," řekla Reevesová, ale uznala: "Pro Labouristickou stranu a všechny politické strany je třeba se naučit důležité lekce o výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě řadou premiérů a pokut a stran a standardů, které výrazně zaostávají za tím, co byste mohli očekávat. "
Dodala: "Jedna věc, kterou bych řekla o Labouristické straně, je, že když lidé dělají špatně, ztratí bič. A to prostě není případ Konzervativní strany."
Archie Bland a Nimo Omer vás provedou hlavními příběhy a co znamenají, zdarma každý všední den ráno.
Oznámení o ochraně osobních údajů: Zpravodaje mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich Zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme Google reCaptcha a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku pro Openreach, která poskytuje širokopásmovou síť ve Velké Británii.
Poté, co sledoval učně, jak šplhají po falešných telegrafních stožárech na místě za 1,7 milionu liber, Reeves diskutoval o plánech labouristů na přepracování učňovského odvodu, který nutí větší firmy, aby odložily 0,5% svých mezd na financování učňů.
Podniky si stěžují, že daň je příliš nepružná. Například, řekl Reeves, Openreach "chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vlákně, ale učňovská daň nemá takovou flexibilitu kolem rekvalifikace."
Reeves řekl, že labouristé změní daň tak, aby firmy mohly použít peníze na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový průmysl a ti, kteří v současné době instalují plynové kotle.
"Potřebujeme je jako součást energetického přechodu na čistou nulu, abychom se naučili dovednosti pracovat na elektrických vozidlech nebo montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se proti nim zvedá učňovská daň.
Podniky chtějí větší flexibilitu a mladí lidé začínají v životě nebo starší lidé, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost, "řekl Reeves.
Jeden zatčený během protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala událost vyprávění příběhů drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově přitěžujícího komentáře vůči policistovi před uměleckou galerií nedaleko Westminsteru.
Nikdo nebyl zraněn a policisté zůstávají na místě, uvedla policie.
Tate hostil Drag Queen Story Hour UK v sobotu, s příběhy vyprávěnými Aida H Dee, který webová stránka galerie popisuje jako "první drag umělec v Evropě číst příběhy dětem v jeslích."
Pravicová skupina demonstrantů demonstrovala před galerií a setkala se s protidemonstranty vedenými aktivisty za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit chodbu, aby se účastníci mohli dostat do místa konání.
Drag queen napsala na Twitteru, že den byl "řádně emocionální" a dodala, že pět protestujících získalo vstup do Tate a "způsobilo narušení" v částech budovy, ale neovlivnilo čtení.
Předtím řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ + bylo "ctí."
Její čtení bylo již dříve terčem demonstrantů.
Drag Queen řekl, že "hodnocení rizik" se konalo předem - ale dodal, že je "směšné," že jsou nezbytné.
Aida tweeted: "5 haters dělal to do Tate. Způsobili narušení. Ale ne Drag Story Hour UK... Udělali povyk jinde v budově, ne tam, kde byla show!! Show 2 šel hladce!!!"
Aida v sobotu v 11: 00, v poledne a ve 14: 00 uspořádala tři vyprávění.
Mluvčí Tate uvedl: "Neprogramujeme umělce, abychom prosazovali určité názory, ani abychom usmířili odlišné názory."
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, s jakými aspekty se zapojí. "
Trumpova ceněná 40 Wall Street staví na "věřitelské hodinky" uprostřed poklesu příjmů: Zpráva
Mrakodrap Donalda Trumpa na 40 Wall Street je pod dohledem věřitelů kvůli klesajícím příjmům a rostoucím nákladům, informovala v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější - vyskočila ve třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání zbývající hypotéky na budovu ve výši 126,5 milionu dolarů, informovala agentura Bloomberg.
Výdaje mezitím údajně vzrostly o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 ohodnocena na 540 milionů dolarů.
V den teroristických útoků z 11. září 2001, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street byla najednou nejvyšší budovou ve městě.
Nejenže bylo jeho tvrzení necitlivé, byla to také lež.
Další nedaleký mrakodrap na Pine Street v Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem výškových kanceláří na Manhattanu již léta klesá, což se zhoršilo po vypuknutí pandemie COVID-19, když mnoho společností zavřelo a zaměstnanci přežívajících firem pracovali na dálku.
Wells Fargo, která obsluhuje hypotéku na 40 Wall Street, "oslovila dlužníka ohledně stavu leasingu" a plánů na zlepšení výkonu nemovitosti, podle podání, informovala agentura Bloomberg.
Majitel Wagneru říká, že válka na Ukrajině se vleče roky
Majitel ruského soukromého vojenského kontraktora Wagner Group aktivně zapojeného do bojů na Ukrajině předpověděl, že válka by se mohla táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek řekl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad ukrajinským východním průmyslovým srdcem Donbasu.
Dodal, že válka může trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl nazván "Putinovým šéfkuchařem" pro své lukrativní kremelské cateringové smlouvy, znamenalo uznání obtíží, kterým Kreml čelí v kampani, kterou původně očekával, že dokončí během týdnů, kdy ruské jednotky napadly Ukrajinu 24. února.
Rusko utrpělo na podzim řadu ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšnou protiofenzívu, aby získala zpět rozsáhlé území na východě a jihu.
Kreml se vyhnul prognózám o tom, jak dlouho by mohly boje pokračovat, a uvedl, že to, co nazval "speciální vojenskou operací", bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří region Donbas, kde Moskvou podporovaní separatisté bojují s ukrajinskými silami od roku 2014.
Prigožin uvedl, že žoldnéři Wagnerovy skupiny pokračují v nelítostných bojích o kontrolu nad ukrajinskou baštou Bachmut v Doněcké oblasti.
Uznal, že ukrajinské jednotky kladou tvrdý odpor.
Zatímco ruské jednotky pokračují ve svých útocích v Donbasu, Moskva se také snaží demoralizovat Ukrajince tím, že je nechává v kruté zimě bez tepla a vody.
Rusko v pátek zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Vysokonapěťová infrastruktura byla zasažena ve východních, západních a jižních regionech, což v některých oblastech vedlo k výpadkům proudu.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná," a dodala, že se jedná o zálohy, aby se udržely dodávky elektřiny, ale poznamenala, že v některých oblastech bude pokračovat přídělový systém.
Ukrajinský vojenský šéf generál Valerij Zalužnyj uvedl, že ruské síly odpálily 71 řízených střel, 35 raket S-300 a sedm dronů Shahed mezi čtvrtečním večerem a pátečním polednem a dodal, že ukrajinská protivzdušná obrana sestřelila 61 řízených střel a pět dronů.
Ukrajinské úřady ohlásily další útoky zabijáckými drony později v pátek.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 dronů Shahed.
V pátek večer zveřejnili ruští vojenští blogeři a některá ukrajinská média video ukazující útok námořního dronu na strategický železniční most v Oděské oblasti.
Zrnité video ukázalo rychle se pohybující objekt blížící se k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a explodující v silné explozi.
Pravost videa nebylo možné ověřit.
Ukrajinská armáda se k útoku nevyjádřila a Serhij Bratčuk, mluvčí regionální správy, nepotvrdil útok dronu, když v sobotu hovořil v televizních poznámkách.
Most, který byl na začátku války terčem ruských raketových útoků, slouží jako železniční spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: Https: / / apnews.com / hub / russia-ukraine
Kazašští záchranáři vytahují 7 přeživších a těla 19 zemřelých v Türkiye: 11 února 2023,12: 15
Kazašští záchranáři pokračují v prokopávání sutin při hledání přeživších v Turecku, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů brzdí velké množství trosek a nestabilní konstrukce.
Kazašský záchranný tým vytáhl sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte, v Turecku.
První lékařská pomoc je také poskytována nepřetržitě.
Pozoruhodné je, že v pondělí ráno zasáhlo zemětřesení o síle 7,7 stupně, které zdevastovalo části jihovýchodního Turecka a severní Sýrie.
Počet obětí masivního zemětřesení, které zasáhlo jihovýchod Turecka, přesáhl 20 000.
Foto: T.me / QR _ TJM
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM - Slavnostní zahájení 10. halového mistrovství Asie v atletice se uskutečnilo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Při zahájení akce předseda kazašské vlády přečetl uvítací dopis prezidenta Kassyma-Jomarta Tokajeva.
"Sport nezná žádné hranice.
Posiluje přátelství a sbližuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
Pro provozování profesionálního i masového sportu jsou u nás všechny podmínky.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex, který pojme přes šest tisíc lidí, "píše se v dopise kazašského prezidenta.
Kazašští sportovci úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil důvěru, že pořádání mistrovství Asie v Astaně dá nový impuls rozvoji atletiky v zemi a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlan al-Hamad za jeho pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaj svedl dohromady více než 500 sportovců z 31 zemí, kteří budou soutěžit v závodě, štafetě, skoku dalekém, skoku vysokém, trojskoku, skoku o tyči, hodu koulí a víceboji.
Turnaj potrvá do 12. února.
Kazašská běžkyně Caroline Chepkoech Kipkiruiová získala zlato v běhu na 3000 metrů a Olga Safronovová stříbro v běhu na 60 metrů.
Foto: Primeminister.kz
Yellowstonská herečka Q 'orianka Kilcher čelí obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském trháku o pomluvu, získala další právní vítězství - tentokrát s hercem "Yellowstone" Q 'oriankou Kilcherovou.
V pátek úřad okresního prokurátora v Los Angeles očistil Kilchera, 32, ze všech obvinění v případu podvodu s kompenzací pracovníků.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora v Los Angeles uvedl, že soud "rozhodl, že paní Kilcherová se nedopustila pojistného podvodu a informovala soud, že nemůžeme pokračovat."
V červenci 2022 kalifornští úředníci obvinili Kilcherovou ze dvou trestných činů podvodu s kompenzací pracovníků a obvinili ji z nezákonného shromažďování více než 96 000 dolarů v invalidních dávkách mezi říjnem 2019 a zářím 2021.
Časový rámec také zahrnuje několik měsíců, kdy Kilcher pracoval na "Yellowstone," navzdory hercovým tvrzením, že byla příliš zraněna na práci.
Kilcher se vzdal a v květnu byl obžalován.
"Dnes jsem více než vděčný, že můj případ byl zamítnut - zítra začíná moje cesta, která pomůže zvýšit povědomí a požadovat větší transparentnost práv pracovníků v rámci systému zaměstnanců," řekl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že se "těší na to, že na tuto zkušenost vrhne více světla a bude pokračovat v práci, kterou miluji."
Kilcherová také poděkovala Vasquezové a jejímu kolegovi, právníkovi Brownu Rudnickovi Stevu Cookovi za "jejich neochvějnou víru v mou nevinu."
Podle TMZ, Kilcher najal dva v září.
Kilcher prorazil s filmem Terrence Malicka z roku 2002 "Nový svět," kde ztvárnila Pocahontas.
Mezi její další filmy patří Sons of Anarchy, The Alienist a Dora and the Lost City of Gold.
Naposledy se objevila v road-trip filmu "Pes," v hlavní roli Channing Tatum.
Times zaměstnanec spisovatel Christina Martinez přispěl k této zprávě.
Šéf Balenciagy označil kampaň za "hloupou chybu"
Značka luxusního oblečení Balenciaga se stále vzpamatovává z reakce na dvě ze svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal pod palbu kvůli propagačním obrázkům, o kterých kritici říkali, že sexualizují děti, umělecký ředitel Balenciagy Demna (celé jméno Demna Gvasalia) řekl, že se stále omlouvá za snímky v rozhovoru s Vogue, který byl zveřejněn v pátek.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro dárkovou kampaň s dětmi a beru na sebe odpovědnost," řekl Vogue a zopakoval předchozí prohlášení, které v prosinci zveřejnil na sociálních médiích.
V listopadu značka sdílela fotografie pro svou kolekci "The Gift," která představovala dětské modely pózující s plyšovými medvídky, kteří byli oblečeni v otroctví.
Krátce poté Balenciaga vypustila fotografie pro svou jarní kampaň 2023, která obsahovala stránku z případu Nejvyššího soudu z roku 2008 zahrnující "virtuální dětskou pornografii" v pozadí.
Rodiče, včetně reality TV hvězdy a dlouholetého fanouška Balenciagy - a partnera značky - Kim Kardashian, se vyslovili proti značce a jejím "znepokojivým obrázkům" na sociálních médiích.
O několik dní později Balenciaga vydala prohlášení, ve kterém se omluvila za fotografie a nastínila změny, které by provedla, aby se v budoucnu vyhnula podobným "chybám."
"Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s našimi diváky, a ve způsobu, jakým se učíme z našich chyb a postupujeme vpřed," řekl Demna Vogue.
Podrobně popsal změny v Balenciaga: "Restrukturalizaci obrazového oddělení," provádění více interních a externích kontrol snímků kampaně a partnerství s Národní dětskou aliancí, aby pomohla "tisícům dětí v procesu překonání traumatu a řešení jejich duševního zdraví."
"Je to jediná věc, která mi dělá radost z celé této hrozné situace: Udělat z toho něco dobrého," řekl o tomto partnerství, které bylo oznámeno ve středu.
S NCA spolupracuje také mateřská společnost Balenciagy, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod deštníkem Kering je Gucci, který v prosinci čelil odporu kvůli kampani s Harrym Stylesem, kterou někteří kritici sociálních médií údajně také sexualizovali děti.
Denma v rozhovoru uvedl, že se plánuje vzdálit od "provokativních" způsobů značky.
"Je to součást mého učení: Budu mít dospělejší a serióznější přístup ke všemu, co vydám jako nápad nebo obraz," řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciagy, která dělá kvalitní oblečení - nedělá image nebo buzz."
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jednou z nejvíce "bolestivých" částí odporu bylo pošpinění "jména Balenciagy a odkazu Cristóbala Balenciagy."
"Balenciaga je dům, který je více než sto let starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem dělal vše, co bylo v mých tvůrčích silách, abych ho přivedl k jeho modernímu významu, a najednou jsme byli napadeni a označeni za něco, co vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s darovací kampaní a určitě jsme se z toho poučili."
Je to falešná zpráva, CBN Debunks tvrdí, že postrádá kapacitu pro tisk více nových Naira Notes
Centrální banka Nigérie (CBN) označila za zavádějící zprávu, která tvrdila, že cituje guvernéra CBN, pana Godwina Emefieleho, a připisuje současný problém při distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů v nigerijské bezpečnostní tiskové a mincovní společnosti Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neučinil takové prohlášení během své prezentace Národní radě státu na svém zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot Nairy, aby vyhověl transakčním potřebám Nigerijců.
Řekl, že zatímco CBN oceňuje obavy, které projevily všechny zúčastněné strany ohledně distribuce nových bankovek Naira, "jsme znepokojeni rozsahem, v jakém se zájmové skupiny pokoušejí manipulovat s fakty a postavit veřejnost proti bance."
Nwasinobi uvedl, že CBN zůstává odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (ve znění pozdějších předpisů).
"Chceme také zopakovat, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované odsazení Naira.
"Banka proto chce apelovat na veřejnost, aby ignorovala zmíněnou zprávu a projevila větší zdrženlivost, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na konkrétní hlasovou poznámku, která se objevila na sociálních médiích a tvrdila, že CBN plánuje uzavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že takový plán neexistuje a že tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje ignorovat takové nahrávky, protože nepředstavují politický tah CBN a jsou pouze zoufalými pokusy osob, které se snaží podněcovat veřejnost proti bance," uvedl.
Tim Sherwood trhá do £44m podpisu Pedro Porro po ponurém debutu Tottenham
Porro měl odpoledne zapomenout proti Leicesteru (Obrázek: Getty)
Tim Sherwood se pustil do "naprosto nechutné" obrany Pedra Porra během porážky Tottenhamu 4: 1 proti Leicesteru City.
Spurs podepsali pravého obránce ze Sportingu CP v den uzávěrky přestupů na počáteční půjčce za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
23letý hráč dostal svůj debut od Antonia Conteho v sobotu na King Power Stadium, když se jeho strana ujala vedení po 14 minutách přes Rodriga Bentancura.
Ale to se změnilo v mizerné odpoledne s Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni bodování dát Leicester 3-1 v poločase s Porro snášet horký první poločas v Premier League.
Španěl byl opět na vině, protože Leicester si myslel, že přidal čtvrtý přes Barnes a zatímco gól byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood byl šokován obranným úsilím plného záda.
"Nechci si toho kluka pořád dobírat, ale musí být zbaven svých povinností," řekl Sherwood pro Soccer Saturday.
Dám mu výhodu pochybností, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho pozice je naprosto nechutná, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden říkal, že utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale dívám se na hráče, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na bránění a tento hráč, v současné době se snaží bránit. Je proti velmi dobrým hráčům Barnes a Maddison, ale je to velmi zklamáním."
Zatímco gól byl vyloučen, Leicester obnovil své vedení 4-1 s Barnesem na cíl devět minut od plného času.
Navzdory tomu, že minulý týden porazil Manchester City, Tottenham promarnil šanci posunout se před Newcastle na třetí místo.
Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala Joao Felixe a místo toho se vrhla na hvězdu Tottenhamu
Tottenham se chystá nabídnout za hvězdu Crystal Palace Marc Guehi, ale Chelsea má neoficiální možnost zpětného odkupu
Pro více příběhů, jako je tento, podívejte se na naši sportovní stránku.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli boj o privilegia nad Mike Pence obsílkou
Zpráva, že zvláštní poradce Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak bude tým Trump používat soudy k tomu, aby zpackal tento nejnovější vývoj ve vyšetřování ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus zrušit Penceovu obsílku na základě výsad výkonné moci by měl selhat.
Za prvé, existuje prahová otázka, zda bývalý prezident může dokonce nárokovat výsadu.
Trump se 6. ledna pokusil zablokovat výboru Sněmovny reprezentantů přístup k záznamům Bílého domu, ale neuspěl.
Nejvyšší soud odmítl přijmout Trumpovo odvolání v loňském roce, přičemž pouze soudce Clarence Thomas (manžel 2020 volebního popírače Ginni Thomas) nesouhlasil.
Soud však ponechal otevřenou otázku, zda si bývalý prezident může nárokovat výsadu, přičemž soudce Brett Kavanaugh navrhl, že by takové tvrzení podpořil.
Takže je přinejmenším nejasné, zda si bývalý prezident může nárokovat výsadu, aniž by řekl nic o tom, zda by nárok uspěl.
Navíc odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se obsílce ukazuje, že vágní tvrzení o výsadách nebude stačit a může být překonáno specifickou potřebou důkazů.
Soud poznamenal v roce 1974 ve Spojených státech v. Nixon:
Pokud je důvod pro uplatnění výsady, pokud jde o materiály vyžádané pro použití v trestním řízení, založen pouze na obecném zájmu na důvěrnosti, nemůže převážit nad základními požadavky řádného právního procesu při spravedlivém výkonu trestního soudnictví.
Zobecněný nárok na výsadu musí ustoupit prokázané, konkrétní potřebě důkazů v probíhajícím trestním řízení.
Precedens je tedy na straně vlády.
Samozřejmě, že zdržení se soudních sporů i v případě prohry může být pro Trumpa určitým vítězstvím.
Ale další oslabení šancí na úspěšné tvrzení o výsadách je předchozí odmítnutí Trumpova pokusu zablokovat svědectví velké poroty z 6. ledna.
Jak v říjnu uvedl The Washington Post, toto odmítnutí poznamenalo, že například bývalý Penceův poradce Marc Short "pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti o útoku na Capitol z 6. ledna 2021, které nebyly k dispozici z jiných zdrojů."
To, že Pence má také pravděpodobně jedinečné informace, by pomohlo ministerstvu spravedlnosti v jakémkoli boji s obsílkou.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegium měl selhat.
To proto, že Pence se rozhodl veřejně napsat alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říct, že komunikace je privilegovaná, když jste ji předtím považovali za vhodnou k publikování.
Takže zatímco předvolání může představovat různé politické a osobní kalkulace pro Pence - který může soupeřit o republikánskou nominaci v roce 2024 proti Trumpovi, někomu, kdo účinně toleroval výzvy k Penceově mimosoudní popravě 6. ledna - soudy by měly mít snadný čas na straně ministerstva spravedlnosti na privilegium.
Případ proti běhu Biden je zřejmý - a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové demokraté nemohou dělat mnoho ve způsobu přijímání zákonů s GOP v kontrole domu, mohou ještě strávit příští dva roky příkladem.
Kolektivně, každý v týmu by měl hledat příležitosti hrát Gallant k republikánům "podivné Goofus impulsy.
Ale pro Bidena je také důležité, aby si vylepšil svou důvěryhodnost u amerického lidu - a možná byl zoufale potřebným agentem změny v naší příliš ošuntělé politické kultuře.
Washington, notoricky cynické místo, je proslulý svými myšlenkami o vůdcovství, které ochromují zdravý rozum.
Snad jedním z nejznámějších je zvláštní standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli jít do komických délek, aby se tomu vyhnuli.
Existuje i jiný způsob: V Bailoutu, memoárech Neila Barofskyho z doby, kdy působil ve Washingtonu jako zvláštní generální inspektor dohlížející na program pomoci problémovým aktivům, popsal radu, kterou dostal od Kristine Belisle, ženy, kterou chytře najal jako svého ředitele komunikace.
Bylo to asi tak anti-washingtonské, jak jen to jde: "Přiznáme a dokonce zdůrazníme naše chyby."
Jak dále vysvětlila, ve strategii je metoda, kterou by většina lidí uvnitř Beltway považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Můžeme být někdy v rozpacích a prozradit věci, které bychom mohli - a jiní by - snadno skrýt, ale šokujeme tisk svou upřímností.
Nikdo jiný to nedělá a zanedlouho budeme mít vybudovanou obranu, když na nás zaútočí.
Bez ohledu na to, co slyší, tisk přijde nejprve k nám a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč Biden sleduje kurz radikálního převzetí odpovědnosti: V každém prezidentství nevyhnutelně vznikají okamžiky, kdy je kritická důvěra veřejnosti a institucí, které chrání občanský zájem.
Navíc existuje životně důležitý kapitál, který lze získat vlastnictvím našich chyb, a existuje důležitý rozdíl, který Biden může nakreslit se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: Řekni pravdu - a zostuď ďábla.
Reklamní spoty na Super Bowl, na které se nemůžu dočkat
Hvězda sitcomu z devadesátých let, která si zopakovala svou milovanou roli, aby vám prodala pojištění auta.
Reklama, která se stane kulturním fenoménem a dostane okamžitě zelenou jako televizní show, prodlužující dvanáctivteřinovou scénu do deseti sezón.
Všechny celebrity z loňských krypto reklam se omlouvají za své krypto reklamy.
Ti "whassup" kluci, ale trochu je, že teď jsou staří.
Všichni jsou teď do whodunnits, ne?
Takže nějaká série reklam v režii Riana Johnsona, kde když přijdete na to, kdo spáchal vraždu, dostanete slevu na rok pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativní chlápci celý týden zuřit.
Timothée Chalamet v hlavní roli.
Někdo, kdo byl údajně navždy zrušen, se triumfálně vrací do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte, na který se určitě podíváte, až bude za tři týdny streamovat.
Nesnesitelně chytlavá nová znělka, kterou budete zpívat sami pro sebe po celá léta.
Recyklovaný vtip z Twitteru z doby před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který je kontrakulturně říká, abyste banku s Wells Fargo.
"Zoom zoom" dítě, ale trochu je, že teď je dospělý.
Biden DOJ "nechce ozbrojené občany"
Republikán Andrew Clyde (R-GA) se ve čtvrtek sešel s Breitbart News a diskutoval o svých plánech zablokovat pravidlo ATF pistole a jeho přesvědčení, že Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občany" na prvním místě.
Clyde dal jasně najevo svůj nesouhlas s pravidlem vzpěry pistole.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější námitky.
Obecně vyjádřil své přesvědčení, že naši otcové zakladatelé nestanovili plán vládnutí, který by zahrnoval federální agentury, které by vytvářely zákony namísto zákonodárného sboru.
Řekl: "Ministerstvo spravedlnosti je tam, aby prosazovalo zákon, ne aby vytvářelo zákon. Když máte výkonnou moc, která vytváří zákon a vynucuje zákon, pak máte krále a království. Naši zakladatelé nepožadovali krále a v ústavě Spojených států nestanovili království."
Clyde pak přešel ke specifikům týkajícím se pravidla pro vzpěru pistole a vyjádřil své obavy, že pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: "To, co ATF chce, je, že chtějí zvýšit registrační databázi pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co přichází před konfiskací, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany."
Dodal: "Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby po nás mohli jít."
Clyde tvrdí, že pravidlo ATF pistole se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní a plánuje proti němu bojovat zuby nehty.
Řekl, že má "tři nástroje", s nimiž může proti vládě bojovat.
Prvním z těchto nástrojů je SHORT Act a druhým je Congressional Review Act.
Dne 30. ledna Breitbart News citoval Clydea, který nastínil svůj plán "znovu zavést zákon Stop Harassing Owners of Rifles Today Act nebo SHORT Act, aby zrušil prvky Národního zákona o střelných zbraních, čímž zakázal ATF registrovat a zakazovat pistole se stabilizačními výztuhami."
Poznamenal také, že "předloží rezoluci o nesouhlasu podle zákona o přezkumu Kongresu, aby potlačil nezákonné překročení Bidenovy administrativy."
Oba zákony, zákon SHORT a zákon o přezkumu Kongresu, mají možnost zablokovat pravidlo ATF pistole.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k přijetí legislativy SHORT Act, nebo k dokončení usnesení o nesouhlasu podle zákona o přezkumu Kongresu.
Dal jasně najevo, že získání Bidenova podpisu není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k jiným, větším účtům, které demokraté velmi touží projít.
Clyde však naznačil, že existuje i třetí způsob, jak zablokovat pravidlo ATF pistole.
Řekl: "Jsem ve výboru pro přidělování prostředků a můžeme zrušit toto pravidlo pistole, prostřednictvím toho, co se nazývá dodatek o omezení. Můžeme doslova zrušit toto pravidlo a v podstatě říci:" Žádné peníze nesmí být vynaloženy na provádění nebo prosazování tohoto konkrétního pravidla pistole. "
A můžeme také udělat to samé s pravidlem ATF přijímač / rám, od loňského srpna.
Myslím si, že oba musí být odfinancovány a těším se na spolupráci s našimi přivlastňovateli, abychom to udělali.
AWR Hawkins je oceněný sloupkař druhého dodatku pro Breitbart News a spisovatel / kurátor Down Range s AWR Hawkins, týdenní zpravodaj zaměřený na všechny věci druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins má doktorát z vojenské historie se zaměřením na vietnamskou válku (hnědé vodní námořnictvo), americké námořnictvo od počátku, občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @ awr _ hawkins.
Můžete se zaregistrovat a získat Down Range na breitbart.com / downrange.
Kontaktujte ho přímo na adrese AWRHawkins @ breitbart.com.
"Doufáme, že Biden má plán, jak zvládnout ukončení titulu 42," pokud ano, plně ho nesdíleli "
V pátečním vydání NBC "MTP Now" řekl guvernér Colorada Jared Polis (D), že má "velké obavy" o to, co se stane, až v květnu skončí titul 42, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že "pokud ano, ještě s námi plně nesdíleli."
A řekli: "Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili."
Polis uvedl, že si přeje, aby se během setkání guvernérů v Bílém domě věnovalo více času otázce přistěhovalectví, ale otázka "přišla."
Měli jsme tam ministra Mayorkase pro část z toho.
A tak jsme se znovu zmínili o mnoha obavách, které sdílím, o tom, co se stane, až v květnu skončí titul 42, a tak se ujistíme, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě se s námi o to plně nepodělili.
Ale řekli jsme, že potřebuješ plán.
Chceme, aby si to s námi ověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo krát tři, to by byla katastrofa pro zemi a pro Bidenovu administrativu by to bylo hrozné.
Sledujte Iana Hanchetta na Twitteru @ IanHanchett
McDonald 's stahuje "nevkusnou" reklamu poblíž krematoria - RT World News
McDonald 's se omluvil poté, co byla reklama na hamburger "McCrispy" řetězce rychlého občerstvení umístěna v blízkosti krematoria ve Velké Británii - i když někteří místní viděli legrační stránku.
Řetězec restaurací se zavázal odstranit urážející reklamní hromadění po stížnostech obyvatel Truro v britském hrabství Cornwall.
V pátek si na sociálních sítích získala pozornost tím, že byla umístěna na rušné silnici přímo naproti provozovně, která nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí směřující ke krematoriu, byla některými rozzlobenými místními obyvateli označena za "nevkusnou".
"I když vidím tu legrační stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou rádi vidět, když navštíví Penmount na pohřeb a zpopelnění milovaného člověka," řekl jeden z obyvatel, jehož tchyně byla zpopelněna v pohřebním ústavu v loňském roce.
Ne všichni však byli nešťastným umístěním reklamy tak uraženi, přičemž jeden poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, "jak dávno jste sledovali značku krematoria v černé kravatě."
Jeden člověk řekl, že "spadl ze židle smíchy," když si všiml inzerát on-line, zatímco to bylo také poznamenal jiný místní, že to bylo "o nic horší," než rozhodnutí rady bavit myšlenku umožňující krematorium, které mají být postaveny "vedle vesnice důchodců."
Prohlášení vydané společností McDonald 's bylo zveřejněno místními médii v pátek brzy poté, co se obrázek reklamy stal virálním online, ve kterém řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
"Nebyli jsme si vědomi dopravní značky v blízkosti této autobusové zastávky. Nicméně, ve světle obav vznesených CornwallLive, jsme požádali o odstranění naší reklamy," uvedla značka rychlého občerstvení.
Rada Cornwallu, která provozuje jak krematorium, tak autobusový přístřešek, který zobrazuje reklamu, odmítla komentovat rozruch, když ji kontaktovala místní média.
Pohřešovaná žena není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové začalo 16. den poté, co její partner řekl, že jeho "instinkt" je, že není v řece.
Policie v Lancashire uvedla, že policisté zachovávají "otevřenou mysl" a nadále apelují na informace o paní Bulleyové, která zmizela 27. ledna při venčení svého psa v St Michael 's on Wyre.
Síly pokračují v prohledávání řeky Wyre směrem k moři v zálivu Morecambe a pracují na jedné hypotéze, že 45letý muž z Inskipu mohl spadnout.
Jejich hledání bylo podporováno specialisty a potápěči z HM Coastguard, horské záchrany a Lancashire Fire and Rescue Service, s nasazenými psy, drony a policejními vrtulníky.
Paní Bulleyová zmizela, když venčila svého špringršpaněla Willow u řeky, krátce poté, co nechala své dcery ve věku šest a devět let ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále připojený k pracovnímu hovoru.
Její partner Paul Ansell řekl, že chce zachovat "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popsal paní Bulleyovou jako "zábavnou," "milující," "nejvěrnější kamarádku, jakou jste kdy mohli mít" a "výjimečnou maminku," která "naprosto zbožňuje naše dívky."
"Je to jen pilíř síly naší rodiny a bez ní je díra větší, než si dokážete představit," řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází "bezprecedentním peklem," naděje, že jeho partner bude nalezen, je "silnější než kdy jindy."
Policie vyloučila hrubou hru a incident vyšetřuje jako pohřešovanou osobu.
Ve čtvrtek se zaměření jejich pátrání změnilo ze St Michael 's na asi 10 mil po proudu, kde se řeka vlévá do moře v Morecambe Bay, přičemž v oblasti byly spatřeny hlídkové a záchranné čluny.
Ve věku 95 let zemřel poslední komunistický vůdce východního Německa
Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během turbulentního funkčního období, které skončilo v prvních a jediných svobodných volbách v zemi, zemřel.
Bylo mu 95.
Modrow zemřel v sobotu brzy ráno, napsala na Twitteru parlamentní skupina Levicové strany.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nemohl zpomalit rostoucí dynamiku německého znovusjednocení.
"Celý poklidný průběh nastolení německé jednoty byl právě jeho zvláštním úspěchem," napsala Levice na Twitteru. "To zůstane jeho politickým odkazem."
Během šestnácti let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst protiestablishmentové postavy.
Odmítl stranické požitky a trval na tom, že bude bydlet v normálním bytě.
Místo v nejvyšším vedení východního Německa se mu vyhýbalo, dokud se v listopadu 1989 - několik dní po pádu Berlínské zdi - nestal premiérem, což byla pozice, která dříve měla malý vliv.
Když vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro odstoupili na začátku prosince, Modrow se stal nejvyšší politickou postavou východního Německa.
Ale komunisté už nemohli volat výstřely na vlastní pěst.
Následující měsíc souhlasil se sdílením moci se stále hlasitější opozicí a posunul první svobodné volby ve východním Německu na březen 1990 uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle nabyla příchuti sjednocení, komunisté se zpočátku stavěli proti rozhovorům o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se Západním Německem směrem k eventuální "sjednocené vlasti", která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow stál v čele volební kampaně restylizovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nestačila, aby jim zabránila skončit až jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS - předchůdkyně dnešní opoziční Levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho dostala před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků místních voleb v Drážďanech v květnu 1989.
Dostal devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozdělení mezi východními a západními Němci.
Jeho právní zástupce tvrdil, že předchozí křivdy napravil tím, že jako premiér dohlížel na svobodné volby.
Později v životě Modrow sloužil v radě starších Levicové strany.
"Hans byl hluboce upřímný a bojovný socialista," napsal na twitteru předseda poslaneckého klubu Levice Dietmar Bartsch.
"Až do vysokého věku byl důležitým poradcem v naší straně, jehož moudrost nám bude chybět."
Indická vláda po kritice stáhla výzvu k objímání krav na Valentýna
Objímání krávy na Valentýna už indická vláda nepodporuje - navzdory tomu, že dříve žádala lidi, aby tak činili na podporu hinduistických hodnot.
Indická rada pro dobré životní podmínky zvířat (AWBI) stáhla svou výzvu "Den objetí krav" poté, co vyvolala kritiku ze strany politických soupeřů a uživatelů sociálních médií.
Indické ministerstvo vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k objímání krav byla "naprosto šílená, vzdorující logice."
Dodal, že rozhodnutí stáhnout odvolání bylo spíše "zabránit tomu, aby byla politika hindutvy (hinduistického nacionalismu) zesměšňována tváří v tvář tvrdé kritice ze všech stran."
AWBI se v pátek vzdal svého odvolání s tím, že "stojí stažen."
Až ve středu se v jejím prohlášení psalo, že "objímání krav [by] přineslo emocionální bohatství a zvýšilo individuální i kolektivní štěstí."
Více o Indii
Dodal, že kráva je "páteří indické kultury a venkovské ekonomiky... kvůli své výživné povaze jako matka."
Na první oznámení byly smíšené reakce, protože někteří zveřejnili videa krav, které odmítly být objímány a nabíjely.
Jiní chtěli objasnit, že odvolání bylo spíše pro následování vlastní kultury, na rozdíl od "slepého" následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněnými parky a restauracemi, vyměňují si dárky a pořádají večírky.
Mazlení s krávou také není nic nového - v některých částech světa je považováno za terapeutické a v Nizozemsku je známé jako "koe knuffelen."
Oddaní hinduisté uctívají krávu - známou jako gau mata nebo "matka kráva" - a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie provedli razie v obchodech prodávajících valentýnské předměty, pálili pohlednice a dárky a vyháněli páry držící se za ruce z restaurací a parků, přičemž trvali na tom, že tento den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadřazenost náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinisté tvoří většinu zbytku.
Chodec zemřel v nemocnici po nehodě s autem v Cowdenbeath jako muž zatčen
Chodec zemřel po srážce s autem v Fife.
Osmatřicetiletá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeath v pátek kolem 13: 30.
V souvislosti s nehodou byl následně zatčen čtyřiadvacetiletý muž.
Policie vyzývá všechny svědky nebo kohokoli, kdo má záběry z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a apelujeme na každého, kdo byl v oblasti a kdo byl svědkem havárie, aby se dostal do kontaktu."
Chtěl bych také apelovat na každého, kdo řídil v této oblasti a kdo může mít záběry z palubní kamery, které by mohly pomoci našemu vyšetřování, aby nás kontaktoval.
"Každého, kdo může pomoci, žádáme, aby zavolal policii Skotska na číslo 101 a citoval incident číslo 1638 z pátku 10. února 2023."
V ČÍSLECH: Čtvrti Osla, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili občané z Asie, včetně Turecka, největší přistěhovaleckou skupinu, přičemž podle údajů národní datové agentury Statistics Norway (SSB) žije ve městě více než 62 985 těchto státních příslušníků.
Poté tvořili občané z EU, EHP a Spojeného království druhou největší skupinu, což představuje necelých 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, s 28 020 lidmi z Afriky žijícími v Oslu.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, což představuje 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen 7 000 občanů z jihoamerických zemí, zatímco v Severní a Střední Americe bylo přes 3 000 státních příslušníků.
Mezitím bylo v Oslu necelých 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrť s nejvíce zahraničními obyvateli.
V roce 2022 zde bylo registrováno 18 257 zahraničních rezidentů.
Poté, trendy Grünerløkka, který se nachází poměrně centrálně, měl druhý nejvyšší počet zahraničních obyvatel, s 17,631.
Gamle Oslo mělo také významnou přistěhovaleckou populaci, s 17 631 lidmi, kteří tam žili poté, co se přestěhovali z jiné země.
Statistiky Norska ukázaly, že cizinci byli rozptýleni po všech městských čtvrtích, protože Søndre Nordstrand, nejjižnější čtvrť v Oslu, měla více než 14 000 registrovaných přistěhovalců.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl okres s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra, jen 184 zahraničních obyvatel volal Marka domov, a jen něco málo přes 700 žil v centrální čtvrti města.
Ullern, Vestre Aker a Nordstrand tvořily další městské části s nejmenším počtem zahraničních obyvatel.
V těchto čtvrtích však žilo výrazně více přistěhovalců než v centrálním Oslu a Marce.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili ve Frogneru, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Zatímco spousta občanů z Asie, včetně Turecka, také pobývala v Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu s Stovner, Grünerløkka a Søndre Norstrand.
Ti ze Severní Ameriky byli rozloženi poměrně rovnoměrně přes Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji nacházeli ve Frogneru, Grünerløkka, Gamle Oslo st. Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Velké Británii tendenci žít ve městě je nejvíce centrální čtvrti, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika set národností z Oceánie, Frogner, Grünerløkka a Gamle Oslo byly městské části s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny v březnu
Od Florence Tan
Bengaluru (Reuters) - Zimbabwe zahájí provoz nové jednotky ve své jediné uhelné elektrárně do března, říká náměstek ministra energetiky země, který poskytuje úlevu milionům občanů otřesených častými výpadky elektřiny v posledních měsících.
Nový blok elektrárny Hwange zvýší instalovaný výkon afrického národa o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časový harmonogram.
Méně než polovina ze 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální tlak na financování nových uhelných kapacit omezil schopnost země zapojit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu pro výrobu až 2100 megawattů (MW) z našich energetických zdrojů, ale v současné době vyrábíme mnohem méně než to," řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit," řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediného, desetiletí starého uhelného zařízení se v průběhu času prudce snížila, zatímco poptávka po energii v posledních letech vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících vyhlídky Zimbabwe na růst.
Nedostatek finančních prostředků na uhelnou energii vede ekonomiku závislou na těžbě a zemědělství k dovozu nákladné energie od regionálních sousedů, včetně Zambie a Mosambiku.
(Scénář: Sudarshan Varadhan, editace: Jacqueline Wong)
(PERSON11) Ale pro některé složky je z nějakého důvodu zvukový formát špatný, takže něco je špatně -
V podstatě ten velký obchod, nebo je něco špatně.
Takže některé soubory jsou stále - stále mají podivný výstup.
Ale - ale pro většinu složek, to by mělo být již v pořádku.
(PERSON1) Dobře, díky.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé, že [PERSON7], jste mysleli na [PERSON11].
A [PERSON11] teď má čas.
Existují další věci, kde jsem myslel na [PERSON11] a to by bylo školení prázdných systémů, aby zkrátili.
Takže, pokud jste [PERSON11] měli čas.
Je zřejmé, že pro příští týden neexistuje způsob, jak bychom to mohli udělat.
Ale opravdu bychom měli mít systém - připravený na -
Podíval jsem se na výukový program z NLP - bylo to?
(PERSON6) Pro nadcházející zasedání a zeptal jsem se na poptávku, protože jsem viděl demo projektu (meme).
Dělají offline titulkování.
Je to o něco jednodušší než to, co děláme my.
Mají stále stejné segmentační problémy a tak dále.
Ale jejich poslání v překladu se zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech dochází k přirozenému zkrácení.
Bylo by skvělé, kdybychom mohli také najít takový typ dat, kde dochází k nějakému přirozenému zkrácení.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože musím zjistit, který z nich je ten, který dostává přihrávky.
Takže jakmile to vím, mohu to sledovat, takže do budoucna -
Nebo vlastně pro budoucnost bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset provést konverzi.
(PERSON6) No, tohle, tohle by vlastně mělo být -
Slyšíš mě ještě?
Kvalita zvuku je trochu horší.
Takže by se to mělo dělat opravdu pořád.
Takže pokaždé, když spustíme toto hodnocení, mělo by být spuštěno od nuly.
Takže pokaždé by mělo dojít k novému stažení nové konverze a novému hodnocení.
(PERSON8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript, a mohl se postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, uvidím to později.
(PERSON6) Takže tohle je důležitá věc, na kterou jsme měli narazit už před měsíci.
Pamatujte si, že od srpna vám říkám, že chceme vyhodnotit pozdější testovací sadu.
A pokaždé, když se všichni.
Není to jen vy osobně, [PERSON8].
Byly tu samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si: "To bude snadné, prostě to spustíme."
A teprve když to skutečně uděláte, vidíte všechny problémy.
Tak, tohle je známé, běžné.
Vždycky to tak je.
Takže to je vzkaz pro všechny.
Než to zkusíte, nikdy nevíte, v čem bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, tak chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Takže než to uděláte, nemůžete říci, zda to bude fungovat nebo ne.
A zde narážíme na problémy konverze formátů souborů.
Doufejme tedy, že se nám podaří rychle získat čísla.
Takže, máte zatím nějaké slovní chybovosti?
(PERSON8) Ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně hluku.
Takže jsem vás požádal, abyste měli různé verze tohoto slovníku tím, že vezmete pouze slova, která byla pozorována, pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takže takto, tyto náhodné chyby, jako příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba řekne toto "alzo," pokud si pamatujete, pokud řekne toto "alzo" s "Z" 20krát v rozhovoru, pak uvidíte, že v datech s "Z."
A pokud se mu někdy podaří říct také správně, pak jo, opět, to uvidíte v datech.
Tak, Chtěl bych, [PERSON4] být v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, že?
Teď budu muset odjet, protože potřebuju dát dětem oběd a tak.
Ale prosím, zůstaňte na tomto hovoru a společně zjistěte, jak používat tento slovník.
Takže [PERSON4], prosím, ukažte [PERSON2], jaký je slovník, který systém přijímá.
Sdílejte svou obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste vyslali do tohoto souboru.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři sloupce.
Grafém, jak je výstup.
Jeden poznal.
Fonémy, jak navrhl [PERSON2].
A bude tam více řádků s různými variacemi fonémů.
A třetí sloupec n bude pro všechny opět stejný a opět bude mít stejný tvar grafému.
Takže to je, když jazykový model vidí.
A myslím si, že tímto způsobem by to tyto systémy měly umět načíst.
A možná narazíte ještě na jeden problém: Že není připraven na dva velké vlastní slovníky.
Takže to je také něco, co musí být testováno, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a potřebujete dát tyto dvě znalosti dohromady.
Ah, tak, aby to fungovalo s, s generovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Jo, jistě, probereme to.
(PERSON6) Jo, takže je tu ještě něco, [PERSON2], co máš?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časové razítko.
Nejsem si jistý, jak dobré to bude, protože se to snažím dělat na (libry) speech.
A když jsem ji stahoval, tvrdili, že má více než 600 hodin.
Pak ale Školení uvedlo, že skutečná tréninková sada obsahovala jen kolem 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale vyřčené různými mluvčími.
Například v angličtině nebo češtině jsem dříve pozoroval strmější přepočty.
A teď se to nebude tak rychle převádět.
Tedy, pokud během tréninku odebereme nějaké vzorky.
Pak jsou tu ještě některé závažné chyby ve výstupu ASR.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo bychom to aspoň mohli zkusit.
(PERSON17) Dobře, to je dobré, jo.
Takže jsem začal, ale myslím, že jsem vám nikdy nedokončil e-mail, protože jste mi připomněli, [PERSON8], že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že to je také důležitá zpráva pro [PERSON5], který opět zmizel z hovoru.
Takže důležité poselství je, že ano, je velmi dobré, že aktivně tlačíte na to, aby vaše výsledky byly integrovány, a každý by tak měl učinit.
A zároveň potřebujeme mít nastavení, abyste jej mohli skutečně integrovat a otestovat sami.
Já tomu říkám integrace "udělej si sám".
Takže [PERSON8], při práci s [PERSON5] a při dokumentování nastavení, se ujistěte, že je dostatečně dobře otestován kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontrolu jazykového modelu a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou komponentu, celý pipeline by měl být pro něj přiměřeně snadno přístupný, aby ji mohl sám otestovat.
Takže tato integrace do-it-yourself je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4] Že jo?
Filtrování vulgárních výrazů, bylo testováno na protokolech?
Myslím, že to tak bylo.
(PERSON8) Jo, myslím, že to bylo testováno na protokolech.
Takže teď je čas vyzkoušet to na živých potrubích.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, takže [PERSON4] spustí pro sebe některé z pracovníků a živě hraje nějaký problematický soubor, jako je použití [PROJECT8] nebo cokoli jiného.
Jednoduše si je zahrajte.
Sledujte zvukový výstup na vašem počítači a zjistěte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité jej nejprve odladit pomocí souborů protokolu a poté je důležité jej odladit v potrubí.
A pokud toto ladění může být provedeno autorem této komponenty, zde, v tomto případě [PERSON4], bylo by to nejefektivnější pro nás všechny.
Takže, [PERSON8], potvrďte prosím, že souhlasíte s touto myšlenkou integrace typu "udělej si sám".
(PERSON17) Jo, takže pro angličtinu s více přízvuky.
Takže nyní [PERSON14] to dáváme dohromady pouze do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že bude vytvářet nové věty se slovy, která byla vyslovena v jiných větách, a bude to dělat napříč různými mluvčími.
Takže to budou opravdu věty s více mluvčími, a proto by mohla být také zlepšena robustnost vůči různým přízvukům těchto mluvčích.
Tohle je experiment s jednou částicí.
A později možná uděláme něco víc s tím multi-akcentem.
Takže tyto nové věty se budou snažit vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Takže systém ASR musí vidět největší možnou sadu vět.
A budeme vytvářet nové věty z textového jazykového modelu přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost pro různé reproduktory bude také lepší.
A ve včerejším rozhovoru jsem slyšel další nápad.
Bylo to během tréninku.
Vypouštěli ze zvuku časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech, což také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoli jiný může pracovat na věci s cizím přízvukem.
OK, pak další věc, kterou jsem si všiml, je - to je v pondělním testovacím dokumentu.
Je zvýrazněn celkem čtyřikrát.
Takže, když se nějaká relace děje, potřebujeme názvy a terminologii pro tuto relaci.
A my ho potřebujeme sbírat, ručně připravovat, tak nějak vytvářet.
A tato ruční tvorba by měla být co nejvíce podporována automatickými nástroji.
Takže v tom je určitá dovednost b, kterou je třeba praktikovat.
Takže jsem docela zručný v míchání textových souborů.
A kdykoli vidím někoho z vás, jak to dělá, rád mám v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme, aby za to byl někdo zodpovědný.
A obávám se, že jediná osoba, která by to mohla udělat, je [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, křupání dat, prosím, řekněte to.
A pak potřebujeme -
Takže jakmile jsme zajistili slovník termínů a bez ohledu na výslovnosti slov, potřebujeme techniky, abychom tyto slovníky použili v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal pro všechny relace, byl, že v hybridním ASR nebyl opravdu viditelný.
Další takové setkání se uskuteční již toto pondělí.
[PERSON9] již zahajuje sběr dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat přizpůsobení domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Kdybyste se vy tři mohli sejít a zkontrolovat, co [Project5] dělá s -
Není to [PROJECT5], ve skutečnosti je adaptace domény určena pro sadu nástrojů [PERSON18], správně.
Takže je to trochu ohlédnutí zpět, abychom se ujistili, že starý přístup funguje.
V současné době je absolutně nemožné provést žádnou doménovou adaptaci pro plně neurální ASR.
Takže to, co zvažuji, je mít nezávislé klíčové slovo, které se nachází od zvuku a nějakého postupu slučování.
Takže můžeme mít dva ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení [Project5] přizpůsobené doméně, které se používá pouze k vyhledání klíčových slov.
A když vidíme klíčové slovo ve verzi přizpůsobené doméně, pak bychom použili tuto větu z [PROJECT5], která je obecně horší, ale obsahuje správné termíny.
To je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a dělat různé experimenty na doladění a tak dále.
Takže jsme o tom diskutovali s [PERSON14].
A [PERSON14], existuje nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je někdo jiný, kdo by byl na to zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co by bylo obecně dobře přijato jako papír, protože to lidé ještě nedělají.
A to je v těchto dnech ten nejnaléhavější problém.
Takže bychom tam opravdu mohli mít vliv.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat pro to v současné době používáme, protože například, když zkontrolujete modely [ORGANIZATION4] na [ORGANIZATION5], že jsou v těchto věcech docela dobré -
(PERSON6) A myslím, že když se nám prostě líbí -
Pravděpodobně bychom mohli získat data z nich, protože máte jako takovou velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčích na [organization5].
A měl jsem nápad, že bychom mohli použít nějaký nástroj ke stažení v podstatě některých druhů filtrovaných videí z [organization5] a udělat z nich tréninkové testy.
Takže mám v plánu to udělat sám.
Mám v plánu tam jet, ale potřebujeme záložní osobu.
A také, pro událost [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, archivář, abychom znovu neztratili tuto relaci.
A tím důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A navrhl jsem zde v odstavci pro [PERSON2], že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by rostly.
Myslím, že by bylo asi nejjednodušší dát tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Může být obtížné připravit tyto tabulky.
Takže jsem požádal [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Chcete-li nám sdělit, zda [ORGANISATION242], což je webové řešení.
Některé start-up společnost, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANISATION242] není doporučeno [PERSON7].
Takže jednoduchý html je pravděpodobně způsob, jak jít.
Takže, jakmile [PERSON2] má tato hodnocení m vyčistit.
Takže to znamená přesunout několik skriptů tam, kam patří z testovací sady [project3] a nějakého automatického běžce.
Pak také prosím vytvořit konverzi z tabulek do HTML podobné tech konverze a pak dát tyto výsledky pravidelně na své webové stránky.
Nebo to, co byste mohli dokonce udělat, je mít plný git check out přímo umístěný v tomto veřejném html nebo singling z tohoto veřejného html.
Takže by to bylo okamžitě přístupné přes web a kdokoli by se mohl podívat na aktuální skóre a prozkoumat to.
Takže by to bylo užitečné, zejména pro m lidí mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají rádi -
Výkon byl špatný pro některé soubory, a oni mohli přímo m procházet na webu m.
Mohli by také procházet to vlastně na [ORGANISATION101].
To je na vás, abyste jej nastavili tak, aby byl uživatelsky přívětivý a snadno sledovatelný.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na, nebo se dostat k aktualizaci, podání demo papír, který je splatný příští pátek, pokud se nepletu.
A pak musím udělat nějaké projektové zprávy a začínám sbírat dokumenty - nebo odkazy na dokumenty, ještě ne samotné dokumenty, pro dvě zasedání.
(PERSON11) < parallel _ talk > Pro ASR bychom také měli přidat doplňkovou metriku -
Ve skutečnosti bychom měli přidat doplňkové met- tyto doplňkové metriky. < / parallel _ talk >
Takže, jste zmínil jeden, a to je sprostá slova filtrování m hodnocení.
Takže < parallel _ talk > má explicitní seznam věcí, které se nesmí objevit ve výstupu < / parallel _ talk >, že?
< parallel _ talk > A pak vyhodnocení vzácných slov.
A tady máme explicitní seznam jmen a termínů, které chceme, aby se objevily ve výstupu, bodované nejen podle (pořadí) rate < / parallel _ talk >, ale bodované něčím, co tyto věci přímo zohledňuje, že?
ANO, takže naprosto souhlasím.
To zahrnuje také manuální přípravu odkazu.
Takže < parallel _ talk > oba potřebují ručně vytvořené odkazy. < / parallel _ talk >
Mám jednu poznámku od [PERSON1].
Takže < parallel _ talk > [PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit. < / parallel _ talk >
Takže toto by se mohlo stát prázdnou částí druhé věci vzácného slova -
Takže < parallel _ talk > toto by bylo vzácné hodnocení slov pro MT a pak z [PROJEC210] pravděpodobně také dostaneme nějaký slovník. < / parallel _ talk >
Takže to by byla doména [PROJEC210] samozřejmě.
A [PERSON2], mohl bych vás požádat o revizi domény < nesrozumitelné / > a vytvoření takového slovníku tím, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže, jako shortlisting - seznam slov, která se nám líbí a nelíbí se nám v doméně < nesrozumitelné / >.
Mohl bys to udělat?
(PERSON11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Tak, já si to zapíšu.
Takže < parallel _ talk > směřuje k termínu [ORGANISATION62] s titulkovým studijním papírem. < / parallel _ talk >
ANO < parallel _ talk > a pak pak multi-source s [PERSON7] nebo na základě [PERSON7] nebo - < / parallel _ talk >
A pokud jde o ID jazyka, jsem zvědavý, jak přesně ho chcete integrovat, protože to již zahrnuje zvažování více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to můžeme zapojit?
(PERSON13) Bude to zvukový textový pracovník a bude vydávat časová razítka jako pro čtyři nebo dvě sekundová okna a třídu.
< nesrozumitelné / > Ticho, česky, německy, anglicky, a pak nechám na ostatních, jak to budou chtít v potrubí použít.
(PERSON11) To je důležité.
Prosím, napište to sem do dokumentátoru toto < nesrozumitelné / > shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], dobře a také možná [PERSON5].
Pokud máme tento nástroj, musíme (loď) zvuk více ASR nebo více pracovníků < nesrozumitelné / >
Budeme samostatně potřebovat (odeslat) zvuk do anglického ASR, odděleně do německého ASR a českého ASR, například v závislosti na < other _ noise / >
A také, do tohoto jazyka ID pracovníka a pak musíme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je vícezdrojový nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a bude vydávat - pravděpodobně by to chtělo produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Takže potřebujeme filtr pro ASR, takže ASR je tichý, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Jen jsem to vymyslel tento typ nastavení.
Další nastavení by bylo, že stejný zvuk je dodáván do ASR a této kontroly jazyka.
Tato kontrola jazyka je v podstatě součástí ASR, umlčování ASR, pokud je to špatný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Takže prosím, přemýšlejte o tom, jaké jsou naše ropovody.
V ideálním případě si myslím, že nejméně podobný zmatek v řízení a tak dále by vznikl, kdyby naše modely MT byly vícejazyčné.
Pokud podporovaly různé zdrojové jazyky a překládaly z některého z těchto jazyků do angličtiny.
Případně dělat jen kopii, pokud by angličtina byla dána jako vstup, takže bychom měli vícejazyčné více ASR na začátku.
Vše půjde do angličtiny, a pak z angličtiny půjde do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, nebude toto ID jazyka ani potřeba.
(PERSON3) Jde o to, že pokud uděláme analýzu správněji, jedna věc je možné oponentní hodnocení, jen abychom naznačili, že omezení skutečně mají dopad na skutečný výstup.
Že by to bylo hezké a jo možná ta analýza pozornosti.
Ale nejsem si jistý, že by nám to mohlo dát stejné odpovědi, v podstatě, pokud model dodržuje nebo nedodržuje omezení.
(PERSON4) Musel jsem se podívat jen na několik příkladů pozornosti, neudělal jsem žádnou statistiku ani nic jiného, a dívá se na omezení, a když překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti to v tomto smyslu nedělá.
To dělá některé obecné chyby v překladu, ale ne (jevy), které se snažíme vyřešit.
No, vraťme se k automatickému vyhodnocení, problém s nesouladem je, že výstup je správně skloňován, ale kontext je jiný.
Proto to není stejná slovní forma jako v referenci, že?
(PERSON4) Jo, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly automatickým vyhodnocením označeny jako chyba, 91 z nich bylo správně skloňováno ve správných kontextech.
(PERSON4) A myslím, že jen dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako že překlad byl chybný.
A pak jsou některé případy, kdy byl překlad úplně špatný, protože věta byla opravdu špatná a část musí být < nesrozumitelná / >, ale to bylo jen jako jeden nebo dva případy.
(PERSON3) Snažíte se ale sladit formy odklonu, když to vyhodnocujete, že?
Vy neděláte vůbec nic -
(PERSON3) -lemmatizace odkazu a -
(PERSON4) Oba, oba, oba, shoduji jak povrchové tvary, tak lemma.
(PERSON3) Oh vidím, oh jo, to jsou ty dvě skóre, že?
(PERSON4) Je to jen dilema skóre pro (evropské?) není v tabulce, protože tabulka jako se nevejde do papíru tak < nesrozumitelné / >
Pokrytí je vždy jako 97 procent.
Jen generuje správná lemmata, jen-
(PERSON3) No jo, dobře, chápu to, chápu to.
Takže v podstatě pokrytí lemmatu říká, zda existuje omezení, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně skloňováno, ale není tomu tak.
(PERSON3) No jo, jen nevím, jestli ty, jestli ty, jestli chytíš < nesrozumitelné / > když jsme mluvili o [PERSON1],
Ale jedna věc je, že, že (rána) je lepší, ale druhá věc je, že lemmata jsou vlastně správně skloňovány ručně,
Ale to je to, že je další, ne, žádný problém, je to vlastně dobře, že je < nesrozumitelné / > právo, jo.
Tak jsem si říkal, že by tam mohl být.
Ale nejsem si jistý, zda pro to máme nějaká testovací data, ale mohli bychom se pokusit pohrát si s modely s nějakým přenosem stylu?
Jak víte, můžeme použít omezení a pokusit se místo toho použít synonymní omezení a vidět nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to jen vágně popisoval, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakých stylových přenosových datech pro anglickou češtinu? Máme něco?
(PERSON4) < nesrozumitelné / >
(PERSON1) Přenosem stylu, Dušane, myslíš, že by bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, byl by v mluveném jazyce nebo něco takového?
(PERSON3) No, to je věc jako, mám jen omezené znalosti o úkolu.
Ale dokážu si představit, že chcete přepsat větu, že ji nenapsal muž, ale místo toho ji napsala žena, nebo, nevím, jako můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenka je, že styl vět je dost vágně definován.
Takže opět, ne tak jistý.
(PERSON1) Máme tento korpus větných transformací.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například to, že věty jsou obecnější.
Takže detaily jsou vynechány, věta je zjednodušena a pak věta zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení, Matous dělá nějaký experiment s angličtinou-češtinou, ale nemáme tam žádná referenční data.
Nemáme tedy žádný soubor dat pro kompresi vět.
Takže možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediná referenční by byla příliš omezená na to, aby vám řekla něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových transformací, tohle by se například dalo udělat < nesrozumitelné / > pro češtinu, takže možná by byl ten správný člověk Rudolf Rosa, abych se ho zeptal, jestli někdy nějaký takový dataset vygeneroval.
Takže dojde ke generování nějakého větného protějšku založeného na kořenech.
(PERSON3) Myslím, že je to vlastně jako zajímavá otázka, zda můžeme použít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní dílčí část testovací sady [Project1], která by to pokryla.
Ah, takže někdy známe pohlaví mluvčího, takže pokud jste. možná budu sdílet obrazovku a procházet to.
(PERSON8) Nebo jsem to zkusil s Marianem, který se toho právě zúčastnil, a je to... nevím, o kolik BLEU bodů nižší.
(PERSON2) Protože stejně jako způsob, jakým věřím, že Martin dělá svůj < nesrozumitelný / > malý překlad, tak překládá více vět najednou a pak vybere pouze ten střed a jde takto pro celý dokument.
Takže kontext je jako v jedné < nesrozumitelné / > spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nebyl to Dominik, kdo s Ivanou dělal nějaké experimenty?
Myslím, že poslední rok nebo před dvěma lety pro dvojité prázdné, kde se účastnili kontextu nebo zřetězení kontextu se vstupní větou a dělali nějaký překlad na úrovni dokumentu.
Ale věc je s tím s zřetězení není zcela jisté, zda má stejný účinek jako my multi enkodér nastavení-
(PERSON1) Stejně jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale jsem překvapen, že [PERSON8] říká, že to nefunguje na plný úvazek.
(PERSON8) Jo, dobře, tak promiň, možná bych měl být správnější, že to nefungovalo tak, jak jsem to udělal < smích / >
(PERSON1) Jo, protože si myslím, že je to metoda, která se velmi snadno testuje, a vždy by měla být testována v kontrastu se dvěma kodéry, a očekával bych, že někdy bude lepší a někdy horší než dva nastavené kodéry, v závislosti na přesném úkolu, jako je to, co přesně je druhá věc, kterou kódujete.
Takže pokud máte dvě kopie dvou parafrází stejné věty,
Možná je to nějak matoucí pro pozornost, takže cokoliv, nevím.
Chování by také mohlo být odlišné pro staré metody sekvence k sekvenci, ve srovnání s transformátorem, takže pro RNN se pak choval jinak, možná s transformátorem je to jo, je těžší trénovat, takže možná budete muset zvýšit počet zahřívacích her, zahřívací sady.
(PERSON2) Jo, tak prostě vědět jako-
(PERSON8) Nevzpomínám si, takže si přesně nevzpomínám, ale tohle je jako co-
Když jsem v létě začal s těmi multi-zdrojovými experimenty.
První věc, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná jsem, už si nevzpomínám,
Do příští schůzky si to můžu ověřit, jestli jsem to taky zkusil,
Rozhodně jsem se snažil, když zdroje jsou na první pozici pak nějaký oddělovač a parafráze na druhé pozici.
Mohl jsem se také snažil, že jsem zamíchal dvě věci náhodně, jo, a já si jen vzpomínám, že to dělalo hojně tento compenetration věci a snažil multi-kodéry.
(PERSON8) A pravděpodobně to bylo kvůli nízkému skóre.
(PERSON2) < nesrozumitelné / >, které se vám líbí, může zlepšit vaše skóre pohodlí pouhým přidáním výstupu založeného na frázi a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže pokud zadáte výstup založený na frázi, který je v podstatě post editací, že? Můžete o tom přemýšlet jako o posteditaci, jako byste posteditovali výstup založený na frázi, že? Nebo jako záleží na úhlu pohledu, že?
(PERSON1) < nesrozumitelné / >, které chcete zcela přepsat, ale technicky to přesně odpovídá úkolu posteditace, můžete to připojit jako řešení úkolu posteditace.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální token, který rozlišuje, který je zdroj a který je kontext nebo druhá věta, nebo je prostě zřetězíte bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Snažil jsem se, myslím, že dva tokeny a jo, protože v první verzi jsme měli podezření, že token může být také tokenizován sám, takže jsem to přehrál s jiným tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník a tento slovník neobsahoval oddělovací tokeny.
Takže, použil jsem nějaký token, u kterého jsem předpokládal, že nebude jako tokenizovaný na několik kusů a tak se jednou objeví.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže, dalo by se to udělat řádněji, jo, souhlasím.
(PERSON2) Ale část Flask nebo část komunikace s klientem je něco, co nemohu udělat.
Protože nemám žádné zkušenosti a žádný čas na to, abych to spustil.
(PERSON1) Myslel jsem, že to znamená něco pomocí nevím prostředníka.
(PERSON2) Ne, vytvořte HTTP klienta, který může vyplnit frontu a číst z jiné fronty.
A odešlete text zpět v HTTP požadavku.
Protože moje představa je, že kliknutí uživatele bude použito i v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, odešlete zvuk po malých částech současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dát do fronty, kterou budu zpracovávat frontu později s (ASR).
A model s tím udělá nějakou logiku, nějaký závěr.
A kdykoli má nový kus přepisu, pošle ho zpět a uživatel by měl dostat částečný přepis zpět.
A to by mělo být okamžitě zobrazeno v textovém poli.
(PERSON1) Mohl bych o tom přemýšlet.
Akorát Flaska taky moc neznám, ale jo, o tom můžu přemýšlet.
(PERSON2) Možná jiný HTTP server.
Nevím, možná k tomu ani nepotřebujeme nějaký vymyšlený HTTP server.
(PERSON1) Myslím, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo.
(PERSON2) Jo, jediný požadavek je, že by měl zvládnout více připojení najednou.
(PERSON1) Myslím, že online tok textu je něco kolem 2 000 přinejmenším.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochu jinými vnitřními pracovníky, takže myslím, že jo, takže mám < nesrozumitelné / > řekněme deset, dobře místo výstupu, soubor od < nesrozumitelného / > vedlejšího pracovníka, takže < nesrozumitelné / >, který máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně ze všech dostupných pracovníků.
(PERSON1) Ach, to by nám ušetřilo čas.
(PERSON7) Jo, jo, je to velmi důležité, aby se všechno paralelizovalo, paralelizovalo se jak zpracování systémů, tak i vyhodnocení buněčného DF, protože by to musel spustit mnohokrát, dojde k chybám, musíte to rychle znovu spustit.
(PERSON7) Dobře, tak díky.
Takže jste s tím velmi zaneprázdněni, nechci vám dávat žádné další věci, takže mi dovolte začít s připomínkami.
Musíme dokončit popis sady stolů [Project1],
Koho tady máme?
No dobře, vlastně ne, jo, (je to hotové) a tady to bohužel není.
Takže tohle by bylo pro [PERSON2],
Pak vyhodnocení, to je pro [PERSON1], ale o tom jsme diskutovali.
Poslouchej, dej mi tabulku v DSD, dej sem jemnou čáru a zatlačte šablonu tabulky, jako je struktura plánu do delebl nyní, takže čísla přijdou později, ale chci vidět některá čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuji vám.
Máme [PERSON5], to je dobře.
Takže pro [PERSON5] bych chtěl zkontrolovat, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také pro vývoj, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
(PERSON7) Jo, takže je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte si výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromážděte všechny výstupní soubory a spusťte vyhodnocení.
A důvodem tohoto rozkolu je, že můžete více paralyzovat.
Takže jsem si jistý, že na různých frontách budou problémy a čísla budeme potřebovat velmi brzy.
Takže pokud například některé z testovacích souborů z nějakého důvodu selžou,
Pak můžete ještě nechat běžet překlad pro ty zbývající,
A znovu vyhodnotit, s sel T F, chybějící ty, a, a tak dále.
Takže, nejde o to vytvořit sériové, sekvenční zpracování, které zahrnuje obojí,
Ale jde o to získat výsledky, a to je vlastně lepší dělat to v plátcích.
Nejprve získáme všechny výstupy, pak získáme všechna hodnocení.
(PERSON1) Jo, takže, chci říct, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Jako filtrování paprsků a nahrazování paprsků jinými paprsky.
A pro multitokenová omezení a podobné věci.
Ale pokud jde o pozitivní omezení, porovnal jsem pouze tréninkový přístup s těmito velmi jednoduchými věcmi.
Stačí upravit skóre v každém kroku stejným způsobem.
(PERSON7) Dobře, takže zpět k pozitivním omezením.
Soustředili jste se už na analýzu systému?
(PERSON2) Ano, právě teď čekám na přepracování datové sady od ([PERSON9]).
Také [PERSON9] Podíval jsem se na (kód) a myslím, že vím, proč je tak pomalý.
Protože pro každou položku v terminologii při přepracování (Europar) otevřete datovou sadu, tokenizujete ji, čtete ji řádek po řádku, tokenizujete ji řádek po řádku a zavřete ji.
Ale to děláte jen vy -
(PERSON4) Vzpomínám si, že pro [PROJECT1] jsem to dělal z minulého roku z nějaké chaty v horách.
A já jsem si právě uvědomil, krátce před Silvestrem, že to potřebuji odevzdat.
A < smích / > takže to je také něco, co se stane [PERSON8] Obávám se, že by mohl být... no, žádná strana, ale možná na vzdálené straně.
A pak by si najednou uvědomil, že se tomu musí podřídit.
Takže v tomto bodě nebude žádná recenze. < smích / >
Prostě vzal PDF a nahrál ho. < smích / >
(PERSON7) No, dobře.
Takže, Jo, budu kontrolovat 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že je lepší poslat jim e-mail právě teď a jen požádat o tento odkaz předem.
(PERSON7) Dobře.
(PERSON4) Ano, díky.
(PERSON7) Máme dnes diskutovat o jiných otázkách, nebo je to všechno do Nového roku?
(PERSON6) Doufám, že tam nebylo nic pro mě?
(PERSON3) Před několika lety.
Mt maratony mívaly tento systém nebo nástroje, které byly publikovány jako speciální vydání PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normální, jako tam byly také PBML problémy, které smíšené prázdné okrajové papíry a samostatné papíry, protože počet těchto dokumentů.
A dokonce jsme měli věc, jako kdyby papír nebyl dost dobrý pro PBML, ale pokud byl nástroj prezentován na maratonu MT.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, jak už jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, zveřejněte to na MT maratonu mezi lidmi.
Ale tvůj papír je moc špatný.
Musíte to zlepšit, a dostanete se jen na další PBML.
(PERSON4) Ano, ale další možnost pro SIGDIAL.
Není možné, že zkoušením SIGDIALu přilákáme lepší účastníky?
(PERSON3) To je ano, to je. jako bych si myslel, že jsem také měl, ale neznám ani jedno z míst.
Finální papírovou registraci mají v červenci.
Takže konference byla v září a odevzdání příspěvku bylo v květnu.
Protože pro Interspeech bychom to také mohli rozdělit papír po papíru.
Aby některé papíry šly do řízení Interspeech.
A některé z našich podkladů by přišly později pro řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď s SIGDIAL nebo Interspeech.
Jestli je v pořádku, aby měli nějaké naše papíry, vzhledem k tomu, že tyto papíry jsou předkládány do březnového termínu.
Takže existuje absolutní přísný požadavek.
A myslím, že proti tomu nemohou nic mít.
Protože jestli ten papír stojí za to publikovat.
Jako je to jen bonus, že papír má nějaký sdílený výsledek úkolu, který se objeví v satelitní události.
Takže jo, myslím, že je to v pořádku.
Není tedy třeba žádat o svolání zvláštního zasedání.
V Interspeech se tomu říká speciální sezení, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj příspěvek připraven do termínu Interspeech, pošlete jej jako Interspeech papír a budete mít v rámci Interspeech.
Ah, pokud ne, ah, udělejte to pro termín Interspeech, tady je náš termín.
A to je pro PBML.
(PERSON7) Á, dobře.
Ale věc je jako pro Interspeech satelitní událost.
ERM, Interspeech jako se nedostane do žádného řízení.
(PERSON2) Můžete Myslím, že můžete jen můžete jen vyhradit celý semestr jen pro kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale já si myslím, že je to jiná věc, protože si myslím, že to opravdu není věc, aby selhaly jeho kurzy.
Rádi selháváte, protože nejste schopni to dokončit.
Samozřejmě, jako by se lidé jen vzdávali, ale myslím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám na začátku semestru řekl, že pokud chceme jeden (??), dostanete jeden.
Právě do druhého termínu byste ji měli odevzdat.
To je skoro jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů minulých let to spousta lidí nedělá.
Snáze se jim čte na zkoušku.
Ne, promiň, studuj na zkoušku -
(PERSON2) Jo, protože obecně jsou jeho zkoušky poměrně snadné.
(PERSON2) Takže bych neřekl, že je to super snadné, protože existují některé kurzy, kde je zkouška jako zábava.
(PERSON1) No, jeden z nich byl včera pro mě.
(PERSON2) Jo, když má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se opravdu zaváže k něčemu, že například za sekundu nebo dvě zjistí, oh, no, vlastně to byl špatný překlad.
Proto se snaží použít jinou formulaci.
Chcete-li například specifikovat věc.
Takže vlastně, moc se mi to líbilo.
Některé překlady se mi líbí. Byl jsem opravdu ohromen, i když jste mohli vidět, že model udělal chyby na první pokus, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo opravdu plynně, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud nižší kvalita je proto, že překlad, pokud budete číst vše, co dostanete stejné informace, ale znění je jen špatná, protože se používá, například, více slov a používá některé opravy a tak dále.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, třeba nějaké příklady?
Protože bych se na to rád podíval, jen tak ze zvědavosti.
(PERSON2) Určitě, můžu ti dát svoje záznamy.
(PERSON7) Ale ve kterých jazycích?
Protože víte, že neumím německy.
(PERSON2) Angličtina a němčina.
(PERSON7) Jo, ale nemusím nutně mluvit německy < smích / >.
(PERSON2) Pak mohu poskytnout anglicko-čínskou a anglicko-japonskou, pokud to pomůže < smích / >.
(PERSON2) Takže znovu, chci, aby to bylo lidsky čitelné.
Protože tohle blikání je opravdu otravné a pak ztratíte soustředění na to, co bylo vlastně řečeno, protože možná je to také otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Promiňte, nikdy jsem o tom do hloubky nepřemýšlel.
Ale myslím si, že kdykoliv vidím nějaké slovo, tak si ho uložím do paměti a moje paměť není lineární věc, ale je to spíš taková taškařice.
Tak jsem dal slovo do pytle.
A ráda věci v tašce propojuji, abych získala celkový obraz slova.
A myslím, že to je ten problém s blikáním.
Pokud něco přeložíte a pak to změníte, pak už jsem to vlastně četl, je to v mém mozku.
A pak ztrácím soustředění a kontrolu nad tím, co bylo vlastně tehdy přeloženo jako správné a nebylo tím, čím nebylo.
Takže to je důvod, proč si myslím, že celá věc blikání je špatná a hloupá z definice.
Jako vidím motivaci, jako chcete zobrazit vše, co máte.
I když nemůžete slíbit, že je to dobré.
Myslím si ale, že s touto informací navíc nemůžeme pracovat.
A myslím si, že možná problém je v tom, že ty systémy jsou vytvářeny lidmi, kteří s tím pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále to ukazuji a je to nějak dobré, ale myslím, že vývojář se opravdu nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíš to, že, ach jo, můj systém to dokáže vyprodukovat opravdu rychle.
A i když to jen hádá, že kvalita je v pořádku-ish, Myslím, že možná proto byl vytvořen retranslation.
Jen vývojáři systémů touží zobrazovat informace, a myslím, že protože jsme omezeni v objemu informací, které můžeme vnímat nějaký čas, rádi vidíme, že další informace jsou pro nás jen další zátěží.
Takže si myslím, že není dobré ukazovat extra.
Například pokud chcete snížit latenci, pak místo blikání snižte kvalitu.
Myslím, že je to pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste vlastně měli vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Stejně jako technicky, když lidští překladatelé začnou překládat, mám na mysli cíl, dokonce i pro anotátory, by se snažili sledovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatné, takže by se jen opravili.
(PERSON2) No, ale jo, to znamená s mým řešením, jako byste neudělali blikání, ale zavázali jste se, jako neexistuje žádný způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Mám silný pocit, že naše práce není přesně v oblasti řeči, je to nezdravé.
Protože zde není žádný koncept řeči.
Pracujeme přímo na textu.
Ale věc se má tak, že návrh na statistický workshop pro letošní rok je u konce, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel na rok 2022, což by už pro nás bylo pozdě.
Je lepší, když dostaneme jednu ze dvou sektil nebo Interspeech, protože oba jsou v komunitě dobře uznáváni.
Můžeme motivovat účastníky k odevzdání.
Ah, jediná jediná námitka, že jsem najít teď jde s Interspeech je, jako by nám nedovolí prostor v řízení, což může odradit některé z účastníků, Nejsem si jistý, jak moc budou nadšeni zveřejnit papír v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, že?
Takže to není výhoda pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
To byl důvod, proč jsem se za toto zvláštní zasedání zaručil.
Ale tentokrát je problém v tom, že to, co mohu pochopit, je naposledy, časové období mezi návrhy, podáním a konečným předložením papíru bylo pět měsíců, takže by to bylo dost času na náš harmonogram, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vnímám jako důležitý možný zdroj nerodilé anglické řeči, který můžeme využít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na soutěž Nejjasnější hlas, a pokud budeme muset, můžeme udělat stánek.
To bych ale rád omezil, protože šíření na středoškoláky má pro nás menší dopad.
Je důležitější použít ji jako testovací relaci.
Takže bychom se měli zaměřit, [PERSON1], na [PROJECT2] Nejjasnější hlas a udržet organizátory šťastné, abychom tam mohli shromažďovat data.
A udělat to, co chtějí, abychom udělali výměnou za to, a my musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tento plenární program užitečný.
Takže by to pro nás bylo testovací zasedání, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže pokud jsme dotázáni, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, pak v pořádku, ale pokud ne, pak si myslím, že je pro nás určitě dobré být jen za oponou a v zákulisí a dělat tam svou práci.
(PERSON1) Jo, ještě jsem se o to nepokusil, ale myslím, že minule bylo povinné mít stánek.
(PERSON2) Ano. Takže s nimi diskutujte o tom, co je potřeba, aby byli šťastní, a oni nám umožňují dělat Nejjasnější hlas, což je nejdůležitější věc.
Zkušební relace je méně naléhavá.
A budka je prostě něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se připojili k zasedáním dříve, než aby dělali takové věci.
Takže tyto přípravy opravdu potřebujeme procvičovat.
V online světě se zdá, že jednoduše vstoupíte do relace a práce je hotová.
Tak tomu ale není.
Vždy trvá 30 minut, než se spustí a správně připojí.
Takže tam musíme být dříve.
A pokud nějaká relace, kterou děláme, začíná v devět, ale organizátoři se scházejí ve čtvrt na devět.
Pak už musíme přijít ve čtvrt na osm, abychom měli těch 30 minut navíc, abychom se ujistili, že všechno běží a naháníme lidi.
Takže toto je poznámka pro všechny, aby vedení fungovalo, prosím také předvídejte, co by vás vedení mohlo náhle požádat, abyste udělali, a to by trochu pomohlo.
Dalším poselstvím, které je velmi důležité, je záznam těchto důležitých zasedání.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytl jakoukoli aktualizaci dokumentu.
Možná jsem vám to všem zapomněla říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto sezení.
Takže je důležité pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, mít dobré záznamy těchto zasedání.
A jedním aspektem je získat souhlasy, aby bylo skutečně povoleno nahrávat.
A to i když se budeme snažit získat souhlasy zpětně, nebo cokoliv.
Pak je tu technická stránka nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
ANO, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citrony v řadě: (
Objednal jsem si od této společnosti, protože jsem si ji koupil v předchozích sezónách a fungovalo to skvěle pro nás.
V této sezóně jsem si koupil další velikost, kterou jsem potřeboval.
Jedno z pyžam, které jsem dostala, mělo na noze pyžama díru.
Vrátil jsem ho a firma mi poslala nový.
Náhradní pyžamo, které měl jednou na sobě můj syn, jsem dala jako vždy do pračky a zip se utrhl!
Jsem tak zklamaný, protože nemám čas se zabývat návraty každých pár dní, a přesto se to děje právě teď.
Přesně jak je popsáno
Jedná se o základní puffer coat.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuově utěsněném sáčku, takže je třeba ho pověsit na pár dní, aby se vrásky dostaly ven a trochu se "nafoukly."
Jsem 5 stop 6 palců a kabát je délka kolena na mě.
Objednal jsem si 2 + velikosti kvůli dalším komentářům a minulým zkušenostem a kabát je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapuce funguje, ale nejsou na ní žádné kravaty.
Přední zip je funkční.
Na boku ani na zádech nejsou žádné otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase mám dvě kapsy (u vás mohou být vyšší nebo nižší).
Neexistují žádné ozdoby nebo stylingové detaily - je to BASIC COAT.
Za tu cenu si myslím, že je to fajn.
Měla jsem ho na sobě ve větrném dni, ale ne v zimě.
Necítila jsem vítr, takže to bylo dobré znamení.
Nicméně jsem zvědavý, jak to bude fungovat v chladnějších teplotách a v dešti / sněhu (má být odolný).
Celkově mě to těší.
Sáček s vakuovým těsněním lze znovu použít a prodejce zahrnoval opravdu roztomilou děkovnou poznámku, která byla skvělým dotykem.
Tohle je moc hezká sukně.
Krajkový vzor je elegantní a měkký
Tohle je moc hezká sukně.
Krajkový vzor je elegantní a měkký.
Nemačká se, dokonce i poté, co byl nacpaný do plastu a krabice, byl velmi hladký, takže je to opravdu v pohodě.
To může být snadno oblečeno nebo oblečeno a má jakýsi vintage pocit kvůli délce a řezu, který jsem opravdu do.
Myslím, že tohle by mohlo být lichotivé na kohokoliv.
Jsem 5 '5 "a 130 liber a objednal jsem si malý, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, určitě velikost dolů.
Nepracoval s mým Buick LeSabre z roku 1999
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce i s předinstalovanou baterií.
Nicméně, i když to mělo být kompatibilní s mým 1999 Buick LeSabre, dálkové ovládání se nepodařilo naprogramovat nebo synchronizovat s autem.
Pokyny jsou dostatečně snadné a vím, že jsem je správně sledoval, protože jsem byl schopen úspěšně přeprogramovat svůj starý dálkový ovladač.
Tento nový by však nefungoval, a tak ho vrátím.
S prodejcem ani servisem nebyl žádný problém, jen se zdálo, že tato konkrétní položka je vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Mřížka mého auta byla vytržena velkým něčím, co letělo po dálnici, takže jsem potřeboval náhradu.
Po přečtení několika recenzí jsem se bála, že se to nehodí, ale bylo to perfektní!
V roce 2013 jsem koupil Corollu LE.
Nedal jsem si to na sebe - měl jsem chlapa v obchodě s tělem, který to pro mě udělal - ale vypadalo to opravdu snadno.
Prostě to prasklo za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože se zdá být docela chatrný (čas a létající trosky řeknou), ale celkově jsem velmi spokojen, že moje auto už nemá zející tlamu na přední straně a že cena byla přiměřená.
Potřebuje zlepšení
Super úžasné světlo Můj 5 letý absolutně miloval toto světlo Nemělo to trvat dlouho, dostal ho k narozeninám v lednu, je to únor, už má problémy s tlačítky a neběží jasně se zástrčkou, vyžírá baterie, dokonce se snažil dobíjet baterie Super cool, ale potřebuje zlepšení
Hudební start
Klavír je skvělý začátečník!
Nachází vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruka-oko.
Klavír není jen hračka, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby se vaše dítě stalo budoucím pianistou, měli byste tento produkt vyzkoušet!
Velmi stojí za ty peníze!
Dal jsem si to na nos podle pokynů dvakrát denně a tříl jsem to po dobu 2 minut.
Kůže na mém nose zčervenala a byla úplně syrová.
Byl jsem z toho dost zaskočený.
Měl jsem dobře zahojenou jizvu z pádu do ostnatého drátu před lety.
Nejen, že tento produkt nefungoval, ale téměř jsem skončila v ordinaci dermatologa, nicméně uvedení aqua-for a bandaid nad oblastí se konečně uklidnilo asi po týdnu.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo tu formuli zpackal?
To je tak zvláštní.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslila jsem růžovou linku pomocí malířské tyčinky od jiné značky, abyste viděli, jak by růžová měla vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl jim říkat červené nebo růžové.
Bílá není tak jasná, jak bych doufal.
Ostatní barvy jsou skvělé a líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem si myslel, že tam byla růžová.
Myslím, že fialová bude stačit.
Funguje z větší části
Před několika měsíci jsem si odbarvil celou hlavu a pak jsem ji obarvil černým barvivem.
Pak jsem šel a měl zvýraznění dát po celé mé hlavě.
O pár týdnů později jsem si na vlasy nanesla modrozelenou barvu Arctic Fox a nevybledla.
Použil jsem tuto látku s Olaplexem č. 3 a to se TŘESTNĚ zesvětlilo, odstranilo zelené a modré části, stejně jako zvedlo tmavé barvivo.
Nicméně, po dni jsem si všiml, zelený odstín na vlasy.
Každý den se to zhoršuje a já jsem použil extraktor barvy dvakrát, se stejnými výsledky.
Moje vlasy jsou také stále tmavší, kde byl box barvivo.
Jedná se o skvělý produkt, který prostě nevypadá, že vydrží.
Nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román musí být zmírněno některými realističtějšími hodnoceními.
Zkoušel jsem to číst, ale jazyk mi přišel plochý.
Metafora "sladké vody" a mnohé popisy dělohy jako řeky a dítěte jako ryby se zdály být vynucené, otřepané a vymyšlené.
Přeskočil jsem dopředu a vypadalo to, že jediné, co najdu, je kampus drama.
Dávám této knize 10 hvězdiček!
Vynikající čtení!!
Absolutně jsem miloval knihu!!
V průběhu let jsem adoptoval 4 siamské kočky od Siri a všechny z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri šla nad rámec svých snah o záchranu koček (hlavně siamských)!!
Opravdu se mi líbí toto prstencové světlo!
Je to skvělé pro cenu a dostane práci!
Jediným problémem je, že žárovka se zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout a chvíli počkat a pak ji znovu zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám vadné světlo nebo co, ale kromě přehřátí je to velmi pěkné kruhové světlo.
Nepřehledný děj
S knihou bylo těžké držet krok, protože hodně poskakovala.
Ani název se k příběhu nehodí.
Autor uvedl, že několik lidí bylo infikováno tímto mimozemšťanem, ale vynechal podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byla zmatená a musela jsem se vracet a hodně číst, abych se ujistila, že mi nic neuniklo.
Miloval Collinse...
Chvíli trvalo, než se Grady rozehřál
3 1 / 2 hvězdy Remedy je romantika nejlepšího přítele bratrů, stejně jako romantika druhé šance smíchaná do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše proto, aby Collinse získal zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostává vše, o čem snila, nejlepší kamarádku svých bratrů. ale když se druhý den ráno probudila sama a nikdy se jí neozvala, věci se rozhodně změnily.
Teď je Grady zpátky a neodchází, a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdává.
I když jsem miloval premisu tohoto příběhu a občas Gradyho, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale neposlat ani dopis Collinsovi, aby se vysvětlil?
Nechat ji všechny ty roky přemýšlet a bolet a pak očekávat, že ho přivítá zpátky s otevřenou náručí?
Byl snad bludný?!
Collins měl pravdu, když byl rozrušený, naštvaný, zraněný atd.
Měla pravdu, když se s ním poprala, když ji chtěl zpátky, a šla dál.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Milovala jsem Collinsovou v této knize, byla silná a střežila své srdce, a za to jsem ji obdivovala.
Jistě, že milovala Gradyho, ale byla vyděšená a váhala, jestli ho pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně nechávala věci plynout tempem, jakým chtěla, a když byla připravená poslouchat, poslouchala.
V této knize je hodně úzkosti a líbilo se mi sledovat, jak se tito dva znovu spojují, když Collins začal odpouštět Gradymu, jen si přeji, aby Grady nevyšel jako tak kňučivý a byl by trochu více pochopení.
Pořád říkal, že rozumí, ale občas byl na mě trochu moc dotěrný, a pak byl ke konci sladký.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla potíže číst jeho názory, protože jsem se nemohla spojit s jeho postavou.
První díl knihy nebyl můj nejoblíbenější, ale druhý díl ano.
Líbí se mi, proto mé hodnocení.
Pokud máte rádi druhou šanci, a bratři nejlepší přítel románky, můžete si opravdu vychutnat tuto knihu, jen jsem měl těžký čas s Grady na první a jak se mu podařilo některé z věcí, které udělal.
On i Johnny Depp jsou úžasní herci.
Co se týče jeho portrétu Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je těžké říct, že je to on.
On i Johnny Depp jsou úžasní herci.
Jeho ztvárnění Churchilla je velmi povedené.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otáčení stránek...
Kulisy i kostýmy byly vynikající.
Je dojemný s dnešní dvojicí polobohů, kteří zastávají světové politické postavení.
Stojí za to podívat se několikrát... stojí za zamyšlené přemítání... ještě mnohokrát
Vyhněte se připojení Wifi - přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme se stěhovali a bydleli v hotelu.
Nemohl jsem se dostat tuto váhu připojit k Wifi v hotelu.
Rozhodl jsem se počkat, až jsme se přestěhovali do našeho domova a já jsem mohl nastavit svůj vlastní systém Wifi.
Březen 2018- Nastavil jsem svůj systém Wifi a tato váha se stále nepřipojí.
Pokaždé, když to zkusím, dostanu chybovou zprávu.
Dokonce i když jsem 10 'od jednotky Wifi.
Sledoval jsem instalační video YouTube bez úspěchu.
Když jsem si koupil jednotku, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato váha používá Wifi router pro komunikaci s telefonem.
Tento systém je omezen na připojení routeru... který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Nedoporučil bych tuto váhu nikomu kvůli připojení Wifi.
Místo toho se prosím podívejte na systémy, které pro komunikaci používají Bluetooth.
Nahrazuji to stupnicí připojení Bluetooth.
Dobrý, ale rád bych našel něco lepšího
Po mnoha výzkumech jsem tento produkt začal používat před mnoha lety.
Měla nejmenší množství škodlivých složek a stále fungovala dobře.
Vysušuje se však tak rychle, že nakonec používáte tolik maziva, což nakonec stojí spoustu peněz, stejně jako příliš rušivé během sexu.
Byl jsem příliš líný, abych hledal nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš nákladný.
Životnost baterie je hrozná na tom, který jsem koupil na Amazonu.
Stále nemohu uvěřit, že Logitech přestal tento dálkový ovladač, nic jiného se ve srovnání neblíží.
Naprosto miluji tento dálkový ovladač Harmony, je to můj čtvrtý.
Pes žvýkal první, manžel klečel na obrazovce druhého a třetí stále pracuje, ale uprostřed dotykové obrazovky je značka lokte také s laskavým svolením manžela... koupil to jako zálohu a obrazovky skvělé, ale baterie, se kterou přišla, drží nabití možná na pár dní.
Můj původní (třetí) udržuje nabíjení po celé týdny a já používám dálkový ovladač pro všechno.
Rozbil se za necelý týden
Líbí se mi produkt, je to pěkná velikost a barva!
Bohužel to mělo jen týden a otevřelo jedny dveře a prasklo horní část dřevěného kusu!
Jsem opravdu zklamaný!
Je to všechno sestavené a já už nemám krabici, takže jak bych mohl vůbec přemýšlet o tom, že ji pošlu zpět?!
Můj manžel to zkusil opravit dřevěným lepidlem, ale bohužel to také nefungovalo!
Dveře se opět otevřely!!!
Není příliš snadné sestavit plus.
Je to pěkný kus nábytku, když je sestaven, ale montáž byla obtížná.
Některé z písmenných označení byly nesprávně označeny, takže jsem se musel pokusit zjistit na vlastní pěst Šrouby, které dodali k připevnění podlahy a bočních panelů, praskly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také skleněné panelové dveře jsou mimo linii a neodpovídají rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedna z dvířek zůstala zavřená, protože magnet, který udržuje dvířka zavřená, je mimo linii.
Ještě jsme nepřišli na to, jak je sladit.
Špatný kód vytištěný na horní části modulu
Koupila jsem je v únoru.
Nedávno jsem se je snažil použít a bohužel pokaždé, když se snažím jeden můj stroj Keurig mi dává chybovou zprávu, že modul není kompatibilní s mým strojem.
Používám Donut Shop lusky v mém stroji, protože jsem si ho poprvé koupil a nikdy jsem neměl problém.
Při bližším zkoumání kávové kapsle jsem si všiml, že kód vytištěný na horní části kapsle není příliš čitelný, takže mohu pouze předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72, což je 6 krabic po 12.
Dokonce jsem zkusil jeden z každého z 6 boxů a stále dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože jiné lusky, které zkouším, fungují dobře.
Je to jen z této zásilky, že mám tento problém.
"Je to velké zklamání, protože mi vypršelo návratové okno.
Aktualizace: Mluvil jsem se zástupcem zákazníka, který vracel peníze.
Děkujeme společnosti Amazon za vaši skvělou zákaznickou podporu!
Sladidlo na cesty.
Taková vymoženost!
Je opravdu hezké mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích!
Miluji odchýlit, a to je tak výhodné mít tyto hodit do kabelky pro stolování, nebo použít v domě přítele.
I když jsou trochu drahé, nemůžu vystát Equal nebo růžové věci v mém ledovém čaji.
Odchýlit se nebo nic, takže jsem nadšený, že mám své sladidlo na cestách!
Nedělá vlastně žádné "čištění" vzduchu
Koupil to jako zvlhčovač, část "čištění vzduchu" je ve skutečnosti falešná reklama; v závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač knotového typu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku, budete pravděpodobně muset spustit asi 5 let, aby se rozdíl.
Má poměrně velkou kapacitu vody pro svou velikost, protože "nádrž" je nedílnou součástí jednotky a je to nízký výkon (i když není lepší než typ knotu).
Je také poměrně snadno čistitelný, i když plastové disky nemohou být skutečně servisovány, protože disková jednotka nemůže být rozebrána.
Nicméně, pro německé inženýrství, kvalita sestavení není skvělá.
Měl jsem můj rok, což by bylo asi šest měsíců v chladném počasí, a jednotka vyvinula velmi nepříjemný rachotivý zvuk z ventilátoru.
Můj odhad by byl ložiska ventilátoru, takže jen čekám na úplné selhání, které se zde stane.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní nákupu nového zvlhčovače knotů.
Tl; dr - nestojí za dodatečné náklady, je lepší mít zvlhčovač knotu.
Asi se to zlomilo snáz, než si mysleli.
Dávám tomuto produktu 3 hvězdičky za to, že když jsem ho dostal, byl už uvnitř zlomený.
Jakmile jsem to prozkoumal, uvědomil jsem si, že ten, kdo ho dal do krabice, ho tam dal rozbitý. Mohlo to být buď výrobci balíků, nebo kvůli výrobcům, problém by mohl být v tom, že kupující vrátil položku a tvrdil, že ji prostě nechtěl nebo ji nepotřeboval a Amazon možná neudělal dostatečně dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti kupující nemohl říct, že to bylo rozbité, protože pak by to Amazon nevzal zpět, což je dobré zejména s tímto druhem produktu, i když jsem ten, kdo uvízl s něčí nedbalostí.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a diskutoval o tom se svým manželem, rozhodl jsem se dát tomuto kupujícímu další šanci.
S tím jsem řekl, že budu aktualizovat své hodnocení pouze na vyšší hvězdu v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (alespoň tím, že ho osloví) a pokud položka přichází ve skvělé kondici, skutečně má příležitost dělat to, co dělá, a funguje dobře, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale instalace pro mě nebyla tak snadná.
Zkoušel jsem nainstalovat oba "zvony" do připojeného vysílače několikrát bez úspěchu.
Byl jsem připraven ho vrátit jako nefunkční, ale myslel jsem, že bych to ještě jednou zkusil a zkontroloval baterie ve zvoncích.
Voila. z krytů baterií trčely malé plastové jazýčky, které jsem vytáhl, a vyšel plastový kus, který zakrýval baterii a zastavil ji.
Poté, co jsem odstranil tyto kusy plastu, zvonky fungovaly dobře a byl jsem s tímto nákupem zcela spokojen.
Zvláštní je, že v uživatelské příručce není zmínka o plastu nad baterií, který musí být odstraněn, aby zvonek fungoval.
Bylo by to mnohem méně frustrující, kdyby se o tom zmínili a nemyslel jsem si, že problém byl v tom, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou kroužků, zvonků a melodií, které si můžete vybrat, a je snadné je kdykoli změnit.
Jedna věc, kterou se ptají při hodnocení tohoto zvonu, je, jak je "odolný proti povětrnostním vlivům."
Nemohu se k tomu vyjádřit, protože byl nainstalován 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný vůči povětrnostním vlivům až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - Znovu nabito
Vyrostl s nimi a byl psyched je koupit pro mého syna, ale ztratili balíček živých housenek.
Řekli mi, že mi ho vymění a tentokrát budou účtovat poloviční poštovné.
Po značném telefonním čase mi nakonec znovu účtovali za novou objednávku se slevou 3 $.
Myslel jsem, že je to docela neprofesionální, protože nejen, že to ztratili, ale vedli mě k přesvědčení, že to napraví, jen aby mi účtovali téměř plnou cenu na konci 30 minutového telefonátu s nějakým spielem o voucheru.
Strávil jsem 30 minut na telefonu, takže jsem se vzdal a koupil další sadu housenek.
Cokoliv.
Funguje dobře po několika bolestech hlavy.
Měl nějaké problémy s tím, aby to fungovalo.
Dodávaný kabel nebyl dobrý - nenabíjel baterii.
Když jsem vyměnil kabel s mým vlastním byl schopen nabíjet a poté připojit zařízení přes bluetooth k počítači.
Měl jsem potíže s nalezením softwaru pro PC, ale když jsem poslal e-mail jejich podpoře, odpověděli do jednoho dne se správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, ale nebyl jsem schopen se připojit k iPhone nebo iPadu (vyzkoušel jsem několik z nich) přes bluetooth.
Budu muset pevně zapojit, pokud se rozhodnu použít toto zařízení v mém produktu.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je jako starožitné zlato
Zeptal jsem se prodejce, jestli je barva příliš žlutá před nákupem a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízkého!
Sada vypadá velmi levně.
Je to super lesklá žlutá se spoustou CZ, ještě lesklejší.
Na fotce vypadá skvěle, ale v reálu bych ho nedala ani puberťačce.
Prstýnek se mi líbil, ale nemohla jsem ho nosit pořád!: (
Ten prsten byl krásný.
Miloval jsem design a robustní pocit; vypadalo to drahé a bylo to velmi pohodlné!
Jediný důvod, proč jsem dala jen 3 hvězdičky a nakonec produkt vrátila, je ten, že jsem si uvědomila, že ho nebudu moct nosit pořád.
Rád nosím své prsteny po celou dobu, což je důvod, proč se vždy ujistím, že dostanu sterlingové stříbro, a vím, že někteří lidé říkali, že jejich prsteny po chvíli ztmavly, ale já jsem nosil můj asi týden rovně - dokonce i při mytí rukou - a nevšiml jsem si žádného ztmavnutí.
Je zajímavé, že problém, který jsem měl, byl, že vnitřní pás prstence se ve skutečnosti obrátil na můj prst bílý a vlhký - něco jako způsob, jakým bandaid dělá poté, co ho necháte na dlouhou dobu.
To se stalo, i když jsem se ujistil, že prsten a můj prst byl zcela suchý.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale stalo se to nepříjemné, takže jsem se rozhodl, že to není prsten pro mě.
: (Škoda, protože jsem to opravdu miloval!
Takže pokud si kupujete tento prsten s úmyslem nosit ho jen občas, říkám, jděte na to!!
Nebudete zklamáni!
Kupte si hýčkaného šéfkuchaře...
Vlastním malou lopatku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Miluji použití těchto kopečků při pečení pro dokonale porcované sušenky.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a získat OXO - obvykle mám štěstí s jejich produkty.
Tenhle ne.
Asi na sušence s arašídovým máslem # 30 přestala fungovat páka uvnitř lopatky.
Musel jsem vypáčit rukojeti od sebe a znovu umístit páku, abych udělal několik dalších, a pak opakovat.
Takže... zachránit svůj zdravý rozum a koupit Pampered Chef lopatku.
Je to naprosto stojí za to!
Už si nekoupím kafe
Byl to dobrý kávovar na chvíli, ale tam byly vždy problémy s ním.
Pokud byste dostali vodu mezi černý plast a kov na karafě, prosakovala by a vypouštěla vodu po celé dny.
Pak se zlomila naše plastová páčka, která umožňuje, aby káva protékala filtrem a do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je to skvělé na přípravu kávy a udržet ji v teple, ale existuje příliš mnoho dalších problémů s ním investovat do něj za současnou cenu.
Musí koupit!!
Milovala jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi, že mám trochu více detailů v rukojeti a všiml jsem si, že předtím, než jsem si ji koupil, což je důvod, proč stále dávám 5 hvězdiček!
Bylo snadné se vyčistit a všechno přišlo zabalené jednotlivě, což jsem zjistil, že je opravdu organizované a uklidnilo mou duši lol láska, láska, láska k barvě a určitě bych si to koupil znovu pro sebe nebo pro milovaného člověka!
Může být dobré na tyči, ale NE jako závěsná přepážka nebo štít proti počasí.
Ostuda pro Audubona.
Pokyny vám říkají, abyste zasunuli zástrčku do otvoru v přepážce a "Ujistěte se, že je bezpečně na svém místě."
Jak???
Je navržen tak, aby přepážka jednoduše seděla volně na zástrčce, takže ji může vytlačit jakýkoli tvor nebo sebemenší vítr.
Můžete otočit zástrčku vzhůru nohama tak, aby šrouby palce byly na spodní straně ozvučnice, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to neudělá a jen nejmenší prsty by to měly snadné.
Trvalo mi více než hodinu, než jsem udělal napůl pečenou práci, když jsem je zašrouboval, abych zajistil přepážku na zástrčku.
Jedná se o kompletní pita.
Objednal jsem čtyři z nich; tři, které jsem neotevřel, jdou rovnou zpět a já jsem na trhu pro lepší strážce počasí.
(Přiznejme si to; neexistuje nic takového, co by ve skutečnosti "zmátlo" veverky!)
Mám rád mnoho funkcí těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které moje nové sazenice zeleniny dostávaly z okna.
Líbí se mi mnoho vlastností těchto světel.
Klady: Za prvé, snadno se upínají na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou chladná na dotek a nezpůsobují poškození ani při dotyku s rostlinami.
Věřím, že mé zelenině světla prospěla.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Nepoužíval jsem časovač, raději jsem je zapnul a vypnul sám.
Vidím tuto funkci jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Proti: Nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro školky.
Světla jsou malá!
Až světla dohoří, budu si muset koupit celou novou jednotku.
Pozor... VŮNĚ JE VELMI ŠPATNÉ... SLOTY NA KARTY PŘÍLIŠ VELKÉ!
Když jsem to viděla poprvé, myslela jsem si, že je to krásné, ale páchlo to tak špatně.
Zpočátku jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že je to vůně MOLD.
Nikdy to nezmizelo, tak jsem to musel vrátit.
Kapsy na kreditní karty jsou příliš velké.
Kreditní karty klouzat celou cestu dolů, tipy neukazují, takže nemáte tušení, co karta je kde a velmi obtížné se dostat ven.
Fotka, KTEROU Ukazují, KDE KARTY VSTUPUJÍ, JE NEPŘESNÁ.
Je to velmi malé..
Obdržel cestovní peníze pás a to mnohem menší, než ukazují obrázky.
Přál bych si, abych si ji nekoupil a stále budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Za prvé, musím říct, že barva je loveeeee.
Spousta věcí, které si objednám ve fialové, mi vždycky přijde moc světlá, moc dětinská, moc divná, moc neonová.
Ale tato fialová byla hluboká a svěží a já ji miluji, deštník je robustní a opravdu kvalitní.
Nejlepší deštník, co jsem kdy měla.
Dodává se s krytem a i když nemusí mít mnoho funkčního využití, opravdu to vypadá ostře.
Balení je hrozné - obdržel 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že firma neví, jak svůj produkt ochránit.
Nesnažte se získat ten, který není poškozen.
Vrátili jsme 2 kvůli poškození při přepravě a třetí byl také poškozen.
Vzdal se.
Dodávají ji v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné polstrování.
Cool koncept!
Jen potřebuje nějaké další vylepšení, aby to byl opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené, způsob, jakým to funguje, je současně působí jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a zaznamenává vše, co vyjde.
V samotném mikrofonu není žádná hudba.
Má konektor bluetooth, takže jej můžete synchronizovat s telefonem a stáhnout karaoke aplikaci, která může posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi pro nastavení hlasitosti hudby a vašeho hlasu (také samostatně!)
A dokonce má možnost nastavit úroveň ozvěny, takže budete skutečně znít, jako byste byli v karaoke místnosti.
Některé věci, které bych chtěl vidět budoucí zlepšení, jsou: 1) existuje nějaká nepříjemná zpětná vazba, která se nezdá, že zmizí bez ohledu na to, jak daleko jsem vzdálil telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem přísavka na minimalismus, takže by bylo skvělé, kdyby budoucí produkty mohly design uhladit.
3) podpora pro více karaoke aplikací Konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne přes plochou obrazovku nebo centrální reproduktorový systém v obývacím pokoji, není to tak zábavné v nastavení strany.
Pokud to výrobce dokáže nějak integrovat do většího ekosystému party karaoke, bylo by to mnohem příjemnější.
Žebrování off od Vision Supplies
Říjen 2017 zakoupil čtyři (4) kazety od Vision Supplies - Amazon Marketplace, takže bych měl v případě potřeby a ušetřit náklady na dopravu.
Použil jsem dva za posledních pár let, asi jeden rok, a fungovaly dobře.
Snažil jsem se použít jeden minulý týden, téměř prázdný po vytištění štítků 20, ale v minulém došel po stránkách 40.
Na obou chybí plast.
Uvedená záruka vypršela!!!
Kdo by kontroloval každou jednotlivou kazetu při přijetí???
Kupující být vědomi!!!!!!!!!!!!!
Je mi líto, Cože?
Kamarádka mi doporučila masku z této řady, tak jsem si koupila tuto, tento kondicionér a vše v jednom mléce.
Nemohu mluvit o účinnosti produktu, protože vůně byla prostě nesnesitelná.
Víte, že zatuchlý zápach starých budov se používá v dámských toaletách, aby se pokusil maskovat zápach * dam *, ale ukázalo se, že je to kyselý, chemický, druh zatuchlé babičky?
To je všechno, na co si vzpomenu, když to ucítím.
Znáte různé tahy různých lidí, takže možná se vám bude líbit vůně.
Můj přítel řekl, že to může pomoci i těm nejvíce poškozeným vlasům, takže pokud se nestaráte o vůni, pak se nemusíte bát.
Vím, že přírodní produkty nebudou vonět tak krásně jako některé syntetické, ale mám pocit, že stále více přírodních linek se o to méně stará, protože se stejně bude prodávat a tak teď všechno prostě voní jako playdough.
Ztratil jsem pár oblíbených řádků, když jsem změnil vzorec na levnější ingredience.
Nevím, jestli je to ten případ, nebo jestli je to falešný (který jsem zavolal Davines a oni řekli, že to není), ale to voní jako Y U C K a musel jsem ho vrátit.
Shazuje internet
Koupil jsem si tento modem / router asi před dvěma lety.
Na začátku se to zdálo být v pořádku, ale za poslední rok plus jsem měl problémy s ním klesá internet.
To se děje na všech mých zařízeních, a to jak Wi-Fi, tak kabelové.
Jediným způsobem, jak obnovit službu, bylo provést reset napájení střídavého proudu.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel ven, spustil nové koaxiální vedení z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Kluci z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést obnovení továrního nastavení, abych to obnovil.
Nemohu doporučit tento modem / router na základě mých zkušeností.
Koupil jsem si Netgear AC1900 modem / router.
Je to fantastické.
Měl jsem to více než týden bez problémů.
Je rychlejší a má větší dosah než Arris.
Četl jsem online, že jiní lidé měli problémy s modemem / routerem Arris připojeným ke společnosti Comcast.
Pokud máte Comcast internet nedoporučuji tento Arris modem / router.
Pořiďte si Netgear, je mnohem spolehlivější.
Ale stává se to dost, aby to bylo otravné.
Na pozitivní notu
1 z fanoušků znělo z krabičky nevyváženě.
Ovládací prvky rychlosti jsou opravdu nepředvídatelné - pokud je vytočíte na 100%, ventilátory se vypnou, takže je musíte otočit na 100% a pak pomalu vytočit, dokud se nevrátí.
Kvalita sestavení je průměrná, ale zdá se, že je to pro většinu těchto typů produktů v tomto cenovém bodě.
Nohy pro držení notebooku, když je nakloněný, se několikrát utrhly.
Vrací se, ale je to dost otravné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z otvorů umístěných v horní části notebooku.
Mnoho jiných chladičů má ventilátory směrem ke středu a poskytuje velmi málo dalšího proudění vzduchu do notebooku s takovou konfigurací chlazení.
OK případ s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný - 3,5 nebo 4 max.
Problém je, že pro pero Tab A 10.1 w S je k dispozici méně případů.
Z těch Gumdrop je asi nejlepší, ale má některé vážné problémy.
Kaučuk pouzdra (silikon, cokoli) je velmi hladký a kluzký a nedává vám velkou důvěru, když držíte Tab jednou rukou.
Tab A je těžký, takže pokud si položíte sledování videa, pouzdro vám sklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový štít, který pokrývá obrazovku, protože narušil provoz dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a křehký.
A nakonec ztížili přístup k S-peru.
Pero S je v zadním pravém dolním rohu karty Tab A a vytvořili malou gumovou klapku, která chrání rohový švih dozadu pro přístup k peru S.
To znamená, že aby se pero S dostalo ven, musí se klapka otočit o 180 stupňů.
To je opravdu nepříjemné a těžké dělat jednou rukou.
Toto pouzdro dobře chrání můj Tab A, ale s těmito vážnými konstrukčními nedostatky ho nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu elegantní - jedna zastávka nakupování pro všechny mé potřeby připojení.
Miluji jen házet to a můj notebook malý napájecí adaptér v mé tašce a být připraven pracovat na velkém 4k displeji nebo zachytit fotografie z mého fotoaparátu.
Jediná divná věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích usb-c, které jsem zkoušel od různých značek), je, že mac zřejmě nedokáže rozeznat rozdíl mezi násobky stejného monitoru (takže můj mac vydává stejné video na všechny identické monitory připojené k rozbočovači, ať už pomocí HDMI a / nebo VGA).
Ale pokud používám 2 samostatné rozbočovače / adaptéry nebo 2 různé modely monitoru, pak mac správně výstupy na displeje jednotlivě.
OK, potřebuje nějaké zlepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký druh bezpečnostního zámku nad šokovým tlačítkem (byl stisknut více na nehodě, když je v kapse, pak jsem ho skutečně zamýšlel použít), moji psi se dokonce náhodně zapnuli po šlápnutí na dálkové ovládání.
Také pokud se váš pes rád válí v mývalích výkalech, jako je ten můj, je to taková bolest v zadku, aby se vyčistila.
Jak se fekální hmota dostane mezi praskliny zařízení, které vyžadují, abyste rozebrali celou věc, abyste ji řádně vyčistili a dostali zápach ven.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že téměř potřebujete přímku pohledu, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Být dobíjecí je určitě hezká funkce a nabíjení trvá dlouho.
Potřebuji nabíjet jen jednou za dva týdny.
Dostanete to, za co zaplatíte.
Příšerný produkt, zkreslovaný
Koupil jsem si to jako tracker, který používám při plavání, a ani jsem nedostal pořádnou šanci to vyzkoušet.
Za prvé, není odolný proti vodě a podle návodu se nedoporučuje používat při plavání.
Za druhé, nepřichází s nabíječkou.
Místo toho navrhuje použít USB konektor nebo počítač.
Dobře, máme jich kolem sebe hodně.
Když se ho pokusím dostat do portu, abych ho nabil, spustí se přímo ven.
Nejsem si jistý, jestli je něco nekompatibilní, nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
A konečně, aplikace stále objevuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílal text, což je velmi znepokojující.
Pak jsem zavřel všechny aktivní aplikace v telefonu a viděl jsem další reklamu, když jsem šel zkontrolovat čas o 20 minut později.
Příšerný produkt, myslím, že dostanu to, za co jsem zaplatil.
Skvělý batoh, ale overkill na popruzích
Tento batoh vypadá dobře a funguje dobře.
Je to skvělé, zvláště když to porovnáte s tím, co batohy stojí nyní dny.
Důvod, proč jsem srazil hvězdu, je proto, že je příliš mnoho popruhů.
Na téhle tašce je víc popruhů, než dokážu spočítat.
Skončím s řezáním a spálením těchto dalších popruhů, protože většina z nich není opravdu nutná a jen se dostane do cesty otevírání a zavírání tašky.
Jinak tohle je moje nová školní taška na vysokou.
V zadní části batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se vejdou do kapes.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli sondáže s hokejovými míčky.
Můj pes je miluje - její oblíbená hračka na přenášení a žvýkání - a plavou.
Tedy do té doby, než je rozseká na kousky.
Vyzkoušel několik, dokonce i verze "horké počasí" - a trvaly o několik minut déle než ostatní.
Dokud se neobjevily tyto.
Ty obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavý o tom, co žvýká.
Říká se, že nezáleží na tom, jak velký je pes v boji, ale jak velký je boj v psovi.
Palec nahoru od Daisy a mě.
Tento výrobek je nebezpečný pro děti.
To je velké zdravotní riziko pro vaše dítě.
Zkontrolovali jsme baterii po několika týdnech používání a viděli jsme, že voda šla do přihrádky, kam jdou baterie.
Samotné baterie shnily a vytékala z nich černá tekutina.
Při pohledu na design se zdá, že neexistuje žádný způsob, jak by kryt baterie mohl být vodotěsný, což znamená, že nejen voda šla do prostoru během koupele, ale i některé z těchto toxických materiálů vyšly.
Prosím, nekupujte tento produkt.
Jsem šokován, že to bylo dovoleno jít na trh i přes takovou zjevnou chybu.
Problémy s přehříváním a potíže s připojením regulátoru
Dávám to 3 hvězdy pro tuto chvíli, nechci nechat špatné hodnocení pro prodejce, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale pravděpodobně se pokusím oba jen vidět, co říkají.
Líbí se mi, že dron je skvělá malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí více jako hračka než tento.
Nicméně je to jediný dron, se kterým jsem kdy měl problémy s přehřátím, a ve skutečnosti to bere zábavu z létání im bude předpokládat, že je to výrobní problém, který musí co nejdříve řešit, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal dron, protože jsem zaplatil za nový.
Dám prodejci rekvizity k dodání, protože dorazí 1 den po nákupu.
Aktualizuji datum mé recenze po kontaktování prodejce a dji tello.
Mám jen dobré věci říct o této dárkové tašce
Mám jen dobré věci říct o tomto dárkovém balení.
Byl jsem schopen zabalit všechny své vánoční dárky s taškami, dárkovým obalem a hedvábným papírem.
Výrobek je velmi kvalitní a různé možnosti velikosti usnadňují výběr dokonalého pro každý dárek!
Vřele ji doporučuji.
Prodejce je naprosto sladký a pozorný.
Oslovil mě po mém nákupu, aby se ujistil, že jsem byl spokojený s mým produktem.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte tuto hru fyzika jsou hrozné a já jsem tak naštvaný na tuto hru, protože pravděpodobně existuje asi 40 hackeři na každé hře a hře.
Don 't ani s tím nic nedělá, víte, že prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra stále dělá aktualizace o svých postavách opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné nekupujte tuto hru fyzika je hrozná a mechanika je hrozná lidé, kteří zjevně lidé, kteří postavili tuto hru, byli vysocí nebo něco, protože je to jedna z nejhorších her, kterou jsem upřímně kdy hrál v mém životě Raději bych hrál Pixel Games v této blbosti je to jedna z nejhorších her nekupujte
Ne jako ostatní Tomb Raider hry
Od samého začátku to nebyl pocit, jako ostatní Tomb Raider hry.
Hratelnost je brutální v tom, že ovládací prvky nejsou chytré, když vědí, jakým směrem se snažíte vzít.
Nechat tě padnout k smrti těmi nejzbytečnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tuhle hru jsem si moc neužil.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomický a cenově dostupný, ale není příliš tolerantní k neustálému používání
Má štíhlejší tvar, který lépe padne do ruky, nemá žádné ostré rohy a s napájecím kabelem jako trvalým připojením je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští v akčních hrách, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Máme velmi těžké ruce a máme tendenci opotřebovávat 2-3 řadiče ročně.
Takže pro nás každoroční investice do regulátorů znamená, že musíme být vybíraví a obezřetní ohledně toho, co kupujeme.
Ovladač by si mohl vystačit s odolnějšími pružinami; po několika měsících přestanou tlačítka, která se používají nejvíce, reagovat a pravý joystick ztratí své centrování, IE- zvětší obrazovky map a postavy chodí dopředu, aniž by se dotkly ovládacích prvků.
Dostanete to, za co zaplatíte
Byl jsem zklamán, když jsem obdržel tuto položku, protože stříbrná část, která jde kolem obličeje, se zdála být vyrobena z nějakého levného plastu.
Není to skutečnost, že byl vyroben z plastu, který mě zklamal stejně jako skutečnost, že použitý plast vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled.
Také jsem nevěřil, že vydrží každodenní nošení, takže jsem ho nakonec vrátil.
Byl jsem zklamán, protože se zdálo, že by to bylo dobré, kdyby tomu tak nebylo.
Nicméně, to můžete přehlédnout, pak by to mohlo být pro vás to pravé.
Byl dobře zabalen a přišel rychle.
Nic jako předchozí telefony Stylo, MASSIVE DISAPPOINMENT.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je zřejmé, že se mi opravdu líbilo Stylos vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem si ho.
Nikdy proto, že jeden měl problémy nebo zlomil, jen proto, že jsem chtěl zůstat aktualizován a "ve smyčce" a já jsem to udělal.
Ze všech těchto telefonů jsem nikdy neměl žádné problémy s telefonem samotným.
Když jsem udělal tento nákup pro Stylo 3 přes Virgin Mobile, prostě jsem věděl, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak předchozí Stylos byly tak nádherné.
Nikdy jsem nebyl schopen úspěšně přenést tento telefon na svůj účet Virgin Mobile.
S tímto telefonem jsem se pohyboval o něco méně než týden.
Hledal jsem informace na internetu a dělal různé hovory, zoufale se snažil dát Stylo 3 výhodu pochybností doufat, že jsem to jen já, kdo dělá něco špatného, ale bohužel jsem tím ztratil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Nenávidím skutečnost, že musím dát Stylo takové hrozné hodnocení a recenzi, ale byl jsem s tímto telefonem extrémně zklamaný.
Doufejme, že LG zvedne svou hru a může zlepšit budoucí Stylos, pokud existují, ale to byl obrovský BUST.
Na druhou stranu, návrat a moje vrácení peněz proběhlo hladce, ale to je asi tak všechno.
