Heknutá verze videohry Jedi Knight padala, protože vyvolávala funkci z konce objektu vtable.
Ukázalo se, že předpokládané volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má ve srovnání s IDirect3DViewport na konci další metody, a to jsem právě implementoval.
Pro mě je to zcela velký předpoklad, protože se vytváří výřez pomocí jen objektu Direct3D místo Direct3D3.
Nyní chápu, že v praxi je objekt IDirectXObject2 obvykle správnou nadmnožinou objektu IDirectXObject, bez změněných signatur funkcí, přičemž nové metody jsou přidány pouze na konec.
Ale to tak vždy neplatí; v těchto případech záleží na tom, jaké rozhraní používáte ke tvorbě daného objektu.
Každopádně, protože to platí i zde, abych to dal do pořádku, musel jsem rozšířit svou implementaci výřezu tak, aby byla zahrnuta i metoda IDirect3DViewport3 a volání bylo platné.
Při argumentaci předpokládejme, že se věda alespoň zčásti skládá ze seznamů objektivně faktických tvrzení o světě, pravdivých nezávisle na jakékoli teorii, kterou by mohli podporovat.
I když je pravda, že taková fakta ve vědě existují, pořád lze tvrdit, že vědecká fakta jsou nabitá teorií.
Vědecká fakta vycházejí z experimentů.
Experimenty nevytvářejí fakta o tomto záznamu, ale výběr experimentů, které lze provést, ovládá to, která fakta jsou objevena.
Některá fakta, například o subatomárních částicích, mohou být výsledkem jen experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, organizace a nátlaku, než aby to šlo jinak.
Toto je velmi stručná skica věrohodného argumentu o tom, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi, které prosazují existenci objektivních vědeckých faktů.
To *není* argumentem ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Tento víkend si jej vyzvednu.
Hledal jsem dobré první auto pro chlapa; a opravdu miluji estetiku 80. let.
Už kvůli výraznému chladiči a snížené světlé výšce.
Udělal jsem si malý průzkum, ale byl bych rád, kdyby měl někdo nějaké informace o takovém autě.
Osobní zkušenosti?
Vím, že to nejde rychle srovnávat
#Průchod do času Fediverse.
Dnes večer jsme šli s Domácím partnerem do obchodu s likéry pro pár piv a láhev bublaniny.
Když jsme se šli odhlásit, pokladní je zcela zjevná #trans žena.
Já v kraťasech, žena v bělavých barvách a Domácí partner, všichni otrhaní a s novým sestřihem, o kterém on sám napsal, že „vypadám jako neonacista“.
Její tělo okamžitě ztuhlo a v očích měla výraz strachu.
A pak jsme jen... zaplatili za naše věci.
A řekli, děkuji.
A já jsem řekl, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale to, že se nejdřív bála, JE OPRAVDU HNUS A NESNÁŠÍM TO.
Toto je ta nejhloupější časová osa a nesnáším to, tečka, com.
Nic nebrání Donaldu Trumpovi kandidovat na prezidenta, když bude obviněn po odsouzení nebo dokonce z vězeňské cely.
Pokud by byl zvolen, bez pochyby by se omilostnil, aby se dostal z vězení.
Ale ze státního vězení se nemůže omilostnit.
K tomu je potřeba guvernér státu.
Dva zúčastněné státy jsou New York a Georgia.
Poslední guvernér Kemp nepochybně omilostní Trumpa, pokud bude odsouzen nebo dokonce obžalován DA Fannie Willisovou z okresu Fulton.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze redukovat na vysílání signálů s významem nezávislým na kontextu.
Na základě varianty klasického Lewisova (1969) signalizačního modelu zkoumáme v této práci podmínky pro vznik komunikace závislé na kontextu v situovaném scénáři.
Hlavně ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Současně také studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové zpřehlednění významů symbolů.
Ukazujeme, že omezení prostředí na referenční volbu příjemce může být jednostranně zneužito odesílatelem, aniž by došlo ke zpřehlednění na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je u odesílatele vyžadováno povědomí o kontextu.
Navrhujeme, aby kontextově závislá komunikace byla situovaným vícevrstvým fenoménem, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model, který byl vyvinut v této práci, je ukázkou toho, jak mohou být signály mimo kontext nejednoznačné, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si o víkendu užil setkání s Penny a Nicholasem z Ashanti Development, abychom si popovídali o jejich pokroku.
Ashanti Development spolupracuje se stále rostoucí komunitou v regionu Ashanti v Ghaně již po dobu 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a farmaření.
Komunity získávají znalosti, které mohou začlenit a podpořit jejich vlastní rozvoj.
Měl jsem štěstí, že v roce 2011 jsem strávil po boku Nicholase nezapomenutelných šest měsíců při podpoře řady projektů.
Když jsme to o víkendu dohnali, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
Tisíce stromů bylo zasazeno a farmáři zaznamenali zvýšení výnosů plodin prostřednictvím řady intervencí od podpory nákupu vybavení až po školení.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu i škůdci, jako je červotoč, který může zlikvidovat úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS blízko mě mi neumožní napsat štítek nebo napsat na krabici.
Nutností je štítek vytisknout.
Nedovolí mi, abych jim řekl adresu, kam to jde a kdo to posílá.
Musím poslat e-mailem nějakou náhodnou adresu s daty bez formátu, aby si úředník mohl přečíst e-mail, zadat jej do svého systému a vytisknout štítek.
A pokaždé mi za tu „výhodu“ naúčtují 2,25 $.
Druhý den ráno se nemohu dostat přes hanebné předstírání veřejnoprávní žurnalistiky Chrise Lichta včera v noci na CNN.
Byla to potupa, jako symbolický 6. leden antidemokratického svátku lží a křivd, který byl pořádán sebedestruktivně americkými médii.
HANEBNÍ DIVÁCI.
Licht SOUHLASIL s celým republikánským publikem!
Kdo ty jednotlivce prověřoval a vybíral?
Je třeba nahlásit příběh.
Hodnocení – hledání klamné nezodpovědnosti všeho.
Nejde to zopakovat.
Ve sklepě mám docela průvan, a to v podstatě znamená, že se tam může uchýlit hodně hlodavců.
Minulý měsíc se objevilo více známek hlodavců, a to nás výjimečně překvapilo, protože je jaro a myslel jsem si, že se změnou počasí vyrazí ven.
Měl jsem však rozmístěných pár obyčejných starých pastí a každých pár dní jsem do nich poctivě doplňoval arašídové máslo, protože ho myši s radostí olizovaly.
Minulé noci jsem se konečně toho nabažil, vyčistil všechny pasti od arašídového másla a nalepil na ně pistácie.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř všechny „humánní“ pasti, které byly na trhu, s velmi malým úspěchem.
Nijak moc mě netěší jejich zabíjení, ale etiku zabíjení myší nebudu raději komentovat.)
Z konzervativních stran a vlád, které se schovávají za značky pro byznys, jsem unavený.
Alespoň v Albertě nejsou.
Jasně, že snížili daně z podnikání.
Ale také omezují granty a daňové úlevy podporují větší obchodní aktivitu.
Mám firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Zjistil jsem tím nejhorším způsobem, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, překryvná okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělat peníze, ale všechen ten marast se zdá kontraproduktivní, pokud odhání lidi pryč.
To platí i teď, když je goatse.cx pryč, i když mezi goatse a, řekněme, khou.com, kde jsem se snažil podívat na video, které mi poslala Wendy, by to byl těsný závod na dno.
V prvním dnešním vlaku se průvodčí podíval na naše jízdenky a řekl „dlouhá cesta!“
„Jo a dnes se vrátím,“ řekl jsem.
Pokusil jsem se vysvětlit, že ho vysazuji v Glasgow, a gestikuloval jsem na svého cestujícího.
„Nebývá tu moc často slyšet, že někoho někdo vysazuje v Glasgow,“ řekl průvodčí.
Takovou věc jsem nikdy předtím neřekl.
Věc, o které jsem byl včera večer přesvědčen, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který ve skutečnosti nikdo nechce, kromě fanatiků, kteří jsou v něm.
A jsou to opravdu blázni.
Nemůžeme jim dovolit, aby nám unesli naši zemi.
Je čas se postavit na odpor.
Teď jděte ven a běžte protestovat.
Pořiďte si samolepky na nárazníky, které jsou zaměřené proti Trumpovi, a celé je polepte.
Křičte zpět na ty, kteří se mohou pokusit o nás mluvit.
To není normální.
Tohle není OK...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak z druhé strany ulice má covidový kašel a vykašlává hleny.
Tak jsem spěchal, abych se dostal do svého bytu a abych se mu vyhnul, ale přesto mě dokázal dohnat a popovídat si.
Přísahám, že lidé nakažení covidem jsou zombie, kteří se snaží nakazit všechny ostatní.
Není společensky přijatelné vycházet na veřejnost nebo spěchat k lidem, když se dávíte vykašláváním hlenů.
Opakuji. Není společensky přijatelné šířit svou covidovou nákazu všude!!!
Writing Wonders 5/11: Směje se váš MC víc, nebo víc pláče?
Abe skrývá své smutky a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví drsný humor.
Jan ti ublíží dříve, než ti ukáže, že je zraněná, a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4 000 nouzi se Yl ocitne v místě lásky a má neskutečný pocit, že neví, co dělat, takže je tu spousta obojího.
#CNN se prostě musí zavřít.
Včerejší fiasko s #MangoMoron bylo skandálním fiaskem.
Kdo byl v té ubohé, umírající síti zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který „jednatel“ kabelových zpráv zavolal, aby dal tomu tučnému, ležícímu zločinci tolik vysílacího času?
Počátkem příštího týdne bude panovat tlaková výše.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno IR satelitní a pozemní pozorování naznačovala rozšiřující se nerovnoměrnou oblast nízké vrstvy <URL>
Podivínský student Arnie Cunningham se zamiluje do Christine, rezavé Plymouth Fury z roku 1958, a začne být posedlý obnovením původní slávy klasického automobilu.
Jak se mění auto, mění se i Arnie, jehož nově nabyté sebevědomí se za volantem jeho exotické krásky mění v aroganci.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše konzultanty Salesforce ještě dnes!
Najděte si spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu investic do CRM.
Zjistěte, jak vám partner Salesforce pomůže s implementací, přizpůsobením, integrací a průběžnou podporou, aby vaše firma mohla v ekosystému Salesforce prosperovat.
Jedna z nejbláznivějších částí z toho všeho, jak se moji sousedé obrátili proti mně, je přemýšlení o tom, kolik úsilí stojí nepřátelství.
Zapomeň na mě, dobře.
Ignorujte mě, dobře.
Bolí to, ale musíš to udělat.
V tomto bodě se však otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře před obličejem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A stále NETUŠÍM, co jsem mohl udělat, abych si to zasloužil.
Klíče od mého bytu měli přes 6 let.
Ta loď není povolena.
Jsem si vědom vaší nenávisti k Organě.
Není pro mě vůbec důležitá.
Můžete ji zabít, pokud můžete.
Ale na palubě té lodi často lítá jiný jedinec.
Ten kdyby měl zemřít... následky by měly... významný dopad.
Hodně mě trápí dadifikace.
Zde je kratičký rychlokurz o tom, co mám na mysli pod pojmem dadifikace:
Není to můj pojem, je to pojem používaný při popisu, když je vyprávění nebo herní mechanika postavena kolem hlavního protagonisty (obvykle staršího, obvykle mužského), který řídí nebo hlídá jinou osobu (často mladší).
The Last of Us je snadným a kanonickým příkladem dadifikace.
Joel využívá své dovednosti a schopnosti k provedení (extrémních) násilných činů, aby splnil úkol, kterým je označen jako „pečující“.
Dadifikace obvykle předpokládá, že řešením situace, kdy se rodič musí starat nebo chránit dítě nebo kdy zastupuje dítě, je ohromná síla k vynucení velmi specificky tvarované dynamiky síly.
Dadifikace narušuje možnost společných řešení a často úplně ignoruje nebo podkopává jakoukoli činnost dítěte.
Tímto způsobem dadifikace zastupuje mnoho neoliberálních ideálů; zejména myšlenky jako bootstrapping a soběstačnost jako konečný cíl či ukazatel úspěchu.
Zde je rychlý přehled toho, jak využívat naše webové stránky.
- Zasíláme upozornění, když se letenky začnou prodávat.
- Poskytujeme odkazy, kde si můžete rezervovat letenky.
- Neprodáváme letenky ani neúčtujeme předplatné.
- Další podrobnosti jsou v celém příspěvku na blogu.
- Udržujeme seznam vzorových dat rezervací pro každou zveřejněnou nabídku a tento seznam několikrát denně aktualizujeme.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto v nich nepředstavitelný strach, teror a vysídlení zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby prodiskutovala, jak může podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví zranitelným dětem.
Už jsme nabídli duševní zdraví a psychosociální podporu.
Veškerá naše úsilí jim pomůže projít touto cestou.
Kopa nových nablýskaných dobrot v #šipky
Postupem času se šipky staly mým cílem pro rychlé uživatelské rozhraní.
#flutter je radost pracovat a pro snadnou správu obchodu mají #mobx.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, že Flutter je opravdu na nic, pokud jde o chování jako dobrá nativní aplikace (skutečně všude, dokonce i cíl webu Flutter je na nic).
Umožňuje ale rychlý pohyb, a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými hroty.
Mají průměrnou výšku, průměrnou stavbu těla a jsou svalnatí.
Jejich ocas je extrémně hustý.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Být schopen skákat opravdu vysoko, roztrhat obyčejné lidi na kousky, používat strašidelné kouzelné síly a doplňovat zdraví hodováním na svých nepřátelích – to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze, aby vypadali špatně – všichni...
Snil jsem, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mojí mámě líbila logická hra, kterou jsem vytvořil před lety, a většinu tajemství našla sama, proto nebyla jen mámou, když řekla, že se jí to líbí.
Takže možná se jí může líbit také moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny či hokkienu, z nichž ani jeden vůbec neznám.
Myslím, že se budu muset podívat, jestli je Bing nebo Google lepší v překladu špinavých gay sexuálních hříček.
Chvíli jsem si s touto myšlenkou pohrával:
Duševní zdraví bývá často vnímáno jako něco odděleného od „normálního“ zdraví.
Proč?
Protože se to děje v mysli a zdá se to méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli a vašeho mozku stejně tak otázkou zdraví jako zdraví vašich nohou.
Intersex je dokonce uznáván TERFem a podobně, protože je obecně více fyzický a jako takový i viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně „skutečné“ než fyzické zdraví, mám takový pocit, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více mi tvrzení „Mé pohlaví je mužské, mé gender je ženský“ připadá zjednodušené a nepřesné.
Skoro to vypadá jako postoupení části argumentu TERFům.
Mám pocit, že být trans znamená být „biologicky nebinární“.
Moje pohlaví je nebinární, můj gender je ženský.
Myslím, že označení „nebinární“ je třeba rozšířit z pouhého výrazu gender, aby mohlo být použito, když se mluví o pohlaví.
Poslouchal jsem, zapínal a vypínal, díla @iotar
V backlogu tohoto tajemného kolektivu je spousta dobrých věcí.
Jako krauty nálady a další světská populární hudba a radiofonická dílna a všechno další možné.
Stojí to opravdu za to se na to podívat.
Také FWIW rozhraní archive.org se mi líbí mnohem více než desktop #bandcamp \- Vůbec nevím, jak lidé používají jako svou primární hudební platformu bc (kromě politických důvodů).
Trochu si pohrávám s aplikací Flutter.
Upřímně bych nerad zakládal své podnikání na technologiích od Googlu, na druhou stranu je Google jedním z mála velkých hráčů, kteří mají skutečné pobídky vytvářet nepřekonatelné zážitky z různých platforem a je to vidět.
(A také: Web je bohužel nyní z velké části záležitostí Googlu)
Také mi prosím neříkejte, že aplikace google/flutter na iOS a macOS převládají.
Být univerzální na všech platformách je těžké, pokud to chcete dělat dobře.
Vím to.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Několik velmi malých obtíží vyšlo najevo.
Nic, co by spustilo zvonění na poplach, ale i tak jsou adresovány.
Příští týden bude vydána malá aktualizace, která je opraví.
Většinu včerejška strávili někteří zákazníci instalací nové aktualizace a každý, kdo tuto pomoc potřebuje, ji už měl obdržet.
Hezký den!
Technické přiznání: Nemohu se věnovat jen systémům Grafana a Prometheus, alespoň z hlediska serverových/aplikačních metrik a monitorování.
Nevím přesně, proč na to můj mozek nemůže přijít; může to být tím, že jsou nástroje tak široké a vágní, že se můj mozek jen zablokuje kvůli „příliš mnoha možnostem“.
Chci dělat řídicí panely.
Grafana vypadá pěkně.
Mozek bez práce.
Takže s blížící se novou vrstvou #FFXIV jsem dlouho přemýšlel: „Člověče, chtěl bych zkusit pořádnou jízdu, ale Party Finder zní jako zmatek a nikdy nenajdu statiku, která by mě chytla.“
Tak jsem si řekl, vyser se na to!
Udělám si vlastní statiku!
Plno lidí, kteří jsou příliš netrpěliví na to, aby se pokusili připojit k jízdě, bez očekávání, že budou vůbec dobří!
Neexistuje... žádný způsob, kterým by to fungovalo, asi!
...A tak jsem zjistil, že musím sestavit seznam nájezdových skupin.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a ztratil jsem veškerou svou vášeň pro fikci a skvělé vyprávění příběhů.
Ale po ~desetiletích~ čtení téměř o ničem (s výjimkou funkčních pracovních textů, naučné literatury a občasné svépomocné knihy) jsem si stanovil cíl, že v roce 2023 přečtu 23 knih.
Teď jsem v knize č. 31 a je teprve květen.
Jsem ZPĚT zlato!
Opravdu jsem ničeho nedosáhl.
Jsem rád, že za mnou soukromě přišlo pár lidí a řekli: „Podívejte, za všechnu vaši práci vám dám tuto částku peněz.“
Chci vidět tyto společnosti zprostředkující transakce, jak vysvětlují svým zákazníkům způsob nastavení svých procent.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobrou čtvrtinu, budou.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté se zbraněmi, prodiktátorské pravicové křídlo... je tady nebezpečí.
Deportujte bílé rasisty.
Jsem tak unavený z titulků, které tvrdí, že „práce na dálku je mrtvá“. nebo že „práce na dálku byl neúspěšným experimentem.“
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele jedné velké společnosti.
Všechno je to návnada na klikání, ale znepokojuje mě to kvůli vedení a manažerů, kteří tyto články čtou.
Před rokem 2020 existovala práce na dálku.
Stále existují práce, které lze v dohledné budoucnosti vykonávat na dálku.
Práci na dálku je možná.
Umožňuje lidem pracovat v pohodlných prostorách a ne v přeplněných a hlučných kancelářích.
Umožňuje dostupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které ubírá čas z jejich dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a snažte se porozumět, jak vaši zaměstnanci skutečně vykonávají práci.
#WFH #podnikání #neurodiverzita
Nejsou to jen konzervativci versus progresivisté, řekl na semináři více než 100 přívrženců v Grande Prairie.
„Toto je válka mezi pro-lidmi a anti-lidmi,“ řekl.
Parker odkazoval na potraty a impuls moderních městských žen odkládat mít děti kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
„Vy jste uhlík, který se snaží redukovat.“
Tak jako od začátku u všech mých narozenin v minulosti jsem to měl vždy drsné.
Kdykoli se objevil květen, bál jsem se pokusit oslavit své narozeniny.
Vždy se něco může stát, pokazit nebo skončit stresujícím a depresivním způsobem.
Celé roky jsem bojoval, abych se od takového myšlení oprostil a měl lepší narozeniny.
Trvalo mně to roky, kdy jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si narozeniny bez starostí.
A dnešek se také stává skvělým dnem!
Zima bude v této malé části Velkého jižního světa za 30 dní.
Ale já se nedám oklamat!
Toto je začátek.
Déšť padá, a dokud nezamrzne, nebudete v něm tančit!
Je dobrý den na objednání zmrzliny.
Byla to jedna psí noc a ten pes nevstával z postele ani na „psí snídani – snídani pro psa!“
Podšívku si zapnu do cyklistické bundy – jen pro případ, že bych ji uvnitř potřeboval.
Znáte účinný způsob, jak webová komponenta může reagovat na přidání či odebrání z dokumentu?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Je to většinou sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectedCallback).
V současné době používáme hack MutationObserver.
Kvůli výkonu nesledujeme celý dokument.
Vytvoříme odděleného dočasného rodiče, nainstalujeme tam MO a pozorujeme, jak se odpojuje (tedy připojuje jinde).
#krysa Casper je v dnešní době absolutní jednotkou.
Myslím, že moje nová práce byla pro něj dobrá – dvě volné procházky denně, když pracuji, v celkem předvídatelných časech.
Konečně mám pořádnou fotku, abych si mohla být jistá, že není tlustý.
(U #krys může příliš vysoký tělesný tuk škodit jejich zdraví.)
On není.
Je prostě úplně vytržený z toho, že mě dvakrát denně něco trhal v kanceláři.
Nemám váhu, abych ho mohla zvážit, ale má pocit, že má hodně přes libru.
Dělá mi takovou radost, když vidím, jak se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1) Mírné úpravy rozložení mapy Hel's Fighters.
Nabídka mapy je navíc plně funkční!
2) Systém měnových odměn byl připojen.
Zítra to bude testováno v různých bitvách.
Deštivé dny!
Minulý týden jsem toho udělal hodně a ohledně věcí v terénu se cítím mnohem lépe.
Přesazují se všechny brukve, kapusty, řepy.
Plánuje zasadit salát v Pennu v šestiřadém vzoru a zjistit, jak se mu bude dařit s porovnávanými vysílanými sazenicemi.
V Gilpinu se objevuje jarní hrášek, proto je potřeba nastavit mřížovinu.
Také je potřeba zasít řádek salátu, aby jej bylo možné začlenit do nakrájené zeleniny, v obou případech mají vyškolený personál na zavlažování, přípravu záhonu a přesazování, což je 90 % dovedností mimo sklizeň.
Píše se rok 2023 a stále vidím, že se lidé s iPhony aktivně vyhýbají používání Apple Maps.
Apple Maps jsou standardně dodávány s iOS, a přesto se lidé stále snaží stáhnout a nainstalovat Mapy Google do svých iPhonů.
Netuším proč.
Byl jsem zvědavý, a měl jsem otevřenou mysl, abych mohl srovnat Mapy Google a Apple Maps ve svém testovacím zařízení iPhone (mým denním chlebem je zařízení Android, takže iPhone používám jen zřídka).
Zkušenost s následováním pokynů byla na Apple Maps mnohem lepší než na Mapách Google.
Apple Maps vítězí.
Proč tedy lidé při instalaci Map Google přeskakují další překážky?
Vůbec nevím.
Mohlo by to být tím, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa pro Apple Maps v roce 2012?
Mohlo by to být tím, že je vyhledávání Google integrováno s Mapami Google?
Vůbec nevím.
To znamená, že jsem předpojatý.
Jsem předpojatý, aby se koncovým uživatelům nevypouštěly zmetky a Apple to s jejich Apple Maps královsky nezvládl, když vyšly v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z ní dělá dobré úložiště bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože se zhoršuje jeho stav a je třeba jej vyměnit.
Spousta lidí si myslí, že doslova vlastní zemi, když si koupí její kus.
Není tomu tak.
V Číně si můžete půdu pouze pronajmout.
Nejsou tak hloupí, aby ji prodali navždy.
Vláda může tuto politiku kdykoli změnit.
Pozemek je dočasný.
Zdá se to nepředstavitelné, že vám může být jednoho dne odebrána půda, když sledujete australské a americké mediální kanály, ale je to proto, že bohatí jsou tam celý den a starají se o to, aby váš mozek přemýšlel určitým způsobem.
Jednou je půda je velmi snadno a rychle odebrána vládou, pokud to chtějí udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si ppl může udržet půdu na úkor ostatních.
Jednou musí být odebrána.
Proto Číňané povolují pouze pronájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem tamním investorům připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci a vytvořme světlejší budoucnost pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm #geolog #podnikání #udržitelnost #úspěch #přátelství #přípitek #sny
Často žasnu nad lidskou schopností *tak moc* se kritizovat, když jsme zaplavení tolika důkazy o tom, jak vypadá opravdová krutost.
Trápit se osobním selháním a pocitem viny ve světě, kde se „úspěchu“ tak často dostává lidem zodpovědným za ty nejodpudivější činy...
Všichni jsme taková nemorální verbež.
Avšak zmírnit zoufalství nad naší nemorálností je zásadní – protože nám dává více prostoru vypořádat se se zkázou všude kolem.
Tak se na to snažte nezapomínat, jo?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: „Na rychlosti psaní nezáleží!“
nebo „Modální editory jsou dneska k ničemu“ :morty:
Já, jak extrahuju funkčnost svých projektů #Axum do sdílených knihoven: „Podržte mi klávesnici“ :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, zda je to nejlepší přístup pro sdílení, ale zatím se mi líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné využití.
Jak byste sdíleli osobní knihovny?
Výzva na tento týden ke Zjevení zní: Zůstaňte vzhůru celou noc.
Pohrávám si s tímhle kouskem v hlavě už několik dnů.
Je to rozhodně víc romantiky než špíny.
Asi jsem četla až moc romantických povídek s nemožnými zápletkami o „setkání s roztomilými kluky“ a tohle je výsledek, ale mám je ráda.
Rozhodně se jednoho dne taky chystám na orgasmus v Mílovém klubu, ale asi ne s ciz
Nesouhlasím s tím, že síť #Mastodon je obtížné nastavit.
Je to prosté, opravdu to není tak těžké.
Je však obtížnější najít lidi, které můžete sledovat, a vytvořit si svou časovou osu.
Přál bych si, aby existovalo nějaké doporučení „koho sledovat“.
Kromě toho to však není obtížné – pokud použijete aplikaci třetí strany, jako jsou Elk a/nebo Ivory.
Pokud zůstanete u výchozího webového rozhraní, nevypadá to a nepůsobí to dobře (dle mého skromného názoru).
Takže to vyžaduje trochu víc úsilí, abyste se do toho dostali, a pravděpodobně budete potřebovat dobrou aplikaci pro lepší #UX.
Nevím, zda je možná prevence, ale stojí za to to zkusit.
O čtyřech krocích, které uvádím, se dá diskutovat, přičemž v každém z nich lze dosáhnout určitého pokroku:
Popis: názvy incidentů při chování člověka a algoritmu, které zohledňují algoritmy a lidi.
Vysvětlení: zohlednění obou stran se vzájemným vlivem
Předvídání: očekávání škod dříve, než nastanou (i kdyby jen o několik minut)
Intervence: znalost věcí, které můžeme udělat, abychom dosáhli změny, v určitých mezích sebejistoty
Na CNN town hall jsem se nedíval, ale vypadá to, jako by Trump říkal přesně to samé, co říká pokaždé, když otevře pusu nebo zmáčkne tlačítko Odeslat na svém telefonu.
I kdyby je ve vysílání town hall neřekl, všichni v Americe je stejně uslyší, a to opakovaně, od nynějška až do listopadu 2024.
To pořád není důvod, proč mu dát další prostor, ale ta škodlivost se přehání.
Vyhraje primárky.
Nezmizne jen proto, že si to budeme přát.
Je tady a bude ty věci říkat, ať se děje, co se děje.
Zapsal jsem se na čekací listinu „Zkušební kuchyně vybavená AI“ společnosti Google a ještě ten den jsem se dostal dovnitř.
Zatím je to dost zklamání.
„Demoverze MusicLM“ je jen trochu zajímavá.
Můžete požádat o konkrétní hudební skladbu, například „jazz se sólem na trubku v 5/4 taktu“, a po několika sekundách vám vygeneruje dvě skladby.
Zdá se, že rozumí taktu, ale... ta hudba prostě... není dobrá.
Hodit v reakci na GPT všechno, co máte, přes palubu není to pravé.
Snaž se víc, Google.
Je divný vzpírat, ale zároveň nemít ani páru o tom, jaký je vaše jedno opakovací maximum, pač to je jedna z hlavních metod, kterou lidi sledují svůj pokrok.
Cvičím sám v ložnici bez spottera a dokonce i bez stojanu na závaží.
Jen já a činka s hromadou závaží.
Vzpírám na posteli.
Kdybych se snažil zjistit jedno své opakovací maximum, nemusel bych mít dost závaží, abych ho dosáhl, nebo by mě to naopak mohlo vážně zranit / zabít.
Každopádně si dneska naložím víc.
Pořád je to v pohodě.
Přísahal bych, že burrata před pěti lety neexistovala
Což je můj osobní Mandelův efekt.
Nikdy jsem ji v žádné kuchařce neviděl.
Nikdy jsem ji neviděl v lepším obchodě s potravinami ani v žádném z italských lahůdkářství.
Nikdy jsem neviděl, že by ji dělala něčí máma, ani že by mi ji někdo cpal na večírku, ani že by se objevovala v souvislosti s něčími husarskými kousky při dělání omáčky nebo pečení
Jednoho dne se prostě objevila a najednou byla všude k dostání.
Vstoupil jsem do dimenze burraty.
drakeovi dosluhuje stárnoucí iPad, a tak mu vyrazila na trh pro nový tablet.
Jak jsme se tu zradikalizovali, zdráháme se koupit novou mašinu od FAANG*.
Má někdo oblíbený tablet s Linuxem?
Sloužil by hlavně k prohlížení webu, občasnému posílání e-mailů a nějakým těm hrám.
V časopisu Gamefan č. 06 roč. 1998 se Jason Schrieber v souvislosti s dlouhým vývojem první hry na enginu Unreal vyjádřil:
„Dobrá hra se opozdí jen do chvíle, než vám přijde.
Špatná hra bude špatná navždy.“
Byli to tedy Epic, kdo to vymyslel?
Mohli bychom pokračovat.
V dřívějším vydání časopisu GamePro č. 11 roč. 1997 je citace mnohem nejednoznačnější:
„Nebo, jak se říká v oboru: Opožděná hra je opožděná jen do chvíle, než vám přijde.
Špatná hra bude špatná po zbytek vašeho života.“
Je tedy tak pomíjivá?
Pouze „slogan“ bez jasného původce?
Smoky, můj desetiměsíční kocour modré kočky domácí, si hraje s červenou gumovou násadkou na Apple Pencil koupenou na Amazonu, kterou si ukořistil před několika měsíci.
Nosí ji hrdě v puse po celém domě a já se musím v duchu smát.
Pokaždé, když ho při tom vidím.
Nyní jste absolvovali celou okružní jízdu novým vlakem ICNG.
Opravdu se mi líbí.
Zejména vozy s většími okny.
Jsou oblasti, které by se daly vylepšit.
Jmenovitě se jedná o nedostatek košů a chybějící cedule vysvětlující význam barev osvětlení.
Opravte tyto drobné problémy a pak bychom jich mohli vzít víc.
Nebudu smutný, když dočkám konce akcií ICM nebo DDZ.
Pravidlo jedné na zákazníka zůstávají zachována, protože se snažíme zajistit, aby se na každého, kdo stojí ve frontě, deska dostala.
Můžete si koupit JEDNU z výše uvedených desek, ne jednu od každé.
Na počítače Pico ani jiné zboží se nevztahují žádná omezení nákupu.
Včera jsem prožil nejlepší chvíle se svým přítelem a bývalým kolegou rabínem.
Několik hodin jsme strávili návštěvou na mé verandě.
Takové přátelství překonává rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Pán vám žehnej a ochraňuj vás!
A močál se zazelená.
Docela se mi líbí software akkoma a název domény, který jsem dostal pro svou instanci.
Ale mám tak nějak pocit, že jsem tuto instanci začal takříkajíc vykročením špatnou nohou.
A nikdy jsem se tam necítil pohodlně.
Ještě chvíli se tu zdržím a popřemýšlím, zda bych měl vůbec migrovat.
#FalconGameBooks
Zdá se, že tě osmiocí repnidi sledují, jak s kluzákem přistáváš na červené půdě, ale ani se k tobě nepohnou, vlastně se nehýbou, když vystupuješ z kluzáku a pomalu k nim kráčíš.
Země se ti pod nohama začne chvět a pak otřásat jako při zemětřesení a ty ztratíš půdu pod nohama, ačkoli se zdá, že repnidy to nezasáhlo.
Skála pod tebou náhle povolí.
Repnidi se prohrabali pod povrch a ty spadneš do vroucí masy stovek těl repnidů v jeskyni pod tebou.
Konec je rychlý, několik párů kusadel do tebe vstříkne smrtící jed a vzduch Dyskry ti zamoří plíce.
Nikdo se nikdy nedozví, že jsi byl prvním lidským cestovatelem do budoucnosti.
Přistaneš s kluzákem přídí nahoru na bok struskové haldy a vylezeš ven.
Zdá se, že tě osmiocí repnidi sledují, ale ani se k tobě nepohnou, vlastně se nehýbou, když k nim pomalu kráčíš.
Zastavíš se ještě na hroudě zvětralé skály a hlíny a promluvíš k nim: „Přicházím v míru, jako přítel.“
Zdá se, že tě neslyší, natož aby ti rozuměli, protože tvůj univerzální překladač nezachytí žádnou odpověď.
Rozhodneš se použít své psychické vědomí, aby ses s nimi spojil mentálně.
Je těžké pochopit smysl jejich myšlenek, které jsou děsivě cizí, a tvá mysl se při kontaktu s nimi vzpouzí.
Rozhodneš se, že navázat kontakt znovu by bylo nebezpečné, a vrátíš se ke kluzáku, ale tato zkušenost ti pročistí mysl, která byla zmatená od chvíle, kdy jsi skočil do budoucnosti.
Jakmile se vrátíš do Sokolího křídla, celkem snadno určíš kurz k Zemi v roce 3034 našeho letopočtu.
Všimneš si, že jsi při skoku spotřeboval další polybdenovou tyč.
(pokrač.)
#dneska mám kávu, sluníčko a klídek!
Začala jsem nový šál.
V tuto chvíli si jím nejsem jistá.
Našla jsem nerovnoměrně předenou stříbrošedou přízi, která je většinou jemně předená se žmolky.
Plánuju ji smíchat s jemně fialovou / šeříkově zpestřenou bavlnou.
Ale nejsem si jistá, jestli mám dost té fialové.
Používám háček H na podobný vzor z krátkého sloupku, jako jsem uháčkovala už dřív.
První spoj jsem udělala včera večer, tak uvidíme.
Přeju všem šťastný čtvrtek!
Nesnáším však hodiny výtvarné výchovy a literatury a moje dosavadní vzdělávání to potvrzuje.
Doslova jsem vyzkoušel KAŽDOU Z NICH a od VŠECH jsem upustil.
Ještě před dvěma lety jsem o tom neměl ani tušení, dokud jsem se nepodíval do svých zápisů.
Nenávist k hodinám literatury je ještě horší: rád čtu.
Většinu klasiků jsem přečetl předtím, než mi bylo osmnáct – i když to je spíš odrazem toho, že jsem žil v úplném zapadákově, ze zoufalství jsem přečetl i Encyklopedii Brittaniku z roku 1979.
Můj domov je pohodlný a úžasný a jsem tam šťastný, ale musím být někde jinde, abych se mohl přes den uklidnit a číst beletrii bez výčitek svědomí.
Je to, jako bych byl na dovolené, a proto dělám to, co se dělá o dovolené.
A to i přesto, že jsem se tu poslední dvě noci nevyspal tak dobře jako doma a trochu mě dostává únavový syndrom už jen z toho, že jsem v cizím prostředí, kde se hůř orientuju a musím si pamatovat, kde jsou jaké věci.
A to i přesto, že mám stále svůj seznam úkolů a také si organizuju život.
Humanity vychází za 5 dnů.
Je vzrušující, nervy drásající, stresující a vůbec všechno, co mám na práci ve hrách rád.
Co si o ní budou lidé myslet?
Mně se líbí, ale dokáže přilákat publikum těch správných hráčů?
Vyroste kolem obsahu tvořeného uživateli komunita?
(Opravdu v to doufám.)
Příběh hry, myšlenky a otázky, které hra vyvolává, působí aktuálně.
Doufám, že vše půjde dobře.
Je den ThinkPadu!!
Přišel jsem domů o pauze na oběd a viděl jsem to posazené venku uwu.
Kéž bych si to mohl vzít s sebou do práce a víc si s tím pohrát.
Ale to bude muset počkat do večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to příliš roztomilé, až to působilo sentimentálně?
Určitě
Mluví vůbec některá z těch postav jako člověk?
Ani vzdáleně
Ale líbilo se mi to?
Rozhodně!
co tu dělala Olivia Colemanová?
Dlužila někomu peníze?
Musel jsem dnes večer dost zkritizovat čerstvého absolventa umění.
Částečně proto, že ho špatně učili.
Ale je důležité nevymlouvat se na problémy a prostě je vyřešit, zejména ve výrobě, když vedení potřebuje změny.
Zejména s ohledem na konkurenci.
Každý umělec si tím prošel, dopustil se stejných chyb.
Dobrá kritika slouží k rychlé nápravě problému a není zaměřena na vaše schopnosti.
Předpokládá, že jste schopni problém vyřešit nebo najít řešení.
Takže i když sledování videí o kompostování a prohlížení obrázků květin je úžasnou připomínkou, abychom vzhlédli a uvědomili si život mimo obrazovku,
Je stejně tak důležité prozkoumávat servery a IP adresy.
Sledujte, jak dobří lidičkové zasévají a opečovávají (a ne náhodně rozhazují) semínka.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale je pro silný a houževnatý růst v budoucnu.
Jami mu vzkaz podstrčila, když se míjeli na cestě těsně před psí hlídkou.
Ona byla na cestě ke zdi, on šel ze služby.
Kouknul se za sebe, aby ji viděl odcházet a ujistil se, že je nikdo neviděl.
Neohlédla se.
Počkal, až se ocitne v temnotě noclehárny, než vzkaz vytáhl a přečetl si ho v paprsku světla, který pronikal zatemňovacími závěsy.
Jedno slovo tiskacím písmem.
Dlouho na ně hleděl a snažil se zůstat klidný:
V poslední době jsem na síti #Mastodon potkala několik úžasných nových kámošů a chci tento trend udržet.
Při volání do #Fediverse se cítím jako velryba zpívající do širého oceánu!
Chcete se přidat na můj „pod“?
Zejména bych se ráda spojila s více lidmi.
Všichni, kterým se ježí vlasy na hlavě kvůli CNN, mohou za ten tvrdý pravicový obrat poděkovat Stephenu Colbertovi.
Pomohl udělat z Chrise Lichta národní problém.
Jakkoli se nám někteří lidé mohou líbit, pokud jen zajišťují druhořadou kariéru fašistům, asi by s tím měli přestat.
Bylo to poprvé (ale ne naposledy), kdy Kaveesha Dilhari zaskórovala více než 20 bodů a získala více než 2 branky v jednom utkání T20I.
Připojila se tak k úzké skupině srílanských žen, kterým se podařilo dosáhnout takového výkonu ve všem v tomto formátu.
Policie po násilném protestu před hotelem pro uprchlíky ve Velké Británii zatkla 15 lidí
K incidentu došlo po nárůstu počtu uprchlíků a žadatelů o azyl, kteří se na člunech plaví přes Kanál do Spojeného království.
Policie zadržela 15 lidí poté, co se demonstrace proti uprchlíkům před hotelem, v němž jsou ubytováni žadatelé o azyl, nedaleko anglického Liverpoolu zvrhla v násilnosti.
Policejní oddělení hrabství Merseyside uvedlo, že při výtržnostech v pátek večer v distriktu Knowsley utrpěli lehká zranění strážník a dva civilisté.
Policie uvedla, že někteří protestující házeli předměty a zapálili policejní dodávku.
Zadržené osoby ve věku od 13 do 54 let byly zadrženy „po násilných výtržnostech“.
Policejní komisařka hrabství Merseyside Emily Spurrell řekla stanici Radio City: „Bylo to neuvěřitelně nebezpečné a došlo k několika zraněním strážníků.“
Podle místních médií využívá ministerstvo vnitra hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje distrikt Knowsley v britském parlamentu, řekl, že násilnosti z páteční noci neodrážejí náladu v komunitě.
„Lidé z Knowsley nejsou fanatici a jsou vstřícní k lidem, kteří utíkají z jedněch z nejnebezpečnějších míst na světě a hledají bezpečné místo,“ uvedl.
„Ti, kdo dnes večer na tomto protestu demonstrují proti uprchlíkům, tuto komunitu nereprezentují.“
Protest se konal v době zvýšeného napětí, kdy se přes Kanál vydává stále více uprchlíků a migrantů na malých člunech.
V roce 2022 se touto cestou dostalo do Spojeného království více než 45 000 lidí, a většina z nich požádala o azyl.
Systém vyřizování žádostí o azyl se kvůli politickým zmatkům a byrokratickým průtahům velmi zpomalil, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Překračování Kanálu se stalo politickým problémem, protože konzervativní vláda slíbila „zastavit lodě“ a prosazuje plán poslat takovéto žadatele o azyl do Rwandy.
Opozice obvinila vládu z démonizace zoufalých lidí, kteří utíkají před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers v úvodním zápase sezóny na stadionu Brandywell
Záložník Derry Adam Reilly sejmul Leeho Grace na stadionu Brandywell
Derry City zvítězili v Prezidentském poháru, když porazili Shamrock Rovers 2 : 0.
Držitelé poháru FAI porazili vítěze ligy z minulé sezóny na stadionu Brandywell díky gólům Willa Patchinga a Michaela Duffyho z prvního poločasu.
Ve druhém poločase Hoops hráli proti přesile, ale svěřenci Ruaidhriho Higginse odolali a zahřívací zápas vyhráli.
Příští pátek se Derry vydají na hřiště St. Patrick’s Athletic na úvodní zápas ligy.
Patchingův boční volej posunul Derry po 23 minutách do vedení – záložník otevřel skóre, když Foylesider’s v únoru loňského roku zvítězili 2 : 1 nad konečnými šampiony.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy brzy posunul ještě více do vedení, když se mu podařilo dlouhou střelu dostat pod brankářem Leonem Pohlsem až do sítě.
Loňští vicemistři měli o poločase dva góly k dobru.
Nejblíže se ke snížení rozdílu dostal ve druhém poločase Graham Burke, ale Candystripes nakonec pohodlně vyhráli týden před hlavním zápasem o národní slávu.
Šéf City Ruaidhri Higgins pochválil svůj tým po tom, co podle jeho slov bylo „nejtěžším týdnem v jeho životě“ vzhledem k úmrtí jeho bratra Kevina.
„Je to kopanec do brady a čekají nás těžké týdny, ale budeme pokračovat na jeho počest,“ uvedl Higgins.
„Porazit Shamrock Rovers, a to zaslouženě, dobrým výkonem, je opravdu potěšující.“
Ministerstvo vnitřní bezpečnosti si najalo právní firmu, která se bude zabývat případným řízením o impeachmentu Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí advokátní kancelář Debevoise & Plimpton, aby mu pomohla v případném řízení o impeachmentu ministra Alejandra Mayorkase, který by mohl čelit obviněním vzneseným republikány ze Sněmovny reprezentantů v souvislosti s postupem při ochraně jižní hranice.
„Ministerstvo vnitřní bezpečnosti si najalo externího poradce, aby pomohlo zajistit, že životně důležité poslání ministerstva nebude přerušeno bezprecedentními, neopodstatněnými a stranickými snahami o impeachment ze strany některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl v pátečním prohlášení mluvčí Ministerstva vnitřní bezpečnosti.
„Ministerstvo vnitřní bezpečnosti bude i nadále prioritně chránit naši zemi před terorismem, reagovat na přírodní katastrofy a zabezpečovat naše hranice, přičemž bude náležitě reagovat na požadavky více než 70 výborů a podvýborů Kongresu, které na Ministerstvo vnitřní bezpečnosti dohlížejí.“
Úředník Ministerstva vnitřní bezpečnosti sdělil CBS News, že ministerstvo najalo firmu na smluvní práci po dobu trvání vyšetřování ze strany Kongresu.
Společnost Debevoise byla vybrána díky svým odborným znalostem v oblasti impeachmentu a zkušenostem se spoluprací s oběma stranami pod dohledem Kongresu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na Ministerstvu zahraničí ve Washingtonu, D. C., 13. října 2022.
OLIVIER DOULIERY / AFP prostřednictvím služby Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva se společností Debevoise je pro Ministerstvo vnitřní bezpečnosti přiměřeným výdajem.
Ministerstvo vnitřní bezpečnosti se snaží zajistit, aby jeho poslání nebylo podkopáváno stranickými útoky a aby řízení proti Mayorkasovi vedli lidé s odpovídající odborností.
Mayorkas se k tomuto vývoji nevyjádřil, ale minulý čtvrtek na otázku ohledně vyšetřování impeachmentu novinářům řekl: „Budeme s tímto Kongresem spolupracovat, stejně jako jsme spolupracovali s minulým Kongresem. Myslím, že je to naše odpovědnost.“
Připustil, že vyhovět vyšetřování ze strany Sněmovny reprezentantů „bude nějakou dobu trvat“.
„Budu tomu věnovat čas, stejně jako ostatní, ale také nebudeme slevovat z času, který věnujeme plnění našeho poslání.“
Jeden z vysokých úředníků Ministerstva vnitřní bezpečnosti potvrdil, že se Mayorkas se svým novým externím právním poradcem ještě nesetkal.
Pouze jeden člen vlády kdy čelil impeachmentu, a to ministr války William Belknap.
V roce 1876 byl Belknap, který působil ve vládě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale Senát ho nakonec zprostil viny.
Trendy zprávy
Děkujeme vám, že čtete CBS NEWS.
Čtyři náctileté obviněny z útoku na čtrnáctiletou dívku, která spáchala sebevraždu poté, co bylo na internetu zveřejněno video z jejího bití
Otec tvrdí, že si dcera vzala život poté, co byla šikanována ve škole v New Jersey
Otec tvrdí, že si dcera vzala život poté, co byla šikanována ve škole v New Jersey 02:33
Čtyři náctileté z New Jersey byly obviněny v souvislosti s útokem na čtrnáctiletou dívku, která si později vzala život poté, co bylo video z incidentu zveřejněno na sociálních sítích.
Jedna mladistvá je obviněna z útoku s přitěžujícími okolnostmi, dvě mladistvé jsou obviněny ze spiknutí za účelem spáchání útoku s přitěžujícími okolnostmi a jedna mladistvá je obviněna z obtěžování, uvedl v e-mailu pro CBS News státní zástupce okresu Ocean County Bradley D. Billhimer.
Čtrnáctiletá Adriana Kuch byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na střední škole Central Regional High School.
Na videu je vidět, jak dívky po náctileté házejí pití, pak ji kopou a tahají po školních chodbách.
Natlačily Adrianu na červené skříňky na školní chodbě a jedna z dívek v růžovém tričku Kuch opakovaně udeřila.
Další dívka se mimo záběr videa smála, když scénu nahrávala.
Do potyčky se vložili dva dospělí, jeden z nich od sebe náctileté odtrhl.
Adriana ležela zraněná a pokrytá modřinami na podlaze chodby, zatímco se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: „To ti patří.“
„Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali,“ řekl ve čtvrtek její otec Michael Kuch CBS New York a dodal, že je naštvaný a chce, aby všichni viděli video a to, co náctileté jeho dceři udělaly.
Čtrnáctiletá Adriana Kuch spáchala sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video, na kterém byla ve škole napadena. CBS2
Kuch uvedl, že se měla okamžitě zavolat policie, protože studentky, s nimiž měla jeho dcera podle jeho slov problémy, jí rozbili obličej půllitrovou lahví.
„Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejňovaly videa ze školy,“ řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
„Vždy se zabýváme každým případem šikany a v den incidentu byly čtyři studentky vyloučeny,“ řekl CBS New York Dr. Triantafillos Parlapanides, školní inspektor.
Vedení školy sdělilo CBS New York, že informovalo rodinu a označilo Adrianinu smrt za hroznou.
Každé mladistvé a jejímu zákonnému zástupci byla doručena kopie žaloby a mladistvé byly propuštěny až do budoucího stání před soudem, uvedl státní zástupce pro CBS News.
Studenti školy uspořádali ve středu stávku na podporu Adrianiny rodiny.
Pokud se vy nebo někdo, koho znáte, ocitnete v emocionální tísni nebo v sebevražedné krizi, můžete se obrátit na Linku pomoci pro sebevražedné a krizové situace 988, a to telefonicky nebo prostřednictvím SMS na číslo 988.
Zde můžete s Linkou pro sebevražedné a krizové situace 988 také chatovat.
Další informace o zdrojích péče o duševní zdraví a podpory získáte na lince pomoci Národní aliance pro duševní nemoci (NAMI), která je k dispozici od pondělí do pátku od 10:00 do 22:00
východního času na čísle 1-800-950-NAMI (6264) nebo na e-mailové adrese info@nami.org.
Mluvil jsem s 30 odborníky na zdraví a wellness o tom, jak se vyhnout vyhoření
V každodenním životě neustále hledáme způsoby, jak zvýšit svou energii a vyhnout se vyhoření, zejména v našem zaměstnání.
Pro pracovníky ve zdravotnictví to může být nesmírně obtížné, a proto jsem položil stejnou otázku 30 odborníkům v oblasti zdraví a wellness: „Jak hospodařit se svou energií a ve své profesi nevyhořet?“
Rozsah jejich povolání sahá od lékařů specializujících se na infekční choroby přes psychology až po učitele mindfulness – a všichni měli skvělé rady, jak si udržet motivaci a pokračovat v tempu aktivity.
Navzdory velkým rozdílům v jejich rolích se v odpovědích objevilo několik témat, která vynikla jako způsoby prevence vyhoření.
Zde jsou čtyři nejčastější přístupy, které používají.
1. Vybudujte silnou komunitu
Eufrosina Young, která pracuje s nevyléčitelně nemocnými pacienty, si dokáže udržet energii díky svému silnému systému podpory.
Young je certifikovanou neuroložkou a specialistkou na ALS na neurologickém oddělení nemocnice Upstate University Hospital a říká, že zde „mobilizují jako armáda lidí“.
Lék na amyotrofickou laterální sklerózu (ALS) zatím neexistuje, ale vědomí, že není jediná, kdo se snaží ze všech sil vyvíjet léčbu a poskytovat svým pacientům lepší možnosti, pomáhá Young pokračovat i v těch nejtěžších dnech.
„Neneseme tíhu světa, ale jsme součástí světa lidí, kteří se o tuto práci zasazují,“ říká.
2. Odpočívejte, když potřebujete
Práce ve dvou zaměstnáních jako výzkumník spánku a návrhář algoritmů, a to vše při péči o nově narozené dítě, by podle slov Raphaela Vallata určitě vedlo k vyhoření, kdyby neodpočíval.
„Když se cítím být na pokraji vyhoření, připadá mi v podstatě každý úkol jako hora, kterou musíte zdolat, a připadá mi každý úkol velmi naléhavý a důležitý,“ říká Vallat.
V těchto chvílích „si opravdu musíte vzít trochu volna a uvědomit si, že tyto úkoly mohou počkat“.
Vallat si obvykle během dne najde chvíle, kdy si může dát přestávku a strávit čas v přírodě, aby se ukotvil, než se vrátí k práci.
3. Buďte zapálení pro to, co děláte, a nezapomeňte na své poslání
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounder 100 hodin týdně sedm dní v týdnu.
Práce v první linii během pandemie jí zabrala téměř všechen čas, ale vyhoření se vyhýbala tím, že si připomínala, proč je její práce důležitá.
„Nemyslím si, že vám práce připadá jako práce, když máte pocit, že něco ovlivňujete,“ říká Gounder.
„Když pracujete na šílené směny a děláte něco, co pro vás nemá žádný smysl, myslím, že byste opravdu měli udělat krok vzad a zamyslet se nad tím, co vlastně děláte.“
4. Mějte jiné radosti
Každý z odborníků uvedl, že se věnuje nějakému koníčku, například cvičení, tanci nebo dokonce hře na kytaru.
Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho dosahujete v zaměstnání, říká Christina Maslach, sociální psycholožka, emeritní profesorka psychologie na Kalifornské univerzitě v Berkeley a autorka knihy „The Burnout Challenge: Managing People’s Relationships with Their Jobs“.
„Podívejte se na svůj život jako na celek, ujistěte se, že v něm jsou dobré věci, a udělejte si na ně určitě čas.“
Získejte zdarma Průvodce investováním Warrena Buffetta od CNBC, který v přehledné a jednoduché příručce shrnuje nejlepší rady miliardáře č. 1 pro pravidelné investory, doporučení, co dělat a co nedělat, a tři klíčové zásady investování.
Zaregistrujte se nyní: S naším týdenním newsletterem získáte chytřejší přístup ke svým penězům a kariéře
Mladistvý obviněn z vraždy v prosincové střelbě na chicagské škole, při níž zemřeli dva lidé
Policie v pátek oznámila, že v souvislosti s prosincovou smrtící střelbou na dva studenty chicagské střední školy byl obviněn z vraždy šestnáctiletý chlapec.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou pokusů o vraždu, oznámil vrchní inspektor chicagské policie David Brown.
„V současné době nemáme jasný motiv, proč by šestnáctiletý mladík chtěl střílet a zabíjet jiné děti,“ řekl Brown.
Jméno podezřelého nebylo v pátek kvůli jeho věku zveřejněno, Brown však uvedl, že obvinění z vraždy a pokusu o vraždu bude čelit jako dospělý.
16. prosince byli na střední škole Benito Juarez High School zastřeleni čtyři mladiství.
Oběma oběťmi, které zemřely, byli chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Podle vyšetřovatelů je k podezřelému, který byl ve čtvrtek zatčen, dovedly tipy od veřejnosti.
„Jsme vděční těm, kteří byli natolik odvážní a poskytli nám informace, aby zajistili, že pachatel bude dopaden a nyní se ze svých činů bude zodpovídat,“ uvedla státní návladní okresu Cook County Kim Foxx.
Brown uvedl, že podezřelý by se měl v sobotu dostavit k soudnímu jednání o vazbě, kde budou předloženy další podrobnosti o shromážděných důkazech.
Minnesotští biologové zachránili chyceného medvěda baribala
Agentura pro přírodní zdroje státu Minnesota přispěchala na pomoc nešťastnému medvědovi, který uvízl v příkopu a medvěděl, jak se z něj dostat.
Podle příspěvku na facebookovém profilu agentury se medvěd schoval v propustku u silnice poblíž města Wannaska v Minnesotě.
Když však sníh začal tát, propustek se začal zaplavovat a medvěd uvízl v hlubokém sněhu a ledu, uvedla agentura.
Na místo rychle dorazili pracovníci agentury a pomohli medvěda vytáhnout.
Podle příspěvku na Facebooku agenturní biolog specializující se na medvědy Andrew Tri „medvěda prohlédl a konstatoval, že je zdravý, ale omámený – zřejmě proto, že byl probuzen ze svého zimního spánku“.
Agentura poté medvěda přemístila do státní rezervace, kde mohl pokračovat v hibernaci.
Věk ospalé šelmy byl odhadnut na 6 let a její hmotnost na 170 až 180 kg.
Agentura připomněla obyvatelům, že přemisťování medvědů je práce, kterou je nejlepší svěřit odborníkům.
Pokud se obáváte medvěda ve svém okolí, měli byste se obrátit na místní úřady – ne se pokoušet spícího obra přemístit nebo krmit.
V tomto případě se přihlížející nejprve snažili medvěda sami vyhrabat a nabízeli mu jídlo, včetně taštiček Pop-Tarts, salátu a krmiva pro kočky Fancy Feast.
Ale naštěstí pro vyhrabávající s dobrými úmysly, „protože medvědi nemají v zimě chuť k jídlu, je medvěd nepokousal“.
Podle Agentury pro přírodní zdroje žije v Minnesotě 12 000 až 15 000 medvědů baribalů, kteří se vyskytují především v severní třetině státu.
V zimě tyto šelmy hibernují až šest nebo sedm měsíců, během nichž nepřijímají potravu a žijí z uloženého tělesného tuku.
Fotografie: Egypt slavnostně otevřel hrobky Džehuteje a Hereje po restaurování
Ve čtvrtek byly po dokončení restaurátorských prací slavnostně otevřeny hrobky Džehuteje a Hereje.
Slavnostní otevření provedli generální tajemník Nejvyšší rady pro památky Egypta Mostafa Waziri, španělský velvyslanec v Egyptě Álvaro Iranzo a předsedkyně Španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že obě hrobky byly objeveny díky společné egyptsko-španělské archeologické misi Nejvyšší rady pro památky a CSIC, která pracuje od roku 2002.
Uvedl, že mise prováděla vykopávky a restaurátorské práce a publikovala výzkumy týkající se hrobek, které se nacházejí v oblasti Dra Abú el-Naga na západním břehu Luxoru.
Podařilo se jim odhalit mnoho hrobek, rakví, mumií a pohřební zahradu.
Významné hrobky z významné doby
Waziri vysvětlil, že tyto dvě hrobky patří prominentním lidem, kteří žili na počátku 18. dynastie Nové říše – jedné z nejvýznamnějších epoch starověkého Egypta.
Uvedl, že hrobky mají tvar písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Tvoří je vchod, sloupová síň vedoucí k pohřební šachtě a stěny s výraznými nápisy.
Waziri dodal, že Džehutej byl správcem státní pokladny a za vlády královny Hatšepsut dohlížel na práci řemeslníků a umělců.
Džehutej byl také zodpovědný za zaznamenání Hatšepsutiny cesty do země Punt a za poskytnutí elektra (směsi zlata a stříbra) na pokrytí špiček obelisků, které nechala umístit v chrámech v Karnaku.
Kromě toho měl na starosti proces přesouvání obelisků.
V místnosti, která předchází Džehutejově pohřební komoře, jsou vyryty nápisy se 43 kapitolami Knihy mrtvých, což je první případ, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než se začaly psát na plátno a papyrus.
Herej zastával funkci správce královských skladů posvátné královské manželky a matky Ahhotep.
Jared O’Mara nikdy neměl být kandidátem Labouristů, říká Rachel Reeves
Stínová kancléřka prohlásila, že zdiskreditovaný bývalý poslanec Jared O’Mara „neměl být nikdy vybrán na kandidátku Labouristů“ a zaslouží si čtyřletý trest vězení.
Rachel Reeves hovořila s deníkem Guardian ve volebním obvodu Bolton North East v pátek, několik hodin poté, co klíčové osobnosti místní strany rezignovaly na protest proti tomu, jak národní výkonný výbor Labouristů (NEC) řídí proces výběru poslanců pro příští parlamentní volby.
Celá výběrová komise ve volebním obvodu Bolton North East odstoupila poté, co jí nebylo umožněno vybrat užší výběr, což je v Labouristické straně Keira Starmera stále častější praxe: „A opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje londýnské kliky, nikoliv místních členů na severu.“
Dodali: „To je v rozporu s postojem, který je nezbytný ke znovuzískání rudé zdi, která je tak zoufale potřebná k vytvoření Labouristické vlády.“
Reeves řekla: „Nevím, jaké jsou okolnosti toho, co se stalo ve volebním obvodu Bolton, ale vím, že ti, kteří byli vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.“
Obzvlášť nešťastná byla skutečnost, že Leigh Drennan, předseda Labouristů na severozápadě a poradce poslankyně za volební obvod Warrington North Charlotte Nichols, která podporuje Jeremyho Corbyna, nebyl zařazen do širšího výběru, aby se pokusil získat zpět křeslo od Konzervativců, přestože získal nominace od čtyř velkých odborových svazů.
Reeves uvedla, že s výběrem kandidátů nemá nic společného, ale dodala: „Vím, že je opravdu důležité, abychom měli přísné postupy pro to, kdo může být zařazen do širšího a kdo do užšího výběru.“
O’Mara byl tento týden odsouzen na čtyři roky do vězení poté, co porota zjistila, že předkládal falešné žádosti o proplacení výdajů v celkové výši 52 000 liber ve snaze financovat svou závislost na kokainu a alkoholu.
Mnozí lidé naznačují, že nebyl labouristy řádně prolustrován, když byl vybrán do boje proti Nicku Cleggovi, bývalému vicepremiérovi za Liberální demokraty, ve volebním obvodu Sheffield Hallam v předčasných parlamentních volbách v roce 2017.
Na otázku, zda O’Marův debakl nadále straší v myslích členů Labouristické NEC, Reeves odpověděla: „V žádném případě nechci naznačovat, že každý, kdo není v užším výběru, je uživatelem kokainu.
Ale Jared O’Mara byl hrozný případ.
Nikdy neměl být vybrán na Labouristickou kandidátku, nikdy se neměl stát poslancem.
Využil veřejné peníze, takže je naprosto správné, že dostal trest.“
Okolnosti O’Marova případu byly „dost výjimečné“, řekla Reeves, ale připustila, že: „Pro Labouristickou stranu a všechny politické strany z toho plynou důležitá ponaučení ohledně výběru kandidátů.
Řekla bych ale také, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě střídáním premiérů, pokut a stran, přičemž standardy zdaleka nedosahovaly toho, co by se dalo očekávat.“
Dodala: „O Labouristické straně bych řekla, že když někdo udělá chybu, je mu pozastaveno členství v poslaneckém klubu. A to v případě Konzervativní strany prostě není.“
Archie Bland a Nimo Omer vás každé všední ráno zdarma seznámí s nejlepšími příběhy a jejich významem.
Oznámení o ochraně soukromí: Newslettery mohou obsahovat informace o charitativních organizacích, online reklamy a obsah financovaný externími stranami.
Další informace naleznete v našich Zásadách ochrany soukromí.
K ochraně naší webové stránky používáme službu Google reCaptcha a platí pro ni Zásady ochrany soukromí a Smluvní podmínky služby Google.
Reeves se ve volebním obvodu Bolton setkala s učni ve školicím středisku společnosti Openreach, která ve Spojeném království zajišťuje širokopásmovou síť.
Poté, co Reeves sledovala, jak učni šplhají po cvičných telegrafních sloupech na staveništi za 1,7 milionu liber, diskutovala o plánech Labouristů na revizi učňovské dávky, která nutí větší firmy odkládat 0,5 % z mezd na financování učňů.
Podniky si stěžují, že dávka je příliš neflexibilní. Například společnost Openreach, uvedla Reeves, „chce přeškolit lidi, kteří pracují na měděných rozvodech, na práci na optických vláknech, ale učňovská dávka není tak flexibilní, pokud jde o rekvalifikaci.“
Reeves uvedla, že Labouristé by dávku změnili tak, aby společnosti mohly peníze použít na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a aktuálně prováděné montáže plynových kotlů.
„Potřebujeme, aby se v rámci energetického přechodu na uhlíkovou neutralitu naučili pracovat s elektromobily nebo montovat tepelná čerpadla či vodíkové kotle.
Chceme, aby tito lidé byli rekvalifikováni a získali dovednosti, které potřebují k úspěchu.
A přesto se proti nim staví učňovská dávka.
Podniky chtějí větší flexibilitu a mladí lidé, kteří začínají svůj život, nebo starší lidé, kteří se chtějí rekvalifikovat, si chtějí zajistit, že jejich dovednosti budou relevantní pro budoucnost,“ řekla Reeves.
Jeden zatčený při protestu v galerii Tate Britain kvůli dětské akci s drag queen
Jedna osoba byla zatčena při protestu před galerií Tate Britain, kde se konala akce pro děti s vyprávěním příběhů drag queen.
Metropolitní policie uvedla, že jedna osoba byla před uměleckou galerií nedaleko Westminsteru zatčena pro podezření z rasistického komentáře vůči strážníkovi.
Podle policie nebyla hlášena žádná zranění a strážníci zůstávají na místě.
V sobotu se v galerii Tate konala Drag Queen Story Hour UK, kde příběhy vyprávěla Aida H Dee, kterou webová stránka galerie popisuje jako „první drag umělkyni v Evropě, která čte příběhy dětem ve školce“.
Před galerií demonstrovala skupina pravicových demonstrantů, proti nimž se postavili jejich odpůrci v čele s bojovníky za práva transgender osob a politickými skupinami, včetně iniciativy Stand Up to Racism.
Strážníci museli vytvořit koridor, aby se účastníci mohli dostat na místo konání.
Na Twitteru drag queen napsala, že tento den byl „řádně emotivní“, a dodala, že pět protestujících se dostalo do galerie Tate a „způsobilo rozruch“ v některých částech budovy, ale čtení neovlivnilo.
Pro Pink News již dříve uvedla, že pozvání do galerie Tate na akci v rámci měsíce historie LGBTQ+ jí bylo „ctí“.
Její čtení se již dříve stala terčem protestujících.
Drag queen uvedla, že předem proběhlo „posouzení rizik“, ale dodala, že je „absurdní“, že to vůbec bylo nutné.
Aida napsala na Twitteru: „Do galerie Tate se dostalo 5 haterů. Způsobili rozruch. ALE ne na Drag Story Hour UK ...Dělali rozruch jinde v budově, ne tam, kde se konala show!! SHOW 2 proběhla hladce!!!“
V sobotu v 11, v poledne a ve 14 hodin pořádala Aida tři sezení s vyprávěním příběhů.
Mluvčí galerie Tate uvedl: „Neuvádíme program umělců za účelem propagace určitých názorů, ani za účelem smíření odlišných názorů.“
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, kterými jeho aspekty se nechají zaujmout.“
Trumpova ceněná budova na 40 Wall Street je v hledáčku věřitelů v souvislosti s klesajícími příjmy: zpráva
Mrakodrap Donalda Trumpa na 40 Wall Street, který je silně zatížen hypotékou, je kvůli strmě klesajícím příjmům a rostoucím nákladům „v hledáčku věřitelů“, uvedla v pátek agentura Bloomberg.
Podle měsíční zprávy o zbytku hypotéky na budovu ve výši 126,5 milionu dolarů se míra neobsazenosti 72patrové budovy, která je Trumpovou nejcennější budovou, ve třetím čtvrtletí loňského roku vyšplhala na téměř 18 %, uvedla agentura Bloomberg.
Výdaje mezitím od vzniku hypotéky v roce 2015 údajně vzrostly o 11 %.
Trump se často chlubil budovou, kterou získal v roce 1995 a jejíž cena byla v roce 2015 stanovena na 540 milionů dolarů.
V den teroristických útoků z 11. září 2001, které zničily Světové obchodní centrum a zabily 3 000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street je najednou nejvyšší budovou ve městě.
Jeho tvrzení bylo nejen necitlivé, ale také lživé.
Nejvyšší budovou po zničení Dvojčat se stal další nedaleký mrakodrap na Pine Street na Lower Manhattanu.
Pronájmy výškových kancelářských budov na Manhattanu již několik let klesají, což se ještě zhoršilo po vypuknutí pandemie COVID-19, kdy mnoho společností ukončilo činnost a zaměstnanci přeživších firem pracovali na dálku.
Společnost Wells Fargo, která obsluhuje hypotéku na 40 Wall Street, „oslovila dlužníka, aby zjistila stav vývoje pronájmu“ a plány na zlepšení výkonnosti nemovitosti, uvedla podle zprávy agentura Bloomberg.
Majitel wagnerovců tvrdí, že válka na Ukrajině se protáhne na několik let
Majitel ruské soukromé vojenské společnosti Wagnerova skupina, která se aktivně účastní bojů na Ukrajině, předpovídá, že válka se může protáhnout na několik let.
Jevgenij Prigožin ve videorozhovoru vydaném v pátek pozdě večer uvedl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny, Donbasem.
Dodal, že válka může trvat tři roky, pokud se Moskva rozhodne obsadit širší území na východ od řeky Dněpru.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a pro své lukrativní kremelské cateringové zakázky byl přezdíván „Putinův šéfkuchař“, znamená uznání obtíží, s nimiž se Kreml potýká v kampani, kterou původně očekával úspěšně ukončit během několika týdnů, když ruská vojska 24. února vtrhla na Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících porážek, když ukrajinská armáda zahájila úspěšnou protiofenzívu a získala zpět rozsáhlá území na východě a jihu země.
Kreml se vyhnul prognózám, jak dlouho by boje mohly pokračovat, a uvedl, že takzvaná „speciální vojenská operace“ bude pokračovat, dokud nebudou splněny její cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří region Donbas, kde Moskvou podporovaní separatisté od roku 2014 bojují proti ukrajinským silám.
Prigožin uvedl, že žoldnéři Wagnerovy skupiny pokračují v tvrdých bojích o kontrolu ukrajinské pevnosti Bachmut v Doněcké oblasti.
Připustil, že ukrajinské jednotky kladou zuřivý odpor.
Zatímco ruská vojska pokračují v útocích na Donbas, Moskva se také snaží demoralizovat Ukrajince tím, že je v kruté zimě nechává bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další důležitou infrastrukturu.
Ve východních, západních a jižních regionech byla zasažena infrastruktura vysokého napětí, což vedlo k výpadkům proudu v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale zvládnutelná“, a dodala, že se zapojily záložní zdroje, které udržují dodávky elektřiny, ale upozornila, že v některých oblastech budou pokračovat příděly elektřiny.
Velitel ukrajinské armády, generál Valerij Zalužnyj, uvedl, že ruské síly od čtvrtečního večera do pátečního poledne odpálily 71 řízených střel, 35 raket S-300 a sedm dronů Šáhid. Dodal, že ukrajinská protivzdušná obrana sestřelila 61 řízených střel a pět dronů.
Ukrajinské úřady později v pátek informovaly o dalších útocích zabijáckých dronů.
Ukrajinské letectvo uvedlo, že večer armáda sestřelila 20 dronů Šáhid.
V pátek pozdě večer zveřejnili ruští vojenští bloggeři a některé ukrajinské zpravodajské servery video, na kterém je vidět útok námořního dronu na strategický železniční most v Oděské oblasti.
Na zrnitém videu je vidět rychle se pohybující objekt, který se blíží k mostu ve městě Zatoka asi 50 kilometrů jihozápadně od Oděsy a exploduje mocným výbuchem.
Pravost videa nebylo možné ověřit.
Ukrajinská armáda se k útoku nevyjádřila a mluvčí regionální správy Serhij Bratčuk v rámci sobotních televizních zmínek útok dronem nepotvrdil.
Most, který byl na počátku války terčem ruských raketových úderů, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro dodávky zbraní ze Západu.
Sledujte zpravodajství agentury AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli v Turecku 7 přeživších a těla 19 mrtvých: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM – Kazašští záchranáři pokračují v prohledávání trosek a hledání přeživších v Turecku, cituje agentura Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství trosek a nestabilní konstrukce.
Kazašský záchranný tým zatím v Turecku vytáhl sedm přeživších zemětřesení a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc je poskytována nepřetržitě.
Zejména v pondělí brzy ráno zasáhlo zemětřesení o síle 7,7 stupně Richterovy škály, které zdevastovalo části jihovýchodního Turecka a severní Sýrie.
Počet obětí mohutných zemětřesení na jihovýchodě Turecka k dnešnímu dni přesáhl 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM – V pátek se ve sportovním centru Qazaqstan v Astaně konalo slavnostní zahájení 10. halového mistrovství Asie v atletice.
Akce se zúčastnil kazašský premiér Alichan Smailov, cituje agentura Kazinform tiskovou službu kazašského premiéra.
Při zahájení akce přečetl šéf kazašské vlády uvítací dopis prezidenta Kasym-Žomarta Tokajeva.
„Sport nezná hranic.
Posiluje přátelství a sbližuje národy a země.
Zvláštní pozornost je v Kazachstánu věnována sportu.
V naší zemi existují všechny podmínky pro provozování profesionálního a masového sportu.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex pro více než šest tisíc lidí,“ stojí v dopise kazašského prezidenta.
Kazašští atleti úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro dorůstající generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání mistrovství Asie v Astaně bude novým impulsem pro rozvoj atletiky v zemi, a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní poděkování prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za pomoc při přípravě a konání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Na turnaji se setká více než 500 sportovců z 31 zemí, kteří se při této všestranné události utkají v běhu, štafetovém běhu, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí.
Turnaj potrvá do 12. února.
Již dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkirui získala zlato v běhu žen na 3000 metrů a Olga Safronovová vybojovala na turnaji stříbro v běhu žen na 60 metrů.
Foto: primeminister.kz
Herečka ze seriálu Yellowstone Q’orianka Kilcher se brání obvinění z podvodu
Advokátka Camille Vasquez, která zastupovala Johnnyho Deppa v loňském mediálně sledovaném soudním procesu pro pomluvu, si připsala další právní vítězství – tentokrát s herečkou ze seriálu „Yellowstone“ Q’oriankou Kilcher.
V pátek zprostil úřad okresního návladního v Los Angeles County 32letou Kilcher všech obvinění v případu podvodu s náhradou za pracovní úraz.
V prohlášení, které v pátek poskytl deníku The Times, mluvčí okresního návladního v Los Angeles County uvedl, že soud „rozhodl, že se slečna Kilcher nedopustila pojistného podvodu, a oznámil, že v projednávání nelze pokračovat“.
V červenci 2022 kalifornské úřady obvinily Kilcher ze dvou trestných činů podvodu s náhradou za pracovní úraz a obvinily ji, že v období od října 2019 do září 2021 nezákonně pobírala dávky v invaliditě ve výši více než 96 000 dolarů.
Do tohoto období spadá i několik měsíců, kdy Kilcher pracovala na seriálu „Yellowstone“, přestože tvrdila, že je příliš zraněná na to, aby mohla pracovat.
Kilcher se sama přihlásila a v květnu byla obžalována.
„Dnes jsem nadmíru vděčná, že můj případ byl zamítnut – zítra začíná moje cesta, která má pomoci zvýšit povědomí a požadovat větší transparentnost práv pracovníků v rámci systému náhrad,“ uvedla Kilcher v pátek v prohlášení, které sdílela s deníkem The Times.
Dodala, že „se těší, až bude moci tuto zkušenost více osvětlit a pokračovat v práci, kterou miluje.“
Kilcher také poděkovala Vasquez a jejímu kolegovi z advokátní kanceláře Brown Rudnick Stevu Cookovi za „neochvějnou víru v její nevinu“.
Podle organizace TMZ si je Kilcher najala v září.
Kilcher prorazila ve filmu Terrence Malicka „Nový svět“ z roku 2002, kde ztvárnila Pocahontas.
Na kontě má také seriály „Zákon gangu“, „Psychiatr“ a film „Dora a ztracené město“.
Naposledy se objevila v road movie „Pes“ s Channingem Tatumem v hlavní roli.
Na této zprávě se podílela Christina Martinez, pracovnice deníku Times.
Šéf značky Balenciaga označuje prázdninovou kampaň za „hloupou chybu“
Luxusní oděvní značka Balenciaga se stále vzpamatovává z vlny odporu proti dvěma svým nedávným reklamním kampaním.
Několik měsíců poté, co se módní dům dostal pod palbu kritiky kvůli propagačním snímkům, které podle kritiků sexualizovaly děti, se umělecký ředitel značky Balenciaga Demna (celým jménem Demna Gvasalia) v rozhovoru pro časopis Vogue, který byl zveřejněn v pátek, za tyto snímky omluvil.
„Chci se osobně omluvit za špatnou uměleckou volbu konceptu dárkové kampaně s dětmi a beru na sebe odpovědnost,“ řekl časopisu Vogue a zopakoval tak své předchozí prohlášení, které zveřejnil na sociálních sítích v prosinci.
V listopadu značka sdílela fotografie ke své kolekci „The Gift“, na kterých dětské modelky a dětští modelové pózovali s plyšovými medvídky oblečenými do bondage oblečků.
Krátce poté značka Balenciaga zveřejnila fotografie pro svou kampaň na jaro 2023, na kterých byla v pozadí stránka z případu Nejvyššího soudu z roku 2008 týkajícího se „virtuální dětské pornografie“.
Rodiče, včetně hvězdy televizní reality show a dlouholeté fanynky a partnerky značky Balenciaga Kim Kardashian, se na sociálních sítích vyjádřili proti značce a jejím „znepokojivým snímkům“.
O několik dní později vydala značka Balenciaga prohlášení, ve kterém se za fotografie omluvila a uvedla změny, které provede, aby se v budoucnu podobným „chybám“ vyhnula.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já sám i my pracujeme, jakým vytváříme a komunikujeme snímky, jak komunikujeme s naším publikem a jak se učíme z chyb a jdeme dál,“ řekl Demna časopisu Vogue.
Podrobně popsal změny, které se ve značce Balenciaga udály po aféře: „restrukturalizace oddělení image“, více interních a externích kontrol snímků pro kampaně a spolupráce s Národní dětskou aliancí, která pomáhá „tisícům dětí v procesu překonávání traumat a řešení jejich duševního zdraví“.
„Jediná věc, která mě na celé té hrozné situaci těší: možnost udělat z ní něco dobrého,“ řekl o partnerství, které bylo oznámeno ve středu.
S NCA spolupracuje také mateřská společnost značky Balenciaga, společnost Kering, která zastřešuje další luxusní značky, včetně značek Saint Laurent a Bottega Veneta.
Pod společnost Kering patří i značka Gucci, která v prosinci čelila vlně odporu proti kampani s Harrym Stylesem, v níž podle tvrzení některých kritiků na sociálních sítích sexualizovala i děti.
Denma v rozhovoru uvedl, že se hodlá odklonit od „provokativních“ zvyklostí značky.
„Je to součást mého učení: ke všemu, co vydám jako nápad nebo image, budu přistupovat dospěleji a vážněji,“ řekl.
„Rozhodl jsem se vrátit ke svým kořenům v módě i ke kořenům značky Balenciaga, což je vyrábět kvalitní oblečení – ne dělat image nebo rozruch.“
Když mluví o původu značky, na jiném místě rozhovoru Demna říká, že jednou z „nejbolestivějších“ částí vlny odporu bylo pošpinění „jména Balenciaga a odkazu Cristóbala Balenciagy“.
„Balenciaga je více než sto let starý rod, který je založen na silných a krásných tvůrčích hodnotách, a já jsem se snažil udělat vše, co bylo v mých tvůrčích silách, abych ho přivedl k jeho moderní aktuálnosti, a najednou jsme byli napadeni a označeni za něco, co vůbec nejsme,“ řekl Demna.
„Rozhodně jsme s dárkovou kampaní udělali velkou a hloupou chybu, ale určitě jsme se z ní poučili.“
Je to falešná zpráva, vyvrací CBN tvrzení, že nemá kapacitu tisknout další nové bankovky nairy
Nigerijská centrální banka (CBN) označila za zavádějící zprávu, která údajně cituje guvernéra CBN Godwina Emefieleho, který přičítá současný problém s distribucí nově navržených bankovek nairy nedostatku tiskových materiálů ve společnosti Nigerian Security Printing and Minting Company Plc.
V sobotním prohlášení mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN během své prezentace Národní státní radě na jejím zasedání v pátek 10. února 2023 v žádném případě neučinil takové prohlášení.
Nwasinobi uvedl, že Emefiele na schůzce pouze sdělil, že společnost NSPMC pracuje na tisku všech nominálních hodnot nairy, aby uspokojila potřeby Nigerijců v oblasti transakcí.
Uvedl, že CBN sice oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek nairy, ale „jsme znepokojeni tím, do jaké míry se zájmové skupiny snaží manipulovat s fakty a poštvat veřejnost proti bance“.
Nwasinobi uvedl, že CBN je i nadále odhodlána plnit své funkce v rámci měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění pozdějších předpisů).
„Rádi bychom také znovu zdůraznili, že společnost NSPMC má kapacitu a dostatek materiálu k výrobě požadované úřední objednávky nairy.
„Banka by proto ráda vyzvala veřejnost, aby zmíněné zprávy nebrala v úvahu a byla zdrženlivější, zatímco vytrvale pracujeme na zvýšení oběhu nových bankovek v zemi,“ dodal.
Ke konkrétnímu hlasu, který se objevil na sociálních sítích a který tvrdil, že CBN plánuje zavřít některé banky, zejména v určitém geopolitickém regionu země, CBN uvedla, že žádný takový plán neexistuje a že tato tvrzení jsou nelogická a neodpovídají fungování nigerijského bankovního systému.
„Veřejnosti proto doporučujeme, aby tyto nahrávky ignorovala, protože nepředstavují směřování zásad CBN a jsou pouze zoufalým pokusem osob, které chtějí proti bance poštvat veřejnost,“ uvedl.
Tim Sherwood se pustil do Pedra Porra, který za 44 milionů liber podepsal smlouvu s Tottenhamem a předvedl žalostný debutový výkon
Porro prožil proti Leicesteru odpoledne, na které by nejraději zapomněl (snímek: služba Getty)
Tim Sherwood se při porážce Tottenhamu od Leicester City (4 : 1) pustil do „naprosto nechutného“ bránění Pedra Porra.
Spurs podepsali pravého obránce ze Sporting CP v den uzávěrky přestupů na dohodnutou počáteční půjčku 5 milionů liber s povinností koupit ho v létě za 39 milionů liber.
Třiadvacetiletý hráč si odbyl svůj debut v sobotu pod vedením Antonia Conteho na stadionu King Power Stadium, kde se jeho tým ujal vedení po 14 minutách hry zásluhou Rodriga Bentancura.
Ale vše se změnilo v mizerné odpoledne, když to Nampalys Mendy, James Maddison a Kelechi Iheanacho v poločase nandali Leicesteru 3 : 1 a Porro musel vydržet útrpný první poločas v Premier League.
Španěl byl opět na vině, protože hráči Leicesteru si mysleli, že Barnes přidal čtvrtý gól, a ačkoli byl tento gól zneplatněn kvůli ofsajdu, byl bývalý manažer Spurs Sherwood zcela šokován obráncovou nulovou defenzivní snahou.
„Nechci se do toho kluka pořád navážet, ale musí být zbaven svého postu,“ řekl Sherwood v rozhovoru pro vysílání Soccer Saturday.
Přiznám mu výhodu pochybnosti, protože je to jeho debut, ale Pedro Porro je tak špatný, až je to neuvěřitelné.
Jeho zaujímání pozice na hřišti je naprosto nechutné, Barnes a Maddison mu úplně ničí levou stranu.
Daniel Levy tento týden řekl, že utratili spoustu peněz, to ano, ale jejich nábor byl velmi špatný a toto je poslední přírůstek.
V tuto chvíli nedělejme žádné závěry, ale dívám se na hráče, který nechce bránit.
Více: Premier League
„Antonio Conte si stěžoval na bránění a tento hráč má v současné době problémy s bráněním. Proti němu stojí velmi dobří hráči Barnes a Maddison, ale je to velké zklamání.“
Ačkoli gól byl zneplatněn, Leicester potvrdil své vedení 4 : 1 díky Barnesově gólu v deváté minutě před koncem zápasu.
Přestože Tottenham minulý týden porazil Manchester City, propásl šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala smlouvu s Joaem Felixem a místo toho si klofnula hvězdu Tottenhamu
VÍCE: Tottenham se chystá podat nabídku na Marca Guehiho z Crystal Palace, ale Chelsea má neoficiální možnost zpětného odkupu
Další podobné příběhy najdete na naší sportovní stránce.
Sledujte Metro Sport a jeho nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli boj o imunitu v souvislosti s předvoláním Mikea Pence k soudu
Zpráva, že zvláštní poradce Jack Smith předvolal Mikea Pence k soudu, vyvolává otázku: jak Trumpův tým využije soudy, aby tento nejnovější vývoj ve zkoumání Ministerstvem spravedlnosti zhatil?
Stručná odpověď zní, že jakýkoli pokus o zmaření Penceova předvolání k soudu na základě imunity výkonné moci by měl být neúspěšný.
Za prvé, je tu otázka, zda se bývalý prezident vůbec může takové imunity dovolávat.
Připomeňme, že Trump se 6. ledna neúspěšně pokusil zabránit výboru Sněmovny reprezentantů získat záznamy z Bílého domu.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, přičemž nesouhlas vyjádřil jediný soudce Clarence Thomas (manžel popíračky voleb v roce 2020 Ginni Thomas).
Soud však ponechal otevřenou otázku, zda se bývalý prezident může dovolávat imunity, přičemž soudce Brett Kavanaugh naznačil, že by takový nárok podpořil.
Je tedy přinejmenším nejasné, zda se bývalý prezident může dovolávat imunity, aniž by bylo řečeno, zda by takový nárok uspěl.
Odvolání k Nejvyššímu soudu ve věci pokusu tehdejšího prezidenta Richarda Nixona vyhnout se předvolání k soudu navíc ukazuje, že neurčité prosazování imunity nestačí a může být překonáno konkrétní potřebou důkazů.
Soud v případu Spojené státy v. Nixon z roku 1974 uvedl:
... pokud je důvod pro uplatnění imunity na materiály předvolaného, které mají být použity v trestním řízení, založen pouze na obecném zájmu na důvěrnosti, tento nemůže převážit nad základními požadavky na náležitý právní postup v rámci spravedlivého výkonu trestního soudnictví.
Obecné prosazování imunity musí ustoupit prokázané konkrétní potřebě důkazů v probíhajícím trestním řízení.
Proto je precedens na straně vlády.
Samozřejmě, že odklady soudních sporů i v případě prohry mohou být pro Trumpa určitým vítězstvím.
Šance na úspěšné uplatnění nároku na imunitu však dále snižuje předchozí zamítnutí Trumpova pokusu zablokovat výpověď před velkou porotou z 6. ledna.
Jak v říjnu informoval deník The Washington Post, v tomto odmítnutí bylo uvedeno, že například bývalý Penceův poradce Marc Short „pravděpodobně disponoval informacemi důležitými pro trestní vyšetřování Ministerstvem spravedlnosti ohledně útoku na Kapitol ze 6. ledna 2021, které nebyly dostupné z jiných zdrojů“.
To, že Pence pravděpodobně také disponuje jedinečnými informacemi, by Ministerstvu spravedlnosti pomohlo v případném boji o předvolání k soudu.
A důvod, proč si myslíme, že Pence takové informace má, je jen dalším důvodem, proč by nárok na imunitu neměl být úspěšný.
To proto, že se Pence rozhodl veřejně napsat alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké tvrdit, že komunikace podléhá imunitě, když jste ji předtím považovali za vhodnou ke zveřejnění.
Ačkoli tedy předvolání k soudu může pro Pence, který by se mohl v roce 2024 ucházet o Republikánskou nominaci proti Trumpovi jakožto někomu, kdo 6. ledna fakticky přimhouřil oko nad výzvami k Penceově mimosoudní popravě, představovat rozličné politické a osobní kalkulace, pro soudy by mělo být snadné postavit se na stranu Ministerstva spravedlnosti, pokud jde o imunitu.
Argumenty proti Bidenově kandidatuře jsou zřejmé – a slabé
Proč je to důležité?
Biden a jeho demokratičtí kolegové sice nemohou s Republikány ovládajícími Sněmovnu reprezentantů udělat mnoho z hlediska přijímání zákonů, ale přesto mohou jít příští dva roky příkladem.
Všichni členové týmu by měli společně vyhledávat příležitosti, aby si hráli na dobráky, zatímco Republikáni budou mít ty podivné sklony zlounů.
Pro Bidena je však také důležité, aby si u Američanů upevnil důvěryhodnost – a možná se stal nezbytně potřebným hybatelem změn v naší až příliš okoralé politické kultuře.
Washington, známé to cynické místo, se proslavil svými zdravý rozum ničícími představami o vůdcovství.
Jedním z nejznámějších je asi podivný standard, podle kterého je veřejné přiznávání chyb známkou slabosti a politici by se měli až komicky snažit, aby se tomu vyhnuli.
Existuje i jiný způsob: V knize Bailout, vzpomínkách Neila Barofskyho na jeho působení ve Washingtonu jako zvláštního generálního inspektora dohlížejícího na program Troubled Asset Relief Program, popisuje rady, které dostával od Kristine Belisle, ženy, kterou si chytře najal jako svou ředitelku pro komunikaci.
Bylo to tak protiwashingtonské, jak jen mohlo: „Přiznáme své chyby a dokonce na ně poukážeme.“
Jak dále vysvětlila, ve strategii, kterou by většina lidí uvnitř washingtonské okružní mezistátní silnice 495, přezdívané Beltway, považovala za šílenství, existuje jedna metoda:
Ten nejlepší způsob, jak si získat důvěru tisku.
Budou vědět, že je neodmítáme jako všichni ostatní.
Agentura SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o programu TARP ve Washingtonu.
Možná se někdy budeme stydět a prozradíme věci, které bychom mohli skrýt – a jiní by je snadno skryli –, ale svou upřímností budeme tisk šokovat.
Nikdo jiný to nedělá a zanedlouho budeme mít vybudovanou obranu, kdyby na nás někdo zaútočil.
Bez ohledu na to, co uslyší, novináři přijdou nejdříve za námi a uvěří nám, protože jim dokážeme, že mluvíme pravdu.
To je možná největší důvod, proč Biden pokračuje v radikálním přebírání odpovědnosti: v každém prezidentském úřadu nevyhnutelně nastávají okamžiky, kdy je rozhodující mít důvěru veřejnosti a institucí, které chrání občanské zájmy.
Kromě toho lze získat důležitý kapitál tím, že si uvědomíme své chyby, a v tom je důležitý rozdíl, ve kterém se Biden může svým politickým protivníkům vyrovnat.
Prezident by se měl pro své dobro řídit starým pořekadlem: Říkej pravdu a nenechej se ďáblem svádět ke lži.
Některé reklamy na Super Bowlu, u kterých se nemůžu dočkat, až je uvidím
Hvězda sitcomu z devadesátých let si zopakuje svou oblíbenou roli, aby vám prodala pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, který se z dvanáctisekundové scény protáhne na deset sezón.
Všechny celebrity z loňských reklam na kryptoměny se omlouvají za své reklamy na kryptoměny.
Tihle týpci z reklamy na americký Budweiser, ale fór je v tom, že teď už jsou staří.
Všichni teď mají rádi detektivky, že?
Takže nějaká série reklam v režii Riana Johnsona, kde když zjistíte, kdo vraždil, dostanete slevu na roční pojištění auta.
Reklama, kvůli které budou všichni superkonzervativní online týpci asi týden zuřit.
Timothée Chalamet v určité funkci.
Někdo, kdo byl údajně navždy zrušený, se triumfálně vrací do televize, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte a na který se určitě podíváte, až bude za tři týdny dostupný na streamovacích platformách.
Nesnesitelně chytlavá nová znělka, kterou si budete zpívat ještě několik let.
Recyklovaný vtip z Twitteru starý dva měsíce.
Hudebník, jehož celý smysl spočívá v tom, že je kontrakulturní, a který vám kontrakulturně říká, abyste si uzavřeli smlouvu u společnosti Wells Fargo.
Kluk ze staré reklamy na Mazdu, co dělal „zum zum“, ale fór je v tom, že už je dospělý.
Bidenovo Ministerstvo spravedlnosti „nechce ozbrojené občany“
Člen Sněmovny reprezentantů Andrew Clyde (Republikán za stát Georgia) se ve čtvrtek sešel se zpravodajským portálem Breitbart News a hovořil o svých plánech zablokovat pravidlo úřadu ATF o pistolových předpažbích a o svém přesvědčení, že Bidenovo Ministerstvo spravedlnosti „v první řadě nechce ozbrojené občany“.
Clyde jasně vyjádřil svůj nesouhlas s pravidlem o pistolových předpažbích.
Důvody jeho nesouhlasu zahrnují jak obecné, tak konkrétnější námitky.
Obecně vyjádřil přesvědčení, že naši Otcové zakladatelé nestanovili plán vládnutí, který by zahrnoval federální agentury, jež by vydávaly zákony namísto zákonodárného sboru.
Řekl: „Ministerstvo spravedlnosti je tu od toho, aby právo vymáhalo, ne aby ho vytvářelo. Když máte výkonnou moc, která vytváří zákony a zároveň je prosazuje, pak máte krále a království. Naši zakladatelé po králi nevolali a v Ústavě Spojených států království neustanovili.“
Clyde poté přešel ke konkrétním informacím o pravidle o pistolových předpažbích a vyjádřil svou obavu, že toto pravidlo je součástí větší snahy úřadu ATF o širší registraci střelných zbraní.
Poznamenal: „To, co úřad ATF chce, je rozšířit registrační databázi pro Národní zákon o střelných zbraních. Chce registrovat lidi po celé zemi, protože, jak víme, registrace předchází konfiskaci. A konfiskace je podle mého názoru konečným cílem, protože toto Ministerstvo spravedlnosti nechce mít ozbrojené občany.“
Dodal: „Ale Ministerstvo spravedlnosti chce mít registrované občany, aby vědělo, kdo co má, a mohlo po nás jít.“
Clyde tvrdí, že pravidlo úřadu ATF o pistolových předpažbích se zrodilo v tomto prostředí nepřátelství vůči Druhému dodatku a soukromému vlastnictví zbraní, a hodlá proti němu bojovat zuby nehty.
Řekl, že má „tři nástroje“, kterými může proti pravidlu bojovat.
Prvním z těchto nástrojů je zákon SHORT a druhým je zákon o přezkumu Kongresem.
30. ledna zpravodajský portál Breitbart News citoval Clydea, který nastínil svůj plán „znovu předložit zákon Stop Harassing Owners of Rifles Today, neboli zákon SHORT, který by zrušil prvky Národního zákona o střelných zbraních, a tím zakázal úřadu ATF registrovat a zakazovat pistole se stabilizačními předpažbími.“
Poznamenal také, že „předloží rozhodnutí o neschválení podle zákona o přezkumu Kongresem, aby zrušil nezákonné překročení pravomocí Bidenovy administrativy“.
Oba zákony, SHORT a zákon o přezkumu Kongresem, mají možnost zablokovat pravidlo úřadu ATF o pistolových předpažbích.
Jak však Clyde ve čtvrtek řekl zpravodajskému portálu Breitbart News, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k přijetí legislativy zákona SHORT, nebo k finalizaci rozhodnutí o neschválení podle zákona o přezkumu Kongresem.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existuje několik způsobů, například legislativa zákona SHORT by mohla být přidána k jiným, větším zákonům, které demokraté velmi touží schválit.
Clyde však naznačil, že existuje i třetí způsob, jak pravidlo úřadu ATF o pistolových předpažbích zablokovat.
Řekl: „Jsem členem dotačního výboru a můžeme toto pravidlo o pistolových předpažbích zrušit prostřednictvím takzvaného omezujícího pozměňovacího návrhu. Můžeme toto pravidlo doslova zrušit a v podstatě říct: „Na provádění nebo prosazování tohoto konkrétního pravidla o pistolových předpažbích se nesmějí vynakládat žádné peníze.“
A totéž můžeme udělat i s pravidlem úřadu ATF o pouzdru úderníku nebo závěru / tělu z loňského srpna.
Myslím si, že obě tato pravidla je třeba zrušit, a těším se na spolupráci s našimi přisvojovateli.
AWR Hawkins je oceňovaným sloupkařem zpravodajského portálu Breitbart News a autorem/kurátorem Down Range with AWR Hawkins, týdenního newsletteru zaměřeného na všechno týkající se Druhého dodatku, rovněž pro zpravodajský portál Breitbart News.
Je politickým analytikem rádia Armed American Radio a ambasadorem organizace Turning Point USA.
AWR Hawkins je držitelem doktorátu z vojenské historie se zaměřením na válku ve Vietnamu (říční námořnictvo), americké námořnictvo od jeho vzniku, občanskou válku a raně novověkou Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
K odběru Down Range se můžete přihlásit na adrese breitbart.com/downrange.
Obraťte se přímo na něj na adrese awrhawkins@breitbart.com.
„Doufáme,“ že Biden má plán, jak se vypořádat s ukončením platnosti hlavy 42, „ale pokud ano, ještě se o něj plně nepodělili“
V pátečním vydání pořadu „MTP Now“ stanice NBC vystoupil guvernér státu Colorado Jared Polis (zvolený za Demokraty) řekl, že má „velké obavy“ z toho, co se stane, až v květnu skončí platnost hlavy 42, a že doufá, že Bidenova administrativa má plán na to, až tato politika skončí, a že „pokud ho má, ještě se s námi o něj plně nepodělila“.
A uvedl „řekli jsme, že plán potřebujete vy. Chceme, aby ho s námi posoudili.“
Polis prohlásil, že by si přál, aby se během setkání guvernérů v Bílém domě věnovalo více času problému přistěhovalectví, ale tento problém „přišel na řadu“.
Části jednání se účastnil i ministr Mayorkas.
A tak jsme se znovu zmínili o tom, že máme velké obavy z toho, co se stane, až v květnu skončí platnost hlavy 42, a proto se musíme ujistit, že federální vláda má plán.
Doufáme, že má.
Pokud má, zatím se s námi o něj plně nepodělila.
Ale řekli jsme, že plán potřebujete vy.
Chceme, aby ho společně s námi posoudili.
Chceme se ujistit, že se v trojnásobném nebo pětinásobném měřítku nestane to, co jsme zažili už v prosinci, to by byla pro zemi katastrofa a pro Bidenovu administrativu by to bylo hrozné.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
Společnost McDonald’s stáhla „nevkusnou“ reklamu v blízkosti krematoria – RT World News
Společnost McDonald’s se omluvila poté, co byla reklama na hamburger „McCrispy“ tohoto řetězce rychlého občerstvení umístěna v blízkosti krematoria ve Velké Británii – ačkoli někteří místní obyvatelé v tom viděli vtipnou stránku věci.
Na základě množících se stížností obyvatel města Truro v britském hrabství Cornwall se řetězec restaurací zavázal pobuřující reklamu odstranit.
V pátek si získala pozornost na sociálních sítích, protože byla umístěna na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlenou reklamu, která byla umístěna přímo za cedulí mířící na krematorium, označili někteří rozzlobení místní obyvatelé za „nevkusnou“.
„I když to dokážu pochopit z té vtipné stránky, je to nevkusné a jsem si jistá, že někteří truchlící rodinní příslušníci to při návštěvě Penmountu během pohřbu a kremace blízkého člověka neuvidí rádi,“ uvedla jedna z obyvatelek, jejíž tchyně byla v pohřebním ústavu zpopelněna loni, jak ji citovala britská média.
Ne všichni však byli nešťastným umístěním reklamy tak pohoršeni, jeden z místních poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, „před jak dlouhou dobou jste ceduli s nápisem krematorium následovali v černém obleku“.
Jeden člověk řekl, že „spadl smíchy ze židle“, když si reklamy všiml na internetu, zatímco jiný místní poznamenal, že to není „o nic horší“ než rozhodnutí rady hrabství zabývat se myšlenkou povolit stavbu krematoria „vedle pečovatelského areálu pro důchodce“.
Místní média v pátek zveřejnila prohlášení společnosti McDonald’s, které bylo vydáno krátce poté, co se snímek reklamy objevil na internetu, a ve kterém řetězec restaurací uvedl, že reklamu odstraní co nejdříve.
„O dopravní značce v blízkosti této autobusové zastávky jsme nevěděli. Vzhledem k obavám, které vyjádřil zpravodajský portál CornwallLive, jsme však požádali o odstranění naší reklamy,“ uvedla značka rychlého občerstvení.
Rada hrabství Cornwall, která provozuje krematorium i přístřešek na autobusové zastávce, na němž je reklama umístěna, se na dotaz místních médií odmítla k pozdvižení vyjádřit.
„Instinkt“ mi říká, že pohřešovaná žena není v řece
Pátrání po pohřešované Angličance Nicole Bulley pokračuje šestnáctým dnem poté, co její partner prohlásil, že podle jeho „instinktu“ se nenachází v řece.
Policie hrabství Lancashire uvedla, že strážníci zachovávají „otevřenou mysl“ a nadále žádají o informace o paní Bulley, která zmizela 27. ledna při venčení psa v obci St Michael’s on Wyre.
Policie pokračuje v prohledávání řeky Wyre směrem k moři v ústí Morecambe Bay a pracuje s jednou hypotézou, že 45letá žena z obce Inskip mohla spadnout do řeky.
Při pátrání jim pomáhali specialisté a potápěči z Královské pobřežní hlídky, horské služby a hasičského záchranného sboru hrabství Lancashire, nasazeni byli i pátrací psi, drony a policejní vrtulníky.
Paní Bulley zmizela, když venčila svého špringršpaněla Willow poblíž řeky krátce poté, co odvedla své dcery ve věku šest a devět let do školy.
Telefon hypoteční poradkyně byl nalezen na lavičce s výhledem na řeku, stále napojený na pracovní hovor.
Její partner Paul Ansell řekl, že si chce nechat „všechny možnosti ohledně jejího zmizení otevřené“, ale jeho „instinkt“ mu říká, že v řece není.
Paní Bulley popsal jako „zábavnou“, „milující“, „nejvěrnější přítelkyni, jakou byste kdy mohli mít“ a „výjimečnou mámu“, která „jejich holky naprosto zbožňuje“.
„Pro naši rodinu je prostě pilířem síly a bez ní je ta díra větší, než si vůbec dokážete představit,“ řekl kanálu 5 News.
Pan Ansell uvedl, že ačkoli si rodina prochází „bezprecedentním peklem“, naděje, že se jeho partnerka najde, je „silnější než kdy dřív“.
Policie vyloučila cizí zavinění a případ řeší jako pátrání po pohřešované osobě.
Ve čtvrtek se pátrání přesunulo z obce St Michael’s do oblasti asi 10 mil po proudu řeky, kde se řeka v ústí Morecambe Bay vlévá do moře, a v oblasti byly spatřeny hlídkové a záchranné čluny.
Poslední komunistický vůdce Východního Německa zemřel ve věku 95 let
BERLÍN (AP) – Zemřel Hans Modrow, který zastával úřad posledního komunistického vůdce východního Německa během bouřlivého období, které skončilo prvními a jedinými svobodnými volbami v zemi.
Bylo mu 95 let.
Modrow zemřel v sobotu brzy ráno, uvedla na Twitteru parlamentní skupina Levicové strany.
Modrow, reformní komunista, převzal Východní Německo krátce po pádu Berlínské zdi a později přizval do vlády opoziční síly, ale nedokázal zpomalit sílící snahu o znovusjednocení Německa.
„Celý mírový průběh nastolení německé jednoty byl právě jeho zvláštní zásluhou“ napsala Levice na Twitteru. „Což zůstane jeho politickým odkazem.“
Během šestnáctiletého působení v čele komunistické strany v Drážďanech, které začalo v roce 1973, si Modrow vybudoval pověst odpůrce establishmentu.
Odmítl stranické výhody a trval na tom, že bude bydlet v normálním bytě.
Post v nejvyšším východoněmeckém vedení mu unikal, dokud se v listopadu 1989 – několik dní po pádu Berlínské zdi – nestal premiérem, což byla dříve málo významná funkce.
Když na začátku prosince odstoupil vůdce Egon Krenz zastávající tvrdou linii a jeho vládnoucí politbyro, Modrow se stal vrcholnou politickou osobností Východního Německa.
Komunisté však již nemohli rozhodovat sami.
Následující měsíc souhlasil se sdílením moci se stále hlasitější opozicí a za rostoucích nepokojů posunul termín prvních svobodných voleb ve Východním Německu na březen 1990.
I když prodemokratická shromáždění rychle získávala chuť po sjednocení, komunisté se zpočátku stavěli proti jednáním o sjednocení.
V únoru 1990 však Modrow vyzval k jednání se Západním Německem o případné „sjednocené vlasti“, která by byla nezávislá na vojenských blocích a byla by řízena společným parlamentem v Berlíně.
Modrow vedl volební kampaň přejmenovaných komunistů, Strany demokratického socialismu, ale ani jeho osobní popularita nestačila na to, aby se strana neumístila až na třetím místě s 16% podporou.
Vítězem se stala aliance konzervativních stran, která se vyslovila pro rychlé sjednocení a kterou podpořila vláda západoněmeckého vůdce Helmuta Kohla.
Německo se pod Kohlovým vedením a jako člen NATO sjednotilo 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal až do roku 1994, a čestným předsedou postkomunistické PDS – předchůdkyně dnešní opoziční Levicové strany. V letech 1999–2004 byl poslancem Evropského parlamentu.
Modrowova minulost v době vlády tvrdé komunistické linie ho několik let po sjednocení přivedla před soud.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků komunálních voleb v Drážďanech v květnu 1989.
Soud mu uložil devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces je politicky motivovaný, a prohlašoval, že jeho výsledek prohloubí rozpory mezi východními a západními Němci.
Jeho právní zástupce argumentoval tím, že odčinil předchozí křivdy tím, že jako premiér dohlížel na svobodné volby.
V pozdějších letech byl členem rady starších Levicové strany.
„Hans byl hluboce upřímný a bojovný socialista,“ napsal na Twitteru předseda parlamentní frakce Levicové strany Dietmar Bartsch.
„Až do vysokého věku byl významným poradcem naší strany, jehož moudrost nám bude chybět.“
Indická vláda po kritice stáhla výzvu k objímání krav na Den sv. Valentýna
Indická vláda již nepodporuje objímání krav na Den sv. Valentýna, přestože dříve žádala, aby tak lidé činili v zájmu podpory hinduistických hodnot.
Indická rada pro ochranu zvířat (AWBI) stáhla svou výzvu „Den objímání krav“ poté, co vyvolala kritiku politických soupeřů a uživatelů sociálních sítí.
Indické vládní orgány vyzvaly občany, aby se odklonili od západních romantických gest slavených na Den sv. Valentýna.
Nilandžan Mukhopadhyay, politický analytik, řekl, že výzva k objímání krav byla „naprosto šílená, odporující logice“.
Dodal, že rozhodnutí stáhnout výzvu bylo spíše proto, „aby se politika hindutvy (hinduistického nacionalismu) nezesměšnila tváří v tvář tvrdé kritice ze všech stran“.
Rada AWBI se v pátek vzdala své výzvy se slovy, že výzva „zůstává stažena“.
Teprve ve středu ve svém prohlášení uvedla, že „objímání krav (by) přineslo emocionální bohatství a zvýšilo individuální i kolektivní štěstí“.
Více o Indii
Rada dodává, že kráva je „páteří indické kultury a venkovské ekonomiky... díky své vyživující povaze matky“.
První oznámení vyvolalo smíšené reakce, protože někteří zveřejnili videa, na nichž krávy odmítají objetí a odbíhají pryč.
Jiní chtěli upřesnit, zda se výzva týká spíše následování své vlastní kultury než „slepého“ následování západních hodnot.
Mladí Indové obvykle tráví Den sv. Valentýna v parcích a restauracích, vyměňují si dárky a pořádají večírky.
Avšak ani objímání krav není nic nového – v některých částech světa je považováno za terapeutické a v Nizozemsku je známé pod názvem „koe knuffelen“.
Zbožní hinduisté uctívají krávu – známou jako gau mata neboli „kráva matka“ – a většina indických států zakazuje porážku krav.
V posledních letech někteří zastánci hinduistické tvrdé linie napadali obchody s valentýnským zbožím, pálili přáníčka a dárky a vyháněli páry držící se za ruce z restaurací a parků s tím, že tento den odporuje tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny, jako jsou Šiv Séná a Badžrang Dal, tvrdí, že tyto zátahy pomáhají opětovně potvrdit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadvládu tohoto náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80 % z téměř 1,4 miliardy obyvatel, většinu ostatních tvoří muslimové, křesťané, sikhové, buddhisté a džinisté.
Chodkyně zemřela v nemocnici po srážce s autem v obci Cowdenbeath, muž byl zatčen
Po srážce s autem ve správní oblasti Fife zemřela chodkyně.
Osmatřicetiletá žena byla po nehodě na ulici Broad Street v obci Cowdenbeath v pátek kolem půl druhé odpoledne převezena do nemocnice Victoria Hospital ve městě Kirkcaldy.
V souvislosti s nehodou byl následně zatčen 24letý muž.
Policie žádá případné svědky nebo osoby, které mají záznam z kamery na palubní desce, aby se přihlásili.
Seržant Lee Walkingshaw řekl: „Naše vyšetřování pokračuje a žádáme všechny, kteří se pohybovali v okolí a byli svědky nehody, aby se s námi spojili.“
Chtěl bych také požádat všechny, kdo oblastí projížděli a mohli by mít záznam z kamery na palubní desce, který by nám mohl pomoci při vyšetřování, aby nás kontaktovali.
„Kdokoli, kdo může pomoci, ať se ozve skotské policii na číslo 101 a uvede číslo incidentu 1638 z pátku 10. února 2023.“
V ČÍSLECH: Čtvrti Osla, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se do Norska přistěhovalo z jiných zemí.
Pokud zahrneme i ty, kteří se narodili v Oslu rodičům cizincům, podíl přistěhovalců nebo osob s přistěhovaleckým původem se zvýší na více než třetinu.
Podle údajů národního statistického úřadu (SSB) tvoří v Oslu největší skupinu přistěhovalců občané z Asie včetně Turecka, kterých ve městě žije více než 62 985.
Druhou nejpočetnější skupinou pak jsou občané EU, EHP a Spojeného království, kteří tvoří necelých 10 procent obyvatel města.
Afričané tvoří třetí nejpočetnější skupinu přistěhovalců v Oslu, kde žije 28 020 lidí z Afriky.
Čtvrtou nejpočetnější skupinou jsou Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, a to 15 566 obyvatel Osla.
Dál velikost skupin výrazně klesá.
Například v roce 2022 bylo jen necelých 7 000 občanů ze zemí Jižní Ameriky, zatímco občanů původem ze Severní a Střední Ameriky bylo něco málo přes 3 000.
Zatímco z Oceánie bylo v Oslu méně než 700 lidí.
Alna na severovýchodě města byla čtvrtí s největším počtem obyvatel z řad cizinců.
V roce 2022 zde bylo hlášeno k pobytu přibližně 18 257 cizinců.
Druhý nejvyšší počet obyvatel z řad cizinců měla módní čtvrť Grünerløkka nacházející se v přiměřené vzdálenosti od centra, a to 17 631 osob.
Ve čtvrti Gamle Oslo žilo také velké množství přistěhovalců – 17 631 osob, které se sem přistěhovaly z jiné země.
Údaje norského statistického úřadu ukázaly, že cizinci jsou rozptýleni po všech městských čtvrtích, například v Søndre Nordstrand, nejjižnější čtvrti Osla, bylo registrováno více než 14 000 přistěhovalců.
Mnoho přistěhovalců žilo také ve vyhledávaných oblastech, protože Frogner byla čtvrť s pátým nejvyšším počtem cizinců.
Zbylých deset čtvrtí v Oslu s největším počtem obyvatel z jiné země tvoří Stovner, Bjerke, Grorud, Østensjø a Sagene.
Na druhém konci spektra žilo ve čtvrti Marka jen 184 cizinců a v centrální čtvrti města jich žilo něco přes 700.
Dalšími čtvrtěmi s nejmenším počtem cizinců jsou Ullern, Vestre Aker a Nordstrand.
V těchto čtvrtích však žilo výrazně více přistěhovalců než v centru Osla a ve čtvrti Marka.
Osoby ze zemí EU a EHP a osoby ze Spojeného království žily převážně ve čtvrtích Frogner, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Přestože v Oslu žilo také hodně občanů z Asie, včetně Turecka (5 837), většina z nich byla hlášena k pobytu ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě čtvrti města, kde žilo nejvíce přistěhovalců z Afriky, spolu se čtvrtěmi Stovner, Grünerløkka a Søndre Norstrand.
Přistěhovalci ze Severní Ameriky byli poměrně rovnoměrně rozděleni mezi čtvrtě Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve čtvrtích Frogner, Grünerløkka, Gamle Oslo, St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojeného království žili spíše v nejcentrálnější městské čtvrti a ve čtvrtích Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek státních příslušníků Oceánie byly Frogner, Grünerløkka a Gamle Oslo městskými čtvrtěmi s nejvyšším počtem těchto státních příslušníků.
Zimbabwe zahájí provoz nového uhelného bloku do března
Autorka: Florence Tan
BENGALÚR (Reuters) – Náměstkyně ministra energetiky Zimbabwe řekla, že její země uvede v březnu do provozu nový blok své jediné uhelné elektrárny, čímž poskytne úlevu milionům občanů, kteří byli v posledních měsících postiženi častými výpadky elektřiny.
Nový blok elektrárny Hwange zvýší instalovaný výkon africké země o více než 14 % na 2400 megawattů.
Další blok by měl být uveden do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časový harmonogram.
Přístup k elektřině má méně než polovina z 16 milionů obyvatel Zimbabwe a celosvětové omezení financování kapacit uhelných elektráren omezuje schopnost země řešit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
„Jsme schopní vyrábět až 2100 megawattů (MW) z našich zdrojů energie, ale v současné době vyrábíme mnohem méně než to… asi 1000 MW,“ řekla Mudyiwa agentuře Reuters.
„Ale naše poptávka elektřiny je asi 1700 MW, takže jí máme velký nedostatek,“ řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné elektrárny se v průběhu času prudce snížila, zatímco poptávka po elektřině v posledních letech prudce vzrostla v důsledku zvýšené těžební a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů, které omezují vyhlídky Zimbabwe na růst.
Nedostatek finančních prostředků na uhelné elektrárny vede k tomu, že ekonomika závislá na těžbě a zemědělství dováží drahou energii ze sousedních zemí v regionu, včetně Zambie a Mosambiku.
(napsal Sudarshan Varadhan; redakce Jacqueline Wong)
[PERSON11] Ale u některých složek je z nějakého důvodu formát zvuku špatný, takže je něco špatně –
V podstatě je velký obchod nebo něco špatně.
Takže některý soubory jsou pořád – pořád mají podivný výstup.
Ale – ale u většiny složek už by to mělo být v pořádku.
[PERSON1] Dobře, díky.
[PERSON6] Jo, to je skvělý.
Podporuju to, je skvělý, že [PERSON7] jste mysleli na [PERSON11].
A teď je čas na [PERSON11].
Existují další věci, o kterých jsem přemýšlel, [PERSON11] a to by teprve bylo trénování, prázdných systémů, který by prováděly zkracování.
Takže kdybyste, [PERSON11], měli čas.
Je zřejmý, že za příští týden to v žádném případě nemůžeme stihnout.
Ale měli bychom mít systém – připravený na –
Díval jsem se na výukový program od NLP – byl to on?
[PERSON6] Pro nadcházející relace a tak, jsem se zeptal na poptávku, protože jsem viděl demo projektu (meme).
Dělají titulky offline.
Takže je to o něco jednodušší než to, co děláme my.
Pořád mají stejný problémy se segmentací a tak vůbec.
Jejich překladatelská mise se ale zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořený pro osoby se sluchovým postižením.
V datech tedy dochází jakoby k přirozenému zkracování.
Bylo by skvělý, kdybychom i my mohli najít takové typ dat, kde dochází k přirozenému zkracování.
Zařadili bychom ho do architektury.
[PERSON8] To zabere trochu času, protože musím zjistit, který z nich je ten, co prochází.
Takže jakmile to budu vědět, budu to moct sledovat, takže do budoucna –
Nebo vlastně do budoucna to nebudu potřebovat, protože jakmile budu mít webový soubor, pravděpodobně ho nebudu muset konvertovat.
[PERSON6] No, tohle, to by vlastně mělo být –
Slyšíš mě ještě?
Kvalita zvuku je o něco horší.
Takže by se to mělo dělat opravdu po celou dobu.
Při každým provádění tohoto hodnocení by se to tedy mělo spustit úplně od začátku.
Takže pokaždé by mělo dojít k novému stažení nové konverze a k novému vyhodnocení.
[PERSON8] Ale přesto, jak sleduji soubory, který je potřeba zkonvertovat ručně, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známý, a samozřejmě, pokud přidáme nějaký nový soubory, můžu se na to podívat později.
[PERSON6] Takže se jedná o důležitou věc, na kterou jsme měli narazit už před několika měsíci.
Nezapomeňte, že už od srpna vám říkám, že chceme vyhodnocovat na pozdějším testovacím souboru.
A pokaždé jste všichni...
Nejde jen o vás osobně, [PERSON8].
Byly tam samozřejmě i další věci.
Ale pokaždé, když jste o tom přemýšleli, říkali jste si „to bude snadný, prostě to spustíme“.
A teprve až to opravdu uděláte, uvidíte všechny ty problémy.
Tak je to známý, běžný.
A je to tak vždycky.
Takže tohle je vzkaz pro všechny.
Než se o to pokusíte, nikdy nevíte, v čem bude problém.
Tak například hovor, který jsem měl, kdy se mnou někdo dělal rozhovor, a tak si chtěl nahrát video.
Zoom mi nikdy nefungoval tak špatně jako dneska při nahrávání.
Než to uděláte, nemůžete říct, zda to bude fungovat, nebo ne.
A tady narážíme na problémy s konverzí formátů souborů.
Doufejme tedy, že se nám podaří rychle získat čísla.
Máte zatím nějaké údaje o chybovosti slov?
[PERSON8] Ne, nezpracoval jsem je.
Takže [PERSON1] řekl, že jakmile dostanou přepis, budeme to dělat společně.
A pak souhlasím s tím, že v tomhle slovníku je spousta šumu.
Tak jsem vás požádal, abyste měli různý verze tohohle slovníku, a to tak, že vezmete pouze ty slova, který byly pozorovaný, pětkrát.
A pouze ty výslovnosti, který byly pozorovaný třikrát nebo vícekrát, nebo něco takového.
Takže takhle se tyhle náhodný chyby, jako je příklad s těmahle čtyřma IBM místo IBM.
Tohle nebude tak častý.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba, řekne to „alzo“, pokud si pamatujete, pokud řekne to „alzo“ se „Z“ za, za rozhovor 20krát, pak ho uvidíte v datech se „Z“.
A pokud se mu to někdy podaří říct i správně, pak jo, zas to uvidíte v datech.
Takže bych chtěl, aby [PERSON4] byl v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, co?
Budu už muset odejít, protože musím dát dětem oběd a tak vůbec.
Ale prosím, zůstaňte u toho hovoru a společně zjistěte, jak ten slovník používat.
Takže, [PERSON4], prosím, ukaž [PERSON2], jaký slovník systém přijímá.
Sdílej obrazovku a ukaž ji.
A [PERSON2], podívej se prosím na to a pomoz s konverzí slovníku, který jste na ten soubor pustili.
Jedna z věcí, která bude pořád ještě potřeba, je náhrada jazykového modelu.
Ale všechny ty slova by měly být známý.
Takže ,[PERSON4], musíš zjistit, jaký slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by se měly jednoduše zkopírovat.
Takže slovník bude mít tři sloupce.
Grafém tak, jak je na výstupu.
Jeden rozpoznaný.
Fonémy tak, jak je [PERSON2] navrhl.
A bude existovat víc řádků s různými variantami fonémů.
Třetí sloupec bude zase stejný pro všechny z nich a zase bude mít stejnou formu grafému.
A to je ta chvíle, kdy to jazykový model vidí.
A myslím, že tímhle způsobem by tyhle systémy měly být schopný ho načíst.
A možná narazíte ještě na jeden další problém: že není připravený na dva velký vlastní slovníky.
Takže i to je něco, co je potřeba otestovat, ale prosím, otestujte to vy dva společně.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A ty víš, jak slovník vypadá, když ho vytváříš ručně, a tyhle dvě znalosti musíte spojit dohromady.
Aha, takže to funguje s tím, s tím vygenerovaným slovníkem.
[PERSON4] Dobře.
[PERSON6] Takže, [PERSON2], dává to smysl?
[PERSON2] Jo, jistě, probereme to.
[PERSON6] Jo, takže je ještě něco, [PERSON2], co máš?
[PERSON2] No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který se dá použít pro časovou značku.
Nejsem si jistý, jak dobrý to bude, protože se to snažím dělat na (Libry) Speech.
Když jsem to stahoval, tvrdili, že má přes 600 hodin.
Ale pak se při trénování ukázalo, že skutečný tréninkový soubor obsahuje jenom asi 300 hodin.
A stále si nejsem jistý, zda těch 300 hodin neobsahuje podobný věty.
Nebo vlastně tytéž věty, ale pronášený různými mluvčími.
Například v angličtině nebo češtině jsem dřív pozoroval prudší konverze.
A teď už nekonvertuje tak rychle.
Takže pokud během trénování vezmeme několik vzorků.
Pak se ve výstupu ASR pořád vyskytují určitý závažný chyby.
Doufám tedy, že na časovou značku je to dostatečně dobrý.
Nebo to aspoň můžeme zkusit.
[PERSON17] Dobře, to je dobrý, jo.
Tak jsem ti začal psát e-mail, ale myslím, že jsem ho nikdy nedokončil, protože jsi mi připomněl, [PERSON8], že filtrování nadávek ještě není integrovaný.
A myslím, že je to taky důležitá zpráva pro [PERSON5], který se z hovoru zase vytratil.
Důležitý poselství tedy je, že ano, je velmi dobrý, že aktivně usilujete o to, aby se vaše výsledky integrovaly, a měl by to tak dělat každý.
A zároveň potřebujeme mít nastavení, abyste ho mohli sami integrovat a testovat.
Říkám tomu „integrace svépomocí“.
Takže, [PERSON8], když pracuješ s [PERSON5] a dokumentujete, jaká jsou nastavení, ujistěte se, že je to dostatečně dobře otestovaný kolegy, například [PERSON4] nebo dokonce [PERSON9] z hlediska kontrol jazykového modelu a všema ostatníma.
Takže kdykoli někdo vyvine novou užitečnou komponentu, měl by mít dostatečně snadno k dispozici celou pajplajnu, aby ji mohl sám otestovat.
Tato integrace svépomocí je tedy důležitá, protože jinak všechno zůstane na tobě, [PERSON8], a ty se nechceš nechat přetěžovat.
Proto chceš těmhle lidem poskytnout vstupy a výstupy jako první testovací přístup, který už proběhl.
Je to tak, [PERSON4]?
Filtrování nadávek, bylo už otestovaný na protokolech?
Myslím, že bylo.
[PERSON8] Ano, myslím, že bylo testované na protokolech.
Takže teď nastal čas otestovat ho na ostrých pajplajnách.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to má udělat, aby si [PERSON4] spustil sám pro sebe některý převaděče a živě přehrál některý z problematických souborů, třeba za pomoci [PROJECT8] nebo jakkoli jinak.
Jednoduše je přehraj.
Sledujte zvukový výstup na svém počítači a podívejte se, jak to funguje.
Protože teprve při skutečným nastavení se objeví skutečné chyby.
Je důležitý ho nejprve odladit pomocí souborů protokolu a pak je důležitý ho odladit v pajplajně.
A pokud by to ladění mohl provádět autor dané komponenty, v tomhle případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Takže, [PERSON8], prosím, potvrď, že s touhle myšlenkou jakoby integrace svépomocí souhlasíš.
[PERSON17] Jo, takže pro angličtinu s více přízvuky.
Takže to teď [PERSON14] dáváme dohromady do jednoho technického řešení.
Současný nápad, na kterém [PERSON14] pracuje, spočívá v tom, že bude vytvářet nový věty se slovy, který byl řečený v jiných větách, a provede to napříč různými mluvčími.
Bude se tedy jednat o věty s více mluvčími, a proto by se mohla zlepšit i odolnost vůči různým přízvukům těchhle mluvčích.
Aha, takže to je jeden částicový experiment.
A později možná uděláme něco víc s tou záležitostí s více přízvuky.
Takže tyhle nový věty se vlastně snaží vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Takže systém ASR musí vidět co největší soubor vět.
A my budeme vytvářet nový věty z pouze textového jazykového modelu přidáním zvukové části, takže jazykový model bude pro ASR lepší a robustnost vůči různým mluvčím bude taky lepší.
A včera jsem v jedné přednášce zaslechl další nápad.
Bylo to během tréninku.
Ze zvuku jim vypadávaly časový a frekvenční pásma.
Takže trénovali na porušených vstupech, což taky výrazně zlepšilo robustnost systému.
[PERSON17] Kdokoli jiný může pracovat na záležitosti s přízvukem nerodilého mluvčího.
Dobře, pak jsem si všiml ještě jedné věci – je to v pondělním testovacím dokumentu.
Je zvýrazněná čtyřikrát.
Když tedy probíhá nějaká relace, potřebujeme pro ni názvy a terminologii.
A my je musíme shromáždit, ručně připravit, jaksi vytvořit.
A tahle ruční tvorba by měla být co nejvíc podpořená automatickými nástroji.
Takže je potřeba mít v tom určitou dovednost, kterou je potřeba trénovat.
No, já jsem docela zkušený v přehazování textových souborů.
A kdykoli vidím, že to někdo z vás, někdo z vás dělá, jakoby mám v hlavě tipy, co by se dalo udělat rychleji.
Možná to pro vás není rychlejší, ale měli byste to alespoň zvážit.
Takže tahle dovednost je něco, co potřebujeme, aby lidi měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jedinou osobou, která by to mohla být, je [PERSON8].
Pokud se najde někdo další, kdo by byl ochotný pomoct s okamžitou doménovou adaptací a zpracováním dat, řekněte to, prosím.
A pak potřebujeme –
Takže jakmile zajistíme slovník termínů a všelijaký výslovnosti slov, budeme potřebovat techniky, kterýma by se tyhle slovníky využily v systémech.
No, můj dojem z doménové adaptace, kterou [PERSON9] pečlivě prováděl u všech relací, byl takový, že v hybridním ASR to nebylo zrovna moc vidět.
Jedna taková relace se tedy uskuteční i toto pondělí.
[PERSON9] už začíná se sběrem dat, ale rád bych viděl přínos téhle doménové adaptace v, v, v nastavení od [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat doménovou adaptaci, a [PERSON14], protože dělá na tom, jak pracovat s [PROJECT5].
Kdybyste se vy tři mohli sejít a překontrolovat, co dělá [PROJECT5] s –
Ve skutečnosti to není [PROJECT5], doménová adaptace je určená pro sadu nástrojů [PERSON18], ne?
Je to takový zpátečnický, pořád jen používat starý ověřený metody.
V současné době je naprosto nemožný provést jakoukoli doménovou adaptaci pro plně neuronový ASR.
Uvažuji tedy o nezávislém vyhledávání klíčových slov ze zvuku a o nějakém postupu slučování.
No, mohli bychom mít spuštěný dvě ASR současně.
End-to-end ASR, který je obecně lepší.
A pak doménově adaptovaný nastavení od [PROJECT5], který se použije jen k rozpoznání klíčových slov.
A když uvidíme klíčový slovo v doménově adaptovaný verzi, pak bychom, pak bychom použili větu od [PROJECT5], která je obecně horší, ale obsahuje správný výrazy.
To je můj návrh, co bychom mohli udělat.
Dalším návrhem je, že bychom měli mít vlastní plně neuronový ASR a provádět různý experimenty s dolaďováním a vůbec.
Takže jsme o tom diskutovali s [PERSON14].
A, [PERSON14], máš nějaký aktuální informace od svého potenciálního kolegy nebo přítele?
[PERSON17] Jo, takže pokud je tady ještě někdo, koho by to zajímalo, dejte mi prosím vědět nebo se ozvěte.
Takže to je, je to něco, co by se obecně dalo dobře přijmout jako článek, protože lidi to zatím ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže bychom tam opravdu mohli zapůsobit.
[PERSON6] Jo, možná jsem jen přemýšlel jakoby o tom, jaký druhy dat pro to v současnosti používáme, protože například, jakoby když se podíváte na modely jakoby od [ORGANIZATION4] na [ORGANIZATION5], že už jsou v těchhle věcech jakoby docela dobří –
[PERSON6] A myslím, že kdybychom prostě jakoby –
Pravděpodobně bychom od nich mohli získat data, protože na [ORGANIZATION5] máte v podstatě jakoby tak velký soubor videí s různými doménami a různými rodnými jazyky mluvčích.
A napadlo mě, že bychom jakoby mohli použít nějaký nástroj, který by v podstatě stáhl několik druhů filtrovaných videí z [ORGANIZATION5] a vytvořil z nich tréninkovou sadu tréninkových testů.
Takže, plánuji to udělat sám.
Mám v plánu tam jít, ale potřebujeme někoho jako zálohu.
A taky potřebujeme někoho, kdo se postará o nahrávání akce [PROJEC210],
Takže nějakého archiváře, abychom o tuhle relaci zase nepřišli.
A ještě důležitějším a pořád přetrvávajícím tématem, na kterém je potřeba pracovat, je stoupání po žebříčku.
A tady v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by se generovaly automaticky a které by rostly.
Myslím, že by bylo asi nejjednodušší nasadit tabulky jako html, ale mohlo by se to zkomplikovat, až budeme chtít vidět rozdíly, protože po každé nové hodnotící kampani se budou hodnotit nový systémy.
Příprava těchhle tabulek může být obtížná.
Zeptal jsem se tedy [PERSON7] a [PERSON7] bohužel nebude během tohohle hovoru k dispozici.
Aby nám sdělil, zda použít [ORGANISATION242], což je webový řešení.
Nějaká startupová společnost, která nabízí účty pro akademické účely zdarma.
Pokud by nám to pomohlo, nebo ne.
Dobře, takže [PERSON7] [ORGANISATION242] nedoporučuje.
Takže tou správnou cestou je pravděpodobně jednoduchý html.
Jakmile tedy [PERSON2] bude mít ty hodnocení pročištěný.
To znamená přesunout těch několik skriptů z testovacího souboru [PROJECT3] a nějakého automatického spouštěče tam, kam patří.
Pak taky prosím vytvořte konverzi z tabulek do html podobně jako u technické konverze a tyhle výsledky pak pravidelně vkládejte na svou webovou stránku.
Nebo co můžete dokonce udělat, je mít úplný git checkout, který by se nacházel přímo v tomhle veřejným html, nebo by si to z tohohle veřejného html aspoň tahal.
Aby to bylo okamžitě přístupný prostřednictvím webu a kdokoli se mohl podívat na aktuální bodové hodnocení a prozkoumat ho.
Takže by to bylo užitečný, zejména pro lidi mimo [ORGANISATION2], jako je například [ORGANISATION15].
Víme, že mají rádi –
Výkon byl u některých souborů špatný, a mohli si to přímo procházet na webu.
Mohli by si to taky procházet ve skutečnosti na [ORGANISATION101].
Je na vás, abyste to nastavili tak, aby to bylo uživatelsky přívětivý a snadno se to sledovalo.
[PERSON2] Dobře, já to udělám.
[PERSON11] Jo, díky.
Nyní pracuju na, nebo se chystám aktualizovat odevzdávku článku k demu, která má termín příští pátek, pokud se nemýlím.
A pak musím udělat nějaký projektový zprávy a začínám shromažďovat dokumenty – jakoby, nebo odkazy na dokumenty, zatím ne samotné dokumenty, pro obě zasedání.
[PERSON11] <parallel_talk> Taky pro ASR bychom měli přidat doplňkovou metriku –
Vlastně víc, měli bychom přidat doplňkový met- tyhle doplňkový metriky. </parallel_talk>
Takže jsi zmínil jedno, a to je hodnocení filtrování nadávek.
Takže <parallel_talk> má explicitní seznam věcí, který se nesmějí objevit ve výstupu </parallel_talk>, že?
<parallel_talk> A pak hodnocení zřídkavých slov.
A tady máme explicitní seznam jmen a termínů, který chceme, aby se objevily ve výstupu, a to ne jednoduše podle (pořadí) míry </parallel_talk>, ale hodnocený podle něčeho, co tyhle věci přímo zohledňuje, že?
Ano, s tím naprosto souhlasím.
Což zahrnuje i ruční přípravu referencí.
Takže <parallel_talk> obojí vyžaduje ručně vytvářený reference. </parallel_talk>
Měl bych jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavila nějaký překladový slovník.
A měla by se o něj brzo podělit. </parallel_talk>
Takže to by se mohlo stát prázdnou částí té druhé záležitosti zřídkavého slova –
Takže <parallel_talk> to by bylo hodnocení zřídkavých slov pro MT a pak od [PROJEC210] pravděpodobně taky získáme nějaký slovník. </parallel_talk>
Takže to bude zřejmě doména [PROJEC210].
A [PERSON2], mohl bych tě požádat o revizi domény <unintelligible/> a vytvoření takového slovníku s ohledem na to, že se podíváš na výstupy a na to, co v nich chybí?
Tedy jakoby užší výběr – výčet slov, který se nám v doméně <unintelligible/> líbí a který se nám tam nelíbí.
Mohl bys to udělat?
[PERSON11] Mělo by to být proveditelný, tak to zkusme.
Bylo by jakoby – bylo by skvělý, kdyby se ti to podařilo.
Takže si to zapíšu.
Takže <parallel_talk> se zaměřuje na [ORGANISATION62] termín odevzdání článku o studii titulkovače. </parallel_talk>
Ano <parallel_talk> a pak na víc zdrojů s [PERSON7] nebo na základě [PERSON7], případně – </parallel_talk>.
A pokud jde o ID jazyka, zajímalo by mě, jak přesně ho chceš integrovat, protože to už zahrnuje zohlednění víc zdrojů ASR, víc kanálů, takže jaký by byl případ užití u ID jazyka?
Jak to tam zapojíme?
[PERSON13] Bude to převaděč zvuku na text a bude vysílat časový značky jakoby pro čtyři nebo dvousekundová okna a třídy.
<unintelligible/> ticho, čeština, němčina, angličtina, a pak nechám na ostatních, jak to chtějí v pajplajně používat.
[PERSON11] To je důležitý.
Prosím, zapište to sem do dokumentátoru, tohle shrnutí <unintelligible/>, protože to je pro [PERSON2].
A taky [PERSON2], až budeš mluvit s [PERSON10], no a taky možná [PERSON5].
Pokud máme tenhle nástroj, je potřeba (odesílat) zvuk víc ASR nebo víc převaděčům <unintelligible/>
Samostatně budeme muset (odesílat) zvuk do anglického ASR, samostatně do německého ASR a českého ASR, například v závislosti na <other_noise/>.
A taky do tohohle převaděče ID jazyka a pak potřebujeme tyhle výstupy sloučit, a to je nástroj, který zatím nemáme k dispozici.
To je nástroj s víc zdroji, který bude sledovat textový výstupy a taky časový značky a bude vysílat – pravděpodobně bude jakoby vytvářet výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Takže potřebujeme filtr pro ASR, aby byl ASR zticha, pokud je to nesprávný jazyk, a aby byl rozpoznaný text, pokud je to správný jazyk.
Tenhle typ nastavení jsem právě vymyslel.
Další z nastavení by bylo, že stejný zvuk bude posílaný do ASR a tohohle kontroloru jazyka.
Tenhle kontrolor jazyka je v podstatě součástí ASR a v případě nesprávného jazyka ASR umlčí.
I to je možnost.
Takže, potřebujeme vymyslet, který způsob integrace ID jazyka je pro naše účely nejlepší.
Přemýšlejte proto o tom, jaký jsou naše pajplajny.
V ideálním případě by podle mého názoru vzniklo nejmíň zmatků v řízení a tak dál, kdyby naše modely MT byly vícejazyčný.
Pokud by podporovaly různý zdrojový jazyky a překládaly z jakéhokoli z nich do angličtiny.
Případně by stačilo, aby dělaly jen kopii, pokud by byla jako vstup zadaná angličtina, takže bychom na začátku měli vícejazyčný vícenásobný ASR.
Vše půjde do angličtiny a z angličtiny pak do všech jazyků.
A později, až bude [PERSON12] mít vícejazyčný model ASR, nebude tohle jazykový ID vůbec potřeba.
[PERSON3] Jde o to, že pokud provedeme analýzu správněji, jedna věc je možný protichůdný vyhodnocení, který jen naznačuje, že, že omezení mají skutečně vliv na skutečný výstup.
To by bylo hezký a jo, možná i udělat analýzu pozornosti.
Ale nejsem si jistý, zda nám to může dát stejný odpovědi, v podstatě, zda, zda model dává, nebo nedává pozor na omezení.
[PERSON4] Musel jsem se podívat na pár příkladů pozornosti, nedělal jsem si žádnou statistiku ani nic jiného, a podívá se to na omezení, a když to překládá omezení, vypadá to jako daný omezení, a myslím, že by bylo užitečný, kdyby systém dělal nějaký chyby, ale ve skutečnosti žádný v tomhle smyslu nedělá.
Dělá některý obecný chyby v překladu, ale ne ty (jevy), který se snažíme vyřešit.
Když se vrátíme k automatickému vyhodnocování, problém s neshodou spočívá v tom, že výstup je správně vyskloňovaný, ale kontext se liší.
Nejedná se tedy o stejný slovní druh jako v referenci, že?
[PERSON4] Jo, ale taky jsem zkontroloval, zda jsou kontexty platný překlady, a ve většině případů jsou.
Stejně jako v prvních 100 příkladů, které byly automatickým vyhodnocením označený jako chybné, bylo 91 z nich správně vyskloňované ve správných kontextech.
[PERSON4] A myslím, že jen dvě nebo tři věty byly správně vyskloňovaný v nesprávném kontextu, jako by byl překlad špatný.
A pak jsou některý případy, kdy byl překlad úplně špatný, protože věta byla opravdu špatně a část musí být <unintelligible/>, ale to bylo jen v jednom nebo dvou případech.
[PERSON3] Ale při vyhodnocování se snažíš o shodu forem odchylek, že?
Neděláš žádný –
[PERSON3] – lemmatizace referencí a –
[PERSON4] Obojí, obojí, obojí, snažím se o shodu jak povrchových forem, tak lemmatu.
[PERSON3] Aha, aha, jo, to jsou ty dvě skóre, že?
[PERSON4] Jen skóre dilematu pro (evropský?) není v tabulce, protože tabulka jako by se nevešla na papír, takže <unintelligible/>
Pokrytí je vždycky asi 97 procent.
Prostě to generuje správný lemmata, jen –
[PERSON3] Aha, jo, dobře, chápu to, chápu to.
Pokrytí lemmatu tedy v podstatě říká, zda omezení existuje, a rozdíl v pokrytí povrchu naznačuje, že by to mohlo být nesprávně vyskloňovaný, ale tohle ten případ není.
[PERSON3] No jo, jen nevím, jestli jste, jestli jste, jestli jste zachytili <unintelligible/>, když jsme mluvili o [PERSON1],
ale jedna věc je, že, že (rozptyl) je lepší, ale druhá věc je, že lemmata jsou skutečně správně skloňovaný ručně,
ale to je, to je další, ne, žádný problém, to je vlastně dobře, že je <unintelligible/> správně, jo.
Tak jsem si říkal, že by to tam mohlo být.
Nejsem si ale jistý, zda pro to máme nějaký testovací data, ale mohli bychom si zkusit pohrát s modely pomocí nějakého přenosu stylu?
Jak víte, můžeme použít omezení a místo něj zkusit použít synonymní omezení a zjistit nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale tohle je, jakoby to popisuji jenom vágně, protože sám nemám přesnou představu, jak to udělat, ale mohl by to být zajímavý, nevšední scénář.
Nevím, [PERSON1], víš o nějakých datech o přenosu stylu mezi angličtinou a češtinou? Máme něco k dispozici?
[PERSON4] <unintelligible/>
[PERSON1] Tím přenosem stylu, Dušane, myslíš, že by tam bylo něco, co je ve spisovném jazyce, a ty bys byl cílovou stranou, bylo by to v mluveném jazyce, nebo něco takového?
[PERSON3] No, to je taková věc, jakoby, mám jen omezený znalosti úlohy.
Ale dovedu si představit, že chceš přepsat větu tak, že ji nenapsal muž, ale místo něho ji napsala žena, nebo, já nevím, jako že můžeš mít vědecký a nevědecký vysvětlení určitých jevů.
Opravdu nejsem tak dobře obeznámený s přesnými soubory dat a s tím, co pokrývají.
A jde o to myšlenku toho, že styl vět je poměrně vágně definovaný.
Takže si zase nejsem tak jistý.
[PERSON1] Máme tenhle korpus transformací vět.
A jedna z věcí, která v něm je a která by mohla být označená jako přenos stylu, je například větší zobecňování vět.
Takže se vynechávají detaily, věta se zjednodušuje a pak zní hovorově.
No, je to jen parafráze.
A nejsem si jistý, zda máme něco jako zkracování věty.
Ohledně zkracování dělá Matouš nějaký pokusy mezi angličtinou a češtinou, ale nemáme k dispozici žádný referenční data.
Takže nemáme k dispozici žádný soubor dat pro kompresi vět.
Možná by tedy zobecnění mohlo být zajímavý, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediná reference by byla příliš omezená na to, aby vám řekla něco o kvalitě vašeho zobecnění.
A nejsem si vědomý žádných podobných genderových transformací, například by se to dalo udělat <unintelligible/> pro češtinu, takže možná správnou osobou by byl Rudolf Rosa, zeptat se ho, jestli někdy nějaký takový soubor dat nevytvořil.
Takže se bude generovat nějaký protějšek věty na základě kořene.
[PERSON3] Myslím, že je to vlastně jakoby zajímavá otázka, zda můžeme použít omezení k vynucení tohohle druhu věcí, jako je rod mluvčího v, v překladu.
[PERSON1] To je vlastně hodně dobrý nápad.
Takže bychom se mohli zaměřit na tuhle oblast a vytvořit určitou dílčí část testovacího souboru[PROJECT1], která by to pokrývala.
Aha, takže někdy známe pohlaví mluvčího, takže pokud jste... možná vám nasdílím obrazovku a projdeme si to.
[PERSON8] Nebo jsem to zkusil s Marianem, který se ho právě účastní, a je to... Nevím, o kolik bodů BLEU nižší.
[PERSON2] Protože jakoby způsob, kterým Martin podle mě dělá <unintelligible/> ty svoje překládky tak, že překládá víc vět najednou a pak si vybere jen tu prostřední a takhle postupuje celým dokumentem.
Takže kontext je jakoby v jednom <unintelligible/> spolu s větou, kterou vlastně chceme přeložit.
[PERSON10] Jo, myslím – nebyl to Dominik, kdo dělal nějaký experimenty s Ivanou?
Myslím, že v minulém roce nebo před dvěma roky pro hodnotu double empty, kde dávali pozor na kontext nebo řetězili kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale ta záležitost s tímhle, se řetězením není zcela jistá, zda má stejný účinek, protože my děláme na nastavení s víc kodéry –
[PERSON1] Jakože každý je jiný, je to určitě jiný výpočet, jiný vedoucí, ale to, překvapuje mě, že [PERSON8] říká, že to nefunguje – a tečka.
[PERSON8] Jo, dobře, tak se omlouvám, možná bych měl být přesnější, že to nefungovalo jakoby tím způsobem, jak jsem to udělal <laugh/>.
[PERSON1] Jo, protože si myslím, že je to metoda, která se dá velmi snadno testovat, a vždycky by se měla testovat v kontrastu s dvěma kodéry, a očekával bych, že někdy bude lepší a někdy horší než dva nastavené kodéry, v závislosti na přesné úloze, jako co přesně je ta druhá věc, kterou kódujete.
Takže pokud máte dvě kopie dvou parafrází téže věty,
možná je to nějak matoucí z hlediska pozornosti, takže, cokoliv, nevím.
Chování se taky mohlo lišit u starých metod sekvence po sekvenci ve srovnání s transformátorem, takže u RNN se to pak chovalo jinak, možná u transformátoru je to tak, jo, je těžší ho trénovat, takže možná je třeba zvýšit počet zahřívacích, zahřívacích sad.
[PERSON2] Jo, takže prostě víš, jakoby –
[PERSON8] Nepamatuji si to, takže si to nepamatuji přesně, ale je to jakoby –
když jsem v létě začal s experimenty s více zdroji.
Nejdřív jsem začal se řetězením parafráze a zdroje a možná jsem, teď si nevzpomínám,
do příštího mítinku můžu zkontrolovat, zda jsem se o to taky pokusil,
určitě jsem zkoušel, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Možná jsem taky zkoušel, že jsem ty dvě věci náhodně zamíchal, jo, a jen si vzpomínám, že to hojně dělalo tyhle kompenetrační věci a zkoušelo to víc kodérů.
[PERSON8] A to pravděpodobně kvůli nízkému skóre.
[PERSON2] <unintelligible/>, který se ti líbí, ti může zlepšit skóre amenity pouhým připojením výstupu založeného na frázi a pozornost je jako dvojitá diagonála, takže pozornost není problém, takže jakoby věřím ti, ale je překvapující, že to nefungovalo.
[PERSON10] Takže pokud zadáte výstup založený na frázi, je to v podstatě posteditování, že? Můžete o tom přemýšlet jako o posteditování, jako byste posteditovali výstup založený na frázi, že? Nebo jakoby záleží na úhlu pohledu, že?
[PERSON1] <unintelligible/>, který se ti líbí plně přepsat, ale technicky přesně odpovídá úloze posteditování, můžeš to zapojit jako řešení úlohy posteditování.
[PERSON10] Dobře, takže jedna otázka jenom za mě, abych se ujistil, že v nastavení řetězení vkládáte token oddělovače vět, že?
Máte nějaký speciální token, který rozlišuje, která věta je zdrojová a která kontextová nebo jiná, nebo je prostě zřetězíte bez čehokoli?
A doufáte, že se to systém naučí?
[PERSON8] Zkoušel jsem, tuším, dva tokeny a jo, jakoby protože v první verzi jsme měli podezření, že by ten token mohl být taky tokenizovaný sám o sobě, tak jsem to pak přehrál s jiným tokenem, který není určený jenom pro tenhle účel, protože jsme použili nějaký předtrénovaný slovník, a tenhle slovník neobsahoval tokeny oddělovačů.
Takže jsem použil nějaký token, u kterého jsem předpokládal, že nebude jakoby tokenizovaný na několik částí, a tak se objeví jednou.
Neměl jsem žádnou záruku, že by se ten token nemohl objevit na jiných místech ve větě a že je to to jediný místo, kde se může objevit.
Takže by se to dalo udělat pořádněji, jo, souhlasím.
[PERSON2] Ale část Flask nebo část komunikace s klientem je něco, co nemůžu udělat.
Protože nemám žádný zkušenosti ani čas na jeho zprovoznění.
[PERSON1] Myslel jsem, že to znamená něco, co používá, já nevím, mediátor.
[PERSON2] Ne, vytvoříš klienta HTTP, který může naplnit frontu a číst z jiné fronty.
A odešleš text zpátky v požadavku HTTP.
Moje představa je totiž taková, že kliknutí uživatele se budou používat i v ukrajinském projektu.
[PERSON2] A moje představa je taková, že klient klikne na tohle tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk zároveň po malých kouscích.
Řekněme 200 nebo dokonce 100 milisekund.
A na serveru HTTP to dáš do fronty, kterou budu později zpracovávat pomocí (ASR).
A model s tím na základě toho provede určitou logiku, určitou inferenci.
A kdykoli se objeví nová část přepisu, odešle ji zpátky a uživatel by měl dostat zpátky částečný přepis.
A ten by se měl okamžitě zobrazit v textovém poli.
[PERSON1] Mohl bych o tom popřemýšlet.
Jen Flask taky moc neznám, ale jo, můžu o tom popřemýšlet.
[PERSON2] Aha, možná jiný server HTTP.
Nevím, možná k tomu ani nepotřebujeme žádný vyšperkovaný server HTTP.
[PERSON1] Pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, zda by to fungovalo i v tomhle případě.
[PERSON2] Jo, jediným požadavkem je, aby zvládal víc připojení najednou.
[PERSON1] No, myslím, že online tok textu je něco kolem 2 000 minimálně.
[PERSON1] Myslím tím skript, který mám ve dvou různých složkách, a pak ho spustím s trochu rozdílnými vnitřními převaděči, takže myslím, jo, takže mám <unintelligible/> řekněme deset, no místo výstupu, soubor <unintelligible/> pobočního převaděče, takže <unintelligible/>, který máme, takže se prostě ujistím, že se tyhle věci pro jeden soubor generují paralelně ze všech dostupných převaděčů.
[PERSON1] Aha, to by nám ušetřilo čas.
[PERSON7] Jo, jo, je velmi důležitý všechno ve skutečnosti paralelizovat, paralelizovat jak zpracování systémů, tak vyhodnocování DF buněk, protože by to potřeboval spouštět mnohokrát, budou se vyskytovat chyby, je třeba to rychle spustit znova.
[PERSON7] Dobře, takže díky.
Máte s tím hodně práce, nechci vás zatěžovat dalšíma věcmi, takže začnu s připomínkami.
Musíme dokončit popis souboru stolů [PROJECT1],
Koho to tu máme?
Aha, no ne tak docela, jo, (je to hotový) a bohužel to není tady.
Takže to by bylo pro [PERSON2],
Pak vyhodnocení, to je pro [PERSON1], ale to už jsme probrali.
Poslouchejte, dejte mi tabulku v DSD, dejme sem jemnou čáru a pushněte šablonu tabulky, jakože strukturu plánu do delebl teď, takže čísla přijdou později, ale už velmi brzo chci vidět nějaký čísla a úplnou strukturu tabulky.
[PERSON7] Dobře, děkuju.
Máme [PERSON5], to je dobrý.
Rád bych si tedy u [PERSON5] ověřil, jaký je pokrok ve vyhodnocování systémů, a zda jste v kontaktu s [PERSON1] taky kvůli vývoji, což je důležitější.
Slyšíš nás, [PERSON5]?
[PERSON1] a pak zjistíme, který balíčky nainstalovat do prostředí Petri.
[PERSON7] Jo, takže je tu další věc,
Možná není dobrý nápad spojit tyhle dvě spuštění do jednoho nastavení.
Myslím, že ve skutečnosti bude lepší, když to spustíš samostatně a uložíš výstupy.
Takže nejprve použiješ prostředí pro řízení a zpracování,
[PERSON7] a ty shromáždíš všechny výstupní soubory a poté spustíš vyhodnocení.
Důvodem tohohle rozdělení je, že můžeš víc paralyzovat.
Takže jsem si jistý, že se vyskytnou problémy na různých frontách a že budeme velmi brzo potřebovat čísla.
Takže pokud například některé testovací soubory z nějakého důvodu selžou,
Pak můžete nechat překlad spuštěný i pro zbývající,
a znovu vyhodnotit pomocí sel T F ty chybějící a, a tak dál.
Takže nejde o to vytvořit sériový, sekvenční zpracování, který by zahrnovalo obojí,
ale cílem je, abyste získali výsledky, a to je ve skutečnosti lepší dělat po částech.
Nejprve získáme všechny výstupy, a až potom všechna hodnocení.
[PERSON1] Jo, takže, teda myslím, teď jsem dělal to samý.
[PERSON2] Ano, to je jediná věc, kterou jsem udělal pro kladné omezení.
Se zápornými omezeními jsem při dekódování udělal něco trochu složitějšího.
Jako odfiltrování paprsků a jejich nahrazení jinými paprsky.
A například pro omezení víc tokenů a tenhle podobný druh záležitostí.
Ale pro kladné omezení jsem porovnával jenom přístup k trénování s, jo, právě touhle velmi jednoduchou záležitostí.
Stačí jenom upravit skóre v každém kroku stejným způsobem.
[PERSON7] Dobře, takže zpět ke kladným omezením.
Zaměřili jste se už na analýzu systému?
[PERSON2] Jo, právě teď tak trochu čekám na přepracování datového souboru od ([PERSON9]).
I [PERSON9] já jsem se podíval na (kód) a myslím, že vím, proč je to tak pomalý.
Protože pro každou položku v terminologii v rámci přepracování (Europar) otevřete datový soubor, tokenifikujete ho, přečtete ho řádek po řádku, tokenifikujete ho řádek po řádku a poté ho zavřete.
Ale jenom ty to ty děláš –
[PERSON4] Takže si vzpomínám, že pro [PROJECT1] jsem tohle dělal loni z nějaké chaty na horách.
A já jsem si krátce před Silvestrem uvědomil, že to musím odeslat.
A <laugh/> takže to je taky něco, co se stane i [PERSON8]. Obávám se, že by mohl být... no, na žádné straně, ale možná na vzdálené straně.
A pak si najednou uvědomí, že to má odeslat.
V tomto okamžiku tedy nebude provedený žádný přezkoumání. <laugh/>
Jednoduše by vzal PDF a nahrál ho tak. <laugh/>
[PERSON7] No, dobře.
Takže jo, zkontroluji to 21. a jinak jim pošlu e-mail.
[PERSON4] Prosím, myslím, že bude lepší jim hned poslat e-mail a požádat je o ten odkaz předem.
[PERSON7] Dobře.
[PERSON4] Jo, díky.
[PERSON7] Máme dnes ještě nějaké další otázky k projednání, nebo je to do Nového roku všechno?
[PERSON6] Doufám, že tam nebylo nic pro mě?
[PERSON3] Před několika lety.
Maratony MT mívaly tyhle články o systému nebo o nástrojích, který byly publikovaný jako zvláštní vydání PBML.
To bylo v prvním roce, kdy se to stalo.
V dalších letech pak byly integrovaný s normálníma, stejně jako byly i vydání PBML, kde se míchaly prázdné marginální články a samostatný články, protože těch článků bylo hodně.
A dokonce jsme měli i takovou věc, jako že pokud článek nebyl dost dobrý pro PBML, ale pokud byl nástroj prezentovaný na maratonu MT.
Autoři byli vyzvaní, aby se přihlásili k dalšímu recenznímu řízení pro příští vydání PBML.
Takže máme, jak jsem dokonce řekl, váš systém, váš nástroj je zajímavý.
Prosím, zveřejněte ho na maratonu MT mezi lidmi.
Ale váš článek je příliš špatný.
Musíte ho zlepšit a dostanete se až do dalšího vydání PBML.
[PERSON4] Ano, ale další možnost pro SIGDial.
Není možný, že bychom pokusem o SIGDial přilákali lepší účastníky.
[PERSON3] To znamená, ano, to je... jakoby jsem si myslel, že jsem měl taky, ale neznám ani jedno z těch míst.
V červenci je registrace posledních článků.
Takže konference se konala v září a článek se odevzdával v květnu.
Protože pro Interspeech bychom to mohli taky rozdělit článek po článku.
Tak, aby se některý články dostaly do sborníku Interspeech.
A některý z našich odevzdaných článků se objeví později ve sborníku PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď s konferencí SIGDial, nebo Interspeech.
Jestli jim nevadí, že mají k dispozici některý naše články, vzhledem k tomu, že tyhle články jsou odevzdaný do březnové uzávěrky.
Takže existuje naprosto striktní požadavek.
A myslím, že proti tomu nemůžou nic mít.
Protože pokud je článek hodný zveřejnění.
Jakoby, je to jen bonus, že článek obsahuje nějaký společný výsledek úkolu, který se objeví v rámci satelitní události.
Takže jo, myslím, že je to v pořádku.
Nemusíme tedy žádat o zvláštní zasedání.
V rámci konference Interspeech se tomu říká zvláštní zasedání, to nechceme.
V rámci konference Interspeech chceme satelitní událost.
Ale našim lidem řekneme tohle.
Pokud se vám podaří připravit článek do uzávěrky konference Interspeech, pošlete ji jako článek pro Interspeech a budete ji mít v rámci konference Interspeech.
Ale pokud to, eh, neuděláte v termínu konference Interspeech, tady je náš termín.
A to je pro PBML.
[PERSON7] Aha, dobře.
Ale je to jako satelitní akce v rámci konference Interspeech.
Ehm, Interspeech se jakoby nedostane do žádného sborníku.
[PERSON2] Myslím, že si můžeš celý semestr vyhradit jen na předměty [PERSON9] a budeš mít spoustu práce a žádný volný čas, i když máš jen jeden předmět.
Ale já si myslím, že je to něco jiného, protože si myslím, že propadnout z jeho kurzů není opravdu nic těžkého.
Jakoby propadneš, protože to nebudeš schopný dokončit.
Samozřejmě, že to jakoby lidi vzdávají, ale myslím, že je to možná z jiného důvodu, že prostě nejde projít.
Myslím, že je to určitě možný, ale chce to hodně práce.
[PERSON1] Jo, myslím, že nám na začátku semestru řekl, že když budeme chtít jedničku (??), dostaneme jedničku.
Právě ve druhém termínu byste ji měli odevzdat.
To je v podstatě jediná věc, kterou požadoval.
Zároveň nám ale řekl, že podle trendů z minulých let to spousta lidí neudělá.
Čtení na zkoušku je pro ně snazší.
Ne, promiň, uč se na zkoušku –
[PERSON2] Jo, protože jeho zkoušky jsou, no, obecně poměrně snadný.
[PERSON2] Takže bych neřekl, že je to super snadný, protože jsou kurzy, kde je zkouška jako zábava.
[PERSON1] Aha, no, jeden z takových byl pro mě včera.
[PERSON2] Jo, když to má krátký kontext, a protože se rozhoduji na základě velmi krátkého kontextu pro tuhle velmi nízkou latenci, pak se opravdu dopustí něčeho, o čem například za sekundu nebo dvě zjistí, aha, no, tak tohle byl vlastně špatný překlad.
Proto se snaží použít jiný znění.
Aby například specifikoval věc.
Takže se mi to vlastně moc líbilo.
Některý překlady se mi líbí. Opravdu mě překvapilo, že i když bylo vidět, že model udělal na první pokus chyby, opravdu chtěl provést nějaký druh opravy.
A rozhodně zněl opravdu plynule, což je podle mě taky důležitý.
Pokud opravdu požadujete nízkou latenci, pak, pak si myslím, že i o něco nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale jestli je ta nižší kvalita způsobená překladem, když si přečtete všechno, tak dostanete stejnou informaci, ale formulace je prostě špatná, protože je v něm použitých například víc slov a jsou použitý nějaký opravy a takový záležitosti.
Myslím, že pro simultánní použití je to naprosto v pořádku, pokud neztratíte žádný informace.
A pro který jazykové páry máte tyhle výsledky, například nějaký příklady?
Rád bych se na ně totiž podíval, už jenom ze zvědavosti.
[PERSON2] No určitě, můžu ti vysypat své protokoly.
[PERSON7] Ale v jakých jazycích?
Protože víš, že nemluvím německy.
[PERSON2] Angličtina a němčina.
[PERSON7] Jo, ale já nemusím nutně mluvit německy <laugh/>.
[PERSON2] Pak můžu poskytnout anglicko-čínský a anglicko-japonský, pokud to pomůže <laugh/>.
[PERSON2] Zase tedy chci, aby to bylo lidsky čitelný.
Protože to blikání je opravdu otravný a člověk se pak přestává soustředit na to, co bylo vlastně řečený, protože to je možná taky otázka na někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Omlouvám se, ale nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím, že kdykoli vidím nějaký slovo, uložím si ho do paměti a moje paměť není lineární, ale je to spíš takový pytel.
Tak jsem dal slovo do pytle.
Rád v tom pytli spojuji věci, abych dostal celkový obraz slova.
A myslím, že to je problém toho blikání.
Když něco přeložíš a pak to změníš, tak už jsem to vlastně četl, mám to v mozku.
A pak jsem ztratil pozornost a kontrolu nad tím, co bylo vlastně pak přeložený jako správný, a nebylo to, co nebylo.
Proto si myslím, že celá ta záležitost s blikáním je špatná a hloupá už z definice.
Jako bych viděl motivaci, jako byste chtěli ukázat všechno, co máte.
I když nemůžete slíbit, že to bude dobrý.
Myslím si však, že s těmito informacemi navíc nemůžeme pracovat.
A myslím, že problém je možná v tom, že systémy vytvářejí lidi, kteří s nimi pracují.
Pokud vyvíjím nějaký systém, tak mám opravdu šílenou radost, když vidím, že i když neslibuji, že je překlad správný, tak ho přesto ukážu a je to tak nějak dobrý, ale myslím si, že vývojář se opravdu nesoustředí na samotný obsah.
A to, jak vnímáte obsah, ale spíš na to, že, no jo, můj systém to dokáže vypsat opravdu rychle.
A i když se jen domnívá, že kvalita je tak nějak v pořádku, myslím, že to je možná důvod, proč byl vytvořený nový překlad.
Prostě vývojáři systémů touží po tom zobrazovat informace a myslím si, že protože jsme omezeni jakoby objemem informací, který můžeme vnímat v určitém čase, jakoby vidíme, že informace navíc jsou pro nás jen zátěží navíc.
Proto si myslím, že není dobrý ukazovat něco navíc.
Jakoby pokud chcete snížit latenci, pak místo blikání prostě snižte kvalitu.
Myslím, že je to pořád lepší než zobrazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste vlastně potřebovali vidět nestabilní hypotézu?
Třeba z pohledu uživatele?
[PERSON1] Jakoby technicky, když lidští překladatelé začnou překládat, myslím, že cílem pro autory poznámek i tam je, aby se snažili následovat řetězec řeči původního mluvčího.
Někdy se stane, že něco řeknou a je to špatně, takže se prostě opraví.
[PERSON2] No jo, ale to znamená, že s mým řešením, jako byste neudělali blikání, ale spáchali jste to, jako by neexistoval způsob změnit to, ale opravíte se.
A to je vlastně to, co dělají překladatelé.
[PERSON3] Mám silný pocit, že naše práce není zrovna v doméně řeči, je nezdravá.
Protože tady neexistuje žádný koncept řeči.
Pracujeme přímo na textu.
Jde však o to, že návrh na letošní statistický workshop je za námi, konal se v září, což pro nás bylo příliš brzo.
A další návrh by přišel v roce 2022, což už by pro nás bylo příliš pozdě.
Je lepší, když se dostaneme do některého ze dvou sborníků, buďto sectile, nebo interspeech, protože oba jsou v komunitě dobře známý.
Můžeme účastníky motivovat k odevzdávání.
Jediná výhrada, kterou teď zjišťuji, když se chystáme na interspeech, je to, že nám nedají prostor ve sborníku, což může odradit některý účastníky, nejsem si jistý, jak moc budou nadšeni z publikování článku v archivu.
Takže v archivu můžou lidi publikovat kdykoli, že?
Což tedy není přínosem pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
To byl důvod, proč jsem se obzvlášť přimlouval za mimořádné zasedání.
Ale tentokrát je problém v tom, že minule byla doba mezi předložením návrhů, odevzdáním a finálním odevzdáním článku pět měsíců, takže by to bylo dost času na náš plán, ale tentokrát
jsou to jenom tři měsíce.
Tenhle veletrh tedy považuji za důležitý možný zdroj nerodilé anglické řeči, kterou můžeme využít k rozšíření testovacího souboru.
Takže si myslím, že bychom se opravdu měli soustředit na soutěž Clearest voice, a pokud budeme muset, můžeme postavit stánek.
Rád bych to ale omezil, protože šíření mezi středoškoláky má pro nás menší dopad.
Důležitější je použít ji jako testovací relaci.
Měli bychom se tedy zaměřit [PERSON1] na soutěž [PROJECT2] Clearest voice a na to, aby byli organizátoři spokojeni, abychom tam mohli provádět sběr dat.
A udělat výměnou za to cokoli, co po nás budou chtít, a my musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tenhle plenární program užitečný.
takže by to pro nás byla testovací relace, a pokud jde o naši vlastní účast na tomhle veletrhu, nemyslím si, že je nějak přílišně důležitá.
Takže pokud budeme požádáni, pokud se od nás opravdu očekává, že tam budeme a účastníme se, tak dobře, ale pokud ne, tak si myslím, že je pro nás určitě dobré, abychom jenom byli za oponou a v zákulisí a dělali svou práci tam.
[PERSON1] Jo, ještě jsem se nezkoušel registrovat, ale myslím, že minule bylo povinné mít stánek.
[PERSON2] Ano. Takže s nimi proberte, co je potřeba, aby byli spokojení a umožnili nám udělat Clearest voice, což je ta nejdůležitější věc.
Testovací relace je míň naléhavá.
A stánek je něco, čemu bychom se opravdu mohli vyhnout, pokud to bude možný.
Byl bych raději, kdyby se k relacím připojili dřív, než aby dělali takový věci.
Proto je třeba tyhle přípravy opravdu nacvičit.
V online světě se zdá, že stačí naskočit do relace a práce je hotová.
To však není tenhle případ.
Zprovoznění a správný připojení trvá vždy 30 minut.
Proto tam musíme být dřív.
A pokud nějaká relace, kterou děláme, začíná v devět, tak organizátoři se sejdou ve čtvrt na devět.
Pak musíme přijít už ve čtvrt na devět, abychom měli 30 minut navíc na to ujistit se, že všechno běží, a abychom nahnali lidi.
To je tedy poznámka pro všechny, že aby vedení fungovalo, předvídejte taky prosím, co po vás může vedení náhle chtít, a to by vám mohlo trochu pomoct.
Dalším velmi důležitým sdělením je nahrávání těchhle důležitých relací.
Nevím, jestli jste reagovali, neviděl jsem, že by někdo poskytl nějaké – nějak aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli při nahrávání těchhle relací velmi špatní.
Pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, je důležitý mít k dispozici kvalitní nahrávky těchhle relací.
Jedním z aspektů je získání souhlasů, aby bylo možný nahrávání skutečně provést.
A to i v případě, že se pokusíme získat souhlasy zpětně nebo jakkoli jinak.
Pak je tu technická stránka nahrávání.
A viděli jsme, že je to velmi rozmanitý a složitý.
Jo, [PERSON5] posílá tenhle odkaz.
Vzpomínám si, že jsem ho poslal e-mailem.
2 špatné kusy v řadě :(
Objednala jsem si ho u této společnosti, protože jsem si ho koupila v předchozích sezónách a fungovalo nám skvěle.
Tuto sezónu jsem si koupila další velikost, kterou jsem potřebovala.
Jedno z pyžam, které jsem obdržela, mělo na nohavici díru.
Vrátila jsem ho a společnost mi poslala nové.
Náhradní pyžamo, které měl syn jednou na sobě, jsem dala do pračky jako vždycky a zip se odlomil!
Jsem zklamaná, protože nemám čas řešit každých pár dní vracení zboží, a přesto se přesně tohle právě teď děje.
Přesně podle popisu
Jedná se o základní prošívaný kabát.
Pokud hledáte základní kabát, pak tento kabát splní vaše očekávání.
Kabát přišel ve vakuově uzavřeném sáčku, takže je potřeba ho na několik dní pověsit, aby vyvěsilo pomačkání a trochu se „nafoukl“.
Měřím 167 cm a kabát je mi dlouhý ke kolenům.
Vzhledem k ostatním komentářům a zkušenostem z minulosti jsem si objednala o víc jak 2 velikosti větší a kabát je pravděpodobně o něco větší, než bylo potřeba.
S tlustším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou manžety, takže je pravděpodobně přidám později.
Kapuce funguje, ale nejsou na ní žádné šňůrky.
Přední zip funguje.
Na bocích ani na zádech nejsou žádné větrací otvory pro větší pohyb, ale díky větší velikosti bych měla mít dostatek místa.
U pasu mám dvě kapsy (u vás mohou být výše nebo níže).
Nemá žádné ozdobné prvky ani stylové detaily – jedná se o ZÁKLADNÍ KABÁT.
Myslím, že za tu cenu je to v pořádku.
Vzala jsem si ho na sebe ve větrném, ale ne chladném dni.
Vítr jsem necítila, takže mám pocit, že to je dobré znamení.
Jsem však zvědavá, jak se bude chovat v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem spokojená.
Vakuový sáček lze použít opakovaně a prodávající přiložil opravdu roztomilou kartičku s poděkováním, což bylo skvělé gesto.
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a jemný
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a jemný.
Nemačká se, i po nacpání do plastu a krabice byla velmi hladká, takže je opravdu super.
Dá se snadno obléknout jako ležérní i jako slavnostní a díky délce a střihu působí jako vintage, což mě na ní opravdu dostává.
Myslím, že by mohla slušet každému.
Měřím 165 cm a vážím 59 kg a objednala jsem si malou velikost, takže pokud máte pocit, že jste uvízli mezi malou a střední velikostí, určitě si velikost snižte.
Nefungoval s mým autem Buick LeSabre z roku 1999
Položka dorazila rychle a vypadala, že je v dobrém stavu, dokonce zahrnovala předinstalovanou baterii.
Přestože měl být kompatibilní s mým autem Buick LeSabre z roku 1999, dálkový ovladač se nepodařilo naprogramovat ani synchronizovat s autem.
Návod je dostatečně jednoduchý a vím, že jsem podle něj postupoval správně, protože se mi podařilo úspěšně přeprogramovat můj starý dálkový klíč.
Tento nový však nefungoval, a tak ho budu vracet.
S prodejcem nebo službou nebyl žádný problém, jen se zdá, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Mřížku chladiče mého auta utrhlo něco velkého, co letělo po mezistátní silnici, takže jsem potřeboval náhradu.
Po přečtení nějakých recenzí jsem se bál, že tohle nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Sám jsem si ji nenasadil – nechal jsem to za sebe udělat chlapíka z karosárny – ale vypadalo to opravdu jednoduše.
Za méně než 5 minut zacvakla přímo na místo.
Dal jsem jí 4 hvězdičky za robustnost, protože se zdá být docela slabá (čas a odletující suť to prověří), ale celkově jsem velmi spokojen, že moje auto už nemá na přední straně zející tlamu a že cena byla přiměřená.
Potřebuje vylepšit
Super úžasné světlo Můj pětiletý syn naprosto miloval toto světlo Netrvalo dlouho a dostal ho k narozeninám v lednu, Teď už je únor, má problémy s tlačítky a po připojení do zásuvky nesvítí jasně, žere baterie, dokonce jsem zkusil dobíjecí baterie Super cool, ale potřebuje vylepšit
Hudební začátek
Klavír je skvělý nástroj pro začátečníky!
Odhalí vnitřní umělecké schopnosti a hudební nadání vašeho dítěte.
Rozvíjí dobrou koordinaci ruky a oka.
Klavír není jen hračka na hraní, ale skutečně funguje a umožňuje dítěti hrát hudbu již od útlého věku.
Pokud chcete, aby se z vašeho dítěte stal budoucí klavírista, měli byste tento produkt vyzkoušet!
Velmi stojí za ty peníze!
Dvakrát denně si ho podle návodu nanesu na nos a 2 minuty ho vtírám.
Kůže na nose mi zčervenala a úplně ztvrdla.
Docela mě to zaskočilo.
Měl dobře zahojenou jizvu po pádu do ostnatého drátu před lety.
Nejenže tento produkt nefungoval, ale málem jsem skončil v ordinaci dermatologa, nicméně po týdnu se to konečně zklidnilo, když jsem si na místo dal mast aquaphor a náplast.
Mám však stále zarudlý nos, ale doufám, že to brzy zmizí.
Někdo pokazil recept??
To je tak divné.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslila jsem růžovou čáru pomocí tyčinky od jiné značky, abyste viděli, jak má růžová vypadat, a věděli, že to není jen mou kamerou.
Růžová je moje nejpoužívanější barva, takže mě to trochu štve.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červenou ani růžovou.
Bílá není tak jasná, jak jsem doufala.
Ostatní barvy jsou všechny skvělé a líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem si myslela, že je tam růžová.
Myslím, že fialová bude stačit.
většinou mi funguje
Před několika měsíci jsem si nechala odbarvit celou hlavu a pak jsem si ji obarvila černou krabičkovou barvou.
Pak jsem si nechala udělat melír po celé hlavě.
O několik týdnů později jsem si na vlasy nanesla modrozelenou barvu na vlasy Arctic Fox a ta mi nechtěla vyblednout.
Použila jsem tuhle věc s Olaplexem č. 3 a zesvětlila jsem ji HROZNĚ po celé hlavě, odstranila tak zelené a modré části, stejně jako tmavou krabičkovou barvu.
Po jednom dni jsem si však všimla zeleného odstínu vlasů.
Každý den je to horší a horší a už dvakrát jsem použila extraktor barev se stejným výsledkem.
Vlasy mi také tmavnou v místě, kde byla krabičková barva.
Jedná se o skvělý produkt, který se jen nezdá, že by vydržel.
nevěřte reklamnímu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba zmírnit některými realističtějšími hodnoceními.
Zkoušela jsem ji číst, ale jazyk mi přišel plochý.
metafora „sladké vody“ a četné popisy dělohy jako řeky a dítěte jako ryby mi připadaly nucené, otřepané a vykonstruované.
Přeskočila jsem dopředu a vypadá to, že se dočkám jen dramatu ze školního kampusu.
Této knize dávám 10 hvězdiček!
Vynikající čtení!!
Kniha se mi naprosto líbila!!
V průběhu let jsem od Siri adoptovala 4 siamské kočky a všechny byly naprostými miláčky.
Jakmile začnete tuto knihu číst, je těžké ji odložit.
Vtipné, duchaplné a velmi zábavné!!
Siri ve svém úsilí o záchranu koček (hlavně siamských) překračuje všechny meze!!
Opravdu se mi líbí toto kruhové světlo!
Za tu cenu je skvělé a zastane práci!
Jediným problémem je, že se žárovka příliš rychle zahřívá a světlo zhasíná, takže ho musím vypnout a chvíli počkat, než ho znovu zapnu.
Myslím, že by se to nemělo stávat... Nevím, jestli mám vadné světlo nebo co, ale kromě přehřívání je to velmi pěkné kruhové světlo.
Zmatený děj
Bylo těžké udržet tempo s knihou, protože se v ní hodně skákalo.
Také název se k příběhu nehodí.
Autor uvedl, že několik lidí bylo infikováno tímto mimozemšťanem, avšak vynechal některé podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byla zmatená a musela jsem se hodně vracet a číst znovu, abych se ujistila, že mi nic neuniklo.
Milovaná Collins...
Chvíli trvalo, než jsme si Gradyho oblíbili.
3 1/2 hvězdičky Remedy je nejlepší romantický příběh o bratrově nejlepším příteli, stejně jako romantický příběh o druhé šanci, oba smíchané do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat všechno pro to, aby Collins získal zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collins si myslela, že konečně získala všechno, o čem kdy snila, nejlepšího přítele svého bratra... ale když se druhý den ráno probudila sama a už o ní neslyšela, všechno se definitivně změnilo.
Teď je Grady zpátky a nehodlá odejít a dělá všechno pro to, aby jí dokázal, proč odešel a že se jí tentokrát nevzdá.
I když se mi líbila premisa tohoto příběhu a občas Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale že Collins ani neposlal vysvětlující dopis?
Nechávat ji celé ty roky v nejistotě a zraněnou a pak očekávat, že ho přivítá zpátky s otevřenou náručí?
To měl halušky?!
Collins měla právo být naštvaná, rozzlobená, zraněná atd.
Udělala dobře, že se s ním pohádala, když ji chtěl zpátky a chtěl jít dál.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
V této knize se mi líbila Collins, byla silná a chránila si své srdce, za což jsem ji obdivovala.
Jistěže Gradyho milovala, ale bála se a váhala, jestli ho má pustit zpátky do svého života, kdo by se nebál po tom, co jí udělal?
Její postava byla rozhodně mou nejoblíbenější z obou.
Rozhodně nechávala věci plynout tempem, jakým chtěla, a když byla připravená naslouchat, tak naslouchala.
V této knize je hodně úzkosti a já jsem si užívala, když jsem sledovala, jak se tito dva znovu sbližují, když Collins začala Gradymu odpouštět, jen bych si přála, aby Grady nebyl tak ufňukaný a byl trochu chápavější.
Pořád říkal, že to chápe, ale občas byl na mě až moc vlezlý, ale ke konci už byl milý.
Nakonec jsem si ho zamilovala stejně jako Collins, ale na začátku knihy jsem měla problém číst jeho názory, protože jsem se s jeho postavou nedokázala sžít.
První část této knihy nebyl můj oblíbený, ale on v druhé části?
Zbožňovala jsem, proto mé hodnocení.
Pokud máte rádi romantické příběhy o druhé šanci a o bratrově nejlepším příteli, tuhle knihu si opravdu užijete, jen jsem měla zpočátku těžké s Gradym a s tím, jak se vypořádal s některými věcmi, které udělal.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké poznat, že je to on.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla, bylo velmi dobře provedeno.
Komprimovaný časový rámec od 10. května do 26. května byl dobře znázorněn sedmerým překlopením lístkových hodin...
Kulisy a kostýmy byly vynikající.
Je pikantní, že dnešní dvojice polobohů zastává světové politické pozice.
Stojí za to shlédnout několikrát... stojí za to hluboce přemítat... ještě mnohokrát
Vyhněte se připojení Wi-Fi – přejděte na Bluetooth!
V říjnu 2017 jsem to koupil pro svou ženu.
V té době jsme byli uprostřed stěhování a bydleli v hotelu.
Nedařilo se mi tuto váhu připojit k hotelové Wi-Fi.
Rozhodl jsem se počkat, až se nastěhujeme k nám domů a budu si moci nastavit vlastní Wi-Fi.
Březen 2018 – nastavil jsem svou Wi-Fi a tato váha se stále nepřipojuje.
Při každém pokusu se zobrazí chybová zpráva.
I když jsem jen 10 stop od jednotky Wi-Fi.
Podle videa na YouTube jsem provedl nastavení bez úspěchu.
Když jsem si jednotku koupil, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho používá tato váha ke komunikaci s telefonem Wi-Fi router.
Tento systém je omezen na připojení k routeru... který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Kvůli Wi-Fi připojení bych tuto váhu nikomu nedoporučoval.
Místo toho se podívejte na systémy, které ke komunikaci používají Bluetooth.
Nahrazuji ji váhou, která se připojuje přes Bluetooth.
Dobré, ale chtělo by to najít něco lepšího
Po dlouhém výzkumu jsem tento produkt začal používat před mnoha lety.
Měl nejmenší množství škodlivých přísad a stále fungoval dobře.
Vysychá však tak rychle, že nakonec spotřebujete tolik lubrikantu, a to nakonec stojí hodně peněz a také to při sexu příliš ruší.
Byl jsem jen příliš líný najít nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a nestojí příliš moc.
Výdrž baterie je hrozná na tom, co jsem koupil na Amazonu.
Stále nemohu uvěřit, že společnost Logitech přestala toto dílkové ovládání nabízet, nic jiného není tomu podobné.
Absolutně MILUJI tento ovladač Harmony, toto je můj čtvrtý.
Pes rozkousal první, manžel klečel na obrazovce druhého a třetí stále fungoval, ale uprostřed dotykové obrazovky je značka loktu, také díky manželovi... ten jsem koupil jako zálohu a obrazovky jsou skvělé, ale baterie, která byla dodána, vydrží nabitá možná několik dní.
Můj původní (třetí) se stále nabíjí týdny a na všechno používám dálkové ovládání.
Rozbité za méně než týden
Produkt se mi líbí, má pěknou velikost a barvu!
Měl jsem to však jen týden, otevřel jsem jedny dveře a prasklo to v horní části dřevěného kusu!
Jsem opravdu zklamaný!
Vše je smontováno a krabici už nemám, tak jak jsem mohl vůbec přemýšlet o zaslání zpět?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale ani to bohužel nefungovalo!
Dveře zase vyskočily!!
Není příliš snadné to sestavit a navíc....
Po sestavení je to pěkně vypadající kus nábytku, ale sestavení bylo těžké.
Některá písmena byla špatně označena, takže jsem se musel pokusit přijít na to sám. Všechny šrouby, které dodali pro připevnění k podlaze a bočních panelů, praskly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také prosklené dveře jsou mimo linii a nesedí rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny z dveří zůstaly zavřené, protože magnet, který má udržet dveře zavřené, je mimo linii.
Stále jsem nepřišel na to, jak je zarovnat.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA HORNÍ ČÁSTI KAPSLE
Koupil jsem je v únoru.
Nedávno jsem je zkusil použít a bohužel pokaždé, když jeden zkusím, můj přístroj Keurig mi zobrazí chybovou zprávu, že modul není kompatibilní s mým strojem.
Od prvního nákupu používám ve svém přístroji kapsle z obchodu Lusky Donut Shop a nikdy jsem neměl problém.
Při bližším prozkoumání kávové kapsle jsem si všiml, že kód vytištěný na vrchní straně kapsle není příliš čitelný, mohu tedy jen předpokládat, že mám vadnou krabici.
Koupil jsem balení 72, což je 6 krabic po 12.
Zkusil jsem i jednu z každého z 6 krabic a stále dostávám stejnou chybovou zprávu.
Vím, že to není mým přístrojem, protože ostatní kapsle, které zkouším, fungují dobře.
Tento problém mám pouze u této zásilky.
Zklamalo mě to hodně, protože moje lhůta k vrácení už vypršela.
AKTUALIZACE: Mluvil jsem se zástupcem zákazníků, který vrací peníze.
Děkujeme společnosti AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cesty.
Takové pohodlí!
Je opravdu příjemné mít mou oblíbenou alternativu cukru zabalenou v malých jednotlivých baleních!
MILUJU odlišnosti a je tak pohodlné je mít a hodit do kabelky na schůzku nebo použít v domě přítele.
I když jsou trochu dražší, nemůžu vystát Equal nebo růžové věci v mém ledovém čaji.
Jinou variantu nebo nic, takže jsem nadšená, že mám své sladidlo na cestách!
Ve skutečnosti neprovádí žádné „čištění“ vzduchu
Koupeno jako zvlhčovač, část „čištění vzduchu“ je ve skutečnosti klamavá reklama; v závislosti na tom, jak tvrdou máte vodu, se na dně hromadí usazeniny, ale nic z toho není prachem ve vašem domově, pokud nežijete v uhelném dole nebo v něčem takovém.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač typu knotu se stejnou velikostí ventilátoru.
Výhodou je, že knoty nespotřebovává.
Vzhledem k docela vyšší ceně za jednotku ji pravděpodobně budete muset mít zapnutou asi 5 let, aby se cenový rozdíl srovnal.
Na svou velikost má poměrně velkou vodní kapacitu, protože „nádrž“ je součástí jednotky a má nízkou spotřebu (ačkoli není lepší než knot).
Čištění je také poměrně snadné, i když plastové disky nelze ve skutečnosti opravit, protože jednotku disků nejde rozebrat.
Pro německé inženýrství však není kvalita sestavení výborná.
Svůj už mám rok, což by bylo asi šest měsíců provozu v chladném počasí, a jednotka vydává velmi nepříjemný rachotivý zvuk ze sestavy ventilátoru.
Hádám, že by to mohla být ložiska ventilátoru, takže jen čekám, až tady dojde k úplnému selhání.
Jak poznamenal někdo jiný, jakékoli opravy se téměř cenově vyrovnají pouhému nákupu nového zvlhčovače typu knot.
tl; dr – nestojí to za další náklady, je lepší použít zvlhčovač typu knot.
Myslím, že by to bylo jednodušší rozbít, než si mysleli.
Tomuto produktu dávám 3 hvězdičky za to, že když jsem ho dostal, byl už uvnitř rozbitý.
Jakmile jsem to prozkoumal, uvědomil jsem si, že ať už to kdokoli dal do krabice, dal to tam rozbité. Mohlo to být buď z výroby, nebo problém mohl být v tom, že kupující zboží vrátil a tvrdil, že ho prostě nechtěl. Nebo jej nepotřeboval a Amazon možná neprovedl dostatečně dobrou kontrolu kvality, když se vrátil.
Ve vší spravedlnosti kupující nemohl říct, že je rozbitý, protože pak by jej Amazon nevzal zpět, což je dobré zejména u tohoto druhu produktu, i když jsem to právě já, kdo uvízl v něčí nedbalosti.
Své peníze jsem však dostal zpět, takže poté, co jsem o tom přemýšlel a probral to se svou manželkou, rozhodl jsem se dát tomuto kupujícímu další šanci.
S tím, co bylo řečeno, aktualizuji své hodnocení na vyšší počet hvězdiček pouze díky tomu, jak zákaznický servis zpracovává tento příspěvek (přinejmenším tím, že jej osloví) a pokud položka přijde ve skvělém stavu, má skutečně příležitost dělat to, co má dělat, a funguje tak dobře, jak se od něj očekává.
Snadná instalace?????
Celkově jsem s tímto nákupem docela spokojen, ale nebylo pro mě tak snadné provést instalaci.
Několikrát jsem zkoušel nainstalovat bez úspěchu do zapojeného vysílače oba „zvonky“.
Už jsem se chystal ho vrátit, protože nefunguje, ale řekl jsem si, že to zkusím ještě jednou a zkontroluji ve zvoncích baterie.
Voila... z krytů baterie trčely malé plastové jazýčky, za které jsem zatáhnul, až vypadly plastové kousky, které zakrývaly baterie a bránily jim v činnosti.
Po odstranění těchto plastových kousků zvonky fungovaly dobře a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v uživatelské příručce není žádná zmínka o plastové zábraně nad baterii, kterou bylo nutné odstranit, aby zvonek fungoval.
Bylo by mnohem méně frustrující, kdyby se o tom zmínili, a já si nemusel myslet, že je problém v tom, že jsem instalaci nedokončil správně.
Je to dobrý produkt se širokou řadou vyzváněcích tónů a melodií, které si můžete vybrat, a je snadné je kdykoli změnit.
Jedna věc, na kterou se ptají při hodnocení tohoto zvonku, je, jak je „odolný ve venkovních podmínkách“.
Nemohu se k tomu vyjádřit, protože jsem ho nainstaloval 5. července 2019 a asi nebudu moci komentovat, jak je odolný, až do příštího období dešťů... nejspíš v listopadu.
Ztracený balíček – Nabij si mě
Vyrůstal jsem s nimi a byl nadšený, že je koupí mému synovi, ale ztratili balíček živých housenek.
Řekli mi, že ho vymění a budou tentokrát účtovat jen poloviční poštovné.
Po značné době telefonování mi telefon skončil znovu nabitím pro novou objednávku se slevou 3 $.
Myslel jsem si, že je to dost neprofesionální, protože to nejen ztratili, ale navíc mě vedli k přesvědčení, že to napraví, jen aby mi na konci 30minutového telefonátu ohledně nějaké hádky o voucheru naúčtovali téměř plnou cenu.
Strávil jsem 30 minut na telefonu, takže jsem ustoupil a koupil si další sadu housenek.
To je putna.
Po bolestech hlavy funguje dobře.
Byli nějaké problémy, aby fungoval správně.
Dodaný kabel nebyl dobrý – nenabíjel baterii.
Když jsem vyměnil kabel za vlastní, podařilo se mi nabít zařízení a poté jej připojit přes Bluetooth k PC.
Měl problém najít PC software, ale když jsem poslal e-mail jejich podpoře, odpověděli do jednoho dne se správnými informacemi o stažení.
K testování jednotky funguje PC program dobře poté, co zjistíte, který port použít (v mém případě port 4).
Přesnost a stabilita jednotky vypadá pro mou aplikaci velmi dobře, nemohl jsem se však připojit k iPhonu ani iPadu (vyzkoušel jsem jich několik od každého) přes Bluetooth.
Pokud se rozhodnu použít toto zařízení ve svém produktu, budu ho muset připojit přes drát.
... byl před nákupem příliš žlutý a řekli ji, že je jak starožitné zlato
Před nákupem jsem se zeptala prodejce, zda není barva příliš žlutá, a řekli mi, že je jak starožitné zlato, tmavší.
Moc se netrefili!
Sada vypadá VELMI levně.
Je super lesklá žlutá se spoustou CZ, ještě lesklejších.
Na fotce vypadá skvěle, ale ve skutečnosti bych to nenechala nosit ani teenagerovi.
Prsten se mi líbil – ale nemohla jsem ho nosit pořád! :(
Tento prsten byl krásný.
Moc se mi líbil design a robustní pocit; vypadal jako drahý a byl velmi pohodlný!
Jediný důvod, proč jsem dala pouze 3 hvězdičky a nakonec produkt vrátila, je ten, že jsem si uvědomila, že ho nebudu moci nosit pořád.
Ráda nosím své prsteny pořád, a proto se vždy postarám o to, abych si pořídila mincovní stříbro, a vím, že někteří lidé říkali, že jim prsteny po chvíli ztratili lesk, ale já jsem ten svůj nosila asi týden v kuse – dokonce i při mytí rukou – a nevšimla jsem si žádné ztráty lesku.
Docela zajímavé je, že problém, který jsem měla, byl ten, že vnitřní strana kruhu prstenu ve skutečnosti způsobila, že mi prst zbělel a zvlhl – podobně jak to dělá náplast, když si ji necháte na sobě dlouho.
To se tak stalo, i když jsem se ujistila, že byl prsten i můj prst úplně suchý.
Nevím, proč se to stalo a nikdy se mi to nestalo u žádného jiného prstenu, ale začalo mi to být nepříjemné, tak jsem se rozhodla, že to nebude prsten pro mě.
:( Škoda, protože se mi opravdu líbil!
Takže pokud si chcete tento prsten koupit s úmyslem ho nosit jen občas, říkám jděte do toho!!
Nezklame vás!
kupte si Pampered Chef...
Vlastním malou naběračku Pampered Chef, ale jsem mezi bydlištěm, takže většina mých „věcí“ je ve skladu.
Ráda používám tyto naběračky při pečení pro dokonale naporcované cukroví.
Podívala jsem se na naběračku OXO a naběračku Pampered Chef a rozhodla jsem se ušetřit nějaké peníze a pořídit si OXO – obvykle mám na jejich produkty štěstí.
Pro tento to neplatí.
Kolem sušenky č. 30 s arašídovým máslem přestala fungovat páčka uvnitř naběračky.
Musel jsem oddělit úchopy a přemístit páčku, abych jich mohl udělat ještě pár, a pak toto opakovat.
Takže... zachovejte si zdravý rozum a kupte si naběračku Pampered Chef.
Rozhodně to stojí za to!
Už si Mr. Coffee znovu nekoupím
Na chvíli to byl dobrý kávovar, ale vždy s ním byly problémy.
Pokud se mezi černý plast a kov na nádržce dostane voda, prosakuje a propouští vodu celé dny.
Pak se nám zlomila plastová páka, která umožňuje, aby káva protekla přes filtr a do nádržky.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali mě pouze na servis, který je více než 90 minut od mého domu.
Je skvělý na přípravu a udržování horké kávy, ale je s ní příliš mnoho dalších problémů, než abychom do ní za současnou cenu investovali.
Musíte to koupit!!
Milovala jsem tuto barvu růžového zlata a všechno na ní bylo skvělé!
Jedinou věcí, s kterou jsem měla problém, bylo, že byla opravdu prostá.
Líbí se mi mít trochu více detailů na pákách a všimla jsem si jich už předtím, než jsem si to koupila, proto stále dávám 5 hvězdiček!
Snadno se čistilo a vše přišlo zabalené po jednotlivých částech, což jsem zjistil, že je opravdu uspořádané a uklidnilo to mou duši heh miluji, miluji, MILUJI tu barvu a určitě bych to koupila znovu pro sebe nebo pro někoho blízkého!
Mohl by být dobrý na tyči, ale NE jako závěsná přepážka nebo štít proti počasí.
Hanba Audubonovi.
Pokyny vám říkají, abyste zatlačili zástrčku nahoru otvorem v přepážce a „Ujistěte se, že je bezpečně na svém místě.“
JAK???
Je navržena tak, aby přepážka jednoduše seděla volně na zástrčce, takže ji může vytlačit nahoru jakýkoli tvor nebo sebemenší vítr.
Můžete otočit zástrčku vzhůru nohama, aby byly křídlové šrouby na spodní straně přepážky, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to neudělá a snadno to zvládnou jen ty nejmenší prsty.
Trvalo mi přes hodinu, než jsem tu dřínu zvládl a zašrouboval je, abych zajistil přepážku k zástrčce.
Je to kompletní PITA.
Objednal jsem čtyři takové; ty tři, které jsem neotevřel, jdou rovnou zpátky a já hledám na webu lepší ochranu proti počasí.
(Nic si nenamlouvejme, neexistuje nic takového, co by ve skutečnosti veverky „zmátlo“!)
Líbí se mi mnoho funkcí těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které moje nové sazenice zeleniny dostávaly z okna.
Líbí se mi mnoho funkcí těchto světel.
Výhody: Za prvé se snadno upnou na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny přitom, jak moje rostliny rostou.
Světla jsou chladná na dotek a neškodí ani při dotyku rostlin.
Věřím, že mé zelenině světla prospěla.
Světla jsou stmívatelná, ale používám jen nejsilnější nastavení.
Nepoužil jsem časovač, raději je zapínám a vypínám sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo když jste na dovolené. Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby mohla být primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až světla vyhoří, budu muset koupit celou novou jednotku.
POZOR... ZÁPACH JE VELMI HROZNÝ... OTVOR NA KARTY JE PŘÍLIŠ VELKÝ!
Když jsem to viděl poprvé, myslel jsem si, že je to krásné, ALE bylo to cítit TAK HROZNĚ.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že jde o zápach PLÍSNĚ.
Nikdy nezmizel, takže jsem to musel vrátit.
Navíc jsou otvory na kreditní karty příliš velké.
Kreditní karty se zasunou úplně dolů, rohy se nezobrazují, takže nemáte ponětí, která karta je kde a je velmi obtížné je vysunout.
FOTOGRAFIE, KDE JSOU VIDĚT KARTY, NENÍ PŘESNÁ.
Je to velmi malé...
Obdržel jsem cestovní pás na peníze a je mnohem menší, než ukazují obrázky.
Kéž bych to nekoupil a stejně budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Nejprve musím říct, že barva je nádhernááá.
Spousta věcí, které si objednávám ve fialové, mi vždycky přijde moc světlá, moc dětská, moc divná, moc neonová, co máš.
Ale tato fialová byla výrazná a svěží a moc se mi líbí, deštník je pevný a opravdu kvalitní.
Pravděpodobně nejlepší deštník, který jsem měl.
Dodává se s obalem, a i když nemusí být moc funkční, opravdu si zachovává ostrý vzhled.
Balení je hrozné – došly 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že společnost neví, jak svůj produkt chránit.
Nezkoušejte ani získat takovou, která není poškozená.
Dvě jsme vrátili kvůli poškození při přepravě a třetí byla také poškozena.
Vzdal jsem to.
Dodávají je v měkkém tenkém balíku s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné vycpávky.
Skvělý koncept!
Potřebuje jen další vylepšení, aby to byl opravdu úžasný produkt
Opravdu skvělý koncept pro karaoke.
Mám rád karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý – růžové zlato je příjemné na dotek.
Jedná se také o standardní design, který jsem viděl u všech ostatních variant souvisejících s tímto typem mikrofonu.
Pro nezasvěcené to funguje tak, že současně funguje jako 1) osobní mikrofon, 2) hudební streamer/reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesílí vaše hlasy a hudbu a zaznamená vše, co vyjde.
V samotném mikrofonu však není žádná hudba.
Má Bluetooth konektor, takže jej sesynchronizujete s telefonem a stáhnete si aplikaci karaoke, která může posílat skladby karaoke do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon se dodává s různými možnostmi k nastavení úrovně hlasitosti hudby i vašeho hlasu (také samostatně!)
a dokonce má možnost upravit úroveň ozvěny, abyste zněli jako ve skutečné místnosti pro karaoke.
Některé věci, které bych rád u dalšího vylepšení viděl, jsou tyto: 1) je tam nějaká otravná zpětná vazba, která nevypadá, že by zmizela bez ohledu na to, jak daleko je telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem příznivcem minimalismu, takže by bylo skvělé, kdyby mohl být design elegantnější díky budoucím produktům.
3) podpora více aplikací karaoke. Konečně, protože zvuk vychází přímo z tohoto mikrofonu a ne přes plochou obrazovku nebo centrální reproduktorový systém v obývacím pokoji, není to tak zábavné jak na párty.
Pokud to výrobce dokáže nějak začlenit do většího ekosystému party karaoke, bude to nekonečně příjemné.
Odtrženo od Vision Supplies
Říjen 2017 zakoupeny čtyři (4) kazety od Vision Supplies – Amazon Marketplace, takže jsem je měl, až je budu potřebovat a abych ušetřil za dopravu.
Používány dva za posledních několik let, asi jeden za rok, a fungovaly dobře.
Minulý týden jsem zkusil jeden, po vytištění 20 štítků byl téměř prázdný, ale minulý došel po 40 stranách.
U obou chybí plast.
Uvedená záruka skončila!!!!
Kdo by chtěl při doručení kontrolovat každou jednotlivou kazetu????
KUPUJÍCÍ POZOR!!!!!!!!!!
Omlouvám se, co?
Moje kamarádka mi doporučila masku této řady, tak jsem si koupila tuto, tento kondicionér, a vše v jednom mléce.
Nemohu mluvit o účinnosti produktu, protože zápach byl prostě nesnesitelný.
Víte, že zatuchlý zápach ve starých budovách se používá na ženských toaletách, aby se pokusil zamaskovat vůni *dám*, ale ukázalo se, že je to něco jako kyselý a chemický zápach zatuchlé babičky?
Jo, to vše mě napadne, když to cítím.
Znáte různé tahy různých lidí, takže možná se vám bude vůně líbit.
Můj kamarád řekl, že to může pomoci i těm nejpoškozenějším vlasům, pokud vám tedy nezáleží na vůni či zápachu, není čeho se bát.
Vím, že přírodní produkty nebudou vonět tak krásně jako některé syntetické, ale řekl bych, že čím dál víc přírodních řad se o toto méně stará, protože se stejně prodají, a tak teď všechno voní jen jako těsto.
Ztratil jsem kvůli nim několik oblíbených řad, které změnily přísady ve vzorci na levnější.
Nevím, jestli je to tento případ nebo jestli je to padělek (což jsem volal na Davines a oni řekli, že není), ale tohle zavání sračkou a já jsem to musel vrátit.
Vypadává internet
Tento modem/router jsem koupil asi před dvěma roky.
Ze začátku to vypadalo, že je v pořádku, ale poslední rok jsem měl problémy s tím, že vypadával internet.
To se děje ve všech mých zařízeních s Wi-Fi i kabelovým internetem.
Jediný způsob, jak obnovit službu, bylo provést reset napájení.
To se stávalo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku ze základny do domu a zesílil tak úroveň signálu.
Stejný problém.
Kluci z Arris Techu byli výborní, ale nedokázali ten problém vyřešit.
Navíc se třikrát vypnula služba 5G.
Musel jsem provést tovární reset, abych ji obnovil.
Na základě těchto mých zkušeností nemohu tento modem/router doporučit.
Koupil jsem modem/router Netgear AC1900.
Je fantastický.
Měl jsem ho něco přes týden bez problémů.
Je rychlejší a jeho dosah je větší než Arris.
Na internetu jsem četl, že někteří lidé měli problémy s modemem/routerem Arris připojeným ke Comcastu.
Pokud máte internet Comcast, tento modem/router Arris nedoporučuji.
Pořiďte si Netgear, je mnohem spolehlivější.
ale stává se to docela často na to, aby to bylo nepříjemné.
V pozitivním duchu
1 z fanoušků zněl z krabice nevyváženě.
Ovládání rychlosti je opravdu podivné – Pokud ji nastavíte na 100 %, ventilátory se vypnou, takže je musíte přepnout na 100 % a poté je pomalu otáčet zpět, dokud se znovu nezapnou.
Kvalita sestavení je průměrná, ale vypadá to, že v této cenové hladině odpovídá většině těchto typů produktů.
Nožičky držící notebook, když je nakloněný, se několikrát podlomily...
Vrátí se dovnitř, ale stává se to dost často a je to nepříjemné.
Pozitivní je, že je ventilátor umístěn ideálně u notebooků, které nasávají vzduch z otvorů umístěných v horní části.
Mnoho dalších chladičů má ventilátory umístěné uprostřed a poskytují velmi malý proud vzduchu navíc v notebooku s takovou konfigurací chlazení.
Dobrý případ s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný – max. 3,5 nebo 4.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně pouzder.
Z těch všech je Gumdrop nejspíš nejlepší, ale má několik vážných problémů.
Guma pouzdra (silikonová či co) je velmi hladká a kluzká a při držení tabletu jednou rukou nebudete mít moc jistotu.
Tab A je těžký, takže když při sledování videa ležíte, pouzdro vám klouže v ruce, takže si ho musíte často posunovat.
Musel jsem odstranit průhledný plastový kryt, který je přes obrazovku, protože zhoršoval funkci dotykové obrazovky.
Tím se ovlivnila pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a tenký.
Nakonec ztížili přístup k peru S.
Pero S je v zadním pravém dolním rohu Tab A a u něj vytvořili malý gumový záhyb, který chrání roh směrem dozadu kvůli přístupu k peru S.
To znamená, že aby bylo možné pero S vysunout, musí se záhyb vyklopit o 180 stupňů.
To je opravdu nepohodlné a těžko se to dělá jednou rukou.
Můj Tab A toto pouzdro dobře chrání, ale s těmito vážnými konstrukčními nedostatky jej nemohu doporučit, ledaže byste měli pero S, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu elegantní – nakupování na jednom místě pro všechny mé potřeby v oblasti připojení.
Má rád, když to jen hodím do tašky spolu s mým malým napájecím adaptérem pro notebook a jsem připraven pracovat na velkém 4K displeji nebo pořizovat fotografie z mého fotoaparátu.
Jediná divná věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích usb-c, které jsem zkoušel od různých značek), je, že počítače mac očividně nedokážou rozeznat rozdíl mezi násobky stejného monitoru (takže můj mac zobrazuje stejné video na všech identických monitorech připojených k rozbočovači, ať už přes HDMI nebo VGA).
Ale pokud použiji dva samostatné rozbočovače/adaptéry nebo dva různé modely monitoru, pak mac správně na jednotlivých displejích zobrazuje video.
Ok, chce to nějaké vylepšení.
Slušný tréninkový nástroj, ale potřebuje opravdu nějaký bezpečnostní zámek přes tlačítko šoku (stisklo se mi vícekrát náhodně, když jsem ho měl v kapse, než jsem ho měl ve skutečnosti v úmyslu použít) moji psi dokonce sebou trhli poté, co šlápli na dálkové ovládání.
Také pokud se váš pes rád válí v mývalích lejnech jako můj, umývat ho je jak mít osinu v zadku.
Když se fekální hmota dostane mezi praskliny v zařízení, budete muset celou věc rozebrat, abyste zařízení pořádně vyčistili a zbavili se zápachu.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že potřebujete téměř přímý dohled na to, aby to fungovalo.
A chvílemi to nefungovalo vůbec, i když jsem byl jen 30 stop od svého psa.
Možnost dobíjení je určitě příjemná funkce a nabitý stav vydrží docela dlouho.
Ten svůj potřebuji nabíjet jen jednou za dva týdny.
Za co zaplatíte, to dostanete.
Otřesný produkt, překroucené údaje
Koupil jsem to jako sledovač, abych ho používal při plavání, a ani jsem neměl šanci to vyzkoušet.
Za prvé, není voděodolný a podle pokynů v příručce se při plavání nedoporučuje používat.
Za druhé, nedodává se s nabíječkou.
Místo toho se doporučuje použít USB zásuvku nebo počítač.
Fajn, takových máme kolem sebe hodně.
Když se ho však pokusím dostat do portu, abych ho nabil, spustí se a zmizí.
Nejsem si jistý, jestli je něco nekompatibilní nebo jestli je to jen špatný výrobek, ale nebudu sedět a držet své zařízení, zatímco se bude nabíjet.
A konečně, aplikace neustále zobrazuje reklamy, i když je zavřena.
Reklamy se zobrazily, když jsem posílal text, a to mě hodně znepokojilo.
Poté jsem zavřel všechny aktivní aplikace v telefonu, a když jsem šel zkontrolovat čas o 20 minut později, uviděl jsem další reklamu.
Hrozný produkt, asi dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přehnaný na popruzích
Tento batoh vypadá dobře a funguje dobře.
Je to dobrý obchod, zvláště když ho porovnáte s tím, co dnes stojí batohy.
Důvod, proč jsem ubral jednu hvězdu, je ten, že je tam prostě příliš moc popruhů.
Na tomto batohu je více popruhů, než dokážu spočítat.
Tyto přebytečné popruhy nakonec odstřihnu a spálím, protože většina z nich není ve skutečnosti potřeba a jen při otevírání a zavírání tašky překážejí.
Kromě toho jsem si z něj udělal novou školní tašku na vysokou školu.
Přímo v zadní části batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se dobře vejdou do jeho kapes.
Vlajka je také skvělým zakončením
Můj pes ho ještě nezničil
Měli jste problémy s hokejovými míčky.
Moje fenka je miluje – její oblíbená aportovací a žvýkací hračka – a plavou.
Tedy dokud je nerozkousá na kousky.
Vyzkoušel jsem jich několik, dokonce i verze do „velmi teplého počasí“ – a ty vydržely o pár minut déle než ostatní.
Dokud se neobjevily tyto.
Tyto obstály ve zkoušce.
Moje fenka není velká, ale je tvrdohlavá v tom, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký boj je v psovi.
Palec nahoru od Daisy a mě.
Tento výrobek je pro děti nebezpečný.
To je pro vaše dítě velké zdravotní riziko.
Po několika týdnech používání jsme zkontrolovali baterie a zjistili jsme, že voda vnikla do prostoru, kam se baterie vkládají.
Samotné baterie se pokazily a vytékala z nich černá tekutina.
Když se podíváte na design, vypadá to, že kryt baterie nemůže být vodotěsný, což znamená, že nejenom, že se do přihrádky dostala voda během koupání, ale také z něj vytekl nějaký toxický materiál.
Nekupujte prosím tento produkt.
To mě teda šokovalo, že i přes tak zjevnou chybu se to dostalo na trh.
problémy s přehříváním a problémy s připojením ovladače
Zatím mu dávám 3 hvězdičky, nechci prodejci dát špatnou recenzi, pokud si to nezaslouží, ale tento dron se dost přehřívá.
Nejsem si jistý, jestli mám kontaktovat prodejce nebo samotnou dji tello, ale pravděpodobně zkusím obojí, jen abych viděl, co na to řeknou.
Líbí se mi, že je dron skvělá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů mi připadají spíš jako hračka než tento.
Je to však jediný dron, se kterým jsem měl problémy s přehříváním, a ve skutečnosti mi létání ubírá na zábavě. Prozatím budu předpokládat, že jde o výrobní vadu, kterou musí co nejdříve vyřešit, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal již používaný dron, když jsem zaplatil za nový.
Prodejci předám vrtule k doručení tak, jak chodí 1 den po nákupu.
Po zkontaktování prodejce a dji tello zaktualizuji datum své recenze.
K této sadě dárkových tašek mohu říci jen dobré věci
K této sadě dárkových tašek mohu říci jen dobré věci.
Všechny své vánoční dárky jsem mohl zabalit do tašek, dárkových obalů a hedvábného papíru.
Produkt je velmi kvalitní a různé velikosti usnadňují ten nejlepší výběr pro každý dárek!
Velmi to doporučuji.
Prodejce je naprosto milý a pozorný.
Po nákupu mě oslovil, aby se ujistil, zda jsem se svým produktem spokojen.
5 hvězdiček s přehledem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic nenadělají
Nekupujte si tuto hru, fyzika je příšerná a tato hra mě štve, protože si myslím, že existuje 40 hackerů na každou jednotlivou hru, ale i na celou hru.
Ani s tím nic nedělají, víte, že prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a ve hře se neustále aktualizují jejich postavy, by opravdu měli aktualizovat spíš fyziku, protože je strašná, nekupujte tuto hru, fyzika je strašná a mechanika je také tak strašná, že lidé, kteří tuto hru postavili, byli očividně vysocí nebo tak něco, protože je to jedna z nejhorších her, kterou jsem upřímně kdy v životě hrál, radši bych hrál Pixel Games, v tomhle svinstvu je to jedna z nejhorších her, nekupuji
Ne jako u jiných tomb raider her
Od samého začátku jsem se tak necítil jako u jiných tomb raider her.
Hratelnost je brutální v tom, že ovládání není chytré, aby vědělo, jakým směrem se chcete vydat.
Nechá vás zemřít těmi nejzbytečnějšími způsoby.
Hádanky jsou těžké, ale ne ve své logice.
Tato hra mě nebavila.
Nemám v plánu ji dokončit.
Příběh také není výrazný, a to je hlavní důvod, proč hrávám hry.
Ergonomický a cenově dostupný, ale nepříliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, na které by se dalo napíchnout, a díky napájecímu kabelu trvale připojenému je mnohem méně náchylný k poškození než originální ovladač XB1.
Nevýhodami jsou: 1) Vibrační efekt, který se spouští při akčním hraní, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžkopádný a většinou opotřebujeme 2–3 ovladače za rok.
Pro nás tedy každoroční investice do ovladačů znamená, že si musíme vybírat a být obezřetní při nákupu.
Ovladač si vystačil s odolnějšími pružinkami; po několika měsících přestanou nejvíce používaná tlačítka reagovat a pravý joystick ztratí vystředění, IE- přiblíží obrazovku mapy a postavy se pohybují vpřed, aniž bych se vůbec dotknul ovladače.
Za co zaplatíte, to dostanete
Zklamalo mě to, když jsem dostal tuto položku, protože stříbrná část, která prochází kolem obličeje, se zdála být vyrobena z nějakého levného plastu.
Nezklamalo mě ani to, že se jednalo o plast, ale to, že použitý plast působil neuvěřitelně levně.
Mně tento detail pokazil celý vzhled.
Také jsem nevěřil, že vydrží každodenní nošení, takže jsem ho nakonec vrátil.
Zklamalo mě to, protože se zdálo, že to mohl být dobrý obchod, kdyby tomu tak nebylo.
Pokud jste schopni to však přehlédnout, může to být pro vás to pravé.
Bylo dobře zabalené a dorazilo to rychle.
Nic jako předchozí telefony Stylo, VELKÉ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Telefony Stylo se mi očividně opravdu líbily, taky pokaždé, když vyšel nový, jsem si ho koupil.
Nikdy to nebylo proto, že by měl některý problémy nebo se porouchal, bylo to jen proto, že jsem chtěl vždy mít aktuální verzi, a to jsme i dělal
Ze všech těchto telefonů jsem ani jednou neměl problém se samotným telefonem.
Když jsem koupil Stylo 3 přes Virgin Mobile, věděl jsem, že vše půjde hladce, jakmile telefon dostanu a nastavím, ale velmi jsem se mýlil, že jsem toto předpokládal.
Tento telefon měl tak tolik problémů, že mě upřímně šokovalo, jak byly předchozí telefony Stylo tak úžasné.
Nikdy se mi ani nepodařilo tento telefon úspěšně převést na můj účet Virgin Mobile.
S tímto telefonem jsem se hrál o něco méně než týden.
Hledal jsem informace na internetu a telefonoval, zoufale jsem se snažil Stylo 3 zvýhodnit před pochybnostmi a doufal jsem, že to jen mnou, ale bohužel jsem tím ztratil spoustu času, protože to byl na 100 % telefon, který měl všechny ty problémy, které jsem si nechtěl připustit.
Nenávidím, že musím dát Stylo tak hrozné hodnocení a recenzi, ale tento telefon mě děsně zklamal.
Doufejme, že LG svou hru vylepší a vylepší i budoucí telefony Stylo, pokud nějaké další budou, ale toto byl obrovský NEÚSPĚCH.
Vrácení zboží a peněz proběhlo hladce, a to je ta lepší stránka.
