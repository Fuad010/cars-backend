import { FC } from 'react';
import { Link } from 'react-router-dom';
import styles from './carCard.module.css'

const baseUrl = import.meta.env.VITE_API_BASE_URL_FOR_IMAGES;

interface CarCardProps{
    brandName: string
    name:string
    price:number
    mileage:number
    year:number
    engine:string
    image:string
}

export const CarCard: FC<CarCardProps> = ({
    brandName,
    name,
    price,
    mileage,
    year,
    engine,
    image,
}) => {
    
    return(
        <Link to={''} className={styles.card_container}>
            <div className={styles.title_container}>
                <img src={`${baseUrl}${image}`} alt="car" />
                <div className={styles.price_container}>
                    <div className={styles.price}>{`${price.toLocaleString("en-US")} $`}</div>
                </div>
            </div>
            <div className={styles.bottom}>
                <h1>{brandName} {name}</h1>
                <p>{year}, {engine}, {mileage} km</p>
            </div>
        </Link>
    )
}