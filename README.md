# TP1 - Unity

Projet réalisé dans le cadre du TP1 Unity.  
L’objectif principal est d’explorer les mécaniques de tir, collisions, score, physique et contrôle FPS.
<img width="1301" height="828" alt="image" src="https://github.com/user-attachments/assets/31989db9-b200-4b26-93d5-b482d091b29e" />


**Capture : Aperçu global du projet (vue d’ensemble) **  
<img width="1741" height="1008" alt="image" src="https://github.com/user-attachments/assets/34e8a6a0-16e2-432a-87ef-108abf4f320d" />

---

#  Fonctionnalités (avec captures)

##  1. Tir de projectiles (clic souris)
En cliquant avec le bouton gauche de la souris, l’utilisateur tire une balle.  
La balle apparaît juste devant la caméra (vue FPS) et part tout droit dans la direction où le joueur regarde.  
Cela donne un comportement simple et naturel de “viser puis tirer” en première personne.



**Capture : tir du projectile **  
<img width="1919" height="1062" alt="image" src="https://github.com/user-attachments/assets/5d17ef3d-2e6c-4cce-95f2-9c7ba6b5ea65" />


---

##  2. Collision avec la voiture rouge
La voiture a été définie comme un objet solide (non traversable).  
Les projectiles entrent en collision avec son collider et ne peuvent donc pas passer à travers.


**Capture : collision avec la voiture **  
<img width="1913" height="1060" alt="image" src="https://github.com/user-attachments/assets/cd5d6330-bb0c-434a-bb90-364d8874404f" />


---

##  3. Destruction des cubes + Score
Lorsqu’un projectile touche un cube :
- le cube est détruit,
- le score augmente,
- l’UI est mise à jour.

**Capture : score mis à jour après destruction**  
<img width="316" height="125" alt="image" src="https://github.com/user-attachments/assets/3c6f83ec-22d7-4975-8d49-609ca96d0aa7" />
<img width="327" height="114" alt="image" src="https://github.com/user-attachments/assets/de61809b-0e0f-4d40-b4f1-e20b4592b1f4" />



---

##  4. Gravité des cubes
Les cubes tombent au début de la partie grâce au Rigidbody.

**Captures : chutes des cubes**  
État initial

<img width="794" height="546" alt="image" src="https://github.com/user-attachments/assets/18f93dfc-e50b-44a2-a053-ece4e0c09e9c" />

En jeu, les cubes commencent à tomber

<img width="800" height="483" alt="image" src="https://github.com/user-attachments/assets/28a7320c-5d2c-4d9c-bebb-4818d8adf1f9" />


---

##  5. Rotation (touche R)
En appuyant sur R, le joueur déclenche la rotation des cubes (activation/désactivation).

**Capture : rotation des cubes**  
<img width="778" height="534" alt="image" src="https://github.com/user-attachments/assets/9a95f9f7-0356-4e45-8f08-ddc45fc94eec" />


---

##  6. Déplacement FPS
- WASD / ZQSD : déplacement
- Souris : orientation de la caméra
Le joueur peut viser sous différents angles.

**Captures : vue FPS & changement d’angle**  
<img width="1905" height="1051" alt="image" src="https://github.com/user-attachments/assets/9b397371-39ea-49a4-9b62-61c6d7113db3" />

<img width="1912" height="1052" alt="image" src="https://github.com/user-attachments/assets/259504ac-996a-468c-b05f-6a3b90ced6da" />



---

#  Parcours complet du joueur (flow du gameplay)

Voici le déroulement typique lorsque le joueur lance la scène :

### ▶️ Étape 1 — Le joueur apparaît en vue FPS
<img width="1908" height="997" alt="image" src="https://github.com/user-attachments/assets/269dfabc-63bd-4824-baa1-342c815f3252" />

---

### ▶️ Étape 2 — Les cubes tombent naturellement
- La physique se met en place.
- Le joueur observe la scène.

<img width="1858" height="952" alt="image" src="https://github.com/user-attachments/assets/a25b71e2-007f-4eb5-8f3a-54ae47652bef" />


---

### ▶️ Étape 3 — Le joueur tire (clic)
- Le projectile part en ligne droite.

<img width="1876" height="931" alt="image" src="https://github.com/user-attachments/assets/1963fcf1-2fea-4089-bdf1-8e9405c3bc63" />


---

### ▶️ Étape 4 — Le cube est touché → destruction + score + physique
- Le cube disparaît  
- Le score augmente  
- Les autres cubes réagissent physiquement

<img width="1860" height="963" alt="image" src="https://github.com/user-attachments/assets/d563ce9d-71fa-4f53-80ae-4fbf0c0b41cc" />


---

#  Télécharger l’exécutable

 Télécharger le build :  
**(https://github.com/yami-59/TP1/releases/tag/v1.0)**

---

#  Code source

👉 https://github.com/USERNAME/TP1

---

#  Résumer TP1

Merci beaucoup pour votre cours et votre correction 🙏  
Ce TP m’a permis de comprendre :
- les collisions
- la physique des rigidbodies
- le tir de projectiles
- la gestion du score
- le contrôle FPS
- l’organisation d’une scène Unity
