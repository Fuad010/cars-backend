import { FC } from 'react'
import styles from './carDescription.module.css'

interface CarDescriptionProps{
    readonly description:string
    readonly descAnswer:string
}

export const CarDescription: FC<CarDescriptionProps> = ({description, descAnswer}) => {
    return( 
        <div className={styles.content}>
             <p>{description}</p>
             <h5>{descAnswer}</h5>
        </div>
    )
}