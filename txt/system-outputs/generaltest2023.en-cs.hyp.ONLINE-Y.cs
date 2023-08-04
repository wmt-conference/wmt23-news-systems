Hackovaná verze Jedi Knight havarovala, protože vyvolávala funkci z konce vtable.
Ukázalo se, že předpokládá, že volání iDirect3D: :createViewPort () by vrátilo iDirect3DViewport3, který má další metody přiřazené na konec ve srovnání s iDirect3DViewPort, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože se jedná pouze o vytvoření výřezu pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní chápu, že v praxi je iDirectXObject2 obvykle správná nadmnožina iDirectXObject, bez změněných podpisů funkcí a nové metody jsou přidány pouze na konec.
To však není všeobecně pravda; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže každopádně, protože to platí zde, abych to opravil, musel jsem rozšířit implementaci výřezu tak, aby obsahovala metody iDirect3DViewport3, aby volání na novou bylo platné.
Předpokládejme, že pro argument, že věda se alespoň částečně skládá ze seznamů objektivně faktických výroků o světě, pravdivých kromě jakékoli teorie, kterou by mohli podporovat.
I když je pravda, že taková fakta existují ve vědě, stále je možné tvrdit, že vědecká fakta jsou teoreticky nabitá.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale výběr experimentů, které mají být provedeny, kontroluje, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplynout pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se jinak vymanily.
Toto je velmi stručný náčrt věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi, které tvrdí existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvednu to tento víkend.
Hledal jsem dobré auto pro první auto; a opravdu miluji estetiku 80. let.
Již na cívkách a snížené výšce jízdy.
Udělal jsem malý průzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že nejsou rychle srovnávány
#Venting do doby Fediverse.
Domestic Partner a já jsme dnes večer šli do obchodu s alkoholem na pivo a láhev bub.
Když jsme šli na odhlášení, pokladní je docela zřejmá žena #trans.
Já, v šortkách a šlehačce manželky, a Domácí partner, všichni potetovaní a s novým účesem, který sám popsal jako „díky tomu, abych vypadal jako neonacista“.
Její tělo okamžitě ztuhlo a v jejích očích byl tento výraz strachu.
A pak jsme prostě... zaplatili za naše věci.
A řekl děkuji.
A řekl jsem, že její nehty vypadaly skvěle.
Úsměv úlevy na tváři byl skvělý pocit, ale skutečnost, že se nejprve bála FUCKING SUCKS A JÁ TO NENÁVIDÍM.
Toto je nejhloupější časová osa a nesnáším to dot com.
Nic nebrání Donaldu Trumpovi v tom, aby kandidoval na prezidenta, když byl obviněn, poté, co byl usvědčen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by si odpustil, aby se dostal z vězení.
Ale nemůže se odpustit ze státního vězení.
Chce to guvernéra státu.
Dvě zúčastněné státy jsou New York a Georgia.
Ten guvernér Kemp nepochybně Trumpovi omilost, pokud ho usvědčí nebo dokonce obviní DA Fulton County DA Fannie Willis.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze omezit na vysílání signálů s kontextově nezávislým významem.
V této práci na základě varianty klasického Lewisova (1969) signalizačního modelu zkoumáme podmínky pro vznik kontextově závislé komunikace v situačním scénáři.
Zejména, demonstrujeme, že tlak na minimalizaci velikosti slovní zásoby je dostatečný pro takový vznik.
Současně studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové disambiguaci významů symbolů.
Ukazujeme, že environmentální omezení na volbě referenta příjemce může odesílatel jednostranně využít, aniž by na konci příjemce bylo možné rozcestovat.
V souladu se společnými předpoklady se zdá, že povědomí odesílatele o kontextu je pro kontextovou komunikaci vyžadováno.
Navrhujeme, aby kontextově závislá komunikace je situovaný vícevrstvý jev, zásadně ovlivněný vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale přesto umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil dohánění Penny a Nicholase z Ashanti Development o víkendu na rozhovor o jejich pokroku.
Ashanti Development spolupracuje se stále se rozšiřujícím počtem komunit v regionu Ashanti v Ghaně již 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti pro vložení a podporu vlastního rozvoje.
Měl jsem to štěstí, že jsem strávil nezapomenutelných šest měsíců po boku Nicholase v roce 2011 podporou řady projektů.
Když jsme o víkendu dohonili, byl jsem nadšen, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšené výnosy plodin prostřednictvím řady intervencí od podpory nákupu vybavení až po školení.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je podzimní červ, který může zničit plodiny kukuřice.
Fotky z mé návštěvy Ghany v roce 2011.
Obchod UPS poblíž mě mi nedovolí napsat štítek nebo psát na krabici.
Musí vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou jde a kdo ji odesílá.
Musím poslat e-mailem nějakou náhodnou adresu, s neformátovanými daty, aby úředník mohl přečíst e-mail a zadat jej do svého systému a vytisknout štítek.
A vždy mi za to „pohodlí“ účtují 2,25$.
Druhý den ráno a já se nemůžu dostat přes hanebnou předstírání veřejné žurnalistiky Chrise Lichta včera v noci na CNN.
Bylo to pobouření, jako symbolický antidemokratický festival lží a stížností 6. ledna, sebezničivě hostovaný americkými médii.
HANEBNÉ PUBLIKUM.
Licht SOUHLASIL s celým republikánským publikem!
Kdo prověřil a vybral jednotlivce?
Je tu příběh, který tam bude nahlášen.
Hodnocení-hledající klamnou nezodpovědnost za to všechno.
Nemůže se to opakovat.
Mám velmi průvanový suterén, což v podstatě znamená, že mohu přimět spoustu hlodavců, aby se uchýlili.
Minulý měsíc se objevilo mnoho známek více hlodavců, což bylo mimořádně překvapivé, protože je jaro, a já bych si myslel, že se se změnou počasí vydají ven.
Přesto jsem měl kolem sebe roztříštěnou hromadu obyčejných starých pastí a každých pár dní na nich svědečně doplňoval arašídové máslo, protože myši to laskavě olízly.
Včera v noci jsem se konečně touto rutinou naštvalo, vyčistil všechny pasti arašídového másla a nalepil k nim pistácie.
Fungovalo to.
(fwiw, Vyzkoušel jsem téměř každou „humánní“ past na trhu s velmi malým úspěchem.
Nejsem zvlášť spokojený s jejich zabitím, ale nebudu se vyjadřovat k etice zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se balí do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jistě, že snižují obchodní daně.
Ale také snižují granty a daňové úlevy, které podporují větší obchodní činnost.
Vlastním firmu. Je to úspěšné navzdory provinční vládě, ne kvůli ní.
Bylo zjištěno, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automatické přehrávání videa, animace, poppovers, a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jakým vydělávají peníze, ale všechny ty odpadky se zdají kontraproduktivní, pokud lidi odváží.
To platí i teď, když koza.cx je pryč, i když by to byl těsný závod ke dnu mezi kozou a řekněme khou.com, kde jsem se snažil sledovat video, které mi Wendy poslala.
V prvním dnešním vlaku se kontrola jízdenek podívala na naše lístky a řekla „dlouhá cesta!“
„Jo a dnes se vracím,“ řekl jsem.
„Právě jsem ho vysadil v Glasgow,“ pokusil jsem se vysvětlit a ukázal na svého společníka na cestách.
„Není něco, co moc slyšíte.“ „Jen ho vysadím v Glasgow,“ řekl chlápek s lístkem.
To je věc, kterou jsem nikdy předtím neřekl.
Věc, o které mě včera v noci přesvědčila, je, že musíme být připraveni bojovat proti Trumpismu.
Trumpismus je kult.
Je to kult, který nikdo opravdu nechce, kromě fanatiků, kteří jsou v něm.
A jsou to opravdu blázni.
Nemůžeme jim dovolit unést naši zemi.
Je čas se bránit.
Jděte ven a protestujte hned.
Získejte nějaké samolepky na nárazníky, které jsou proti Trumpovi, a omítněte je všude.
Křičte zpět na ty, kteří by se o nás pokusili mluvit.
To není normální.
To není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak vykašlává bouři covidského hlenu z druhé strany ulice.
Tak jsem spěchal, abych se dostal do svého aptu, abych se mu vyhnul, ale přesto se mu podařilo dohnat mě, abych si povídal.
Přísahám, že lidé infikovaní covidem jsou zombie, kteří se snaží infikovat všechny ostatní.
Není společensky přijatelné chodit na veřejnost nebo spěchat k lidem, když vykašláte hlenovou bouři.
Opakuji. Není společensky přijatelné šířit svou hlenovou bouři covid všude!!!
Psaní zázraků 5/11: Směje se váš MC více nebo pláče?
Abe udržuje své zármutky skryté a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho pobaví hrubý humor.
Jan vám ublíží, než vám umožní vidět, že je zraněná, a nejvíce se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4 000 tísni se Yl ocitá na místě lásky a má obrovské pocity, že neví, co s tím dělat, takže je tu spousta obojího.
#CNN se musí jen zavřít.
Včerejší fiasko s #MangoMoron bylo pobuřující fiasko.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který „výkonný“ kabelové zprávy zavolal, aby dal tučnému, lhanícímu zločinci tolik času?
Vysoký tlak bude převládat počátkem příštího týdne.
Studená fronta by měla dorazit do poloviny příštího týdne.
Brzy ráno, IR satelitní a povrchová pozorování naznačila rozšiřující se oblast nízké vrstvy a nerovnoměrných vrstev <URL>
Podivínská studentka Arnie Cunningham se zamiluje do Christine, rezavé Plymouth Fury z roku 1958, a je posedlá obnovením klasického automobilu do své dřívější slávy.
Jak se auto mění, mění se i Arnie, jehož nově nalezená důvěra se mění v aroganci za volantem jeho exotické krásy.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce nabízejících nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše Salesforce Consultants ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jednou z nejbláznivějších částí toho, jak se moji sousedé obracejí proti mně, je přemýšlení o tom, kolik úsilí je zapotřebí k nepřátelství.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto okamžiku se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře do obličeje vyžaduje úsilí.
Naši psi bývali nejlepšími přáteli.
A stále netuším, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu více než 6 let.
Ta loď je zakázána.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě irelevantní.
Můžeš ji zabít, jestli můžeš.
Ale jiný jedinec často letí na palubu této lodi.
Kdyby zemřel... následky by byly... významné.
Hodně jsem se dozvěděl o otci.
Zde je (o něco delší než) rychlokurz délky špičky, který mám na mysli pod pojmem otcová:
Není to můj termín, je to termín používaný k popisu, kdy je příběh nebo herní mechanik postaven na ústředním protagonistovi (obvykle starším, obvykle mužském), který řídí nebo střeží jinou osobu (často mladší).
Poslední z nás je snadným a kanonickým příkladem otcování.
Joel využívá své schopnosti a schopnosti k uzákonění (extrémních) násilných činů k dosažení úkolu, který je kódován jako „pečující“.
Dad-ification obvykle předpokládá, že řešením situace, kdy se rodičovská postava musí starat nebo chránit dítě nebo dítě, je ohromující síla, a použití této síly k vynucení velmi specificky tvarované dynamiky moci.
Ifikace táty narušuje možnost komunálních řešení, a často zcela ignoruje, nebo podkopává jakoukoli agenturu, kterou dítě má.
Tímto způsobem je DAD-Ification státem pro mnoho neoliberálních ideálů; zejména myšlenky jako bootstrapping a soběstačnost jako konečný cíle/indikátor úspěchu.
Zde je stručný přehled o tom, jak používat naše webové stránky.
- Zasíláme oznámení, když se letenky začnou prodávat.
- Poskytujeme odkazy na místo, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti jsou v plném příspěvku na blogu.
- Udržujeme seznam příkladů rezervačních dat pro každou nabídku, kterou zveřejníme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto jim nepředstavitelný strach, hrůza a vysídlení zanechaly neviditelnou jizvu traumatu.
Toto úterý, Prezident von der Leyen se setkal s první dámou Olenou Zelenskou v Kyjevě, aby diskutoval o tom, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli duševní zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže projít touto cestou.
Banda lesklých nových dobrot v #dart
Postupem času se šipka stala mým cílem pro rychlé uživatelské rozhraní.
#flutter je radost s ním pracovat a mají #mobx pro snadnou správu obchodu.
Příběh závislosti je také méně šílený než nodejs.
Flutter samozřejmě naštve opravdu špatně, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i třepotající webový cíl naštve).
Umožňuje však rychlý pohyb, a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou stavbu a svalnatý.
Jejich ocas je extrémně silný.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Být schopen skákat opravdu vysoko, roztrhat běžné lidi na kousky, používat strašidelné magické síly a doplňovat zdraví hodováním na svých nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze, aby vypadali špatně - všichni...
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
V reálném životě, moje máma měla ráda logickou hru, kterou jsem vytvořil před lety, a většinu tajemství našla sama, takže nebyla jen mámou, když řekla, že se jí to líbí.
Takže možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a/nebo Hokkien, ani jeden z nich vůbec neznám.
Asi budu muset zjistit, zda Bing nebo Google umí překládat špinavé gay sexuální hříčky.
Chvíli jsem si pohrával s touto myšlenkou:
Duševní zdraví je často považováno za něco odděleného od „běžného“ zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku stejně otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce rozpoznán TERF a podobně, protože je obecně fyzičtější a jako takový viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně „skutečné“ než fyzické zdraví, mám pocit, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, pohlaví, psychologii, tím více se zdá, že prohlášení „Můj sex je muž, moje pohlaví je žena“ zjednodušující a nepřesné.
Skoro to vypadá, že část argumentu postoupí TERF.
Cítím, že být trans znamená být „biologicky nebinární“.
Můj sex není binární, moje pohlaví je ženské.
Myslím, že označení „nebinárního“ je třeba rozšířit pouze z genderového výrazu, který se má použít při odkazu na sex.
Byl jsem, zapnutý a vypnutý, poslouchal díla @iotar
V tomto tajemném kolektivu je spousta dobrých věcí.
Jako krauty nálady a další světská populární hudba a radiofonní dílna a všechny druhy.
Velmi stojí za to jít.
Také FWIW Líbí se mi rozhraní archive.org mnohem víc než desktop #bandcamp\ - Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrával s Flutterem.
Nerad bych zakládal své podnikání na technologiích od Googlu, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého zážitku napříč platformami a ukazuje to.
(A také: Web je nyní bohužel do značné míry věcí Google)
Také mi prosím neříkejte, že aplikace google/flutter jsou na iOS a MacOS sát.
Cross platform je těžký, pokud to chcete dělat dobře.
Já to vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Vyšlo najevo několik velmi malých obtíží.
Nic, co by nastavilo zvonění poplašných zvonků, ale přesto jsou řešeny.
Příští týden bude vytvořena malá aktualizace, která je opraví.
Většina včerejška byla vynaložena na instalaci nové aktualizace pro některé zákazníky, a každý, kdo tuto pomoc potřebuje, by ji měl dostat už teď.
Hezký den!
Technické přiznání: Nemohu omotat hlavu kolem Grafany a Prometheus, alespoň z metriky serveru/aplikace a monitorovacího hlediska.
Nevím přesně, proč na to můj mozek nedokáže přijít; je možné, že nástroje jsou tak široké a vágní, že můj mozek jen zablokuje kvůli „příliš mnoha možnostem“.
Chci dělat řídicí panely.
Grafana vypadá hezky.
Mozek žádná práce.
Takže s blížícím se novou úrovní nájezdu #FFXIV jsem dlouho přemýšlel „člověče, rád bych zkusil pořádný nájezd, ale Party Finder zní jako nepořádek a nikdy nenajdu statiku, která by mě měla.“
Tak jsem si pomyslel, kašlu na to!
Udělám si vlastní statiku!
Plný lidí příliš dychtivých na to, aby se pokusili připojit k raidové statické síti, bez očekávání, že budou vůbec dobří!
Není možné, že by to fungovalo, pravděpodobně!
... A tak jsem zjistil, že musím vyřešit seznam skupin nájezdů.
V mládí jsem byl nenasytným čtenářem.
Pak, život rozdrtil mou duši a ztratil jsem veškerou vášeň pro fikci a skvělé vyprávění příběhů.
Ale po ~ desetiletích ~ čtení téměř ničeho (s výjimkou funkčních prací souvisejících s literaturou faktu a příležitostné svépomocné knihy) jsem si stanovil cíl přečíst v roce 2023 23 knih.
Nyní jsem v knize # 31 a je to teprve květen.
Jsem zpět, baby!
Opravdu jsem ničeho nedosáhl.
Jsem rád, že za mnou přišlo několik lidí v soukromí a říkalo: „Podívej, kvůli celé tvé práci ti poskytnu tuhle částku peněz“.
Chci vidět tyto společnosti, které zprostředkovávají transakce, vysvětlují svým zákazníkům, jak nastavují svá procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobrou čtvrtinu, budou.
Je nebezpečí vpustit migranty na jižní hranici? Já nevím.
Nechte je rehabilitovat vyhloubená a rozpadající se města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, prodiktátorské pravicové křídlo... tady je nebezpečí.
Deportovat bílé rasisty.
Jsem tak unavený z titulků, které tvrdí, že „Vzdálená práce je mrtvá.“ nebo že „Vzdálená práce byla neúspěšným experimentem“.
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno clickbait, ale dělá mi starosti s vedoucími pracovníky a manažery, kteří čtou tyto články.
Před rokem 2020 proběhla práce na dálku.
Stále budou existovat pracovní místa, která lze v dohledné budoucnosti provést na dálku.
Vzdálená práce je povolena.
Umožňuje lidem pracovat v pohodlných prostorách a ne dusných, hlučných kancelářích.
Umožňuje přístup pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim zabere čas od dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a pokuste se pochopit, jak vaši zaměstnanci skutečně dělají práci.
#WFH #business #neurodiversity
Nejde jen o konzervativce versus progresivisty, řekl na semináři více než 100 přívrženců v Grande Prairie.
„Je to válka mezi pro-lidmi a antilidmi,“ řekl.
Parker se zmínil o potratech a impulsu moderních městských žen odkládat děti kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
„Vy jste uhlík, který se snaží snížit.“
Takže jako od začátku všech mých narozenin v minulosti, Vždy jsem měl drsné.
Kdykoli se May objevil, bál jsem se, že se pokusím oslavit svůj den.
Něco by se vždy stalo, pokazilo se, nebo prostě skončilo stresujícím a depresivním.
V průběhu let jsem bojoval, abych se dostal z tohoto myšlení a měl lepší dny.
Trvalo to roky, než jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si svůj den bez obav.
A dnes se již stává skvělým dnem!
Zima je v této malé části Velkého jižního světa vzdálená 30 dní.
Ale nemůžu být oklamán!
To je začátek.
Déšť padá a zatímco není zmrzlý, nebudete v něm tančit!
Je to skvělý den na objednání rozvozu zmrzliny.
Byla to jedna psí noc a ten doggo nevystupoval z postele ani kvůli „Psí snídani - snídaně pro psy!“
Zipnu si podšívku do cyklistické bundy - jen pro případ, že bych ji potřeboval uvnitř.
Víte o výkonném způsobu, jak může webová komponenta reagovat na to, že je z dokumentu přídav/odebrána?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Jedná se většinou o sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí ConnectedCallback).
V současné době používáme hack MutationObserver.
Pro představení nedodržujeme celý dokument.
Vytvoříme odpojený dočasný rodič, nainstalujeme tam MO a sledujeme, jak se odpojuje (tedy připojuje jinde).
Casper #rat je v dnešní době absolutní jednotkou.
Myslím, že moje nová práce byla pro něj dobrá - dva volné touly denně, když pracuji, v poměrně předvídatelných dobách.
Konečně jsem dostal dobrou visící fotku, takže si mohu být jistý, že není tlustý.
(V #rats může být příliš vysoký tělesný tuk špatný pro jejich zdraví.)
On není.
Prostě je absolutně vytrhaný z toho, že se mi dvakrát denně roztrhal v kanceláři.
Nemám váhu, která by ho vážila, ale má pocit, že má přes libru.
Dělá mě tak šťastným, když vidím, jak se mu daří.
Dnešní zpráva o pokroku společnosti Aerostrike:
1) Mírné úpravy rozložení mapy Hel's Fighters.
Menu mapy je navíc plně funkční!
2) Systém odměn měny byl připojen.
Zítra to bude testováno různými bitvami.
Deštivé dny!
Minulý týden jsem udělal tunu a cítil se mnohem lépe z polních předmětů.
Všechny límce, kapusta, mangold jsou transplantovány.
Plánuje nasadit salát v Pennu na 6řádkovém vzoru a zjistit, jak se to srovnává s vysílanými záhony.
Jarní hrášek v Gilpinu se objevuje, takže je třeba nastavit mřížovinu.
Také je třeba tam nasadit řadu salátů, abyste integrovali řezanou zeleninu, oba mají vyškolenou posádku na zavlažování, přípravu lůžka a přesazování, což je 90% nesklizňových dovedností
Je rok 2023 a stále vidím, že se lidé s iPhony aktivně vyhýbají používání Apple Maps.
Apple Maps je standardně dodáván s iOS, a přesto by si lidé šli stáhnout a nainstalovat Mapy Google do svých iPhonů.
Netuším proč.
Zvědavý, měl jsem otevřenou mysl porovnat, jak se porovnávají Mapy Google a Apple Maps, na mém testovacím zařízení iPhone (můj denní ovladač je zařízení Android, takže je vzácné, že používám iPhone).
Zkušenost s dodržováním pokynů byla v Apple Maps mnohem lepší ve srovnání s Mapami Google.
Apple Maps vyhrává.
Proč tedy lidé přeskakují přes další obruče a instalují Mapy Google?
Nemám ponětí.
Je možné, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že Vyhledávání Google je integrováno s Mapami Google?
Nemám ponětí.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch neuvolňování odpadků koncovým uživatelům, a Apple se královsky posral se svými Apple Mapami, když vyšel v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to země, která z něj dělá dobrého skladatele bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a je třeba jej vyměnit.
Spousta ppl si myslí, že doslova vlastní Zemi, když si koupí kus.
Ne ten případ.
V Číně si můžete pronajmout pouze pozemky.
Nejsou tak hloupí, aby prodali prodej navždy.
Vláda může tyto politiky změnit, kdykoli chce.
Země je dočasná.
Zdá se nepředstavitelné, že by země mohla být jednoho dne odebrána, když sledujete australské a americké mediální kanály, ale je to proto, že bohatí jsou tam celý den a zajišťují, že vaše mysl myslí určitým způsobem.
Země je velmi snadno a rychle odebrána vládou jednoho dne, pokud to chtějí udělat.
A hádej co?
Nikdy nedávalo smysl, jak může ppl udržet půdu na úkor ostatních.
Jednoho dne to musí být odebráno.
To je důvod, proč Číňané povolují pouze pronájem.
Už jim došla země.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem investorům, kteří jsou tam venku, si připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, si vážme jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm #geologist #entrepreneurship #sustainability #success #friendship #toast #dreams
Často přemýšlím o lidské schopnosti být „tak* na sobě“, zatímco je zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Atrýznit se nad osobním selháním a vinou ve světě, kde je „úspěch“ tak často udělun lidem odpovědným za ty nejtrestuhodnější činy...
Všichni jsme tak špinaví tvorové.
Ale jemné zoufalství z naší nepořádku je zásadní - protože nám dává více prostoru k řešení ruin všude kolem.
Tak se snaž nezapomenout, co?
Láskavost k sobě samým je také aktivismus.
Někteří programátoři: „Rychlost psaní nezáleží!“
nebo „Modální editoři jsou dnes k ničemu“ :morty:
Extrahuji funkčnost mých #Axum projektů do sdílených knihoven: „Hold my keyboard“ :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup ke sdílení, ale zatím se mi to líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva tohoto týdne na Zjevení je Zůstaňte vzhůru celou noc.
Už několik dní si pohrávám s tímto malým kouskem na hlavě.
Je to rozhodně více romantika než špína.
Možná jsem četl mnoho románků s nemožnými „setkáními“ a to je výsledek, ale líbí se mi to.
Jednoho dne také úplně udělám míle vysoký orgasmus, možná ne se str.
Nesouhlasím s tím, že #Mastodon je obtížné nastavit.
Běžné, opravdu to není tak těžké.
Ale je obtížnější najít lidi, kteří by sledovali a sestavili vaši časovou osu.
Přál bych si, aby nějakým způsobem existovalo doporučení „koho následovat“.
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany, jako je Elk a/nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá to a necítí se dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali, a pravděpodobně budete potřebovat dobrou aplikaci ke zlepšení #UX.
Nevím, jestli je prevence možná, ale stojí za to vyzkoušet.
Čtyři kroky, které nastíním, jsou k diskusi, s určitým pokrokem v každém z nich:
Popis: názvy incidentů chování člověka a algoritmů, které odpovídají za algoritmy a lidi.
Vysvětlení: zohlednění obou stran vzájemného vlivu
Předpovídání: předvídání škod dříve, než k nim dojde (i když v minutách)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých mezích důvěry
Nedíval jsem se na radnici CNN, ale zdá se, jako by Trump řekl přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne Odeslat na svém telefonu.
I kdyby je během radnice neřekl, všichni v Americe je stejně uslyší opakovaně, od nynějška do listopadu 2024.
To stále není důvod dát mu další místo, ale škoda je přehnaná.
On vyhraje primárky.
Nemůžeme ho odvést.
Je tady a řekne tyhle věci bez ohledu na to, co se děje.
Zaregistroval se na čekací listinu Google „AI Test Kitchen“ a dostal se ve stejný den.
V tuto chvíli je to velmi ohromující.
„MusicLM Demo“ je mírně zajímavé.
Můžete požádat o konkrétní skladbu jako „jazz s trubkovým sólem v 5/4 tempu“ a po několika sekundách vám vygeneruje dvě skladby.
Zdá se, že tempo rozumí, ale... hudba prostě... není dobrá.
Házet vše, co máte přes plot v reakci na GPT, to není.
Snaž se víc Google.
Je divné dělat vzpírání, ale také nemít skutečné ponětí, co je vaše jednorázové opakování, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Pracuji sám ve své ložnici bez pozorovače nebo dokonce stojanu na závaží.
Jen já a činka se spoustou závaží.
Lavičkový lis na posteli.
Pokud se pokusím přijít na to, že moje jedno opakování max je, že bych nemusel vlastnit dost závaží, abych maximalizoval, nebo by mě to mohlo vážně zranit/zabít.
Každopádně, zátěž dnes stoupá.
Pořád se cítím dobře.
Přísahám, že burrata před pěti lety neexistovala
Tohle je můj osobní Mandela efekt.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem to neviděl u luxusního obchodníka s potravinami ani u italských lahůdek.
Nikdy jsem neviděl něčí mámu, aby to dělala, ani to na mě strčila na večírku, ani jsem neviděl, jak to vypadá ve spojení s něčími eskapádami nebo dny pečení
Jednoho dne se objevil a najednou byl všude k dispozici.
Vstoupil jsem do dimenze burraty.
Drakeův stárnoucí iPad se rozdává, takže je na trhu s novým tabletem.
Když jsme zde byli radikalizováni, zdráháme se koupit nový stroj FAANG*.
Má někdo tablet s Linuxem, který miluje?
To by bylo hlavně pro procházení webu, příležitostný e-mail, a některé hry.
V letech 1998-06 Gamefan, v souvislosti s dlouhým vývojem první hry Unreal, Jason Schrieber komentoval:
„Dobrá hra je jen pozdě, dokud se neobjeví.
Špatná hra je špatná navždy.“
Takže to bylo Epic, které to vytvořilo?
Můžeme jít dál.
Dřívější vydání GamePro 1997-11 má citát s mnohem větší nejednoznačností,
„Nebo, jak říká průmyslová fráze: Pozdní hra je jen pozdě, dokud se nedodá.
Špatná hra je špatná po zbytek tvého života.“
Je to tak pomíjivé?
Pouze „fráze“ bez jasného původce?
Smoky, můj 10měsíční pes Domácí modré kotě, hrající si s červeným gumovým komfortním zařízením Apple Pencil zakoupeným od Amazonu, který před několika měsíci utíkal.
Nosí ho hrdě v ústech po celém domě a já se musím vnitřně smát.
Pokaždé, když ho vidím dělat.
Nyní jste absolvovali úplnou zpáteční cestu novým vlakem ICNG.
Moc se mi to líbí.
Esp kočárů s většími okny.
Existují oblasti, které by mohly použít nějaký lesk.
Jmenovitě nedostatek dostatečných košů a nedostatek znaků, které by vysvětlovaly význam barev osvětlení.
Opravte tyto drobné problémy, a pak jich můžeme mít více, prosím?
Nebudu smutný, když vidím konec akcií ICM nebo DDZ.
Jedno pravidlo pro zákazníka zůstává, protože se snažíme zajistit, aby se každý, kdo čeká ve frontě, dostal ruce na tabuli.
Můžete si koupit JEDNU z výše uvedených desek, ne jednu z nich.
Neexistují žádná omezení nákupu Picos nebo jiného zboží.
Včera jsem měl nejlepší čas se svým přítelem a bývalým rabínským kolegou.
Navštívili jsme pár hodin na mé verandě.
Taková přátelství překračují rozdíly.
Všichni máme příběhy, které musíme vyprávět.
Pán vám žehná a zachovejte si vás!
A bažina se ozelenuje.
Docela se mi líbí software akkoma a název domény, který jsem dostal pro svůj příklad.
Ale nějak cítím, že jsem tento případ začal špatnou nohou, abych tak řekl.
A nikdy jsem se tam nepohodlně nedostal.
Budu tu ještě trochu déle trvat a přemýšlet o tom, zda bych měl vůbec migrovat.
#FalconGameBooks
Zdá se, že Osmiokí Repnidové sledují, jak usazujete leták na červené půdě, ale nepohybují se směrem k vám, ve skutečnosti jsou nehybní, když vylézáte z letáku a pomalu k nim kráčíte.
Země pod vašimi nohama se začne třást a pak se třást, jako by při zemětřesení a vy ztratíte základ, i když se Repnidové zdají být nedotčeni.
Skála pod vámi náhle ustoupí.
Repnidi tunelovali pod povrchem a vy spadnete do vroucí hmoty stovek těl Repnid v jeskyni dole.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jste byl první lidský budoucí cestovatel.
Přistanete s nosem letáku nahoru na stranu hromady strusky a vylezete ven.
Zdá se, že Osmiokí Repnidové sledují, ale nepohybují se směrem k vám, ve skutečnosti jsou nehybní, když k nim pomalu kráčíte.
Zastavíte se ještě na kopci rozpadlé skály a půdy a mluvíte k nim a říkáte: „Přicházím v pokoji, jako přítel.“
Zdá se, že vás nemohou slyšet, natož pochopit, protože váš univerzální překladatel nezvedá žádnou odpověď.
Rozhodnete se použít své psychické povědomí, abyste je mentálně kontaktovali.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a vaše mysl se odvrací od kontaktu.
Rozhodnete se, že opětovné navázání kontaktu bude nebezpečné a vrátíte se ke svému letáku, ale zkušenost vám vyčistila mysl, která byla zmatená od té doby, co jste skočili do budoucnosti.
Jakmile se vrátíte do Falconova křídla, zjistíte, že je docela snadné vykreslit kurz pro Zemi v roce 3034 n. L.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[Cont'd]
#today Mám kávu, slunce a klidný čas!
Začal jsem nový šátek.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně spřádanou stříbrně šedou přízi, která je většinou jemně spřádaná hrudkami.
Mám v plánu smíchat s jemnou fialovou/lila pestrobarevnou bavlnou.
Ale nejsem si jistý, jestli mám dost fialové.
Používám háček H s podobným vzorem dvojitého háčkování jako předtím.
První jsem se připojil včera večer, takže uvidíme.
Přejeme všem šťastný čtvrtek!
nicméně, Nesnáším kurzy výtvarného umění a literatury, a moje školní historie to nese.
Doslova jsem se snažil a upustil KAŽDÝ JEDEN.
A až před dvěma lety, Neměl jsem tušení, dokud jsem nezkontroloval své přepisy.
Nenávist třídy literatury je ještě horší: Rád čtu.
Většinu klasiků jsem zasáhl před osmnácti - i když je to spíše odraz života v bláznivém nikde, v zoufalství jsem také četl Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a úžasný a jsem tam šťastný, ale musím být někde jinde, abych se dostatečně ochladil, abych si během dne přečetl beletrii, aniž bych se cítil provinile.
Je to, jako bych byl na dovolené, a proto dělám to, co člověk dělá o prázdninách.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma, a trochu jsem se dostal do #MECFS z toho, že jsem prostě v podivném prostředí, kde jsem méně schopný tempo a musím si pamatovat, kde jsou věci.
A to i přesto, že stále mám svůj seznam úkolů a organizuji také svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující, a všechny dobré věci, které miluji na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi to, ale dokáže přilákat publikum správných hráčů?
Rozkvete komunita kolem části hry generovaného uživatelem?
(Opravdu v to doufám.)
Příběh hry, nápady a otázky, které inspiruje, se cítí včas.
Doufám, že to půjde dobře.
Je den ThinkPad!!
Přišel jsem domů na polední přestávku, abych viděl, jak sedí venku uwu.
Přál bych si, abych to mohl vzít zpět do práce se mnou na nastavení více.
Ale to bude muset počkat do dnešního večera.
Tak jsem konečně sledoval #Heartstopper
Bylo to příliš roztomilé do té míry, že jsem twee?
Rozhodně
Mluví některá z těchto postav o lidských bytostech?
Ani vzdáleně
Ale miloval jsem to?
Absolutně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Kdyby čerstvý postgraduální umělec dnes večer vzal nějakou kritiku špatně.
Částečně proto, že by se špatně učili.
Je však důležité neomlouvat se za problémy a jen je opravovat, zejména ve výrobě, když se váš vedoucí potřebuje změnit.
Zejména s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je zde k rychlému vyřešení problému a není zaměřena na vaše schopnosti.
Předpokládá se, že máte schopnost problém vyřešit, nebo najít řešení.
Takže zatímco kompostování a rolování květů jsou skvělou připomínkou, jak se podívat nahoru a být si vědom života mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte semena, která jsou zaseta a kultivována (a ne náhodně rozptýlena) dobrými peepy.
Tyto kořeny jsou skryté.
Práce není viditelná.
Ale pro silný a pevný budoucí růst.
Jami mu podal poznámku, když se míjeli na cestě, těsně před hlídkou psa.
Byla na cestě ke zdi, odcházel ze služby.
Podíval se za sebou, aby sledoval, jak odcházela, a ujistil se, že nebyli vidět.
Neohlédla se zpět.
Čekal, až bude ve tmě palandy, než vytáhl poznámku a přečetl ji paprskem světla procházejícím zatemňovacími závěsy.
Jedno blokově vytištěné slovo.
Dlouho na to zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových kamarádů #Mastodon a chci si tento trend zachovat.
Díky volání do #Fediverse se cítím jako velryba zpívající obrovským oceánem!
Chcete se připojit k mému „pod“?
Zvláště bych se rád spojil s více.
Každý, kdo má ohnivé vlasy ohledně CNN, může poděkovat Stephenu Colbertovi za tvrdou pravou zatáčku.
Pomohl udělat z Chrisa Lichta národní problém.
Stejně jako by se nám někteří lidé mohli líbit, pokud fašistům poskytují jen malou ligovou kariéru, pravděpodobně by to měli nosit.
Bylo to poprvé (ale nebude to poslední), kdy Kaveesha Dilhari zaznamenala 20+ běhů a vzala 2+ branky ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, aby dosáhla všestranného výkonu ve formátu.
Policie zatkla 15 po násilném protestu před britským uprchlickým hotelem
K incidentu došlo po nárůstu počtu uprchlíků a žadatelů o azyl, kteří překračují Lamanšský průliv do Velké Británie na lodích.
Policie zatkla 15 lidí po demonstraci proti uprchlíkům před hotelem sloužící k ubytování žadatelů o azyl, která se stala násilnou poblíž anglického města Liverpool.
Policejní oddělení Merseyside uvedlo, že policista a dva civilisté utrpěli během narušení v pátek večer v Knowsley lehká zranění.
Policie uvedla, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zatčení lidé, kteří byli ve věku od 13 do 54 let, byli zadrženi „po násilném nepořádku“.
Policejní komisařka Merseyside Emily Spurrellová pro Radio City řekla: „Bylo to neuvěřitelně nebezpečné a mezi policisty došlo k několika zraněním.“
Ministerstvo vnitra používá hotel k dočasnému ubytování žadatelů o azyl od loňského roku, podle místních médií.
George Howarth, který zastupuje Knowsley v britském parlamentu, uvedl, že násilí v pátek večer neodráží komunitu.
„Lidé z Knowsley nejsou fanatičtí a vítají lidi, kteří utíkají z některých z nejnebezpečnějších míst na světě při hledání bezpečného místa,“ řekl.
„Ti, kteří demonstrují proti uprchlíkům na dnešním protestu, tuto komunitu nezastupují.“
Protest se konal uprostřed zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů překračuje Lamanšský průliv v malých člunech.
Více než 45 000 lidí se touto cestou dostalo do Velké Británie v roce 2022 a většina požádala o azyl.
Systém posuzování žádostí o azyl zpomalil kvůli politickým neklidům a byrokratickým zpožděním, takže mnoho žadatelů o azyl zůstalo uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Přechody Lamanšského průlivu se staly politickým problémem, přičemž konzervativní vláda slibuje „zastavit lodě“ a bude pokračovat v plánu vyslat takové žadatele o azyl do Rwandy.
Odpůrci obvinili vládu z démonizace zoufalých lidí prchajících před válkou a chudobou.
Prezidentský pohár: Candystripes porazil Rovers v otvíráku sezóny v Brandywellovi
Záložník Derry Adam Reilly uzavírá Lee Grace na Brandywell
Derry City zvítězilo v prezidentském poháru, když došli vítězové 2:0 nad Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze loňské sezóny na Brandywell díky gólům v prvním pololetí od Will Patching a Michael Duffy.
Obruče se ve druhé polovině tlačily na snížené podmínky, ale obvinění Ruaidhri Higginse stály pevně, aby vyhrály zvedák záclon.
Derry příští pátek odcestuje do St. Patrick's Athletic za otvírákem ligy.
Patchingova salva s bočními nohami postrčila Derryho vpředu po 23 minutách - záložník otevřel bodování, když Foylesider loni v únoru došel vítězům 2—1 nad případnými šampiony.
Obruče dále vyhrály Premier Division o 13 bodů, ale Duffy brzy měl City dále vpřed s úsilím na dlouhé vzdálenosti, které se dokázalo vrhnout pod brankářem Leonem Pohlsem a do sítě.
Poslední finalisté minulé sezóny byli dva góly k dobrému v přestávce.
Graham Burke se ve druhé třetině přiblížil ke snížení nedoplatků, ale Candystripes byli pohodlnými vítězi týden před jejich pátráním po národní slávě.
Šéf města Ruaidhri Higgins ocenil svůj tým poté, co řekl, že byl „nejtěžším týdnem mého života“ po smrti jeho bratra Kevina.
„Je to kop do zubů a čekají nás těžké týdny, ale budeme s tím pokračovat v jeho paměti,“ řekl Higgins.
„Porazit Shamrock Rovers a zaslouženě tak dobrým výkonem je opravdu příjemné.“
DHS najímá advokátní kancelář, aby zvládla možné řízení o obžalobě Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti najalo externí advokátní kancelář - Debevoise & Plimpton -, aby pomohla v případném řízení o obžalobě ministra Alejandra Mayorkase, protože potenciálně čelí obvinění republikánů Sněmovny republikánů ohledně zacházení s jižní hranicí.
„Ministerstvo vnitřní bezpečnosti si ponechalo externího zástupce, aby pomohlo zajistit, aby životně důležité poslání ministerstva nebylo přerušeno bezprecedentním, neoprávněným a stranickým úsilím o obžalobu některých členů Kongresu, kteří již podnikli kroky k zahájení řízení,“ uvedl mluvčí DHS v pátek v prohlášení.
„DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic, přičemž bude odpovídajícím způsobem reagovat na více než 70 výborů a podvýborů Kongresu, které mají dohled nad DHS.
Úředník DHS říká CBS News, že oddělení najalo firmu na smluvní práci po dobu vyšetřování Kongresu.
Debevoise byl vybrán kvůli svým odborným znalostem v oblasti obžaloby a dvoustranným zkušenostem při práci s Kongresem na dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, DC, 13. října 2022.
OLIVIER DOULIERY/AFP přes Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva se společností Debevoise se kvalifikuje jako vhodný výdaj pro DHS.
DHS se snaží zajistit, aby její poslání nebylo narušeno partyzánskými útoky a aby řízení proti Mayorkům řešili lidé s příslušnými odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale minulý čtvrtek se zeptal na vyšetřování obžaloby, řekl novinářům: „Budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s posledním Kongresem. Myslím, že je to naše zodpovědnost.“
Připustil, že „bude nějakou dobu trvat“, než bude vyhovět vyšetřování Sněmovny.
„Budu trávit čas stejně jako ostatní a také nebudeme kompromitovat čas, který strávíme při plnění našeho poslání.“
Vysoký úředník DHS potvrdil, že Mayorkas se dosud nesetkal se svým novým externím právním zástupcem.
Obžalován byl pouze jeden člen kabinetu, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl Senátem osvobozen.
Trendy novinky
Děkujeme za přečtení CBS NEWS.
Čtyři dospívající obviněni z útoku čtrnáctiletého, který zemřel na sebevraždu poté, co porazil video, bylo zveřejněno online
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem čtrnáctileté dívky, která si později vzala život poté, co bylo video z incidentu zveřejněno na sociálních médiích.
Jeden mladistvý je obviněn z těžkého útoku, dva mladiství jsou obviněni ze spiknutí za účelem spáchání přitěžujícího útoku a jeden mladistvý je obviněn z obtěžování, řekl státní zástupce Ocean County Bradley D.
Adriana Kuch, 14, byla nalezena mrtvá ve svém domě v Bayville v únoru 3, dva dny poté, co bylo online zveřejněno znepokojivé video z útoku na Central Regional High School.
Video ukázalo dívky, jak házejí na dospívajícího drink, pak ji kopali a táhli po školních chodbách.
Zatlačili Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kucha opakovaně děrovala.
Další dívka mimo rámeček videa se zasmála, když nahrávala scénu.
Dva dospělí přišli, aby útok rozbili, s jedním dospělým, který oddělil dospívající.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý pokusil pomoci vstát.
Jedna z dívek řekla: „To je to, co dostanete.“
„Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali, „Její otec, Michael Kuch, řekl CBS New York ve čtvrtek a dodal, že je naštvaný a chce, aby všichni viděli video a to, co dospívající udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video o jejím útoku ve škole. CBS2
Kuch řekl, že policie měla být okamžitě zavolána, protože studenti, s nimiž řekl, že jeho dcera měla problémy, si rozbili obličej 20 uncovou lahví.
„Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejnily videa ze školy,“ řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
„Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti pozastaveni,“ řekl CBS New York Dr. Triantafillos Parlapanides, superintendant škol.
Úředníci školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních vystoupení, státní zástupce řekl CBS News.
Studenti ve škole uspořádali ve středu procházku na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v emocionální tísni nebo sebevražedné krizi, můžete se dostat na 988 Suicide & Crisis Lifeline zavoláním nebo textovou zprávou 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Další informace o zdrojích a podpoře péče o duševní zdraví najdete na lince pomoci Národní aliance pro duševní choroby (NAMI) od pondělí do pátku od 10:00 do 22:00.
ET, na adrese 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 zdravotními a wellness profesionály o tom, jak se vyhnout syndromu vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se syndromu vyhoření, zejména v naší práci.
To může být pro ty ve zdravotnictví nesmírně obtížné, a proto jsem položil 30 zdravotníkům a wellness na stejnou otázku: „Jak spravujete svou energii a nevyhoříte ve své profesi?“
Jejich kariéra sahá od lékařů infekčních chorob přes psychology až po učitele všímavosti - a všichni měli skvělé rady, jak dát, jak zůstat motivovaní a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vynikala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají smrtelná onemocnění, Eufrosina Young děkuje svému silnému systému podpory za schopnost udržet si energii.
Young je certifikovaný neurolog a specialista ALS na neurologickém oddělení Fakultní nemocnice v Upstate a říká, že se tam „mobilizují jako armáda lidí“.
Neexistuje lék na amyotrofickou laterální sklerózu (ALS), ale s vědomím, že není jediná, kdo usilovně pracuje na vývoji léčby a poskytování lepších možností pro své pacienty, udržuje Young v nejtěžších dnech.
„Neneseme váhu světa, ale jsme součástí světa lidí, kteří se zasazují o tuto práci,“ říká.
2. Odpočiňte si, když potřebujete
Práce ve dvou zaměstnáních jako výzkumník spánku a algoritmický inženýr, to vše při péči o nové dítě, by rozhodně vedlo Raphaela Vallatovi k vyhoření, kdyby neodpočíval, říká.
„Mám pocit, že když se chystám vyhořet, v podstatě se každý úkol cítí jako hora, na kterou musíte vylézt, a cítí se velmi naléhavě a důležitě,“ říká Vallat.
V těchto chvílích „opravdu musíte vzít nějaký čas a uvědomit si, že tyto úkoly mohou počkat.“
Typicky, Vallat najde okamžiky ve své době, kdy se může zastavit a trávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
Buďte nadšení pro to, co děláte, a pamatujte si svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounder 100 hodin týdně sedm dní v týdnu.
Být v první linii během pandemie sežralo téměř celou dobu, ale vyhnula se vyhoření tím, že si připomněla, proč je její práce důležitá.
„Nemyslím si, že práce je jako práce, když máte pocit, že máte dopad,“ říká Gounder.
„Pokud pracujete bláznivě a děláte něco, co pro vás nemá smysl, myslím, že opravdu musíte ustoupit a ptát se, co děláte.“
4. Mějte jiné radosti
Každý z odborníků uvedl, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je nesmírně důležité mít život, který vás baví, který přesahuje to, čeho ve své práci dosáhnete, říká Christina Maslach, sociální psycholožka, profesorka psychologie v důchodu na U.C. Berkeley a autorka knihy „The Burnout Challenge: Management People's Relationships with their Jobs“.
„Podívejte se na svůj život jako celek a ujistěte se, že jsou na něm dobré věci, a ujistěte se, že na ně máte čas.“
Získejte bezplatný průvodce investováním Warrena Buffetta od CNBC, který destiluje nejlepší radu miliardáře pro pravidelné investory, co dělat a co nedělat, a tři klíčové investiční principy do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Získejte chytřejší informace o svých penězích a kariéře pomocí našeho týdenního zpravodaje
Mladistvý obviněn z vraždy v prosinci v Chicagské školní střelbě, která si vyžádala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě dvou studentů na chicagské střední škole v prosinci, oznámila policie v pátek.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou případů pokusu o vraždu, Oznámil policejní dozorce Chicago David Brown.
„V současné době nemáme jasný motiv, proč by šestnáctiletý chtěl střílet a zabíjet další děti,“ řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown řekl, že bude čelit vraždě a pokusit se o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběťmi, kteří zemřeli, byli oba chlapci, ve věku 14 a 15, oznámila policie v té době.
Vyšetřovatelé tvrdí, že tipy od veřejnosti jim pomohly vést k podezřelému, který byl ve čtvrtek zatčen.
„Jsme vděční těm, kteří měli dost odvahy, aby se přihlásili, aby zajistili, že pachatel bude chycen a nyní bude hnán k odpovědnosti,“ řekla státní zástupkyně okresu Cook Kim Foxx.
Očekává se, že se podezřelý objeví v Bond Court v sobotu, Řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Minnesotští biologové zachraňují uvězněného černého medvěda
Minnesotské ministerstvo přírodních zdrojů přišlo na záchranu medvědího nešťastného medvěda poté, co byl uvězněn v příkopu.
Medvěd se hrbil dolů v propustku podél silnice poblíž Wannasky, Minnesota, podle příspěvku na Facebooku z oddělení.
Ale když se sníh začal tát, propustek začal zaplavovat a podle oddělení chytit medvěda v hlubokém sněhu a ledu.
Zaměstnanci oddělení rychle reagovali na scénu a pomohli odstranit medvěda.
Medvědí biolog oddělení Andrew Tri „medvěda prozkoumal a prohlásil ho za zdravého, ale omráčeného - očividně proto, že byl probuzen ze zimního spánku,“ uvádí příspěvek na Facebooku.
Oddělení poté přemístilo medvěda do státní svatyně, aby obnovilo jeho hibernaci.
Ospalý masožravec byl odhadován na 6 let a mezi 375 a 400 liber.
Oddělení připomnělo obyvatelům, že stěhování medvědů je práce, kterou nejlépe ponechat profesionálům.
Pokud se obáváte medvěda ve vašem okolí, měli byste kontaktovat místní úřady - nepokoušejte se pohybovat nebo krmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tents, salátu a krmiva pro kočky Fancy Feast.
Ale naštěstí pro dobře míněné bagry, „protože medvědi nemají chuť jíst v zimě, medvěd nekousl.“
Minnesota je domovem 12 000 až 15 000 černých medvědů, které se podle ministerstva přírodních zdrojů vyskytují hlavně v severní třetině státu.
Predátoři v zimě přezimují až šest nebo sedm měsíců, během této doby nejedí a nežijí ze svého uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedl generální tajemník Nejvyšší rady pro památky v Egyptě Mostafa Waziri, velvyslanec Span v Egyptě Alvaro Iranzo a prezident Španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že tyto dvě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady pro památky a CSIC, která funguje od roku 2002.
Řekl, že mise provedla výkopové a restaurátorské práce a publikovala výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odhalit mnoho hrobek, rakví, mumií a pohřební zahrady.
Významné hrobky z důležité éry
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili na začátku 18. dynastie Nové říše - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že rozložení hrobek má tvar T, styl běžně používaný v hrobkách z 18. dynastie.
Ty odpovídají vchodu, sloupové síni vedoucí k pohřební šachtě a stěnám s výraznými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a přehlížel díla řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byla také zodpovědná za zaznamenávání Hatšepsutovy cesty do Puntlandu a poskytnutí elektra (směsi zlata a stříbra) pro zakrytí horní části obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
Místnost, která předchází pohřební komoře Djehuty, obsahuje nápisy vyryté 43 kapitolami Knihy mrtvých, poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek, než byly napsány na prádlo a papyrus.
Hery zastávala funkci dozorce královských obchodů posvátné královské manželky a matky Ahhotepa.
Jared O'Mara by nikdy neměl být kandidátem na labouristy, říká Rachel Reeves
Zneuctěný bývalý poslanec Jared O'Mara „nikdy neměl být vybrán jako labouristický kandidát“ a zaslouží si svůj čtyřletý trest odnětí svobody, řekl stínový kancléř.
Rachel Reeves hovořila s Guardianem ve volebním obvodu Bolton North East v pátek, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak Labouristický národní výkonný výbor (NEC) kontroluje parlamentní výběrový proces pro příští všeobecné volby.
Celá výběrová komise v Boltonu na severovýchodě rezignovala poté, co jim nebylo dovoleno vybrat užší výběr, což je stále běžnější praxe v Labouristické straně Keira Starmera, a řekla: „Opět se zdá, že labouristická strana se snaží propagovat názory a postoje klika v Londýně, spíše než místní členové na severu.
Dodali: „To je v rozporu s postojem nezbytným k získání červené zdi, která je tak zoufale potřebná k dodání labouristické vlády.“
Reeves řekl: „Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.“
Obzvláště neštěstí nastalo, že Leigh Drennanová, předsedkyně labouristického severozápadu a poradkyně poslankyně Warrington North podporující Jeremyho Corbyna Charlotte Nichols, nebyla dlouho zařazena, aby se pokusila získat křeslo zpět od konzervativců, navzdory získávání nominací ze čtyř velkých odborových svazů.
Reeves řekla, že nemá nic společného s výběrem kandidátů, ale dodala: „Vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo může být zařazen do užšího výběru.“
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že podal falešné žádosti o výdaje v celkové výši 52 000 liber ve snaze financovat své zneužívání kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl řádně prověřen labouristy, když byl vybrán do boje s Nickem Cleggem, bývalým místopředsedou vlády liberálních demokratů, v Sheffieldu Hallamu v rychlých všeobecných volbách roku 2017.
Na otázku, zda se debakl O'Mara rýsuje v myslích labouristického NEC, Reeves řekl: „Nechci žádným způsobem naznačovat, že někdo, kdo není na užším výběru, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest.“
Okolnosti O'Mara byly „docela výjimečné,“ řekla Reeves, ale uznala: „Pro labouristickou stranu a všechny politické strany si při výběru kandidátů musí vzít důležité ponaučení.
Ale také bych řekl, že v tomto parlamentu jsme viděli neustálé podkopávání standardů v politice, v neposlední řadě posloupností premiérů a pokut a stran a standardů, které nedosahují toho, co byste mohli očekávat.“
Dodala: „Jedna věc, kterou bych řekl o labouristické straně, je, že když lidé dělají špatně, ztratí bič. A to není případ konzervativní strany.“
Archie Band a Nimo Omer vás provedou nejlepšími příběhy a tím, co znamenají, zdarma každý pracovní den ráno.
Oznámení o ochraně osobních údajů: Informační bulletiny mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme Google reCAPTCHA a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku pro Openreach, který poskytuje britskou širokopásmovou síť.
Poté, co Reeves sledoval, jak učni stoupají po předstíraných telegrafních stožích na místě 1,7 milionu liber, diskutoval o plánech Labouristů na přepracování učňovského poplatku, což nutí větší firmy odložit 0,5% své mzdy na financování učňů.
Podniky si stěžují, že poplatek je příliš nepružný. Například, řekl Reeves, Openreach „chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vláknu, ale učňovský poplatek nemá tuto flexibilitu ohledně rekvalifikace“.
Reeves uvedl, že Labour změní poplatek, aby společnosti mohly peníze použít na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový průmysl a těch, kteří v současné době montují plynové kotle.
„Potřebujeme je v rámci přechodu energie na nulu energie, abychom se naučili dovednosti pracovat na elektrických vozidlech nebo při montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto je proti nim naskládán učňovský poplatek.
Podniky chtějí větší flexibilitu a mladí lidé začínající v životě nebo starší lidé, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost, „řekl Reeves.
Jeden zatčen uprostřed protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena uprostřed protestu před Tate Britain, kde se konala událost vyprávění příběhů drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově přitěžujícího komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyla hlášena žádná zranění a policisté zůstávají na místě činu, řekla síla.
Tate v sobotu hostil Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou web galerie popisuje jako „prvního drag umělce v Evropě, který četl příběhy dětem v dětském pokoji“.
Pravicová skupina demonstrantů předvedla mimo galerii a setkali se s nimi protidemonstranti vedeni aktivisty za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit chodbu, aby se účastníci mohli dostat na místo konání.
Psaní na Twitteru, drag queen uvedla, že den byl „řádně emocionální“ a dodal, že pět demonstrantů získalo vstup do Tate a „způsobilo narušení“ v částech budovy, ale neovlivnili čtení.
Předtím řekla Pink News, že pozvání na Tate na akci během měsíce historie LGBTQ+ bylo „čest“.
Její čtení byla dříve terčem demonstrantů.
Drag Queen uvedla, že „hodnocení rizik“ proběhlo předem - ale dodala, že je „směšné“, že jsou nezbytné.
Aida tweetovala: „Do Tate se dostalo 5 nenávistníků. Způsobili narušení. ALE ne Drag Story Hour UK... Udělali rozruch jinde v budově, ne tam, kde byla show!! SHOW 2 šla plavat!!!“
Aida uspořádala v sobotu v 11 hodin tři vyprávění příběhů, poledne a 14:00.
Mluvčí Tate řekl: „Neprogramujeme umělce, abychom propagovali konkrétní úhly pohledu, ani abychom sladili různé úhly pohledu.“
Naše galerie nabízejí široký program a návštěvníci mají svobodu zvolit si, s jakými aspekty se zabývají.“
Trumpova cena 40 Wall Street Building na „Lender Watch“ uprostřed klesajícího příjmu: Zpráva
Silně zastavený mrakodrap Donalda Trumpa na 40 Wall Street je na „hlídce věřitele“ uprostřed klesajících příjmů a rostoucích nákladů, informoval Bloomberg v pátek.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější - vyskočila ve třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání zbývající hypotéky budovy ve výši 126,5 milionu dolarů, informoval Bloomberg.
Výdaje mezitím údajně vzrostly o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den 11. září 2001, teroristických útoků, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, byla to také lež.
Další nedaleký mrakodrap na Pine Street na dolním Manhattanu se stal nejvyšší budovou po zničení Twin Towers.
Pronájem výškových kanceláří na Manhattanu už léta klesá, což se zhoršilo po vypuknutí pandemie COVID-19, protože mnoho společností se zavřelo a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, který obsluhuje hypotéku na 40 Wall Street, „oslovil dlužníka o stav vývoje leasingu“ a plány na zlepšení výkonnosti nemovitosti, podle podání, uvedl Bloomberg.
Majitel Wagnera říká, že válka na Ukrajině bude trvat roky
Majitel soukromého vojenského dodavatele ruské skupiny Wagner Group, který se aktivně podílí na bojích na Ukrajině, předpovídal, že válka by mohla trvat roky.
Jevgenij Prigozhin ve videorozhovoru zveřejněném pozdě v pátek uvedl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny Donbasu.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr.
Prohlášení Prigozhina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl nazván „Putinovým kuchařem“ pro své lukrativní smlouvy o stravování v Kremlu, znamenalo uznání obtíží, kterým Kreml čelil v kampani, kterou původně očekával, že se uzavře během několika týdnů, kdy ruské jednotky napadly Ukrajinu 24. února.
Rusko utrpělo na podzim řadu ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšné protiofenzívy s cílem získat zpět široké oblasti území na východě a na jihu.
Kreml se vyhnul předpovědím, jak dlouho by boje mohly pokračovat, a řekl, že to, co nazval „speciální vojenská operace“, bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří oblast Donbasu, kde Moskvou podporovaní separatisté bojují od roku 2014 s ukrajinskými silami.
Prigozhin řekl, že žoldáci skupiny Wagner pokračují v divokých bitvách o kontrolu nad ukrajinskou baštou Bakhmut v Doněcké oblasti.
Uznal, že ukrajinská vojska vzrůstají tvrdý odpor.
Jak ruské jednotky tlačily své útoky na Donbasu, Moskva se také snažila demoralizovat Ukrajince tím, že je v hořké zimě nechá bez tepla a vody.
Rusko v pátek zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Vysokonapěťová infrastruktura byla zasažena ve východních, západních a jižních oblastech, což mělo za následek výpadky proudu v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale kontrolovatelná“, a dodala, že zahrnovala zálohy pro udržení dodávek energie, ale poznamenala, že přidělování energie bude v některých oblastech pokračovat.
Velitel ukrajinské armády generál Valerij Zaluzhnyi uvedl, že ruské síly odpálily 71 řízených střel, 35 raket S-300 a sedm dronů Shahed mezi čtvrtkem a polednem pátku a dodal, že ukrajinská protivzdušná obrana sestřelila 61 řízených střel a pět dronů.
Ukrajinské úřady informovaly o dalších útocích zabijáckých dronů později v pátek.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 dronů Shahed.
Pozdě v pátek zveřejnili ruští vojenští bloggeři a některé ukrajinské zpravodajské stanice video ukazující útok mořského dronu na strategický železniční most v oblasti Odesa.
Zrnité video ukazovalo rychle se pohybující objekt blížící se k mostu v Zatoce, asi 50 kilometrů jihozápadně od Odesy, a explodující silným výbuchem.
Pravost videa se nepodařilo ověřit.
Ukrajinská armáda se k útoku nevyjádřila a mluvčí regionální správy Serhii Bratčuk nepotvrdil útok dronů, když v sobotu promluvil v televizních poznámkách.
Most, na který se na začátku války zaměřily ruské raketové údery, slouží železniční spojení s Rumunskem, které je klíčovým kanálem pro dodávky západních zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazašští záchranáři pokračují v kopání sutin a hledají přeživší v Türkiye, Kazinform cituje tiskovou službu kazašského ministerstva pro mimořádné situace.
Práce záchranářů je omezena velkým množstvím nečistot a nestabilních konstrukcí.
Kazachstánský záchranný tým vytáhl sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte, v Türkiye.
První lékařská pomoc je také poskytována nepřetržitě.
Zejména zemětřesení o síle 7,7 stupně, které zničilo části jihovýchodního Türkiye a severní Sýrie, zasáhlo brzy v pondělí.
K dnešnímu dni počet obětí masivních zemětřesení zasáhl jihovýchod Türkiye 20 000.
Foto: t.me/qr_tjm
Asijské mistrovství má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM - Slavnostní zahájení 10. halového mistrovství Asie v atletice se konalo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, Kazinform cituje tiskovou službu kazašského premiéra.
Vedoucí kazašské vlády zahájil akci a přečetl uvítací dopis prezidenta Kassym-Jomarta Tokajeva.
„Sport nezná hranic.
Posiluje přátelství a sdružuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi existují všechny podmínky pro profesionální a masové sporty.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex, který má více než šest tisíc lidí, „píše se v dopise kazašského prezidenta.
Kazachstánští sportovci úspěšně soutěží a reprezentují Kazachstán na hlavních světových soutěžích.
Jsou příkladem rostoucí generace a inspirují mládež k velkým vítězstvím, poznamenal Tokayev.
Vyjádřil důvěru, že pořádání asijských mistrovství v Astaně dá nový impuls rozvoji atletiky v zemi a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanovi al-Hamadovi za jeho pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaj sdružilo více než 500 sportovců z 31 zemí, kteří mají soutěžit v závodech, štafetových závodech, skoku dalekém, skoku do výšky, trojskok, skok o tyči, výstřel a všestrannou akci.
Turnaj poběží do 12. února.
Dříve bylo hlášeno, že kazašská běžkyně Caroline Chepkoech Kipkirui vyhrála ženské 3 000 m zlato a Olga Safronová si na turnaji nárokovala 60m stříbro žen.
Foto: primeminister.kz
Herec „Yellowstone“ Q'Orianka Kilcher porazil obvinění z podvodu
Advokátka Camille Vasquez, která zastupovala Johnnyho Deppa v loňském trháku, zaznamenala další právní vítězství - tentokrát s hercem „Yellowstone“ Q'oriankou Kilcherovou.
V pátek, kancelář okresního prokurátora okresu Los Angeles vyčistila Kilchera, 32, všech obvinění v případě podvodu s odškodněním pracovníků.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora okresu Los Angeles uvedl, že soud „rozhodl, že paní Kilcherová se nedopustila pojistného podvodu, a sdělil soudu, že nemůžeme pokračovat“.
V červenci 2022 kalifornští úředníci obvinili Kilcher ze dvou trestných činů podvodů s odškodněním pracovníků a obvinili ji z nezákonného vybírání více než 96 000 dolarů na invalidních dávkách mezi říjnem 2019 a zářím 2021.
Časový rámec zahrnuje také několik měsíců, kdy Kilcher pracovala na „Yellowstone“, navzdory hercovým tvrzením, že byla příliš zraněna na práci.
Kilcher se vzdal a byl v květnu obhájen.
„Dnes jsem nesmírně vděčný za to, že můj případ byl zamítnut - zítra moje cesta začíná pomáhat zvyšovat povědomí a požadovat větší transparentnost práv pracovníků v rámci systému pracujících,“ uvedl Kilcher v prohlášení sdíleném s The Times.
Dodala, že „těší se na to, aby vrhla více světla na tuto zkušenost a pokračovala v práci, kterou miluji“.
Kilcher také poděkovala Vasquezovi a jejímu kolegovi právníkovi Brown Rudnickovi Stevu Cookovi za „jejich vytrvalou víru v mou nevinu“.
Podle TMZ, Kilcher je najal v září.
Kilcher vypukla s filmem Terrence Malicka z roku 2002 „Nový svět“, kde ztvárnila Pocahontas.
Mezi její zásluhy patří také „Synové anarchie“, „Alienist“ a „Dora a ztracené město zlata“.
Naposledy se objevila v road-tripovém filmu „Dog“, v hlavní roli Channing Tatum.
K této zprávě přispěla spisovatelka Times Christina Martinez.
Šéf Balenciaga nazývá prázdninová kampaň „hloupou chybou“
Značka luxusního oblečení Balenciaga se stále vzpamatovává z odporu dvou svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal pod teplo pro propagační obrázky, které kritici uvedli, že sexualizovali děti, umělecká ředitelka Balenciaga Demna (celé jméno Demna Gvasalia) uvedla, že je stále líto obrázků v rozhovoru pro Vogue zveřejněném v pátek.
„Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro darovací kampaň s dětmi a přebírám svou odpovědnost,“ řekl Vogue a zopakoval předchozí prohlášení, které zveřejnil na sociálních médiích v prosinci.
V listopadu, značka sdílela fotografie pro svou kolekci „The Gift“, který představoval dětské modely pózující s plyšovými medvídky oblečenými v otroctví.
Krátce poté Balenciaga upustila od fotografií pro svou kampaň na jaře 2023, která obsahovala stránku z případu Nejvyššího soudu z roku 2008 zahrnující „virtuální dětskou pornografii“ v pozadí.
Rodiče, včetně televizní reality hvězdy a dlouholetého fanouška Balenciaga - a partnera značky - Kim Kardashian, vystoupili proti značce a jejím „znepokojivým obrazům“ na sociálních médiích.
O několik dní později, Balenciaga vydala prohlášení, v němž se omlouvá za fotografie a nastiňuje změny, které by provedla, aby se v budoucnu vyhnula podobným „chybám“.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrázky, způsob, jakým komunikujeme s publikem a ve způsobu, jakým se učíme ze svých chyb a postupujeme vpřed,“ řekla Demna Vogue.
Podrobně popsal změny postbacklash v Balenciaze: „restrukturalizace obrazového oddělení“, provádění více interních a externích kontrol snímků kampaně a partnerství s Národní dětskou aliancí s cílem pomoci „tisícům dětí v procesu překonávání traumatu a řešení jejich duševního zdraví“.
„Je to jediná věc, která mi dělá radost z celé této hrozné situace: udělat z toho něco dobrého,“ řekl o partnerství, které bylo oznámeno ve středu.
S NCA se také spojila mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod deštníkem Kering je Gucci, který v prosinci čelil odporu pro kampaň představující Harryho Stylese, o které někteří kritici sociálních médií tvrdili, že také sexualizovali děti.
V rozhovoru Denma uvedl, že se plánuje vzdálit od „provokativních“ způsobů značky.
„Toto je součást mého učení: Budu mít zralejší a vážnější přístup ke všemu, co uvolním jako nápad nebo obraz,“ řekl.
„Rozhodl jsem se vrátit ke svým kořenům v módě i ke kořenům Balenciaga, která vyrábí kvalitní oblečení - nevytváří obraz ani bzučení.“
Když už mluvíme o původu značky, jinde v rozhovoru Demna uvedla, že jednou z nejvíce „bolestivých“ částí odporu bylo pošpinit „jméno Balenciaga a odkaz Cristóbal Balenciaga“.
„Balenciaga je dům, který je starý více než jedno století a je založen na silných a krásných tvůrčích hodnotách, a já jsem byl zaneprázdněn tím, že dělám vše, co je v mých tvůrčích silách, abych ho přivedl k jeho modernímu významu, a najednou jsme byli pod útokem a označeni jako něco, co vůbec nejsme,“ řekla Demna.
„Určitě jsme udělali obrovskou a hloupou chybu s dárkovými kampaněmi a určitě jsme se z ní poučili.“
Jsou to falešné zprávy, CBN odhaluje, že postrádá kapacitu pro tisk dalších nových poznámek Naira
Nigerijská centrální banka (CBN) označila zprávu, která tvrdila, že cituje vládce CBN pana Godwina Emefieleho jako zavádějící současnou výzvu v distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů v Nigerian Security Printing and Minting Company Plc.
V sobotním prohlášení mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN takové prohlášení nikdy neučinil během své prezentace Státní radě na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi uvedl, že Emefiele na schůzce pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot Nairy, aby vyhověl transakčním potřebám Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových poznámek z Nairy, „jsme znepokojeni tím, do jaké míry se vlastní zájmy pokoušejí manipulovat fakta a postavit veřejnost proti bance“.
Nwasinobi uvedl, že CBN je i nadále odhodlána vykonávat své funkce měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (ve znění pozdějších předpisů).
„Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálů pro výrobu požadované odrážky Nairy.
„Banka si proto přeje apelovat na veřejnost, aby tuto zprávu ignorovala a uplatňovala větší zdrženlivost, i když vytrvale pracujeme na zvýšení oběhu nových bankovek v zemi,“ dodal.
Na konkrétní hlasovou poznámku, která na sociálních médiích tvrdí, že CBN plánovala zavřít některé banky, zejména v konkrétním geopolitickém regionu země, CBN uvedla, že takový plán neexistuje a že tvrzení byla nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
„Veřejnosti se proto doporučuje ignorovat takové nahrávky, protože nepředstavují politický tah CBN a jsou to jen zoufalé pokusy osob usilujících o podněcování veřejnosti proti bance,“ uvedl.
Tim Sherwood se po neutěšeném debutu v Tottenhamu roztrhá do 44 milionů liber s Pedrem Porrem
Porro měl odpoledne, aby zapomněl proti Leicesteru (Obrázek: Getty)
Tim Sherwood vtrhl do „absolutně nechutné“ obrany Pedra Porra během porážky Tottenhamu 4:1 s Leicester City.
Spurs podepsal pravou zpětnou stranu od Sporting CP v den uzávěrky převodu na počáteční smlouvu o půjčce za 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
23letý debut předal Antonio Conte v sobotu na stadionu King Power Stadium a jeho strana se ujala vedení po 14 minutách prostřednictvím Rodriga Bentancura.
Ale změnilo se to v mizerné odpoledne, kdy Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni skórovali, aby dali Leicesteru v poločase 3-1, přičemž Porro vydržel v první polovině Premier League krutou první polovinu.
Španěl byl opět na vině, protože Leicester si myslel, že přidali čtvrtou přes Barnes, a zatímco cíl byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood byl šokován obranným úsilím úplného obránce.
„Nechci dál vybírat dítě, ale musí být zbaven svých povinností,“ řekl Sherwood v sobotu pro Soccer.
Dám mu výhodu pochybnosti, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé straně.
Daniel Levy říkal tento týden, utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
V tuto chvíli nedělejme žádné závěry, ale to, na co se dívám, je hráč, který se nechce bránit.
Více: Premier League
„Antonio Conte si stěžoval na obranu a tento hráč se v tuto chvíli snaží bránit. Je proti velmi dobrým hráčům v Barnes a Maddisonu, ale je to velké zklamání.“
Zatímco cíl byl vyloučen, Leicester obnovil vedení 4-1 s Barnesem na cíli devět minut z plného úvazku.
Navzdory tomu, že minulý týden porazil Manchester City, Tottenham minul šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepsala Joao Felixe a místo toho se vrhá na hvězdu Tottenhamu
VÍCE: Tottenham se chystá udeřit na hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu
Pro více podobných příběhů, podívejte se na naši sportovní stránku.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitter a Instagram.
Jack Smith by měl vyhrát jakýkoli privilegovaný boj o předvolání Mika Pence
Zpráva, že zvláštní poradce Jack Smith předvolal Mika Pence, vyvolává otázku: Jak bude tým Trump používat soudy k potlačení tohoto nejnovějšího vývoje v sondě ministerstva spravedlnosti?
Krátká odpověď je, že jakýkoli pokus o potopení předvolání Pence z důvodů výkonných privilegií by měl selhat.
Za prvé, existuje prahová otázka, zda si bývalý prezident může vůbec nárokovat privilegium.
Připomeňme, že Trump se pokusil a nedokázal zablokovat komisi Sněmovny 6. ledna v získávání záznamů v Bílém domě.
Nejvyšší soud loni odmítl přijmout Trumpovo odvolání, přičemž nesouhlasil pouze soudce Clarence Thomas (manžel popírání voleb v roce 2020 Ginni Thomas).
Soud však nechal otevřenou otázku, zda bývalý prezident může požadovat privilegium, přičemž soudce Brett Kavanaugh navrhl, aby takové tvrzení podpořil.
Není tedy alespoň jasné, zda se bývalý prezident může domáhat privilegium a neříká nic o tom, zda by tvrzení uspělo.
Navíc odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se dodržování předvolání ukazuje, že vágní tvrzení o výsadách nebude stačit a lze jej překonat konkrétní potřebou důkazů.
Soud poznamenal v roce 1974 Spojené státy proti Nixonům:
... pokud je důvod pro uplatnění privilegia ohledně předvolaných materiálů hledaných k použití v trestním řízení založen pouze na všeobecném zájmu o důvěrnost, nemůže převažovat nad základními požadavky řádného právního procesu při spravedlivém výkonu trestního soudnictví.
Zobecněné uplatňování privilegií musí odpovídat prokázané specifické potřebě důkazů v probíhajícím trestním řízení.
Precedens je tedy na straně vlády.
Samozřejmě, nicméně, zpoždění v soudních sporech, i když prohrává, může být pro Trumpa jakýmsi vítězstvím.
Ale další tlumení šance na úspěšné uplatnění privilegia je předchozí odmítnutí Trumpova pokusu zablokovat svědectví velké poroty 6. ledna.
Jak uvedl Washington Post v říjnu, toto odmítnutí poznamenalo, že například bývalý pobočník Pence Marc Short „pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti při útoku na Kapitol 6. ledna 2021, který nebyl k dispozici z jiných zdrojů.
Ten Pence, také, pravděpodobně má jedinečné informace, které by pomohly ministerství spravedlnosti v jakémkoli boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegia měl selhat.
Je to proto, že se Pence rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti se 6. lednem.
Je těžké říci, že komunikace je privilegovaná, když jste je dříve považovali za vhodné k propagaci.
Takže zatímco předvolání může představovat různé politické a osobní výpočty pro Pence - který může soupeřit o republikánskou nominaci na Trumpa v roce 2024, někoho, kdo účinně schvaloval výzvy k Pencově mimosoudní popravě 6. ledna - soudy by se měly snadno postavit na stranu DOJ na privilegium.
Případ proti Biden Run je zřejmý - a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové demokraté nemohou moc dělat v cestě přijímání zákonů s GOP, která má kontrolu nad Sněmovnou, mohou stále strávit další dva roky příkladem.
Kolektivně, všichni v týmu by měli hledat příležitosti hrát Gallant republikánským podivným Goofusovým impulsům.
Je však také důležité, aby Biden rozšířil svou důvěryhodnost americkému lidu - a možná byl právě potřebným agentem změny v naší až příliš tetované politické kultuře.
Washington, notoricky cynické místo, je známý svými společnými myšlenkami ochromujícími smysly o vedení.
Snad jedním z nejznámějších je zvláštní standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli jít komicky, aby se tomu vyhnuli.
Existuje i jiný způsob: V Bailout, vzpomínce Neila Barofského na jeho čas ve Washingtonu, který sloužil jako zvláštní generální inspektor dohlížející na program pomoci problémovým aktivům, popsal radu, kterou obdržel od Kristine Belisleové, ženy, kterou chytře najal, aby byla jeho komunikační ředitelkou.
Bylo to asi tak anti-Washington, jak to jen může být: „Přiznáme a dokonce zdůrazníme své chyby.“
Jak pokračovala ve vysvětlování, ve strategii existuje metoda, kterou by většina lidí uvnitř Beltway považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Mohli bychom se občas stydět a odhalit věci, které bychom mohli - a jiní - snadno skrýt, ale tisk šokujeme svou upřímností.
Nikdo jiný to neudělá a nedlouho budeme mít postavenou obranu, když na nás zaútočí.
Bez ohledu na to, co uslyší, tisk k nám přijde první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod pro Bidena, aby pokračoval v radikálním přijímání odpovědnosti: V každém předsednictví nevyhnutelně vznikají okamžiky, kdy je kritická důvěra veřejnosti a institucí, které chrání občanský zájem.
Navíc je zde životně důležitý kapitál, který je třeba získat vlastnictvím našich chyb, a existuje důležitý rozdíl, který může Biden nakreslit se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým příslovím: Řekněte pravdu - a zahanbujte ďábla.
Některé reklamy na Super Bowl, které se nemůžu dočkat, až uvidím
Hvězda sitcomu z devadesátých let, která opakuje svou milovanou roli při prodeji pojištění automobilu.
Reklama, která se stává kulturním fenoménem a okamžitě se rozsvítí zeleně jako televizní show, rozšíření dvanáctisekundové scény do deseti sezón.
Všechny celebrity z loňských kryptoměnových reklam se omlouvají za své krypto reklamy.
Ti „whassup“ kluci, ale trochu je, že teď jsou staří.
Všichni jsou teď na whodunnits, že jo?
Takže několik sérií reklam režírovaných Rian Johnsonem, kde pokud zjistíte, kdo vraždu spáchal, získáte slevu na roční pojištění automobilu.
Reklama, na kterou budou všichni super-online konzervativní kluci na týden zuřit.
Timothée Chalamet v určité kapacitě.
Někdo, kdo byl údajně navždy zrušen, se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte, který budete určitě sledovat, když bude streamovat za tři týdny.
Snesitelně chytlavá nová znělka, kterou si budete zpívat roky.
Recyklovaný vtip na Twitteru z doby před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste bankovali u Wells Fargo.
Dítě „zoom zoom“, ale trochu je, že je teď dospělý.
Biden DOJ „Nechce ozbrojeného občana“
Zástupce Andrew Clyde (R-GA) se ve čtvrtek posadil s Breitbart News a diskutoval o svých plánech zablokovat vládu pistolové ortézy ATF a o svém přesvědčení, že Bidenské ministerstvo spravedlnosti „v první řadě nechce ozbrojené občany“.
Clyde dal jasně najevo svůj nesouhlas s pravidlem pistolové ortézy.
Mezi jeho důvody pro tuto opozici patří jak obecné námitky, tak konkrétnější námitky.
Obecně vyjádřil své přesvědčení, že naši otcové zakladatelé nestanovili plán správy, který by zahrnoval federální agentury, které místo zákonodárného sboru vytvářejí zákony.
Řekl: „Ministerstvo spravedlnosti je tu proto, aby prosazovalo zákon, ne aby zákon vytvořilo. Když máte výkonnou moc, která vytváří zákon a prosazuje zákon, pak máte krále a království. Naši zakladatelé nepožadovali krále a nestanovili království v ústavě Spojených států.
Clyde poté přešel ke specifikům týkajícím se pravidla pistolové ortézy a vyjádřil své znepokojení, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal, „ATF chce rozšířit registrační databázi národního zákona o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, před konfiskací přichází registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany.“
Dodal: „Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby mohli jít po nás.“
Clydeovo tvrzení je, že pravidlo pistolové ortézy ATF se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní, a plánuje s tím bojovat zuby a nehty.
Řekl, že má „tři nástroje“, pomocí kterých může bojovat proti pravidlu.
Prvním z těchto nástrojů je zákon SHORT a druhým je zákon o přezkumu Kongresu.
30. ledna Breitbart News citoval Clydea, který nastínil svůj plán „znovu zavést zákon Stop Harassing Owners of Rifles Today Act nebo SHORT Act, aby zrušil prvky národního zákona o střelných zbraních, čímž se ATF zakazuje registraci a zákaz pistolí se stabilizačními rovnátkami“.
Poznamenal také, že „zavede řešení nesouhlasu podle zákona o přezkoumání Kongresu, aby potlačil nezákonné překročení Bidenovy administrativy“.
Oba akty, zákon SHORT a zákon o přezkumu Kongresu, mají možnost zablokovat pravidlo ortézy pistole ATF.
Ale jak řekl Clyde ve čtvrtek Breitbart News, velkou výzvou je, že obě tyto trasy budou nakonec vyžadovat podpis prezidenta Bidena, buď k přijetí legislativy SHORT Act, nebo k dokončení řešení nesouhlasu podle zákona o přezkoumání Kongresu.
Objasnil, že získání Bidenova podpisu není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k dalším větším zákonům, které demokraté velmi touží schválit.
nicméně, Clyde naznačil, že existuje také třetí způsob, jak zablokovat pravidlo ortézy pistole ATF.
Řekl: „Jsem ve Výboru pro rozpočtové prostředky a můžeme toto pravidlo pistolové ortézy zruinovat, prostřednictvím toho, co se nazývá pozměňovací návrh omezení. Můžeme doslova odmítnout toto pravidlo a v podstatě říci: „Na provádění nebo prosazování tohoto konkrétního pravidla pistolové ortézy nelze utratit žádné peníze.“
A totéž můžeme udělat také s pravidlem přijímače/rámce ATF, od loňského srpna.
Myslím, že oba musí být zaniklí a těším se na spolupráci s našimi přivlastňovateli, abychom to udělali.
AWR Hawkins je oceněný publicista druhého dodatku pro Breitbart News a spisovatel/kurátor Down Range s AWR Hawkins, týdenního zpravodaje zaměřeného na všechny věci Druhý dodatek, také pro Breitbart News.
Je politickým analytikem Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins je držitelem doktorského titulu ve vojenské historii se zaměřením na vietnamskou válku (hnědé vodní námořnictvo), americké námořnictvo od počátku, občanskou válku a ranou moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat a získat Down Range na breitbart.com/downrange.
Oslovte ho přímo na awrhawkins@breitbart.com.
„Doufáme“, že Biden má plán na zvládnutí titulu 42 Konec, „Pokud ano, nesdíleli to plně“
V pátečním vydání NBC „MTP Now“ guvernér Colorada Jared Polis (D) řekl, že má „velké obavy“ nad tím, co se stane, až hlava 42 skončí v květnu, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že „Pokud ano, ještě to s námi plně nesdíleli.“
A řekl: „Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili.“
Polis uvedl, že si přeje, aby během setkání guvernérů v Bílém domě bylo věnováno více času otázce imigrace, ale problém „přišel“.
Měli jsme tam část ministra Mayorka.
A tak jsme znovu uvedli, že existuje mnoho obav, které sdílím ohledně toho, co se stane, až hlava 42 skončí v květnu a tak, aby se ujistil, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě se s námi plně nesdíleli.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pětkrát nebo třikrát, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stáhne „nevkusnou“ reklamu poblíž krematoria - RT World News
McDonald's se omluvil poté, co byla reklama na hamburger „McCrispy“ řetězce rychlého občerstvení umístěna blízko krematoria ve Velké Británii - ačkoli někteří místní obyvatelé viděli legrační stránku.
Řetězec restaurací se zavázal odstranit urážlivé hromadění reklamy na základě stížností obyvatel Truro ve britském hrabství Cornwall.
V pátek si získala pozornost na sociálních médiích za to, že byla umístěna na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí ukazující na krematorium, byla některými rozzlobenými místními obyvateli označena za „nevkusnou“.
„I když vidím tu vtipnou stránku, je bez chuti a jsem si jistý, že někteří truchlící členové rodiny ji nebudou rádi vidět při návštěvě Penmount na pohřeb a kremaci milovaného člověka,“ řekl obyvatel, jehož tchyně byla zpopelněna v pohřebním ústavu loni, jak citují britská média.
Ne každý však byl tak uražen nešťastným umístěním reklamy, přičemž jeden poznamenal, že reakce člověka na ni by pravděpodobně byla ovlivněna „jak dávno jste sledovali nápis krematoria s černou kravatou“.
Jedna osoba uvedla, že „spadli ze židle se smíchem“, když si všimli reklamy online, zatímco jiný místní také poznamenal, že to není „o nic horší“ než rozhodnutí rady pobavit myšlenku umožnit výstavbě krematoria „vedle vesnice pro důchodce“.
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek brzy poté, co se obraz reklamy stal virálním online, ve kterém řetězec restaurací uvedl, že reklamu odstraní co nejdříve.
„Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. Ve světle obav vznesených společností CornwallLive jsme však požádali o odstranění naší reklamy, „uvedla značka rychlého občerstvení.
Rada v Cornwallu, která provozuje jak krematorium, tak autobusový přístřešek, který zobrazuje reklamu, odmítl komentář k rozruch, když byl kontaktován místními médii.
Chybějící žena „Střevní instinkt“ není v řece
Hledání pohřešované Angličanky Nicoly Bulleyové vstoupilo 16. den poté, co její partner řekl, že jeho „instinkt střeva“ spočívá v tom, že není v řece.
Policie v Lancashire uvedla, že důstojníci udržují „otevřenou mysl“ a nadále žádají o informace o paní Bulleyové, která zmizela 27 Ledna při venčení svého psa v St Michael's na Wyre.
Síla pokračuje v hledání řeky Wyre směrem k moři v zálivu Morecambe a pracuje na jedné hypotéze, do které mohl spadnout 45letý muž z Inskipu.
Jejich pátrání pomáhali odborníci a potápěči z pobřežní stráže HM, horská záchrana, a Lancashire Hasičský a záchranný sbor, s nasazenými čichacími psy, drony, a policejní vrtulníky.
Paní Bulleyová zmizela při chůzi svého springršpaněla Willow poblíž řeky, krátce poté, co upustila své dcery, ve věku šesti a devíti let, ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner, Paul Ansell řekl, že chce ponechat „všechny možnosti otevřené“ ohledně jejího zmizení, ale jeho „instinkt střeva“ mu říká, že není v řece.
Popsal paní Bulleyovou jako „zábavnou“, „milující“, „nejvěrnější kamarádku, jakou jste kdy mohli mít“ a „výjimečnou matku“, která „absolutně zbožňuje naše dívky“.
„Je to jen pilíř síly pro naši rodinu a bez ní je díra větší, než si dokážete představit,“ řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází „bezprecedentním peklem“, naděje, že jeho partner bude nalezen, je „silnější než kdy jindy“.
Policie zlevnila faul a incident považuje za vyšetřování pohřešované osoby.
Ve čtvrtek, zaměření jejich hledání se změnilo ze St Michael's na přibližně 10 mil po proudu, kde se řeka vlévá do moře v zálivu Morecambe, s hlídkovými a záchrannými čluny spatřenými v této oblasti.
Poslední komunistický vůdce východního Německa zemřel ve věku 95 let
BERLÍN - Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během turbulentního funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95.
Modrow zemřel brzy v sobotu, parlamentní skupina levicové strany tweetovala.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval do vlády opoziční síly, ale nemohl zpomalit shromažďování hybnosti pro znovusjednocení Německa.
„Celý mírový směr nastolení německé jednoty byl právě jeho zvláštním úspěchem,“ napsala levice na Twitteru. To zůstane jeho politickým dědictvím.“
Během 16 let jako šéf komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst postavy proti establishmentu.
Odmítl párty výhody a trval na tom, že bude žít v normálním bytě.
Post v nejvyšším vedení východního Německa mu vyhýkal, dokud nebyl jmenován předsedou vlády, což je pozice, která dříve měla malý dotek, v listopadu 1989 - dny po pádu Berlínské zdi.
Když vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro začátkem prosince rezignovali, Modrow se ukázal jako nejvyšší politická postava východního Německa.
Ale komunisté už nemohli sami volat výstřely.
Následující měsíc souhlasil se sdílením moci se stále hlasitější opozicí a posunul se do mezníkových prvních svobodných voleb východního Německa do března 1990, uprostřed rostoucích nepokojů.
I když prodemokratické shromáždění rychle získaly příchuť pro sjednocení, komunisté se zpočátku stavěli proti řeči o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se západním Německem o případné „sjednocené vlasti“, která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow vedl volební kampaň restylovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nestačila na to, aby jim zabránila skončit jako třetí nejsilnější strana s 16procentní podporou.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu spojilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde seděl až do roku 1994, a čestným předsedou postkomunistické PDS - předchůdce dnešní opoziční levice. Od roku 1999 do roku 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho přivedla k soudu několik let po znovusjednocení.
V roce 1995 jej soud odsoudil za podněcování k falšování výsledků v květnových komunálních volbách v Drážďanech.
Přinesl mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný, a tvrdil, že jeho výsledek zhorší rozdíly mezi východními a západními Němci.
Jeho právník tvrdil, že napravil předchozí nespravedlnosti tím, že dohlížel na svobodné volby jako předseda vlády.
Později v životě Modrow sloužil v radě starších levicové strany.
„Hans byl hluboce upřímný a bojovný socialista,“ napsal na Twitteru předseda parlamentní skupiny levicové strany Dietmar Bartsch.
„Až do stáří byl důležitým poradcem naší strany, jehož moudrost bude chybět.“
Indická vláda stáhne výzvu k objetí krav na Valentýna po kritice
Objímání krávy na Valentýna již indická vláda nepodporuje - přestože dříve žádala lidi, aby tak učinili, aby propagovali hinduistické hodnoty.
Indická rada pro dobré životní podmínky zvířat (AWBI) odvolala svou výzvu „Cow Hug Day“ poté, co vzbudila kritiku ze strany politických soupeřů a uživatelů sociálních médií.
Indické vládní ministerstvo vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k objímání krav byla „naprosto šílená, vzdorující logice“.
Dodal, že rozhodnutí stáhnout odvolání bylo spíše „zabránit tomu, aby politika hindutvy [hinduistického nacionalismu] byla zesměšňována tváří v tvář tvrdé kritice ze všech stran“.
AWBI v pátek odmítla své odvolání a řekla, že „stojí stažena“.
Bylo to teprve ve středu, kdy jeho prohlášení znělo, že „objímání krav přinese emocionální bohatství a zvýší individuální a kolektivní štěstí“.
Více informací o Indii
Dodal, že kráva je „páteří indické kultury a venkovského hospodářství... kvůli své výživné povaze jako [matka]“.
Na počáteční oznámení došlo ke smíšeným reakcím, protože některé zveřejňovaly videa krav, které odmítly objímání a odbíjení.
Jiní chtěli objasnit, že přitažlivost byla spíše pro sledování vlastní kultury, na rozdíl od „slepého“ následování západních hodnot.
Mladí indiáni obvykle tráví Valentýna přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Mazlení krav není nic nového - protože je považováno za terapeutické v některých částech světa a v Nizozemsku, kde je známé jako „koe knuffelen“.
Oddaní hinduisté uctívají krávu - známou jako gau mata nebo „mateřská kráva“ - a většina států v Indii zakázala porážku krav.
V posledních letech, někteří hinduističtí zastánci tvrdé linie přepadli obchody prodávající předměty na Valentýna, spálené karty a dárky, a vyhnali páry držící ruce z restaurací a parků, trvající na tom, že den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Narendry Modiho tvrdí, že jeho vláda prosazovala hinduistickou agendu, usilující o nadvládu náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, většinu zbytku tvoří muslimové, křesťané, sikhové, buddhisté a džinisté.
Chodec zemře v nemocnici po havárii s autem v Cowdenbeathu, když byl muž zatčen
Chodec zemřel po srážce s autem ve Fife.
38letá žena byla převezena do nemocnice Victoria v Kirkcaldy po havárii na Broad Street v Cowdenbeath v pátek kolem 13:30.
V souvislosti s havárií byl následně zatčen 24letý muž.
Policie apeluje na všechny svědky nebo kohokoli, kdo má záběry z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: „Naše dotazy pokračují a apelujeme na každého, kdo byl v této oblasti a kdo byl svědkem havárie, aby se dostal do kontaktu.“
Chtěl bych také apelovat na každého, kdo řídil v této oblasti a kdo může mít záběry z palubní kamery, které by mohly pomoci našemu vyšetřování, aby nás kontaktovali.
„Každý, kdo může pomoci, je požádán, aby zavolal na 101 policejní Skotsko s uvedením incidentu číslo 1638 z pátku 10. února 2023.“
V ČÍSLECH: Městské části Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla emigrovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu, k cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, stoupne na více než třetinu.
V Oslu tvořili občané z Asie, včetně Turecka, největší skupinu přistěhovalců, s více než 62 985 těchto státních příslušníků žijících ve městě, podle údajů národní datové agentury Statistics Norway (SSB).
Poté tvořili občané EU, EHP a Velké Británie druhou největší skupinu, která představuje ne daleko 10 procent populace města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, v Oslu žije 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Velké Británie, EU nebo EHP, byli čtvrtou největší skupinou s 15 566 obyvateli Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen plachých 7 000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo přes 3 000 státních příslušníků.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrť s nejvíce zahraničními obyvateli.
V roce 2022 tam bylo zaregistrováno asi 18 257 zahraničních obyvatel.
Poté měla módní Grünerløkka, která se nachází přiměřeně centrálně, druhý nejvyšší počet zahraničních obyvatel se 17 631.
Gamle Oslo mělo také významnou populaci přistěhovalců, přičemž po přestěhování z jiné země tam žilo 17 631 lidí.
Statistiky Norské údaje ukázaly, že cizinci byli rozptýleni po celých městských částech, protože Søndre Nordstrand, čtvrť nejjižněji v Oslu, tam zaregistrovala více než 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl okresem s pátým největším cizincem.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořili zbytek deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra nazývalo Marku domovem jen 184 zahraničních obyvatel a něco přes 700 žilo v centrální části města.
Ullern, Vestre Aker a Nordstrand tvořili ostatní čtvrti s nejmenším počtem zahraničních obyvatel.
V těchto čtvrtích však žilo podstatně více přistěhovalců než ve středním Oslu a Marce.
Ti ze zemí EU a EHP a ze Spojeného království většinou žili ve Frogneru, Grünerløkce, Gamle Oslu a St. Hanshaugenu.
Mezitím, zatímco spousta občanů z Asie, včetně Turecka, také pobývala ve hře Oslo (5 837), většina byla zaregistrována jako žijící ve městských částech Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Norstrand.
Ti ze Severní Ameriky byli rovnoměrně rozloženi po Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky byli nejčastěji nalezeni ve Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království měli tendenci žít v nejcentrálnější části města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek státních příslušníků z Oceánie byly Frogner, Grünerløkka a Gamle Oslo čtvrtí s nejvyšší populací těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
Autor: Florence Tan
BENGALURU (Reuters) - Zimbabwe začne provozovat novou jednotku ve své jediné uhelné elektrárně do března, říká náměstek ministra energetiky země a poskytne pomoc milionům občanů otřesených častými výpadky elektřiny v posledních měsících.
Nová jednotka elektrárny Hwange zvýší instalovaný výkon afrického národa o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, Řekla Magna Mudyiwa, aniž by uvedla časovou osu.
Méně než polovina ze 16 milionů občanů Zimbabwe má přístup k elektřině a globální tlak na financování nové uhelné kapacity omezil schopnost země zapojit chronické výpadky proudu, které v posledních dnech trvaly až 18 hodin.
„Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v tuto chvíli generujeme mnohem méně než to, asi 1000 MW,“ řekl Mudyiwa agentuře Reuters.
„Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit,“ řekla.
Nedostatečné srážky vedly k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné elektrárny v průběhu času prudce poklesla, zatímco poptávka po energii v posledních letech vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících růstové vyhlídky Zimbabwe.
Nedostatek finančních prostředků na uhelnou energii vede hospodářství závislé na těžbě a zemědělství k dovozu nákladné energie z regionálních sousedů včetně Zambie a Mosambiku.
(Autor: Sudarshan Varadhan; Editace Jacqueline Wong)
(PERSON11) Ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně -
V podstatě velký obchod, nebo něco není v pořádku.
Tak, některé soubory jsou stále - stále mají divný výstup.
Ale - ale pro většinu složek, mělo by to být již v pořádku.
(PERSON1) Dobře, díky.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé, že, [PERSON7], přemýšleli jste o [PERSON11].
A [PERSON11] nyní má čas.
Existují i jiné věci, na které jsem přemýšlel [PERSON11], a to by bylo školení, prázdných systémů, aby provedly zkrácení.
Tak, jestli ty, [PERSON11], měl čas.
Očividně, neexistuje způsob, jak bychom to mohli udělat příští týden.
Ale opravdu bychom měli mít systém - připraven -
Podíval jsem se na tutoriál z NLP - bylo to?
(PERSON6) Pro nadcházející relace jsem se zeptal na poptávku, protože jsem viděl ukázku projektu (meme).
Dělají offline titulkování.
Tak, to je o něco jednodušší než to, co děláme.
Stále mají stejné problémy se segmentací a tak dále.
Jejich poslání v překladu je však zkrácení jednoduše proto, že se data zkracují.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech je jako přirozené zkrácení.
Bylo by skvělé, kdybychom také mohli lokalizovat takový typ dat tam, kde dochází k přirozenému zkrácení.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože potřebuji zjistit, který z nich je ten, který získává průkazy.
Takže, jakmile to vím, mohu to sledovat, takže, pro budoucnost -
Nebo vlastně, pro budoucnost bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset provést převod.
(PERSON6) No, tohle by vlastně mělo být -
Pořád mě slyšíš?
Kvalita zvuku je o něco horší.
Tak, to by mělo být opravdu provedeno, po celou dobu.
Takže pokaždé, když spustíme toto hodnocení, mělo by být spuštěno od nuly.
Takže pokaždé by mělo být nové stažení nové konverze a nové hodnocení.
(PERSON8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript a mohl by se postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, uvidím to později.
(PERSON6) Takže toto je důležitá věc, se kterou jsme se měli setkat před měsíci.
Pamatujte, že od srpna vám říkám, že chceme vyhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejste to jen vy osobně, [PERSON8].
Byly tam i jiné věci, očividně.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si, že „to bude snadné, prostě to spustíme“.
A jen když to skutečně uděláte, vidíte všechny problémy.
Takže je to známo, běžné.
Vždycky je to tak.
Takže to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, jaký bude problém.
Takže například hovor, který jsem měl, ve kterém se mnou někdo pohovořil, takže chtěli video nahrát.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Než to uděláte, nemůžete říci, zda to bude fungovat nebo ne.
A tady narazíme na problémy převodu formátů souborů.
Tak, doufejme, budeme schopni rychle získat čísla.
Tak, máte zatím nějakou chybovost slov?
(PERSON8) Ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně hluku.
Požádal jsem tedy, abyste měli různé verze tohoto slovníku tím, že vezmete pouze slova, která byla pozorována, pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo více, nebo něco takového.
Tak, tyto náhodné chyby, jako například příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba řekne toto „alzo“, pokud si pamatujete, pokud řekne toto „alzo“ s „Z“ 20krát v rozhovoru, pak to uvidíte v datech s „Z“.
A pokud se mu někdy podaří říci také správně, pak jo, znovu, uvidíte to v datech.
Tak, Chtěl bych, [PERSON4] být v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, že?
Budu muset odejít, protože musím dát dětem oběd a tak dále.
Ale prosím, zůstaňte na tomto hovoru a společně zjistěte, jak tento slovník používat.
Takže [PERSON4], prosím ukažte [PERSON2] jaký je slovník, který systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste do tohoto souboru vyslali.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Tak, slovník bude mít tři kol. ns.
Grafém, jak je výstup.
Jeden poznal.
Fonémy, jak [PERSON2] navrhl.
A bude existovat více řádků s různými variacemi fonémů.
A třetí sloupec n bude pro všechny opět stejný a opět bude stejná grafémová forma.
To je, když jazykový model vidí.
A myslím si, že tímto způsobem by tyto systémy měly být schopny je načíst.
A možná také narazíte na ještě jeden problém: že není připraven na dva velké vlastní slovníky.
Tak, to je také něco, co musí být testováno, ale prosím otestujte to, vy dva společně.
Takže [PERSON2] ví, co vytvořil ve slovníku.
A víte, jak vypadá slovník, když jej vytváříte ručně, a musíte tyto dvě znalosti dát dohromady.
Ah, aby to fungovalo s, s generovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Jo, jistě, probereme to.
(PERSON6) Jo, takže je tu ještě něco, [PERSON2], které máš?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který lze použít pro časové razítkování.
Nejsem si jistý, jak dobré to bude, protože se to snažím udělat na (Libry) Speech.
A když jsem to stahoval, tvrdili, že má více než 600 hodin.
Ale pak školení říkalo, že skutečná tréninková sada obsahovala jen asi 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými řečníky.
Například v angličtině nebo češtině jsem pozoroval strmější konverze.
A teď to nebude konvertovat tak rychle.
Pokud tedy během tréninku odebereme nějaké vzorky.
Pak stále existují některé závažné chyby ve výstupu ASR.
Tak, Doufám, že pro časovou razítku, je to dost dobré.
Nebo to alespoň zkusíme.
(PERSON17) Dobře, to je dobré, jo.
Tak, Začal jsem, ale myslím, že jsem ti nikdy nedokončil e-mail, protože jsi mi připomněl, [PERSON8], že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že je to také důležitá zpráva pro [PERSON5], který z hovoru opět zmizel.
Důležitým poselstvím tedy je, že ano, je velmi dobré, že aktivně tlačíte, aby vaše výsledky byly integrovány, a každý by to měl dělat.
A zároveň musíme mít nastavení, abyste to mohli skutečně integrovat a otestovat sami.
Takže tomu říkám „integrace do-it-yourself“.
Tak, [PERSON8], při práci s [PERSON5] a při dokumentování toho, jaká jsou nastavení, ujistěte se, že je dostatečně dobře testováno kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykových modelů a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou součást, měl by mu být celý kanál přístupný přiměřeně snadno, aby si ho mohl sám vyzkoušet.
Tato integrace do-it-yourself je tedy důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že jo?
Filtrování vulgárních výrazů, bylo testováno na protokolech?
Myslím, že to bylo.
(PERSON8) Jo, myslím, že to bylo testováno na protokolech.
Takže teď je čas vyzkoušet to na živých potrubích.
A znovu si myslím, že je lepší, když [PERSON8] vysvětluje [PERSON4], jak to udělat, takže [PERSON4] to provozuje pro sebe některé pracovníky a živě hraje některé z problematických souborů, jako je použití [PROJECT8] nebo cokoli jiného.
Prostě si je zahrajte.
Sledujte zvukový výstup na vašem zařízení a podívejte se, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité jej nejprve ladit pomocí souborů protokolu a pak je důležité jej ladit v potrubí.
A pokud toto ladění může provést autor této komponenty, zde, v tomto případě [PERSON4], by to bylo nejúčinnější pro nás všechny.
Tak, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou integrace jako do-it-yourself.
(PERSON17) Jo, takže pro angličtinu s více přízvukem.
Takže nyní [PERSON14] to dáváme dohromady do jediného technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a udělá to napříč různými řečníky.
Budou to tedy opravdu věty s více řečníky, a proto by mohla být také vylepšena robustnost vůči různým akcentům těchto reproduktorů.
Ah, takže to je experiment s částicemi.
A později, můžeme udělat něco víc s věcí s více přízvukem.
Tyto nové věty se tedy ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět co největší sadu vět.
A chystáme se vytvořit nové věty z textového jazykového modelu přidáním zvukové části k tomu, aby jazykový model byl pro ASR lepší a robustnost vůči různým reproduktorům by byla také lepší.
A včera v přednášce jsem slyšel další nápad.
Bylo to během tréninku.
Ze zvuku vypadávali časová pásma a frekvenční pásma.
Školili tedy na narušených vstupech, což také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoli jiný může pracovat na věci s nepůvodním přízvukem.
Dobře, pak další věc, kterou jsem si všiml, je - to je v pondělním testovacím dokumentu.
Je zvýrazněn čtyřikrát.
Když tedy probíhá nějaká relace, potřebujeme jména a terminologii pro tuto relaci.
A musíme ji sbírat, připravit ručně, trochu ji vytvořit.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Takže v tom je určitá dovednost b, kterou je třeba procvičovat.
Takže jsem docela zručný v míchání textových souborů.
A kdykoli vidím, jak to někdo z vás dělá, pak mám rád vždy v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tam je tato dovednost něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo by za to byl zodpovědný.
A obávám se, že jedinou osobou pro to může být [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoci s okamžitou adaptací domény, křupání dat, řekněte to prosím.
A pak potřebujeme -
Jakmile tedy zajistíme slovník termínů a bez ohledu na výslovnost slov, potřebujeme techniky, jak tyto slovníky použít v systémech.
Můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal pro všechny relace, byl, že to nebylo ve skutečnosti vidět v hybridním ASR.
Tak, jedno takové zasedání se opět uskuteční toto pondělí.
[PERSON9] již začíná sběr dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Pokud byste se vy tři mohli setkat a dvakrát zkontrolovat, co [PROJECT5] dělá s -
Není to [PROJECT5], ve skutečnosti je adaptace domény pro sadu nástrojů [PERSON18], že jo.
Tak, to je druh zpětného pohledu, ujistěte se, že starý přístup funguje.
V současné době je naprosto nemožné provést jakoukoli adaptaci domény pro plně neurální ASR.
Uvažuji tedy o tom, že máme nezávislé klíčové slovo, které bude detekovat ze zvuku a nějaký postup slučování.
Takže bychom mohli mít dvě ASR spuštěné současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení [PROJECT5] přizpůsobené doméně, které se používá pouze k rozpoznání klíčových slov.
A když uvidíme klíčové slovo ve verzi přizpůsobené doméně, pak bychom použili tuto větu z [PROJECT5], což je obecně horší, ale obsahuje správné výrazy.
Takže to je můj návrh toho, co bychom mohli udělat.
A dalším návrhem je, že bychom opravdu měli mít vlastní plně neurální ASR a provádět různé experimenty s jemným zjemněním a tak dále.
Tak, diskutovali jsme o tom s [PERSON14].
A, [PERSON14], existuje nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
(PERSON17) to jo, takže pokud existuje někdo jiný, kdo by na to byl zvědavý, dejte mi prosím vědět nebo se ozvte.
Tak, je to něco, co by bylo obecně přijato dobře jako papír, protože to lidé ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže bychom tam opravdu mohli mít dopad.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat k tomu v současné době používáme, protože například, jako kdybyste zkontrolovali modely [ORGANIZATION4] na [ORGANIZATION5], že jsou v těchto věcech jako už docela dobří -
(PERSON6) A myslím, že pokud se nám líbí -
Pravděpodobně bychom z nich mohli získat data, protože máte tak velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčího na [ORGANIZATION5].
A měl jsem tušení, že bychom mohli použít nějaký nástroj ke stažení v podstatě některých druhů filtrovaných videí z [ORGANIZATION5] a udělat z nich tréninkové testy tréninkovou sadu.
Tak, Plánuji to udělat sám.
Mám v plánu tam jet, ale potřebujeme záložního člověka.
A také pro událost [PROJEC210] potřebujeme někoho, kdo by se postaral o nahrávku,
Takže osoba archivátora, abychom tu relaci znovu neztratili.
A důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A navrhl jsem zde v odstavci pro [PERSON2], že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by rostly.
Myslím, že by to bylo asi nejjednodušší umístit tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnoceny po každé nové hodnotící kampani.
Příprava těchto tabulek může být obtížná.
Tak, Zeptal jsem se [PERSON7] a [PERSON7] bohužel během tohoto hovoru nebude k dispozici.
Abychom nám řekli, zda [ORGANIZATION242], což je webové řešení.
Některá začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANIZATION242] nedoporučuje [PERSON7].
Tak, jednoduchý html je pravděpodobně způsob, jak jít.
Tak, jakmile [PERSON2] má tato hodnocení vyčištěna.
To znamená přesunout několik skriptů tam, kam patří, z testovací sady [PROJECT3] a nějakého automatického běžce.
Pak také vytvořte převod z tabulek na html podobný technologické konverzi a poté tyto výsledky pravidelně vkládejte na svou webovou stránku.
Nebo to, co byste dokonce mohli udělat, je mít úplný git check out přímo umístěný v tomto veřejném html nebo singling z tohoto veřejného html.
Aby to bylo okamžitě přístupné přes web, a kdokoli by se mohl podívat na aktuální spalování a prozkoumat to.
Tak, to by bylo užitečné, zejména pro m lidí mimo [ORGANIZACE2], jako je, [ORGANIZACE15].
Víme, že mají rádi -
Výkon byl pro některé soubory špatný, a mohli jej přímo procházet na webu m.
Mohli si to také prohlédnout ve skutečnosti na [ORGANIZATION101].
Je jen na vás, abyste jej nastavili tak, aby byl uživatelsky přívětivý a snadno sledovatelný.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, dík.
Nyní pracuji nebo se chystám aktualizovat předváděcí papír, který má být příští pátek, pokud se nemýlím.
A pak musím udělat nějaké projektové zprávy a začínám shromažďovat dokumenty - nebo odkazy na dokumenty, ještě ne samotné dokumenty, pro obě sezení.
(PERSON11) <parallel_talk>Také pro ASR bychom měli přidat bezplatnou metriku -
Vlastně více, měli bychom přidat doplňkové splněné- tyto doplňkové metriky</parallel_talk>.
Tak, zmínil jste jeden a to je filtrování vulgárních výrazů m hodnocení.
Takže <parallel_talk>máte explicitní seznam věcí, které se nesmí objevit ve výstupu</parallel_talk>, že?
<parallel_talk>A pak hodnocení vzácných slov.
A tady máme explicitní seznam jmen a termínů, které chceme objevit ve výstupu, bodované nejen podle (pořadí) sazby</parallel_talk>, ale skóre něčím, co tyto věci přímo zohledňuje, že?
Ano, takže naprosto souhlasím.
To zahrnuje také ruční přípravu reference.
<parallel_talk>Oba tedy potřebují ručně vytvořené reference.</parallel_talk>
Mám jednu poznámku z [PERSON1].
Takže <parallel_talk>[PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit.</parallel_talk>
Takže by se to mohlo stát prázdnou součástí druhé věci vzácného slova -
Takže <parallel_talk>toto by bylo vzácné hodnocení slov pro MT a pak z [PROJEC210] pravděpodobně také dostaneme nějaký</parallel_talk> slovník.
Takže to by samozřejmě byla doména [PROJEC210].
A [PERSON2], mohl bych vás požádat o revizi <unintelligible/> domény a vytvoření takového slovníku pohledem na výstupy a to, co ve výstupech chybí.
Stejně jako užší výběr - seznam slov, která se nám líbí, a v doméně se nám nelíbí. <unintelligible/>
Mohl bys to udělat?
(PERSON11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Takže si to zapíšu.
Takže, <parallel_talk>zaměřit se na termín [ORGANIZACE62] se studijním příspěvkem s titulky</parallel_talk>.
Ano <parallel_talk>a poté multi-source s [PERSON7] nebo na základě [PERSON7</parallel_talk>] nebo -
A pokud jde o jazykové ID, Zajímalo by mě, jak jej chcete integrovat přesně proto, že již zahrnuje zvážení více zdrojů ASR, více kanálů, jaký by tedy byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude to zvuk pro textového pracovníka a bude vydávat časová razítka jako pro čtyři nebo dvě sekundové okno a třídu.
<unintelligible/>ticho, česky, německy, anglicky, a pak nechám ostatní, jak to chtějí používat.
(PERSON11) To je důležité.
Toto <unintelligible/> shrnutí prosím napište sem do dokumentaristu, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], dobře a také možná [PERSON5].
Pokud máme tento nástroj, musíme (odeslat) zvuk více ASR nebo více pracovníkům <unintelligible/>
Samostatně budeme muset (odeslat) zvuk do anglického ASR, zvlášť do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také tomuto jazykovému ID pracovníkovi a pak musíme tyto výstupy sloučit, a to je nástroj, který ještě nemáme.
To je vícezdrojový nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a vysílá - pravděpodobně by to chtělo vytvořit výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Potřebujeme tedy filtr pro ASR, aby ASR mlčel, pokud je to špatný jazyk, a pokud je to správný jazyk, je to rozpoznaný text.
Právě jsem si vymýšlela tento typ nastavení.
Dalším nastavením by bylo, že stejný zvuk je dodáván do ASR a této kontroly jazyků.
Tato jazyková kontrola je v podstatě součástí ASR a umlčí ASR, pokud je to nesprávný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Tak, prosím, přemýšlejte o tom, jaké jsou naše potrubí.
V ideálním případě si myslím, že nejméně podobný zmatek v řízení atd. by vznikl, kdyby naše modely MT byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná uděláme jen kopii, pokud by byla jako vstup uvedena angličtina, takže bychom na začátku měli vícejazyčné více ASR.
Všichni jdou do angličtiny, a pak z angličtiny půjde do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, toto jazykové ID by ani nebylo potřeba.
(PERSON3) Jde o to, že pokud provádíme analýzu správněji, jednou věcí je možné kontradiktorní hodnocení, jen abychom naznačili, že omezení mají ve skutečnosti dopad na skutečný výstup.
To by bylo hezké a ano, možná analýza pozornosti.
Ale nejsem si jistý, zda by nám to mohlo dát stejné odpovědi, v podstatě, pokud se model omezení účastní nebo nedbá.
(PERSON4) Musel jsem se podívat jen na několik příkladů pozornosti, nedělal jsem žádné statistiky ani nic, a dívá se na omezení, a když to překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti to v tomto smyslu nic nedělá.
Dělá některé obecné chyby překladu, ale ne (jevy), které se snažíme vyřešit.
Když se vrátíme k automatickému vyhodnocení, problém s neshodou spočívá v tom, že výstup je správně skloňován, ale kontext je jiný.
Proto to není stejná slovní forma jako v odkazu, že?
(PERSON4) Jo, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů ano.
Stejně jako v prvních 100 příkladech, které byly automatickým hodnocením označeny jako chyba, 91 z nich bylo správně skloňováno ve správných kontextech.
(PERSON4) A myslím, že pouze dvě nebo tři věty byly správně skloněny v nesprávném kontextu, jako by překlad byl špatný.
A pak jsou některé případy, kdy byl překlad úplně špatný, protože věta byla opravdu špatná, a část musí být<unintelligible/>, ale to bylo jako jeden nebo dva případy.
(PERSON3) Ale snažíte se přizpůsobit přesměrovaným formulářům, když to vyhodnocujete, že?
Ty neděláš žádné...
(PERSON3) -lemmatizace odkazu a-
(PERSON4) Oba, oba, oba, shoduji jak povrchové formy, tak lemma.
(PERSON3) Ach, vidím, oh jo, to jsou dvě skóre, že jo?
(PERSON4) Je to jen skóre dilematu pro (Evropský?) není v tabulce kvůli stolu, jako by se nevešel do papíru <unintelligible/>
Pokrytí je vždy jako 97 procent.
Jen to generuje správná lemmata, jen...
(PERSON3) Ach jo, dobře, chápu to, chápu to.
Pokrytí lemmatu tedy v podstatě říká, zda existuje omezení, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně skloňuje, ale není tomu tak.
(PERSON3) Ach jo, jen nevím, jestli ty, pokud chytíš, <unintelligible/> když jsme mluvili o [PERSON1],
ale jedna věc je, že (rána) je lepší, ale druhá věc je, že lemmata jsou ve skutečnosti správně skloňována ručně,
ale to je další, ne, žádný problém, ve skutečnosti je dobré, že je to <unintelligible/> správné, jo.
Tak, Myslel jsem, že by to mohlo být.
Ale nejsem si jistý, zda na to máme nějaké testovací údaje, ale mohli bychom se pokusit pohrát si s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít omezení a pokusit se místo toho použít synonymní omezení a zjistit nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to jen popisoval nejasně, protože já sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakém stylu přenosu dat pro anglickou češtinu? Máme něco?
(OSOBA4) <unintelligible/>
(PERSON1) Přenesením stylu, Dušan, myslíš, že by existovalo něco, co je v psaném jazyce, a vy byste byli cílovou stranou, bylo by v mluveném jazyce nebo něco podobného?
(PERSON3) No, to je věc jako, mám jen omezené znalosti o úkolu.
Dokážu si však představit, že chcete přepsat větu, že není napsána mužem, ale místo toho je napsána ženou nebo, nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem tak obeznámen s přesnými soubory dat a tím, co pokrývají.
A myšlenka je taková, že styl vět je docela nejasně definován.
Takže znovu, nejsem si tak jistý.
(PERSON1) Máme tento korpus transformací vět.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například, zobecnění vět.
Podrobnosti jsou tedy vynechány, věta je zjednodušena a pak věta zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení Matous dělá nějaký experiment s angličtinou - češtinou, ale nemáme tam žádná referenční data.
Takže nemáme žádnou datovou sadu komprese vět.
Možná by tedy zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediný referenční by byl příliš omezený na to, aby vám řekl něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových transformací, například, to by se dalo udělat <unintelligible/> pro Čechy, takže možná by ten pravý člověk byl Rudolf Rosa, kdyby se ho zeptal, jestli někdy takovou datovou sadu vygeneroval.
Tak, bude existovat generace nějakého větného protějšku založená na kořenech.
(PERSON3) Myslím, že je to vlastně zajímavá otázka, zda můžeme použít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Mohli bychom se tedy zaměřit na to a vytvořit konkrétní dílčí část testovací sady [PROJECT1], která by to pokryla.
Ah, abychom někdy znali pohlaví řečníka, takže pokud ano... možná sdílím obrazovku a procházím ji.
(PERSON8) Nebo jsem to zkusil, když se toho Marian jen zúčastnila a je to... Nevím, o kolik bodů BLEU je nižší.
(PERSON2) Protože stejně jako já věřím, že Martin dělá svůj <unintelligible/> malý překlad, tak překládá více vět najednou a pak vybere jen středovou a jde takto pro celý dokument.
Kontext je tedy jako v jednom <unintelligible/> spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nebyl to Dominik, který dělal nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva roky byl dvojitě prázdný, kde se účastnili kontextu nebo zřetězili kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale věc je, že s tím zřetězení není zcela jisté, zda má stejný účinek jako nastavení více kodérů-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale jsem překvapen, že [PERSON8] říká, že to nefunguje úplně.
(PERSON8) Jo, dobře, tak promiň, možná bych měl mít větší pravdu, že to nefungovalo tak, jak jsem to udělal <laugh/>
(PERSON1) Ano, protože si myslím, že je to metoda, kterou lze velmi snadno testovat, a vždy by měla být testována na rozdíl od dvou kodérů a očekával bych, že někdy bude lepší a někdy horší než dva nastavené kodéry, v závislosti na přesném úkolu, jako je to, co přesně je druhá věc, kterou kódujete.
Takže, možná pokud máte dvě kopie dvě parafráze stejné věty,
Možná je to pro pozornost nějak matoucí, takže cokoli, nevím.
Chování se také může lišit u starých metod sekvence na sekvenci, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak, možná s transformátorem je to jo, je těžší trénovat, takže možná budete potřebovat jakékoli zvýšení počtu zahřívání, zahřívací sady.
(PERSON2) Jo, tak prostě vězte...
(PERSON8) Nepamatuji si, takže si přesně nepamatuji, ale tohle je jako...
když jsem začal v létě s těmi experimenty s více zdroji.
První věc, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná si to teď nepamatuji,
Můžu to zkontrolovat až do příští schůzky, jestli jsem to také zkusil,
Rozhodně jsem se snažil, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Možná jsem se také pokusil, že jsem tyto dvě věci náhodně zamíchal, to jo, a jen si pamatuji, že to hojně dělalo tyto kompenetrační věci a vyzkoušelo více kodérů.
(PERSON8) A bylo to pravděpodobně kvůli nízkým skóre.
(PERSON2)<unintelligible/>, které se vám líbí, může zlepšit vaše skóre vybavení pouhým připojením výstupu založeného na frázách a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Pokud tedy zadáte výstup založený na frázách, je to v podstatě post editace, že? Můžete o tom přemýšlet jako o posteditaci, jako byste posteditoval výstup založený na frázích, že jo? Nebo jako záleží na úhlu pohledu, že?
(PERSON1)<unintelligible/>, že ji chcete plně přepsat, ale technicky přesně odpovídá úkolu posteditace, můžete to připojit jako řešení úlohy posteditace.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální token, který rozlišuje, který je zdrojem a který je kontext nebo druhá věta, nebo je jen zřetězíte bez čehokoli?
A doufám, že se to systém naučí?
(PERSON8) Snažil jsem se, myslím, že dva tokeny a ano, protože v první verzi jsme měli podezření, že token může být také tokenizován sám, takže jsem to přehrál s jiným tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník a tento slovník neobsahoval separační tokeny.
Takže jsem použil nějaký token, o kterém jsem předpokládal, že to nebude jako tokenizované na několik kusů, a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Dalo by se to udělat správněji, jo, souhlasím.
(PERSON2) Ale část baňky nebo komunikační část s klientem je něco, co nemohu udělat.
Protože nemám žádné zkušenosti a nemám čas to rozběhat.
(PERSON1) Myslel jsem, že to znamená něco, co používá Neznám mediátora.
(PERSON2) Ne, vytvořte klienta HTTP, který může vyplnit frontu a číst z jiné fronty.
A pošlete text zpět v požadavku HTTP.
Protože moje představa je, že kliknutí uživatele budou použity i v ukrajinském projektu.
(PERSON2) A můj nápad je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk v malých kouskech současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server jej vložte do fronty, se kterou budu později zpracovávat frontu (ASR).
A model udělá nějakou logiku, nějaký závěr s tím.
A kdykoli má nový přepis, pošle jej zpět, a uživatel by měl získat částečný přepis zpět.
A měl by být okamžitě zobrazen v textovém poli.
(PERSON1) Mohl bych o tom přemýšlet.
Flaska taky neznám, ale jo, můžu o tom přemýšlet.
(PERSON2) Možná jiný HTTP server.
Nevím, možná k tomu ani nepotřebujeme fantastický HTTP server.
(PERSON1) Myslím tím, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to pro to fungovalo.
(PERSON2) Jo, jediným požadavkem je, aby zvládl více připojení najednou.
(PERSON1) Myslím, že online tok textu je alespoň něco kolem 2 000.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustí s malými různými vnitřními pracovníky, takže myslím, jo, takže <unintelligible/> řekněme deset, místo výstupu, soubor <unintelligible/> vedlejším pracovníkem, takže <unintelligible/> máme, takže se jen ujistím, že tyto věci pro jeden soubor se generují paralelně od všech dostupných pracovníků.
(PERSON1) Ach, to by nám ušetřilo čas.
(PERSON7) Jo, jo, to je velmi důležité paralelizovat všechno ve skutečnosti, paralelizovat jak zpracování systémů, tak i vyhodnocení buňky DF, protože by to musel spustit mnohokrát, dojde k chybám, musíte to rychle spustit.
(PERSON7) Dobře, takže díky.
Takže jste tím velmi zaneprázdněni, nechci na vás dávat žádné další věci, takže mi dovolte začít s připomenutími.
Musíme dokončit popis [PROJECT1] stolní sady,
Koho tu máme?
No, ne opravdu, jo, (je to hotovo) a není to tady bohužel.
Tak, to by bylo pro [PERSON2],
Pak hodnocení, toto je pro [PERSON1], ale diskutovali jsme o tom.
Poslouchej, dej mi tabulku v DSD, pojďme sem dát tenkou čáru a zatlačit šablonu tabulky, stejně jako strukturu plánu, do delebl, takže čísla přijdou později, ale chci vidět některá čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuji.
My máme [PERSON5], to je dobré.
Takže pro [PERSON5] bych rád zkontroloval, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také pro vývoj, což je důležitější.
Slyšíš nás, [PERSON5]?
(PERSON1) a poté zjistíme, které balíčky nainstalovat v Petriho prostředí.
(PERSON7) Jo, takže je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte výstupy.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a poté spustíte vyhodnocení.
A důvodem tohoto rozdělení je, že můžete více paralyzovat.
Takže na různých frontách budou problémy, jsem si jistý, a čísla budeme potřebovat velmi brzy.
Pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále udržovat překlad běžící pro zbývající,
a přehodnotit, s sel T F, chybějící, a, a tak dále.
Takže jde o to, že nejde o vytvoření sériového, sekvenčního zpracování, které zahrnuje obojí,
ale jde o to získat výsledky a ve skutečnosti je lepší to udělat v plátcích.
Nejprve získáme všechny výstupy, pak dostaneme všechna hodnocení.
(PERSON1) Jo, takže, myslím, právě teď, dělal jsem to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu komplikovanějšího v dekódování.
Stejně jako filtrování paprsků a nahrazení nosníků různými paprsky.
A jako omezení více tokenů a tento druh věcí.
Ale pro pozitivní omezení, Porovnal jsem tréninkový přístup pouze s těmito velmi jednoduchými věcmi.
Stejným způsobem upravte skóre v každém kroku.
(PERSON7) Dobře, takže zpět k pozitivním omezením.
Zaměřili jste se již na analýzu systému?
(PERSON2) Jo, právě teď čekám na přepracování datové sady z ([PERSON9]).
Také [PERSON9] Podíval jsem se na (kód) a myslím, že vím, proč je to tak pomalé.
Protože pro každou položku v terminologii v přepracování (Europar) otevřete datovou sadu, tokenizujete ji, přečtete řádek po řádku, tokenizujete ji řádek po řádku a poté ji zavřete.
Ale vy to děláte jen vy -
(PERSON4) Takže si pamatuji, že pro [PROJECT1] jsem to dělal z loňského roku z nějaké chaty v horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím předložit.
A <laugh/> tak je to také něco, co se stane [PERSON8] Obávám se, že by mohl být... no, žádná párty, ale možná na vzdálené párty.
A najednou si uvědomí, že to musí předložit.
Tak, v tu chvíli nebude žádná recenze podobných. <laugh/>
Jednoduše by vzal PDF a nahrál ho tak. <laugh/>
(PERSON7) No, dobře.
Tak, Jo, zkontroluji 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že jim raději pošlete e-mail právě teď a požádejte o tento odkaz předem.
(PERSON7) Dobře.
(PERSON4) Ano, děkuji.
(PERSON7) Musíme dnes diskutovat o dalších otázkách, nebo je to všechno až do nového roku?
(PERSON6) Doufám, že pro mě nic nebylo?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo papíry o nástrojích, které byly publikovány jako speciální vydání PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálním, jako by existovaly také problémy PBML, které mísily prázdné maržové papíry a samostatné papíry kvůli počtu těchto papírů.
A dokonce jsme měli něco, jako kdyby papír nebyl dost dobrý pro PBML, ale pokud byl nástroj představen na maratonu MT.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, jak jsem řekl, váš systém, váš nástroj je zajímavý.
Zveřejněte to prosím na maratonu MT mezi lidmi.
Ale váš papír je příliš špatný.
Musíte to vylepšit a dostanete se pouze na další PBML.
(PERSON4) Ano, ale další možnost pro SigDial.
Není možné, že při pokusu o SigDial přitahujeme lepší účastníky.
(PERSON3) To je ano, to je... jako jsem si myslel, že jsem také měl, ale neznám žádné z míst.
V červenci mají konečnou registraci papíru.
Konference se konala v září a předložení příspěvku bylo v květnu.
Protože pro Interspeech bychom to také mohli rozdělit papír po papíře.
Aby některé dokumenty šly do řízení Interspeech.
A některé z našich příspěvků by přišly později pro řízení PBML.
A autoři by si mohli svobodně vybrat.
Abychom to museli vyjednat buď se SigDial nebo Interspeech.
Pokud je pro ně v pořádku mít některé z našich dokumentů, vzhledem k tomu, že tyto dokumenty jsou předloženy do březnového termínu.
Existuje tedy absolutně přísný požadavek.
A myslím, že proti tomu nemohou nic mít.
Protože pokud se papír vyplatí publikovat.
Jako, je to jen bonus, že papír má nějaký sdílený výsledek úkolu, který se objeví v satelitní události.
Takže jo, myslím, že je to v pořádku.
Nemusíme tedy žádat o zvláštní zasedání.
V Interspeech se tomu říká speciální relace, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří připravit svůj příspěvek do termínu Interspeech, pošlete jej jako papír Interspeech a budete jej mít v Interspeech.
Ah, pokud to neuděláte, ah, udělejte to pro termín Interspeech, tady je náš termín.
A to je pro PBML.
(PERSON7) Ah, dobře.
Ale věc je jako pro satelitní událost Interspeech.
Ehm, Interspeech like se nedostane do žádného řízení.
(PERSON2) Můžete si myslet, že si můžete jen rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že to není věc, aby selhal v jeho kurzech.
Rád selhávám, protože to nedokážete dokončit.
Samozřejmě, jako by se lidé prostě vzdali, ale myslím, že je to možná z jiného důvodu, že je nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám na začátku semestru řekl, že pokud chceme jeden (??) dostaneš jednu.
Jen ve druhém termínu byste ji měli odeslat.
To je skoro jediná věc, kterou žádal.
Ale také nám řekl, že soudě podle trendů minulých let to mnoho lidí nedělá.
Je pro ně snazší číst na zkoušku.
Ne, promiň, studium na zkoušku...
(PERSON2) Jo, protože obecně, jeho zkoušky jsou poměrně snadné.
(PERSON2) Takže bych neřekl, že je to super snadné, protože existují kurzy, kde je zkouška jako zábava.
(PERSON1) No, jeden z nich byl včera pro mě.
(PERSON2) Jo, když má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se opravdu zavazuje k něčemu, co například za sekundu nebo dvě zjistí oh, no, ve skutečnosti to byl špatný překlad.
Snaží se tedy použít jiné znění.
Chcete-li například určit věc.
Vlastně se mi to opravdu líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když jste viděli, že model udělal chyby při prvním pokusu, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo opravdu plynule, což je podle mě také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je zbytečný.
Ale pokud nižší kvalita je proto, že překlad, pokud si přečtete vše, dostanete stejné informace, ale znění je prostě špatné, protože používalo například více slov a používalo nějaké opravy a podobně.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako některé příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
(PERSON2) Určitě, mohu vám vyhodit své záznamy.
(PERSON7) Ale v jakých jazycích?
Protože víš, že neumím německy.
(PERSON2) Angličtina a němčina.
(PERSON7) Jo, ale nemluvím nutně německy<laugh/>.
(PERSON2) Pak mohu poskytnout angličtinu-čínštinu a angličtinu-japonštinu, pokud to pomůže. <laugh/>
(PERSON2) Takže opět chci, aby to bylo lidsky čitelné.
Protože toto blikání je opravdu nepříjemné a pak se ztratíte soustředění na to, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a o tom, jak pracujeme s informacemi.
Promiňte, nikdy jsem o tom do hloubky nepřemýšlel.
Ale myslím si, že kdykoli uvidím slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš jako taška.
Takže jsem dal slovo do tašky.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je problém s tím blikáním.
Pokud něco přeložíte a pak to změníte, pak jsem to vlastně už četl, je to v mém mozku.
A pak jsem ztratil soustředění a kontrolu nad tím, co bylo vlastně přeloženo jako správné a nebylo to, co nebylo.
Proto si myslím, že celá ta věc s blikáním je podle definice špatná a hloupá.
Jako bych viděl motivaci, jako byste chtěli zobrazit vše, co máte.
I když nemůžete slíbit, že je to dobré.
Ale myslím si, že s těmito dodatečnými informacemi nemůžeme pracovat.
A myslím, že možná problém je v tom, že systémy vytvářejí lidé, kteří s ním pracují.
Pokud vyvíjím systém, pak jsem opravdu blázen šťastný, když vidím, že i když neslibuji, že překlad je správný, stále to ukazuji a je to nějak dobré, ale myslím si, že vývojář se opravdu nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíše to, ach jo, můj systém to dokáže vydat opravdu rychle.
A i když to jen odhaduje, že kvalita je v pořádku, myslím, že možná proto byl vytvořen překlad.
Jen vývojáři systémů touží zobrazovat informace, a myslím si, že protože jsme omezeni jako množství informací, které můžeme nějakou dobu vnímat, rádi vidíme, že další informace jsou pro nás jen další zátěží.
Takže si myslím, že není dobré ukazovat navíc.
Stejně jako pokud chcete snížit latenci, pak místo blikání stačí snížit kvalitu.
Myslím, že je to stále lepší, než ukázat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste opravdu potřebovali vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Stejně jako technicky, když lidští překladatelé začnou překládat, mám na mysli cíl i pro anotátory, pokusili by se sledovat řečový řetězec původního mluvčího.
Tak, jsou chvíle, kdy by něco řekli, a to by bylo špatně, takže by se prostě opravili.
(PERSON2) No, ale ano, to znamená s mým řešením, jako byste neblikali, ale zavázali jste se, že neexistuje způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Silně cítím, že naše práce není přesně v oblasti řeči, je nezdravá.
Protože zde není žádný koncept řeči.
Pracujeme přímo na textu.
Jde však o to, že návrh letošního statistického workshopu skončil, což bylo v září, což bylo pro nás příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme některou ze dvou sektilních nebo interspeech, protože oba jsou v komunitě dobře uznáváni.
Můžeme motivovat účastníky, aby se podali.
Ach, jediná výhrada, kterou nyní nacházím, je, že jde o řeč, je, že nám nedovolí prostor ve sborníku, což může některé účastníky odradit, Nejsem si jistý, jak moc budou nadšeni publikováním příspěvku v archivu.
Tak, v archivech, lidé mohou publikovat kdykoli, že jo?
To tedy není přínosem pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
Tak, to byl důvod, proč jsem se zvláště ručil za speciální zasedání.
Ale tentokrát je problém v tom, co chápu, je naposledy, časové období mezi návrhy, předložením a konečným předložením příspěvku bylo pět měsíců, takže by to bylo dost času na náš harmonogram, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh považuji za důležitý možný zdroj nepůvodní anglické řeči, kterou můžeme použít k rozšíření testovací sady.
Takže si myslím, že bychom se měli soustředit na nejjasnější hlasovou soutěž, a pokud budeme muset, můžeme udělat stánek.
Ale rád bych to omezil, protože šíření mezi studenty středních škol má pro nás menší dopad.
Je důležitější použít jej jako testovací relaci.
Měli bychom se tedy zaměřit [PERSON1] na nejjasnější hlas [PROJECT2] a udržet organizátory šťastné, abychom tam mohli shromažďovat data.
A udělejte, co chtějí, abychom udělali výměnou za to, a musíme zkontrolovat jejich plenární program, a jaký typ titulků by byl užitečný pro tento plenární program.
takže by to pro nás bylo testovací sezení, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Pokud se nás tedy zeptají, jestli se od nás opravdu očekává, že budeme tam a přítomni, pak v pořádku, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
(PERSON1) Jo, ještě jsem se o to nepokusil provést registraci, ale myslím, že minule bylo povinné mít stánek.
(PERSON2) Ano. Takže s nimi diskutujte o tom, co je potřeba, aby byli šťastní, a umožňují nám dělat nejjasnější hlas, což je nejdůležitější věc.
Testovací relace je méně nutkání.
A stánek je jen něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se k sezení připojili dříve, než aby dělali takové věci.
Takže tyto přípravy opravdu musíme praktikovat.
S online světem, zdá se, že do relace jednoduše jp, a práce je hotová.
Ale není tomu tak.
Trvá to vždy 30 minut, aby se spustil a správně připojil.
Takže tam musíme být dřív.
A pokud nějaká relace, kterou děláme, začíná v devět, ale organizátoři se sejdou ve čtvrt na devět.
Pak už musíme přijít ve čtvrt osmé, abychom měli 30 minut navíc, abychom se ujistili, že všechno běží a honí lidi.
Takže toto je poznámka pro všechny, že aby vedení fungovalo, prosím také předvídejte, o co by vás vedení mohlo najednou požádat, a to by trochu pomohlo.
Dalším velmi důležitým poselstvím je záznam těchto důležitých relací.
Nevím, jestli jste odpověděli, Neviděl jsem nikoho, kdo by poskytoval jakékoli aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto relací.
Pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, je tedy důležité mít dobré nahrávky těchto relací.
A jedním aspektem je získat souhlasy, aby bylo skutečně povoleno nahrávat.
A i když se pokusíme získat souhlasy zpětně nebo cokoli jiného.
Pak je tu technický aspekt- záznamu.
A viděli jsme, že je to tak rozmanité a složité.
Jo, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, pamatuji si.
2 špatné citrony v řadě :(
Objednal jsem si od této společnosti, protože jsem ji koupil v minulých sezónách a fungovalo to pro nás skvěle.
V této sezoně jsem si koupil další velikost, kterou jsem potřeboval.
Jedno z pyžam, které jsem dostal, mělo díru na úpatí pyžama.
Vrátil jsem to a společnost mi poslala novou.
Náhradní pyžamo, které můj syn nosil jednou, dal jsem ho do pračky stejně jako vždy a zip se zlomil!
Jsem tak zklamaný, protože nemám čas se zabývat návraty každých pár dní, a přesto se to právě teď děje.
Přesně tak, jak je popsáno
Jedná se o základní puffer kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil do vakuově uzavřeného sáčku, takže je třeba jej na několik dní zavěsit, aby mohly vyjít vrásky a trochu se „nafouknout“.
Jsem 5 ft 6 palců a kabát je na mě po kolena.
Objednal jsem si 2+ velikostí kvůli dalším komentářům a minulým zkušenostem a kabát je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale na ní nejsou žádné vazby.
Přední zip funguje.
Na boku ani na zádech nejsou žádné větrací otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase jsou dvě kapsy (mohou být vyšší nebo nižší na vás).
Neexistují žádné obklady ani stylingové detaily - jedná se o ZÁKLADNÍ KABÁT.
Pokud jde o cenu, myslím, že je to v pořádku.
Nosila jsem ho za větrného dne, ale ne zima.
Necítil jsem vítr, takže mám pocit, že je to dobré znamení.
Jsem však zvědavý, jak to bude fungovat v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem potěšen.
Vakuový těsnicí vak lze znovu použít a prodejce zahrnoval opravdu roztomilé poděkování, které bylo skvělým dotekem.
To je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký
To je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký.
Nezmačká se, ani poté, co byl nacpán do plastu a krabice, byl velmi hladký, takže je to opravdu skvělé.
To lze snadno obléknout nebo obléknout, a má jakýsi vintage pocit díky délce a střihu, což mě opravdu baví.
Myslím, že by to mohlo být lichotivé pro každého.
Mám 5'5 „a 130 liber a objednal jsem si malé, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně dolů.
Nepracoval jsem s mým Buickem LeSabrem z roku 1999
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce i předinstalovaná baterie.
I když to mělo být kompatibilní s mým Buickem LeSabre z roku 1999, dálkové ovládání se nepodařilo naprogramovat nebo synchronizovat s autem.
Pokyny jsou dost snadné a vím, že jsem je sledoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý dálkový ovladač.
Tenhle nový by však nefungoval, a tak ho vrátím.
Nebyl problém s prodejcem nebo službou, jen se zdálo, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta byl roztržen velkým něčím letícím po dálniční dálniční dálniční dálniční soustavě, takže jsem potřeboval výměnu.
Po přečtení některých recenzí jsem se bál, že se to nehodí, ale bylo to perfektní!
Vlastním 2013 Corolla LE.
Nedal jsem si to na sebe - měl jsem chlapa v karosářství, který to udělal za mě - ale vypadalo to opravdu snadno.
Prostě se to rozběhla přímo za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože to vypadá docela chatrně (čas a létající trosky to ukáže), ale celkově jsem velmi spokojen s tím, že moje auto už nemá na přední straně zející maw a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Můj 5 letý absolutně miloval toto světlo Netrvalo dlouho, dostal ho k narozeninám v lednu, je únor už má potíže s tlačítky a neběží jasně, když zásuvka požírá baterie, dokonce se pokusil dobíjet baterie Super cool, ale potřebuje zlepšení
Hudební start
Klavír je skvělý předkrm!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruka-oko.
Klavír není jen hrací hračka, ale ve skutečnosti funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě bylo budoucím pianistou, měli byste tento produkt vyzkoušet!
Velmi stojí za peníze!
Dal jsem si to na nos podle pokynů dvakrát denně a třel jsem ho 2 minuty.
Kůže na mém nosu zčervenala a šla úplně syrová.
Byl jsem docela zaskočen.
Měl jsem dobře zahojenou jizvu z pádu do ostnatého drátu před lety.
Nejen, že tento produkt nefungoval, ale téměř jsem skončil v ordinaci dermatologa, ale nasazení aqua-for a bandaid přes oblast ho nakonec asi po týdnu uklidnilo.
Můj nos je stále zarudlá, ale doufám, že to brzy zmizí.
Někdo podělal vzorec?
To je tak divné.
Při normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV zářením jsou stejné!
Nakreslil jsem růžovou čáru pomocí malířské tyčinky od jiné značky, abyste viděli, jak by měla růžová vypadat, a vědět, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl jim říkat červené nebo růžové.
Bílá není tak jasná, jak bych doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy omývají.
Jen jsem rozum, že tam byla růžová.
Myslím, že fialová bude stačit.
pracuje z větší části
Před několika měsíci jsem si vybělila celou hlavu a pak ji obarvila černým barvivem.
Pak jsem šel a nechal si po celé hlavě nasadit zvýraznění.
O několik týdnů později jsem si na vlasy dal modro/zelené barvivo na vlasy Arctic Fox a nevybledlo by to.
Použil jsem tyto věci s Olaplexem č. 3 a to se nesmírně zesvětlilo, odstranilo zelené a modré části a zvedlo tmavé krabičkové barvivo.
Po dni jsem si však všiml zeleného odstínu vlasů.
Každý den se to zhoršuje a já jsem použil extraktor barev dvakrát, se stejnými výsledky.
Moje vlasy také tmavnou tam, kde bylo krabicové barvivo.
Je to skvělý produkt, který prostě nevypadá, že by vydržel.
Nevěřte humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román musí být zmírněn některými realističtějšími hodnoceními.
Snažil jsem se to přečíst, ale prostě jsem zjistil, že jazyk je plochý.
„sladkovodní“ metafora a mnoho popisů lůna jako řeka a dítěte jako ryba se zdálo být vynucené, zmatené a vymyšlené.
Přeskočil jsem dopředu a vypadalo to, že vše, co jsem našel, bylo kampusové drama.
Dávám této knize 10 hvězdiček!
Vynikající čtení!!
Knihu jsem absolutně milovala!!
Za ta léta jsem adoptoval 4 siamské kočky od Siri a všechny z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Legrační, vtipný a velmi zábavný!!
Siri šla nad rámec svého úsilí o záchranu koček (hlavně siamských)!!
Opravdu se mi líbí toto prstencové světlo!
Je to skvělé za cenu a dělá to práci!
Jediným problémem je, že se žárovka zahřívá příliš rychle a světlo zhasne, takže ji musím chvíli vypnout, počkat a poté ji znovu zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám vadné světlo nebo co, ale kromě přehřátí je to velmi pěkné prstencové světlo.
Matoucí děj
S knihou bylo těžké držet krok, protože hodně skákala.
Také název neodpovídá příběhu.
Autor uvedl, že tímto mimozemšťanem bylo nakaženo několik lidí, nicméně vynechány mohou podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a hodně číst, abych se ujistil, že mi nic neuniklo.
Miloval Collinse...
Chvíli trvalo, než se zahřál na Gradyho
3 1/2 Stars Remedy je romantika nejlepšího přítele bratrů a romantika druhé šance smíchaná do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše pro to, aby získal Collinse zpět a dokázal, že je ten chlap pro ni.
Před třemi lety, Grady a Collins měli spolu úžasnou noc.
Collins si myslela, že konečně dostává všechno, o čem snila, nejlepší kamarádka svých bratrů... ale když se ráno probudila sama, a nikdy o ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpět, a on neodchází, a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdává.
Zatímco jsem miloval předpoklad tohoto příběhu, a občas Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale ani neposlat Collinsovi dopis, v němž by se vysvětlil?
Nechat ji přemýšlet a bolet po všechny ty roky, a pak očekávat, že ho přivítá zpět s otevřenou náručí?
Byl klamný?!
Collins měl pravdu, když byl naštvaný, naštvaný, zraněný, atd.
Měla pravdu, když s ním bojovala, když ji chtěl zpět, a posunula se kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collinse v této knize, byla silná, a hlídala si srdce, a za to jsem ji obdivoval.
Určitě milovala Gradyho, ale bála se, a váhala, zda ho pustit zpět do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje oblíbená ze dvou.
Rozhodně nechala věci jít tempem, které chtěla, a když byla připravena poslouchat, poslouchala.
V této knize je spousta úzkosti, a rád jsem sledoval, jak se tito dva znovu spojují, když Collins začal Gradymu odpouštět, Jen bych si přál, aby Grady nevypadl tak kňučel a byl by trochu chápavější.
Stále říkal, že rozumí, ale občas byl na mě příliš ctižádostivý, a pak byl ke konci sladký.
Nakonec jsem ho miloval stejně jako Collins, ale na začátku knihy, Těžko jsem četl jeho názory, protože jsem se nemohl spojit s jeho postavou.
První část této knihy, nebyla moje oblíbená, ale druhá část?
Zbožňoval jsem, proto moje hodnocení.
Pokud máte rádi druhou šanci, a bratři nejlepší kamarádské románky, možná se vám tato kniha opravdu líbí, Zpočátku jsem měl s Gradym těžké časy a jak zvládl některé věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho zobrazení Churchilla, bylo velmi dobře provedeno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otočnými stránkami...
Krajina a kostýmy byly vynikající.
Je uštěpačný, když dnešní dvojice polobohů zastává světovou politickou pozici.
Stojí za to podívat se několikrát... stojí za promyšlené přemítnutí... mnohokrát
Vyhněte se připojení Wifi- jděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V době, kdy, byli jsme uprostřed přestěhování a bydlení v hotelu.
Nemohl jsem dostat tuto váhu, aby se připojila k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domu, a mohl jsem si nastavit vlastní Wifi systém.
Březen 2018- Nastavil jsem svůj systém Wifi a tato váha se stále nepřipojí.
Pokaždé, když se pokusím, zobrazí se chybová zpráva.
I když jsem 10 'od jednotky Wifi.
Sledoval jsem video nastavení YouTube bez úspěchu.
Když jsem jednotku koupil, myslel jsem si, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato stupnice používá směrovač Wifi ke komunikaci s telefonem.
Tento systém je omezen na připojení routeru... který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Nedoporučoval bych tuto stupnici nikomu kvůli připojení Wifi.
Namísto, podívejte se na systémy, které používají Bluetooth pro komunikaci.
Nahrazuji to stupnicí připojení Bluetooth.
Dobře, ale rád bych našel něco lepšího
Po mnoha výzkumech jsem tento produkt začal používat před mnoha lety.
Měl nejmenší množství škodlivých přísad a stále fungoval dobře.
Vysychá však tak rychle, že nakonec použijete tolik lubrikant, což nakonec stojí spoustu peněz, stejně jako příliš rušivé během sexu.
Jen jsem byl příliš líný na to, abych hledal nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš nákladný.
Výdrž baterie je hrozná na té, kterou jsem koupil na Amazonu.
Stále nemůžu uvěřit, že Logitech přerušil toto dálkové ovládání, nic jiného se ve srovnání nepřiblíží.
Absolutně MILUJI tento dálkový ovladač Harmony, toto je můj 4.
Pes rozžvýkal první, manžel poklekl na obrazovce druhého a třetí stále fungují, ale uprostřed dotykové obrazovky je značka lokte, také s laskavým svolením manžílek... koupil tento jako zálohu a obrazovky skvělé, ale baterie, se kterou přišla, má nabití možná na pár dní.
Můj originál (třetí) udržuje nabíjení po celé týdny a na všechno používám dálkový ovladač.
Zlomil se za méně než týden
Líbí se mi produkt, je to pěkná velikost a barva!
Bohužel to měl jen týden a otevřel jedny dveře a praskl horní část dřevěného kusu!
Jsem opravdu zklamaný!
Je to všechno sestavené a já už nemám krabici, tak jak bych mohl vůbec přemýšlet o tom, že ji pošlu zpět?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale bohužel to také nefungovalo!
Dveře znovu vyskočily!!
Není příliš snadné sestavit plus...
Je to pěkně vypadající kus nábytku, když je sestaven, ale montáž byla obtížná.
Některá označení písmen byla nesprávně označena, takže jsem se musel pokusit přijít na to sám. Šrouby, které dodali k připevnění podlahy a bočních panelů, byly prasklé.
Musel jsem jít ven a koupit rohové závorky, abych se ujistil, že zůstanou spolu.
Dveře skleněných panelů jsou také mimo linii a neodpovídají rovnoměrně.
Toto vyrovnání zabraňuje tomu, aby jeden z dveří zůstal zavřený, protože magnet, který udržuje dveře zavřené, je mimo linii.
Stále jsem nepřišel na to, jak je zarovnat.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA HORNÍ ČÁSTI LUSKU
Koupil jsem je v únoru.
Nedávno jsem se je pokusil použít a bohužel pokaždé, když zkusím jeden, můj stroj Keurig mi dává chybovou zprávu, že pod není kompatibilní s mým strojem.
Použil jsem lusky Donut Shop ve svém stroji od doby, kdy jsem je poprvé zakoupil, a nikdy jsem neměl problém.
Při bližším zkoumání kávového lusku jsem si všiml, že kód vytištěný na horní části lusku není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jednu z každé ze 6 políček a stále dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože jiné lusky, které zkouším, fungují dobře.
Pouze z této zásilky mám tento problém.
Velmi zklamáním, protože moje návratové okno vypršelo.
AKTUALIZACE: Mluvil jsem se zástupcem zákazníka, který byl vrácen penězi.
Děkujeme AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestách.
Takové pohodlí!
Je opravdu hezké mít moji oblíbenou alternativu cukru zabalenou v malých balíčcích!
MILUJI swerve, a je tak pohodlné mít je hodit do kabelky na stolování, nebo použít v domě přítele.
I když jsou trochu drahé, nemůžu vydržet Equal ani růžové věci v mém ledovém čaji.
Otočte se nebo nic, takže jsem nadšený, že mám své sladidlo na cestách!
Ve skutečnosti neprovádí žádné „čištění“ vzduchu
Koupil jsem to jako zvlhčovač, část „čištění vzduchu“ je ve skutečnosti falešná reklama; v závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych to ohodnotil jako o něco méně účinný než zvlhčovač knotového typu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku, pravděpodobně ji budete muset provozovat asi 5 let, aby se rozdíl změnil.
Má poměrně velkou kapacitu vody pro svou velikost, protože „nádrž“ je nedílnou součástí jednotky a má nízký výkon (i když ne lepší než typ knotu).
Čistí se také poměrně snadno, i když plastové disky nelze opravdu opravit, protože diskovou jednotku nelze rozebrat.
Pro německé inženýrství však kvalita sestavení není skvělá.
Mám svůj už rok, což by bylo asi šest měsíců doby chodu v chladném počasí, a jednotka vyvinula velmi nepříjemný chrastící hluk ze sestavy ventilátoru.
Můj odhad by byla ložiska ventilátoru, takže čekám, až se zde stane úplné selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní pouhému nákupu nového knotového zvlhčovače.
tl; dr - nestojí za další náklady, je vám lépe s knotovým zvlhčovačem.
Myslím, že bylo snazší zlomit, než si mysleli.
Dávám tomuto produktu 3 hvězdičky, že když jsem ho dostal, byl rozbitý již uvnitř.
Jakmile jsem to prozkoumal, uvědomil jsem si, že kdokoli to vložil do krabice, dal to tam rozbité, Mohli to být buď výrobci balírny, nebo kvůli výrobcům, problém by mohl být v tom, že kupující položku vrátil a tvrdil, že ji prostě nechtěl nebo ji nepotřeboval a Amazon možná neprovedl dostatečně dobrou kontrolu kvality, když se vrátil.
Při vší spravedlnosti kupující nemohl říci, že byl rozbitý, protože pak by to Amazon nevzal zpět, což je dobré, zejména u tohoto druhu produktu, i když jsem ten, kdo uvízl v něčí nedbalosti.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a diskutoval o tom se svým manželem, rozhodl jsem se dát tomuto kupci další šanci.
Díky tomu budu aktualizovat své hodnocení pouze na vyšší hvězdu v závislosti na tom, jak zákaznický servis tento příspěvek zpracovává (alespoň jeho adresováním), a pokud je položka ve skvělé kondici, má ve skutečnosti příležitost dělat to, co dělá, a funguje dobře dělat to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale instalace pro mě nebyla tak snadná.
Snažil jsem se nainstalovat oba „zvonky“ do zapojeného vysílače několikrát bez štěstí.
Byl jsem připraven to vrátit, protože nefunguje, ale myslel jsem si, že to ještě jednou zkusím a zkontroluji baterie ve zvoncích.
Voila... z krytů baterií vyčnívaly malé plastové jazýčky, které jsem vytáhl, a vycházel plastový kus, který zakrýval baterii a zastavoval její fungování.
Poté, co jsem odstranil tyto kousky plastu, zvonky fungovaly dobře a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v příručce pro uživatele není zmínka o plastu nad baterií, který musí být odstraněn, aby zvonek fungoval.
Bylo by méně frustrující, kdyby se o tom zmínili, a nemyslel jsem si, že problém byl v tom, že jsem instalaci nedokončoval správně.
Je to dobrý produkt se širokou škálou prstenů, zvonkohry a melodie, které si můžete vybrat, a je snadné jej kdykoli změnit.
Jedna věc, kterou se ptají při hodnocení tohoto zvonu, je, jak je „odolný proti povětrnostním vlivům“.
Nemohu to komentovat, protože byl nainstalován 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný vůči povětrnostním vlivům, až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - Re-Charged me
Vyrostl s nimi a byl nadšený, že je koupil pro mého syna, ale ztratili balíček živých housenek.
Řekli mi, že to vymění a tentokrát si účtují polovinu zásilky.
Po značném telefonním čase mi nakonec dobili novou objednávku se slevou 3$.
Myslel jsem, že je to docela neprofesionální, protože to nejen ztratili, ale vedli mě k přesvědčení, že to napraví, jen aby mi na konci 30 minutového telefonního hovoru účtovali téměř plnou cenu s nějakou hrou o poukazu.
Strávil jsem 30 minut na telefonu, tak jsem se propadl a koupil další sadu housenek.
Cokoliv.
Funguje dobře po některých bolestech hlavy.
Měl nějaké problémy s tím, aby to fungovalo.
Dodaný kabel nebyl dobrý - nenabíjí baterii.
Když jsem vyměnil kabel za svůj vlastní byl schopen nabíjet a poté připojit zařízení přes bluetooth k počítači.
Měl potíže s nalezením počítačového softwaru, ale když jsem poslal e-mailem jejich podporu, odpověděli během jednoho dne správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají pro mou aplikaci velmi dobře, ale nebyl jsem schopen se připojit k iPhone ani iPad (vyzkoušel několik z nich) přes bluetooth.
Budu muset pevně zapojit, pokud se rozhodnu použít toto zařízení ve svém produktu.
... byl příliš žlutý před nákupem a bylo mu řečeno, že je to jako starožitné zlato
Před nákupem jsem se zeptal prodejce, jestli je barva příliš žlutá, a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízko!
Sada vypadá VELMI levně.
Je super lesklá žlutá se spoustou CZs, ještě lesklejší.
Vypadá skvěle na fotografii, ale v reálném životě bych to ani nedal teenagerovi, aby si ho oblékl.
Miloval prsten - ale nemohl jsem ho nosit pořád! :(
Ten prsten byl krásný.
Miloval jsem design a jeho robustní pocit; vypadalo to drahé a bylo to velmi pohodlné!
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec jsem produkt vrátil, je to, že jsem si uvědomil, že ho nebudu moci nosit pořád.
Rád nosím prsteny pořád, a proto se vždy ujistím, že dostanu mincovní stříbro, a vím, že někteří lidé říkali, že jejich prsteny se po chvíli poskvrnily, ale já jsem svůj nosil asi týden rovně - i když jsem si myl ruce - a nevšiml jsem si žádného pošpinění.
Zajímavé je, že problém, který jsem měl, byl ten, že vnitřní pás prstenu ve skutečnosti otáčel můj prst bílý a vlhký - něco jako to dělá bandaid poté, co ho necháte dlouho zapnutý.
Stalo se to, i když jsem se ujistil, že prsten a prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale stalo se to nepříjemným, takže jsem se rozhodl, že to není prsten pro mě.
:( Škoda, protože jsem to opravdu miloval!
Takže pokud kupujete tento prsten s úmyslem nosit ho jen příležitostně, Říkám jděte do toho!!
Nebudete zklamáni!
koupit hýčkaného kuchaře...
Vlastním malou lopatku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých „věcí“ je uložena.
Rád používám tyto kopečky při pečení pro dokonale porcované sušenky.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a získat ten OXO - obvykle mám štěstí s jejich produkty.
Tenhle ne.
Asi u sušenky z arašídového másla #30 páka uvnitř lopatky přestala fungovat.
Musel jsem oddělit rukojeti od sebe a znovu umístit páku, abych udělal několik dalších, a pak opakovat.
Takže... šetři si zdravý rozum a kupte si naběračku Hýčkaného šéfkuchaře.
Stojí to za to!
Mr. Coffee znovu nekoupím
Chvíli to byl skvělý kávovar, ale vždy s tím byly problémy.
Pokud máte vodu mezi černým plastem a kovem na karafě, vytékala by a vypustila vodu celé dny.
Pak se naše plastová páka zlomila, což umožňuje, aby káva protékala filtrem a do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali by mě pouze do servisního střediska, které je přes 90 minut od mého domu.
Je to skvělé při přípravě kávy a udržování horké kávy, ale je s ní příliš mnoho dalších problémů, než aby do ní investovalo za současnou cenu.
Musí koupit!!
Miloval jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo to opravdu jasné.
Líbí se mi mít trochu více podrobností v rukojetí a všiml jsem si, že předtím, než jsem je koupil, a proto tomu stále dávám 5 hvězdiček!
Snadno se čistilo a vše přišlo zabalené jednotlivě, což mi připadalo opravdu organizované, a uklidnilo to mou duši lol lásku, milovat, MILOVAT barvu a určitě bych si to koupil znovu pro sebe nebo pro milovaného člověka!
Mohlo by to být dobré na tyči, ale NE jako závěsná přepážka nebo povětrnostní štít.
Hanba Audubonovi.
Pokyny vám řeknou, abyste zástrčku zatlačili nahoru otvorem v přepážce a „Ujistěte se, že je bezpečně na svém místě.“
JAK???
Je navržen tak, aby přepážka jednoduše volně seděla na zástrčce, takže ji může tlačit nahoru jakýkoli tvor nebo sebemenší vítr.
Zástrčku můžete otočit vzhůru nohama tak, aby palcové šrouby byly na spodní straně přepážky, ale otáčení těchto šroubů vám zabere hodiny; žádný nástroj to neudělá, a jen ty nejmenší prsty by to měly snadný čas.
Trvalo mi více než hodinu, než jsem udělal napůl upečenou práci, abych je zašrouboval, aby se přepážka zajistila k zástrčce.
Je to kompletní PITA.
Objednal jsem si čtyři z nich; tři, které jsem neotevřel, jdou rovnou zpět a já jsem na trhu pro lepší stráže počasí.
(Přiznejme si to; není nic takového, co by ve skutečnosti „zmatilo“ veverky!)
Miluji mnoho funkcí těchto světel
Koupil jsem tuto lampu, abych doplnil světlo, které moje nové sazenice zeleniny dostávaly z okna.
Miluji mnoho funkcí těchto světel.
Klady: Nejprve se snadno upnou na mou polici a ohnou se do mnoha pozic, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou chladná na dotek a nepoškodila ani při dotyku rostlin.
Věřím, že moje zelenina těží ze světel.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Časovač jsem nevyužil, raději je zapínám a vypnu sám.
Tuto funkci považuji za užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až světla zhasnou, budu si muset koupit úplně novou jednotku.
POZOR... VŮNĚ JE VELMI ŠPATNÁ... SLOTY PRO KARTY JSOU PŘÍLIŠ VELKÉ!
Když jsem to poprvé viděl, myslel jsem si, že je to krásné, ALE vonělo to tak špatně.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že je to vůně MOLD.
Nikdy to nezmizelo, takže jsem to musel vrátit.
PLUS, kapsy na kreditní karty jsou příliš velké.
Kreditní karty se posouvají úplně dolů, tipy se nezobrazují, takže nemáte tušení, která karta je kde a je velmi obtížné se dostat ven.
FOTOGRAFIE, KTEROU UKAZUJÍ, KDE KARTY VYČNÍVAJÍ, JE NEPŘESNÁ.
Je to velmi malé..
Obdržel pás cestovních peněz a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych to nekoupil a stále budu muset hledat něco většího.
Dobrý deštník, koupil bych ho znovu, kdybych musel
Nejprve musím říct, že barva je loveeee.
Spousta věcí, které si objednávám ve fialové barvě, je vždy příliš světlá, příliš dětinská, příliš divná, příliš neonová, co máte.
Ale tato fialová byla hluboká a svěží a já ji miluji, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, jaký jsem měl.
Dodává se s krytem a přestože nemusí mít příliš funkční využití, opravdu to udržuje ostrý vzhled.
Balení je hrozné - obdržel 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Neobtěžujte se pokusit získat ten, který není poškozen.
Vrátili jsme 2 kvůli škodám v přepravě a třetí byl také poškozen.
Vzdal jsem to.
Doručují je v měkkém tenkém pouzdře s jedním listem hnědého papíru v lepenkové krabici.
Vůbec žádné polstrování.
Skvělý koncept!
Potřebuje jen další vylepšení, aby se z něj udělal opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje současně jako 1) osobní mikrofon 2) hudební streamer/reproduktor a 3) hlasový záznamník.
Celkově máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a zaznamenává vše, co vyjde.
V samotném mikrofonu však není žádná hudba.
Má konektor Bluetooth, takže jej synchronizujete s telefonem a stáhnete si aplikaci karaoke, která může posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a hlasu (také samostatně!)
a dokonce má možnost upravit úroveň ozvěny, takže ve skutečnosti zníte, jako byste byli v karaoke místnosti.
Některé věci, na kterých bych chtěl vidět budoucí vylepšení, jsou: 1) existuje nějaká nepříjemná zpětná vazba, která zřejmě nezmizí bez ohledu na to, jak daleko vzdálím telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače volby uprostřed mikrofonu jsou neohrabané.
Jsem blázen pro minimalismus, takže je skvělé, když budoucí produkty dokážou design udělat elegantnější.
3) podpora více aplikací pro karaoke Konečně, protože zvuk vychází z tohoto mikrofonu přímo, a nikoli prostřednictvím plochého nebo centrálního reproduktorového systému obývacího pokoje, není to tak zábavné v prostředí párty.
Pokud to výrobce dokáže nějak integrovat do většího ekosystému karaoke party, bylo by to toto nekonečno příjemnější.
Žebrovaný Vision Supplies
Říjen 2017 koupil čtyři (4) kazety od společnosti Vision Supplies - Amazon Marketplace, takže bych měl v případě potřeby a ušetřil náklady na dopravu.
Použili dva za posledních pár let, asi jeden za rok, a fungovali dobře.
Pokusil se použít jeden minulý týden, téměř prázdný po vytištění 20 štítků, ale v posledním došel po 40 stránkách.
Plast chybí na obou.
Řekla, že záruka vypršela!!!!
Kdo by při přijetí zkontroloval každou kazetu????
KUPUJÍCÍ BÝT VĚDOM!!!!!!!!!!!
Promiň, co?
Můj přítel doporučil masku této řady, takže jsem si ji koupil, tento kondicionér a vše v jednom mléce.
Nemohu mluvit za účinnost produktu, protože vůně nebyla přijatelná.
Víte, že zatuchlý zápach, který staré budovy používají v ženských toaletách, aby se pokusily zamaskovat vůni *dám*, ale ukázalo se, že tato kyselá, chemická, jakási zatuchlá vůně babičky?
To je vše, na co si vzpomenu, když to cítím.
Znáte různé tahy, různé lidi, takže možná se vám bude líbit vůně.
Můj přítel řekl, že to může pomoci i těm nejvíce poškozeným vlasům, takže pokud se nestaráte o vůni, pak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že stále více přirozeným liniím záleží jen méně, protože se budou stejně prodávat, a tak teď všechno prostě voní jako playdough.
Ztratil jsem několik oblíbených linek, které změnily recepturu na levnější ingredience.
Nevím, jestli tomu tak je, nebo jestli je to falešný (kterému jsem říkal Davines a oni řekli, že to není), ale to voní jako Y U C K a musel jsem to vrátit.
Drops internet
Tento modem/router jsem koupil asi před dvěma lety.
Na začátku se zdálo, že je v pořádku, ale za poslední rok jsem měl problémy s tím, že upustí internet.
To se děje na všech mých zařízeních Wi-Fi i kabelových.
Jediným způsobem, jak obnovit službu, bylo provést reset střídavého proudu.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku od podstavce k domu a zvýšil úroveň signálu.
Stejný problém.
Kluci Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem ztratil službu 5G třikrát.
Musel jsem provést obnovení továrního nastavení, abych to obnovil.
Nemohu doporučit tento modem/router na základě mých zkušeností.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Měl jsem to déle než týden bez problémů.
Je rychlejší a dosah je větší než Arris.
Četl jsem online, že ostatní lidé měli problémy s modem/routerem Arris připojeným k Comcastu.
Pokud máte internet Comcast, nedoporučuji tento modem/router Arris.
Získejte Netgear, je mnohem spolehlivější.
ale stává se to dost na to, aby to bylo nepříjemné.
Pozitivní poznámka
1 z fanoušků zněl mimo rovnováhu po vybalení z krabice.
Ovládací prvky rychlosti jsou opravdu zvratné - pokud je vytočíte na 100%, ventilátory se vypnou, takže je musíte otočit na 100% a poté jej pomalu vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že je to stejné pro většinu těchto typů produktů v této cenové kategorii.
Nohy pro držení notebooku, když je nakloněný, se několikrát odlomily...
Vracejí se zpět, ale stane se to dost na to, aby to bylo nepříjemné.
Pozitivní je, že to má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z větracích otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a poskytuje velmi malé přídavné proudění vzduchu do notebooku s takovou konfigurací chlazení.
Ok případ s vážnými omezeními
Tento případ je v pořádku, ale ne výjimečný - 3,5 nebo 4 max.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně případů.
Z nich je Gumdrop asi nejlepší, ale má několik vážných problémů.
Guma pouzdra (silikon, cokoli) je velmi hladká a hladká a nedává vám velkou důvěru, když držíte Tab jednou rukou.
Tab A je těžký, takže pokud ležíte při sledování videa, pouzdro vám vklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit čirý plastový štít, který zakrývá obrazovku, protože to narušilo provoz dotykové obrazovky.
To ovlivnilo sílu 1dílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a chatrný.
Nakonec ztěžovali dostat se k peru S.
Pero S je v pravém zadním dolním rohu karty A, a vytvořili malou gumovou chlopni, která chrání rohový výkyv dozadu pro přístup k peru S.
To znamená, že k vytažení pera S se musí klapka vyklopnout o 180 stupňů.
To je opravdu trapné a těžké to udělat jednou rukou.
Tento případ dělá dobrou práci při ochraně mé karty A, ale s těmito vážnými konstrukčními vadami to nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu úhledný - nakupování na jednom místě pro všechny mé potřeby připojení.
Rád jen házím tohle a malý napájecí adaptér svých notebooků do tašky a jsem připraven pracovat na velkém 4k displeji nebo pořizovat fotografie z fotoaparátu.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích usb-c, které jsem vyzkoušel od různých značek), je to, že Mac zjevně nedokáže rozeznat rozdíl mezi násobky stejného monitoru (takže můj mac vysílá stejné video na všechny identické monitory připojené k rozbočovači, ať už přes HDMI a/nebo VGA).
Pokud ale používám 2 samostatné rozbočovače/adaptéry nebo 2 různé modely monitoru, pak mac správně vystupuje na displeje jednotlivě.
Ok, potřebuje nějaké zlepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký bezpečnostní zámek nad tlačítkem šoku (byl stisknut více při nehodě, když je v mé kapse, než jsem ho vlastně chtěl použít), moji psi se dokonce náhodně přepnuli po šlápnutí na dálkový ovladač.
Také pokud se váš pes rád valí v mývalovém hovínku jako já, je to taková bolest v zadku, kterou je třeba vyčistit.
Jak se fekální hmota dostane mezi praskliny zařízení a vyžaduje, abyste celou věc rozebrali, abyste ji řádně vyčistili a odstranili zápach.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že málem potřebujete viditelnost, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Být dobíjecí je určitě příjemná funkce a nabíjení trvá dobrou chvíli.
Potřebuji nabíjet svůj asi jednou za dva týdny.
Dostanete to, za co zaplatíte.
Hrozný produkt, zkreslený
Koupil jsem si to jako tracker, který jsem použil při plavání, a neměl jsem ani pořádnou šanci to vyzkoušet.
Za prvé, není voděodolný a nedoporučuje se používat při plavání podle návodu k použití.
Za druhé, nepřichází s nabíječkou.
Místo toho navrhuje použít USB konektor nebo počítač.
Fajn, máme kolem sebe spoustu.
Když se ho pokusím dostat do portu, abych jej nabil, spustí se hned zpět.
Nejsem si jistý, jestli něco není kompatibilní, nebo jestli je to jen špatně vyrobeno, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
Konečně, aplikace stále vyskakuje reklamy, i když je zavřená.
Při odesílání textu se objevily reklamy, což je velmi znepokojující.
Poté jsem zavřel všechny aktivní aplikace v telefonu, a viděl jsem další reklamu, když jsem šel zkontrolovat čas 20 minut později.
Hrozný produkt, myslím, že dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přehnaný na popruzích
Tento batoh vypadá dobře a funguje dobře.
Je to hodně, zvláště když to porovnáte s tím, co batohy stojí nyní dny.
Důvod, proč jsem srazil hvězdu, je ten, že je tam příliš mnoho popruhů.
Na tašce je víc popruhů, než dokážu spočítat.
Nakonec tyto extra popruhy odříznu a spálím, protože většina z nich není opravdu nutná a jen se dostanu do cesty otevírání a zavírání tašky.
Kromě toho jsem z toho vyrobil svou novou školní tašku na vysokou školu.
Přímo v zadní části batohu je přihrádka pro můj MacBook Pro a všechny mé knihy zapadají do přiložených kapes.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli jsme s hokejovými míčky.
Můj pes je miluje - její oblíbená hračka pro aportování a žvýkání - a vznášejí se.
To je, dokud je nežvýká na kousky.
Vyzkoušeli několik, dokonce i verzí „horkého počasí“ - a trvaly o několik minut déle než ostatní.
Dokud se neobjevily tyhle.
Ti obstáli v testu.
Můj pes není velký, ale je tvrdohlavá ohledně toho, co žvýká.
Jak se říká, není to, jak velký pes v boji, ale jak velký je boj u psa.
Palec nahoru od Daisy a já.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme zkontrolovali baterii a viděli jsme, že voda šla do prostoru, kam baterie jdou.
Samotné baterie zhnily a z nich vycházela černá kapalina.
Při pohledu na design, zdá se, že neexistuje způsob, jak by kryt baterie mohl být vodotěsný, což znamená, že nejen voda šla do prostoru během koupele, vyšla také část tohoto toxického materiálu.
Tento produkt prosím nekupujte.
Jsem šokován, že bylo dovoleno jít na trh navzdory tak zjevné chybě.
problémy s přehřátím a obtížné připojení ovladače
Prozatím tomu dávám 3 hvězdičky, nechci zanechat špatnou recenzi pro prodejce, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sám, ale pravděpodobně zkusím obojí, jen abych viděl, co říkají.
Líbí se mi, že dron je skvělá malá hračka, která létá lepší než některé větší starší drony a některé z mých větších dronů se cítí spíš jako hračka než tento.
Je to však jediný dron, se kterým jsem kdy měl problémy s přehřátím, a ve skutečnosti to bere zábavu z létání, prozatím budu předpokládat, že je to výrobní problém, který musí co nejdříve vyřešit, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal dron, protože jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, protože dorazí 1 den po zakoupení.
Po kontaktování prodejce a dji tello aktualizuji datum své recenze.
O této dárkové tašce mám jen dobré věci
O této sadě dárkových tašek mám jen dobré věci.
Dokázal jsem zabalit všechny své vánoční dárky taškami, dárkovým obalem a hedvábným papírem.
Produkt je velmi kvalitní a různé možnosti velikosti usnadňují výběr toho dokonalého pro každý dárek!
Vřele doporučuji.
Prodávající je naprosto milý a pozorný.
Po mém nákupu mě oslovil, aby se ujistil, že jsem se svým produktem spokojený.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte tuto hru, fyzika je hrozná a jsem na tuto hru tak naštvaný, protože pravděpodobně existuje asi 40 hackerů v každé hře a hře.
Nedělejte s tím ani nic, víte, že prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra neustále aktualizuje své postavy, opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné nekupujte tuto hru fyzika je hrozná a mechanici jsou hrozní lidé, že lidé, kteří tuto hru postavili, byli zjevně vysocí nebo tak něco, protože je to jedna z nejhorších her, které jsem v životě upřímně hrál, raději bych hrál Pixel Games v tomto kecy je to jedna z nejhorších her, které si nekupujete
Ne jako jiné hry Tomb Raider
Od samého začátku to nepřipadalo jako ostatní hry Tomb Raider.
Hra je brutální v tom, že ovládací prvky nejsou chytré v tom, aby věděli, jakým směrem se snažíte ubírat.
Nechává tě padnout na smrt tím nejnadbytečnějším způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tuto hru jsem si neužil.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomické a cenově dostupné, ale ne příliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, které by se mohly zachytit, a díky napájecímu kabelu jako trvalému připevnění je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští v akčních hrách, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžcí a máme tendenci opotřebovávat 2-3 regulátory ročně.
Takže pro nás investice do kontrolorů ročně znamená, že musíme být vybíraví a obezřetní ohledně toho, co kupujeme.
Ovladač by mohl dělat s odolnějšími pružinami; po několika měsících tlačítka, která se používají nejvíce, přestanou reagovat a správný joystick ztratí své centrování, IE- způsobí přiblížení obrazovek mapy a postavy kráčejí vpřed, aniž by se dotkly ovládacích prvků.
Dostaneš to, za co zaplatíš
Byl jsem zklamaný, když jsem obdržel tuto položku, protože stříbrná část, která obchází obličej, vypadala, že je vyrobena z nějakého levného plastu.
Není to skutečnost, že byl vyroben z plastu, který mě zklamal stejně jako skutečnost, že použitý plast vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled.
Také jsem mu nevěřil, že vydrží každodenní nošení, a tak jsem to nakonec vrátil.
Byl jsem zklamaný, protože se zdálo, že by to bylo dobré, kdyby to nebylo pro to.
To však můžete přehlédnout, pak by to mohlo být pro vás to pravé.
Byl dobře zabalen a rychle dorazil.
Nic jako předchozí telefony Stylo, MASIVNÍ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je zřejmé, že se mi Stylos opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem ho.
Nikdy proto, že někdo měl problémy nebo se zlomil, jen proto, že jsem chtěl zůstat upgradovaný a „ve smyčce“ a udělal jsem to.
Ze všech těch telefonů jsem ani jednou neměl problémy se samotným telefonem.
Když jsem provedl tento nákup pro Stylo 3 přes Virgin Mobile, Věděl jsem, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokoval, jak byli předchozí Stylos tak úžasní.
Nikdy jsem nebyl schopen úspěšně přenést tento telefon na můj účet Virgin Mobile.
S tímto telefonem jsem si pohrával o něco méně než týden.
Hledal jsem informace na internetu a zoufale jsem volal a snažil jsem se dát Stylu 3 výhodu pochybnosti v naději, že jsem to jen já dělal něco špatného, ale bohužel jsem tím ztrácel spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Nesnáším skutečnost, že musím dát Stylovi tak hrozné hodnocení a recenzi, ale byl jsem tímto telefonem extrémně zklamaný.
Doufejme, že LG zvýší svou hru a může zlepšit budoucí Stylos, pokud existují, ale to byla obrovská BUST.
Na druhou stranu, návrat a moje vrácení proběhly hladce, ale to je o tom.
