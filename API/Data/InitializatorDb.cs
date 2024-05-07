using API.Entitati;

namespace API.Data
{
    public static class InitializatorDb
    {
        public static void Initializare(MagazinContext context)
        {
            if(context.Produs.Any()) return;

            var produs = new List<Produs>
            {
             new Produs


{   Nume = "Placa Angular Speedster 2000",
    Descriere = "Placa Angular Speedster 2000 este un echipament de vârf pentru entuziaștii Angular, proiectat pentru performanțe maxime. Cu o construcție solidă și tehnologie avansată, această placă este perfectă pentru proiectele Angular care necesită viteză și agilitate. Indiferent dacă sunteți un începător sau un profesionist experimentat, Placa Angular Speedster 2000 vă va oferi o experiență de neegalat în dezvoltarea aplicațiilor Angular.",
    Pret = 20000,
    AdresaUrlImagini = "/images/products/sb-ang1.png",
    Brend = "Angular",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Placa Angular Verde 3000",
    Descriere = "Placa Angular Verde 3000 este o opțiune versatilă și puternică pentru proiectele Angular. Cu o estetică vibrantă și tehnologie avansată, această placă vă permite să explorați toate aspectele fascinante ale dezvoltării aplicațiilor web Angular. Cu o construcție solidă și performanțe fiabile, Placa Angular Verde 3000 este alegerea perfectă pentru cei care caută să creeze aplicații web dinamice și interactive. Indiferent dacă sunteți un începător curios sau un dezvoltator experimentat, această placă vă va îmbunătăți cu siguranță procesul de dezvoltare Angular.",
    Pret = 15000,
    AdresaUrlImagini = "/images/products/sb-ang2.png",
    Brend = "Angular",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Placa de bază Core Speed Rush 3",
    Descriere = "Placa de bază Core Speed Rush 3 este inima sistemului tău de dezvoltare. Cu o combinație perfectă între viteză și stabilitate, această placă îți oferă performanțe de neegalat pentru proiectele tale. Cu tehnologii avansate și o construcție robustă, Core Speed Rush 3 este partenerul ideal pentru orice dezvoltator în căutarea unor soluții rapide și fiabile. Indiferent dacă lucrezi la aplicații web complexe sau la proiecte de infrastructură, această placă îți va oferi puterea și flexibilitatea de care ai nevoie pentru a-ți transforma viziunea în realitate.",
    Pret = 18000,
    AdresaUrlImagini = "/images/products/sb-core1.png",
    Brend = "NetCore",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Placa de bază Net Core Super",
    Descriere = "Placa de bază Net Core Super este o alegere excelentă pentru proiectele de dezvoltare. Cu o performanță excepțională și o stabilitate remarcabilă, această placă este esențială pentru cei care caută să creeze aplicații robuste și scalabile. Indiferent dacă sunteți un începător sau un veteran în domeniul dezvoltării software, Placa de bază Net Core Super vă va oferi instrumentele de care aveți nevoie pentru a vă atinge obiectivele de dezvoltare.",
    Pret = 30000,
    AdresaUrlImagini = "/images/products/sb-core2.png",
    Brend = "NetCore",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Placa React Super Whizzy Fast",
    Descriere = "Placa React Super Whizzy Fast este alegerea perfectă pentru dezvoltatorii care doresc să creeze aplicații web rapide și reactiv. Cu o performanță excepțională și o interfață de utilizator plăcută, această placă este ideală pentru proiectele care necesită o reactivitate sporită și o experiență de utilizare fluidă. Indiferent dacă lucrați la proiecte personale sau la aplicații de întreprindere, Placa React Super Whizzy Fast vă va oferi instrumentele de care aveți nevoie pentru a realiza aplicații web de înaltă calitate.",
    Pret = 25000,
    AdresaUrlImagini = "/images/products/sb-react1.png",
    Brend = "React",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Placa TypeScript Entry",
    Descriere = "Placa TypeScript Entry este un instrument esențial pentru dezvoltatorii care lucrează cu TypeScript. Cu o performanță fiabilă și un set extins de funcționalități, această placă vă permite să creați aplicații complexe și scalabile folosind TypeScript. Indiferent dacă sunteți un începător sau un expert în TypeScript, Placa TypeScript Entry vă va ajuta să vă atingeți obiectivele de dezvoltare cu ușurință și eficiență.",
    Pret = 12000,
    AdresaUrlImagini = "/images/products/sb-ts1.png",
    Brend = "TypeScript",
    Tip = "Placi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Caciula Core Albastra",
    Descriere = "Căciula Core Albastră este o alegere excelentă pentru cei care doresc să rămână confortabili și protejați în timpul sesiunilor lungi de programare. Cu un design simplu și elegant, această căciulă este potrivită pentru orice ocazie, de la codare la plimbări în aer liber. Indiferent dacă lucrați de acasă sau la birou, Căciula Core Albastră vă va oferi confortul și stilul de care aveți nevoie pentru a vă bucura de fiecare moment.",
    Pret = 1000,
    AdresaUrlImagini = "/images/products/hat-core1.png",
    Brend = "NetCore",
    Tip = "Caciuli",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Caciula React Verde de Lana",
    Descriere = "Căciula React Verde de Lână este alegerea perfectă pentru iubitorii de React care doresc să rămână calzi și confortabili în timpul iernii. Fabricată din lână de înaltă calitate și cu un design atrăgător, această căciulă este ideală pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în parc, Căciula React Verde de Lână vă va menține confortabil și la modă în orice situație.",
    Pret = 8000,
    AdresaUrlImagini = "/images/products/hat-react1.png",
    Brend = "React",
    Tip = "Caciuli",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Caciula React Purpurie de Lana",
    Descriere = "Căciula React Purpurie de Lână este alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design plin de farmec și o textură moale și plăcută, această căciulă este ideală pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Căciula React Purpurie de Lână vă va menține confortabil și la modă în orice situație.",
    Pret = 1500,
    AdresaUrlImagini = "/images/products/hat-react2.png",
    Brend = "React",
    Tip = "Caciuli",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Manusi Code Albastre",
    Descriere = "Mănușile Code Albastre sunt partenerul perfect pentru dezvoltatorii care doresc să lucreze în confort și stil. Cu un design ergonomic și o calitate superioară a materialelor, aceste mănuși vă vor oferi confortul și protecția de care aveți nevoie în timpul sesiunilor lungi de tastare. Indiferent dacă lucrați de acasă sau la birou, Mănușile Code Albastre vă vor menține mâinile calde și protejate în timpul activităților de programare.",
    Pret = 1800,
    AdresaUrlImagini = "/images/products/glove-code1.png",
    Brend = "VS Code",
    Tip = "Manusi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Manusi Code Verzi",
    Descriere = "Mănușile Code Verzi sunt partenerul perfect pentru dezvoltatorii care doresc să aducă o notă de culoare în rutina lor de programare. Fabricate din materiale de înaltă calitate și cu un design ergonomic, aceste mănuși oferă confortul și protecția necesare în timpul sesiunilor lungi de tastare. Indiferent dacă sunteți la birou sau lucrați de acasă, Mănușile Code Verzi vă vor menține mâinile calde și protejate în orice situație.",
    Pret = 1500,
    AdresaUrlImagini = "/images/products/glove-code2.png",
    Brend = "VS Code",
    Tip = "Manusi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Manusi React Purpurii",
    Descriere = "Mănușile React Purpurii sunt alegerea perfectă pentru dezvoltatorii care doresc să rămână calzi și protejați în timpul sesiunilor lungi de programare. Fabricate din materiale de înaltă calitate și cu un design atractiv, aceste mănuși oferă confortul și stilul de care aveți nevoie în timpul activităților de codare. Indiferent dacă lucrați la proiecte personale sau profesionale, Mănușile React Purpurii vă vor menține mâinile calde și protejate în orice situație.",
    Pret = 1600,
    AdresaUrlImagini = "/images/products/glove-react1.png",
    Brend = "React",
    Tip = "Manusi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Manusi React Verzi",
    Descriere = "Mănușile React Verzi sunt alegerea perfectă pentru dezvoltatorii care doresc să aducă o notă de prospețime și vitalitate în activitățile lor de programare. Cu un design ergonomic și o calitate superioară a materialelor, aceste mănuși oferă confortul și protecția necesare în timpul sesiunilor lungi de tastare. Indiferent dacă lucrați la proiecte personale sau profesionale, Mănușile React Verzi vă vor menține mâinile calde și protejate în orice situație.",
    Pret = 1400,
    AdresaUrlImagini = "/images/products/glove-react2.png",
    Brend = "React",
    Tip = "Manusi",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Cizme Redis Rosii",
    Descriere = "Cizmele Redis Roșii sunt alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design plin de farmec și o calitate superioară a materialelor, aceste cizme sunt ideale pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Cizmele Redis Roșii vă vor menține confortabil și la modă în orice situație.",
    Pret = 25000,
    AdresaUrlImagini = "/images/products/boot-redis1.png",
    Brend = "Redis",
    Tip = "Cizme",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Cizme Core Rosii",
    Descriere = "Cizmele Core Roșii sunt alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design modern și o calitate superioară a materialelor, aceste cizme sunt ideale pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Cizmele Core Roșii vă vor menține confortabil și la modă în orice situație.",
    Pret = 18999,
    AdresaUrlImagini = "/images/products/boot-core2.png",
    Brend = "NetCore",
    Tip = "Cizme",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Cizme Core Purpurii",
    Descriere = "Cizmele Core Purpurii sunt alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design modern și o calitate superioară a materialelor, aceste cizme sunt ideale pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Cizmele Core Purpurii vă vor menține confortabil și la modă în orice situație.",
    Pret = 19999,
    AdresaUrlImagini = "/images/products/boot-core1.png",
    Brend = "NetCore",
    Tip = "Cizme",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Cizme Angular Purpurii",
    Descriere = "Cizmele Angular Purpurii sunt alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design modern și o calitate superioară a materialelor, aceste cizme sunt ideale pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Cizmele Angular Purpurii vă vor menține confortabil și la modă în orice situație.",
    Pret = 15000,
    AdresaUrlImagini = "/images/products/boot-ang2.png",
    Brend = "Angular",
    Tip = "Cizme",
    CantitateStoc = 100
},
new Produs
{
    Nume = "Cizme Angular Albastre",
    Descriere = "Cizmele Angular Albastre sunt alegerea perfectă pentru cei care doresc să aducă o notă de culoare și stil în garderoba lor de iarnă. Cu un design modern și o calitate superioară a materialelor, aceste cizme sunt ideale pentru zilele reci și ploioase. Indiferent dacă mergeți la birou sau faceți plimbări în oraș, Cizmele Angular Albastre vă vor menține confortabil și la modă în orice situație.",
    Pret = 18000,
    AdresaUrlImagini = "/images/products/boot-ang1.png",
    Brend = "Angular",
    Tip = "Cizme",
    CantitateStoc = 100
}
            };

            foreach(var produsList in produs)
            {
                context.Produs.Add(produsList);
            }
            context.SaveChanges();
        }
    }
}