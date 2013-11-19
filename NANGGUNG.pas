{=====================================================}
Program Laundry;
{=====================================================}
Uses Crt;
Type
   Data = Record
       Nama    : String[25];
       Alamat  : String [50];
       Tanggal : String [11];
       Laundry : integer;
       Harga   : integer;
       End;
   
   DaftarPointer = ^PenunjukData;
   PenunjukData = Record
                   IsiData : Data;
                   next,prev : DaftarPointer;
                  End;

Var
   awal,akhir,element     : DaftarPointer;
   dt,st,hps : DaftarPointer;
   pil,pil2 : integer;
   ketemu : boolean;


{=====================================================}
Procedure sisip_depan;
{=====================================================}
var
Nama,Tanggal,Alamat:string;
Laundry,Harga:integer;
begin
   clrscr;
   new(dt);
   gotoxy(26,3);write('Sisip Depan');
   gotoxy(21,5);write('Nama Pelanggan   : ');readln(Nama);
   gotoxy(21,6);write('Alamat Pelanggan : ');readln(Alamat);
   gotoxy(21,7);write('Tanggal(HH/BB/TT): ');readln(Tanggal);
   gotoxy(21,8);write('Laundry (Kg)     : ');readln(Laundry);
   Harga:=Laundry*3000;
   gotoxy(21,9);write('Total            : Rp ',Harga);
      dt^.Isidata.Nama := Nama;
      dt^.Isidata.Alamat := Alamat;
      dt^.Isidata.Tanggal := Tanggal;
      dt^.Isidata.Laundry := Laundry;
      dt^.Isidata.Harga := Harga;
      if (awal=nil) then
      begin
         awal := nil;
         akhir := nil;
         dt^.next := nil;
         dt^.prev := nil;
         awal := dt;
         akhir := dt;
      end
      else
      begin
         dt^.prev := nil;
         dt^.next := awal;
         awal^.prev := dt;
         awal := dt;

      end;
   writeln;
   readln();
end;



{=====================================================}
procedure sisip_kanan;
{=====================================================}
var
   ds : string;
   Nama,Tanggal,Alamat:string;
   Laundry,Harga:integer;
begin
   if (awal = nil) then
   begin
   clrscr;
   writeln('Data Kosong');
   end
   else
   begin
      clrscr;
      gotoxy(20,3);write('Sisip Data Setelah Nama Pelanggan : ');readln(ds);
      st := awal;
      ketemu := false;
      while ((not ketemu) and (st <> nil)) do
         begin
            if (ds = st^.IsiData.Nama) then
            begin
               ketemu := true;
            end
            else
            begin
               st := st^.next;
            end;
         end;
     if (ketemu) then
     begin
        clrscr;
        gotoxy(26,3);write('Sisip Tengah');
        gotoxy(21,5);write('Nama Pelanggan   : ');readln(Nama);
        gotoxy(21,6);write('Alamat Pelanggan : ');readln(Alamat);
        gotoxy(21,7);write('Tanggal(HH/BB/TT): ');readln(Tanggal);
        gotoxy(21,8);write('Laundry (Kg)     : ');readln(Laundry);
        Harga:=Laundry*3000;
        gotoxy(21,9);write('Total            : Rp ',Harga);
        new(dt);
        dt^.Isidata.Nama := Nama;
        dt^.Isidata.Alamat := Alamat;
        dt^.Isidata.Tanggal := Tanggal;
        dt^.Isidata.Laundry := Laundry;
        dt^.Isidata.Harga := Harga;
        if (st = akhir) then
        begin
         dt^.next := nil;
         dt^.prev := akhir;
         akhir^.next := dt;
         akhir := dt;
      end
        else
        begin
           dt^.prev := st;
           dt^.next := st^.next;
           st^.next := dt^.next^.prev;
           st^.next := dt;
        end;
     end
     else
     begin
        write('Data Kosong...');
     end;
   end;
   readln;
end;

{=====================================================}
procedure sorting_asc (Awal, Akhir : DaftarPointer);
{=====================================================}
var
Min,I, J : DaftarPointer;
Temp  : integer;
begin
    I := Awal;
    While (I  <> Akhir)  do
        Min  := I;
        J  :=  I^.Next;
        While (J <> Nil) do
       If (J^.IsiData.Harga < Min^.Isidata.Harga)
	   Then
	   Min := J;
	   J := J^.Next;
        Temp  :=  I^.IsiData.Harga ;
        I^.IsiData.Harga  := Min^.IsiData.Harga ;
        Min^.IsiData.Harga  := Temp  ;
        I := I^.Next;
end;




{=====================================================}
procedure sisip_kiri;
{=====================================================}
var
   ds : string;
   Nama,Tanggal,Alamat:string;
   Laundry,Harga:integer;
begin
   if (awal = nil) then
   begin
   clrscr;
   writeln('Data Kosong');
   end
   else
   begin
      clrscr;
      gotoxy(20,3);write('Sisip Data Sebelum Nama Pelanggan : ');readln(ds);
      st := awal;
      ketemu := false;
      while ((not ketemu) and (st <> nil)) do
         begin
            if (ds = st^.IsiData.Nama) then
            begin
               ketemu := true;
            end
            else
            begin
               st := st^.next;
            end;
         end;
     if (ketemu) then
     begin
        clrscr;
        gotoxy(26,3);write('Sisip Tengah');
        gotoxy(21,5);write('Nama Pelanggan   : ');readln(Nama);
        gotoxy(21,6);write('Alamat Pelanggan : ');readln(Alamat);
        gotoxy(21,7);write('Tanggal(HH/BB/TT): ');readln(Tanggal);
        gotoxy(21,8);write('Laundry (Kg)     : ');readln(Laundry);
        Harga:=Laundry*3000;
        gotoxy(21,9);write('Total            : Rp ',Harga);
        new(dt);
        dt^.Isidata.Nama := Nama;
        dt^.Isidata.Alamat := Alamat;
        dt^.Isidata.Tanggal := Tanggal;
        dt^.Isidata.Laundry := Laundry;
        dt^.Isidata.Harga := Harga;
        {if (st = akhir) then
        begin
           dt^.prev := akhir;
           akhir^.next := dt;
           akhir := dt;
     end
        else}
        if (st = awal) then
        begin
        dt^.prev := nil;
         dt^.next := awal;
         awal^.prev := dt;
         awal := dt;
          end
          else
        begin
           dt^.next := st;
           dt^.prev := st^.prev;
           st^.prev^.next := dt;
           st^.prev := dt;
     end;
     end
     else
     begin
        write('Data Kosong...');
     end;
   end;
   readln;
end;


{=====================================================}
procedure sisip_belakang;
{=====================================================}
var
Nama,Tanggal,Alamat:string;
Laundry,Harga:integer;
begin
   clrscr;
   gotoxy(26,3);write('Sisip Belakang');
   gotoxy(21,5);write('Nama Pelanggan   : ');readln(Nama);
   gotoxy(21,6);write('Alamat Pelanggan : ');readln(Alamat);
   gotoxy(21,7);write('Tanggal(HH/BB/TT): ');readln(Tanggal);
   gotoxy(21,8);write('Laundry (Kg)     : ');readln(Laundry);
   Harga:=Laundry*3000;
   gotoxy(21,9);write('Total            : Rp ',Harga);
      new(dt);
      dt^.IsiData.Nama := Nama;
      dt^.IsiData.Alamat := Alamat;
      dt^.IsiData.Tanggal := Tanggal;
      dt^.IsiData.Laundry := Laundry;
      dt^.IsiData.Harga := Harga;
      dt^.next := nil;
      if (awal=nil) then
      begin
         awal := nil;
         akhir := nil;
         dt^.next := nil;
         dt^.prev := nil;
         awal := dt;
         akhir := dt;
      
      end
      else
      begin
         dt^.next := nil;
         dt^.prev := akhir;
         akhir^.next := dt;
         akhir := dt;
      end;
   writeln;
   readln();
end;

{=====================================================}
Procedure Menu;
{=====================================================}

Begin
      ClrScr;
      gotoxy(23,3);WriteLn ('------------------------');
      gotoxy(25,4);WriteLn ('Laundry Selalu Nyuci');
      gotoxy(23,5);WriteLn ('------------------------');
      gotoxy(27,6);WriteLn ('1. Tambah Data');
      gotoxy(27,7);WriteLn ('2. Sisip Data');
      gotoxy(27,8);WriteLn ('3. Tampil Data');
      gotoxy(27,9);WriteLn ('4. Hapus Data');
      gotoxy(27,10);WriteLn ('5. Pencarian Data');
      gotoxy(27,11);WriteLn ('0. Quit');
      gotoxy(23,12);WriteLn ('------------------------');
      gotoxy(25,13);Write ('Pilihan : '); ReadLn (pil);
End;

{====================================================}
procedure sisip_tengah;
{=====================================================}
var
pil1 : integer;
begin
   clrscr;
   gotoxy(25,3);write('Tambah Data Pelanggan');
   gotoxy(26,5);writeln('1. Sisip Kanan');
   gotoxy(26,6);writeln('2. Sisip Kiri');
   gotoxy(25,9);write('Pilihan : ');readln(pil2);
   if (pil2 = 1) then
   begin
   sisip_kanan;
   end
   else
   if ( pil = 2) then
   begin
   sisip_kiri;
   end;
   end;



{=====================================================}
procedure penyisipan;
{=====================================================}
var
pil1 : integer;
begin
     if (awal = nil)then
     begin
     clrscr;
     writeln('Data Kosong');
     readln;
     end
     else
     begin
   clrscr;
   gotoxy(25,3);write('Tambah Data Pelanggan');
   gotoxy(26,5);writeln('1. Sisip Depan');
   gotoxy(26,6);writeln('2. Sisip Tengah');
   gotoxy(26,7);writeln('3. Sisip Belakang');
   gotoxy(25,9);write('Pilihan : ');readln(pil1);
   if (pil1 = 1) then
   begin
      sisip_depan;
   end
   else if (pil1 = 2) then
   begin
      sisip_tengah;
   end
   else if (pil1 = 3) then
   begin
      sisip_belakang;
   end;
end;
end;
{=====================================================}
procedure lihat_data(awal : DaftarPointer);
{=====================================================}
var
    j    : integer;
    begin
    j:=6;
   clrscr;
      gotoxy(19,1);writeln('Daftar Pelanggan di Laundry Selalu Nyuci');
      gotoxy(1,3);write('|==|==============|================|=============|==========|==========|');
      gotoxy(1,4);write('|No|    Nama      |     Alamat     |   Tanggal   |  Laundry |  Total   |');
      gotoxy(1,5);write('|==|==============|================|=============|==========|==========|');
   new(dt);
   dt:=awal;
   if (dt = nil) then
   begin
      gotoxy(2,6);write('Data kosong...');
   end
   else
   while (dt <> nil) do
   begin
      gotoxy(1,j);writeln('| ',j-5);
      gotoxy(4,j);writeln('| ',dt^.IsiData.Nama);
      gotoxy(19,j);writeln('| ',dt^.IsiData.Alamat);
      gotoxy(36,j);writeln('| ',dt^.IsiData.Tanggal);
      gotoxy(50,j);writeln('| ',dt^.IsiData.Laundry,' Kg');
      gotoxy(61,j);writeln('| Rp ',dt^.IsiData.Harga);
      gotoxy(72,j);write('|');
      dt:=dt^.next;
      j:=j+1;
      gotoxy(1,j);write('|  |              |                |             |          |          |');
      gotoxy(1,j+1);write('|==|==============|================|=============|==========|==========|');
   end;
   readln;
end;

{=====================================================}
procedure hapus_depan(awal,akhir : DaftarPointer);
{=====================================================}
var
hps : DaftarPointer;
begin
   if (awal = nil) then
   begin
      gotoxy(25,11);write('Data Kosong...');
   end
   else if (awal = akhir) then
   begin
      awal := nil;
      akhir := nil;
      hps := awal;
      dispose(hps);
      write('Data Pertama Telah dihapus');
   end
   else
   begin
      hps := awal;

      end;
      dispose(hps);
      clrscr;
      gotoxy(25,11);write('Data Pertama Telah dihapus');
end;




{=====================================================}
procedure hapus_tengah;
{=====================================================}
var
   posisihapus,hd : string;
begin
   st := awal;
   if (awal = nil) then
   begin
      gotoxy(25,11);write('Data Kosong...');
   end
   else if (awal = akhir) then
   begin
      hd := awal^.IsiData.Nama;
      element := dt;
      awal := nil;
      akhir := nil;
      gotoxy(25,13);write('Data Dengan Nama Pelanggan ',hd,' Telah dihapus');
   end
   else
   begin
      gotoxy(25,11);write('Hapus Data Nama Pelanggan : ');readln(posisihapus);
      hps := awal;
      hd := awal^.IsiData.Nama;
      if (posisihapus = hd) then
      begin
         awal := awal^.next;
         dispose(hps);
         gotoxy(25,13);write('Data Dengan Nama Pelanggan ',posisihapus,' Telah dihapus');
      end
      else
      begin
      while (hps <> nil) do
         begin
            if (posisihapus = hps^.IsiData.Nama) then
            begin
               while (st^.next <> hps) do
               begin
                  st := st^.next
               end;
               st^.next := hps^.next;
               dispose(hps);
               gotoxy(25,13);write('Data Dengan Nama Pelanggan ',posisihapus,' Telah Dihapus');
            end
            else
            begin
               hps := hps^.next;
            end;
         end;
      end;
   end;
   readln;
end;


{=====================================================}
procedure hapus_belakang;
{=====================================================}
begin
   st := awal;
   hps := akhir;
   if (awal = nil) then
   begin
      gotoxy(25,11);write('Data Kosong...');
   end
   else if (awal = akhir) then
   begin
      awal := nil;
      akhir := nil;
      gotoxy(25,11);write('Data Terakhir Telah dihapus');
   end
   else
   begin
      akhir := hps^.prev;
      dispose(hps);
      akhir^.next := nil;
      gotoxy(25,11);write('Data Terakhir Telah dihapus');
   end;
   readln;
end;


{=====================================================}
procedure hapus_data;
{=====================================================}
begin
   clrscr;
   gotoxy(25,3);write('Hapus Data Pelanggan');
   gotoxy(25,5);write('1. Hapus Depan');
   gotoxy(25,6);write('2. Hapus Tengah');
   gotoxy(25,7);write('3. Hapus Belakang');
   gotoxy(25,9);write('Pilihan : ');readln(pil);
   if (pil = 1) then
   begin
      hapus_depan(awal,akhir);
      lihat_data(awal);
   end
   else if (pil = 2) then
   begin
      hapus_tengah;
      lihat_data(awal);
   end
   else if (pil = 3) then
   begin
      hapus_belakang;
      lihat_data(awal);
   end;
end;
{=====================================================}
Procedure pencarian(awal : DaftarPointer);
{=====================================================}
var
   ketemu : boolean;
   ds : string;
   dt : DaftarPointer;
   begin
   clrscr;
   new(dt);
   dt:=awal;
   if (dt = nil) then
   begin
      gotoxy(26,6);write('Data kosong...');
      readln;
   end
   else
   begin
      clrscr;
      gotoxy(20,3);write('Nama Pelanggan : ');readln(ds);
      st := awal;
      ketemu := false;
      while ((not ketemu) and (st <> nil)) do
         begin
            if (ds = st^.IsiData.Nama) then
            begin
               ketemu := true;
            end
            else
            begin
               st := st^.next;
            end;
         end;
     if (ketemu) then
     begin
        clrscr;
        writeln('Data yang di cari : ',ds);
        write('Nama               : ');writeln(st^.IsiData.Nama);
        write('Alamat             : ');writeln(st^.IsiData.Alamat);
        write('Tanggal            : ');writeln(st^.IsiData.Tanggal);
        write('Laundry            : ');writeln(st^.IsiData.Laundry,' Kg');
        write('Harga              : ');writeln('Rp ',st^.IsiData.Harga);
        readln;
   end
   else
     begin
        gotoxy(26,5);write('Data Tidak Ada...');
     readln;
     end;
end;
end;




begin
   repeat
   textbackground(255);
   textcolor(256);
   clrscr;
   Menu;
   if (pil = 1) then
   begin
      sisip_depan;
   end
   else
   if (pil = 2) then
   begin
      penyisipan;
   end
   else
   if (pil = 3) then
   begin
      lihat_data(awal);
   end
   else
   if (pil = 4) then
   begin
      hapus_data;
   end
   else
   if (pil = 5) then
   begin
      pencarian(awal);
   end

   until (pil = 0);

   awal:=nil;
   akhir:=nil;
   dispose(dt);
   clrscr;
   gotoxy(25,12);write('Semua data telah dihancurkan...');
   readkey;
end.
