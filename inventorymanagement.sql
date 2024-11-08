PGDMP      "            
    |            InventoryManagement    16.3    16.3 !               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    33317    InventoryManagement    DATABASE     �   CREATE DATABASE "InventoryManagement" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
 %   DROP DATABASE "InventoryManagement";
                postgres    false            �            1259    33319    admin    TABLE     �   CREATE TABLE public.admin (
    id_admin integer NOT NULL,
    email character varying(32) NOT NULL,
    password character varying(32) NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false            �            1259    33318    admin_id_admin_seq    SEQUENCE     �   CREATE SEQUENCE public.admin_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.admin_id_admin_seq;
       public          postgres    false    216            	           0    0    admin_id_admin_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.admin_id_admin_seq OWNED BY public.admin.id_admin;
          public          postgres    false    215            �            1259    33333    category    TABLE     u   CREATE TABLE public.category (
    id_category integer NOT NULL,
    nama_category character varying(32) NOT NULL
);
    DROP TABLE public.category;
       public         heap    postgres    false            �            1259    33332    category_id_category_seq    SEQUENCE     �   CREATE SEQUENCE public.category_id_category_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.category_id_category_seq;
       public          postgres    false    220            
           0    0    category_id_category_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.category_id_category_seq OWNED BY public.category.id_category;
          public          postgres    false    219            �            1259    33340 
   inventaris    TABLE     �   CREATE TABLE public.inventaris (
    id_inventaris integer NOT NULL,
    nama_inventaris character varying(32) NOT NULL,
    id_category integer NOT NULL,
    jumlah integer NOT NULL,
    harga integer NOT NULL
);
    DROP TABLE public.inventaris;
       public         heap    postgres    false            �            1259    33339    inventaris_id_inventaris_seq    SEQUENCE     �   CREATE SEQUENCE public.inventaris_id_inventaris_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.inventaris_id_inventaris_seq;
       public          postgres    false    222                       0    0    inventaris_id_inventaris_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.inventaris_id_inventaris_seq OWNED BY public.inventaris.id_inventaris;
          public          postgres    false    221            �            1259    33326    pengguna    TABLE     �   CREATE TABLE public.pengguna (
    id_pengguna integer NOT NULL,
    email character varying(32) NOT NULL,
    password character varying(32) NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    postgres    false            �            1259    33325    pengguna_id_pengguna_seq    SEQUENCE     �   CREATE SEQUENCE public.pengguna_id_pengguna_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.pengguna_id_pengguna_seq;
       public          postgres    false    218                       0    0    pengguna_id_pengguna_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.pengguna_id_pengguna_seq OWNED BY public.pengguna.id_pengguna;
          public          postgres    false    217            _           2604    33322    admin id_admin    DEFAULT     p   ALTER TABLE ONLY public.admin ALTER COLUMN id_admin SET DEFAULT nextval('public.admin_id_admin_seq'::regclass);
 =   ALTER TABLE public.admin ALTER COLUMN id_admin DROP DEFAULT;
       public          postgres    false    215    216    216            a           2604    33336    category id_category    DEFAULT     |   ALTER TABLE ONLY public.category ALTER COLUMN id_category SET DEFAULT nextval('public.category_id_category_seq'::regclass);
 C   ALTER TABLE public.category ALTER COLUMN id_category DROP DEFAULT;
       public          postgres    false    220    219    220            b           2604    33343    inventaris id_inventaris    DEFAULT     �   ALTER TABLE ONLY public.inventaris ALTER COLUMN id_inventaris SET DEFAULT nextval('public.inventaris_id_inventaris_seq'::regclass);
 G   ALTER TABLE public.inventaris ALTER COLUMN id_inventaris DROP DEFAULT;
       public          postgres    false    222    221    222            `           2604    33329    pengguna id_pengguna    DEFAULT     |   ALTER TABLE ONLY public.pengguna ALTER COLUMN id_pengguna SET DEFAULT nextval('public.pengguna_id_pengguna_seq'::regclass);
 C   ALTER TABLE public.pengguna ALTER COLUMN id_pengguna DROP DEFAULT;
       public          postgres    false    218    217    218            �          0    33319    admin 
   TABLE DATA           :   COPY public.admin (id_admin, email, password) FROM stdin;
    public          postgres    false    216   T$                  0    33333    category 
   TABLE DATA           >   COPY public.category (id_category, nama_category) FROM stdin;
    public          postgres    false    220   �$                 0    33340 
   inventaris 
   TABLE DATA           `   COPY public.inventaris (id_inventaris, nama_inventaris, id_category, jumlah, harga) FROM stdin;
    public          postgres    false    222   �$       �          0    33326    pengguna 
   TABLE DATA           @   COPY public.pengguna (id_pengguna, email, password) FROM stdin;
    public          postgres    false    218   W%                  0    0    admin_id_admin_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.admin_id_admin_seq', 1, true);
          public          postgres    false    215                       0    0    category_id_category_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.category_id_category_seq', 3, true);
          public          postgres    false    219                       0    0    inventaris_id_inventaris_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.inventaris_id_inventaris_seq', 5, true);
          public          postgres    false    221                       0    0    pengguna_id_pengguna_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.pengguna_id_pengguna_seq', 1, false);
          public          postgres    false    217            d           2606    33324    admin admin_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id_admin);
 :   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_pkey;
       public            postgres    false    216            h           2606    33338    category category_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (id_category);
 @   ALTER TABLE ONLY public.category DROP CONSTRAINT category_pkey;
       public            postgres    false    220            j           2606    33345    inventaris inventaris_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.inventaris
    ADD CONSTRAINT inventaris_pkey PRIMARY KEY (id_inventaris);
 D   ALTER TABLE ONLY public.inventaris DROP CONSTRAINT inventaris_pkey;
       public            postgres    false    222            f           2606    33331    pengguna pengguna_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id_pengguna);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public            postgres    false    218            k           2606    33346    inventaris id_category    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventaris
    ADD CONSTRAINT id_category FOREIGN KEY (id_category) REFERENCES public.category(id_category);
 @   ALTER TABLE ONLY public.inventaris DROP CONSTRAINT id_category;
       public          postgres    false    4712    220    222            �   *   x�3�LK,�*��N-J�sH�M���K�υ�s��qqq N�          A   x�3�H-JL�/I�S*�M�PI�KOO�2�t�I�.)�����2��N�M,R�M�K������  ��         h   x�%��@0E����_ ����]FK%B��{����$��m���(Y��� F��Y�ߐA�{<f�leu�*��cV����R�E��JYJ��P�5r�      �      x������ � �     