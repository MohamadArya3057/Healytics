PGDMP                      }         	   Healytics    17.4    17.4 Z    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    41320 	   Healytics    DATABASE     q   CREATE DATABASE "Healytics" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en-US';
    DROP DATABASE "Healytics";
                     postgres    false            �            1259    41322    alat    TABLE     �   CREATE TABLE public.alat (
    id_alat integer NOT NULL,
    nama_alat character varying(100) NOT NULL,
    stock integer NOT NULL,
    CONSTRAINT alat_stock_check CHECK ((stock >= 0))
);
    DROP TABLE public.alat;
       public         heap r       postgres    false            �            1259    41321    alat_id_alat_seq    SEQUENCE     �   CREATE SEQUENCE public.alat_id_alat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.alat_id_alat_seq;
       public               postgres    false    218            �           0    0    alat_id_alat_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.alat_id_alat_seq OWNED BY public.alat.id_alat;
          public               postgres    false    217            �            1259    41330    desa    TABLE     j   CREATE TABLE public.desa (
    id_desa integer NOT NULL,
    nama_desa character varying(100) NOT NULL
);
    DROP TABLE public.desa;
       public         heap r       postgres    false            �            1259    41329    desa_id_desa_seq    SEQUENCE     �   CREATE SEQUENCE public.desa_id_desa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.desa_id_desa_seq;
       public               postgres    false    220            �           0    0    desa_id_desa_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.desa_id_desa_seq OWNED BY public.desa.id_desa;
          public               postgres    false    219            �            1259    41390    detail_riwayat    TABLE     �   CREATE TABLE public.detail_riwayat (
    id_detail_riwayat integer NOT NULL,
    id_riwayat integer NOT NULL,
    id_obat integer NOT NULL,
    id_gejala integer NOT NULL
);
 "   DROP TABLE public.detail_riwayat;
       public         heap r       postgres    false            �            1259    41389 $   detail_riwayat_id_detail_riwayat_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_riwayat_id_detail_riwayat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ;   DROP SEQUENCE public.detail_riwayat_id_detail_riwayat_seq;
       public               postgres    false    232            �           0    0 $   detail_riwayat_id_detail_riwayat_seq    SEQUENCE OWNED BY     m   ALTER SEQUENCE public.detail_riwayat_id_detail_riwayat_seq OWNED BY public.detail_riwayat.id_detail_riwayat;
          public               postgres    false    231            �            1259    41420    detail_transaksi    TABLE       CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_transaksi integer NOT NULL,
    id_obat integer NOT NULL,
    jumlah integer NOT NULL,
    catatan text,
    CONSTRAINT detail_transaksi_jumlah_check CHECK ((jumlah > 0))
);
 $   DROP TABLE public.detail_transaksi;
       public         heap r       postgres    false            �            1259    41419 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transaksi_id_detail_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ?   DROP SEQUENCE public.detail_transaksi_id_detail_transaksi_seq;
       public               postgres    false    236            �           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE OWNED BY     u   ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNED BY public.detail_transaksi.id_detail_transaksi;
          public               postgres    false    235            �            1259    41364    gejala    TABLE     p   CREATE TABLE public.gejala (
    id_gejala integer NOT NULL,
    nama_gejala character varying(100) NOT NULL
);
    DROP TABLE public.gejala;
       public         heap r       postgres    false            �            1259    41363    gejala_id_gejala_seq    SEQUENCE     �   CREATE SEQUENCE public.gejala_id_gejala_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.gejala_id_gejala_seq;
       public               postgres    false    226            �           0    0    gejala_id_gejala_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.gejala_id_gejala_seq OWNED BY public.gejala.id_gejala;
          public               postgres    false    225            �            1259    41371    kategori_obat    TABLE     {   CREATE TABLE public.kategori_obat (
    id_kategori integer NOT NULL,
    nama_kategori character varying(100) NOT NULL
);
 !   DROP TABLE public.kategori_obat;
       public         heap r       postgres    false            �            1259    41370    kategori_obat_id_kategori_seq    SEQUENCE     �   CREATE SEQUENCE public.kategori_obat_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.kategori_obat_id_kategori_seq;
       public               postgres    false    228            �           0    0    kategori_obat_id_kategori_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.kategori_obat_id_kategori_seq OWNED BY public.kategori_obat.id_kategori;
          public               postgres    false    227            �            1259    41378    obat    TABLE     �   CREATE TABLE public.obat (
    id_obat integer NOT NULL,
    nama_obat character varying(100) NOT NULL,
    id_kategori integer NOT NULL,
    harga numeric(10,2),
    stock integer NOT NULL
);
    DROP TABLE public.obat;
       public         heap r       postgres    false            �            1259    41377    obat_id_obat_seq    SEQUENCE     �   CREATE SEQUENCE public.obat_id_obat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.obat_id_obat_seq;
       public               postgres    false    230            �           0    0    obat_id_obat_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.obat_id_obat_seq OWNED BY public.obat.id_obat;
          public               postgres    false    229            �            1259    41337    pasien    TABLE     �   CREATE TABLE public.pasien (
    no_register integer NOT NULL,
    nama_pasien character varying(100) NOT NULL,
    umur integer,
    id_desa integer NOT NULL,
    CONSTRAINT pasien_umur_check CHECK ((umur >= 0))
);
    DROP TABLE public.pasien;
       public         heap r       postgres    false            �            1259    41336    pasien_no_register_seq    SEQUENCE     �   CREATE SEQUENCE public.pasien_no_register_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.pasien_no_register_seq;
       public               postgres    false    222            �           0    0    pasien_no_register_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.pasien_no_register_seq OWNED BY public.pasien.no_register;
          public               postgres    false    221            �            1259    41350    riwayat_kunjungan    TABLE     �   CREATE TABLE public.riwayat_kunjungan (
    id_riwayat integer NOT NULL,
    tanggal date NOT NULL,
    no_register integer NOT NULL,
    catatan text
);
 %   DROP TABLE public.riwayat_kunjungan;
       public         heap r       postgres    false            �            1259    41349     riwayat_kunjungan_id_riwayat_seq    SEQUENCE     �   CREATE SEQUENCE public.riwayat_kunjungan_id_riwayat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.riwayat_kunjungan_id_riwayat_seq;
       public               postgres    false    224            �           0    0     riwayat_kunjungan_id_riwayat_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.riwayat_kunjungan_id_riwayat_seq OWNED BY public.riwayat_kunjungan.id_riwayat;
          public               postgres    false    223            �            1259    41412 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    id_transaksi integer NOT NULL,
    tanggal date NOT NULL,
    total numeric(12,2) NOT NULL,
    id_riwayat integer,
    CONSTRAINT transaksi_total_check CHECK ((total >= (0)::numeric))
);
    DROP TABLE public.transaksi;
       public         heap r       postgres    false            �            1259    41411    transaksi_id_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_id_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_id_transaksi_seq;
       public               postgres    false    234            �           0    0    transaksi_id_transaksi_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_id_transaksi_seq OWNED BY public.transaksi.id_transaksi;
          public               postgres    false    233            �           2604    41325    alat id_alat    DEFAULT     l   ALTER TABLE ONLY public.alat ALTER COLUMN id_alat SET DEFAULT nextval('public.alat_id_alat_seq'::regclass);
 ;   ALTER TABLE public.alat ALTER COLUMN id_alat DROP DEFAULT;
       public               postgres    false    218    217    218            �           2604    41333    desa id_desa    DEFAULT     l   ALTER TABLE ONLY public.desa ALTER COLUMN id_desa SET DEFAULT nextval('public.desa_id_desa_seq'::regclass);
 ;   ALTER TABLE public.desa ALTER COLUMN id_desa DROP DEFAULT;
       public               postgres    false    219    220    220            �           2604    41393     detail_riwayat id_detail_riwayat    DEFAULT     �   ALTER TABLE ONLY public.detail_riwayat ALTER COLUMN id_detail_riwayat SET DEFAULT nextval('public.detail_riwayat_id_detail_riwayat_seq'::regclass);
 O   ALTER TABLE public.detail_riwayat ALTER COLUMN id_detail_riwayat DROP DEFAULT;
       public               postgres    false    231    232    232            �           2604    41423 $   detail_transaksi id_detail_transaksi    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail_transaksi SET DEFAULT nextval('public.detail_transaksi_id_detail_transaksi_seq'::regclass);
 S   ALTER TABLE public.detail_transaksi ALTER COLUMN id_detail_transaksi DROP DEFAULT;
       public               postgres    false    236    235    236            �           2604    41367    gejala id_gejala    DEFAULT     t   ALTER TABLE ONLY public.gejala ALTER COLUMN id_gejala SET DEFAULT nextval('public.gejala_id_gejala_seq'::regclass);
 ?   ALTER TABLE public.gejala ALTER COLUMN id_gejala DROP DEFAULT;
       public               postgres    false    226    225    226            �           2604    41374    kategori_obat id_kategori    DEFAULT     �   ALTER TABLE ONLY public.kategori_obat ALTER COLUMN id_kategori SET DEFAULT nextval('public.kategori_obat_id_kategori_seq'::regclass);
 H   ALTER TABLE public.kategori_obat ALTER COLUMN id_kategori DROP DEFAULT;
       public               postgres    false    228    227    228            �           2604    41381    obat id_obat    DEFAULT     l   ALTER TABLE ONLY public.obat ALTER COLUMN id_obat SET DEFAULT nextval('public.obat_id_obat_seq'::regclass);
 ;   ALTER TABLE public.obat ALTER COLUMN id_obat DROP DEFAULT;
       public               postgres    false    230    229    230            �           2604    41340    pasien no_register    DEFAULT     x   ALTER TABLE ONLY public.pasien ALTER COLUMN no_register SET DEFAULT nextval('public.pasien_no_register_seq'::regclass);
 A   ALTER TABLE public.pasien ALTER COLUMN no_register DROP DEFAULT;
       public               postgres    false    222    221    222            �           2604    41353    riwayat_kunjungan id_riwayat    DEFAULT     �   ALTER TABLE ONLY public.riwayat_kunjungan ALTER COLUMN id_riwayat SET DEFAULT nextval('public.riwayat_kunjungan_id_riwayat_seq'::regclass);
 K   ALTER TABLE public.riwayat_kunjungan ALTER COLUMN id_riwayat DROP DEFAULT;
       public               postgres    false    224    223    224            �           2604    41415    transaksi id_transaksi    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN id_transaksi SET DEFAULT nextval('public.transaksi_id_transaksi_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN id_transaksi DROP DEFAULT;
       public               postgres    false    234    233    234            w          0    41322    alat 
   TABLE DATA           9   COPY public.alat (id_alat, nama_alat, stock) FROM stdin;
    public               postgres    false    218   �k       y          0    41330    desa 
   TABLE DATA           2   COPY public.desa (id_desa, nama_desa) FROM stdin;
    public               postgres    false    220   �k       �          0    41390    detail_riwayat 
   TABLE DATA           [   COPY public.detail_riwayat (id_detail_riwayat, id_riwayat, id_obat, id_gejala) FROM stdin;
    public               postgres    false    232   4l       �          0    41420    detail_transaksi 
   TABLE DATA           g   COPY public.detail_transaksi (id_detail_transaksi, id_transaksi, id_obat, jumlah, catatan) FROM stdin;
    public               postgres    false    236   �l                 0    41364    gejala 
   TABLE DATA           8   COPY public.gejala (id_gejala, nama_gejala) FROM stdin;
    public               postgres    false    226    m       �          0    41371    kategori_obat 
   TABLE DATA           C   COPY public.kategori_obat (id_kategori, nama_kategori) FROM stdin;
    public               postgres    false    228   6m       �          0    41378    obat 
   TABLE DATA           M   COPY public.obat (id_obat, nama_obat, id_kategori, harga, stock) FROM stdin;
    public               postgres    false    230   sm       {          0    41337    pasien 
   TABLE DATA           I   COPY public.pasien (no_register, nama_pasien, umur, id_desa) FROM stdin;
    public               postgres    false    222   �m       }          0    41350    riwayat_kunjungan 
   TABLE DATA           V   COPY public.riwayat_kunjungan (id_riwayat, tanggal, no_register, catatan) FROM stdin;
    public               postgres    false    224   in       �          0    41412 	   transaksi 
   TABLE DATA           M   COPY public.transaksi (id_transaksi, tanggal, total, id_riwayat) FROM stdin;
    public               postgres    false    234   to       �           0    0    alat_id_alat_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.alat_id_alat_seq', 7, true);
          public               postgres    false    217            �           0    0    desa_id_desa_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.desa_id_desa_seq', 3, true);
          public               postgres    false    219            �           0    0 $   detail_riwayat_id_detail_riwayat_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.detail_riwayat_id_detail_riwayat_seq', 29, true);
          public               postgres    false    231            �           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public.detail_transaksi_id_detail_transaksi_seq', 15, true);
          public               postgres    false    235            �           0    0    gejala_id_gejala_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.gejala_id_gejala_seq', 7, true);
          public               postgres    false    225            �           0    0    kategori_obat_id_kategori_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.kategori_obat_id_kategori_seq', 3, true);
          public               postgres    false    227            �           0    0    obat_id_obat_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.obat_id_obat_seq', 12, true);
          public               postgres    false    229            �           0    0    pasien_no_register_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.pasien_no_register_seq', 10, true);
          public               postgres    false    221            �           0    0     riwayat_kunjungan_id_riwayat_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.riwayat_kunjungan_id_riwayat_seq', 30, true);
          public               postgres    false    223            �           0    0    transaksi_id_transaksi_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transaksi_id_transaksi_seq', 16, true);
          public               postgres    false    233            �           2606    41328    alat alat_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.alat
    ADD CONSTRAINT alat_pkey PRIMARY KEY (id_alat);
 8   ALTER TABLE ONLY public.alat DROP CONSTRAINT alat_pkey;
       public                 postgres    false    218            �           2606    41335    desa desa_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.desa
    ADD CONSTRAINT desa_pkey PRIMARY KEY (id_desa);
 8   ALTER TABLE ONLY public.desa DROP CONSTRAINT desa_pkey;
       public                 postgres    false    220            �           2606    41395 "   detail_riwayat detail_riwayat_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.detail_riwayat
    ADD CONSTRAINT detail_riwayat_pkey PRIMARY KEY (id_detail_riwayat);
 L   ALTER TABLE ONLY public.detail_riwayat DROP CONSTRAINT detail_riwayat_pkey;
       public                 postgres    false    232            �           2606    41428 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public                 postgres    false    236            �           2606    41369    gejala gejala_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.gejala
    ADD CONSTRAINT gejala_pkey PRIMARY KEY (id_gejala);
 <   ALTER TABLE ONLY public.gejala DROP CONSTRAINT gejala_pkey;
       public                 postgres    false    226            �           2606    41376     kategori_obat kategori_obat_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.kategori_obat
    ADD CONSTRAINT kategori_obat_pkey PRIMARY KEY (id_kategori);
 J   ALTER TABLE ONLY public.kategori_obat DROP CONSTRAINT kategori_obat_pkey;
       public                 postgres    false    228            �           2606    41383    obat obat_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.obat
    ADD CONSTRAINT obat_pkey PRIMARY KEY (id_obat);
 8   ALTER TABLE ONLY public.obat DROP CONSTRAINT obat_pkey;
       public                 postgres    false    230            �           2606    41343    pasien pasien_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.pasien
    ADD CONSTRAINT pasien_pkey PRIMARY KEY (no_register);
 <   ALTER TABLE ONLY public.pasien DROP CONSTRAINT pasien_pkey;
       public                 postgres    false    222            �           2606    41357 (   riwayat_kunjungan riwayat_kunjungan_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public.riwayat_kunjungan
    ADD CONSTRAINT riwayat_kunjungan_pkey PRIMARY KEY (id_riwayat);
 R   ALTER TABLE ONLY public.riwayat_kunjungan DROP CONSTRAINT riwayat_kunjungan_pkey;
       public                 postgres    false    224            �           2606    41418    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public                 postgres    false    234            �           1259    41594    fki_detail_transaksi    INDEX     Y   CREATE INDEX fki_detail_transaksi ON public.detail_transaksi USING btree (id_transaksi);
 (   DROP INDEX public.fki_detail_transaksi;
       public                 postgres    false    236            �           1259    41582    fki_g    INDEX     E   CREATE INDEX fki_g ON public.detail_riwayat USING btree (id_gejala);
    DROP INDEX public.fki_g;
       public                 postgres    false    232            �           1259    41612    fki_kategori obat    INDEX     K   CREATE INDEX "fki_kategori obat" ON public.obat USING btree (id_kategori);
 '   DROP INDEX public."fki_kategori obat";
       public                 postgres    false    230            �           1259    41576    fki_o    INDEX     C   CREATE INDEX fki_o ON public.detail_riwayat USING btree (id_obat);
    DROP INDEX public.fki_o;
       public                 postgres    false    232            �           1259    41606    fki_riwayat pasien    INDEX     Y   CREATE INDEX "fki_riwayat pasien" ON public.riwayat_kunjungan USING btree (no_register);
 (   DROP INDEX public."fki_riwayat pasien";
       public                 postgres    false    224            �           1259    41588    fki_riwayat_transaksi    INDEX     Q   CREATE INDEX fki_riwayat_transaksi ON public.transaksi USING btree (id_riwayat);
 )   DROP INDEX public.fki_riwayat_transaksi;
       public                 postgres    false    234            �           1259    41600    fki_transaksi_obat    INDEX     R   CREATE INDEX fki_transaksi_obat ON public.detail_transaksi USING btree (id_obat);
 &   DROP INDEX public.fki_transaksi_obat;
       public                 postgres    false    236            �           2606    41566    detail_riwayat detail_riwayat    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_riwayat
    ADD CONSTRAINT detail_riwayat FOREIGN KEY (id_riwayat) REFERENCES public.riwayat_kunjungan(id_riwayat) ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY public.detail_riwayat DROP CONSTRAINT detail_riwayat;
       public               postgres    false    224    4809    232            �           2606    41589 !   detail_transaksi detail_transaksi    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi) ON UPDATE CASCADE ON DELETE CASCADE;
 K   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi;
       public               postgres    false    4823    234    236            �           2606    41344    pasien fk_pasien_desa    FK CONSTRAINT     x   ALTER TABLE ONLY public.pasien
    ADD CONSTRAINT fk_pasien_desa FOREIGN KEY (id_desa) REFERENCES public.desa(id_desa);
 ?   ALTER TABLE ONLY public.pasien DROP CONSTRAINT fk_pasien_desa;
       public               postgres    false    220    4804    222            �           2606    41607    obat kategori obat    FK CONSTRAINT     �   ALTER TABLE ONLY public.obat
    ADD CONSTRAINT "kategori obat" FOREIGN KEY (id_kategori) REFERENCES public.kategori_obat(id_kategori) ON UPDATE CASCADE ON DELETE CASCADE;
 >   ALTER TABLE ONLY public.obat DROP CONSTRAINT "kategori obat";
       public               postgres    false    230    4813    228            �           2606    41601     riwayat_kunjungan riwayat pasien    FK CONSTRAINT     �   ALTER TABLE ONLY public.riwayat_kunjungan
    ADD CONSTRAINT "riwayat pasien" FOREIGN KEY (no_register) REFERENCES public.pasien(no_register) ON UPDATE CASCADE ON DELETE CASCADE;
 L   ALTER TABLE ONLY public.riwayat_kunjungan DROP CONSTRAINT "riwayat pasien";
       public               postgres    false    224    222    4806            �           2606    41577    detail_riwayat riwayat_gejala    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_riwayat
    ADD CONSTRAINT riwayat_gejala FOREIGN KEY (id_gejala) REFERENCES public.gejala(id_gejala) ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY public.detail_riwayat DROP CONSTRAINT riwayat_gejala;
       public               postgres    false    232    226    4811            �           2606    41571    detail_riwayat riwayat_obat    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_riwayat
    ADD CONSTRAINT riwayat_obat FOREIGN KEY (id_obat) REFERENCES public.obat(id_obat) ON UPDATE CASCADE ON DELETE CASCADE;
 E   ALTER TABLE ONLY public.detail_riwayat DROP CONSTRAINT riwayat_obat;
       public               postgres    false    230    4816    232            �           2606    41583    transaksi riwayat_transaksi    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT riwayat_transaksi FOREIGN KEY (id_riwayat) REFERENCES public.riwayat_kunjungan(id_riwayat) ON UPDATE CASCADE ON DELETE CASCADE;
 E   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT riwayat_transaksi;
       public               postgres    false    4809    234    224            �           2606    41595    detail_transaksi transaksi_obat    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT transaksi_obat FOREIGN KEY (id_obat) REFERENCES public.obat(id_obat) ON UPDATE CASCADE ON DELETE CASCADE;
 I   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT transaksi_obat;
       public               postgres    false    4816    236    230            w   =   x�3�I�+��M-I-�44�2�r��|���̒�NCS.c���Ԓ����7F��� >��      y   8   x�3��I,J�KO�SpJL)�K�2�tJ��ps$���&��*�d�q��qqq ~��      �   L   x�-���@�I1��;����0�`��Dbx'��2Ԁʙ�ei��_��4��HD9w-�7X���9���¡�      �   `   x�3�4�4bϤ҂����<#��t.#��1��V��禖d�d$�)�$&外pe�0Ə���1��24�44�2����q��qqq ��          &   x�3�(-��K�2�tI�M��2�tJ,)������ ���      �   -   x�3�t�+�,�,J-���2�s�S��lc�LIiqfW� 4�B      �   b   x�-�1
�0���a�nb�V��� 6�D,Ԅ��+�zxc1.w�q,f6��H0i�5=���qBCxJ�g({�i��ʖ�����O�O�!�1��      {   t   x�%��
�0F��>E�@�c���vR\>��;4����F��9p��s3jV�8�X���Q�#3!Xx	X�M͕��\-�Dܙ[��u��a�<b���YL�M33��?:y�D�˪r      }   �   x�}��n� �3</�����u{��^f�d� 1"��11|�Փ�����DtB]:}�8����4B`s�6��_�� RQ�$��aM������,�'��ce5n�F�����l��\
�i[Ϝ��-U;菀ށ<׶���V_�?0d�;3�G^"�KgW&�������E�v��Kh\�7;n�����ĩS�0}�tݔ>vU��3W%�N����6��gk�O������L8d�De���h<LP��������      �   K   x�U���0����Dw6���:�A8�Gڕ9=G�LI��6xA�oib���:^�ʒk������ ��      