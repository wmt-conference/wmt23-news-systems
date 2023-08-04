Hacknutá verze Jedi Knight se zhroutila, protože volala funkci z konce vtable.
Ukázalo se, že se předpokládá, že volání IDirect3D:: CreateViewport() vrátí IDirect3DViewport3, který má na konci další metody ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože vytváří výřez pouze pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní, chápu, že v praxi, IDirectXObject2 je obvykle správná supersada IDirectXObject, bez změněných podpisů funkcí a nových metod přidaných až do konce.
To však není všeobecně pravda; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže stejně, protože to platí zde, opravit jsem musel rozšířit implementaci výřezu tak, aby obsahovala metody IDirect3DViewport3 tak, aby volání na nový bylo platné.
Předpokládejme pro argument, že věda se alespoň částečně skládá ze seznamů objektivně faktických prohlášení o světě, pravdivých na rozdíl od jakékoli teorie, kterou by mohli podporovat.
I když je pravda, že taková fakta ve vědě existují, je stále možné tvrdit, že vědecká fakta jsou nabitá teorií.
Vědecká fakta jsou výsledkem experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale výběr toho, které experimenty provádějí kontroly, které skutečnosti jsou objeveny.
Některá fakta, např. o subatomárních částicích, mohou vyplývat pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se jinak vytáhly.
Toto je velmi stručný náčrt věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to můj první projektový vůz.
Vyzvedávám to tento víkend.
Hledal jsem dobré auto pro první auto; a opravdu miluji estetiku 80.let.
Již na cívkách a sníženou světlou výšku.
Udělal jsem malý průzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že nejsou rychlí ve srovnání
# Venting do Fediverse času.
S domácím partnerem jsme šli dnes večer do obchodu s lihovinami na pár piv a láhev Bubu.
Když jsme se šli podívat, pokladní je docela zřejmá # trans žena.
Já, v trenýrkách a manželce, a domácí Partner, všichni potetovaní a s novým účesem, který sám popsal jako "takže vypadám jako neonacista".
Její tělo okamžitě ztuhlo a v jejích očích se objevil strach.
A pak už jen... zaplatil za naše věci.
A řekl Děkuji.
A řekl jsem, že její nehty vypadají cool.
Úsměv úlevy na její tváři byl skvělý pocit, ale skutečnost, že se nejprve vyděsila, je kurva na hovno a nenávidím to.
Toto je nejhloupější časová osa a nesnáším ji dot com.
Nic nebrání Donaldu Trumpovi kandidovat na prezidenta, když je obžalován, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen,nepochybně by se omilostnil, aby se dostal z vězení.
Ze státního vězení se ale omilostnit nemůže.
Chce to guvernéra státu.
Oba zúčastněné státy jsou New York a Gruzie.
Jeho guvernér Kemp nepochybně omilostní Trumpa, pokud bude usvědčen nebo dokonce obžalován Fulton County DA Fannie Willis.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze omezit na odesílání signálů s kontextově nezávislým významem.
V této práci, založené na variantě klasického Lewisova (1969) signalizačního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména demonstrujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Současně studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextuální disambiguaci významů symbolů.
Ukazujeme, že environmentální omezení výběru referenta příjemce může být jednostranně využito odesílatelem, bez disambiguačních schopností na konci přijímače.
V souladu s běžnými předpoklady se zdá, že povědomí odesílatele o kontextu je pro kontextovou komunikaci nezbytné.
Navrhujeme, že kontextově závislá komunikace je situovaný vícevrstvý jev, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné z kontextu, ale přesto umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil dohánění Penny a Nicholase z Ashanti Development o víkendu na chat o jejich pokroku.
Ashanti Development pracuje se stále se rozšiřujícím počtem komunit v oblasti Ashanti v Ghaně 20 let, zapojení do komunit a poskytování podpory vodou a hygienou, vzdělávání, zdravotní péče, výsadba stromů a zemědělství.
Komunity získávají znalosti pro začlenění a podporu vlastního rozvoje.
Měl jsem to štěstí, že jsem v roce 2011 strávil po boku Nicholase nezapomenutelných šest měsíců podporou řady projektů.
Když jsme o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšené výnosy plodin prostřednictvím řady intervencí od podpory nákupů vybavení až po školení.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je fall armyworm, který může devastovat plodiny kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS poblíž mě mi nedovolí napsat štítek nebo napsat na krabici.
Musí vytisknout štítek.
Nedovolí mi, abych jim řekl adresu, na kterou jde a kdo ji odesílá.
Musím poslat e-mailem nějakou náhodnou adresu s neformátovanými údaji, aby si úředník mohl přečíst e-mail a zadat jej do svého systému, aby vytiskl štítek.
A vždy mi účtují 2,25 $za toto "pohodlí".
Druhý den ráno a nemůžu se dostat přes ostudné předstírání žurnalistiky veřejné služby Chrise lichta na CNN včera v noci.
Bylo to pobouření, jako symbolický antidemokratický festival lží a křivd 6. Ledna, sebedestruktivně pořádaný americkými médii.
HANEBNÉ PUBLIKUM.
Licht souhlasil s celorepublikovým publikem!
Kdo prověřil a vybral jednotlivce?
Je tam reportáž.
Hodnocení-hledání klamné nezodpovědnosti toho všeho.
Nedá se to opakovat.
Mám velmi průvan suterénu, což v podstatě znamená, že mohu získat spoustu hlodavců útočiště.
Za poslední měsíc se objevilo mnoho známek více hlodavců, což bylo výjimečně překvapivé, protože je jaro a já bych si myslel, že se změnou počasí vydají ven.
Nicméně, měl jsem kousek obyčejných starých lapacích pastí, a poslušně bych na ně každých pár dní doplňoval arašídové máslo,protože myši to laskavě olizují.
Včera v noci jsem se konečně otrávil touto rutinou, vyčistil všechny pasti arašídového másla a přilepil k nim pistácii.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř každou" humánní " past na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť spokojený s jejich zabíjením, ale nebudu se vyjadřovat k etice zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se balí do značky pro-business.
Nejsou, alespoň ne v Albertě.
Jistě, snížili daně z podnikání.
Ale také snižují granty a daňové úlevy, které podporují větší podnikatelskou aktivitu.
Vlastním firmu. Je to úspěšné navzdory provinční vládě, ne kvůli ní.
Objevil tvrdý způsob, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, Automatické přehrávání videí, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jakým vydělávají své peníze, ale všechny ty odpadky se zdají kontraproduktivní, pokud odvádějí lidi pryč.
To platí i nyní, že goatse.cx je pryč, i když by to byl těsný závod ke dnu mezi goatse a, řekněme, khou.com, kde jsem se snažil sledovat video, které mi poslala Wendy.
Na prvním vlaku dnes, kontrola jízdenek se podívala na naše lístky a řekla: "dlouhá cesta!"
"Jo a dneska se vrátím," řekl jsem.
"Jen ho Vysadím v Glasgow," pokusil jsem se vysvětlit a ukázal na svého společníka na cestách.
"Není nic, co byste slyšeli hodně 'jen ho Vysadím v Glasgow', " řekl muž s lístky.
Je to věc, kterou jsem nikdy předtím neřekl.
Věc, která mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti Trumpismu.
Trumpismus je kult.
Je to kult, který nikdo opravdu nechce, kromě fanatiků, kteří jsou v něm.
A jsou opravdu ořechy.
Nemůžeme jim dovolit unést naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Získejte nějaké nálepky, které jsou anti-Trump a omítněte je všude.
Křičte zpět na ty, kteří by se o nás pokusili mluvit.
To není normální.
To není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak vykašlává bouři hlenu covid z druhé strany ulice.
Tak jsem spěchal, abych se dostal do svého APTu, abych se mu vyhnul, ale stále se mi podařilo dohnat, abych si povídal.
Přísahám, že lidé infikovaní covidem jsou zombie, kteří se snaží infikovat všechny ostatní.
Není společensky přijatelné chodit na veřejnost nebo spěchat k lidem, když vykašláváte hlenovou bouři.
Opakuji. Není společensky přijatelné šířit svou hlenovou bouři covid všude!!!
Psaní Divů 5/11: směje se váš MC nebo pláče víc?
Abe udržuje své smutky skryté a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví hrubý humor.
Jan vám ublíží, než vám umožní vidět, že je zraněná, a nejvíce se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4,000 utrpení se yl ocitne na místě lásky a má obrovský pocit, že neví, co dělat, takže je tu spousta obojího.
# CNN musí prostě zavřít.
Včerejší fiasko s # Mangomoronem bylo nehorázné fiasko.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "výkonný ředitel" kabelových zpráv vyzval, aby dal tlustému, lhajícímu zločinci tolik vysílacího času?
Vysoký tlak bude převládat až začátkem příštího týdne.
Studená fronta by měla dorazit v polovině příštího týdne.
Brzy ráno, IR satelitní a povrchová pozorování ukázala rozšiřující se oblast nízkých vrstev a nerovnoměrných <URL>
Podivínský student Arnie Cunningham se zamiluje do Christine, rezavé Plymouth Fury z roku 1958, a je posedlý obnovením klasického automobilu do své dřívější slávy.
Jak se auto mění, mění se i Arnie, jehož nově nalezená důvěra se mění v aroganci za volantem jeho exotické krásy.
Salesforce Partner
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše Salesforce konzultanty ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije své odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a trvalou podporou, která umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jednou z nejbláznivějších částí toho, jak se moji sousedé obracejí proti mně, je přemýšlet o tom, kolik úsilí je zapotřebí k nepřátelství.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto okamžiku se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnutí dveří do obličeje vyžaduje úsilí.
Naši psi bývali nejlepšími přáteli.
A stále netuším, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu na 6 + let.
Ta loď je zakázaná.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě irelevantní.
Můžete ji zabít, pokud můžete.
Ale na palubu této lodi často letí jiný jedinec.
Kdyby zemřel... důsledky by byly... významný.
Hodně se trápím s tátou.
Zde je (o něco delší než) rychlokurz délky toot v tom, co myslím tátou-ification:
Není to můj termín, je to termín používaný k popisu, kdy je narativní nebo herní mechanik postaven na centrálním protagonistovi (obvykle starším, obvykle mužským), který řídí nebo hlídá jinou osobu (často mladší).
Poslední z nás je snadným a kanonickým příkladem otcovství.
Joel využívá své dovednosti a schopnosti uzákonit (extrémní) násilné činy k dosažení úkolu, který je kódován jako "péče"."
Dad-ification obvykle předpokládá, že řešení situace, kdy se rodičovská postava musí starat nebo chránit dítě nebo dítě, je ohromující síla, a pomocí této síly vynutit velmi specificky tvarovanou mocenskou dynamiku.
Dad-ification narušuje možnost komunálního řešení a často zcela ignoruje nebo podkopává jakoukoli agenturu, kterou dítě má.
Tímto způsobem je Dad-ification zastáncem mnoha neoliberálních ideálů; zejména myšlenky jako bootstrapping a soběstačnost jako konečný cíl/indikátor úspěchu.
Zde je stručný přehled toho, jak využít naše webové stránky.
- Zasíláme oznámení, když se letenky začnou prodávat.
- Poskytujeme odkazy na místo, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti jsou v plném blogu.
- Udržujeme seznam příkladových termínů rezervace pro každou dohodu, kterou zveřejníme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto nepředstavitelný strach, teror a vysídlení jim zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezidentka von der Leyenová setkala v Kyjevě s první dámou Olenou Zelenskou, aby diskutovala o tom, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli duševní zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže tuto cestu zvládnout.
Banda lesklé nové dobroty v # dart
Postupem času se dart stal mým cílem pro rychlé uživatelské rozhraní.
#flutter je potěšením pracovat a mají #mobx pro snadnou správu obchodu.
Příběh závislosti je méně šílený než nodejs, také.
Samozřejmě flutter naštve opravdu špatně, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i flutter web target sucks).
Umožňuje však rychlý pohyb, a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými hroty.
Jsou průměrná výška, má průměrnou stavbu a svalnatý.
Jejich ocas je extrémně silný.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové brýle cateye.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Schopnost skákat opravdu vysoko, trhat běžné lidi na kousky, používat strašidelné magické síly a doplňovat zdraví hodováním na svých nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Bram Stoker, Max Schreck, a Stephenie Meyer ve snaze, aby vypadali špatně - všichni ...
Zdálo se, že moji rodiče hráli moji porno hru a dávali mi zpětnou vazbu.
V reálném životě, moje máma měla ráda logickou hru, kterou jsem vytvořil před lety, a většinu tajemství našla sama, takže nebyla jen mámou, když řekla, že se jí to líbí.
Takže se jí možná bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Je třeba přeložit do Mandarin a / nebo Hokkien, ani jeden z nich vím vůbec.
Asi budu muset zjistit, zda je Bing nebo Google lepší v překladu špinavých gay sexuálních hříček.
Byl pohrává s touto myšlenkou na chvíli:
Duševní zdraví je často vnímáno jako něco odděleného od" běžného " zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku stejně otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce rozpoznán TERFs a podobně, protože je obecně fyzičtější a jako takový viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně "skutečné" než fyzické zdraví, mám pocit, že trans je pouze intersex mysli.
Čím více čtu o studiích sex, Rod, psychologie, čím více se prohlášení "můj sex je muž, moje pohlaví je žena" zdá zjednodušující a nepřesné.
Skoro to vypadá jako postoupení části argumentu Terfovi.
Mám pocit, že být trans znamená být "biologicky nebinární".
Moje pohlaví je nebinární, Moje pohlaví je ženské.
Myslím, že označení "nebinární" je třeba rozšířit pouze z genderového výrazu, který se používá při odkazování na sex.
Byl jsem, zapínat a vypínat, poslouchat díla @iotar
V tomto tajemném kolektivu je spousta dobrých věcí.
Jako krauty moods a další světská popová hudba a radiofonická dílna a všechny druhy.
Velmi stojí za to jít na.
Také FWIW se mi líbí archive.org rozhraní mnohem více než desktop # bandcamp \ - nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si hrajeme s flutterem.
Nerad bych založil své podnikání na technologiích od společnosti Google, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého multiplatformního zážitku a ukazuje se to.
(A také: Web je nyní z velké části věcí Google, bohužel)
Také mi prosím neříkejte, že aplikace google/flutter sají iOS a macOS.
Cross platform je těžké, pokud to chcete udělat dobře.
To vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Objevilo se několik velmi malých obtíží.
Nic nastavit poplašné zvony zvonění, ale přesto jsou řešeny.
Příští týden bude vydána malá aktualizace, která je opraví.
Většina včerejška byla vynaložena na instalaci nové aktualizace pro některé zákazníky a každý, kdo tuto pomoc potřebuje, ji měl nyní obdržet.
Přeji hezký den!
Tech vyznání: nemohu zabalit hlavu kolem Grafana & Prometheus, alespoň z hlediska metrik serveru / aplikace a monitorování.
Nevím přesně vědět, proč můj mozek nemůže přijít na to; to by mohlo být, že nástroje jsou jen tak široký a vágní, že můj mozek jen hardlocks kvůli 'příliš mnoho možností'.
Chci dělat dashboardy.
Grafana vypadá hezky.
Mozek nefunguje.
Takže když se blíží nová úroveň #FFXIV raid, dlouho jsem si myslel: "člověče, rád bych vyzkoušel správný nájezd, ale Party Finder zní jako nepořádek a nikdy nenajdu statiku, která mě bude mít."
Tak jsem si řekl, kašlu na to!
Udělám si vlastní statiku!
Plný lidí, kteří jsou příliš dychtiví, aby se pokusili připojit k raid static, bez očekávání, že budou vůbec dobří!
Tady je... v žádném případě by to nefungovalo, pravděpodobně!
...A tak jsem zjistil,že musím vyřešit soupisku skupiny raid.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a ztratil jsem veškerou vášeň pro fikci a skvělé vyprávění.
Ale po ~ desetiletích ~ čtení téměř ničeho (s výjimkou funkčních věcí z literatury faktu souvisejících s prací a příležitostné svépomocné knihy) jsem si dal za cíl přečíst 23 knih v roce 2023.
Nyní jsem v knize # 31 a je teprve Květen.
Jsem zpátky, zlato!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou přišlo pár lidí v soukromí a řekli: "podívej, kvůli tvé práci ti poskytnu tuto částku peněz".
Chci vidět, jak tyto společnosti, které zprostředkovávají transakce, vysvětlují svým zákazníkům, jak si stanovují procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobrou čtvrtinu,budou.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Nechte je rehabilitovat vydlabaná a rozpadající se města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pro-diktátorské pravicové křídlo.. tady je to nebezpečí.
Deportujte bílé supremacisty.
Jsem tak unavený z titulků, které tvrdí, že " práce na dálku je mrtvá."nebo že" práce na dálku byla neúspěšným experimentem."
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno clickbait, ale dělá mi starosti o manažery a manažery, kteří čtou tyto články.
Před rokem 2020 probíhala práce na dálku.
Stále existují práce, které lze v dohledné budoucnosti splnit na dálku.
Vzdálená práce umožňuje.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístup každému, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim zabere čas od jejich dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte zobecňovat a snažte se pochopit, jak vaši zaměstnanci skutečně odvádějí práci.
#WFH # podnikání #neurodiversity
Není to jen konzervativci versus progresivisté, řekl seminář více než 100 přívrženců v Grande Prairie.
"Je to válka mezi pro-lidmi a anti-lidmi," řekl.
Parker se zmínil o potratech a impulsu moderních městských žen odložit mít děti kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
"Jste uhlík, který se snaží snížit."
Takže jako od začátku ke všem mým narozeninám v minulosti, vždy jsem měl drsné.
Kdykoli se objeví Květen, obával jsem se, že se pokusím oslavit svůj bday.
Vždy se něco stane, pokazí se nebo skončí stresujícím a depresivním.
V průběhu let jsem bojoval, abych se dostal z tohoto myšlení a měl lepší bdays.
Trvalo roky, než jsem změnil svůj život a tvrdě pracoval,ale nakonec...
Začínám se usmívat a užívat si bday bez obav.
A dnes se již stává skvělým dnem!
Zima je 30 dny pryč v této malé části velkého Jižního světa.
Ale nemůžu se nechat oklamat!
Tohle je začátek.
Déšť padá a zatímco není zmrzlý, nebudete v něm tančit!
Je to skvělý den na objednání dodávky zmrzliny.
Byl to jeden pes noc a že doggo nebyl dostat z postele ani pro " psí snídaně-snídaně pro psa!"
Podšívku zapnu do cyklistické bundy - pro případ, že bych ji uvnitř potřeboval.
Víte o účinném způsobu, jak webová komponenta reagovat na přidání/odebrání z dokumentu?
Toto je pro knihovnu komponent Wikipedie (Ooui).
Je to většinou sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
V současné době používáme hack MutationObserver.
Pokud jde o výkon, nedodržujeme celý dokument.
Vytvoříme odpojeného rodiče temp, nainstalujeme tam MO a pozorujeme, jak se odděluje (tedy připojuje jinde).
Casper # rat je v dnešní době absolutní jednotkou.
Myslím, že moje nová práce pro něj byla dobrá - dva volné toulání denně, zatímco pracuji, v poměrně předvídatelných časech.
Konečně jsem dostal dobrou fotku, abych si mohl být jistý, že není tlustý.
(U # potkanů může být příliš vysoký tělesný tuk špatný pro jejich zdraví.)
Není.
Je prostě naprosto roztrhaný z trhání po mé kanceláři dvakrát denně.
Nemám váhu, abych ho vážil, ale má pocit, že je hodně přes libru.
Jsem moc rád, že se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1)mírné úpravy rozložení mapy Hel ' s Fighters.
Nabídka mapy je navíc plně funkční!
2) Systém odměn měny byl připojen.
Zítra bude testován s různými bitvami.
Deštivé dny!
Minulý týden jsem udělal tunu a cítil se mnohem lépe o polních položkách.
Všechny límce, kapusta, mangold jsou transplantovány.
Plánuje nastavit salát v Penn na 6row vzoru a uvidíte, jak se to srovnává s vysíláním nasazených lůžek.
Jarní hrášek v Gilpinu se objevuje, takže je třeba nastavit trellise.
Také je třeba semeno salát řádek tam integrovat řezané greeny v obou mají vyškolenou posádku na zavlažování, postel prep, a přesazování, což je 90% non-sklizni dovedností položek
Je rok 2023 a stále vidím, jak se lidé s iPhony aktivně vyhýbají používání Apple Maps.
Apple Maps je standardně dodáván s iOS, a přesto by lidé šli z cesty ke stažení a instalaci Map Google do svých iPhonů.
Netuším proč.
Zvědavý jsem měl otevřenou mysl, abych porovnal, jak Google Maps a Apple Maps porovnávají, na svém testovacím zařízení iPhone (můj denní ovladač je zařízení Android, takže je vzácné, že používám iPhone).
Zkušenost s dodržováním pokynů byla na Mapách Apple ve srovnání s Mapami Google mnohem lepší.
Apple Maps vyhrává.
Proč tedy lidé skákají přes další obruče, aby si nainstalovali Mapy Google?
Nemám ponětí.
Je možné, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa Apple Maps 2012?
Je možné, že Vyhledávání Google je integrováno s Mapami Google?
Nemám ponětí.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch neuvolňování odpadků koncovým uživatelům a Apple královsky v prdeli s jejich Apple Maps, když vyšel v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to země, která z ní dělá dobrého skladovatele bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a je třeba jej vyměnit.
Mnoho ppl si myslí, že doslova vlastní zemi, když si koupí kus.
Není tomu tak.
V Číně si můžete pronajmout pouze půdu.
Nejsou tak hloupí, aby prodali prodej navždy.
Vláda může tyto politiky kdykoli změnit.
Země je dočasná.
Zdá se nepředstavitelné, že země může být odebrána jednoho dne, když sledujete australské a americké mediální kanály, ale je to proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl přemýšlela určitým způsobem.
Země je velmi snadno a rychle odebrána vládou jednoho dne, pokud to chtějí udělat.
A hádej co?
Nikdy nedávalo smysl, jak může ppl udržovat půdu na úkor ostatních.
Jednoho dne to musí být odebráno.
Proto Číňané povolují pouze nájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem investorům, kteří tam jsou, připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, opatrujme jednoduché, ale pravdivé věci v životě, které nám přinášejí radost a naplnění.
# Robecofirm#geolog #podnikání #udržitelnost #úspěch #přátelství #toast # sny
Často přemýšlím nad lidskou schopností být * tak * dole na sobě, zatímco jsem zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a vinou ve světě, kde je "úspěch" tak často udělován lidem odpovědným za nejodpornější činy...
Všichni jsme taková špinavá zvířátka.
Ale mírné zoufalství nad naší nepořádností je zásadní-protože nám dává více prostoru k řešení ruin všude kolem.
Tak se snažte nezapomenout, co?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: "na rychlosti psaní nezáleží!"
nebo "modální editoři jsou dnes k ničemu": morty:
Extrahování funkcí mých projektů #Axum do sdílených knihoven: "Hold my keyboard" :partyparrot: :helix:: ferrisdance:
Nejsem si jistý, jestli je to nejlepší přístup ke sdílení, ale zatím se mi to líbí: < URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva Tento týden na odhalení je zůstat vzhůru celou noc.
Už pár dní si pohrávám s tímto malým kouskem na hlavě.
Je to rozhodně více romantiky než špíny.
Možná jsem četl mnoho románků s nemožnými "meet cutes" a to je výsledek, ale líbí se mi to.
Také jednoho dne jsem úplně udělám mile vysoký Orgasmus, možná ne s str
Nesouhlasím s tím, že # Mastodon je obtížné nastavit.
Běžné, opravdu to není tak těžké.
Je však obtížnější najít lidi, kteří by sledovali a budovali vaši časovou osu.
Přál bych si, aby bylo nějaké doporučení" koho následovat".
Ale kromě toho to není těžké - pokud používáte aplikaci 3.strany, jako je Elk a/nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá a necítí se dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali, a pravděpodobně budete potřebovat dobrou aplikaci pro zlepšení #UX.
Nevím, jestli je prevence možná, ale stojí za to ji vyzkoušet.
Čtyři kroky, které nastíním, jsou k diskusi, s určitým pokrokem v každém z nich:
Popis: názvy incidentů chování člověka a algoritmu, které odpovídají algoritmům a lidem.
Vysvětlení: účet za obě strany vzájemného vlivu
Předpovídání: předvídání škod dříve, než k nim dojde (i když po minutách)
Intervence: znalosti o věcech, které můžeme udělat, abychom vytvořili změnu, v určitých mezích důvěry
Nesledoval jsem radnici CNN, ale zdá se, jako by Trump řekl přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne odeslat na svém telefonu.
I kdyby je během radnice neřekl, všichni v Americe je stejně uslyší, opakovaně, od nynějška do listopadu 2024.
To ještě není důvod mu dát další místo, ale škoda je přehnaná.
Vyhraje Primárky.
Nemůžeme ho odvést.
Je tady a bude říkat tyhle věci bez ohledu na to, co se děje.
Přihlásil se do čekací listiny Google "AI Test Kitchen" a dostal se ve stejný den.
V tuto chvíli je to velmi ohromující.
"Musiclm Demo" je mírně zajímavé.
Můžete požádat o konkrétní skladbu, jako je "jazz with a trumpet solo in 5/4 tempo", a po několika sekundách vám vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... hudba je prostě... to není dobré.
Házení všeho, co máte, přes plot v reakci na GPT není ono.
Zkuste více Google.
Je to divné dělat vzpírání, ale také mít žádné skutečné ponětí, co je vaše one-rep-max, cus to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám ve své ložnici bez pozorovatele nebo dokonce stojanu na závaží.
Jen já a činka se spoustou závaží.
I bench press na mé posteli.
Pokud se pokusím zjistit, že můj jeden rep max je, možná nevlastním dostatek závaží, abych se maximalizoval, nebo naopak by mě mohl vážně zranit/zabít.
No nic, dneska to jde nahoru.
Pořád se cítím dobře.
Přísahám, že burrata před pěti lety neexistovala
Tohle je moje osobní věc s mandelovým efektem.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem to neviděl v luxusním obchodě s potravinami ani v žádném italském lahůdkářství.
Nikdy jsem neviděl, že by to něčí máma udělala, ani jsem to na mě strčil na večírku, ani jsem neviděl, že by se to objevilo ve spojení s něčími eskapádami nebo dny pečení
Jednoho dne se objevil a najednou byl k dispozici všude.
Vstoupil jsem do burratovy dimenze.
Drakeův stárnoucí iPad rozdává, takže je na trhu s novým tabletem.
Když jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo linuxový tablet, který miluje?
To by bylo hlavně pro procházení webu, příležitostné e-maily a některé hry.
V 1998-06 Gamefan, v souvislosti s dlouhým vývojem první neskutečné hry, Jason Schrieber komentoval,
"Dobrá hra je pozdě, dokud se nedodá.
Špatná hra je špatná navždy."
Takže to bylo epické, které to vzniklo?
Můžeme pokračovat.
Dřívější vydání GamePro 1997-11 má citát s mnohem nejednoznačností,
"Nebo, jak říká průmyslová fráze: pozdní hra je pozdě, dokud se nedodá.
Špatná hra je špatná po zbytek vašeho života."
Je to tedy tak pomíjivé?
Pouhá "hláška" bez jasného původce?
Kouřový, můj 10 měsíční mužský domácí modrý kotě, hraní s červeným gumovým zařízením Apple Pencil comfort zakoupeným od Amazonu utekl před měsíci.
Nosí to hrdě v ústech po celém domě a já se musím vnitřně smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní provedli celou zpáteční cestu novým vlakem ICNG.
Moc se mi to líbí.
Esp vozy s většími okny.
Jsou oblasti, které by mohly použít trochu lesku.
Konkrétně nedostatek dostatku košů a nedostatek značek, které by vysvětlovaly význam barev osvětlení.
Opravte tyto drobné problémy, a pak můžeme mít více z nich, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Jedna pravidla pro každého zákazníka zůstávají, protože se snažíme zajistit, aby každý, kdo stojí ve frontě, mohl dostat ruce na tabuli.
Můžete si koupit jednu z výše uvedených desek, ne jednu z nich.
Neexistují žádná omezení nákupu Picos nebo jiného zboží.
Včera jsem měl nejlepší čas se svým přítelem a bývalým rabínským kolegou.
Navštívili jsme několik hodin na mé verandě.
Taková přátelství přesahují rozdíly.
Všichni máme co vyprávět.
Pán vám žehnej a udržuje vás!
A bažina se ozelenila.
Docela se mi líbí akkoma software a název domény, který jsem dostal pro svou instanci.
Ale mám pocit, že jsem tento případ začal takříkajíc špatnou nohou.
A nikdy jsem se tam necítil pohodlně.
Bude tu ještě trochu déle a přemýšlet o tom, zda bych měl vůbec migrovat.
# FalconGameBooks
Zdá se, že Osmioké Repnidy sledují, jak usazujete leták na červené půdě, ale nepohybují se k vám, ve skutečnosti jsou nehybní, když vylezete z letáku a pomalu k nim kráčíte.
Země pod nohama se začne třást a pak se třást, jako by při zemětřesení a ztratíte půdu pod nohama, i když se Repnidy zdají být nedotčeny.
Skála pod vámi náhle ustoupí.
Repnidy se tunelovaly pod povrchem a spadnete do vroucí hmoty stovek repnidových těl v jeskyni dole.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl první lidský budoucí cestovatel.
Přistanete s nosem letáku nahoru na stranu hromady strusky a vylezete ven.
Zdá se, že Osmioké Repnidy sledují, ale nepohybují se k vám, ve skutečnosti jsou nehybní, když k nim pomalu kráčíte.
Zastavíš se ještě na hromadě rozpadlé skály a půdy a mluvíš k nim, rčení, " přicházím v pokoji, jako přítel.'
Zdá se, že vás neslyší, natož pochopit, protože váš univerzální Překladatel nezachytí žádnou odpověď.
Rozhodnete se použít své psychické vědomí, abyste je mentálně kontaktovali.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a vaše mysl se od kontaktu odvrací.
Rozhodnete se, že opětovné navázání kontaktu by bylo nebezpečné a vrátíte se ke svému letáku, ale zkušenost vám vyčistila mysl, která byla zmatená od té doby, co jste skočili do budoucnosti.
Jakmile se vrátíte do Falcon ' s Wing, zjistíte, že je docela snadné naplánovat kurz pro zemi v roce 3034 NL.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[cont ' d]
# dnes mám kávu, slunce a klidný čas!
Začal jsem nový šátek.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně spředenou stříbrně šedou přízi, která je většinou jemně spředená hrudkami.
Plánuji to smíchat s jemnou fialovou / lila pestrou bavlnou.
Ale nejsem si jistý, jestli mám dost fialové.
Používám h háček s podobným dvojitým háčkováním, jako jsem to udělal dříve.
Včera jsem se poprvé připojil, takže uvidíme.
Přeji všem šťastný čtvrtek!
Nesnáším však hodiny výtvarného umění a literatury a moje školní historie to nese.
Doslova jsem se snažil a upustil každý z nich.
A ještě před dvěma lety jsem to netušil, dokud jsem nekontroloval své přepisy.
Literární třídní nenávist je ještě horší: rád čtu.
Většinu klasik jsem trefil před osmnáctkou-i když to je spíš odraz života v bumfucku, četl jsem v zoufalství i encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a úžasný a jsem tam šťastný, ale musím být někde jinde, abych se dostatečně ochladil, abych během dne četl beletrii, aniž bych se cítil provinile.
Je to, jako bych byl na dovolené, a proto dělám to, co člověk dělá na dovolené.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma a trochu jsem se dostal z toho, že jsem prostě v podivném prostředí, kde jsem méně schopen tempo a musím si pamatovat, kde jsou věci.
A to i přesto, že stále mám svůj seznam úkolů a organizuji také svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny dobré věci, které na práci ve hrách miluji.
Co si o tom lidé pomyslí?
Líbí se mi to, ale dokáže přilákat publikum správných hráčů?
Rozkvete komunita kolem obsahu vytvářeného uživateli ve hře?
(Opravdu v to doufám.)
Příběh hry, nápady a otázky, které inspiruje, se cítí aktuální.
Doufám, že to půjde dobře.
Je ThinkPad den!!
Přišel jsem domů o polední přestávce, abych viděl toto posezení před uwu.
Přál bych si, abych to mohl vzít zpět do práce se mnou a nastavit více.
Ale to bude muset počkat do večera.
Takže jsem konečně sledoval #Heartstopper
Bylo to příliš roztomilé do té míry, že je twee?
Rozhodně
Mluví některá z těchto postav o lidských bytostech?
Ani vzdáleně
Ale miloval jsem to?
Rozhodně!
co tu dělala Olivia Colemanová?
Dlužila někomu peníze?
Měl čerstvý absolvent umělec vzít nějakou kritiku špatně dnes večer.
Částečně proto, že by se špatně učili.
Je však důležité nevymlouvat se na problémy a jen je opravit, zejména ve výrobě, když váš vedoucí potřebuje změny.
Zejména s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tu, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Předpokládá se, že máte schopnost problém vyřešit nebo najít řešení.
Takže zatímco kompostování a rolování květů jsou skvělou připomínkou, abyste se podívali nahoru a byli si vědomi života mimo obrazovku.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak se semena vysévají a pěstují (a nejsou náhodně rozptýlena) dobrými peepy.
Tyto kořeny jsou skryté.
Práce není viditelná.
Ale pro silný a pevný budoucí růst.
Jami mu zasunul poznámku, když se míjeli na cestě, těsně před hlídkou psa.
Byla na cestě ke zdi, on odcházel ze služby.
Podíval se za sebe, aby ji sledoval, jak jde, a aby se ujistil, že je nikdo neviděl.
Neohlédla se.
Počkal, až bude ve tmě palandy, než vytáhl poznámku a přečetl ji v paprsku světla procházejícím zatemňovacími závěsy.
Jeden blok-tištěné slovo.
Dlouho na to zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových #Mastodonových kamarádů a chci tento trend udržet.
Volání do # Fediverse mě nutí cítit se jako velryba zpívající obrovským oceánem!
Chcete se připojit k mému "podu"?
Zvláště bych se chtěl spojit s více.
Každý, kdo má vlasy v ohni o CNN, může poděkovat Stephenu Colbertovi za tvrdou odbočku doprava.
Pomohl udělat z Chrise lichta národní problém.
I když by se nám někteří lidé mohli líbit, pokud jen poskytují fašistům malou ligovou kariéru, pravděpodobně by ji měli nosit.
Bylo to poprvé (ale nebude to poslední), kdy Kaveesha Dilhari zaznamenal 20+ běhů a vzal 2+ branky ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, aby dosáhla všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilném protestu před britským uprchlickým hotelem
K incidentu došlo poté, co se zvýšil počet uprchlíků a žadatelů o azyl překračujících kanál do Velké Británie na lodích.
Policie zatkla 15 lidí poté, co se demonstrace proti uprchlíkům před hotelem používaným k ubytování žadatelů o azyl stala násilnou poblíž anglického města Liverpool.
Policejní oddělení Merseyside uvedlo, že policista a dva civilisté utrpěli během rušení v pátek večer v Knowsley lehká zranění.
Podle policie někteří demonstranti házeli předměty a zapalovali policejní dodávku.
Zatčení lidé, kteří se pohybovali ve věku od 13 na 54, byli zadrženi " po násilné poruše."
Merseyside policejní komisař Emily Spurrell řekl Radio City, " bylo to neuvěřitelně nebezpečné a mezi policisty došlo k několika zraněním."."
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje Knowsleyho v britském parlamentu, řekl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou fanatici a vítají lidi, kteří utíkají z nejnebezpečnějších míst na světě a hledají bezpečné místo," řekl.
"Ti, kteří demonstrují proti uprchlíkům na tomto dnešním protestu, nereprezentují tuto komunitu."
Protest se konal uprostřed zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů překračuje kanál v malých člunech.
Do Velké Británie touto cestou dorazilo v roce 2022 více než 45 000 lidí a většina požádala o azyl.
Systém posuzování žádostí o azyl se kvůli politickým nepokojům a byrokratickým průtahům zpomalil, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Přechody přes kanál La Manche se staly politickým problémem, kdy konzervativní vláda slíbila "zastavit lodě" a prosazovala plán vyslat takové žadatele o azyl do Rwandy.
Odpůrci obvinili vládu z démonizace zoufalých lidí prchajících před válkou a chudobou.
Prezidentský pohár: Candystripes porazil Rovers v sezoně v Brandywellu
Derry záložník Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City zvítězilo v prezidentském poháru, když došly vítězům 2-0 Shamrock Rovers.
Držitelé poháru FAI porazili vítěze minulé sezóny v Brandywellu díky gólům Willa Patchinga a Michaela Duffyho v první polovině.
Obruče tlačil na snížení podmínek ve druhé polovině, ale ruaidhri Higgins' obvinění stál pevně vyhrát opona-raiser.
Derry cestuje do St .. Patrick ' s Athletic na otvírák ligy příští pátek.
Patchingův boční volej postrčil Derryho dopředu po 23 minutách-záložník otevřel skóre, když Foylesider vyběhl 2-1 vítězové nad případnými šampiony loni v únoru.
Obruče pokračoval vyhrát Premier Division 13 body, ale Duffy brzy měl City dále dopředu s dlouhým doletem úsilí, které se podařilo kroutit pod brankářem Leon Pohls a do sítě.
V uplynulé sezoně byli o přestávce dva góly k dobru.
Graham Burke šel nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byli pohodlnými vítězi týden před jejich hledáním národní slávy.
Šéf města Ruaidhri Higgins ocenil svůj tým poté, co řekl, že byl "nejtěžším týdnem mého života" po smrti jeho bratra Kevina.
"Je to kopanec do zubů a čekají nás těžké týdny, ale budeme si to pamatovat v jeho paměti," řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě tak s dobrým výkonem je opravdu příjemné."
DHS najímá advokátní kancelář, aby zvládla možné řízení o obžalobě Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti najalo externí advokátní kancelář-Debevoise & Plimpton-na pomoc při případném řízení o obžalobě tajemníka Alejandra Mayorkase, protože potenciálně čelí obvinění republikánů Sněmovny ohledně manipulace s jižní hranicí.
"Ministerstvo vnitřní bezpečnosti si ponechalo externí poradce, aby pomohlo zajistit, aby životně důležitá mise Ministerstva nebyla přerušena bezprecedentním, neoprávněným a stranickým obviněním některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl mluvčí DHS v pátek v prohlášení.
"DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reakci na přírodní katastrofy a zabezpečení našich hranic a zároveň odpovídajícím způsobem reagovat na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS."
Úředník DHS řekl CBS News, že ministerstvo najalo firmu na smluvní práci po dobu vyšetřování Kongresu.
Debevoise byl vybrán kvůli svým odborným znalostem v obžalobě a bipartisanským zkušenostem při práci s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., v říjnu. 13, 2022.
OLIVIER DOULIERY / AFP přes Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise se kvalifikuje jako vhodný výdaj pro DHS.
DHS se snaží zajistit, aby její poslání nebylo podkopáváno stranickými útoky a aby řízení proti starostům řešili lidé s patřičnou odborností.
Mayorkas se k tomuto vývoji nevyjádřil, ale zeptal se na vyšetřování obžaloby minulý čtvrtek novinářům řekl: "budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s posledním Kongresem. Myslím, že je to naše zodpovědnost."
Připustil, že" bude nějakou dobu trvat", než se podaří vyhovět vyšetřování Sněmovny.
"Budu trávit tento čas stejně jako ostatní a také nebudeme kompromitovat čas, který trávíme plněním našeho poslání."
Vysoký představitel DHS potvrdil, že Mayorkas se dosud nesetkal se svým novým externím poradcem.
Obžalován byl pouze jeden člen vlády, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese s.Granta, obviněn z přijímání úplatků, ale nakonec byl senátem osvobozen.
Trendy Novinky
Díky za přečtení CBS NEWS.
Čtyři dospívající obviněni z útoku 14letého muže, který zemřel na sebevraždu poté, co porazil video, bylo zveřejněno online
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ
Táta says Dcera taked ji vlastní život po being bullied na NJ školní 02: 33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem 14leté dívky, která si později vzala život poté, co bylo video incidentu zveřejněno na sociálních médiích.
Jeden mladistvý je obviněn ze zhoršeného útoku, dva mladiství jsou obviněni ze spiknutí za účelem spáchání zhoršeného útoku a jeden mladistvý je obviněn z obtěžování, státní zástupce Ocean County Bradley D.Billhimer řekl CBS News v e-mailu.
Adriana Kuch, 14, byla nalezena mrtvá ve svém domě v Bayville v únoru 3, dva dny poté, co bylo Online zveřejněno znepokojivé video z útoku na střední regionální střední školu.
Video ukázalo, že dívky házely na teenagera drink, pak ji kopal a táhl po školních chodbách.
Adrianu strčili do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili kuch opakovaně praštila.
Další dívka mimo záběr videa se smála, když nahrávala scénu.
Dva dospělí přišli rozbít útok, s jedním dospělým tahání dospívající od sebe.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý snažil pomoci.
Jedna z dívek řekla: "To je to, co dostanete."
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali, " řekl ve čtvrtek CBS New York její otec Michael Kuch a dodal, že je naštvaný a chce, aby všichni viděli video a to, co dospívající udělali jeho dceři.
14letá Adriana Kuch zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video, na kterém byla napadena ve škole. CBS 2
Kuch řekl, že policie měla být okamžitě přivolána, protože studenti, s nimiž podle něj měla jeho dcera problémy, jí rozbili obličej lahví o objemu 20 uncí.
"Pokud by zavolali policii a provedli vyšetřování, ty dívky by nezveřejnily videa ze školy," řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
"Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni," řekl Dr. triantafillos Parlapanides, dozorce škol, řekl CBS New York.
Úředníci školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni do budoucích soudních vystoupení, řekl státní zástupce CBS News.
Studenti ve škole uspořádali ve středu stávku na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v emocionální nouzi nebo v sebevražedné krizi, můžete dosáhnout záchranného lana 988 Suicide & Crisis voláním nebo SMS 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Další informace o zdrojích a podpoře péče o duševní zdraví najdete na lince pomoci Národní aliance pro duševní nemoci (Nami) od pondělí do pátku, 10: 00-10: 00.
ET, na 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 zdraví, wellness profesionálové o vyhýbání se vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v naší práci.
To může být pro ty ve zdravotnictví extrémně obtížné, a proto jsem se zeptal 30 odborníků na zdraví a wellness na stejnou otázku: "jak zvládáte svou energii a nevyhoříte ve své profesi?"
Jejich kariéra sahá od lékařů s infekčními chorobami přes psychology až po učitele všímavosti - a všichni měli skvělé rady, jak zůstat motivovaní a udržet míč v pohybu.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vynikala jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají smrtelné nemoci, eufrosina Young děkuje svému silnému systému podpory za schopnost udržovat svou energii.
Young je certifikovaný neurolog a specialista ALS na neurologickém oddělení Upstate University Hospital a říká, že se tam" mobilizují jako armáda lidí".
Neexistuje lék na amyotrofickou laterální sklerózu (ALS), ale s vědomím, že není jediná, kdo tvrdě pracuje na vývoji léčby a poskytuje lepší možnosti pro své pacienty, udržuje mladé i v nejtěžších dnech.
"Neneseme tíhu světa, ale jsme součástí světa lidí, kteří tuto práci obhajují," říká.
2.Odpočívejte, když potřebujete
Práce dvou zaměstnání jako výzkumník spánku a inženýr algoritmů, to vše při péči o nové dítě, by rozhodně vedlo Raphaela Vallata k vyhoření, kdyby neodpočíval, říká.
"Mám pocit, že když se chystám vyhořet, v podstatě každý úkol se cítí jako hora, na kterou musíte vylézt, a cítí se velmi naléhavý a důležitý," říká Vallat.
V těchto chvílích " si opravdu musíte vzít volno a uvědomit si, že tyto úkoly mohou počkat."
Vallat obvykle najde ve svém dni chvíle, kdy se může zastavit a trávit čas v přírodě, aby se před návratem do práce uzemnil.
3.Be vášnivý o tom, co děláte, a pamatujte si svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounder 100 hodin týdně po dobu sedmi dnů v týdnu.
Být v první linii během pandemie jí sežralo téměř veškerý čas, vyhoření se ale vyhnula tím, že si připomněla, proč je její práce důležitá.
"Nemyslím si, že práce se cítí jako práce, když máte pocit, že máte dopad," říká Gounder.
"Pokud pracujete šílené hodiny dělat něco, co nemá žádný význam pro vás, myslím, že opravdu potřebujete ustoupit a ptát se, co děláte."
4.Mít jiné radosti
Každý z odborníků uvedl, že se věnuje nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je nesmírně důležité mít život, který vás baví a který převyšuje to, čeho ve své práci dosáhnete, říká Christina Maslach, sociální psychologka, profesorka psychologie v důchodu na U.C. Berkeley a autorka knihy "the Burnout Challenge: Managing People' s Relationships with Their Jobs."
"Podívejte se na svůj život jako celek a ujistěte se, že jsou v něm dobré věci, a ujistěte se, že na ně máte čas."
Získejte ZDARMA průvodce investováním Warrena Buffetta CNBC, který destiluje nejlepší radu miliardáře č. 1 pro pravidelné investory, co dělat a co nedělat, a tři klíčové principy investování do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Získejte chytřejší informace o svých penězích a kariéře s naším týdenním zpravodajem
Mladistvý obviněn z vraždy v prosinci Chicago školní střelba, která opustila 2 mrtvý
16letý chlapec byl obviněn z vraždy při smrtelné střelbě dvou studentů na Chicagské střední škole v prosinci, oznámila policie v pátek.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou trestných činů pokusu o vraždu, oznámil policejní dozorce v Chicagu David Brown.
"V současné době nemáme jasný motiv, proč by 16leté dítě chtělo zastřelit a zabít další děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Oběťmi, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti pomohly přivést je k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční za ty, kteří byli dost odvážní, aby se přihlásili, aby zajistili, že pachatel bude chycen a nyní bude odpovědný," řekl státní zástupce okresu Cook Kim Foxx.
Očekává se, že podezřelý se objeví v sobotu u soudu, řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Biologové z Minnesoty zachránili uvězněného černého medvěda
Ministerstvo přírodních zdrojů v Minnesotě přišlo na záchranu medvědího nešťastného medvěda poté, co byl uvězněn v příkopu.
Medvěd se podle příspěvku na Facebook z oddělení schoval do propustku podél silnice poblíž Wannasky v Minnesotě.
Když ale sníh začal tát, propustek začal zaplavovat a medvěda uvěznil v hlubokém sněhu a ledu, podle oddělení.
Pracovníci oddělení rychle reagovali na scénu a pomohli medvěda odstranit.
Biolog medvědů z oddělení Andrew Tri " medvěda prozkoumal a prohlásil ho za zdravého, ale omámeného - samozřejmě, protože byl probuzen ze zimního spánku," uvádí Facebook.
Oddělení poté přemístilo medvěda do státní svatyně, aby obnovilo jeho hibernaci.
Ospalý masožravec byl odhadován na 6 let a mezi 375 a 400 librami.
Ministerstvo obyvatelům připomnělo, že stěhování medvědů je práce, kterou je nejlepší nechat na profesionálech.
Pokud se obáváte medvěda ve vašem okolí, měli byste kontaktovat místní úřady - nesnažte se spát nebo krmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tarts, hlávkový salát a ozdobné hodové krmivo pro kočky.
Ale naštěstí pro dobře míněné Bagry: "protože medvědi nemají chuť jíst v zimě, medvěd nekousl."
Podle ministerstva přírodních zdrojů je Minnesota domovem 12 000 až 15 000 černých medvědů, kteří se vyskytují hlavně v Severní třetině státu.
Predátoři v zimě hibernují až šest nebo sedm měsíců, během nichž nejí a nežijí ze svého uloženého tělesného tuku.
Fotografie: po restaurování Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Džehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedli generální tajemník Nejvyšší rady starožitností v Egyptě Mostafa Waziri, velvyslanec Span v Egyptě Alvaro Iranzo a prezident španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že tyto dvě hrobky byly objeveny prostřednictvím společné Egyptsko-španělské archeologické mise Nejvyšší rady starožitností a CSIC, která funguje od roku 2002.
Řekl, že mise provedla výkopové a restaurátorské práce a zveřejnila výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odhalit mnoho hrobek, rakví, mumií a pohřební zahrady.
Důležité hrobky z významné éry
Wazir vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili na počátku 18.dynastie Nové Říše - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že uspořádání hrobek má tvar T, styl běžně používaný v hrobkách z 18.dynastie.
Jedná se o vchod, sloupovou halu vedoucí k pohřební šachtě a stěny s výraznými nápisy.
Waziri dodal, že Džehuty byl supervizorem státní pokladny a přehledně prohlížel díla řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byla také zodpovědná za záznam Hatšepsutovy cesty do Puntlandu a za poskytnutí electrum (směs zlata a stříbra) pro zakrytí vrcholu obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
Místnost, která předchází pohřební komoře Djehuty, obsahuje nápisy vyryté 43 kapitolami Knihy mrtvých, poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek, než byly napsány na prádlo a papyrus.
Hery, zastával funkci dozorce královských obchodů posvátné královské manželky a matky Ahhotepa.
Jared O ' Mara nikdy neměl být labouristickým kandidátem, říká Rachel Reeves
Zneuctěný bývalý poslanec Jared O 'Mara" nikdy neměl být vybrán jako labouristický kandidát" a zaslouží si čtyřletý trest vězení, řekl stínový kancléř.
Rachel Reeves mluvila s Guardianem ve volebním obvodu Bolton North East v pátek, několik hodin poté, co klíčové postavy místní strany skončily na protest proti tomu, jak labouristický národní výkonný výbor (NEC) kontroloval parlamentní výběrové řízení pro příští všeobecné volby.
Celá výběrová komise v Bolton North East rezignovala poté, co jim nebylo dovoleno vybrat si užší seznam, což je stále běžnější praxe v Keir Starmerje Labouristická strana, říká: "opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místní členové na severu."
Dodali: "to je v rozporu s postojem nezbytným k získání zpět červené zdi, která je tak zoufale potřebná k vytvoření labouristické vlády."
Reeves řekl: "nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Tam byl zvláštní neštěstí, že Leigh Drennan, předseda Labouristické North West a asistent Jeremy Corbyn-podporující Warrington North MP Charlotte Nichols, nebyl longlisted pokusit se získat křeslo zpět od konzervativců, navzdory sbírání nominací ze čtyř velkých odborů.
Reeves řekla, že nemá nic společného s výběrem kandidátů, ale dodala: "vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo do užšího výběru."
O ' Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné nároky na výdaje v celkové výši £52,000 ve snaze financovat jeho zneužívání kokainu a alkoholu.
Mnoho lidí navrhlo, že nebyl řádně prověřen labouristy, když byl vybrán k boji Nick Clegg, bývalý liberální demokrat místopředseda vlády, v Sheffield Hallam v 2017 snap všeobecné volby.
Na otázku, zda se debakl O 'Mary rýsuje v myslích labouristického NEC, Reeves řekl:" Nechci žádným způsobem naznačovat, že kdokoli, kdo není na užším seznamu, je uživatelem kokainu.
Ale Jared O ' Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest."
Okolnosti O 'Mary byly" docela výjimečné, "řekla Reevesová, ale uznala:" pro Labouristickou stranu a všechny politické strany je třeba se při výběru kandidátů poučit.
Ale také bych řekl, že v tomto Parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě sledem předsedů vlád a pokut a stran a standardů, které nedosahují toho, co byste mohli očekávat."
Dodala: "" jedna věc, kterou bych řekla o labouristické straně, je, že když lidé dělají špatně, ztrácejí bič. A to v Konzervativní straně prostě neplatí."
Archie Bland a Nimo Omer vás provedou hlavními příběhy a tím, co znamenají, zdarma každý pracovní den ráno.
Oznámení o ochraně osobních údajů: informační bulletiny mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich zásadách ochrany osobních údajů.
Používáme google reCaptcha k ochraně našich webových stránek a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku pro Openreach, které poskytuje britskou širokopásmovou síť.
Poté, co sledoval, jak učni šplhají po předstíraných telegrafních sloupech na místě 1,7 milionu liber, Reeves diskutoval o plánech labouristů na přepracování učňovského poplatku, který nutí větší firmy odložit 0,5% své mzdy na financování učňů.
Firmy si stěžují, že poplatek je příliš nepružný. Například, řekl Reeves, Openreach " chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vlákně, ale učňovský poplatek nemá takovou flexibilitu kolem rekvalifikace."
Reeves uvedl, že labouristé změní odvody, aby firmy mohly peníze použít na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový průmysl a ty, které v současné době montují plynové kotle.
"Potřebujeme je jako součást energetického přechodu na čistou nulu, abychom se naučili dovednosti pracovat na elektrických vozidlech nebo montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se proti nim hromadí učňovský poplatek.
Podniky chtějí větší flexibilitu a mladé lidi začínající v životě nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost," řekl Reeves.
Jeden zatčen uprostřed protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena uprostřed protestu u Tate Britain, kde se konala událost vyprávění drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově zhoršeného Komentáře vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyla hlášena žádná zranění a policisté zůstávají na místě, řekla síla.
Tate v sobotu hostil Drag Queen Story Hour UK, s příběhy vyprávěnými Aidou H Dee, kterou web Galerie popisuje jako "prvního umělce v Evropě, který četl příběhy dětem v dětském pokoji."
Pravicová skupina demonstrantů demonstrovala před galerií a setkali se s nimi protiprotesteři vedeni bojovníky za práva a politickými skupinami, včetně postavit se rasismu.
Strážníci museli vytvořit chodbu, aby se účastníci mohli dostat na místo konání.
Psaní na Twitteru, drag queen řekl, že den byl " správný emocionální, "a dodal, že pět demonstrantů získalo vstup do Tate a" způsobilo narušení " v částech budovy, ale neovlivnily čtení.
Dříve řekla Pink News, že pozvání na Tate na akci během měsíce historie LGBTQ+ bylo "ctí."
Její četby se již dříve staly terčem demonstrantů.
Drag Queen uvedla, že" hodnocení rizik "proběhlo předem - ale dodala, že je" směšné", že jsou nezbytná.
Aida tweetovala: "5 nenávistníků se dostalo do Tate.". Způsobili narušení. Ale ne táhnout příběh hodinu UK ...Udělali rozruch jinde v budově, ne tam, kde byla show!! SHOW 2 šla plavat!!!"
Aida uspořádala tři vyprávění v sobotu v 11 hodin, poledne a 2pm.
Mluvčí Tate řekl: "neprogramujeme umělce, abychom propagovali konkrétní úhly pohledu, ani abychom sladili různé úhly pohledu."
Naše Galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, s jakými aspekty se zabývají."
Trumpova ceněná budova 40 Wall Street na "Lender Watch" uprostřed klesajícího příjmu: zpráva
Těžce zastavený mrakodrap Donalda Trumpa na 40 Wall Street je na" lender watch " uprostřed klesajících příjmů a rostoucích nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější-vyskočila ve třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání o zbývající hypotéce ve výši 126,5 milionu dolarů, uvedla agentura Bloomberg.
Výdaje mezitím údajně vzrostly o 11% od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
Den září. 11, 2001, teroristické útoky, které zničily Světové obchodní centrum a zabily 3 000 lidí, Trump se v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, byla to také lež.
Další nedaleký mrakodrap na Pine Street na Dolním Manhattanu se stal nejvyšší budovou po zničení dvojčat.
Leasing výškových kanceláří na Manhattanu už léta klesá, což se po vypuknutí pandemie COVID-19 ještě zhoršilo, protože mnoho společností se uzavřelo a zaměstnanci přežívajících firem pracovali na dálku.
Wells Fargo, který obsluhuje hypotéku na 40 Wall Street," oslovil dlužníka kvůli stavu vývoje leasingu " a plánům na zlepšení výkonnosti nemovitosti, uvádí Bloomberg.
Majitel Wagnera říká, že válka na Ukrajině se bude táhnout roky
Majitel ruské soukromé vojenské společnosti Wagner Group, která se aktivně podílí na bojích na Ukrajině, předpověděl, že válka se může táhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném pozdě v pátek řekl, že může trvat 18 měsíců až dva roky, než Rusko plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny Donbas.
Dodal, že válka může trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpr.
Prohlášení Prigozhina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinovým kuchařem" pro jeho lukrativní smlouvy o stravování v Kremlu, znamenalo uznání obtíží, kterým Kreml čelil v kampani, které původně očekával, že se zabalí během několika týdnů, když ruské jednotky napadly Ukrajinu v únoru. 24.
Rusko na podzim utrpělo řadu ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšné protiofenzivy s cílem získat zpět široké oblasti území na východě a jihu.
Kreml se vyhnul předpovědím, jak dlouho by boje mohly pokračovat, a řekl, že to, co nazval "speciální vojenskou operací", bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří oblast Donbas, kde separatisté podporovaní Moskvou bojují s ukrajinskými silami od roku 2014.
Prigozhin uvedl, že žoldnéři Wagnerovy skupiny pokračují v tvrdých bojích o kontrolu nad ukrajinskou pevností Bakhmut v Doněcké oblasti.
Připustil, že ukrajinské jednotky budují prudký odpor.
Zatímco ruské jednotky prosazovaly své útoky na Donbasu, Moskva se také snažila demoralizovat Ukrajince tím, že je v hořké zimě nechala bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Ve východních, západních a jižních oblastech byla zasažena zařízení infrastruktury vysokého napětí, což mělo za následek výpadky proudu v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná", a dodala, že se jedná o zálohy na udržení dodávek energie, ale poznamenala, že příděl energie bude v některých oblastech pokračovat.
Ukrajinský vojenský velitel generál Valerii Zaluzhnyi uvedl, že ruské síly odpálily 71 řízených střel, 35 střel S-300 a sedm dronů Shahed mezi koncem čtvrtka a pátečním polednem a dodaly, že Ukrajinská protivzdušná obrana sestřelila 61 řízených střel a pět dronů.
Ukrajinské úřady oznámily další útoky zabijáckých dronů později v pátek.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 letounů Shahed.
V pátek zveřejnili ruští vojenští blogeři a některé ukrajinské zpravodajské stanice video ukazující útok mořského dronu na strategický železniční most v oblasti Odesa.
Zrnité video ukazovalo rychle se pohybující objekt blížící se k mostu v Zatoka, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a explodující při silném výbuchu.
Pravost videa se nepodařilo ověřit.
Ukrajinská armáda se k útoku nevyjádřila a Serhii Bratčuk, mluvčí regionální správy, nepotvrdil útok dronu, Když v sobotu hovořil v televizních komentářích.
Most, který byl terčem ruských raketových útoků na začátku války, slouží železničnímu spojení s Rumunskem, které je klíčovým potrubím pro západní dodávky zbraní.
Sledujte reportáž agentury AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli 7 přeživších a těla 19 zemřelých v Türkiye: 11. února 2023, 12: 15
GAZIANTEP.KAZINFORM-kazašští záchranáři pokračují v kopání sutin a hledají přeživší v Türkiye, cituje Kazinform tiskovou službu kazašského Ministerstva pro mimořádné situace.
Práci záchranářů brání velké množství trosek a nestabilní konstrukce.
Kazašský záchranný tým zatím v Türkiye vytáhl sedm přeživších otřesů a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc je poskytována také nepřetržitě.
Pozoruhodné je, že zemětřesení o síle 7,7 stupně, které zdevastovalo části jihovýchodního Türkiye a severní Sýrie, zasáhlo už v pondělí.
K dnešnímu dni počet obětí masivních otřesů zasažených jihovýchodně od Türkiye přesáhl 20 000.
Foto: t.me/qr_tjm
Asijské mistrovství má dát nový impuls rozvoji atletiky
KAZACHSTÁN.KAZINFORM-slavnostní zahájení 10. halového mistrovství Asie v atletice se konalo v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil Kazašský Premiér Alikhan Smailov, Kazinform cituje tiskovou službu kazašského předsedy vlády.
Zahájení akce, vedoucí kazašské vlády přečetl uvítací dopis prezidenta Kassym-Jomart Tokayev.
"Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro profesionální a masové sporty.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex s kapacitou přes šest tisíc lidí," stojí v dopise kazašského prezidenta.
Kazašští sportovci úspěšně soutěží a reprezentují Kazachstán na hlavních světových soutěžích.
Jsou příkladem rostoucí generace a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že pořádání asijských šampionátů v Astaně dá nový impuls rozvoji atletiky v zemi a zaváže se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský Premiér Smailov vyjádřil zvláštní vděčnost prezidentovi asijské atletické asociace Dahlanovi Al-Hamadovi za pomoc při přípravě a pořádání mistrovství.
Halové mistrovství Asie v atletice se koná poprvé na území SNS.
Na turnaji se sešlo více než 500 sportovců z 31 zemí, kteří mají soutěžit v závodě, štafetovém závodě, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí a všestranné akci.
Turnaj potrvá do 12. února.
Dříve se uvádělo, že Kazašská běžkyně Caroline Chepkoech Kipkirui získala zlato žen na 3 000 m a Olga Safronová získala na turnaji stříbro žen na 60 m.
Foto: primeminister.kz
Herec "Yellowstone" Q ' orianka Kilcher bije obvinění z podvodu
Advokát Camille Vasquez, který zastupoval Johnnyho Deppa v loňském trháku hanobení, zaznamenal další právní vítězství-tentokrát s "Yellowstonskou" herečkou Q ' oriankou Kilcherovou.
V pátek, kancelář okresního prokurátora v Los Angeles vyčistila Kilchera, 32, ze všech obvinění v případě podvodu s kompenzací pracovníků.
V prohlášení sdíleném v pátek s The Times, mluvčí okresního prokurátora okresu Los Angeles uvedl, že soud "rozhodl, že paní Kilcherová se nedopustila pojistného podvodu, a informoval soud, že nemůžeme pokračovat."
V červenci 2022 kalifornští úředníci obvinili Kilcherovou ze dvou trestných činů podvodu s odškodněním pracovníků a obvinili ji z nelegálního výběru více než 96 000 $v dávkách v invaliditě mezi říjnem 2019 a zářím 2021.
Časový rámec zahrnuje také několik měsíců, kdy Kilcher pracoval na "Yellowstone", navzdory hercovým tvrzením, že byla příliš zraněna na práci.
Kilcher se vzdal a byl obviněn v květnu.
"Dnes jsem vděčný za to, že můj případ byl zamítnut - zítra moje cesta začíná pomáhat zvyšovat povědomí a požadovat větší transparentnost práv pracovníků v systému workers comp," řekl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že se " dívá [s] dopředu, aby vrhla více světla na tuto zkušenost a pokračovala v práci, kterou miluji."
Kilcher také poděkoval Vasquez a její kolega Brown Rudnick právník Steve Cook za " jejich neochvějnou víru v mé nevině."
Podle TMZ, Kilcher najal dva v září.
Kilcher vypukl s Terrence Malickfilm z roku 2002" nový svět", kde ztvárnila Pocahontas.
Mezi její kredity patří také "Sons Of Anarchy", "The Alienist" a " Dora and The Lost City of Gold."
Naposledy se objevila v road-trip filmu "Pes", v hlavní roli Channing Tatum.
K této zprávě přispěla spisovatelka times Christina Martinez.
Šéf Balenciaga označil sváteční kampaň za hloupou chybu
Značka luxusního oblečení Balenciaga se stále vzpamatovává z odporu nad dvěma ze svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal do horka kvůli propagačním obrázkům, které podle kritiků sexualizovaly děti, umělecký ředitel Balenciaga Demna (celé jméno Demna Gvasalia) řekl, že je mu stále líto obrázků v rozhovoru pro Vogue zveřejněném v pátek.
"Chci se osobně omluvit za nesprávnou uměleckou volbu konceptu pro dárkovou kampaň s dětmi a beru na sebe svou odpovědnost," řekl Vogue a zopakoval předchozí prohlášení, které v prosinci zveřejnil na sociálních médiích.
V listopadu značka sdílela fotografie pro svou kolekci "The Gift", která obsahovala dětské modely pózující s plyšovými medvídky, které byly oblečeny v otroctví.
Krátce poté Balenciaga upustila od fotografií pro svou kampaň na jaře 2023, která obsahovala stránku z případu Nejvyššího soudu z roku 2008 zahrnující "virtuální dětskou pornografii" na pozadí.
Rodiče, včetně televizní hvězdy reality a dlouholetého fanouška Balenciaga - a partnera značky-Kim Kardashian, se na sociálních médiích vyslovili proti značce a jejím "znepokojivým obrazům".
O několik dní později vydal Balenciaga prohlášení, ve kterém se omlouval za fotografie a nastínil změny, které by provedl, aby se v budoucnu vyhnul podobným "chybám".
"Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s naším publikem, a ve způsobu, jakým se učíme ze svých chyb a postupujeme vpřed," řekl Demna Vogue.
Podrobně popsal změny postbacklash v Balenciaga:" restrukturalizace obrazového oddělení", provádění více Interních a externích kontrol snímků kampaní a partnerství s Národní dětskou aliancí na pomoc " tisícům dětí v procesu překonávání traumat a řešení jejich duševního zdraví."
"Je to jediná věc, která mě těší z celé této hrozné situace: udělat z toho něco dobrého," řekl o partnerství, které bylo oznámeno ve středu.
S NCA se také spojuje mateřská společnost Balenciaga Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod Keringovým deštníkem je Gucci, který v prosinci čelil odporu kvůli kampani představující Harryho Stylese, o které někteří kritici sociálních médií tvrdili, že také sexualizovali děti.
V rozhovoru Denma uvedla, že se plánuje odklonit od "provokativních" způsobů značky.
"Je to součást mého učení: budu mít zralejší a vážnější přístup ke všemu, co vydám jako nápad nebo obraz," řekl.
"Rozhodl jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciaga, která vyrábí kvalitní oblečení - ne dělat image nebo buzz."
Když už mluvíme o původu značky, jinde v rozhovoru Demna uvedl, že jednou z "nejbolestivějších" částí odporu bylo pošpinění "jména Balenciaga a odkazu Cristóbala Balenciagy."
"Balenciaga je dům, který je více než jedno století starý a je založen na silných a krásných tvůrčích hodnotách, a já jsem byl zaneprázdněn tím, že jsem dělal vše, co bylo v mé tvůrčí síle, abych ho přivedl k jeho modernímu významu, a najednou jsme byli pod útokem a označeni jako něco, čím vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s dárcovskou kampaní a určitě jsme se z ní poučili.""
Je to falešné zprávy, CBN Debunks tvrdí, že postrádá kapacitu pro tisk dalších nových poznámek Naira
Centrální banka Nigérie (CBN) popsala jako zavádějící zprávu, která tvrdila, že cituje guvernéra CBN, pana Godwina Emefieleho, jako přisuzující současnou výzvu v distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů v nigerijské bezpečnostní tiskárně a ražbě společnosti Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neučinil takové prohlášení během své prezentace Národní radě státu na jejím zasedání v pátek 10.února 2023.
Pan Nwasinobi uvedl, že Emefiele na schůzce pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot Nairy, aby uspokojila transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových poznámek Naira, " jsme znepokojeni tím, do jaké míry se partikulární zájmy pokoušejí manipulovat s fakty a postavit veřejnost proti bance."
Nwasinobi uvedl, že CBN je i nadále odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (ve znění pozdějších předpisů).
"Chceme také zopakovat, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované odrážky Naira.
"Banka si proto přeje apelovat na veřejnost, aby zmíněnou zprávu ignorovala a uplatňovala větší zdrženlivost, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na konkrétní hlasové poznámce trendující na sociálních médiích, která tvrdí, že CBN plánovala zavřít některé banky, zejména v konkrétní geopolitické oblasti země, CBN uvedla, že takový plán neexistuje a že tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje takové nahrávky ignorovat, protože nepředstavují politický tah CBN a jsou pouze zoufalými pokusy osob usilujících o podněcování veřejnosti proti bance," uvedl.
Tim Sherwood slzy do £ 44m podpisem Pedro Porro po neutěšeném debutu Tottenhamu
Porro měl odpoledne zapomenout proti Leicesteru (obrázek: Getty)
Tim Sherwood se při porážce Tottenhamu 4: 1 s Leicesterem City vtrhl do "naprosto nechutné" obrany Pedra Porra.
Spurs podepsal pravý bek od Sporting CP v den uzávěrky převodu na počáteční smlouvu o půjčce za 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
23-letý byl předán jeho debut Antonio Conte v sobotu na stadionu King Power Stadium s jeho stranou, která se ujala vedení po 14 minutách přes Rodrigo Bentancur.
Ale to se změnilo v mizerné odpoledne s Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni skórovali, aby dali Leicesteru 3-1 v poločase, kdy Porro vydržel v první polovině Premier League vášnivý první poločas.
Španělé byli opět na vině, když si Leicester myslel, že přidali čtvrtou přes Barnes a zatímco cíl byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood byl šokován obranným úsilím plného záda.
"Nechci si toho kluka dál vybírat, ale musí být zbaven svých povinností," řekl Sherwood Soccer Saturday.
Dám mu výhodu pochybnosti, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé straně.
Daniel Levy Tento týden říkal, že utratili spoustu peněz, Ano, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale to, na co se dívám, je hráč, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na obranu a tento hráč se v tuto chvíli snaží bránit. Je proti velmi dobrým hráčům v Barnes a Maddison, ale je to velmi zklamáním."
Zatímco gól byl vyloučen, Leicester obnovil vedení 4: 1 s Barnesem v cíli devět minut z plného času.
Přestože Tottenham minulý týden porazil Manchester City, promarnil šanci posunout se před Newcastle na třetí místo.
Více: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepsala Joao Felixe a místo toho se vrhla na hvězdu Tottenhamu
Více: Tottenham se uchází o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu
Další podobné příběhy najdete na naší sportovní stránce.
Sledujte Metro Sport a získejte nejnovější zprávy na Facebook, Twitter a Instagram.
Jack Smith by měl vyhrát jakýkoli výsadní Boj o předvolání Mikea Pence
Zpráva, že zvláštní poradce Jack Smith předvolal Mika Pence, vyvolává otázku: jak tým Trump použije soudy k tomu, aby zmařil tento nejnovější vývoj v sondě Ministerstva spravedlnosti?
Krátká odpověď je, že jakýkoli pokus o potopení předvolání Pence z důvodů výkonných privilegií by měl selhat.
Za prvé, je tu otázka, zda si bývalý prezident vůbec může nárokovat privilegium.
Připomeňme, že Trump se pokusil a nedokázal zablokovat dům Jan. 6 výbor od získání záznamů Bílého domu.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, s tím nesouhlasil pouze soudce Clarence Thomas (manžel popíračky voleb v roce 2020 Ginni Thomas).
Soud však ponechal otevřenou otázku, zda může bývalý prezident požadovat privilegium, přičemž soudce Brett Kavanaugh navrhl, že by takové tvrzení podpořil.
Takže je přinejmenším nejasné, zda si bývalý prezident může nárokovat privilegium a neříká nic o tom, zda by nárok uspěl.
Navíc odvolání Nejvyššího soudu nad snahou tehdejšího prezidenta Richarda Nixona vyhnout se dodržování předvolání ukazuje, že vágní tvrzení o privilegiích nebude stačit a může být překonáno konkrétní potřebou důkazů.
Soud pozoroval v roce 1974 Spojené státy v. Nixon:
... pokud je důvod pro uplatnění výsady, pokud jde o předvolané materiály určené k použití v trestním řízení, založen pouze na obecném zájmu o důvěrnost, nemůže zvítězit nad základními požadavky řádného soudního procesu ve spravedlivém výkonu trestního soudnictví.
Zobecněné tvrzení o privilegiu musí ustoupit prokázané specifické potřebě důkazů v probíhajícím trestním řízení.
Precedens je tedy na straně vlády.
Samozřejmě, nicméně, zpoždění od soudního sporu i prohraného problému může být pro Trumpa svým způsobem vítězstvím.
Dalším tlumením šancí na úspěšný nárok na privilegium je však předchozí odmítnutí Trumpova pokusu zablokovat Jana. 6 svědectví velké poroty.
Jak uvedl Washington Post v říjnu, toto odmítnutí poznamenalo, že bývalý pobočník Pence Marc Short, například, "pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti Jan. 6, 2021, útok na Capitol, který nebyl k dispozici z jiných zdrojů."
I tento Pence má zřejmě unikátní informace, které by ministerstvu spravedlnosti pomohly v jakémkoliv souboji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegium měl selhat.
Je to proto, že Pence se rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s Janem. 6.
Je těžké říci, že komunikace jsou privilegované, když jste je dříve považovali za vhodné k propagaci.
Takže zatímco předvolání může představovat různé politické a osobní výpočty pro Pence - který může soupeřit o nominaci republikánů v roce 2024 proti Trumpovi, někdo, kdo účinně toleroval výzvy k penceově mimosoudní popravě v lednu. 6-soudy by měly mít snadný čas na straně ministerstva spravedlnosti.
Případ proti Bidenovu běhu je zřejmý-a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové demokraté nemohou dělat mnoho ve způsobu schvalování zákonů s GOP pod kontrolou Sněmovny, stále mohou strávit další dva roky příkladem.
Kolektivně, každý v týmu by měl hledat příležitosti, jak hrát galantně na podivné Goofusovy impulsy republikánů.
Je však také důležité, aby Biden spálil svou důvěryhodnost u amerického lidu-a možná byl naléhavě potřebným agentem změn v naší příliš chatrné politické kultuře.
Washington, notoricky cynické místo, je proslulý svými zdravým rozumem ochromujícími představami o vedení.
Snad jedním z nejznámějších je zvláštní standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli jít do komických délek, aby se tomu vyhnuli.
Existuje další způsob: v Bailoutu, monografii Neila Barofského o jeho působení ve Washingtonu jako zvláštního generálního inspektora dohlížejícího na program pomoci problémovým aktivům, popsal rady, které dostal od Kristine Belisle, ženy, kterou chytře najal, aby byla jeho ředitelkou komunikace.
Bylo to asi tak anti-Washington, jak to může být: "přiznáme a dokonce zdůrazníme naše chyby."
Jak dále vysvětlovala, ve strategii je metoda, kterou by většina lidí uvnitř Beltway považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Občas se můžeme stydět a zveřejňovat věci, které bychom mohli - a ostatní by - snadno skrýt, ale šokujeme tisk svou upřímností.
Nikdo jiný to nedělá a zanedlouho budeme mít postavenou obranu, když nás napadnou.
Bez ohledu na to, co slyší, tisk k nám přijde jako první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč Biden pokračuje v radikálním přijímání odpovědnosti: v každém předsednictví nevyhnutelně nastanou okamžiky, kdy je kritická důvěra veřejnosti a institucí, které chrání občanský zájem.
Navíc je tu zásadní kapitál, který lze získat vlastnictvím našich chyb, a je tu důležitý rozdíl, který může Biden čerpat se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým pořekadlem: řekni pravdu-a hanba ďábla.
Některé reklamy na Super Bowl, které se nemůžu dočkat
Hvězda sitcomu z devadesátých let, která si zopakovala svou milovanou roli, aby vám prodala pojištění auta.
Reklama, která se stává kulturním fenoménem a okamžitě se rozsvítí zeleně jako televizní show, prodloužení dvanáctisekundové scény do deseti sezón.
Všechny celebrity z loňských krypto reklam se omlouvají za své krypto reklamy.
Ti" whassup " kluci, ale trochu je, že teď jsou staří.
Všichni jsou teď na whodunnits, že jo?
Takže nějaká série reklam režírovaných Rianem Johnsonem, kde když zjistíte, kdo udělal vraždu, dostanete slevu na roční pojištění auta.
Reklama, na kterou budou všichni super-online konzervativní kluci celý týden zuřit.
Timothée Chalamet v určité funkci.
Někdo, kdo byl údajně navždy zrušen, aby se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte, který budete určitě sledovat, až bude streamován za tři týdny.
Nesnesitelně chytlavá nová znělka, kterou si budete zpívat roky.
Recyklovaný vtip z Twitteru před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste bankovali s Wells Fargo.
"Zoom zoom" dítě, ale trochu je, že teď je dospělý.
Biden DOJ "nechce ozbrojené občany"
Rep. Andrew Clyde (R-GA) se ve čtvrtek sešel s Breitbart News a diskutoval o svých plánech zablokovat pravidlo ATF pistol brace a jeho přesvědčení, že Bidenovo Ministerstvo spravedlnosti "nechce ozbrojené občany".
Clyde dal jasně najevo svůj nesouhlas s pravidlem ortézy pistole.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější.
Obecně, vyjádřil své přesvědčení, že naši otcové zakladatelé nepředložili plán správy věcí veřejných, který zahrnoval federální agentury, které místo zákonodárného sboru vytvářejí zákony.
Řekl: "Ministerstvo spravedlnosti je tu proto, aby prosazovalo zákon, ne proto, aby zákon vytvářelo. Když máte výkonnou větev, která vytváří zákon a prosazuje zákon, pak máte krále a království. Naši zakladatelé nevolali po králi a nevytvořili království v Ústavě Spojených států."
Clyde poté přešel ke specifikům týkajícím se pravidla ortézy pistole a vyjádřil své znepokojení nad tím, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: "ATF chce zvýšit registrační databázi pro národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co přichází před konfiskací, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojeného občana."
Dodal: "ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby mohli jít po nás."
Clydeovo tvrzení je, že pravidlo ATF pistol brace se zrodilo v tomto prostředí nepřátelství vůči druhému dodatku A vůči soukromému vlastnictví zbraní a plánuje s ním bojovat zuby nehty.
Řekl, že má "tři nástroje", s nimiž může bojovat proti pravidlu.
Prvním z těchto nástrojů je krátký zákon a druhým zákon o kongresu.
30. Ledna Breitbart News citoval Clyda, který nastínil svůj plán " znovu zavést zákon o zastavení obtěžování majitelů pušek dnes, nebo krátký zákon, zrušit prvky zákona o národních střelných zbraních, čímž ATF zakazuje registraci a zákaz pistolí se stabilizačními rovnátky."
Poznamenal také, že " zavede usnesení o nesouhlasu podle zákona o přezkumu Kongresu, aby potlačil protiprávní překročení Bidenovy administrativy."
Oba akty, krátký zákon a zákon o přezkumu Kongresu, mají možnost zablokovat pravidlo ATF pistol ortéza.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, buď k přijetí legislativy krátkého zákona, nebo k dokončení řešení nesouhlasu podle zákona o kongresu.
Dal jasně najevo, že získání Bidenova podpisu není nemožné, protože existují způsoby; například, legislativa krátkého zákona by mohla být přidána k dalším, větší účty, které demokraté velmi touží projít.
Clyde však naznačil, že existuje také třetí způsob, jak zablokovat pravidlo ortézy pistole ATF.
Řekl: "jsem ve Výboru pro rozpočtové prostředky a můžeme zrušit toto pravidlo pistole, prostřednictvím takzvaného pozměňovacího návrhu. Toto pravidlo můžeme doslova zrušit a v zásadě říci: "při provádění nebo prosazování tohoto konkrétního pravidla ortézy pistole nelze utratit žádné peníze."
A totéž můžeme udělat také s pravidlem přijímače/rámce ATF z loňského srpna.
Myslím, že oba je třeba defundovat a těším se na spolupráci s našimi přivlastňovateli.
AWR Hawkins je oceněný druhý dodatek publicista pro Breitbart News a spisovatel/kurátor down Range s AWR Hawkins, týdenní zpravodaj zaměřený na všechny věci druhý dodatek, také pro Breitbart News.
Je politickým analytikem amerického rozhlasu a velvyslancem USA.
AWR Hawkins je držitelem doktorátu z vojenské historie se zaměřením na vietnamskou válku (hnědé vodní námořnictvo), americké námořnictvo Od počátku, občanskou válku a raně novověkou Evropu.
Sledujte ho na Instagram: @awr_hawkins.
Můžete se zaregistrovat a dostat se dolů na breitbart.com/downrange.
Oslovte ho přímo na awrhawkins@breitbart.com.
"Doufáme," Biden má plán na zpracování titulu 42 konec, "pokud ano, nesdíleli to úplně"
V pátečním vydání NBC "MTP Now" guvernér Colorada Jared Polis (D) uvedl, že má "velké obavy" z toho, co se stane, až v květnu skončí Hlava 42, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že "pokud ano, ještě to s námi plně nesdíleli."
A řekl, že " řekli jsme, že potřebujete plán. Chceme, aby to prověřili u nás."
Polis uvedl, že si přeje, aby během setkání guvernérů v Bílém domě bylo věnováno více času otázce imigrace, ale problém "přišel."
Měli jsme tam ministra starostu.
A tak, znovu jsme vychovali, je tu spousta obav, které sdílím o tom, co se stane, když hlava 42 končí v květnu, a tak, ujistit se, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě to s námi plně nesdíleli.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to prověřili u nás.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pětkrát nebo třikrát, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald 's Stahuje" nevkusnou " reklamu u krematoria - novinky. cz
McDonald ' s se omluvil poté, co byla reklama na hamburger "McCrispy" řetězce rychlého občerstvení umístěna poblíž krematoria ve Velké Británii-ačkoli někteří místní obyvatelé viděli vtipnou stránku.
Řetězec restaurací se zavázal odstranit urážlivé hromadění reklamy na základě stížností obyvatel Truro v britském hrabství Cornwall.
V pátek si na sociálních sítích získala pozornost za to, že byla umístěna na rušné silnici přímo naproti podniku, který nabízí kremační služby.
Jasně osvětlenou reklamu, která byla umístěna přímo za cedulí ukazující na krematorium, označili někteří naštvaní místní za "nevkusnou".
"I když vidím tu vtipnou stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou rádi vidět, když navštíví Penmount na pohřeb a kremaci milovaného člověka," řekla obyvatelka, jejíž tchyně byla v loňském roce zpopelněna v pohřebním ústavu, jak citovala Britská média.
Nicméně, ne každý byl tak uražen nešťastným umístěním reklamy, s tím, že reakce člověka na ni bude pravděpodobně ovlivněna "jak dávno jste sledovali značku krematoria v černé kravatě."
Jedna osoba řekla, že" spadla ze židle se smíchem", když spatřila reklamu online, zatímco jiný místní také poznamenal, že to nebylo" o nic horší "než rozhodnutí Rady pobavit myšlenku umožnit vybudování krematoria" vedle vesnice pro odchod do důchodu."
Prohlášení vydané společností McDonald ' s bylo zveřejněno místními médii v pátek brzy poté, co se obrázek reklamy stal virálním online, ve kterém řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
"Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. S ohledem na obavy vznesené společností CornwallLive jsme však požádali o odstranění naší reklamy," uvedla značka rychlého občerstvení.
Cornwallská rada, která provozuje krematorium i Autobusový přístřešek, který zobrazuje reklamu, odmítl komentář k rozruchu, když byl kontaktován místními médii.
"Gut instinct" chybějící žena není v řece
Hledání pohřešované Angličanky Nicoly Bulleyové vstoupilo do 16. dne poté, co její partner řekl, že jeho "instinkt střeva" je, že není v řece.
Lancashirská Policie uvedla, že policisté udržují "otevřenou mysl" a nadále žádají o informace o paní Bulleyové, který zmizel 27 leden při venčení svého psa v St Michael ' s on Wyre.
Síla pokračuje v prohledávání řeky Wyre směrem k moři v zátoce Morecambe a pracuje na jedné hypotéze, že 45letý muž z Inskipu mohl spadnout.
Při jejich hledání pomáhali specialisté a potápěči z pobřežní stráže HM, horská záchrana, a Lancashire Fire and Rescue Service, s nasazenými čichacími psy, drony, a policejní vrtulníky.
Paní Bulleyová zmizela při procházce vrbou springer spaniel poblíž řeky, krátce poté, co upustila své dcery, ve věku šesti a devíti let, ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner, Paul Ansell řekl, že chce mít " všechny možnosti otevřené "o jejím zmizení, ale jeho" instinkt střeva " mu říká, že není v řece.
Popsal paní Bulley jako " zábavu," "milující," "nejvěrnější přítel, jaký jste kdy mohli mít" a "výjimečná maminka", která " absolutně zbožňuje naše dívky."
"Je to jen pilíř síly pro naši rodinu a bez ní je díra větší, než si dokážete představit," řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází "bezprecedentním peklem," naděje, že se jeho partner najde, je "silnější než kdy jindy."
Policie případ odložila a případ vyšetřuje jako pohřešovanou osobu.
Ve čtvrtek, zaměření jejich hledání se změnilo ze St Michael ' s na asi 10 mil po proudu, kde se řeka vlévá do moře v zátoce Morecambe, s hlídkovými a záchrannými čluny spatřenými v této oblasti.
Poslední komunistický vůdce východního Německa zemřel v 95 letech
Hans Modrow, který působil jako poslední komunistický vůdce Východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95 let.
Modrow zemřel brzy v sobotu, parlamentní skupina levicové strany tweetovala.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nemohl zpomalit hybnou sílu pro znovusjednocení Německa.
"Celý mírový průběh nastolení německé jednoty byl právě jeho zvláštním úspěchem," napsala levice na Twitteru."To zůstane jeho politickým dědictvím."
Během 16 let jako šéf Komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst anti-establishmentu.
Odmítl stranické výhody a trval na bydlení v normálním bytě.
Post ve vrcholném vedení Východního Německa mu unikal, dokud nebyl jmenován premiérem, což byla pozice, která dříve měla malý vliv, v listopadu 1989 - dny po pádu Berlínské zdi.
Když na začátku prosince rezignoval šéf tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou osobností Východního Německa.
Komunisté už ale nemohli volat sami.
Následující měsíc souhlasil se sdílením moci se stále hlasitější opozicí a posunul se do východoněmeckých mezníků první svobodné volby do března 1990, uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle získala prounifikační příchuť, komunisté se zpočátku stavěli proti rozhovorům o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se Západním Německem o eventuální "sjednocené vlasti", která by byla nezávislá na vojenských blocích a řízena společným parlamentem v Berlíně.
Modrow vedl volební kampaň restylovaných komunistů, strany demokratického socialismu, ale jeho osobní Popularita nestačila na to, aby jim zabránila skončit jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a podpořila ji vláda západoněmeckého vůdce Helmuta Kohla.
Německo se znovu spojilo pod Kohlovým vedením a jako člen NATO v říjnu. 3, 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS-předchůdce dnešní opoziční levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho přistála před soudem několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků v květnu 1989 v místních volbách v Drážďanech.
Udělil mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že soud byl politicky motivovaný, a tvrdil, že jeho výsledek zhorší rozdíly mezi východními a západními Němci.
Jeho advokát tvrdil, že předchozí nespravedlnosti napravil tím, že dohlížel na svobodné volby jako předseda vlády.
Později v životě sloužil Modrow v radě starších levé strany.
"Hans byl hluboce upřímný a bojovný Socialista," tweetoval Dietmar Bartsch, předseda parlamentní skupiny levé strany.
"Až do stáří byl důležitým poradcem naší strany, jejíž moudrost bude chybět."
Indická vláda po kritice stáhla výzvu k objetí krav na Valentýna
Objímání krávy na Valentýna již indická vláda nepodporuje-navzdory tomu, že dříve žádala lidi, aby tak učinili, aby propagovali hinduistické hodnoty.
Rada pro dobré životní podmínky zvířat v Indii (AWBI) odvolala svou výzvu "den objetí krav" poté, co vyvolala kritiku politických soupeřů a uživatelů sociálních médií.
Indické vládní oddělení vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k objetí krav byla " naprosto šílená, vzdorující logice."
Dodal, že rozhodnutí stáhnout odvolání bylo spíše "zabránit tomu, aby politika Hindutvy [hinduistického nacionalismu] byla zesměšňována tváří v tvář tvrdé kritice ze všech stran."
AWBI se v pátek vzdala svého odvolání a uvedla, že " stojí staženo."
Bylo to jen ve středu, kdy jeho prohlášení znělo, že "objímání krav [by] přineslo emocionální bohatství a zvýšilo individuální a kolektivní štěstí."
Více o Indii
Dodal, že kráva je " páteří indické kultury a venkovské ekonomiky... pro svou výživnou povahu jako [a] matka."
Na počáteční oznámení byly smíšené reakce, protože některá zveřejněná videa krav odmítajících objímání a nabíjení.
Jiní chtěli objasnit, že výzva byla spíše pro následování vlastní kultury, na rozdíl od "slepého" následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněním parků a restaurací, výměnou dárků a pořádáním večírků.
Mazlení krav také není nic nového-v některých částech světa je považováno za terapeutické, a v Nizozemsku, kde je známý jako "koe knuffelen."
Zbožní hinduisté uctívají krávu-známou jako gau mata nebo "matka kráva" - a většina států v Indii zakázala porážku krav.
V posledních letech, někteří Hinduističtí zastánci tvrdé linie přepadli obchody prodávající Valentýnské předměty, spálil karty a dárky, a pronásledoval páry držící ruku z restaurací a parků, trvá na tom, že den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Narendry Modiho tvrdí, že jeho vláda prosadila hinduistickou agendu a usilovala o nadvládu náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, většinu zbytku tvoří muslimové, křesťané, Sikhové, buddhisté a džinisté.
Chodec zemřel v nemocnici po nehodě s autem v Cowdenbeath, když byl zatčen muž
Chodec zemřel po srážce s autem ve Fife.
38letá žena byla převezena do nemocnice Victoria v Kirkcaldy po havárii na Broad Street v Cowdenbeath v pátek kolem 1.30 hodin.
V souvislosti s nehodou byl následně zadržen 24letý muž.
Policie žádá případné svědky nebo kohokoli se záznamem z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: "naše vyšetřování probíhají a žádáme každého, kdo byl v této oblasti a kdo byl svědkem havárie, aby se ozval."."
Také bych apeloval na každého, kdo řídil v této oblasti a kdo může mít záběry z palubní kamery, které by mohly pomoci našemu vyšetřování, aby nás kontaktoval.
"Každý, kdo může pomoci, je požádán, aby zavolal Police Scotland na číslo 101 a citoval číslo incidentu 1638 z pátku 10.února 2023."
V číslech: městské části Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla emigrovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, se zvýší na více než třetinu.
V Oslu tvořili občané z Asie, včetně Turecka, největší skupinu přistěhovalců, přičemž ve městě žilo více než 62 985 těchto státních příslušníků, podle údajů Národní datové agentury Statistics Norway (SSB).
Poté tvořili druhou největší skupinu občané z EU, EHP a Velké Británie, kteří tvořili necelých 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, přičemž v Oslu žilo 28 020 lidí z Afriky.
Čtvrtou největší skupinou byli Evropané ze zemí, které nejsou součástí Velké Británie, EU nebo EHP, což představuje 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen plachých 7 000 občanů z jihoamerických zemí, zatímco ze severní a střední Ameriky pocházelo přes 3 000 státních příslušníků.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrť s největším počtem zahraničních obyvatel.
V roce 2022 zde žilo asi 18 257 zahraničních obyvatel.
Poté měla trendy Grünerløkka, umístěná přiměřeně centrálně,druhý nejvyšší počet zahraničních obyvatel, s 17 631.
Gamle Oslo mělo také významnou populaci přistěhovalců, kde po přestěhování z jiné země žilo 17 631 lidí.
Statistiky norské údaje ukázaly, že cizinci byli rozptýleni po městských částech, protože Søndre Nordstrand, čtvrť nejvzdálenější na jih v Oslu, tam registrovalo přes 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo ve vyhledávaných oblastech, protože Frogner byl okresem s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra jen 184 zahraničních obyvatel volalo Marka domů a něco přes 700 žilo v centrální čtvrti města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní městské části s nejmenším počtem zahraničních obyvatel.
V těchto čtvrtích však žilo podstatně více přistěhovalců než v centru Osla a Marka.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili v Frogner, Grünerløkka, Gamle Oslo a St.Hanshaugen.
Mezitím, zatímco spousta občanů z Asie, včetně Turecka, také pobývala v Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu s Stovner, Grünerløkka a Søndre Norstrand.
Ty ze Severní Ameriky byly rozloženy poměrně rovnoměrně přes Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z jižní a střední Ameriky se nejčastěji vyskytovali v Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království měli tendenci žít v nejcentrálnější městské části města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek státních příslušníků z Oceánie, Frogner, Grünerløkka a Gamle Oslo byly městské části s nejvyšší populací těchto státních příslušníků.
Zimbabwe začne do března provozovat novou uhelnou elektrárnu
Florence Tan
BENGALURU (Reuters) - Zimbabwe začne provozovat novou jednotku ve své jediné uhelné elektrárně do března, říká náměstek ministra energetiky v zemi a poskytuje úlevu milionům občanů, kteří se v posledních měsících otřásli častými výpadky proudu.
Nový blok elektrárny Hwange zvýší instalovaný výkon africké země o více než 14% na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časovou osu.
Méně než polovina z 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální tlak na financování nových uhelných kapacit omezil schopnost země zapojit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době generujeme mnohem méně..asi 1000 MW, " řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit," řekla.
Nedostatečné srážky vedly k poklesu výroby vodní energie, zatímco účinnost jediného, desetiletí stará uhelná utilita v průběhu času prudce poklesla, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících růstové vyhlídky Zimbabwe.
Nedostatek finančních prostředků na energii z uhlí vede ekonomiku závislou na těžbě a zemědělství k dovozu nákladné energie od regionálních sousedů, včetně Zambie a Mosambiku.
(Scénář: Sudarshan Varadhan; editace: Jacqueline Wong)
(PERSON11) ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně –
V podstatě, velký obchod, nebo něco není v pořádku.
Takže některé soubory jsou stále-stále mají divný výstup.
Ale-ale pro většinu složek by to mělo být již v pořádku.
(PERSON1) dobře, díky.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé ,že, [PERSON7], mysleli jste na [PERSON11].
A [PERSON11] nyní má čas.
Jsou i jiné věci, na které jsem myslel [PERSON11] a to by bylo školení prázdných systémů, aby se zkrátily.
Takže, pokud jste, [PERSON11], měl čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat pro příští týden.
Ale opravdu bychom měli mít systém připravený na –
Podíval jsem se na tutoriál z NLP-bylo to?
(PERSON6) pro nadcházející zasedání a zeptal jsem se na poptávku, protože jsem viděl (meme) demo projektu.
Dělají offline titulky.
Takže je to o něco jednodušší než to, co děláme.
Stále mají stejné problémy se segmentací a tak dále.
Jejich posláním v překladu je však zkracování jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech je jako přirozené zkrácení.
Bylo by skvělé, kdybychom mohli také najít takový typ dat, kde dochází k určitému přirozenému zkrácení.
Dali bychom to do architektury.
(OSOBA8) to trvá trochu času, protože musím zjistit, který z nich je ten, který dostává průchody.
Tak, jakmile to vím, mohu to sledovat, tak, pro budoucnost –
Nebo vlastně, pro budoucnost bych to nepotřeboval, protože jakmile mám webový soubor, pravděpodobně nebudu muset konvertovat.
(PERSON6) No, tohle, tohle by mělo být –
Pořád mě slyšíš?
Kvalita zvuku je o něco horší.
Takže by to mělo být opravdu provedeno, po celou dobu.
Takže pokaždé, když spustíme toto hodnocení, mělo by být spuštěno od nuly.
Takže pokaždé by mělo dojít k čerstvému stažení čerstvé konverze a novému vyhodnocení.
(PERSON8) ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript a mohl by se postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, vidím to později.
(OSOBA6) takže je to důležitá věc, se kterou jsme se měli setkat před měsíci.
Pamatujte, že od srpna vám říkám, že to chceme vyhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Není to jen vy osobně, [PERSON8].
Samozřejmě byly i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si: "to bude snadné, prostě to spustíme".
A teprve když to skutečně uděláte, uvidíte všechny problémy.
Takže je to známé, běžné.
Vždycky je to tak.
Takže to je Vzkaz pro všechny.
Než to zkusíte, nikdy nevíte, jaký bude problém.
Takže například hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, tak chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Takže než to uděláte, nemůžete říci, zda to bude fungovat nebo ne.
A tady narážíme na problémy převodu formátů souborů.
Doufejme tedy, že se nám podaří rychle získat čísla.
Máte tedy zatím nějaké chybovosti slov?
(OSOBA8) ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jednou dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně hluku.
Takže jsem požádal, abyste měli různé verze tohoto slovníku tím, že vezmete pouze slova, která byla pozorována, pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo více, nebo něco takového.
Tak, tímto způsobem, tyto náhodné chyby, jako je příklad s tímto čtyřem IBM namísto IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba řekne toto "alzo", pokud si pamatujete, pokud řekne toto "alzo" s "Z" 20krát v rozhovoru, pak to uvidíte v datech s "Z".
A pokud se mu někdy podaří říci také správně, pak ano, znovu to uvidíte v datech.
Tak, chtěl bych, [PERSON4] být v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, že?
Teď budu muset odejít, protože musím dát dětem oběd a tak dále.
Ale prosím, zůstaňte v tomto hovoru a společně zjistěte, jak tento slovník používat.
Takže [PERSON4], prosím ukažte [PERSON2] jaký je slovník, který systém přijímá.
Sdílejte obrazovku a zobrazte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste vyslali do tohoto souboru.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři col ns.
Grafém, jak je výstup.
Jeden uznán.
Fonémy, jak [PERSON2] navrhl.
A bude více řádků s různými variacemi fonémů.
A třetí col n bude opět stejný pro všechny z nich a opět bude stejný grafémový tvar.
Takže to je, když jazykový model vidí.
A myslím, že tímto způsobem by tyto systémy měly být schopny jej načíst.
A také možná narazíte na ještě jeden problém: že není připraven na dva velké vlastní slovníky.
Tak, to je také něco, co musí být testováno, ale prosím otestujte to, vy dva společně.
Takže [PERSON2] ví, co vytvořil ve slovníku.
A víte, jak slovník vypadá, když jej vytváříte ručně, a musíte tyto dvě znalosti dát dohromady.
Ah, aby to fungovalo s, s generovaným slovníkem.
(PERSON4) dobře.
(PERSON6) takže [PERSON2], má to smysl?
(PERSON2) jo, jasně, probereme to.
(PERSON6) Jo, je tu ještě něco, [PERSON2], že máte?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časové razítko.
Nejsem si jistý, jak to bude dobré, protože se to snažím dělat na (Libry) řeči.
A když jsem to stahoval, tvrdili, že to má více než 600 hodin.
Ale pak trénink řekl, že skutečná tréninková sada obsahovala jen asi 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými řečníky.
Například v angličtině nebo Češtině jsem pozoroval strmější konverze.
A teď to nebude konvertovat tak rychle.
Pokud tedy během tréninku odebereme nějaké vzorky.
Pak jsou ve výstupu ASR stále některé závažné chyby.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo to aspoň zkusíme.
(PERSON17) dobře, to je dobře, jo.
Tak, začal jsem, ale myslím, že jsem vám nikdy nedokončil e-mail, protože jsi mi připomněl, [PERSON8], že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že je to také důležitá zpráva pro [PERSON5], který z hovoru znovu zmizel.
Důležité je tedy, že ano, je velmi dobré, že aktivně tlačíte, aby byly vaše výsledky integrovány, a každý by to měl dělat.
A zároveň musíme mít nastavení, abyste jej mohli skutečně integrovat a otestovat sami.
Takže tomu říkám "integrace do-it-yourself".
Tak, [PERSON8], při práci s [PERSON5] a při dokumentování toho, co jsou nastavení, ujistěte se, že je testován dostatečně dobře kolegy, například [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykového modelu a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou součást, měl by mu být celý plynovod přiměřeně snadno přístupný, aby si ho mohl sám vyzkoušet.
Takže tato integrace do-it-yourself je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a nechcete být přetíženi.
Chcete tedy těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že?
Filtrování vulgárních výrazů, bylo testováno na protokolech?
Myslím, že byla.
(PERSON8) Jo, to bylo testováno na protokolech, myslím.
Takže teď je čas vyzkoušet to na živých potrubích.
A znovu si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, takže [PERSON4] to spustí pro sebe některé z pracovníků a živě hraje nějaký problematický soubor, jako je použití [PROJECT8] nebo cokoli jiného.
Jednoduše je zahrajte.
Sledujte zvukový výstup na vašem počítači a uvidíte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité jej nejprve ladit pomocí souborů protokolu a poté je důležité jej Ladit v potrubí.
A pokud toto ladění může provést autor této komponenty, zde, v tomto případě [PERSON4], bylo by to nejúčinnější pro nás všechny.
Tak, [PERSON8], potvrďte, že souhlasíte s touto myšlenkou integrace jako do-it-yourself.
(PERSON17) Jo, takže pro angličtinu s více přízvuky.
Nyní to tedy [PERSON14] spojujeme pouze s jedním technickým řešením.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a udělá to napříč různými řečníky.
Budou to tedy opravdu vícepřehlas věty, a proto by se také mohla zlepšit robustnost různých akcentů těchto reproduktorů.
To je jeden částicový experiment.
A později, můžeme udělat něco víc o multi-přízvuk věc.
Tyto nové věty se tedy ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět největší možnou sadu vět.
A budeme vytvářet nové věty z jazykového modelu pouze pro text přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost pro různé reproduktory bude také lepší.
A včera v rozhovoru jsem slyšel další nápad.
Bylo to během tréninku.
Ze zvuku vypadávali časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech, což také výrazně zlepšilo robustnost systému.
(PERSON17) kdokoli jiný může pracovat na věci s nepůvodním přízvukem.
Ok, pak další věc, kterou jsem si všiml, je - to je v pondělním testovacím dokumentu.
Je zvýrazněn čtyřikrát.
Když tedy probíhá nějaká relace, potřebujeme jména a terminologii pro tuto relaci.
A musíme to sbírat, připravit ručně, trochu to vytvořit.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Takže v tom je určitá dovednost b, které je třeba praktikovat.
Takže jsem docela zručný v míchání textových souborů.
A kdykoli vidím někoho z vás, jak to dělá, pak mám rád vždy v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo by za to byl zodpovědný.
A obávám se, že jediná osoba pro to by mohla být [PERSON8].
Pokud najdete někoho jiného, kdo by byl připraven pomoci s okamžitou adaptací domény, data křupání, prosím, řekněte to.
A pak potřebujeme -
Jakmile tedy zajistíme Slovník pojmů a bez ohledu na výslovnosti slov, potřebujeme techniky, jak tyto slovníky použít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě dělal pro všechny relace, byl, že to v hybridním ASR nebylo opravdu vidět.
Jedno takové zasedání se tedy opět uskuteční toto pondělí.
[PERSON9] již začíná sběr dat, ale rád bych viděl výhodu této adaptace domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak provádět adaptaci domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Pokud se vy tři můžete setkat a zkontrolovat, co je [PROJECT5] dělá s -
Není to [PROJECT5], ve skutečnosti je adaptace domény pro [PERSON18] toolkit, že jo.
Takže je to trochu zpětně vypadající, ujistěte se, že starý přístup funguje.
V tuto chvíli je naprosto nemožné provést jakoukoli doménovou adaptaci pro plně neurální ASR.
Takže to, co zvažuji, je mít nezávislé vyhledávání klíčových slov ze zvuku a nějaký postup slučování.
Takže bychom mohli mít dva Asr spuštěné současně.
End-to-end ASR, což je obecně lepší.
A pak Nastavení [PROJECT5] přizpůsobené doméně,které se používá pouze k vyhledání klíčových slov.
A když vidíme Klíčové slovo ve verzi přizpůsobené doméně, pak bychom použili větu z [PROJECT5], která je obecně horší, ale obsahuje správné výrazy.
To je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neurální ASR a provádět různé experimenty na finetuningu a tak dále.
Tak, diskutovali jsme o tom s [PERSON14].
A, [PERSON14], existuje nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je někdo jiný, kdo by byl zvědavý na to, dejte mi prosím vědět nebo se spojte.
Takže je to něco, co by bylo obecně dobře přijato jako papír, protože to lidé ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže bychom tam opravdu mohli mít dopad.
(PERSON6) jo, možná jsem jen přemýšlel o tom, jaké druhy dat k tomu aktuálně používáme, protože například, jako když zkontrolujete modely [ORGANIZATION4] na [ORGANIZATION5], že jsou v těchto věcech už docela dobré -
(OSOBA6) a myslím, že pokud se nám to líbí -
Pravděpodobně bychom z nich mohli jen získat data, protože máte jako tak velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčích [ORGANIZATION5].
A měl jsem nápad, že bychom mohli použít nějaký nástroj ke stažení v podstatě některých druhů filtrovaných videí z [ORGANIZATION5] a učinit z nich tréninkové testy tréninkem.
Takže to plánuji udělat sám.
Mám v plánu jít tam, ale potřebujeme záložní osobu.
A také pro událost [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže osoba archivátora, abychom tu relaci znovu neztratili.
A tím důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A navrhl jsem zde v odstavci pro [PERSON2], že bychom mohli použít jednoduché tabulky html, které by byly autogenerovány a které by rostly.
Myslím, že to by bylo asi nejjednodušší jen umístit tabulky jako html, ale to by mohlo být obtížné, když chceme vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Může být obtížné připravit tyto tabulky.
Tak, zeptal jsem se [PERSON7] a [PERSON7] bohužel nebude k dispozici během tohoto hovoru.
Řekněte nám, zda [ORGANIZATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANIZATION242] nedoporučuje [PERSON7].
Takže jednoduchý html je pravděpodobně způsob, jak jít.
Tak, jakmile [PERSON2] má tato hodnocení m vyčištěna.
To znamená přesunout několik skriptů tam, kam patří [PROJECT3] testovací sada a nějaký automatický běžec.
Pak také vytvořte konverzi z tabulek do html podobnou technické konverzi a poté tyto výsledky pravidelně vkládejte na svou webovou stránku.
Nebo to, co byste dokonce mohli udělat, je mít úplnou kontrolu git přímo umístěnou v tomto veřejném html nebo singling z tohoto veřejného html.
Aby byl okamžitě přístupný přes web, a kdokoli se mohl podívat na aktuální skóre a prozkoumat to.
Tak, to by bylo užitečné, zejména pro M lidí mimo [ORGANISATION2] jako, [ORGANISATION15].
Víme, že mají rádi -
Výkon byl špatný pro některé soubory a mohli je přímo procházet na webu m.
Mohli by to také skutečně procházet na [ORGANISATION101].
Je jen na vás, abyste jej nastavili tak, aby byl uživatelsky přívětivý a snadno sledovatelný.
(PERSON2) dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na, nebo se chystám aktualizovat, předložení demo papíru, který je splatný příští pátek, pokud se nemýlím.
A pak mám nějaké projektové zprávy a začínám shromažďovat dokumenty-jako, nebo odkazy na dokumenty, zatím ne samotné dokumenty, pro obě zasedání.
(PERSON11) < parallel_talk> také pro ASR bychom měli přidat bezplatnou metriku -
Vlastně více, Měli bychom přidat doplňkové met-tyto doplňkové metriky. < / parallel_talk>
Takže jste zmínil jeden a to je filtrování vulgárních výrazů M hodnocení.
Takže <parallel_talk> mít explicitní seznam věcí, které se nesmí objevit ve výstupu < / parallel_talk>, že?
< parallel_talk> a pak hodnocení vzácných slov.
A tady máme explicitní seznam jmen a termínů, které se chceme objevit ve výstupu, skóroval nejen (pořadí) rychlostí < / parallel_talk> , ale skóroval něčím, co přímo odpovídá těmto věcem, že?
Ano, Takže naprosto souhlasím.
To zahrnuje také ruční přípravu odkazu.
Takže <parallel_talk > oba potřebují ručně vytvořené odkazy. < / parallel_talk>
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit. < / parallel_talk>
Tak, to by se mohlo stát prázdnou součástí druhé věci vzácného slova -
Takže <parallel_talk> toto by bylo vzácné hodnocení slov pro MT a pak z [PROJEC210] pravděpodobně také dostaneme nějaký slovník. < / parallel_talk>
Takže to by byla doména [PROJEC210] samozřejmě.
A [PERSON2], mohl bych vás požádat, abyste revidovali <nesrozumitelnou/> doménu a vytvořili takový slovník tím, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže jako užší seznam-seznam slov, která se nám líbí, a nemáme rádi v <nesrozumitelné/> doméně.
Mohl bys to udělat?
(PERSON11) mělo by to být proveditelné, tak to zkusme.
Bylo by to jako-bylo by skvělé, kdyby se vám to podařilo.
Tak to napíšu.
Takže <parallel_talk> směřující k [ORGANIZATION62] termínu se studijním papírem subtitler. < / parallel_talk>
Ano < parallel_talk> a pak multi-source s [PERSON7] nebo na základě [PERSON7] nebo - < / parallel_talk>
A pokud jde o ID jazyka, jsem zvědavý, jak jej chcete integrovat přesně proto, že již zahrnuje zvážení více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) bude to audio na textového pracovníka a bude vydávat časová razítka jako pro čtyři nebo dvě druhé okno a třídu.
< nesrozumitelné/> ticho, česky, německy, anglicky, a pak nechám na ostatních, jak to chtějí použít v potrubí.
(OSOBA11) to je důležité.
Prosím, napište to sem do documenter toto < nesrozumitelné/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte [PERSON10], dobře a také možná [PERSON5].
Pokud máme tento nástroj, musíme (odeslat) zvuk více ASR nebo více pracovníků <nesrozumitelné / >
Budeme samostatně potřebovat (odeslat) zvuk do anglického ASR, odděleně do německého ASR a českého ASR, například v závislosti na <other_noise / >
A také do tohoto jazyka ID worker a pak musíme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je multi-source nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a bude vydávat - pravděpodobně by chtěl vytvořit výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Takže potřebujeme filtr pro Asr, takže ASR mlčí, pokud je to špatný jazyk, a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem to vymyslel tento typ nastavení.
Dalším nastavením by bylo, že stejný zvuk je dodáván do ASR a této kontroly jazyka.
Tato kontrola jazyka je v podstatě součástí ASR a umlčí ASR, pokud se jedná o nesprávný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Takže, prosím, přemýšlejte o tom, jaké jsou naše potrubí.
V ideálním případě si myslím, že nejméně podobný zmatek v řízení a tak dále by nastal, kdyby naše modely MT byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná děláme jen kopii, pokud byla jako vstup uvedena angličtina, takže bychom na začátku měli vícejazyčné více Asr.
Vše půjde do angličtiny, a pak z angličtiny půjde do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, toto ID jazyka nebude ani potřeba.
(OSOBA3) jde o to, že pokud provedeme analýzu správněji, jedna věc je možné kontradiktorní hodnocení, jen abychom naznačili, že omezení mají ve skutečnosti dopad na skutečný výstup.
Že by to bylo hezké a jo možná analýza pozornosti.
Ale nejsem si jistý, že by nám to mohlo dát stejné odpovědi, v podstatě, pokud se model účastní nebo se nevěnuje omezení.
(PERSON4) musel jsem se podívat jen na několik příkladů pozornosti, nedělal jsem žádné statistiky ani nic, a dívá se na omezení, a když překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti v tomto smyslu žádné nedělá.
Dělá některé obecné chyby překladu, ale ne (jevy), které se snažíme vyřešit.
Vrátíme-li se k automatickému vyhodnocení, problém s nesouladem spočívá v tom, že výstup je správně skloňován, ale kontext je jiný.
Není to tedy stejná slovní forma jako v odkazu, že?
(PERSON4) jo, ale také jsem zkontroloval, zda jsou kontexty platné překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly označeny jako chyba automatickým vyhodnocením, bylo 91 z nich správně skloňováno ve správných kontextech.
(PERSON4) a myslím, že pouze dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako by překlad byl špatný.
A pak jsou některé případy, kdy byl překlad úplně špatný, protože věta byla opravdu špatná a část musí být <nesrozumitelná/>, ale to bylo jako jeden nebo dva případy.
(PERSON3) ale snažíte se odpovídat formulářům přesměrování, když je hodnotíte,že?
Neděláte žádné-
(PERSON3) - lemmatizace odkazu a-
(PERSON4) oba, oba, oba, odpovídám povrchovým formám i lemmatu.
(PERSON3) Ach vidím, ach jo, to jsou dvě skóre, že?
(PERSON4)je to jen dilema skóre pro (evropské?) není v tabulce, protože tabulka se nevejde do papíru tak < nesrozumitelné / >
Pokrytí je vždy jako 97 procent.
Vytváří jen správná lemmata, jen-
(PERSON3) Ach jo, dobře, chápu to, chápu to.
Takže v podstatě pokrytí lemmatem říká, zda existuje omezení, a rozdíl povrchového pokrytí naznačuje, že by to mohlo být nesprávně skloňováno, ale není tomu tak.
(PERSON3) Ach jo, jen nevím, jestli vy, pokud chytíte <nesrozumitelné/>, když jsme mluvili o [PERSON1],
ale jedna věc je, že (rána) je lepší, ale druhá věc je, že lemmata jsou skutečně správně skloňována ručně,
ale to je to další, ne, žádný problém, je to vlastně dobré, že je <nesrozumitelné/> správně, jo.
Tak jsem si říkal,že by to mohlo být.
Ale nejsem si jistý, zda na to máme nějaká testovací data, ale mohli bychom se pokusit pohrát si s modely s nějakým přenosem stylu?
Jak víte, můžeme použít omezení a místo toho zkusit použít synonymní omezení a vidět nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to jen nejasně popisoval, protože sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakém stylu přenosu dat pro anglickou češtinu? Máme něco?
(PERSON4) <nesrozumitelné / >
(PERSON1) stylovým převodem, dušane, myslíš, že by bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, byl by v mluveném jazyce nebo něco takového?
(PERSON3) no, to je věc jako, mám jen omezené znalosti o úkolu.
Ale dokážu si představit, že chcete přepsat větu, že to není napsáno mužem, ale místo toho je napsáno ženou nebo, nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem tak obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenka je, že styl vět je docela nejasně definován.
Takže znovu, ne tak jistý.
(PERSON1) máme tento korpus transformací vět.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například, aby byly věty obecnější.
Podrobnosti jsou tedy vynechány, věta je zjednodušena a poté věta zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení Matous dělá nějaký experiment s anglicko-češtinou, ale nemáme tam žádné referenční údaje.
Takže nemáme žádnou datovou sadu pro kompresi vět.
Takže možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediná referenční by byla příliš omezená na to, aby vám řekla něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných genderových proměn, například by se to dalo udělat <nesrozumitelné/> pro češtinu, takže možná tou pravou osobou by byl Rudolf Rosa, který by se ho zeptal, jestli někdy vytvořil nějaký takový datový soubor.
Takže bude existovat kořenová generace nějakého protějšku věty.
(PERSON3) myslím, že je to vlastně jako zajímavá otázka, zda můžeme použít omezení k prosazení tohoto druhu podobného pohlaví mluvčího v překladu.
(OSOBA1) to je vlastně velmi dobrý nápad.
Mohli bychom se tedy zaměřit na to a vytvořit konkrétní dílčí část testovací sady [PROJECT1], která by to pokryla.
Ah, takže někdy známe pohlaví mluvčího, takže pokud jste...  možná budu sdílet obrazovku a procházet to.
(PERSON8) nebo jsem to zkusil s Marianem, který se toho jen zúčastnil a je to... Nevím, o kolik BLEU bodů níže.
(OSOBA2) protože tak, jak si myslím, že Martin dělá svůj <nesrozumitelný/> malý překlad, tak překládá více vět najednou a pak vybere jen středovou a jde takto pro celý dokument.
Kontext je tedy jako v jedné < nesrozumitelné/> spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nedělal Dominik nějaké experimenty s Ivanou?
Myslím, že minulý rok nebo před dvěma lety pro double empty, kde se účastnili kontextu nebo zřetězili kontext se vstupní větou a dělali nějaký překlad na úrovni dokumentu.
Ale věc je s tím, že zřetězení není zcela jisté, zda má stejný účinek jako my multi encoder nastavení-
(PERSON1) jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale je to překvapuje mě, že [PERSON8] říká, že to nefunguje tečka.
(OSOBA8) Jo, dobře, Tak Promiň, možná bych měl být správnější, že to nefungovalo tak, jak jsem to udělal <smích / >
(PERSON1) jo, protože si myslím, že je to metoda, kterou lze velmi snadno otestovat, a vždy by měla být testována v kontrastu se dvěma kodéry, a očekával bych, že někdy bude lepší a někdy horší než nastavené dva kodéry, v závislosti na přesném úkolu, jako je to, co přesně je druhá věc, kterou kódujete.
Takže možná, pokud máte dvě kopie, dvě parafráze stejné věty,
možná je to nějak matoucí pro pozornost, takže cokoli, nevím.
Chování také může být odlišné pro staré metody sekvence k sekvenci, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak možná s transformátorem je to jo, je těžší trénovat, takže možná budete muset zvýšit počet rozcviček, zahřívací sady.
(OSOBA2) jo, tak jen vědět jako-
(OSOBA8) nepamatuji si, takže si nepamatuji přesně, ale tohle je jako co-
když jsem začal v létě s těmi vícezdrojovými experimenty.
První věc, kterou jsem začal, bylo zřetězení parafráze a zdroje a možná I já, teď si nepamatuji,
Mohu to zkontrolovat až do příští schůzky, zda jsem se také pokusil,
Rozhodně jsem se snažil, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Možná jsem se také pokusil, že jsem náhodně zamíchal dvě věci, jo, a jen si pamatuji, že to hojně dělalo tuto kompenetrační věc a zkoušelo multi-enkodéry.
(OSOBA8) a bylo to pravděpodobně kvůli nízkým skóre.
(PERSON2) <nesrozumitelné/> které se vám líbí, mohou zlepšit vaše skóre amenity pouhým připojením výstupu založeného na frázích a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) pokud tedy zadáte výstup založený na frázích, který je v podstatě po úpravách, že? Můžete o tom přemýšlet jako o posteditingu, jako byste zveřejňovali výstup založený na frázích, že? Nebo jako záleží na úhlu pohledu, že?
(PERSON1) <nesrozumitelné / > Chcete-li jej plně přepsat, ale technicky to přesně odpovídá úkolu postediting, můžete jej připojit jako řešení úkolu postediting.
(PERSON10) dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token oddělovače vět, že?
Máte speciální token, který rozlišuje, jaký je zdroj a jaký je kontext nebo druhá věta, nebo je jen zřetězíte bez čehokoli?
A doufám, že se to systém naučí?
(PERSON8) snažil jsem se, myslím, že dva tokeny a Jo jako, protože v první verzi jsme měli podezření, že token může být také tokenizován sám, takže jsem ho pak přehrál jiným tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník a tento slovník neobsahoval oddělovací tokeny.
Použil jsem tedy nějaký token, který jsem předpokládal, že to nebude jako tokenizovaný na několik kusů, a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě, a to je jediné místo, kde se může objevit.
Takže by to mohlo být provedeno správněji, Ano, souhlasím.
(PERSON2) ale část baňky nebo komunikační část s klientem je něco, co nemohu udělat.
Protože nemám žádné zkušenosti a nemám čas to rozjet.
(OSOBA1) myslel jsem, že to znamená něco, co používám, nevím mediátora.
(PERSON2) ne, vytvořte klienta HTTP, který může vyplnit frontu a číst z jiné fronty.
A poslat text zpět v požadavku HTTP.
Protože moje představa je, že uživatel klikne být použity v ukrajinském projektu příliš.
(PERSON2) a moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, odešlete zvuk v malých kusech současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server jej vložte do fronty, se kterou budu frontu zpracovávat později (ASR).
A model bude dělat nějakou logiku, nějaký závěr s tím.
A kdykoli má nový přepis, odešle jej zpět a uživatel by měl získat částečný přepis zpět.
A měl by být okamžitě zobrazen v textovém poli.
(OSOBA1) mohl bych o tom přemýšlet.
Jen nevím, baňka buď, ale jo, můžu přemýšlet o tom.
(PERSON2) možná jiný HTTP server.
Nevím, možná na to ani nepotřebujeme nóbl HTTP server.
(PERSON1) myslím pro tok textu, používáme něco jako Hypercore, ale nejsem si jistý, jestli by to pro to fungovalo.
(PERSON2) Jo, jediným požadavkem je, aby zvládl více připojení najednou.
(PERSON1) No myslím, že on-line Tok textu je něco kolem 2 000 přinejmenším.
(PERSON1) mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými vnitřními pracovníky, takže myslím, Ano, Takže mám <nesrozumitelný/> řekněme deset, No místo výstupu, soubor od <nesrozumitelného/> vedlejšího pracovníka, takže <nesrozumitelný/>, který máme, takže se ujistím, že tyto věci pro jeden soubor jsou generovány paralelně od všech dostupných pracovníků.
(PERSON1) to by nám ušetřilo čas.
(PERSON7) jo, jo, to je velmi důležité pro paralelizaci všeho ve skutečnosti, paralelizaci jak zpracování systémů, tak vyhodnocení buňky DF, protože by to musel spustit mnohokrát, budou chyby, musíte to rychle znovu spustit.
(PERSON7) dobře, takže díky.
Takže jste s tím velmi zaneprázdněni, nechci na vás dávat žádné další věci, takže mi dovolte začít s připomenutím.
Musíme dokončit popis [PROJECT1] desk set,
Koho tu máme?
No, opravdu ne, jo, (je hotovo) a bohužel to tu není.
Tak, to by bylo pro [PERSON2],
Pak Hodnocení, to je pro [PERSON1], ale diskutovali jsme o tom.
Poslyš, dej mi tabulku v DSD, pojďme sem dát jemnou čáru a zatlačte šablonu tabulky, jako je struktura plánu, do delebl, takže čísla přijdou později, ale chci vidět některá čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) dobře, děkuji.
Máme [PERSON5], to je dobré.
Takže pro [PERSON5] bych chtěl zkontrolovat, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také pro vývoj, který je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
(OSOBA7) Jo, takže je tu ještě jedna věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když jej spustíte samostatně a uložíte výstupy.
Nejprve tedy použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a poté spustíte vyhodnocení.
A důvodem tohoto rozdělení je, že můžete více paralyzovat.
Jsem si jistý, že na různých frontách budou problémy a čísla budeme potřebovat velmi brzy.
Pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále udržovat překlad spuštěný pro zbývající,
a přehodnotit, s sel T F, ty chybějící, a, a tak dále.
Nejde tedy o to vytvořit sériové, sekvenční zpracování, které zahrnuje obojí,
ale jde o to získat výsledky a ve skutečnosti je lepší to udělat na plátky.
Nejprve získáme všechny výstupy, poté získáme všechna hodnocení.
(PERSON1) Jo, takže, myslím, právě teď, dělal jsem to samé.
(PERSON2) Ano, To je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem v dekódování udělal něco trochu komplikovanějšího.
Jako odfiltrování paprsků a nahrazení paprsků různými paprsky.
A Pro jako multi-token omezení a tento druh věcí.
Ale pro pozitivní omezení jsem jen porovnal tréninkový přístup s Jo, jen s touto velmi jednoduchou věcí.
Stačí upravit skóre v každém kroku stejným způsobem.
(PERSON7) dobře, takže zpět k pozitivním omezením.
Zaměřili jste se již na analýzu systému?
(PERSON2) Jo, právě teď čekám na přepracování datové sady z ([PERSON9]).
Také [PERSON9] podíval jsem se na (kód) a myslím, že vím, proč je to tak pomalé.
Protože pro každou položku v terminologii v přepracování (Europar) otevřete datovou sadu, tokenizujte ji, přečtěte ji řádek po řádku, tokenizujte ji řádek po řádku a poté ji zavřete.
Ale ty to děláš jen ty -
(PERSON4) takže si pamatuji, že pro [PROJECT1] jsem to dělal z loňského roku z nějaké chaty na horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím předložit.
A <smích / > takže to je také něco, co se stane [PERSON8] obávám se, že by mohl být...no, žádná párty, ale možná na vzdálené párty.
A najednou by si uvědomil, že to musí předložit.
Takže v tomto bodě nebude žádná recenze jako. <smát/>
On by prostě vzít PDF a nahrát ji tak. <smát/>
(PERSON7) dobře, dobře.
Tak, jo, zkontroluji 21., a jinak jim pošlu e-mail.
(PERSON4) prosím, myslím, že je lepší jim poslat e-mail hned teď a požádat o tento odkaz předem.
(PERSON7) dobře.
(PERSON4) Ano, díky.
(PERSON7) máme dnes k diskusi další otázky, nebo je to všechno až do Nového roku?
(PERSON6) doufám, že pro mě nic nebylo?
(PERSON3) před několika lety.
Mt marathons míval tento systém nebo nástroje, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, byl integrován s normálními, jako by existovaly také problémy PBML, které kvůli počtu těchto papírů smíchaly prázdné marže a samostatné papíry.
A dokonce jsme měli něco jako kdyby papír nebyl dost dobrý pro PBML, ale kdyby byl nástroj představen na Mt Marathonu.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, i když jsem řekl, váš systém, váš nástroj je zajímavý.
Zveřejněte to prosím na Mt marathon mezi lidmi.
Ale vaše noviny jsou příliš špatné.
Musíte to vylepšit a dostanete se pouze k dalšímu PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že zkoušením SIGDial přilákáme tak trochu lepší účastníky.
(PERSON3) to je ano, to je... jak jsem si myslel, že jsem také měl,ale neznám ani jedno z míst.
V červenci mají konečnou registraci papíru.
Konference byla tedy v září a papírové podání bylo v květnu.
Protože pro Interspeech bychom to také rádi rozdělili papír po papíru.
Aby některé dokumenty šly do interspeechového řízení.
A některé z našich příspěvků by přišly později pro řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat se Sigdialem nebo Interspeechem.
Pokud je v pořádku, aby měli některé z našich příspěvků, vzhledem k tomu, že tyto dokumenty jsou předloženy do březnového termínu.
Existuje tedy absolutní přísný požadavek.
A myslím,že proti tomu nemohou mít nic.
Protože pokud papír stojí za zveřejnění.
Jako, je to jen bonus, že papír má nějaký výsledek sdíleného úkolu, který se objeví v satelitní události.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o zvláštní zasedání.
V Interspeech se tomu říká speciální relace, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj papír připravený do termínu Interspeech, pošlete jej jako Interspeech papír a budete jej mít v Interspeech.
Ah, pokud ne, ah, udělejte to pro mezihvězdný termín, tady je náš termín.
A to je pro PBML.
(PERSON7) Ah, dobře.
Ale věc je jako pro satelitní událost Interspeech.
Ehm, Interspeech jako se nedostane do žádného řízení.
(PERSON2) můžete si myslím, že můžete jen si můžete rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím, že je to jiná věc, protože si myslím, že to není věc, která by selhala v jeho kurzech.
Rád selhávám, protože to nedokážete dokončit.
Samozřejmě, jako by to lidé jen vzdávali, ale myslím, že je to možná z jiného důvodu, že je nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám na začátku semestru řekl, že dobře, pokud chceme jeden (??) dostaneš jedničku.
Právě ve druhém termínu byste jej měli odeslat.
To je skoro jediná věc, na kterou se ptal.
Ale také nám řekl, že soudě podle trendů z minulých let to spousta lidí nedělá.
Je pro ně snazší číst na zkoušku.
Ne, promiň, studuj na zkoušku-
(OSOBA2) ano, protože obecně jsou jeho zkoušky poměrně snadné.
(PERSON2) takže bych neřekl, že je to super snadné, protože existují kurzy, kde je zkouška jako zábava.
(PERSON1) No, jeden z nich byl včera pro mě.
(OSOBA2) jo, když má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se opravdu zavazuje k něčemu, co například za sekundu nebo dvě zjistí oh, No, vlastně to byl špatný překlad.
Snaží se tedy použít jiné znění.
Chcete-li například specifikovat věc.
Takže vlastně, opravdu se mi to líbilo.
Líbí se mi některé překlady. Byl jsem opravdu ohromen, i když jste viděli, že model udělal chyby při prvním pokusu, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo opravdu plynule, což je podle mě také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita, protože překlad, pokud si přečtete vše, co dostanete stejné informace, ale formulace je prostě špatná, protože používala například více slov a používala nějaké opravy a podobně.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako některé příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
(PERSON2) Oh rozhodně, mohu vám vypsat své protokoly.
(OSOBA7) ale v jakých jazycích?
Protože víš, že neumím německy.
(OSOBA2) angličtina a němčina.
(PERSON7) jo, ale nemusím nutně mluvit německy <smích/>.
(PERSON2) pak mohu poskytnout anglicky–čínsky a anglicky–japonsky, pokud to pomůže <laugh/>.
(OSOBA2) takže znovu chci, aby to bylo lidsky čitelné.
Protože toto blikání je opravdu nepříjemné a pak ztratíte zaměření na to, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a o tom, jak pracujeme s informacemi.
Promiň, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoli vidím slovo, vložím si ho do paměti a moje paměť není lineární věc, ale je to spíš jako taška.
Tak jsem dal slovo do tašky.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je ten problém s blikáním.
Pokud něco přeložíte a pak to změníte, pak jsem to už četl, je to v mém mozku.
A pak ztrácím pozornost a kontrolu nad tím, co bylo ve skutečnosti přeloženo jako správné a nebylo to, co nebylo.
Proto si myslím, že celá ta věc s blikáním je z definice špatná a hloupá.
Jako bych viděl motivaci, jako byste chtěli zobrazit vše, co máte.
I když nemůžete slíbit, že je to dobré.
Ale myslím si, že s těmito extra informacemi nemůžeme pracovat.
A myslím, že možná problém je v tom, že systémy jsou vytvářeny lidmi, kteří s nimi pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále to ukazuji a je to nějak dobré, ale myslím si, že vývojář se ve skutečnosti nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíše to, ach jo, můj systém To může vydat opravdu rychle.
A i když jen hádá, že kvalita je v pořádku, myslím, že možná proto byl vytvořen retranslace.
Jen vývojáři systémů dychtí po zobrazení informací a myslím si, že protože jsme omezeni jako objem informací, můžeme nějaký čas vnímat, rádi vidíme, že další informace jsou pro nás jen další zátěží.
Takže si myslím, že není dobré ukazovat extra.
Stejně jako pokud chcete snížit latenci, pak místo blikání stačí snížit kvalitu.
Myslím, že je to stále lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste měli vidět nestabilní hypotézu, opravdu?
Jako z pohledu uživatele?
(PERSON1) stejně jako technicky, když překladatelé začnou překládat, mám na mysli cíl i pro anotátory, snažili by se sledovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatné, takže by se jen opravili.
(PERSON2) no, ale jo to znamená s mým řešením, jako byste neudělali blikání, ale zavázali jste se, jako by neexistuje způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) silně cítím, že naše práce není zrovna v oblasti řeči, je nezdravá.
Protože zde neexistuje žádný koncept řeči.
Pracujeme přímo na textu.
Jde ale o to, že návrh na statistický workshop letos skončil, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme jeden ze dvou sektilních nebo interspeech, protože oba jsou v komunitě dobře uznáváni.
Můžeme motivovat účastníky k předložení.
AHA, jediné jediné upozornění, které nyní zjišťuji, je, že s interspeechem nám nedovolí prostor v řízení, což může některé účastníky odradit, Nejsem si jistý, jak moc budou nadšeni zveřejněním příspěvku v archivu.
Takže v archivech mohou lidé publikovat kdykoli, že?
Takže to není výhoda pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
To byl důvod, proč jsem se zvláště zaručil za zvláštní zasedání.
Ale tentokrát, problém je, co chápu, je Naposledy, časové období mezi návrhy, předložením a konečným podáním papíru bylo pět měsíců, takže by to bylo dost času na náš harmonogram, ale tentokrát.
Jsou to jen tři měsíce.
Vidím tedy tento veletrh jako důležitý možný zdroj nepůvodní anglické řeči, který můžeme použít k rozšíření testovací sady.
Takže, myslím, že bychom se měli zaměřit na nejjasnější hlasovou soutěž, a můžeme udělat stánek, pokud budeme muset.
Ale rád bych to omezil, protože šíření do středoškoláků má pro nás menší dopad.
Je důležitější jej použít jako testovací relaci.
Měli bychom se tedy zaměřit [PERSON1] na [PROJECT2] nejjasnější hlas a udržet organizátory šťastné, abychom tam mohli shromažďovat data.
A dělat, co chtějí, abychom udělali výměnou za to, a musíme zkontrolovat jejich plenární program a jaký typ titulkování by byl užitečný pro tento plenární program.
takže by to pro nás bylo testovací sezení, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud se nás někdo zeptá, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, pak dobře, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
(PERSON1) Jo, ještě jsem se o registraci nepokoušel, ale myslím, že minule bylo povinné mít stánek.
(OSOBA2) Ano. Diskutujte s nimi tedy o tom, co je potřeba, aby byli šťastní, a oni nám umožňují dělat nejjasnější hlas, což je nejdůležitější věc.
Testovací relace je méně nutkání.
A budka je prostě něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se připojili k relacím dříve, než dělat takové věci.
Takže tyto přípravy opravdu potřebujeme procvičit.
S online světem, zdá se, že jednoduše j p do relace, a práce je hotová.
Ale není tomu tak.
Spuštění a správné připojení vždy trvá 30 minut.
Takže tam musíme být dřív.
A pokud nějaké sezení, které děláme, začíná v devět, ale organizátoři se sejdou ve čtvrt na devět.
Pak už musíme přijít ve čtvrt na osm, abychom měli 30 minut navíc, abychom se ujistili, že vše běží a pronásleduje lidi.
Tak, to je poznámka pro všechny, že pro vedení pracovat, prosím také předvídat, co vedení může náhle požádat, abyste udělat, a to by pomohlo trochu.
Další velmi důležitou zprávou je záznam těchto důležitých relací.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A první bod této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto relací.
Pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, je tedy důležité mít dobré záznamy o těchto relacích.
A jedním aspektem je získat souhlasy, aby bylo skutečně dovoleno nahrávat.
A to i když se pokusíme získat souhlas zpětně nebo cokoli jiného.
Pak je tu technický aspekt-záznamu.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, pamatuji si.
2 špatné citrony v řadě :(
Objednal jsem si od této společnosti, protože jsem ji koupil v předchozích sezónách a fungovalo to pro nás skvěle.
V této sezóně jsem si koupil další velikost, kterou jsem potřeboval.
Jedno z pyžam, které jsem dostal, mělo díru na noze pyžama.
Vrátil jsem to a společnost mi poslala nový.
Náhradní pyžamo, které můj syn nosil jednou, jsem si dal do pračky jako vždy a zip se ulomil!
Jsem tak zklamaný, protože nemám čas řešit výnosy každých pár dní, a přesto se to právě děje.
Jak je popsáno
Jedná se o základní puffer kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil do vakuově uzavřeného sáčku, takže je třeba jej na několik dní zavěsit, aby se vrásky objevily a trochu se "nafoukly".
Jsem 5 ft 6 palce a kabát je na mně po kolena.
Objednal jsem 2 + velikosti nahoru kvůli dalším komentářům a minulým zkušenostem a kabát je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapota funguje, ale žádné vazby na něm.
Přední zip funguje.
Na boku ani na zádech nejsou žádné větrací otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase jsou dvě kapsy (na vás mohou být vyšší nebo nižší).
Neexistují žádné ozdoby ani stylové detaily-je to základní kabát.
Za cenu si myslím, že je to v pořádku.
Nosil jsem ho za větrného dne, ale ne za studena.
Necítil jsem vítr, takže cítím, že je to dobré znamení.
Jsem však zvědavý, jak to bude fungovat v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem potěšen.
Vak s vakuovým těsněním lze znovu použít a prodejce zahrnul opravdu roztomilý poděkování, což byl skvělý dotek.
To je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký
To je velmi pěkná sukně.
Krajkový vzor je elegantní a měkký.
Nemačká se, ani poté, co byl nacpaný do plastu a krabice, byl velmi hladký, takže je to opravdu skvělé.
To lze snadno obléknout nebo obléknout a díky délce a střihu má jakýsi vintage pocit, do kterého jsem opravdu.
Myslím, že by to mohlo být lichotivé pro každého.
Jsem 5 " 5 " A 130 liber a objednal jsem si malý, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně velikost dolů.
Nepracoval s mým 1999 Buick LeSabre
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce i předinstalovaná baterie.
Nicméně, i když to mělo být kompatibilní s mým 1999 Buick LeSabre, dálkové ovládání se nepodařilo naprogramovat nebo synchronizovat s autem.
Pokyny jsou dostatečně snadné a vím, že jsem je sledoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý vzdálený fob.
Tento nový, nicméně, nebude fungovat,a tak ho vrátím.
Nebyl žádný problém s prodejcem nebo službou, zdálo se, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Gril mého auta byl ošizen velkým něčím, co letělo po dálnici, takže jsem potřeboval náhradu.
Po přečtení některých recenzí jsem se bál, že se to nehodí, ale bylo to perfektní!
Vlastním 2013 Corolla LE.
Nedal jsem si to na sebe-nechal jsem to udělat chlapa v karosárně-ale vypadalo to opravdu snadno.
Prostě to prasklo přímo za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože to vypadá docela chatrně (čas a létající úlomky to řeknou), ale přes to všechno jsem velmi spokojen, že moje auto už nemá na přední straně zející tlamu a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo My 5 letý absolutně miloval toto světlo netrvalo to dlouho dostal to k narozeninám v lednu je to Únor už má potíže s tlačítky a neběží jasně s plug in jí baterie dokonce se snažil dobíjení baterií Super cool, ale potřebuje zlepšení
Hudební Start
Klavír je skvělý předkrm!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruka-oko.
Klavír není jen hrací hračka, ale ve skutečnosti funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Pokud chcete, aby vaše dítě bylo budoucím pianistou,měli byste tento produkt vyzkoušet!
Velmi stojí za peníze!
Dal jsem si to na nos podle pokynů dvakrát denně třením po dobu 2 minut.
Kůže na mém nosu zčervenala a šla úplně syrová.
Byl jsem docela zaskočený.
Před lety jsem měl dobře uzdravenou jizvu po pádu do ostnatého drátu.
Nejen, že tento produkt nefungoval, ale téměř jsem skončil v ordinaci dermatologa, nicméně uvedení aqua-for a bandaid přes oblast ho nakonec uklidnilo asi po týdnu.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo pokazil vzorec??
To je tak divné.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí tyčinky od jiné značky, abyste viděli, jak by růžová měla vypadat, a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu rozrušený.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl jim říkat červená nebo růžová.
Bílá není tak jasná, jak bych doufal.
Zbytek barev je skvělý a Líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem věděl, že tam byla růžová.
Myslím, že fialová bude stačit.
pracuje z větší části
Před několika měsíci jsem si vybělil celou hlavu a pak jsem ji obarvil barvivem černé skříňky.
Pak jsem šel a nechal si po celé hlavě dát zvýraznění.
O několik týdnů později jsem si na vlasy nanesl barvivo na vlasy modré/zelené polární lišky a nevybledlo by.
Použil jsem tyto věci s Olaplex č. 3 a to se ohromně zesvětlilo, odstranilo zelené a modré části a zvedlo tmavé barvivo.
Po dni jsem si však všiml zeleného odstínu vlasů.
Každý den se to zhoršuje a já jsem použil extraktor barev dvakrát, se stejnými výsledky.
Moje vlasy jsou také tmavší tam, kde bylo barvivo na krabici.
Je to skvělý produkt, zdá se, že nevydrží.
nevěřte humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román musí být zmírněno některými realističtějšími hodnoceními.
Zkoušel jsem to číst, ale právě jsem našel jazyk plochý.
metafora" sladkovodní " a mnoho popisů lůna jako řeky a dítěte jako ryby se zdály vynucené, hacknuté a vymyšlené.
Přeskočil jsem dopředu a vypadalo to, že vše, co jsem našel, bylo drama kampusu.
Dávám této knize 10 hvězdiček!
Vynikající čtení!!
Knihu jsem naprosto miloval!!
V průběhu let jsem adoptoval 4 siamské kočky od Siri a každý z nich byl absolutní láskou.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri šla nad rámec svého úsilí o záchranu koček (hlavně siamských)!!
Opravdu se mi líbí toto kruhové světlo!
Je to úžasné za cenu a to dostane práci!
Jediným problémem je, že žárovka se zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji znovu zapnout.
Nemyslím si, že by se to mělo stát...Nevím, jestli mám vadné světlo nebo co, ale je to velmi pěkné kruhové světlo kromě přehřátí.
Matoucí příběh
S knihou bylo těžké držet krok, protože hodně poskakovala.
Také název se k příběhu nehodí.
Autor uvedl, že tímto mimozemšťanem bylo nakaženo několik lidí, nicméně vynechal podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a hodně číst, abych se ujistil, že mi nic neuniklo.
Miloval Collinse...
Chvíli trvalo, než se zahřál na Grady
3 1/2 hvězdy lék je bratři nejlepší přítel romance, stejně jako druhá šance romance smíšené do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše pro to, aby získal Collinse zpět a dokázal, že je pro ni ten pravý.
Před třemi lety měli Grady a Collins úžasnou společnou noc.
Collins si myslela, že konečně dostává všechno, o čem snila, nejlepší přítel jejích bratrů... ale když se druhý den ráno probudila sama a nikdy o ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpět a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdává.
I když jsem miloval předpoklad tohoto příběhu, a občas Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody pro odchod té noci,ale ani poslat dopis Collinsovi s vysvětlením?
Nechat ji přemýšlet a bolet po celá ta léta, a pak očekávat, že ho přivítá zpět s otevřenou náručí?
Byl klamný?!
Collins měl pravdu být naštvaný, rozzlobený, zranit, atd.
Měla pravdu, když se s ním pohádala, když ji chtěl zpátky a jít kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Miloval jsem Collins v této knize, byla silná, a střežila své srdce, a za to jsem ji obdivoval.
Jistě milovala Gradyho, ale byla vyděšená, a váhala ho pustit zpět do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla rozhodně moje oblíbená ze dvou.
Rozhodně nechala věci jít tempem, které chtěla, a když byla připravena poslouchat, poslouchala.
V této knize je spousta úzkosti, a bavilo mě sledovat, jak se tito dva znovu spojují, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevypadl tak kňučel a byl by trochu chápavější.
Pořád říkal, že to chápe, ale občas byl na mě trochu příliš ctižádostivý, a pak byl ke konci sladký.
Nakonec jsem ho miloval stejně jako Collins, ale na začátku knihy, těžko jsem četl jeho názory, protože jsem se nemohl spojit s jeho postavou.
První část této knihy, nebyl můj oblíbený, ale on druhá část?
Zbožňoval jsem, proto moje hodnocení.
Pokud máte rádi druhou šanci, a Brothers best friend romances, tuto knihu si můžete opravdu užít, zpočátku jsem měl s Gradym těžké časy a jak zvládl některé věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho zobrazení Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho zobrazení Churchilla, bylo velmi dobře provedeno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otáčení stránek...
Scenérie a kostýmy byly vynikající.
Je uštěpačný s dnešní dvojicí polobohů, kteří zastávají světovou politickou pozici.
Stojí za to podívat se několikrát...stojí za promyšlené přežvykování... ještě mnohokrát
Vyhněte se Wifi připojení-go Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V době, kdy, byli jsme uprostřed stěhování a bydlení v hotelu.
Nemohl jsem dostat tuto váhu pro připojení k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domu a mohu si nastavit vlastní Wifi systém.
Březen 2018-nastavil jsem svůj Wifi systém a tato stupnice se stále nepřipojí.
Pokaždé, když se pokusím, zobrazí se chybová zpráva.
I když jsem 10 ' od Wifi jednotky.
Sledoval jsem instalační video YouTube bez úspěchu.
Když jsem koupil jednotku, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato stupnice používá WiFi router ke komunikaci s telefonem.
Tento systém je omezen na připojení routeru...což obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Tuto stupnici bych nikomu nedoporučoval kvůli Wifi připojení.
Místo toho se podívejte na systémy, které pro komunikaci používají Bluetooth.
Nahrazuji to stupnicí připojení Bluetooth.
Dobrý, ale rád bych našel něco lepšího
Po mnoha výzkumech jsem tento produkt začal používat před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval dobře.
Vysychá však tak rychle, že nakonec použijete tolik lubrikantu, což nakonec stojí spoustu peněz a je příliš rušivé během sexu.
Byl jsem příliš líný na to, abych hledal nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš nákladný.
Životnost baterie je hrozná na té, kterou jsem koupil na Amazonu.
Stále nemůžu uvěřit, že Logitech přerušil tento dálkový ovladač, nic jiného se ve srovnání nepřiblíží.
Absolutně miluji tuto Harmony remote, toto je moje 4.
Pes žvýkal první, manžel klečel na obrazovce druhého a třetí stále funguje, ale uprostřed dotykové obrazovky je značka loktů také s laskavým svolením manžílek...koupil jsem to jako zálohu a obrazovky skvělé, ale baterie, se kterou byla dodána, drží poplatek možná na pár dní.
Můj originál (3rd one) udržuje poplatek za týdny najednou a já používám dálkový ovladač pro všechno.
Zlomil se za méně než týden
Líbí se mi produkt, je to pěkná velikost a barva!
Bohužel to měl jen týden a otevřel jedny dveře a prasklo to horní část dřevěného kusu!
Jsem opravdu zklamaný!
Je to všechno sestaveno a já už nemám krabici, tak jak bych mohl dokonce přemýšlet o tom, že ji pošlu zpět?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale bohužel to také nefungovalo!
Dveře zase vyskočily!!
Není příliš snadné sestavit plus....
Po sestavení je to pěkně vypadající kus nábytku, ale montáž byla obtížná.
Některá označení písmen byla nesprávně označena, takže jsem se musel sám pokusit zjistit šrouby, které dodaly k připevnění podlahy a bočních panelů.
Musel jsem jít ven a koupit rohové závorky, abych se ujistil, že zůstali spolu.
Také skleněné panelové dveře jsou mimo linii a neodpovídají rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedna z dveří zůstala zavřená, protože magnet, který udržuje dveře zavřené, je mimo linii.
Stále jsem nepřišel na to, jak je sladit.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA HORNÍ ČÁSTI MODULU
Koupil jsem je v únoru.
Nedávno jsem se je pokusil použít a bohužel pokaždé, když zkusím jeden můj stroj Keurig mi dává chybovou zprávu, že pod není kompatibilní s mým strojem.
Byl jsem pomocí koblihy Shop lusky v mém stroji, protože jsem ji poprvé koupil a nikdy neměl problém.
Při bližším zkoumání kávového lusku jsem si všiml, že kód vytištěný na horní části lusku není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72 což je 6 krabic po 12.
Dokonce jsem zkusil jeden z každého z polí 6 a stále dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože ostatní lusky, které se snažím, fungují dobře.
Je to jen z této zásilky, že mám tento problém.
Velmi zklamáním, protože moje návratové okno vypršelo.
Aktualizace: mluvil jsem se zástupcem zákazníka, který vrátil peníze.
Děkujeme Amazonu za vaši skvělou zákaznickou podporu!
Sladidlo na cestách.
Takové pohodlí!
Je opravdu hezké mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích!
Miluji swerve, a to je tak pohodlné mít tyto hodit do kabelky pro stolování ven, nebo použít v domě přítele.
I když jsou trochu drahé, nemohu vydržet stejné nebo růžové věci v mém ledovém čaji.
Swerve nebo nic, takže jsem nadšený, že mám sladidlo na cestách!
Ve skutečnosti nedělá žádné "čištění"vzduchu
Koupil to jako zvlhčovač, část" čištění vzduchu " je ve skutečnosti falešná reklama; V závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač knotového typu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně budete muset provozovat asi 5 let, aby se rozdíl zvýšil.
Na svou velikost má poměrně velkou kapacitu vody, protože "nádrž" je nedílnou součástí jednotky a má nízký výkon (i když o nic lepší než knotový Typ).
Je také poměrně snadné jej čistit, i když plastové disky nelze skutečně opravit, protože diskovou jednotku nelze rozebrat.
Pro německé inženýrství však kvalita sestavení není skvělá.
Měl jsem svůj už rok, což by bylo asi šest měsíců chladného počasí, a jednotka vyvinula velmi nepříjemný chrastící zvuk ze sestavy ventilátoru.
Můj odhad by byl ložiska ventilátoru, takže jen čekám, až se zde stane úplné selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní pouhému nákupu nového zvlhčovače knotu.
tl; dr-nestojí za dodatečné náklady,je vám lépe s knotovým zvlhčovačem.
Myslím, že bylo snazší zlomit, než si mysleli.
Dávám tomuto produktu 3 hvězdičku k tomu, že když jsem ho dostal, byl už uvnitř rozbitý.
Jakmile jsem to prozkoumal, uvědomil jsem si, kdo to vložil do krabice, vložil to tam rozbité, mohlo to být buď výrobci packers, nebo pro výrobce, problém by mohl být, že kupující vrátil položku a tvrdil, že ji prostě nechtěl nebo nepotřeboval a Amazon možná neudělal dostatečně dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti kupující nemohl říct, že to bylo rozbité, protože pak by to Amazon nevzal zpět, což je dobré zejména u tohoto druhu produktu, i když jsem ten, kdo uvízl s něčí nedbalostí.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a diskutoval o tom se svým manželem, jsem se rozhodl dát tomuto kupujícímu další šanci.
S tím řekl, že budu aktualizovat své hodnocení pouze na vyšší hvězdu v závislosti na tom, jak zákaznický servis zpracovává tento příspěvek (alespoň jeho adresováním) a pokud položka přichází ve skvělé kondici, má ve skutečnosti příležitost dělat to, co dělá, a funguje dobře dělat to, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale instalace pro mě nebyla tak snadná.
Snažil jsem se nainstalovat oba "zvony" do zapojeného vysílače několikrát bez štěstí.
Byl jsem připraven to vrátit, protože to nefunguje, ale myslel jsem, že to ještě zkusím a zkontroluji baterie ve zvoncích.
Voila...z krytů baterií vyčnívaly malé plastové jazýčky, které jsem vytáhl a vyšel plastový kus, který zakrýval baterii a zastavil ji v práci.
Poté, co jsem odstranil tyto kousky plastu, zvony fungovaly dobře a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v uživatelské příručce není zmínka o plastu nad baterií, který musí být odstraněn, aby zvonek fungoval.
Bylo by to méně frustrující, kdyby se o tom zmínili a nemyslel jsem si, že problém byl v tom, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou prstenů, zvonkoher a melodií, které si můžete vybrat, a je snadné jej kdykoli změnit.
Jedna věc, na kterou se při hodnocení tohoto zvonu ptají, je, jak je "odolný proti povětrnostním vlivům".
Nemohu se k tomu vyjádřit, protože byl nainstalován 5.července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný vůči povětrnostním vlivům, až do příštího období dešťů...pravděpodobně v listopadu.
Ztracený balíček-znovu mě Nabil
Vyrostl s nimi a byl nadšený, že je koupil pro mého syna, ale ztratili balíček živých housenek.
Řekli mi, že to vymění a tentokrát naúčtují polovinu přepravy.
Po významném telefonním čase mi nakonec znovu účtovali novou objednávku se slevou 3$.
Myslel jsem, že to bylo docela neprofesionální, protože to nejen ztratili, ale vedli mě k přesvědčení, že to napraví, jen aby mi na konci a účtovali téměř plnou cenu 30 minutový telefonní hovor s nějakým spiel o poukazu.
Strávil jsem 30 minut na telefonu, takže jsem ustoupil a koupil další sadu housenek.
Ohled.
Funguje dobře po některých bolestech hlavy.
Měl nějaké problémy s tím, aby to fungovalo.
Dodaný kabel nebyl dobrý-nenabíjel by baterii.
Když jsem vyměnil kabel za vlastní, byl schopen nabíjet a poté připojit zařízení přes bluetooth k počítači.
Měl potíže s nalezením počítačového softwaru, ale když jsem poslal e-mailem jejich podporu, odpověděli během jednoho dne se správnými informacemi o stahování.
Program PC funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadají velmi dobře pro mou aplikaci, ale nebyl jsem schopen se připojit k iPhonu nebo iPadu (vyzkoušel několik z nich) přes bluetooth.
Pokud se rozhodnu použít toto zařízení ve svém produktu, bude muset být tvrdý drát.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je to jako starožitné zlato
Zeptal jsem se prodejce, jestli je barva příliš žlutá před nákupem a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic Blízkého!
Sada vypadá velmi levně.
Je super lesklá žlutá se spoustou CZ, ještě lesklejší.
Na fotografii vypadá skvěle, ale v reálném životě bych ji nedal ani teenagerovi na nošení.
Miloval prsten-ale nemohl ho nosit pořád! :(
Ten prsten byl krásný.
Miloval jsem design a robustní pocit z toho; vypadalo to drahé a bylo to velmi pohodlné!
Jediný důvod, proč jsem dal pouze 3 hvězdičky a nakonec jsem produkt vrátil, je ten, že jsem si uvědomil, že ho nebudu moci nosit pořád.
Rád nosím své prsteny po celou dobu, proto se vždy ujistím, že dostanu mincovní stříbro, a vím, že někteří lidé říkali, že jejich prsteny po chvíli poskvrnily, ale já jsem nosil Moje asi týden rovně - dokonce i při mytí rukou - a nevšiml jsem si žádného poškození.
Zajímavé je, že problém, který jsem měl, byl, že vnitřní pás prstenu ve skutečnosti otočil můj prst bílý a vlhký - něco jako způsob, jakým bandaid dělá poté, co ho necháte na dlouhou dobu.
Stalo se to, i když jsem se ujistil, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale stalo se to nepříjemné, takže jsem se rozhodl, že to není prsten pro mě.
: (Škoda, protože jsem to opravdu miloval!
Takže pokud kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám, jděte do toho!!
Nebudete zklamáni!
kupte si Hýčkaného kuchaře...
Vlastním hýčkanou kuchařskou malou lopatku, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Rád používám tyto kopečky při pečení pro dokonale porcované sušenky.
Podíval jsem se na OXO scoop a Hýčkaného šéfkuchaře scoop a rozhodl jsem se ušetřit nějaké peníze a získat OXO one - obvykle mám hodně štěstí s jejich produkty.
Tenhle ne.
Kolem cookie arašídového másla #30 páka uvnitř lopatky přestala fungovat.
Musel jsem vypáčit rukojeti od sebe a znovu umístit páku, abych udělal několik dalších, a pak opakovat.
Proto... Uložte si zdravý rozum a kupte si hýčkanou kuchařskou lopatku.
Stojí to za to!
Nebude kupovat Mr. Coffee znovu
Chvíli to byl skvělý kávovar, ale vždy s tím byly problémy.
Pokud máte vodu mezi Černým plastem a kovem na karafě, vytékala by a vypouštěla vodu celé dny.
Pak se rozbila naše plastová páka, která umožňuje, aby káva protékala filtrem a do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale oni by mě odkázali pouze na servisní středisko, které je u konce 90 minut od mého domu.
Je skvělé připravovat kávu a udržovat ji horkou, ale je s ní příliš mnoho dalších problémů, než aby se do ní investovalo za současnou cenu.
Musí koupit!!
Miloval jsem tuto růžovou zlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v rukojetích a všiml jsem si, že předtím, než jsem si ji koupil, což je důvod, proč to stále dávám 5 hvězdy!
Bylo to snadné čištění a všechny přišly zabalené jednotlivě, které jsem zjistil, že jsou opravdu organizované, a uklidnilo to mou duši lol láska, milovat, milovat barvu a určitě bych si to koupil znovu pro sebe nebo pro milovaného člověka!
Může být dobrý na tyči, ale ne jako závěsná přepážka nebo štít proti počasí.
Hanba Audubonovi.
Pokyny vám říkají, abyste zasunuli zástrčku nahoru otvorem v přepážce a " ujistěte se, že je bezpečně na svém místě."
Jak???
Je navržen tak, aby přepážka jednoduše volně seděla na zástrčce, takže ji může tlačit nahoru jakýkoli tvor nebo sebemenší vítr.
Zástrčku můžete otočit vzhůru nohama tak, aby palcové šrouby byly na spodní straně přepážky, ale otočení těchto šroubů vám bude trvat hodiny; žádný nástroj to neudělá a jen ty nejmenší prsty by to měly snadné.
Trvalo mi více než hodinu, než jsem udělal napůl upečenou práci, jak je zašroubovat, abych zajistil přepážku ke zástrčce.
Je to kompletní PITA.
Objednal jsem si čtyři z nich; tři, které jsem neotevřel, jdou rovnou zpět a já jsem na trhu pro lepší počasí.
(Přiznejme si to; není nic takového, co by ve skutečnosti "zmátlo" veverky!)
Miluji mnoho funkcí těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které moje nové sazenice zeleniny dostávaly z okna.
Miluji mnoho funkcí těchto světel.
Klady: za prvé, snadno se upnou na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou na dotek chladná a nezpůsobila škodu ani při dotyku rostlin.
Věřím, že moje zelenina těží ze světel.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Nevyužil jsem časovač, raději je zapínám a vypínám sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené nevýhody: nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až zhasnou světla, budu si muset koupit úplně novou jednotku.
POZOR...VŮNĚ JE VELMI ŠPATNÁ...SLOTY PRO KARTY JSOU PŘÍLIŠ VELKÉ!
Když jsem to poprvé viděl, myslel jsem si, že je to krásné, ale vonělo to tak špatně.
Nejprve jsem si myslel, že to byla vůně kůže, ale mnozí poukázali na to, že je to vůně plísní.
Nikdy to nezmizelo, takže jsem to musel vrátit.
Navíc kapsy na kreditní karty jsou příliš velké.
Kreditní karty sklouznout celou cestu dolů, tipy nezobrazují, takže nemáte ponětí, co karta je kde a velmi obtížné se dostat ven.
FOTOGRAFIE, NA KTERÉ UKAZUJÍ, KDE KARTY TRČÍ, JSOU NEPŘESNÉ.
Je velmi malý..
Obdržel pás cestovních peněz a je mnohem menší, než ukazují obrázky.
Přál jsem si, abych to nekoupil a stále budu muset hledat něco většího.
Dobrý deštník, koupil bych to znovu, kdybych musel
První off, musím říct, že barva je loveeeee.
Spousta věcí, které si objednám ve fialové barvě, vždy přijde příliš světlá, příliš dětinská, příliš divná, příliš neonová, co máš.
Ale tato fialová byla hluboká a svěží a miluji ji, deštník je robustní a opravdu kvalitní.
Asi nejlepší deštník, jaký jsem kdy měl.
Dodává se s krytem a přestože nemusí mít příliš funkční použití, opravdu to vypadá ostře.
Balení je hrozné-obdržel 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Neobtěžujte se snažit získat ten, který není poškozen.
Vrátili jsme se 2 kvůli škodám při přepravě a třetí byl také poškozen.
Vzdát.
Dodávají to v měkkém tenkém pouzdře s jedním listem hnědého papíru v lepenkové krabici.
Vůbec žádné polstrování.
Skvělý koncept!
Potřebuje jen další vylepšení, aby se z něj stal opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý-růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech ostatních možnostech souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje tak, že současně funguje jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Celkově máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a zaznamenává vše, co vyjde.
V samotném mikrofonu však není žádná hudba.
Má konektor bluetooth, takže jej synchronizujete s telefonem a stáhnete si karaoke aplikaci, která dokáže posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a vašeho hlasu (také samostatně!)
a dokonce má možnost upravit úroveň ozvěny, takže ve skutečnosti zníte, jako byste byli v karaoke místnosti.
Některé věci, které bych rád viděl v budoucích vylepšeních, jsou: 1) je tu nějaká nepříjemná zpětná vazba, která se nezdá, že zmizí bez ohledu na to, jak daleko vzdálím telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače opcí uprostřed mikrofonu jsou neohrabané.
Jsem blázen do minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly učinit design elegantnějším.
3) Podpora více karaoke aplikací konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne prostřednictvím reproduktorového systému s plochou obrazovkou nebo centrálním obývacím pokojem, není to tak zábavné v prostředí večírku.
Pokud to výrobce dokáže nějak integrovat do většího ekosystému karaoke party, bude to nekonečno příjemnější.
Žebrovaný pryč podle Vision Supplies
Říjen 2017 koupil čtyři (4) kazety z Vision Supplies - Amazon Marketplace, takže bych měl v případě potřeby a ušetřit náklady na dopravu.
Za posledních pár let jsem použil dva, asi jeden ročně, a fungovaly dobře.
Pokusil jsem se použít jeden minulý týden, téměř prázdný po tisku 20 štítků, ale v posledním došel po 40 stránkách.
Plast a chybí na obou.
Řekl záruka vypršela!!!!
Kdo by zkontroloval každou kazetu při přijetí????
KUPUJÍCÍ BÝT VĚDOMI!!!!!!!!!!!
Promiň, Cože?
Můj přítel doporučil masku této řady, takže jsem si ji koupil, tento kondicionér a vše v jednom mléce.
Nemohu mluvit o účinnosti produktu, protože vůně byla prostě nesnesitelná.
Víte, že zatuchlý zápach staré budovy používají v ženských toaletách, aby se pokusily maskovat vůni * dám*, ale ukázalo se to jako tento kyselý, chemický, druh zatuchlé babičky?
To je vše, co mě napadne, když to cítím.
Znáte různé tahy různých lidí, takže se vám možná bude líbit vůně.
Můj přítel řekl, že může pomoci i těm nejvíce poškozeným vlasům, takže pokud se nestaráte o vůni, pak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že stále více přírodních linií se stará méně, protože se bude prodávat stejně, a tak teď všechno voní jako playdough.
Ztratil jsem několik oblíbených řádků, které měnily vzorec na levnější ingredience.
Nevím, jestli tomu tak je, nebo jestli je to falešný (který jsem nazval Davines a řekli, že to není), ale voní to jako Y U C K a musel jsem to vrátit.
Drops internet
Tento modem/router jsem koupil asi před dvěma lety.
Na začátku se zdálo, že je to v pořádku, ale za poslední rok jsem měl problémy s tím, že jsem upustil internet.
To se děje na všech mých zařízeních Wi-Fi i kabelových.
Jediným způsobem, jak obnovit službu, bylo provést reset napájení střídavým proudem.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Arris Tech kluci byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést obnovení továrního nastavení, abych to obnovil.
Nemohu doporučit tento modem / router na základě mých zkušeností.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Měl jsem to přes týden bez problémů.
Je to rychlejší a dosah je větší než Arris.
Četl jsem online, že ostatní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte Comcast internet nedoporučuji tento Arris modem / router.
Získejte Netgear, je mnohem spolehlivější.
ale stává se to dost nepříjemné.
Na pozitivní poznámku
1 z fanoušků znělo z rovnováhy po vybalení z krabice.
Ovládací prvky rychlosti jsou opravdu wonky - pokud je vytočíte na 100%, ventilátory se vypnou, takže je třeba je otočit na 100% a poté je pomalu vytočit zpět, dokud se znovu nezapne.
Kvalita sestavení je průměrná, ale zdá se, že u většiny těchto typů produktů je to v tomto cenovém bodě stejné.
Nohy pro držení notebooku, když je nakloněný, se několikrát odlomily...
Vracejí se, ale stává se to dost nepříjemné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z větracích otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a poskytuje velmi málo dalšího proudění vzduchu do notebooku s takovou konfigurací chlazení.
OK případ s vážnými omezeními
Tento případ je v pořádku,ale není výjimečný - 3,5 nebo 4 max.
Problém je v tom, že pro Tab A 10.1 W S pen je k dispozici méně případů.
Z těch je Gumdrop asi nejlepší, ale má některé vážné problémy.
Pouzdro guma (silikon, cokoli) je velmi hladký a hladký a nedává vám velkou jistotu, když držíte jazýček jednou rukou.
Karta a je těžká, takže pokud si položíte sledování videa, pouzdro vám sklouzne do ruky, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový štít, který zakrývá obrazovku, protože narušil provoz dotykové obrazovky.
To ovlivnilo pevnost 1dílného plastového rámu, který obklopuje jazýček a, takže nyní je gumový vnější kryt opravdu pružný a křehký.
Nakonec bylo obtížné se dostat do S pen.
S pen je v zadním pravém dolním rohu karty a, a udělali malou gumovou klapku, která chrání rohový výkyv dozadu pro přístup k S pen.
To znamená, že aby se pero s dostalo ven, musí se klapka vyklopit o 180 stupňů.
To je opravdu trapné a těžké to udělat jednou rukou.
Tento případ dělá dobrou práci při ochraně mé karty A, ale s těmito vážnými konstrukčními vadami to nemohu doporučit, pokud nemáte S pen, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu úhledný-one stop shopping pro všechny mé potřeby připojení.
Miluji jen házet to a mé notebooky malý napájecí adaptér v mém go bag a být připraven pracovat na velkém displeji 4k nebo chytit fotografie z mého fotoaparátu.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech rozbočovačích 4 usb-c, které jsem vyzkoušel od různých značek), je, že mac zjevně nedokáže rozeznat rozdíl mezi násobky stejného monitoru (takže můj mac vydává stejné video na všechny identické monitory připojené k rozbočovači, ať už pomocí HDMI a/nebo VGA).
Ale pokud používám 2 samostatné rozbočovače / adaptéry nebo 2 různé modely monitoru, pak mac správně vystupuje na displeje jednotlivě.
Ok, potřebuje nějaké zlepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký bezpečnostní zámek nad šokovým tlačítkem (byl stisknut více při nehodě, když je v kapse, pak jsem ho vlastně zamýšlel použít), moji psi se dokonce omylem zapnuli po šlápnutí na dálkový ovladač.
Také pokud se váš pes rád válí v mývalích hovínkách, jako to dělá můj, je to taková bolest v zadku.
Když se fekální hmota dostane mezi praskliny zařízení, vyžaduje to, abyste celou věc rozebrali, abyste ji řádně vyčistili a dostali zápach.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že téměř potřebujete přímý výhled, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Dobíjení je jistě pěkná funkce a nabíjení trvá dlouho.
Musím si účtovat jen jednou za dva týdny.
Dostanete to, za co zaplatíte.
Hrozný produkt, zkreslený
Koupil jsem si to jako tracker, který jsem použil, když jsem plaval, a ani jsem nedostal pořádnou šanci to vyzkoušet.
Za prvé, není odolný proti vodě a nedoporučuje se používat při plavání podle návodu k použití.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít zástrčku USB nebo počítač.
Fajn, máme kolem sebe spoustu lidí.
Když se ho snažím dostat do portu, abych ho Nabil, spustí se hned zpět.
Nejsem si jistý, jestli je něco, co není kompatibilní, nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
A konečně, aplikace stále vyskakuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílal text, což je velmi znepokojující.
Poté jsem v telefonu zavřel všechny aktivní aplikace, a viděl jsem další reklamu, když jsem šel zkontrolovat čas 20 o několik minut později.
Hrozný produkt, myslím, že dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přehnaný na popruzích
Tento batoh vypadá dobře a funguje dobře.
Je to hodně, zvláště když to porovnáte s tím, co dnes stojí batohy.
Důvod, proč jsem srazil hvězdu, je ten, že je tam příliš mnoho popruhů.
Na tašce je víc popruhů, než dokážu spočítat.
Skončím tím, že tyto extra popruhy odříznu a vypálím, protože většina z nich není opravdu nutná a jen se dostanu do cesty otevírání a zavírání tašky.
Kromě toho jsem si z toho udělal svou novou školní tašku na vysokou školu.
V zadní části batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se vejdou do dodaných kapes.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli problémy s hokejovými míčky.
Můj pes je miluje - její oblíbená hračka pro Aport a žvýkání-a plavou.
To je, dokud je nerozkousá na kousky.
Vyzkoušel několik, dokonce i verze "horkého počasí" - a trvaly o několik minut déle než ostatní.
Dokud se neobjevily tyhle.
Ty obstály v testu.
Můj pes není velký, ale je tvrdohlavá v tom, co žvýká.
Jak se říká, není to, jak velký pes v boji, Ale jak velký boj u psa.
Palec nahoru od Daisy a já.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Zkontrolovali jsme baterii po několika týdnech používání a viděli jsme, že voda šla do přihrádky, kam jdou baterie.
Samotné baterie shnily a vycházela z nich černá kapalina.
Při pohledu na design, zdá se, že neexistuje žádný způsob, jak by kryt baterie mohl být vodotěsný, což znamená, že nejen voda šla do prostoru během koupele, některé z tohoto toxického materiálu vyšly také.
Prosím, nekupujte tento výrobek.
Jsem šokován, že to bylo dovoleno jít na trh i přes tak zjevnou chybu.
problémy s přehřátím a těžké připojení ovladače
Dávám to 3 hvězdy prozatím, nechci nechat špatnou recenzi pro prodejce, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo samotné DJI tello, ale pravděpodobně zkusím oba, abych viděl, co říkají.
Líbí se mi, že drone je skvělá malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí spíše jako hračka než tato.
Je to však jediný dron, se kterým jsem kdy měl problémy s přehřátím, a ve skutečnosti to bere zábavu z létání, prozatím budu předpokládat, že jde o výrobní problém, který musí řešit co nejdříve, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že prodávající mi neposlal použití drone, jak jsem zaplatil za nový.
Dám prodejcům rekvizity k dodání, jakmile dorazí 1 den po zakoupení.
Aktualizuji Datum své recenze po kontaktování prodejce a dji tello.
O této dárkové tašce mám jen dobré věci
O této sadě dárkových tašek mám jen dobré věci.
Byl jsem schopen zabalit všechny své vánoční dárky s taškami, dárkový obal a hedvábný papír.
Produkt je velmi kvalitní a různé možnosti velikosti usnadňují výběr toho dokonalého pro každý dárek!
Vřele doporučuji.
Prodejce je naprosto sladký a pozorný.
Oslovil mě po mém nákupu, aby se ujistil, že jsem se svým produktem spokojený.
5 hvězd celou cestu kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte tuto hru Fyzika jsou hrozné a já jsem tak naštvaný na tuto hru, protože pravděpodobně existuje asi 40 hackeři na každou hru a hru.
A pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra stále dělá aktualizace o svých postavách opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné nekupujte tuto hru Fyzika je hrozná a mechanika je hrozná lidé, kteří zjevně lidé, kteří postavili tuto hru, byli vysoko nebo tak něco, protože je to jedna z nejhorších her, které jsem kdy v životě upřímně hrál, raději bych hrál pixelové hry v této kecy, je to jedna z nejhorších her, které jsem kdy v životě hrál.
Ne jako ostatní hry tomb raider
Od samého začátku se necítil jako ostatní hry tomb raider.
Hra je brutální v tom, že ovládací prvky nejsou chytré, když vědí, jakým směrem se snažíte ubírat.
Nechat tě padnout na smrt tím nejneudálějším způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tuto hru jsem si neužil.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomické a cenově dostupné, ale ne příliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, na které by se mohly zachytit, a s napájecím kabelem jako trvalým připevněním je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) vibrační efekt, který se spouští v akčních hrách, je mnohem slabší.
2) směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžcí a máme tendenci opotřebovávat 2-3 ovladače ročně.
Takže pro nás investice do kontrolorů ročně znamená, že musíme být vybíraví a obezřetní ohledně toho, co kupujeme.
Ovladač by si vystačil s odolnějšími pružinami; po několika měsících tlačítka, která se používají nejvíce, přestanou reagovat a správný joystick ztratí jeho Centrování, tj.
Dostanete to, za co zaplatíte
Po obdržení této položky jsem byl zklamaný, protože stříbrná část, která obchází obličej, se zdála být vyrobena z nějakého levného plastu.
Není to skutečnost, že byl vyroben z plastu, který mě zklamal stejně jako skutečnost, že použitý plast vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled pro mě.
Také jsem nevěřil, že vydrží každodenní nošení,takže jsem ho nakonec vrátil.
Byl jsem zklamaný, protože se zdálo, že by to byl dobrý obchod, kdyby tomu tak nebylo.
To však můžete přehlédnout, pak by to mohlo být pro vás to pravé.
Bylo to dobře zabaleno a rychle dorazilo.
Nic jako předchozí telefony Stylo, obrovské zklamání.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V A Stylo 2 Plus.
Je zřejmé, že se mi Stylos opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem si ho.
Nikdy proto, že člověk měl problémy nebo se zlomil, jen proto, že jsem chtěl zůstat upgradován a "ve smyčce" a udělal jsem to.
Ze všech těch telefonů, ani jednou jsem nikdy neměl žádné problémy se samotným telefonem.
Když jsem provedl tento nákup pro Stylo 3 prostřednictvím Virgin Mobile, věděl jsem, že všechno půjde hladce, jakmile dostanu telefon a nastavím ho, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokoval, jak byly předchozí Stylos tak úžasné.
Nikdy jsem nebyl schopen úspěšně nechat tento telefon převést na Můj účet Virgin Mobile.
S tímto telefonem jsem si pohrával o něco méně než týden.
Hledal jsem informace na internetu a dělal různé hovory zoufale se snaží dát Stylo 3 výhodu pochybností doufat, že to byl jen já dělat něco špatně, ale bohužel jsem promarnil spoustu času tím, protože to bylo 100% telefon má všechny problémy, které jsem nechtěl přiznat.
Nesnáším skutečnost, že musím dát Stylo takové hrozné hodnocení a recenzi, ale byl jsem s tímto telefonem extrémně zklamaný.
Doufejme, že LG ups svou hru a může zlepšit budoucí Stylos, pokud existují nějaké, ale to byla obrovská Busta.
Na světlé straně, návrat a moje vrácení peněz proběhlo hladce, ale to je asi tak vše.
