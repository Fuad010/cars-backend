import { Link } from 'react-router-dom';
import styles from './carCard.module.css'
import lambo from 'shared/assets/images/lambo.jpg'

export const CarCard = () => {
    const number = 1200000;
    return(
        <Link to={''} className={styles.card_container}>
            <div className={styles.title_container}>
                <img src={lambo} alt="car" />
                <div className={styles.price_container}>
                    <div className={styles.price}>{`${number.toLocaleString("en-US")} $`}</div>
                </div>
            </div>
            <div className={styles.bottom}>
                <h1>FORD Mustang</h1>
                <p>2023, 3.4L, 0 km</p>
            </div>
        </Link>
    )
}