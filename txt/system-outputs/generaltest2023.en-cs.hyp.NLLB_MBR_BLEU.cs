Rozseknutá verze Jedi Knighta havarovala, protože volala funkci z konce vtable.
Ukázalo se, že jsem předpokládal, že volání IDirect3D:: CreateViewport() by vrátilo IDirect3DViewport3, který má další metody přiložené na konec ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože to jen vytváří viewport pomocí objektu Direct3D, ne Direct3D3 objektu.
Pochopil jsem, že v praxi je IDirectXObject2 typicky správná supermnožina IDirectXObject, bez změněných funkčních podpisů, a nové metody se přidávají až na konci.
Ale to není univerzálně platné; v těchto případech je důležité, jaké rozhraní používáte k vytvoření daného objektu.
Tak jako tak, protože to platí tady, abych to napravil, musel jsem rozšířit svou implementaci viewportu, aby obsahovala metody IDirect3DViewport3, takže volání do nové bylo platné.
Předpokládejme, že věda se alespoň zčásti skládá ze seznamů objektivně faktických výroků o světě, které jsou pravdivé bez ohledu na jakoukoli teorii, kterou mohou podporovat.
I když je pravda, že takové fakta ve vědě existují, je stále možné argumentovat, že vědecké fakta jsou teorií nabití.
Vědecká fakta jsou výsledkem experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale volba, které experimenty provést, kontroluje, které fakta jsou odhaleny.
Některá fakta, např. o subatomárních částicích, mohou být výsledkem experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se to podařilo jinak.
To je velmi stručná skica věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi, které tvrdí existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvedneme to o víkendu.
Hledal jsem dobré první auto, a opravdu miluju estetiku 80. let.
Už je to na kolečce a snížená výška jízdy.
Trochu jsem prozkoumal, ale rád bych, kdyby někdo měl nějaké informace o tomhle autě.
Osobní zkušenosti?
Vím, že nejsou tak rychlí
Vypouštím se do času Fediverse.
Domácí partner a já jsme šli do obchodu s alkoholem, na pivo a láhev bublíku.
Když jsme šli na výpis, pokladna je poměrně zřejmá #trans žena.
Já, ve šortkách a s ženským pálkačem a Domácí partner, celý tetovaný a s novým účesem, který sám popsal jako "který mě dělá vypadat jako neonacista".
Její tělo okamžitě ztuhlo a v jejích očích byl ten výraz strachu.
A pak jsme prostě... zaplatili za naše věci.
A poděkoval.
A řekla jsem, že její nehty vypadají skvěle.
Ten úsměv úlevy na jejím obličeji byl skvělý pocit, ale fakt, že se nejprve bála, je kurevsky trapný a já to nesnáším.
Tohle je ta nejhloupější časová os a já nesnáším to dot com.
Nic nezastaví Donalda Trumpa, aby kandidoval na prezidenta, když je pod obviněním, po odsouzení, nebo dokonce z vězeňské cely.
Kdyby byl zvolen, bezpochyby by se sám omluvil, aby se dostal z vězení.
Ale nemůže se z vězení propustit.
Je to jen guvernér státu.
Dva státy jsou New York a Georgia.
Vládce posledního Kemp nepochybně odpustil Trumpovi, pokud bude usvědčen nebo dokonce obviněn Fulton County DA Fannie Willis.
New York je nejlepší naděje na zodpovědnost.
Existují významné důkazy, že komunikace v reálném světě se nemůže omezit na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického modelu signalizace Lewise (1969), zkoumáme podmínky pro vznik komunikace závislé na kontextu v situovaném scénáři.
Zejména dokazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takové objevení dostatečný.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextuální rozlišování významů symbolů.
Ukázali jsme, že environmentální omezení na výběru referentu odběratele mohou být jednostranně využita odesílatelem, bez rozlišovacích možností na konci příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je zapotřebí vědomí odesílatele kontextu.
Navrhujeme, že komunikace závislá na kontextu je situovaný, mnohostranný jev, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály z kontextu nejednoznačné, ale stále umožňují téměř dokonalou komunikační přesnost.
Opravdu jsem si užíval setkání s Penny a Nicholasem z Ashanti Development o víkendu, abychom si povídali o jejich pokroku.
Ashanti Development spolupracuje s rostoucím počtem komunit v oblasti Ashanti v Ghaně po dobu přibližně 20 let, zabývá se s komunitami a poskytuje podporu v oblasti vody a kanalizace, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Společnosti získají znalosti, které mohou začlenit a podpořit svůj vlastní rozvoj.
Měla jsem to štěstí, že jsem v roce 2011 strávila šest památných měsíců s Nicholasem a podpořila řadu projektů.
Když jsme se setkali na víkendu, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
Vznikly tisíce stromů a zemědělcům se zvýšil objem úrody prostřednictvím řady intervencí, od podpory nákupem zařízení až po vzdělávání.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci jako je opadový červ, který může zničit kukuřičné úrody.
Fotografie z mé návštěvy Ghany v roce 2011.
V obchodě UPS u mě mi nedovolí psát na štítku nebo na krabici.
Musí vytisknout ten štítek.
Nedovolí mi říct jim, na kterou adresu a kdo to posílá.
Musím poslat e-mail na nějakou náhodnou adresu s neformátovanými daty, aby zaměstnanec mohl přečíst e-mail a vložit ho do systému, aby vytištěl štítek.
A vždycky mi za tu "pohodlí" účtovali 2,25 dolarů.
Druhý den ráno a nemůžu se dostat přes Chris Lichtovo hanebný předstírání veřejného žurnalismu na CNN včera večer.
Bylo to rozhořčení, jako symbolický antidemokratický svátek lží a urážek 6. ledna, sebedestruktivně pořádaný americkými médii.
Stydlivé publikum.
Licht souhlasil s republikánským publikem!
Kdo prověřoval a vybral jednotlivce?
Je tam příběh, který je třeba oznámit.
Hodnocení... hledá falešnou nezodpovědnost toho všeho.
Nemůže se to opakovat.
Mám velmi vzdušný suterén, což v podstatě znamená, že se tam může schovat spousta hlodavců.
Za poslední měsíc bylo hodně náznaků dalších hlodavců, což je velmi překvapivé, protože je jaro a já bych si myslel, že se budou snažit vyjít ven při změně počasí.
Nicméně, měl jsem hromadu jednoduchých starých snap-pady umístěné kolem, a by slušně doplnit arašídové máslo na ně každých pár dní, jak myši laskavě olizovat čisté.
Včera jsem si to už konečně užil, umyl jsem všechny pasti z arašídového másla a přilepil k nim pistacii.
Fungovalo to.
Ženo, zkusil jsem skoro všechny "humánní" pasti na trhu s velmi malým úspěchem.
Nejsem rád, že je zabíjíme, ale nebudu brát poznámky o etice zabíjení myší.)
Jsem unavená z konzervativních stran a vlád, které se obalují do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jistě, že snižují daně.
Ale také snížili dotace a daňové úlevy, které podporují více podnikatelské aktivity.
Mám podnik, který je úspěšný navzdory provinční vládě, ne díky ní.
Zjistila jsem, že v roce 2023 jsou webové stránky místních televizí absolutně nejhorší zkušenost na internetu.
Popup, automatické přehrávání videa, animace, pop-overy a reklamy, reklamy, reklamy.
Vím, že reklamou vydělávají peníze, ale všechno tohle špíně je kontraproduktivní, když to lidi odháří.
Je to pravda i teď, když je goatse.cx pryč, ačkoliv by to byl těsný závod mezi goatse a, řekněme, khou.com, kde jsem se snažil sledovat video, které mi Wendy poslala.
V prvním dnešním vlaku se kontrolář díval na naše letenky a řekl: "Dlouhá cesta!"
"Jo, a já se dnes vrátím", řekl jsem.
"Já jsem jen vysadit ho v Glasgow", Snažil jsem se vysvětlit, poukazující na mého spolujezdce.
"Je to něco, co se neslyší moc, že ho jen vyřídím v Glasgow", řekl prodavač letenek.
Taky jsem to nikdy předtím neřekl.
Minulá noc mě přesvědčila, že musíme být připraveni bojovat proti Trumpismu.
Trumpismus je kult.
Je to kult, který nikdo nechce, kromě fanatiků, kteří jsou v něm.
A jsou opravdu šílení.
Nemůžeme jim dovolit unést naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Sežeňte si nějaké samolepky proti Trumpovi a oblečte je.
Zakřič na ty, co by se o nás chtěli mluvit.
To není normální.
Tohle není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a já jsem ho slyšela, jak z druhé strany ulice vykašeje kovidovou mucovou bouři.
Tak jsem běžel do svého bytu, abych se mu vyhnul, ale on se mi přesto podařilo dohonit a promluvit si.
Přísahám, že lidé nakažení kovidem jsou zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné vycházet na veřejnost, nebo spěchat k lidem, když kašlete slizí.
Opakuji, není společensky přijatelné šířit vaši kovidovou mukovou bouři všude!!!
Writing Wonders 5/11: Směje se váš MC víc nebo pláče?
Abe skrývá své trápení a snadno se směje, zatímco Tom se nebojí plakat, ale je méně pobaven hrubým humorem.
Jan ti ublíží dřív, než ti ukáže, že jí ublížili a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je neustálým společníkem života.
Po 4000 letech zklamání se Yl ocitla na místě lásky a má obrovské pocity, které neví, co dělat, takže je tam hodně obojího.
CNN musí prostě zavřít.
Včerejší fiasko s #MangoMoron bylo skandální fiasko.
Kdo v té ubohé, umírající síti byl odpovědný za kontrolu takzvaných "nezávislých voličů" v publiku?
Který manažer televizních zpráv zavolal a dal tomu tlustému, lživému kriminálníku tolik vysílacího času?
Vysoký tlak bude převládat až do začátku příštího týdne.
Studená fronta by měla dorazit do poloviny příštího týdne.
Dnes ráno IR satelitní a povrchové pozorování indikovaly šířecí se oblast nízké vrstvy a hromadného
Zmatený student Arnie Cunningham se zamiluje do Christine, rezavého Plymouth Fury z roku 1958, a stane se posedlý obnovou klasického automobilu do bývalého slávy.
Jak se auto mění, mění se i Arnie, jehož nově nalézaná sebedůvěra se promění v aroganci za volantem jeho exotické krásy.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebuješ pomoct?
Kontaktujte naše poradce Salesforce ještě dnes!
Najděte si spolehlivého partnera Salesforce, který využije jeho odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám může partner společnosti Salesforce pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jedna z nejšílenějších částí toho, že se mí sousedé obrátili proti mně, je, že si myslím na to, kolik je potřeba úsilí, abychom byli nepřátelští.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zatáhnout mi dveře do obličeje vyžaduje úsilí.
Naši psi byli nejlepší přátelé.
A pořád nemám tušení, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu víc než 6 let.
Ta loď je zakázaná.
Jsem si vědom vaší nenávisti k Organovi.
Ona je pro mě irelevantní.
Můžeš ji zabít, pokud to půjde.
Ale na palubě té lodi často létá někdo jiný.
Kdyby zemřel... následky by byly... významné.
Často si stěžuju na otcovství.
Zde je (trochu delší než) hmatový kurz o tom, co mám na mysli pod pojmem dad-ification:
Není to můj termín, je to termín používaný k popisu, když je příběh nebo mechanismus hry postaven kolem hlavního protagonisty (obvykle staršího, obvykle muže), který hlídá nebo chrání jinou osobu (často mladší).
The Last of Us je jednoduchý a kanonický příklad otcovství.
Joel používá své schopnosti a schopnost představit (extrémní) násilné činy, aby splnil úkol, který je kódován jako "starostlivý".
Otcování obvykle předpokládá, že řešení situace, kdy rodičová osoba musí pečovat o nebo chránit dítě nebo dítě, je ohromující síla a použití této síly k vynucování velmi specificky tvarované moci.
Otcovství narušuje možnost společných řešení a často zcela ignoruje, nebo podkopává veškerou možnost, kterou dítě má.
Tímto způsobem, otcovství je vázáním na mnoho neoliberálních ideálů; zejména myšlenek, jako je bootstrapping a soběstačnost jako konečný cíl/ ukazatel úspěchu.
Zde je krátký přehled o tom, jak využít naše webové stránky.
- Pošleme oznámení, až budou prodávány letenky.
Poskytneme vám odkazy, kde si můžete rezervovat jízdenku.
- Neprodáváme lístky, nebo účtujeme předplatné.
- Další podrobnosti jsou v plném blogu.
Udržujeme seznam příkladů termínů rezervace pro každou nabídku, kterou zveřejníme a aktualizujeme tento seznam několikrát denně.
Ukrajinské děti mají právo vyrůstat v mírovém a bezpečném prostředí.
Přesto nepředstavitelný strach, hrůza a vystěhování zanechaly na nich neviditelnou jizvu traumatu.
V úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby diskutovala o tom, jak podpořit její úsilí o poskytování pomoci duševního zdraví zranitelným dětem.
Už jsme nabídli duševní zdraví a psychosociální podporu.
Všechny naše úsilí jim pomůže zvládnout tuto cestu.
Spousta zářivé nové dobroty v #dart
V průběhu času se mi dart stal hlavním nástrojem pro rychlé uživatelské rozhraní.
#flutter je potěšením pracovat s, a oni mají #mobx pro snadné řízení obchodu.
Příběh o závislosti je také méně šílený než Nodejs.
Samozřejmě, že Flatter je špatný, pokud jde o chování jako dobrá nativní aplikace (všude, opravdu).
Ale umožňuje se pohybovat rychle, a proto je ideální pro malé hacky.
Echidna s ametystem a purpurovými špičkami.
Jsou průměrné výšky, mají průměrnou postavu a jsou svalnatí.
Mají extrémně tlustý ocas.
Mají malinové vlasy, krátké a kudrnaté.
Mají hruškové oči a nosí šarlatové brýle.
Jejich nejzajímavějším rysem jsou jejich dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Skákat opravdu vysoko, roztrhat obyčejné lidi na kousky, používat děsivé magické schopnosti a obnovit zdraví tím, že se budete slavit na svých nepřátelích - to by mělo být základem všech počítačových her, abych byla upřímná.
I přes úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové, aby je zahanbili - všichni...
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
V reálném životě máma ráda hádanku, kterou jsem před lety vytvořila, a většinu tajemství našla sama, takže nebyla jen máma, když říkala, že se jí to líbí.
Takže možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Musím to přeložit do mandarínštiny a/nebo Hokkien, které vůbec neznám.
Asi budu muset zjistit, jestli je Bing nebo Google lepší v překládání špinavých gay sex slovních hřeby.
Už nějakou dobu si s touto myšlenkou hraju.
Mentalní zdraví je často považováno za něco odděleného od "běžného" zdraví.
Proč? Proč?
Protože se to děje v mysli a je méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku stejně důležitá otázka zdraví jako zdraví vašich nohou.
Intersex je dokonce uznáváno TERF a podobně, protože je obecně fyzičtější a je jako takový viditelný.
Stejně jako mentální zdraví je pro mnohé méně "skutečné" než fyzické zdraví, mám pocit, že být trans je pouze intersexuální povaha mysli.
Čím více čtu o studiích o sexu, pohlaví, psychologii, tím více se mi prohlášení: "Mé pohlaví je mužské, moje pohlaví je ženské" zdá být zjednodušené a nepřesné.
Skoro to vypadá, jako by se část argumentu odevzdala TERF.
Myslím, že být trans znamená být "biologicky nebinární".
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení "nebinární" musí být rozšířeno z pojmu pohlaví, aby bylo používáno při odkazu na sex.
Poslouchal jsem díla @iotara.
V záhadném kolektivu je spousta dobrých věcí.
Krautské nálady a další světová popová hudba a radiofonické dílny a všecko další.
Hodně stojí za to.
Také FWIW se mi líbí rozhraní archiv.org mnohem víc než desktop #bandcamp \- Nemám ponětí, jak lidé používají bc jako primární hudební platformu (kromě politických důvodů).
Trochu si hraju s Flutterem.
Nerad bych založil svůj byznys na technologii od Googlu, abych byl upřímný, na druhou stranu je Google jedním z mála velkých hráčů se skutečnou motivací vytvořit přesvědčivou platformu pro různé platformy a to se ukazuje.
(A také: Web je dnes bohužel převážně věc Googlu)
A také mi prosím neříkejte, že aplikace Google / Flutter jsou na iOS a macOS špatné.
Křižovatka je těžké, pokud to chcete dělat dobře.
- To vím.
Děkujeme lidem, kteří si stáhli poslední aktualizaci pro Leasey.
Objevila se několik velmi malých obtíží.
Nic, co by vyvolalo alarm, ale přesto se na ně obrací.
Příští týden bude vydána malá aktualizace, která je opraví.
Většinu včerejška jsem strávil instalací nové aktualizace pro některé zákazníky a všichni, kdo potřebují pomoc, by ji teď už měli mít.
Přeji pěkný den!
Tech konfese: Nemůžu zprovoznit hlavu kolem Grafana & Prometheus, alespoň z hlediska parametrů serveru/aplikace a monitorování.
Nevím přesně, proč to můj mozek nedokáže pochopit; mohlo by to být proto, že ty nástroje jsou tak široké a vágní, že můj mozek se prostě uzamkne kvůli "příliš mnoha možnostem".
Chci dělat palubní desky.
Grafana vypadá hezky.
Mozek nepracuje.
Takže, s blížícím se novým levelem náletu #FFXIV, jsem si říkal "člověče, rád bych zkusil pořádný nálet, ale Party Finder zní jako bordel a nikdy nenajdu static, který by mě dostal".
Tak jsem si řekl, k čertu s tím!
Udělám si vlastní ruch!
Plné lidí, kteří se bojí se připojit k nájezdu, bez očekávání, že budou dobří!
To asi nebude fungovat.
... a tak jsem se ocitl v situaci, kdy jsem musel udělat seznam útokových skupin.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a já ztratil veškerou svoji vášeň pro fikci a skvělé vyprávění příběhů.
Ale po ~desítkách~ let čtení skoro nic (s výjimkou non-fiction a občasné knihy o sebevzdělávání) jsem si dala za cíl přečíst 23 knih v roce 2023.
Jsem na knize číslo 31 a je teprve květen.
Jsem zpátky, zlato!
Nic jsem nedokázal.
Jsem rád, že několik lidí za mnou přišlo v soukromí a řeklo "sleduj, kvůli tvé práci ti dám tuhle částku peněz".
Chci vidět ty firmy, které zprostředkovávají transakce, jak vysvětlují svým zákazníkům, jak nastavují procenta.
Nebudou o tom mluvit v Bloomberg!
Ale když Spotify bude mít dobrou čtvrtinu, tak to udělají.
Je nebezpečné nechat migranty na jižní hranici?
Ať obnoví prázdná a rozpadající se města po celé zemi.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pravicoví prokořisťáři.. to je nebezpečí.
Deportovat rasisty.
Jsem unavená z titulků, které tvrdí, že "prace na dálku je mrtvá". nebo že "práce na dálku byl neúspěšný experiment".
Tyto titulky a články obvykle zmiňují jednoho generálního ředitele jedné velké společnosti.
Je to všechno jen klikovací návnada, ale znepokojuje mě vedení a manažery, kteří si tyto články přečítají.
Před rokem 2020 existovala práce na dálku.
V dohledné budoucnosti budou stále existovat práce, které mohou být vykonávány na dálku.
Práce na dálku je příznivá.
Umožňuje lidem pracovat v pohodlných prostorech a ne v dusných, hlučných kancelářích.
Umožňuje přístup pro každého, kdo má připojení k internetu a dobré pracovní prostory.
Umožňuje lidem vyhnout se dlouhým dojížděním, které jim berou čas jejich denního života a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a snažte se pochopit, jak vaši zaměstnanci ve skutečnosti dělají práci.
#WFH #business #neurodiverzita
Není to jen konzervativci proti progresivcům, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Tohle je válka mezi pro-lidmi a anti-lidmi", řekl.
Parkerová mluvila o potratech a impulsu moderních městských žen posunout porod kvůli kariéře.
Také tvrdí, že NDP a progresivisté chtějí odlidnit společnost kvůli životnímu prostředí.
"Jste uhlík, který se snaží snížit".
Takže jako na začátku všech mých narozenin v minulosti, vždycky jsem měla tvrdé.
Kdykoliv se objevila May, bála jsem se oslavovat svůj narozeniny.
Vždycky se něco stalo, něco šlo špatně, nebo to skončilo stresem a depresí.
Celé ty roky jsem bojovala, abych se z toho vzhledu dostala a měla lepší dny.
Trvalo to roky měnit svůj život a tvrdě pracovat, ale nakonec...
Začínám se usmívat a užívat si svůj den bez starostí.
A dnes už je velký den!
Zima je za 30 dní v této malé části Velkého jižního světa.
Ale já se nenechám oklamat!
Tohle je začátek.
Prší a dokud není zamrzlý, nebudete v něm tančit!
Je hezký den na objednávku zmrzliny.
Byla to noc pro psa, a ten pes nevstal z postele ani na "Psí snídani"!
Zapnu si podšívku do své cyklistické bundu - pro případ, že bych ji potřeboval uvnitř.
Znáte nějaký efektivní způsob, jak webová komponent reagovat na přidání/odstranění z dokumentu?
To je pro komponentovou knihovnu Wikipedie (OOUI).
Je to většinou sémantický HTML s CSS, a obecně nevyžaduje vlastní prvky (které nabízejí connectedCallback).
V současné době používáme MutationObserver hack.
Pro výkon, nesledujeme celý dokument.
Vytvoříme oddělený dočasný rodič, instalujeme tam MO a pozorujeme, jak se odděluje (a tím přilétá jinde).
Casper je v dnešní době absolutní jednotka.
Myslím, že moje nová práce pro něj byla dobrá - dva volné putování denně, zatímco já pracuji, v dost předvídatelných časech.
Konečně mám dobrou fotku, takže si můžu být jistá, že není tlustý.
(U #krys může být příliš vysoký obsah tuku škodlivý pro jejich zdraví.)
Není.
Je úplně na dně z toho, jak se mi dvakrát denně vracel do kanceláře.
Nemám váhu, ale cítí se, jako by vážil přes půl kila.
Jsem ráda, že se mu daří.
Dnešní zpráva o průběhu Aerostrike:
1) Malé úpravy na mapě Hel's Fighters.
Navíc, mapa je plně funkční!
2) Byl připojen systém měnových odměn.
Zítra se bude zkoušet v různých bitvách.
Deštivé dny!
Minulý týden jsem toho udělal spoustu a cítím se o dost lepší ohledně věcí z terénu.
Všechny zelí, kapusta, chard jsou transplantovány.
Chystám se nastolit salát na Penn v šesti řadě a uvidíme, jak to bude vypadat v porovnání s rozhlasem.
Jarní hrášek v Gilpinu se objevuje, takže je třeba umístit krytinu.
Musíme tam také vysát řadu šalátů, aby se do nich začlenily zeleniny. Oba mají vycvičený personál pro zavlažování, přípravu lůžka a transplantaci, což je 90% neziskových dovedností.
Je rok 2023 a stále vidím lidi s iPhony, kteří se aktivně vyhýbají používání Apple Map.
Apple Maps jsou ve výchozím nastavení v iOS, a přesto se lidé snaží stáhnout a nainstalovat Google Maps na své iPhony.
Nevím proč.
Z zvědavosti jsem si nechal otevřenou mysl a porovnal to, jak se porovnávají Mapy Google a Mapy Apple na mém testovacím zařízení iPhone (můj denní ovladač je zařízení Android, takže používám iPhone velmi zřídka).
Dožívání při sledování směrů bylo na Mapách Apple mnohem lepší než na Mapách Google.
Apple Maps vyhrává.
Proč tedy lidé přebíhají přes další obruče, aby si nainstalovali Google Maps?
Nemám ponětí.
Je možné, že Google Maps se dostala na trh první?
Byla to katastrofa s Apple Maps v roce 2012?
Je možné, že je Google Search integrován s Google Mapy?
Nemám ponětí.
To znamená, že jsem zaujatý.
Jsem za to, abychom nezneškodňovali koncovým uživatelům, a Apple královsky posral své Apple Mapy, když byly vypuštěny v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z ní dělá dobrý sklad bohatství tak dlouho, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům ztrácí na hodnotě, protože ztrácí svůj stav a potřebuje být nahrazen jiným.
Spousta lidí si myslí, že vlastní Zemi, když si ji koupí.
To není případ.
V Číně si můžete pronajmout jen půdu.
Nejsou tak hloupí, aby prodávali na věky.
Vláda může změnit tuto politiku kdykoli bude chtít.
Ta země je dočasná.
Zdá se nepředstavitelné, že jednoho dne vám půda bude odebrána, když se díváte na australské a americké mediální kanály, ale to proto, že bohatí jsou na nich celý den a zajišťují, že vaše mysl myslí určitým způsobem.
Tato zem může být jednou velmi snadno a rychle odebrána vládou, pokud to bude chtít.
A hádej co?
Nikdy jsem nepochopil, jak si mohou lidé udržet půdu na úkor druhých.
Jednoho dne ti ji musí vzít.
Proto Číňané povolují jen pronájem.
Už jim došla půda.
Na úspěch, uskutečnění snů, přátelství, na to jednoduché, ale pravdivé!!
Pro všechny investory, připíjím na váš úspěch a uskutečnění vašich snů.
Pokračujme v naší spolupráci na vytváření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, pojďme si vážit jednoduchých, ale opravdových věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm #geolog #podnikatelství #udržitelnost #úspěch # přátelství #toast #sny
Často přemýšlím nad lidskou schopností být *tak* sklopený do sebe, když je zaplavený tolik důkazů o tom, jak skutečná krutost vypadá.
Trápit se osobním selháním a vinou ve světě, kde "úspěch" je tak často udělován lidem zodpovědným za ty nejodpornější činy...
Všichni jsme tak neslušní tvorové.
Ale mírné zoufalství nad naším nepořádkem je zásadní - protože nám dává více prostoru, abychom se mohli vypořádat s ruinami všude kolem.
Tak se snaž nezapomenout, jo?
Milost k sobě samým je také aktivismus.
Někteří programátoři: "Rychlost psaní na počítači nezáleží!"
nebo "Modální redaktoři jsou dnes k ničemu".
Já extrahuji funkčnost svých projektů #Axum do sdílených knihoven: "Hold my keyboard"
Nejsem si jistý, zda je to nejlepší přístup pro sdílení, ale zatím se mi to líbí: <URL>
Poznámka: Můžete si vzít inspiraci, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Tento týden v Revelations je "Neustále vzhůru celou noc".
Hrál jsem si s tímhle kouskem na hlavě už několik dní.
Rozhodně je to více romantika než špína.
Možná jsem četla mnoho románků s nemožnými 'náleznými úlomky' a tohle je výsledek, ale líbí se mi to.
A taky jednou budu mít milový orgasmus, možná ne s str.
Nesouhlasím s tím, že #Mastodon je těžké nastavit.
Společná, není to tak těžké.
Ale je těžší najít lidi, kteří budou následovat a budovat vaši časovou osu.
Přál bych si, aby tu bylo nějaké doporučení, komu mám následovat.
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany, jako je Elk a / nebo Ivory.
Pokud se budete držet předchozího webového rozhraní, nevypadá to dobře (imho).
Takže to vyžaduje trochu více úsilí, aby se do toho dostal a pravděpodobně potřebujete dobrou aplikaci k zlepšení # UX.
Nevím, jestli je prevence možná, ale stojí to za pokus.
Čtyři kroky, které jsem načrtl, jsou předmětem diskuze, přičemž v každém z nich došlo k určitým pokrokům:
Popis: názvy pro případy chování člověka-algoritmu, které se týkají algoritmů a lidí.
Vysvětlení: zohledňují se obě strany vzájemného vlivu.
Předvídání: předvídání škod před tím, než k nim dojde (i v minutách).
Intervence: znalosti o věcech, které můžeme udělat pro změnu, v rámci určitých hranic sebevědomí.
Neviděl jsem radnici CNN, ale zdá se, že Trump řekl přesně to samé, co říká pokaždé, když otevře pusu nebo stiskne tlačítko Send ve svém telefonu.
I kdyby je nemluvil na radnici, každý v Americe je stejně uslyší, opakovaně, od teď do listopadu 2024.
To ještě není důvod dát mu jiné místo, ale škody jsou přehnané.
Vyhraje primárky.
Nemůžeme ho odvézt.
Je tady a řekne to, bez ohledu na to, co se stane.
Zapsala se na čekací seznam Google's "AI Test Kitchen" a dostala se tam ve stejný den.
V tuto chvíli to není moc příjemné.
"MusicLM Demo" je mírně zajímavé.
Můžete si vyžádat konkrétní hudební skladbu jako "jazz s trubkovým sólem v 5/4 tempu" a po několika vteřinách pro vás vytvoří dvě skladby.
Zdá se, že rozumí tempu, ale... hudba prostě... není dobrá.
Vymítnout všechno, co máš, v reakci na GPT, není to.
Zkus víc Google.
Je to divné dělat vzpírání, ale zároveň ani netušit, co je to tvoje jednorázová maximální, protože to je jeden z klíčových způsobů, jak si lidé sledují svůj pokrok.
Cvičím sama v ložnici bez pozorovatele, ani bez váhy.
Jen já a tyč s hromadou závaží.
Pracuju na lavičce na posteli.
Jestli se pokusím zjistit, že je můj maximální limit jednoho hráče, možná nebudu mít dost váh pro maximální výkon, nebo naopak, může mě to vážně zranit/zabijet.
Každopádně, dnes se nám zvedlo.
Pořád je to dobrý.
Přísahám, že burrata před pěti lety neexistovala.
Tohle je můj osobní Mandela efekt.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem ho neviděl v luxusním potravinářství, ani v žádném italském delikatesním.
Nikdy jsem neviděla, že by to něčí máma uvařila, nebo že by mi to někdo strčil na párty, nebo to spíš viděl v kombinaci s něčími eskapádami u koláče nebo při pečení.
Jednou se objevil a najednou byl k dispozici všude.
Vstoupil jsem do dimenze burraty.
Drakeův iPad se rozpadá, takže hledá nový tablet.
Jelikož jsme se zde radikalizovali, zdráháme se koupit nový FAANG stroj.
Má někdo z vás oblíbený Linuxový tablet?
To by bylo hlavně pro prohlížení webu, příležitostný e-mail a některé hry.
V letech 1998-2006 Gamefan, v souvislosti s dlouhým vývojem první hry Unreal, Jason Schrieber komentoval,
"Dobrá hra je pozdě, dokud se neodesílá.
Špatná hra je špatná navždy".
Takže to byl Epic, kdo to vyvolal?
Můžeme pokračovat.
V minulém vydání GamePro 1997-11 je citát s mnohem více nejednoznačnosti:
"Nebo, jak říká známé přísloví: Pozdní hra je pozdní jen do té doby, než se dostane na trh.
Špatná hra je špatná po zbytek života".
Je to tak krátkodobé?
Pouhá "vtipná fráze" bez jasného původce?
Smoky, můj 10měsíční samec Domestic Blue, si hraje s červeným gumovým Apple Pencilem, který koupil na Amazonu a před měsícem utekl.
Nese to v ústech po celém domě, a já se prostě musím smát uvnitř.
Pokaždé, když ho vidím, jak to dělá.
Dělali jsme celou cestu na novém ICNG vlaku.
Opravdu se mi líbí.
Hlavně vozy s většími okny.
Jsou zde oblasti, které by potřebovaly trochu vyleštit.
Právě nedostatek dostatečných kontejnerů a nedostatek značek, které by vysvětlovaly význam barev osvětlení.
Zreš ty drobné problémy a pak můžeme mít ještě více, prosím?
Nebudu smutný, až uvidím konec akcií ICM nebo DDZ.
Jedno pravidlo na každého zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo ve frontě mohl dostat na desku.
Můžete si koupit JEDNO z výše uvedených desek, ne jednu z každé.
Na Pico nebo jiné zboží nejsou žádné omezení.
Včera jsem se bavil se svým přítelem a bývalým kolegou rabínem.
Navštívili jsme pár hodin na mém verandě.
Takové přátelství překonává rozdíly.
Všichni máme příběhy, které máme vyprávět.
Bůh ti žehnej a ochraňuj!
A bažina se zelení.
Docela se mi líbí software a jméno domény, které jsem dostal pro můj případ.
Ale mám pocit, že jsem začala špatnou nohou, abych tak řekla.
A nikdy jsem se tam necítil dobře.
Budu se tu ještě chvíli zdržovat a přemýšlet, jestli bych neměla vůbec emigrovat.
#FalconGameBooks
Zdá se, že osmoký repnidi pozorují, jak pokládáš leták na červenou půdu, ale nepohybují se k tobě. Ve skutečnosti se nepohybují, když vylezete z letáku a pomalu jdete k nim.
Země pod vašimi nohama se začne třást a pak se třást, jako při zemětřesení a vy ztratíte stopu, i když Repnids se nezdá ovlivněn.
Skála pod tebou se náhle rozkládá.
Repnidy si vybudovaly tunel pod povrchem a ty spadneš do vřející masy stovek těl Repnidů v jeskyni pod námi.
Konec je rychlý, protože několik párů tesáků vstřikuje svůj smrtící jed a vzduch Diskra znečišťuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl první člověk, který cestoval do budoucnosti.
Vletíte nahoru na stranu hromady špiny a vylezeš ven.
Zdá se, že osmimití Repnidi tě sledují, ale nepohybují se směrem k tobě, vlastně se nehýbou, když k nim pomalu jdeš.
Zastavíš se zatímco jsi na hrobce zhroucených skály a půdy a promluvíš k nim a řekneš: 'Přišel jsem v míru, jako přítel.'
Zdá se, že vás nemohou slyšet, natož chápat, protože váš Univerzální Překladatel nedostává žádnou odpověď.
Rozhodli jste se použít své psychické vědomí, abyste je kontaktovali.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a vaše mysl se od toho kontaktu odvrací.
Rozhodnete se, že navázání kontaktů by bylo nebezpečné a vrátíte se ke svému letadlu, ale tato zkušenost vám očistila mysl, která byla zmatená od té doby, co jste skočil do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je poměrně snadné nastavit kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že při skoku jste spotřebovali další polybdenovou tyč.
[ pokračoval ]
Dnes mám kávu, slunce a klid!
Začala jsem nový šál.
Nejsem si tím teď jistý.
Našla jsem nerovnoměrně stříbrně šedou nit, která je většinou jemně spředená s hrudkami.
Mám v plánu to smíchat s jemnou fialovou bavlnou.
Ale nejsem si jistá, jestli mám dost fialové.
Použiji hák typu H s podobným vzorem dvojitého háčkování, jako jsem to dělal předtím.
První spojení jsem udělal včera večer, takže uvidíme.
Přejeme všem šťastný čtvrtek!
Nicméně nesnáším kurzy umění a literatury, a moje školní historie to potvrzuje.
Doslova jsem to zkoušela a všechny jsem ztratila.
A až do před dvěma lety jsem to netušila, dokud jsem si nezkontrolovala výsledky ze studia.
Nenávist na třídě literatury je ještě horší: miluju čtení.
Před osmnácti jsem četl většinu klasiků - i když to je spíš odraz života v posraným nikam. Z zoufalství jsem také četl Encyclopedia Brittanica z roku 1979.
Můj domov je pohodlný a krásný a jsem tam šťastná, ale musím být někde jinde, abych se mohla odpočinout, číst si během dne bez pocitu viny.
Je to jako bych byl na dovolené a proto dělám to, co se dělá na dovolené.
A to i přesto, že jsem v posledních dvou noci nespala tak dobře jako doma, a mám malý pocit #MECFS z toho, že jsem prostě v podivném prostředí, kde jsem méně schopná si dát čas a musím si pamatovat, kde jsou věci.
A to i přesto, že mám stále svůj seznam úkolů a pořádám svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervózní, stresující a všechny ty dobré věci, které miluji na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi to, ale bude to schopno přilákat publikum těch správných hráčů?
Rozkvétá se komunita kolem uživatelského obsahu hry?
(Opravdu doufám, že ano.)
Příběh hry, myšlenky a otázky, které vyvolává, jsou aktuální.
Doufám, že to půjde dobře.
Dnes je den ThinkPadu!
Přišel jsem domů na oběd, abych viděl tohle venku.
Kéž bych to mohla vzít zpátky do práce, abych si dala další.
Ale to bude muset počkat do večera.
Tak jsem se konečně podívala na #Heartstopper
Bylo to až moc rozkošné na to, aby to bylo pikantní?
Rozhodně.
Mluví některá z těchto postav jako lidé?
Ani zdaleka.
Ale miloval jsem to?
Rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávný umělec vzal dnes večer špatnou kritiku.
Částečně proto, že byli špatně vychováni.
Ale je důležité nevymlouvat se za problémy a prostě je napravit. Obzvlášť ve výrobě, když váš vedoucí potřebuje změnu.
Zvlášť s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tam, aby problém rychle napravily, a není zaměřena na vaše schopnosti.
Předpokládá to, že máte schopnost vyřešit problém, nebo najít řešení.
Takže zatímco kompostování a blum scrolling jsou skvělou připomínkou, abychom se podívali nahoru a byli si vědomi života za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak se semena rozkvétají a kultivují (a ne náhodně rozesílána) dobrými lidmi.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu ten dopis podal, když se potkali na stezce, těsně před sledováním psa.
Ona byla na cestě ke zdi, on se vracel z služby.
Podíval se za sebe, aby ji sledovat jít, a ujistit se, že nebyli viděni.
Neohlédla se zpět.
Počkal, až se ocitne ve tmě pokoje a pak ten vzkaz vytáhl a přečetl ho v paprsku světla, které se vtrhlo skrz záclony.
Jedno slovo v blokách.
Strávil dlouhou dobu zíráním na něj, snažil se zůstat v klidu:
V poslední době jsem potkala pár úžasných nových #Mastodon partnerů a chci tento trend udržet.
Když volám do #Fediverse, cítím se jako velryba, která zpívá v obrovském oceánu!
Chceš se přidat k mému "pod"?
Rád bych se spojil s více lidmi.
Každý, kdo má vlasy v plamenech kvůli CNN, může poděkovat Stephenovi Colbertovi za tu tvrdou změnu napravo.
Pomohl Chrisu Lichtovi stát se národním problémem.
I když se nám mohou líbit někteří lidi, pokud jen poskytují menší kariéru fašistům, měli by je pravděpodobně nosit.
Bylo to poprvé (ale nebude to poslední), kdy Kaveesha Dilhariová zaznamenala více než 20 runů a získala 2 a více prohry v jednom T20I.
Připojuje se k vybrané skupině srilanských žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilných protestech před hotelem pro uprchlíky
Tento incident přišel po nárůstu počtu uprchlíků a žadatelů o azyl, kteří projíždějí loděmi přes kanál La Manche do Británie.
Policie zatkla 15 lidí po demonstraci proti uprchlíkům před hotelem, který byl používán k ubytování žadatelů o azyl, který se stal násilným nedaleko anglického města Liverpool.
Policie Merseyside oznámila, že jeden policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek v noci v Knowsley.
Policie uvedla, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zatčeni lidé, ve věku od 13 do 54 let, byli zadrženi "v důsledku násilného nepořádku".
Policejní komisař Merseyside Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty byla několik zraněných".
Podle místních médií používá ministerstvo vnitra tento hotel pro dočasné ubytování žadatelů o azyl od loňského roku.
George Howarth, který reprezentuje Knowsley v britském parlamentu, řekl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou fanatici a vítávají lidi, kteří utíkají z nejnebezpečnějších míst na světě, aby našli místo bezpečí", řekl.
"Ti, kteří dnes demonstrují proti uprchlíkům, tuto komunitu nezastupují".
Protest se odehrál uprostřed zvýšeného napětí, když rostoucí počet uprchlíků a migrantů překračuje kanál v malých člunech.
V roce 2022 se do Spojeného království touto cestou dostalo více než 45 000 lidí a většina z nich požádala o azyl.
Systém pro posuzování žádostí o azyl se zpomalil kvůli politickým nepokojům a byrokratickým zpožděním, čímž mnoho žadatelů o azyl zůstalo v hotelech nebo jiných dočasných ubytovnách.
Průjezd přes kanál La Manche se stal politickou otázkou a konzervativní vláda slíbila, že "zastaví lodě" a plánuje poslat žadatele o azyl do Rwandy.
Oponenti obviňují vládu, že démonizuje zoufalé lidi, kteří prchají před válkou a chudobou.
Prezidentův pohár: Candystripes porazili Rovers v zahájení sezony na Brandywellu
Středník Derry Adam Reilly uzavírá Lee Grace v Brandywell
Derry City zvítězilo v pohárě prezidenta, když porazili Shamrock Rovers 2: 0.
Držitelé FAI Cupu porazili vítěze minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho.
Hoopové se snažili v druhé polovině, ale Ruaidhri Higgins si udržel svůj cíl a vyhrál.
Derry jede do St. Patrick's Athletic na první zápas ligy příští pátek.
Odpal patchinga do strany dostal Derryho dopředu po 23 minutách - centrální obránce zahájil branku, když Foylesiderové vyhráli 2:1 nad eventuálními šampiony loni v únoru.
Hoopové pak vyhráli Premier Division o 13 bodů, ale Duffy brzy měl City před sebou s velkým úkolem, který se podařilo skrýt pod brankářem Leonem Pohlsem a do siete.
Finálová skupina byla na odpočinku o dva góly za sebou.
Graham Burke se nejvíce přiblížil ke snížení dluhů ve druhé části, ale Candystripes byli pohodlní vítězové týden před jejich snahou o národní slávu.
Šéf města Ruaidhri Higgins chválil svůj tým po tom, co řekl, že to byl "nejtěžší týden mého života" po smrti jeho bratra Kevina.
"Je to kopanec do zubů a máme před sebou těžké týdny, ale v jeho paměti si na to vzpomeneme", řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě tak s dobrým výkonem je opravdu potěšující".
DHS najal právnickou firmu, aby se postarala o případný proces odvolání Alexandera Mayorky.
Ministerstvo vnitřní bezpečnosti si najalo externí advokátní kancelář Debevoise & Plimpton, aby pomohla v možném procesu obžaloby ministra Alejandro Mayorkase, protože by mohl čelit obviněním republikánů ohledně jeho zacházení na jižní hranici.
"Ministerstvo vnitřní bezpečnosti si pořídilo externí poradce, aby zajistilo, že životně důležitá mise ministerstva nebude narušena bezprecedentními, neoprávněnými a stranickými pokusy některých členů kongresu o obžalobu, kteří již podnikli kroky k zahájení řízení", uvedl mluvčí DHS v pátek.
DHS bude i nadále dávat přednost své práci na ochraně naší země před terorismem, reagovat na přírodní pohromy a zabezpečit naše hranice, přičemž odpovídá na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS.
Úředník DHS řekl CBS News, že oddělení najalo firmu na smluvní práci po celý život kongresového výzkumu.
Debevoise byl vybrán kvůli jeho odbornosti na obvinění a oběstrannými zkušenostmi v práci s Kongresem na dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas mluví během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoisem je považována za vhodný výdaj pro DHS.
DHS se snaží zajistit, aby jeho mise nebyla podkopána partyzánskými útoky a aby se o řízení proti Mayorkám zabývaly lidé s odpovídajícími odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na dotaz ohledně vyšetřování impeachmentu v minulý čtvrtek řekl novinářům: "Budeme spolupracovat s tímto kongresem, tak jako jsme spolupracovali s minulým kongresem. Myslím, že je to naše odpovědnost".
Přiznal, že "bude trvat čas", aby se vyslechl vyšetřování Sněmovny.
"Budu trávit ten čas stejně jako ostatní a také nebudeme kompromitovat čas, který věnujeme plnění našeho poslání".
Vysoký představitel DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím právníkem.
Pouze jeden člen vlády byl kdy obviněn, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulysse S. Granta, obviněn z přijímání úplatků, ale byl nakonec osvobozen Senátem.
Aktuální zprávy
Díky, že čtete CBS NEWS.
Čtyři teenageři obviněni z útoku na 14letého kluka, který zemřel na sebevraždu po bití. Video bylo zveřejněno na internetu.
Otec říká, že dcera si vzala život po tom, co ji šikanovali ve škole v New Jersey.
Táta říká, že dcera si vzala život po tom, co byla šikanována ve škole v New Jersey 02:33
Čtyři mladíci z New Jersey byli obviněni v souvislosti s útokem na 14letou dívku, která si později vzala život poté, co bylo na sociálních sítích zveřejněno video.
Jeden mladistvý je obviněn z napadení, dva mladiství jsou obviněni ze spiknutí k spáchání napadení a jeden mladistvý je obviněn z obtěžování, řekl prokurátor okresu Ocean Bradley D. Billhimer CBS News v e-mailu.
Adriana Kuch, 14, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video útoku na střední střední školu.
Na videu bylo vidět, že dívky házejí do mladistvého drink, pak ji kopou a táhnou po školních chodbách.
Adrianu strčili do červených skříněk ve školních chodbách a jedna z dívek v růžové košili opakovaně praštila Kuchovi.
Další dívka, která byla mimo video rám, se smála, když natáčela scénu.
Přijeli dva dospělí, aby útok přerušili, a jeden z nich rozdělil mladistvý od sebe.
Adriana ležela zraněná na podlaze v chodbě, když se jí ten dospělý snažil pomoci vstát.
Jedna z holek řekla: "To je to, co dostaneš".
"Milovala život. Byla to nejšťastnější dítě. Všichni jí milovali", řekl její otec, Michael Kuch, CBS New York ve čtvrtek, dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová spáchala sebevraždu poté, co bylo na internetu zveřejněno znepokojující video, ve kterém byla napadena ve škole.
Kuch řekl, že by měli okamžitě zavolat policii, protože studenti, se kterými podle něj měla jeho dcera problémy, jí rozbili obličej 20-uncovou láhev.
"Kdyby zavolali policii a provedli vyšetřování, tyto dívky by nezveřejnily videa ze školy", řekl Kuch.
Také řekl, že jeho dcera, která měla na těle modřiny, měla být odvezena do nemocnice.
"Vždycky řešíme každé téma šikanování, a v den incidentu byli čtyři studenti suspendováni", řekl Dr. Triantafillos Parlapanides, dozorce škol, stanici CBS New York.
Školní úředníci CBS New York řekli, že informovali rodinu a označili smrt Adriany za hroznou.
Každý teenager a jeho opatrovník dostal kopii jejich stížnosti a byli propuštěni až do budoucího soudu, řekl prokurátor CBS News.
Studenti na škole uspořádali středu stávku na podporu Adrianiny rodiny.
Pokud vy nebo někdo, koho znáte, trpí emocionální útrapou nebo má sebevražedné myšlenky, můžete kontaktovat záchrannou linku pro sebevraždy a krizové případy 988 telefonem nebo smsem na číslo 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Další informace o dostupných zdrojích péče o duševní zdraví a podpoře lze získat na lince pro pomoc organizace The National Alliance on Mental Illness (NAMI) od pondělí do pátku od 10 do 22 hodin.
ET, na 1-800-950-NAMI (6264) nebo e-mailem na info@nami.org.
Mluvil jsem s 30 zdravotníky a wellness profesionály o tom, jak se vyhnout vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zvláště v práci.
To může být extrémně obtížné pro lidi ve zdravotnictví, a proto jsem se zeptala 30 odborníků v oblasti zdraví na totéž: "Jak zvládáte svou energii a nevyčerpáte se ve své profesi?"
Jejich kariéry se pohybují od lékařů infekčních onemocnění přes psychology a učitele pozornosti - a všichni měli skvělé rady, jak zůstat motivovaní a jak udržovat pohyb v pohybu.
Navzdory velkým rozdílům v jejich rolích, existovalo několik témat v jejich reakcích, které vynikly jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři hlavní přístupy, které používají.
1.Vybudovat silnou komunitu
Jako osoba, která pracuje s pacienty, kteří trpí smrtelnou nemocí, Eufrosina Young děkuje svému silnému systému podpory za svou schopnost udržet energii.
Young je certifikovaným neurologem a specialistem na ALS na neurologickém oddělení Univerzitní nemocnice v Upstate a říká, že tam "mobilizují jako armáda lidí".
Pro amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo se snaží vyvinout léčbu a zajistit lepší možnosti pro své pacienty, Youngovou posiluje i v jejích nejtěžších dnech.
"Neobjímáme váhu světa, ale jsme součástí světa lidí, kteří se za tuto práci angažují", říká.
2.Odpočívejte, když potřebujete
Pracovat na dvou místech jako výzkumník spánku a inženýr algoritmů, zatímco pečoval o své novorozené dítě, by určitě vedlo Raphaela Vallata k vyhoření, kdyby si odpočinul, říká.
"Mám pocit, že když se chystám vyčerpat, každý úkol mi připadá jako hora, na kterou musím šplhat, a cítím, že je to hodně naléhavé a důležité", říká Vallat.
V takových chvílích "se opravdu potřebuješ trochu odpočinout a uvědomit si, že to může počkat".
Obvykle si Vallat najde v den okamžiky, kdy si může dát pauzu a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3.Buďte vášniví v tom, co děláte, a nezapomeňte na svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně sedm dní v týdnu.
Být v první linii během pandemie jí zabíralo téměř všechen její čas, ale vyhýbala se vyhoření tím, že si připomínala, proč je její práce důležitá.
"Myslím si, že práce se necítí jako práce, když máte pocit, že máte vliv", říká Gounder.
"Když pracujete šílené hodiny a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu potřebujete udělat krok zpět a ptát se, co vlastně děláte".
4. Mít jiné radosti
Všichni zkušení odborníci uvádějí, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je velice důležité mít život, který si užijete, a který přesahuje to, co jste dosáhli ve své práci, říká Christina Maslachová, sociální psycholožka, profesorka psychologie v důchodu na UC Berkeley a autorka knihy "The Burnout Challenge: Managing People's Relationships with Their Jobs".
"Podívejte se na svůj život jako na celek a ujistěte se, že v něm jsou dobré věci, a ujistěte se, že pro ně máte čas".
Získejte bezplatný příručku investování od CNBC, ve které se shrnují nejlepší rady miliardáře pro běžné investory, to, co dělat a co nedělat, a tři klíčové principy investování do jasné, jednoduché příručky.
Přihlaste se: Zjistěte více o svých penězích a kariéře pomocí našeho týdenního zpravodaje
Mladý obviněn z vraždy v prosinci při střelbě ve škole v Chicagu, která zanechala dvě mrtvé.
Šestnáctiletý chlapec byl obviněn z vraždy při zastřelení dvou studentů na střední škole v Chicagu v prosinci, oznámila policie v pátek.
Podezřelý je obviněn ze dvou vražd prvního stupně a dvou pokusů o vraždu, oznámil šéf chicagské policie David Brown.
"V současné době nemáme jasný motiv, proč by 16letý chtěl zastřelit a zabít jiné děti", řekl Brown.
Jméno podezřelého nebylo zveřejněno kvůli jeho věku, i když Brown řekl, že by čelil vraždě a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benito Juarez.
Oběti, které zemřely, byly chlapci ve věku 14 a 15 let, oznámila policie.
Vyšetřovatelé říkají, že tipy od veřejnosti jim pomohly k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční všem, kteří byli dostatečně odvážní, aby se přihlásili a zajistili, že pachatel bude chycen a bude nyní zodpovědný", řekl státní zástupce obvodu Cook Kim Foxx.
Brown řekl, že podezřelý se má v sobotu objevit u Bond Court, kde mu budou předloženy další detaily o důkazech, které shromáždili.
Biologové z Minnesoty zachraňují uvězněného medvěda
Minesota Ministerstvo přírodních zdrojů přišlo na záchranu medvěd-y nešťastný medvěd poté, co se stal uvízl v příkopu.
Medvěd se usadil v průsmyku u silnice u Wannasky v Minnesotě, podle článku na Facebooku oddělení.
Ale když se sníh začal tavit, kanál začal zaplavat, a uvěznil medvěda v hlubokém sněhu a ledu, podle oddělení.
Zaměstnanci oddělení rychle na místo a pomohli odstranit medvěda.
Podle článku na Facebooku medvědův biolog Andrew Tri, "prošetřil medvěda a prohlásil, že je zdravý, ale omámený - očividně proto, že byl probuzen ze svého zimního spánku".
Oddělení pak přestěhovalo medvěda do státní útočiště, aby pokračoval v zimním spánku.
Spát karnivor byl odhadován na 6 let a mezi 375 a 400 liber.
Oddělení připomíná obyvatelům, že pohyb medvědů je práce, kterou je nejlepší nechat na profesionálech.
Pokud máte obavy z medvěda ve vašem sousedství, měli byste kontaktovat místní úřady - ne se pokusit hýbat nebo nakrmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat a nabídli mu jídlo, včetně Pop-Tarts, salátu a kočičího jídla Fancy Feast.
Ale, naštěstí pro dobře míněné kopce, "protože medvědi nemají chuť jíst v zimě, medvěd nekoušel".
Podle Ministerstva přírodních zdrojů je v Minnesotě mezi 12 000 až 15 000 černých medvědů, kteří se nacházejí především v severní třetině státu.
Loviči v zimě hibernují šest až sedm měsíců, během nichž nejí a živí se uloženým tělesným tukem.
Fotografie: Po restaurování, Egypt otevírá hrobky Djehuty a Hery
Hrobky Džehuty a Hery byly otevřeny ve čtvrtek po dokončení restaurátorských prací.
Oslavu vedli generální tajemník Nejvyšší rady pro starožitnosti v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a prezident Španělské národní rady pro výzkum (CSIC), Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Vysoké rady pro starožitnosti a CSIC, která pracuje od roku 2002.
Řekl, že mise provedla vykopávky a restaurační práce a zveřejnila výzkum související s hrobkami, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odhalit mnoho hrobek, rakví, mumií a pohřební zahradu.
Významné hrobky z významné éry
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili na počátku 18. dynastie Nového království - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že uspořádání hrobek má tvar písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty jsou konzistentní s vchodem, sloupovou halou vedoucí k hrobní šachty, a zdi s odlišnými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a dohlížel na díla řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byl také zodpovědný za zaznamenání Hatshepsutovy cesty do Puntlandu a za zásobu elektrum (směs zlata a stříbra) pro pokrytí vrcholu obelisků, které umístila v chrámech v Karnaku.
Navíc byl zodpovědný za proces přesunu obelisků.
V místnosti, která předchází Djehutovy pohřební komnatě, jsou inskripce vyryté s 43 kapitolami Knihy mrtvých, poprvé, když byly kapitoly knihy napsány na stěny hrobek, než byly napsány na plátno a papyrus.
Hery, zastával pozici dozorce královských skladů svaté královské manželky a matky Ahhotepa.
Jared O'Mara by nikdy neměl být labouristickým kandidátem, říká Rachel Reevesová
Zhanbený bývalý poslanec Jared O'Mara "by nikdy neměl být vybrán jako labouristický kandidát" a zaslouží si čtyřletý vězení, řekl stínový kancléř.
Rachel Reevesová v pátek mluvila s Guardianem v volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany rezignovaly na protest proti tomu, jak národní výkonný výbor Laboristů (NEC) kontroluje parlamentní proces výběru pro příštích voleb.
Celá výběrová komise v Boltonu severovýchodní rezignovala poté, co jim nebylo dovoleno vybrat si krátkou přihlášku, což je stále běžnější praxe v Labouristické straně Keira Starmera: " Znovu se zdá, že Labouristická strana se snaží propagovat názory a postoje klinky v Londýně, spíše než místních členů na severu".
Doplnili: "To je v rozporu s postojem, který je nezbytný k získání zpět červené zdi, která je tak zoufale zapotřebí k vytvoření vlády laboristů.
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách".
Velké rozhořčení vyvolává skutečnost, že Leigh Drennanová, předsedkyně labouristické strany North West a poradkyně poslanečky Warringtonu North Charlotte Nicholsové, která podporuje Jeremyho Corbyna, nebyla v seznamu kandidátů, kteří se pokusí vyhrát místo od konzervativců, ačkoli získala nominaci od čtyř velkých odborových svazů.
Reevesová řekla, že nemá nic společného s výběrem kandidátů, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné postupy pro to, kdo může být uveden v seznamu a kdo může být na seznamu".
O'Mara byl tento týden vězněn na čtyři roky poté, co porota zjistila, že předložil falešné výdaje v celkové výši 52 000 liber ve snaze financovat jeho zneužívání kokainu a alkoholu.
Spousta lidí tvrdí, že nebyl řádně vyšetřen laboristy, když byl vybrán, aby bojoval s Nickem Cleggem, bývalým místopředsedou vlády Liberalistických demokratů, v Sheffield Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se debakl O'Mary stal velkým v mysli Labouristické NEC, Reeves řekl: "Nechci žádným způsobem naznačovat, že někdo, kdo není na krátkém seznamu, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy by neměl být vybrán jako Labouristický kandidát, nikdy by neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest".
O'Maraova okolnosti byly "příliš výjimečné", řekla Reevesová, avšak uznávají: "Pro labouristickou stranu a všechny politické strany je možné získat důležité ponaučení při výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme viděli neustálé podkopávání standardů v politice, v neposlední řadě následováním premiérů a pokut a stran a standardů, které daleko nedosahují toho, co můžete očekávat".
"Jedna věc, kterou bych řekl o Labouristické straně, je, že když lidé dělají špatně, ztrácejí bič a to prostě není případ v Konzervativní straně".
Archie Bland a Nimo Omer vás provázejí hlavními příběhy a co znamenají, zdarma každé ráno.
Oznámení o ochraně osobních údajů: Zprávy mohou obsahovat informace o charitativních organizacích, on-line reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich zásadách ochrany osobních údajů.
Pro ochranu našich webových stránek používáme Google reCaptcha a platí zásady ochrany osobních údajů a podmínky služby společnosti Google.
Reeves byl v Boltonu, aby se setkal s učňami ve školícím centru pro Openreach, který poskytuje širokopásmovou síť ve Velké Británii.
Po pozorování učňů, kteří lezou na falešný telegrafní stožár v budově v hodnotě 1,7 milionu liber, Reeves projednává plány Laboristů na přepravení výdaje za učňovství, která nutí větší firmy dát stranou 0,5% svých platů na financování učňů.
Podniky si stěžují, že je poplatek příliš neflexibilní.Podle Reeve například Openreach "chce přepracovat lidi, kteří pracují na mědi, aby pracovali na vláknech, ale poplatek za učení nemá tuto flexibilitu v oblasti přeskupení".
Reeves řekl, že laboristé změní daň tak, aby společnosti mohly použít peníze na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový sektor a ty, které nyní montují plynové kotle.
"Potřebujeme je jako součást přechodu na nulovou energii, abychom se naučili pracovat na elektrických vozidlech nebo na montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli přetvářeni, aby získali dovednosti, které potřebují k úspěchu.
A přesto je proti nim namátka na učňovství.
Podniky chtějí větší flexibilitu a mladí lidé, kteří začínají život nebo starší lidé, kteří se chtějí přetvořit, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost", uvedl Reeves.
Jeden zatčen uprostřed protestu Tate Britain proti dětské akci drag queenů
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala atrakce pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena kvůli podezření z rasistických poznámek k policejnímu důstojníkovi před uměleckou galerií v blízkosti Westminsteru.
Žádná zranění nebyla hlášena a policisté zůstávají na místě, řekla policie.
Tate v sobotu hostil Drag Queen Story Hour UK, kde vyprávěla Aida H Dee, kterou webová stránka galerie popisuje jako "první drag umělkyni v Evropě, která četla příběhy dětem z mateřských škol".
Skupina pravicových demonstrantů demonstrovala mimo galerií a setkala se s protispřítomnými vedeni aktivisty za trans-práva a politickými skupinami, včetně skupiny Stand Up to Racism.
Policisté museli vytvořit chodbu, aby se do sálu mohli dostat dozorci.
Překládající královna napsala na Twitteru, že den byl "skutečně emocionální", a dodala, že pět demonstrantů vstoupilo do Tate a "způsobilo narušení" v částech budovy, ale na čtení nepomohlo.
Předtím řekla Pink News, že pozvání do Tate pro událost během měsíce historie LGBTQ + byla "častí".
Její přednášky byly dříve terčem protestů.
Drag Queen řekla, že "hodnocení rizik" proběhlo předem - ale dodala, že je "směšné", že je to nezbytné.
Aida tweetovala: "5 nenávistníků se dostala do Tate. Oni způsobili zmatek. Ale ne na Drag Story Hour UK...Učinili zmatek jinde v budově, ne tam, kde byla show!! SHOW 2 šlo bez problémov!!!"
Aida uspořádala tři příběhy v sobotu v 11 hodin ráno, v poledne a ve dvě odpoledne.
Mluvčí muzeum Tate řekl: "Neprogramujeme umělce proto, abychom propagovali konkrétní názory, ani abychom usmířili různé názory".
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybírat, s jakými aspekty se zapojují".
Trumpova oceňovaná budova na 40 Wall Street je stále v bezpečí kvůli poklesu příjmů:
Trumpův vysoce zadlužený mrakodrap na Wall Street 40 je "na pozorování" uprostřed prudce klesajících příjmů a zvyšujících se nákladů, uvedl Bloomberg v pátek.
Míra prázdných míst v budově s 72 patry - Trumpově nejcennější budově - vzrostla během třetího čtvrtletí loňského roku na téměř 18%, podle měsíčních údajů o zbývajícím hypotékním dluhu budovy ve výši 126,5 milionu dolarů, informoval Bloomberg.
Podle zpráv se mezitím náklady zvýšily o 11% od vzniku hypotéky z roku 2015.
Trump se často chlubil budovou, kterou získal v roce 1995, která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků 11. září 2001, kdy bylo zničeno Světové obchodní centrum a zabito 3000 lidí, se Trump v televizním interview chlubil, že 40 Wall Street je najednou nejvyšší budova ve městě.
Jeho tvrzení bylo nejen necitlivé, ale také lež.
Další nedaleký mrakodrap na Pine Street na Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem kancelářských budov na Manhattanu klesá již po léta, což se ještě zhoršilo po vypuknutí pandemie COVID-19, protože mnoho firem se zavřelo a zaměstnanci přežívajících firem pracovali na dálku.
Wells Fargo, která poskytuje hypotéku na 40 Wall Street, "se dotkla dlužníka pro status leasingu vývoje" a plány na zlepšení výkonu nemovitosti, podle podání Bloomberg uvedl.
Majitel Wagnera říká, že válka na Ukrajině bude trvat roky.
Majitel ruského soukromého vojenského dodavatele Wagner Group, aktivně zapojeného do bojů na Ukrajině, předpovídá, že válka by se mohla táhnout po léta.
Yevgeny Prigozhin řekl v video interview zveřejněném v pátek, že Rusku může trvat 18 měsíců až dva roky, než získá plnou kontrolu nad východním průmyslovým centrem Ukrajiny, Donbasu.
Dodal, že válka by mohla pokračovat tři roky, pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr.
Vyjádření Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinův kuchař" pro své lukrativní kontrakty na kremelské restaurace, znamenalo uznání těžkostí, kterým Kreml čelí v kampani, kterou zpočátku očekával uzavřít během týdnů, kdy ruské síly napadly Ukrajinu 24. února.
Rusko utrpělo na podzim sérii ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšnou protiofenzívu, aby získala zpět široké pásy území na východě a jihu.
Kreml se vyhýbal předpovědím, jak dlouho by boje mohly pokračovat, říká, že to, co nazval "zvláštní vojenská operace" bude pokračovat, dokud jeho cíle nejsou naplněny.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří oblast Donbasu, kde separatisté podporovaní Moskvou bojují proti ukrajinským silám od roku 2014.
Prígožin uvedl, že žoldáci skupiny Wagner pokračují v ostrých bitvách o kontrolu nad ukrajinskou pevností Bakhmut v Doněcké oblasti.
Přiznal, že ukrajinské jednotky vytvářejí prudký odpor.
Zatímco ruské jednotky posouvaly útoky na Donbas, Moskva se také snažila demoralizovat Ukrajince tím, že je nechala bez tepla a vody v kruté zimě.
V pátek Rusko zahájilo 14. kolo masivních útoků na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Vysokonapěťové zařízení byly postiženy ve východních, západních a jižních regionech, což vedlo k výpadkům elektrické energie v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná", přičemž dodávala, že se jedná o zálohy, které zajistí dodávky elektřiny, ale uvádí, že v některých oblastech bude pokračovat v omezení elektřiny.
Předseda ukrajinské armády generál Valerii Zaluzhnyi prohlásil, že ruské síly ve čtvrtek večer a v pátek v poledne odpálily 71 střel, 35 raket S-300 a sedm dronů Shahed a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel a pět dronů.
Ukrajinské úřady hlásily další útoky zabijáckých dronů později v pátek.
Ukrajinské letectvo uvedlo, že armáda sestřelila 20 dronů Shahed.
V pátek v noci zveřejnili ruské vojenské blogery a některé ukrajinské zpravodajské organizace video, které ukazuje útok na strategický železniční most v oblasti Oděsy.
Z zrnitého videa bylo vidět, jak se rychle se pohybující předmět blíží k mostu v Zatce, asi 50 kilometrů jihozápadně od Oděsy, a exploduje silnou explozí.
Autentičnost videa nebyla ověřena.
Ukrajinská armáda se k útoku nevyjádřila a Serhii Bratchuk, mluvčí regionální správy, útok drony v sobotu v televizním prohlášení nepopustil.
Most, který byl cílem ruských raketových útoků na začátku války, slouží železničnímu spojení s Rumunskem, což je klíčový kanál pro dodávky zbraní ze Západu.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazachští záchranáři v Turecku vyklidili 7 přeživších a těla 19 mrtvých: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazachští záchranáři pokračují v pátrání po přeživších v Turecku, cituje Kazinform tiskovou službu ministerstva pro mimořádné situace Kazachstánu.
Práce záchranářů je ztížena velkým množstvím trosek a nestabilními konstrukcemi.
Zatím Kazachstánský záchranný tým v Turecku vyjmul sedm přeživších a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc se poskytuje také nepřetržitě.
Zejména v pondělí ráno postihlo zemětřesení o síle 7,7 stupně, které zdevastovalo části jihovýchodního Turecka a severní Sýrie.
Počet mrtvých v důsledku silného zemětřesení, které postihlo jihovýchod Turecka, dosud přesáhl 20 000.
Fotografie: t.me/qr_tjm
Asijské mistrovství má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM - V pátek se v sportovním centru Kazachstánu v Astaně uskutečnilo slavnostní zahájení 10. asijských šampionátů v atletice.
Na akci se zúčastnil předseda vlády Kazachstánu Alikhan Smailov, cituje Kazinform tiskovou službu kazachského premiéra.
Při zahájení akce předseda vlády přečetl přivítatelný dopis prezidenta Kašima-Jomarta Tokayeva.
"Sport nezná hranice.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro profesionální i masový sport.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex s kapacitou přes šest tisíc lidí", stojí v dopise kazašského prezidenta.
Kazachstánští sportovci úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokayev.
Vyjádřil přesvědčení, že konání Asijského šampionátu v Astaně dává nový impuls rozvoji lehké atletiky v zemi, a přislíbil větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazachstánský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanovi al-Hamadovi za pomoc při přípravě a konání šampionátu.
Asijské mistrovství v atletice se koná poprvé na území SNS.
Do soutěže se zapojilo přes 500 sportovců z 31 zemí, kteří se budou soutěžit v závodech, v štafetoch, ve skoku, ve skoku do výšky, ve skoku do tří, v skoku z prknu, v střelbě a v all-around.
Turnaj proběhne do 12. února.
Dříve se informovalo, že kazašská běžkyně Caroline Chepkoech Kipkirui vyhrála v běhu na 3 000 m zlato a Olga Safronova získala stříbro na 60 m.
Fotka: primeminister.kz
Herec z "Yellowstone", Q'orianka Kilcherová, je obviněn z podvodu.
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském slavném případu o pomluvě, dosáhla dalšího právního vítězství - tentokrát s herečkou z filmu Yellowstone, Q'oriankou Kilcherovou.
V pátek, okresní kanceláře Los Angeles prokuratura osvobodila Kilchera, 32 let, ze všech obvinění ve zpronevěře zaměstnanců.
V prohlášení zveřejněném v pátek pro The Times, mluvčí okresního prokurátora v Los Angeles řekl, že soud "rozhodl, že paní Kilcherová nespáchala pojišťovací podvod a doporučil soudu, že jsme nebyli schopni pokračovat".
V červenci 2022 obvinili úředníci v Kalifornii Kilcherovou ze dvou trestných činů podvodů v rámci náhrady zaměstnancům, obvinily ji z toho, že mezi říjnem 2019 a zářím 2021 ilegálně získala více než 96 000 dolarů na zdravotních výhodách.
Do časové lhůty zahrnuje i několik měsíců, kdy Kilcher pracovala na "Yellowstone", navzdory tvrzení herečky, že byla příliš zraněná, než aby mohla pracovat.
Kilcher se sám vzdal a v květnu byl postaven před soud.
"Dnes jsem více než vděčná, že můj případ byl zamítnut - zítra začne moje cesta pomoci zvyšovat povědomí a požadovat větší transparentnost pracovních práv v rámci systému zaměstnanců", řekl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodal, že "se těší na to, že budu moci ještě více mluvit o této věci a pokračovat v práci, kterou miluji".
Kilcher také poděkoval Vasquezové a jejímu kolegovi z Brown Rudnick, advokátovi Stevu Cookovi za "jejich pevnou víru v mou nevinu".
Podle TMZ je Kilcher najal v září.
Kilcher se rozešla v roce 2002 ve filmu Terrence Malicka "The New World", kde hrála Pocahontas.
Zahrnuje také "Sons of Anarchy", "The Alienist" a "Dora a ztracené město zlata".
V poslední době se objevila ve filmu "Dog", kde hrál Channing Tatum.
Christina Martinezová, redaktorka Times, přispěla k této zprávě.
Šéf Balenciagy nazývá vánoční kampaň "hloupou chybou"
Luxusní značka oblečení Balenciaga se stále ještě probouzí po negativní reakci z dvou svých nedávných reklamních kampaní.
Míty měsíců poté, co se tento módní dům dostal pod tlak kvůli reklamnímu fotování dětí, které podle kritiků sexuálně poškozovaly, umělecký ředitel Balenciagy Demna (plné jméno Demna Gvasalia) v rozhovoru pro Vogue, publikovaném v pátek, řekl, že je mu stále líto těchto fotek.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro kampaň s dětmi a přebírám svou zodpovědnost", řekl Vogue, odrážející předchozí prohlášení, které zveřejnil na sociálních sítích v prosinci.
V listopadu se značka sdílela fotky ze své kolekce "The Gift", na které byly zobrazeny dětské modely pózující s medvědy oblečenými v oblečení pro bondage.
Krátce poté Balenciaga uložila fotky pro svou kampaní na jaře 2023, kde na pozadí byla stránka ze případu Nejvyššího soudu z roku 2008, která zahrnovala "virtuální dětskou pornografii".
Rodiče, včetně reality show hvězdy a dlouholeté fanoušky značky Balenciaga - a partnerky značky - Kim Kardashian, vyjádřili se proti značce a jejím "obtěžujícím obrázkům" na sociálních sítích.
O několik dní později Balenciaga vydala prohlášení, ve kterém se omluvila za fotky a uvedla změny, které chce provést, aby se zabránilo podobným "chybám" v budoucnu.
"Tato zkušenost mě donutila přehodnotit mnoho věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s publikem, a ve způsobu, jak se učíme ze svých chyb a postupujeme kupředu", řekla Demna časopisu Vogue.
Podrobně popsal změny v Balenciage: "reorganizaci image oddělení", provádění více interních a externích kontrol pro kampaně imagery a partnerství s National Children's Alliance na pomoc "tisticem dětí v procesu překonání traumatu a vypořádání s jejich duševním zdravím".
"Je to jediná věc, která mě z celé této hrozné situace dělá šťastným: udělat z ní něco dobrého", řekl o této spolupráci, která byla oznámeno ve středu.
S NCA se také spolupracuje mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky, včetně Saint Laurent a Bottega Veneta.
Pod záštitou Kering je Gucci, které čelilo v prosinci protichůdným reakcím za kampaň s Harry Stylesem, o které někteří kritici sociálních médií tvrdili, že sexuálně zneužívá děti.
V rozhovoru Denma řekl, že se plánuje vzdálit od "provokačních" způsobů značky.
"Toto je součástí mého učení: Budu mít zralější a vážnější přístup ke všemu, co zveřejním jako myšlenku nebo obraz", řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě a také k kořenům Balenciag, která vyrábí kvalitní oblečení - ne vytváření obrazu nebo buzu".
Když mluví o původu značky, Demna jinde v rozhovoru uvedla, že jednou z nejbolestivějších částí reakce bylo znehodnocení " jména Balenciaga a dědictví Cristóbala Balenciagy".
"Balenciaga je dům, který je starší než sto let a je založen na silných a krásných kreativních hodnotách, a já jsem dělala vše, co bylo v mé kreativní síle, abych ho přinesla do jeho moderní současnosti, a najednou jsme byli napadeni a označeni jako něco, co nejsme vůbec", řekla Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s dárkovou kampaní a určitě jsme se z toho poučili".
Je to falešná zpráva, CBN odhalí, že nemá kapacitu na tisk nových bankovek
Central Bank of Nigeria (CBN) popsala jako zavádějící zprávu, která tvrdila, že cituje guvernéra CBN, pana Godwina Emefiele, který připisuje současnou výzvu v distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů ve společnosti Nigerian Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neudělal takové prohlášení během své prezentace Státní radě na její zasedání v pátek 10. února 2023.
Pan Nwasinobi uvedl, že Emefiele pouze oznámil na setkání, že NSPMC pracuje na tisku všech nominálních hodnot nairy, aby vyhověla potřebám transakcí Nigerijců.
Řekl, že zatímco CBN oceňuje obavy projevené všechny zúčastněné strany ohledně distribuce nových bankovek, "jsme znepokojeni tím, do jaké míry se zmocněné zájmy snaží manipulovat skutečnostmi a vytáhnout veřejnost proti bance".
Nwasinobi uvedl, že CBN zůstává odhodlána plnit své funkce v oblasti měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění změn).
"Přejíme si také znovu zdůraznit, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované výraze nairu.
"Bank proto žádá veřejnost, aby tuto zprávu ignorovala a uplatňovala větší zdrženlivost, zatímco usilovně pracujeme na zvýšeném oběhu nových bankovek v zemi", dodal.
Na konkrétní hlas, který se objevil na sociálních sítích, v němž se uvádí, že CBN plánuje zavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že takový plán neexistuje a že tato tvrzení jsou nelogická a nezpůsobuje se fungováním nigerijského bankovního systému.
"Všeobecnosti se proto doporučuje, aby tyto nahrávky ignorovaly, protože nereprezentují směr politiky CBN a jsou jen zoufalými pokusy osob, které jsou odhodlané podněcovat veřejnost proti bance", uvedl.
Tim Sherwood chce za 44 milionů dolarů podepsat Pedra Porra po ponurém debutu v Tottenhamu.
Porro měl nepopsatelné odpoledne proti Leicesteru (Foto: Getty)
Tim Sherwood se vrhl do "úplně nechutné" obrany Pedra Porra během porážky Tottenhamu 4-1 před Leicesterem.
Spurs podepsal pravého obránce ze Sporting CP na den transferového termínu v úvodní smlouvě o půjčce za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
23-letý hráč obdržel své první vítězství od Antonia Contého v sobotu na King Power Stadium, kde jeho tým vedl po 14 minutách přes Rodrigo Bentancur.
Ale to se změnilo v mizerný odpoledne s Nampalys Mendy, James Maddison a Kelechi Iheanacho všechny branky dát Leicester 3-1 na půličase s Porro snášet pálícím první půli v Premier League.
Španěl se opět mýlil, protože Leicester si myslel, že přidali čtvrtého přes Barnes a zatímco gól byl vyloučen z ofsajdu, bývalý manažer Spurs Sherwood byl šokován obranným úsilím plného záložníka.
"Nechci ho stále otravat, ale potřebuje být zbaven svých povinností", řekl Sherwood v sobotu pro Soccer.
Dávám mu předpoklady, protože je to jeho debut, ale Pedro Porro není špatný, je neuvěřitelný.
Jeho pozice je naprosto nechutná, Barnes a Maddison ho ničí na levé straně.
Daniel Levy tento týden říkal, že utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a tohle je poslední přírůstek.
Teď už nesmíme dělat žádné závěry, ale vidím hráče, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na obranu a tenhle hráč se právě potýká s obranou, proti velmi dobrým hráčům jako Barnes a Maddison, ale je to velmi zklamání".
Zatímco gól byl vyloučen, Leicester obnovil svůj 4-1 s Barnesem na cíli devět minut od začátku zápasu.
I když minulý týden porazili Manchester City, Tottenham propásl šanci dostat se před Newcastle na třetí místo.
Jimmy Floyd Hasselbaink říká Chelsea, aby nepřihlásil Joao Felixe a místo toho se přihlásil na Tottenhamovi
Tottenham nabídl za hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu.
Další příběhy, jako je tento, naleznete na naší sportovní stránce.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoliv boj o předvolání Mikea Pencea.
Zpráva o tom, že speciální státní zástupce Jack Smith předvolá Mikea Pencea, vyvolává otázku: Jak bude tým Trump využívat soudy k tomu, aby zkazil poslední vývoj ve vyšetřování ministerstva spravedlnosti?
Krátká odpověď je, že jakýkoli pokus o zrušení Penceova předvolání z důvodů privilegia by měl selhat.
Za prvé, je tu otázka, zda by bývalý prezident mohl požádat o výsadu.
Připomeňte si, že Trump se pokusil a nepodařilo se mu zabránit, aby komise pro 6. ledna získala záznamy z Bílého domu.
Nejvyšší soud loni odmítl přezkoumat Trumpův odvolání, pouze soudce Clarence Thomas (manžel popírajícího voleb v roce 2020 Ginni Thomas) nesouhlasil.
Ale soud nechal otevřenou otázku, zda bývalý prezident může tvrdit, že má výsady, soudce Brett Kavanaugh navrhl, že by takový nárok podpořil.
Takže je nejméně nejasné, zda by se bývalý prezident mohl nárokovat na výsadu, nic neříká o tom, zda by nárok uspěl.
Navíc, odvolání Nejvyššího soudu na pokus tehdejšího prezidenta Richarda Nixona vyhnout se dodržování předvolání ukazuje, že to neurčité tvrzení o privilegiích nebude stačit, a může být překonat specifickou potřebou důkazů.
Soud konstatoval v případu Spojené státy proti Nixonovi v roce 1974:
... když důvod pro uplatnění výsadních pravomocí týkající se předvolaných materiálů požadovaných pro použití v trestním řízení je založen pouze na obecném zájmu o důvěrnost, nemůže převládnout nad základními požadavky řádného soudního řízení při spravedlivém výkonu trestního soudnictví.
Všeobecné tvrzení o výsadě musí ustat před prokázanou, konkrétní potřebou důkazů v probíhajícím trestním procesu.
Proto je precedens na straně vlády.
Samozřejmě, že zpoždění ve vedení sporu, i když je prohrávající, může být pro Trumpa vítězstvím.
Ale nadále slábne šance úspěšného nároku na výsady je předchozí odmítnutí Trumpova pokusu blokovat svědectví poroty 6. ledna.
Jak informoval The Washington Post v říjnu, toto odmítnutí naznačuje, že například bývalý Penceův asistent Marc Short "pravděpodobně měl důležité informace pro trestní vyšetřování ministerstva spravedlnosti z 6. ledna 2021 útoku na Kapitol, které nebyly dostupné z jiných zdrojů".
Pence má pravděpodobně unikátní informace, které by pomohly ministerstvu spravedlnosti v boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace je další důvod, proč by nárok na výsadu měl padnout.
To proto, že Pence se rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říci, že komunikace jsou důvěrné, když jste je považovali za vhodné zveřejnit.
Takže zatímco předvolání by mohlo prezentovat různé politické a osobní kalkulace pro Pence - který se může utkat o nominaci Republikánů v roce 2024 proti Trumpovi, někomu, kdo v podstatě odpouštěl volání po Penceově mimosoudní popravě 6. ledna - by soudy měly mít snadné uvést se na stranu ministerstva spravedlnosti za zásluhy.
Případ proti Bidenovi je zřejmý - a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové demokrati nemohou udělat moc při schvalování zákonů s republikány v kontrolním sněmovně, mohou pořád strávit příští dva roky tím, že budou příkladem.
Všichni v týmu by měli hledat příležitosti, jak hrát Galant na Republikánce.
Ale je také důležité, aby Biden vylepšil svoji důvěryhodnost u amerického lidu - a možná být potřebným agentem změny v naší příliš vystrašené politické kultuře.
Washington, notoricky cynické místo, je proslulé svými myšlenkami o vedení, které ochromují zdravý rozum.
Možná nejznámější z nich je zvláštní standard, podle něhož je veřejné přiznání chyb znamením slabosti a politici by se měli snažit, aby se tomu vyhnuli.
Existuje jiný způsob: v Bailout, paměti Niela Barofskyho z doby, kdy byl ve Washingtonu jako zvláštní generální inspektor dohlížející na program na pomoc problémovým aktivům, popsal rady, které dostal od Kristine Belisleové, ženy, kterou chytré najal na své komunikační ředitele.
Byl tak proti Washingtonu, jak to jen může být: "Uznáváme a dokonce zdůrazňujeme naše chyby".
Jak vysvětlila dále, ve strategii je metoda, kterou by většina lidí uvnitř Beltway považovala za šílenství:
Tohle je nejlepší způsob, jak si získat důvěru tisku.
Vědí, že se neotáčíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o TARP ve Washingtonu.
Možná se občas stydíme a odhalíme věci, které bychom mohli - a ostatní by - snadno skryli, ale tisk bude šokován naší upřímností.
Nikdo jiný to nedělá a brzy budeme mít vestavěnou obranu, když na nás zaútočí.
Nezáleží na tom, co uslyší, tisk přijde první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč Biden usiluje o radikální převzetí odpovědnosti: V každé prezidentské funkci nevyhnutelně přicházejí okamžiky, kdy je důvěra veřejnosti a institucí, které chrání občanský zájem, zásadní.
Navíc je zde životně důležitý kapitál, který můžete získat vlastnictvím svých chyb, a je tu důležitý rozdíl, který může Biden vytvářet s jeho politickými oponenty.
Prezident by měl následovat staré přísloví: Řekni pravdu - a zesměšni ďábla.
Některé reklamy na Super Bowl, na které se nemůžu dočkat.
Hvězda sitcomu 90. let, který opakuje svou milovanou roli, aby vám prodal pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní show, prodlužující 12 sekundovou scénu na deset sezon.
Všechny celebrity z loňských reklamy se omlouvají za své reklamy.
Ti "whassup" kluci, ale teď už jsou staří.
Všichni jsou teď na "kdo je kdo", že?
Takže několik seriálů reklam režírovaných Rianem Johnsonem, kde když zjistíte, kdo spáchal vraždu, dostanete slevu na roční pojištění auta.
Reklama, na kterou budou všichni super-online konzervativci zuřit celý týden.
Timothée Chalamet v určitém postavení.
Někdo, kdo byl údajně navždy zrušen a triumfálně se vrací do televize, aby ti prodával pivo.
Reklama na nejhorší film, jaký jste kdy viděli, který určitě uvidíte, až se bude streamovat za tři týdny.
Neskutečně chytlavý nový jingl, který si budeš zpívat celé roky.
Recyklovaný vtip z Twitteru z před dvěma měsíci.
Hudebník, jehož celá věc je proti-kultura. který vám říká, abyste bankovali u Wells Fargo.
Ten "zoom zoom", ale teď je dospělý.
Biden DOJ 'Nechce ozbrojené občany'
Andrew Clyde (R-GA) se ve čtvrtek sešel s Breitbart News a diskutoval o svých plánech blokovat pravidlo ATF o podpisu pistole a jeho přesvědčení, že Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občanství" na prvním místě.
Clyde jasně řekl, že je proti pravidlu o držení pistole.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější.
Obecně vzato, vyjádřil své přesvědčení, že naši otcové zakladatelé nezajistili plán vlády, který by zahrnoval federální agentury vytvářející zákony místo zákonodárců.
Řekl: "Ministerstvo spravedlnosti je tam, aby prosazovalo zákon, ne aby vytvářelo zákon. Když máte výkonnou moc, která dělá zákony a prosazuje je, pak máte krále a království. Naši zakladatelé nenavolali krále a nevyložili království v ústavě Spojených států".
Clyde se pak přesunul do detailů ohledně pravidla o pistole a vyjádřil obavy, že pravidlo je součástí většího úsilí ATF získat širší registraci střelných zbraní.
"ATF chce rozšířit databázi registrace pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co přichází před konfiskací je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občanství. "
A dodal: "Ale toto ministerstvo spravedlnosti chce registrované občanství, aby vědělo, kdo co má, aby nás mohlo pronásledovat".
Clyde tvrdí, že pravidlo o držení pistole v ATF se zrodilo v prostředí nepřátelství vůči druhému dodatku a soukromému vlastnictví zbraní, a plánuje s tím bojovat zuby a nehty.
Řekl, že má "tři nástroje", kterými může bojovat proti pravidlu.
Prvním z těchto nástrojů je SHORT Act a druhým je zákon o přezkumu Kongresu.
Dne 30. ledna Breitbart News citoval Clyda, jak zdůrazňoval svůj plán "znovu zavést Stop Harassing Owners of Rifles Today Act nebo SHORT Act, aby zrušil prvky Národního zákona o střelných zbraních, čímž zakáže ATF registrovat a zakázat pistole se stabilizačními podpěry".
Také poznamenal, že "zaveďuje rezoluci o nesouhlasu podle zákona o přezkoumání v Kongresu, aby překročil nezákonné překročení Bidenovy administrativy".
Oba zákony, SHORT Act a Congress Review Act, mají možnost blokovat pravidlo ATF pro držení pistole.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, buď k přijetí legislativy SHORT Act, nebo k dokončení rezoluce nesouhlasu podle zákonu o přezkoumání Kongresu.
Jasně uvedl, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT by mohla být přidána k jiným, větším zákonům, které demokraté velmi touží schválit.
Nicméně, Clyde naznačil, že existuje i třetí způsob, jak zablokovat pravidlo ATF o držení pistole.
Řekl: "Jsem v komisi pro rozpočtovou kontrolu a můžeme zrušit toto pravidlo o držení pistole, prostřednictvím tzv. změny omezování. Můžeme doslova zrušit toto pravidlo a v podstatě říct:" Žádné peníze nesmí být vynaloženy na výkon nebo vynucování tohoto pravidla o držení pistole.
A můžeme udělat totéž s pravidlem ATF přijímač/obrázek, z minulého srpna.
Myslím, že oba potřebují zrušení financování a těším se na spolupráci s našimi příjemci, aby to mohli provést.
AWR Hawkins je oceněný sloupkovník o Druhém dodatku pro Breitbart News a spisovatel / kurátor Down Range s AWR Hawkins, týdenní informační bulletin zaměřený na všechny věci Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem USA v Turning Point.
AWR Hawkins má doktorát z vojenské historie, se zaměřením na válku ve Vietnamu (hnědá vodní flotila), americké námořnictvo od vzniku, občanskou válku a ranou novodobou Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se přihlásit na Down Range na breitbart.com/downrange.
Sežeňte ho přímo na awrhawkins@breitbart.com.
"Doufáme, že Biden má plán na zvládnutí hlavy 42, pokud ano, tak se nesdíleli úplně".
V pátkový program NBC "MTP Now" guvernér Colorada Jared Polis (D) řekl, že má "velké obavy" z toho, co se stane, až Title 42 v květnu vyprší, doufá, že Bidenova administrativa má plán, kdy se politika skončí, a že "pokud to učiní, ještě nás úplně nespojují".
Řekl jsem: "Řekli jsme, že potřebujete plán, chceme, aby ho prozkoumali s námi.
Polis uvedl, že by si přál, aby se více času věnovalo otázce imigrace během schůzce guvernérů v Bílém domě, ale tato otázka "vytáhla".
Zčásti jsme tam měli ministra Mayorkase.
A tak jsme se znovu dohodli, že je spousta obavy o to, co se stane, když vyprší titul 42 v květnu, a tak se ujistit, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, tak to s námi ještě nesdíleli.
Ale říkali jsme, že potřebujete plán.
Chceme, aby to s námi prozkoumali.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo krát tři. To by byla katastrofa pro zemi a bylo by hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stáhne "nevkusnou" reklamu v blízkosti krematoria - RT World News
McDonald's se omluvil poté, co reklama "McCrispy" burgeru řetězce rychlého občerstvení byla umístěna blízko krematoria ve Velké Británii - i když někteří místní viděli zábavnou stránku.
Řetězec restaurací se zavázal odstranit porušující reklamní plakát po stížnostech od obyvatel Trura v anglickém hrabství Cornwall.
V pátek získal pozornost na sociálních sítích tím, že byl umístěn na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulem ukazujícím na krematorium, byla označena některými nahněvanými místními obyvateli jako "nevkusná".
"Ačkoli vidím v tom zábavnou stránku, je to nechutné a jsem si jist, že někteří truchlící členové rodiny to nebudou chtít vidět, když navštíví Penmount na pohřbu a kremování milovaného člověka", řekl obyvatel, jehož tchyně byla minulý rok spálena v pohřebním ústavu, jak citují britská média.
Ale ne všichni se tak urazili kvůli nešťastnému umístění inzerátu, a jeden člověk poznamenal, že reakci člověka na reklamu bude pravděpodobně ovlivňovat to, "jak dlouho jsi následoval cedulku krematorií s černou kravatou".
Jedna osoba řekla, že "spadla ze židle ze smíchu", když spatřila reklamní spot online, zatímco jiný místní také poznamenal, že to není "horší" než rozhodnutí rady přijmout myšlenku dovolit výstavbu krematoria "vedle vesnice důchodců".
Místní média v pátek zveřejnila prohlášení společnosti McDonald krátce poté, co se obraz reklamy objevil na internetu, v němž řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
"Nebyl nám znám signál v okolí autobusové zastávky, ale vzhledem k obavám, které vyvolalo CornwallLive, jsme požádali o odstranění naší reklamy", uvedla značka rychlého občerstvení.
Cornwall Council, která provozuje krematorium i autobusový zastávku, kde je ta reklama, odmítla komentovat tento rozruch, když byla kontaktována místními médii.
"Gut Instinct" pohřešovaná žena není v řece.
Pátrání po nezvěstné Angličance Nicola Bulleyové vstoupila do 16. dne poté, co její partner řekl, že jeho "pocit" je, že není v řece.
Lancashire policie uvedla, že policisté mají "otevřenou mysl", zatímco se snaží získat informace o paní Bulleyové, která zmizela 27. ledna, když se procházela se svým psem v kostele St Michael's v Wyre.
Policie pokračuje v pátrání po řece Wyre směrem k moři v Morecambe Bay, pracuje na jedné hypotéze, že by 45letý muž z Inskipu mohl upadnout do vody.
Při hledání jim pomohli odborníci a potápěči z HM pobřežní stráže, horské záchranné služby, a z Lancashire Fire and Rescue Service, přičemž tam byli využít psi, drony a policejní vrtulníky.
Slečna Bulleyová zmizela, když šla s Willow na procházku u řeky, krátce poté, co odvezla své dcery ve věku šesti a devíti let do školy.
Telefon hypotékového poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner, Paul Ansell řekl, že chce udržet "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popsal paní Bulleyovou jako "zábavnou", "milující", "nejvěrnější kamarádku, kterou jste kdy mohli mít" a "výjimečnou maminku", která "absolutně zbožňuje naše dívky".
"Je to jen pilíř síly naší rodiny a bez ní je díra větší, než si dokážete představit", řekl 5 News.
Pan Ansell řekl, že i když rodina prochází "bezprecedentním peklem", naděje, že jeho partner bude nalezen je "silnější než kdy jindy".
Policie odmítá podezření na pachatele a vyšetřuje incident jako pohřešovanou osobu.
Ve čtvrtek se jejich pátrání zaměřilo z St Michael asi 10 mil směrem dolů, kde se řeka vyprázdňuje do moře v Morecambe Bay, přičemž v oblasti byly spatřeny hlídkové a záchranné lodě.
Poslední komunistický vůdce Východního Německa zemřel ve věku 95 let
Hans Modrow, který sloužil jako poslední komunistický vůdce Východního Německa během turbulentního funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95.
Modrow zemřel v sobotu brzy ráno, tweetovala parlamentní skupina Levice.
Modrow, reformně smýšlející komunista, převzal Východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nemohl zpomalit momentum shromažďování pro německé sjednocení.
"Celý mírový proces vytvoření německé jednoty byl právě jeho zvláštním úspěchem", napsala Levice na Twitteru. "To zůstane jeho politickým dědictvím".
Během 16 let, kdy byl vedoucím komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst protivládního představitele.
Odmítl výhody a trval na tom, že bude žít v normálním bytě.
Posazení v nejvyšším vedení Východní Německa ho uniklo, dokud se v listopadu 1989 - několik dní po pádu berlínské zdi - nestal premiérem, což byla pozice, na kterou předtím neměl velký vliv.
Když na počátku prosince odstoupil vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou postavou východního Německa.
Ale komunisté už nemohli rozhodovat sami.
Příští měsíc souhlasil s rozdělením moci s čím dál hlasitější opozicí a posunul první svobodné volby do března 1990, uprostřed rostoucích nepokojů.
I když prodemokratické shromáždění brzy nabrali příznaky pro sjednocení, komunisté se zpočátku proti jednání o znovusjednocení.
V únoru 1990 však Modrow vyzval k jednáním se Západním Německem o možném vytvoření "spojené vlasti", která by byla nezávislá na vojenských blocích a byla by vládnuta společným parlamentem v Berlíně.
Modrow vedl volební kampaň restylovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nebyla dostatečná k tomu, aby jim zabránilo skončit jako třetí nejsilnější strana, s podporou 16 procent.
Vítězem byla aliance konzervativních stran, které upřednostňovaly rychlé znovusjednocení a které podporovala vláda západoněmeckého vůdce Helmuta Kohla.
Německo se sjednocilo pod Kohlovým vedením a jako člen NATO 3. října 1990, méně než rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde působil do roku 1994, a čestným předsedou postkomunistické strany PDS - předchůdce dnešní opoziční levicové strany.
Modrowova minulost pod tvrdou komunistickou vládou ho přivedla na soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků místních voleb v květnu 1989 v Drážďanech.
Dalo mu devítiměsíční podmíněný trest a pokutu.
Modrow prohlásil, že soud byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozdělení mezi východními a západními Němci.
Jeho právník tvrdil, že odčinil minulé nespravedlnosti tím, že jako premiér dohlížel na svobodné volby.
Později v životě, Modrow sloužil v radě starších levicové strany.
"Hans byl hluboce upřímný a bojovný socialista", napsal na Twitteru Dietmar Bartsch, předseda parlamentní skupiny levicové strany.
"Až do stáří byl důležitým poradcem naší strany, jehož moudrost nám bude chybět".
Indická vláda po kritice stáhne výzvu k objetí krav na Den svatého Valentýna
Objatí krávy na Valentýna už není indickou vládou podporováno - navzdory tomu, že dříve žádá lidi, aby tak učinili, aby podporovali hinduistické hodnoty.
Indická rada pro ochranu zvířat (AWBI) stáhla svůj požadavek na "Cow Hug Day" poté, co vyvolala kritiku od politických soupeřů a uživatelů sociálních médií.
Indická vláda vyzvala občany, aby se vyvarovali západních romantických gest slavených na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k obejmutí krav byla "absolutně šílená, vzdorující logice".
Dodal, že rozhodnutí o stažení odvolání bylo spíše "za účelem, aby se zabránilo tomu, aby se politice Hindutvy [hinduistického nacionalismu] vysmívala vzhledem ke těžké kritice ze všech stran".
AWBI se v pátek vzdá odvolání s tím, že "stane odvoláno".
Až ve středu bylo ve zprávě uvedeno, že "objímání krav [by] přineslo citové bohatství a zvýšilo individuální i kolektivní štěstí".
Více o Indii
A dodal, že kráva je "základem indické kultury a venkovské ekonomiky... díky své živné povaze jako matka".
Na počáteční oznámení byly různé reakce, protože někteří lidé zveřejnili videa krav, které odmítají být objaty a odbíhají.
Jiní chtěli objasnit, že se spíše odvolávalo na následování vlastní kultury, na rozdíl od "slepého" následování západních hodnot.
Mladí Indové tráví Den svatého Valentýna plnými lidí v parcích a restauracích, kde si vyměňují dárky a pořádávají večírky.
Objímání krav taky není nic nového - v některých částech světa je považováno za terapeutické, a v Nizozemsku je známo jako "koe knuffelen".
Oddaní hinduisté uctívají krávu - známou jako gau mata neboli "matka kráva" - a většina indických států zabíjení kravy zakázala.
V posledních letech někteří hinduisté tvrdé linie vypálili obchody, kde se prodávají zboží z Dne svátku svatého Valentýna, spálili pohlednice a dárky, a vyháněli z restaurací a parků ty páry, které se drží za ruce, protože trvají na tom, že tento den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal říkají, že takovéto nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Narendra Modiho tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadvládu náboženství v sekulárním národu známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinisté představují většinu zbytku.
Chodce zemřel v nemocnici po nehodě s autem v Cowdenbeath, muž zatčen
Pěší zemřel při srážce s autem v Fife.
38letá žena byla dopravena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeath v pátek kolem 13.30.
V souvislosti s nehodou byl zatčen 24letý muž.
Policie žádá všechny svědky, nebo někoho, kdo má záznam z palubní kamery, aby se přihlásil.
Seržant Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a žádáme každého, kdo byl v této oblasti a byl svědkem toho neštěstí, aby nás kontaktoval".
Také bych apeloval na každého, kdo jel v této oblasti a kdo by mohl mít záznamy z palubní kamery, které by mohly pomoci v našem vyšetřování, aby nás kontaktoval.
"Každý, kdo může pomoci, je žádán, aby zavolal Police Scotland na 101, kde uvádí číslo 1638 z pátku 10. února 2023".
ČÍTKY: Obce v Oslu, kde žije nejvíce cizinců
Zhruba 177.000 z 634.000 obyvatel Osla přistěhovalo do Norska z jiných zemí.
Pokud zahrnete ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecké zázemí, stoupne na více než třetinu.
V Oslu tvoří občané z Asie, včetně Turecka, největší skupinu přistěhovalců a podle údajů národní agentury pro statistiku Norska (SSB) jich žije ve městě více než 62 985.
Následují občané EU, EHP a Spojeného království, kteří tvoří druhou největší skupinu a tvoří téměř 10% obyvatel města.
Afričané tvořili třetí největší skupinu imigrantů v Oslu, přičemž v Oslu žilo 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, což činilo 15 566 obyvatel Osla.
Odtud se počet skupin výrazně snižuje.
Například v roce 2022 bylo jen málo nad 7000 občanů ze zemí Jižní Ameriky, zatímco více než 3000 občanů pocházelo ze Severní a Střední Ameriky.
Mezitím v Oslu bylo méně než 700 lidí z Oceánie.
Alna, která se nachází na severovýchodě města, byla čtvrtí s největším počtem cizinců.
V roce 2022 tam bylo registrováno 18 257 cizinců.
Následně má módní Grünerløkka, která se nachází dostatečně centrálně, druhý nejvyšší počet cizinců s 17 631.
Ve starém Oslu také žilo značné množství imigrantů, 17 631 lidí, kteří se tam stěhovali z jiné země.
Údaje norské statistiky ukázaly, že cizinci byli rozptýleni po všech městských čtvrtích, neboť v Søndre Nordstrand, nejjižnější čtvrti v Oslu, bylo registrováno více než 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo v vyhledávaných oblastech, protože Frogner byl čtvrťí s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okrsků v Oslu s největším počtem obyvatel z cizích zemí.
Na druhém konci spektra bylo pouze 184 cizinců, kteří Marka nazývali svým domovem, a jen něco přes 700 lidí žilo v centrální části města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní okresy s nejmenším počtem cizinců.
Nicméně v těchto okrscích bydlelo výrazně více přistěhovalců než v centrálním Oslu a Marce.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili ve Frogner, Grünerløkka, Gamle Oslo a St.
Zatímco v Game Oslo žilo mnoho občanů z Asie, včetně Turecka (5 837), většina byla registrována jako obyvatelé městských částí Alna, Stovner a Søndre Nordstrand.
Staré Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkka a Søndre Norstrand.
Ty ze Severní Ameriky byly poměrně rovnoměrně rozloženy napříč Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky byli nejčastěji nacházeli ve Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království bývali většinou v nejcentrálnějších městských čtvrtích Ullern, Vestre Aker, Nordre Aker a Stovner.
A nakonec, z několika stovek státních příslušníků z Oceánie byly Frogner, Grünerløkka a Gamle Oslo obcí s nejvyšší populací těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
Florence Tanová
BENGALURU (Reuters) - Zimbabwe začne do března provozovat novou jednotku v své jediné uhelné elektrárně, říká náměstek ministra energetiky země, který poskytuje úlevu milionům občanů otřesených častými výpadky proudu v posledních měsících.
Nová jednotka elektrárny Hwange zvýší instalovanou kapacitu afrického národa o více než 14% na 2400 megawattů.
Další jednotka by měla být uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časový harmonogram.
Méně než polovina z 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení na financování nových uhelných elektráren omezila schopnost země zastavit chronické výpadky energie, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době generujeme mnohem méně, asi 1000 MW", řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je kolem 1700 MW, takže máme vážný deficit", řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediného desetiletí starého uhelného zdroje se časem výrazně snížila, zatímco poptávka po energii v posledních letech vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond počítá nedostatek elektřiny jako jeden z hlavních faktorů, které ovlivňují vyhlídky na růst v Zimbabwe.
Nedostatek finančních prostředků na výrobu elektřiny z uhlí vede ekonomiku závislou na těžbě a zemědělství k tomu, aby dovážela nákladnou energii z regionálních sousedů, včetně Zambie a Mozambiku.
(Psaní: Sudarshan Varadhan; Redakce: Jacqueline Wong)
(PERSON11) Ale pro některé složky, z nějakého důvodu, je zvukový formát špatný, takže, něco je špatně
V podstatě, velký obchod, nebo něco je špatně.
Takže, některé soubory jsou stále  mají divný výstup.
Ale, ale pro většinu složek by to mělo být v pořádku.
Dobře, díky.
Jo, to je skvělé.
Podporuji to, je skvělé, že jste si mysleli na [ČLOVÁK7].
A teď má čas.
Jsou další věci, na které jsem myslel, a to by bylo trénování prázdných systémů, aby ty ukrátely.
Takže pokud jste měl čas...
Očividně to nemůžeme udělat do příštího týdne.
Ale měli bychom mít systém připravený na
Podíval jsem se na instrukce z NLP, že ano?
Ptal jsem se na poptávku, protože jsem viděl demo projektu (meme).
Mají offline titulky.
Takže to je o něco jednodušší, než to, co děláme my.
Stále mají stejné problémy s segmentací a tak dále.
Ale jejich poslání v překladu se zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro neslyšící.
Takže je to jako přirozené zkrácení dat.
Bylo by skvělé, kdybychom také mohli lokalizovat takový typ dat, kde dochází k nějakému přirozenému zkrácení.
Dali bychom to do architektury.
To chce trochu času, protože musím zjistit, kdo z vás je ten, který dostane lístky.
Takže, když to budu vědět, můžu to sledovat, takže do budoucna...
Nebo vlastně v budoucnu nebudu potřebovat, protože jakmile budu mít webový soubor, nebudu muset udělat konverzi.
No, tohle by mělo být...
Slyšíš mě?
Kvalita zvuku je trochu horší.
Takže tohle by se mělo dělat pořád.
Takže pokaždé, když provádíme toto hodnocení, mělo by být provedeno od začátku.
Takže pokaždé by měl být čerstvý stažení nové konverze a nové hodnocení.
(PERSON8) Ale přesto, když sleduji soubory, které potřebují být manuálně převedeny, tak můžu napsat skript, který by se mohl postarat aspoň o ty známé a samozřejmě, pokud přidáme nějaké nové soubory, mohu to zjistit později.
Takže tohle je důležitá věc, kterou jsme měli poznat už před několika měsíci.
Pamatujte, že od srpna vám říkám, že chceme vyhodnotit na příštím testovacím setovi.
A pokaždé, vy všichni...
Není to jen o vás osobně, [Osoby 8].
Samozřejmě byly i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si: "To bude jednoduché, prostě to zkusíme".
A teprve když to opravdu uděláte, uvidíte všechny problémy.
Takže tohle je známé, běžné.
Vždycky je to tak.
Takže to je zpráva pro všechny.
Než to zkusíš, nikdy nevíš, jaký bude problém.
Takže například ten hovor, který jsem měl, kdy mě někdo vyslýchal, a chtěl nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes při nahrávání.
Takže než to uděláte, nemůžete říct, jestli to bude fungovat nebo ne.
A tady se potýkáme s problémy konverze formátů souborů.
Takže doufejme, že budeme schopni rychle získat čísla.
Takže, máte zatím nějaké chybové počty slov?
Ne, nezpracovala jsem to.
Takže [ČLOVEK 1] řekl, že jakmile dostanou záznam, uděláme to společně.
A pak, souhlasím, že v tomhle slovníku je hodně hluku.
Takže jsem požádal, abyste měli různé verze tohoto slovníku, vybrat pouze slova, která byla pozorována, pětkrát.
A jen výslovnosti, které byly pozorovány třikrát nebo více, nebo něco takového.
Takže, tímto způsobem, tyto náhodné chyby, jako například s těmito čtyřmi IBM místo IBM.
Tohle nebude tak časté.
A stále budete mít varianty v výslovnosti, protože pokud osoba, řekne toto "alzo", pokud si to pamatujete, říká-li toto "alzo" s "Z" 20krát v v rozhovoru, pak to uvidíte v datách s "Z".
A pokud se mu někdy podaří říci i správně, pak ano, opět, uvidíte to v datech.
Takže bych rád, aby [ČLONKA4] byla v kontaktu s [ČLONKA2].
Možná budete pokračovat v hovoru, že?
Budu muset odejít, protože musím dát dětem oběd a tak dále.
Ale prosím, zůstaňte na telefonu a společně vymyslete, jak použít ten slovník.
Takže [PERSON4], prosím, ukažte [PERSON2], jaký slovník systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte převést slovník, který jste emitovali do toho souboru.
Jedna věc, která bude stále potřebná, je náhražka jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, která slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu by měla být jednoduše kopírována.
Takže slovník bude mít tři sloupce.
Grafém, jak je vypuštěn.
Jeden známý.
Fonémy, jak navrhl [PERSON2].
A bude tam několik řádků s různými zvukovými variacemi.
A třetí sloupec bude stejný pro všechny tyto a bude mít stejnou grafémovou formu.
Takže to je to, co vidí jazykový model.
A myslím, že tímto způsobem by tyto systémy měly být schopny to nahrát.
A možná také narazíte na jeden další problém: že není připraven na dva velké vlastní slovníky.
A to je také něco, co je třeba otestovat, ale zkuste to, prosím, vy dva společně.
Takže [PERSON2] ví, co v slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a musíte dát tyto dva kousky poznání dohromady.
Ah, takže to funguje s generovaným slovníkem.
Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
Jasně, promluvíme si o tom.
- Jo, takže je ještě něco, co máš?
No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časové značení.
Nejsem si jistý, jak dobrý to bude, protože se to snažím udělat na (Libry) Speech.
A když jsem si to stahoval, tvrdili, že má více než 600 hodin.
Ale pak v tréninku řekl, že skutečný výcvik obsahuje jen asi 300 hodin.
A stále si nejsem jistý, jestli tyto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo české jsem pozoroval strmější konverze.
A teď to nebude měnit tak rychle.
Takže, když si vezmeme nějaké vzorky během výcviku.
Pak jsou ještě nějaké vážné chyby v výstupu ASR.
Takže doufám, že pro časové značení je to dost dobré.
Nebo bychom to aspoň mohli zkusit.
Dobře, to je dobré, jo.
Takže jsem začal, ale myslím, že jsem vám e-mail nikdy nedokončil, protože jste mi připomněl, že váš projev nezákaznosti ještě není integrován.
A myslím, že je to také důležitá zpráva pro [osobu 5], která zase zmizela z hovoru.
A důležitým zprávou je, že ano, je velmi dobré, že se aktivně snažíte, aby vaše výsledky byly integrované, a každý by to měl udělat.
Zároveň potřebujeme mít nastavení, abyste to mohli integrovat a testovat sami.
Říkám tomu "integrace na vlastní pěst".
Takže, [PERSON8], když pracujete s [PERSON5] a zdokumentujete, jaké jsou nastavení, ujistěte se, že je dostatečně dobře otestováno kolegy, jako [PERSON4] nebo dokonce [PERSON9] pro kontrolu modelu jazyka a každý jiný.
Takže kdykoliv někdo vyvine novou užitečnou součást, měl by mít k ní přístup relativně snadno, aby ji mohl sám otestovat.
Takže tato integrace na do-it-yourself je důležitá, protože jinak to všechno zůstane na vás, a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, což už bylo provedeno.
[PERSON4], že jo?
Filtrování nadávek, bylo testováno na deníku?
Myslím, že ano.
Jo, myslím, že to bylo testováno na polích.
Takže, teď je čas to otestovat na živých trubkách.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, takže ho [PERSON4] spustí on sám, některé z pracovníků a živě odehraje některé problémové soubory, jako použití [PROJECT8] nebo cokoliv.
Prostě je zahraj.
Sledujte zvukový výstup na vašem přístroji a uvidíte, jak to funguje.
Protože jen při opravdové montáži se objeví skutečné chyby.
Je důležité to nejdříve odstraňovat, pomocí logových souborů, a pak je důležité to odstraňovat v pipeline.
A pokud toto odstraňování chyb může dělat autor té složky, tady, v tomto případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Takže, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou, jako do-it-yourself integrace.
Jo, takže pro angličtinu s různými přízvuky.
Takže teď to [PERSON14] spojíme do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje je, že vytvoří nové věty se slovy, které byly vysloveny v jiných větech a provede to s různými řečníky.
Takže to budou opravdu věty pro více mluvčích, a proto by se také mohla zlepšit odolnost různým přízvukům těchto mluvčích.
Takže to je jeden experiment s částicemi.
A později možná budeme dělat něco víc s tím multi-akcent.
Takže tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní model jazyka.
Takže systém ASR musí vidět co největší možný soubor vět.
A my vytvoříme nové věty z jazykového modelu pouze s textem, přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost pro různé mluvčí by byla také lepší.
A včera jsem slyšel další nápad.
Bylo to během tréninku.
Vypouštěli z zvuku časové pásma a frekvenční pásma.
Takže, trénovali na narušených vstupů, a to také výrazně zlepšilo robustnost systému.
Každý jiný může pracovat na tom cizím přízvuku.
Dobře, další věc, kterou jsem si všiml, je, že je to v pondělním testu.
Je zdůrazněno čtyřikrát.
Takže, když se nějaké sezení děje, potřebujeme jména a terminologii pro tuto sezení.
Musíme ji sbírat, připravit ručně, vytvořit ji.
A tato ruční tvorba by měla být co nejvíce podporována automatickými nástroji.
Takže v tom je určitá dovednost, kterou je třeba procvičovat.
Takže, jsem dost schopný v míchání textových souborů.
A kdykoliv vidím někoho z vás, jak to dělá, tak mám v mysli vždycky tip, co by se mohlo udělat rychleji.
Možná to pro tebe není rychlejší, ale aspoň bys to měl zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jediná osoba, která to může udělat, je [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoct s okamžitou adaptací domény, s zpracováním dat, dejte mi vědět.
A pak potřebujeme...
Takže jakmile jsme získali slovník termínů a jakkoli zřetelné vyslovení slov, potřebujeme techniky, abychom tyto slovníky použili v systémech.
Takže můj dojem z domény adaptace, kterou [PERSON9] pečlivě prováděl pro všechny sezení, byl ten, že to nebylo viditelné v hybridní ASR.
Tak, jeden takový sezení se opět stane tento pondělí.
[PERSON9] již začala s shromažďováním dat, ale rád bych viděl prospěch této doménové adaptace v [PROJEKTU 5].
Tedy možná [PERSON9] a [PERSON8], protože se učí jak zvládat doménovou adaptaci a [PERSON14], protože se učí, jak pracovat s [PROJEKT5].
Kdybyste se vy tři mohli sejít a zkontrolovat, co dělá Projekt 5 s...
Není to [PROJEKT5], vlastně, doménová adaptace je pro [PERSON18] soubor nástrojů, že jo.
Takže to je trochu zpětný pohled, ujistit se, že starý přístup funguje.
V současné době je naprosto nemožné provést žádnou doménovou adaptaci pro plně neurální ASR.
Takže to, co zvažuji, je mít nezávislé vyhledávání klíčových slov z zvuku a nějaký postup sloučení.
Takže můžeme mít dvě ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení pro doménový [PROJEKT 5], které se používá pouze k nalezení klíčových slov.
A když vidíme klíčové slovo v doménově upravené verzi, použijeme tu větu z [PROJEKT 5], která je obecně horší, ale obsahuje správné termíny.
Takže to je můj návrh, co bychom mohli udělat.
Dalším návrhem je, že bychom měli mít vlastní plně neuronální ASR a dělat různé experimenty se jemným laděním a tak dále.
Mluvili jsme o tom s [osobou 14].
A, [ČLEN 14], máte nějaké novinky od potenciálního kolegy nebo přítele?
Jo, takže pokud je tu ještě někdo, kdo by to chtěl zjistit, dejte mi vědět nebo mě kontaktujte.
Takže to je něco, co by bylo všeobecně akceptováno jako papír, protože to lidé ještě nedělají.
A to je ten nej naléhavější problém dnešní doby.
Takže bychom tam opravdu mohli mít vliv.
(ČLOVÍKA6) Jo, asi jsem jen přemýšlel o tom, jaké druhy dat teď používáme, protože například pokud zkontrolujete modely [ORGANIZATION4] na [ORGANIZATION5] že jsou už dost dobrý v těchto věcech...
A myslím, že kdybychom jen...
Mohli bychom z nich získat data, protože máte tak velký soubor videí, v podstatě s různými doménami a různými rodilými jazyky mluvčích v [ORGANIZATION5].
A já měl nápad, že bychom mohli použít nějaký nástroj k stažení některých filtrovaných videí z [ORGANIZATION5] a udělat z nich výcvikové testy.
Takže to mám v plánu udělat sám.
Plánuji tam jít, ale potřebujeme zálohu.
A také pro [PROJEK210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, ten archivář, aby jsme tu schůzku znovu neztratili.
A důležitější a stále přetrvávající téma, na kterém se pracuje, je lezení po žebříku.
A navrhl jsem zde v odstavci pro [PERSON2], že bychom mohli použít jednoduché HTML tabulky, které by byly autogenerované a které by rostly.
Myslím, že by bylo pravděpodobně nejjednodušší dát tabulky jako html, ale může to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnoceny po každé nové hodnotící kampani.
Může být obtížné připravit tyto stoly.
Takže, požádala jsem [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Aby nám řekl, zda [ORGANIZATION242], což je webové řešení.
Nějaká začínající firma, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
OK, takže [ORGANIZATION242] není doporučena [PERSON7].
Takže jednoduchý HTML je pravděpodobně ta správná cesta.
Takže, jakmile [Person2] tyto hodnocení vyčistí.
Takže to znamená přesunout pár skriptů tam, kam patří ze zkušební sady [PROJEKT3] a nějakého automatického běžce.
Potom také vytvořte konverzi z tabulek do html podobně jako technické přeměny a pak tyto výsledky pravidelně na své webové stránky.
Nebo co byste mohli udělat, je mít kompletní git check out přímo umístěný v tomto veřejném html nebo singling z tohoto veřejného html.
Takže by byl okamžitě přístupný přes web, a každý by se mohl podívat na aktuální skóre a prozkoumat to.
Takže by to bylo užitečné, zejména pro m lidí mimo [ORGANIZATION2] jako [ORGANIZATION15].
Víme, že mají...
Výkon některých souborů byl špatný a mohli je přímo procházet na webu.
Mohou jej také prohlížet na [ORGANIZATION101].
Je to na vás, jak to nastavíte tak, aby bylo uživatelsky přívětivé a snadno sledovatelné.
Dobře, udělám to.
Jo, díky.
Teď pracuji na, nebo aktualizuji, předložení demo papíru, které mám dát příští pátek, pokud se nemýlím.
A pak mám nějaké projektové zprávy a začínám shromažďovat dokumenty - jako, nebo odkazy na dokumenty, zatím ne samotné dokumenty, pro dva sezení.
Pro ASR bychom měli přidat doplňkovou metrikou -
V podstatě bychom měli přidat doplňující metriky.
Takže, zmiňovali jste jeden a to je filtrování nadávek m hodnocení.
Takže <parallel_talk> má explicitní seznam věcí, které se nesmí objevit ve výstupu <parallel_talk>, že?
A pak hodnocení vzácných slov.
A zde máme explicitní seznam jmen a termínů, které chceme, aby se objevily ve výstupu, zaznamenané nejenom podle (řídění) frekvence, ale zaznamenané něčím, co přímo zachycuje tyto věci, že?
Ano, takže s tím naprosto souhlasím.
To zahrnuje i ruční přípravu odkazu.
Takže <parallel_talk> oba potřebují manuálně vytvořené odkazy. </parallel_talk>
Mám jednu poznámku od [PERSONA1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladatelský slovník.
A měla by se o to brzy podělit.
Takže to by se mohlo stát prázdnou částí druhé věci z toho vzácného slova -
Takže <parallel_talk> tohle by bylo vzácné slovo vyhodnocení pro MT a pak z [PROJEKT210] také pravděpodobně dostaneme nějaký slovník. </parallel_talk>
Takže to by byla doména [PROJEK 210] samozřejmě.
A [PERSON2], mohl bych vás požádat, abyste revidovali <nepřehledněný/> doménu a vytvořili takový slovník tím, že se podíváte na výstupy a co chybí v výstupy.
Jako třeba shortlisting - seznam slov, která se nám líbí a nelíbí se nám v doméně <nerozumitelných/>.
Mohl bys to udělat?
Mělo by to být proveditelné, tak to zkusme.
Bylo by skvělé, kdybys to dokázal.
Takže si to napíšu.
Takže, <parallel_talk> se zaměřujeme na [ORGANIZATION62] termín s titulníkem studijního papíru. </parallel_talk>
Ano <parallel_talk> a pak pak multi-zdroj s [PERSON7] nebo na základě [PERSON7] nebo - </parallel_talk>
A pokud jde o Language ID, zajímalo by mě, jak přesně to chcete integrovat, protože to již zahrnuje zvážit více zdrojů ASR, více kanálů, takže jaký by byl případ využití pro Language ID?
Jak to zapojíme?
(PERSON13) Bude to audio na textu pracovníka, a bude emitovat časové razítka jako pro čtyři nebo dva sekundové okno a třídu.
<nepochopitelné/> ticho, čeština, němčina, angličtina, a pak budu nechat ostatní, jak to chtějí použít v potrubí.
To je důležité.
Prosím, napište to sem do dokumentu tohoto <nesrozumitelného/> shrnutí, protože je to pro [PERSON2].
A také [PERSON 2], když mluvíte s [PERSON 10], a možná také [PERSON 5].
Pokud máme tento nástroj, musíme (odeslat) audio na více ASR nebo více pracovníků <nerozumitelné/>
Budeme muset odděleně (poslat) audio do anglického ASR, odděleně do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také, k tomuto jazykové identifikace pracovník a pak musíme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je multi-source nástroj, který bude pozorovat textové výstupy a také sledovat časové razítky a vydává by... pravděpodobně by produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby byl ASR tichý, pokud je nesprávný jazyk, a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem si to vymyslel.
Další nastavení by bylo, že stejný zvuk by byl posílán do ASR a tohoto jazykového kontroláře.
Tento kontrolor je v podstatě součástí ASR, který ASR umlčí, pokud je to špatný jazyk.
To je taky možnost.
Takže musíme zjistit, který způsob integrace jazykového identifikátoru je pro naše účely nejlepší.
Takže, prosím, přemýšlejte nad tím, jaké jsou naše potrubí.
V ideálním případě, myslím, že menší typ zmatků vedení a tak dále by vzniklo, kdyby naše modely MT byly vícejazyčné.
Pokud podporují různé zdrojové jazyky a překládají z některého z těchto jazyků do angličtiny.
Mohli bychom udělat jen kopii, pokud by angličtina byla uvedená jako vstup, takže bychom měli vícejazyčné ASR na začátku.
Všechny do angličtiny, a pak z angličtiny do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, toto jazykové ID ani nebude potřeba.
Jde o to, že pokud budeme provádět analýzu správně, jedna věc je možné vzájemné hodnotění, jen abychom naznačili, že omezení skutečně mají dopad na skutečný výstup.
To by bylo hezké a ano, možná analýza pozornosti.
Ale nejsem si jistý, že by nám to mohlo dát stejné odpovědi, v podstatě, pokud model IF je nebo není součástí omezení.
Musel jsem se podívat na pár příkladů pozornosti, neudělal jsem žádné statistiky nebo tak něco, a to se dívá na omezení, a když je převedla omezení, vypadá jako omezení dané, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti to dělat nic v tomto smyslu.
Dělá některé obecné překladové chyby, ale ne ty, které se snažíme vyřešit.
No, vraťme se zpět k automatickému hodnocení, problém s nesouladem je, že výstup je správně zakroužený, ale kontext je jiný.
Takže to není stejná forma slova jako v odkazu, že?
Jo, ale taky jsem zkontroloval, zda jsou kontexty platnými překlady, a ve většině případů jsou.
Stejně jako u prvních 100 příkladů, které byly označeny automatickým hodnocením jako chyby, bylo 91 z nich správně skloněno ve správném kontextu.
A myslím, že jen dvě nebo tři věty byly správně zkresleny v nesprávném kontextu, jako že překlad byl špatný.
A pak jsou některé případy, kdy překlad byl úplně špatně, protože věta byla opravdu špatná, a část musí být <nepochopitelná/>, ale to byl jen jeden nebo dva případy.
(PERSON3) Ale vy se snažíte shodovat s přesměrováním form, když to hodnotíte, že?
Neuděláš nic...
(PERSON3) -lematizace odkazu a
Oba, oba, oba, oba, shoduji povrchové formy a lemma.
Aha, ano, to jsou ty dvě partitury, že?
(PERSON4) To je jen dilema skóre pro (evropské?) není v tabulce, protože na tabulce jako nebude zapadat do papíru tak <nepochopitelné/>
Pokrytí je vždy jako 97 procent.
Jenom generuje správné lemmy, jen...
Jo jo, dobře, chápu, chápu.
Takže lemma pokrytí říká, zda je zde omezení, a rozdíl povrchového pokrytí naznačuje, že by mohlo být nesprávně ohněm, ale to není tak.
O ano, jen nevím, jestli jste si to, když jsme mluvili o [osobě1],
Ale jedna věc je, že (dup) je lepší, ale druhá věc je, že lemma jsou vlastně správně sklopeny ručně,
Ale tohle je něco jiného, ne, žádný problém, je to vlastně dobré, že je <nerozumitelné/> správně, jo.
Tak jsem si říkal, že by mohlo být.
Ale nejsem si jistý, jestli pro to máme nějaké testovací údaje, ale mohli bychom zkusit zahrát si s modely s nějakým stylem přenosu?
Jak víte, můžeme použít omezení a pokusit se použít synonymní omezení a vidět nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to jen popsal nejasně, protože sám nemám přesnou představu, jak to udělat, ale mohl by to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte něco o přenosu stylu z anglicky český?
(PERSON4) <nepochopitelný/>
Dusan, tím, že by to bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, bylo by to v mluveném jazyce nebo tak nějak?
(ČLOVE3) No, to je věc, jako že mám jen omezené znalosti o tom úkolu.
Ale mohu si představit, že chcete přepsat větu, kterou nenapsal muž, ale napsala žena nebo, nevím, jako můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámena s přesnými datovými sady a s tím, co pokrývají.
A myšlenka je, že styl vět je velmi nejasně definován.
Takže znovu, nejsem si tak jistý.
(PERSON1) Máme tento soubor proměn vět.
A jedna věc, která tam je a může být označena jako přechod stylu, je například generalizace vět.
Takže, detaily jsou vynechány, věta je zjednodušena a pak se věta zní hovorově.
No, jen parafrázuji.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení Matous provádí nějaký experiment s angličtinou a českou, ale nemáme žádné referenční údaje.
Takže nemáme žádný datový soubor pro kompresi vět.
Takže možná generalizace by mohla být zajímavá, ale obávám se, že existuje příliš mnoho různých dobrých generalizací, takže jediná referenční generalizace by byla příliš omezená, aby vám řekla něco o kvalitě vaší generalizace.
Nejsem si vědom jakékoliv podobné transformace pohlaví, například tohle by mohlo být provedeno <nepochopitelné/> pro češtinu, takže možná ta správná osoba by byl Rudolf Rosa, zeptat se ho, jestli někdy generoval nějaký takový datový soubor.
Takže zde bude základní generace nějaké věty.
(Person3) Myslím, že je to vlastně zajímavá otázka, zda můžeme použít omezení k prosazení stejného pohlaví řečníka v překladu.
To je vlastně velmi dobrý nápad.
Mohli bychom se na to zaměřit a vytvořit určitou podčást zkušebního souboru [PROJEKT1], která by to pokryla.
No, někdy víme pohlaví mluvčího, takže pokud ano... možná vám dám sdílet obrazovku a prohlédnu si to.
Nebo jsem to zkusil s Marian, která tam byla a je to... nevím, o kolik bodů nižší.
Protože stejně jako já věřím Martin dělá svůj malý <nepochopitelný/> překlad, tak překládá více vět najednou a pak si vybere jen tu střední a dělá tohle pro celý dokument.
Takže kontext je jako v jedné <nerozumitelné/> spolu s větou, kterou chceme přeložit.
(PERSON10) Jo, myslím, že to nebyl Dominik, co dělal nějaké experimenty s Ivanou?
Myslím, že před rokem nebo dvěma lety kvůli dvojitému prázdnému, kde se zabývali kontextem nebo propojováním kontextu se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Jde o to, že si nejsem úplně jistý, zda to má stejný efekt jako při nastavení mnoha kódů.
(PERSON1) Jako každý je jiný, to je určitě jiný výpočet, jiný vůdce, ale jsem překvapen, že [PERSON8] říká, že to nefunguje.
Jo, jo, tak promiň, možná bych měl být korektnější, že to nefungovalo tak, jak jsem to udělal.
Ano, protože si myslím, že je to metoda která je velmi snadno testovatelná, a měla by být vždy testována v kontrastu se dvěma enkodéry, a očekával bych, že někdy bude lepší a někdy horší než dvě enkodéry nainstalované v závislosti na konkrétním úkolu, jako například, co přesně je ta druhá věc, co je kódována.
Takže pokud máte dvě kopie, dvě parafráze téže věty,
Možná je to nějak zmatené pro pozornost, tak to je jedno, já nevím.
Chování může být také jiné pro staré metody sekvence-sekvence ve srovnání s transformátorem, takže u RNN se pak chovala jinak možná s transformátorem je to jo, je to těžší trénovat, takže možná potřebujete navýšit počet zahřívání a sety zahřívání.
Jo, takže prostě vím, že...
Nepamatuju si, takže si to nepamatuju přesně, ale tohle je jako...
když jsem začal v létě s těmi multi-zdrojovými experimenty.
První věc, kterou jsem začal, bylo spojení parafrázy a zdroje a možná jsem, už si to nepamatuji,
Můžu to zkontrolovat až do další schůzky, jestli jsem to zkusil.
Rozhodně jsem to zkusil, když jsou zdroje na první pozici a pak nějaké omezení a parafráze na druhé pozici.
Možná jsem taky zkoušel, že jsem ty dvě věci náhodně smíchal, jo, pamatuji si, že to bylo spousta kompentrácí a zkusil jsem multi-encoder.
A pravděpodobně to bylo kvůli nízkým výsledkům.
(PERSON2) <nerozumitelné/>, že se vám líbí, můžete zlepšit své hodnocení pohodlí jen přidávat výstupy na bázi fráze a pozornost je jako dvojnásobná diagonální, takže pozornost není problém, takže jako já vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže, pokud pokud zadáte výstup založený na frází, což je v podstatě post-editing, můžete si o něm přemýšlet jako o post-editing, jako byste posunula výstup založený na frázích, nebo to závisí na pohledu, správně?
(PERSON1) <nepochopitelné/> chcete úplně přepsat, ale technicky se to přesně hodí do zadání následné úpravy, můžete to zapojit jako řešení úkolu následné úpravy.
Dobře, jedna otázka jen pro mě, jen abych si byl jistý, že v nastavení přikládání vložíš znak oddělující větu, že jo?
Máte speciální symbol, kterým rozeznáváte, který je zdroj, a který je kontext nebo druhá věta, nebo je jen propojíte, nic nemáte?
A doufat, že se to systém naučí?
Zkusil jsem to s dvěma tokeny a jo, protože v první verzi jsme měli podezření, že token může být také tokenizován sám, tak jsem ho pak přehrával s dalším tokenem, který není jen pro tento účel, protože jsme použili nějaký předběžný slovník, a tento slovník neobsahoval separátorové tokeny.
Takže jsem použil nějaký token, který jsem předpokládal, že nebude na několik částí, takže se objeví jednou.
Neměl jsem žádnou záruku, že se tento symbol nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže se to mohlo udělat lépe, ano, souhlasím.
Ale ten část s Flaskem nebo komunikace s klientem je něco, co nemůžu udělat.
Protože nemám žádné zkušenosti a nemám čas, abych to spustil.
Myslel jsem, že to něco znamená, že použiješ neznámého mediátora.
(PERSON2) Ne, vytvořit HTTP klient, který může zaplnit řadu a číst z jiné řady.
A text pošlete zpět jako HTTP žádost.
Protože můj nápad je, aby se uživatelské kliknutí použilo i v ukrajinském projektu.
(PERSON2) A můj nápad je, že klient klikne na tlačítko v tomto mikrofonu a začne mluvit, a když uživatel mluví, odesíláte zvuk v malých částech najednou.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server ho vložil do fronty, kterou budu později zpracovávat pomocí (ASR).
A model bude dělat nějakou logiku, nějaký závěr.
A kdykoliv bude mít nový kus přepisu, pošle ho zpátky a uživatel by měl získat zpět částečný přepis.
A mělo by se okamžitě zobrazit v textovém poli.
O tom bych mohl přemýšlet.
Ani Flaska moc neznám, ale ano, o tom můžu přemýšlet.
Možná jiný HTTP server.
Nevím, možná ani nepotřebujeme na to luxusní HTTP server.
Pro přenos textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo pro tohle.
Jo, jediným požadavkem je, že by měl zvládnout více spojení najednou.
No, myslím, že online textový tok je něco kolem 2 000.
Mám na mysli skript, který mám ve dvou různých složkách, a pak ho budu spouštět s malými různými vnitřními pracovníky, takže mám na mysli, jo, takže mám <nerozumitelný/> řekněme deset, no, místo výstupu, soubor od <nerozumitelného/> vedlejšího pracovníka, takže <nerozumitelného/> který máme, takže se ujistím, že tyto věci pro jeden soubor jsou generovány paralelně ze všech dostupných pracovníků.
To by nám ušetřilo čas.
Ano, to je velmi důležité, aby se všechno srovnalo. Rovnaložit jak zpracování systémů, tak i hodnocení buněk DF, protože by to musel spustit několikrát, budou chyby, potřebujete to rychle znova spustit.
Dobře, takže díky.
Máte s tím hodně práce, nechci vám dávat na starosti žádné další věci, tak mi dovolte začít s připomínkami.
Musíme dokončit popis [PROJEKT1] stolní sady,
Koho to tu máme?
- No, vlastně ne, jo, a bohužel tady není.
Takže tohle bude pro [přítele 2],
Dále hodnocení, toto je pro [PERSON 1], ale o tom jsme diskutovali.
Poslouchej, dej mi tabulku v DSD, dáme tu tu jemnou čáru a vytiskneme šablonu tabulky, jako strukturu plánu do delebl, takže čísla přijdou později, ale já chci vidět některé čísla a plnou strukturu tabulky velmi brzy.
Dobře, děkuji.
Máme [PERSON5], to je dobře.
Takže, pro [PERSON5], rád bych zkontrolovat, jaký je pokrok v hodnocení systémů, a zda jste v kontaktu s [PERSON1] také pro evoluci, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do Petriho prostředí.
Jo, je tu ještě jedna věc.
Možná není dobrý nápad spojit tyhle dva útoky do jednoho.
Myslím, že je vlastně lepší, když to spustit odděleně a uložit výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromažďujete všechny výstupní soubory, a pak spustíte hodnocení.
A důvod tohoto rozdělení je, že můžete paralyzovat více.
Takže budou problémy na různých frontách, jsem si jistý, a budeme potřebovat čísla velmi brzy.
Takže, pokud například některé z testovacích souborů z nějakého důvodu selžou,
Pak si můžete nechat překlad běžet pro zbývající,
a znovu vyhodnotit, s sel T F, chybějící, a, a tak dále.
Takže, nejde o to vytvořit sériové, sekvenční zpracování, které zahrnuje oba,
Ale hlavní je dostat výsledky, a je lepší to dělat po kouskách.
Nejdřív všechny výsledky, pak všechny hodnocení.
Jo, takže, teď jsem dělal to samé.
Ano, to je to jediné, co jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu komplikovanějšího v dekódování.
Jako filtrování paprsků a jejich nahrazení jinými paprsky.
A pro omezení více tokenů a podobné věci.
Ale za pozitivní omezení jsem porovnal jen tréninkový přístup s jo, jen s velmi jednoduchými věcmi.
Jen měním skóre v každém kroku stejným způsobem.
Dobře, takže zpátky k pozitivním omezením.
Už jste se zaměřil na analýzu systému?
(PERSON2) Jo, právě teď čekám na zpracování datové sady z (PERSON9).
Také jsem se podíval na kód a myslím, že vím, proč je tak pomalý.
Protože u každé položky v terminologii v (Europar) reprocesingu, otevřete datové soubor, tokenizujete ho, čtete řádek po řádku, tokenizujete řádek po řádku a pak ho zavřete.
Ale to děláš jen ty...
Pamatuji si, že pro [PROJEKT1] jsem to dělal v loňském roce z nějaké chalupy v horách.
A zrovna jsem si uvědomil, krátce před Silvestrem, že to musím odevzdat.
A to je také něco, co se stane [ČLOVĚT8] Obávám se, že by mohl být... no, žádná party, ale možná na dálkové party.
A pak si najednou uvědomil, že to musí předložit.
Takže, nebude žádná revize podobná tomu bodu. <smích/>
Prostě si vzal PDF a nahrál ho. <smích/>
Dobře, dobře.
Takže, jo, zkontroluju 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že je lepší jim hned poslat e-mail a požádat o ten link předem.
Dobře.
Jo, díky.
Máme dnes jiné téma, nebo je to všechno do nového roku?
Doufám, že pro mě nic nebylo?
Před několika lety.
MT maratony měly tento systém nebo nástroje, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, bylo integrováno s normálním jako tam také byly PBML problémy které smíchalo prázdné margin papers a samostatné papers kvůli počtu těchto papírů.
A dokonce jsme měli otázku, jestli ten text nebyl dost dobrý pro PBML, ale pokud byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, jak jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, uveřejněte to v MT maratonu mezi lidmi.
Ale tvoje práce je špatná.
Musíte to vylepšit, a dostanete se jen do dalšího PBML.
Ano, ale další možnost pro SIGDial.
Není možné, že pokusem o SIGDial přilákáme lepší účastníky?
To je ano, to je... Tak jak jsem si myslel, že jsem taky, ale já neznám ani jedno z těch míst.
V červenci mají poslední papírovou registraci.
Takže konference byla v září a podání papíru bylo v květnu.
Protože pro Interspeech bychom ho mohli rozdělit papír za papírem.
Abychom mohli nechat nějaké papíry pro Interspeech.
A některé z našich písemností by přišly později pro řízení PBML.
A autoři by si mohli volně vybrat.
Takže to musíme vyjednat s SIGDial nebo Interspeech.
Pokud je v pořádku, aby měly některé z našich papírů, vzhledem k tomu, že tyto papíry jsou předány v březnu.
Takže je tu absolutně přísný požadavek.
A myslím, že nemohou mít nic proti tomu.
Protože jestli ten článek stojí za vydání.
Je to jen bonus, že se některé výsledky společných úkolů objevují v satelitní události.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o zvláštní schůzku.
V Interspechu se tomu říká zvláštní zasedání, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří, aby váš dokument byl připraven do termínu Interspeech, zašlete jej jako dokument Interspeech a obdržíte ho v Interspeech.
Pokud to neuděláte do termínu pro Interspeech, tady je náš termín.
A to je za PBML.
Dobře.
Ale je to jako u satelitní akce Interspeech.
Interspeech se do žádného řízení nedostane.
Můžete si prostě rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít hodně práce a žádný volný čas, i když máte jen jeden předmět.
Ale já si myslím, že je to něco jiného, protože si myslím, že to není moc dobrá věc prohrát jeho kurzy.
Miluješ selhání, protože to nedokážeš dokončit.
Samozřejmě, že lidé to prostě vzdávají, ale myslím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
Ano, myslím, že nám na začátku semestru řekl, že pokud chceme 1, dostanete 1.
Měla byste ho předložit do druhé lhůty.
To je asi jediná věc, na kterou se ptal.
Ale také nám řekl, že podle trendů z předchozích let, to mnoho lidí nedělá.
Je pro ně snazší číst na zkoušku.
Ne, promiň, učím se na zkoušku...
Jo, protože jeho zkoušky jsou docela jednoduché.
Takže bych neřekl, že je to super snadné, protože jsou kurzy, kde je zkouška zábavná.
No, jeden z nich byl včera pro mě.
(Person2) Jo, když má krátký kontext, a protože já dělám rozhodnutí na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, potom se opravdu věnuje něčemu, které například za vteřinu nebo dvě, zjistí oh, no, vlastně to byl špatný překlad.
Takže se snaží použít jiné znění.
Například, určit věc.
Takže se mi to opravdu líbilo.
Byl jsem opravdu ohromen, i když můžete vidět, že model udělal chyby při prvním pokusu, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo plynule, což je podle mě také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nízká kvalita, je to proto, že překlad, pokud si přečtete všechno, dostanete stejné informace, ale znění je prostě špatné, protože používal například více slov a používal nějaké opravy a další věci.
Takže si myslím, že to je naprosto v pořádku pro souběžné připojení, pokud neztratíte žádnou informaci.
A pro které jazykové páry máte tyto výsledky, jako některé příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
Jasně, můžu ti dát svoje deníky.
(PERSON7) Ale v jakých jazycích?
Protože víš, že nemluvím německy.
(PERSON2) Angličtina a němčina.
Jo, ale nemluvím nutně německy.
(Person2) Pak mohu poskytnout anglicky-čínsky a anglicky-japonsky, pokud to pomůže <smích/>.
(PERSON2) Takže znovu, chci, aby to bylo čitelné pro lidi.
Protože tohle jiskření je opravdu otravné a pak ztratíte soustředění na to, co bylo vlastně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a o tom, jak pracujeme s informacemi.
Promiň, nikdy jsem o tom nepřemýšlel.
Ale myslím si, že když vidím slovo, vložím ho do své paměti a moje paměť není lineární, ale spíše je jako pytel.
Tak jsem dal slovo do pytle.
A rád spojuji věci v pytli, abych získal celkový obraz slova.
A myslím, že to je ten problém s tím světlem.
Pokud něco přeložíte a pak to změníte, tak jsem to vlastně už četl, je to v mém mozku.
A pak jsem ztratil soustředění a kontrolu nad tím, co bylo přeloženo jako správné a co nebylo to, co nebylo.
Proto si myslím, že celá ta věc s tím blikacím světlem je špatná a hloupá.
- Jako bych viděl motivaci, jako bys chtěl ukázat všechno, co máš.
I když nemůžeš slíbit, že je to dobré.
Ale myslím, že s těmito dalšími informacemi nemůžeme pracovat.
A myslím, že možná problém je v tom, že systémy vytvářejí lidé, kteří s nimi pracují.
Pokud vyvíjíme systém, pak jsem šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, přesto ho ukazuji a je to nějak dobré, ale myslím, že vývojář se ve skutečnosti nesoustřeďuje na samotný obsah.
A jak vnímáte obsah, ale spíše, že můj systém to dokáže vypustit opravdu rychle.
A i když jen domnívá, že kvalita je v pořádku, myslím, že možná proto byl vytvořen přečtěný překlad.
Jenže vývojáři systémů jsou dychtiví zobrazovat informace, a já si myslím, že protože jsme omezeni v objemu informací, které můžeme určitou dobu vnímat, chceme vidět, že přidělávající informace jsou pro nás jen další břemenou.
Takže si myslím, že není dobré ukazovat se navíc.
Jako když chcete snížit latenci, tak místo blikání, snížte kvalitu.
Myslím, že je to lepší, než ukázat záblesk.
Protože jaký by byl skutečný případ použití?
Proč byste potřeboval vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Technicky, když začínají lidští překladatelé překládat, myslím tím, že cílem, i pro komentátory, je, že by se snažili sledovat řeč původního mluvčího.
Takže jsou chvíle, kdy řeknou něco, a to by bylo špatné, tak by se prostě napravily.
Ale jo, to znamená, že s mým řešením, jako by jste nefoukli, ale jste oddaní, jako že neexistuje žádný způsob, jak se změnit, ale opravit sami.
A to je vlastně to, co překladatelé dělají.
Mám silný pocit, že naše práce není zrovna v doméně řeči, je nezdravá.
Protože zde není žádný pojem řeči.
Pracujeme přímo na textu.
Ale věc je taková, že návrh na statistický workshop byl tento rok u konce, což bylo v září, což bylo pro nás příliš brzy.
A další návrh by přišel v roce 2022, což by pro nás bylo příliš pozdě.
Je lepší, když budeme mít buď z obou sektilních, nebo interspeech, protože oba jsou dobře uznávané v komunitě.
Můžeme motivovat účastníky, aby se podřídili.
Ah, jediné, které teď vidím, že jde o interspeech, je, že nám nedovolí prostor v projednání, což může odradit některé z účastníků, nejsem si jistá, jak moc budou nadšeni, až zveřejní článek v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, že?
Takže to není přínos pro jejich profily.
Takže jak motivovat účastníky, aby se připojili k našemu společnému úkolu?
Takže to byl důvod, proč jsem se za zvláštní sezení zaručil.
Ale tentokrát, problém je, co mohu pochopit je, že posledně, časové období mezi návrhy, podání a finální předložení papíru bylo pět měsíců, takže by to bylo dost času pro náš plán, ale tentokrát.
Jsou to jen tři měsíce.
Takže, vidím tento veletrh jako důležitý zdroj nemilostního hovoru, který můžeme použít k rozšíření testovacího souboru.
Takže si myslím, že bychom se měli soustředit na soutěž nejrozumnějšího hlasu, a můžeme to udělat v chatě, pokud budeme muset.
Ale já bych to rád omezil, protože šíření mezi středoškolskými studenty má pro nás menší dopad.
Je důležitější to použít jako testovací sezení.
Takže bychom se měli zaměřit, [PERSON1], na [PROJEKT2] nejčistší hlas, a udržet organizátory šťastné, abychom mohli dát dohromady data.
A udělat to, co chtějí, abychom učinili výměnou za to, a musíme zkontrolovat jejich plenární program a jaký typ titulků by pro ten plenární program byl užitečný.
takže je to pro nás testovací sezení, a co se týče naší přítomnosti na veletrhu, nemyslím si, že je to příliš důležité.
Takže kdybychom se zeptali, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, tak je to v pořádku, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a za scénou a dělat tu naši práci.
Jo, ještě jsem se nesnažila to zapsat, ale myslím, že posledně bylo povinné mít stánek.
Takže s nimi promluvte o tom, co je potřeba, aby byli šťastní, a dovolíme jim dělat Čistý hlas, což je nejdůležitější věc.
Zkušební sezení je méně nutkání.
A stánek je něco, čemu bychom se mohli vyhnout, pokud je to možné.
Radši bych, aby se k nám připojili dřív, než aby dělali takové věci.
Takže, opravdu potřebujeme cvičit tyto přípravy.
V online světě se zdá, že jednoduše zapnete do sesí, a práce je hotová.
Ale to není pravda.
Vždy trvá 30 minut, než se to začne fungovat a správně napojí.
Takže tam musíme být dřív.
A když nějaká naše konference začíná v devět, ale organizátoři se scházejí v čtvrt na devět.
Pak musíme přijít už v čtvrt na osm, takže máme 30 minut navíc, abychom se ujistili, že všechno funguje a pronásledovali lidi.
Takže tohle je připomínka pro všechny, aby vedení fungovalo, prosím také předvídejte, co by vás vedení mohlo najednou požádat, a to by trochu pomohlo.
Dalším velmi důležitým poselstvím je nahrávání těchto důležitých setkání.
Nevím, jestli jste odpověděli, ale neviděl jsem nikoho, kdo by dodával informace k dokumentu.
Možná jsem vám to zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJEKTU4] a [PROJEKTU5] 2020.
A první bod této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto sezení.
Takže pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, je důležité mít dobré nahrávky těchto setkání.
A jedním aspektem je získat souhlas, aby bylo možné nahrávat.
A i když se pokusíme získat souhlasy zpětně nebo tak něco.
Pak je tu technický aspekt nahrávání.
A viděli jsme, že je to tak rozmanité a složité.
Jo, [PERSON5] posílá ten odkaz.
Poslal jsem ti to e-mailem, pamatuju si to.
2 zkažené citrony v řadě.
Objednal jsem si ho od téhle společnosti, protože jsem ho koupil v předchozích sezonách a fungoval perfektně.
Letos jsem si koupila další velikost, kterou jsem potřebovala.
Jeden z pyžam, které jsem dostal, měl díru na noze.
Vrátil jsem ho a firma mi poslala novou.
Náhradní pyžamo, které kdysi nosil můj syn, jsem ho dala do pračky jako vždycky a zip se mi uvolnil!
Jsem tak zklamaná, protože nemám čas řešit návraty každé několik dní, a přesto se to právě teď děje.
Přesně tak, jak bylo popsáno.
Tohle je základní plášť.
Pokud hledáte základní kabát, pak tento kabát splní vaše očekávání.
Kabát přišel ve vakuově uzavřeném pytli, takže ho musíme zavěsit na pár dní, aby se z něj vynuly rány a trochu se "vypuchl".
Jsem 5 stop 6 palců a kabát je na mě klekatého.
Objednala jsem 2 a více velikostí vzhledem k ostatním připomínkám a zkušenostem v minulosti, a kabát je pravděpodobně trochu větší, než je potřeba.
Ale s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou pouta, takže je asi přidám později.
Kapuce funguje, ale žádné pásky na ní.
Přední zip funguje.
Na boku a vzadu nejsou ventilace na další pohyb, ale s větší velikostí bych měl mít spoustu místa.
Na pasu mám dvě kapsy (na tobě mohou být vyšší nebo nižší).
Žádné ořezání nebo stylové detaily, je to BASIC COAT.
Za tu cenu, myslím, že je to fajn.
Nosila jsem ho ve větrný den, ale ne na chlad.
Necítil jsem vítr, takže to je dobré znamení.
Jsem však zvědavý, jak se bude chovat v chladnějších podmínkách a v dešti/sněhu (může být odolný).
Celkově jsem spokojený.
Větrná taška se dá znovu použít a prodávající připojil do ní také krásný poděkování, což byl skvělý kousek.
To je velmi pěkná sukně.
Ten krajkový vzor je elegantní a jemný.
To je velmi pěkná sukně.
Ten krajkový vzor je elegantní a jemný.
Nezmršťuje se, i když byl nacpaný do plastu a krabice, byl velmi hladký, takže to je vážně super.
To snadno může být oblečena dolů nebo oblečené nahoru, a má druh vintage pocit díky délce a řezu, který jsem opravdu do.
Myslím, že by to mohlo být lichotivé pro kohokoliv.
Mám 160 cm a 130 liber a objednala jsem si tu malou, takže pokud máte pocit, že jste uvízli mezi malou a střední, určitě si dejte menší.
Nefungovalo to s mým Buickem LeSabrem z roku 1999.
Nástroj přišel rychle a vypadal, že je v dobrém stavu, dokonce obsahoval baterií předinstalovanou.
Ale i když by měl být kompatibilní s mým Buickem LeSabrem z roku 1999, ovladač se nedokázal naprogramovat či synchronizovat s autem.
Instrukce jsou dost snadné a vím, že jsem je dodržoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý ovladač.
Tento nový by ale nefungoval, a tak ho vrátím.
Nešlo o žádný problém s prodejcem nebo servisem, jen se zdálo, že tato konkrétní položka je vadná nebo neslučitelná s mým vozidlem.
Dobrá cena za náhradu
Grill mýho auta byl odtržen něčím velkým, co letělo po dálnici, takže jsem ho potřeboval vyměnit.
Bál jsem se, že to nebude sednout, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Nenabýval jsem ho sám, nechal jsem to udělat chlápkovi z dílny, ale vypadalo to opravdu snadno.
Stalo se to za méně než 5 minut.
Dal jsem jí 4 hvězdičky za odolnost, protože vypadá docela křehko (čas a letená troska to ukáží), ale celkově jsem velmi spokojen s tím, že mé auto už nemá na přední straně otvorené zuby a že cena byla rozumná.
Potřeba zlepšení
Super super světlo Moje 5 letý miluje toto světlo, netrvalo to dlouho, dostal ho k narozeninám v lednu je únor už má problémy s tlačítky a ne běží jasný s plug v sežere baterie dokonce pokusil dobíjení baterií Super super cool, ale potřebuje zlepšení
Hudební začátek
Klavír je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí to dobrou koordinaci ruky a oka.
Klavír není jen hračkou, ale ve skutečnosti funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě bylo budoucím pianistou, měli byste tento produkt vyzkoušet!
Velmi stojí za to!
Dávám si to na nos, dvakrát denně a držím si to 2 minuty.
Kůže na mém nose se zarudla a úplně se mi rozšedila.
Byla jsem překvapená.
Měl jsem dobře zahojenou jizvu z pádu do ostnatého drátu před lety.
Nejenže ten přípravek nefungoval, ale málem jsem skončila u dermatologa. Nicméně, po přiložení přípravku Aqua-For a bandaž na to místo, to po týdnu konečně uklidnilo.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo ten vzorec podělal?
To je tak divný.
Při normálním světle to vypadá jako mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslila jsem růžovou čáru pomocí barvy jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejčastější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl nazývat je červené nebo růžové.
Ta bílá není tak jasná, jak jsem doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy odmývají.
Myslel jsem, že tam byla růžová.
Myslím, že fialová bude stačit.
většinou pracuje
Před několika měsíci jsem si celou hlavu zbledila, a pak ji natřila barvou z černé krabice.
Pak jsem si nechal umístit výstřižky po celé hlavě.
O pár týdnů později jsem si na vlasy dala modro-zelenou barvu na vlasy Arctic Fox a neztratila se mi.
Použil jsem to s Olaplexem č. 3 a to ohromně osvětlilo celou tělo, a odstranilo zelené a modré části stejně jako tmavé tyčinky.
Po jednom dni jsem si však všiml, že moje vlasy mají zelený odstín.
Každý den je to horší a už jsem použil extractor barvy dvakrát, s stejnými výsledky.
Taky mám tmavší vlasy tam, kde byla ta barva.
Tohle je skvělý produkt, ale zdá se, že nevydrží dlouho.
Nevěřte tomu.
Příliš mnoho pětihvězdičkových recenzí na tento román musí být zklidněno několika realistickými hodnoceními.
Snažil jsem se to přečíst, ale jazyk byl prostý.
metafora "sladké vody" a mnoho popisů dělohy jako řeky a dítě jako ryby vypadalo nuceně, zastrašováním a vymysleně.
Přeskočil jsem to a vypadalo to, že všechno, co bych našel, bude kampusní drama.
Dávám této knize 10 hvězdiček!
Skvělé čtení!
Tu knihu jsem naprosto milovala!
Za ty roky jsem adoptovala 4 siamské kočky od Siri a všechny byly naprostá láska.
Jakmile začnete číst tuhle knihu, je těžké ji odložit.
Zábavné, vtipné a velmi zábavné!!
Siri šla přes hranice ve svém úsilí zachránit kočky (hlavně siamské)!!
Tohle světlo se mi líbí!
Je to báječné za tu cenu a dělá svou práci!
Jediný problém je, že žárovka se příliš rychle zahřeje a světlo zhasne, takže ji musím vypnout a chvíli počkat a pak zase zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám poškozenou světelku, nebo co, ale kromě přehřátí je to velmi hezká kruhová lampa.
Zmatený příběh
S knihou bylo těžké držet krok, protože se hodně skákala.
Také název nezapadá do příběhu.
Autor uvedl, že několik lidí bylo infikováno mimozemšťany, avšak ponechal podrobnosti o tom, kdy nebo jak se to stalo.
Občas jsem byla zmatená a musela jsem se vracet a hodně číst, abych se ujistila, že jsem nic nezmeškala.
Milovaný Collins...
Chvíli trvalo, než jsem se Gradyho dostal.
3 1/2 hvězdy Remedy je romance mezi nejlepšími přáteli, stejně jako druhá šance smíšená do jednoho.
Je to unikátní příběh a hrdina (Grady) musí udělat všechno, aby dostal Collinse zpět a dokázal, že je pro ni tím pravým mužem.
Před třemi lety měli Grady a Collins spolu úžasnou noc.
Collins si myslela, že konečně má vše, o čem snila, svého bratra nejlepšího přítele, ale když se ráno probudila sama a nikdy od ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpátky, a neodejde, a dělá všechno, co je v jeho silách, aby jí dokázal, proč odešel, a že ji tentokrát neopustí.
Zatímco já miloval předpoklad tohoto příběhu, a někdy Grady, on opravdu dostal na mé nervy.
Úplně chápu, proč odešel, ale ani neposlat dopis Collinsovi, kde by se vysvětlil?
Zanechat ji trpící a zraněnou po ty roky a pak očekávat, že ho přivítá s otevřenou náručí?
Byl blázen?!
Collins měl pravdu, že byl naštvaný, naštvaný, zraněný, atd.
Měla pravdu, když se s ním bojovala, když ji chtěl zpátky a šla dál.
Obdivuji její vůli, protože Grady byl vytrvalý.
Miloval jsem Collinsovou v téhle knize, byla silná a střežila své srdce a obdivoval jsem ji za to.
Jasně, že Gradyho milovala, ale bála se a váhala ho pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně si vše dělala tak, jak chtěla, a když byla připravena naslouchat, tak naslouchala.
V této knize je hodně úzkosti a líbilo se mi sledovat, jak se ti dva znovu spojili, když Collins začal odpuštěním Grady, jen jsem si přál, aby Grady nebyl tak nářkavý, a byl trochu chápavejší.
Pořád říkal, že mi rozumí, ale občas na mě přitiskl, a pak na konci byl sladký.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla velké problémy s jeho názory, protože jsem se nemohla spojit s jeho postavou.
První část knihy nebyla moje oblíbená, ale ta druhá část?
Zbožňovala jsem ho, odtud můj rating.
Jestli máte rádi druhou šanci a románky s nejlepšími kámoši, možná se vám tahle kniha bude líbit, jen jsem si na začátku trochu ztěžovala Gradyho s tím, jak si vzali věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho portrétu Churchilla.
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho portrétu Churchilla, bylo velmi dobře provedeno.
Změrný časový rámec od 10. května do 26. května byl dobře prezentován s tím, že hodiny 7 otáčí stránky...
Scéna a kostýmy byly vynikající.
Je dojemný, že dnešní dvojice polobohů drží světové politické pozice.
Stojí za to se na to podívat několikrát... Stojí to za přemýšlení... A ještě víc.
Vyhněte se Wifi připojení, přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme se právě stěhovali a bydleli v hotelu.
Nedokázal jsem dostat tuto váhu k Wifi v hotelu.
Rozhodl jsem se počkat, až se nastěhujeme a můžu si nainstalovat vlastní Wifi systém.
Březen 2018- Nastavil jsem WiFi systém a ta váha se stále nepřipojí.
Pokaždé, když to zkusím, dostanu chybovou zprávu.
Dokonce i když jsem 10 metrů od Wifi jednotky.
Sledoval jsem video na YouTube, ale bez úspěchu.
Když jsem si ten telefon koupil, myslel jsem, že se spojí přímo s telefonem mé ženy (jako Bluetooth).
Místo toho, tato váha používá Wifi router k komunikaci s telefonem.
Tento systém je omezen na připojení router... který není obvykle blízko ložnice na rozdíl od mobilního telefonu!
Nedoporučoval bych tuhle váhu nikomu kvůli Wifi připojení.
Místo toho se podívejte na systémy, které používají Bluetooth pro komunikaci.
Tohle nahrazuji přes Bluetooth.
Dobře, ale rád bych našel něco lepšího.
Po dlouhém výzkumu, jsem začal používat tento produkt před mnoha lety.
Měl nejmenší množství škodlivých složek a stejně fungoval.
Nicméně, suší to tak rychle, že nakonec použijete tolik lubrikantu, což nakonec stojí hodně peněz, stejně jako to je příliš rušivé během sexu.
Byl jsem jen příliš lenivý, abych hledal nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš drahý.
Životnost baterie je hrozná na tom, co jsem koupil na Amazonu.
Pořád nemůžu uvěřit, že Logitech přerušil výrobu tohoto ovladače, nic jiného se tomu ani nepřiblíží.
Tenhle dálkový ovladač Harmony miluju, je to můj čtvrtý.
Pes rozžvýkal první, manžel klekl na obrazovce druhýho a ty třetí stále fungují, ale uprostřed dotykové obrazovky je znak loktu, což se také ukázalo u manžela...koupil jsem to jako zálohu a obrazovky jsou skvělé, ale baterie s ní je nabitá možná několik dní.
Moje původní (třetí) je nabitá po celé týdny a na všechno používám dálkový ovladač.
Zkrachoval za méně než týden.
Líbí se mi ten výrobek, je pěkná velikost a barva!
Bohužel měl jen týden a otevřel jsem jedno dveře a rozbil vrchol toho kusu dřeva!
Jsem opravdu zklamaná!
Vše je sestavené a já už nemám krabici, tak jak bych mohla dokonce přemýšlet o tom, že ji pošlu zpátky?!
Můj manžel to zkusil opravit lepidlem na dřevo, ale bohužel to taky nefungovalo!
Dveře se zase otevřely!
Není to snadné sestavit plus...
Po sestavení je to hezký kus nábytku, ale bylo to těžké.
Některé znaky byly chybně označené, tak jsem se musel snažit vyřešit to sám. Šrouby, které dodávali k upevnění podlahy a bočních panelů, byly všechny prasklé.
Musel jsem jít ven a koupit rohové zábradlí, abych se ujistil, že zůstanou pohromadě.
Také skleněné dveře jsou mimo linii a nesouhlasí rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedna ze dveří zůstala zavřená, protože magnet, který udržuje dveře zavřené, je mimo linii.
Pořád nevím, jak je uspořádat.
Zlý kód vytištěný na vrchní stranu
Koupil jsem je v únoru.
Nedávno jsem je pokusil použít a bohužel pokaždé, když jsem jednu zkoušet můj Keurig stroj mi dává chybovou zprávu, že kapsle není kompatibilní s mým strojem.
Používám Donut Shop od doby, co jsem ji poprvé koupil, a nikdy jsem neměl problém.
Po bližším zkoumání kaviárny jsem si všiml, že kód, vytištěný na vrchní straně, není moc čitelný, takže můžu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72, což je 6 krabic po 12 kusů.
Zkoušel jsem jeden z každého ze 6 políček a stále dostávám stejnou zprávu o chybě.
Vím, že to není můj stroj, protože ostatní moduly, které jsem vyzkoušel, fungují dobře.
To je jen z této zásilky, že jsem tento problém.
Velmi zklamání, protože moje návratová doba skončila.
Aktualizace: Mluvil jsem s zástupcem zákazníka, který mi vrátil peníze.
Děkujeme AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestě.
Takové pohodlí!
Je opravdu pěkné mít svou oblíbenou alternativu k cukru zabalenou v malých balíčcích!
Miluji swerve, a je to tak pohodlné mít tyto zahodit do kabelky na večeři, nebo používat na přátel's domu.
I když jsou trochu drahé, nemůžu vystát Equal ani růžovou věc v ledovém čaji.
Odbočit nebo nic, takže jsem nadšená, že moje sladidlo je na cestě!
Vlastně není "čištění" vzduchu.
Koupil jsem ho jako zvlhčovač, část "vyčistit vzduch" je vlastně falešná reklama, v závislosti na tom, jak je tvrdá voda, sediment se hromadí na dně, ale nic z toho není prach ve vašem domě, pokud bydlíte v uhelné dole nebo něčem takovém.
Jako zvlhčovač bych to hodnotil jako o něco méně efektivní než zvlhčovač typu facka se stejnou velikostí ventilátoru.
Výhodou je, že to nezohynou.
Vzhledem k dodatečným nákladům na jednotku, pravděpodobně budete muset pracovat asi 5 let, abyste vyrovnali rozdíl.
Má poměrně velkou kapacitu vody pro svou velikost, protože je "nádrž" nedílnou součástí jednotky a má nízký výkon (i když ne lepší než facka).
Je také poměrně snadno čitelný, i když plastové disky nelze opravit, protože disková jednotka nemůže být demontována.
Nicméně, pro německé inženýrství, kvalita stavby není skvělá.
Já mám svůj už rok, což by bylo asi šest měsíců chladivého počasí, a jednotka vyvolala velmi otravný šumění z ventilačního souboru.
Myslím, že to bude ten ventilátor, takže čekám, až se tady stane úplná záhoda.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř stejné jako koupě nového zvlhčovače.
- Není to za další náklady, je lepší mít vlhkač.
Asi to bylo snazší rozbít, než si mysleli.
Dávám tomuto produktu 3 hvězdičky za to, že když jsem ho dostal dovnitř, byl už zevnitř rozbitý.
Poté, co jsem ho prozkoumal, uvědomil jsem si, že ten, kdo ho vložil do krabice, ho tam dal rozbité, mohli to být buď výrobci, balení, nebo výrobci, problém by možná mohl být, že kupující vrhnul zboží a tvrdil, že ho prostě nechtěl nebo ho nepotřeboval a Amazon pravděpodobně nedělal dostatečně dobrou kontrolu kvality, když se vrátil.
Poctivě vzato, kupující nemohl říct, že je to rozbitý, protože by si ho Amazon nevezl zpět, což je dobře, zejména u tohoto výrobku, i když jsem to já, kdo se nechal zkazit něčí nedbalostí.
Ale své peníze jsem dostal zpátky, takže po přemýšlení a rozhovoru s manželkou, jsem se rozhodl dát tomuto kupujícímu ještě jednu šanci.
To znamená, že svůj rating až budu aktualizovat na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zachází s tímto příspěvkem (alespoň se na něho podává) a pokud produkt přichází ve skvělé formě, má ve skutečnosti příležitost dělat to, co dělá, a dobře dělá to, co má dělat.
Snadné nainstalovat?????
Celkově jsem s tímto nákupem docela spokojená, ale nebylo to pro mě tak jednoduché nainstalovat.
Snažil jsem se několikrát napojovat oba "zvony" do připojeného vysílače, ale bez úspěchu.
Byl jsem připraven ho vrátit, že nefunguje, ale myslel jsem, že to zkusím ještě jednou a zkontrolním baterie v zvonech.
Voila...byly tam malé plastové karty, co visely z baterie, které jsem si vytáhl a ven z nich vylezl plast, který zakrýval baterii a bránil jí v práci.
Jakmile jsem odstranil ty kousky plastu, zvony fungovaly skvěle a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v příručce pro uživatele není zmínka o plastovém obalu nad baterií, který musí být odstraněn, aby zvon fungoval.
Bylo by to mnohem méně frustrující, kdyby to zmínili, a nemyslel jsem si, že problém je v tom, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou zvonů, zvonů a melodií, které si můžete vybrat a je snadné to změnit kdykoli budete chtít.
Jediná věc, kterou se ptají při hodnocení tohoto zvonu je, jak je "vzduchový".
Nemůžu to komentovat, protože to bylo instalováno 5. července 2019 a pravděpodobně nebudeme schopni komentovat jak odolné je k počasí až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček.
Vyrůstal jsem s nimi a chtěl je koupit pro syna, ale ztratili balíček živých housenek.
Řekli mi, že ho vymění a tentokrát si účtují polovinou nákladů.
Po značné době telefonování mi nakonec účtovali za novou objednávku s cenovou slevou 3 dolary.
Myslel jsem si, že je to dost neprofesionální, protože nejenže to přišli o, ale také mě navedli věřit, že to opravují, jen aby mi účtovali skoro plnou cenu na konci 30 minutového hovoru s nějakým vtipem o poukazu.
Strávil jsem 30 minut na telefonu, tak jsem se vzdal a koupil si novou sadu housenek.
To je jedno.
Funguje to dobře po bolesti hlavy.
Měl jsem problémy, aby to fungovalo.
Dodávaný kabel nebyl dobrý - nemohl dobít baterii.
Když jsem vyměnil kabel za můj, byl jsem schopen ho nabit a pak připojit zařízení přes Bluetooth k PC.
Měl jsem problém najít software pro PC, ale když jsem jim poslal e-mail na podporu, reagovali během dne s správnými informacemi pro stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, nicméně jsem nebyl schopen se připojit k iPhonu nebo iPadu (zkoušel jsem několik z nich) prostřednictvím bluetooth.
Budu muset tvrdě kabel, pokud se rozhodnu použít toto zařízení v mém produktu.
... bylo příliš žluté než se koupila a řekli mi, že je to jako starožitné zlato.
Zeptal jsem se prodávajícího, jestli není barva příliš žlutá, a on mi řekl, že je jako staré zlato, tmavší.
Nic blízkého!
Set vypadá velmi levně.
Je to super lesklá žlutá s spoustou CZ, ještě lesklejší.
Na fotce vypadá skvěle, ale v reálném životě bych ji nedala ani teenagerovi.
Miloval ten prsten - ale nemohl ho nosit pořád!
Ten prsten byl nádherný.
Líbil se mi jeho design a pevný nádych; vypadal draze a byl velmi pohodlný!
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec produkt vrátil, je, protože jsem si uvědomil, že ho nebudu moct nosit pořád.
Mám ráda prsteny, které nosím neustále, proto si vždycky beru zlaté stříbro, a vím, že někteří lidé říkali, že jejich prsteny po chvíli zabarvily, ale já jsem nosila svůj asi týden po sobě - dokonce i když jsem si myla ruce - a nepozorovala jsem žádné zabarvení.
Zajímavé je, že můj problém byl v tom, že vnitřní pás prstence změnil můj prst na bílý a vlhký, podobně jako bandaž po dlouhém opotřebení.
Stalo se to i když jsem se ujistila, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale bylo to nepříjemné a tak jsem se rozhodla, že to není prsten pro mě.
Škoda, protože se mi to opravdu líbilo!
Takže pokud si kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám: Jděte na to!
Nebudeš zklamaný!
koupit rozmazleného kuchaře...
Mám malý obal Pampered Chef, ale jsem mezi rezidencemi, takže většina mých věcí je ve skladu.
Miluju tyhle lopatky, když peču perfektně porcované sušenky.
Díval jsem se na OXO a Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a koupit si ten OXO - s jejich produkty mám většinou štěstí.
Tohle ne.
U třicátého bodě, páka uvnitř šroubu přestala fungovat.
Musel jsem roztrhávat rukávky a znovu umístit páku, abych udělal pár dalších, a pak opakovat.
Takže... ušetři rozum a kup si Pampered Chef.
Stojí to za to!
Už nikdy nebudu kupovat kafe.
Chvíli to byl dobrý kávovar, ale vždycky s ním byly problémy.
Kdyby byla mezi černým plastem a kovem na kadícku voda, tak by to mohlo praskat a vodu vypouštělo po celé dny.
Pak se nám zlomila plastická páka, která umožňuje, aby káva proudila filtrem do karafy.
Kontaktovala jsem zákaznickou podporu, abych se zeptala na nový kousek, ale oni mě posílají pouze na servis, který je 90 minut od mého domu.
Je skvělá na výrobu kávy a udržování ho v teple, ale je s ní příliš mnoho dalších problémů, než abychom investovali v ní za současnou cenu.
Musím koupit!!
Líbila se mi ta růžová zlatá barva a všechno na ní bylo skvělé!
Jediná věc, s kterou jsem měl problém, bylo, že to bylo opravdu obyčejné.
Líbí se mi, že mám víc detailů ve rukávích, a všiml jsem si toho ještě předtím, než jsem ji koupila, což je důvod, proč dávám 5 hvězdiček!
Bylo to snadné vyčistit a všechno přišlo zabalené individuálně, což jsem shledal, že je to opravdu organizované a uklidňovalo mou duši lol miluju, miluju, Miluji barvu a určitě bych to koupil znovu pro sebe nebo pro milovaného!
Může to být dobré na tyči, ale ne jako visící deflektor nebo štít proti počasí.
Škoda Audubonu.
Podle pokynů je třeba vnutit zástrčku do otvoru v defektu a "Ujistěte se, že je pevně na místě".
Jak???
Je navržen tak, aby deflektor jednoduše ležel volně na zástrčce, takže ho může vystrčit jakýkoli tvor nebo i ten nejmenší vítr.
Můžete otáčet zásuvku vzhůru nohama tak, aby se šrouby na palec nacházejí na spodní straně defektu, ale bude vám trvat hodiny, než se tyto šrouby otáčí; žádný nástroj to neudělá a pouze nepatrné prsty by si to mohly lehce udělat.
Trvalo mi přes hodinu, než jsem je napojila tak, abych upevnil deflektor na tyče.
Je to úplná PITA.
Objednala jsem si čtyři, ty tři, které jsem neotevřela, se vrátí přímo zpátky a hledám lepší ochranné kryty proti počasí.
(Uvědomme si to, není nic, co by veverky opravdu "překvapilo"!)
Miluji mnoho rysů těchto světel.
Koupila jsem si tuto lampu, abych doplnila světlo, které moje nové sadby zeleniny dostávaly z okna.
Mám rád mnoho vlastností těchto světel.
Výhody: Za prvé, snadno se přilepí na moji polici, a ohýbají se do mnoha pozic, což mi umožňuje provést změny, jak mé rostliny rostou.
Světla jsou chladná na dotek a neškodí ani při dotýkání rostlin.
Myslím, že moje zelenina má užitek z světla.
Světla jsou stlačitelná, ale používám jen nejsilnější nastavení.
Nepoužíval jsem časovač, raději je sám zapínám a vypínám.
Mohu tuto funkci považovat za užitečnou v kancelářském prostředí s domácími rostlinami nebo na dovolené Minusy: Nemyslím si, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro rostliny v jeslích.
Světla jsou malá!
Až zhasnou světla, budu si muset koupit úplně nový.
Pozor...Páchne velmi špatně...Kartové sloty jsou příliš velké!
Když jsem to poprvé viděl, myslel jsem, že je to krásné, ale páchlo to strašně.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že to je vůně plísně.
Nikdy nezmizelo, tak jsem ho musela vrátit.
Plus, kapsy na kreditní karty jsou příliš velké.
Kreditky se posouvají dolů, spropitné se neobjevují, takže nevíte, která karta je kde a je velmi těžké ji dostat ven.
Fotografie, na které se zobrazuje, kde se karty přilepí, není přesná.
Je to velmi malé.
Dostal jsem pásek na cestovní peníze a je mnohem menší, než na obrázcích.
Přál bych si, abych si ho nekoupil a stejně budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel.
Zaprvé, musím říct, že barva je milá.
Spousta věcí, které si objednám ve fialové, jsou vždy příliš lehké, příliš dětinské, příliš divné, příliš neonové, nebo co.
Ale ta fialová byla hluboká a svěží a líbí se mi, deštník je pevný a opravdu dobré kvality.
Asi nejlepší deštník, co jsem kdy měl.
Dodává se s krytem a i když to nemusí mít moc funkční využití, opravdu to udržet vypadat ostrý.
Balení je hrozné. Dostali jsme 3 poškozené kytary.
Velmi hezká kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Neobtěžujte se dostat jednu, která není poškozena.
Dva jsme vrátili kvůli poškození v přepravě a ten třetí byl také poškozen.
Vzdal se.
Posílají ji v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Žádné polstrování.
Skvělý koncept!
Chce jen nějaké vylepšení, aby to byl opravdu skvělý produkt.
Opravdu skvělý koncept, když jde o karaoke.
Miluju karaoke, takže tenhle mikrofon hned vyvolal můj zájem.
Myslím, že celkový design je dobrý - růžové zlato je pěkný detail.
Je to také standardní design, který jsem viděl na všech dalších variantách souvisejících s tímto typem mikrofonu.
Pro nezavázané, jak to funguje je to současně působí jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Celkově máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co vyjde ven.
Ale v tom mikrofonu není žádná hudba.
Má to Bluetooth konektor, takže ho synchronizujete s telefonem a stahujete karaoke aplikaci, která může vyslat karaoke písničky do mikrofonu.
Nebo můžete dokonce synchronizovat aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi pro nastavení hlasitosti hudby a vašeho hlasu (také samostatně!).
a dokonce má možnost nastavit úroveň ozvěny, takže zníte, jako byste byli v karaoke sále.
Některé věci, u kterých bych rád uviděl zlepšení, jsou: 1) je tam nějaká otravná zpětná vazba, která nezmizí, bez ohledu na to, jak daleko jsem od telefonu a mikrofonu.
Jestli jsi na to přišel, rád bych to věděl!
2) Přepínač na střed mikrofonu je nešikovný.
Jsem fanoušek minimalizmu, takže by bylo skvělé, kdyby budoucí produkty mohly udělat design elegantnější.
3) podporu pro více karaoke aplikací Konečně, protože zvuk vychází přímo z mikrofonu, a ne přes plochou obrazovku nebo centrální vysílačku v obývacím pokoji, není to tak zábavné v party prostředí.
Pokud by to výrobce mohl nějak integrovat do většího party karaoke ekosystému, tak by to mohlo udělat tuto nekonečnost příjemnější.
Vytrženo z pohledu Vision Supplies
V říjnu 2017 jsem zakoupil čtyři (4) kazety od Vision Supplies - Amazon Marketplace, abych měl, když bude potřeba, a abych ušetřil náklady na dopravu.
Využil jsem dva za posledních pár let, asi jeden za rok, a fungovali dobře.
Pokusil jsem se jeden použít minulý týden, skoro prázdný po tisku 20 štítků, ale u posledního vypršel po 40 stranách.
Na obou chybí plast.
Řekli, že záruka vypršela!!!!
Kdo by kontroloval každou zásobní kartu při obdržení????
Kupující pozor!!!!!!!!!!!
Promiň, cože?
Můj přítel mi doporučil masku z této řady, tak jsem si koupil toto, tento kondicionér a všechno v jednom mléce.
Nemůžu mluvit o účinnosti produktu, protože ten zápach byl prostě netolerovatelný.
Víš, že ten zápach plísně ze starých budov se používá na dámských záchodech, aby se maskovalo zápach dám, ale nakonec z toho vypadá jako kyslý, chemický, jako zápach plísně ze babičky?
To je všechno, na co myslím, když to cítím.
Znáš různé lidi, tak možná se ti bude líbit vůně.
Můj přítel říká, že to pomůže i těm nejpoškozenějším vlasům, takže pokud se nestaráš o vůni, tak se neboj.
Vím, že přírodní výrobky nebudou vonět tak krásně jako některé syntetické, ale cítím, že se více a více přírodních linií o to prostě nezajímá, protože se stejně prodá a teď všechno prostě voní jako playdough.
Ztratil jsem pár oblíbených řádků, když změnili vzorec na levnější ingredience.
Nevím, jestli je to tak, nebo jestli je to padělek (který jsem nazval Davines a oni řekli, že to není), ale cítí to jako YU C K a musela jsem ho vrátit.
Internet klesá
Ten modem/router jsem koupil asi před dvěma lety.
Na začátku to vypadalo v pořádku, ale za poslední rok jsem měl problémy s tím, jak mi padal internet.
To se děje na všech mých zařízeních, jak Wi-Fi, tak kabelové.
Jediný způsob, jak obnovit službu, bylo obnovit napájení.
Stalo se to jednou nebo dvakrát denně.
Vyrostl Comcast a spustil novou koaxální linku od podstavce k domu a zvýšil úroveň signálu.
Stejný problém.
Chlapi z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem při třem příležitostech přišel o 5G.
Musel jsem to obnovit továrním nastavením.
Nemohu doporučit tento modem/router na základě svých zkušeností.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Měl jsem ho přes týden bez problémů.
Je rychlejší a má větší dosah než Arris.
Četla jsem na internetu, že jiní lidé měli problémy s modemem/routerem Arris připojeným k Comcast.
Pokud máte Comcast internet, nedoporučuji tento modem / router Arris.
Vezmi si Netgear, je mnohem spolehlivější.
Ale je to dost na to, aby to bylo otravné.
Na pozitivní stránce.
Jeden z ventilátorů zněl mimo rovnováhu.
Ovládání rychlosti je velmi zmatené. Když je nastavíte na 100%, ventilátory se vypnou, takže to musíte změnit na 100% a pak to pomalu upravit, dokud se znovu nezapne.
Kvalita konstrukce je průměrná, ale zdá se, že je to normální pro většinu těchto typů výrobků v tomto cenovém bodě.
Nožičky, které drží notebook, když je nakloněný, se párkrát odtrhly...
Vracejí se zpátky, ale je to dost otravné.
Na druhou stranu má to ideální umístění ventilátoru pro notebooky, které navíjejí vzduch ze vzduchových otvorů umístěných v blízkosti horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a dodávají velmi malý příliv vzduchu do notebooku s takové konfigurací chlazení.
Případ s vážnými omezeními.
Tento případ je v pořádku, ale ne výjimečný - 3,5 nebo 4 maximálně.
Problém je, že je dostupných méně případů pro Tab A 10.1 w S.
Gumdrop je asi nejlepší, ale má pár vážných problémů.
Kazetová guma (silikon, cokoliv) je velmi hladká a lehká a nedává vám spoustu důvěry, když držíte Tab jednou rukou.
Tab A je těžká, takže když si lehnete a díváte se na video, ten obal vám v ruce uklouzne, takže musíte často upravovat.
Musela jsem odstranit čirý plastový štít, který zakrývá obrazovku, protože to narušilo ovládání dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže teď je vnější gumový kryt opravdu pružný a křehký.
A nakonec, ztěžily cestu do S Pen.
S Pen je v pravém dolním rohu Tab A a oni udělali malou gumovou klapku, která chrání roh, která se otáčí dozadu, pro přístup k S Pen.
To znamená, že aby bylo možné vyndat pero S, musí se klapka otáčet o 180 stupňů.
Tohle je opravdu trapné a těžké udělat jednou rukou.
Tento pouzdro dobře chrání můj Tab A, ale s těmito vážnými designovými chybami je nemohu doporučit, pokud nemáte S-pen, pak nemáte moc na výběr.
Všechno, co jsem potřeboval.
Tento produkt je opravdu chytrý - jediné místo pro všechny mé potřeby připojení.
Miluju mít to a malý napájecí adaptér pro můj notebook v mojí batohu a být připraven pracovat na velkém 4K displeji nebo pořídit fotky z foťáku.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 USB-C huby jsem zkusil od různých značek) je, že Mac je zřejmě nemůže rozeznat rozdíl mezi multiply stejné monitora (takže můj Mac výstupy stejné video ke všem identických monitorů připojených k rozbočovači, ať už HDMI a / nebo VGA).
Ale pokud používám 2 oddělené huby / adaptéry nebo 2 různé modely monitorů, pak Mac správně výstupy na displeje jednotlivě.
Dobře, potřebuje se vylepšit.
Hodný tréninkový nástroj, ale opravdu musí mít nějaký druh bezpečného zámku přes tlačítko. (Byla stisknuta spíš náhodou, když je v kapse, než jsem chtěl použít) Moji psi dokonce omylem zapnuli, když šli na ovladač.
A když se váš pes rád valí v mývalích hovadinách jako můj, tak to vyčistí je taková potíž.
Jak se stolice dostává mezi trhliny přístroje, potřebujete rozmontovat celou věc, aby to bylo vyčistěno správně a odehnul se zápach.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebujete dohled, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem byl jen 30 stop od svého psa.
To, že je nabíjecí, je určitě hezká vlastnost a nabíjení vydrží dost dlouho.
Já musím nabíjet jen jednou za dva týdny.
Dostaneš, za co zaplatíš.
Hrozný produkt, zkreslený.
Koupil jsem to jako sledovač, abych ho používal během plavání, a ani jsem neměl příležitost to vyzkoušet.
Za prvé, není odolný vůči vodě a nedoporučuje se ho používat při plavání.
Za druhé, nepřichází s nabíječkou.
Místo toho navrhuje použít USB nebo počítač.
Dobře, máme jich tu spoustu.
Když se ho snažím dostat do přístavu, aby se nabíjel, vypouští se zase.
Nejsem si jistá, jestli je něco neslučitelné, nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet moje zařízení, zatímco se nabíjí.
A konečně, aplikace stále zobrazuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílala zprávu, což je velmi znepokojující.
Poté jsem zavřel všechny aktivní aplikace na svém telefonu, a viděl jsem další reklamu, když jsem šel zkontrolovat čas 20 minut později.
Hrozný produkt, asi jsem dostal to, za co jsem zaplatil...
Skvělý batoh, ale přehnaný popruhy.
Tento batoh vypadá dobře a funguje dobře.
Je to hodně, zvlášť když to porovnáš s tím, co tašky stojí dnes.
Utrhla jsem hvězdu, protože je tam příliš mnoho řemenů.
Na té tašce je víc popruhů, než dokážu spočítat.
Nakonec tyto přebytečné popruhy odříznu a spálím, protože většina z nich není nutná a jen brání otevírání a zavření tašky.
Kromě toho jsem si udělala tuhle novou školní tašku na vysokou.
Vzadu v batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se vejdou do nabízených kapes.
Vlajka je také skvělý závěr.
Můj pes ho ještě nezničil.
Měl jsem problémy s hokejovými míčky.
Můj pes je miluje - je to její oblíbená hračka - a plavou se.
Dokud je nezžvýká na kousky.
Zkusil jsem je několik, dokonce i ty s "horkým počasím" - a vydržely o pár minut déle než ty ostatní.
Než se objevily tyhle.
Tyto přestaly zkoušku.
Můj pes není velký, ale je tvrdohlavý, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj v psovi.
Palce nahoru od Daisy a mě.
Tento přípravek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
- Zkontrolovali jsme baterii po pár týdnech používání a viděli jsme, že voda se dostala do komory, kam baterie chodí.
Samotné baterie se rozpadly a z nich vycházela černá kapalina.
Když se podívám na design, zdá se, že není možné, aby byl prostor baterie vodotěsný, což znamená, že nejen voda vniká do prostoru během koupele, ale také se z něj vylévá nějaký toxický materiál.
Prosím, nekupujte tento přípravek.
Jsem šokován, že ho nechali na trh i přes tak zjevnou chybu.
problémy s přehřátím a těžký čas připojení ovladač
Teď mu dávám 3 hvězdičky, nechci nechat špatnou recenzi pro prodávajícího, pokud si to nezaslouží, ale tenhle dron se hodně přehřívá.
Nejsem si jistá, jestli mám kontaktovat prodávajícího nebo DJ Tello, ale nejspíš bych to obě zkoušela, abych viděla, co řeknou.
Líbí se mi, že drony jsou malé super hračky, které létají lépe než některé větší, starší drony a některé z mých větších dronů se cítí jako hračky.
Nicméně je to jediný dron, se kterým jsem měl problémy s přehřátím a který opravdu bere zábavu z létání. Pro teď si budu myslet, že je to výrobní problém, který musí co nejdřív řešit, pokud chtějí, aby byl jejich produkt úspěšný.
Upřímně doufám, že mi prodávající neposlal použitý dron, protože jsem zaplatil za nový.
Prodávajícího předám rekvizity na doručení, jakmile dorazí den po koupi.
Aktualizuji datum své recenze poté, co kontaktuji prodávajícího a DJ Tello.
O téhle dárkové tašce mám jen dobré věci.
O téhle dárkové tašce můžu říct jen dobré věci.
Dokázal jsem zabalit všechny své vánoční dárky do sáčků, obalů a papírových ručníků.
Výrobek je skvělé kvality a různé možnosti velikosti usnadňují volbu perfektní jeden pro každý dárek!
Velmi doporučuji.
Prodávající je naprosto milý a pozorný.
Po mém nákupu mě kontaktoval, aby se ujistil, že jsem spokojený se svým produktem.
Pět hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří tu hru vytvořili, s tím nic neudělají.
Nevěřte této hře, fyzika je hrozná a já jsem na to tak naštvaná, protože na každé hře je asi 40 hackerů.
Víte, oni prostě nechají hackery dělat, co chtějí a pak vědějí, že hra je hrozná, ale nedělají s tím absolutně nic a hra dál upravuje své postavy opravdu to, co by měli aktualizovat je fyzika, protože je to hrozné, nekupujte si tuhle hru, fyzika je hrozná a mechanika je strašná lidé, kteří samozřejmě, kteří vytvořili tuto hru byli vytočený, protože je to jedna z nejhorších her, na které jsem kdy ve svém životě hrál, upřímně bych raději hrál pixel hry v této blbosti je to jedna z nejhorších her nekupuj
Ne jako ostatní hry Tomb Raider.
Od samého začátku to nevypadalo jako ostatní hry Tomb Raider.
Hra je brutální v tom smyslu, že ovládání je chytré v tom, že neví, jakým směrem se snažíte jít.
Nechal tě padnout k smrti tím nejvíce zbytečným způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tato hra mi moc nepřijde.
Neplánuji ji dokončit.
Příběh je taky slabý, což je hlavní důvod, proč hraju hry.
Ergonomické a cenově dostupné, ale ne příliš odolné vůči konstantnímu používání
Má tenčí tvar, který se lépe hodí na ruce, nemá ostré rohy, a s napájecím káblem jako stálým připevněním, je daleko méně náchylný ke poškození než originální ovladač XB1.
Nevýhodou je: 1) Vibrační efekt, který se spouští při akčních hrách, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi ruční a máme tendenci ztratit 2-3 ovladače za rok.
Takže pro nás každoroční investice do ovladačů znamená, že musíme být vybíraví a opatrní ohledně toho, co kupujeme.
Ovladač by mohl používat trvanlivější pružiny; po pár měsících se tlačítka, která jsou používána nejvíce, přestanou reagovat a pravý joystick ztrácí svou soustředění, IE- činí obrazovky map přiblížit a postavy kráčí vpřed, aniž by se dotýkaly ovladačů.
Dostaneš, za co zaplatíš.
Byl jsem zklamaný, když jsem obdržel tento předmět, protože stříbrná část, která obklopuje obličej, byla jaksi vyrobena z nějakého levného plastu.
Nezklamalo mě to, že je vyrobená z plastu, ale spíš to, že díky plastu vypadá neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled.
Také jsem nevěřil, že vydrží každodenní nošení, tak jsem ho nakonec vrátil.
Byl jsem zklamaný, protože to vypadalo, že by to byla dobrá dohoda, kdyby to nebylo pro to.
Ale pokud to přehlížíte, pak by to mohlo být správné pro vás.
Bylo to dobře zabalené a přišlo to rychle.
Nic jako předchozí telefony Stylo, obrovské zklamání.
Měl jsem původní Stylo stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Očividně se mi Stylos líbí vzhledem k tomu, že pokaždé, když vyšel nový, koupila jsem si ho.
Nikdy proto, že někdo měl problémy nebo se rozpadl, jen proto, že jsem chtěl zůstat aktualizovaný a "do slučky" a udělal jsem to.
Ze všech těch telefonů, ani jednou jsem neměl problém s samotnými telefony.
Když jsem si koupil Stylo 3 přes Virgin Mobile, věděl jsem, že všechno půjde hladce jakmile dostanu telefon a nastavím ho, ale mýlil jsem se při tom.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos skvělé.
Nikdy jsem nebyl schopen úspěšně přesunout telefon na můj účet Virgin Mobile.
S tímhle telefonem jsem točil méně než týden.
Hledal jsem informace na internetu a volal jsem různým lidem, zoufale jsem se snažil, dát Stylo 3 výhody pochybnosti, a doufal, že jsem to byl jen já, kdo dělá něco špatně, ale bohužel jsem tím plýtval spoustou času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl připustit.
Nenávidím fakt, že musím dát stylovi takové hrozné hodnocení a recenzi, ale byl jsem extrémně zklamaný z tohoto telefonu.
Doufejme, že LG zvedne svou hru a zlepší budoucí Stylos, pokud existují, ale tohle byl obrovský BUST.
Na druhou stranu, návrat a náhrada šlo hladce, ale to je všechno.
