Rozseknutá verze Jedi Rytíře se zhroutila, protože volala funkci z konce vtable.
Ukázalo se, že jsme předpokládali, že volání IDirect3D::CreateViewport() by vrátilo IDirect3DViewport3, který má na konci přidány další metody ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože to je jen vytváření viewport pomocí Direct3D objektu, ne Direct3D3 objektu.
Teď, já vím, že v praxi, IDirectXObject2 je typicky správná superset IDirectXObject, bez změněné funkce podpisy, a nové metody pouze přidána na konci.
Ale to není univerzálně pravdivé; v těchto případech je důležité, jaké rozhraní používáte k vytvoření daného objektu.
Takže, protože to platí, abych to opravil, musel jsem rozšířit implementaci viewportu, aby obsahovala metody IDirect3DViewport3, takže volání do nového bylo platné.
Předpokládejme, že věda alespoň částečně sestává ze seznamů objektivně faktických tvrzení o světě, která jsou pravdivá bez ohledu na jakoukoli teorii, kterou by mohla podporovat.
I kdyby to byla pravda, že takové fakta existují ve vědě, je stále možné argumentovat, že vědecké fakta jsou nabitá teorií.
Vědecké fakta jsou výsledkem experimentů.
Experimenty nevytvářejí fakta v tomto čtení, ale volba, které experimenty provést, kontroluje, které fakta jsou objeveny.
Některá fakta, např. o subatomárních částicích, mohou být výsledkem experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se to jinak podařilo.
Toto je velmi stručný náčrt věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi, které tvrdí existenci objektivních vědeckých faktů.
To není argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvedneme to o víkendu.
Hledal jsem dobrý první auto, a opravdu miluju estetiku 80. let.
Už je na převrácení a snížená výška jízdy.
Trochu jsem se prozkoumal, ale rád bych, kdyby někdo měl nějaké informace o tomhle autě.
Osobní zkušenosti?
Vím, že nejsou tak rychlé, jako ty.
#Vyvětrávání do Fediverse času.
Domácí partner a já jsme šli do obchodu s alkoholem na pivo a láhev bublíku.
Když jsme šli na výpis, pokladna je zcela zřejmá #trans žena.
Já, v šortkách a s tím, co bije ženu, a Domácí partner, celý tetovaný a s novým účesem, který sám popsal jako "který mě dělá vypadat jako neonacista".
Její tělo okamžitě ztuhlo a v jejích očích byl ten pohled strachu.
A pak jsme prostě... zaplatili za naše věci.
A poděkoval.
A já řekla, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale fakt, že se nejdřív bála, je zkurvený a já to nesnáším.
Tohle je ta nejhloupější časová os a já nesnáším dot com.
Nic nezastaví Donalda Trumpa, aby kandidoval na prezidenta, když je obviněn, poté, co je odsouzen, nebo dokonce z vězeňské cely.
Kdyby byl zvolen, nepochybně by se sám promítl, aby se dostal z vězení.
Ale nemůže se z vězení propustit.
Stačí státní guvernér.
Dva státy, které se toho účastní, jsou New York a Georgia.
Guvernér Kemp zřejmě odpustí Trumpovi, pokud bude odsouzen nebo dokonce obviněn Fulton County DA Fannie Willis.
New York je nejlepší naděje na zodpovědnost.
Existují významné důkazy, že komunikace v reálném světě nemůže být redukována na vysílání signálů s významem nezávislým na kontextu.
V této práci, založené na variantě klasického modelu signalizace Lewis (1969) zkoumáme podmínky pro vznik komunikace závislé na kontextu v situačním scénáři.
Zejména jsme prokázali, že tlak na minimalizaci velikosti slovní zásoby je pro takové objevení dostatečný.
Zároveň studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextovou deambiguaci symbolických významů.
Ukážeme, že environmentální omezení při výběru referenčního zdroje odběratele mohou být jednostranně využity odesílatelem bez možnosti rozlišování na konci odběratele.
V souladu se společnými předpoklady se zdá, že pro kontextovou komunikaci je zapotřebí vědomí odesílatele kontextu.
Navrhujeme, aby kontextově závislá komunikace byla situovaným vícevrstveným jevem, který je zásadně ovlivněn vlastnostmi prostředí, jako je například distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale stále umožňují téměř dokonalou komunikační přesnost.
Opravdu jsem si užil setkání s Penny a Nicholasem z Ashanti Development o víkendu, abychom si povídali o jejich pokroku.
Ashanti Development pracuje s stále rostoucím počtem komunit v oblasti Ashanti v Ghaně již téměř 20 let, angažuje se s komunitami a poskytuje podporu s vodou a sanitací, vzděláním, zdravotní péčí, výsadbou stromů a zemědělstvím.
Společenství získají znalosti, které mohou začlenit do svého vlastního rozvoje a podpořit jej.
Měla jsem to štěstí, že jsem v roce 2011 strávila památná šest měsíců s Nicholasem a podpořila řadu projektů.
Když jsme se o víkendu setkali, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
V roce 2007 se v rámci programu "Zdrojové zdroje" v rámci programu "Rozvoj venkova" uskutečnilo více než 200 projektů, z nichž největší část byla zaměřena na rozvoj venkova.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škodlivými organismy, jako je například pádový armádní červ, který může zničit kukuřičné plodiny.
Fotografie z mé návštěvy Ghany v roce 2011.
U obchodu UPS nedaleko mě nepustí napsat na štítek nebo na krabici.
Musí vytisknout štítek.
Nechtějí, abych jim řekl, na kterou adresu to jde a kdo to posílá.
Musím poslat e-mail na nějakou náhodnou adresu, s neformátovanými daty, aby si úředník mohl přečíst e-mail a vložit ho do svého systému, aby vytiskl štítek.
A vždycky mi za to účtovali 2,25 dolaru.
Další ráno a nemůžu se dostat přes Chris Lichtovu hanebnou předstíranou veřejnou službu v CNN včera večer.
Bylo to pobuřující, jako symbolický antidemokratický festival lží a nespokojenosti, který se konal 6. ledna a který se samo-zničivě pořádaly americké média.
Škoda diváků.
Licht souhlasil s republikánským publikem!
Kdo prověřoval a vybral jednotlivce?
Je tu příběh, který se musí napsat.
Hledání iluzorní nezodpovědnosti.
To se nemůže opakovat.
Mám ve sklepě velmi průvan, což v podstatě znamená, že se tam může schovat spousta hlodavců.
Za poslední měsíc se objevila spousta známek dalšího přítomnosti hlodavců, což je mimořádně překvapivé, protože je jaro a já bych si myslel, že se při změně počasí vydávají ven.
Nicméně, měl jsem hromadu obyčejných starých snap-pasti umístěné kolem, a by dutifullylyly doplnit arašídové máslo na ně každých pár dní, jako myši laskavě lízat čisté.
Včera večer jsem se toho rutiny konečně unavil, vyčistil všechny pasti z arašídového másla a přilepil k nim pistacii.
- Fungovalo to.
Ženo, vyzkoušel jsem skoro všechny "humánní" pasti na trhu s velmi malým úspěchem.
Nejsem moc rád, že je zabíjím, ale nebudu brát komentáře o etice zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se obalují do značky pro-business.
Nejsou, alespoň ne v Alberte.
Jistě, že snižují daně.
Ale také snížili dotace a daňové úlevy, které podporují více podnikatelské aktivity.
Mám podnik, který je úspěšný navzdory provinční vládě, ne díky ní.
Zjistil jsem, že v roce 2023 jsou webové stránky místních televizí absolutně nejhorší zkušenost na internetu.
Popup, automatické přehrávání videa, animace, pop-over a reklamy, reklamy, reklamy.
Vím, že reklamou vydělávají peníze, ale všechno to svinstvo je kontraproduktivní, když lidi odhání.
To platí i teď, když goatse.cx je pryč, i když by to byl těsný závod na dno mezi goatse a, řekněme, khou.com, kde jsem se snažil sledovat video, které mi Wendy poslala.
V prvním vlaku se nám kontrolka podívala na lístky a řekla "dlouhá cesta!"
"Ano, a já se dneska vrátím", řekl jsem.
"Jsem jen vysadit ho v Glasgow", Snažil jsem se vysvětlit, žehnaje na mé spolucestující.
"Není to něco, co slyšíte často, jen ho nechávám v Glasgow", řekl prodavač lístků.
To je něco, co jsem nikdy předtím neřekl.
To, co mě přesvědčilo minulou noc, je, že musíme být připraveni bojovat proti Trumpismu.
Trumpismus je kult.
Je to kult, který nikdo nechce, kromě fanatiků, kteří jsou v něm.
A jsou opravdu šílení.
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas se bránit.
Jděte ven a protestujte.
Sežeň si nějaké samolepky proti Trumpovi a rozlep je po celém autě.
Křič na ty, co by se o nás pokusili mluvit.
To není normální.
Tohle není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a já jsem ho slyšela z druhé strany ulice kašlat na kovidovou slinu.
Tak jsem se pospíchal do svého pokoje, abych se mu vyhnul, ale on se mi stejně podařilo dohonit, abychom si popovídali.
Přísahám, že lidé nakažení covidem jsou zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné vycházet na veřejnost nebo spěchat k lidem, když kašlete slizovou bouři.
Opakuji, není společensky přijatelné šířit svou bouři sliz Covidem všude!!!
Writing Wonders 5/11: Směje se váš MC více nebo pláče?
Abe skrývá své smutky a snadno se směje, zatímco Tom se nebojí plakat, ale je méně pobaven hrubým humorem.
Jan ti ublíží dřív, než ti ukáže, že je zraněná a nejvíc se směje, když je všechno vzhůru nohama.
Mio ví, že smutek je životní společník.
Po 4000 letech utrpení se Yl ocitla na místě lásky a má obrovské pocity, které neví, co dělat, takže je tam hodně obojího.
CNN musí prostě zavřít.
Včerejší fiasko s #MangoMoron bylo neskutečné fiasko.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "vedoucí" televizních zpráv zavolal, aby dal tomu tlustému, lživému zločinci tolik vysílacího času?
Vysoký tlak bude převažovat až do začátku příštího týdne.
Studená fronta by měla dorazit do poloviny příštího týdne.
Dnes ráno, IR satelitní a povrchové pozorování naznačují rozšiřující se oblast nízké vrstvy a nekonečné
Šprt student Arnie Cunningham se zamiluje do Christine, rezavého Plymouth Fury z roku 1958, a je posedlý obnovou klasického automobilu do jeho bývalé slávy.
Jak se auto mění, tak se mění i Arnie, jehož nově nalezená sebedůvěra se mění v aroganci za volantem jeho exotické krásy.
Partner v Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebuješ pomoc?
Kontaktujte naše Salesforce Consultants ještě dnes!
Najít spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám může partner Salesforce pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, což umožní vaší firmě prosperovat v ekosystému Salesforce.
Jedna z nejšílenějších částí toho, že se mí sousedi obrátili proti mně, je přemýšlení o tom, kolik úsilí je zapotřebí, abychom byli nepřátelští.
Zapomeň na mě, fajn.
Ignoruj mě, fajn.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zlomit mi dveře do obličeje vyžaduje úsilí.
Naši psi byli nejlepší přátelé.
A pořád nemám ponětí, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu přes 6 let.
Ta loď je mimo dosah.
Jsem si vědom vaší nenávisti k Orgány.
Ona je pro mě irelevantní.
Můžeš ji zabít, pokud to půjde.
Ale na palubě té lodi často letí jiný člověk.
Kdyby zemřel, následky by byly... významné.
Já si stěžuju na otcovství.
Tady je (trochu delší než) náhlý kurz o tom, co myslím tím otcováním:
Není to můj termín, je to termín používaný k popisu, kdy je příběh nebo herní mechanika postavená kolem hlavního protagonisty (obvykle staršího, obvykle mužského) hlídání nebo hlídání jiné osoby (často mladší).
The Last of Us je snadný a kanonický příklad otcovství.
Joel využívá své schopnosti a schopnost předvádět (extrémní) násilné činy, aby splnil úkol, který je kódován jako "starostlivost".
Tato teorie obvykle předpokládá, že řešením situace, kdy se musí rodič starat o dítě nebo dítě, je ohromující síla a použití této síly k vynucení velmi specifické síly.
Otcovství narušuje možnost společných řešení a často zcela ignoruje nebo podkopává veškerou volnost, kterou dítě má.
Takto je tato koncepce zastáncem mnoha neoliberálních ideálů, zejména myšlenek jako je bootstrapping a soběstačnost jakožto konečný cíl / ukazatel úspěchu.
Zde je krátký přehled o tom, jak využít naše webové stránky.
- Pošleme oznámení, až budou prodávány letenky.
- Poskytneme vám odkazy, kde si můžete rezervovat jízdenku.
- Neprodáváme lístky, ani neúčtujeme předplatné.
- Více podrobností je v plném blogu.
- Udržujeme seznam příkladů termínů rezervace pro každou nabídku, kterou zveřejníme a aktualizujeme tento seznam několikrát denně.
Ukrajinské děti mají právo vyrůstat v mírovém a bezpečném prostředí.
Přesto je nepředstavitelný strach, hrůza a vysídlení zanechaly s neviditelnou jizvou traumatu.
V úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby diskutovala o tom, jak podpořit její úsilí poskytovat pomoc v oblasti duševního zdraví zranitelným dětem.
Už jsme nabídli duševní zdraví a psychosociální podporu.
Všechny naše úsilí jim pomůže, aby se dostali přes tuto cestu.
Spousta zářivého nového dobrého v #dart
Časem se mi dart stal rychlým uživatelským rozhraním.
S #flutterem je potěšení pracovat a mají #mobx pro snadné řízení obchodu.
Příběh o závislosti je méně šílený než Nodejs.
Samozřejmě, že Flutter je na nic, pokud jde o chování jako dobrá nativní aplikace (kdekoli, opravdu. Dokonce i Flutter je na nic.
Ale umožňuje rychlý pohyb a proto je ideální pro malé hacky.
Echidna s ametystem a purpurovými špičkami.
Jsou průměrné výšky, mají průměrnou postavu a jsou svalnatí.
Mají extrémně tlustý ocas.
Mají malinové vlasy, krátké a kudrnaté.
Mají hruškové oči a nosí šarlatové brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upíří her na PC?
Schopnost skákat opravdu vysoko, roztrhat obyčejné lidi na kousky, používat strašidelné magické síly a obnovit zdraví tím, že se budete krmit na svých nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory všem snahám Brama Stokera, Maxe Schrecka a Stephenie Meyerové, aby se je snažili zkazit, všichni...
Zdálo se mi, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
V reálném životě máma měla ráda hádanku, kterou jsem před lety vytvořil, a většinu tajemství našla sama, takže nebyla jen máma, když řekla, že se jí to líbilo.
Takže možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Musím to přeložit do mandarínštiny a/nebo Hokkien, které neznám.
Asi budu muset zjistit, jestli Bing nebo Google jsou lepší v překladu špinavých gay sexuálních slovních hře.
Už nějakou dobu si s tímhle přemýšlím:
Duševní zdraví je často považováno za něco odlišného od "běžného" zdraví.
- Proč? - Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku, stejně důležitá otázka zdraví jako zdraví vašich nohou.
Intersex je dokonce uznáván TERF a podobně, protože je obecně fyzičtější a jako takový viditelný.
Stejně jako duševní zdraví je mnohými vnímáno jako méně "skutečné" než fyzické zdraví, tak mám pocit, že být trans je pouze intersex duše.
Čím více čtu o studiích o sexu, pohlaví, psychologii, tím více se mi zdává, že tvrzení "Můj pohlaví je mužské, moje pohlaví je ženská" je zjednodušené a nepřesné.
Skoro to vypadá, jako by se část argumentů přenechala TERF.
Myslím, že být trans znamená být "biologicky nebinární".
Moje pohlaví je nebinární, moje pohlaví je ženský.
Myslím, že označení "nebinární" by mělo být rozšířeno z genderového pojmu, aby se používalo při odkazu na sex.
Poslouchám díla @iotara.
V záhadném kolektivu je spousta dobrých věcí.
Jako třeba krauty moods a další světová popová hudba a radiofonické dílny a všeho druhu.
Hodně za to, abychom to zkusili.
Také FWIW se mi líbí rozhraní archive.org mnohem více než desktop #bandcamp \- Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si hraju s Flutterem.
Nerad bych založil svůj byznys na technologii od Googlu, abych byl upřímný, na druhou stranu je Google jedním z mála velkých hráčů s opravdovými motivacemi k vytvoření přesvědčivého zážitku přes platformu a to se ukazuje.
(A také: Web je dnes bohužel převážně věcí Googlu)
A také mi prosím neříkejte, že aplikace Google/Flutter jsou na iOS a macOS špatné.
Je těžké dělat cross platform, pokud to chcete udělat dobře.
- Já vím.
Děkujeme všem, kteří si stáhli nejnovější aktualizaci Leasey.
Objevila se několik velmi malých obtíží.
Nic, co by vyvolalo poplach, ale přesto se na ně obracíme.
Příští týden bude vydána malá aktualizace, která je opraví.
Většina včerejška byla strávena instalací nové aktualizace pro některé zákazníky, a všichni, kteří potřebují pomoc, by ji měli mít již dost.
Přeji pěkný den!
Tech přiznání: Nemůžu se zamotat hlavu kolem Grafana & Prometheus, alespoň z hlediska server / aplikace metriky a monitorování.
Nevím přesně, proč to můj mozek nedokáže pochopit; může to být proto, že nástroje jsou tak široké a nejasné, že můj mozek se zdržuje kvůli "příliš mnoha možnostem".
Chci dělat palubní desky.
Grafana vypadá hezky.
Mozek nepracuje.
Takže s novým #FFXIV raidem, který se blíží, jsem dlouho přemýšlel "chlape, rád bych zkusil pořádný raid, ale Party Finder zní jako bordel a nikdy nenajdu statickou, která by mě měla".
Tak jsem si řekl, do prdele!
Udělám si vlastní ruch!
Plné lidí, kteří se příliš snaží připojit k nájezdu statické, bez očekávání, že bude dobrý vůbec!
To by asi fungovat nemohlo!
A tak jsem se ocitl v situaci, že musím vyřídit seznam nájezdových skupin.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a já ztratil veškerou vášeň pro fikci a skvělé vyprávění.
Ale po ~desítkách~ let téměř nečtení (s výjimkou funkčních pracovních nefikčních věcí a příležitostných knih o sebepomoc) jsem si stanovila cíl přečíst 23 knih v roce 2023.
Jsem teď na knize číslo 31 a je teprve květen.
Jsem zpátky, zlato!
Nic jsem nedokázal.
Jsem rád, že ke mně pár lidí přišlo a řeklo: "Podívej, díky tvé práci ti dám tuhle částku peněz".
Chci vidět ty společnosti, které zprostředkovávají transakce vysvětlit svým zákazníkům, jak nastavit jejich procenta.
Nebudou o tom mluvit v Bloomberg!
Ale pokud Spotify bude mít dobrou čtvrtinu, tak ano.
Je nebezpečné nechat migranty na jižní hranici?
Ať obnoví vyvrácená a rozpadající se města po celé zemi.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pravicoví příznivci diktátora... to je nebezpečí.
Deportovat všechny rasisty.
Jsem unavená z titulků, které tvrdí, že "práce na dálku je mrtvá" nebo že "práce na dálku byl neúspěšný experiment".
Tyto titulky a články obvykle zmiňují jednoho ředitele jedné velké společnosti.
Je to jen návnada na kliknutí, ale znepokojuje mě to, že vedení a manažeři, kteří si tyto články přečítají, budou mít problém.
Před rokem 2020 existovala práce na dálku.
V dohledné budoucnosti budou stále existovat práce, které lze vykonávat na dálku.
Práce na dálku je příležitostná.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných, hlučných kancelářích.
Umožňuje přístup všem, kteří mají připojení k internetu a dobré pracovní prostory.
Umožňuje lidem vyhnout se dlouhým dojížděním, které jim berou čas od jejich denního života a jejich rodin.
Ignorovat tyto skutečnosti je špatné.
Přestaňte generalizující a snažte se pochopit, jak vaši zaměstnanci skutečně práci dokončit.
#WFH #business #neurodiverzita
Nejsou to jen konzervativci proti progresivcům, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Tohle je válka mezi pro-lidmi a anti-lidmi", řekl.
Parkerová se zmínila o potratech a impulsu moderních městských žen, aby zdržely porod kvůli kariéře.
Také tvrdí, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
"Jste uhlík, který se snaží snížit".
Takže od začátku, na všechny mé narozeniny v minulosti, jsem měla vždycky těžké.
Kdykoliv se objevila May, bála jsem se oslavovat svůj narozeniny.
Vždycky se něco stane, něco se pokazí, nebo to skončí stresujícím a depresivním.
Celé ty roky jsem bojoval, abych se z toho dostal a měl lepší dny.
Trvalo to roky změny mého života a tvrdé práce, ale nakonec...
Začínám se usmívat a užívat si svůj den bez starostí.
A dnešek se už začíná stát skvělým dnem!
Zima je za 30 dní v této malé části Velkého Jižního světa.
Ale já se nenechám oklamat!
Tohle je začátek.
Prší a dokud není zmrzlá, tak v ní nebudete tančit!
Je to krásný den na objednání zmrzliny.
Byla to noc pro jednoho psa a ten pes neskládal z postele ani na "Psí snídani - Snídaně pro psa!"
Zapnu si podšívku do motorky - pro případ, že bych ji potřebovala uvnitř.
Znáte nějaký výkonný způsob, jak webová složka reaguje na přidání/odstranění z dokumentu?
To je pro Wikipedii komponentní knihovna (OOUI).
Je to většinou sémantický HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízejí connectedCallback).
V současné době používáme MutationObserver hack.
Pro výkonnost, nesledujeme celý dokument.
Vytvoříme oddělený dočasný rodič, nainstalujeme tam MO a pozorujeme, jak se odděluje (a tak je připojen jinde).
Casper je v dnešní době naprostá jednotka.
Myslím, že moje nová práce mu prospěla - dvě volné procházky denně, když pracuji, v docela předvídatelných časech.
Konečně mám dobrou fotku, abych si byla jistá, že není tlustý.
(U #krys může být příliš vysoký obsah tělesného tuku špatný pro jejich zdraví.)
- Ne, není.
Je úplně na dně, protože se dvakrát denně vrací do mé kanceláře.
Nemám váhu, ale cítí se, jako by měl víc než půl kila.
Jsem tak šťastná, že se mu daří.
Dnešní zpráva o průběhu Aerostrike:
1) Malé úpravy na mapě Hel's Fighters.
Navíc, mapa je plně funkční!
2) Systém měnové odměny byl připojen.
Zítra to bude testováno různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal spoustu a cítím se o hodně lépe ohledně věcí z terénu.
Všechny koláče, kapusta, chard jsou přeložené.
Plánuje se na Penn v salátu na 6 řadě a uvidíme, jak to bude vypadat v porovnání s vysílanými postelí.
Jarní hrášek se objevuje v Gilpinu, takže je třeba nastavit trellis.
Také potřebujeme zasít řadu salátů, aby se integrovaly řezané zeleniny. Oba mají vyškolenou posádku na zavlažování, přípravě lůžek a transplantaci, což je 90% ne-sklizeň dovedností.
Je rok 2023 a stále vidím lidi s iPhonem, kteří se aktivně vyhýbají používání Apple Map.
Apple Maps jsou standardně k dispozici s iOS, a přesto lidé dělají vše pro to, aby si stáhli a nainstalovali Google Maps na své iPhony.
Nemám ponětí proč.
Z zvědavosti jsem si nechal otevřenou mysl, abych porovnal, jak se porovnávají Google Maps a Apple Maps, na mém testovacím zařízení iPhone (můj denní ovladač je zařízení Android, takže používám iPhone jen zřídka).
Zkušenost s následováním směrů byla na Mapách Apple mnohem lepší než na Mapách Google.
Apple Maps vyhrává.
Tak proč se lidé snaží nainstalovat Google Maps?
- Nemám tušení.
Je možné, že Google Maps se dostala na trh jako první?
Byla to katastrofa s Apple Maps v roce 2012?
Je možné, že je Google Search integrován s Google Mapy?
- Nemám tušení.
To znamená, že jsem zaujatý.
Jsem za to, abychom nespouštěli odpadky koncovým uživatelům, a Apple si to s jejich mapami v roce 2012 pěkně posral.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to země, která z ní dělá dobrý sklad bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům ztrácí hodnotu, protože ztrácí svůj stav a potřebuje být nahrazen.
Mnoho lidí si myslí, že když kupují kus země, tak ji doslova vlastní.
- To není případ.
V Číně můžete jen pronajmout půdu.
Nejsou tak hloupí, aby prodávali navždy.
Vláda může změnit tyto zásady kdykoli bude chtít.
Ta země je dočasná.
Zdá se nemyslitelné, že by vám mohla být jednou odebrána půda, když se díváte na australské a americké mediální kanály, ale to je proto, že bohatí jsou tam celý den a zajišťují, že vaše mysl myslí určitým způsobem.
Země může být jednou velmi snadno a rychle odňata vládou, pokud to bude chtít.
A hádej co?
Nikdy jsem nepochopil, jak si lidé mohou udržet půdu na úkor druhých.
Jednoho dne ti ho musí vzít.
Proto Číňané umožňují pouze pronájem.
Už jim došly pozemky.
Na úspěch, uskutečnění snů, přátelství, na to jednoduché, ale pravdivé!!
Všem investorům, kteří jsou venku, připíjím na váš úspěch a uskutečnění vašich snů.
Pokračujme v naší společné práci na vytvoření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, pojďme si vážit těch jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm#geolog #podnikatelství #udržitelnost #úspěch #přátelství #přípitek #sny
Často se divuji, jak je možné, že člověk je *tak* sám sebou, když je zaplaven tolika důkazy o tom, jak skutečná krutost vypadá.
Trpět nad osobním selháním a vinou ve světě, kde "úspěch" je tak často udělován lidem zodpovědným za ty nejodpornější činy...
Všichni jsme tak chaotičtí tvorové.
Ale mírné zoufalství nad naším nepořádkem je zásadní - protože nám dává více prostoru, abychom se vypořádali s ruinami všude kolem.
Tak se snaž nezapomenout, jo?
Milost k sobě samým je také aktivismus.
Někteří programátoři: "Rychlost psaní na počítači nezáleží!"
nebo "Modální editory jsou dnes k ničemu".
Já extrahuji funkčnost svých projektů #Axum do sdílených knihoven: "Hold my keyboard"
Nejsem si jistý, zda je to nejlepší přístup k sdílení, ale zatím se mi to líbí:
Poznámka: Můžete si vzít inspiraci, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Tento týden je v Revelations téma "Budej vzhůru celou noc".
Už několik dní si s tímhle kouskem na hlavě hraju.
Rozhodně je to víc romantika než špína.
Možná jsem četla spoustu románků s nemožnými 'potkávkami' a tohle je výsledek, ale líbí se mi to.
Taky jednou budu mít milový orgasmus, možná ne s str
Nesouhlasím s tím, že #Mastodon je obtížné nastavit.
- To není tak těžké.
Ale je těžší najít lidi, které budete následovat a budovat svou časovou osu.
Kéž by tu bylo nějaké doporučení, komu mám následovat.
Ale kromě toho to není těžké - pokud používáte aplikaci třetí strany jako Elk a/nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá to dobře.
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali a pravděpodobně potřebujete dobrou aplikaci, abyste zlepšili #UX.
Nevím, jestli je prevence možná, ale stojí za to to zkusit.
O čtyřech krocích, které jsem načrtl, se nyní diskutuje, přičemž v každém z nich došlo k určitému pokroku:
Popis: názvy pro případy chování člověka a algoritmu, které se týkají algoritmů a lidí.
Vysvětlení: zohledňují se obě strany vzájemného vlivu
Předvídání: předvídání škod dříve, než k nim dojde (i když jen o několik minut)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých hranic důvěry
Neviděl jsem radnici CNN, ale zdá se, že Trump řekl přesně to samé, co říká pokaždé, když otevře pusu nebo zmáčkne tlačítko "Vyslat" na svém telefonu.
I kdyby je nemohl říct během radnice, každý v Americe je stejně uslyší, opakovaně, od teď do listopadu 2024.
To ještě není důvod dát mu jiné místo, ale škody jsou přehnané.
Vyhraje primárky.
Nemůžeme ho odvézt.
Je tady a řekne to, ať se děje cokoliv.
Zapsala jsem se na seznam čekání na "AI Test Kitchen" a dostala se tam ve stejný den.
V tuto chvíli to není moc uspokojující.
"MusicLM Demo" je mírně zajímavý.
Můžete požádat o konkrétní skladbu jako "jazz s trubkovým sólem v 5/4 tempu" a po několika vteřinách vám to vytvoří dvě skladby.
Zdá se, že rozumí tempu, ale... hudba prostě... není dobrá.
Ne, že bys kvůli GPT hodil všechno, co máš, přes plot.
Zkus víc Google.
Je to divné dělat vzpírání, ale zároveň nemít tušení, jaká je vaše maximální výkonnost, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám ve svém pokoji bez pozorovatele nebo dokonce bez váhové stojany.
Jen já a ta činkárna s hromadou závaží.
Já si na postel sednu.
Pokud se pokusím zjistit, že můj maximální výkon je jeden opak, možná nebudu mít dostatek váhy na maximální výkon, nebo naopak, může mě to vážně zranit/zabijí.
Každopádně, dnes se nám zvedne náklaďák.
Pořád je to dobrý.
Přísahám, že burrata před pěti lety neexistovala.
Tohle je můj osobní Mandela efekt.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem ho neviděl v luxusním obchodě nebo v žádném italském delikatesním.
Nikdy jsem neviděl, aby to něčí máma dělala, nebo mi to někdo na párty strčil, nebo jsem to neviděl objevit se v souvislosti s něčí výpravou na výroba omáčky nebo pečení.
Jednou se objevila a najednou byla dostupná všude.
Vstoupil jsem do dimenze burraty.
Drakeův iPad se vyčerpává, tak hledá nový tablet.
Protože jsme tady byli radikalizováni, jsme zdráhaví koupit si nový FAANG stroj.
Má někdo z vás Linuxový tablet, který miluje?
To by bylo hlavně pro prohlížení webu, příležitostný e-mail a některé hry.
V letech 1998-2006 Gamefan, ve vztahu k dlouhému vývoji první hry Unreal, Jason Schrieber komentoval,
"Dobrá hra je pozdě, dokud se neodešle.
Špatná hra je špatná navždy".
Takže to bylo Epic, kdo to vytvořil?
Můžeme pokračovat.
V dřívějším vydání GamePra 1997-11 je citát s mnohem více nejednoznačností,
"Nebo, jak říká průmyslová fráze: "Pozdní hra je pozdní, dokud se neodešle.
Špatná hra je špatná po zbytek života".
Je to tak krátkodobé?
Je to jen "přitažlivá fráze" bez jasného původce?
Smoky, můj 10měsíční koťátko, si hraje s červeným gumovým Apple Pencil, který koupil na Amazonu a před měsícem utekl.
Nosí ho v ústech hrdě po celém domě a já se musím smát vnitřně.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsme absolvovali kompletní cestu na novém vlaku ICNG.
Opravdu se mi líbí.
Hlavně vozy s většími okny.
Jsou tu místa, která by potřebovala trochu leštění.
A to nedostatek dostatečných odpadních košů a nedostatek značek, které by vysvětlovaly význam barev osvětlení.
Vyřeš ty drobné problémy a pak nám dáš víc, prosím?
Nebudu smutný, až uvidím konec ICM nebo DDZ akcií.
Pravidlo jednoho zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo stojí ve frontě, mohl dostat do rukou desku.
Můžete si koupit JEDNO z výše uvedených desek, ne jednu z každé.
Na Picos nebo jiné zboží nejsou žádné omezení.
Včera jsem se bavil s mým přítelem a bývalým kolegou rabínem.
Na pár hodin jsme se viděli na mém verandě.
Takové přátelství překonává rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Bůh vám žehnej a ochraňuj vás!
A bažina se zelení.
Docela se mi líbí software a doména, kterou jsem pro svůj příklad dostal.
Ale mám pocit, že jsem začal špatně, abych tak řekl.
A nikdy jsem se tam necítil dobře.
Ještě se tu chvíli zdržím a přemýšlím, jestli bych neměla vůbec emigrovat.
#FalconGameBooks
Zdá se, že osmoký repnidi sledují, jak položíte leták na červenou půdu, ale nehýbou se směrem k vám, ve skutečnosti jsou nehybní, když vylezete z letáku a pomalu jdete k nim.
Země pod vašimi nohama se začne třást a pak se třást, jako při zemětřesení a vy ztratíte své postavení, ačkoli Repnidi se zdají být neovlivněni.
Skála pod tebou se náhle rozpadne.
Repnidi se v tunelu pod povrchem a ty spadneš do vroucího množství stovek těl Repnidů v jeskyni pod námi.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskra znečišťuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl první člověk, který cestoval do budoucnosti.
Přistaneš s nosem nahoru na straně hromady šrámů a vylezeš ven.
Osmioký repnidi se zdají, že tě sledují, ale nepohybují se k tobě, ve skutečnosti se nepohybují, když k nim pomalu kráčíš.
Zastavíš se, zatímco jsi stále na kopci rozpadlé skály a půdy, a promluvíš k nim a řekneš: 'Přišel jsem v míru, jako přítel.'
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladatel nedostává žádnou odpověď.
Rozhodl ses použít své psychické vědomí, abys je mentálně kontaktoval.
Je těžké pochopit jejich myšlenky; jsou ti strašlivě cizí a tvoje mysl se od toho kontaktu odvrací.
Rozhodnete se, že navázání kontaktu bude nebezpečné a vrátíte se ke svému letadlu, ale zkušenost vyčistila vaši mysl, která byla zmatená od té doby, co jste skočili do budoucnosti.
Jakmile se vrátíte do Falcon's Wing, zjistíte, že je docela snadné naplánovat kurz k Zemi v roce 3034 našeho letopočtu.
Všimněte si, že při skoku jste spotřebovali další polybdenovou tyč.
[ pokračoval ]
Dnes mám kávu, slunce a klid!
Začala jsem nový šál.
Nejsem si tím teď jistý.
Našel jsem nerovnoměrně spředenou stříbrně šedou nit, která je většinou jemně spředená s hrudkami.
Plánuju to smíchat s jemnou fialovou/lilacovou různobarevnou bavlnou.
Ale nejsem si jistá, jestli mám dost fialové.
Používám hák typu H s podobným vzorem dvojitého háčkání, jako jsem to dělal předtím.
První jsem se připojil včera večer, takže uvidíme.
Přeji vám všem šťastný čtvrtek!
Nicméně, nesnáším kurzy výtvarného umění a literatury, a moje školní historie to potvrzuje.
Doslova jsem to zkoušela a nechala jsem je všechny.
A až do před dvou lety jsem to netušil, dokud jsem si nezkontroloval záznamy.
Nenávist v literární třídě je ještě horší: miluju čtení.
Většinu klasiky jsem četl před osmnácti lety, ačkoli to je spíš odraz života v blbém nikde, také jsem v zoufalství četl Encyclopedia Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a jsem tam šťastná, ale musím být někde jinde, abych se mohla dostatečně uvolnit a během dne číst fikci bez pocitu viny.
Je to jako bych byl na dovolené a proto dělám to, co se dělá na dovolené.
A to i přesto, že jsem tu poslední dvě noci nespala tak dobře jako doma a trochu jsem se z toho, že jsem v tak podivném prostředí, kde se nemůžu udržet v klidu a musím si pamatovat, kde jsou věci, trochu vytratila.
A to i přesto, že mám pořád svůj seznam úkolů a pořádám si život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervově vyčerpávající, stresující a všechny ty dobré věci, které miluji na práci ve hrách.
Co si o tom lidé pomyslí?
Líbí se mi to, ale bude to schopné přilákat publikum správných hráčů?
Rozkvete se komunita kolem obsahu vytvořeného uživateli?
(To opravdu doufám.)
Příběh hry, myšlenky a otázky, které inspiruje, jsou aktuální.
Doufám, že to půjde dobře.
Je den ThinkPadu!
Přišel jsem domů na oběd, abych viděl tohle venku u Uwu.
Kéž bych si ho mohla vzít zpátky do práce, abych si mohla připravit víc.
Ale to bude muset počkat do večera.
Tak jsem se konečně podívala na #Heartstopper
Bylo to moc roztomilé, až na to, že to bylo na twee?
Rozhodně.
Mluví některá z těchto postav jako lidské bytosti?
Ani zdaleka.
Ale miloval jsem to?
- To rozhodně!
Co tady dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno absolvovaný umělec dnes večer špatně vzal nějakou kritiku.
Částečně proto, že by se špatně učili.
Ale je důležité nevymlouvat se za problémy a jen je napravit, zvláště ve výrobě, když váš vedoucí potřebuje změny.
Zvlášť s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tam, aby rychle napravila problém, a není zaměřena na vaše schopnosti.
Předpokládá, že máte schopnost vyřešit problém, nebo najít řešení.
Takže kompostování a blum scrolling jsou úžasnou připomínkou, abychom se podívali nahoru a byli si vědomi života za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak se semínka zasévá a pěstuje (a ne náhodně rozptýlí) dobrými lidmi.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu ten vzkaz podstrčil, když se potkali na cestě, těsně před sledováním psa.
Ona byla na cestě ke zdi, on se vracel z služby.
Podíval se za sebe, aby ji sledovat jít, a ujistit se, že nebyli viděni.
Neohlédla se zpět.
Čekal, až bude v temnotě ložnice, než vytáhl vzkaz a přečetl ho ve světle, které přicházelo z zastíněných závěsů.
Jedno slovo v blokovém tisku.
Strávil dlouhou dobu zíráním na něj, snažil se zůstat v klidu:
V poslední době jsem potkala pár úžasných nových #Mastodon partnerů a chci tento trend udržet.
Když volám do #Fediverse, cítím se jako velryba zpívající v obrovském oceánu!
Chceš se přidat k mému "pod"?
Rád bych se spojil s více lidmi.
Každý, kdo má vlasy v plamenech kvůli CNN, může poděkovat Stephenovi Colbertovi za těžký odboček doprava.
Pomohl udělat z Chrise Lichta národní problém.
I když bychom někteří lidi rádi viděli, pokud jen poskytují fašistům kariéru v menší lize, měli by ji nosit.
Bylo to poprvé (ale nebude to naposledy), kdy Kaveesha Dilhariová v jednom T20I získala více než 20 běhů a 2 nebo více úderů.
Přidá se k vybrané skupině srilanckých žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 lidí po násilné demonstraci před hotelem pro uprchlíky v Británii
Tento incident nastal poté, co se zvýšil počet uprchlíků a žadatelů o azyl, kteří přeplavili kanál La Manche do Británie loděmi.
Policie zatkla 15 lidí po protirefugee demonstraci před hotelem, který byl použit k ubytování žadatelů o azyl, se stal násilný poblíž anglického města Liverpool.
Policie Merseyside oznámila, že jeden policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek v noci v Knowsley.
Policie uvedla, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zatčení lidé, jejichž věk se pohybuje od 13 do 54 let, byli zadrženi "v důsledku násilných nepokojů".
Policejní komisařka Merseyside Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zraněných".
Podle místních médií používá ministerstvo vnitra hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který reprezentuje Knowsley v britském parlamentu, řekl, že násilí v pátek večer neodráží komunitu.
"Lidé z Knowsley nejsou bigotní a vítá lidi, kteří utíkají z některých z nejnebezpečnějších míst na světě, aby našli bezpečné místo", řekl.
"Ti, kteří dnes demonstrují proti uprchlíkům, tuto komunitu nezastupují".
Protesty se odehrály uprostřed zvýšeného napětí, když rostoucí počet uprchlíků a migrantů přeplavil kanál v malých lodích.
V roce 2022 se touto cestou do Spojeného království dostalo více než 45 000 lidí, z nichž většina požádala o azyl.
Systém pro posuzování žádostí o azyl se zpomalil kvůli politickým nepokojům a byrokratickým zpožděním, což zanechalo mnoho žadatelů o azyl uvízl v hotelech nebo jiných dočasných ubytovacích zařízeních.
Přeplacení kanálu La Manche se stalo politickou záležitostí, kdy konzervativní vláda slíbila "zastavit lodě" a pokračuje v plánu poslat žadatele o azyl do Rwandy.
Odpůrci obviňují vládu, že démonizuje zoufalé lidi, kteří prchají před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v zahájení sezóny v Brandywellu
Střední obránce Adam Reilly uzavřel zápas s Lee Graceem v Brandywellu.
Derry City vyhrálo v President's Cupu, když vyhráli 2:0 proti Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze ligy z minulé sezóny na Brandywellu díky gólům z první půly od Willa Patchinga a Michaela Duffyho.
Hoopové se snažili o snížení podmínek ve druhé polovině, ale Ruaidhri Higgins byl neústupný a vyhrál závěrečný zápas.
Derry jede do St. Patrick's Athletic na první zápas ligy příští pátek.
Patchingova boční volejka poslala Derryho dopředu po 23 minutách - středohráč otevřel skóre, když Foylesiderové v únoru vyhráli 2:1 nad eventuálními šampiony.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy brzy dostal City dál s dlouhým úsilím, které se podařilo skrývat pod brankářem Leonem Pohlsem a do sítě.
Poslední sezona byla o dva góly lepší.
Graham Burke se nejvíce přiblížil ke snížení dluhů ve druhé části, ale Candystripes byli pohodlnými vítězi týden před jejich snahou o národní slávu.
Šéf města Ruaidhri Higgins pochválil svůj tým po tom, co řekl, že to byl "nejtěžší týden mého života" po smrti jeho bratra Kevina.
"Je to kopanec do zubů a před námi jsou těžké týdny, ale budeme pokračovat v jeho paměti", řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě s dobrým výkonem je opravdu potěšující".
DHS najímá právnickou firmu, aby se postarala o případné obvinění Alejandra Mayorky.
Ministerstvo vnitřní bezpečnosti najalo externí právnickou firmu - Debevoise & Plimpton - aby pomohla při možném procesu obžaloby ministra Alejandro Mayorkase, protože by mohl čelit obvinění republikánů z jeho jednání na jižní hranici.
"Ministerstvo vnitřní bezpečnosti si na sebe najalo externí poradce, aby zajistilo, že životně důležitá mise ministerstva nebude přerušena bezprecedentními, neoprávněnými a stranickými úsilím o impeachment některými členy Kongresu, kteří již podnikli kroky k zahájení řízení", uvedl mluvčí DHS v pátek ve svém prohlášení.
"DHS bude i nadále dávat přednost své práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečit naše hranice, zatímco odpovídá vhodně na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS".
Úředník DHS řekl CBS News, že oddělení najalo firmu na smluvní práci po dobu kongresu.
Debevoise byl vybrán kvůli své odbornosti v obžalobě a zkušenosti z práce s Kongresem v oblasti dohledu.
Ministr pro vnitřní bezpečnost Alejandro Mayorkas mluví na společné tiskové konferenci s mexickými úředníky na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise je považována za vhodný výdaj pro DHS.
DHS se snaží zajistit, aby jeho mise nebyla podkopána partyzánskými útoky a aby řízení proti Mayorkám bylo řešeno lidmi s příslušnými odbornými znalostmi.
Mayorkas se k tomuto vývoji nevyjádřil, ale na otázku o vyšetřování impeachmentu minulý čtvrtek řekl novinářům: "Budeme spolupracovat s tímto Kongresem, stejně jako jsme spolupracovali s minulým Kongresem.
Přiznal, že "potrvá čas", než bude vyhovět vyšetřování Sněmovny.
"Utrávím ten čas tak, jako ostatní a nebudeme také dělat kompromisy s časem, který věnujeme plnění našeho poslání".
Vysoce postavený představitel DHS potvrdil, že Mayorkas se ještě nesetkal se svým novým externím právním zástupcem.
Jen jeden člen vlády byl kdy obviněn, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulysse S. Granta, obviněn z přijímání úplatků, ale byl nakonec senátem zproštěn viny.
Aktuální zprávy
Díky, že čtete CBS NEWS.
Čtyři teenageři obviněni z útoku na 14letého, který zemřel na sebevraždu po bití, video bylo zveřejněno na internetu.
Otec říká, že dcera si vzala život po tom, co byla šikanována ve škole v New Jersey.
Otec říká, že dcera si vzala život po tom, co byla šikanována ve škole v New Jersey 02:33
Čtyři mladíci z New Jersey byli obviněni z útoku na čtrnáctiletou dívku, která si později vzala život poté, co bylo video z incidentu zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z násilného útoku, dva mladiství jsou obviněni ze spiknutí k páchání násilného útoku a jeden mladistvý je obviněn z obtěžování, řekl prokurátor okresu Ocean Bradley D. Billhimer CBS News v e-mailu.
Adriana Kuchová, 14 let, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojující video útoku na střední školu v Central Regional High School.
Na videu bylo vidět, jak dívky házejí na teenagera pití, pak ji kopou a táhnou po školních chodbách.
Adrianu strčili do červených skříněk, které se nacházejí na chodbách školy a jedna z dívek v růžové košili opakovaně praštila Kucha.
Další dívka, která nebyla na záběru, se při natáčení smála.
Dva dospělí přišli, aby útok zastavili, jeden z nich rozdělil teenagery.
Adriana ležela zraněná a pohmožděná na chodbě, když se jí dospělý snažil pomoci vstát.
Jedna z holek řekla: "To je to, co dostaneš".
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali", řekl její otec Michael Kuch v CBS New York ve čtvrtek, dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
Čtrnáctiletá Adriana Kuchová spáchala sebevraždu poté, co na internetu bylo zveřejněno video, na kterém byla napadena ve škole.
Kuch řekl, že by měl okamžitě zavolat policii, protože studenti, s nimiž má jeho dcera problémy, jí rozbili obličej 20-uncovou lahví.
"Kdyby zavolali policii a provedli vyšetřování, tyto dívky by nevysílali videa ze školy", řekl Kuch.
Také řekl, že jeho dcera, která měla na těle modřiny, měla být odvezena do nemocnice.
"Vždycky řešíme každý problém šikanování a v den incidentu byli čtyři studenti suspendováni", řekl Dr. Triantafillos Parlapanides, dozorce škol, CBS New York.
Školní úředníci CBS New York řekli, že informovali rodinu a nazvali smrt Adriany strašlivou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jeho stížnosti a byli propuštěni, dokud se v budoucnu neukáže u soudu, řekl prokurátor CBS News.
Studenti na škole uspořádali středu stávku na podporu Adrianině rodiny.
Pokud vy nebo někdo, koho znáte, trpí citovou úzkostí nebo má sebevražedné myšlenky, můžete se spojit s záchrannou linkou pro sebevražedné případy a krize 988 telefonem nebo textovou zprávou na 988.
Můžete také chatovat s 988 Suicide & Crisis Lifeline zde.
Další informace o zdroji a podpoře v oblasti duševní péče naleznete na lince pomoci Národní aliance pro duševní choroby (NAMI) od pondělí do pátku od 10 do 22 hodin.
ET, na 1-800-950-NAMI (6264) nebo e-mailem na info@nami.org.
Mluvil jsem s 30 zdravotnickými a wellness profesionály o tom, jak se vyhnout vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit naši energii a vyhnout se vyhoření, zejména v naší práci.
To může být pro lidi ve zdravotnictví extrémně obtížné, a proto jsem se zeptal 30 zdravotnických a wellness profesionálů na stejnou otázku: "Jak zvládáte svou energii a nevyčerpáte se ve své profesi?"
Jejich kariéry se pohybují od lékařů infekčních onemocnění přes psychology až po učitele pozornosti - a všichni měli skvělé rady, jak zůstat motivovaní a udržet se v pohybu.
Navzdory velkým rozdílům v jejich rolích, bylo několik témat v jejich odpovědi, které se vyznačily jako způsoby, jak zabránit vyhoření.
Zde jsou čtyři hlavní přístupy, které používají.
1.Vybudovat silnou komunitu
Jako osoba, která pracuje s pacienty, kteří mají smrtelné nemoci, je Eufrosina Youngová vděčná za svou silnou podpůrnou soustavu, která jí umožňuje udržovat si energii.
Young je certifikovaným neurologem a specialistou na ALS na oddělení neurologie Univerzitní nemocnice v Upstate a říká, že tam "mobilizují jako armáda lidí".
Na amyotrofickou laterální sklerózu (ALS) není lék, ale vědomí, že není jediná, kdo se snaží vyvinout léčbu a poskytnout pacientům lepší možnosti, pomáhá Youngové i v těch nejtěžších dnech.
"Nejsme nositeli světa, ale jsme součástí světa lidí, kteří toto dílo podporují", říká.
2.Odpočívejte, když potřebujete
Dvě práce jako výzkumník spánku a inženýr algoritmů, a to vše při péči o nové dítě, by určitě vedlo Raphaela Vallata k vyhoření, kdyby si odpočinul, říká.
"Mám pocit, že když se chystám vyhořet, každý úkol je jako hora, kterou musíte překonat, a je to velmi naléhavé a důležité", říká Vallat.
V takových chvílích "si opravdu potřebuješ dát pauzu a uvědomit si, že tyhle věci mohou počkat".
Obvykle si Vallat najde v den chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3.Buďte vášniví v tom, co děláte, a nezapomeňte na svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně sedm dní v týdnu.
Být na frontě během pandemie jí zabíralo téměř všechen čas, ale vyhýbala se vyhoření tím, že si připomínala, proč je její práce důležitá.
"Myslím, že práce se necítí jako práce, když máte pocit, že na ně máte vliv", říká Gounder.
"Pokud pracujete šílené hodiny, děláte něco, co pro vás nemá žádný význam, myslím, že opravdu potřebujete ustoupit a zpochybnit, co děláte".
4.Mít jiné radosti
Všichni experti říkali, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hraní na kytaru.
Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho dosáhnete ve své práci, říká Christina Maslachová, sociální psycholožka, profesorka psychologie na UC Berkeley v důchodu a autorka knihy "The Burnout Challenge: Managing People's Relationships with Their Jobs" (Výzva vyhoření: Jak zvládnout vztah lidí k jejich práci).
"Podívej se na svůj život jako na celek a ujisti se, že v něm jsou dobré věci a zajisti si, že na ně máš čas".
Získejte zdarma Warren Buffettův průvodce investic od CNBC, který obsahuje nejlepší rady miliardáře pro běžné investory, to, co dělat a co nedělat, a tři klíčové principy investování do jasného a jednoduchého průvodce.
Přihlaste se: Zjistěte více o svých penězích a kariéře pomocí našeho týdenního zpravodaje
Mladík obviněn z vraždy v prosinci v Chicagu ve škole, kde zemřeli dva lidé.
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě na dva studenty na střední škole v Chicagu v prosinci, oznámila policie v pátek.
Podezřelý je obviněn ze dvou vražd prvního stupně a dvou pokusů o vraždu, oznámil superintendent policie v Chicagu David Brown.
"V současné době nemáme jasný motiv, proč by 16letý chtěl střílet a zabíjet jiné děti", řekl Brown.
Jméno podezřelého nebylo zveřejněno kvůli jeho věku, ačkoli Brown řekl, že by čelil vraždě a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benito Juarez.
Oběti, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila policie v té době.
Vyšetřovatelé říkají, že tipy od veřejnosti jim pomohly k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční za ty, kteří byli dostatečně odvážní, aby se přihlásili a zajistili, že pachatel bude chycen a bude nyní zodpovědný", řekl státní zástupce okresu Cook County Kim Foxx.
Podezřelý se má v sobotu objevit u soudu pro dluhopisy, kde budou předloženy další detaily o důkazech, které shromáždili.
Biologové z Minnesoty zachraňují uvězněného medvěda
Minnesota Department of Natural Resources přišla na záchranu medvědího nešťastného medvěda poté, co se ocitl uvězněný v příkopu.
Medvěd se schoval v průplavu u silnice poblíž Wannaska, Minnesota, podle příspěvku na Facebooku oddělení.
Ale když se sníh začal tavit, kanál začal zaplavit, a medvěd uvízl v hlubokém sněhu a ledu, podle oddělení.
Zaměstnanci oddělení rychle na místo činu a pomohl odstranit medvěda.
Podle článku na Facebooku "biolog oddělení Andrew Tri medvěda vyšetřil a prohlásil, že je zdravý, ale omámený - zřejmě proto, že byl probuzen ze svého zimního spánku".
Oddělení pak přemístilo medvěda do státní rezervace, aby pokračoval v zimním spánku.
Usnulý masožravce byl odhadován na 6 let a vážil mezi 375 a 400 liber.
Oddělení připomíná obyvatelům, že přemísťování medvědů je práce, kterou je nejlepší nechat na profesionálech.
Pokud máte obavy o medvěda ve vašem sousedství, měli byste kontaktovat místní úřady - ne se snažit pohnout nebo krmit spícího obra.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tarts, salátu a Fancy Feast kočičího jídla.
Ale naštěstí pro dobře míněné kopáče, "protože medvědi nemají chuť jíst v zimě, medvěd nekoušel".
Podle ministerstva přírodních zdrojů je v Minnesotě 12 000 až 15 000 černých medvědů, které se nacházejí především v severní třetině státu.
Zima se v zimním spánku drží šest až sedm měsíců, během nichž nejí a živí se na svém tělesném tuku.
Fotografie: Po restaurování otevřela Egypt hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly ve čtvrtek otevřeny po dokončení restaurátorských prací.
Úvodní ceremoniál vedli generální tajemník Nejvyšší rady pro starožitnosti v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a prezident Španělské národní rady pro výzkum (CSIC), Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady pro starožitnosti a CSIC, která pracuje od roku 2002.
Řekl, že mise provedla vykopávky a restaurátorské práce a zveřejnila výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odhalit mnoho hrobek, rakví, mumií a pohřební zahradu.
Důležité hrobky z důležité éry
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili na počátku 18. dynastie Nového království - jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že rozvržení hrobek je ve tvaru písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty jsou konzistentní s vchodem, sloupovou halou vedoucí k pohřební šachty a stěnami s odlišnými nápisy.
Waziri dodal, že Djehuty byl dozorcem státní pokladny a dohlížel na díla řemeslníků a umělců za vlády královny Hatšepsut.
Djehuty byla také zodpovědná za zaznamenání Hatshepsutovy cesty do Puntlandu a za poskytnutí elektrumu (směsi zlata a stříbra) pro pokrytí vrcholu obelisků, které umístila do chrámů v Karnaku.
Kromě toho byl zodpovědný za proces přesunu obelisků.
V místnosti, která předchází pohřební komnatě Djehuty, jsou vyryty nápisy s 43 kapitolami Knihy mrtvých, poprvé, kdy byly kapitoly knihy napsány na stěny hrobů, než byly napsány na plátno a papyrus.
Hery, zastával pozici dozorce královských skladů posvátné královské manželky a matky Ahhotepu.
Jared O'Mara by nikdy neměl být kandidátem labouristů, říká Rachel Reevesová
Zneuceněný bývalý poslanec Jared O'Mara "neměl být nikdy vybrán jako kandidát labouristů" a zaslouží si čtyřletý trest vězení, řekl stínový kancléř.
Rachel Reevesová v pátek mluvila s Guardianem v volebním obvodu Bolton North East, několik hodin poté, co klíčové postavy místní strany odstoupily v protestu proti tomu, jak laboristický národní výkonný výbor (NEC) kontroloval proces parlamentního výběru pro příští všeobecné volby.
Celá výběrová komise v Boltonu Severovýchodní rezignovala poté, co jim nebylo dovoleno vybrat si kandidáty, což je stále běžnější praxe v Labouristické straně Keira Starmera, který řekl: "Zase se zdá, že Labouristická strana se snaží propagovat názory a postoje kliky v Londýně, spíše než místních členů na severu".
Dodal: "To je v rozporu s postojem nezbytným k získání zpět červené zdi, která je tak zoufale potřebná k vytvoření vlády labouristů".
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách".
Obzvláště smutné bylo, že Leigh Drennanová, předsedkyně Labouristů ze severozápadní části a poradkyně poslance Warringtonu Charlotte Nicholsové, která podporuje Jeremyho Corbyna, nebyla na dlouhém seznamu, aby se pokusila získat křeslo zpět od konzervativců, a to navzdory získání nominací od čtyř velkých odborových svazů.
Reevesová řekla, že nemá nic společného s výběrem kandidátů, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné postupy pro to, kdo může být na dlouhém seznamu a kdo může být na krátkém seznamu".
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné výdaje ve výši 52 000 liber ve snaze financovat jeho zneužívání kokainu a alkoholu.
Mnoho lidí naznačilo, že nebyl řádně prověřen labouristy, když byl vybrán, aby bojoval s Nickem Cleggem, bývalým místopředsedou vlády liberálních demokratů, v Sheffield Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se O'Maraův debakl v hlavách NEC Labouristické strany projevoval jako velký, Reeves řekl: "Nechci žádným způsobem naznačovat, že někdo, kdo není na seznamu, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy by neměl být vybrán jako labouristický kandidát; nikdy by neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest".
O'Maraova situace byla "celkem výjimečná", řekla Reevesová, ale uznala: "Pro labouristickou stranu a všechny politické strany je třeba se v oblasti výběru kandidátů poučit.
Ale také bych řekl, že v tomto parlamentu jsme viděli neustálé podkopávání standardů v politice, a to nejen následkem premiérů a pokut a stran a standardů, které jsou daleko pod tím, co byste mohli očekávat".
"Jednou věcí, kterou bych řekla o Labouristické straně je, že když lidé dělají špatně, ztrácejí bič.
Archie Bland a Nimo Omer vás provázejí hlavními příběhy a co znamenají, zdarma každé pracovní ráno.
Oznámení o ochraně osobních údajů: Zpravodaje mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich zásadách ochrany osobních údajů.
Používáme Google reCaptcha k ochraně našich webových stránek a platí zásady ochrany osobních údajů a podmínky služby Google.
Reeves byl v Boltonu, aby se setkal s učňovskými pracovníky v školícím centru pro Openreach, které poskytuje širokopásmovou síť ve Velké Británii.
Poté, co sledoval učňáky, jak lezou na předstírané telegrafní stožáry na místě za 1,7 milionu liber, Reeves diskutoval o plánech labouristů na přepravu výplaty za učňovství, která nutí větší firmy, aby odložily 0,5% svých platů na financování učňů.
Podniky si stěžují, že je tento poplatek příliš nepružný. "Openreach chce například přetvořit lidi, kteří pracují na mědi, na práci na vláknech, ale v učňovském poplatku není tato flexibilita ohledně přetváření", řekl Reeves.
Reeves řekl, že labouristé změní daň, aby společnosti mohly použít peníze na rekvalifikaci zaměstnanců v průmyslových odvětvích, jako je automobilový sektor a ty, které v současné době montují plynové kotle.
"Potřebujeme je jako součást energetického přechodu k čisté nulové spotřebě, abychom se naučili pracovat na elektrických vozidlech nebo montovat tepelná čerpadla nebo vodíkové kotle.
Chceme, aby tito lidé byli přetvořeni, aby získali dovednosti, které potřebují k úspěchu.
A přesto je proti nim vybrána výše poplatku za učňovství.
Podniky chtějí větší flexibilitu a mladí lidé, kteří začínají svůj život, nebo starší lidé, kteří chtějí přetvořit, aby se ujistili, že jejich dovednosti budou mít význam pro budoucnost", řekl Reeves.
Jeden zatčen uprostřed protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konal transvestitský pohádkový večírek pro děti.
Policie v Londýně uvedla, že jedna osoba byla zatčena kvůli podezření z rasově urážlivých poznámek vůči policejnímu důstojníkovi před uměleckou galerií poblíž Westminsteru.
Žádné zranění nebyly hlášeny a policisté zůstávají na místě, policie řekla.
V sobotu se v Tate v Británii konal Drag Queen Story Hour, kde vyprávěla příběhy Aida H Dee, kterou webová stránka galerie popisuje jako "první drag umělkyni v Evropě, která četla příběhy dětem v mateřské školce".
Skupina pravicových demonstrantů demonstrovala před galérií a setkala se s protitvrzujícími, vedeními aktivisty za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit chodbu, aby se do sálu mohli dostat všichni.
Na Twitteru popsala, že den byl "skutečně emocionální", a dodala, že pět demonstrantů se dostalo do Tate a "způsobilo narušení" v částech budovy, ale neovlivnilo čtení.
Předtím řekla Pink News, že pozvání do Tate pro událost během měsíce historie LGBTQ+ byla "čast".
Její čtení bylo dříve terčem protestů.
Drag Queen řekla, že "posouzení rizik" proběhlo předem - ale dodal, že je "směšné", že jsou nezbytné.
Aida tweetovala: "5 nenáviděčů se dostalo do Tate. Způsobili rozruch. NEBO na Drag Story Hour UK...Způsobili rozruch jinde v budově, ne tam, kde se konalo představení!! SHOW 2 proběhlo plavbě!!!"
Aida uspořádala tři vyprávění v sobotu v 11 hodin, v poledne a ve 14 hodin.
Mluvčí Tate Museum řekl: "Neprogramujeme umělce, abychom prosazovali určité názory, ani abychom usmířili různé názory".
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, s jakými jeho aspekty se budou zabývat".
Trumpův cenný dům na Wall Street je stále v pozornosti úvěrových institucí, i když jeho příjmy klesly: Zpráva
Trumpův vysokohypotekovaný mrakodrap na Wall Street 40 je v "pozornosti věřitelů" uprostřed prudce klesajících příjmů a rostoucích nákladů, uvedl Bloomberg v pátek.
Míra prázdných míst v 72patrové budově - Trumpově nejcennější - vzrostla v třetím čtvrtletí loňského roku na téměř 18%, podle měsíčního podání o zbývající hypotéce budovy ve výši 126,5 milionu dolarů, uvedl Bloomberg.
V roce 2015 se úvěr na domácnost v Číně stal součástí úvěrového portfolia společnosti Cimos.
Trump se často chlubil budovou, kterou koupil v roce 1995, která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků 11. září 2001, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budova ve městě.
Nejenže byl jeho tvrzení necitlivé, bylo to také lež.
Další nedaleký mrakodrap na Pine Street na Dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem vysokých kancelářských budov na Manhattanu klesá už léta, což se zhoršilo po vypuknutí pandemie COVID-19, když se mnoho společností zavřelo a zaměstnanci přeživších firem pracovali na dálku.
Podle Bloombergova dokumentu Wells Fargo, který je úředníkem hypotéky na 40 Wall Street, "se obrátil na dlužníka, aby se domluvil na pronájem nemovitosti" a plánoval zlepšit její výkonnost.
Majitel Wagnera říká, že válka na Ukrajině bude trvat roky.
Majitel ruské soukromé vojenské firmy Wagner Group, aktivně zapojené do bojů na Ukrajině, předpovídá, že válka by se mohla protáhnout roky.
Jevgenij Prigožin v video rozhovoru zveřejněném v pátek večer řekl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny, Donbasu.
Dodal, že válka by mohla pokračovat po dobu tří let, pokud se Moskva rozhodne získat širší území východně od řeky Dněpr.
Vyjádření Prigozhina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinův kuchař" pro své lukrativní smlouvy s Kremlem, znamenalo uznání obtíží, kterým Kreml čelí v kampani, kterou původně očekával, že do týdnů uzavře, když ruské jednotky napadly Ukrajinu 24. února.
Rusko utrpělo sérii ponižujících neúspěchů na podzim, kdy ukrajinská armáda zahájila úspěšnou protiofenzivu, aby získala zpět rozsáhlé území na východě a jihu.
Kreml se vyhýbal předpovědi, jak dlouho by boj mohl pokračovat, a řekl, že to, co nazval "zvláštní vojenskou operací", bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří oblast Donbasu, kde separatisté podporovaní Moskvou bojují proti ukrajinským silám od roku 2014.
Prigožin uvedl, že žoldáci skupiny Wagner pokračují v zuřivých bitvách o kontrolu nad ukrajinskou pevností Bakhmut v Doněcké oblasti.
Přiznal, že ukrajinské jednotky vytvářejí krutý odpor.
Zatímco ruské jednotky posílily své útoky na Donbasu, Moskva se také snažila demoralizovat Ukrajiny tím, že je nechala bez tepla a vody v kruté zimě.
V pátek Rusko zahájilo 14. kolo masivních útoků na ukrajinské energetické zařízení a další životně důležité infrastruktury.
Východní, západní a jižní oblasti byly zasaženy vysokonapěťové infrastruktury, což vedlo k výpadkům elektrické energie v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale zvládnutelná", a dodala, že se jedná o zálohy, aby se udržely dodávky elektřiny, ale poznamenal, že v některých oblastech bude pokračovat v přídělovém řízení elektřiny.
Generál Valerii Zaluzhnyi, velitel ukrajinské armády, uvedl, že ruské síly od pátečního večera do čtvrtka vypustily 71 střel, 35 raket S-300 a sedm dronů Shahed. Ukrajinská protivzdušná obrana sestřelila 61 střel a pět dronů.
Ukrajinské úřady hlásily další útoky zabijáckých dronů později v pátek.
Ukrajinské letectvo uvedlo, že armáda sestřelila 20 dronů Shahed.
V pátek večer ruské vojenské blogery a některé ukrajinské zpravodajské agentury zveřejnily video, které ukazuje útok mořského dronu na strategický železniční most v oblasti Oděsy.
Z zrnitého videa bylo vidět, jak se rychle se pohybující předmět blíží k mostu v Zatokě, asi 50 kilometrů jihozápadně od Oděsy, a exploduje silným výbuchem.
Autentičnost videa nebyla ověřena.
Ukrajinská armáda se k útoku nevyjádřila a mluvčí regionální správy Serhii Bratchuk v sobotu v televizním projevu útok drony nepotvrdil.
Most, který byl cílem ruských raketových útoků na začátku války, slouží železničnímu spojení s Rumunskem, což je klíčový kanál pro dodávky zbraní ze Západu.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazachští záchranáři vytahují 7 přeživších a těla 19 zemřelých v Turecku: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazachští záchranáři pokračují v pátrání po přeživších v Turecku, cituje Kazinform tiskovou službu ministerstva pro mimořádné situace Kazachstánu.
Práce záchranářů je ztížena velkým množstvím trosek a nestabilními konstrukcemi.
Do dnešního dne kazašský záchranný tým vytáhl sedm přeživších a těla 19 lidí, včetně jednoho dítěte, z Turecka.
První lékařská pomoc je poskytována také nepřetržitě.
V pondělí ráno zasáhlo zemětřesení o síle 7,7 stupně Richteru, které zdevastovalo části jihovýchodního Turecka a severní Sýrie.
Počet obětí zemětřesení, které zasáhlo jihovýchod Turecka, přesáhl 20 000.
Fotografie: t.me/qr_tjm
Asijské mistrovství má dát nový impuls rozvoji atletické atletické hry
ASTANA.KAZINFORM - V pátek se v Kazachstánu konal slavnostní zahájení 10. asijského šampionátu v atletice v interiéru.
Na akci se zúčastnil i kazachstánský premiér Alihan Smailov, cituje Kazinform tiskovou službu kazachského premiéra.
Šéf kazachstánské vlády zahájil akci předčítáním přivítání prezidenta Kašima-Jomarta Tochayeva.
"Sport nezná hranice.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
V naší zemi jsou všechny podmínky pro profesionální a masový sport.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex, který má více než šest tisíc míst pro sedící", stojí v dopise kazašského prezidenta.
Kazachstánští sportovci úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro rostoucí generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokayev.
Vyjádřil důvěru, že konání asijského šampionátu v Astaně dá nový impuls rozvoji lehké atletické hry v zemi, a slíbil větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazachstánský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlan al-Hamad za jeho pomoc při přípravě a konání šampionátu.
Asijské atletické mistrovství v interiéru se koná poprvé na území SNS.
Na turnaji se zúčastnilo přes 500 sportovců z 31 zemí, kteří se budou soutěžit v závodech, v štafetách, ve skoku do dlouhého, vysokého, trojitého skoku, v skoku s tyčí, ve střeleckém skoku a v závodech v obou směrech.
Turnaj bude probíhat do 12. února.
Dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkiruiová vyhrála zlato v běhu na 3000 metrů a Olga Safronová získala stříbro v běhu na 60 metrů.
Fotka: primeminister.kz
Herec z filmu Yellowstone Q'orianka Kilcherová se postavila obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském blockbusterovém procesu za pomluvu, dosáhla dalšího právního vítězství - tentokrát s herečkou z "Yellowstone" Q'oriankou Kilcherovou.
V pátek, kancelář okresního prokurátora v Los Angeles osvobodila Kilchera, 32 let, ze všech obvinění v případu podvodů s pracovními odškodněním.
V prohlášení, které v pátek sdílel s The Times, mluvčí okresního prokurátora okresu Los Angeles řekl, že soud "určil, že slečna Kilcherová nespáchala pojišťovací podvod a informoval soud, že jsme nebyli schopni pokračovat".
V červenci 2022 obvinili kalifornští úředníci Kilcherovou ze dvou trestných činů podvodů s odškodněním pracovníků, obvinili ji z nelegálního získání více než 96 000 dolarů v invalidních dávkách mezi říjnem 2019 a zářím 2021.
Časový rámec také zahrnuje několik měsíců, kdy Kilcher pracovala na "Yellowstone", navzdory tvrzením herečky, že byla příliš zraněná, aby pracovala.
Kilcher se sám vzdal a byl v květnu předvolán.
"Dnes jsem nesmírně vděčný, že můj případ byl zamítnut - zítra začíná moje cesta, abych pomohl zvýšit povědomí a požadoval větší transparentnost pro práva dělníků v rámci systému pracovních kompenzací", řekl Kilcher v pátek v prohlášení sdíleném s The Times.
A dodal, že "se těší, až bude moci o této zážitku více mluvit a pokračovat v práci, kterou miluji".
Kilcher také poděkoval Vasquezové a jejímu kolegovi z Brown Rudnick, advokátovi Steve Cookovi, za "jejich pevnou víru v mou nevinu".
Podle TMZ, Kilcher najal ty dva v září.
Kilcher se objevila ve filmu Terrence Malicka z roku 2002 "The New World", kde hrála Pocahontas.
Její díla zahrnují také "Sons of Anarchy", "The Alienist" a "Dora a Ztracené město zlata".
Nejnovější roli měla ve filmu "Dog", kde hrál Channing Tatum.
Christina Martinezová, redaktorka Times, přispěla k této zprávě.
Šéf Balenciagy nazval sváteční kampaň "hloupou chybou"
Luxusní značka oblečení Balenciaga se stále ještě potýká s negativními reakcemi na dvě z jejích nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal pod tlak kvůli reklamním obrázkům, o kterých kritici říkali, že sexualizují děti, umělecký ředitel Balenciagy Demna (plné jméno Demna Gvasalia) řekl, že je mu stále líto těchto obrázků v rozhovoru s Vogue, který byl zveřejněn v pátek.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu pro kampaň s dětmi a beru na sebe svou odpovědnost", řekl Vogue, opakujíc předchozí prohlášení, které zveřejnil na sociálních sítích v prosinci.
V listopadu se značka podělila o fotky ze své kolekce "The Gift", která představovala dětské modely pózující s medvídky, které byly oblečené do oblečení pro bondage.
Krátce poté Balenciaga uložila fotky pro svou kampaň na jaře 2023, na které byla zobrazena stránka ze soudního procesu z roku 2008, která zahrnovala "virtuální dětskou pornografii" v pozadí.
Rodiče, včetně reality show hvězdy a dlouholeté fanoušky Balenciagy - a partnerky značky - Kim Kardashian, se vyjádřili proti značce a jejím "znepokojujícím obrázkům" na sociálních sítích.
O několik dní později Balenciaga vydala prohlášení, ve kterém se omluvila za fotografie a uvedla změny, které by zavedla, aby se v budoucnu vyhnula podobným "chybám".
"Tato zkušenost mě donutila přehodnotit mnoho věcí ve způsobu, jakým já, my, pracujeme, ve způsobu, jakým vytváříme a komunikujeme s obrázky, ve způsobu, jakým komunikujeme s naším publikem, a ve způsobu, jak se učíme ze svých chyb a postupujeme vpřed", řekla Demna Vogue.
Podrobně popsal změny v Balenciaze po reakci: "reorganizace image oddělení", provádění více interních a externích kontrol pro kampaně obrazy, a partnerství s Národní dětskou alianci, aby pomohla "tisíce dětí v procesu překonávání traumatu a zabývat se jejich duševní zdraví".
"Jediná věc, která mě dělá šťastným v celé této hrozné situaci: udělat z ní něco dobrého", řekl o této spolupráci, která byla oznámila ve středu.
NCA se také spojila s mateřskou společností Balenciaga, Kering, která dohlíží na další luxusní značky, včetně Saint Laurent a Bottega Veneta.
Pod záštitou Kering je Gucci, který v prosinci čelil odporu kvůli kampani s Harry Stylesem, o které někteří kritici sociálních médií tvrdili, že sexuálně zneužívá i děti.
V rozhovoru Denma řekl, že se hodlá vzdálit "provokativních" způsobů značky.
"Toto je součástí mého učení: Budu mít zralější a vážnější přístup ke všemu, co vydám jako myšlenku nebo obraz", řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě a také k kořenům Balenciaga, která vyrábí kvalitní oblečení - ne vytvářet image nebo buzz".
Když mluví o původu značky, Demna v jiném místě rozhovoru říká, že jednou z nejbolestivějších částí reakce bylo pošpinění "jménu Balenciaga a dědictví Cristóbala Balenciagy".
"Balenciaga je dům, který je starší než sto let a je založen na silných a krásných tvůrčích hodnotách, a já jsem byla zaneprázdněna tím, že jsem dělala vše, co bylo v mé tvůrčí síle, abych ho přivedla do jeho moderního významu, a najednou jsme byli napadeni a označeni jako něco, co vůbec nejsme", řekla Demna.
"S kampaní dárků jsme se rozhodně dopustili obrovské a hloupé chyby a rozhodně jsme se z toho poučili".
Je to falešná zpráva, CBN odhalí tvrzení, že nemá kapacitu tisknout další nové bankovky naira
Central Bank of Nigeria (CBN) označila zprávu, která údajně cituje guvernéra CBN, pana Godwina Emefieleho, za zavádějící, protože současnou výzvu při distribuci nově přepracovaných bankovek naira přičítá nedostatku tiskových materiálů v nigerijské společnosti Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neudělal takové prohlášení během své prezentace Národní radě státu na jejím zasedání v pátek 10. února 2023.
Podle Nwasinobiho Emefiele na setkání pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot nairy, aby uspokojila potřeby nigerijských transakcí.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek, "jsme znepokojeni tím, do jaké míry se zájmové skupiny snaží manipulovat s fakty a vyvolat veřejnost proti bance".
Nwasinobi uvedl, že CBN zůstává odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění změn).
"Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované záložky nairy.
"Bank proto žádá veřejnost, aby tuto zprávu ignorovala a uplatňovala větší zdrženlivost, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi", dodal.
Na konkrétní hlasovou poznámku, která se šíří na sociálních sítích a tvrdí, že CBN plánuje zavřít některé banky, zejména v konkrétní geopolitické oblasti země, CBN uvedla, že takový plán neexistuje a že tato tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje, aby tyto nahrávky ignorovala, protože nereprezentují politický směr CBN a jsou jen zoufalými pokusy osob, které se snaží podněcovat veřejnost proti bance", uvedl.
Tim Sherwood se snaží získat 44 milionů liber za Pedro Porra po jeho úspěšném debutu v Tottenhamu.
Porro měl na Leicester zapomenutelné odpoledne (Zdroj: Getty)
Tim Sherwood se v roztržce do "absolutně nechutné" obrany Pedra Porra během porážky Tottenhamu 4-1 před Leicesterem City.
Spurs podepsal pravého obránce ze Sporting CP v den transferového termínu na počáteční půjčkové smlouvě za 5 milionů liber s povinností koupit toto léto za 39 milionů liber.
23letý hráč debutoval v sobotu na King Power Stadium pod vedením Antonio Conteho, jeho tým se po 14 minutách dostal do vedení díky Rodrigo Bentancurovi.
Ale pak se to změnilo v mizerný odpoledne, kdy Nampalys Mendy, James Maddison a Kelechi Iheanacho všichni skórovali, aby Leicester vyhrál 3:1 na přestávce, zatímco Porro vydržel horlivý první poločas Premier League.
Španěl byl opět v omylu, protože Leicester si myslel, že přidali čtvrtý skrze Barnesa a zatímco gól byl vyloučen z ofsajdu, bývalý manažer Spurs Sherwood byl šokován obrannými úsilím plného záložníka.
"Nechci ho pořád zlobit, ale musí být zbaven svých povinností", řekl Sherwood v sobotu pro Soccer.
Dávám mu výhodu pochybností, protože je to jeho debut, ale Pedro Porro není špatný, je neuvěřitelný.
Jeho pozice je naprosto nechutná, Barnes a Maddison ho ničí na levé straně.
Daniel Levy říkal tento týden, že utratili spoustu peněz, ano, utratili, ale jejich nábor byl velmi špatný a tohle je poslední přírůstek.
Teď už si nedělejme závěry, ale vidím hráče, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na obranu a tento hráč, který se momentálně snaží bránit, je proti velmi dobrým hráčům jako Barnes a Maddison, ale je to velmi zklamání".
Zatímco gól byl vyloučen, Leicester obnovil své vedení 4-1 s Barnesem na cíli devět minut od plného času.
I když minulý týden porazili Manchester City, Tottenham ztratil šanci dostat se před Newcastle na třetí místo.
Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepsala Joa Felix a místo toho se vrhla na Tottenhamovu hvězdu
Tottenham se chystá nabídnout za hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu
Další příběhy jako tento naleznete na naší stránce o sportu.
Sledujte Metro Sport na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoliv boj o výsady nad předvoláním Mikea Pencea
Zpráva, že zvláštní zástupce Jack Smith předvolá Mikea Pencea, vyvolává otázku: Jak bude tým Trump využívat soudní dvůr, aby zkazil tento nejnovější vývoj v vyšetřování ministerstva spravedlnosti?
Stručná odpověď je, že jakýkoli pokus o zrušení Penceova předvolání na základě výkonných privilegií by měl selhat.
Za prvé, je tu otázka, zda by bývalý prezident mohl nárokovat na tuto výsadu.
Vzpomeňte si, že Trump se pokusil a neuspěl zabránit výboru pro 6. ledna, aby získal záznamy z Bílého domu.
Nejvyšší soud loni odmítl Trumpovu odvolání, jen soudce Clarence Thomas (manžel popírajícího volby v roce 2020 Ginni Thomas) nesouhlasil.
Ale soud nechal otevřenou otázku, zda by bývalý prezident mohl nárokovat na výsadu, soudce Brett Kavanaugh navrhl, že by takový nárok podpořil.
Takže je nejméně nejasné, zda by bývalý prezident mohl nárokovat na privilegium, nic neříká o tom, zda by nárok uspěl.
Navíc, odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se dodržování předvolání ukazuje, že nejasné tvrzení o výsadě nebude stačit a může být překonáno specifickou potřebou důkazů.
Soud v rozsudku Spojené státy proti Nixonovi z roku 1974 poznamenal:
... když důvod pro uplatnění výsady ohledně předvolaných materiálů, které se chtějí použít v trestním řízení, je založen pouze na obecném zájmu o důvěrnost, nemůže převládnout nad základními požadavky řádného soudního řízení při spravedlivém výkonu trestního soudnictví.
Všeobecné tvrzení o výsadě musí ustoupit před prokázanou, specifickou potřebou důkazů v probíhajícím trestním procesu.
Proto je precedens na straně vlády.
Samozřejmě, že zpoždění v soudním řízení, i když jde o prohrávající věc, může být pro Trumpa vítězstvím.
Ale další omezení šancí na úspěšné nárok na výsadu je předchozí odmítnutí Trumpova pokusu blokovat 6. ledna svědectví velké poroty.
Jak The Washington Post v říjnu informoval, toto odmítnutí uvádí, že například bývalý Penceův asistent Marc Short "pravděpodobně vlastnil informace důležité pro trestní vyšetřování ministerstva spravedlnosti z 6. ledna 2021, útok na Kapitol, který nebyl dostupný z jiných zdrojů".
A že Pence má pravděpodobně unikátní informace, které by pomohly ministerstvu spravedlnosti v boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace je další důvod, proč by nárok na výsadu neměl uspět.
To proto, že Pence se rozhodl veřejně psát o alespoň některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říct, že komunikace je privilegovaná, když jste ji již dříve považovali za vhodnou k zveřejnění.
Takže zatímco předvolání by mohlo představovat různé politické a osobní kalkulace pro Pence - který by mohl bojovat o nominaci Republikánů v roce 2024 proti Trumpovi, někomu, kdo účinně odpustil volání po Penceově mimosoudní popravě 6. ledna - by soudy měly mít snadné čas na straně DOJ na privilegiích.
Případ proti kandidatu Bidena je zřejmý - a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové demokraté nemohou udělat mnoho v cestě pro schvalování zákonů s GOP v kontrole Sněmovny, mohou stále strávit příští dva roky, které dávají příklad.
Všichni v týmu by měli hledat příležitosti, jak hrát Gallanta na republikány.
Ale je také důležité, aby Biden vylepšil svou důvěryhodnost u amerického lidu - a možná byl velmi potřebným agentem změny v naší příliš zmatené politické kultuře.
Washington, notoricky cynické místo, je známé svými zdravým rozumem ochromenými myšlenkami o vedení.
Možná nejznámější je podivný standard, podle kterého veřejné přiznání chyb je známkou slabosti a politici by se měli snažit, aby se tomu vyhnuli.
Je tu i jiný způsob: v "Pomoc", memoárích Neila Barofského o jeho době ve Washingtonu, kdy sloužil jako generální inspektor dohlížející na program pomoci problémovým aktivům, popsal radu, kterou dostal od Kristine Belisleové, ženy, kterou chytrě najal jako svého komunikačního ředitele.
Bylo to tak proti-Washingtonské, jak to jen může být: "Uznáváme a dokonce zdůrazňujeme své chyby".
Jak vysvětlila, strategie obsahuje metodu, kterou by většina lidí uvnitř Beltway považovala za šílenství:
Tohle je nejlepší způsob, jak si získat důvěru tisku.
Vědí, že se neotáčejeme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Možná se někdy stydíme a odhalíme věci, které bychom mohli - a ostatní by - snadno skrývat, ale tisk bude šokován naší upřímností.
Nikdo jiný to nedělá a brzy budeme mít vestavěnou obranu, když na nás zaútočí.
Ať uslyší cokoliv, tisk přijde nejdřív za námi a uvěří nám, protože jim dokážeme, že mluvíme pravdu.
To je možná největší důvod, proč Biden usiluje o radikální převzetí odpovědnosti: V každém prezidentství nevyhnutelně nastanou okamžiky, kdy je důvěra veřejnosti a institucí, které chrání občanské zájmy, zásadní.
Navíc je zde životně důležitý kapitál, který lze získat vlastnictvím našich chyb, a je zde důležitý rozdíl, který může Biden vytvořit se svými politickými oponenty.
Prezident by měl následovat staré přísloví: Řekni pravdu - a zahanbi ďábla.
Reklamy na Super Bowl, které se nemůžu dočkat
Hvězda sitcomu z devadesátých let, který si zopakuje svou milovanou roli, aby vám prodal pojištění auta.
Reklama, která se stane kulturním fenoménem a dostane okamžitě zelenou jako televizní pořad, prodloužení dvanácti sekundové scény do deseti sezón.
Všechny celebrity z loňských reklam na kryptoměny se omlouvají za své kryptoměny.
Ti "whassup" kluci, ale teď už jsou staří.
Všichni teď chodí po whodunnitech, že?
Takže, řada reklam režírovaných Rianem Johnsonem, kde když zjistíte, kdo spáchal vraždu, dostanete slevu na roční pojištění auta.
Reklama, na kterou budou všichni super-online konzervativci zuřit celý týden.
Timothée Chalamet v nějaké funkci.
Někdo, kdo byl údajně navždy zrušen, se triumfující vrací do televize, aby ti prodával pivo.
Reklama na nejhorší film, který jste kdy viděli, který určitě uvidíte, až bude streamovat za tři týdny.
Nepochopitelně chytlavý nový jingl, který si budeš zpívat celé roky.
Recyklovaný vtip z Twitteru z předchozích dvou měsíců.
Hudebník, jehož celá věc je kontrakultura, která vám kontrakulturně říká, abyste platili u Wells Fargo.
Ten "zoom zoom" kluk, ale teď je dospělý.
Biden DOJ 'nechtějí ozbrojené občany'
Kongresman Andrew Clyde (R-GA) se ve čtvrtek sešel s Breitbart News a diskutoval o svých plánech blokovat pravidlo ATF pro držení pistole a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občanství" na prvním místě.
Clyde jasně prohlásil, že je proti pravidlu o držení pistole.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější.
Obecně, vyjádřil své přesvědčení, že naši zakladatelé nezpracovali plán vlády, který by zahrnoval federální agentury, které by vytvářely zákony místo zákonodárců.
Řekl: "Ministerstvo spravedlnosti je tam, aby prosazovalo zákon, ne aby zákony vytvářelo. Když máte výkonnou moc, která vytváří zákony a prosazuje zákony, pak máte krále a království. Naši zakladatelé nenavolali krále a nevytvořili království v ústavě Spojených států".
Clyde se pak přesunul k specifikacím ohledně pravidla o držení pistole a vyjádřil obavy, že pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
"ATF chce rozšířit databázi registrace pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co přichází před konfiskací, je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany".
A dodal: "Ale toto ministerstvo spravedlnosti chce registrované občanství, aby vědělo, kdo co má, a tak nás mohlo pronásledovat".
Clyde tvrdí, že pravidlo ATF o držení pistole se zrodilo v prostředí nepřátelství vůči druhému dodatku a vůči soukromému vlastnictví zbraní a plánuje s tím bojovat nehty a zuby.
Řekl, že má "tři nástroje", kterými se může s tímto pravidlem bojovat.
Prvním z těchto nástrojů je SHORT Act a druhým je zákon o přezkoumání Kongresu.
Dne 30. ledna Breitbart News citoval Clydeho, který načrtl svůj plán "opětovného zavedení zákona Stop Harassing Owners of Rifles Today Act, nebo SHORT Act, aby zrušil prvky Národního zákona o střelných zbraních, čímž by ATF zakázal registrovat a zakázat pistole se stabilizačními brekety".
Také poznamenal, že "předloží rezoluci nesouhlasu podle zákona o přezkoumání Kongresu, aby přehodnotil protiprávní přehánění Bidenovy administrativy".
Oba zákony, SHORT Act a Kongresový zákon o přezkoumání, mají možnost blokovat pravidlo ATF pro držení pistole.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, buď k přijetí legislativy SHORT Act, nebo k dokončení rezoluce nesouhlasu podle zákona o přezkoumání Kongresu.
Ujasnil, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k jiným, větším zákonům, které demokraté velmi chtějí schválit.
Nicméně, Clyde naznačil, že existuje i třetí způsob, jak zablokovat pravidlo ATF o držení pistole.
Řekl: "Jsem v výboru pro příděly a můžeme zrušit toto pravidlo o držení pistole, prostřednictvím tzv. změny omezení. Můžeme doslova zrušit toto pravidlo a v podstatě říct: "Žádné peníze nesmí být vynaloženy na provedení nebo prosazování tohoto konkrétního pravidla o držení pistole".
A můžeme udělat totéž s pravidlem ATF přijímač/obrázek, z minulého srpna.
Myslím, že obě potřebují zrušení a těším se na spolupráci s našimi příjemci, abychom to udělali.
AWR Hawkins je oceněný sloupkař o Druhém dodatku pro Breitbart News a spisovatel / kurátor Down Range s AWR Hawkins, týdenní zpravodaj zaměřený na všechno, co se týká Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem USA v Turning Point.
AWR Hawkins má doktorát z vojenské historie, se zaměřením na Vietnamskou válku (hnědý námořní loďstvo), americké námořnictvo od jeho vzniku, občanskou válku a ranou novodobou Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se přihlásit na Down Range na breitbart.com/downrange.
Sežeňte ho přímo na awrhawkins@breitbart.com.
Doufáme, že Biden má plán na řešení Titulu 42 a končí: "Pokud ano, tak to sdíleli ne úplně".
V pátek v NBC guvernér Colorada Jared Polis (D) řekl, že má "velké obavy" o to, co se stane, až Title 42 skončí v květnu, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že "pokud to udělají, ještě s námi to úplně nesdíleli".
A řekli, že "my jsme řekli, že potřebujete plán. Chceme, aby to s námi prozkoumali".
Polis uvedl, že by si přál, aby se více času věnovalo otázce imigrace během schůzky guvernérů v Bílém domě, ale otázka "vznikla".
Zčásti jsme tam měli i ministra Mayorkase.
A tak jsme se znovu sešli, je tu hodně starostí, které sdílím, o to, co se stane, když se titul 42 skončí v květnu a tak, aby se ujistil, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, tak nám to ještě neřekli.
Ale jak jsme řekli, potřebujete plán.
Chceme, aby to s námi prozkoumali.
Chceme se ujistit, že to není to, co jsme zažili v prosinci, krát pět nebo krát tři, což by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu vládu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stahuje "nevkusnou" reklamu poblíž krematoria - RT World News
McDonald's se omluvil poté, co byla reklama na hamburger "McCrispy" řetězce rychlého občerstvení umístěna blízko krematoria ve Velké Británii - ačkoli někteří místní viděli zábavnou stránku.
Řetězec restaurací se zavázal odstranit urážlivé reklamní plakáty po stížnostech obyvatel Trura v anglickém hrabství Cornwall.
V pátek se na sociálních sítích dostalo pozornosti, protože bylo umístěno na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulem ukazujícím na krematorium, byla označena některými rozzlobenými místními obyvateli jako "nevkusná".
"I když vidím tu zábavnou stránku, je to nechutné a jsem si jistý, že někteří truchlící členové rodiny to nebudou rádi vidět, když navštíví Penmount na pohřeb a kremaci milovaného člověka", řekl obyvatel, jehož tchyně byla loni spálena v pohřebním ústavu, jak citovali britská média.
Ne všichni však byli tak uraženi nešťastným umístěním reklamy, jeden z nich poznamenal, že reakci člověka na ni pravděpodobně ovlivní "jak dlouho jste následovali značku krematoria, když jste na sobě měli černou kravatu".
Jeden člověk řekl, že "spadl ze židle ze smíchu", když spatřil reklamu na internetu, zatímco další místní si také všiml, že to nebylo "horší" než rozhodnutí rady, aby se zabývala myšlenkou, že by bylo možné postavit krematorium "vedle vesnice důchodců".
Místní média zveřejnila v pátek prohlášení McDonald's krátce poté, co se obrázek reklamy stal na internetu virálním, v němž řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
"Nebyli jsme si vědomi, že v okolí této autobusové zastávky je silniční značka, ale vzhledem k obavám, které vyjádřil CornwallLive, jsme požádali o odstranění naší reklamy", uvedla značka rychlého občerstvení.
Cornwall Council, která provozuje krematorium i autobusový přístřešek, kde je zobrazena reklama, odmítla komentovat rozruch, když byla kontaktována místními médii.
"Gut Instinct" pohřešovaná žena není v řece
Hledání pohřešované Angličanky Nicola Bulleyové je už šestnáctý den poté, co její partner řekl, že jeho "instinkt" říká, že není v řece.
Policie v Lancashiru uvedla, že policisté mají "otevřenou mysl", zatímco pokračují v žádosti o informace o paní Bulleyové, která zmizela 27. ledna, když se procházela se svým psem v kostele St Michael na Wyre.
Policie pokračuje v pátrání po řece Wyre směrem k moři v Morecambe Bay, pracuje na jedné hypotéze, že 45letý muž z Inskipu by mohl spadnout do vody.
Jejich pátrání bylo podpořeno odborníky a potápěči z HM pobřežní stráže, horské záchranné služby a Lancashire Fire and Rescue Service, s nastrčenými psy, dronů a policejních vrtulníků.
Slečna Bulleyová zmizela, když procházela svého springerského španěla Willow poblíž řeky, krátce poté, co nechala své dcery, šest a devět let, ve škole.
Telefon poradce s hypotékami byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner, Paul Ansell, řekl, že chce udržet "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popsal slečnu Bulleyovou jako "zábavnou", "milující", "nejvěrnější kamarádku, jakou můžete mít" a "výjimečnou mámu", která "absolutně zbožňuje naše dívky".
"Je jen pilíř síly naší rodiny a bez ní je díra větší, než si dokážete představit", řekl 5 News.
Pan Ansell řekl, že i když rodina prochází "nepřekonatelným peklem", naděje, že jeho partner bude nalezen, je "silnější než kdy jindy".
Policie odmítla podezření na zločin a vyšetřuje tento incident jako pohřešovanou osobu.
Ve čtvrtek se jejich hledání zaměřilo z St Michael's na asi 10 mil po proudu, kde se řeka vyprázdňuje do moře v Morecambe Bay, s hlídkami a záchrannými loděmi v oblasti.
Poslední komunistický vůdce Východního Německa zemřel ve věku 95 let
Hans Modrow, který sloužil jako poslední komunistický vůdce Východního Německa během turbulentního funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95.
Modrow zemřel v sobotu ráno, tweetovala parlamentní skupina Levice.
Modrow, reformně smýšlející komunista, převzal Východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nemohl zpomalit shromažďování hybnosti pro německé sjednocení.
"Celý mírový proces vytvoření německé jednoty byl právě jeho zvláštním úspěchem", napsala Levice na Twitteru. "To zůstane jeho politickým dědictvím".
Během 16 let, kdy byl šéfem komunistické strany v Drážďanech, od roku 1973, si Modrow vybudoval pověst protiestablishmentové postavy.
Odmítl zábavní výhody a trval na tom, že bude žít v normálním bytě.
Východní Německo mu uniklo místo v nejvyšším vedení, dokud se v listopadu 1989 nestal premiérem, což byla pozice, která předtím neměla velký vliv - několik dní po pádu berlínské zdi.
Když na začátku prosince odstoupil vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se stal nejvyšší politickou postavou východního Německa.
Ale komunisté už nemohli rozhodovat sami.
Následující měsíc souhlasil s rozdělením moci s čím dál hlasitější opozicí a posunul první svobodné volby do března 1990, uprostřed rostoucích nepokojů.
I když pro-demokratické shromáždění rychle získaly pro-sjednocení chuť, komunisté původně byli proti řeči o znovusjednocení.
V únoru 1990 však Modrow naléhavě vyzval k jednáním se Západním Německem o eventuální "sjednocené vlasti", která by byla nezávislá na vojenských blocích a byla by řízena společným parlamentem v Berlíně.
Modrow vedl volební kampaň reformovaných komunistů, Strany demokratického socialismu, ale jeho osobní popularita nebyla dostatečná, aby jim zabránila skončit jako třetí nejsilnější strana, s podporou 16 procent.
Vítězem byla aliance konzervativních stran, které upřednostňovaly rychlé znovusjednocení a byly podporovány vládou západoněmeckého vůdce Helmuta Kohla.
Německo se pod Kohlovým vedením a jako člen NATO znovu sjednocilo 3. října 1990, méně než rok po pádu Berlínské zdi.
Modrow se stal členem sjednoceného parlamentu, kde působil do roku 1994, a čestným předsedou postkomunistické PDS - předchůdce dnešní opoziční levicové strany.
Modrowova minulost pod tvrdým komunistickým režimem ho přivedla k soudu několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků místních voleb v květnu 1989 v Drážďanech.
Dostal 9 měsíců podmíněného trestu a pokutu.
Modrow prohlásil, že soud byl politicky motivovaný a tvrdil, že jeho výsledek by zhoršil rozdělení mezi východními a západními Němci.
Jeho právník tvrdil, že se mu podařilo napravit dřívější nespravedlnosti tím, že jako premiér dohlížel na svobodné volby.
Později v životě sloužil Modrow v radě starších levicové strany.
"Hans byl hluboce upřímný a bojovný socialista", napsal na Twitteru Dietmar Bartsch, předseda parlamentní skupiny Levice.
"Do stáří byl důležitým poradcem naší strany, jehož moudrost nám bude chybět".
Indská vláda po kritice stáhne výzvu k obejmutí krav na Valentýna
Indická vláda už nepovzbuzuje k objetí krávy na Valentýna - ačkoli to dříve od lidí požadovala, aby tak činili, aby propagovali hinduistické hodnoty.
Indická rada pro ochranu zvířat (AWBI) zrušila svůj apel na "Dnešní den kravského objetí" poté, co byl kritizován politickými soupeři a uživateli sociálních médií.
Indické ministerstvo vnitra vyzvalo občany, aby se vyvarovali západních romantických gest slavených na Valentýna.
Nilanjan Mukhopadhyay, politický analytik, řekl, že výzva k objímání krav byla "absolutně šílená, odporující logice".
Dodal, že rozhodnutí o stažení odvolání bylo spíše "pro zabránění tomu, aby se politika Hindutvy [hinduského nacionalismu] stala směšnou tváří v tvář silné kritice ze všech stran".
AWBI v pátek odmítla odvolání, protože tvrdí, že je "odvoláno".
Teprve ve středu se v prohlášení uvádí, že "objímání krav [by] přineslo citové bohatství a zvýšilo individuální i kolektivní štěstí".
Více o Indii
Dodal, že kráva je "základem indické kultury a venkovské ekonomiky... díky své výživné povaze jako [matka]".
Na první oznámení se objevily různé reakce, když někteří zveřejnili videa krav, které odmítají objetí a utíkají.
Jiní chtěli objasnit, že se odvolání týká spíše toho, že se člověk drží své vlastní kultury, než "slepě" se drží západních hodnot.
Mladí Indové obvykle stráví Valentýn v parcích a restauracích, kde si vyměňují dárky a pořádá párty.
Kočí objetí není nic nového - v některých částech světa je považováno za terapeutické, a v Nizozemsku je známé jako "koe knuffelen".
Oddaní hinduisté uctívají krávu, známou jako gau mata neboli "matka kráva", a většina indických států zakázalo zabíjení krav.
V posledních letech někteří hinduističtí radikálové vtrhli do obchodů, kde se prodávají valentýnské zboží, spálili pohlednice a dárky a vyháněli z restaurací a parků páry, které se drželi za ruce, a trvali na tom, že tento den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal tvrdí, že takovéto nájezdy pomáhají znovu potvrdit hinduistickou identitu.
Kritici premiéra Narendra Modiho tvrdí, že jeho vláda prosazuje hinduistickou agendu, usilující o nadvládu náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80% z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhistou, buddhisté a džinisté tvoří většinu zbytku.
Pěší zemřel v nemocnici po nehodě s autem v Cowdenbeath jako muž zatčen
Jeden chodce zemřel při srážce s autem v Fife.
38letá žena byla převezená do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeath v pátek kolem 13.30.
V souvislosti s nehodou byl zatčen 24letý muž.
Policie žádá všechny svědky nebo kohokoliv, kdo má záznam z palubní kamery, aby se přihlásil.
Seržant Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a žádáme každého, kdo byl v této oblasti a byl svědkem nehody, aby nás kontaktoval".
Také bych apeloval na každého, kdo jel v této oblasti a kdo by mohl mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
"Každý, kdo může pomoci, je požádán, aby zavolal Police Scotland na 101, s číslem 1638 z pátku 10. února 2023".
V ČÍSTECH: Obce v Oslu, kde žije nejvíce cizinců
Zhruba 177.000 z 634.000 obyvatel Osla přistěhovalo do Norska z jiných zemí.
Když se do počtu zahrnou i ti, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecké pozadí, stoupne na více než třetinu.
V Oslu tvořili největší skupinu imigrantů občané z Asie, včetně Turecka, a podle údajů národní agentury pro statistiku Norska (SSB) v tomto městě žije více než 62 985 těchto občanů.
Poté byli občany EU, EHP a Spojeného království druhou největší skupinou, což činilo necelých 10% obyvatel města.
Africkí imigranti tvořili třetí největší skupinu imigrantů v Oslu, přičemž v Oslu žilo 28 020 lidí z Afriky.
Evropští občané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, což činilo 15 566 obyvatel Osla.
Odtud se velikost skupin výrazně snižuje.
Například v roce 2022 bylo jen necelých 7 000 občanů z jihoamerických zemí, zatímco bylo více než 3 000 občanů ze Severní a Střední Ameriky.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
V Alně, na severovýchodě města, bylo nejvíce cizinců.
V roce 2022 bylo v této zemi registrováno 18 257 cizinců.
Následně měla trendová Grünerløkka, která se nachází poměrně centrálně, druhý nejvyšší počet cizinců s 17 631.
Ve starém Oslu také žilo značné množství přistěhovalců, přičemž zde žilo 17 631 lidí po přestěhování z jiné země.
Údaje norské statistiky ukazují, že cizinci byli rozptýleni po všech městských čtvrtích, protože v Søndre Nordstrand, nejjižnější čtvrti v Oslu, bylo registrováno více než 14 000 přistěhovalců.
Mnoho přistěhovalců také žilo v vyhledávaných oblastech, protože Frogner byl čtvrtým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek deseti okrsků v Oslu s největším počtem obyvatel z jiné země.
Na druhé straně spektrum bylo jen 184 cizinců, kteří Marka nazývali domovem, a jen něco přes 700 žilo v centrální čtvrti města.
Ullern, Vestre Aker a Nordstrand tvořily další okresy s nejmenším počtem cizinců.
V těchto okrscích však žilo podstatně více přistěhovalců než v centrálním Oslu a Marce.
Ti z zemí EU a EHP a ti ze Spojeného království žili převážně ve Frogner, Grünerløkka, Gamle Oslo a St.
Zatímco v Game Oslo bydlelo také mnoho občanů z Asie, včetně Turecka (5 837), většina byla registrována jako obyvatelé čtvrtí Alna, Stovner a Søndre Nordstrand.
Staré Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Norstrandem.
Ty ze Severní Ameriky byly poměrně rovnoměrně rozložené napříč Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky byli nejčastěji nacházeny ve Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království bydleli v nejcentrálnější části města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A nakonec, z několika set státních příslušníků z Oceánie, Frogner, Grünerløkka a Gamle Oslo byly okresy s nejvyšší populací těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
Napsala Florence Tanová
BENGALURU (Reuters) - Zimbabwe začne do března provozovat novou jednotku své jediné uhelné elektrárny, říká náměstek ministra energetiky země, který poskytuje pomoc milionům občanů otřesených častými výpadky elektřiny v posledních měsících.
Nová jednotka elektrárny Hwange zvýší instalovanou kapacitu afrického národa o více než 14% na 2400 megawattů.
Další jednotka by měla být uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časovou osu.
Méně než polovina z 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální omezení financování nových uhelných elektráren omezuje schopnost země zapnout chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době generujeme mnohem méně než to, asi 1000 MW", řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit", řekla.
Nedostatek srážek vedl ke snížení výroby vodní energie, zatímco účinnost jediné, desetiletí staré uhelné elektrárny se časem prudce snížila, zatímco poptávka po energii v posledních letech vzrostla kvůli vyšší těžbě a zemědělské činnosti.
Mezinárodní měnový fond počítá nedostatek elektřiny jako jeden z hlavních faktorů, které brání růstu v Zimbabwe.
Nedostatek finančních prostředků na výrobu elektřiny z uhlí vede hospodářství závislé na těžbě a zemědělství k dovozu nákladné elektřiny ze sousedních zemí, včetně Zambie a Mozambiku.
(Psaní Sudarshan Varadhan; úprava Jacqueline Wong)
(PERSON11) Ale pro některé složky, z nějakého důvodu, je zvukový formát špatný, takže, něco je špatně
V podstatě, velké obchodování, nebo něco je špatně.
Takže některé soubory mají stále zvláštní výstup.
Ale  ale pro většinu složek, to by už mělo být v pořádku.
Dobře, díky.
Jo, to je skvělé.
Podporuji to, je skvělé, že [PERSON7], jste si mysleli na [PERSON11].
A [ČLEN11] má teď čas.
Jsou i jiné věci, o kterých jsem přemýšlel, a to by bylo trénink prázdných systémů, aby dělali zkrácení.
Takže, pokud jste měl čas.
Očividně to nemůžeme udělat do příštího týdne.
Ale měli bychom mít systém připravený na
Podíval jsem se na výukový program z NLP, že?
(PERSON6) pro nadcházející sezení a ptal jsem se na poptávku, protože jsem viděl demo projektu (meme).
Dělají offline titulky.
Takže to je o něco jednodušší, než to, co děláme my.
Stále mají stejné problémy s segmentací a tak dále.
Ale jejich překladatelská mise se zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro neslyšící.
Takže je to jako přirozené zkrácení dat.
Bylo by skvělé, kdybychom také mohli najít takový typ dat, kde se děje nějaké přirozené zkrácení.
Dali bychom to do architektury.
To bude trvat trochu déle, protože musím zjistit, kdo z nich je ten, kdo dostane propustky.
Takže, jakmile to budu vědět, budu to mít na paměti, takže, pro budoucnost
Nebo vlastně, v budoucnu bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu potřebovat konvertovat.
Tohle by mělo být...
Slyšíš mě?
Kvalita zvuku je o něco horší.
Takže tohle by se mělo dělat pořád.
Takže pokaždé, když provedeme toto hodnocení, mělo by být spuštěno od nuly.
Takže pokaždé by mělo být nové stažení nové konverze a nové hodnocení.
(PERSON8) Ale i tak, pokud sleduji soubory, které potřebují být manuálně konvertovány, tak abych mohl napsat skript, a mohl se postarat o známé, a samozřejmě, pokud přidáme nějaké nové soubory, mohu to vidět později.
(PERSON6) Takže tohle je důležitá věc, kterou jsme měli poznat už před měsíci.
Pamatujte, že od srpna vám říkám, že chceme vyhodnotit na pozdější testovací sestavě.
A pokaždé, když...
Nejde jen o vás osobně, [ČLEN 8].
Samozřejmě, že byly i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si, že to bude snadné, že to prostě zvládneme.
A teprve když to opravdu uděláte, uvidíte všechny problémy.
Takže tohle je známé, běžné.
Vždycky je to tak.
Takže to je zpráva pro všechny.
Než to zkusíš, nikdy nevíš, jaký bude problém.
Například ten hovor, který jsem měl, v němž mě někdo vyslýchal, tak chtěli nahrát video.
Zoom mi nikdy nefungoval tak špatně jako dnes při nahrávání.
Takže, než to uděláte, nemůžete říct, jestli to bude fungovat nebo ne.
A tady se potýkáme s problémy konverze formátů souborů.
Takže doufejme, že budeme schopni rychle získat čísla.
Takže, máte zatím nějaké chybové hodnoty slov?
Ne, ještě jsem to nezpracoval.
Takže [PERSON1] řekl, že jakmile dostanou záznam, uděláme to společně.
A souhlasím, že v tomhle slovníku je hodně hluku.
Takže jsem požádal, abyste měli různé verze tohoto slovníku, jen tak, že budete brát slova, která byla pozorována, pětkrát.
A jen výslovnosti, které byly pozorovány třikrát nebo více, nebo něco takového.
Takže, tímto způsobem, tyto náhodné chyby, jako například tento příklad s čtyřmi IBM místo IBM.
To nebude tak časté.
Ale stále budete mít varianty ve výslovnosti, protože pokud osoba řekne "alzo", pokud si vzpomenete, pokud řekne "alzo" s "Z" 20krát v přednášce, pak to uvidíte v datech s "Z".
A pokud někdy dokáže říct i správně, pak ano, opět to uvidíte v datech.
Takže bych chtěl, aby [ČLONKA4] byla v kontaktu s [ČLONKA2].
Možná bys mohl pokračovat v hovoru, že?
Musím jít, protože musím dát dětem oběd a tak.
Ale prosím, zůstaňte na telefonu a společně se domyslete, jak používat slovník.
Takže [PERSON4], prosím ukažte [PERSON2], co je slovník, který systém přijímá.
Sdílejte obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte mě přeměnit slovník, který jste vyslali do toho souboru.
Jedna věc, která bude stále potřebná, je náhražka jazykového modelu.
Ale všechna tato slova by měla být známá.
Takže [PERSON4], musíte zjistit, která slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše kopírována.
Takže slovník bude mít tři sloupce.
Grafém, jak je to výstup.
Jeden rozpoznán.
Phonémy, jak navrhl [PERSON2]
A bude tam několik řádků s různými zvukovými variacemi.
A třetí sloupce bude stejná pro všechny tyto, a bude mít stejnou formu grafemu.
Takže to je to, co vidí model jazyka.
A myslím, že tímto způsobem by tyto systémy měly být schopny to načítat.
A možná narazíte na další problém: že není připraven na dva velké slovníky.
Takže, tohle je také něco, co musí být testováno, ale prosím, zkuste to, vy dva společně.
Takže [ČLON 2] ví, co vytvořil ve slovníku.
A víte, jak slovník vypadá, když ho vytváříte ručně, a musíte dát tyto dva kousky znalostí dohromady.
Ah, takže to funguje s generovaným slovníkem.
Dobře.
(ČLEN6) Takže, (ČLEN2) dává to smysl?
Jasně, promluvíme si o tom.
Jo, takže je tu ještě něco, co máš?
No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časové značení.
Nejsem si jistý, jak dobrý to bude, protože se to snažím udělat na (Libry) Speech.
A když jsem si ho stáhl, tvrdili, že má více než 600 hodin.
Ale pak se ve výcviku uvedlo, že skutečný výcvikový soubor obsahuje jen asi 300 hodin.
A stále si nejsem jistá, jestli tyto 300 hodin neobsahuje podobné věty.
Nebo vlastně stejné věty, ale mluvené různými mluvčími.
Například v angličtině nebo české jsem pozoroval strmější konverze.
A teď se to tak rychle nekonvertuje.
Takže, pokud si vezmeme nějaké vzorky během tréninku.
Pak jsou ještě nějaké vážné chyby v výstupu ASR.
Takže doufám, že pro časové značení je to dost dobré.
Nebo bychom to aspoň mohli zkusit.
Dobře, to je dobře.
Tak jsem začal, ale myslím, že jsem nikdy nedokončil e-mail, protože jsi mi připomněl, že tvůj filtr pro urážku není ještě integrován.
A myslím, že je to také důležitá zpráva pro [PERSONU 5], která opět zmizela z hovoru.
Důležité je, že ano, je velmi dobré, že se aktivně snažíte, aby vaše výsledky byly integrovány, a každý by to měl dělat.
A zároveň potřebujeme mít nastavení, abyste to mohli integrovat a testovat sami.
Říkám tomu "integrace na vlastní pěst".
Takže, [PERSON8], když pracujete s [PERSON5] a když dokumentujete, jaké jsou nastavení, ujistěte se, že je dostatečně dobře testováno kolegy, jako [PERSON4] nebo dokonce [PERSON9] pro ověření jazykových modelů a všichni ostatní.
Takže, kdykoli někdo vyvine novou užitečnou součást, celý proces by měl být pro něj přístupný s rozumnou lehkostí, aby ho mohl sám otestovat.
Takže tato integrace "udělej si to sám" je důležitá, protože jinak to všechno zůstane na tobě, [PERSON8], a ty nechceš být přetížen.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[ČLEN4], že?
Filtrování nadávek, bylo testováno na deníku?
Myslím, že ano.
Jo, myslím, že to bylo testováno na polích.
Takže, teď je čas to otestovat na živých potrubích.
A opět, myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4] jak to udělat, takže [PERSON4] to spustí pro sebe, některé z pracovníků a živě přehraje některé problematické soubory jako třeba [PROJECT8] nebo cokoliv.
Prostě je zahrajte.
Sledujte zvukový výstup na vašem přístroji a uvidíte, jak to funguje.
Protože jen při opravdové instalaci se objeví skutečné chyby.
Je důležité nejdříve odstraňovat chyby, pomocí souborů deníku, a pak je důležité odstraňovat chyby v průběhu.
A pokud toto odstraňování chyb může provést autor této komponenty, tady, v tomto případě [PERSON4], bude to pro nás všechny nejefektivnější.
Takže, [PERSON8], prosím potvrďte, že souhlasíte s touto myšlenkou integrace typu "udělej si to sám".
Jo, takže pro angličtinu s více přízvukem.
Takže teď to [PERSON14] spojíme do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je, že vytvoří nové věty se slovy, které byly vysloveny v jiných větech, a to bude dělat napříč různými mluvčími.
Takže to budou opravdu věty pro více mluvčích, a proto by se mohla zlepšit robustnost různých přízvuků těchto mluvčích.
Takže to je jeden experiment s částicemi.
A později možná uděláme něco víc s tou věcí s více přízvukem.
Takže tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní model jazyka.
Takže systém ASR musí vidět co největší možný soubor vět.
A my vytvoříme nové věty z jazykového modelu pouze s textem, přidáním zvukové části k němu, takže jazykový model bude lepší pro ASR a robustnost pro různé mluvčí bude také lepší.
A včera jsem slyšel další nápad.
Bylo to během tréninku.
Z zvuků vypouštěli časové pásma a frekvenční pásma.
Takže trénovali na narušených vstupních datech, a to také výrazně zlepšilo robustnost systému.
(PERSON17) Každý jiný může pracovat na tom ne-rodilém přízvuku.
Dobře, další věc, kterou jsem si všiml je, že je to v pondělním testovacím dokumentu.
Je zdůrazněno čtyřikrát.
Takže, když se nějaké sezení děje, potřebujeme jména a terminologii pro tuto sezení.
A my ji musíme sbírat, připravit ručně, vytvořit ji.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Takže je v tom určitá dovednost, která se musí procvičovat.
Takže jsem dost dobrý v míchání textových souborů.
A kdykoliv vidím, že to někdo z vás dělá, tak mám v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jedinou osobou, která by to mohla být, je [PERSON8].
Pokud najdete někoho, kdo by byl připraven pomoci s okamžitou adaptací domény, zpracováním dat, dejte to prosím vědět.
A pak potřebujeme...
Takže, jakmile máme zabezpečený slovník termínů a jakkoliv se vyslovuje slovo, potřebujeme techniky, abychom tyto slovníky použili v systémech.
Takže můj dojem z doménové adaptace, kterou [PERSON9] pečlivě prováděl pro všechny sezení, byl, že to nebylo ve skutečnosti viditelné v hybridním ASR.
Takže, jedna taková schůzka se bude konat tento pondělí.
[PERSON9] již začíná sběrat data, ale rád bych viděl prospěch této doménové adaptace v [PROJEKTU 5].
Takže, možná [PERSON9] a [PERSON8], protože se učí jak dělat doménovou adaptaci a [PERSON14], protože se učí jak pracovat s [PROJEKT5].
Kdybyste se vy tři mohli sejít a zkontrolovat, co [PROJEKT5] dělá s...
Není to [PROJEKT5], vlastně, doménová adaptace je pro [PERSON18] toolkit, správně.
Takže, tohle je trochu zpětný pohled, aby se ujistil, že starý přístup funguje.
V současné době je naprosto nemožné provést jakoukoli doménovou adaptaci pro plně neuronální ASR.
Takže, to, co zvažuji, je mít nezávislé odhalování klíčových slov ze zvuku a nějaký postup sloučení.
Takže můžeme mít dvě ASR běžící současně.
End-to-end ASR, což je obecně lepší.
A pak doménově přizpůsobené nastavení [PROJEKT 5], které se používá pouze k nalezení klíčových slov.
A když vidíme klíčové slovo v doméně přizpůsobené verzi pak bychom pak bychom použít tuto větu z [PROJEKT5], který je obecně horší, ale obsahuje správné pojmy.
Takže to je můj návrh, co bychom mohli udělat.
Dalším návrhem je, že bychom měli mít vlastní plně neuronální ASR a dělat různé experimenty s jemným laděním a tak dále.
Takže jsme to probrali s [PERSON14].
A, [ČLEN 14], máte nějaké novinky od potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je tu někdo, kdo by byl zvědavý na tohle, dejte mi vědět nebo mě kontaktujte.
Takže je to něco, co by bylo obecně přijaté jako článek, protože to lidé ještě nedělají.
A to je nejvíce naléhavý problém v těchto dnech.
Takže bychom tam mohli opravdu něco udělat.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké typy dat pro to v současné době používáme, protože například, pokud zkontrolujete modely [ORGANIZATION4] na [ORGANIZATION5] že jsou v těchto věcech už dost dobří -
A myslím, že kdybychom jen tak...
Mohli bychom z nich získat data, protože máme takovou velkou sadu videí v podstatě z různých oblastí a různých rodilých jazyků na [ORGANIZATION5].
A měl jsem nápad, že bychom mohli použít nějaký nástroj, abychom si stáhli nějaké filtrované videa z [ORGANIZATION5] a z nich udělali výcvikové testy.
Takže to hodlám udělat sám.
Plánuju tam jít, ale potřebujeme zálohu.
A také, pro [PROJEKT210] událost potřebujeme někoho, kdo se postará o nahrávání,
Takže, archivář, abychom ten sezení znovu neztratili.
A důležitější a stále trvající téma, na kterém se pracuje, je lezení po žebříku.
A já jsem navrhl tady v odstavci pro [PERSON2], že bychom mohli použít jednoduché HTML tabulky, které by byly automaticky generované a které by rostly.
Myslím, že by bylo nejlehčí, kdybychom tabulky jen dali jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnoceny po každé nové hodnocení.
Může být obtížné připravit tyto stoly.
Tak jsem požádal [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Aby nám řekl, zda [ORGANIZACION242], což je webové řešení.
Nějaká začínající firma, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANIZACION242] není doporučena [PERSON7].
Takže jednoduchý HTML je pravděpodobně cesta.
Takže, jakmile [PERSON2] tyto hodnocení vyčistí.
To znamená přesunout několik skriptů tam, kam patří, z testovací sady [PROJEKT3] a nějakého automatického běžce.
Pak také vytvořte konverzi z tabulek do HTML podobnou technologické konverzi a pak tyto výsledky pravidelně umístěte na své webové stránky.
Nebo byste mohli udělat kompletní git check out přímo z tohoto veřejného html nebo singling z tohoto veřejného html.
Takže by byl okamžitě přístupný přes web a kdokoliv by se mohl podívat na aktuální skóre a prozkoumat to.
Takže to by bylo užitečné, zejména pro m lidí mimo [ORGANIZACION2] jako například, [ORGANIZACION15].
Víme, že mají něco jako...
Výkon některých souborů byl špatný a mohli je přímo procházet na webu.
Mohli by si ho také prohlížet na [ORGANIZACION101].
Je na vás, jak to nastavíte, aby bylo uživatelsky přívětivé a snadno sledovatelné.
Dobře, udělám to.
Jo, díky.
Pracuji na tom, nebo se dostávám k aktualizaci, na předložení demo papíru, který je na příští pátek, pokud se nemýlím.
A pak mám nějaké projektové zprávy a začínám shromažďovat dokumenty - jako, nebo odkazy na dokumenty, ne samotné dokumenty, pro dvě sezení.
Pro ASR bychom měli přidat doplňkovou metrikou -
Vlastně bychom měli přidat doplňující metriky.
Takže, zmínil jste jeden a to je filtrování nemravnosti m hodnocení.
Takže <parallel_talk> má explicitní seznam věcí, které se nesmí objevit ve výstupu <parallel_talk>, že?
A pak hodnocení vzácných slov.
A tady máme explicitní seznam jmen a termínů, které chceme, aby se objevily ve výstupu, skóre nejen podle (řídící) rychlosti, ale skóre něčeho, co přímo účty tyto věci, že jo?
Ano, takže s tím naprosto souhlasím.
To zahrnuje i ruční přípravu referenční zprávy.
Takže oba potřebují manuálně vytvořené odkazy.
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladatelský slovník.
A měla by se o to brzy podělit.
Takže, tohle by se mohlo stát prázdnou částí druhé věci vzácného slova -
Takže <parallel_talk> by to bylo vzácné slovo pro MT a pak z [PROJEKT210] bychom také pravděpodobně dostali nějaký slovník. </parallel_talk>
Takže to by byla doména [PROJEK 210].
A [PERSON2], mohl bych vás požádat, abyste revidovali <nepochopitelné/> doménu a vytvořili takový slovník tím, že se podíváte na výstupy a na to, co v výstupích chybí.
Takže, jako v krátkém seznamu - seznam slov, které máme rádi, a nelíbí se nám v doméně <nepochopitelné/>.
- Mohl bys to udělat?
Mělo by to být proveditelné, tak to zkusme.
Bylo by skvělé, kdybys to dokázal.
Takže si to zapíšu.
Takže, <parallel_talk> zaměřuje se na [ORGANIZATION62] termín s titulníkem studijního papíru. </parallel_talk>
Ano <parallel_talk> a pak pak multi-zdroj s [PERSON7] nebo založené na [PERSON7] nebo - </parallel_talk>
A co se týče jazykového ID, zajímalo by mě, jak přesně to chcete integrovat, protože to už zahrnuje zvážení více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro jazykový ID?
Jak to zapojíme?
(PERSON13) Bude to audio textový pracovník, a bude vysílat časové razítka jako pro čtyři nebo dva sekundové okno a třídu.
<nepochopitelné/> ticho, česky, německy, anglicky, a pak dám ostatním vědět, jak to chtějí použít v potrubí.
To je důležité.
Prosím, napište to sem do dokumentu, do tohoto <nepochopitelného/> shrnutí, protože to je pro [PERSON2].
A také [ČLON 2], když mluvíte s [ČLON 10], a možná také [ČLON 5].
Pokud máme tento nástroj, musíme (doprava) audio na více ASR nebo více pracovníků <nerozumitelné/>
Budeme muset samostatně (odeslat) audio do anglického ASR, samostatně do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také, k tomuto jazykovému identifikátoru a pak musíme tyto výstupy sloučit, a to je nástroj, který ještě nemáme.
To je nástroj s více zdroji, který bude sledovat textové výstupy a také sledovat časové razítka a vypustí - pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby byl ASR tichý, pokud je to špatný jazyk, a je to rozpoznaný text, pokud je to správný jazyk.
Tohle jsem si vymyslel.
Další nastavení by bylo, že stejný zvuk je přenesen do ASR a do tohoto jazykového kontroléru.
Tento jazykový kontrolor je v podstatě součástí ASR, který ASR umlčí, pokud je to špatný jazyk.
To je taky možnost.
Takže musíme zjistit, který způsob integrace jazykového ID je pro naše účely nejlepší.
Takže prosím, přemýšlejte nad tím, jaké jsou naše potrubí.
V ideálním případě by podle mě nejméně podobných zmatků v řízení a podobně vzniklo, kdyby naše modely MT byly vícejazyčné.
Pokud podporují různé jazyky a překládá z kteréhokoli z těchto jazyků do angličtiny.
Možná jen kopírování, pokud by byla angličtina jako vstup, takže bychom měli na začátku vícejazyčné více ASR.
Všechny do angličtiny a pak z angličtiny do všech jazyků.
A později, když [PERSON12] bude mít vícejazyčný model ASR, nebude tento jazyk ID ani potřebovat.
(PERSON3) Jde o to, že pokud budeme provádět analýzu správně, jedna věc je možné protihodnotné hodnocení, jen abychom naznačili, že tyto omezení mají skutečný dopad na skutečný výstup.
To by bylo hezké a možná analýza pozornosti.
Ale nejsem si jistý, zda nám to může dát stejné odpovědi, v podstatě, jestliže model "if" se stará nebo ne o omezení.
Musel jsem se podívat na pár příkladů pozornosti, neudělal jsem žádnou statistiku nebo něco, a to se dívá na omezení, a když překládá omezení, vypadá jako omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti to v tomto smyslu nedělá.
Dělá to některé obecné překladatelské chyby, ale ne ty, které se snažíme vyřešit.
No, vraťme se k automatickému hodnocení, problém s nesouladem je, že výstup je správně zkreslen, ale kontext je jiný.
Proto to není stejná forma slova jako v odkazu, že?
Jo, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů jsou.
Stejně jako u prvních 100 příkladů, které byly automatickým hodnocením označeny jako chyby, bylo 91 z nich správně zkresleno v správných souvislostech.
(PERSON4) A myslím, že jen dvě nebo tři věty byly správně zkresleny v nesprávném kontextu, jako kdyby překlad byl špatný.
A pak jsou některé případy, kdy překlad byl úplně špatný, protože věta byla opravdu špatná, a část musí být <nepochopitelná/>, ale to byl jen jeden nebo dva případy.
Ale snažíte se při hodnocení odpovídat formám přesměrování, že?
Neděláš nic...
(PERSON3) -lematizace odkazu a
Oba, oba, oba, oba, shoduji povrchové formy i lemmu.
Aha, jasně, to jsou ty dvě partitury, že?
(PERSON4) Je to jen dilema skóre pro (Evropské?) není v tabulce, protože tabulka jako nebude zapadat do papíru tak <nepochopitelné/>
Pokrytí je vždycky 97 procent.
Jenom generuje správné lemmy, jen...
Jo, jasně, chápu to.
Takže lemma pokrytí říká, zda je zde omezení, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně ohnuté, ale to není případ.
Oh jo, jen nevím, jestli ty, jestli ty, jestli ty chytíš <nepochopitelné/> když jsme mluvili o [PERSON1],
Ale jedna věc je, že, že (dýchání) je lepší, ale druhá věc je, že lemma jsou vlastně správně ohýbané ručně,
Ale to je něco jiného, ne, žádný problém, je to vlastně dobré, že je <nepochopitelné/> správně, jo.
Takže jsem si říkal, že by to mohlo být.
Ale nejsem si jistý, jestli máme nějaké testovací údaje, ale mohli bychom si zahrát s modely s nějakým stylem přenosu?
Jak víte, můžeme použít omezení a pokusit se použít synonymní omezení místo toho a vidět nebo porovnat jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jako bych to jen popsal nejasně, protože já sám nemám přesnou představu, jak to udělat, ale mohl by to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakých stylech přenosu dat do anglického češtiny?
(PERSON4) <nerozumitelné/>
Tím, že přenesete styl, Dusane, myslíte, že by bylo něco, co je v psaném jazyce, a vy byste byli cílovou stranou, bylo by to v mluveném jazyce nebo něco takového?
(PERSON3) No, to je věc jako, mám jen omezené znalosti o úkolu.
Ale můžu si představit, že chcete přepsat větu, která není napsána mužem, ale je napsaná ženou, nebo, nevím, jako můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem moc obeznámena s přesnými datovými soubory a co pokrývají.
A myšlenka je, že styl vět je poměrně neurčitě definován.
Takže zase, nejsem si tak jistý.
Máme tu tento soubor proměn vět.
A jedna věc, která je tam a mohla by být označena jako stylový přenos je například, že věty jsou obecnější.
Takže detaily jsou vynechány, věta je zjednodušena a pak se věta zní jako hovorová.
No, jen parafrázuji.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení Matous provádí nějaký experiment s angličtinou a českou, ale nemáme zde žádné referenční údaje.
Takže nemáme žádný soubor dat o kompresi vět.
Takže možná by mohla být obecná úvaha zajímavá, ale obávám se, že existuje příliš mnoho různých dobrých generalizací, takže jediná referenční by byla příliš omezená, aby vám řekla něco o kvalitě vaší generalizace.
A nejsem si vědom žádných podobných genderových transformací, například, toto by mohlo být provedeno <nepochopitelně/> pro české, takže možná správnou osobou by byl Rudolf Rosa, zeptat se ho, jestli někdy vytvořil takový datový soubor.
Takže bude existovat generace nějaké věty založené na kořeni.
(PERSON3) Myslím, že je to vlastně jako zajímavá otázka, zda můžeme použít omezení k prosazování tohoto druhu stejného pohlaví řečníka v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní podčást testovací sady [PROJEKT1], která by to pokryla.
Někdy víme pohlaví řečníka, takže pokud ano... možná bych mohl sdílet obrazovku a prohlížet si to.
Nebo jsem to zkusil s Marian, která se na to podívala a je to... nevím, o kolik bodů nižší.
Protože podobně jako Martin dělá svůj <nepochopitelný/> překlad, překládá více vět najednou a pak si vybere jen tu střední a dělá to tak po celý dokument.
Takže kontext je jako v jednom <nepochopitelném/> spolu se větou, kterou chceme přeložit.
Jo, myslím, že to nebyl Dominik, co dělal nějaké experimenty s Ivanou?
Myslím, že před rokem nebo dvěma roky pro dvojité prázdné, kde se účastnili kontext nebo propojování kontext s vstupní věty a dělat nějaký druh překladu na úrovni dokumentu.
Ale věc je s tím, s konkatenací není zcela jisté, zda to má stejný efekt jako my děláme více kódovač nastavení-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale je to jsem překvapen, že [PERSON8] říká, že to nefunguje, a to je úplná zastávka.
Jo, dobře, tak promiň, možná bych měl být správnější, že to nefungovalo tak, jak jsem to udělal.
(PERSON1) Ano, protože si myslím, že je to metoda, která je velmi snadná k testování, a vždy by měla být testována v kontrastu s dvěma enkodéry, a očekával bych, že někdy bude lepší a někdy horší než dva enkodéry nastavené, v závislosti na přesném úkolu, jako například co přesně je druhá věc, kterou kódujete.
Takže, možná, pokud máte dvě kopie, dvě parafráze téže věty,
Možná je to nějak zmatené, takže nevím.
Chování by mohlo být také jiné u starých metod sekvence-sekvence, ve srovnání s transformátorem, takže u RNN se chovala jinak možná s transformátorem, je to těžší trénovat, takže možná potřebujete zvýšit počet zahřátek, sety zahřátek.
Jo, takže prostě vězte, že...
Nepamatuju si to, takže si to nepamatuju přesně, ale tohle je jako...
když jsem v létě začal s těmi multi-source experimenty.
První věc, kterou jsem začal, byla parafráze a zdroj a možná jsem, teď si to nepamatuji,
Můžu to zkontrolovat až do další schůzky, jestli jsem se taky snažil,
Rozhodně jsem to zkusil, když jsou zdroje na první pozici, pak nějaký delimiter a parafraze na druhé pozici.
Možná jsem také zkusil, že jsem ty dvě věci náhodně smíchal, jo, a pamatuji si, že to bylo spousta toho kompenetráce a zkoušel jsem multi-encoder.
A pravděpodobně to bylo kvůli nízkým výsledkům.
(PERSON2) <nepochopitelný/>, který se vám líbí, může zlepšit vaše skóre pohodlí pouze přidáním výstupů založených na frázi a pozornost je jako dvojitá diagonální, takže pozornost není problém, takže jako já vám věřím, ale je překvapivé, že to nefungovalo.
Takže, pokud zadáte výstup založený na frázi, což je v podstatě post-editing, můžete to považovat za post-editing, jako když jste post-editing výstup založený na frázi, nebo to závisí na pohledu, že?
(PERSON1) <nerozumitelné/>, které byste chtěli úplně přepsat, ale technicky se to přesně hodí k úkolu po úpravě, můžete to připojit jako řešení úkolu po úpravě.
(PERSON10) Dobře, tak jedna otázka jen pro mě jen aby se ujistil, že v nastavení řetězce vložit větu odděleného token, že jo?
Máte speciální symbol, který rozlišuje, který je zdroj a který je kontext nebo druhá věta, nebo je prostě spojujete bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Zkusil jsem, myslím, že dva tokeny a jo, protože v první verzi jsme měli podezření, že token by mohl být také tokenizován, takže jsem ho pak přehrával s dalším tokenem, který není jen pro tento účel, protože jsme použili předškolený slovník a tento slovník neobsahoval separátorové tokeny.
Takže jsem použil nějaký token, který jsem předpokládal, že nebude jako token na několik kusů a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento symbol nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže, mohlo by to být provedeno lépe, ano, souhlasím.
Ale ten Flask nebo komunikace s klientem je něco, co nemůžu udělat.
Protože nemám žádné zkušenosti a nemám čas, abych to spustil.
Myslel jsem, že to znamená něco, když použiješ neznámého prostředníka.
(PERSON2) Ne, vytvořit HTTP klient, který může zaplnit řadu a číst z jiné řady.
A text pošlete zpět jako HTTP žádost.
Protože můj nápad je, aby se uživatelské kliknutí použilo i v ukrajinském projektu.
(PERSON2) A můj nápad je, že klient klikne na tlačítko mikrofonu a začne mluvit, a když uživatel mluví, vysíláte zvuk v malých částech současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server dát do fronty, kterou budu nakládat s fronty později s (ASR).
A model bude dělat nějakou logiku, nějakou inferenci s tím.
A kdykoli má nový kus přepisu, pošle ho zpět a uživatel by měl získat zpět částečný přepis.
A mělo by se to okamžitě zobrazit v textovém poli.
To bych si mohla představit.
Já Flaska taky moc neznám, ale jo, o tom můžu přemýšlet.
Možná jiný HTTP server.
Nevím, možná ani nepotřebujeme na to nějaký skvělý HTTP server.
Pro textový tok používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo pro tohle.
Jo, jediným požadavkem je, že by měl zvládnout více spojení najednou.
Myslím, že on-line textový tok je něco kolem 2 000 nejméně.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s malými různými vnitřními pracovníky, takže myslím, že ano, takže mám <nerozumitelné/> řekněme deset, no místo výstupu, soubor od <nerozumitelného/> vedlejšího pracovníka, takže <nerozumitelné/>, který máme, takže se ujistím, že tyto věci pro jeden soubor jsou generovány paralelně ze všech dostupných pracovníků.
To by nám ušetřilo čas.
(PERSON7) Jo, jo, je to velmi důležité, aby se všechno paralelovalo, vlastně, aby se paralelovalo jak zpracování systémů, tak i vyhodnocení buněk DF, protože by to musel spustit mnohokrát, budou tam chyby, musíte to rychle spustit znovu.
Dobře, takže díky.
Takže, jste s tím velmi zaneprázdněn, nechci vám dávat na hlavu další věci, takže začnu s připomínkami.
Musíme dokončit popis [PROJEKT1] stolní sady,
Koho to tu máme?
No, ne tak docela, jo, a bohužel tady není.
Takže tohle bude pro [PERSON2],
A pak hodnocení, to je pro [PERSON1], ale o tom jsme už mluvili.
Poslouchejte, dejte mi tabulku v DSD, dejme tu jemnou čáru a vytlačíme šablonu tabulky, jako je struktura plánu do delebl, takže čísla přijdou později, ale chci vidět některá čísla a plnou strukturu tabulky velmi brzy.
Dobře, děkuji.
Máme [PERSON5], to je dobře.
Takže, pro [PERSON5], bych rád zkontroloval, jaký je pokrok v hodnocení systémů, a zda jste v kontaktu s [PERSON1] také pro evoluci, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do Petriho prostředí.
Jo, je tu ještě jedna věc.
Možná není dobrý nápad spojit tyhle dva útoky do jednoho.
Myslím, že je vlastně lepší, když to spustíte odděleně a uložíte výstupy.
Takže nejprve použijete prostředí pro rychlostní kontrolu a zpracování,
(PERSON7) a shromažďujete všechny výstupní soubory a pak provedeš hodnocení.
A důvodem tohoto rozdělení je, že můžete paralyzovat více.
Takže budou problémy na různých frontách, jsem si jistý, a budeme potřebovat čísla velmi brzy.
Takže, pokud například některé z testovacích souborů z nějakého důvodu selžou,
Pak můžete stále udržet překlad běžet pro zbývající,
a znovu vyhodnotit, s sel T F, chybějící, a, a tak dále.
Takže, to je, bod není vytvořit sériové, sekvenční zpracování, které zahrnuje oba,
ale hlavní je získat výsledky, a je lepší to dělat po kouscích.
Nejdřív všechny výsledky, pak všechny hodnocení.
Jo, takže, myslím, právě teď jsem dělal to samé.
Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Jako filtrování paprsků a nahrazení paprsků jinými paprsky.
A pro omezení s více tokeny a podobné věci.
Ale pro pozitivní omezení jsem porovnal pouze tréninkový přístup s jo, jen s těmito velmi jednoduchými věcmi.
Jenom měním skóre v každém kroku stejným způsobem.
Dobře, takže zpět k pozitivním omezením.
Už jste se zaměřil na analýzu systému?
(PERSON2) Jo, právě teď, tak nějak čekám na přepracování datového souboru z ([PERSON9]).
Taky jsem se podíval na kód a myslím, že vím, proč je tak pomalý.
Protože pro každý vstup do terminologie v (Europar) přepracování, otevřete datový soubor, tokenizujete ho, čtete řádek po řádku, tokenizujete řádek po řádku a pak ho zavřete.
Ale to děláš jen ty.
(PERSON4) Pamatuji si, že jsem to dělal pro [PROJEKT1] loni z nějaké chalupy v horách.
A já si uvědomil, krátce před Silvestrem, že to musím předložit.
A <smích/> takže tohle je také něco, co se stane [PERSON8] Obávám se, že by mohl být... no, žádná párty, ale možná na vzdálené párty.
A pak si najednou uvědomil, že to musí předložit.
Takže, nebude žádná revize, jako v tomto bodě.
Prostě by vzal PDF a nahrál ho.
Dobře, dobře.
Takže, jo, zkontroluju to na 21., a jinak jim pošlu e-mail.
Prosím, myslím, že je lepší jim hned teď poslat e-mail a požádat o ten odkaz předem.
Dobře.
Jo, díky.
Máme dnes ještě nějaké jiné záležitosti, nebo je to všechno do nového roku?
Doufám, že pro mě nic nemáte.
Před několika lety.
MT maratony měly tento systém nebo nástroje, které byly publikovány jako speciální číslo PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, byl integrován s normálními, jako byly také PBML problémy, které smíchaly prázdné margin papers a samostatné papers kvůli počtu těchto papers.
A dokonce jsme měli něco jako, jestli ten článek není dost dobrý pro PBML, ale jestli ten nástroj byl prezentován na MT maratonu.
Autoři byli vyzváni, aby se přihlásili k dalšímu přezkumu pro další číslo PBML.
Takže, máme, jak jsem řekl, váš systém, váš nástroj je zajímavý.
Prosím, uveřejněte to na MT maratonu mezi lidmi.
Ale tvoje práce je špatná.
Musíš to vylepšit, a dostaneš se až na další PBML.
Ano, ale další možnost pro SIGDial.
Není možné, že pokusem o SIGDial přilákáme lepší účastníky?
To je ano, to je... jako bych si myslel, že jsem měl taky, ale neznám ani jedno z těchto míst.
V červenci mají poslední papírovou registraci.
Takže konference byla v září a předložení práce v květnu.
Protože pro Interspeech bychom to mohli rozdělit papír za papírem.
Aby se některé papíry dostaly do řízení Interspeech.
A některé z našich podkladových papírů přijdou později pro řízení PBML.
A autoři by si mohli volně vybrat.
Takže to musíme vyjednat buď s SIGDial nebo Interspeech.
Pokud je pro ně v pořádku mít některé z našich papírů, vzhledem k tomu, že tyto papíry jsou předloženy v březnu.
Takže je tu absolutně přísná podmínka.
A myslím, že proti tomu nic mít nemohou.
Protože jestli ten článek stojí za to, aby byl publikován.
Jako bonus, že se v novinách objeví výsledky společných úkolů v satelitní události.
Takže jo, myslím, že je to v pořádku.
Takže nemusíme žádat o zvláštní schůzku.
V Interspeech se tomu říká zvláštní zasedání, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj článek připraven do termínu Interspeech, zašlete ho jako článek Interspeech a obdržíte ho v Interspeech.
Pokud to neuděláte do termínu Interspeech, tady je náš termín.
A to je za PBML.
Dobře.
Ale je to jako na satelitní akci Interspeech.
Interspeech se do žádného řízení nedostane.
(PERSON2) Můžete si jen tak rezervovat celý semestr jen pro kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale já si myslím, že je to něco jiného, protože si myslím, že to není opravdu věc, aby selhal své kurzy.
Líbí se ti selhání, protože to nedokážeš dokončit.
Samozřejmě, že se lidé prostě vzdávají, ale myslím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že je to určitě možné, ale je to hodně práce.
Jo, myslím, že nám na začátku semestru řekl, že když chceme jedničku, dostaneme ji.
Jen do druhé lhůty, byste to měli předložit.
To je asi jediná věc, kterou se ptal.
Ale také nám řekl, že podle trendů z minulých let to mnoho lidí nedělá.
Je pro ně snazší číst před zkouškou.
Ne, promiň, učím se na zkoušku.
Jo, protože jeho zkoušky jsou obecně docela jednoduché.
Takže bych neřekl, že je to super snadné, protože jsou kurzy, kde je zkouška zábava.
No, jeden z nich byl včera pro mě.
(PERSON2) Jo, když má krátký kontext a protože dělám rozhodnutí založená na velmi krátkém kontextu pro tuto velmi nízkou latenci, pak se opravdu zaváže k něčemu, že například za sekundu nebo dvě, zjistí oh, no, vlastně to byl špatný překlad.
Takže se snaží použít jiné znění.
Například, aby se určila věc.
Takže se mi to opravdu líbilo.
Byl jsem opravdu ohromen, i když jste viděli, že model udělal chyby při prvním pokusu, opravdu chtěl udělat nějakou opravu.
A rozhodně to znělo plynule, což je podle mě také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i mírně nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita, protože překlad, pokud si přečtete všechno, co dostanete stejné informace, ale formulace je jen chudá, protože to použilo, například, více slov a použil některé opravy a věci.
Takže si myslím, že to je naprosto v pořádku pro současné, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako příklady?
Protože bych se na to rád podíval, jen ze zvědavosti.
Oh, určitě, můžu ti dát moje deníky.
(PERSON7) Ale v jakých jazycích?
Protože víš, že nemluvím německy.
(PERSON2) angličtina a němčina.
Jo, ale nemluvím nutně německy.
(PERSON2) Pak vám můžu poskytnout angličtinu/čínštinu a angličtinu/japonskou, pokud to pomůže <smích/>.
(PERSON2) Takže znovu, chci to udělat lidsky čitelným.
Protože to blikání je opravdu otravné a pak se ztrácíte na tom, co bylo skutečně řečeno, protože možná je to také otázka někoho, kdo ví více o lidském mozku a o tom, jak pracujeme s informacemi.
Promiň, nikdy jsem o tom nepřemýšlel.
Ale myslím si, že kdykoliv vidím slovo, vložím si ho do paměti a moje paměť není lineární, ale spíše je to jako taška.
Tak jsem dal slovo do pytle.
A rád spojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je ten problém s tím blikavým světlem.
Když něco přeložíte a pak to změníte, tak to vlastně už jsem četl, je to v mém mozku.
A pak jsem ztratil soustředění a kontrolu nad tím, co bylo vlastně přeloženo jako správné a co nebylo.
Proto si myslím, že celá ta věc s třpytím je špatná a hloupá.
Jako bych viděl motivaci, jako bys chtěl ukázat všechno, co máš.
I když nemůžeš slíbit, že je to dobré.
Ale myslím, že s těmito dalšími informacemi nemůžeme pracovat.
A myslím, že možná je problém v tom, že systémy jsou vytvářeny lidmi, kteří s nimi pracují.
Pokud vyvíjím systém, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále ho ukazuji a je to nějak dobré, ale myslím, že vývojář se ve skutečnosti nesoustředí na samotný obsah.
A jak vnímáte obsah, ale spíše, že můj systém to dokáže vypustit opravdu rychle.
A i když to jen hádá, že kvalita je v pořádku, myslím, že možná proto byl vytvořen přeložení.
Jen vývojáři systémů jsou dychtiví zobrazovat informace, a myslím, že protože jsme omezení v objemu informací, které můžeme vnímat, rádi vidíme, že extra informace jsou pro nás jen další zátěž.
Takže si myslím, že není dobré ukazovat se navíc.
Jako když chcete snížit latenci, tak místo blikajícího, snížte kvalitu.
Myslím, že je to lepší než ukazovat ten blikající obraz.
Protože jaký by to bylo skutečné použití?
Proč byste potřeboval vidět nestabilní hypotézu, opravdu?
Jako z pohledu uživatele?
(PERSON1) Technicky vzato, když lidé začnou překládat, myslím tím, že cílem je i pro komentáře, že se budou snažit sledovat řečnický řetězec původního mluvčího.
Takže jsou chvíle, kdy něco řeknou, a to by bylo špatné, takže by se jen opravily.
(PERSON2) No, ale jo, to znamená, že s mým řešením, jako byste neudělali třpyt, ale jste se zavázali, jako že neexistuje způsob, jak se změnit, ale opravit se.
A to je vlastně to, co překladatelé dělají.
Mám silný pocit, že naše práce není přesně v doméně řeči, je nezdravá.
Protože tady není žádný pojem řeči.
Pracujeme přímo na textu.
Ale věc je taková, že návrh na statistický seminář je letos u konce, což bylo v září, což bylo pro nás příliš brzy.
A další návrh by přišel v roce 2022, což by pro nás bylo příliš pozdě.
Je lepší, když máme buď sektilní nebo interspeech, protože oba jsou dobře uznávané v komunitě.
Můžeme motivovat účastníky, aby se podřídili.
Jediná výstraha, kterou teď vidím, je, že nám nedovolí prostor v jednání, což může odradit některé účastníky, nejsem si jistý, jak moc budou nadšeni, že zveřejní článek v archivu.
Takže v archivu mohou lidé publikovat kdykoliv, že?
Takže to není výhodou pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu?
Proto jsem se za tuto zvláštní schůzku zaručil.
Ale tentokrát je problém, že jak jsem pochopil, naposledy, časové období mezi návrhy, podání a konečné podání papíru bylo pět měsíců, takže by to bylo dost času pro náš rozvrh, ale tentokrát.
Jsou to jen tři měsíce.
Takže, vidím tento veletrh jako důležitý možný zdroj nemluvňat anglicky, který můžeme použít k rozšíření testovacího souboru.
Takže si myslím, že bychom se měli zaměřit na soutěž o nejčistší hlas a můžeme udělat stánek, když budeme muset.
Ale rád bych to omezil, protože šíření mezi středoškolskými studenty má pro nás menší dopad.
Je důležitější to použít jako testovací sezení.
Takže bychom se měli zaměřit, [PERSON1], na [PROJEKT2] nejčistší hlas a udržet organizátory šťastné, abychom mohli shromažďovat data.
A uděláme cokoliv, co chtějí, abychom za to udělali, a musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tento plenární program užitečný.
Takže to bude pro nás testovací sezení, a co se týče naší přítomnosti na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud se nás zeptají, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, tak dobře, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a za scénou a dělat tam naši práci.
Jo, ještě jsem se nepokusil o registraci, ale myslím, že naposledy bylo povinné mít kabinu.
Takže s nimi promluvte o tom, co je potřeba, aby byli šťastní a dovolili nám dělat Clearest Voice, což je nejdůležitější.
Testování je méně nutkání.
A stánku bychom se mohli vyhnout, pokud je to možné.
Raději bych, aby se připojili k sezení dříve, než aby dělali takové věci.
Takže, opravdu potřebujeme cvičit tyto přípravy.
V online světě se zdá, že jednoduše zapnete do relace a práce je hotová.
Ale to není pravda.
Vždy trvá 30 minut, než se to spustí a bude správně připojeno.
Takže tam musíme být dřív.
A když se nějaká schůzka, kterou děláme, začne v devět, ale organizátoři se sejdou v čtvrt na devět.
Pak musíme přijít v osm čtvrt na pět, takže máme 30 minut navíc, abychom se ujistili, že všechno běží a pronásledovali lidi.
Takže, toto je poznámka pro všechny, aby vedení fungovalo, prosím, předvídejte také, co by vás vedení mohlo najednou požádat, abyste udělali, a to by trochu pomohlo.
Další velmi důležitou zprávou je nahrávání těchto důležitých setkání.
Nevím, jestli jste odpověděli, ale neviděl jsem nikoho, kdo by poskytl nějaké aktualizace dokumentu.
Možná jsem vám to zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJEKTU4] a [PROJEKTU5] 2020.
A první věc, kterou jsme si při této zkušenosti mohli připomenout, je, že jsme byli velice špatní při nahrávání těchto sezení.
Takže je důležité pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo mít dobré nahrávky těchto sezení.
A jedním aspektem je získat souhlas, aby bylo možné nahrávat.
A i když se pokusíme získat souhlasy zpětně nebo cokoliv.
Pak je tu technický aspekt nahrávání.
A viděli jsme, že je to tak rozmanité a složité.
Jo, [PERSON5] posílá ten odkaz.
Poslal jsem ti to e-mailem, pamatuju si to.
2 špatné citrony v řadě:
Objednal jsem si ho od téhle společnosti, protože jsem ho koupil v předchozích sezónách a fungoval nám skvěle.
V téhle sezóně jsem si koupila další velikost, kterou jsem potřebovala.
Jeden z pyžam, který jsem dostal, měl na nohou díru.
Vrátil jsem ho a firma mi poslala nový.
Náhradní pyžamo, které měl můj syn, jsem ho dala do pračky jako vždycky a rozbil se mi zip!
Jsem tak zklamaná, protože nemám čas na to, abych se zabývala vrácením zboží každých pár dní a přesto se to právě teď děje.
Přesně jak bylo popsáno.
Tohle je základní plášť.
Pokud hledáte základní kabát, pak tento kabát splní vaše očekávání.
Kabát přišel ve vakuově uzavřeném sáčku, takže ho musíme pár dní pověsit, aby se z něj mohly dostat vrásky a aby se trochu "nafoukl".
Jsem vysoká 1,80 metrů a kabát mi jde až k kolenům.
Objednala jsem si 2 a více velikostí vzhledem k ostatním komentářům a zkušenostem z minulosti, a kabát je pravděpodobně trochu větší, než je potřeba.
Ale s těžším svetrem nebo mikinou by to mělo být v pořádku.
Na rukávech nejsou pouta, takže je asi přidám později.
Kapuce funguje, ale žádné vazby na ní.
Přední zip funguje.
Na straně ani vzadu nejsou ventilační otvory pro další pohyb, ale s větší velikostí bych měl mít spoustu místa.
Mám dvě kapsy v pasu (na tobě může být vyšší nebo nižší).
Není tam žádné ozdoby nebo stylové detaily, je to BASIC COAT.
Za tu cenu, myslím, že je to v pořádku.
Nosila jsem ho i ve větrný den, ale ne na chlad.
Necítil jsem vítr, takže to je dobré znamení.
Jsem však zvědavý, jak bude fungovat v chladnějších podmínkách a v dešti/sněhu (měl by být odolný).
Celkově jsem spokojen.
Ta vakuová taška se dá znovu použít a prodávající přidal do ní opravdu roztomilý děkovný dopis, což byl skvělý dotek.
To je velmi pěkná sukně.
Ten krajkový vzor je elegantní a jemný.
To je velmi pěkná sukně.
Ten krajkový vzor je elegantní a měkký.
Nezmršťuje se, i když je vkládána do plastu a krabice, byla velmi hladká, takže je to opravdu super.
To může být snadno oblečený dolů nebo oblečený, a má druh vintage pocit kvůli délce a řez, který jsem opravdu do.
Myslím, že to může být lichotné pro kohokoliv.
Mám 1,70 a 130 liber a objednala jsem si malou, takže pokud máte pocit, že jste uvízla mezi malou a střední, určitě si vezměte menší.
Nefungovalo to s mým Buickem LeSabrem z roku 1999.
Položka přišla rychle a vypadalo to, že je v dobrém stavu, dokonce byla součástí baterie předinstalovaná.
Nicméně, i když by měl být kompatibilní s mým 1999 Buick LeSabre, dálkový ovladač selhal programovat nebo synchronizovat s autem.
Instrukce jsou dostatečně jednoduché a vím, že jsem je dodržoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý ovladač.
Tenhle nový, nicméně, by nefungoval a tak ho vrátím.
S prodejcem nebo servisem nebyl žádný problém, jen se zdálo, že tahle konkrétní položka je vadná nebo neslučitelná s mým vozidlem.
Dobrá cena za náhradu
Gril mého auta byl odtržen velkým něčím, co letělo po dálnici, takže jsem potřeboval náhradu.
Bála jsem se, že to nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Já jsem si to nenalíčil sám - nechal jsem to udělat chlápkovi v dílně - ale vypadalo to opravdu snadno.
Prostě to za necelých 5 minut zapadlo.
Dal jsem mu 4 hvězdičky za robustnost, protože se zdá být docela křehký (čas a létající trosky to ukáží), ale celkově jsem velmi spokojený, že mé auto už nemá na přední straně otevřenou čelisti a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Můj 5letý miloval toto světlo, netrvalo dlouho, dostal ho k narozeninám v lednu, je únor, už má problémy s tlačítky a nejezdí jasně s zásuvkou, žere baterie, dokonce se pokusil dobít baterie Super cool, ale potřebuje zlepšení
Začátek hudby
Piáno je skvělý začátek!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí se v ní dobrá koordinace ruka-oko.
Klavír není jen hračkou, ale funguje a umožňuje vašemu dítěti hrát hudbu v raném věku.
Jestli chcete, aby vaše dítě bylo budoucím klavíristem, měli byste tento produkt vyzkoušet!
Hodí se to za peníze!
Dávám si to na nos, jak jsem se naučila, dvakrát denně a třu si to po dobu dvou minut.
Kůže na mém nose se zarudla a úplně se mi rozpárla.
Byl jsem docela překvapený.
Měla jsem dobře zahojenou jizvu z pádu do ostnatého drátu před lety.
Nejenže tento přípravek nefungoval, ale málem jsem skončila u dermatologa. Ale po týdnu jsem si na to místo dala vodu a obvaz a konečně se uklidnilo.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Někdo to s receptem zkazil?
To je tak divný.
Při normálním světle to vypadá, jako bych měl růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou čáru pomocí barvy jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejčastější barva, takže jsem z toho trochu rozrušená.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl nazývat je červenými nebo růžovými.
Bílá není tak jasná, jak jsem doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se ty barvy umývají.
Jen jsem myslel, že tam byla růžová.
Myslím, že fialová bude stačit.
Většinou funguje
Před několika měsíci jsem si celou hlavu vybělila a pak ji obarvila barvou z černé krabice.
Pak jsem si nechal na hlavu dát výzdvihy.
O pár týdnů později jsem si na vlasy dala modro-zelenou barvu na vlasy arktického liška a ta mi nezmizela.
Použil jsem to s Olaplexem č. 3 a to všechno nesmírně osvětlilo, odstranilo zelené a modré části a také odstranilo tmavé barvivo.
Po jednom dni jsem si však všiml, že se mi vlasy staly zelenými.
Každý den je to horší a už jsem použil extrahér dvakrát, se stejnými výsledky.
Moje vlasy jsou také tmavší, kde byla krabice barvy.
Tohle je skvělý produkt, ale zdá se, že to nevydrží.
Nevěřte tomu, co se říká.
Příliš mnoho pětihvězdičkových recenzí tohoto románu musí být zklidněno některými realističtějšími hodnoceními.
Snažil jsem se to přečíst, ale jazyk byl úplně stejný.
metafora "sladké vody" a mnohé popisy dělohy jako řeky a dítěte jako ryby se zdálo být vynucené, vymačkané a vymyslené.
Přeskočil jsem to a vypadalo to, že všechno, co jsem našel, byla školní dráma.
Dávám této knize 10 hvězdiček!
Skvělé čtení!
Tu knihu jsem naprosto milovala!
Za ta léta jsem si adoptovala 4 siamské kočky od Siri a všechny byly naprostá láska.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri se v úsilí zachránit kočky (hlavně siamské) vynasnažila víc než jen to!!
Opravdu se mi líbí to světlo!
Je to skvělé za tu cenu a dělá svou práci!
Jediný problém je, že žárovka se zahřeje moc rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak zase zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám vadnou světlo nebo co, ale je to velmi pěkné kruhové světlo kromě přehřátí.
Zmatený příběh
S knihou bylo těžké držet krok, protože hodně skákala.
Také název nesedí k příběhu.
Autor uvedl, že několik lidí bylo infikováno tímto mimozemšťanem, ale vynechal podrobnosti o tom, kdy nebo jak se to stalo.
Občas jsem byla zmatená a musela jsem se vracet a hodně číst, abych se ujistila, že jsem nic nezmeškala.
Milovaný Collins...
Trvalo mi, než jsem se Gradyho naučil.
3 1/2 hvězdy Remedy je románek mezi nejlepšími přáteli a druhá šance smíšená do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat všechno, aby dostal Collinse zpět a prokázal, že je pro ni tím pravým.
Před třemi lety měli Grady a Collins spolu úžasnou noc.
Collinsová si myslela, že konečně má vše, o čem snila, nejlepší kamarádku svého bratra... ale když se ráno probudila sama a nikdy se o ní neozvala, věci se rozhodně změnily.
Teď je Grady zpátky a neodejde, a dělá všechno, co je v jeho silách, aby jí dokázal, proč odešel, a že ji tentokrát nevzdá.
Zatímco já miloval předpoklad tohoto příběhu, a někdy Grady, on opravdu dostal na mé nervy.
Úplně chápu jeho důvod, proč tu noc odešel, ale ani neposlat dopis Collinsovi, kde by se vysvětlil?
Nechal ji tak dlouho v úzkosti a trpěla bolestí, a pak čekal, že ho přivítá s otevřenou náručí?
Byl to blázen?
Collins měl pravdu, že byl naštvaný, naštvaný, zraněný, atd.
Měla pravdu, že se s ním postavila do boje, když ji chtěl zpátky a posunula se dál.
Obdivuji její vůli, protože Grady byl vytrvalý.
Miloval jsem Collinsovou v téhle knize, byla silná a střežila své srdce, a obdivoval jsem ji za to.
Jistě, že Gradyho milovala, ale byla vyděšená a váhala ho pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla zcela jistě má nejoblíbenější z těch dvou.
Rozhodně nechávala věci běžet tak, jak chtěla, a když byla připravena naslouchat, naslouchala.
V téhle knize je hodně úzkosti a já si užil sledovat, jak se ti dva znovu spojili, když Collins začal Gradymu odpouštět, jen jsem si přál, aby Grady nevypadal tak kňučivě a byl trochu chápavější.
Pořád říkal, že to chápe, ale občas na mě příliš tlačil, a pak byl ke konci sladký.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla problém číst jeho názory, protože jsem se nemohla spojit s jeho postavou.
První část knihy mi nebyla oblíbená, ale druhá část?
- Zbožňoval jsem ho, proto mám hodnocení.
Pokud máte rádi druhou šanci a románky o bratrských přátelích, možná se vám tahle kniha bude líbit, ale já jsem měl jen na začátku problém s Grady a s tím, jak zvládal některé věci, které udělal.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho portrétu Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho portrétu Churchilla, bylo to velmi dobře.
Zkrácený časový rámec od 10. do 26. května byl dobře prezentován s hodinami 7 otáčejícími stránky...
Scéna a kostýmy byly vynikající.
Je dojemný, že dnešní dvojice polobohů drží světové politické postavení.
Stojí za to se podívat několikrát... stojí za to přemýšlet... ještě mnohokrát
Vyhněte se Wifi připojení - přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme se právě stěhovali a bydleli jsme v hotelu.
Nemohl jsem dostat tuto váhu, aby se připojil k Wifi v hotelu.
Rozhodl jsem se počkat, až se nastěhujeme a budu mít svůj vlastní Wi-Fi systém.
Březen 2018 - Nastavil jsem Wifi systém a ta váha se stále nespojuje.
Pokaždé, když to zkusím, dostanu chybovou zprávu.
I když jsem 10 metrů od Wifi jednotky.
Sledoval jsem video na YouTube, ale bez úspěchu.
Když jsem si ten přístroj koupil, myslel jsem, že se spojí přímo s telefonem mé ženy (jako Bluetooth).
Místo toho, tato váha používá Wifi router pro komunikaci s telefonem.
Tento systém je omezen na připojení k routeru...které není obvykle blízko ložnice na rozdíl od mobilního telefonu!
Nedoporučoval bych tuhle váhu nikomu kvůli Wifi připojení.
Místo toho se podívejte na systémy, které používají Bluetooth pro komunikaci.
Tohle nahrazuji Bluetoothovou váhou.
Dobře, ale rád bych našel něco lepšího.
Po dlouhém zkoumání jsem začal používat tento produkt před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval.
Nicméně, suší tak rychle, že nakonec použijete tolik lubrikantu, což nakonec stojí hodně peněz, a také je příliš rušivé během sexu.
Byl jsem příliš líný, abych hledal nový produkt, ale začnu hledat ten, který je neškodný, funguje dobře a není příliš drahý.
Životnost baterie je hrozná na tom, co jsem koupil na Amazonu.
Pořád nemůžu uvěřit, že Logitech přestal vyrábět tento ovladač, nic jiného se k tomu nepřiblíží.
Miluju tenhle ovladač Harmony, je to můj čtvrtý.
Pes rozkousl první, manžel klekl na obrazovce druhého a třetí stále funguje, ale je tam znamení lokte uprostřed dotykové obrazovky, také zdvořilost manžela...koupil jsem si tento jako zálohu a obrazovky jsou skvělé, ale baterie, se kterou přišel, vydrží nabitou možná pár dní.
Můj původní (třetí) je nabitý týdny a na všechno používám dálkový ovladač.
Zkrachoval za méně než týden.
Líbí se mi ten výrobek, je to pěkná velikost a barva!
Bohužel to mělo jen týden a otevřelo se jedno dveře a prasklo to horní část dřeva!
Jsem opravdu zklamaná!
Je to všechno sestavené a já už nemám krabici, tak jak bych mohla vůbec přemýšlet o tom, že to pošlu zpátky?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale bohužel to taky nefungovalo!
Dveře se znovu otevřely!
Není to snadné sestavit plus...
Je to pěkný kus nábytku, když je sestaven, ale montáž byla obtížná.
Některé písmenka byly špatně označené, takže jsem se musel sám pokusit zjistit, že šrouby, které mi dali k upevnění podlahy a bočních panelů, byly všechny prasklé.
Musel jsem jít ven a koupit rohové podpěry, abych se ujistil, že zůstanou pohromadě.
Také skleněné dveře jsou mimo linii a nesouhlasí rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedna z dveří zůstala zavřená, protože magnet, který udržuje dveře zavřené, je mimo linii.
Pořád nevím, jak je uspořádat.
Špatný kód vytištěný na vrchní straně hrnce
Koupil jsem je v únoru.
Nedávno jsem se je pokusil použít a bohužel pokaždé, když to zkusím, můj Keurig mi dá chybovou zprávu, že kapsle není kompatibilní s mým strojem.
Používám Donut Shop v mém přístroji od doby, co jsem ho poprvé koupil a nikdy jsem neměl problém.
Po bližším zkoumání kapsle jsem si všiml, že kód na vrcholu kapsle není moc čitelný, takže můžu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72 kusů, což je 6 krabic po 12 kusů.
Zkoušel jsem jeden z každých 6 políček a pořád dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože ostatní moduly, které jsem zkoušel, fungují dobře.
To je jen z této zásilky, že mám tento problém.
Velmi zklamání, protože moje návratová doba vypršela.
Aktualizace: Mluvil jsem s zástupcem zákazníka, který mi vrácí peníze.
Děkujeme AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cestě.
To je ale pohodlí!
Je opravdu příjemné mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích na odvoz!
Miluju to, když se to odkloní, a je to tak pohodlné, když je mám, abych je hodila do kabelky na večeři, nebo použila u kamaráda.
I když jsou trochu drahé, nemůžu vystát Equal nebo růžovou věc v ledovém čaji.
Zboč nebo nic, takže jsem nadšená, že mám svůj sladidlo na cestě!
Vlastně to nečišťuje vzduch.
Koupil jsem to jako zvlhčovač, část "čistící vzduch" je vlastně falešná reklama; v závislosti na tom, jak tvrdá je vaše voda, sediment se hromadí na dně, ale nic z toho není prach ve vašem domě, pokud nežijete v uhelném dole nebo tak nějak.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač typu facka se stejnou velikostí ventilátoru.
Výhodou je, že to neohrožuje víky.
Vzhledem k dodatečným nákladům na jednotku, budete ji pravděpodobně muset provozovat asi 5 let, abyste vyrovnali rozdíl.
Má poměrně velkou kapacitu vody pro svou velikost, protože "nádrž" je nedílnou součástí jednotky a má nízký výkon (i když není lepší než typ klínu).
Je také poměrně snadné ji vyčistit, ačkoli plastové disky nelze opravit, protože disková jednotka nelze demontovat.
Nicméně, pro německé inženýrství, není kvalita stavby skvělá.
Já mám svůj už rok, což by bylo asi šest měsíců chladu, a jednotka vyvolala velmi otravný šum z ventilátoru.
Myslím, že to bude ventilační ložisko, takže čekám, až se tady stane úplné selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř rovnocenné tomu, že si koupíte nový zvlhčovač.
T.L.D. - Nestojí to za ty peníze, je lepší mít zvlhčovač.
Asi to bylo jednodušší rozbít, než si mysleli.
Dávám tomuto produktu 3 hvězdičky, protože když jsem ho dostal dovnitř, byl už uvnitř rozbitý.
Když jsem to prozkoumal, uvědomil jsem si, že kdokoliv to dal do krabice, dal to tam rozbité, to mohli být buď výrobci, balení nebo výrobci, problém by mohl být, že kupující vrátil zboží a tvrdil, že ho prostě nechtěl nebo ho nepotřeboval a Amazon možná neudělal dostatečně dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti, kupující nemohl říct, že je rozbitý, protože pak by ho Amazon nevzal zpět, což je dobré, zvláště u tohoto druhu produktu, i když jsem to já, kdo se zasekl s něčí nedbalostí.
Ale peníze jsem dostal zpátky, takže po přemýšlení a po rozhovoru s manželkou jsem se rozhodl dát kupci další šanci.
S tím, že jsem řekl, že budu pouze aktualizovat svůj rating na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zachází s tímto příspěvkem (přinejmenším řešením) a pokud položka přijde ve skvělé formě, má skutečně příležitost dělat to, co dělá, a funguje dobře dělat to, co má dělat.
Snadno se instaluje?
Celkově jsem s tímto nákupem docela spokojená, ale nebylo to pro mě tak snadné nainstalovat.
Snažil jsem se několikrát nainstalovat oba "zvony" do připojeného vysílače, ale bez úspěchu.
Byl jsem připraven vrátit to, protože to nefunguje, ale myslel jsem, že to zkusím ještě jednou a zkontroluji baterie ve zvonech.
Voila...z krytů baterie vyčnívaly malé plastové tabule, které jsem si nasadil a vyšel z nich plastový kousek, který kryl baterii a bránil jí v práci.
Když jsem odstranil ty kousky plastu, zvony fungovaly dobře a byl jsem s tím nákupem naprosto spokojený.
Zvláštní je, že v příručce pro uživatele není zmínka o plastu na baterii, který musí být odstraněn, aby zvonek fungoval.
Bylo by to mnohem méně frustrující, kdyby to zmínili a já si nemyslel, že problém je, že jsem nedokončil instalaci správně.
Je to dobrý produkt s širokou škálou zvonů, zvonů a melodií, které si můžete vybrat a je snadné je změnit, kdykoli budete chtít.
Jedna věc, kterou se ptají při hodnocení tohoto zvonu je, jak je "odporný na počasí".
Nemůžu to komentovat, protože to bylo instalováno 5. července 2019 a pravděpodobně nebudeme schopni komentovat, jak je to odolné vůči povětrnostním vlivům, až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - znovu mě obvinil
Vyrůstal jsem s nimi a byl jsem nadšený, že je koupím pro svého syna, ale ztratili balíček živých housenek.
Řekli mi, že ho vymění a tentokrát si účtují půlku nákladů.
Po dlouhém telefonování mi nakonec účtovali novou objednávku s 3 dolary slevy.
Myslel jsem, že je to dost neprofesionální, protože nejenže to ztratili, ale donutili mě věřit, že to napraví, jen aby mi naúčtovali skoro plnou cenu na konci 30 minutového telefonátu s nějakým vtipem o poukazu.
Strávil jsem 30 minut na telefonu, tak jsem se vzdal a koupil si další sadu housenek.
- To je jedno.
Funguje to dobře po bolesti hlavy.
Měl jsem problém s jeho funkcí.
Kabel, který byl dodáván, nebyl dobrý - nechtěl nabíjet baterii.
Když jsem vyměnil kabel za svůj, byl jsem schopen ho nabit a pak připojit prostřednictvím bluetooth k PC.
Měl jsem problém najít software pro PC, ale když jsem poslal e-mail na podporu, odpověděli mi během jednoho dne s správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (port 4 v mém případě).
Přesnost a stabilita jednotky vypadá velmi dobře pro mou aplikaci, ale nebyl jsem schopen se připojit k iPhone nebo iPad (zkoušel jsem několik z nich) přes Bluetooth.
Budu muset tvrdě drátit, pokud se rozhodnu použít toto zařízení v mém produktu.
...bylo příliš žluté než jsem ho koupil a řekli mi, že je jako staré zlato.
Zeptal jsem se prodávajícího, jestli není barva příliš žlutá, než jsem si koupil a on mi řekl, že je to jako staré zlato, tmavší.
Nic blízkého!
Tenhle soubor vypadá velmi levně.
Je to super lesklá žlutá s hodně CZ, ještě lesklější.
Na fotce vypadá skvěle, ale v reálném životě bych ji nedala ani teenagerovi.
Miloval ten prsten - ale nemohl ho nosit pořád!
Ten prsten byl nádherný.
Líbil se mi design a jeho hromádkový vzhled; vypadal draze a byl velmi pohodlný!
Jediný důvod, proč jsem dal jen 3 hvězdičky a nakonec vrátil produkt je, že jsem si uvědomil, že bych ho nemohl nosit pořád.
Ráda nosím prsteny pořád, proto si vždycky beru stříbro. Vím, že někteří lidé říkali, že jejich prsteny po chvíli zbarvily, ale já jsem nosila svůj asi týden po sobě - dokonce i když jsem si myla ruce - a nevšimla jsem si, že by zbarvily.
Zajímavé je, že problém, který jsem měl, byl, že vnitřní pás prstence mi vlastně změnil prst na bílý a vlhký - podobně jako to dělá obvaz, když ho necháte na sobě dlouho.
Stalo se to i když jsem se ujistil, že prsten a prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se to nestalo s žádným jiným prstenem, ale bylo to nepříjemné, tak jsem se rozhodla, že to není prsten pro mě.
Škoda, protože jsem to opravdu milovala!
Takže pokud si kupujete tento prsten s úmyslem nosit ho jen příležitostně, říkám, že si ho dejte!
Nebudeš zklamaný!
koupit Špinavého kuchaře...
Vlastním malou špínu Pampered Chef, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Miluju používat tyto lžičky při pečení perfektně porcovaných sušenek.
Podíval jsem se na OXO a Pampered Chef a rozhodl jsem se ušetřit a koupit si OXO - s jejich produkty mám obvykle štěstí.
Ne tenhle.
Asi v třicáté hodině páka uvnitř šroubu přestala fungovat.
Musel jsem odtrhnout rukojeti a přemístit páku, abych udělal pár dalších a pak to zopakoval.
Takže... ušetři si rozum a kup si Pampered Chef.
Stojí to za to!
Už nikdy nebudu kupovat panu Kafe.
Chvíli to byl dobrý kávovar, ale vždycky s ním byly problémy.
Pokud by se mezi černým plastem a kovem na karafě dostala voda, tak by to uniklo a vyčerpalo vodu po několik dní.
Pak se nám zlomila plastová páka, která umožnila, aby káva prošla filtrem a vstoupila do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale oni mě jen odkázali na servis, který je více než 90 minut od mého domu.
Je skvělá na výrobu kávy a udržování teploty, ale je tu příliš mnoho dalších problémů, než aby se do ní investovalo za současnou cenu.
Musím koupit!
Líbila se mi ta růžová zlatá barva a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu obyčejné.
Mám rád, když jsou v rukojeti více detailů a všiml jsem si toho ještě před tím, než jsem ho koupil, a proto tomu dávám 5 hvězdiček!
Bylo snadné ho vyčistit a všechno bylo zabaleno individuálně, což jsem zjistila, že je opravdu organizované a uklidnilo to mou duši lol miluju, miluju, miluju barvu a určitě bych si to koupila znovu pro sebe nebo pro někoho blízkého!
Mohlo by to být dobré na tyči, ale NE jako zavěšený deflektor nebo štít proti počasí.
Škoda Audubon.
Instrukce říkají, že musíte zatlačit zástrčku do otvoru v defluze a "Ujišťujte se, že je pevně na místě".
Jak to???
Je navržen tak, aby se deflektor jednoduše nacházel volně na zástrčce, takže ho může vytlačit jakýkoliv tvor nebo i ten nejmenší vítr.
Můžete otočit zástrčku vzhůru nohama, takže šrouby na palce budou na spodní straně defektu, ale bude vám trvat hodiny, než tyto šrouby otočíte; žádný nástroj to neudělá a jen ty nejmenší prsty by to mohly snadno zvládnout.
Trvalo mi přes hodinu, než jsem je do nich zašrouboval, abych připevnil deflektor ke zásuvce.
Je to úplná PITA.
Objednal jsem si čtyři, ty tři, co jsem neotevřel, jdou rovnou zpátky a já hledám lepší ochranku proti počasí.
(Uznáváme to, není nic takového, co by veverky skutečně "zahrnulo"!)
Miluji mnoho vlastností těchto světel.
Koupila jsem si tuhle lampu, abych doplnila světlo, které moje nové sadby zeleniny dostávaly z okna.
Miluji mnoho vlastností těchto světel.
Výhody: Za prvé, snadno se přilepí na mou polici a ohýbají se do mnoha pozic, což mi umožňuje provádět změny, jak rostliny rostou.
Světla jsou chladná na dotek a neškodí ani při dotýkání rostlin.
Myslím, že moje zelenina má z těch světlů užitek.
Světla jsou stlačitelná, ale používám jen nejsilnější nastavení.
Nepoužil jsem časovač, raději jsem je sám zapínal a vypínal.
Tento prvek je užitečný v kancelářském prostředí s domácími rostlinami nebo na dovolené. Nevýhody: Nemyslím si, že jsou tyto světla dostatečně silná, aby byla primárním zdrojem světla pro rostliny v jeslích.
Světla jsou malá!
Až se zhasnou světla, budu si muset koupit úplně novou jednotku.
Pozor, smrad je hrozný, hrací automaty jsou moc velké.
Když jsem to poprvé viděl, myslel jsem, že je to krásné, ale smrdí to tak špatně.
Nejdřív jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že je to vůně plísně.
Nikdy to neodešlo, tak jsem to musela vrátit.
A navíc kapsy na kreditky jsou příliš velké.
Kreditky jsou všude dole, spropitné se neukáže, takže nevíte, jaká karta je kde a je velmi těžké ji dostat ven.
ZDÁVKA, na které se zobrazuje, kde se karty přilepí, není přesná.
Je to velmi malé.
Dostal jsem pásek s penězi na cestu a je mnohem menší, než na obrázcích.
Přál bych si, abych ho nekoupil a stejně budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel.
Nejdřív musím říct, že barva je milá.
Spousta věcí, které si objednám v fialové, jsou vždycky příliš lehké, příliš dětinské, příliš divné, příliš neonové, co máš.
Ale tahle fialová byla hluboká a bujná a já ji miluju, deštník je pevný a opravdu dobré kvality.
Nejlepší deštník, jaký jsem kdy měl.
Je vybaven krytem a i když to nemusí mít moc funkční využití, opravdu to udržuje ostrý vzhled.
Balení je hrozné - přišlo 3 poškozené kytary
Velmi pěkná kytara.
Škoda, že společnost neví, jak chránit svůj produkt.
Neobtěžujte se tím, že byste se snažili získat jednu, která není poškozena.
Dva jsme vrátili kvůli poškození při přepravě a ten třetí byl také poškozen.
Vzdal se.
Posílají ho v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Žádné polstrování.
Skvělý nápad!
Jenom potřebuje pár vylepšení, aby z něj byl opravdu úžasný produkt.
Opravdu skvělý koncept, když jde o karaoke.
Miluju karaoke, takže tenhle mikrofon mi hned vzbudil zájem.
Myslím, že celkový design je dobrý - růžové zlato je pěkný dotek.
Je to také standardní design, který jsem viděl na všech dalších možnostech souvisejících s tímto typem mikrofonu.
Pro nezasvěcené, způsob, jakým to funguje je, že současně působí jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Celkově máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co vyjde.
V samotném mikrofonu ale žádná hudba není.
Má Bluetooth konektor, takže ho synchronizujete s telefonem a stahujete karaoke aplikaci, která může poslat karaoke písničky do mikrofonu.
Nebo můžete synchronizovat i aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení hlasitosti hudby a vašeho hlasu (také samostatně!).
a dokonce má možnost nastavit úroveň ozvěny, takže zníte, jako byste byli v karaokém sále.
Některé věci, které bych rád viděl v budoucnu vylepšeny jsou: 1) je tu nějaká otravná zpětná vazba, která se nezdá, že zmizí bez ohledu na to, jak daleko odkládám svůj telefon od mikrofonu.
Jestli jsi na to přišel, rád bych to věděl!
2) vypínače na střed mikrofonu jsou nemotorné.
Jsem blázen do minimalizmu, takže by bylo skvělé, kdyby budoucí produkty mohly udělat design elegantnější.
3) podpora pro více karaoke aplikací Konečně, protože zvuk vychází přímo z tohoto mikrofonu, a ne přes plochou obrazovku nebo centrální systém reproduktorů v obýváku, není to tak zábavné na večírku.
Pokud by výrobce to nějak mohl integrovat do většího karaoke ekosystému, tak by to mohlo udělat tuto nekonečnost příjemnější.
Zkrácené vizuálními zařízeními
V říjnu 2017 jsem si zakoupil čtyři (4) kazety od Vision Supplies - Amazon Marketplace, takže bych je měl, když budu potřebovat a ušetřit náklady na dopravu.
Použil jsem dva za posledních pár let, asi jeden za rok, a fungovali dobře.
Zkoušel jsem použít jeden minulý týden, skoro prázdný po tisku 20 štítků, ale poslední vypršel po 40 stránkách.
Na obou chybí plast.
Řekla jsem, že záruka vypršela!!!!
Kdo by kontroloval každou zásobní vložku, když ji obdrží????
Kupující buďte si vědomi!!!!!!!!!!!
Promiň, cože?
Můj přítel mi doporučil masku z této řady, tak jsem si koupil tohle, tento kondicionér a všechno v jednom mléce.
Nemůžu mluvit o účinnosti produktu, protože ten zápach byl prostě nesnesitelný.
Víš, že ten zápach z plísně staré budovy používají v dámských toaletách, aby se pokusili zakrýt zápach "dám", ale nakonec to vypadá jako kyslý, chemický, jako zápach z plísně babičky?
Na tohle si myslím, když to cítím.
Znáš různé lidi, takže možná se ti bude líbit vůně.
Můj přítel říkal, že to může pomoci i těm nejvíce poškozeným vlasům, takže pokud se nestaráte o vůni, tak se nebojte.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale cítím, že přírodní linie se stále více a více nezajímají, protože se stejně prodá a tak teď všechno voní jako playdough.
Ztratil jsem pár oblíbených řádků kvůli tomu, že změnili recept na levnější ingredience.
Nevím, jestli je to tak, nebo jestli je to padělek (který jsem nazval Davines a oni řekli, že není), ale tohle smrdí jako Y U C K a já jsem ho musel vrátit.
Internet se vytratil
Ten modem/router jsem koupil asi před dvěma lety.
Na začátku to vypadalo v pořádku, ale za poslední rok jsem měl problémy s tím, že jsem ztratil internet.
To se děje na všech mých zařízeních, jak Wi-Fi, tak kabelovém.
Jediný způsob, jak obnovit službu, bylo obnovit napájení.
Stalo se to jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxální linku od podstavce k domu a zvýšil úroveň signálu.
Stejný problém.
Chlapi z Arris Tech byli skvělí, ale nedokázali ten problém vyřešit.
Navíc jsem při třem příležitostech přišel o 5G.
Musel jsem to obnovit továrním nastavením.
Nemohu doporučit tento modem/router na základě svých zkušeností.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Měl jsem ho přes týden bez problémů.
Je rychlejší a má větší dosah než Arris.
Četl jsem na internetu, že jiní lidé měli problémy s modemem/routerem Arris připojeným k Comcast.
Pokud máte Comcast internet, nedoporučuji tento modem/router Arris.
Vezmi si Netgear, je mnohem spolehlivější.
Ale je to dost otravné.
Na pozitivní stránce
Jeden z ventilátorů zněl mimo rovnováhu.
Ovládání rychlosti je opravdu zmatené - pokud je nastavíte na 100%, ventilátory se vypnou, takže je třeba to otočit na 100% a pak to pomalu stáhnout, dokud se to znovu nezapne.
Kvalita konstrukce je průměrná, ale zdá se, že je to standardní pro většinu těchto typů výrobků v tomto cenovém bodě.
Nohy, které drží notebook nahoru, když je nakloněný, se párkrát odtrhly...
Vrátí se, ale je to dost otravné.
Na druhou stranu má to ideální umístění ventilátorů pro notebooky, které přijímá vzduch z otvorů umístěných v blízkosti horní části notebooku.
Mnoho dalších chladičů má větráky směrem do středu a poskytují velmi malý přídavný tok vzduchu do notebooku s takovou konfigurací chlazení.
Případ s vážnými omezeními
Tento případ je v pořádku, ale ne výjimečný - 3,5 nebo 4 max.
Problém je, že je méně případů dostupných pro tabulku A 10.1 w S.
Gumdrop je nejlepší, ale má vážné problémy.
Pouzdro z gumy (silikon, cokoliv) je velmi hladké a levké, a nedává vám spoustu sebedůvěry, když držíte Tab jednou rukou.
Tab A je těžký, takže když si lehnete a sledujete video, ta pouzdro vám uklouzne do ruky, takže musíte často upravovat.
Musel jsem odstranit čirý plastový štít, který zakrývá obrazovku, protože to narušilo ovládání dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže teď je gumový vnější kryt opravdu pružný a křehký.
A nakonec, ztěžovali cestu do S Pen.
S Pen je v pravém dolním rohu tabulky A a oni udělali malou gumovou klapku, která chrání roh, aby se otáčila dozadu pro přístup k S Pen.
To znamená, že aby bylo možné vyndat S pero, musí se klapka otočit o 180 stupňů.
Tohle je opravdu trapné a těžké udělat jednou rukou.
Tento pouzdro dobře chrání můj Tab A, ale s těmito vážnými konstrukčními vadami ho nemohu doporučit, pokud nemáte S Pen, pak nemáte moc na výběr.
Všechno, co jsem potřeboval.
Tento produkt je opravdu chytrý - jedním zastávkou pro všechny mé potřeby připojení.
Miluju, když si tohle a malý napájecí adaptér mého notebooku strčím do tašky a jsem připraven pracovat na velkém 4K displeji nebo pořídit fotky z foťáku.
Jediná divná věc, kterou jsem zažil (a já jsem zažil to na všech 4 USB-C huby jsem zkoušel z různých značek) je, že macs zřejmě nemůže říct rozdíl mezi násobky stejného monitoru (tak můj Mac výstupy stejné video na všechny identické monitory připojené k rozbočovači, ať už HDMI a / nebo VGA).
Ale pokud použiji 2 oddělené rozbočovače / adaptéry nebo 2 různé modely monitoru pak Mac správně výstupy na displeje jednotlivě.
Dobře, potřebují se vylepšit.
Je to slušný tréninkový nástroj, ale opravdu potřebuje mít nějaký druh bezpečnostního zámku nad tlačítkem na šoku (bylo stisknuto více náhodou, když je v kapse, než jsem měl v úmyslu použít) moje psy se dokonce náhodou zapnuly, když šláply na ovladač.
A jestli se váš pes rád valí v mývalích hovnech jako já, tak je to taková osina v zadku, když to uklízíte.
Jak se stolice dostává mezi trhliny přístroje, musíte celou věc rozebrat, aby se řádně vyčistila a vyhnula se zápachu.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že skoro potřebujete přímou dohled, aby to fungovalo.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem byla jen 30 stop od svého psa.
Je to určitě pěkná vlastnost a nabíjení vydrží nějakou dobu.
Já potřebuju nabíjet jen jednou za dva týdny.
Dostaneš, za co jsi zaplatil.
Hrozný produkt, zkreslený.
Koupil jsem si ho jako sledovač, abych ho používal při plavání, a ani jsem ho neměl možnost vyzkoušet.
Za prvé, není vodotěsná a nedoporučuje se ji používat při plavání podle návodu.
Za druhé, s ním není nabíječka.
Místo toho navrhuje použít USB nebo počítač.
Dobře, máme jich spoustu.
Když se ho snažím dostat do portu, aby se nabíjel, vypouští se hned zpátky.
Nevím, jestli je něco neslučitelné, nebo je to jen špatně vyrobené, ale nebudu sedět a držet zařízení, zatímco se nabíjí.
A konečně, aplikace stále vyskytuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílala zprávu, což je velmi znepokojující.
Pak jsem zavřel všechny aktivní aplikace na svém telefonu a viděl jsem další reklamu, když jsem šel zkontrolovat čas o 20 minut později.
Hrozný produkt, asi jsem dostal, za co jsem zaplatil...
Skvělá batoh, ale přehnaná popruhy.
Tento batoh vypadá dobře a funguje dobře.
Je to hodně, zvláště když to porovnáte s tím, co teď kostí batoh.
Způsob, proč jsem odkopl hvězdu je, že je tam příliš mnoho popruhů.
Na té tašce je víc popruhů, než můžu spočítat.
Nakonec ty přebytečné popruhy uříznu a spálím, protože většina z nich není opravdu nutná a jen brání otevírání a zavírání tašky.
Kromě toho jsem si udělala tuhle novou školní tašku na vysokou.
Na zádech batohu je oddíl pro můj MacBook Pro a všechny mé knihy se vejdou do kapes, které jsou k dispozici.
Vlajka je také skvělý závěr.
Můj pes ho ještě nezničil.
Měl jsem problémy s hokejovými míčky.
Můj pes je miluje - je to její oblíbená hračka na přinášet a žvýkat - a plavou.
Dokud je nerozkrájí na kousky.
Zkusil jsem několik, dokonce i ty "horké" verze - a vydržely o pár minut déle než ty ostatní.
Dokud se neobjevily tyhle.
Tyto se vydařily zkoušce.
Můj pes není velký, ale je tvrdohlavý, co se týče toho, co žvýká.
Jak se říká, není to o tom, jak velký je pes v boji, ale jak velký je boj v psovi.
Palce nahoru od Daisy a mě.
Tento přípravek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Zkontrolovali jsme baterii po několika týdnech používání a viděli jsme, že voda se dostala do oddělení, kam baterie jdou.
Baterie se zhroutily a z nich vycházela černá kapalina.
Při pohledu na design, zdá se, že není možné, aby byl obal baterie vodotěsný, což znamená, že nejenže voda vnikla do oddělení během koupání, ale také se z něj vytratila některá toxická látka.
Prosím, nekupujte tento přípravek.
Jsem šokován, že se jí dovolilo jít na trh navzdory tak zjevné chybě.
problémy s přehřátím a těžký čas připojení ovladač
Dávám mu 3 hvězdičky, nechci nechat špatnou recenzi pro prodávajícího, pokud si to nezaslouží, ale tenhle dron se hodně přehřívá.
Nejsem si jistá, jestli bych měla kontaktovat prodávajícího nebo DJ Tello, ale asi bych měla zkusit obojí, abych viděla, co řeknou.
Líbí se mi, že drony jsou malé, cool hračky, které létají lépe než některé větší, starší drony a některé z mých větších dronů se cítí jako hračky víc než tenhle.
Nicméně je to jediný dron, se kterým jsem měl problémy s přehřátím a ve skutečnosti to bere zábavu z létání. Teď předpokládám, že je to výrobní problém, který musí řešit co nejdříve, pokud chtějí, aby byl jejich produkt úspěšný.
Doufám, že mi prodávající neposlal použitý dron, protože jsem zaplatil za nový.
Dám prodejcům rekvizity na doručení, jakmile dorazí den po koupi.
Až budu kontaktovat prodávajícího a DJ Tello, aktualizuji datum své recenze.
O téhle tašce mám jen dobré věci na říct.
O téhle dárkové tašce mám jen dobré věci na říct.
Dokázal jsem zabalit všechny své vánoční dárky do sáčků, obalů a papírových obalů.
Výrobek je vynikající kvality a různé možnosti velikosti usnadňují výběr perfektní jeden pro každý dárek!
Velmi doporučuji.
Prodávající je naprosto milý a pozorný.
Po mém nákupu se mnou spojil, aby se ujistil, že jsem spokojená s mým produktem.
Pět hvězdiček všude kolem!
Fyziky jsou hrozné a lidé, kteří tu hru vytvořili, s tím nic neudělají.
Nechte si tuhle hru, fyzika je hrozná a já jsem na ni tak naštvaná, protože na každou hru je asi 40 hackerů.
Víte, oni prostě nechávají hackery dělat, co chtějí a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra stále dělá aktualizace o jejich postavách opravdu to, co by měli aktualizovat je fyzika, protože je to hrozná, nekupujte si tuto hru fyzika je hrozná a mechanika je hrozná lidé, kteří zjevně lidé, kteří tuto hru postavili, byli na vysoké nebo něco, protože je to jedna z nejhorších her, které jsem kdy hrál v životě upřímně bych raději hrál Pixel Games v této sračce, je to jedna z nejhorších her nekupujte
Ne jako ostatní hry Tomb Raider
Od samého začátku to nevypadalo jako ostatní hry Tomb Raider.
Hra je brutální, protože ovládací prvky nejsou chytré v poznávání, kterým směrem se snažíte jít.
Nechal tě padnout k smrti tím nejvíce nadbytečným způsobem.
Hádanky jsou těžké, ale ne v logickém smyslu.
- Ta hra mi moc nepřipadá.
Neplánuju to dokončit.
Příběh je taky slabý, což je hlavní důvod, proč hraju hry.
Ergonomické a cenově dostupné, ale ne příliš odolné vůči neustálému používání
Má tenčí tvar, který se lépe vejde do rukou, není tam žádné ostré rohy, na které by se dalo chytit a s napájecím káblem jako trvalým připojením je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který je vyvolán v akčních hrách, je mnohem slabší.
2) Směrný joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Máme velmi těžký rukou a mají tendenci nosit 2-3 kontroléry za rok.
Takže pro nás, každoroční investice do ovladačů znamená, že musíme být vybíraví a opatrní, co kupujeme.
Ovladač by mohl použít odolnější pružky; po několika měsících přestávají reagovat tlačítka, která se nejvíce používají a pravý joystick ztrácí své soustředění, IE- přibližuje obrazovky map a postavy jdou vpřed, aniž by se dotýkaly ovládacích prvků.
Dostaneš, za co jsi zaplatil.
Byl jsem zklamaný, když jsem tento předmět obdržel, protože stříbrná část, která obklopuje obličej, se zdá být vyrobena z nějakého levného plastu.
Nedevnívalo mě, že je vyrobená z plastu, ale spíše to, že z plastů vypadá neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled.
Také jsem nevěřil, že to vydrží každodenní nošení, tak jsem to nakonec vrátil.
Byl jsem zklamaný, protože to vypadalo, že by to byla dobrá dohoda, kdyby nebylo toho.
Ale pokud to přehlédneš, pak by to mohlo být pro tebe.
Bylo to dobře zabalené a přišlo to rychle.
Nic jako předchozí telefony Stylo, MASIVNÍ ZKLADENÍ.
Měl jsem originální Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Jasně, že se mi Stylos líbil, když uvážuji, že pokaždé, když vyšel nový, koupil jsem si ho.
Nikdy proto, že by někdo měl problémy nebo se rozpadl, jen proto, že jsem chtěl zůstat v aktuálním stavu a "v kruhu" a udělal jsem to.
Ze všech těch telefonů, ani jednou jsem neměl problémy s samotnými telefony.
Když jsem si koupil Stylo 3 přes Virgin Mobile, věděl jsem, že všechno půjde hladce, jakmile si telefon koupím a nastavím, ale mýlil jsem se.
Tenhle telefon měl tolik problémů, že mě to upřímně šokovalo, jak byly předchozí Stylos tak skvělé.
Nikdy jsem nebyl schopen úspěšně přenést tento telefon na můj účet Virgin Mobile.
S tímhle telefonem jsem se poflakoval necelý týden.
Hledal jsem informace na internetu a telefonoval jsem různým lidem, zoufale jsem se snažil dát Stylo 3 výhodu pochybností, doufal jsem, že jsem to jen já, kdo dělá něco špatně, ale bohužel jsem ztratil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem nechtěl přiznat.
Nesnáším fakt, že musím dát Stylo takové hrozné hodnocení a recenzi, ale byl jsem extrémně zklamaný z tohoto telefonu.
Doufejme, že LG zlepší svou hru a může zlepšit budoucí stylosy, pokud nějaké budou, ale tohle byl obrovský BUST.
Na druhou stranu, návrat a moje náhrada proběhly hladce, ale to je asi všechno.
