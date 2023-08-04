Hakovaná verze Jedi Knight se hroutila, protože volala funkci z konce vtable.
Ukázalo se, že se předpokládalo, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má na konci přidány další metody ve srovnání s IDirect3DViewport, který jsem implementoval.
Pro mě je to docela velké předpokládání, protože vytváří pouze pohledové okno pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní chápu, že v praxi je IDirectXObject2 obvykle správnou nadmnožinou IDirectXObject, bez změněných podpisů funkcí a nových metod přidávaných pouze na konec.
Ale toto není všeobecně pravda; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže, protože to zde platí, musel jsem pro opravu rozšířit implementaci mého zobrazení o metody IDirect3DViewport3, aby bylo volání nové metody platné.
Předpokládejme pro účely argumentace, že věda alespoň částečně sestává ze seznamů objektivně faktických tvrzení o světě, které jsou pravdivé bez ohledu na jakoukoli teorii, kterou by mohly podporovat.
I když je pravda, že taková fakta existují ve vědě, je stále možné argumentovat, že vědecká fakta jsou teorií nabité.
Vědecké fakta vznikají z experimentů.
Experimenty na tomto čtení nefaktury vytvářejí, ale volba, které experimenty provést, ovládá, které fakty jsou objeveny.
Některá fakta, např. o subatomárních částicích, mohou vzniknout pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se jinak uskutečnily.
Toto je velmi stručný náčrt pravděpodobného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
To *není* argument ve prospěch existence objektivních vědeckých faktů, ve které nevěřím.
Bude to můj první projektový vůz.
Vyzvednu to tento víkend.
Hledal jsem dobré první auto pro chlapa; a opravdu miluji estetiku 80. let.
Již na cívkových tlumičích a snížené výšce jízdy.
Udělal jsem trochu výzkumu, ale rád bych, kdyby někdo měl nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že nejsou rychlé ve srovnání
#Čas vyvětrání do Fediverse.
Domácí partner a já jsme dnes večer šli do obchodu s alkoholem pro nějaké pivo a láhev bublin.
Když jsme šli zaplatit, pokladní byla poměrně zřejmě #trans žena.
Já, v kraťasech a tílku, a Domácí partner, celý potetovaný a s novým účesem, který sám popsal jako "dělá mě vypadat jako neo-nacista".
Její tělo se okamžitě ztuhlo a v jejích očích se objevil výraz strachu.
A pak jsme prostě... zaplatili za naše věci.
A řekl děkuji.
A řekl jsem, že její nehty vypadají cool.
Úsměv úlevy na její tváři byl skvělý pocit, ale fakt, že se nejdříve bála, JE STRAŠNĚ OTRAVNÝ A NENÁVIDÍM TO.
Toto je nejhloupější časová osa a nesnáším ji tečka com.
Nic nezabrání Donaldu Trumpovi kandidovat na prezidenta, ať už je obviněn, odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se sám omilostnil, aby se dostal z vězení.
Ale nemůže se omluvit z vězení ve státě.
To bere guvernér státu.
Dvěma zapojenými státy jsou New York a Georgia.
Posledně jmenovaný guvernér Kemp nepochybně prominout Trumpovi, pokud bude odsouzen nebo dokonce obviněn státním zástupcem okresu Fulton Fannie Willisovou.
NY je nejlepší nadějí pro odpovědnost
Existuje významný důkaz, že skutečná komunikace v reálném světě nemůže být redukována na odesílání signálů s kontextově nezávislým významem.
V této práci, založené na variantě klasického signálního modelu Lewise (1969), zkoumáme podmínky pro vznik kontextově závislé komunikace v konkrétním scénáři.
Konkrétně ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Zároveň studujeme environmentální podmínky a kognitivní schopnosti, které umožňují kontextovou disambiguaci významů symbolů.
Ukazujeme, že omezení prostředí na volbu referenta příjemce může jednostranně využít odesílatel, bez schopnosti odstranění nejednoznačnosti na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Navrhujeme, že kontextově závislá komunikace je situovaný vícevrstvý fenomén, který je zásadně ovlivněn vlastnostmi prostředí, jako je rozložení kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály mimo kontext nejednoznačné, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil setkání s Penny a Nicholasem z Ashanti Development o víkendu a pokec o jejich pokroku.
Organizace Ashanti Development již téměř 20 let spolupracuje s neustále se rozšiřujícím počtem komunit v regionu Ashanti v Ghaně, zapojuje se do komunit a poskytuje podporu v oblasti vody a sanitace, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, jak začlenit a podporovat svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase při podpoře řady projektů.
Když jsme se o víkendu setkali, byl jsem potěšen slyšet o pokroku, zejména v oblasti výsadby stromů a podpory farmářů.
Bylo vysazeno tisíce stromů a zemědělci zaznamenali zvýšení výnosů plodin díky řadě zásahů, od podpory při nákupu zařízení po školení.
Nicholas spolupracuje s farmáři na snižování použití pesticidů, zatímco hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je padající armádní červ, který může zničit kukuřičné plodiny.
Fotografie z mé návštěvy Ghany v roce 2011.
UPS obchod poblíž mě mi nedovolí napsat štítek nebo psát na krabici.
Musí vytisknout štítek.
Nedovolí mi říct jim adresu, kam to jde, a kdo to odesílá.
Musím poslat e-mail na nějakou náhodnou adresu s neformátovanými daty, aby úředník mohl e-mail přečíst a zadat ho do svého systému pro tisk štítku.
A vždy mi za tu "pohodlnost" účtují 2,25 dolaru.
Následující ráno a nemůžu překonat ostudnou předstírání veřejné služby žurnalistiky Chrisa Lichta na CNN minulou noc.
Bylo to skandální, jako symbolický 6. ledna protidemokratický festivus lží a stížností, sebezničující hostovaný americkými médii.
HANEBNÉ PUBLIKUM.
Licht SOUHLASIL s publikem složeným pouze z republikánů!
Kdo prověřil a vybral jednotlivce?
Je tam příběh, který je třeba nahlásit.
Hledání hodnocení - iluzorní nezodpovědnost toho všeho.
To nelze opakovat.
Mám velmi průvanový sklep, což v podstatě znamená, že se mi tam může ukrývat hodně hlodavců.
V posledním měsíci nebo tak nějak bylo hodně známek více hlodavců, což bylo mimořádně překvapivé, protože je jaro a myslel jsem, že by s příchodem změny počasí vyrazili ven.
Přesto jsem měl roztroušené několik starých pastí a pečlivě jsem na ně každých pár dní doplňoval arašídové máslo, které mi myši laskavě olizovaly.
Včera večer jsem se toho nakonec přesytíl, všechny pasti jsem vyčistil od arašídového másla a přilepil na ně pistácii pomocí super lepidla.
To fungovalo.
(jen pro informaci, vyzkoušel jsem téměř každou "humánní" past na trhu s velmi malým úspěchem.
Nejsem zvlášť šťastný z jejich zabíjení, ale nebudu přijímat komentáře k etice zabíjení myší.)
Už mě unavují konzervativní strany a vlády, které se obalují značkou pro-podnikání.
Nejsou, alespoň ne v Albertě.
Určitě snížili daně pro podniky.
Ale také snížili granty a daňové úlevy, které podporují více podnikatelské aktivity.
Vlastním podnik. Je úspěšný navzdory provinciální vládě, ne díky ní.
Objevil jsem těžkou cestou, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky se přehrávající videa, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělávají peníze, ale všechny ty odpadky se zdají být kontraproduktivní, pokud lidi odhání.
To platí i nyní, když goatse.cx už neexistuje, i když by to byl těsný závod na dno mezi goatse a například khou.com, kde jsem se pokusil sledovat video, které mi poslala Wendy.
Na prvním vlaku dnes, revizor se podíval na naše lístky a řekl "dlouhá cesta!"
"Ano a dnes se vracím," řekl jsem.
"Pouze ho odvážím do Glasgow," pokusil jsem se vysvětlit, ukazujíc na mého spolucestujícího.
"To není něco, co slyšíte často 'Jen ho odvážím do Glasgow,' " řekl prodavač lístků.
Je to věc, kterou jsem také nikdy předtím neřekl.
Věc, která mě přesvědčila minulou noc, je, že musíme být připraveni bojovat proti Trumpismu.
Trumpismus je kult.
Je to kult, který opravdu nikdo nechce, kromě fanatiků, kteří jsou v něm.
A oni jsou opravdu šílení.
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas se bránit.
Vyjděte a protestujte nyní.
Získejte nějaké nálepky na nárazník, které jsou proti Trumpovi, a nalepte je všude.
Odpovězte zpět těm, kteří by se pokusili mluvit přes nás.
To není normální.
To není v pořádku...
Můj soused a já jsme přijeli domů ve stejnou dobu a já jsem ho mohl slyšet, jak z druhé strany ulice kašle bouři covidového hlenů.
Tak jsem se rychle snažil dostat do svého bytu, abych se mu vyhnul, ale on se mi stále podařilo dohnat a povídat si se mnou.
Přísahám, že lidé nakažení covidem jsou jako zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné chodit na veřejnost nebo se vrhat na lidi, když kašlete mukovou bouři.
Opakuji. Není společensky přijatelné šířit svou covidovou slizovou bouři všude!!!
Psaní Zázraků 5/11: Směje se vaše hlavní postava více, nebo více pláče?
Abe své starosti skrývá a snadno se směje, zatímco Tom se nebojí plakat, ale je méně pobaven hrubým humorem.
Jan tě zraní, než ti dovolí vidět, že je zraněná, a nejvíce se směje, když jsou věci naruby.
Mio ví, že smutek je stálým společníkem života.
Po 4 000 letech trápení se Yl ocitá na místě plném lásky a prožívá silné emoce, se kterými neví, co dělat, takže je toho hodně z obou.
#CNN by měla prostě zavřít.
Včerejší fiasko s #MangoMoron bylo skandální fiasko.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "ředitel" kabelových zpráv rozhodl o tom, že dá tolik vysílacího času tomuto tlustému, lživému zločinci?
Vysoký tlak bude převládat až do začátku příštího týdne.
Studená fronta by měla dorazit do poloviny příštího týdne.
Dnes ráno ukázaly IR satelitní a pozemní pozorování rozšiřující se oblast nízkých strat a skvrnitých <URL>
Nerdovský student Arnie Cunningham se zamiluje do Christine, rezavého Plymouth Fury z roku 1958, a stane se posedlým obnovou tohoto klasického automobilu do její bývalé slávy.
Jak se mění auto, mění se i Arnie, jehož nově nabytá sebejistota se za volantem jeho exotické krásy mění v aroganci.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte spolehlivého partnera Salesforce, abyste využili jeho odbornosti a maximalizovali hodnotu vaší investice do CRM.
Objevte, jak vám může partner Salesforce pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což umožní vašemu podnikání prosperovat v ekosystému Salesforce.
Jednou z nejšílenějších věcí na tom, jak se moji sousedé obrátili proti mně, je přemýšlení o tom, kolik úsilí stojí být nepřátelský.
Zapomeň na mě, v pohodě.
Ignoruj mě, fajn.
Bolí to, ale musíš dělat to, co je pro tebe nejlepší.
Ale v tomto bodě se otevřená nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zavření dveří před mým obličejem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A stále nemám ANI PONĚTÍ, co jsem mohl možná udělat, abych si toto zasloužil.
Měli klíče k mému bytu více než 6 let.
Ta loď je zakázána.
Jsem si vědom vaší nenávisti vůči Organovi.
Ona pro mě není důležitá.
Můžete ji zabít, pokud to dokážete.
Ale další jedinec často létá na té lodi.
Pokud by zemřel... důsledky by byly... významné.
Často si stěžuji na otcovství.
Zde je (trochu delší než) krátký úvod do toho, co myslím tím, že otcovství:
Není to můj termín, je to termín používaný k popisu, kdy je vyprávění nebo herní mechanika postavena kolem centrálního protagonisty (obvykle staršího, obvykle muže), který se stará nebo chrání jinou osobu (často mladší).
The Last of Us je jednoduchý a kanonický příklad otcovství.
Joel využívá své dovednosti a schopnosti k provádění (extrémních) násilných činů, aby splnil úkol, který je označen jako "pečování."
Otcovství obvykle předpokládá, že řešením situace, kdy rodičovská postava musí pečovat nebo chránit dítě nebo náhradu dítěte, je ohromná síla a použití této síly k vynucení velmi specificky tvarované dynamiky moci.
Otcovství narušuje možnost komunitních řešení a často zcela ignoruje nebo podkopává jakoukoli agenturu, kterou dítě má.
Tímto způsobem je "Dad-ification" zástupcem mnoha neoliberalistických ideálů; zejména myšlenek jako je samostatnost a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je rychlý přehled, jak využít naši webovou stránku.
- Posíláme oznámení, když se sníží cena letenek.
- Poskytujeme odkazy, kde si můžete rezervovat jízdné.
- My neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti najdete v celém blogovém příspěvku.
- Udržujeme seznam příkladů rezervačních dat pro každou nabídku, kterou zveřejníme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v mírovém a bezpečném prostředí.
Přesto jim neuvěřitelný strach, teror a vyhnání zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby prodiskutovaly, jak podpořit její snahu poskytnout pomoc v oblasti duševního zdraví zranitelným dětem.
Již jsme nabídli podporu v oblasti duševního zdraví a psychosociální podporu.
Všechny naše snahy jim pomohou zvládnout tuto cestu.
Hromada nových lesklých věcí v #dart
Časem se dart stal mým oblíbeným nástrojem pro rychlé vytváření uživatelského rozhraní.
#flutter je radost s ním pracovat a mají #mobx pro snadnou správu obchodů.
Příběh o závislostech je méně šílený než u nodejs.
Samozřejmě, že Flutter je opravdu špatný, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i cíl Flutter web je špatný).
Ale umožňuje rychle se pohybovat a proto je ideální pro malé hacky.
Ježura s ametystovými a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou postavu a jsou svalnatí.
Jejich ocas je extrémně tlustý.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové kočičí brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Být schopen skákat opravdu vysoko, roztrhat obyčejné lidi na kusy, používat děsivé magické schopnosti a doplňovat zdraví tím, že se krmíte svými nepřáteli - to by mělo být základem všech PC her, abych byl upřímný.
Navzdory nejlepším snahám Bráma Stokera, Maxe Schrecka a Stephenie Meyerové je zobrazit v špatném světle - každý ...
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě si moje maminka oblíbila puzzle hru, kterou jsem vytvořil před lety, a většinu tajemství objevila sama, takže nebyla jenom maminka, když řekla, že se jí to líbí.
Tak možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a/nebo hokkienštiny, které vůbec neznám.
Hádám, že budu muset zjistit, zda je Bing nebo Google lepší v překládání sprostých homosexuálních sexuálních narážek.
Hrála mi hlavou tato myšlenka už nějakou dobu:
Duševní zdraví je často vnímáno jako něco odděleného od "běžného" zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku, stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce uznáván TERFs a podobnými, protože je obecně více fyzický a jako takový viditelný.
Stejným způsobem, jak je duševní zdraví mnohými vnímáno jako méně "skutečné" než fyzické zdraví, mám pocit, že být trans je pouze intersexem mysli.
Čím více čtu studie o sexu, pohlaví, psychologii, tím více se mi tvrzení "Mé pohlaví je mužské, moje genderová identita je ženská" zdá zjednodušené a nepřesné.
Téměř to vypadá, jako bychom ustoupili část argumentu TERFům.
Mám pocit, že být trans znamená být "biologicky non-binární".
Mé biologické pohlaví je nebinární, moje genderová identita je ženská.
Myslím, že označení "non-binary" by mělo být rozšířeno nejen jako termín pro pohlaví, ale také když se odkazuje na sex.
Poslouchal jsem, s přestávkami, díla od @iotar.
V tomto tajemném kolektivu je spousta opravdu dobrých věcí.
Líbí se mi krautrockové nálady a jiná světová popová hudba a radiophonic workshop a všechno možné.
Rozhodně stojí za to to zkusit.
Také pro informaci, mnohem více se mi líbí rozhraní archive.org než desktop #bandcamp - nemám ponětí, jak lidé používají bc jako svou hlavní hudební platformu (kromě politických důvodů).
Trochu si hraji s Flutter.
Nenáviděl bych založit svůj podnik na technologiích od Google, abych byl upřímný, na druhou stranu Google je jedním z mála velkých hráčů s reálnými pobídkami k vytvoření přitažlivého zážitku napříč platformami a to je vidět.
(A také: Web je nyní bohužel většinou věcí Google)
Také se prosím zdržte říkat mi, že aplikace google/flutter na iOS a macOS jsou špatné.
Práce na více platformách je těžká, pokud ji chcete dělat dobře.
To vím.
Děkujeme všem, kteří si stáhli nejnovější aktualizaci Leasey.
Vynořilo se několik velmi malých obtíží.
Nic, co by způsobilo poplach, ale přesto se tím zabýváme.
Příští týden bude vytvořena malá aktualizace, která je opraví.
Většinu včerejška jsme strávili instalací nové aktualizace pro některé zákazníky a každý, kdo potřeboval tuto pomoc, by ji měl mít již nyní.
Mějte hezký den!
Technické přiznání: Nemůžu pochopit Grafana & Prometheus, alespoň z hlediska metrik a monitoringu serveru/aplikace.
Nevím přesně, proč můj mozek to nedokáže vypočítat; může to být tím, že nástroje jsou prostě tak široké a nejasné, že můj mozek se prostě zablokuje kvůli 'příliš mnoha možnostem'.
Chci vytvářet nástěnky.
Grafana vypadá pěkně.
Mozek nefunguje.
Tak s přicházející novou úrovní raidu #FFXIV jsem dlouho přemýšlel "člověče, chtěl bych zkusit pořádný raiding, ale Party Finder zní jako nepořádek a nikdy nenajdu statickou skupinu, která by mě vzala."
Tak jsem si řekl, na to kašlu!
Vytvořím si svůj vlastní statický obsah!
Plný lidí příliš nervózních na to, aby se pokusili připojit k raid static, aniž by měli jakékoliv očekávání, že budou vůbec dobří!
To... by asi nefungovalo!
...A tak jsem se našel, jak musím sestavit seznam účastníků raidové skupiny.
V mládí jsem byl nenasyceným čtenářem.
Poté mi život zlomil duši a já ztratil veškerou vášeň pro fikci a skvělé vyprávění.
Ale, po ~desetiletích~ čtení téměř ničeho (s výjimkou funkčních pracovně orientovaných nebeletristických textů a občasné knihy o seberozvoji) jsem si stanovil cíl přečíst 23 knih v roce 2023.
Nyní jsem u knihy číslo 31 a je teprve květen.
Jsem ZPĚT, zlato!
Ve skutečnosti jsem nic nedosáhl.
Jsem rád, že mi několik lidí přišlo soukromě a řeklo "podívej, kvůli všemu tvému úsilí, ti dám tuto částku peněz".
Chci vidět, jak tyto společnosti, které zprostředkovávají transakce, vysvětlují svým zákazníkům, jak stanovují své procenta.
O tomhle nebudou mluvit na Bloombergu!
Ale pokud bude Spotify mít dobrý kvartál, tak to udělají.
Je to nebezpečí pustit migranty na jižní hranici? Nevím.
Nechte je znovu obnovit vyprázdněná a chátrající města po celé zemi. Znovu.
Tyto lidé chtějí zlepšit svůj život.
Bílí nacionalisté, závislí na zbraních, pravicoví zastánci diktatury.. to je nebezpečí.
Vyhostit bílé supremacisty.
Jsem tak unavený z titulků tvrdících, že "Práce z domova je mrtvá." nebo že "Práce z domova byl nezdařený experiment."
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Je to všechno clickbait, ale dělá mi starosti o výkonné ředitele a manažery, kteří tyto články čtou.
Před rokem 2020 existovala možnost práce na dálku.
Stále budou existovat práce, které lze vykonávat na dálku v předvídatelné budoucnosti.
Práce na dálku je umožňující.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístupnost pro každého s internetovým připojením a dobrým pracovním prostorem.
Umožňuje lidem vyhnout se dlouhým cestám do práce, které jim berou čas ze dne a od rodiny.
Ignorovat tyto fakty je špatně.
Přestaňte zobecňovat a snažte se pochopit, jak vaši zaměstnanci skutečně pracují.
#PráceZDomova #podnikání #neurodiverzita
Nejde jen o konzervativce proti progresivistům, řekl na semináři více než 100 příznivců v Grande Prairie.
"Toto je válka mezi pro-lidskými a anti-lidskými," řekl.
Parker se odkázal na potrat a moderní impuls městských žen odkládat mít děti kvůli své kariéře.
Také tvrdí, že NDP a progresivci chtějí pro dobro životního prostředí zredukovat populaci společnosti.
"Jsi uhlík, který se snaží snížit."
Tak jako od začátku pro všechny mé narozeniny v minulosti, vždy jsem měl těžké.
Vždy, když se blížil květen, bála jsem se oslavovat své narozeniny.
Něco by se vždy stalo, špatně dopadlo, nebo by to bylo jen stresující a depresivní.
Během let jsem bojoval, abych se dostal z této myšlenkové nálady a měl lepší narozeniny.
Trvalo to roky změn v mém životě a tvrdé práce, ale konečně...
Začínám se usmívat a užívat si své narozeniny bez starostí.
A dnešek se již stává skvělým dnem!
Zima je 30 dní daleko v této malé části Velkého jižního světa.
Ale já nemůžu být oklamán!
Toto je začátek.
Déšť padá a i když není zmrzlý, nebudete v něm tančit!
Je to skvělý den na objednání doručení zmrzliny.
Byla to jedna psí noc a ten pejsek nešel z postele ani pro "Psí snídani - Snídani pro psy!"
Zapnu podšívku do mé cyklistické bundy - pro případ, že bych ji potřeboval uvnitř.
Znáte výkonný způsob, jak může webová komponenta reagovat na přidání/odebrání z dokumentu?
Toto je pro komponentovou knihovnu Wikipedie (OOUI).
Je to převážně sémantický HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
Momentálně používáme hack MutationObserver.
Z důvodu výkonu nezaznamenáváme celý dokument.
Vytvoříme oddělený dočasný rodičovský prvek, nainstalujeme MO tam a sledujeme, jak se stává odděleným (tedy připojeným jinde).
Casper, ta #krysa, je v těchto dnech absolutní jednotka.
Myslím, že moje nová práce mu prospěla - dvakrát denně má volný pohyb, zatímco já pracuji, vcelku předvídatelných časech.
Konečně se mi podařilo pořídit dobrou fotku, na které visí, takže si mohu být jistý, že není tlustý.
(U #krys, příliš vysoký obsah tělesného tuku může být škodlivý pro jejich zdraví.)
On není.
Je naprosto vyčerpaný z toho, že dvakrát denně běhá po mé kanceláři.
Nemám váhu, abych ho zvážil, ale zdá se, že má dobře přes libru.
Dělá mi takovou radost vidět ho, jak se mu daří.
Dnešní pokroková zpráva o Aerostrike:
) Drobné úpravy rozložení mapy Hel's Fighters.
Navíc je mapové menu plně funkční!
2) Měnový odměňovací systém byl připojen.
Zítra bude testováno s různými bitvami.
Deštivé dny!
Minulý týden jsem udělal spoustu práce a cítím se mnohem lépe ohledně položek na poli.
Všechny kapusty, kel, mangold jsou přesazeny.
Plány na výsadbu salátu na Penn v 6řádkovém vzoru a porovnání, jak se to vyrovná výsevu na lůžkách.
Jarní hrášek na Gilpinu začíná růst, takže je třeba postavit mříže.
Také je třeba zasít řadu salátů, aby se do obou integrovaly nakrájené zeleniny, a vycvičit posádku na zavlažování, přípravu záhonů a přesazování, což představuje 90% dovedností mimo sklizeň.
Je rok 2023 a stále vidím lidi s iPhony, kteří se aktivně vyhýbají používání Apple Maps.
Apple Maps je standardně předinstalovaná aplikace v iOS, a přesto si lidé stáhnou a nainstalují Google Maps do svých iPhonů.
Nemám ponětí proč.
Zvědavý, udržoval jsem otevřenou mysl, abych porovnal, jak se Google Maps a Apple Maps srovnávají na mém testovacím zařízení iPhone (můj každodenní telefon je zařízení Android, takže je vzácné, že používám iPhone).
Zkušenost s následováním pokynů byla na Apple Maps mnohem lepší než na Google Maps.
Apple Maps vyhrává.
Proč tedy lidé skáčou přes extra obruče, aby nainstalovali Google Maps?
Žádný nápad.
Mohlo by to být tím, že Google Maps přišly na trh jako první?
Byla to katastrofa Apple Maps z roku 2012?
Může to být tak, že Google Search je integrován s Google Maps?
Žádný nápad.
To ale řečeno, jsem zaujatý.
Jsem zaujatý ve prospěch toho, abychom uživatelům neposkytovali odpad, a Apple se s jejich Apple Maps, když vyšly v roce 2012, opravdu pěkně pokazil.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to právě půda, která ji činí dobrým uchovatelem bohatství, pokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Dům samotný ztrácí na hodnotě, protože se zhoršuje jeho stav a je třeba ho nahradit.
Mnoho lidí si myslí, že doslova vlastní Zemi, když si koupí kousek.
To není případ.
V Číně můžete pozemek pouze pronajmout.
Nejsou tak hloupí, aby prodávali navždy.
Vláda může tyto politiky kdykoli změnit.
Pozemek je dočasný.
Zdá se nepochopitelné, že vám jednoho dne může být odebrána půda, když sledujete australské a americké mediální kanály, ale to je proto, že tam bohatí jsou po celý den a ujistí se, že váš mozek myslí určitým způsobem.
Pozemek může vláda velmi snadno a rychle jednoho dne zabavit, pokud to bude chtít.
A víte co?
Nikdy nedávalo smysl, jak mohou lidé držet půdu na úkor ostatních.
Jednoho dne to musí být odstraněno.
Proto Číňané povolují pouze pronájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem investorům tam venku připíjím na váš úspěch a realizaci vašich snů.
Pokračujme společně v práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, si vážme jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm #geolog #podnikání #udržitelnost #úspěch #přátelství #přípitek #sny
Často se divím lidské schopnosti být *tak* tvrdý k sobě samému, zatímco je zavalený tolika důkazy toho, jak skutečná krutost vypadá.
Trápit se kvůli osobnímu selhání a výčitkám svědomí v světě, kde je "úspěch" tak často přiznáván lidem odpovědným za nejodsouzeníhodnější činy...
Všichni jsme takové nepořádné tvory.
Ale je důležité zmírnit zoufalství z našeho nepořádku - protože nám to dává více prostoru k řešení trosk kolem nás.
Tak se snažte nezapomenout, jo?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: "Rychlost psaní nezáleží!"
nebo "Modální editory jsou dnes k ničemu" :morty:
Já, jak vyjímám funkčnost z mých #Axum projektů do sdílených knihoven: "Drž mi klávesnici" :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, zda je to nejlepší přístup k sdílení, ale zatím se mi to líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Téma tohoto týdne na Revelations je Zůstaňte vzhůru celou noc.
Už několik dní si pohrávám s touto malou věcí na hlavě.
Je to rozhodně více romantika než špína.
Možná jsem četl příliš mnoho romancí s nemožnými 'setkáními roztomilých' a toto je výsledek, ale líbí se mi to.
Také jednoho dne určitě zkusím orgasmus ve výšce míle, možná ne s páskem
Nesouhlasím s tím, že #Mastodon je složitý na nastavení.
No tak, to opravdu není tak těžké.
Ale je těžší najít lidi, které budete sledovat a budovat svou časovou osu.
Přál bych si, aby zde byla nějaká doporučení "koho sledovat".
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany, jako je Elk a/nebo Ivory.
Pokud se držíte výchozího webového rozhraní, nevypadá to dobře a necítí se dobře (podle mého názoru).
Takže je potřeba trochu více úsilí se do toho dostat a pravděpodobně budete potřebovat dobrou aplikaci pro zlepšení #UX.
Nevím, zda je prevence možná, ale stojí za to to zkusit.
Čtyři kroky, které nastiňuji, jsou předmětem debaty, s určitým pokrokem v každém:
Popis: názvy pro incidenty chování člověk-algoritmus, které zohledňují algoritmy a lidi.
Vysvětlení: zohledněte obě strany vzájemného ovlivňování
Předpovídání: předvídání škod předtím, než se stanou (i když jen o minuty)
Zásahy: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých hranic jistoty.
Nesledoval jsem městské setkání na CNN, ale zdá se, že Trump řekl přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne tlačítko Odeslat na svém telefonu.
I když je neměl možnost říci během městského setkání, každý v Americe je stejně uslyší, opakovaně, mezi nyní a listopadem 2024.
To stále není důvod mu dát další prostor, ale škoda je přehnaná.
Vyhraje primárky.
Nemůžeme ho jen tak odkázat pryč.
Je tady a řekne tohle bez ohledu na cokoli.
Přihlásil jsem se na čekací listinu Googlu "AI Test Kitchen" a byl jsem přijat ten samý den.
V současné době je to velmi neuspokojivé.
"MusicLM Demo" je mírně zajímavé.
Můžete požádat o konkrétní kus hudby, jako je "jazz s trumpetovým sólem v tempu 5/4", a po několika sekundách vám vygeneruje dvě skladby.
Zdá se, že rozumí tempu, ale... hudba je prostě... ne dobrá.
Házet vše, co máte, přes plot jako reakci na GPT to není.
Snaž se více, Google.
Je divné dělat vzpírání, ale zároveň nemít skutečně tušení, jaký je váš maximální jednorázový výkon, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám v mém pokoji bez pozorovatele nebo dokonce bez stojanu na závaží.
Jen já a činka s hromadou závaží.
Dělám bench press na své posteli.
Pokud se pokusím zjistit, jaký je můj maximální jednorázový výkon, možná nebudu mít dostatek závaží na dosažení maxima, nebo by mě to naopak mohlo vážně zranit/zabít.
Každopádně, zatížení dnes stoupá.
Stále to cítím dobře.
Přísahám, že burrata před pěti lety neexistovala.
Toto je moje osobní Mandela efekt věc.
Nikdy jsem to v kuchařce neviděl.
Nikdy jsem to neviděl v luxusním obchodě s potravinami ani v žádných italských delikatesách.
Nikdy jsem neviděl, jak něčí matka to dělá, nebo mi to někdo na párty nacpal, nebo jsem to viděl v souvislosti s něčími dobrodružstvími v přípravě omáček nebo pečení.
Jednoho dne se to prostě objevilo a najednou to bylo dostupné všude.
Vstoupil jsem do dimenze burraty.
Drakeův stárnoucí iPad začíná selhávat, takže hledá nový tablet.
Poté, co jsme zde byli radikalizováni, jsme zdráhaví koupit nový stroj FAANG*.
Má někdo tablet s Linuxem, který miluje?
To by bylo hlavně pro prohlížení webu, občasné e-maily a některé hry.
V roce 1998-06 Gamefan, v souvislosti s dlouhým vývojem první hry Unreal, Jason Schrieber komentoval,
"Dobrá hra je zpožděná jen do doby, než je vydaná."
Špatná hra je navždy špatná."
Takže to bylo Epic, které toto vytvořilo?
Můžeme pokračovat.
Dřívější vydání GamePro 1997-11 obsahuje citát s mnohem větší nejednoznačností,
"Nebo, jak zní průmyslové rčení: Pozdní hra je pozdní jen do doby, než je dodána.
Špatná hra je špatná pro zbytek vašeho života."
Je to tedy tak pomíjivé?
Pouze "slogan" bez jasného původce?
Smoky, můj 10 měsíců starý samičí kotě Domácí Modré, si hraje s červeným gumovým Apple Pencil komfortním zařízením, které jsem koupil na Amazonu a on před měsíci zcizil.
Nese to pyšně v ústech po celém domě a já se musím jen v duchu smát.
Pokaždé, když ho to vidím dělat.
Nyní jsem absolvoval celou okružní cestu na novém vlaku ICNG.
Opravdu se mi to líbí.
Zvláště vozy s většími okny.
Existují oblasti, které by mohly využít nějakého vylepšení.
Konkrétně nedostatek odpadkových košů a nedostatek značek vysvětlujících význam barev osvětlení.
Opravte ty menší problémy a poté můžeme mít více těchto, prosím?
Nebudu smutný, když uvidím konec zásob ICM nebo DDZ.
Pravidla jednoho kusu na zákazníka zůstávají, protože se snažíme zajistit, aby každý, kdo se postaví do fronty, mohl dostat desku.
Můžete koupit JEDNU z výše uvedených desek, ne jednu z každé.
Neexistují žádná omezení pro nákup Picos nebo jiného zboží.
Včera jsem si užil nejlepší čas s mým přítelem a bývalým kolegou rabínem.
Navštívili jsme se na pár hodin na mé verandě.
Taková přátelství překonávají rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Pán vás žehnej a chrání!
A bažina se začíná zelenat.
Docela se mi líbí software akkoma a doménové jméno, které jsem získal pro mou instanci.
Ale mám pocit, že jsem tuto situaci nějak začal špatně, tak říkajíc.
A nikdy jsem se tam necítil pohodlně.
Budu zde ještě chvíli zdržovat a přemýšlet, zda bych měl vůbec migrovat.
#FalconHerníKnihy
Osmooké Repnidy se zdají sledovat, jak přistáváte s létajícím vozidlem na červené půdě, ale nepřibližují se k vám, ve skutečnosti jsou nehybné, když vystupujete z létajícího vozidla a pomalu se k nim blížíte.
Země pod vašimi nohama začíná třást a pak se třese, jako by bylo zemětřesení a vy ztrácíte pevný stůj, i když Repnidi se zdají být neovlivněni.
Skála pod vámi se náhle propadne.
Repnidi se prokopali pod povrch a vy padáte do vroucí hmoty stovek Repnidových těl v jeskyni níže.
Konec je rychlý, když několik párů tesáků vpichuje svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo nikdy nezjistí, že jste byl prvním lidským cestovatelem do budoucnosti.
Přistanete s letákem nosem vzhůru na straně škvárové haldy a vylezete ven.
Osmooké Repnidy se zdají sledovat, ale nepohybují se k vám, ve skutečnosti jsou nehybné, když se k nim pomalu blížíte.
Zastavíte, zatímco jste stále na kopečku rozpadlého kamene a půdy, a řeknete jim: 'Přicházím v míru, jako přítel.'
Zdá se, že vás nemohou slyšet, natož rozumět, protože váš univerzální překladač nezaznamenává žádnou odpověď.
Rozhodnete se využít své psychické vnímání k mentálnímu kontaktu s nimi.
Je těžké pochopit jejich myšlenky; jsou děsivě cizí a váš mozek se od kontaktu odráží.
Rozhodnete se, že navázání kontaktu znovu by bylo nebezpečné a vrátíte se k vašemu letáku, ale zážitek vám vyčistil mysl, která byla zmatená od chvíle, kdy jste skočili do budoucnosti.
Jakmile se vrátíte do Falcon's Wing, zjistíte, že je poměrně snadné naplánovat kurz pro Zemi v roce 3034 AD.
Všimněte si, že jste při skoku spotřebovali další tyč z molybdenu.
[pokračování]
#dnes mám kávu, slunce a klidný čas!
Začala jsem nový šál.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně předenou stříbrně šedou přízi, která je většinou jemně předená s hrudkami.
Plánuji to smíchat s jemnou fialovou/lila melírovanou bavlnou.
Ale nejsem si jistý, že mám dostatek fialové.
Používám háček H s podobným vzorem dvojitého háčkování, jaký jsem dělal předtím.
Včera večer jsem udělal první spojení, tak uvidíme.
Přeji všem šťastný čtvrtek!
Nicméně, nesnáším hodiny výtvarného umění a literatury, a můj školní výkaz to potvrzuje.
Doslova jsem vyzkoušel a zahodil KAŽDÝ JEDEN.
A až do před asi dvěma lety jsem o tom neměl ponětí, dokud jsem si neprohlédl své výpisy.
Nenávist v literární třídě je ještě horší: Miluji čtení.
Přečetl jsem většinu klasiků před osmnáctým rokem - i když to je spíše odraz toho, že jsem žil v zapadákově, z zoufalství jsem také přečetl Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a úžasný a jsem tam šťastný, ale musím být někde jinde, abych se mohl dostatečně uvolnit a číst beletrii během dne, aniž bych se cítil vinný.
Je to, jako bych byl na dovolené a proto dělám to, co se na dovolené dělá.
A to i přesto, že jsem zde poslední dvě noci nespal tak dobře jako doma a cítím se trochu vyčerpaný z #MECFS jen tím, že jsem v cizím prostředí, kde se hůře orientuji a musím si pamatovat, kde co je.
A to i přesto, že stále mám svůj seznam úkolů a také si organizuji svůj život.
Humanita vyjde za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které miluji na práci v herním průmyslu.
Co si o tom lidé budou myslet?
Líbí se mi to, ale bude schopné přilákat publikum správných hráčů?
Rozvine se kolem uživatelsky generovaného obsahu hry komunita?
(Opravdu doufám.)
Příběh hry, nápady a otázky, které inspiruje, se cítí aktuálně.
Doufám, že vše půjde dobře.
Je den ThinkPadu!!
Přišel jsem domů na obědovou přestávku a viděl jsem toto sedět venku uwu.
Chtěl bych to vzít zpět do práce, abych mohl nastavit více.
Ale to bude muset počkat až do večera.
Tak jsem konečně shlédla #Heartstopper
Bylo to příliš roztomilé až na hranici kýčovitosti?
Rozhodně
Mluví některé z těchto postav jako lidé?
Ani zdaleka
Ale miloval jsem to?
Absolutně!
Co tady dělala Olivia Coleman?
Dlužila někomu peníze?
Dnes večer si jeden nedávno absolvent umění špatně vzal kritiku.
Částečně, protože by byli špatně vyučováni.
Ale je důležité nevymlouvat se na problémy a prostě je řešit, zejména ve výrobě, když váš vedoucí potřebuje změny.
Obzvláště s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je zde k rychlému nápravě problému a není zaměřena na vaše schopnosti.
Předpokládá se, že máte schopnost problém vyřešit nebo najít řešení.
Takže kompostování a prohlížení květin jsou skvělou připomínkou, abychom se dívali nahoru a byli si vědomi života mimo obrazovku.
Je stejně důležité prozkoumávat servery a IP adresy.
Sledujte, jak jsou semena vysévána a pěstována (a ne náhodně rozptylována) dobrými lidmi.
Tyto kořeny jsou skryté.
Práce není viditelná.
Ale pro silný a pevný budoucí růst.
Jami mu podala poznámku, když se míjeli na cestě, těsně před hlídkou psa.
Byla na cestě k zdi, on končil službu.
Podíval se za sebe, aby ji sledoval, jak odchází, a aby se ujistil, že je neviděli.
Ona se neohlédla zpět.
Počkal, až bude v temnotě ložnice, než vytáhl poznámku a přečetl ji v paprsku světla procházejícího černými závěsy.
Jedno slovo tisknuté blokovým tiskem.
Dlouho na to zíral, snažil se zůstat klidný:
Nedávno jsem potkal několik úžasných nových kamarádů na #Mastodon a chci tento trend udržet.
Volání do #Fediverse mě nutí cítit se jako velryba, která zpívá v obrovském oceánu!
Chceš se připojit k mému "podu"?
Rád bych se spojil s více lidmi.
Každý, kdo má kvůli CNN vlasy na hlavě v plamenech, může poděkovat Stephenovi Colbertovi za tvrdý obrat doprava.
Pomohl udělat z Chrisa Lichta národní problém.
Bez ohledu na to, jak některé lidi můžeme mít rádi, pokud poskytují pouze kariéru ve druhé lize fašistům, pravděpodobně by to měli nosit na svědomí.
To bylo poprvé (ale ne naposledy), kdy Kaveesha Dilhari zaznamenala jak 20+ bodů, tak i 2+ wicketů ve stejném T20I zápase.
Připojuje se k vybrané skupině srílanských žen, kterým se podařilo dosáhnout tohoto všestranného úspěchu v tomto formátu.
Policie zatýká 15 lidí po násilné demonstraci před britským hotelovým zařízením pro uprchlíky.
Incident nastal po nárůstu počtu uprchlíků a žadatelů o azyl, kteří překračují Kanál do Velké Británie lodí.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem, který se používá k ubytování žadatelů o azyl, u anglického města Liverpool stala násilnou.
Oddělení Merseyside Police uvedlo, že policista a dva civilisté utrpěli menší zranění během nepokojů v pátek večer v Knowsley.
Policie uvedla, že někteří protestující házeli předměty a zapálili policejní dodávku.
Zatčené osoby, jejichž věk se pohyboval od 13 do 54 let, byly zadrženy "po násilných nepokojích."
Policejní komisařka z Merseyside Emily Spurrell řekla rozhlasu Radio City: "Bylo to nesmírně nebezpečné a mezi policejními důstojníky bylo několik zranění."
Podle místních médií používá Home Office hotel k dočasnému ubytování žadatelů o azyl již od minulého roku.
George Howarth, který zastupuje Knowsley v britském parlamentu, uvedl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou fanatiky a vítají lidi, kteří utíkají z některých z nejnebezpečnějších míst na světě v hledání bezpečného místa," řekl.
"Ti, kteří dnes večer na této demonstraci protestují proti uprchlíkům, nezastupují tuto komunitu."
Protest se konal v době zvýšeného napětí, kdy rostoucí počet uprchlíků a migrantů překračuje Kanál v malých lodích.
Více než 45 000 lidí dorazilo do Velké Británie touto cestou v roce 2022 a většina požádala o azyl.
Systém pro posuzování žádostí o azyl se kvůli politickým nepokojům a byrokratickým zpožděním téměř zastavil, což zanechalo mnoho žadatelů o azyl uvězněných v hotelech nebo jiných dočasných ubytováních.
Přejezdy kanálu se staly politickou otázkou, s tím, že konzervativní vláda slibuje "zastavit lodě" a usiluje o plán na odeslání takových žadatelů o azyl do Rwandy.
Oponenti obvinili vládu z démonizace zoufalých lidí, kteří utíkají před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v úvodním zápase sezóny na Brandywell.
Záložní hráč Derry Adam Reilly zavírá Lee Grace na Brandywellu.
Derry City vyšlo vítězně z President's Cup, když porazilo Shamrock Rovers 2:0.
Držitelé poháru FAI porazili vítěze minulé sezóny ligy na Brandywell díky gólům z prvního poločasu od Willa Patchinga a Michaela Duffyho.
Hoops se ve druhé půli snažili o snížení podmínek, ale tým Ruaidhriho Higginse pevně stál a vyhrál úvodní zápas.
Derry cestuje na zápas s týmem St. Patrick's Athletic pro úvodní zápas ligy příští pátek.
Patchingův volej posunul Derry do vedení po 23 minutách - záložník otevřel skóre, když Foylesider's vyhráli 2-1 nad budoucími šampiony minulého února.
Hoops pokračovali vítězstvím v Premier Division o 13 bodů, ale Duffy brzy posunul City dále vpřed s dlouhým pokusem, který se podařilo protlačit pod brankářem Leonem Pohlem a do sítě.
Loňští finalisté vedli o dvě branky v poločase.
Graham Burke se v druhém poločase nejvíce přiblížil snížení náskoku, ale Candystripes byli pohodlnými vítězi týden před svým úsilím o národní slávu.
Městský šéf Ruaidhri Higgins chválil svůj tým po tom, co označil za "nejtěžší týden mého života" po smrti svého bratra Kevina.
"Je to rána do zubů a čekají nás těžké týdny, ale půjdeme dál na jeho památku," řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě tak s dobrým výkonem je opravdu potěšující."
DHS najímá právnickou firmu k řešení možného impeachmentu Alejandro Mayorkase.
Ministerstvo vnitřní bezpečnosti si najalo externí právnickou firmu - Debevoise & Plimpton - aby pomohla v případném řízení o odvolání tajemníka Alejandra Mayorkase, který čelí možným obviněním od republikánů v Sněmovně reprezentantů ohledně jeho zvládání jižní hranice.
"Ministerstvo vnitřní bezpečnosti si najalo externího právního zástupce, aby zajistilo, že klíčové poslání ministerstva nebude přerušeno bezprecedentními, neopodstatněnými a stranickými snahami o impeachment ze strany některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl v pátečním prohlášení mluvčí DHS.
"DHS bude nadále prioritizovat svou práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečovat naše hranice, zatímco adekvátně reaguje na více než 70 kongresových výborů a podvýborů, které dohlížejí na DHS."
Úředník DHS řekl CBS News, že oddělení najalo firmu pro smluvní práce po dobu trvání kongresového vyšetřování.
Debevoise bylo vybráno kvůli své odbornosti na impeachment a dvojstranné zkušenosti s prací s Kongresem na dohledu.
Ministr pro vnitřní bezpečnost Alejandro Mayorkas hovoří během společné tiskové konference s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno doporučilo, že smlouva s Debevoise je vhodnou výdajovou položkou pro DHS.
DHS se snaží zajistit, aby jeho mise nebyla narušena stranickými útoky a aby řízení proti Mayorkasovi byla řešena lidmi s příslušnou odborností.
Mayorkas se k tomuto vývoji nevyjádřil, ale když byl v minulý čtvrtek tázán na vyšetřování impeachmentu, řekl novinářům: "Budeme spolupracovat s tímto Kongresem, stejně jako jsme to udělali s posledním Kongresem. Myslím, že to je naše odpovědnost."
Uznal, že "bude trvat čas", než se vyhoví vyšetřování Sněmovny.
"Strávím ten čas tak jako ostatní a také nebudeme kompromitovat čas, který věnujeme plnění naší mise."
Vysoký úředník DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím právním zástupcem.
Pouze jeden člen vlády byl kdy impeachován, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl senátem zproštěn obvinění.
Trendující zprávy
Děkujeme za čtení CBS NEWS.
Čtyři mladiství obviněni z útoku na 14letého, který spáchal sebevraždu poté, co bylo video z bití zveřejněno online.
Otec tvrdí, že jeho dcera spáchala sebevraždu po šikaně na škole v NJ.
Otec tvrdí, že jeho dcera spáchala sebevraždu po šikaně na škole v NJ 02:33
Čtyři mladiství z New Jersey byli obviněni v souvislosti s útokem na 14letou dívku, která si později vzala vlastní život poté, co bylo video z incidentu zveřejněno na sociálních médiích.
Jedno nezletilé je obviněno z těžkého ublížení na zdraví, dva nezletilí jsou obviněni z pokusu o spáchání těžkého ublížení na zdraví a jedno nezletilé je obviněno z obtěžování, sdělil prokurátor Ocean County Bradley D. Billhimer CBS News v e-mailu.
Adriana Kuch, 14 let, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video útoku na střední škole Central Regional.
Video ukázalo dívky, které hodily nápoj na dospívající, poté ji kopaly a táhly po školních chodbách.
Strčili Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžovém tričku opakovaně udeřila Kuch.
Další dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli, aby přerušili útok, přičemž jeden dospělý roztáhl dospívající.
Adriana ležela zraněná a podlitá na podlaze chodby, zatímco dospělý se ji snažil zvednout.
Jedna z dívek řekla: "To je to, co dostaneš."
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali," řekl v čtvrtek její otec, Michael Kuch, stanici CBS New York a dodal, že je naštvaný a chce, aby všichni viděli video a co dospívající udělali jeho dceři.
14letá Adriana Kuch spáchala sebevraždu poté, co bylo na internetu zveřejněno znepokojující video, na kterém je napadena ve škole. CBS2
Kuch řekl, že policie měla být zavolána okamžitě, protože studenti, se kterými měla jeho dcera problémy, jí rozbili obličej 20uncovou lahví.
"Kdyby zavolali policii a provedli vyšetření, ty dívky by nezveřejnily videa ze školy," řekl Kuch.
Také řekl, že jeho dcera, která měla na těle modřiny, měla být odvezena do nemocnice.
"Vždy se zabýváme každým případem šikany a v den incidentu byli čtyři studenti suspendováni," řekl Dr. Triantafillos Parlapanides, ředitel škol, CBS New York.
Školní úředníci informovali CBS New York, že rodinu informovali a označili Adriáninu smrt za hroznou.
Každý dospívající a jejich zákonný zástupce obdrželi kopii jejich stížnosti a byli propuštěni do budoucího soudního řízení, jak sdělil státní zástupce CBS News.
Studenti na škole ve středu uspořádali stávku na podporu Adriany rodiny.
Pokud jste vy nebo někdo, koho znáte, v emoční tísni nebo v sebevražedné krizi, můžete se obrátit na linku pro krizovou pomoc a prevenci sebevraždy 988 voláním nebo posláním textové zprávy na 988.
Můžete také chatovat s linkou pro krizovou pomoc a prevenci sebevraždy 988 zde.
Pro více informací o zdrojích a podpoře péče o duševní zdraví můžete kontaktovat linku pomoci Národní aliance pro duševní nemoci (NAMI) od pondělí do pátku, od 10:00 do 22:00.
ET, na 1-800-950-NAMI (6264) nebo email info@nami.org.
Hovořil jsem s 30 odborníky na zdraví a wellness o tom, jak se vyhnout vyhoření.
Ve svém každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v naší práci.
To může být extrémně obtížné pro ty, kteří pracují ve zdravotnictví, a proto jsem položil 30 odborníkům na zdraví a wellness stejnou otázku: "Jak zvládáte svou energii a nevyhoříte ve své profesi?"
Jejich kariéry sahají od lékařů specializujících se na infekční nemoci po psychology a učitele mindfulness - a všichni měli skvělé rady, jak zůstat motivovaní a udržet balón v pohybu.
Navzdory velkým rozdílům v jejich rolích, v jejich odpovědích se vynořilo několik témat jako způsoby, jak předcházet vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
Vytvořte silnou komunitu
Jako někdo, kdo pracuje s pacienty s terminálními nemocemi, Eufrosina Young děkuje své silné podpoře za schopnost udržovat svou energii.
Young je certifikovaný neurolog a specialista na ALS v oddělení neurologie nemocnice Upstate University a říká, že tam "mobilizují jako armádu lidí".
Není lék na amyotrofickou laterální sklerózu (ALS), ale vědomí, že není jediná, kdo tvrdě pracuje na vývoji léčebných postupů a poskytuje lepší možnosti pro své pacienty, udržuje Young v chodu i v jejích nejtěžších dnech.
"Neuneseme váhu světa, ale jsme součástí světa lidí, kteří se zasazují o tuto práci," říká.
Odpočívejte, když to potřebujete.
Práce na dvou pracovních místech jako výzkumník spánku a inženýr algoritmů, a to vše při péči o novorozence, by určitě vedlo Raphaela Vallata k vyhoření, pokud by si neodpočinul, říká.
"Cítím, že když jsem na pokraji vyhoření, prakticky každý úkol se mi jeví jako hora, kterou musím vylézt, a působí super naléhavě a důležitě," říká Vallat.
V těchto chvílích "si opravdu musíte vzít nějaký volný čas a uvědomit si, že tyto úkoly mohou počkat."
Typicky si Vallat najde chvíle během dne, kdy se může zastavit a strávit čas v přírodě, aby se uklidnil před návratem do práce.
Buďte nadšeni z toho, co děláte a pamatujte na svůj účel.
Až do jara 2022 pracovala specialistka na infekční nemoci Céline Gounder 100 hodin týdně sedm dní v týdnu.
Být na frontové linii během pandemie jí zabralo téměř veškerý čas, ale vyhnula se vyhoření tím, že si připomínala, proč je její práce důležitá.
"Myslím, že práce nepřipadá jako práce, když máte pocit, že máte dopad," říká Gounder.
"Pokud pracujete šílené hodiny na něčem, co pro vás nemá žádný význam, myslím, že byste se opravdu měli zastavit a zamyslet se nad tím, co děláte."
Mít jiné radosti
Všichni odborníci jednoznačně uvedli, že se věnují nějakému koníčku, jako je cvičení, tanec nebo dokonce hraní na kytaru.
Je nesmírně důležité mít život, který si užíváte a který přesahuje to, co dokážete ve své práci, říká Christina Maslach, sociální psycholožka, emeritní profesorka psychologie na U.C. Berkeley a autorka knihy "The Burnout Challenge: Managing People's Relationships with Their Jobs."
"Přehlédněte svůj život jako celek, ujistěte se, že v něm jsou dobré věci, a ujistěte se, že na ně máte čas."
Získejte zdarma průvodce investováním od Warrena Buffetta od CNBC, který shrnuje nejlepší radu miliardáře pro běžné investory, co dělat a nedělat, a tři klíčové investiční principy do jasného a jednoduchého průvodce.
Přihlaste se nyní: Získejte lepší přehled o svých financích a kariéře s naším týdenním newsletterem
Nezletilý obviněn z vraždy při prosincové střelbě ve škole v Chicagu, která si vyžádala 2 mrtvé.
Šestnáctiletý chlapec byl obviněn z vraždy dvou studentů na chicagské střední škole v prosinci, oznámila v pátek policie.
Obviněný je obviněn ze dvou případů trestného činu vraždy v prvním stupni a dvou případů pokusu o vraždu, oznámil náčelník chicagské policie David Brown.
"Aktuálně nemáme jasný motiv, proč by šestnáctiletý chtěl střílet a zabíjet další děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown uvedl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageri byli postřeleni 16. prosince na střední škole Benito Juarez.
Oběti, které zemřely, byli chlapci ve věku 14 a 15 let, jak tehdy oznámila policie.
Vyšetřovatelé říkají, že tipy od veřejnosti jim pomohly najít podezřelého, který byl zatčen ve čtvrtek.
"Jsme vděční těm, kteří měli odvahu přijít a zajistit, že pachatel bude dopaden a nyní bude následně zodpovědný," řekla státní zástupkyně okresu Cook Kim Foxx.
Očekává se, že podezřelý se v sobotu objeví u soudu pro vazbu, řekl Brown, kde budou prezentovány další detaily o shromážděných důkazech.
Biologové z Minnesoty zachránili uvězněného černého medvěda.
Minnesotské oddělení přírodních zdrojů přišlo na pomoc velmi smolnému medvědovi, který uvízl v příkopu.
Medvěd se uchýlil do koryta podél silnice poblíž Wannaska, Minnesota, podle příspěvku na Facebooku od oddělení.
Ale když začal sníh tát, potrubí začalo zaplavovat, což uvěznilo medvěda v hlubokém sněhu a ledu, podle úřadu.
Personál z oddělení rychle reagoval na místo a pomohl odstranit medvěda.
Biolog oddělení pro medvědy, Andrew Tri, "prohlédl medvěda a prohlásil ho za zdravého, ale ospalého - samozřejmě, protože byl probuzen ze svého zimního spánku," podle příspěvku na Facebooku.
Oddělení poté přemístilo medvěda do státní rezervace, aby pokračoval v hibernaci.
Odhaduje se, že ospalý masožravec byl starý 6 let a vážil mezi 375 a 400 liber.
Oddělení připomnělo obyvatelům, že přesun medvědů je práce nejlépe ponechána profesionálům.
Pokud se obáváte medvěda ve své čtvrti, měli byste kontaktovat místní úřady - ne se pokoušet přesunout nebo krmit tohoto spícího obra.
V tomto případě se náhodní kolemjdoucí nejprve pokusili vykopat medvěda sami a nabídli mu jídlo, včetně Pop-Tarts, salátu a kočičího jídla Fancy Feast.
Ale naštěstí pro dobře míněné kopáče, "protože medvědi v zimě nemají chuť k jídlu, medvěd nekousl."
Minnesota je domovem pro 12 000 až 15 000 černých medvědů, kteří se nacházejí hlavně v severní třetině státu, podle Ministerstva přírodních zdrojů.
Predátoři hibernují až šest nebo sedm měsíců v zimě, během kterého nejedí a žijí z uloženého tělesného tuku.
Fotografie: Po rekonstrukcích Egypt slavnostně otevřel hrobky Djehuty a Hery
Hrobky Djehutyho a Heryho byly ve čtvrtek slavnostně otevřeny po dokončení restaurátorských prací.
Otevření provedl generální tajemník Nejvyšší rady pro starožitnosti v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a prezidentka Španělské národní výzkumné rady (CSIC), Eloísa del Pino.
Waziri vysvětlil, že oba hroby byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise od Nejvyšší rady pro starožitnosti a CSIC, která pracuje od roku 2002.
Řekl, že mise prováděla vykopávky a restaurační práce a publikovala výzkum související s hrobkami, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podarilo se jim odhalit mnoho hrobů, rakví, mumii a pohřební zahradu.
Důležité hroby z důležité éry
Wazir vysvětlil, že tyto dva hroby patří významným osobnostem, které žily na začátku 18. dynastie Nové říše - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že uspořádání hrobek je ve tvaru T, styl běžně používaný v hrobkách z 18. dynastie.
Tyto se skládají z vstupu, sloupové haly vedoucí k pohřební šachtě a zdí s výraznými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a dohlížel na práce řemeslníků a umělců během vlády královny Hatšepsut.
Djehuty byl také zodpovědný za zaznamenání Hatshepsutovy cesty do Puntlandu a za poskytnutí elektro (směsi zlata a stříbra) pro pokrytí vrcholu obelisků, které umístila v chrámech Karnak.
Navíc měl na starosti proces přesunu obelisků.
Místnost, která předchází pohřební komoře Djehuty, obsahuje nápisy vyryté s 43 kapitolami Knihy mrtvých, poprvé byly kapitoly této knihy napsány na stěnách hrobek předtím, než byly napsány na plátně a papyru.
Hery, zastával pozici správce královských skladů svaté královské manželky a matky, Ahhotep.
Rachel Reevesová tvrdí, že Jared O'Mara by nikdy neměl být kandidátem Labouristické strany.
Bývalý poslanec Jared O'Mara, který byl zneuctěn, "nikdy neměl být vybrán jako kandidát Labouristické strany" a zaslouží si svůj čtyřletý trest odnětí svobody, řekl stínový kancléř.
Rachel Reeves mluvila s Guardianem v obvodu Bolton North East v pátek, několik hodin poté, co klíčové postavy místní strany rezignovaly na protest proti tomu, jak národní výkonný výbor Labouru (NEC) ovládá výběrový proces pro příští parlamentní volby.
Celý výběrový výbor v Bolton North East rezignoval poté, co jim nebylo dovoleno vybrat užší výběr, což je stále častější praxe v Labouristické straně Keira Starmera, a řekl: "Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, namísto místních členů na severu."
Dodali: "To je v rozporu s postojem, který je nutný k získání zpět červené zdi, což je tak zoufale potřeba k dosažení vlády Labouristické strany."
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Byla zvláštní nespokojenost s tím, že Leigh Drennan, předseda Labour North West a asistentka poslankyně za Warrington North, která podporuje Jeremyho Corbyna, Charlotte Nichols, nebyla zařazena na dlouhý seznam kandidátů, kteří se pokusí získat mandát zpět od konzervativců, přestože získal nominace od čtyř velkých odborových svazů.
Reevesová řekla, že neměla nic společného s výběrem kandidátů, ale dodala: "Vím, že je opravdu důležité, abychom měli důkladné procesy pro to, kdo může být zařazen na dlouhý seznam a kdo může být zařazen na krátký seznam."
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že podal falešné náklady v celkové výši 52 000 liber v pokusu financovat svou závislost na kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl řádně prověřen Labour Party, když byl vybrán k boji proti Nicku Cleggu, bývalému náměstkovi premiéra za Liberal Democrats, v Sheffield Hallam v předčasných parlamentních volbách v roce 2017.
Na otázku, zda se v myslich členů výkonného výboru Labouru vynořuje debakl s O'Marou, Reeves řekl: "Nechci nijak naznačovat, že kdokoli, kdo není na užším seznamu, je uživatel kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy by neměl být vybrán jako kandidát Labour; nikdy by neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest."
Okolnosti O'Mary byly "docela výjimečné," řekla Reeves, ale uznala: "Pro Labouristickou stranu a všechny politické strany jsou zde důležité lekce týkající se výběru kandidátů.
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého narušování standardů v politice, nejméně od řady premiérů a pokut a stran a standardů, které značně zaostávají za tím, co byste mohli očekávat."
Dodala: "Jednu věc bych řekla o Labouristické straně, když lidé udělají něco špatně, ztratí podporu. A to prostě není případ Konzervativní strany."
Archie Bland a Nimo Omer vás provedou hlavními příběhy a jejich významem, zdarma každé všední ráno.
Oznámení o ochraně soukromí: Newslettery mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Pro více informací si prosím přečtěte naše Zásady ochrany osobních údajů.
Používáme Google reCaptcha k ochraně naší webové stránky a platí Zásady ochrany osobních údajů a Podmínky služby Google.
Reeves byl v Boltonu, aby se setkal s učni na výcvikovém středisku pro Openreach, který poskytuje širokopásmovou síť ve Velké Británii.
Po sledování učňů, jak vylezají na předstírané telegrafní sloupy na místě za 1,7 milionu liber, Reeves diskutoval o plánech Labouru na přepracování daně z učňovských míst, která nutí větší firmy odkládat 0,5% své mzdové listiny na financování učňů.
Podniky si stěžují, že daně jsou příliš nepružné. Například Reeves uvedl, že Openreach "chce přeškolit lidi, kteří pracují s mědí, aby pracovali s vláknem, ale daňový poplatek na učňovské vzdělávání nemá takovou pružnost ohledně přeškolování."
Reeves uvedl, že Labour by změnil daně tak, aby firmy mohly použít peníze na přeškolení zaměstnanců v odvětvích jako je automobilový průmysl a ti, kteří v současnosti instalují plynové kotle.
"Potřebujeme je jako součást přechodu na energetickou nulu, aby se učili dovednostem potřebným pro práci na elektrických vozidlech nebo instalaci tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tyto osoby byly přeškoleny, aby získaly dovednosti, které potřebují k úspěchu.
A přesto je daň z učňovského výcviku proti nim nastavena.
Podniky chtějí větší flexibilitu a mladí lidé, kteří začínají v životě, nebo starší lidé, kteří se chtějí přeškolit, aby se ujistili, že jejich dovednosti budou v budoucnosti relevantní," řekl Reeves.
Jedna osoba zatčena během protestu v Tate Britain proti dětské akci s drag queen.
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala vyprávěcí akce pro děti s drag queen.
Metropolitní policie uvedla, že jedna osoba byla zatčena na základě podezření z rasově motivovaného komentáře vůči policistovi u umělecké galerie poblíž Westminsteru.
Nebyla nahlášena žádná zranění a policisté zůstávají na místě, uvedla policie.
Tate v sobotu hostilo Drag Queen Story Hour UK, kde příběhy vyprávěla Aida H Dee, kterou webové stránky galerie popisují jako "první drag umělce v Evropě, který čte příběhy dětem v mateřské škole."
Pravicová skupina protestujících demonstrovala před galerií a byla potkána protiprotestujícími vedenými aktivisty za práva trans lidí a politickými skupinami, včetně Stand Up to Racism.
Důstojníci museli vytvořit koridor, aby účastníci mohli vstoupit do prostoru akce.
Na Twitteru napsala drag queen, že den byl "pořádně emotivní", a dodala, že pět protestujících se dostalo do Tate a "způsobilo nepokoje" v některých částech budovy, ale neovlivnili čtení.
Dříve řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ+ byla "ctí".
Její čtení bylo v minulosti cílem protestů.
Drag Queen uvedla, že předtím proběhla "hodnocení rizik", ale dodala, že je "směšné", že byla nutná.
Aida tweetla: "5 nenávistníků se dostalo do Tate. Způsobili nepokoj. ALE ne u Drag Story Hour UK ... Dělali povyk jinde v budově, ne tam, kde byla show!! SHOW 2 proběhla hladce!!!"
Aida pořádala tři seance vyprávění příběhů v sobotu v 11:00, v poledne a ve 14:00.
Mluvčí Tate uvedl: "Neplánujeme umělce, aby propagovali konkrétní názory, ani aby smiřovali rozdílné názory."
Naše galerie nabízí široký program a návštěvníci mají svobodu vybrat si, s jakými aspekty se zapojí."
Trumpova ceněná budova na 40 Wall Street je na 'pozoru věřitelů' kvůli klesajícím příjmům: Zpráva
Silně zajištěný mrakodrap Donalda Trumpa na adrese Wall Street 40 je podle páteční zprávy Bloombergu na "hlídce věřitelů" kvůli klesajícím příjmům a rostoucím nákladům.
Míra neobsazenosti v 72patrové budově - nejcennější Trumpově - skočila téměř na 18% ve třetím čtvrtletí minulého roku, podle měsíční zprávy o zbývající hypotéce na budovu ve výši 126,5 milionu dolarů, jak uvedl Bloomberg.
Náklady se mezitím údajně zvýšily o 11% od počátku hypotéky z roku 2015.
Trump často chlubil budovou, kterou získal v roce 1995, a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků 11. září 2001, které zničily Světové obchodní centrum a zabily 3 000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street je náhle nejvyšší budovou ve městě.
Nejenže bylo jeho tvrzení necitlivé, ale také to byla lež.
Další nedaleký mrakodrap na Pine Street v Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem kanceláří v mrakodrapech na Manhattanu klesá již několik let, což se po vypuknutí pandemie COVID-19 ještě zhoršilo, když mnoho firem zastavilo svou činnost a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, "kontaktovala dlužníka ohledně stavu pronájmu" a plánů na zlepšení výkonnosti nemovitosti, podle podání, jak uvedl Bloomberg.
Majitel Wagnera tvrdí, že válka na Ukrajině potrvá ještě několik let.
Majitel ruské soukromé vojenské společnosti Wagner Group, která je aktivně zapojena do bojů na Ukrajině, předpovídá, že válka by mohla trvat roky.
Jevgenij Prigožin uvedl v video rozhovoru zveřejněném v pozdní pátek, že by mohlo trvat 18 měsíců až dva roky, než Rusko plně zabezpečí kontrolu nad průmyslovým srdcem východní Ukrajiny, Donbasem.
Dodává, že pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr, mohla by válka trvat tři roky.
Prohlášení od Prigozhina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinův kuchař" kvůli svým lukrativním smlouvám na stravování v Kremlu, představuje uznání obtíží, kterým se Kreml v kampani musel čelit, kterou původně očekával, že ukončí během několika týdnů, když ruské vojsko 24. února napadlo Ukrajinu.
Rusko utrpělo řadu ponižujících neúspěchů na podzim, kdy ukrajinská armáda úspěšně zahájila protiofenzívy na znovuzískání rozsáhlých území na východě a na jihu.
Kreml se vyhnul předpovědím, jak dlouho by mohly boje pokračovat, a uvedl, že to, co nazval "speciální vojenskou operací", bude pokračovat, dokud nebudou splněny její cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Donetsk, které tvoří region Donbas, kde moskevští separatisté podporovaní Moskvou bojují s ukrajinskými silami od roku 2014.
Prigozhin uvedl, že najemníci skupiny Wagner pokračují v prudkých bojích o kontrolu ukrajinské pevnosti Bakhmut v Doněckém regionu.
Uznal, že ukrajinské jednotky klade prudký odpor.
Jakožto ruské jednotky intenzivně útočí v Donbasu, Moskva se také snaží demoralizovat Ukrajince tím, že je nechává bez tepla a vody v průběhu kruté zimy.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další klíčovou infrastrukturu.
Vysokonapěťová infrastruktura byla zasažena ve východních, západních a jižních oblastech, což vedlo k výpadkům proudu v některých oblastech.
Ukrajinská energetická společnost, Ukrenergo, v sobotu uvedla, že situace je "složitá, ale kontrolovatelná", přičemž dodala, že zapojila zálohy pro udržení dodávek energie, ale upozornila, že v některých oblastech bude pokračovat omezení dodávek energie.
Vojenský náčelník Ukrajiny, generál Valerii Zaluzhnyi, uvedl, že ruské síly vypustily mezi pozdním čtvrtkem a pátečním polednem 71 střel s plochou dráhou letu, 35 raket S-300 a sedm dronů Shahed. Přidal, že ukrajinské protiletadlové obrany sestřelily 61 střel s plochou dráhou letu a pět dronů.
Ukrajinské úřady následně v pátek nahlásily další útoky vražedných dronů.
Ukrajinské letectvo uvedlo, že vojenské síly sestřelily 20 dronů Shahed večer.
Pozdě v pátek ruské vojenské blogy a některé ukrajinské zpravodajské kanály zveřejnily video ukazující útok mořské drony na strategický železniční most v Odeské oblasti.
Zrnitý videozáznam ukazoval rychle se pohybující objekt, který se blížil k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a explodoval v silném výbuchu.
Autenticita videa nemohla být ověřena.
Ukrajinské vojenské vedení nekomentovalo útok a Serhii Bratchuk, mluvčí regionální správy, v sobotu v televizních poznámkách nepotvrdil útok dronem.
Most, který byl na začátku války cílem ruských raketových útoků, slouží jako železniční spojení s Rumunskem, které je klíčovou cestou pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři v Turecku vytáhli 7 přeživších a těla 19 zemřelých: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazachstánské záchranné týmy pokračují v prohledávání trosk v Turecku na hledání přeživších, uvádí tisková služba ministerstva pro mimořádné situace Kazachstánu.
Práce záchranářů je ztížena velkým množstvím sutin a nestabilními konstrukcemi.
K dnešnímu dni vytáhl kazašský záchranný tým ze zemětřesení sedm přeživších a těla 19 lidí, včetně jednoho dítěte, v Turecku.
První lékařská pomoc je také poskytována nepřetržitě.
Zvláště významné bylo zemětřesení o síle 7,7, které v pondělí ráno zasáhlo jihovýchodní část Turecka a severní Sýrii.
Od dnešního dne přesáhl počet mrtvých z masivních zemětřesení na jihovýchodě Turecka 20 000.
Fotografie: t.me/qr_tjm
Asijské šampionáty mají podpořit další rozvoj atletiky.
ASTANA.KAZINFORM - Otevírací ceremoniál 10. Asijských halových atletických šampionátů se konal v pátek ve sportovním centru Qazaqstan v Astaně.
Události se zúčastnil kazašský premiér Alikhan Smailov, uvádí tisková služba kazašského premiéra, cituje Kazinform.
Otevření akce, šéf kazašské vlády přečetl uvítací dopis prezidenta Kassym-Jomarta Tokayeva.
"Sport nezná hranice.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro provozování profesionálního a masového sportu.
Velký důraz je kladen na rozvoj sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex s kapacitou přes šest tisíc lidí," stojí v dopise kazašského prezidenta.
Kazašští sportovci úspěšně soutěží a reprezentují Kazachstán na hlavních světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokayev.
Vyjádřil důvěru, že konání Asijských šampionátů v Astaně dá nový impuls k rozvoji atletiky v zemi, a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil speciální poděkování prezidentovi Asijské atletické asociace Dahlanovi al-Hamadovi za jeho pomoc při přípravě a konání mistrovství.
Asijské halové atletické mistrovství se koná poprvé na území SNS.
Turnaj přilákal více než 500 sportovců z 31 zemí, kteří soutěží v běhu, štafetě, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí a všestranné soutěži.
Turnaj proběhne až do 12. února.
Dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkirui vyhrála zlatou medaili v ženských 3 000 m a Olga Safronova získala stříbrnou medaili v ženských 60 m na turnaji.
Foto: primeminister.kz
Herečka z 'Yellowstone' Q'orianka Kilcher obhájila obvinění z podvodu.
Právník Camille Vasquez, který zastupoval Johnnyho Deppa v loňském soudním procesu o pomluvu, dosáhl dalšího právního vítězství - tentokrát s hercem z "Yellowstone" Q'oriankou Kilcherem.
V pátek kancelář okresního státního zástupce v Los Angeles County zprostila Kilchera, 32, všech obvinění v případě podvodu na dávkách pro pracovníky.
Ve prohlášení sdíleném v pátek s The Times, mluvčí okresního státního zástupce Los Angeles County uvedl, že soud "rozhodl, že paní Kilcherová nespáchala pojistný podvod a informoval soud, že nemůžeme pokračovat."
V červenci 2022 obvinili kalifornští úředníci Kilcherovou ze dvou trestných činů podvodu v oblasti pracovního pojištění, když ji obvinili z nelegálního pobírání více než 96 000 dolarů na invalidních dávkách mezi říjnem 2019 a zářím 2021.
Časový rámec zahrnuje také několik měsíců, kdy Kilcher pracovala na "Yellowstone", přestože herečka tvrdila, že byla příliš zraněná na to, aby mohla pracovat.
Kilcher se sám vydal a byl obžalován v květnu.
"Dnes jsem nesmírně vděčný, že můj případ byl zamítnut - zítra začíná moje cesta k tomu, abych pomohl zvyšovat povědomí a požadoval větší transparentnost práv pracovníků v rámci systému pracovního pojištění," řekl Kilcher v pátek ve prohlášení sdíleném s Times.
Dodala, že se "těší na to, že na tuto zkušenost vrhne více světla a bude pokračovat v práci, kterou miluje."
Kilcher také poděkoval Vasquezovi a jeho kolegyni z právní kanceláře Brown Rudnick, Steve Cookovi, za "jejich neochvějnou víru v mou nevinu."
Podle TMZ, Kilcher najal tyto dva v září.
Kilcher se proslavila filmem Terrence Malicka z roku 2002 "Nový svět", kde ztvárnila Pocahontas.
Mezi její úspěchy patří také "Sons of Anarchy," "The Alienist" a "Dora a Ztracené město zlata."
Naposledy se objevila ve filmu o cestování "Dog," kde hraje hlavní roli Channing Tatum.
K tomuto reportu přispěla Christina Martinez, redaktorka Times.
Šéf Balenciaga označuje vánoční kampaň za 'hloupou chybu'
Luxusní oděvní značka Balenciaga se stále vzpamatovává z negativních reakcí na dvě své nedávné reklamní kampaně.
Měsíce poté, co módní dům čelil kritice za propagační obrázky, které podle kritiků sexualizovaly děti, řekl umělecký ředitel Balenciaga Demna (celým jménem Demna Gvasalia) v rozhovoru pro Vogue zveřejněném v pátek, že mu za tyto obrázky stále ještě líto.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro dárcovskou kampaň s dětmi a přijímám za to odpovědnost," řekl Vogue, což odráží předchozí prohlášení, které v prosinci zveřejnil na sociálních médiích.
V listopadu značka sdílela fotky ze své kolekce "The Gift", na kterých dětské modelky pózovaly s plyšovými medvídky oblečenými v bondážním oblečení.
Krátce poté zveřejnila značka Balenciaga fotografie ze své kampaně na jaro 2023, na nichž byla v pozadí stránka z případu Nejvyššího soudu z roku 2008 týkajícího se "virtuální dětské pornografie".
Rodiče, včetně reality TV hvězdy a dlouholeté fanynky Balenciaga - a značkové partnerky - Kim Kardashian, se na sociálních médiích ohradili proti značce a jejím "znepokojivým obrázkům".
Několik dní poté vydala společnost Balenciaga prohlášení, ve kterém se omluvila za fotografie a nastínila změny, které provede, aby se v budoucnu vyhnula podobným "chybám".
"Tato zkušenost mě donutila přehodnotit mnoho věcí v tom, jak já, my, pracujeme, jak tvoříme a komunikujeme obrázky, jak interagujeme s našimi diváky a jak se učíme z našich chyb a jdeme dál," řekl Demna Vogue.
Podrobně popsal změny po zpětné vazbě v Balenciaga: "restrukturalizace oddělení pro obraz", provádění více interních a externích kontrol pro kampaňové obrázky a partnerství s National Children's Alliance, aby pomohl "tisícům dětí v procesu překonávání traumatu a řešení jejich duševního zdraví."
"Je to jediná věc, která mě dělá šťastným v této celé hrozné situaci: udělat z toho něco dobrého," řekl o tomto partnerství, které bylo oznámeno ve středu.
S NCA se také spojuje mateřská společnost Balenciaga, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod značkou Kering je Gucci, které čelilo v prosinci kritice za kampaň s Harrym Stylesem, kterou někteří kritici na sociálních médiích obvinili z sexualizace dětí.
V rozhovoru Denma uvedl, že plánuje se od značky "provokativních" způsobů odstěhovat.
"Toto je součástí mého učení: ke všemu, co vypustím jako myšlenku nebo obraz, budu mít zralejší a vážnější přístup," řekl.
"Rozhodl jsem se vrátit ke svým kořenům v módním průmyslu, stejně jako ke kořenům Balenciaga, což znamená vyrábět kvalitní oblečení - nevytvářet obraz nebo buzz."
Mluvě o původu značky, Demna v rozhovoru uvedl, že jednou z nejbolestivějších částí zpětné vazby bylo pošpinění "jména Balenciaga a odkazu Cristóbala Balenciagy."
"Balenciaga je značka, která je starší než sto let a je založena na silných a krásných kreativních hodnotách, a já jsem udělal vše, co bylo v mých kreativních silách, abych ji přivedl k její moderní relevanci, a najednou jsme byli napadeni a označeni za něco, čím vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s dárcovskou kampaní a určitě jsme se z toho poučili."
Je to falešná zpráva, CBN vyvrací tvrzení, že nemá kapacitu tisknout více nových nair.
Centrální banka Nigérie (CBN) označila za zavádějící zprávu, která údajně cituje guvernéra CBN, pana Godwina Emefieleho, že současnou výzvu v distribuci nově přepracovaných bankovek Naira připisuje nedostatku tiskových materiálů v nigerijské společnosti pro tisk a ražbu bezpečnostních tiskovin Plc.
Ve prohlášení vydaném v sobotu řekl mluvčí CBN, Osita Nwasinobi, že guvernér CBN v žádném okamžiku během své prezentace pro Národní radu státu na jejím zasedání v pátek 10. února 2023 takové prohlášení neučinil.
Pan Nwasinobi řekl, že Emefiele na schůzce pouze oznámil, že NSPMC pracuje na tisku všech denominací Nairy, aby vyhověla transakčním potřebám Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových nair, "jsme znepokojeni mírou, do jaké se zájmové skupiny snaží manipulovat s fakty a postavit veřejnost proti bance."
Nwasinobi uvedl, že CBN zůstává oddaná plnění svých funkcí měnové politiky, jak je stanoveno v zákoně CBN z roku 2007 (ve znění pozdějších předpisů).
"Také si přejeme znovu zdůraznit, že NSPMC má kapacitu a dostatek materiálů na výrobu požadovaného otisku Nairy.
"Banka proto vyzývá veřejnost, aby ignorovala danou zprávu a projevila více zdrženlivosti, zatímco usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na konkrétní hlasové poznámce, která se šíří na sociálních médiích a tvrdí, že CBN plánuje uzavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že neexistuje žádný takový plán a že tvrzení jsou nelogická a nesouhlasí s fungováním nigerijského bankovního systému.
"Veřejnost je proto vyzvána, aby ignorovala takové nahrávky, protože nezastupují politický směr CBN a jsou pouze zoufalými pokusy osob, které se snaží podnítit veřejnost proti bance," uvedl.
Tim Sherwood se ostře vyjádřil k Pedrovi Porrovi, který stál 44 milionů liber, po jeho neúspěšném debutu za Tottenham.
Porro měl odpoledne na zapomenutí proti Leicesteru (Obrázek: Getty)
Tim Sherwood se ostře vyjádřil k "naprosto odporné" obraně Pedra Porra během porážky Tottenhamu 4:1 od Leicester City.
Spurs podepsali smlouvu s pravým obráncem ze Sporting CP na poslední den přestupového období na počáteční půjčku za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
Tento 23letý hráč dostal svůj debut od Antonia Conteho v sobotu na stadionu King Power, když jeho tým vedl po 14 minutách díky Rodrigo Bentancurovi.
Ale odpoledne se změnilo v bídné, když Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni skórovali a dali Leicesteru náskok 3-1 v poločase, zatímco Porro prožíval strašný první poločas v Premier League.
Španěl znovu udělal chybu, když Leicester si myslel, že přidal čtvrtý gól přes Barnese a i když byl gól pro ofsajd zrušen, bývalý manažer Spurs Sherwood byl šokován obrannými snahami obránce.
"Nechci na toho kluka pořád útočit, ale musí být zbaven svých povinností," řekl Sherwood v Soccer Saturday.
Dám mu prospěch pochybnosti, protože je to jeho debut, ale Pedro Porro je tak špatný, že je to neuvěřitelné.
Jeho pozicování je naprosto odporné, Barnes a Maddison ho na levé straně ničí.
Daniel Levy tuto týden říkal, že utratili hodně peněz, ano, to je pravda, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
Nedělejme zatím žádné závěry, ale na co se dívám, je hráč, který se nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na obranu a tento hráč momentálně bojuje s obranou. Je proti velmi dobrým hráčům jako jsou Barnes a Maddison, ale je to velmi zklamání."
I když byl gól vyřazen, Leicester obnovil své vedení 4-1 s Barnesem na cíli devět minut před koncem zápasu.
Přestože minulý týden Tottenham porazil Manchester City, přišel o šanci přesunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepsala Joao Felix a místo toho se pokusila získat hvězdu Tottenhamu.
VÍCE: Tottenham se chystá podat nabídku na hvězdu Crystal Palace Marc Guehi, ale Chelsea má neoficiální možnost odkupu zpět.
Pro více příběhů jako je tento, zkontrolujte naši sportovní stránku.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoliv souboj o privilegium nad předvoláním Mikea Pence.
Zpráva, že zvláštní poradce Jack Smith vydal předvolání Mikeu Penceovi, vyvolává otázku: Jak bude tým Trumpa využívat soudy k zablokování tohoto nejnovějšího vývoje v probíhajícím vyšetřování ministerstva spravedlnosti?
Krátká odpověď je, že jakýkoli pokus o potopení předvolání Pence na základě výkonné výsady by měl selhat.
Nejprve je třeba položit otázku, zda bývalý prezident může vůbec uplatnit toto privilegium.
Připomeňme, že Trump se pokusil a neúspěšně zablokoval snahu výboru Sněmovny reprezentantů z 6. ledna získat záznamy z Bílého domu.
Nejvyšší soud odmítl loni projednat Trumpovu odvolání, s jedinou výjimkou soudce Clarence Thomase (manžel popírače výsledků voleb v roce 2020, Ginni Thomasové), který nesouhlasil.
Soud ale nechal otázku, zda bývalý prezident může uplatnit privilegium, otevřenou, přičemž soudce Brett Kavanaugh naznačil, že by takový nárok podpořil.
Takže je alespoň nejasné, zda bývalý prezident může uplatnit toto privilegium, aniž by se hovořilo o tom, zda by nárok byl úspěšný.
Navíc, odvolání na Nejvyšší soud ohledně pokusu tehdejšího prezidenta Richarda Nixona vyhnout se dodržování předvolání ukazuje, že nejasné tvrzení o privilegiu nestačí a může být překonáno konkrétní potřebou důkazů.
Soud pozoroval v roce 1974 ve Spojených státech v. Nixon:
... když je důvod pro uplatnění privilegia vůči požadovaným materiálům pro použití v trestním řízení založen pouze na obecném zájmu na důvěrnosti, nemůže převládnout nad základními požadavky právního řádu v rámci spravedlivé správy trestního práva.
Obecné uplatnění privilegia musí ustoupit prokázané, konkrétní potřebě důkazů v probíhajícím trestním procesu.
Proto je precedent na straně vlády.
Samozřejmě, zpoždění způsobené soudními spory, i když prohrané, může být pro Trumpa jakýmsi vítězstvím.
Ale další snížení šancí na úspěšné uplatnění nároku na privilegium je předchozí zamítnutí Trumpova pokusu zablokovat svědectví velké poroty ze dne 6. ledna.
Jak informoval The Washington Post v říjnu, toto odmítnutí poznamenalo, že bývalý asistent Pencea Marc Short, například, "pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti útoku na Kapitol dne 6. ledna 2021, které nebyly dostupné z jiných zdrojů."
To, že i Pence pravděpodobně má unikátní informace, by pomohlo ministerstvu spravedlnosti v jakémkoliv sporu o vydání předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by měl nárok na privilegium selhat.
To proto, že Pence se rozhodl veřejně psát alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké tvrdit, že komunikace jsou privilegované, když jste je dříve považovali za vhodné zveřejnit.
Takže zatímco předvolání může představovat různé politické a osobní kalkulace pro Pence - který by mohl soutěžit o republikánskou nominaci v roce 2024 proti Trumpovi, který efektivně schválil výzvy k Penceově mimosoudní popravě 6. ledna - soudy by měly mít snadný čas přiklonit se na stranu DOJ ohledně privilegia.
Argumenty proti kandidatuře Bidena jsou zřejmé - a slabé.
Proč je toto důležité?
I když Biden a jeho kolegové z Demokratické strany nemohou v případě schvalování zákonů dělat mnoho, když je GOP v kontrolě Sněmovny reprezentantů, mohou stále strávit příští dva roky nastavením příkladu.
Kolektivně by všichni v týmu měli hledat příležitosti hrát Gallanta na podivné impulsy republikánů.
Ale je také důležité, aby Biden zlepšil svou důvěryhodnost u amerického lidu - a možná se stal zásadně potřebným změnovým agentem v naší příliš ošuntělé politické kultuře.
Washington, proslulé svým cynismem, je známé svými nápady o vedení, které paralyzují zdravý rozum.
Možná jedním z nejnotoričtějších je podivný standard, který tvrdí, že veřejné přiznání chyb je znakem slabosti a že politici by měli jít do komických délek, aby se tomu vyhnuli.
Existuje ještě jiná cesta: V knize Bailout, která je vzpomínkou Neila Barofskyho na dobu, kdy v Washingtonu působil jako zvláštní inspektor dohlížející na program Troubled Asset Relief, popisuje radu, kterou dostal od Kristine Belisle, ženy, kterou moudře najal jako svou ředitelku komunikace.
Bylo to tak proti-Washingtonské, jak to jen jde: "Přiznáme a dokonce zdůrazníme naše chyby."
Jak pokračovala v vysvětlování, v strategii, kterou většina lidí uvnitř Beltway považovala za šílenství, je metoda:
Toto je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o TARP ve Washingtonu.
Můžeme se někdy stydět a odhalovat věci, které bychom mohli - a ostatní by - snadno skrýt, ale šokujeme tisk naší upřímností.
Nikdo jiný to nedělá a brzy budeme mít vestavěnou obranu, když budeme napadeni.
Bez ohledu na to, co uslyší, tisk se k nám obrátí jako první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
Toto je možná největší důvod, proč by Biden měl usilovat o cestu radikálního přebírání odpovědnosti: V každém prezidentském období nevyhnutelně nastanou okamžiky, kdy je důvěra veřejnosti a institucí, které chrání občanský zájem, kritická.
Navíc, existuje zásadní kapitál, který lze získat vlastnictvím našich chyb, a Biden může vytyčit důležitý rozdíl oproti svým politickým oponentům.
Prezident by udělal dobře, kdyby následoval staré přísloví: Řekni pravdu - a zahanbi ďábla.
Některé reklamy na Super Bowl, na které se nemůžu dočkat.
Hvězda sitcomu z devadesátých let si znovu zahraje svou oblíbenou roli, aby vám prodala pojištění auta.
Reklama, která se stane kulturním fenoménem a je okamžitě schválena jako televizní show, rozšiřuje dvanáctisekundovou scénu na deset sezón.
Všechny celebrity z loňských reklam na kryptoměny se omlouvají za své reklamy na kryptoměny.
Ti kluci "whassup", ale teď jsou starší.
Všichni teď mají rádi detektivky, že?
Takže nějaká série reklam režírovaných Rianem Johnsonem, kde pokud zjistíte, kdo spáchal vraždu, dostanete slevu na roční pojištění auta.
Reklama, na kterou se budou všichni super-online konzervativní chlapi týden zlobit.
Timothée Chalamet v nějaké roli.
Někdo, kdo byl údajně navždy zrušen, se triumfálně vrací na televizní obrazovky, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte, ale určitě ho budete sledovat, až bude streamován za tři týdny.
Nesnesitelně chytlavá nová melodická linka, kterou budete zpívat sami sobě po léta.
Recyklovaný vtip z Twitteru starý dva měsíce.
Hudebník, jehož celá image je založena na protikultuře, vám protikulturně říká, abyste si založili účet u Wells Fargo.
Dítě ze sloganu "zoom zoom", ale pointa je, že je nyní dospělý.
Bidenovo ministerstvo spravedlnosti 'nechce ozbrojené občanstvo'
Zástupce Andrew Clyde (R-GA) se ve čtvrtek posadil s Breitbart News a diskutoval o svých plánech blokovat pravidlo ATF pro pistolové ramínko a o svém přesvědčení, že ministerstvo spravedlnosti Bidena "nechce v první řadě ozbrojené občanstvo".
Clyde jasně vyjádřil svůj nesouhlas s pravidlem pro pistolovou opěrku.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější.
Obecně vyjádřil své přesvědčení, že naši zakladatelé nevytvořili plán vlády, který by zahrnoval federální agentury vytvářející zákony místo zákonodárného sboru.
Řekl: "Ministerstvo spravedlnosti je zde k vynucování zákona, ne k jeho tvorbě. Když máte výkonnou moc, která vytváří zákon a vynucuje ho, pak máte krále a království. Naši zakladatelé nevolali po králi a v Ústavě Spojených států nevytvořili království."
Clyde poté přešel k podrobnostem týkajícím se pravidla o pistolové opěrce a vyjádřil své obavy, že toto pravidlo je součástí větší snahy ATF získat širší registraci zbraní.
Poznamenal: "Co ATF chce, je zvýšení registrační databáze pro National Firearms Act. Chtějí registrovat lidi po celé zemi, protože jak víme, co předchází konfiskaci, je registrace. A konfiskace, podle mého názoru, je konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občanstvo."
Dodává: "Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo má co, aby nás mohli pronásledovat."
Clyde tvrdí, že pravidlo ATF o pistolové opěrce vzniklo v tomto prostředí nepřátelství vůči druhému dodatku a soukromému vlastnictví zbraní, a plánuje proti němu bojovat zuby nehty.
Řekl, že má "tři nástroje", kterými může bojovat proti pravidlu.
Prvním z těchto nástrojů je zákon SHORT a druhým je zákon Congressional Review Act.
Dne 30. ledna Breitbart News citoval Clydea, jak popisuje svůj plán na "znovu představení zákona Stop Harassing Owners of Rifles Today Act, neboli zákona SHORT Act, který má zrušit prvky National Firearms Act a tím zakázat ATF registraci a zakázání pistolí se stabilizačními držáky."
Také poznamenal, že "představí usnesení o nesouhlasu podle zákona o kongresovém přezkumu, aby zrušil nezákonné překročení pravomocí administrativy Bidena."
Oba akty, SHORT Act a Congressional Review Act, mají možnost blokovat pravidlo ATF pro pistolové rameno.
Ale jak Clyde ve čtvrtek řekl Breitbart News, velkou výzvou je, že obě tyto cesty nakonec vyžadují podpis prezidenta Bidena, ať už k zavedení zákona SHORT Act nebo k finalizaci usnesení o nesouhlasu podle zákona o přezkumu Kongresu.
Učinil jasné, že získání Bidenova podpisu není nemožností, existují způsoby; například legislativa SHORT Act může být přidána k jiným, větším zákonům, které demokraté velmi touží schválit.
Nicméně, Clyde naznačil, že existuje také třetí způsob, jak blokovat pravidlo ATF pro pistolovou opěrku.
Řekl: "Jsem ve výboru pro přidělování prostředků a můžeme tuto pravidlo o pistolové opěrce zbavit financování, prostřednictvím toho, co se nazývá omezovací dodatek. Doslova můžeme toto pravidlo zbavit financování a v podstatě říci: "Nesmí být utraceny žádné peníze na provádění nebo vynucování tohoto konkrétního pravidla o pistolové opěrce."
A můžeme udělat přesně to samé i s pravidlem pro přijímač/rám ATF od minulého srpna.
Myslím, že oběma je třeba zastavit financování a těším se na spolupráci s našimi rozpočtáři, abychom toho dosáhli.
AWR Hawkins je oceněným sloupkařem na téma Druhého dodatku pro Breitbart News a spisovatelem/kurátorem Down Range s AWR Hawkins, týdeníku zaměřeném na všechno kolem Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins drží doktorát z vojenské historie, se zaměřením na válku ve Vietnamu (hnědá vodní námořnictvo), americké námořnictvo od jeho založení, občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se přihlásit k odběru Down Range na breitbart.com/downrange.
Kontaktujte ho přímo na awrhawkins@breitbart.com.
"Doufáme", že Biden má plán na zvládnutí konce Titulu 42, "pokud ho mají, nezveřejnili ho úplně"
V pátečním vydání NBC "MTP Now" řekl guvernér Colorada Jared Polis (D), že má "velké obavy" z toho, co se stane, když v květnu skončí Titul 42, doufá, že administrativa Bidena má plán na dobu, kdy politika skončí, a že "pokud ho mají, ještě nám ho plně nesdíleli."
A řekli, že "řekli jsme, že potřebujete plán. Chceme, aby ho s námi probrali."
Polis uvedl, že by si přál, aby bylo na problém imigrace věnováno více času během setkání guvernérů v Bílém domě, ale problém "přišel na řadu."
Měli jsme tam na část toho tajemníka Mayorkase.
A tak jsme znovu vznesli, mám hodně obav o to, co se stane, když v květnu skončí Titul 42, a tak se ujistěte, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě nám to úplně nesdělili.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to nebude to, co jsme zažili v prosinci, pětkrát nebo třikrát horší, to by byla katastrofa pro zemi a bylo by to hrozné pro administrativu Bidena.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stahuje "nevkusnou" reklamu poblíž krematoria - RT World News
McDonald's se omluvil, poté co byla reklama na rychloobrátkový "McCrispy" burger umístěna blízko krematoria ve Velké Británii - ačkoli někteří místní to viděli z legrační stránky.
Řetězec restaurací se zavázal odstranit dotčený reklamní billboard po stížnostech obyvatel Trura v britském hrabství Cornwall.
Získalo pozornost na sociálních médiích v pátek kvůli umístění na rušné silnici přímo naproti zařízení, které nabízí služby zpopelnění.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí ukazující na krematorium, byla některými rozzlobenými místními označena jako "nevkusná".
"Ačkoli vidím na tom i humornou stránku, je to nevkusné a jsem si jistý, že některým zarmouceným členům rodiny se to nebude líbit, když navštíví Penmount kvůli pohřbu a kremaci blízké osoby," řekl obyvatel, jehož tchyně byla v loňském roce zpopelněna v pohřebním ústavu, jak citovala britská média.
Nicméně, ne každého tak urazilo nešťastné umístění reklamy, jeden poznamenal, že reakce člověka na to by pravděpodobně ovlivnilo "jak dlouho jste sledovali ceduli krematoria s černou kravatou."
Jedna osoba řekla, že "spadla ze židle smíchy", když si všimla reklamy online, zatímco jiný místní poznamenal, že to bylo "ne horší" než rozhodnutí rady zabývat se myšlenkou povolit výstavbu krematoria "vedle důchodcovské vesnice".
Prohlášení vydáno McDonald's bylo zveřejněno místními médii v pátek krátce poté, co se obrázek reklamy stal virálním na internetu, ve kterém řetězec restaurací uvedl, že reklamu odstraní co nejdříve.
"Nebyli jsme si vědomi dopravní značky v blízkosti této autobusové zastávky. Nicméně vzhledem k obavám, které vyjádřil CornwallLive, jsme požádali o odstranění naší reklamy," uvedla značka rychlého občerstvení.
Rada Cornwallu, která provozuje jak krematorium, tak autobusovou zastávku, na které je reklama zobrazena, odmítla komentovat rozruch, když byla oslovena místními médii.
'Podvědomý instinkt' chybějící žena není v řece
Hledání chybějící Angličanky Nicole Bulley vstoupilo do 16. dne, poté co její partner řekl, že jeho "instinkt" je, že není v řece.
Policie v Lancashire uvedla, že policisté mají "otevřenou mysl", zatímco pokračují v odvolání na informace o paní Bulleyové, která zmizela 27. ledna při procházce se svým psem v St Michael's on Wyre.
Síla pokračuje v hledání na řece Wyre směrem k moři u Morecambe Bay, pracuje na hypotéze, že 45letý muž z Inskipu mohl spadnout do vody.
Jejich hledání bylo podpořeno specialisty a potápěči z HM Coastguard, horské záchranné služby a hasičské a záchranné služby Lancashire, s nasazením detekčních psů, dronů a policejních vrtulníků.
Paní Bulleyová zmizela, když procházela se svým springer španělem Willow u řeky, krátce poté, co odvezla své dcery, staré šest a devět let, do školy.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále připojen k pracovnímu hovoru.
Její partner, Paul Ansell, řekl, že chce mít "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popisoval paní Bulleyovou jako "zábavnou", "milující", "nejvěrnější přítelkyni, jakou byste kdy mohli mít" a "výjimečnou matku", která "naprosto zbožňuje naše dívky."
"Je to prostě pilíř síly naší rodiny a bez ní je díra větší, než si dokážete představit," řekl 5 News.
Pan Ansell uvedl, že ačkoli rodina prochází "bezprecedentním peklem", naděje, že jeho partnerka bude nalezena, je "silnější než kdy jindy."
Policie vyloučila trestný čin a incident vyšetřuje jako případ nezvěstné osoby.
Ve čtvrtek se zaměření jejich hledání přesunulo ze St Michael's asi 10 mil po proudu, kde řeka ústí do moře v Morecambe Bay, s hlídkovými a záchrannými čluny spatřenými v oblasti.
Poslední komunistický vůdce Východního Německa zemřel ve věku 95 let.
BERLÍN (AP) - Zemřel Hans Modrow, který sloužil jako poslední komunistický vůdce Východního Německa během turbulentního období, které skončilo prvními a jedinými svobodnými volbami v zemi.
Bylo mu 95.
Modrow zemřel v sobotu ráno, oznámila parlamentní skupina strany Levicoví na Twitteru.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nebyl schopen zpomalit rostoucí momentum pro německé sjednocení.
"Celý mírový průběh vytváření německé jednoty byl právě jeho zvláštním úspěchem," napsala Levice na Twitteru. "To zůstane jeho politickým odkazem."
Během 16 let jako šéf komunistické strany v Drážďanech, začínající v roce 1973, si Modrow vybudoval pověst jako postava proti establishmentu.
Odmítl stranické výhody a trval na bydlení v normálním bytě.
Post v nejvyšším vedení Východního Německa mu unikl, dokud nebyl jmenován premiérem, pozicí, která dříve měla malý vliv, v listopadu 1989 - několik dní po pádu Berlínské zdi.
Když v prosinci rezignoval tvrdý lídr Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou osobností východního Německa.
Ale komunisté už nemohli sami rozhodovat.
Následující měsíc souhlasil s tím, že bude sdílet moc s čím dál hlasitější opozicí a předčasně uspořádal první svobodné volby v NDR na březen 1990, v době rostoucího nepokoje.
I když pro-demokratické shromáždění rychle nabralo na pro-sjednocovacím charakteru, komunisté původně odmítali diskusi o sjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se Západním Německem směřující k budoucímu "sjednocenému vlasti", které by bylo nezávislé na vojenských blocích a řízené společným parlamentem v Berlíně.
Modrow vedl volební kampaň přepracovaných komunistů, strany Demokratického socialismu, ale jeho osobní popularita nestačila na to, aby zabránil tomu, že skončili pouze jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která byla pro rychlou reunifikaci a měla podporu vlády západoněmeckého vůdce Helmuta Kohla.
Německo se pod vedením Kohla a jako člen NATO znovu sjednotilo 3. října 1990, méně než rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS - předchůdce dnešní opoziční strany Levice. Od roku 1999 do roku 2004 byl členem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho přivedla před soud několik let po znovusjednocení.
V roce 1995 byl soudem odsouzen za podněcování k falšování výsledků místních voleb v Drážďanech v květnu 1989.
Vynesl mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že soud byl politicky motivován a tvrdil, že jeho výsledek zhorší rozdělení mezi východními a západními Němci.
Jeho právní zástupce argumentoval, že se za předchozí nespravedlnosti omluvil tím, že jako premiér dohlížel na svobodné volby.
Později v životě Modrow sloužil v radě starších levicové strany.
"Hans byl hluboce upřímný a bojový socialista," tweetnul Dietmar Bartsch, předseda parlamentní skupiny strany Levice.
"Do konce svého života byl důležitým poradcem v naší straně, jehož moudrost nám bude chybět."
Indická vláda stáhla odvolání k objetí krav na Valentýna po kritice.
Objímání krávy na Den svatého Valentýna již není indickou vládou povzbuzováno - přestože dříve požadovala, aby lidé tak činili k propagaci hinduistických hodnot.
Rada pro ochranu zvířat Indie (AWBI) stáhla svůj apel "Den objetí krávy" poté, co vzbudil kritiku politických rivalů a uživatelů sociálních médií.
Indické vládní oddělení vyzvalo občany, aby se odchýlili od západních romantických gest slavených na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k objetí krav byla "naprosto šílená, vzdorující logice."
Dodává, že rozhodnutí stáhnout odvolání bylo spíše "z důvodu zabránění vystavování politiky Hindutvy [hinduistického nacionalismu] posměchu vzhledem k tvrdé kritice ze všech stran."
AWBI se v pátek stáhla ze svého odvolání s tím, že "je stáhnuto."
Bylo to až ve středu, kdy jeho prohlášení uvádělo, že "objímání krav přinese emoční bohatství a zvýší individuální a kolektivní štěstí."
Více o Indii
Dodalo, že kráva je "základem indické kultury a venkovské ekonomiky... kvůli své výživné povaze jako [matka]."
Na původní oznámení byly smíšené reakce, někteří zveřejnili videa krav, které odmítaly být objímány a odcházely.
Jiní chtěli objasnit, že odvolání bylo spíše na následování vlastní kultury, než na "slepotu" následování západních hodnot.
Mladí Indové obvykle tráví Den svatého Valentýna tím, že se shlukují v parcích a restauracích, vyměňují si dárky a pořádají párty.
Objímání krav také není nic nového - v některých částech světa se to považuje za terapeutické a v Nizozemsku, kde se tomu říká "koe knuffelen".
Oddaní hinduisté uctívají krávu - známou jako gau mata, nebo "matka kráva" - a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí radikálové přepadávali obchody prodávající předměty k Valentýnovi, pálili přáníčka a dárky a vyháněli páry držící se za ruce z restaurací a parků, trvajíce na tom, že tento den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové razie pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Narendry Modiho tvrdí, že jeho vláda prosazuje hinduistickou agendu, která usiluje o nadvládu tohoto náboženství v sekulární zemi známé svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhisté, buddhisté a džinisté tvoří většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeath, muž byl zatčen.
Chodec zemřel po srážce s autem ve Fife.
38letá žena byla po nehodě na Broad Street v Cowdenbeath v pátek kolem 13:30 převezena do nemocnice Victoria Hospital v Kirkcaldy.
24letý muž byl následně zatčen v souvislosti s nehodou.
Policie žádá o svědky nebo kohokoli s nahrávkou z palubní kamery, aby se přihlásil.
Sergent Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a žádáme každého, kdo byl v oblasti a byl svědkem nehody, aby se s námi spojil."
Také bych chtěl apelovat na každého, kdo byl v oblasti a mohl by mít záznam z palubní kamery, který by nám mohl pomoci v našem vyšetřování, aby nás kontaktoval.
"Kdokoli, kdo může pomoci, je požádán, aby zavolal na Police Scotland na číslo 101, s uvedením čísla incidentu 1638 z pátku 10. února 2023."
V ČÍSLECH: Městské části v Oslu, kde žije nejvíce cizinců
Přibližně 177 000 z 634 000 obyvatel Osla imigrovalo do Norska z jiných zemí.
Když zahrnete ty, kteří se narodili v Oslu cizincům, podíl těch, kteří jsou imigranti nebo mají imigrantský původ, stoupá na více než třetinu.
V Oslu tvoří občané z Asie, včetně Turecka, největší imigrační skupinu, když ve městě žije přes 62 985 těchto národností, podle údajů z národního statistického úřadu Statistiky Norsko (SSB).
Poté tvořili občané z EU, EHP a Velké Británie druhou největší skupinu, která tvořila téměř 10 procent populace města.
Afričané tvořili třetí největší skupinu imigrantů v Oslu, kde žije 28 020 lidí z Afriky.
Evropané z zemí, které nejsou součástí Velké Británie, EU nebo EHP, byli čtvrtou největší skupinou, kterou tvořilo 15 566 obyvatel Osla.
Odtud velikost skupin výrazně klesá.
Například v roce 2022 bylo těsně pod 7 000 občanů ze zemí Jižní Ameriky, zatímco z oblasti Severní a Střední Ameriky pocházelo jen o něco více než 3 000 občanů.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrtí s nejvíce cizinci.
V roce 2022 bylo zaregistrováno 18 257 cizinců, kteří tam žijí.
Poté měla druhý nejvyšší počet cizinců módní Grünerløkka, která se nachází poměrně centrálně, s 17 631.
Gamle Oslo měl také významnou populaci imigrantů, kde po přestěhování z jiné země žilo 17 631 lidí.
Statistiky Norska ukázaly, že cizinci byli rozptýleni po celých městských čtvrtích, jelikož Søndre Nordstrand, nejjižnější čtvrť v Oslu, měla zaregistrováno přes 14 000 imigrantů.
Mnoho imigrantů také žilo v žádaných oblastech, jelikož Frogner byl obvodem s pátým největším počtem cizinců.
Poté tvořily Stovner, Bjerke, Grorud, Østensjø a Sagene zbytek deseti obvodů v Oslu s nejvíce obyvateli z jiné země.
Na druhém konci spektra žilo v Marka pouze 184 cizinců a v centrální části města jen něco přes 700.
Ullern, Vestre Aker a Nordstrand tvořily další městské části s nejméně cizinci.
Nicméně, v těchto obvodech žilo výrazně více imigrantů než v centrálním Oslu a Marka.
Ti z EU a EHP a ti z Velké Británie většinou žili ve Frogneru, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Mezitím, zatímco mnoho občanů z Asie, včetně Turecka, také bydlelo v Game Oslo (5,837), většina byla registrována jako obyvatelé čtvrtí Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žilo nejvíce přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Norstrandem.
Ti z Severní Ameriky byli rovnoměrně rozprostřeni po Frogneru, Grünerløkce, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky byli nejčastěji nalezeni ve Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané z mimo EU, EHP a UK se obvykle usazovali v nejcentrálnějších čtvrtích města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika set občanů z Oceánie, Frogner, Grünerløkka a Gamle Oslo byly čtvrti s nejvyšším počtem těchto občanů.
Zimbabwe začne provozovat novou uhelnou elektrárnu do března.
Od Florence Tan
BENGALURU (Reuters) - Zimbabwe začne do března provozovat novou jednotku ve své jediné uhelné elektrárně, říká zástupce ministra energetiky země, což přinese úlevu milionům občanů postižených častými výpadky proudu v posledních měsících.
Nová jednotka elektrárny Hwange zvýší instalovanou kapacitu afrického národa o více než 14% na 2400 megawattů.
Další jednotka se očekává, že bude brzy uvedena do provozu, řekla Magna Mudyiwa, aniž by udala časový rámec.
Méně než polovina ze 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení financování nových uhelných elektráren omezuje schopnost země řešit chronické výpadky proudu, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době generujeme mnohem méně..asi 1000MW," řekl Mudyiwa Reuters.
"Ale naše poptávka po elektřině je asi 1700MW, takže máme vážný deficit," řekla.
Nedostatečné srážky vedly k poklesu výroby hydroenergie, zatímco účinnost jediné, desítky let staré uhelné elektrárny, prudce klesla v průběhu času, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžební a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů, které zatěžují vyhlídky na růst Zimbabwe.
Nedostatek financování pro uhelné elektrárny nutí ekonomiku závislou na těžbě a zemědělství dovážet nákladnou energii od regionálních sousedů, včetně Zambie a Mosambiku.
(Psáno Sudarshanem Varadhanem; Editace Jacqueline Wong)
(Osoba11) Ale u některých složek je z nějakého důvodu audio formát špatně, takže, něco je špatně -
V podstatě, velký obchod, nebo je něco špatně.
Takže, některé soubory stále - stále mají podivný výstup.
Ale - ale pro většinu složek by to již mělo být v pořádku.
(PERSON1) Dobře, děkuji.
(ČLOVĚK6) Ano, to je skvělé.
Podporuji to, je skvělé, že jsi na to [PERSON7] myslel/a [PERSON11].
A [PERSON11] nyní má čas.
Existují další věci, na které jsem myslel na [PERSON11] a to by bylo trénování, prázdných systémů, tak aby prováděli zkracování.
Takže, pokud byste vy, [PERSON11], měli čas.
Samozřejmě, není možné, abychom to stihli do příštího týdne.
Ale měli bychom opravdu mít systém – připravený pro –
Podíval jsem se na tutoriál od NLP - bylo to tak?
(PERSON6) Pro nadcházející sezení jsem se ptal na poptávku, protože jsem viděl demo (meme) projektu.
Dělají offline titulkování.
Takže, to je trochu jednodušší než to, co děláme.
Stále mají stejné problémy s segmentací atd.
Ale jejich úkol v překladu je zkracování, jednoduše proto, že se data zkracují.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro osoby se sluchovým postižením.
Takže, v datech je jakési přirozené zkrácení.
Bylo by skvělé, kdybychom mohli také najít takový typ dat, kde dochází k nějakému přirozenému zkracování.
Umístili bychom to do architektury.
(Osoba8) To chvíli trvá, protože musím zjistit, který je ten, který dostává přihrávky.
Takže, jakmile to vím, mohu to sledovat, takže, pro budoucnost -
Nebo vlastně, do budoucna by mi to nebylo potřeba, protože jakmile budu mít webový soubor, pravděpodobně už nebudu potřebovat provést konverzi.
(Osoba6) No, tohle, tohle by vlastně mělo být –
Stále mě slyšíš?
Kvalita zvuku je trochu horší.
Takže, toto by mělo být opravdu děláno, po celou dobu.
Takže, pokaždé když spustíme toto hodnocení, mělo by být spuštěno od začátku.
Takže pokaždé by mělo dojít k novému stažení, nové konverzi a novému hodnocení.
(Osoba8) Ale stále, pokud sleduji soubory, které je třeba převést ručně, abych mohl napsat skript, který by se postaral alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, mohu se na to podívat později.
(Osoba6) Takže toto je důležitá věc, na kterou jsme měli narazit už před měsíci.
Pamatujte, že od srpna vám říkám, že chceme vyhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejde jen o tebe osobně, [PERSON8].
Byly tam samozřejmě i jiné věci.
Ale pokaždé, když jste na to pomyslel, myslel jste si "to bude snadné, prostě to spustíme".
A teprve když to skutečně uděláte, uvidíte všechny problémy.
Takže, toto je známo, běžné.
Je to vždy tak.
Takže to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, jaký bude problém.
Takže, například, hovor, který jsem měl, kdy mě někdo interviewoval, tak chtěli nahrát video.
Zoom pro mě nikdy nefungoval tak špatně, jako dnes při nahrávání.
Takže, než to uděláte, nemůžete říct, zda to bude fungovat nebo ne.
A zde se setkáváme s problémy převodu formátů souborů.
Takže, doufejme, že budeme schopni rychle získat čísla.
Takže, máte dosud nějaké chybové sazby slov?
(PERSON8) Ne, nezpracoval jsem to.
Tak [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím, že v tomto slovníku je hodně šumu.
Tak jsem požádal, abyste měli různé verze tohoto slovníku tím, že vezmete pouze slova, která byla pozorována, pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takže, tímto způsobem, tyto náhodné chyby, jako je příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale stále budete mít varianty ve výslovnosti, protože pokud osoba řekne toto "alzo", pokud si vzpomenete, pokud to řekne "alzo" se "Z" 20krát v rozhovoru, pak to uvidíte v datech se "Z".
A pokud se mu někdy podaří také správně říci, pak ano, znovu, to uvidíte v datech.
Takže bych chtěl, aby [PERSON4] byl v kontaktu s [PERSON2].
Možná pokračujete v hovoru, že?
Budu muset teď odejít, protože musím dát dětem oběd a tak dále.
Ale prosím, zůstaňte na tomto hovoru a společně zjistěte, jak používat ten slovník.
Tak [PERSON4], prosím, ukáž [PERSON2], jaký slovník systém akceptuje.
Sdílejte svou obrazovku a ukážete to.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste vytvořil do toho souboru.
Jedna věc, která bude stále potřebná, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Takže slovník bude mít tři sloupce.
Grafém, jak je výstupem.
Jeden uznán.
Fonémy, jak navrhl [PERSON2].
A budou zde víceřádky s různými variacemi fonémů.
A třetí sloupec n bude také stejný pro všechny tyto, a opět tam bude stejný grafémový tvar.
Tak to je, když jazykový model vidí.
A myslím, že tímto způsobem by tyto systémy měly být schopny to načíst.
A také se možná setkáte s dalším problémem: že není připraveno pro dva velké uživatelské slovníky.
Takže, toto je také něco, co musí být otestováno, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] ví, co vytvořil v slovníku.
A víte, jak vypadá slovník, když ho vytváříte ručně, a tyto dvě znalosti musíte spojit dohromady.
Aha, tak aby to fungovalo s tím, s tím generovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Ano, jistě, probereme to.
(PERSON6) Ano, tak je tu ještě něco jiného, [PERSON2], co máš?
(ČLOVĚK2) No, možná zajímavá informace pro Dominika.
Dokončuji trénink německého ASR, který může být použit pro časové razítko.
Nejsem si jistý, jak dobré to bude, protože se to snažím udělat na (Libry) Speech.
A přesto, když jsem to stahoval, tvrdili, že to má více než 600 hodin.
Ale pak výcvik uvedl, že skutečná tréninková sada obsahovala pouze kolem 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale vyslovené různými mluvčími.
Například v angličtině nebo češtině jsem si všiml strmějších konverzí.
A teď to už nebude konvertovat tak rychle.
Takže, pokud vezmeme nějaké vzorky během tréninku.
Pak jsou výstupu ASR stále nějaké vážné chyby.
Takže doufám, že pro časové razítko je to dostatečně dobré.
Nebo bychom to alespoň mohli zkusit.
(PERSON17) Dobře, to je dobré, ano.
Takže jsem začal, ale myslím, že jsem nikdy nedokončil email pro vás, protože jste mi připomněl, [PERSON8], že váš filtr pro sprostá slova ještě není integrován.
A myslím, že toto je také důležitá zpráva pro [PERSON5], který se opět z hovoru ztratil.
Takže důležitá zpráva je, že ano, je velmi dobré, že aktivně tlačíte na to, aby vaše výsledky byly integrovány, a každý by to měl dělat.
A zároveň potřebujeme mít nastavení, abyste to mohli skutečně integrovat a testovat sami.
Takže tomu říkám "integrace udělej si sám".
Takže, [PERSON8], při práci s [PERSON5] a při dokumentaci nastavení se ujistěte, že to bylo dostatečně otestováno kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykového modelu a všemi ostatními.
Takže, kdykoli někdo vyvine novou užitečnou součást, celý proces by měl být pro něj snadno dostupný, aby si ji mohl sám otestovat.
Takže, tato samostatná integrace je důležitá, protože jinak to vše zůstane na vás, [PERSON8], a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který už byl proveden.
[PERSON4], že?
Byl testován filtr pro nadávky na záznamech?
Myslím, že to tak bylo.
(POSOBA8) Ano, myslím, že to bylo testováno na záznamech.
Takže, teď je čas to otestovat na živých potrubích.
A opět, myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby [PERSON4] to sám prováděl pro některé z pracovníků a živě přehrával některé z problematických souborů, jako je použití [PROJECT8] nebo cokoli jiného.
Jednoduše je hrajte.
Sledujte zvukový výstup na svém stroji a podívejte se, jak to funguje.
Protože pouze při provádění skutečného nastavení se objeví skutečné chyby.
Je důležité nejprve jej ladit pomocí logovacích souborů a poté je důležité jej ladit v pipeline.
A pokud by toto ladění mohl provést autor dané komponenty, v tomto případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Takže, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou na téma do-it-yourself integrace.
(PERSON17) Ano, tak pro angličtinu s více akcenty.
Takže, nyní jsme [PERSON14] to dali dohromady do jednoho technického řešení.
Aktuální myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a toto bude dělat napříč různými mluvčími.
Takže to budou opravdu věty s více mluvčími a robustnost vůči různým akcentům těchto mluvčích by mohla být také zlepšena.
Aha, takže to je jeden experiment s částicemi.
A později se možná budeme věnovat více tématu víceakcentovosti.
Takže, tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním problémem je implicitní jazykový model.
Takže systém ASR musí vidět co největší možný soubor vět.
A hodláme vytvořit nové věty z jazykového modelu pouze na textu přidáním zvukové části, takže jazykový model bude lepší pro ASR a robustnost vůči různým mluvčím by také byla lepší.
A včera jsem v jedné řeči slyšel další nápad.
Bylo to během tréninku.
Vypadávali časové pásma a frekvenční pásma ze zvuku.
Takže trénovali na narušených vstupech, což také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoli jiný může pracovat na věci s ne-native akcentem.
Dobře, další věc, kterou jsem si všiml, je - to je v dokumentu z pondělního testu.
Je to zvýrazněno čtyřikrát.
Takže, když se nějaká relace koná, potřebujeme jména a terminologii pro tuto relaci.
A musíme to sbírat, připravovat ručně, vytvářet to tak nějak.
A vytváření tohoto manuálu by mělo být co nejvíce podporováno automatickými nástroji.
Takže, existuje určitá dovednost b, kterou je třeba procvičovat.
Takže, jsem docela zručný v přehazování textových souborů.
A kdykoli vidím, že někdo z vás to dělá, vždy mám v hlavě tipy, co by se dalo udělat rychleji.
Možná to pro vás není rychlejší, ale měli byste to alespoň zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A bohužel se obávám, že jedinou osobou pro toto by mohl být [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, zpracováním dat, dejte to prosím vědět.
A pak potřebujeme -
Takže, jakmile máme zajištěný slovník termínů a jakékoli výslovnosti slov, potřebujeme techniky, jak tyto slovníky využít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě prováděl pro všechny relace, byl takový, že to nebylo skutečně viditelné v hybridním ASR.
Takže, jedno takové setkání se opět chystá na tuto pondělí.
[PERSON9] již začíná sběr dat, ale rád bych viděl výhodu této adaptace domény v nastavení [PROJECT5].
Takže, možná [PERSON9] a [PERSON8], protože se učí, jak provádět adaptaci domény a [PERSON14], protože se učí, jak pracovat s [PROJECT5].
Pokud byste se tři mohli setkat a dvojnásobně zkontrolovat, co [PROJECT5] dělá s -
To není [PROJECT5], ve skutečnosti je adaptace domény pro nástrojovou sadu [PERSON18], že.
Takže toto je jakýsi zpětný pohled, ujištění, že starý přístup funguje.
V současné době je naprosto nemožné provést jakoukoli adaptaci domény pro plně neuronové ASR.
Takže, co zvažuji, je mít nezávislé vyhledávání klíčových slov ze zvuku a nějaký postup sloučení.
Takže bychom mohli mít dva ASR běžící současně.
Kompletní ASR, který je obecně lepší.
A poté doménově přizpůsobené nastavení [PROJECT5], které se používá pouze pro vyhledávání klíčových slov.
A když vidíme klíčové slovo v doménově přizpůsobené verzi, pak bychom pak použili tu větu z [PROJECT5], která je obecně horší, ale obsahuje správné termíny.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom skutečně měli mít vlastní plně neuronový ASR a provádět různé experimenty na jemném ladění a všem tomu.
Takže jsme toto prodiskutovali s [PERSON14].
A, [PERSON14], máte nějaké novinky od potenciálního kolegy nebo přítele?
(PERSON17) Ano, tak pokud je zde někdo další, kdo by měl o toto zájem, dejte mi prosím vědět nebo se se mnou spojte.
Takže, toto je něco, co by bylo obecně velmi dobře přijato jako článek, protože lidé to ještě nedělají.
A to je v současné době nejnaléhavější problém.
Takže, skutečně bychom tam mohli mít dopad.
(PERSON6) Ano, možná jsem jen přemýšlel o tom, jaká data momentálně pro toto používáme, protože například pokud se podíváte na modely [ORGANIZATION4] na [ORGANIZATION5], jsou v těchto věcech už docela dobří -
(Osoba6) A myslím, že kdybychom jen tak -
Pravděpodobně bychom mohli získat data od nich, protože máte tak velkou sadu videí s různými doménami a různými rodnými jazyky mluvčích na [ORGANIZACE5].
A měl jsem tento nápad, že bychom mohli jednoduše použít nějaký nástroj k stahování v podstatě nějakých filtrovaných videí z [ORGANIZATION5] a vytvořit z nich tréninkové testy a tréninkovou sadu.
Takže, plánuji to udělat sám.
Plánuji tam jít, ale potřebujeme náhradní osobu.
A také, pro událost [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, archivátor, abychom znovu neztratili tu seanci.
A stále trvajícím a důležitějším tématem, na kterém je třeba pracovat, je lezení po žebříku.
A zde jsem v odstavci pro [PERSON2] navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a že by se rozrůstaly.
Myslím, že by bylo pravděpodobně nejjednodušší umístit tabulky jako html, ale mohlo by to být obtížné, když budeme chtít vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Může být obtížné připravit tyto tabulky.
Takže, zeptal jsem se [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Řekněte nám, zda je [ORGANISATION242], což je webové řešení.
Nějaká start-up společnost, která nabízí účty pro akademické účely zdarma.
Pokud by nám to pomohlo nebo ne.
Dobře, takže [ORGANISATION242] není doporučována [PERSON7].
Takže, jednoduchý html je pravděpodobně cestou k úspěchu.
Takže, jakmile [PERSON2] tyto hodnocení vyčistí.
To znamená přesunout několik skriptů, kam patří, z testovací sady [PROJECT3] a nějakého automatického spouštěče.
Poté prosím také vytvořte konverzi z tabulek do html podobně jako technickou konverzi a tyto výsledky pravidelně umisťujte na vaši webovou stránku.
Nebo co byste dokonce mohli udělat, je mít plný git check out přímo umístěný v tomto veřejném html nebo vyčleňování z tohoto veřejného html.
Aby bylo okamžitě dostupné přes web a kdokoli by se mohl podívat na aktuální skóre a prozkoumat to.
Takže, to by bylo užitečné, zejména pro lidi mimo [ORGANISATION2], jako je například [ORGANISATION15].
Víme, že mají něco jako -
Výkon byl špatný pro některé soubory a mohli je přímo prohlížet na webu m.
Mohli by také prohlížet to skutečně na [ORGANISATION101].
Je na vás, abyste to nastavili tak, aby to bylo uživatelsky přívětivé a snadno srozumitelné.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na, nebo se chystám aktualizovat, demo příspěvek, který má být odevzdán příští pátek, pokud se nemýlím.
A pak mám nějaké zprávy o projektech, které musím udělat, a začínám shromažďovat dokumenty - jako, nebo odkazy na dokumenty, ne samotné dokumenty, pro dvě relace.
(PERSON11) <parallel_talk> Pro ASR bychom měli také přidat doplňkovou metriku -
Ve skutečnosti více, měli bychom přidat doplňkové met- tyto doplňkové metriky. </parallel_talk>
Takže jste zmínil jeden a to je hodnocení filtru nadávek.
Takže <parallel_talk> máte explicitní seznam věcí, které se nesmí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A poté hodnocení vzácných slov.
A zde máme explicitní seznam jmen a termínů, které chceme, aby se objevily ve výstupu, hodnocené nejen podle (pořadí) rychlosti </parallel_talk>, ale hodnocené něčím, co přímo zohledňuje tyto věci, že?
Ano, tak s tím naprosto souhlasím.
To zahrnuje také manuální přípravu reference.
Takže, <parallel_talk> oba potřebují ručně vytvořené reference. </parallel_talk>
Mám jednu poznámku od [OSOBA1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by to brzy sdílet. </parallel_talk>
Takže, toto by se mohlo stát prázdnou částí druhé věci z vzácného slova -
Takže <parallel_talk> toto by bylo hodnocení vzácných slov pro MT a pak z [PROJEC210] pravděpodobně také získáme nějaký slovník. </parallel_talk>
Takže to by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat, abyste revidovali <nesrozumitelné/> doménu a vytvořili takový slovník tím, že se podíváte na výstupy a co v těchto výstupech chybí.
Takže, jako třídění - výpis slov, která nám se líbí a která se nám nelíbí v <nesrozumitelné/> doméně.
Mohl byste to udělat?
(Osoba11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdybyste to dokázali udělat.
Takže si to zapišu.
Takže, <parallel_talk> směřujeme k [ORGANISATION62] termínu s prací na studii o titulkování. </parallel_talk>
Ano <parallel_talk> a potom pak multi-zdroj s [PERSON7] nebo založený na [PERSON7] nebo - </parallel_talk>
A co ohledně identifikace jazyka, zajímalo by mě, jak přesně ji chcete integrovat, protože už zahrnuje zvažování více zdrojů ASR, více kanálů, takže jaký by byl případ užití pro identifikaci jazyka?
Jak to zapojíme?
(PERSON13) Bude to pracovník na převod zvuku na text a bude vydávat časové značky, jako je čtyři nebo dvě sekundy okna a třída.
<nesrozumitelné/> ticho, čeština, němčina, angličtina, a pak nechám na ostatních, jak to chtějí využít v procesu.
(TOsoba11) To je důležité.
Prosím, zapište to sem do dokumentu, tento <nesrozumitelný/> souhrn, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], no a možná také [PERSON5].
Pokud máme tento nástroj, musíme (odeslat) zvuk na více ASR nebo více pracovníků <nesrozumitelné/>
Budeme muset zvlášť poslat (odeslat) audio do anglického ASR, zvlášť do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také, k tomuto jazykovému ID pracovníkovi a poté potřebujeme sloučit tyto výstupy, a to je nástroj, který ještě nemáme.
To je nástroj s více zdroji, který bude sledovat textové výstupy a také následovat časové razítka a vydávat - pravděpodobně by produkoval výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže, potřebujeme filtr pro ASR, takže ASR je tichý, pokud je to špatný jazyk a je to rozpoznaný text, pokud je to správný jazyk.
Právě jsem si vymyslel tento typ nastavení.
Další nastavení by bylo, že stejný zvuk je odeslán na ASR a tento jazykový kontrolor.
Tento jazykový kontrolor je v podstatě součástí ASR, který ztlumí ASR, pokud je to špatný jazyk.
To je také možnost.
Takže, musíme zjistit, který způsob integrace jazykového ID je pro naše účely nejlepší.
Takže, prosím, pokračujte v přemýšlení o tom, jaké jsou naše pipeline.
Ideálně si myslím, že by nejméně zmatků v managementu a podobně vzniklo, pokud by naše MT modely byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z kteréhokoli z těchto jazyků do angličtiny.
Možná by stačilo udělat jen kopii, pokud byla jako vstup zadána angličtina, tak bychom na začátku měli vícejazyčné více ASR.
Vše se přeloží do angličtiny a poté se z angličtiny přeloží do všech jazyků.
A později, když by [PERSON12] měl vícejazyčný model ASR, ten jazykový ID by ani nebyl potřeba.
(VLASTNÍ JMÉNO) Věc je taková, pokud provedeme analýzu správněji, jednou z možností je hodnocení ze strany protivníka, jen aby bylo naznačeno, že omezení skutečně mají vliv na výsledný výstup.
To by bylo hezké a ano, možná analýza pozornosti.
Ale nejsem si jistý, zda by nám mohl dát stejné odpovědi, v podstatě, pokud model dodržuje nebo nedodržuje omezení.
(Osoba4) Musel jsem se podívat jen na několik příkladů pozornosti, nedělal jsem žádnou statistiku ani nic podobného, a dívá se na omezení, a když překládá omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém dělal nějaké chyby, ale ve skutečnosti to v tomto smyslu nedělá.
Dělá některé obecné chyby v překladu, ale ne (jevy), které se snažíme vyřešit.
No, pokud se vrátíme k automatickému hodnocení, problém s nesouladem je, že výstup je správně skloňován, ale kontext je jiný.
Tedy, není to stejný slovní tvar jako v referenci, že?
(PERSON4) Ano, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly označeny jako chyba automatickou evaluací, bylo 91 z nich správně skloňováno v správných kontextech.
(Osoba4) A myslím, že pouze dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako by překlad byl špatný.
A pak jsou zde případy, kdy byl překlad zcela špatný, protože věta byla opravdu špatně, a část musí být <nesrozumitelná/>, ale to byl jen jeden nebo dva případy.
(PERSON3) Ale snažíte se shodovat s odkláněcími formami, když to hodnotíte, že?
Neděláte nic-
(PERSON3) - lemmatizace referencí a-
(Osoba4) Obojí, obojí, obojí, shoduju se jak s povrchovými formami, tak s lemmatem.
(PERSON3) Aha, rozumím, ano, to jsou ty dvě skóre, že?
(Osoba4) Je to jen skóre dilematu pro (Evropu?) není v tabulce, protože tabulka by se nevešla na papír, takže <nesrozumitelné/>
Pokrytí je vždy kolem 97 procent.
Jen generuje správné lemmata, jen-
(PERSON3) Jo jo, dobře, chápu to, chápu to.
Takže v podstatě, pokrytí lemmat říká, zda je tam omezení, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně skloňováno, ale to není pravda.
(PERSON3) Oh ano, jen nevím, jestli jste to zachytili <nesrozumitelné/> když jsme mluvili o [PERSON1],
ale jedna věc je, že, že (úder) je lepší, ale druhá věc je, že lemmata jsou vlastně správně skloňována ručně,
ale to je to je něco jiného, ne, ne problém, je to vlastně dobré, že je <nesrozumitelné/> správně, jo.
Takže, přemýšlel jsem, že by mohlo být.
Ale nejsem si jistý, zda máme nějaká testovací data pro to, ale možná bychom mohli zkoušet experimentovat s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít omezení a zkusit použít synonymní omezení místo toho a vidět nebo porovnat jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to jen vágně popisoval, protože sám nemám přesnou představu, jak to udělat, ale mohlo by to být zajímavé, odlišné scénář.
Nevím, [PERSON1], víte o nějakých datech pro přenos stylu pro angličtinu a češtinu? Máme něco?
(PERSON4) <nesrozumitelné/>
(PERSON1) Myslíš tím přenos stylu, Dušane, že by tam bylo něco, co je v psaném jazyce, a ty bys byl cílová strana, bylo by to v mluveném jazyce nebo něco takového?
(PERSON3) No, to je věc, víte, mám o úkolu jen omezené znalosti.
Ale dokážu si představit, že chcete přepsat větu tak, aby nebyla napsána mužem, ale místo toho ji napsala žena, nebo nevím, jako když můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem opravdu tak dobře obeznámen s přesnými datovými sadami a tím, co pokrývají.
A myšlenka je, že styl vět je poměrně nejasně definován.
Takže znovu, nejsem si tak jistý.
(PERSON1) Máme tento korpus transformací vět.
A jedna věc, která je tam a mohla by být označena jako přenos stylu, je například zobecnění vět.
Takže, detaily jsou vynechány, věta je zjednodušena a poté se snažíme, aby věta zněla hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení, Matouš provádí nějaký experiment s angličtinou-češtinou, ale nemáme tam žádná referenční data.
Takže, nemáme žádný dataset pro kompresi vět.
Takže možná by mohla být generalizace zajímavá, ale obávám se, že existuje příliš mnoho různých dobrých generalizací, takže jedna referenční by byla příliš omezená na to, aby vám řekla něco o kvalitě vaší generalizace.
A nejsem si vědom žádných podobných transformací týkajících se pohlaví, například, to by mohlo být provedeno <nesrozumitelné/> pro češtinu, takže možná by správnou osobou byl Rudolf Rosa, abyste se ho zeptali, zda kdy vytvořil nějaký takový dataset.
Takže, dojde k vytvoření kořenové generace nějakého protějšku věty.
(PERSON3) Myslím, že je to vlastně zajímavá otázka, zda můžeme použít omezení k vynucení tohoto druhu pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní podčást testovací sady [PROJECT1], která by to pokryla.
Aha, takže někdy víme pohlaví mluvčího, takže pokud jste... možná se podělím o obrazovku a prohlédnu to.
(Osoba8) Nebo jsem to zkoušel s Marianem, který to jen sledoval a je to... Nevím, o kolik BLEU bodů nižší.
(PERSON2) Protože, jak věřím, že Martin dělá svůj <nesrozumitelný/> malý překlad, tak překládá více vět najednou a pak vybírá pouze tu střední a takto pokračuje v celém dokumentu.
Takže, kontext je jako v jednom <nesrozumitelné/> spolu s větou, kterou skutečně chceme přeložit.
(PERSON10) Jo, myslím - nebyl to Dominik, kdo dělal nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva roky zpět pro dvojitě prázdné, kde se účastnili kontextu nebo spojovali kontext s vstupní větou a prováděli nějaký druh překladu na úrovni dokumentu.
Ale věc je s tímto s konkatenací, není zcela jisté, zda má stejný efekt, jako když používáme nastavení více kódování-
(JMÉNO1) Jakože každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale jsem překvapen, že [JMÉNO8] říká, že to nefunguje vůbec.
(PERSON8) Jo, dobře, tak se omlouvám, možná bych měl být přesnější, že to nefungovalo tak, jak jsem to udělal <smích/>
(PERSON1) Ano, protože si myslím, že je to metoda, která je velmi snadno testovatelná a vždy by měla být testována v kontrastu se dvěma kodéry a očekával bych, že někdy bude lepší a někdy horší než nastavení dvou kodérů, v závislosti na konkrétním úkolu, jako je například to, co přesně je druhá věc, kterou kódujete.
Takže, možná pokud máte dvě kopie dvou parafrází téže věty,
možná je to nějak zmatené pro pozornost, tak co já vím.
Chování by také mohlo být odlišné pro staré metody sekvence na sekvenci, ve srovnání s transformátorem, takže pro RNN se pak chovalo jinak, možná s transformátorem je to ano, je to těžší na trénink, takže možná musíte zvýšit počet rozcvičení, sady rozcvičení.
(PERSON2) Jo, takže jen abys věděl-
(PERSON8) Nepamatuje si, takže si přesně nepamatuji, ale to je jako co-
když jsem v létě začal s těmi experimenty s více zdroji.
První věcí, se kterou jsem začal, bylo spojování parafráze a zdroje a možná já, už si nepamatuji,
Můžu to zkontrolovat do příští schůzky, zda jsem to také zkoušel,
Určitě jsem to zkoušel, když jsou zdroje na první pozici, poté nějaký oddělovač a parafráze na druhé pozici.
Mohl jsem také zkusit, že jsem ty dvě věci náhodně zamíchal, ano, a jen si pamatuji, že to dělalo hojně tuhle věc s prolnutím a zkoušelo multi-kodéry.
(Osoba8) A to bylo pravděpodobně kvůli nízkým skóre.
(PERSON2) <nesrozumitelné/> že vám se může zlepšit skóre pohodlí pouze přidáním frázového výstupu a pozornost je jako dvojitá diagonála, takže pozornost není problém, takže věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže, pokud zadáte výstup založený na frázích, je to v podstatě poeditace, že? Můžete na to nahlížet jako na poeditaci, jako byste poeditovali výstup založený na frázích, že? Nebo to záleží na úhlu pohledu, že?
(PERSON1) <nesrozumitelné/> že se vám to líbí úplně přepsat, ale technicky to přesně odpovídá úkolu post-editace, můžete to zapojit jako řešení úkolu post-editace.
(PERSON10) Dobře, tak jedna otázka jen pro mě, abych se ujistil, v nastaveních konkatenace vkládáte token oddělovače vět, že?
Máte speciální token pro rozlišení, který je zdroj a který je kontext nebo jiná věta, nebo je prostě spojujete bez čehokoli?
A doufáte, že se to systém naučí?
(Osoba8) Zkoušel jsem to, myslím, že dvěma tokeny a ano, protože v první verzi jsme měli podezření, že token může být také tokenizován, takže jsem to pak přehrál s dalším tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník, a tento slovník neobsahoval separační tokeny.
Takže jsem použil nějaký token, o kterém jsem předpokládal, že nebude rozdělen na několik částí a tak se objeví jednou.
Neměl jsem žádnou záruku, že tento token se nemůže objevit na jiných místech věty a že je to jediné místo, kde se může objevit.
Takže, mohlo by to být uděláno lépe, ano, souhlasím.
(PERSON2) Ale část týkající se Flasku nebo komunikace se zákazníkem je něco, co neumím udělat.
Protože nemám zkušenosti a nemám čas to rozchodit.
(PERSON1) Myslel jsem, že to znamená něco pomocí mediátora, kterého neznám.
(PERSON2) Ne, vytvořte HTTP klienta, který může naplnit frontu a číst z jiné fronty.
A odešlete text zpět v HTTP požadavku.
Protože mým nápadem je, že kliknutí uživatele by mělo být využito také v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk ve malých částech současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to vložte do fronty, kterou později zpracuji s (ASR).
A model s tím provede nějakou logiku, nějaký závěr.
A kdykoliv má nový kus přepisu, pošle ho zpět a uživatel by měl dostat zpět částečný přepis.
A mělo by se to okamžitě zobrazit v textovém poli.
(PERSON1) Mohl bych o tom přemýšlet.
Jenže já také moc neznám Flask, ale ano, mohu o tom přemýšlet.
(PERSON2) Oh, možná jiný HTTP server.
Nevím, možná ani nepotřebujeme pro to sofistikovaný HTTP server.
(MUŽ1) Myslím, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo pro toto.
(ČLOVĚK2) Ano, jediným požadavkem je, že by měl zvládnout více připojení najednou.
(PERSON1) Myslím, že online textový tok je něco kolem 2 000 alespoň.
(MUŽ1) Myslím tím skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými pracovníky uvnitř, takže myslím, ano, takže mám <nesrozumitelné/> řekněme deset, no místo výstupu, soubor od <nesrozumitelné/> pracovníka, tak <nesrozumitelné/> které máme, takže se jen ujistím, že se tyto věci pro jeden soubor generují paralelně ze všech dostupných pracovníků.
(PERSON1) To by nám ušetřilo čas.
(PERSON7) Ano, ano, je velmi důležité paralelizovat vše, paralelizovat jak zpracování systémů, tak hodnocení buňky DF, protože by to musel spustit mnohokrát, budou chyby, musíte to rychle znovu spustit.
(PERSON7) Dobře, tak děkuji.
Takže, jste s tím velmi zaneprázdněni, nechci na vás tlačit s dalšími věcmi, takže začnu s připomínkami.
Potřebujeme dokončit popis stolní sady [PROJECT1],
Koho tu máme?
No tak, ne úplně, jo, (je to hotové) a bohužel to tady není.
Takže, toto by bylo pro [PERSON2],
Poté hodnocení, toto je pro [PERSON1], ale to jsme již diskutovali.
Poslouchej, dej mi tabulku v DSD, dejme sem jemnou čáru a vlož šablonu tabulky, jako strukturu plánu do deleblu nyní, takže čísla přijdou později, ale chci vidět nějaká čísla a plnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuji.
Máme [PERSON5], to je dobré.
Takže pro [PERSON5] bych chtěl zkontrolovat, jaký je pokrok v hodnocení systémů a zda jste také v kontaktu s [PERSON1] ohledně vývoje, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a potom zjistíme, které balíčky nainstalovat do Petriho prostředí.
(PERSON7) Ano, takže tu je další věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je to vlastně lepší, pokud to spustíte samostatně a uložíte výstupy.
Takže nejprve využijete prostředí pro tempomat a zpracování,
(PERSON7) a vy shromáždíte všechny výstupní soubory a poté spustíte hodnocení.
A důvodem tohoto rozdělení je, že můžete ochromit více.
Takže, budou problémy na různých frontách, jsem si jistý, a budeme potřebovat čísla velmi brzy.
Takže, pokud například některé z testovacích souborů selžou z nějakého důvodu,
Pak můžete překlad pro zbývající nechat stále běžet,
a přehodnoťte, s využitím sel T F, ty chybějící, a tak dále.
Takže, nejde o to vytvořit sériové, sekvenční zpracování, které zahrnuje obojí,
ale pointou je získat výsledky a je vlastně lepší dělat to po částech.
Nejprve získáme všechny výstupy, poté získáme všechna hodnocení.
(PERSON1) Jo, takže, myslím, že právě teď, dělal jsem to samé.
(POSOBA2) Ano, to je jediné, co jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího při dekódování.
Jako filtrování paprsků a nahrazení paprsků jinými paprsky.
A pro takové věci jako jsou více-tokenové omezení a podobné věci.
Ale pro pozitivní omezení, porovnával jsem pouze tréninkový přístup s ano, jen s tímto velmi jednoduchým materiálem.
Stačí upravit skóre v každém kroku stejným způsobem.
(PERSON7) Dobře, tak zpět k pozitivním omezením.
Už jste se zaměřili na analýzu systému?
(PERSON2) Ano, právě teď, tak nějak čekám na zpracování datové sady od ([PERSON9]).
Také [PERSON9], podíval jsem se na (kód) a myslím, že vím, proč je tak pomalý.
Protože pro každý záznam v terminologii v (Europar) zpracování, otevřete dataset, tokenizujete ho, čtete ho řádek po řádku, tokenizujete ho řádek po řádku a poté ho zavřete.
Ale to děláš jen ty -
(PERSON4) Takže si pamatuji, že jsem to pro [PROJECT1] dělal od minulého roku z nějaké chaty v horách.
A právě jsem si uvědomil, krátce před Silvestrem, že to musím odevzdat.
A <smích/> tak to je také něco, co se stane [PERSON8] Obávám se, že by mohl být...no, žádná párty, ale možná na dálkové párty.
A pak by náhle uvědomil, že to musí odevzdat.
Takže, v tomto bodě nebude žádná recenze. <smích/>
Jednoduše by vzal PDF a nahrál ho tak. <smích/>
(PERSON7) No, dobře.
Takže, ano, zkontroluji to 21., a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že je lepší poslat jim hned teď e-mail a požádat o ten odkaz předem.
(PERSON7) Dobře.
(PERSON4) Ano, děkuji.
(MUŽ7) Máme dnes ještě další otázky k diskusi, nebo je to všechno do nového roku?
(DO OSOBY6) Doufám, že pro mě nebylo nic?
(PERSON3) Před několika lety.
MT maratony dříve používaly tento systém nebo nástrojové dokumenty, které byly publikovány jako speciální vydání PBML.
To se stalo v prvním roce.
A poté, v následujících letech, bylo toto začleněno do normálu, jako byly také vydávány PBML, které smíchaly prázdné okrajové papíry a samostatné papíry kvůli počtu těchto papírů.
A dokonce jsme měli takovou věc, že pokud nebyl článek dostatečně dobrý pro PBML, ale nástroj byl prezentován na MT maratonu.
Autoři byli vyzváni k odeslání dalšího přezkumu pro jedno z příštích vydání PBML.
Takže, jak jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, zveřejněte to na MT maratonu mezi lidmi.
Ale váš papír je příliš špatný.
Musíte to zlepšit a dostanete se pouze k dalšímu PBML.
(ČLOVĚK4) Ano, ale ještě jedna možnost pro SIGDial.
Není možné, že pokud vyzkoušíme SIGDial, přilákáme lepší účastníky.
(PERSON3) To je ano, to je... jako jsem si myslel, že také mám, ale ani jeden z míst neznám.
Mají konečnou registraci papíru v červenci.
Takže konference byla v září a odevzdání příspěvků bylo v květnu.
Protože pro Interspeech bychom to také mohli rozdělit na jednotlivé články.
Aby některé dokumenty byly zařazeny do sborníku Interspeech.
A některé z našich příspěvků by dorazily později pro zápis z jednání PBML.
A autoři by měli svobodu volby.
Takže to musíme vyjednat buď s SIGDial nebo s Interspeech.
Pokud je pro ně v pořádku mít některé z našich dokumentů, za předpokladu, že tyto dokumenty jsou odevzdány do březnového termínu.
Takže, existuje absolutně přísná požadavek.
A myslím, že proti tomu nemohou mít nic.
Protože pokud je papír hodný publikace.
Jako bonus je, že výsledek sdílené úlohy se objevuje v satelitním eventu.
Tak jo, myslím, že je to v pořádku.
Takže, nemusíme žádat o speciální sezení.
Na konferenci Interspeech se tomu říká speciální session, to ale nechceme.
Na Interspeech chceme satelitní událost.
Ale my to řekneme našim lidem.
Pokud se vám podaří mít svůj dokument připravený do termínu Interspeech, pošlete jej jako Interspeech dokument a budete jej mít v rámci Interspeech.
Ah, pokud to neuděláte, ah, pro termín Interspeech, zde je náš termín.
A to je pro PBML.
(PERSON7) Aha, dobře.
Ale věc je jako pro satelitní událost Interspeech.
Erm, Interspeech se pravděpodobně nedostane do žádných jednání.
(PERSON2) Myslím, že si můžete prostě rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít hodně práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím, že je to něco jiného, protože si myslím, že to není opravdu věc, aby propadl svým kurzům.
Rád selháváte, protože to nedokážete dokončit.
Samozřejmě, jako kdyby lidé prostě vzdávali, ale myslím, že to je možná z jiného důvodu, než že je to prostě nemožné projít.
Myslím, že je to rozhodně možné, ale je to hodně práce.
(PERSON1) Ano, myslím, že nám na začátku semestru řekl, že pokud chceme jedničku (??), dostaneme jedničku.
Právě do druhého termínu byste to měli odevzdat.
To je v podstatě jediná věc, kterou se ptal.
Ale také nám řekl, že soudě podle trendů předchozích let, hodně lidí to nedělá.
Najdou to snazší číst na zkoušku.
Ne, promiň, uč se na zkoušku-
(PERSON2) Ano, protože obecně jsou jeho zkoušky spíše snadné.
(PERSON2) Takže bych neřekl, že je to super snadné, protože jsou kurzy, kde je zkouška jako zábava.
(PERSON1) No tak, jeden z nich byl pro mě včera.
(PERSON2) Ano, když má krátký kontext a protože rozhodnutí dělám na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se opravdu zaváže k něčemu, co za například sekundu nebo dvě zjistí, že vlastně to byl špatný překlad.
Takže se snaží použít jiné formulace.
Například, specifikovat věc.
Takže vlastně, to se mi opravdu líbilo.
Některé překlady se mi líbí. Opravdu jsem byl ohromen, i když bylo vidět, že model udělal při prvním pokusu chyby, opravdu se snažil nějakou opravu provést.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud skutečně vyžadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že je překlad zbytečný.
Ale pokud je nižší kvalita způsobena překladem, pokud si přečtete vše, co dostanete stejné informace, ale formulace je prostě špatná, protože se použilo například více slov a použilo se nějaké opravy a tak dále.
Takže si myslím, že toto je zcela v pořádku pro současné použití, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako například nějaké příklady?
Protože bych se na to chtěl podívat, jen z čisté zvědavosti.
(PERSON2) Oh určitě, mohu ti předat mé záznamy.
(PERSON7) Ale v jakých jazycích?
Protože víte, že nemluvím německy.
(PERSON2) Angličtina a Němčina.
(PERSON7) Jo, ale nutně nemluvím německy <smích/>.
(PERSON2) Pak mohu poskytnout anglicko-čínský a anglicko-japonský překlad, pokud to pomůže <smích/>.
(PERSON2) Takže znovu, mám na mysli, aby to bylo lidsky čitelné.
Protože toto blikání je opravdu otravné a pak ztrácíte soustředění na to, co bylo vlastně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a jak pracujeme s informacemi.
Omlouvám se, nikdy jsem o tom nepřemýšlel hlouběji.
Ale myslím, že kdykoli vidím slovo, uložím ho do své paměti a moje paměť není lineární, ale spíše jako taška.
Takže, vložil jsem slovo do tašky.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je problém s blikáním.
Pokud něco přeložíte a pak to změníte, pak to vlastně už četl, je to v mém mozku.
A pak ztrácím soustředění a kontrolu nad tím, co bylo vlastně potom přeloženo jako správné a co nebylo.
Proto si myslím, že celá ta věc s blikáním je špatná a hloupá z definice.
Jako když vidím motivaci, jako když chcete ukázat vše, co máte.
I když to nemůžete slíbit, že to bude dobré.
Ale myslím, že s těmito dalšími informacemi nemůžeme pracovat.
A myslím, že možná problém je, že systémy jsou vytvářeny lidmi, kteří s nimi pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále ho ukazuji a je nějaký dobrý, ale myslím, že vývojář se opravdu nesoustředí na obsah samotný.
A jak vnímáte obsah, ale spíše to, že jo, můj systém to dokáže opravdu rychle vygenerovat.
A i když to jen hádá, kvalita je tak nějak v pořádku, myslím, že to je možná důvod, proč byl vytvořen překlad zpět.
Právě vývojáři systémů jsou dychtiví zobrazovat informace a myslím, že protože jsme omezeni v množství informací, které můžeme vnímat, považujeme další informace jen za další zátěž.
Takže si myslím, že není dobré ukazovat něco navíc.
Pokud chcete snížit latenci, pak místo blikání jednoduše snižte kvalitu.
Myslím, že to je stále lepší než ukazovat blikání.
Protože jaký by byl skutečný případ užití?
Proč byste skutečně potřebovali vidět nestabilní hypotézu?
Z pohledu uživatele?
(PERSON1) Technicky, když lidský překladatel začne překládat, myslím tím, že cílem i pro anotátory je, že se pokusí následovat řečový sled původního mluvčího.
Takže, existují chvíle, kdy by řekli něco, co by bylo špatně, a pak by se prostě opravili.
(PERSON2) No, ale ano, to znamená, že s mým řešením, jako byste nedělali blikání, ale zavázali jste se, jako by nebyla možnost změny, ale opravili jste se.
A to je vlastně to, co překladatelé dělají.
(Osoba3) Silně cítím, že naše práce není přesně v oblasti řeči, je to nezdravé.
Protože zde neexistuje koncept řeči.
Pracujeme přímo na textu.
Ale věc je taková, že návrh na statistický workshop tohoto roku je už za námi, který byl v září, což bylo pro nás příliš brzy.
A další návrh by přišel až na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, pokud získáme buď jedno ze dvou sektile nebo interspeech, protože obě jsou v komunitě dobře uznávány.
Můžeme motivovat účastníky k podání.
Ah, jedinou výhradou, kterou nyní zjišťuji, je, že pokud půjdeme s interspeech, tak nám nepovolí místo v zápisu, což může odradit některé účastníky, nejsem si jistý, jak moc budou nadšeni zveřejnit článek v archivu.
Takže, v archivech mohou lidé publikovat kdykoli, že?
Takže to není výhodou pro jejich profily.
Tak jak motivovat účastníky, aby se připojili k naší sdílené úloze.
Takže to byl důvod, proč jsem se zvláště zaručil za speciální zasedání.
Ale tentokrát je problém, co mohu pochopit, je to, že posledně byly časové úseky mezi návrhy, podáním a konečným odevzdáním práce pět měsíců, takže by to pro náš harmonogram bylo dostatek času, ale tentokrát.
Je to pouze tři měsíce.
Takže, tuto veletrh vidím jako důležitý možný zdroj neanglické řeči, kterou můžeme použít k rozšíření testovací sady.
Takže, myslím, že bychom se opravdu měli soustředit na soutěž v nejjasnějším hlasu a stánek můžeme udělat, pokud to bude nutné.
Ale rád bych to omezil, protože šíření mezi středoškolskými studenty pro nás má menší dopad.
Je důležitější využít to jako testovací sezení.
Takže bychom se měli soustředit, [PERSON1], na [PROJECT2] nejjasnější hlas a udržet organizátory spokojené, abychom mohli provádět sběr dat tam.
A dělejte cokoli chtějí, abychom to pro ně udělali výměnou, a musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tento plenární program užitečný.
takže by to pro nás znamenalo testovací sezení a co se týče naší vlastní přítomnosti na tomto veletrhu, nemyslím si, že je příliš důležitá.
Takže, pokud se nás zeptají, pokud se od nás skutečně očekává, že tam budeme a budeme přítomni, pak je to v pořádku, ale pokud ne, pak si myslím, že je pro nás rozhodně dobré být za oponou a za scénou a dělat tam naši práci.
(PERSON1) Jo, ještě jsem se nepokusil/a o registraci na to, ale myslím, že naposledy bylo povinné mít stánek.
(POSOBA2) Ano. Takže, diskutujte s nimi o tom, co je potřeba, aby byli šťastní, a aby nám dovolili dělat Nejjasnější hlas, což je ta nejdůležitější věc.
Testovací sezení je méně naléhavé.
A stánek je prostě něco, čemu bychom se opravdu rádi vyhnuli, pokud je to možné.
Upřednostnil bych, kdyby se připojili k sezením dříve, než dělají takové věci.
Takže, opravdu potřebujeme tyto přípravy procvičovat.
S online světem to vypadá, že jednoduše vstoupíte do sezení a práce je hotová.
Ale to není případ.
Vždy to trvá 30 minut, než je to spuštěno a správně připojeno.
Takže, musíme tam být dříve.
A pokud nějaká session, kterou děláme, začíná v devět, ale organizátoři se scházejí ve čtvrt na devět.
Potom musíme přijít už ve čtvrt na osm, abychom měli těch 30 minut navíc na to, abychom se ujistili, že vše běží a honili lidi.
Takže, toto je poznámka pro všechny, že aby management fungoval, prosím také předvídejte, co by vám management mohl náhle požádat, abyste udělali, a to by trochu pomohlo.
Další velmi důležitou zprávou je zaznamenání těchto důležitých sezení.
Nevím, zda jste odpověděl, neviděl jsem, že by někdo poskytl jakékoliv aktualizace dokumentu.
Možná jsem zapomněl to všem říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní v zaznamenávání těchto sezení.
Je tedy důležité pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, mít dobré záznamy z těchto sezení.
A jedním aspektem je získání souhlasů, aby bylo skutečně povoleno provést nahrávání.
A i kdybychom se pokusili získat souhlasy zpětně nebo jakkoli jinak.
Pak je zde technický aspekt nahrávání.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [PERSON5] posílá ten odkaz.
Poslal jsem to e-mailem, pamatuji si.
2 špatné citrony za sebou :(
Objednal jsem od této společnosti, protože jsem ji koupil v předchozích sezónách a skvěle nám fungovala.
Tuto sezónu jsem koupil velikost, kterou jsem potřeboval.
Jedny z pyžam, které jsem obdržel, měly díru na noze pyžama.
Vrátil jsem to a firma mi poslala nový.
Náhradní pyžamo, které můj syn nosil jednou, jsem ho dal do pračky jako vždy a zip se odlomil!
Jsem tak zklamaný, protože nemám čas se zabývat vracením zboží každých pár dní a přesto se to právě teď děje.
Přesně jak je popsáno
Toto je základní nafukovací kabát.
Pokud hledáte základní kabát, pak tento kabát splní vaše očekávání.
Kabát dorazil ve vakuově uzavřeném sáčku, takže ho je třeba pověsit na několik dní, aby se vyrovnaly záhyby a trochu "nafoukl".
Měřím 5 stop 6 palců a kabát mi sahá po kolena.
Objednal jsem o 2+ velikosti větší kvůli jiným komentářům a minulým zkušenostem, a kabát je pravděpodobně trochu větší než bylo potřeba.
Nicméně, s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou manžety, takže je pravděpodobně přidám později.
Kapuce funguje, ale nemá na ní žádné šňůrky.
Přední zip funguje.
Na straně ani na zadní části nejsou žádné ventilační otvory pro zvýšení pohybu, ale s větší velikostí bych měl mít dostatek místa.
Na mém pasu jsou dvě kapsy (mohou být na vás výše nebo níže).
Nejsou zde žádné ozdoby nebo stylové detaily - je to ZÁKLADNÍ KABÁT.
Za tu cenu si myslím, že je to v pořádku.
Nosil jsem to ve větrný den, ale nebylo zima.
Necítil jsem vítr, takže mám pocit, že to je dobré znamení.
Nicméně, jsem zvědavý, jak se bude chovat v chladnějších teplotách a v dešti/sníhu (mělo by být odolné).
Celkově jsem spokojený.
Vakuový sáček lze znovu použít a prodejce přiložil opravdu roztomilou poděkovací poznámku, což byl skvělý dotek.
Toto je velmi pěkná sukně.
Krajka je elegantní a měkká.
Toto je velmi pěkná sukně.
Krajka vzor je elegantní a měkký.
Nevráší se, ani po zmačkání do plastu a krabice byla velmi hladká, což je opravdu skvělé.
To lze snadno obléci více neformálně nebo naopak více slavnostně a má takový vintage pocit díky délce a střihu, což se mi opravdu líbí.
Myslím, že toto by mohlo lichotit každému.
Měřím 165 cm a vážím 59 kg a objednal jsem si malou velikost, takže bych řekl, že pokud se cítíte, že jste na rozhraní mezi malou a střední velikostí, rozhodně si vyberte menší.
Nefungovalo to s mým Buick LeSabre z roku 1999.
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce byla předinstalována baterie.
Nicméně, i když by měl být kompatibilní s mým Buick LeSabre z roku 1999, dálkové ovládání se nepodařilo naprogramovat nebo synchronizovat s autem.
Instrukce jsou dostatečně jednoduché a vím, že jsem je správně dodržoval, protože jsem byl schopen úspěšně přeprogramovat můj starý dálkový ovladač.
Tento nový však nefungoval, a proto ho budu vracet.
S prodejcem nebo službou nebyl žádný problém, jen se zdálo, že tento konkrétní výrobek byl vadný nebo neslučitelný s mým vozidlem.
Dobrá cena za náhradu
Mřížka mého auta byla stržena něčím velkým, co letělo po dálnici, takže jsem potřeboval náhradu.
Bál jsem se po přečtení některých recenzí, že to nebude pasovat, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Nedělal jsem to sám - nechal jsem to udělat chlapíka v autoservisu - ale vypadalo to opravdu jednoduše.
Jen to tam cvaklo za méně než 5 minut.
Dal jsem mu 4 hvězdy za pevnost, protože to vypadá docela křehce (čas a létající trosky to ukážou), ale celkově jsem velmi spokojen, že můj vůz nyní nemá na přední straně děsivou díru a že cena byla rozumná.
Potřebuje zlepšení
Super skvělé světlo Můj 5letý syn toto světlo naprosto miloval. Nevydrželo dlouho, dostal ho k narozeninám v lednu a už v únoru má problémy s tlačítky a nesvítí jasně, když je zapojené do zásuvky, rychle vybíjí baterie, i když jsme zkoušeli dobíjet baterie. Super cool, ale potřebuje vylepšení.
Hudební začátek
Piano je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruky a oka.
Klavír není jen hračka, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu již v raném věku.
Pokud chcete, aby se z vašeho dítěte stal budoucí klavírista, měli byste vyzkoušet tento produkt!
Velmi stojí za peníze!
Aplikuji to na svůj nos, jak je uvedeno, dvakrát denně a vetřu to po dobu 2 minut.
Kůže na mém nosu se zčervenala a úplně se oloupala.
Byl jsem docela překvapen.
Měl jsem dobře zahojenou jizvu po pádu do ostnatého drátu z před několika let.
Nejenže tento produkt nefungoval, ale málem jsem skončil u dermatologa, nicméně nanesení aqua-for a náplasti na postiženou oblast to konečně uklidnilo po týdnu.
Můj nos je stále zarudlý, ale doufám, že to brzy odezní.
Někdo pokazil vzorec??
To je tak divné.
Při normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí malířského štětce z jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen moje kamera.
Růžová je barva, kterou používám nejvíce, takže mě to trochu rozčiluje.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červenými nebo růžovými.
Bílá není tak jasná, jak jsem doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy smývají.
Jen bych si přál, aby tam byla růžová.
Myslím, že fialová bude postačovat.
většinou funguje
Před několika měsíci jsem si vybělil celou hlavu a poté ji přebarvil černou barvou z krabičky.
Poté jsem šel a nechal si udělat melír po celé hlavě.
O několik týdnů později jsem si na vlasy nanášela modro/zelené barvy na vlasy Arctic Fox a nechtěla vyblednout.
Použil jsem tento přípravek s Olaplex No. 3 a výrazně to celkově zesvětlilo, odstranilo zelené a modré části, stejně jako odstranilo tmavé barvy z krabičkového barviva.
Nicméně, po dni jsem si všiml zeleného nádechu na mých vlasech.
Každý den je to horší a já jsem použil extraktor barvy už dvakrát, s týmiž výsledky.
Moje vlasy se také tmavnou tam, kde byla barva z krabičky.
Toto je skvělý produkt, jen se zdá, že nevydrží dlouho.
nevěřte propagandě
Příliš mnoho pětihvězdičkových recenzí na tento román by mělo být vyváženo několika realističtějšími hodnoceními.
Zkoušel jsem to číst, ale jazyk mi přišel plochý.
Metafora "sladkovodní" a mnoho popisů dělohy jako řeky a dítěte jako ryby působily násilně, otřepaně a uměle.
Přeskočil jsem dopředu a vypadalo to, že vše, co najdu, bude jen školní drama.
Dávám této knize 10 hvězd!
Vynikající čtení!!
Knihu jsem naprosto milovala!!
Během let jsem od Siri adoptoval 4 siamské kočky a všechny byly naprosto úžasné.
Jakmile začnete tuto knihu číst, je těžké ji odložit.
Vtipné, duchaplné a velmi zábavné!!
Siri se ve svých snahách o záchranu koček (hlavně siámských) opravdu předčila!!
Toto kruhové světlo se mi opravdu líbí!
Je to skvělé za tu cenu a splní svůj účel!
Jediný problém je, že žárovka se příliš rychle zahřeje a světlo zhasne, takže ji musím vypnout, počkat chvíli a pak ji znovu zapnout.
Nemyslím si, že se to mělo stát... Nevím, jestli mám vadné světlo nebo co, ale jinak je to velmi pěkné kruhové světlo kromě přehřívání.
Zmatený dějový příběh
Kniha byla těžko sledovatelná, protože hodně skákala z místa na místo.
Také titulek se nehodí k příběhu.
Autor uvedl, že několik lidí bylo nakaženo tímto vetřelcem, avšak vynechal mnoho detailů o tom, kdy nebo jak se to stalo.
Občas jsem byl zmatený a musel jsem se vrátit a hodně toho znovu přečíst, abych se ujistil, že mi nic neuniklo.
Miloval Collins...
Chvíli trvalo, než jsem si zvykl na Gradyho.
3 1/2 hvězdy Remedy je román o nejlepším příteli bratra, stejně jako o druhé šanci, smíchaný do jednoho.
Je to unikátní příběh a hrdina (Grady) musí udělat vše, aby získal Collins zpět a dokázal, že je pro ni tím pravým.
Před třemi lety měli Grady a Collins úžasnou noc spolu.
Collins si myslela, že konečně dostává vše, o čem snila, nejlepšího přítele svého bratra... ale když se ráno probudila sama a už o ní nikdy neslyšela, věci se rozhodně změnily.
Nyní se Grady vrátil, neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že ji tentokrát neopustí.
Ačkoli jsem milovala předpoklad tohoto příběhu a občas i Gradyho, opravdu mi šel na nervy.
Úplně chápu jeho důvody pro odchod té noci, ale neposlat ani dopis Collins, kde by se vysvětlil?
Nechat ji všechny ty roky v nejistotě a bolesti, a pak od ní očekávat, že ho uvítá s otevřenou náručí?
Byl snad paranoidní?!
Collins měl právo být naštvaný, rozzlobený, zraněný atd.
Měla pravdu, když s ním bojovala, když ji chtěl zpět a chtěl jít vpřed.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
V této knize jsem milovala Collins, byla silná a chránila své srdce, a obdivovala jsem ji za to.
Jistě, milovala Gradyho, ale byla vystrašená a váhala ho znovu pustit do svého života, kdo by neváhal po tom, co jí udělal?
Její postava byla rozhodně moje oblíbená z těch dvou.
Určitě nechala věci jít tempem, které chtěla, a když byla připravena poslouchat, poslouchala.
V této knize je hodně úzkosti a užíval jsem si sledování, jak se tito dva znovu spojují, když Collins začal odpouštět Gradyovi, jen bych si přál, aby Grady nepůsobil tak kňouravě a byl trochu více pochopitelný.
Stále tvrdil, že rozumí, ale občas byl ke mně trochu příliš dotěrný, a pak byl ke konci sladký.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla problém číst jeho pohledy, protože jsem se nemohla s jeho postavou spojit.
První část této knihy nebyla moje oblíbená, ale ta druhá část?
Zbožňoval jsem to, odtud moje hodnocení.
Pokud máte rádi romány o druhé šanci a o nejlepším příteli bratra, mohl by se vám tento kniha opravdu líbit, já jsem měl na začátku s Gradym problém a s tím, jak zvládal některé věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říci, že je to on.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho ztvárnění Churchilla, bylo velmi dobře uděláno.
Komprimovaný časový rámec od 10. do 26. května byl dobře prezentován s hodinami, které otočily 7 stránek...
Scéna a kostýmy byly vynikající.
Je dojemné s dnešní dvojicí polobohů držících světovou politickou pozici.
Stojí za to se na to podívat několikrát... stojí za to o tom hlouběji přemýšlet... mnohem vícekrát.
Vyhněte se Wifi připojení - jděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydleli jsme v hotelu.
Nepodařilo se mi připojit tuto váhu k Wifi v hotelu.
Rozhodl jsem se počkat, až se nastěhujeme do našeho domu a já si mohu nastavit vlastní Wifi systém.
Březen 2018 - Nastavil jsem svůj Wifi systém a tato váha se stále nechce připojit.
Pokaždé, když to zkusím, dostanu chybovou zprávu.
I když jsem 10' od jednotky Wifi.
Sledoval jsem instruktážní video na YouTube, ale bez úspěchu.
Když jsem jednotku kupoval, myslel jsem, že se přímo připojí k telefonu mé ženy (jako Bluetooth).
Místo toho tato váha komunikuje s telefonem pomocí Wifi routeru.
Tento systém je omezen na připojení k routeru...který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Tuto váhu bych nikomu nedoporučil kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které pro komunikaci využívají Bluetooth.
Nahrazuji toto váhou s Bluetooth připojením.
Dobré, ale rád bych našel něco lepšího
Po mnoha výzkumech jsem začal tento produkt používat před mnoha lety.
Mělo to nejmenší množství škodlivých složek a stále fungovalo dobře.
Nicméně, rychle vysychá, takže nakonec používáte hodně lubrikantu, což stojí hodně peněz a během sexu je to také příliš rušivé.
Byl jsem prostě příliš líný hledat nový produkt, ale začnu hledat takový, který je neškodný, dobře funguje a není příliš nákladný.
Životnost baterie je hrozná na tom, který jsem koupil na Amazonu.
Stále nemohu uvěřit, že Logitech přestal vyrábět toto dálkové ovládání, nic jiného se mu ani zdaleka nevyrovná.
Absolutně ZBOŽŇUJI tuto Harmony dálkovou ovládání, je to moje čtvrtá.
Pes rozkousal první, manžel se poklekl na obrazovku druhého a třetí stále funguje, ale uprostřed dotykové obrazovky je také loketní značka, díky manželovi...koupila jsem tento jako záložní a obrazovka je skvělá, ale baterie, kterou měl, vydrží nabitá možná na pár dní.
Můj původní (třetí) udrží nabití na týdny a používám svůj dálkový ovladač pro všechno.
Rozbilo se za méně než týden
Líbí se mi produkt, má hezkou velikost a barvu!
Bohužel jsem to měl jen týden a když jsem otevřel jedny dveře, praskl vrchní kus dřeva!
Jsem opravdu zklamaný!
Je to všechno sestavené a už nemám krabici, tak jak bych mohl i jen uvažovat o tom, že bych to poslal zpět?!
Můj manžel se pokusil to opravit dřevěným lepidlem, ale bohužel to také nefungovalo!
Dveře se hned zase vyskočily!!
Ne tak snadné sestavit plus....
Je to pěkný kus nábytku, když je sestaven, ale sestavení bylo obtížné.
Některé značení písmen bylo nesprávně označeno, takže jsem musel zkusit a zjistit to sám. Šrouby, které dodali pro připevnění podlahy a bočních panelů, všechny popraskaly.
Musel jsem vyjít a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také skleněné dveře jsou mimo linii a nesedí rovnoměrně.
Toto zarovnání brání tomu, aby jedny dveře zůstaly zavřené, protože magnet udržující dveře zavřené je mimo linii.
Stále jsem nezjistil, jak je zarovnat.
ŠPATNÝ KÓD VYTISKNUTÝ NA VRCHU KAPSY
Tyto jsem zakoupil v únoru.
Nedávno jsem se je pokusil použít a bohužel pokaždé, když jeden zkusím, mi můj stroj Keurig dá chybovou zprávu, že kapsle není kompatibilní s mým strojem.
Od doby, kdy jsem si poprvé koupil svůj stroj, používám v něm kapsle Donut Shop a nikdy jsem neměl problém.
Po podrobnějším prozkoumání kávového podu jsem si všiml, že kód vytištěný na vrchu podu není moc čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici s 72 kusy, což je 6 krabic po 12 kusech.
Dokonce jsem vyzkoušel jeden z každé ze 6 krabic a stále dostávám stejnou chybovou zprávu.
Vím, že to není na moji mašině, protože ostatní kapsle, které zkouším, fungují zcela v pořádku.
Je to jen z této zásilky, se kterou mám tento problém.
Velmi zklamáno, protože moje lhůta pro vrácení zboží již vypršela.
AKTUALIZACE: Mluvil jsem se zástupcem zákaznického servisu, který mi vrátil peníze.
Děkuji AMAZON za vaši skvělou podporu zákazníků!
Sladidlo na cestách.
Taková pohodlnost!
Je opravdu skvělé mít mou oblíbenou alternativu cukru balenou v malých sáčcích na cesty!
MILUJI swerve a je velmi pohodlné mít tyto k dispozici, abych je mohla hodit do kabelky na jídlo venku, nebo je použít u přátel doma.
I když jsou trochu drahé, nemůžu vystát Equal nebo tu růžovou věc v mém ledovém čaji.
Buď Swerve nebo nic, takže jsem nadšený, že mám své sladidlo s sebou!
Ve skutečnosti nečistí vzduch.
Koupil jsem to jako zvlhčovač, část o "čištění vzduchu" je ve skutečnosti klamavá reklama; v závislosti na tom, jak tvrdá je vaše voda, se na dně hromadí usazeniny, ale žádný z toho není prach ve vašem domě, pokud nežijete v uhelném dole nebo něco podobného.
Jako zvlhčovač bych ho hodnotil jako mírně méně účinný než zvlhčovač s knotem stejné velikosti.
Výhodou je, že nekonzumuje knoty.
Vzhledem k dodatečným nákladům na jednotku, pravděpodobně ji budete muset provozovat asi 5 let, abyste vyrovnali rozdíl.
Má poměrně velkou kapacitu vody pro svou velikost, protože 'nádrž' je integrální součástí jednotky a má nízký výkon (i když nelepší než typ knotu).
Je také poměrně snadno čistitelný, i když plastové disky nelze opravdu servisovat, protože diskovou jednotku nelze rozebrat.
Nicméně, pro německé inženýrství, kvalita konstrukce není skvělá.
Mám svůj už rok, což by bylo asi šest měsíců běhu v chladném počasí, a jednotka začala vyvíjet velmi otravný klepavý zvuk z ventilátorové sestavy.
Můj tip by byly ložiska ventilátoru, takže jen čekám, až se zde stane úplné selhání.
Jak již někdo jiný poznamenal, jakékoliv opravy jsou téměř ekvivalentní k nákupu nového vlhkoměru s knotem.
tl; dr - nestojí za tu extra cenu, lépe se vám bude dařit s vlhkoměrem s knotem.
Asi to bylo snazší rozbít, než si mysleli.
Dávám tomuto produktu 3 hvězdy kvůli tomu, že když jsem ho dostal, už byl uvnitř rozbitý.
Jakmile jsem to prozkoumal, uvědomil jsem si, že kdokoli to do krabice dal, dal to tam rozbít. Mohli to být buď balíčkovatelé výrobce, nebo pro dobro výrobce mohl být problém v tom, že kupující vrátil položku a tvrdil, že ji prostě nechce nebo nepotřebuje a Amazon možná neudělal dostatečně kvalitní kontrolu, když se to vrátilo.
Ve vší spravedlnosti kupující nemohl říci, že je to rozbité, protože by to Amazon nevzal zpět, což je dobré, zvláště u tohoto druhu produktu, ale tak či onak jsem já ten, kdo skončil s něčí nedbalostí.
Nicméně jsem dostal své peníze zpět, takže po zvážení a diskusi s mým partnerem jsem se rozhodl dát tomuto kupujícímu další šanci.
S tímto na mysli zvýším své hodnocení na vyšší hvězdu pouze v závislosti na tom, jak zákaznický servis zvládne tento příspěvek (alespoň tím, že se ho vůbec ujme) a pokud předmět dorazí v dobrém stavu, skutečně má možnost dělat to, co má dělat, a funguje dobře při tom, co má dělat.
Snadno se instaluje?????
Celkově jsem s tímto nákupem docela spokojen, ale instalace pro mě nebyla tak snadná.
Zkoušel jsem několikrát nainstalovat obě "zvonky" do zapojeného vysílače, ale bez úspěchu.
Byl jsem téměř připraven vrátit to jako nefunkční, ale rozhodl jsem se to zkusit ještě jednou a zkontrolovat baterie v zvonečcích.
Voila... z krytů baterií vyčnívaly malé plastové záložky, na které jsem táhl a vyšel plastový kus, který kryl baterii a bránil jí v práci.
Po odstranění těchto kousků plastu zvony fungovaly naprosto v pořádku a s tímto nákupem jsem byl naprosto spokojen.
Podivné je, že v uživatelském návodu není zmínka o plastu přes baterii, který musí být odstraněn, aby zvonek fungoval.
Bylo by to méně frustrující, kdyby to zmínili a já nemyslel, že problém je v tom, že instalaci nedokončuji správně.
Je to dobrý produkt s širokou škálou zvonečků, zvonění a melodií, které si můžete vybrat a je snadné je kdykoli změnit.
Jedna věc, kterou se ptají při hodnocení tohoto zvonku, je, jak je "odolný vůči počasí".
Nemohu toto komentovat, protože to bylo nainstalováno 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je to odolné vůči počasí, až do příští dešťové sezóny... pravděpodobně v listopadu.
Ztracený balíček - znovu mi naúčtovali
Vyrůstal jsem s těmito a byl nadšený, že je koupím pro svého syna, ale ztratili balíček s živými housenkami.
Řekli mi, že to vymění a tentokrát účtují polovinu za dopravu.
Po významné době strávené na telefonu mi nakonec znovu naúčtovali novou objednávku s nějakou slevou 3 dolarů.
Myslel jsem, že to bylo docela neprofesionální, protože nejen že to ztratili, ale vedli mě k tomu, že to napraví, jen aby mi nakonec účtovali téměř plnou cenu po 30 minutovém telefonátu s nějakým řečněním o poukázce.
Strávil jsem 30 minut na telefonu, takže jsem ustoupil a prostě koupil další sadu housenek.
Jakokoliv.
Funguje dobře po několika bolestech hlavy.
Měl jsem nějaké problémy s tím, aby to fungovalo.
Dodaný kabel nebyl dobrý - nebaterii nenabíjel.
Když jsem kabel nahradil svým vlastním, byl jsem schopen nabíjet a poté připojit zařízení přes bluetooth k PC.
Měl jsem potíže s nalezením PC software, ale když jsem napsal jejich podpoře, odpověděli do jednoho dne s správnými informacemi ke stažení.
PC program funguje dobře pro testování jednotky, jakmile zjistíte, který port použít (v mém případě port 4).
Přesnost a stabilita jednotky vypadají pro mou aplikaci velmi dobře, avšak nebyl jsem schopen se připojit k iPhone nebo iPad (zkusil jsem několik z každého) přes bluetooth.
Budu muset připojit dráty, pokud se rozhodnu použít toto zařízení v mém produktu.
... bylo příliš žluté před koupí a bylo mi řečeno, že je to jako staré zlato
Zeptal jsem se prodejce, jestli není barva příliš žlutá před koupí a bylo mi řečeno, že je to jako staré zlato, tmavší.
Nic blízko!
Sada vypadá VELMI levně.
Je to super lesklé žluté s mnoha CZ, ještě lesklejší.
Na fotce to vypadá skvěle, ale v reálném životě bych to ani nedal na nošení teenagerovi.
Miloval jsem ten prsten - ale nemohl jsem ho nosit pořád! :(
Tento prsten byl krásný.
Miloval jsem design a robustní pocit z něj; vypadal drahý a byl velmi pohodlný!
Jediným důvodem, proč jsem dal pouze 3 hvězdy a nakonec vrátil produkt, je, že jsem si uvědomil, že ho nebudu moci nosit pořád.
Mám rád, když nosím své prsteny pořád, a proto se vždy snažím získat stříbrné, a vím, že někteří lidé říkali, že jejich prsteny po čase zčernaly, ale já jsem svůj nosil asi týden v kuse - dokonce i při mytí rukou - a nevšiml jsem si žádného zčernání.
Zajímavé je, že problém, který jsem měl, byl ten, že vnitřní část prstenu mi skutečně zbarvila prst na bílo a zvlhčila ho - něco jako když necháte náplast na dlouhou dobu.
To se stalo i když jsem se ujistil, že prsten a můj prst byly zcela suché.
Nevím, proč se to stalo a nikdy se mi to s žádným jiným prstenem nestalo, ale stalo se to nepohodlné, takže jsem se rozhodl, že to není prsten pro mě.
:( Škoda, protože jsem to opravdu miloval!
Takže pokud si tento prsten kupujete s úmyslem nosit ho jen občas, říkám, jděte do toho!!
Nebudete zklamaní!
kupte si Pampered Chef...
Vlastním malou lžíci od Pampered Chef, ale momentálně se stěhuji, takže většina mých věcí je ve skladu.
Miluji používání těchto lžící při pečení pro dokonale porciované sušenky.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl se ušetřit nějaké peníze a koupit tu od OXO - obvykle se mi s jejich produkty daří dobře.
Ne tento.
Při přípravě asi třicátého sušenku s arašídovým máslem přestala fungovat páka uvnitř lžíce.
Musel jsem rozevřít rukojeti a přeřadit páku, abych mohl udělat ještě několik, a pak opakovat.
Takže... ušetřete své nervy a kupte si lopatku od Pampered Chef.
To stojí za to!
Už nikdy nekoupím Mr. Coffee
Byl to chvíli dobrý kávovar, ale vždy s ním byly problémy.
Pokud se vám dostala voda mezi černý plast a kov na konvici, mohla by unikat a voda by se vypouštěla po několik dní.
Poté se nám rozbila plastová páka, která umožňuje průtok kávy přes filtr do konvice.
Kontaktoval jsem zákaznickou podporu, abych se informoval o novém dílu, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je skvělý na přípravu kávy a její udržení teplé, ale má příliš mnoho dalších problémů, než abychom do něj investovali za současnou cenu.
Musíte koupit!!
Miloval jsem tuto růžově zlatou barvu a vše na ní bylo skvělé!
Jedinou věcí, s kterou jsem měl problém, bylo, že to bylo opravdu obyčejné.
Mám rád, když jsou rukojeti trochu více detailní a toho jsem si všiml ještě předtím, než jsem to koupil, a proto tomu stále dávám 5 hvězdiček!
Bylo to snadno čistitelné a vše bylo zabalené individuálně, což jsem považovala za velmi organizované a uklidnilo to mou duši lol miluji, miluji, MILUJI tu barvu a rozhodně bych to znovu koupila pro sebe nebo pro někoho, koho miluji!
Může být dobré na tyči, ale NE jako visící clona nebo ochrana proti počasí.
Stydět by se měl Audubon.
Instrukce vám říkají, abyste zástrčku protlačili otvorem v tlumiči a "Ujistěte se, že je pevně na místě."
JAK???
Je navrženo tak, aby přepážka jednoduše volně seděla na zátku, takže ji může jakýkoli tvor nebo sebemenší vítr posunout nahoru.
Můžete otočit zástrčku vzhůru nohama, takže palcové šrouby jsou na spodní straně krytu, ale bude vám trvat hodiny, než tyto šrouby otočíte; žádný nástroj to neudělá a jen ty nejmenší prsty by to měly snadno.
Trvalo mi přes hodinu, než jsem je nějakým způsobem připevnil, aby byl tlumič pevně připevněn k zátku.
Je to naprostá otrava.
Objednal jsem čtyři z těchto; tři, které jsem neotevřel, jdou rovnou zpět a já hledám lepší ochranné prvky proti počasí.
(Pojďme si to přiznat; nic takového, co by skutečně "zmatlo" veverky, neexistuje!)
Miluji mnoho funkcí těchto světel.
Koupil jsem si tuto lampu, aby doplnila světlo, které moje nové sazenice zeleniny dostávaly z okna.
Miluji mnoho funkcí těchto světel.
Výhody: Zaprvé, snadno se připevní na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak rostou mé rostliny.
Světla jsou na dotek chladná a ani při dotyku s rostlinami nezpůsobila škodu.
Věřím, že mé zelenině prospěly světla.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Nevyužil jsem časovač, preferuji je zapínat a vypínat sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené. Nevýhody: Nemyslím si, že tyto světla jsou dost silné, aby byly hlavním zdrojem světla pro sazenice.
Světla jsou malá!
Když světla vyhoří, budu muset koupit úplně novou jednotku.
POZOR...ZÁPACH JE VELMI ŠPATNÝ...ŠTĚRBINY PRO KARTY JSOU PŘÍLIŠ VELKÉ!
Když jsem toto poprvé viděl, myslel jsem, že je to krásné, ALE strašně to smrdělo.
Nejprve jsem si myslel, že to je vůně kůže, ale mnoho lidí upozornilo, že to je pach PLESNĚ.
Nikdy to nezmizelo, takže jsem to musel vrátit.
NAVRH, kapsy pro kreditní karty jsou příliš velké.
Kreditní karty se posouvají až dolů, špičky nejsou vidět, takže nemáte ponětí, která karta je kde a je velmi těžké je vyndat.
FOTO, KTERÉ UKAZUJÍ, KDE KARTY VYSTUPUJÍ, JE NEPŘESNÉ.
Je to velmi malé..
Obdržel jsem cestovní peněžní pásek a je mnohem menší, než ukazují obrázky.
Přál bych si, abych to nekoupil a stále budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel.
Nejprve musím říct, že barva je láska.
Mnoho věcí, které si objednám v barvě fialové, vždy přijde příliš světlé, příliš dětinské, příliš podivné, příliš neonové, co bych vám měl říct.
Ale tato barva byla hluboká a bohatá a já ji miluji, deštník je pevný a opravdu kvalitní.
Pravděpodobně nejlepší deštník, který jsem kdy měl.
Je dodáván s obalem a i když nemusí mít mnoho funkčních využití, opravdu to vypadá ostře.
Balení je hrozné - obdržel jsem 3 poškozené kytary
Velmi pěkně vypadající kytara.
Je škoda, že společnost neví, jak chránit svůj produkt.
Není třeba se snažit získat jeden, který není poškozen.
Vrátili jsme 2 kvůli poškození při přepravě a také třetí byl poškozen.
Vzdal se.
Posílají to v měkkém tenkém obalu s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné polstrování.
Skvělý koncept!
Stačí jen několik dalších vylepšení, aby se z něj stal opravdu skvělý produkt.
Opravdu cool koncept, pokud jde o karaoke.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil můj zájem.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl u všech ostatních možností souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené, jak to funguje, je to současně 1) osobní mikrofon 2) streamer / reproduktor hudby a 3) hlasový záznamník.
Celkově máte 3v1 zařízení, které zesiluje vaše hlasy a hudbu a nahrává vše, co z něj vychází.
V samotném mikrofonu ale není žádná hudba.
Má bluetooth konektor, takže ho můžete synchronizovat s telefonem a stáhnout si karaoke aplikaci, která může posílat karaoke písně do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Vezměte na vědomí, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je vybaven různými možnostmi pro nastavení hlasitosti hudby a vašeho hlasu (i samostatně!)
a dokonce má možnost nastavit úroveň ozvěny, takže skutečně zníte, jako byste byli v karaoke místnosti.
Některé věci, na kterých bych rád viděl budoucí zlepšení, jsou: 1) je zde nějaký otravný zpětný signál, který nezmizí bez ohledu na to, jak daleko od mikrofonu držím svůj telefon.
Pokud jste tohle vyřešil, rád bych to věděl!
2) Přepínače na střední části mikrofonu jsou neohrabané.
Jsem nadšenec pro minimalismus, takže by bylo skvělé, kdyby budoucí produkty mohly design zjednodušit.
3) podpora pro více karaoke aplikací Nakonec, protože zvuk vychází přímo z tohoto mikrofonu, a ne přes plochou obrazovku nebo centrální reproduktorový systém obývacího pokoje, není to tak zábavné v party prostředí.
Pokud by výrobce mohl nějakým způsobem integrovat toto do většího karaoke systému pro párty, stalo by se to neskonale zábavnějším.
Ošizený Vision Supplies
V říjnu 2017 jsem zakoupil čtyři (4) kazety od Vision Supplies - Amazon Marketplace, abych je měl k dispozici, když budu potřebovat a ušetřil na nákladech za dopravu.
Použil jsem dva během posledních pár let, zhruba jeden za rok, a fungovaly v pořádku.
Snažil jsem se použít jeden minulý týden, téměř prázdný po tisku 20 štítků, ale poslední došel po 40 stránkách.
Plast je na obou chybějící.
Bylo mi sděleno, že záruka vypršela!!!!
Kdo by při příjmu kontroloval každou jednotlivou kazetu????
KUPUJÍCÍ, BUĎTE POZORNÍ!!!!!!!!!!!
Omlouvám se, cože?
Můj přítel doporučil masku z této řady, takže jsem koupil tu, tento kondicionér a vše v jednom mléku.
Nemohu mluvit o účinnosti produktu, protože jeho zápach byl prostě nesnesitelný.
Znáte ten plesnivý zápach, který staré budovy používají v dámských toaletách, aby se pokusily zakrýt vůni *dám*, ale nakonec to jen vypadá jako ten kyselý, chemický, takový plesnivý zápach babičky?
Ano, to je vše, na co dokážu myslet, když to cítím.
Víte, každý máme jiné vkusy, takže vám ten zápach možná bude připadat příjemný.
Můj přítel řekl, že to může pomoci i nejvíce poškozeným vlasům, takže pokud vám nevadí vůně, pak žádné starosti.
Vím, že přírodní produkty nebudou vonět tak pěkně jako některé syntetické, ale mám pocit, že stále více přírodních řad se prostě méně stará, protože to stejně prodá, a tak teď všechno jen voní jako modelína.
Ztratil jsem několik oblíbených řádků kvůli tomu, že změnili recepturu na levnější suroviny.
Nevím, jestli je to tady případ, nebo jestli je to padělek (což jsem zavolal Davines a oni řekli, že to není), ale tohle voní jako Y U C K a musel jsem to vrátit.
Přerušení internetu
Koupil jsem tento modem/router před zhruba dvěma lety.
Na začátku to vypadalo v pořádku, ale poslední rok a více mám problémy s tím, že mi padá internet.
To se děje na všech mých zařízeních, jak na Wi-Fi, tak na kabelovém připojení.
Jediný způsob, jak obnovit službu, byl provedení resetu napájení AC.
To se dělo jednou nebo dvakrát denně.
Comcast přišel, položil nový koaxiální kabel od sloupku k domu a zvýšil úroveň signálu.
Stejný problém.
Technici z Arris Tech byli skvělí, ale problém nebyli schopni vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést tovární reset, abych to obnovil.
Na základě mé zkušenosti nemohu doporučit tento modem/router.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Mám to už přes týden a bez problémů.
Je rychlejší a má větší dosah než Arris.
Četl jsem online, že jiní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte internet od Comcast, nedoporučuji tento modem/router od Arris.
Získejte Netgear, je mnohem spolehlivější.
ale stává se to dost často na to, aby to bylo otravné.
Na pozitivní notu
Jeden z ventilátorů zněl nevyváženě hned po vybalení z krabice.
Ovládání rychlosti je opravdu nestabilní -- pokud je nastavíte na 100%, ventilátory se vypnou, takže je musíte nastavit na 100% a pak je pomalu snižovat, dokud se znovu nezapnou.
Kvalita zpracování je průměrná, ale to se zdá být normou pro většinu těchto typů produktů v této cenové kategorii.
Nohy pro držení notebooku, když je nakloněný, se několikrát odlomily...
Vrací se zpět, ale stává se to dost často na to, aby to bylo otravné.
Na pozitivní stránce, toto má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z ventilačních otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory uprostřed a poskytuje velmi málo dodatečného průtoku vzduchu notebooku s takovou konfigurací chlazení.
Ok pouzdro s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný - maximálně 3,5 nebo 4.
Problém je, že je k dispozici méně obalů pro Tab A 10.1 s perem.
Z těch je Gumdrop asi nejlepší, ale má několik vážných problémů.
Pouzdro z gumy (silikonu, cokoli) je velmi hladké a kluzké a nedává vám při držení Tabu jednou rukou moc sebevědomí.
Tab A je těžký, takže pokud ležíte a sledujete video, obal vám klouže v ruce, takže musíte často upravovat.
Musel jsem odstranit průhledný plastový štít, který pokrývá obrazovku, protože narušoval fungování dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní gumový vnější obal působí velmi flexibilně a křehce.
Nakonec to udělali obtížné dostat se k S pera.
Pero S je v pravém dolním rohu Tab A a malý gumový kryt, který chrání roh, se otevírá dozadu pro přístup k peru S.
To znamená, že pro vyjmutí pera S musí klapka otočit o 180 stupňů.
To je opravdu nepohodlné a těžké dělat s jednou rukou.
Tento obal dobře chrání můj Tab A, ale kvůli těmto vážným designovým chybám ho nemohu doporučit, pokud nemáte S pero, pak nemáte moc na výběr.
Vše, co jsem potřeboval
Tento produkt je opravdu skvělý - jediná zastávka pro všechny mé potřeby připojení.
Miluji, když mohu jen hodit toto a malý napájecí adaptér mého notebooku do mé tašky a být připraven pracovat na velkém 4K displeji nebo stahovat fotky z mého fotoaparátu.
Jedinou zvláštností, kterou jsem zažil (a zažil jsem to na všech 4 usb-c hubách, které jsem zkoušel od různých značek), je, že se zdá, že mac není schopen rozlišit mezi více stejnými monitory (takže můj mac vysílá stejné video na všechny identické monitory připojené k hubu, ať už pomocí HDMI a/nebo VGA).
Ale pokud použiji 2 samostatné huby/adaptéry nebo 2 různé modely monitorů, pak mac správně vystupuje na displeje individuálně.
Ok, potřebuje nějaké vylepšení.
Dobrý tréninkový nástroj, ale opravdu by měl mít nějaký druh bezpečnostní pojistky nad tlačítkem pro šok (stisknuto více náhodou, když je v mé kapse, než jsem ho skutečně zamýšlel použít) moje psi se dokonce náhodou šokovala, když šlápla na dálkové ovládání.
Také pokud se váš pes rád válečkuje v rakouním trusu jako ten můj, je to taková otrava ho čistit.
Jelikož se fekální hmota dostává do štěrbin zařízení, je nutné ho celé rozebrat, aby se ho dalo řádně vyčistit a odstranit zápach.
Také dosah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebujete přímý zrakový kontakt, aby to fungovalo.
A byly doby, kdy to vůbec nefungovalo, i když jsem byl od svého psa vzdálený pouze 30 stop.
Bytí dobíjecí je určitě pěkná vlastnost a nabití vydrží pořádně dlouho.
Potřebuji nabíjet svůj přístroj pouze jednou za dva týdny.
Dostanete to, za co zaplatíte.
Hrozný produkt, zavádějící
Koupil jsem si to jako tracker k použití při plavání a ani jsem nedostal řádnou šanci to vyzkoušet.
Předně, není voděodolný a v návodu k použití se nedoporučuje používat při plavání.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB konektor nebo počítač.
Dobře, máme jich tady spoustu.
Když se však pokusím ho vložit do portu k nabíjení, okamžitě se vymrští zpět ven.
Nejsem si jistý, jestli je něco nekompatibilní, nebo jestli je to prostě špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
Nakonec, aplikace neustále vyskakuje reklamy, i když je zavřená.
Reklamy se objevily, zatímco jsem posílal textovou zprávu, což je velmi znepokojivé.
Poté jsem ukončil všechny aktivní aplikace na svém telefonu a o 20 minut později, když jsem šel zkontrolovat čas, jsem viděl další reklamu.
Hrozný produkt, asi dostávám to, za co jsem zaplatil...
Skvělý batoh, ale příliš mnoho popruhů.
Tento batoh vypadá dobře a funguje dobře.
Je to skvělá nabídka, zvláště když to porovnáte s tím, kolik stojí batohy dnes.
Důvodem, proč jsem ubral hvězdu, je, že je zde prostě příliš mnoho popruhů.
Na tomto pytli je více popruhů, než dokážu spočítat.
Tyto přebytečné popruhy nakonec oříznu a spálím, protože většina z nich není skutečně nutná a jen mi překáží při otevírání a zavírání tašky.
Kromě toho jsem si to udělal svým novým školním batohem na vysokou školu.
V zadní části batohu je přihrádka přímo pro můj MacBook Pro a všechny mé knihy se dobře vejdu do poskytnutých kapes.
Vlajka také dodává skvělý závěr.
Můj pes to ještě nezničil.
Měl jsem problémy s hokejovými míčky.
Můj pes je miluje - její oblíbená hračka na aportování a žvýkání - a navíc plavou.
To je, dokud je nerozkouše na kousky.
Vyzkoušel jsem několik, dokonce i verze pro "horké počasí" - a vydržely o několik minut déle než ostatní.
Dokud se tyto neobjevily.
Tyto prošly testem.
Můj pes není velký, ale je tvrdohlavý v tom, co žvýká.
Jak se říká, nezáleží na tom, jak velký je pes v boji, ale jak velký je boj v psovi.
Palec nahoru od Daisy a mě.
Tento produkt je pro děti nebezpečný.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme zkontrolovali baterii a zjistili, že do oddílu, kam patří baterie, se dostala voda.
Baterie samy se rozpadly a z nich vytékala černá tekutina.
Při pohledu na design se zdá, že není možné, aby bylo pouzdro baterie vodotěsné, což znamená, že nejenže během koupání voda pronikla do kompartmentu, ale také z něj unikl nějaký z tohoto toxického materiálu.
Prosím, nekupujte tento produkt.
Jsem šokován, že to bylo povoleno na trh, přestože má tak zřejmou vadu.
problémy s přehříváním a obtížnosti s připojením ovladače
Dávám mu zatím 3 hvězdy, nechci nechat prodejci špatnou recenzi, pokud si ji nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, zda bych měl kontaktovat prodejce nebo samotný dji tello, ale pravděpodobně to zkusím u obou, abych viděl, co řeknou.
Líbí se mi, že tento dron je skvělá malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů se cítí více jako hračka než tento.
Nicméně je to jediný dron, u kterého jsem kdy měl problémy s přehříváním a skutečně to kazí zábavu z létání. Předpokládám, že je to výrobní problém, který musí co nejdříve řešit, pokud chtějí, aby byl jejich produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal použitý dron, když jsem zaplatil za nový.
Dám prodejcům uznání za dodání, protože dorazilo 1 den po nákupu.
Aktualizaci mé recenze provedu po kontaktování prodejce a dji tello.
Mám o tomto dárkovém sáčku jen dobré věci na řečení.
O tomto setu dárkových tašek mohu říci pouze dobré věci.
Byl jsem schopen zabalit všechny své vánoční dárky do tašek, dárkového papíru a krepového papíru.
Produkt je skvělé kvality a různé možnosti velikostí usnadňují výběr dokonalého pro každý dárek!
Vřele to doporučuji.
Prodavač je naprosto milý a pozorný.
Po mém nákupu se na mě obrátil, aby se ujistil, že jsem spokojen s mým produktem.
5 hvězd na celé čáře!
Fyzika je hrozná a lidé, kteří vytvořili hru, s tím neudělají nic.
Nekupujte tuto hru, fyzika je hrozná a jsem na tuto hru tak naštvaný, protože pravděpodobně je v každé hře asi 40 hackerů a hra.
Nedělají s tím vůbec nic, víte, prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím vůbec nic a hra stále dělá aktualizace svých postav, opravdu by měli aktualizovat fyziku, protože je hrozná, nekupujte tuto hru, fyzika je hrozná a mechanika je hrozná, lidé, kteří tuto hru evidentně vytvořili, byli vysocí nebo něco, protože je to jedna z nejhorších her, které jsem kdy v životě hrál, raději bych hrál Pixel Games než tuto hru, je to jedna z nejhorších her, nekupujte.
Ne jako ostatní hry Tomb Raider.
Od samého začátku to nepřipomínalo ostatní hry Tomb Raider.
Hratelnost je brutální v tom, že ovládání není chytré v poznání, jakým směrem se snažíte jít.
Nechává vás padat k smrti nejzbytečnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tuto hru jsem si neužil.
Neplánuji to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomický a cenově dostupný, ale ne moc tolerantní k neustálému používání
Má štíhlejší tvar, který lépe padne do rukou, nemá žádné ostré rohy, o které by se mohlo zachytit, a s napájecím kabelem jako stálou součástí je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Efekt vibrací, který je spuštěn při akčním hraní, se cítí mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebují.
Jsme velmi těžkopádní a obvykle nám do roka vydrží 2-3 ovladače.
Pro nás to znamená, že roční investice do ovladačů nás nutí být vybíraví a opatrní při tom, co nakupujeme.
Ovladač by mohl mít odolnější pružiny; po několika měsících přestanou reagovat tlačítka, která se používají nejvíce, a pravý joystick ztrácí své vycentrování, tedy způsobuje přiblížení mapových obrazovek a postavy jdou dopředu, aniž by se ovladače dotkly.
Dostanete to, za co zaplatíte
Byl jsem zklamaný, když jsem tento předmět obdržel, protože stříbrná část kolem obličeje se zdála být vyrobena z nějakého druhu levného plastu.
Nezklamalo mě to, že bylo vyrobeno z plastu, tolik jako fakt, že použitý plast mu dával velmi levný vzhled.
Pro mě, tento detail pokazil celý vzhled.
Také jsem mu nedůvěřoval, že vydrží každodenní nošení, takže jsem ho nakonec vrátil.
Byl jsem zklamaný, protože to vypadalo, že by to byla dobrá nabídka, kdyby to nebylo tím.
Pokud však můžete toto přehlédnout, pak by to pro vás mohlo být správné.
Bylo to dobře zabalené a dorazilo rychle.
Nic jako předchozí telefony Stylo, OBROVSKÉ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Zřejmě se mi Stylos opravdu líbily, vzhledem k tomu, že pokaždé, když vyšel nový, jsem ho koupil.
Nikdy ne kvůli problémům nebo poruše, ale protože jsem chtěl zůstat aktualizovaný a "v obraze" a to se mi povedlo.
Ze všech těch telefonů jsem nikdy neměl žádné problémy s samotnými telefony.
Když jsem tento nákup Stylo 3 prostřednictvím Virgin Mobile uskutečnil, byl jsem si jistý, že vše půjde hladce, jakmile telefon dostanu a nastavím, ale velmi jsem se mýlil v tomto předpokladu.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos tak úžasné.
Nikdy se mi nepodařilo tento telefon úspěšně převést na můj účet u Virgin Mobile.
S tímto telefonem jsem si pohrával o něco méně než týden.
Hledal jsem informace na internetu a zoufale volal, snažil se dát Stylo 3 prospěch pochybností, doufaje, že jsem to jen já, kdo dělá něco špatně, ale bohužel jsem strávil hodně času, protože to bylo 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Nenávidím to, že musím dát Stylo tak hrozné hodnocení a recenzi, ale byl jsem s tímto telefonem extrémně zklamaný.
Doufejme, že LG zlepší svou hru a dokáže vylepšit budoucí Stylos, pokud nějaké budou, ale tohle byl obrovský propadák.
Na světlé straně, vrácení a moje refundace proběhly hladce, ale to je tak všechno.
